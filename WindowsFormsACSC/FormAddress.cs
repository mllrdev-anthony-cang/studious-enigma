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
    public partial class FormAddress : Form
    {
        public FormAddress(Customer customer)
        {
            InitializeComponent();

            this.Text = $"{customer.FullName} Address List";
            SelectedCustomerId = customer.Id;
            ClearAll();
        }

        public int SelectedCustomerId { get; private set; }
        public int SelectedId { get; private set; }

        private void _fillListView(Address filter)
        {
            listViewAddress.Clear();
            // Set the view to show details.
            listViewAddress.View = View.Details;
            // Select the item and subitems when selection is made.
            listViewAddress.FullRowSelect = true;
            // Display grid lines.
            listViewAddress.GridLines = true;
            // Sort the items in the list in ascending order.
            listViewAddress.Sorting = SortOrder.Ascending;

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listViewAddress.Columns.Add("Id", 0, HorizontalAlignment.Center);
            listViewAddress.Columns.Add("House, Building, Street", 200, HorizontalAlignment.Center);
            listViewAddress.Columns.Add("Province", 120, HorizontalAlignment.Center);
            listViewAddress.Columns.Add("City \\ Municipality", 120, HorizontalAlignment.Center);
            listViewAddress.Columns.Add("Barangay", 120, HorizontalAlignment.Center);

            AddressRepository db = new AddressRepository();
            var addressList = new List<ListViewItem>();
            var addresses = db.GetBy(filter);

            foreach (var address in addresses)
            {
                ListViewItem item = new ListViewItem(address.Id.ToString());
                item.SubItems.Add(address.HouseBuildingStreet);
                item.SubItems.Add(address.Province);
                item.SubItems.Add(address.CityMunicipality);
                item.SubItems.Add(address.Barangay);                

                addressList.Add(item);
            }
            listViewAddress.Items.AddRange(addressList.ToArray());
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
                        
        }

        private void listViewAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedrow = listViewAddress.SelectedItems;

            var address = new Address();

            if (selectedrow.Count > 0)
            {
                address.Id = Convert.ToInt32(selectedrow[0].SubItems[0].Text);
                address.HouseBuildingStreet = selectedrow[0].SubItems[1].Text;
                address.Province = selectedrow[0].SubItems[2].Text;
                address.CityMunicipality = selectedrow[0].SubItems[3].Text;
                address.Barangay = selectedrow[0].SubItems[4].Text;
            }

            SelectedId = address.Id;
            textBoxHouse.Text = address.HouseBuildingStreet;
            textBoxProvince.Text = address.Province;
            textBoxCity.Text = address.CityMunicipality;
            textBoxBarangay.Text = address.Barangay;

            buttonAdd.Enabled = false;
            buttonSearch.Enabled = false;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
        }

        private void _fillListViewBySearchItem()
        {
            var address = new Address
            {
                HouseBuildingStreet = textBoxHouse.Text.Trim(),
                Province = textBoxProvince.Text.Trim(),
                CityMunicipality = textBoxCity.Text.Trim(),
                Barangay = textBoxBarangay.Text.Trim(),
                CustomerId = SelectedCustomerId
            };
            _fillListView(address);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _fillListViewBySearchItem();
        }

        private void ClearAll()
        {
            buttonAdd.Enabled = true;
            buttonSearch.Enabled = true;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;

            textBoxHouse.Text = string.Empty;
            textBoxProvince.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxBarangay.Text = string.Empty;

            var address = new Address { CustomerId = SelectedCustomerId };
            _fillListView(address);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var address = new Address
            {
                HouseBuildingStreet = textBoxHouse.Text.Trim(),
                Province = textBoxProvince.Text.Trim(),
                CityMunicipality = textBoxCity.Text.Trim(),
                Barangay = textBoxBarangay.Text.Trim(),
                CustomerId = SelectedCustomerId
            };
            var db = new AddressRepository();
            var dbResponse = db.Save(address);

            if (dbResponse == true)
            {
                MessageBox.Show("Address added.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Address detail is incomplete, please check.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var address = new Address
            {
                Id = SelectedId,
                HouseBuildingStreet = textBoxHouse.Text.Trim(),
                Province = textBoxProvince.Text.Trim(),
                CityMunicipality = textBoxCity.Text.Trim(),
                Barangay = textBoxBarangay.Text.Trim(),
                CustomerId = SelectedCustomerId
            };
            var db = new AddressRepository();
            var dbResponse = db.Save(address);

            if (dbResponse == true)
            {
                MessageBox.Show("Address updated.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Customer detail is incomplete, please check.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove?", "Message Box", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.No) return;

            var address = new Address
            {
                Id = SelectedId
            };
            var db = new AddressRepository();
            var dbResponse = db.Remove(address);

            if (dbResponse == true)
            {
                MessageBox.Show("Address removed.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
        }
    }
}
