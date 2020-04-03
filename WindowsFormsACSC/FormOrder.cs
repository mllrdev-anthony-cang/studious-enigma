﻿using System;
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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();

            _productClearAll();
            _orderItemClearAll();
            _initializeListViewOrderItem();
            _customerClearAll();
            _addressClearAll();
        }

        private List<OrderItem> _selectedProducts = new List<OrderItem>();
        private Product _selectedProduct = new Product();
        private Product _selectedOrderItem = new Product();
        private Customer _selectedCustomer = new Customer();
        private Address _selectedAddress = new Address();
        private decimal _selectedOrderItemQuantity;
        private decimal _productMaxPrice;
        private decimal _productMinPrice;
        private decimal _productQuantity;
        private decimal _totalAmount;

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var orderitem = new OrderItem
            {
                OrderId = 1,
                ProductId = _selectedProduct.Id,
                Quantity = decimal.TryParse(textBoxProductQuantity.Text.Trim(), out _productQuantity) ? _productQuantity : _productQuantity,
                PurchasePrice = _selectedProduct.CurrentPrice
            };

            if (orderitem.Validate == false)
            {
                MessageBox.Show("Please enter a valid quantity.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxProductQuantity.Focus();
                return;
            }

            _selectedProducts.Add(orderitem);

            var orderitemlist = new List<ListViewItem>();

            ListViewItem item = new ListViewItem(_selectedProduct.Id.ToString());
            item.SubItems.Add(_selectedProduct.Name);
            item.SubItems.Add(_selectedProduct.Description);
            item.SubItems.Add(orderitem.PurchasePrice.ToString());
            item.SubItems.Add(Math.Round(Convert.ToDouble(orderitem.Quantity), 0).ToString());

            item.Name = _selectedProduct.Id.ToString();

            if (listViewOrderItem.Items.ContainsKey(_selectedProduct.Id.ToString()))
            {
                var orderitemsrows = listViewOrderItem.Items;
                
                for(var i=0; i< orderitemsrows.Count; i++)
                {
                    if (string.Equals(_selectedProduct.Id.ToString(), orderitemsrows[i].SubItems[0].Text))
                    {
                        var rowquantity = Math.Round(Convert.ToDouble(orderitem.Quantity), 0) + Math.Round(Convert.ToDouble(orderitemsrows[i].SubItems[4].Text), 0);
                        orderitemsrows[i].SubItems[4].Text = rowquantity.ToString();
                        break;
                    }
                }
            }
            else
            {
                orderitemlist.Add(item);
                listViewOrderItem.Items.AddRange(orderitemlist.ToArray());
            }
        }
        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedrow = listViewProduct.SelectedItems;
            
            if (selectedrow.Count > 0)
            {
                _selectedProduct.Id = Convert.ToInt32(selectedrow[0].SubItems[0].Text);
                _selectedProduct.Name = selectedrow[0].SubItems[1].Text;
                _selectedProduct.Description = selectedrow[0].SubItems[2].Text;
                _selectedProduct.CurrentPrice = Convert.ToDecimal(selectedrow[0].SubItems[3].Text);
            }

            textBoxProductName.Text = _selectedProduct.Name;
            textBoxProductDescription.Text = _selectedProduct.Description;
            textBoxProductCurrentPrice.Text = _selectedProduct.CurrentPrice.ToString();

            buttonProductAdd.Enabled = true;
            buttonProductSearch.Enabled = false;
            buttonAddressClear.Enabled = true;
        }

        private void buttonProductSearch_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = textBoxProductName.Text.Trim(),
                Description = textBoxProductDescription.Text.Trim(),
                MaxPrice = decimal.TryParse(textBoxProductMaxPrice.Text.Trim(), out _productMaxPrice) ? _productMaxPrice : _productMaxPrice,
                MinPrice = decimal.TryParse(textBoxProductMinPrice.Text.Trim(), out _productMinPrice) ? _productMinPrice : _productMinPrice
            };
            _fillListView(product);
        }
        private void _productClearAll()
        {
            buttonProductAdd.Enabled = false;
            buttonProductSearch.Enabled = true;

            textBoxProductName.Text = string.Empty;
            textBoxProductDescription.Text = string.Empty;
            textBoxProductCurrentPrice.Text = string.Empty;
            textBoxProductMinPrice.Text = string.Empty;
            textBoxProductMaxPrice.Text = string.Empty;

            _fillListView(new Product());
        }

        private void _orderItemClearAll()
        { 
            buttonOrderItemUpdate.Enabled = false;
            buttonOrderItemRemove.Enabled = false;

            textBoxOrderItemDescription.Text = string.Empty;
            textBoxOrderItemName.Text = string.Empty;
            textBoxOrderItemPurchasePrice.Text = string.Empty;
            textBoxOrderItemQuantity.Text = string.Empty;
        }

        private void _initializeListViewOrderItem()
        {
            listViewOrderItem.Clear();
            // Set the view to show details.
            listViewOrderItem.View = View.Details;
            // Select the item and subitems when selection is made.
            listViewOrderItem.FullRowSelect = true;
            // Display grid lines.
            listViewOrderItem.GridLines = true;
            // Sort the items in the list in ascending order.
            listViewOrderItem.Sorting = SortOrder.Ascending;

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listViewOrderItem.Columns.Add("Id", 0, HorizontalAlignment.Center);
            listViewOrderItem.Columns.Add("Name", 150, HorizontalAlignment.Center);
            listViewOrderItem.Columns.Add("Description", 150, HorizontalAlignment.Center);
            listViewOrderItem.Columns.Add("Purchase Price", 120, HorizontalAlignment.Center);
            listViewOrderItem.Columns.Add("Quantity", 120, HorizontalAlignment.Center);
        }

        private void buttonProductClear_Click(object sender, EventArgs e)
        {
            _productClearAll();
        }

        private void buttonProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonProductNext_Click(object sender, EventArgs e)
        {
            if(_selectedProducts.Count() > 0)
            {
                tabControlOrder.SelectedTab = tabPageOrderItems;
            }            
        }

        private void listViewOrderItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var selectedrow = listViewOrderItem.SelectedItems;

            if (selectedrow.Count > 0)
            {
                _selectedOrderItem.Id = Convert.ToInt32(selectedrow[0].SubItems[0].Text);
                _selectedOrderItem.Name = selectedrow[0].SubItems[1].Text;
                _selectedOrderItem.Description = selectedrow[0].SubItems[2].Text;
                _selectedOrderItem.CurrentPrice = Convert.ToDecimal(selectedrow[0].SubItems[3].Text);
                _selectedOrderItemQuantity = Convert.ToDecimal(selectedrow[0].SubItems[4].Text);
            }
            textBoxOrderItemName.Text = _selectedProduct.Name;
            textBoxOrderItemDescription.Text = _selectedProduct.Description;
            textBoxOrderItemPurchasePrice.Text = _selectedProduct.CurrentPrice.ToString();
            textBoxOrderItemQuantity.Text = _selectedOrderItemQuantity.ToString();

            buttonOrderItemUpdate.Enabled = true;
            buttonOrderItemRemove.Enabled = true;
        }
        
        private void buttonOrderItemUpdate_Click(object sender, EventArgs e)
        {
            var selectedrow = listViewOrderItem.SelectedItems;
            var selectedproductquantity = Math.Round(Convert.ToDouble(textBoxOrderItemQuantity.Text), 0);

            if (selectedrow.Count > 0 && selectedproductquantity > 0)
            {
                selectedrow[0].SubItems[4].Text = selectedproductquantity.ToString();
                _orderItemClearAll();
            }
            
        }

        private void buttonOrderItemRemove_Click(object sender, EventArgs e)
        {
            var selectedrow = listViewOrderItem.SelectedItems;

            if(selectedrow.Count > 0)
            {
                listViewOrderItem.Items.RemoveAt(listViewOrderItem.SelectedIndices[0]);
                _orderItemClearAll();
            }
            
        }

        private void buttonOrderItemClear_Click(object sender, EventArgs e)
        {
            _orderItemClearAll();
        }

        private void buttonOrderItemNext_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedTab = tabPageCustomer;
        }

        private void buttonOrderItemBack_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedTab = tabPageProduct;
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

        private void buttonCustomerSearch_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = textBoxCustomerFirstName.Text.Trim(),
                LastName = textBoxCustomerLastName.Text.Trim(),
                PhoneNumber = textBoxCustomerPhoneNumber.Text.Trim()
            };
            _fillListView(customer);
        }

        private void buttonCustomerClear_Click(object sender, EventArgs e)
        {
            _customerClearAll();
        }

        private void _customerClearAll()
        {
            buttonCustomerNext.Enabled = false;

            textBoxCustomerFirstName.Text = string.Empty;
            textBoxCustomerLastName.Text = string.Empty;
            textBoxCustomerPhoneNumber.Text = string.Empty;

            _fillListView(new Customer());
        }

        private void listViewCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedrow = listViewCustomer.SelectedItems;

            if (selectedrow.Count > 0)
            {
                _selectedCustomer.Id = Convert.ToInt32(selectedrow[0].SubItems[0].Text);
                _selectedCustomer.FirstName = selectedrow[0].SubItems[1].Text;
                _selectedCustomer.LastName = selectedrow[0].SubItems[2].Text;
                _selectedCustomer.PhoneNumber = selectedrow[0].SubItems[3].Text;
            }

            textBoxCustomerFirstName.Text = _selectedCustomer.FirstName;
            textBoxCustomerLastName.Text = _selectedCustomer.LastName;
            textBoxCustomerPhoneNumber.Text = _selectedCustomer.PhoneNumber;

            buttonCustomerNext.Enabled = true;
            _addressClearAll();
        }

        private void buttonCustomerNext_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedTab = tabPageShippingAddress;
        }

        private void buttonCustomerBack_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedTab = tabPageOrderItems;
        }

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

        private void listViewAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedrow = listViewAddress.SelectedItems;

            if (selectedrow.Count > 0)
            {
                _selectedAddress.Id = Convert.ToInt32(selectedrow[0].SubItems[0].Text);
                _selectedAddress.HouseBuildingStreet = selectedrow[0].SubItems[1].Text;
                _selectedAddress.Province = selectedrow[0].SubItems[2].Text;
                _selectedAddress.CityMunicipality = selectedrow[0].SubItems[3].Text;
                _selectedAddress.Barangay = selectedrow[0].SubItems[4].Text;
            }

            textBoxAddressHouse.Text = _selectedAddress.HouseBuildingStreet;
            textBoxAddressProvince.Text = _selectedAddress.Province;
            textBoxAddressCity.Text = _selectedAddress.CityMunicipality;
            textBoxAddressBarangay.Text = _selectedAddress.Barangay;

            buttonAddressNext.Enabled = true;            
        }

        private void buttonAddressSearch_Click(object sender, EventArgs e)
        {            
            var address = new Address
            {
                HouseBuildingStreet = textBoxAddressHouse.Text.Trim(),
                Province = textBoxAddressProvince.Text.Trim(),
                CityMunicipality = textBoxAddressCity.Text.Trim(),
                Barangay = textBoxAddressBarangay.Text.Trim(),
                CustomerId = _selectedCustomer.Id
            };
            _fillListView(address);
        }

        private void _addressClearAll()
        {
            buttonAddressNext.Enabled = false;

            textBoxAddressHouse.Text = string.Empty;
            textBoxAddressProvince.Text = string.Empty;
            textBoxAddressCity.Text = string.Empty;
            textBoxAddressBarangay.Text = string.Empty;

            var address = new Address { CustomerId = _selectedCustomer.Id };
            _fillListView(address);
            _selectedAddress = new Address();
        }

        private void buttonAddressClear_Click(object sender, EventArgs e)
        {
            _addressClearAll();
        }

        private void buttonAddressNext_Click(object sender, EventArgs e)
        {
            var selectedrow = listViewAddress.SelectedItems;

            if (selectedrow.Count > 0)
            {
                tabControlOrder.SelectedTab = tabPageSummary;
                _generateSummary();
            }
            
        }

        private void buttonAddressBack_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedTab = tabPageCustomer;
        }
        private void _generateSummary()
        {
            listViewSummary.Clear();
            // Set the view to show details.
            listViewSummary.View = View.Details;
            // Select the item and subitems when selection is made.
            listViewSummary.FullRowSelect = true;
            // Display grid lines.
            listViewSummary.GridLines = true;
            // Sort the items in the list in ascending order.
            listViewSummary.Sorting = SortOrder.Ascending;

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listViewSummary.Columns.Add("Id", 0, HorizontalAlignment.Center);
            listViewSummary.Columns.Add("Name", 150, HorizontalAlignment.Center);
            listViewSummary.Columns.Add("Description", 150, HorizontalAlignment.Center);
            listViewSummary.Columns.Add("Purchase Price", 120, HorizontalAlignment.Center);
            listViewSummary.Columns.Add("Quantity", 120, HorizontalAlignment.Center);            

            var orderitemsrows = listViewOrderItem.Items;
            decimal total = 0;
            decimal? numberOfitems = 0;

            for (var i = 0; i < orderitemsrows.Count; i++)
            {
                var item = listViewOrderItem.Items[i].Clone() as ListViewItem;
                listViewSummary.Items.Add(item);

                total += Convert.ToDecimal(orderitemsrows[i].SubItems[3].Text) * Convert.ToDecimal(orderitemsrows[i].SubItems[4].Text);
                numberOfitems += Convert.ToDecimal(orderitemsrows[i].SubItems[4].Text);
            }
            _totalAmount = total;
            labelBillAndShip.Text = $"Customer: {_selectedCustomer.FullName}\r\n\r\nPhone Number:{_selectedCustomer.PhoneNumber}" +
                $"\r\n\r\nAddress: {_selectedAddress.HouseBuildingStreet}, {_selectedAddress.Barangay}, {_selectedAddress.CityMunicipality}, {_selectedAddress.Province}";

            labelOrderSummary.Text = $"Subtotal ({numberOfitems} items): {Math.Round(Convert.ToDouble(_totalAmount), 2).ToString("0.00")}" +
                $"\r\n\r\nTotal: {Math.Round(Convert.ToDouble(_totalAmount), 2).ToString("0.00")}";
        }

        private void tabPageSummary_Enter(object sender, EventArgs e)
        {
            _generateSummary();
        }

        private void buttonSummaryPlaceOrder_Click(object sender, EventArgs e)
        {
            var orderDate = DateTime.Now;
            var order = new Order
            {
                CustomerId = _selectedCustomer.Id,
                AddressId = _selectedAddress.Id,
                OrderDate = orderDate,
                TotalAmount = _totalAmount,
                MinOrderDate = orderDate.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                MaxOrderDate = orderDate.ToString("yyyy-MM-dd HH:mm:ss.fff")
            };
            var orderDB = new OrderRepository();

            if(orderDB.Save(order) == false)
            {
                MessageBox.Show("Your order is incomplete, please check.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var retrieveSaveOrder = orderDB.GetLastId();
            var orderSummaryRows = listViewSummary.Items;
            var orderItemDB = new OrderItemRepository();
            var saveCount = 0;

            for (var i = 0; i < orderSummaryRows.Count; i++)
            {
                var orderItem = new OrderItem
                {
                    OrderId = retrieveSaveOrder[0].Id,
                    ProductId = Convert.ToInt32(orderSummaryRows[i].SubItems[0].Text),
                    PurchasePrice = Convert.ToDecimal(orderSummaryRows[i].SubItems[3].Text),
                    Quantity = Convert.ToDecimal(orderSummaryRows[i].SubItems[4].Text)
                };

                if (orderItemDB.Save(orderItem) == true) saveCount++;
            }

            MessageBox.Show($"Your order of {orderSummaryRows.Count} of {saveCount} items is placed. ", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonSummaryBack_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedTab = tabPageShippingAddress;
        }
    }
}
