using System.Diagnostics;

namespace U10803___Assessment_1 {
    public partial class Form1 : Form {
        //: instansiatating own
        StockSystem stockSystem = new StockSystem();
        int numberOfDetails;
        public Form1() {
            InitializeComponent();
        }
        #region redundant
        private void comboboxType_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {

        }
        #endregion

        public int[] bubbleSort(int[] array) {
            int len = array.Length;
            int temp;
            bool inactiveLoop;
            for (int index1 = 0; index1 < len - 1; index1++) {
                inactiveLoop = true;
                for (int index2 = 0; index2 < len - 1; index2++) {
                    if (array[index2] > array[index2 + 1]) {
                        inactiveLoop = false;
                        temp = array[index2];
                        array[index2] = array[index2 + 1];
                        array[index2 + 1] = temp;
                    }
                }
                if (inactiveLoop) { return array; }
            }
            return array;
        }

        #region tab - Storage
        private void comboboxStorageType_SelectedIndexChanged(object sender, EventArgs e) {
            //! 0 - Shoe, 1 - Clothing, 2 - Accessory
            UIStorageUpdate();
        }
        private void comboboxStorageSort_SelectedIndexChanged(object sender, EventArgs e) {
            //! 0 - Name, 1 - Stock, 2 - Price
            //UIStorageUpdate();
        }
        private void comboboxStorageExtrafilter_SelectedIndexChanged(object sender, EventArgs e) {
            UIStorageUpdate();
        }

        public void UIStorageUpdate() {
            int type = comboboxStorageType.SelectedIndex;
            int sort = comboboxStorageSort.SelectedIndex;
            List<Item> itemList = new List<Item>();
            Item[] itemArr;

            Type classType;

            switch (type) {
                case 0: classType = typeof(Shoe); break;
                case 1: classType = typeof(Clothing); break;
                default: classType = typeof(Accessory); break;
            }

            foreach (Item item in stockSystem.items.Values) {
                if (item.GetType() == classType) {
                    itemList.Add(item);
                }
            }
            itemArr = itemList.ToArray();

            tableStorageItems.RowCount = 1;
            List<Label> labelsBuffer = new List<Label>();
            int labelsBufferPointer = 0;
            for (int i = 0; i < itemArr.Length; i++) {
                tableStorageItems.RowCount++;

                labelsBuffer.Add(new Label());
                labelsBuffer[labelsBufferPointer].Text = itemArr[i].name.ToString();
                tableStorageItems.Controls.Add(labelsBuffer[labelsBufferPointer], 0, i + 1);
                Debug.WriteLine(labelsBuffer[labelsBufferPointer].Text);
                labelsBufferPointer++;

                labelsBuffer.Add(new Label());
                labelsBuffer[labelsBufferPointer].Text = itemArr[i].price.ToString();
                tableStorageItems.Controls.Add(labelsBuffer[labelsBufferPointer], 1, i + 1);
                labelsBufferPointer++;

                labelsBuffer.Add(new Label());
                labelsBuffer[labelsBufferPointer].Text = itemArr[i].stock.ToString();
                tableStorageItems.Controls.Add(labelsBuffer[labelsBufferPointer], 2, i + 1);
                labelsBufferPointer++;

                labelsBuffer.Add(new Label());
                labelsBuffer[labelsBufferPointer].Text = itemArr[i].giveUniqueDetails();
                tableStorageItems.Controls.Add(labelsBuffer[labelsBufferPointer], 3, i + 1);
                labelsBufferPointer++;
            }
        }
        #endregion

        #region tab - Add
        public string[] verifyDetailsInput(string input, int count) {
            string[] verified;
            int counts = 0;

            //: critical verification
            if (input[0] == ',' || input[input.Length - 1] == ',') { return new string[] { }; }
            foreach (char letter in input) {
                if (letter == ',') { counts++; }
            }
            if (counts != count - 1) { return new string[] { }; }

            input = input.ToUpper();
            verified = input.Split(',');

            //: critical verification and modifier
            for (int index = 0; index < verified.Length; index++) {
                if (verified[index].Length == 0) { return new string[] { }; }
                verified[index] = verified[index].Trim();
            }

            return verified;
        }
        private void buttonAddSubmit_Click(object sender, EventArgs e) {
            string[] saperatedInputs = verifyDetailsInput(textboxAddDetails.Text, numberOfDetails);
            string name;
            int stock;
            decimal price;

            if (comboboxAddType.SelectedIndex == null) { MessageBox.Show("You didn't select anything in all availible comboboxes", "ERROR"); }

            //: critical verification
            if (saperatedInputs.Length == 0) {
                MessageBox.Show("You did not type the details in the text box properly!", "ERROR");
                return;
            }

            List<bool> groupVerification = new List<bool>();
            name = saperatedInputs[0];
            groupVerification.Add(int.TryParse(saperatedInputs[1], out stock));
            groupVerification.Add(decimal.TryParse(saperatedInputs[2], out price));
            switch (comboboxAddType.SelectedIndex) {
                case 0:
                    groupVerification.Add(decimal.TryParse(saperatedInputs[3], out decimal shoeSize));
                    string shoeType = saperatedInputs[4];
                    if (groupVerification.Contains(false)) { MessageBox.Show("one of the properites in the detail entry was in the wrong format", "ERROR"); }
                    Shoe shoeObj = new Shoe(name, price, stock, shoeSize, shoeType);
                    if (!stockSystem.add(shoeObj)) { MessageBox.Show("Item (by name) aleady exists", "ERROR"); }
                    break;
                case 1:
                    groupVerification.Add(int.TryParse(saperatedInputs[3], out int clothingSize));
                    string clothingType = saperatedInputs[4];
                    string style = saperatedInputs[5];
                    if (groupVerification.Contains(false)) { MessageBox.Show("one of the properites in the detail entry was in the wrong format", "ERROR"); }
                    Clothing clothingObj = new Clothing(name, price, stock, clothingSize, clothingType, style);
                    if (!stockSystem.add(clothingObj)) { MessageBox.Show("Item (by name) aleady exists", "ERROR"); }
                    break;
                default:
                    Accessory accessoryObj = new Accessory(name, price, stock);
                    if (groupVerification.Contains(false)) { MessageBox.Show("one of the properites in the detail entry was in the wrong format", "ERROR"); }
                    if (!stockSystem.add(accessoryObj)) { MessageBox.Show("Item (by name) aleady exists", "ERROR"); }
                    break;
            }
        }
        private void comboboxAddType_SelectedIndexChanged(object sender, EventArgs e) {
            //! 0 - Shoe, 1 - Clothing, 2 - Accessory
            const string starting = "Name, Stock, Price,";
            const int startingQty = 3;
            switch (comboboxAddType.SelectedIndex) {
                case 0:
                    numberOfDetails = startingQty + 2;
                    labelAddDetails.Text = starting + "size (dec), type: ";
                    break;
                case 1:
                    numberOfDetails = startingQty + 3;
                    labelAddDetails.Text = starting + "size (int), type, style: ";
                    break;
                default:
                    numberOfDetails = startingQty;
                    labelAddDetails.Text = starting + ":";
                    break;
            }
        }
        private void comboboxAddExtra_SelectedIndexChanged(object sender, EventArgs e) {

        }
        #endregion
    }
}