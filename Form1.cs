using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace U10803___Assessment_1;
public partial class Form1 : Form {
    //: instansiatating own
    StockSystem stockSystem = new StockSystem();
    SupplyLines supplyLines = new SupplyLines();
    AllCustomers allCustomers = new AllCustomers();

    int numberOfDetails;

    public Dictionary<string, int> shoppingCart = new Dictionary<string, int>();
    public Form1() {
        InitializeComponent();
    }
    #region redundant (but deletion means GUI breaking)
    private void comboboxType_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void button2_Click(object sender, EventArgs e) {

    }
    #endregion

    #region tab - Storage
    public bool isBigger(Item item1, Item item2, int toCompare) {
        switch (toCompare) {
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
                for (int i = 0; i < item1.name.Length; i++) {
                    if (item1.name[i] > item2.name[i]) { return true; }
                    if (item1.name[i] < item2.name[i]) { return false; }
                }
                return false;
        }
    }
    public Item[] bubbleSort(Item[] itemArr, int toCompare) {
        int len = itemArr.Length;
        Item temp;
        bool inactiveLoop;
        for (int index1 = 0; index1 < len - 1; index1++) {
            inactiveLoop = true;
            for (int index2 = 0; index2 < len - 1; index2++) {
                if (isBigger(itemArr[index2], itemArr[index2 + 1], toCompare)) {
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

    private void UIStorageUpdate() {
        int type = comboboxStorageType.SelectedIndex;
        int sort = comboboxStorageSort.SelectedIndex;
        List<Item> itemList = new List<Item>();
        Item[] itemArr;
        //Type classType;

        //if (type == null) { return; }

        /*
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
        */
        foreach (Item item in stockSystem.Items.Values) {
            switch (type) {
                case 0:
                    if (item is Shoe) { itemList.Add(item); }
                    break;
                case 1:
                    if (item is Clothing) { itemList.Add(item); }
                    break;
                default:
                    if (item is Accessory) { itemList.Add(item); }
                    break;
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
        for (int i = 0; i < itemArr.Length; i++) {
            labelStorageListName.Text += itemArr[i].name + "\n\n";
            labelStorageListPrice.Text += itemArr[i].price + "\n\n";
            labelStorageListStock.Text += itemArr[i].stock + "\n\n";
            labelStorageListUnique.Text += itemArr[i].giveUniqueDetails() + "\n\n";

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
    public bool tryBool(string input, out bool result) {
        result = false;
        switch (input) {
            case "Y":
                result = true;
                return true;
            case "N":
                return true;
            default:
                return false;
        }
    }
    public string[] verifyDetailsInput(string input, int count) {
        string[] verified;
        int counts = 0;

        //: critical verification
        if (input == "") { return new string[] { }; }
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
                if (groupVerification.Contains(false)) {
                    MessageBox.Show("atleast one of the properites in the detail entry was in the wrong format", "ERROR");
                    break;
                }
                Shoe shoeObj = new Shoe(name, price, stock, shoeSize, shoeType);
                if (!stockSystem.add(shoeObj)) {
                    MessageBox.Show("Item (by name) aleady exists", "ERROR");
                    break;
                }
                MessageBox.Show("Item creation successful", "successful action");
                break;
            case 1:
                groupVerification.Add(int.TryParse(saperatedInputs[3], out int clothingSize));
                string clothingType = saperatedInputs[4];
                string style = saperatedInputs[5];
                if (groupVerification.Contains(false)) {
                    MessageBox.Show("atleast one of the properites in the detail entry was in the wrong format", "ERROR");
                    break;
                }
                Clothing clothingObj = new Clothing(name, price, stock, clothingSize, clothingType, style);
                if (!stockSystem.add(clothingObj)) {
                    MessageBox.Show("Item (by name) aleady exists", "ERROR");
                    break;
                }
                MessageBox.Show("Item creation successful", "successful action");
                break;
            default:
                if (groupVerification.Contains(false)) {
                    MessageBox.Show("atleast one of the properites in the detail entry was in the wrong format", "ERROR");
                    break;
                }
                //Accessory accessoryObj = new Accessory(name, price, stock);
                /*
                if (!stockSystem.add(accessoryObj)) {
                    MessageBox.Show("Item (by name) aleady exists", "ERROR");
                    break;
                }
                */
                if (!addAccessory(saperatedInputs[3], name, price, stock)) { break; }

                MessageBox.Show("Item creation successful", "successful action");
                break;
        }
    }
    private bool addAccessory(string type, string name, decimal price, int stock) {
        type = type.Trim().ToUpper();
        string input;
        AccessoryForm accessoryForm;
        string[] extraInfo;

        switch (type) {
            case "WATCH":
                bool infoHasGPS;
                bool infoHasRate;

                accessoryForm = new AccessoryForm(1);
                accessoryForm.ShowDialog();
                input = accessoryForm.Input;
                extraInfo = verifyDetailsInput(input, 2);

                if (extraInfo.Length == 0) {
                    MessageBox.Show("You did not type the details in the text box properly!", "ERROR");
                    return false;
                }
                if (!tryBool(extraInfo[0], out infoHasGPS) || !tryBool(extraInfo[1], out infoHasRate)) {
                    MessageBox.Show("atleast one of the properites in the extra-info entry was in the wrong format", "ERROR");
                    return false;
                }

                Watch watch = new Watch(name, price, stock, infoHasGPS, infoHasRate);
                if (!stockSystem.add(watch)) {
                    MessageBox.Show("accessory (by name) already exists", "ERROR");
                    return false;
                }

                break;
            case "BAG":
                decimal infoCapacityBag;

                accessoryForm = new AccessoryForm(2);
                accessoryForm.ShowDialog();
                input = accessoryForm.Input;
                extraInfo = verifyDetailsInput(input, 1);

                if (extraInfo.Length == 0) {
                    MessageBox.Show("You did not type the details in the text box properly!", "ERROR");
                    return false;
                }
                if (!decimal.TryParse(extraInfo[0], out infoCapacityBag)) {
                    MessageBox.Show("atleast one of the properites in the extra-info entry was in the wrong format", "ERROR");
                    return false;
                }
                Bag bag = new Bag(name, price, stock, infoCapacityBag);
                if (!stockSystem.add(bag)) {
                    MessageBox.Show("accessory (by name) already exists", "ERROR");
                    return false;
                }

                break;
            case "DRINK":
                decimal infoCapacityDrink;
                string infoType;

                accessoryForm = new AccessoryForm(3);
                accessoryForm.ShowDialog();
                input = accessoryForm.Input;
                extraInfo = verifyDetailsInput(input, 2);

                if (extraInfo.Length == 0) {
                    MessageBox.Show("You did not type the details in the text box properly!", "ERROR");
                    return false;
                }
                if (!decimal.TryParse(extraInfo[0], out infoCapacityDrink)) {
                    MessageBox.Show("atleast one of the properites in the extra-info entry was in the wrong format", "ERROR");
                    return false;
                }
                infoType = extraInfo[1];
                Drink drink = new Drink(name, price, stock, infoCapacityDrink, infoType);
                if (!stockSystem.add(drink)) {
                    MessageBox.Show("accessory (by name) already exists", "ERROR");
                    return false;
                }

                break;
            default:
                MessageBox.Show("type of accessory does not exist", "ERROR");
                return false;
        }
        return true;
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
                numberOfDetails = startingQty + 1;
                labelAddDetails.Text = starting + "type of accessory:";
                break;
        }
    }
    private void comboboxAddExtra_SelectedIndexChanged(object sender, EventArgs e) {

    }
    #endregion

    #region tab - Supplier
    private void supplierViewRefresh() {
        if (supplyLines.SupplierDict.Count == 0) { return; }

        labelSupplierViewName.Text = string.Empty;
        labelSupplierViewStock.Text = string.Empty;
        string[] supplierNames = supplyLines.SupplierDict.Keys.ToArray();
        string[] supplierStock = new string[supplierNames.Length];

        for (int i = 0; i < supplierNames.Length; i++) {
            if (supplyLines.SupplierDict[supplierNames[i]].StockDict.Count == 0) {
                supplierStock[i] = "None!";
                continue;
            }
            foreach (KeyValuePair<string, int> pair in supplyLines.SupplierDict[supplierNames[i]].StockDict) {
                supplierStock[i] += $"{pair.Key} - {pair.Value}, ";
            }
        }
        for (int i = 0; i < supplierNames.Length; i++) {
            labelSupplierViewName.Text += supplierNames[i] + "\n";
            labelSupplierViewStock.Text += supplierStock[i] + "\n";
        }
    }
    private bool verifyInputsSupplier(string supplier, string item, string qty) {
        int qtyInt;

        if (supplier == "" || item == "" || qty == "") {
            MessageBox.Show("can't leave any textbox blank!", "error");
            return false;
        }
        if (!supplyLines.SupplierDict.ContainsKey(supplier)) {
            MessageBox.Show("supplier doesn't exist!", "error");
            return false;
        }
        if (!stockSystem.Items.ContainsKey(item)) {
            MessageBox.Show("item doesn't exist!", "error");
            return false;
        }
        if (!int.TryParse(qty, out qtyInt)) {
            MessageBox.Show("invalid format for quantity", "error");
            return false;
        }
        if (qtyInt < 0) {
            if (MessageBox.Show("negative quantity entered, continue?", "confirm", MessageBoxButtons.YesNo) == DialogResult.No) { return false; }
        }
        return true;
    }
    private void buttonSupplierAdd_Click(object sender, EventArgs e) {
        string input = textboxSupplierAdd.Text.Trim().ToUpper();
        if (input == "") {
            MessageBox.Show("can't leave the name blank!", "error");
            return;
        }
        if (supplyLines.Add(input) == false) {
            MessageBox.Show("supplier name already exists!", "error");
            return;
        }
        supplierViewRefresh();
    }
    private void ButtonSupplierRestock_Click(object sender, EventArgs e) {
        string inputSupplier = textboxSupplierRestockSupplier.Text.Trim().ToUpper();
        string inputItem = textboxSupplierRestockItem.Text.Trim().ToUpper();
        string inputQty = textboxSupplierRestockQty.Text.Trim().ToUpper();
        int qty;

        if (!verifyInputsSupplier(inputSupplier, inputItem, inputQty)) { return; }
        qty = int.Parse(inputQty);

        if (!supplyLines.SupplierDict[inputSupplier].restock(inputItem, qty)) {
            MessageBox.Show("supplier currently doesn't have that order/quantity", "error");
            return;
        }

        stockSystem.Items[inputItem].stock += qty;
        supplierViewRefresh();
        UIStorageUpdate();
        MessageBox.Show("restock successful", "info");
    }
    private void ButtonSupplierOrder_Click(object sender, EventArgs e) {
        string inputSupplier = textboxSupplierOrderSupplier.Text.Trim().ToUpper();
        string inputItem = textboxSupplierOrderItem.Text.Trim().ToUpper();
        string inputQty = textboxSupplierOrderQty.Text.Trim().ToUpper();
        int qty;

        if (!verifyInputsSupplier(inputSupplier, inputItem, inputQty)) { return; }
        qty = int.Parse(inputQty);

        supplyLines.SupplierDict[inputSupplier].order(inputItem, qty);
        supplierViewRefresh();
        MessageBox.Show("order successful", "info");
    }
    #endregion

    #region tab - customer
    private char[] generateValidEmailChars() {
        //* Valid characters (RFC-compliant) source: 
        //* https://www.novell.com/documentation/groupwise18/gwsdk_admin_rest_api/data/b12nem8w.html
        List<char> chars = new List<char>();
        int[] others = new int[] { 43, 45, 95, 126 }; //< +,-,_,~

        for (int index = 65; index < 91; index++) { chars.Add(Convert.ToChar(index)); }
        //^ lower-case letters
        for (int index = 97; index < 123; index++) { chars.Add(Convert.ToChar(index)); }
        //^ upper-case letters
        for (int index = 48; index < 58; index++) { chars.Add(Convert.ToChar(index)); }
        //^ digits
        chars.Add(Convert.ToChar(46));
        //^ emails dont require dots yet not restricted: https://en.wikipedia.org/wiki/Email_address#Examples
        return chars.ToArray();
    }
    private bool verifyEmail(string email) {
        char[] validChars = generateValidEmailChars();
        int atSymbolCount = 0;

        if (email == "") { return false; }
        if (email.StartsWith('@') || email.EndsWith('@')) { return false; }
        //^ I keep char count of each line below 128
        foreach (char c in email) {
            if (c == '@') { atSymbolCount++; continue; }
            if (!validChars.Contains(c)) { return false; }
        }
        if (atSymbolCount != 1) { return false; }
        //^ few sources allows more than one '@' symbol in a single email address, but most others don't... I'm confused.
        //^ ... well a customer shouldn't use an inappropiate valid email anyway like:
        //^ "very.(),:;<>[]\".VERY.\"very@\\ \"very\".unusual"@strange.example.com
        //^ https://en.wikipedia.org/wiki/Email_address#Examples
        return true;
    }
    private void buttonCustomerAdd_Click(object sender, EventArgs e) {
        string name = textboxCustomerAddName.Text.Trim().ToUpper();
        string email = textboxCustomerAddEmail.Text.Trim().ToUpper();
        if (!verifyEmail(email)) {
            MessageBox.Show("invalid email format", "error");
            return;
        }
        if (name == "") {
            MessageBox.Show("can't leave name empty", "error");
            return;
        }
        if (allCustomers.findEmail(email)) {
            MessageBox.Show("customer (by email) already exists", "error");
            return;
        }
        allCustomers.addCustomer(email, name);
        MessageBox.Show("customer (with email) added successfully", "successful action");
        refreshRecents();
    }

    private void refreshRecents() {
        string[] emails = allCustomers.viewAllEmails();
        string[] names = allCustomers.viewAllNames();

        labelCustomerAddRecentEmail.Text = "";
        labelCustomerAddRecentName.Text = "";
        for (int i = 0; i < emails.Length; i++) {
            labelCustomerAddRecentEmail.Text += (emails[i] + "\n");
            labelCustomerAddRecentName.Text += (names[i] + "\n");
        }
    }
    private void buttonCustomerViewInspect_Click(object sender, EventArgs e) {
        string email = textboxCustomerView.Text.Trim().ToUpper();
        Purchase[] purchases;

        labelCustomerViewPurchaseDate.Text = "";
        labelCustomerViewPurchaseItems.Text = "";
        labelCustomerViewPurchaseCost.Text = "";

        if (!allCustomers.findEmail(email)) {
            MessageBox.Show("customer (by email) does not exist", "error");
            return;
        }

        purchases = allCustomers.viewCustomer(email).Purchases.ToArray();
        if (purchases.Length == 0) { return; }
        foreach (Purchase purchase in purchases) {
            labelCustomerViewPurchaseDate.Text += (purchase.SaleDate + "\n");
            labelCustomerViewPurchaseItems.Text += purchasedItemsToString(purchase.Items);
            labelCustomerViewPurchaseCost.Text += (purchase.Price + "\n");
        }
    }

    private string purchasedItemsToString(Dictionary<string, int> purchased) {
        string purchases = "";
        string[] names = purchased.Keys.ToArray();
        /*
        string[] qtys = Array.ConvertAll(purchased.Values.ToArray(),x=>x.ToString());
        //^ https://stackoverflow.com/questions/14051257/conversion-from-int-array-to-string-array
        */
        int[] qtys = purchased.Values.ToArray();
        for (int i = 0; i < names.Length; i++) {
            purchases += names[i] + $" ({qtys[i]})";
            if (i < names.Length - 1) { purchases += ", "; }
        }
        return purchases;
    }
    #endregion

    #region tab - checkout
    private bool inspectEmail() {
        string email = textboxCheckoutEmail.Text.Trim().ToUpper();
        if (allCustomers.findEmail(email)) {
            MessageBox.Show("customer (by email) is confirmed to exist", "check successful");
            return true;
        }
        MessageBox.Show("customer (by email) does not exist", "check unsuccessful");
        return false;
    }
    private void buttonCheckoutInspect_Click(object sender, EventArgs e) {
        inspectEmail();
    }
    private decimal refresh() {
        string[] items = shoppingCart.Keys.ToArray();
        int[] qtys = shoppingCart.Values.ToArray();
        decimal totalPrice = 0;

        labelCheckoutItems.Text = "";
        labelCheckoutPrices.Text = "";
        labelCheckoutQtys.Text = "";
        for (int i = 0; i < items.Length; i++) {
            decimal multipliedPrice;

            labelCheckoutItems.Text += items[i] + "\n";
            labelCheckoutQtys.Text += qtys[i] + "\n";
            multipliedPrice = stockSystem.Items[items[i]].price;
            labelCheckoutTotalPrice.Text += multipliedPrice.ToString() + "\n";
            totalPrice += multipliedPrice;
        }
        labelCheckoutTotalPrice.Text = totalPrice.ToString();
        return totalPrice;
    }
    private void buttonCheckoutAdd_Click(object sender, EventArgs e) {
        string inputItem = textboxCheckoutItem.Text.Trim().ToUpper();
        string inputQty = textboxCheckoutQty.Text.Trim().ToUpper();
        int intQty;

        if (!stockSystem.check(inputItem) || !int.TryParse(inputQty, out intQty)) {
            MessageBox.Show("infomation inputted incorrectly", "ERROR");
            return;
        }
        if (shoppingCart.ContainsKey(inputItem)) {
            shoppingCart[inputItem] += intQty;
            refresh();
            return;
        }
        shoppingCart.Add(inputItem, intQty);
        refresh();
    }

    private void buttonCheckoutRemove_Click(object sender, EventArgs e) {
        string inputItem = textboxCheckoutItem.Text.Trim().ToUpper();
        string inputQty = textboxCheckoutQty.Text.Trim().ToUpper();
        int intQty;

        if (!stockSystem.check(inputItem) || !int.TryParse(inputQty, out intQty)) {
            MessageBox.Show("infomation inputted incorrectly", "ERROR");
            return;
        }
        if (!shoppingCart.ContainsKey(inputItem)) {
            MessageBox.Show("you can't remove items that you haven't added", "ERROR");
            return;
        }
        if (intQty > shoppingCart[inputItem]) {
            MessageBox.Show("can't make quantity number in the neagative", "ERROR");
            return;
        }
        shoppingCart[inputItem] -= intQty;
        refresh();
    }

    private void buttonCheckoutSubmit_Click(object sender, EventArgs e) {
        decimal totalPrice = refresh();
        Purchase purchase;

        if (!inspectEmail()) { return; }
        if (!checkStock(shoppingCart)) { return; }

        purchase = new Purchase(DateTime.Now, totalPrice, shoppingCart);
        allCustomers.addPurchase(textboxCheckoutEmail.Text.Trim().ToUpper(), purchase);
        /// remove stock
        MessageBox.Show("purchase successful", "successful action");
    }
    private bool checkStock(Dictionary<string, int> shoppingCart) {
        foreach (KeyValuePair<string, int> item in shoppingCart) {
            if (stockSystem.Items[item.Key].stock < item.Value) {
                MessageBox.Show("atleast one type of item has a higher qty that stock!", "ERROR");
                return false;
            }
        }
        return true;
    }
    private void buttonCheckoutCancel_Click(object sender, EventArgs e) {
        shoppingCart.Clear();
        textboxCheckoutEmail.Text = "";
        textboxCheckoutItem.Text = "";
        textboxCheckoutQty.Text = "";
        MessageBox.Show("cancellation sucessful", "succesful action");
    }
    #endregion


}
