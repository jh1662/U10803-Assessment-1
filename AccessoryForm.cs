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
        //* exist to get extra info for creating a accessory object
        #region initialisers
        private string input = ""; //< user's (only) text input
        public AccessoryForm(int assessoryType) {
            InitializeComponent();
            switch (assessoryType) { //* displays text based on what type of accessory
                case 1: groupboxDynamicText.Text = "has GPS (Y/N), has heart rate (Y/N):"; break; 
                //^ for watch accessory
                case 2: groupboxDynamicText.Text = "capacity (dec):"; break; 
                //^ for bag accessory
                default: groupboxDynamicText.Text = "capacity (dec), type:"; break; 
                //^ for drink accessory
            }
        }
        public string Input { get { return input; } } 
        //^ to be accessed by 'Form1.cs'
        #endregion
        #region methods
        private void button_Click(object sender, EventArgs e) { //* mutator method
            this.input = textbox.Text.ToUpper(); 
            //^ aquire extra accessory info
            this.Close();
        }
        #endregion
    }
}
