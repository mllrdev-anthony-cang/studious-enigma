namespace WindowsFormsACSC
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlOrder = new System.Windows.Forms.TabControl();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.buttonProductCancel = new System.Windows.Forms.Button();
            this.buttonProductClear = new System.Windows.Forms.Button();
            this.buttonProductSearch = new System.Windows.Forms.Button();
            this.buttonProductNext = new System.Windows.Forms.Button();
            this.buttonProductAdd = new System.Windows.Forms.Button();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxProductMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductQuantity = new System.Windows.Forms.TextBox();
            this.textBoxProductCurrentPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageOrderItems = new System.Windows.Forms.TabPage();
            this.buttonOrderItemRemove = new System.Windows.Forms.Button();
            this.buttonOrderItemUpdate = new System.Windows.Forms.Button();
            this.buttonOrderItemNext = new System.Windows.Forms.Button();
            this.buttonOrderItemBack = new System.Windows.Forms.Button();
            this.buttonOrderItemClear = new System.Windows.Forms.Button();
            this.listViewOrderItem = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOrderItemQuantity = new System.Windows.Forms.TextBox();
            this.textBoxOrderItemPurchasePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOrderItemDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOrderItemName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxCustomerFirstName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCustomerSearch = new System.Windows.Forms.Button();
            this.buttonCustomerBack = new System.Windows.Forms.Button();
            this.buttonCustomerNext = new System.Windows.Forms.Button();
            this.buttonCustomerClear = new System.Windows.Forms.Button();
            this.listViewCustomer = new System.Windows.Forms.ListView();
            this.tabPageShippingAddress = new System.Windows.Forms.TabPage();
            this.buttonAddressBack = new System.Windows.Forms.Button();
            this.buttonAddressNext = new System.Windows.Forms.Button();
            this.buttonAddressClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxAddressBarangay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAddressHouse = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxAddressProvince = new System.Windows.Forms.TextBox();
            this.textBoxAddressCity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.listViewAddress = new System.Windows.Forms.ListView();
            this.buttonAddressSearch = new System.Windows.Forms.Button();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.listViewSummary = new System.Windows.Forms.ListView();
            this.buttonSummaryBack = new System.Windows.Forms.Button();
            this.buttonSummaryPlaceOrder = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelOrderSummary = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelBillAndShip = new System.Windows.Forms.Label();
            this.tabControlOrder.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageOrderItems.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageShippingAddress.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOrder
            // 
            this.tabControlOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlOrder.Controls.Add(this.tabPageProduct);
            this.tabControlOrder.Controls.Add(this.tabPageOrderItems);
            this.tabControlOrder.Controls.Add(this.tabPageCustomer);
            this.tabControlOrder.Controls.Add(this.tabPageShippingAddress);
            this.tabControlOrder.Controls.Add(this.tabPageSummary);
            this.tabControlOrder.Location = new System.Drawing.Point(10, 10);
            this.tabControlOrder.Name = "tabControlOrder";
            this.tabControlOrder.SelectedIndex = 0;
            this.tabControlOrder.Size = new System.Drawing.Size(776, 444);
            this.tabControlOrder.TabIndex = 0;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.BackColor = System.Drawing.Color.Transparent;
            this.tabPageProduct.Controls.Add(this.buttonProductCancel);
            this.tabPageProduct.Controls.Add(this.buttonProductClear);
            this.tabPageProduct.Controls.Add(this.buttonProductSearch);
            this.tabPageProduct.Controls.Add(this.buttonProductNext);
            this.tabPageProduct.Controls.Add(this.buttonProductAdd);
            this.tabPageProduct.Controls.Add(this.listViewProduct);
            this.tabPageProduct.Controls.Add(this.groupBox2);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(768, 418);
            this.tabPageProduct.TabIndex = 0;
            this.tabPageProduct.Text = "Product";
            // 
            // buttonProductCancel
            // 
            this.buttonProductCancel.Location = new System.Drawing.Point(136, 322);
            this.buttonProductCancel.Name = "buttonProductCancel";
            this.buttonProductCancel.Size = new System.Drawing.Size(118, 23);
            this.buttonProductCancel.TabIndex = 17;
            this.buttonProductCancel.Text = "Cancel";
            this.buttonProductCancel.UseVisualStyleBackColor = true;
            this.buttonProductCancel.Click += new System.EventHandler(this.buttonProductCancel_Click);
            // 
            // buttonProductClear
            // 
            this.buttonProductClear.Location = new System.Drawing.Point(136, 264);
            this.buttonProductClear.Name = "buttonProductClear";
            this.buttonProductClear.Size = new System.Drawing.Size(118, 23);
            this.buttonProductClear.TabIndex = 16;
            this.buttonProductClear.Text = "Clear";
            this.buttonProductClear.UseVisualStyleBackColor = true;
            this.buttonProductClear.Click += new System.EventHandler(this.buttonProductClear_Click);
            // 
            // buttonProductSearch
            // 
            this.buttonProductSearch.Location = new System.Drawing.Point(136, 235);
            this.buttonProductSearch.Name = "buttonProductSearch";
            this.buttonProductSearch.Size = new System.Drawing.Size(118, 23);
            this.buttonProductSearch.TabIndex = 13;
            this.buttonProductSearch.Text = "Search";
            this.buttonProductSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearch.Click += new System.EventHandler(this.buttonProductSearch_Click);
            // 
            // buttonProductNext
            // 
            this.buttonProductNext.Location = new System.Drawing.Point(136, 293);
            this.buttonProductNext.Name = "buttonProductNext";
            this.buttonProductNext.Size = new System.Drawing.Size(118, 23);
            this.buttonProductNext.TabIndex = 12;
            this.buttonProductNext.Text = "Next";
            this.buttonProductNext.UseVisualStyleBackColor = true;
            this.buttonProductNext.Click += new System.EventHandler(this.buttonProductNext_Click);
            // 
            // buttonProductAdd
            // 
            this.buttonProductAdd.Location = new System.Drawing.Point(6, 235);
            this.buttonProductAdd.Name = "buttonProductAdd";
            this.buttonProductAdd.Size = new System.Drawing.Size(118, 23);
            this.buttonProductAdd.TabIndex = 12;
            this.buttonProductAdd.Text = "Add to kart";
            this.buttonProductAdd.UseVisualStyleBackColor = true;
            this.buttonProductAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewProduct
            // 
            this.listViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(260, 6);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(502, 404);
            this.listViewProduct.TabIndex = 11;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.SelectedIndexChanged += new System.EventHandler(this.listViewProduct_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxProductMaxPrice);
            this.groupBox2.Controls.Add(this.textBoxProductMinPrice);
            this.groupBox2.Controls.Add(this.textBoxProductQuantity);
            this.groupBox2.Controls.Add(this.textBoxProductCurrentPrice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelPrice);
            this.groupBox2.Controls.Add(this.textBoxProductDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxProductName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 223);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // textBoxProductMaxPrice
            // 
            this.textBoxProductMaxPrice.Location = new System.Drawing.Point(127, 156);
            this.textBoxProductMaxPrice.Name = "textBoxProductMaxPrice";
            this.textBoxProductMaxPrice.Size = new System.Drawing.Size(109, 20);
            this.textBoxProductMaxPrice.TabIndex = 3;
            // 
            // textBoxProductMinPrice
            // 
            this.textBoxProductMinPrice.Location = new System.Drawing.Point(9, 156);
            this.textBoxProductMinPrice.Name = "textBoxProductMinPrice";
            this.textBoxProductMinPrice.Size = new System.Drawing.Size(109, 20);
            this.textBoxProductMinPrice.TabIndex = 3;
            // 
            // textBoxProductQuantity
            // 
            this.textBoxProductQuantity.Location = new System.Drawing.Point(9, 195);
            this.textBoxProductQuantity.Name = "textBoxProductQuantity";
            this.textBoxProductQuantity.Size = new System.Drawing.Size(227, 20);
            this.textBoxProductQuantity.TabIndex = 3;
            // 
            // textBoxProductCurrentPrice
            // 
            this.textBoxProductCurrentPrice.Location = new System.Drawing.Point(9, 117);
            this.textBoxProductCurrentPrice.Name = "textBoxProductCurrentPrice";
            this.textBoxProductCurrentPrice.Size = new System.Drawing.Size(227, 20);
            this.textBoxProductCurrentPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search by Price Range:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(6, 101);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(71, 13);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Current Price:";
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.Location = new System.Drawing.Point(9, 80);
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(227, 20);
            this.textBoxProductDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(9, 40);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(227, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = " Name:";
            // 
            // tabPageOrderItems
            // 
            this.tabPageOrderItems.BackColor = System.Drawing.Color.Transparent;
            this.tabPageOrderItems.Controls.Add(this.buttonOrderItemRemove);
            this.tabPageOrderItems.Controls.Add(this.buttonOrderItemUpdate);
            this.tabPageOrderItems.Controls.Add(this.buttonOrderItemNext);
            this.tabPageOrderItems.Controls.Add(this.buttonOrderItemBack);
            this.tabPageOrderItems.Controls.Add(this.buttonOrderItemClear);
            this.tabPageOrderItems.Controls.Add(this.listViewOrderItem);
            this.tabPageOrderItems.Controls.Add(this.groupBox1);
            this.tabPageOrderItems.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderItems.Name = "tabPageOrderItems";
            this.tabPageOrderItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderItems.Size = new System.Drawing.Size(768, 418);
            this.tabPageOrderItems.TabIndex = 1;
            this.tabPageOrderItems.Text = "Order Items";
            // 
            // buttonOrderItemRemove
            // 
            this.buttonOrderItemRemove.Location = new System.Drawing.Point(6, 227);
            this.buttonOrderItemRemove.Name = "buttonOrderItemRemove";
            this.buttonOrderItemRemove.Size = new System.Drawing.Size(118, 23);
            this.buttonOrderItemRemove.TabIndex = 23;
            this.buttonOrderItemRemove.Text = "Remove";
            this.buttonOrderItemRemove.UseVisualStyleBackColor = true;
            this.buttonOrderItemRemove.Click += new System.EventHandler(this.buttonOrderItemRemove_Click);
            // 
            // buttonOrderItemUpdate
            // 
            this.buttonOrderItemUpdate.Location = new System.Drawing.Point(6, 198);
            this.buttonOrderItemUpdate.Name = "buttonOrderItemUpdate";
            this.buttonOrderItemUpdate.Size = new System.Drawing.Size(118, 23);
            this.buttonOrderItemUpdate.TabIndex = 22;
            this.buttonOrderItemUpdate.Text = "Update";
            this.buttonOrderItemUpdate.UseVisualStyleBackColor = true;
            this.buttonOrderItemUpdate.Click += new System.EventHandler(this.buttonOrderItemUpdate_Click);
            // 
            // buttonOrderItemNext
            // 
            this.buttonOrderItemNext.Location = new System.Drawing.Point(136, 228);
            this.buttonOrderItemNext.Name = "buttonOrderItemNext";
            this.buttonOrderItemNext.Size = new System.Drawing.Size(118, 23);
            this.buttonOrderItemNext.TabIndex = 23;
            this.buttonOrderItemNext.Text = "Next";
            this.buttonOrderItemNext.UseVisualStyleBackColor = true;
            this.buttonOrderItemNext.Click += new System.EventHandler(this.buttonOrderItemNext_Click);
            // 
            // buttonOrderItemBack
            // 
            this.buttonOrderItemBack.Location = new System.Drawing.Point(136, 257);
            this.buttonOrderItemBack.Name = "buttonOrderItemBack";
            this.buttonOrderItemBack.Size = new System.Drawing.Size(118, 23);
            this.buttonOrderItemBack.TabIndex = 23;
            this.buttonOrderItemBack.Text = "Back";
            this.buttonOrderItemBack.UseVisualStyleBackColor = true;
            this.buttonOrderItemBack.Click += new System.EventHandler(this.buttonOrderItemBack_Click);
            // 
            // buttonOrderItemClear
            // 
            this.buttonOrderItemClear.Location = new System.Drawing.Point(136, 198);
            this.buttonOrderItemClear.Name = "buttonOrderItemClear";
            this.buttonOrderItemClear.Size = new System.Drawing.Size(118, 23);
            this.buttonOrderItemClear.TabIndex = 22;
            this.buttonOrderItemClear.Text = "Clear";
            this.buttonOrderItemClear.UseVisualStyleBackColor = true;
            this.buttonOrderItemClear.Click += new System.EventHandler(this.buttonOrderItemClear_Click);
            // 
            // listViewOrderItem
            // 
            this.listViewOrderItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOrderItem.HideSelection = false;
            this.listViewOrderItem.Location = new System.Drawing.Point(260, 6);
            this.listViewOrderItem.Name = "listViewOrderItem";
            this.listViewOrderItem.Size = new System.Drawing.Size(502, 404);
            this.listViewOrderItem.TabIndex = 19;
            this.listViewOrderItem.UseCompatibleStateImageBehavior = false;
            this.listViewOrderItem.SelectedIndexChanged += new System.EventHandler(this.listViewOrderItem_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOrderItemQuantity);
            this.groupBox1.Controls.Add(this.textBoxOrderItemPurchasePrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxOrderItemDescription);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxOrderItemName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 186);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Item Details";
            // 
            // textBoxOrderItemQuantity
            // 
            this.textBoxOrderItemQuantity.Location = new System.Drawing.Point(9, 158);
            this.textBoxOrderItemQuantity.Name = "textBoxOrderItemQuantity";
            this.textBoxOrderItemQuantity.Size = new System.Drawing.Size(227, 20);
            this.textBoxOrderItemQuantity.TabIndex = 3;
            // 
            // textBoxOrderItemPurchasePrice
            // 
            this.textBoxOrderItemPurchasePrice.Location = new System.Drawing.Point(9, 119);
            this.textBoxOrderItemPurchasePrice.Name = "textBoxOrderItemPurchasePrice";
            this.textBoxOrderItemPurchasePrice.Size = new System.Drawing.Size(227, 20);
            this.textBoxOrderItemPurchasePrice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Purchase Price:";
            // 
            // textBoxOrderItemDescription
            // 
            this.textBoxOrderItemDescription.Location = new System.Drawing.Point(9, 80);
            this.textBoxOrderItemDescription.Name = "textBoxOrderItemDescription";
            this.textBoxOrderItemDescription.Size = new System.Drawing.Size(227, 20);
            this.textBoxOrderItemDescription.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Description:";
            // 
            // textBoxOrderItemName
            // 
            this.textBoxOrderItemName.Location = new System.Drawing.Point(9, 40);
            this.textBoxOrderItemName.Name = "textBoxOrderItemName";
            this.textBoxOrderItemName.Size = new System.Drawing.Size(227, 20);
            this.textBoxOrderItemName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = " Name:";
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.BackColor = System.Drawing.Color.Transparent;
            this.tabPageCustomer.Controls.Add(this.groupBox3);
            this.tabPageCustomer.Controls.Add(this.buttonCustomerSearch);
            this.tabPageCustomer.Controls.Add(this.buttonCustomerBack);
            this.tabPageCustomer.Controls.Add(this.buttonCustomerNext);
            this.tabPageCustomer.Controls.Add(this.buttonCustomerClear);
            this.tabPageCustomer.Controls.Add(this.listViewCustomer);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(768, 418);
            this.tabPageCustomer.TabIndex = 2;
            this.tabPageCustomer.Text = "Customer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxCustomerPhoneNumber);
            this.groupBox3.Controls.Add(this.textBoxCustomerFirstName);
            this.groupBox3.Controls.Add(this.textBoxCustomerLastName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 150);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Details";
            // 
            // textBoxCustomerPhoneNumber
            // 
            this.textBoxCustomerPhoneNumber.Location = new System.Drawing.Point(9, 120);
            this.textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
            this.textBoxCustomerPhoneNumber.Size = new System.Drawing.Size(227, 20);
            this.textBoxCustomerPhoneNumber.TabIndex = 3;
            // 
            // textBoxCustomerFirstName
            // 
            this.textBoxCustomerFirstName.Location = new System.Drawing.Point(9, 40);
            this.textBoxCustomerFirstName.Name = "textBoxCustomerFirstName";
            this.textBoxCustomerFirstName.Size = new System.Drawing.Size(227, 20);
            this.textBoxCustomerFirstName.TabIndex = 1;
            // 
            // textBoxCustomerLastName
            // 
            this.textBoxCustomerLastName.Location = new System.Drawing.Point(9, 80);
            this.textBoxCustomerLastName.Name = "textBoxCustomerLastName";
            this.textBoxCustomerLastName.Size = new System.Drawing.Size(227, 20);
            this.textBoxCustomerLastName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "First Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Phone Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Last Name:";
            // 
            // buttonCustomerSearch
            // 
            this.buttonCustomerSearch.Location = new System.Drawing.Point(136, 162);
            this.buttonCustomerSearch.Name = "buttonCustomerSearch";
            this.buttonCustomerSearch.Size = new System.Drawing.Size(118, 23);
            this.buttonCustomerSearch.TabIndex = 13;
            this.buttonCustomerSearch.Text = "Search";
            this.buttonCustomerSearch.UseVisualStyleBackColor = true;
            this.buttonCustomerSearch.Click += new System.EventHandler(this.buttonCustomerSearch_Click);
            // 
            // buttonCustomerBack
            // 
            this.buttonCustomerBack.Location = new System.Drawing.Point(136, 249);
            this.buttonCustomerBack.Name = "buttonCustomerBack";
            this.buttonCustomerBack.Size = new System.Drawing.Size(118, 23);
            this.buttonCustomerBack.TabIndex = 10;
            this.buttonCustomerBack.Text = "Back";
            this.buttonCustomerBack.UseVisualStyleBackColor = true;
            this.buttonCustomerBack.Click += new System.EventHandler(this.buttonCustomerBack_Click);
            // 
            // buttonCustomerNext
            // 
            this.buttonCustomerNext.Location = new System.Drawing.Point(136, 220);
            this.buttonCustomerNext.Name = "buttonCustomerNext";
            this.buttonCustomerNext.Size = new System.Drawing.Size(118, 23);
            this.buttonCustomerNext.TabIndex = 10;
            this.buttonCustomerNext.Text = "Next";
            this.buttonCustomerNext.UseVisualStyleBackColor = true;
            this.buttonCustomerNext.Click += new System.EventHandler(this.buttonCustomerNext_Click);
            // 
            // buttonCustomerClear
            // 
            this.buttonCustomerClear.Location = new System.Drawing.Point(136, 191);
            this.buttonCustomerClear.Name = "buttonCustomerClear";
            this.buttonCustomerClear.Size = new System.Drawing.Size(118, 23);
            this.buttonCustomerClear.TabIndex = 11;
            this.buttonCustomerClear.Text = "Clear";
            this.buttonCustomerClear.UseVisualStyleBackColor = true;
            this.buttonCustomerClear.Click += new System.EventHandler(this.buttonCustomerClear_Click);
            // 
            // listViewCustomer
            // 
            this.listViewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCustomer.FullRowSelect = true;
            this.listViewCustomer.HideSelection = false;
            this.listViewCustomer.Location = new System.Drawing.Point(260, 6);
            this.listViewCustomer.Name = "listViewCustomer";
            this.listViewCustomer.Size = new System.Drawing.Size(502, 404);
            this.listViewCustomer.TabIndex = 8;
            this.listViewCustomer.UseCompatibleStateImageBehavior = false;
            this.listViewCustomer.View = System.Windows.Forms.View.Details;
            this.listViewCustomer.SelectedIndexChanged += new System.EventHandler(this.listViewCustomer_SelectedIndexChanged);
            // 
            // tabPageShippingAddress
            // 
            this.tabPageShippingAddress.BackColor = System.Drawing.Color.Transparent;
            this.tabPageShippingAddress.Controls.Add(this.buttonAddressBack);
            this.tabPageShippingAddress.Controls.Add(this.buttonAddressNext);
            this.tabPageShippingAddress.Controls.Add(this.buttonAddressClear);
            this.tabPageShippingAddress.Controls.Add(this.groupBox4);
            this.tabPageShippingAddress.Controls.Add(this.listViewAddress);
            this.tabPageShippingAddress.Controls.Add(this.buttonAddressSearch);
            this.tabPageShippingAddress.Location = new System.Drawing.Point(4, 22);
            this.tabPageShippingAddress.Name = "tabPageShippingAddress";
            this.tabPageShippingAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShippingAddress.Size = new System.Drawing.Size(768, 418);
            this.tabPageShippingAddress.TabIndex = 3;
            this.tabPageShippingAddress.Text = "Shipping Address";
            // 
            // buttonAddressBack
            // 
            this.buttonAddressBack.Location = new System.Drawing.Point(136, 286);
            this.buttonAddressBack.Name = "buttonAddressBack";
            this.buttonAddressBack.Size = new System.Drawing.Size(118, 23);
            this.buttonAddressBack.TabIndex = 6;
            this.buttonAddressBack.Text = "Back";
            this.buttonAddressBack.UseVisualStyleBackColor = true;
            this.buttonAddressBack.Click += new System.EventHandler(this.buttonAddressBack_Click);
            // 
            // buttonAddressNext
            // 
            this.buttonAddressNext.Location = new System.Drawing.Point(136, 257);
            this.buttonAddressNext.Name = "buttonAddressNext";
            this.buttonAddressNext.Size = new System.Drawing.Size(118, 23);
            this.buttonAddressNext.TabIndex = 6;
            this.buttonAddressNext.Text = "Next";
            this.buttonAddressNext.UseVisualStyleBackColor = true;
            this.buttonAddressNext.Click += new System.EventHandler(this.buttonAddressNext_Click);
            // 
            // buttonAddressClear
            // 
            this.buttonAddressClear.Location = new System.Drawing.Point(136, 228);
            this.buttonAddressClear.Name = "buttonAddressClear";
            this.buttonAddressClear.Size = new System.Drawing.Size(118, 23);
            this.buttonAddressClear.TabIndex = 7;
            this.buttonAddressClear.Text = "Clear";
            this.buttonAddressClear.UseVisualStyleBackColor = true;
            this.buttonAddressClear.Click += new System.EventHandler(this.buttonAddressClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxAddressBarangay);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBoxAddressHouse);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBoxAddressProvince);
            this.groupBox4.Controls.Add(this.textBoxAddressCity);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 187);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Address Details";
            // 
            // textBoxAddressBarangay
            // 
            this.textBoxAddressBarangay.Location = new System.Drawing.Point(9, 157);
            this.textBoxAddressBarangay.Name = "textBoxAddressBarangay";
            this.textBoxAddressBarangay.Size = new System.Drawing.Size(227, 20);
            this.textBoxAddressBarangay.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "House, Building, Street:";
            // 
            // textBoxAddressHouse
            // 
            this.textBoxAddressHouse.Location = new System.Drawing.Point(9, 40);
            this.textBoxAddressHouse.Name = "textBoxAddressHouse";
            this.textBoxAddressHouse.Size = new System.Drawing.Size(227, 20);
            this.textBoxAddressHouse.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Province:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Barangay:";
            // 
            // textBoxAddressProvince
            // 
            this.textBoxAddressProvince.Location = new System.Drawing.Point(9, 79);
            this.textBoxAddressProvince.Name = "textBoxAddressProvince";
            this.textBoxAddressProvince.Size = new System.Drawing.Size(227, 20);
            this.textBoxAddressProvince.TabIndex = 1;
            // 
            // textBoxAddressCity
            // 
            this.textBoxAddressCity.Location = new System.Drawing.Point(9, 118);
            this.textBoxAddressCity.Name = "textBoxAddressCity";
            this.textBoxAddressCity.Size = new System.Drawing.Size(227, 20);
            this.textBoxAddressCity.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "City / Municipality:";
            // 
            // listViewAddress
            // 
            this.listViewAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAddress.HideSelection = false;
            this.listViewAddress.Location = new System.Drawing.Point(260, 6);
            this.listViewAddress.Name = "listViewAddress";
            this.listViewAddress.Size = new System.Drawing.Size(502, 404);
            this.listViewAddress.TabIndex = 5;
            this.listViewAddress.UseCompatibleStateImageBehavior = false;
            this.listViewAddress.View = System.Windows.Forms.View.Details;
            this.listViewAddress.SelectedIndexChanged += new System.EventHandler(this.listViewAddress_SelectedIndexChanged);
            // 
            // buttonAddressSearch
            // 
            this.buttonAddressSearch.Location = new System.Drawing.Point(136, 199);
            this.buttonAddressSearch.Name = "buttonAddressSearch";
            this.buttonAddressSearch.Size = new System.Drawing.Size(118, 23);
            this.buttonAddressSearch.TabIndex = 10;
            this.buttonAddressSearch.Text = "Search";
            this.buttonAddressSearch.UseVisualStyleBackColor = true;
            this.buttonAddressSearch.Click += new System.EventHandler(this.buttonAddressSearch_Click);
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSummary.Controls.Add(this.listViewSummary);
            this.tabPageSummary.Controls.Add(this.buttonSummaryBack);
            this.tabPageSummary.Controls.Add(this.buttonSummaryPlaceOrder);
            this.tabPageSummary.Controls.Add(this.groupBox6);
            this.tabPageSummary.Controls.Add(this.groupBox5);
            this.tabPageSummary.Location = new System.Drawing.Point(4, 22);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSummary.Size = new System.Drawing.Size(768, 418);
            this.tabPageSummary.TabIndex = 4;
            this.tabPageSummary.Text = "Summary";
            this.tabPageSummary.Enter += new System.EventHandler(this.tabPageSummary_Enter);
            // 
            // listViewSummary
            // 
            this.listViewSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSummary.HideSelection = false;
            this.listViewSummary.Location = new System.Drawing.Point(260, 6);
            this.listViewSummary.Name = "listViewSummary";
            this.listViewSummary.Size = new System.Drawing.Size(502, 404);
            this.listViewSummary.TabIndex = 12;
            this.listViewSummary.UseCompatibleStateImageBehavior = false;
            this.listViewSummary.View = System.Windows.Forms.View.Details;
            // 
            // buttonSummaryBack
            // 
            this.buttonSummaryBack.Location = new System.Drawing.Point(136, 266);
            this.buttonSummaryBack.Name = "buttonSummaryBack";
            this.buttonSummaryBack.Size = new System.Drawing.Size(118, 23);
            this.buttonSummaryBack.TabIndex = 11;
            this.buttonSummaryBack.Text = "Back";
            this.buttonSummaryBack.UseVisualStyleBackColor = true;
            this.buttonSummaryBack.Click += new System.EventHandler(this.buttonSummaryBack_Click);
            // 
            // buttonSummaryPlaceOrder
            // 
            this.buttonSummaryPlaceOrder.Location = new System.Drawing.Point(136, 237);
            this.buttonSummaryPlaceOrder.Name = "buttonSummaryPlaceOrder";
            this.buttonSummaryPlaceOrder.Size = new System.Drawing.Size(118, 23);
            this.buttonSummaryPlaceOrder.TabIndex = 11;
            this.buttonSummaryPlaceOrder.Text = "Place Order";
            this.buttonSummaryPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonSummaryPlaceOrder.Click += new System.EventHandler(this.buttonSummaryPlaceOrder_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelOrderSummary);
            this.groupBox6.Location = new System.Drawing.Point(6, 152);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(248, 79);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Order Summary";
            // 
            // labelOrderSummary
            // 
            this.labelOrderSummary.Location = new System.Drawing.Point(6, 24);
            this.labelOrderSummary.Name = "labelOrderSummary";
            this.labelOrderSummary.Size = new System.Drawing.Size(236, 52);
            this.labelOrderSummary.TabIndex = 0;
            this.labelOrderSummary.Text = "Subtotal (# items) : 9999.00\r\n\r\nTotal: 9999.00";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelBillAndShip);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 131);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Billing and Shipping";
            // 
            // labelBillAndShip
            // 
            this.labelBillAndShip.Location = new System.Drawing.Point(6, 24);
            this.labelBillAndShip.Name = "labelBillAndShip";
            this.labelBillAndShip.Size = new System.Drawing.Size(236, 84);
            this.labelBillAndShip.TabIndex = 0;
            this.labelBillAndShip.Text = "Full Name\r\n\r\nPhone Number\r\n\r\nAddress";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 462);
            this.Controls.Add(this.tabControlOrder);
            this.MinimumSize = new System.Drawing.Size(809, 501);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.tabControlOrder.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageOrderItems.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageCustomer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageShippingAddress.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPageSummary.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOrder;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TabPage tabPageOrderItems;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.TabPage tabPageShippingAddress;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxProductMaxPrice;
        private System.Windows.Forms.TextBox textBoxProductMinPrice;
        private System.Windows.Forms.TextBox textBoxProductCurrentPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxProductDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.TextBox textBoxProductQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProductCancel;
        private System.Windows.Forms.Button buttonProductClear;
        private System.Windows.Forms.Button buttonProductSearch;
        private System.Windows.Forms.Button buttonProductAdd;
        private System.Windows.Forms.Button buttonProductNext;
        private System.Windows.Forms.Button buttonOrderItemRemove;
        private System.Windows.Forms.Button buttonOrderItemUpdate;
        private System.Windows.Forms.Button buttonOrderItemNext;
        private System.Windows.Forms.Button buttonOrderItemBack;
        private System.Windows.Forms.Button buttonOrderItemClear;
        private System.Windows.Forms.ListView listViewOrderItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOrderItemQuantity;
        private System.Windows.Forms.TextBox textBoxOrderItemPurchasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOrderItemDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOrderItemName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCustomerPhoneNumber;
        private System.Windows.Forms.TextBox textBoxCustomerFirstName;
        private System.Windows.Forms.TextBox textBoxCustomerLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCustomerSearch;
        private System.Windows.Forms.Button buttonCustomerNext;
        private System.Windows.Forms.Button buttonCustomerClear;
        private System.Windows.Forms.ListView listViewCustomer;
        private System.Windows.Forms.Button buttonCustomerBack;
        private System.Windows.Forms.Button buttonAddressBack;
        private System.Windows.Forms.Button buttonAddressNext;
        private System.Windows.Forms.Button buttonAddressClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxAddressBarangay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAddressHouse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxAddressProvince;
        private System.Windows.Forms.TextBox textBoxAddressCity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView listViewAddress;
        private System.Windows.Forms.Button buttonAddressSearch;
        private System.Windows.Forms.ListView listViewSummary;
        private System.Windows.Forms.Button buttonSummaryPlaceOrder;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelOrderSummary;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelBillAndShip;
        private System.Windows.Forms.Button buttonSummaryBack;
    }
}