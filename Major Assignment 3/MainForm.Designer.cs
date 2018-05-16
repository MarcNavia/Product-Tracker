namespace Major_Assignment_3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label productUnitPriceLabel;
            System.Windows.Forms.Label productCostLabel;
            System.Windows.Forms.Label quantityOnHandLabel;
            System.Windows.Forms.Label productLeadTimeLabel;
            System.Windows.Forms.Label productReorderLevelLabel;
            System.Windows.Forms.Label productLineLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label discountPercentLabel;
            System.Windows.Forms.Label yTDPurchasesLabel;
            System.Windows.Forms.Label yTDSalesLabel;
            System.Windows.Forms.Label quantityOnOrderLabel1;
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label vendorRegionLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label emailAddressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label webSiteAddressLabel;
            System.Windows.Forms.Label classificationLabel;
            System.Windows.Forms.Label activeStatusLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label contactNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.vendorList = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchaseAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calcButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsSourcedInTheUSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsSourcedInChinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalCostAndSalesByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsPricedOver55ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPurchasesLabel = new System.Windows.Forms.Label();
            this.averagePurchasesLabel = new System.Windows.Forms.Label();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorProductDatabase1DataSet = new Major_Assignment_3.VendorProductDatabase1DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.vendorIDComboBox = new System.Windows.Forms.ComboBox();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.productCostTextBox = new System.Windows.Forms.TextBox();
            this.quantityOnHandTextBox = new System.Windows.Forms.TextBox();
            this.productLeadTimeTextBox = new System.Windows.Forms.TextBox();
            this.productReorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.productLineTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentTextBox = new System.Windows.Forms.TextBox();
            this.yTDPurchasesTextBox = new System.Windows.Forms.TextBox();
            this.yTDSalesTextBox = new System.Windows.Forms.TextBox();
            this.quantityOnOrderTextBox1 = new System.Windows.Forms.TextBox();
            this.vendorNameLabel1 = new System.Windows.Forms.Label();
            this.vendorRegionLabel1 = new System.Windows.Forms.Label();
            this.stateLabel1 = new System.Windows.Forms.Label();
            this.cityLabel1 = new System.Windows.Forms.Label();
            this.zipCodeLabel1 = new System.Windows.Forms.Label();
            this.countryLabel1 = new System.Windows.Forms.Label();
            this.emailAddressLabel1 = new System.Windows.Forms.Label();
            this.phoneNumberLabel1 = new System.Windows.Forms.Label();
            this.webSiteAddressLabel1 = new System.Windows.Forms.Label();
            this.classificationLabel1 = new System.Windows.Forms.Label();
            this.activeStatusLabel1 = new System.Windows.Forms.Label();
            this.notesLabel1 = new System.Windows.Forms.Label();
            this.contactNameLabel1 = new System.Windows.Forms.Label();
            this.productTableAdapter = new Major_Assignment_3.VendorProductDatabase1DataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Major_Assignment_3.VendorProductDatabase1DataSetTableAdapters.TableAdapterManager();
            this.vendorTableAdapter = new Major_Assignment_3.VendorProductDatabase1DataSetTableAdapters.VendorTableAdapter();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            vendorIDLabel = new System.Windows.Forms.Label();
            productUnitPriceLabel = new System.Windows.Forms.Label();
            productCostLabel = new System.Windows.Forms.Label();
            quantityOnHandLabel = new System.Windows.Forms.Label();
            productLeadTimeLabel = new System.Windows.Forms.Label();
            productReorderLevelLabel = new System.Windows.Forms.Label();
            productLineLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            discountPercentLabel = new System.Windows.Forms.Label();
            yTDPurchasesLabel = new System.Windows.Forms.Label();
            yTDSalesLabel = new System.Windows.Forms.Label();
            quantityOnOrderLabel1 = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            vendorRegionLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            emailAddressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            webSiteAddressLabel = new System.Windows.Forms.Label();
            classificationLabel = new System.Windows.Forms.Label();
            activeStatusLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            contactNameLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProductDatabase1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(15, 53);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(66, 15);
            productIDLabel.TabIndex = 2;
            productIDLabel.Text = "Product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(15, 81);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(87, 15);
            productNameLabel.TabIndex = 4;
            productNameLabel.Text = "Product Name:";
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(16, 107);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(61, 15);
            vendorIDLabel.TabIndex = 6;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // productUnitPriceLabel
            // 
            productUnitPriceLabel.AutoSize = true;
            productUnitPriceLabel.Location = new System.Drawing.Point(15, 140);
            productUnitPriceLabel.Name = "productUnitPriceLabel";
            productUnitPriceLabel.Size = new System.Drawing.Size(106, 15);
            productUnitPriceLabel.TabIndex = 8;
            productUnitPriceLabel.Text = "Product Unit Price:";
            // 
            // productCostLabel
            // 
            productCostLabel.AutoSize = true;
            productCostLabel.Location = new System.Drawing.Point(15, 171);
            productCostLabel.Name = "productCostLabel";
            productCostLabel.Size = new System.Drawing.Size(79, 15);
            productCostLabel.TabIndex = 10;
            productCostLabel.Text = "Product Cost:";
            // 
            // quantityOnHandLabel
            // 
            quantityOnHandLabel.AutoSize = true;
            quantityOnHandLabel.Location = new System.Drawing.Point(16, 234);
            quantityOnHandLabel.Name = "quantityOnHandLabel";
            quantityOnHandLabel.Size = new System.Drawing.Size(107, 15);
            quantityOnHandLabel.TabIndex = 14;
            quantityOnHandLabel.Text = "Quantity On Hand:";
            // 
            // productLeadTimeLabel
            // 
            productLeadTimeLabel.AutoSize = true;
            productLeadTimeLabel.Location = new System.Drawing.Point(16, 266);
            productLeadTimeLabel.Name = "productLeadTimeLabel";
            productLeadTimeLabel.Size = new System.Drawing.Size(110, 15);
            productLeadTimeLabel.TabIndex = 16;
            productLeadTimeLabel.Text = "Product Lead Time:";
            // 
            // productReorderLevelLabel
            // 
            productReorderLevelLabel.AutoSize = true;
            productReorderLevelLabel.Location = new System.Drawing.Point(16, 293);
            productReorderLevelLabel.Name = "productReorderLevelLabel";
            productReorderLevelLabel.Size = new System.Drawing.Size(126, 15);
            productReorderLevelLabel.TabIndex = 18;
            productReorderLevelLabel.Text = "Product Reorder Level:";
            // 
            // productLineLabel
            // 
            productLineLabel.AutoSize = true;
            productLineLabel.Location = new System.Drawing.Point(16, 323);
            productLineLabel.Name = "productLineLabel";
            productLineLabel.Size = new System.Drawing.Size(77, 15);
            productLineLabel.TabIndex = 20;
            productLineLabel.Text = "Product Line:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(16, 353);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(41, 15);
            brandLabel.TabIndex = 22;
            brandLabel.Text = "Brand:";
            // 
            // discountPercentLabel
            // 
            discountPercentLabel.AutoSize = true;
            discountPercentLabel.Location = new System.Drawing.Point(14, 384);
            discountPercentLabel.Name = "discountPercentLabel";
            discountPercentLabel.Size = new System.Drawing.Size(100, 15);
            discountPercentLabel.TabIndex = 24;
            discountPercentLabel.Text = "Discount Percent:";
            // 
            // yTDPurchasesLabel
            // 
            yTDPurchasesLabel.AutoSize = true;
            yTDPurchasesLabel.Location = new System.Drawing.Point(16, 414);
            yTDPurchasesLabel.Name = "yTDPurchasesLabel";
            yTDPurchasesLabel.Size = new System.Drawing.Size(85, 15);
            yTDPurchasesLabel.TabIndex = 26;
            yTDPurchasesLabel.Text = "YTDPurchases:";
            // 
            // yTDSalesLabel
            // 
            yTDSalesLabel.AutoSize = true;
            yTDSalesLabel.Location = new System.Drawing.Point(16, 443);
            yTDSalesLabel.Name = "yTDSalesLabel";
            yTDSalesLabel.Size = new System.Drawing.Size(58, 15);
            yTDSalesLabel.TabIndex = 28;
            yTDSalesLabel.Text = "YTDSales:";
            // 
            // quantityOnOrderLabel1
            // 
            quantityOnOrderLabel1.AutoSize = true;
            quantityOnOrderLabel1.Location = new System.Drawing.Point(16, 202);
            quantityOnOrderLabel1.Name = "quantityOnOrderLabel1";
            quantityOnOrderLabel1.Size = new System.Drawing.Size(108, 15);
            quantityOnOrderLabel1.TabIndex = 12;
            quantityOnOrderLabel1.Text = "Quantity On Order:";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Location = new System.Drawing.Point(310, 53);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(82, 15);
            vendorNameLabel.TabIndex = 30;
            vendorNameLabel.Text = "Vendor Name:";
            // 
            // vendorRegionLabel
            // 
            vendorRegionLabel.AutoSize = true;
            vendorRegionLabel.Location = new System.Drawing.Point(310, 81);
            vendorRegionLabel.Name = "vendorRegionLabel";
            vendorRegionLabel.Size = new System.Drawing.Size(87, 15);
            vendorRegionLabel.TabIndex = 32;
            vendorRegionLabel.Text = "Vendor Region:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(310, 110);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(36, 15);
            stateLabel.TabIndex = 34;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(310, 140);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(31, 15);
            cityLabel.TabIndex = 36;
            cityLabel.Text = "City:";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(310, 171);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(58, 15);
            zipCodeLabel.TabIndex = 38;
            zipCodeLabel.Text = "Zip Code:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(310, 202);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(53, 15);
            countryLabel.TabIndex = 40;
            countryLabel.Text = "Country:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new System.Drawing.Point(310, 234);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(84, 15);
            emailAddressLabel.TabIndex = 42;
            emailAddressLabel.Text = "Email Address:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(310, 266);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(91, 15);
            phoneNumberLabel.TabIndex = 44;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // webSiteAddressLabel
            // 
            webSiteAddressLabel.AutoSize = true;
            webSiteAddressLabel.Location = new System.Drawing.Point(310, 293);
            webSiteAddressLabel.Name = "webSiteAddressLabel";
            webSiteAddressLabel.Size = new System.Drawing.Size(101, 15);
            webSiteAddressLabel.TabIndex = 46;
            webSiteAddressLabel.Text = "Web Site Address:";
            // 
            // classificationLabel
            // 
            classificationLabel.AutoSize = true;
            classificationLabel.Location = new System.Drawing.Point(310, 323);
            classificationLabel.Name = "classificationLabel";
            classificationLabel.Size = new System.Drawing.Size(80, 15);
            classificationLabel.TabIndex = 48;
            classificationLabel.Text = "Classification:";
            // 
            // activeStatusLabel
            // 
            activeStatusLabel.AutoSize = true;
            activeStatusLabel.Location = new System.Drawing.Point(310, 353);
            activeStatusLabel.Name = "activeStatusLabel";
            activeStatusLabel.Size = new System.Drawing.Size(78, 15);
            activeStatusLabel.TabIndex = 50;
            activeStatusLabel.Text = "Active Status:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(310, 384);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(41, 15);
            notesLabel.TabIndex = 52;
            notesLabel.Text = "Notes:";
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new System.Drawing.Point(310, 414);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(87, 15);
            contactNameLabel.TabIndex = 54;
            contactNameLabel.Text = "Contact Name:";
            // 
            // vendorList
            // 
            this.vendorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName,
            this.purchaseAmount});
            this.vendorList.Location = new System.Drawing.Point(592, 50);
            this.vendorList.Name = "vendorList";
            this.vendorList.Size = new System.Drawing.Size(268, 407);
            this.vendorList.TabIndex = 56;
            this.vendorList.UseCompatibleStateImageBehavior = false;
            this.vendorList.View = System.Windows.Forms.View.Details;
            // 
            // productName
            // 
            this.productName.Text = "Product Name";
            this.productName.Width = 125;
            // 
            // purchaseAmount
            // 
            this.purchaseAmount.Text = "Purchase Amount";
            this.purchaseAmount.Width = 141;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 503);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(103, 30);
            this.calcButton.TabIndex = 57;
            this.calcButton.Text = "&Calculate";
            this.mainToolTip.SetToolTip(this.calcButton, "Calculates the products YTD total and average purchases");
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(138, 503);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(103, 30);
            this.refreshButton.TabIndex = 58;
            this.refreshButton.Text = "&Refresh";
            this.mainToolTip.SetToolTip(this.refreshButton, "Removes search filter");
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(263, 503);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 30);
            this.exitButton.TabIndex = 59;
            this.exitButton.Text = "E&xit";
            this.mainToolTip.SetToolTip(this.exitButton, "Closes app");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queriesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(880, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsSourcedInTheUSAToolStripMenuItem,
            this.productsSourcedInChinaToolStripMenuItem,
            this.totalCostAndSalesByToolStripMenuItem,
            this.productsPricedOver55ToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // productsSourcedInTheUSAToolStripMenuItem
            // 
            this.productsSourcedInTheUSAToolStripMenuItem.Name = "productsSourcedInTheUSAToolStripMenuItem";
            this.productsSourcedInTheUSAToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.productsSourcedInTheUSAToolStripMenuItem.Text = "Products Sourced in the USA";
            this.productsSourcedInTheUSAToolStripMenuItem.ToolTipText = "Shows only products from the USA";
            this.productsSourcedInTheUSAToolStripMenuItem.Click += new System.EventHandler(this.productsSourcedInTheUSAToolStripMenuItem_Click);
            // 
            // productsSourcedInChinaToolStripMenuItem
            // 
            this.productsSourcedInChinaToolStripMenuItem.Name = "productsSourcedInChinaToolStripMenuItem";
            this.productsSourcedInChinaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.productsSourcedInChinaToolStripMenuItem.Text = "Products Sourced in China";
            this.productsSourcedInChinaToolStripMenuItem.ToolTipText = "Shows only products from China";
            this.productsSourcedInChinaToolStripMenuItem.Click += new System.EventHandler(this.productsSourcedInChinaToolStripMenuItem_Click);
            // 
            // totalCostAndSalesByToolStripMenuItem
            // 
            this.totalCostAndSalesByToolStripMenuItem.Name = "totalCostAndSalesByToolStripMenuItem";
            this.totalCostAndSalesByToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.totalCostAndSalesByToolStripMenuItem.Text = "Total Cost and Sales by Product";
            this.totalCostAndSalesByToolStripMenuItem.ToolTipText = "Shows total cost and sales";
            this.totalCostAndSalesByToolStripMenuItem.Click += new System.EventHandler(this.totalCostAndSalesByToolStripMenuItem_Click);
            // 
            // productsPricedOver55ToolStripMenuItem
            // 
            this.productsPricedOver55ToolStripMenuItem.Name = "productsPricedOver55ToolStripMenuItem";
            this.productsPricedOver55ToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.productsPricedOver55ToolStripMenuItem.Text = "Products Priced Over $55";
            this.productsPricedOver55ToolStripMenuItem.Click += new System.EventHandler(this.productsPricedOver55ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Closes app";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(589, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 60;
            this.label1.Text = "YTD total purchases:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(589, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 62;
            this.label2.Text = "YTD average purchases:";
            // 
            // totalPurchasesLabel
            // 
            this.totalPurchasesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPurchasesLabel.Location = new System.Drawing.Point(736, 469);
            this.totalPurchasesLabel.Name = "totalPurchasesLabel";
            this.totalPurchasesLabel.Size = new System.Drawing.Size(124, 27);
            this.totalPurchasesLabel.TabIndex = 61;
            // 
            // averagePurchasesLabel
            // 
            this.averagePurchasesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averagePurchasesLabel.Location = new System.Drawing.Point(736, 509);
            this.averagePurchasesLabel.Name = "averagePurchasesLabel";
            this.averagePurchasesLabel.Size = new System.Drawing.Size(124, 27);
            this.averagePurchasesLabel.TabIndex = 63;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem,
            this.toolStripDropDownButton1,
            this.searchTextBox,
            this.searchButton});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(880, 25);
            this.productBindingNavigator.TabIndex = 1;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.vendorProductDatabase1DataSet;
            // 
            // vendorProductDatabase1DataSet
            // 
            this.vendorProductDatabase1DataSet.DataSetName = "VendorProductDatabase1DataSet";
            this.vendorProductDatabase1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ToolTipText = "Sort by";
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productNameToolStripMenuItem,
            this.productPriceToolStripMenuItem,
            this.productCostToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortByToolStripMenuItem.Text = "Sort By";
            // 
            // productNameToolStripMenuItem
            // 
            this.productNameToolStripMenuItem.Name = "productNameToolStripMenuItem";
            this.productNameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productNameToolStripMenuItem.Text = "Product Name";
            this.productNameToolStripMenuItem.Click += new System.EventHandler(this.productNameToolStripMenuItem_Click);
            // 
            // productPriceToolStripMenuItem
            // 
            this.productPriceToolStripMenuItem.Name = "productPriceToolStripMenuItem";
            this.productPriceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productPriceToolStripMenuItem.Text = "Product Price";
            this.productPriceToolStripMenuItem.Click += new System.EventHandler(this.productPriceToolStripMenuItem_Click);
            // 
            // productCostToolStripMenuItem
            // 
            this.productCostToolStripMenuItem.Name = "productCostToolStripMenuItem";
            this.productCostToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productCostToolStripMenuItem.Text = "Product Cost";
            this.productCostToolStripMenuItem.Click += new System.EventHandler(this.productCostToolStripMenuItem_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 25);
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            this.searchTextBox.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(23, 22);
            this.searchButton.Text = "Search";
            this.searchButton.ToolTipText = "Filter product name";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(160, 50);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(121, 23);
            this.productIDTextBox.TabIndex = 3;
            this.productIDTextBox.Click += new System.EventHandler(this.productIDTextBox_Click);
            this.productIDTextBox.Enter += new System.EventHandler(this.productIDTextBox_Enter);
            this.productIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productIDTextBox_KeyPress);
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameComboBox.DataSource = this.productBindingSource;
            this.productNameComboBox.DisplayMember = "ProductName";
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(160, 81);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.productNameComboBox.TabIndex = 5;
            this.productNameComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productNameComboBox_KeyPress);
            // 
            // vendorIDComboBox
            // 
            this.vendorIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "VendorID", true));
            this.vendorIDComboBox.DataSource = this.vendorBindingSource;
            this.vendorIDComboBox.DisplayMember = "VendorID";
            this.vendorIDComboBox.FormattingEnabled = true;
            this.vendorIDComboBox.Location = new System.Drawing.Point(160, 110);
            this.vendorIDComboBox.Name = "vendorIDComboBox";
            this.vendorIDComboBox.Size = new System.Drawing.Size(121, 23);
            this.vendorIDComboBox.TabIndex = 7;
            this.vendorIDComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vendorIDComboBox_KeyPress);
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.vendorProductDatabase1DataSet;
            // 
            // productUnitPriceTextBox
            // 
            this.productUnitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductUnitPrice", true));
            this.productUnitPriceTextBox.Location = new System.Drawing.Point(160, 139);
            this.productUnitPriceTextBox.Name = "productUnitPriceTextBox";
            this.productUnitPriceTextBox.Size = new System.Drawing.Size(121, 23);
            this.productUnitPriceTextBox.TabIndex = 9;
            this.productUnitPriceTextBox.Click += new System.EventHandler(this.productUnitPriceTextBox_Click);
            this.productUnitPriceTextBox.Enter += new System.EventHandler(this.productUnitPriceTextBox_Enter);
            this.productUnitPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productUnitPriceTextBox_KeyPress);
            // 
            // productCostTextBox
            // 
            this.productCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCost", true));
            this.productCostTextBox.Location = new System.Drawing.Point(160, 171);
            this.productCostTextBox.Name = "productCostTextBox";
            this.productCostTextBox.Size = new System.Drawing.Size(121, 23);
            this.productCostTextBox.TabIndex = 11;
            this.productCostTextBox.Click += new System.EventHandler(this.productCostTextBox_Click);
            this.productCostTextBox.Enter += new System.EventHandler(this.productCostTextBox_Enter);
            this.productCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productCostTextBox_KeyPress);
            // 
            // quantityOnHandTextBox
            // 
            this.quantityOnHandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "QuantityOnHand", true));
            this.quantityOnHandTextBox.Location = new System.Drawing.Point(160, 234);
            this.quantityOnHandTextBox.Name = "quantityOnHandTextBox";
            this.quantityOnHandTextBox.Size = new System.Drawing.Size(121, 23);
            this.quantityOnHandTextBox.TabIndex = 15;
            this.quantityOnHandTextBox.Click += new System.EventHandler(this.quantityOnHandTextBox_Click);
            this.quantityOnHandTextBox.Enter += new System.EventHandler(this.quantityOnHandTextBox_Enter);
            this.quantityOnHandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityOnHandTextBox_KeyPress);
            // 
            // productLeadTimeTextBox
            // 
            this.productLeadTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductLeadTime", true));
            this.productLeadTimeTextBox.Location = new System.Drawing.Point(160, 263);
            this.productLeadTimeTextBox.Name = "productLeadTimeTextBox";
            this.productLeadTimeTextBox.Size = new System.Drawing.Size(121, 23);
            this.productLeadTimeTextBox.TabIndex = 17;
            this.productLeadTimeTextBox.Click += new System.EventHandler(this.productLeadTimeTextBox_Click);
            this.productLeadTimeTextBox.Enter += new System.EventHandler(this.productLeadTimeTextBox_Enter);
            this.productLeadTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productLeadTimeTextBox_KeyPress);
            // 
            // productReorderLevelTextBox
            // 
            this.productReorderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductReorderLevel", true));
            this.productReorderLevelTextBox.Location = new System.Drawing.Point(160, 293);
            this.productReorderLevelTextBox.Name = "productReorderLevelTextBox";
            this.productReorderLevelTextBox.Size = new System.Drawing.Size(121, 23);
            this.productReorderLevelTextBox.TabIndex = 19;
            this.productReorderLevelTextBox.Click += new System.EventHandler(this.productReorderLevelTextBox_Click);
            this.productReorderLevelTextBox.Enter += new System.EventHandler(this.productReorderLevelTextBox_Enter);
            this.productReorderLevelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productReorderLevelTextBox_KeyPress);
            // 
            // productLineTextBox
            // 
            this.productLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductLine", true));
            this.productLineTextBox.Location = new System.Drawing.Point(160, 323);
            this.productLineTextBox.Name = "productLineTextBox";
            this.productLineTextBox.Size = new System.Drawing.Size(121, 23);
            this.productLineTextBox.TabIndex = 21;
            this.productLineTextBox.Click += new System.EventHandler(this.productLineTextBox_Click);
            this.productLineTextBox.Enter += new System.EventHandler(this.productLineTextBox_Enter);
            this.productLineTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productLineTextBox_KeyPress);
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(160, 353);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(121, 23);
            this.brandTextBox.TabIndex = 23;
            this.brandTextBox.Click += new System.EventHandler(this.brandTextBox_Click);
            this.brandTextBox.Enter += new System.EventHandler(this.brandTextBox_Enter);
            this.brandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.brandTextBox_KeyPress);
            // 
            // discountPercentTextBox
            // 
            this.discountPercentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "DiscountPercent", true));
            this.discountPercentTextBox.Location = new System.Drawing.Point(160, 384);
            this.discountPercentTextBox.Name = "discountPercentTextBox";
            this.discountPercentTextBox.Size = new System.Drawing.Size(121, 23);
            this.discountPercentTextBox.TabIndex = 25;
            this.discountPercentTextBox.Click += new System.EventHandler(this.discountPercentTextBox_Click);
            this.discountPercentTextBox.Enter += new System.EventHandler(this.discountPercentTextBox_Enter);
            this.discountPercentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountPercentTextBox_KeyPress);
            // 
            // yTDPurchasesTextBox
            // 
            this.yTDPurchasesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "YTDPurchases", true));
            this.yTDPurchasesTextBox.Location = new System.Drawing.Point(160, 414);
            this.yTDPurchasesTextBox.Name = "yTDPurchasesTextBox";
            this.yTDPurchasesTextBox.Size = new System.Drawing.Size(121, 23);
            this.yTDPurchasesTextBox.TabIndex = 27;
            this.yTDPurchasesTextBox.Click += new System.EventHandler(this.yTDPurchasesTextBox_Click);
            this.yTDPurchasesTextBox.Enter += new System.EventHandler(this.yTDPurchasesTextBox_Enter);
            this.yTDPurchasesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yTDPurchasesTextBox_KeyPress);
            // 
            // yTDSalesTextBox
            // 
            this.yTDSalesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "YTDSales", true));
            this.yTDSalesTextBox.Location = new System.Drawing.Point(160, 443);
            this.yTDSalesTextBox.Name = "yTDSalesTextBox";
            this.yTDSalesTextBox.Size = new System.Drawing.Size(121, 23);
            this.yTDSalesTextBox.TabIndex = 29;
            this.yTDSalesTextBox.Click += new System.EventHandler(this.yTDSalesTextBox_Click);
            this.yTDSalesTextBox.Enter += new System.EventHandler(this.yTDSalesTextBox_Enter);
            this.yTDSalesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yTDSalesTextBox_KeyPress);
            // 
            // quantityOnOrderTextBox1
            // 
            this.quantityOnOrderTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "QuantityOnOrder", true));
            this.quantityOnOrderTextBox1.Location = new System.Drawing.Point(160, 202);
            this.quantityOnOrderTextBox1.Name = "quantityOnOrderTextBox1";
            this.quantityOnOrderTextBox1.Size = new System.Drawing.Size(121, 23);
            this.quantityOnOrderTextBox1.TabIndex = 13;
            this.quantityOnOrderTextBox1.Click += new System.EventHandler(this.quantityOnOrderTextBox1_Click);
            this.quantityOnOrderTextBox1.Enter += new System.EventHandler(this.quantityOnOrderTextBox1_Enter);
            this.quantityOnOrderTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityOnOrderTextBox1_KeyPress);
            // 
            // vendorNameLabel1
            // 
            this.vendorNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorName", true));
            this.vendorNameLabel1.Location = new System.Drawing.Point(426, 50);
            this.vendorNameLabel1.Name = "vendorNameLabel1";
            this.vendorNameLabel1.Size = new System.Drawing.Size(160, 23);
            this.vendorNameLabel1.TabIndex = 31;
            // 
            // vendorRegionLabel1
            // 
            this.vendorRegionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorRegionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorRegion", true));
            this.vendorRegionLabel1.Location = new System.Drawing.Point(426, 81);
            this.vendorRegionLabel1.Name = "vendorRegionLabel1";
            this.vendorRegionLabel1.Size = new System.Drawing.Size(160, 23);
            this.vendorRegionLabel1.TabIndex = 33;
            // 
            // stateLabel1
            // 
            this.stateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "State", true));
            this.stateLabel1.Location = new System.Drawing.Point(426, 110);
            this.stateLabel1.Name = "stateLabel1";
            this.stateLabel1.Size = new System.Drawing.Size(160, 23);
            this.stateLabel1.TabIndex = 35;
            // 
            // cityLabel1
            // 
            this.cityLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "City", true));
            this.cityLabel1.Location = new System.Drawing.Point(426, 140);
            this.cityLabel1.Name = "cityLabel1";
            this.cityLabel1.Size = new System.Drawing.Size(160, 23);
            this.cityLabel1.TabIndex = 37;
            // 
            // zipCodeLabel1
            // 
            this.zipCodeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zipCodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "ZipCode", true));
            this.zipCodeLabel1.Location = new System.Drawing.Point(426, 170);
            this.zipCodeLabel1.Name = "zipCodeLabel1";
            this.zipCodeLabel1.Size = new System.Drawing.Size(160, 23);
            this.zipCodeLabel1.TabIndex = 39;
            // 
            // countryLabel1
            // 
            this.countryLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Country", true));
            this.countryLabel1.Location = new System.Drawing.Point(426, 202);
            this.countryLabel1.Name = "countryLabel1";
            this.countryLabel1.Size = new System.Drawing.Size(160, 23);
            this.countryLabel1.TabIndex = 41;
            // 
            // emailAddressLabel1
            // 
            this.emailAddressLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailAddressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "EmailAddress", true));
            this.emailAddressLabel1.Location = new System.Drawing.Point(426, 234);
            this.emailAddressLabel1.Name = "emailAddressLabel1";
            this.emailAddressLabel1.Size = new System.Drawing.Size(160, 23);
            this.emailAddressLabel1.TabIndex = 43;
            // 
            // phoneNumberLabel1
            // 
            this.phoneNumberLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumberLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "PhoneNumber", true));
            this.phoneNumberLabel1.Location = new System.Drawing.Point(426, 263);
            this.phoneNumberLabel1.Name = "phoneNumberLabel1";
            this.phoneNumberLabel1.Size = new System.Drawing.Size(160, 23);
            this.phoneNumberLabel1.TabIndex = 45;
            // 
            // webSiteAddressLabel1
            // 
            this.webSiteAddressLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webSiteAddressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "WebSiteAddress", true));
            this.webSiteAddressLabel1.Location = new System.Drawing.Point(426, 293);
            this.webSiteAddressLabel1.Name = "webSiteAddressLabel1";
            this.webSiteAddressLabel1.Size = new System.Drawing.Size(160, 23);
            this.webSiteAddressLabel1.TabIndex = 47;
            // 
            // classificationLabel1
            // 
            this.classificationLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classificationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Classification", true));
            this.classificationLabel1.Location = new System.Drawing.Point(426, 323);
            this.classificationLabel1.Name = "classificationLabel1";
            this.classificationLabel1.Size = new System.Drawing.Size(160, 23);
            this.classificationLabel1.TabIndex = 49;
            // 
            // activeStatusLabel1
            // 
            this.activeStatusLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeStatusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "ActiveStatus", true));
            this.activeStatusLabel1.Location = new System.Drawing.Point(426, 353);
            this.activeStatusLabel1.Name = "activeStatusLabel1";
            this.activeStatusLabel1.Size = new System.Drawing.Size(160, 23);
            this.activeStatusLabel1.TabIndex = 51;
            // 
            // notesLabel1
            // 
            this.notesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Notes", true));
            this.notesLabel1.Location = new System.Drawing.Point(426, 384);
            this.notesLabel1.Name = "notesLabel1";
            this.notesLabel1.Size = new System.Drawing.Size(160, 23);
            this.notesLabel1.TabIndex = 53;
            // 
            // contactNameLabel1
            // 
            this.contactNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "ContactName", true));
            this.contactNameLabel1.Location = new System.Drawing.Point(426, 414);
            this.contactNameLabel1.Name = "contactNameLabel1";
            this.contactNameLabel1.Size = new System.Drawing.Size(160, 23);
            this.contactNameLabel1.TabIndex = 55;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = Major_Assignment_3.VendorProductDatabase1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorTableAdapter = this.vendorTableAdapter;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(880, 556);
            this.Controls.Add(contactNameLabel);
            this.Controls.Add(this.contactNameLabel1);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesLabel1);
            this.Controls.Add(activeStatusLabel);
            this.Controls.Add(this.activeStatusLabel1);
            this.Controls.Add(classificationLabel);
            this.Controls.Add(this.classificationLabel1);
            this.Controls.Add(webSiteAddressLabel);
            this.Controls.Add(this.webSiteAddressLabel1);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberLabel1);
            this.Controls.Add(emailAddressLabel);
            this.Controls.Add(this.emailAddressLabel1);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryLabel1);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeLabel1);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityLabel1);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateLabel1);
            this.Controls.Add(vendorRegionLabel);
            this.Controls.Add(this.vendorRegionLabel1);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.vendorNameLabel1);
            this.Controls.Add(quantityOnOrderLabel1);
            this.Controls.Add(this.quantityOnOrderTextBox1);
            this.Controls.Add(yTDSalesLabel);
            this.Controls.Add(this.yTDSalesTextBox);
            this.Controls.Add(yTDPurchasesLabel);
            this.Controls.Add(this.yTDPurchasesTextBox);
            this.Controls.Add(discountPercentLabel);
            this.Controls.Add(this.discountPercentTextBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(productLineLabel);
            this.Controls.Add(this.productLineTextBox);
            this.Controls.Add(productReorderLevelLabel);
            this.Controls.Add(this.productReorderLevelTextBox);
            this.Controls.Add(productLeadTimeLabel);
            this.Controls.Add(this.productLeadTimeTextBox);
            this.Controls.Add(quantityOnHandLabel);
            this.Controls.Add(this.quantityOnHandTextBox);
            this.Controls.Add(productCostLabel);
            this.Controls.Add(this.productCostTextBox);
            this.Controls.Add(productUnitPriceLabel);
            this.Controls.Add(this.productUnitPriceTextBox);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDComboBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.productBindingNavigator);
            this.Controls.Add(this.averagePurchasesLabel);
            this.Controls.Add(this.totalPurchasesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.vendorList);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Vendor and Product Database App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProductDatabase1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vendorList;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsSourcedInTheUSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsSourcedInChinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalCostAndSalesByToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader purchaseAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalPurchasesLabel;
        private System.Windows.Forms.Label averagePurchasesLabel;
        private System.Windows.Forms.ToolTip mainToolTip;
        private VendorProductDatabase1DataSet vendorProductDatabase1DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private VendorProductDatabase1DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private VendorProductDatabase1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.ComboBox vendorIDComboBox;
        private System.Windows.Forms.TextBox productUnitPriceTextBox;
        private System.Windows.Forms.TextBox productCostTextBox;
        private System.Windows.Forms.TextBox quantityOnHandTextBox;
        private System.Windows.Forms.TextBox productLeadTimeTextBox;
        private System.Windows.Forms.TextBox productReorderLevelTextBox;
        private VendorProductDatabase1DataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.TextBox productLineTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox discountPercentTextBox;
        private System.Windows.Forms.TextBox yTDPurchasesTextBox;
        private System.Windows.Forms.TextBox yTDSalesTextBox;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.TextBox quantityOnOrderTextBox1;
        private System.Windows.Forms.Label vendorNameLabel1;
        private System.Windows.Forms.Label vendorRegionLabel1;
        private System.Windows.Forms.Label stateLabel1;
        private System.Windows.Forms.Label cityLabel1;
        private System.Windows.Forms.Label zipCodeLabel1;
        private System.Windows.Forms.Label countryLabel1;
        private System.Windows.Forms.Label emailAddressLabel1;
        private System.Windows.Forms.Label phoneNumberLabel1;
        private System.Windows.Forms.Label webSiteAddressLabel1;
        private System.Windows.Forms.Label classificationLabel1;
        private System.Windows.Forms.Label activeStatusLabel1;
        private System.Windows.Forms.Label notesLabel1;
        private System.Windows.Forms.Label contactNameLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripMenuItem productsPricedOver55ToolStripMenuItem;
    }
}

