using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACSC.BL;

namespace WindowsFormsACSC
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            _clearAll();
        }

        public int SelectedId { get; private set; }
        private decimal _currentPrice;
        private decimal _maxPrice;
        private decimal _minPrice;

        private void _fillListView(Product filter)
        {
            listViewProduct.Clear();
            // Set the view to show details.
            listViewProduct.View = View.Details;
            // Select the item and subitems when selection is made.
            listViewProduct.FullRowSelect = true;
            // Display grid lines.
            listViewProduct.GridLines = true;
            // Sort the items in the list in ascending order.
            listViewProduct.Sorting = SortOrder.Ascending;

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listViewProduct.Columns.Add("Id", 0, HorizontalAlignment.Center);
            listViewProduct.Columns.Add("Name", 150, HorizontalAlignment.Center);
            listViewProduct.Columns.Add("Description", 150, HorizontalAlignment.Center);
            listViewProduct.Columns.Add("Current Price", 120, HorizontalAlignment.Center);

            ProductRepository db = new ProductRepository();
            var productList = new List<ListViewItem>();
            var products = db.GetBy(filter);

            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Description);
                item.SubItems.Add(product.CurrentPrice.ToString());

                productList.Add(item);
            }
            listViewProduct.Items.AddRange(productList.ToArray());
        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedrow = listViewProduct.SelectedItems;

            var product = new Product();

            if (selectedrow.Count > 0)
            {
                product.Id = Convert.ToInt32(selectedrow[0].SubItems[0].Text);
                product.Name = selectedrow[0].SubItems[1].Text;
                product.Description = selectedrow[0].SubItems[2].Text;
                product.CurrentPrice = Convert.ToDecimal(selectedrow[0].SubItems[3].Text);
            }

            SelectedId = product.Id;
            textBoxName.Text = product.Name;
            textBoxDescription.Text = product.Description;
            textBoxCurrentPrice.Text = product.CurrentPrice.ToString();

            buttonAdd.Enabled = false;
            buttonSearch.Enabled = false;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = textBoxName.Text.Trim(),
                Description = textBoxDescription.Text.Trim(),
                MaxPrice = decimal.TryParse(textBoxMaxPrice.Text.Trim(), out _maxPrice) ? _maxPrice : _maxPrice,
                MinPrice = decimal.TryParse(textBoxMinPrice.Text.Trim(), out _minPrice) ? _minPrice : _minPrice
            };
            _fillListView(product);
        }

        private void _clearAll()
        {
            buttonAdd.Enabled = true;
            buttonSearch.Enabled = true;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;

            textBoxName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            textBoxCurrentPrice.Text = string.Empty;
            textBoxMinPrice.Text = string.Empty;
            textBoxMaxPrice.Text = string.Empty;

            _fillListView(new Product());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _clearAll();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = textBoxName.Text.Trim(),
                Description = textBoxDescription.Text.Trim(),
                CurrentPrice = decimal.TryParse(textBoxCurrentPrice.Text.Trim(), out _currentPrice) ? _currentPrice : _currentPrice
            };
            var db = new ProductRepository();
            var dbResponse = db.Save(product);

            if (dbResponse == true)
            {
                MessageBox.Show("Product added.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _clearAll();
            }
            else
            {
                MessageBox.Show("Product detail is incomplete, please check.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Id = SelectedId,
                Name = textBoxName.Text.Trim(),
                Description = textBoxDescription.Text.Trim(),
                CurrentPrice = Convert.ToDecimal(textBoxCurrentPrice.Text.Trim())
            };
            var db = new ProductRepository();
            var dbResponse = db.Save(product);

            if (dbResponse == true)
            {
                MessageBox.Show("Product updated.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _clearAll();
            }
            else
            {
                MessageBox.Show("Product detail is incomplete, please check.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Message Box", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.No) return;

            var product = new Product
            {
                Id = SelectedId
            };
            var db = new ProductRepository();
            var dbResponse = db.Remove(product);

            if (dbResponse == true)
            {
                MessageBox.Show("Product removed.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _clearAll();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxMinPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
