namespace U10803___Assessment_1 {
    partial class AccessoryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            textbox = new TextBox();
            button = new Button();
            groupboxDynamicText = new GroupBox();
            groupboxDynamicText.SuspendLayout();
            SuspendLayout();
            // 
            // textbox
            // 
            textbox.Dock = DockStyle.Fill;
            textbox.Location = new Point(3, 23);
            textbox.Name = "textbox";
            textbox.Size = new Size(496, 27);
            textbox.TabIndex = 0;
            // 
            // button
            // 
            button.Dock = DockStyle.Bottom;
            button.Location = new Point(0, 63);
            button.Name = "button";
            button.Size = new Size(502, 45);
            button.TabIndex = 1;
            button.Text = "submit";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // groupboxDynamicText
            // 
            groupboxDynamicText.Controls.Add(textbox);
            groupboxDynamicText.Dock = DockStyle.Fill;
            groupboxDynamicText.Location = new Point(0, 0);
            groupboxDynamicText.Name = "groupboxDynamicText";
            groupboxDynamicText.Size = new Size(502, 63);
            groupboxDynamicText.TabIndex = 2;
            groupboxDynamicText.TabStop = false;
            groupboxDynamicText.Text = "extra info:";
            // 
            // AccessoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 108);
            Controls.Add(groupboxDynamicText);
            Controls.Add(button);
            Name = "AccessoryForm";
            Text = "AccessoryForm";
            groupboxDynamicText.ResumeLayout(false);
            groupboxDynamicText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textbox;
        private Button button;
        private GroupBox groupboxDynamicText;
    }
}