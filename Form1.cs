using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace U10803___Assessment_1
{
    public partial class Form1 : Form
    {
        //: instansiatating own
        StockSystem stockSystem = new StockSystem();
        SupplyLines supplyLines = new SupplyLines();
        int numberOfDetails;
        public Form1()
        {
            InitializeComponent();
        }
        #region redundant (but deletion means GUI breaking)
        private void comboboxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        public bool isBigger(Item item1, Item item2, int toCompare)
        {
            switch (toCompare)
            {
                case 1:
                    if (item1.price > item2.price) { return true; }
                    return false;
                case 2:
                    if (item1.stock > item2.stock) { return true; }
                    return false;
                default:
                    int length;
                    if (item1.name.Length < item2.name.Length) { length = item1.name.Length; }
                    else { length = item2.name.Length; }
                    for (int i = 0; i < item1.name.Length; i++)
                    {
                        if (item1.name[i] > item2.name[i]) { return true; }
                        if (item1.name[i] < item2.name[i]) { return false; }
                    }
                    return false;
            }
        }
        public Item[] bubbleSort(Item[] itemArr, int toCompare)
        {
            int len = itemArr.Length;
            Item temp;
            bool inactiveLoop;
            for (int index1 = 0; index1 < len - 1; index1++)
            {
                inactiveLoop = true;
                for (int index2 = 0; index2 < len - 1; index2++)
                {
                    if (isBigger(itemArr[index2], itemArr[index2 + 1], toCompare))
                    {
                        inactiveLoop = false;
                        temp = itemArr[index2];
                        itemArr[index2] = itemArr[index2 + 1];
                        itemArr[index2 + 1] = temp;
                    }
                }
                if (inactiveLoop) { return itemArr; }
            }
            return itemArr;
        }

        #region tab - Storage
        private void comboboxStorageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //! 0 - Shoe, 1 - Clothing, 2 - Accessory
            UIStorageUpdate();
        }
        private void comboboxStorageSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //! 0 - Name, 1 - Stock, 2 - Price
            UIStorageUpdate();
        }
        private void comboboxStorageExtrafilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIStorageUpdate();
        }

        private void UIStorageUpdate()
        {
            int type = comboboxStorageType.SelectedIndex;
            int sort = comboboxStorageSort.SelectedIndex;
            List<Item> itemList = new List<Item>();
            Item[] itemArr;
            Type classType;

            //if (type == null) { return; }

            switch (type)
            {
                case 0: classType = typeof(Shoe); break;
                case 1: classType = typeof(Clothing); break;
                default: classType = typeof(Accessory); break;
            }

            foreach (Item item in stockSystem.items.Values)
            {
                if (item.GetType() == classType)
                {
                    itemList.Add(item);
                }
            }
            itemArr = itemList.ToArray();
            itemArr = bubbleSort(itemArr, sort);

            //tableStorageItems.RowCount = 1;
            //List<Label> labelsBuffer = new List<Label>();
            labelStorageListName.Text = "";
            labelStorageListPrice.Text = "";
            labelStorageListStock.Text = "";
            labelStorageListUnique.Text = "";

            //int labelsBufferPointer = 0;
            for (int i = 0; i < itemArr.Length; i++)
            {
                labelStorageListName.Text += "\n\n" + itemArr[i].name;
                labelStorageListPrice.Text += "\n\n" + itemArr[i].price;
                labelStorageListStock.Text += "\n\n" + itemArr[i].stock;
                labelStorageListUnique.Text += "\n\n" + itemArr[i].price;

                /*
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
                */
            }
        }
        #endregion

        #region tab - Add
        public string[] verifyDetailsInput(string input, int count)
        {
            string[] verified;
            int counts = 0;

            //: critical verification
            if (input[0] == ',' || input[input.Length - 1] == ',') { return new string[] { }; }
            foreach (char letter in input)
            {
                if (letter == ',') { counts++; }
            }
            if (counts != count - 1) { return new string[] { }; }

            input = input.ToUpper();
            verified = input.Split(',');

            //: critical verification and modifier
            for (int index = 0; index < verified.Length; index++)
            {
                if (verified[index].Length == 0) { return new string[] { }; }
                verified[index] = verified[index].Trim();
            }

            return verified;
        }
        private void buttonAddSubmit_Click(object sender, EventArgs e)
        {
            string[] saperatedInputs = verifyDetailsInput(textboxAddDetails.Text, numberOfDetails);
            string name;
            int stock;
            decimal price;

            if (comboboxAddType.SelectedIndex == null) { MessageBox.Show("You didn't select anything in all availible comboboxes", "ERROR"); }

            //: critical verification
            if (saperatedInputs.Length == 0)
            {
                MessageBox.Show("You did not type the details in the text box properly!", "ERROR");
                return;
            }

            List<bool> groupVerification = new List<bool>();
            name = saperatedInputs[0];
            groupVerification.Add(int.TryParse(saperatedInputs[1], out stock));
            groupVerification.Add(decimal.TryParse(saperatedInputs[2], out price));
            switch (comboboxAddType.SelectedIndex)
            {
                case 0:
                    groupVerification.Add(decimal.TryParse(saperatedInputs[3], out decimal shoeSize));
                    string shoeType = saperatedInputs[4];
                    if (groupVerification.Contains(false))
                    {
                        MessageBox.Show("one of the properites in the detail entry was in the wrong format", "ERROR");
                        break;
                    }
                    Shoe shoeObj = new Shoe(name, price, stock, shoeSize, shoeType);
                    if (!stockSystem.add(shoeObj))
                    {
                        MessageBox.Show("Item (by name) aleady exists", "ERROR");
                        break;
                    }
                    MessageBox.Show("Item creation successful", "successful action");
                    break;
                case 1:
                    groupVerification.Add(int.TryParse(saperatedInputs[3], out int clothingSize));
                    string clothingType = saperatedInputs[4];
                    string style = saperatedInputs[5];
                    if (groupVerification.Contains(false))
                    {
                        MessageBox.Show("one of the properites in the detail entry was in the wrong format", "ERROR");
                        break;
                    }
                    Clothing clothingObj = new Clothing(name, price, stock, clothingSize, clothingType, style);
                    if (!stockSystem.add(clothingObj))
                    {
                        MessageBox.Show("Item (by name) aleady exists", "ERROR");
                        break;
                    }
                    MessageBox.Show("Item creation successful", "successful action");
                    break;
                default:
                    Accessory accessoryObj = new Accessory(name, price, stock);
                    if (groupVerification.Contains(false))
                    {
                        MessageBox.Show("one of the properites in the detail entry was in the wrong format", "ERROR");
                        break;
                    }
                    if (!stockSystem.add(accessoryObj))
                    {
                        MessageBox.Show("Item (by name) aleady exists", "ERROR");
                        break;
                    }
                    MessageBox.Show("Item creation successful", "successful action");
                    break;
            }
        }
        private void comboboxAddType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //! 0 - Shoe, 1 - Clothing, 2 - Accessory
            const string starting = "Name, Stock, Price,";
            const int startingQty = 3;
            switch (comboboxAddType.SelectedIndex)
            {
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
        private void comboboxAddExtra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Supplier
        private void supplierViewRefresh()
        {
            if (supplyLines.SupplierDict.Count == 0) { return; }

            labelSupplierViewName.Text = string.Empty;
            labelSupplierViewStock.Text = string.Empty;
            string[] supplierNames = supplyLines.SupplierDict.Keys.ToArray();
            string[] supplierStock = new string[supplierNames.Length];

            for (int i = 0; i < supplierNames.Length; i++)
            {
                if (supplyLines.SupplierDict[supplierNames[i]].stockDict.Count == 0)
                {
                    supplierStock[i] = "None!";
                    continue;
                }
                foreach (KeyValuePair<string, int> pair in supplyLines.SupplierDict[supplierNames[i]].stockDict)
                {
                    supplierStock[i] += $"{pair.Key} - {pair.Value}, ";
                }
            }
            for (int i = 0; i < supplierNames.Length; i++)
            {
                labelSupplierViewName.Text += supplierNames[i] + "\n";
                labelSupplierViewStock.Text += supplierStock[i] + "\n";
            }
        }
        private bool verifyInputsSupplier(string supplier, string item, string qty)
        {
            int temp;

            if (supplier == "" || item == "" || qty == "")
            {
                MessageBox.Show("can't leave any textbox blank!", "error");
                return false;
            }
            if (!supplyLines.SupplierDict.ContainsKey(supplier))
            {
                MessageBox.Show("supplier doesn't exist!", "error");
                return false;
            }
            if (!stockSystem.items.ContainsKey(item))
            {
                MessageBox.Show("item doesn't exist!", "error");
                return false;
            }
            if (!int.TryParse(qty, out temp))
            {
                MessageBox.Show("invalid format for quantity", "error");
                return false;
            }
            return true;
        }
        private void buttonSupplierAdd_Click(object sender, EventArgs e)
        {
            string input = textboxSupplierAdd.Text.Trim().ToUpper();
            if (input == "")
            {
                MessageBox.Show("can't leave the name blank!", "error");
                return;
            }
            if (supplyLines.Add(input) == false)
            {
                MessageBox.Show("supplier name already exists!", "error");
                return;
            }
            supplierViewRefresh();
        }
        private void ButtonSupplierRestock_Click(object sender, EventArgs e)
        {
            string inputSupplier = textboxSupplierRestockSupplier.Text.Trim().ToUpper();
            string inputItem = textboxSupplierRestockItem.Text.Trim().ToUpper();
            string inputQty = textboxSupplierRestockQty.Text.Trim().ToUpper();
            int qty;

            if (verifyInputsSupplier(inputSupplier, inputItem, inputQty)) { return; }
            qty = int.Parse(inputQty);

            if (!supplyLines.SupplierDict[inputSupplier].restock(inputItem, qty))
            {
                MessageBox.Show("supplier currently doesn't have that order/quantity", "error");
            }

            stockSystem.items[inputItem].stock += qty;
            supplierViewRefresh();
            UIStorageUpdate();
            MessageBox.Show("restock successful", "info");
        }
        #endregion

        private void ButtonSupplierOrder_Click(object sender, EventArgs e)
        {
            string inputSupplier = textboxSupplierOrderSupplier.Text.Trim().ToUpper();
            string inputItem = textboxSupplierOrderItem.Text.Trim().ToUpper();
            string inputQty = textboxSupplierOrderQty.Text.Trim().ToUpper();
            int qty;

            if (verifyInputsSupplier(inputSupplier, inputItem, inputQty)) { return; }
            qty = int.Parse(inputQty);

            supplyLines.SupplierDict[inputSupplier].order(inputItem, qty);
            supplierViewRefresh();
            MessageBox.Show("order successful", "info");
        }
    }
}