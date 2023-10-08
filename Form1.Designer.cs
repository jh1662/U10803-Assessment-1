namespace U10803___Assessment_1 {
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
            tabCheckout = new TabPage();
            tabCustomers = new TabPage();
            tabSuppliers = new TabPage();
            Storage = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            comboboxType = new ComboBox();
            tabAdd = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            tabPage1 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            comboBox2 = new ComboBox();
            tabControl.SuspendLayout();
            Storage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabAdd.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // introTab
            // 
            introTab.Location = new Point(4, 29);
            introTab.Name = "introTab";
            introTab.Padding = new Padding(3);
            introTab.Size = new Size(792, 417);
            introTab.TabIndex = 0;
            introTab.Text = "Introduction";
            introTab.UseVisualStyleBackColor = true;
            // 
            // tabCheckout
            // 
            tabCheckout.Location = new Point(4, 29);
            tabCheckout.Name = "tabCheckout";
            tabCheckout.Padding = new Padding(3);
            tabCheckout.Size = new Size(792, 417);
            tabCheckout.TabIndex = 1;
            tabCheckout.Text = "Checkout";
            tabCheckout.UseVisualStyleBackColor = true;
            // 
            // tabCustomers
            // 
            tabCustomers.Location = new Point(4, 29);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new Padding(3);
            tabCustomers.Size = new Size(792, 417);
            tabCustomers.TabIndex = 2;
            tabCustomers.Text = "Customers";
            tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tabSuppliers
            // 
            tabSuppliers.Location = new Point(4, 29);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Padding = new Padding(3);
            tabSuppliers.Size = new Size(792, 417);
            tabSuppliers.TabIndex = 3;
            tabSuppliers.Text = "Suppliers";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // Storage
            // 
            Storage.Controls.Add(tableLayoutPanel1);
            Storage.Location = new Point(4, 29);
            Storage.Name = "Storage";
            Storage.Padding = new Padding(3);
            Storage.Size = new Size(792, 417);
            Storage.TabIndex = 4;
            Storage.Text = "Storage";
            Storage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.88755F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.11245F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(comboboxType, 1, 0);
            tableLayoutPanel1.Location = new Point(8, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            tableLayoutPanel1.Size = new Size(498, 46);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 46);
            label1.TabIndex = 2;
            label1.Text = "Type of item:";
            // 
            // comboboxType
            // 
            comboboxType.Dock = DockStyle.Fill;
            comboboxType.FormattingEnabled = true;
            comboboxType.Items.AddRange(new object[] { "Shoes", "Clothing", "Assesories" });
            comboboxType.Location = new Point(112, 3);
            comboboxType.Name = "comboboxType";
            comboboxType.Size = new Size(383, 28);
            comboboxType.TabIndex = 3;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(tableLayoutPanel3);
            tabAdd.Location = new Point(4, 29);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.Size = new Size(792, 417);
            tabAdd.TabIndex = 5;
            tabAdd.Text = "Add new items";
            tabAdd.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.88755F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.11245F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(comboBox2, 1, 0);
            tableLayoutPanel3.Location = new Point(17, 17);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            tableLayoutPanel3.Size = new Size(498, 46);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 46);
            label3.TabIndex = 2;
            label3.Text = "Type of item:";
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Shoes", "Clothing", "Assesories" });
            comboBox2.Location = new Point(112, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(383, 28);
            comboBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            Storage.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabAdd.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private ComboBox comboboxType;
        private TabPage tabAdd;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private ComboBox comboBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private ComboBox comboBox1;
        private TabPage tabPage1;
    }
}