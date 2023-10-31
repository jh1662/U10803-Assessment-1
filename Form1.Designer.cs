namespace U10803___Assessment_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            introTab = new TabPage();
            richTextBox1 = new RichTextBox();
            tabCheckout = new TabPage();
            tabCustomers = new TabPage();
            tabSuppliers = new TabPage();
            tabControlSupplier = new TabControl();
            tabPage3 = new TabPage();
            groupBox4 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            textboxSupplierOrderSupplier = new TextBox();
            textboxSupplierOrderItem = new TextBox();
            textboxSupplierOrderQty = new TextBox();
            ButtonSupplierOrder = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            textboxSupplierRestockSupplier = new TextBox();
            textboxSupplierRestockItem = new TextBox();
            textboxSupplierRestockQty = new TextBox();
            ButtonSupplierRestock = new Button();
            tabPage4 = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            label11 = new Label();
            label12 = new Label();
            labelSupplierViewName = new Label();
            labelSupplierViewStock = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label9 = new Label();
            textboxSupplierAdd = new TextBox();
            buttonSupplierAdd = new Button();
            Storage = new TabPage();
            tableStorageItems = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelStorageListName = new Label();
            labelStorageListPrice = new Label();
            labelStorageListStock = new Label();
            labelStorageListUnique = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label4 = new Label();
            comboboxStorageType = new ComboBox();
            comboboxStorageSort = new ComboBox();
            tabAdd = new TabPage();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            textboxAddDetails = new TextBox();
            labelAddDetails = new Label();
            buttonAddSubmit = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            label10 = new Label();
            comboboxAddType = new ComboBox();
            comboboxAddExtra = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            tabPage1 = new TabPage();
            tabControl.SuspendLayout();
            introTab.SuspendLayout();
            tabSuppliers.SuspendLayout();
            tabControlSupplier.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            Storage.SuspendLayout();
            tableStorageItems.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabAdd.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(introTab);
            tabControl.Controls.Add(tabCheckout);
            tabControl.Controls.Add(tabCustomers);
            tabControl.Controls.Add(tabSuppliers);
            tabControl.Controls.Add(Storage);
            tabControl.Controls.Add(tabAdd);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(941, 466);
            tabControl.TabIndex = 0;
            // 
            // introTab
            // 
            introTab.Controls.Add(richTextBox1);
            introTab.Location = new Point(4, 29);
            introTab.Name = "introTab";
            introTab.Padding = new Padding(3);
            introTab.Size = new Size(933, 433);
            introTab.TabIndex = 0;
            introTab.Text = "Introduction";
            introTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(927, 427);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "This is a manual. The program is made to be understandable, but if one still does not understand then this manual will help you!";
            // 
            // tabCheckout
            // 
            tabCheckout.Location = new Point(4, 29);
            tabCheckout.Name = "tabCheckout";
            tabCheckout.Padding = new Padding(3);
            tabCheckout.Size = new Size(933, 433);
            tabCheckout.TabIndex = 1;
            tabCheckout.Text = "Checkout";
            tabCheckout.UseVisualStyleBackColor = true;
            // 
            // tabCustomers
            // 
            tabCustomers.Location = new Point(4, 29);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new Padding(3);
            tabCustomers.Size = new Size(933, 433);
            tabCustomers.TabIndex = 2;
            tabCustomers.Text = "Customers";
            tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tabSuppliers
            // 
            tabSuppliers.Controls.Add(tabControlSupplier);
            tabSuppliers.Location = new Point(4, 29);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Padding = new Padding(3);
            tabSuppliers.Size = new Size(933, 433);
            tabSuppliers.TabIndex = 3;
            tabSuppliers.Text = "Suppliers";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // tabControlSupplier
            // 
            tabControlSupplier.Controls.Add(tabPage3);
            tabControlSupplier.Controls.Add(tabPage4);
            tabControlSupplier.Dock = DockStyle.Fill;
            tabControlSupplier.Location = new Point(3, 3);
            tabControlSupplier.Margin = new Padding(3, 4, 3, 4);
            tabControlSupplier.Name = "tabControlSupplier";
            tabControlSupplier.SelectedIndex = 0;
            tabControlSupplier.Size = new Size(927, 427);
            tabControlSupplier.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(919, 394);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "order and restock items";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel7);
            groupBox4.Controls.Add(ButtonSupplierOrder);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(3, 199);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(913, 191);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "order";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9453831F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.05462F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel7.Controls.Add(label16, 0, 2);
            tableLayoutPanel7.Controls.Add(label17, 0, 1);
            tableLayoutPanel7.Controls.Add(label18, 0, 0);
            tableLayoutPanel7.Controls.Add(textboxSupplierOrderSupplier, 1, 0);
            tableLayoutPanel7.Controls.Add(textboxSupplierOrderItem, 1, 1);
            tableLayoutPanel7.Controls.Add(textboxSupplierOrderQty, 1, 2);
            tableLayoutPanel7.Dock = DockStyle.Top;
            tableLayoutPanel7.Location = new Point(3, 23);
            tableLayoutPanel7.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel7.Size = new Size(907, 132);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 88);
            label16.Name = "label16";
            label16.Size = new Size(68, 20);
            label16.TabIndex = 5;
            label16.Text = "Quantity:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 43);
            label17.Name = "label17";
            label17.Size = new Size(83, 20);
            label17.TabIndex = 3;
            label17.Text = "Item name:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 0);
            label18.Name = "label18";
            label18.Size = new Size(127, 20);
            label18.TabIndex = 0;
            label18.Text = "Name of supplier:";
            // 
            // textboxSupplierOrderSupplier
            // 
            textboxSupplierOrderSupplier.Location = new Point(165, 4);
            textboxSupplierOrderSupplier.Margin = new Padding(3, 4, 3, 4);
            textboxSupplierOrderSupplier.Name = "textboxSupplierOrderSupplier";
            textboxSupplierOrderSupplier.Size = new Size(488, 27);
            textboxSupplierOrderSupplier.TabIndex = 1;
            // 
            // textboxSupplierOrderItem
            // 
            textboxSupplierOrderItem.Location = new Point(165, 47);
            textboxSupplierOrderItem.Margin = new Padding(3, 4, 3, 4);
            textboxSupplierOrderItem.Name = "textboxSupplierOrderItem";
            textboxSupplierOrderItem.Size = new Size(488, 27);
            textboxSupplierOrderItem.TabIndex = 4;
            // 
            // textboxSupplierOrderQty
            // 
            textboxSupplierOrderQty.Location = new Point(165, 92);
            textboxSupplierOrderQty.Margin = new Padding(3, 4, 3, 4);
            textboxSupplierOrderQty.Name = "textboxSupplierOrderQty";
            textboxSupplierOrderQty.Size = new Size(488, 27);
            textboxSupplierOrderQty.TabIndex = 6;
            // 
            // ButtonSupplierOrder
            // 
            ButtonSupplierOrder.Dock = DockStyle.Bottom;
            ButtonSupplierOrder.Location = new Point(3, 159);
            ButtonSupplierOrder.Name = "ButtonSupplierOrder";
            ButtonSupplierOrder.Size = new Size(907, 29);
            ButtonSupplierOrder.TabIndex = 2;
            ButtonSupplierOrder.Text = "order item";
            ButtonSupplierOrder.UseVisualStyleBackColor = true;
            ButtonSupplierOrder.Click += ButtonSupplierOrder_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel6);
            groupBox3.Controls.Add(ButtonSupplierRestock);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(913, 191);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "restock";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9453831F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.05462F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel6.Controls.Add(label15, 0, 2);
            tableLayoutPanel6.Controls.Add(label14, 0, 1);
            tableLayoutPanel6.Controls.Add(label13, 0, 0);
            tableLayoutPanel6.Controls.Add(textboxSupplierRestockSupplier, 1, 0);
            tableLayoutPanel6.Controls.Add(textboxSupplierRestockItem, 1, 1);
            tableLayoutPanel6.Controls.Add(textboxSupplierRestockQty, 1, 2);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(3, 23);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel6.Size = new Size(907, 132);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 88);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 5;
            label15.Text = "Quantity:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 43);
            label14.Name = "label14";
            label14.Size = new Size(83, 20);
            label14.TabIndex = 3;
            label14.Text = "Item name:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(127, 20);
            label13.TabIndex = 0;
            label13.Text = "Name of supplier:";
            // 
            // textboxSupplierRestockSupplier
            // 
            textboxSupplierRestockSupplier.Location = new Point(165, 4);
            textboxSupplierRestockSupplier.Margin = new Padding(3, 4, 3, 4);
            textboxSupplierRestockSupplier.Name = "textboxSupplierRestockSupplier";
            textboxSupplierRestockSupplier.Size = new Size(488, 27);
            textboxSupplierRestockSupplier.TabIndex = 1;
            // 
            // textboxSupplierRestockItem
            // 
            textboxSupplierRestockItem.Location = new Point(165, 47);
            textboxSupplierRestockItem.Margin = new Padding(3, 4, 3, 4);
            textboxSupplierRestockItem.Name = "textboxSupplierRestockItem";
            textboxSupplierRestockItem.Size = new Size(488, 27);
            textboxSupplierRestockItem.TabIndex = 4;
            // 
            // textboxSupplierRestockQty
            // 
            textboxSupplierRestockQty.Location = new Point(165, 92);
            textboxSupplierRestockQty.Margin = new Padding(3, 4, 3, 4);
            textboxSupplierRestockQty.Name = "textboxSupplierRestockQty";
            textboxSupplierRestockQty.Size = new Size(488, 27);
            textboxSupplierRestockQty.TabIndex = 6;
            // 
            // ButtonSupplierRestock
            // 
            ButtonSupplierRestock.Dock = DockStyle.Bottom;
            ButtonSupplierRestock.Location = new Point(3, 159);
            ButtonSupplierRestock.Name = "ButtonSupplierRestock";
            ButtonSupplierRestock.Size = new Size(907, 29);
            ButtonSupplierRestock.TabIndex = 2;
            ButtonSupplierRestock.Text = "restock item";
            ButtonSupplierRestock.UseVisualStyleBackColor = true;
            ButtonSupplierRestock.Click += ButtonSupplierRestock_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel5);
            tabPage4.Controls.Add(tableLayoutPanel4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(919, 394);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "view & add suppliers";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.762785F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.23721F));
            tableLayoutPanel5.Controls.Add(label11, 0, 0);
            tableLayoutPanel5.Controls.Add(label12, 1, 0);
            tableLayoutPanel5.Controls.Add(labelSupplierViewName, 0, 1);
            tableLayoutPanel5.Controls.Add(labelSupplierViewStock, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 45);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.2275133F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 86.7724838F));
            tableLayoutPanel5.Size = new Size(919, 349);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 0;
            label11.Text = "Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(203, 0);
            label12.Name = "label12";
            label12.Size = new Size(103, 20);
            label12.TabIndex = 1;
            label12.Text = "ordered stock:";
            // 
            // labelSupplierViewName
            // 
            labelSupplierViewName.AutoSize = true;
            labelSupplierViewName.Location = new Point(3, 46);
            labelSupplierViewName.Name = "labelSupplierViewName";
            labelSupplierViewName.Size = new Size(36, 20);
            labelSupplierViewName.TabIndex = 2;
            labelSupplierViewName.Text = "N/A";
            // 
            // labelSupplierViewStock
            // 
            labelSupplierViewStock.AutoSize = true;
            labelSupplierViewStock.Location = new Point(203, 46);
            labelSupplierViewStock.Name = "labelSupplierViewStock";
            labelSupplierViewStock.Size = new Size(36, 20);
            labelSupplierViewStock.TabIndex = 3;
            labelSupplierViewStock.Text = "N/A";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.838541F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.16146F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(label9, 0, 0);
            tableLayoutPanel4.Controls.Add(textboxSupplierAdd, 1, 0);
            tableLayoutPanel4.Controls.Add(buttonSupplierAdd, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(919, 45);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(131, 45);
            label9.TabIndex = 0;
            label9.Text = "Name of supplier:";
            // 
            // textboxSupplierAdd
            // 
            textboxSupplierAdd.Dock = DockStyle.Fill;
            textboxSupplierAdd.Location = new Point(140, 4);
            textboxSupplierAdd.Margin = new Padding(3, 4, 3, 4);
            textboxSupplierAdd.Name = "textboxSupplierAdd";
            textboxSupplierAdd.Size = new Size(625, 27);
            textboxSupplierAdd.TabIndex = 1;
            // 
            // buttonSupplierAdd
            // 
            buttonSupplierAdd.Dock = DockStyle.Fill;
            buttonSupplierAdd.Location = new Point(771, 4);
            buttonSupplierAdd.Margin = new Padding(3, 4, 3, 4);
            buttonSupplierAdd.Name = "buttonSupplierAdd";
            buttonSupplierAdd.Size = new Size(145, 37);
            buttonSupplierAdd.TabIndex = 2;
            buttonSupplierAdd.Text = "add supplier";
            buttonSupplierAdd.UseVisualStyleBackColor = true;
            buttonSupplierAdd.Click += buttonSupplierAdd_Click;
            // 
            // Storage
            // 
            Storage.Controls.Add(tableStorageItems);
            Storage.Controls.Add(tableLayoutPanel1);
            Storage.Location = new Point(4, 29);
            Storage.Name = "Storage";
            Storage.Padding = new Padding(3);
            Storage.Size = new Size(933, 433);
            Storage.TabIndex = 4;
            Storage.Text = "Storage";
            Storage.UseVisualStyleBackColor = true;
            // 
            // tableStorageItems
            // 
            tableStorageItems.AutoScroll = true;
            tableStorageItems.AutoSize = true;
            tableStorageItems.ColumnCount = 4;
            tableStorageItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.91379F));
            tableStorageItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.08621F));
            tableStorageItems.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableStorageItems.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 394F));
            tableStorageItems.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 387F));
            tableStorageItems.Controls.Add(label5, 3, 0);
            tableStorageItems.Controls.Add(label6, 2, 0);
            tableStorageItems.Controls.Add(label7, 1, 0);
            tableStorageItems.Controls.Add(label8, 0, 0);
            tableStorageItems.Controls.Add(labelStorageListName, 0, 1);
            tableStorageItems.Controls.Add(labelStorageListPrice, 1, 1);
            tableStorageItems.Controls.Add(labelStorageListStock, 2, 1);
            tableStorageItems.Controls.Add(labelStorageListUnique, 3, 1);
            tableStorageItems.Dock = DockStyle.Fill;
            tableStorageItems.Location = new Point(3, 96);
            tableStorageItems.Margin = new Padding(3, 4, 3, 4);
            tableStorageItems.Name = "tableStorageItems";
            tableStorageItems.RowCount = 2;
            tableStorageItems.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableStorageItems.RowStyles.Add(new RowStyle(SizeType.Absolute, 285F));
            tableStorageItems.Size = new Size(927, 334);
            tableStorageItems.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(535, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 0;
            label5.Text = "[unique properties]:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 1;
            label6.Text = "Stock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 2;
            label7.Text = "Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 3;
            label8.Text = "Name:";
            // 
            // labelStorageListName
            // 
            labelStorageListName.AutoSize = true;
            labelStorageListName.Dock = DockStyle.Fill;
            labelStorageListName.Location = new Point(3, 49);
            labelStorageListName.Name = "labelStorageListName";
            labelStorageListName.Size = new Size(240, 285);
            labelStorageListName.TabIndex = 4;
            labelStorageListName.Text = "N/A";
            // 
            // labelStorageListPrice
            // 
            labelStorageListPrice.AutoSize = true;
            labelStorageListPrice.Dock = DockStyle.Fill;
            labelStorageListPrice.Location = new Point(249, 49);
            labelStorageListPrice.Name = "labelStorageListPrice";
            labelStorageListPrice.Size = new Size(158, 285);
            labelStorageListPrice.TabIndex = 5;
            labelStorageListPrice.Text = "N/A";
            // 
            // labelStorageListStock
            // 
            labelStorageListStock.AutoSize = true;
            labelStorageListStock.Dock = DockStyle.Fill;
            labelStorageListStock.Location = new Point(413, 49);
            labelStorageListStock.Name = "labelStorageListStock";
            labelStorageListStock.Size = new Size(116, 285);
            labelStorageListStock.TabIndex = 6;
            labelStorageListStock.Text = "N/A";
            // 
            // labelStorageListUnique
            // 
            labelStorageListUnique.AutoSize = true;
            labelStorageListUnique.Dock = DockStyle.Fill;
            labelStorageListUnique.Location = new Point(535, 49);
            labelStorageListUnique.Name = "labelStorageListUnique";
            labelStorageListUnique.Size = new Size(389, 285);
            labelStorageListUnique.TabIndex = 7;
            labelStorageListUnique.Text = "N/A";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0366974F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.9633F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(comboboxStorageType, 1, 0);
            tableLayoutPanel1.Controls.Add(comboboxStorageSort, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(927, 93);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 42);
            label1.TabIndex = 2;
            label1.Text = "Type of item:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 42);
            label4.Name = "label4";
            label4.Size = new Size(170, 51);
            label4.TabIndex = 4;
            label4.Text = "Sort by:";
            // 
            // comboboxStorageType
            // 
            comboboxStorageType.Dock = DockStyle.Fill;
            comboboxStorageType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxStorageType.FormattingEnabled = true;
            comboboxStorageType.Items.AddRange(new object[] { "Shoe", "Clothing", "Accessory" });
            comboboxStorageType.Location = new Point(179, 4);
            comboboxStorageType.Margin = new Padding(3, 4, 3, 4);
            comboboxStorageType.Name = "comboboxStorageType";
            comboboxStorageType.Size = new Size(745, 28);
            comboboxStorageType.TabIndex = 7;
            comboboxStorageType.SelectedIndexChanged += comboboxStorageType_SelectedIndexChanged;
            // 
            // comboboxStorageSort
            // 
            comboboxStorageSort.Dock = DockStyle.Fill;
            comboboxStorageSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxStorageSort.FormattingEnabled = true;
            comboboxStorageSort.Items.AddRange(new object[] { "Name", "Stock", "Price" });
            comboboxStorageSort.Location = new Point(179, 46);
            comboboxStorageSort.Margin = new Padding(3, 4, 3, 4);
            comboboxStorageSort.Name = "comboboxStorageSort";
            comboboxStorageSort.Size = new Size(745, 28);
            comboboxStorageSort.TabIndex = 8;
            comboboxStorageSort.SelectedIndexChanged += comboboxStorageSort_SelectedIndexChanged;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(groupBox2);
            tabAdd.Controls.Add(tableLayoutPanel3);
            tabAdd.Location = new Point(4, 29);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.Size = new Size(933, 433);
            tabAdd.TabIndex = 5;
            tabAdd.Text = "Add new items";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(buttonAddSubmit);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 100);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(927, 330);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textboxAddDetails);
            groupBox1.Controls.Add(labelAddDetails);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 24);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(921, 84);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter details:";
            // 
            // textboxAddDetails
            // 
            textboxAddDetails.Dock = DockStyle.Bottom;
            textboxAddDetails.Location = new Point(3, 53);
            textboxAddDetails.Margin = new Padding(3, 4, 3, 4);
            textboxAddDetails.Name = "textboxAddDetails";
            textboxAddDetails.Size = new Size(915, 27);
            textboxAddDetails.TabIndex = 1;
            // 
            // labelAddDetails
            // 
            labelAddDetails.AutoSize = true;
            labelAddDetails.Dock = DockStyle.Top;
            labelAddDetails.Location = new Point(3, 24);
            labelAddDetails.Name = "labelAddDetails";
            labelAddDetails.RightToLeft = RightToLeft.No;
            labelAddDetails.Size = new Size(138, 20);
            labelAddDetails.TabIndex = 0;
            labelAddDetails.Text = "Name, Stock, Price, ";
            // 
            // buttonAddSubmit
            // 
            buttonAddSubmit.Dock = DockStyle.Bottom;
            buttonAddSubmit.Location = new Point(3, 108);
            buttonAddSubmit.Margin = new Padding(3, 4, 3, 4);
            buttonAddSubmit.Name = "buttonAddSubmit";
            buttonAddSubmit.Size = new Size(921, 218);
            buttonAddSubmit.TabIndex = 4;
            buttonAddSubmit.Text = "submit";
            buttonAddSubmit.UseVisualStyleBackColor = true;
            buttonAddSubmit.Click += buttonAddSubmit_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0366974F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.9633F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(label10, 0, 1);
            tableLayoutPanel3.Controls.Add(comboboxAddType, 1, 0);
            tableLayoutPanel3.Controls.Add(comboboxAddExtra, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel3.Size = new Size(927, 97);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 45);
            label3.TabIndex = 2;
            label3.Text = "Type of item:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(3, 45);
            label10.Name = "label10";
            label10.Size = new Size(170, 52);
            label10.TabIndex = 4;
            label10.Text = "[Disabled]";
            // 
            // comboboxAddType
            // 
            comboboxAddType.Dock = DockStyle.Fill;
            comboboxAddType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxAddType.FormattingEnabled = true;
            comboboxAddType.Items.AddRange(new object[] { "Shoe", "Clothing", "Accessory" });
            comboboxAddType.Location = new Point(179, 4);
            comboboxAddType.Margin = new Padding(3, 4, 3, 4);
            comboboxAddType.Name = "comboboxAddType";
            comboboxAddType.Size = new Size(745, 28);
            comboboxAddType.TabIndex = 7;
            comboboxAddType.SelectedIndexChanged += comboboxAddType_SelectedIndexChanged;
            // 
            // comboboxAddExtra
            // 
            comboboxAddExtra.Dock = DockStyle.Fill;
            comboboxAddExtra.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxAddExtra.Enabled = false;
            comboboxAddExtra.FormattingEnabled = true;
            comboboxAddExtra.Items.AddRange(new object[] { "Name", "Stock", "Price" });
            comboboxAddExtra.Location = new Point(179, 49);
            comboboxAddExtra.Margin = new Padding(3, 4, 3, 4);
            comboboxAddExtra.Name = "comboboxAddExtra";
            comboboxAddExtra.Size = new Size(745, 28);
            comboboxAddExtra.TabIndex = 8;
            comboboxAddExtra.SelectedIndexChanged += comboboxAddExtra_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.88755F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.11245F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 100);
            label2.TabIndex = 2;
            label2.Text = "Type of item:";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Shoes", "Clothing", "Assesories" });
            comboBox1.Location = new Point(46, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 100);
            tabPage1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 466);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            introTab.ResumeLayout(false);
            tabSuppliers.ResumeLayout(false);
            tabControlSupplier.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tabPage4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            Storage.ResumeLayout(false);
            Storage.PerformLayout();
            tableStorageItems.ResumeLayout(false);
            tableStorageItems.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabAdd.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage introTab;
        private TabPage tabCheckout;
        private TabPage tabCustomers;
        private TabPage tabSuppliers;
        private TabPage Storage;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabAdd;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private ComboBox comboBox1;
        private TabPage tabPage1;
        private Label label4;
        private TableLayoutPanel tableStorageItems;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboboxStorageType;
        private ComboBox comboboxStorageSort;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label10;
        private ComboBox comboboxAddType;
        private ComboBox comboboxAddExtra;
        private GroupBox groupBox1;
        private Label labelAddDetails;
        private GroupBox groupBox2;
        private TextBox textboxAddDetails;
        private Button buttonAddSubmit;
        private RichTextBox richTextBox1;
        private Label labelStorageListName;
        private Label labelStorageListPrice;
        private Label labelStorageListStock;
        private Label labelStorageListUnique;
        private TabControl tabControlSupplier;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label9;
        private TextBox textboxSupplierAdd;
        private Button buttonSupplierAdd;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label11;
        private Label label12;
        private Label labelSupplierViewName;
        private Label labelSupplierViewStock;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox textboxSupplierRestockSupplier;
        private TextBox textboxSupplierRestockItem;
        private TextBox textboxSupplierRestockQty;
        private Button ButtonSupplierRestock;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox textboxSupplierOrderSupplier;
        private TextBox textboxSupplierOrderItem;
        private TextBox textboxSupplierOrderQty;
        private GroupBox groupBox3;
        private Button ButtonSupplierOrder;
    }
}