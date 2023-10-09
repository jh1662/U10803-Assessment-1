namespace U10803___Assessment_1 {
    public partial class Form1 : Form {
        //: instansiatating own classes
        StockSystem stockSystem = new StockSystem();
        public Form1() {
            InitializeComponent();
        }
        #region redundant
        private void comboboxType_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {

        }
        #endregion

        #region tab - Storage
        private void comboboxStorageType_SelectedIndexChanged(object sender, EventArgs e) {
            //! 0 - Shoe, 1 - Clothing, 2 - Accessory
            UIStorageUpdate();
        }
        private void comboboxStorageSort_SelectedIndexChanged(object sender, EventArgs e) {
            //! 0 - Name, 1 - Stock, 2 - Price
            UIStorageUpdate();
        }
        private void comboboxStorageExtrafilter_SelectedIndexChanged(object sender, EventArgs e) {
            UIStorageUpdate();
        }

        public void UIStorageUpdate() {
            int type = comboboxStorageType.SelectedIndex;
            int sort = comboboxStorageSort.SelectedIndex;
            List<Item> list = new List<Item>();

            foreach (Item item in stockSystem.items) {
            }

        }
        #endregion

        #region tab - Add
        private void buttonAddSubmit_Click(object sender, EventArgs e) {

        }
        private void comboboxAddType_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void comboboxAddExtra_SelectedIndexChanged(object sender, EventArgs e) {

        }
        #endregion
    }
}