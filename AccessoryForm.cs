using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U10803___Assessment_1 {
    public partial class AccessoryForm : Form {
        private string input = "";
        public AccessoryForm(int assessoryType) {
            InitializeComponent();
            switch (assessoryType) {
                case 1: groupboxDynamicText.Text = "has GPS (Y/N), has heart rate (Y/N):"; break; //< for watch accessory
                case 2: groupboxDynamicText.Text = "capacity (dec):"; break; //< for bag accessory
                default: groupboxDynamicText.Text = "capacity (dec), type:"; break; //< for drink accessory
            }
        }
        public string Input { get { return input; } }
        private void button_Click(object sender, EventArgs e) {
            this.input = textbox.Text.ToUpper();
            this.Close();
        }
    }
}
