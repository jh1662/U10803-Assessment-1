﻿namespace U10803___Assessment_1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tabControl = new TabControl();
            introTab = new TabPage();
            richTextBox1 = new RichTextBox();
            tabCheckout = new TabPage();
            tabCustomers = new TabPage();
            tabSuppliers = new TabPage();
            Storage = new TabPage();
            tableStorageItems = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label4 = new Label();
            label9 = new Label();
            comboboxStorageType = new ComboBox();
            comboboxStorageSort = new ComboBox();
            comboboxStorageExtrafilter = new ComboBox();
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
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(700, 338);
            tabControl.TabIndex = 0;
            // 
            // introTab
            // 
            introTab.Controls.Add(richTextBox1);
            introTab.Location = new Point(4, 24);
            introTab.Margin = new Padding(3, 2, 3, 2);
            introTab.Name = "introTab";
            introTab.Padding = new Padding(3, 2, 3, 2);
            introTab.Size = new Size(692, 310);
            introTab.TabIndex = 0;
            introTab.Text = "Introduction";
            introTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(686, 306);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tabCheckout
            // 
            tabCheckout.Location = new Point(4, 24);
            tabCheckout.Margin = new Padding(3, 2, 3, 2);
            tabCheckout.Name = "tabCheckout";
            tabCheckout.Padding = new Padding(3, 2, 3, 2);
            tabCheckout.Size = new Size(692, 310);
            tabCheckout.TabIndex = 1;
            tabCheckout.Text = "Checkout";
            tabCheckout.UseVisualStyleBackColor = true;
            // 
            // tabCustomers
            // 
            tabCustomers.Location = new Point(4, 24);
            tabCustomers.Margin = new Padding(3, 2, 3, 2);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new Padding(3, 2, 3, 2);
            tabCustomers.Size = new Size(692, 310);
            tabCustomers.TabIndex = 2;
            tabCustomers.Text = "Customers";
            tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tabSuppliers
            // 
            tabSuppliers.Location = new Point(4, 24);
            tabSuppliers.Margin = new Padding(3, 2, 3, 2);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Padding = new Padding(3, 2, 3, 2);
            tabSuppliers.Size = new Size(692, 310);
            tabSuppliers.TabIndex = 3;
            tabSuppliers.Text = "Suppliers";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // Storage
            // 
            Storage.Controls.Add(tableStorageItems);
            Storage.Controls.Add(tableLayoutPanel1);
            Storage.Location = new Point(4, 24);
            Storage.Margin = new Padding(3, 2, 3, 2);
            Storage.Name = "Storage";
            Storage.Padding = new Padding(3, 2, 3, 2);
            Storage.Size = new Size(692, 310);
            Storage.TabIndex = 4;
            Storage.Text = "Storage";
            Storage.UseVisualStyleBackColor = true;
            // 
            // tableStorageItems
            // 
            tableStorageItems.ColumnCount = 4;
            tableStorageItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.91379F));
            tableStorageItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.08621F));
            tableStorageItems.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            tableStorageItems.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 342F));
            tableStorageItems.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 339F));
            tableStorageItems.Controls.Add(label5, 3, 0);
            tableStorageItems.Controls.Add(label6, 2, 0);
            tableStorageItems.Controls.Add(label7, 1, 0);
            tableStorageItems.Controls.Add(label8, 0, 0);
            tableStorageItems.Dock = DockStyle.Bottom;
            tableStorageItems.Location = new Point(3, 122);
            tableStorageItems.Name = "tableStorageItems";
            tableStorageItems.RowCount = 2;
            tableStorageItems.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableStorageItems.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            tableStorageItems.Size = new Size(686, 186);
            tableStorageItems.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 0;
            label5.Text = "[unique properties]:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 1;
            label6.Text = "Stock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(144, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 2;
            label7.Text = "Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 3;
            label8.Text = "Name:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0366974F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.9633F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label9, 0, 2);
            tableLayoutPanel1.Controls.Add(comboboxStorageType, 1, 0);
            tableLayoutPanel1.Controls.Add(comboboxStorageSort, 1, 1);
            tableLayoutPanel1.Controls.Add(comboboxStorageExtrafilter, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(686, 115);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 41);
            label1.TabIndex = 2;
            label1.Text = "Type of item:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 41);
            label4.Name = "label4";
            label4.Size = new Size(124, 38);
            label4.TabIndex = 4;
            label4.Text = "Sort by:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 79);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 6;
            label9.Text = "[disabled]";
            // 
            // comboboxStorageType
            // 
            comboboxStorageType.Dock = DockStyle.Fill;
            comboboxStorageType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxStorageType.FormattingEnabled = true;
            comboboxStorageType.Items.AddRange(new object[] { "Shoe", "Clothing", "Accessory" });
            comboboxStorageType.Location = new Point(133, 3);
            comboboxStorageType.Name = "comboboxStorageType";
            comboboxStorageType.Size = new Size(550, 23);
            comboboxStorageType.TabIndex = 7;
            comboboxStorageType.SelectedIndexChanged += comboboxStorageType_SelectedIndexChanged;
            // 
            // comboboxStorageSort
            // 
            comboboxStorageSort.Dock = DockStyle.Fill;
            comboboxStorageSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxStorageSort.FormattingEnabled = true;
            comboboxStorageSort.Items.AddRange(new object[] { "Name", "Stock", "Price" });
            comboboxStorageSort.Location = new Point(133, 44);
            comboboxStorageSort.Name = "comboboxStorageSort";
            comboboxStorageSort.Size = new Size(550, 23);
            comboboxStorageSort.TabIndex = 8;
            comboboxStorageSort.SelectedIndexChanged += comboboxStorageSort_SelectedIndexChanged;
            // 
            // comboboxStorageExtrafilter
            // 
            comboboxStorageExtrafilter.Dock = DockStyle.Fill;
            comboboxStorageExtrafilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxStorageExtrafilter.Enabled = false;
            comboboxStorageExtrafilter.FormattingEnabled = true;
            comboboxStorageExtrafilter.Items.AddRange(new object[] { "ALL", "Bag", "Watch", "Drink" });
            comboboxStorageExtrafilter.Location = new Point(133, 82);
            comboboxStorageExtrafilter.Name = "comboboxStorageExtrafilter";
            comboboxStorageExtrafilter.Size = new Size(550, 23);
            comboboxStorageExtrafilter.TabIndex = 9;
            comboboxStorageExtrafilter.SelectedIndexChanged += comboboxStorageExtrafilter_SelectedIndexChanged;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(groupBox2);
            tabAdd.Controls.Add(tableLayoutPanel3);
            tabAdd.Location = new Point(4, 24);
            tabAdd.Margin = new Padding(3, 2, 3, 2);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3, 2, 3, 2);
            tabAdd.Size = new Size(692, 310);
            tabAdd.TabIndex = 5;
            tabAdd.Text = "Add new items";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(buttonAddSubmit);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(686, 228);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textboxAddDetails);
            groupBox1.Controls.Add(labelAddDetails);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 72);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter details:";
            // 
            // textboxAddDetails
            // 
            textboxAddDetails.Dock = DockStyle.Bottom;
            textboxAddDetails.Location = new Point(3, 46);
            textboxAddDetails.Name = "textboxAddDetails";
            textboxAddDetails.Size = new Size(674, 23);
            textboxAddDetails.TabIndex = 1;
            // 
            // labelAddDetails
            // 
            labelAddDetails.AutoSize = true;
            labelAddDetails.Dock = DockStyle.Top;
            labelAddDetails.Location = new Point(3, 19);
            labelAddDetails.Name = "labelAddDetails";
            labelAddDetails.RightToLeft = RightToLeft.No;
            labelAddDetails.Size = new Size(112, 15);
            labelAddDetails.TabIndex = 0;
            labelAddDetails.Text = "Name, Stock, Price, ";
            // 
            // buttonAddSubmit
            // 
            buttonAddSubmit.Dock = DockStyle.Bottom;
            buttonAddSubmit.Location = new Point(3, 139);
            buttonAddSubmit.Name = "buttonAddSubmit";
            buttonAddSubmit.Size = new Size(680, 86);
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
            tableLayoutPanel3.Location = new Point(3, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.Size = new Size(686, 73);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 35);
            label3.TabIndex = 2;
            label3.Text = "Type of item:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(3, 35);
            label10.Name = "label10";
            label10.Size = new Size(124, 38);
            label10.TabIndex = 4;
            label10.Text = "[Disabled]";
            // 
            // comboboxAddType
            // 
            comboboxAddType.Dock = DockStyle.Fill;
            comboboxAddType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxAddType.FormattingEnabled = true;
            comboboxAddType.Items.AddRange(new object[] { "Shoe", "Clothing", "Accessory" });
            comboboxAddType.Location = new Point(133, 3);
            comboboxAddType.Name = "comboboxAddType";
            comboboxAddType.Size = new Size(550, 23);
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
            comboboxAddExtra.Location = new Point(133, 38);
            comboboxAddExtra.Name = "comboboxAddExtra";
            comboboxAddExtra.Size = new Size(550, 23);
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
            comboBox1.Size = new Size(151, 23);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            introTab.ResumeLayout(false);
            Storage.ResumeLayout(false);
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
        private Label label9;
        private ComboBox comboboxStorageType;
        private ComboBox comboboxStorageSort;
        private ComboBox comboboxStorageExtrafilter;
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
    }
}