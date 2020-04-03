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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();

            ClearAll();
        }

        public int SelectedId { get; private set; }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            
        }

        private void _fillListView(Customer filter)
        {
            listViewCustomer.Clear();
            // Set the view to show details.
            listViewCustomer.View = View.Details;
            // Select the item and subitems when selection is made.
            listViewCustomer.FullRowSelect = true;
            // Display grid lines.
            listViewCustomer.GridLines = true;
            // Sort the items in the list in ascending order.
            listViewCustomer.Sorting = SortOrder.Ascending;

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listViewCustomer.Columns.Add("Id", 0, HorizontalAlignment.Center);
            listViewCustomer.Columns.Add("First Name", 150, HorizontalAlignment.Center);
            listViewCustomer.Columns.Add("Last Name", 150, HorizontalAlignment.Center);
            listViewCustomer.Columns.Add("Phone Number", 120, HorizontalAlignment.Center);

            CustomerRepository db = new CustomerRepository();
            var customerList = new List<ListViewItem>();
            var customers = db.GetBy(filter);            

            foreach (var customer in customers)
            {
                ListViewItem item = new ListViewItem(customer.Id.ToString());
                item.SubItems.Add(customer.FirstName);
                item.SubItems.Add(customer.LastName);
                item.SubItems.Add(customer.PhoneNumber);

                customerList.Add(item);
            }
            listViewCustomer.Items.AddRange(customerList.ToArray());
        }

        private void listViewCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedrow = listViewCustomer.SelectedItems;

            var customer = new Customer();

            if(selectedrow.Count>0)
            {
                customer.Id = Convert.ToInt32(selectedrow[0].SubItems[0].Text);
                customer.FirstName = selectedrow[0].SubItems[1].Text;
                customer.LastName = selectedrow[0].SubItems[2].Text;
                customer.PhoneNumber = selectedrow[0].SubItems[3].Text;
            }

            SelectedId = customer.Id;
            textBoxFirstName.Text = customer.FirstName;
            textBoxLastName.Text = customer.LastName;
            textBoxPhoneNumber.Text = customer.PhoneNumber;

            buttonAdd.Enabled = false;
            buttonSearch.Enabled = false;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonAddress.Enabled = true;
        }

        private void textBoxFirstName_MouseUp(object sender, MouseEventArgs e)
        {           

        }

        private void _fillListViewBySearchItem()
        {
            var customer = new Customer
            {
                FirstName = textBoxFirstName.Text.Trim(),
                LastName = textBoxLastName.Text.Trim(),
                PhoneNumber = textBoxPhoneNumber.Text.Trim()
            };
            _fillListView(customer);
        }

        private void buttonSearch_MouseClick(object sender, MouseEventArgs e)
        {
            _fillListViewBySearchItem();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            buttonAdd.Enabled = true;
            buttonSearch.Enabled = true;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonAddress.Enabled = false;

            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxPhoneNumber.Text = string.Empty;

            _fillListView(new Customer());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = textBoxFirstName.Text.Trim(),
                LastName = textBoxLastName.Text.Trim(),
                PhoneNumber = textBoxPhoneNumber.Text.Trim()
            };
            var db = new CustomerRepository();
            var dbResponse = db.Save(customer);

            if(dbResponse == true)
            {
                MessageBox.Show("Customer added.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Customer detail is incomplete, please check.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Id = SelectedId,
                FirstName = textBoxFirstName.Text.Trim(),
                LastName = textBoxLastName.Text.Trim(),
                PhoneNumber = textBoxPhoneNumber.Text.Trim()
            };
            var db = new CustomerRepository();
            var dbResponse = db.Save(customer);

            if (dbResponse == true)
            {
                MessageBox.Show("Customer updated.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Customer detail is incomplete, please check.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Message Box", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.No) return;

            var customer = new Customer
            {
                Id = SelectedId
            };
            var db = new CustomerRepository();
            var dbResponse = db.Remove(customer);

            if (dbResponse == true)
            {
                MessageBox.Show("Customer removed.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddress_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Id = SelectedId,
                FirstName = textBoxFirstName.Text.Trim(),
                LastName = textBoxLastName.Text.Trim(),
                PhoneNumber = textBoxPhoneNumber.Text.Trim()
            };
            var newForm = new FormAddress(customer);
            
            newForm.ShowDialog();
        }
    }
}
