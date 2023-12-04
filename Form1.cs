using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace U10803___Assessment_1;

public partial class Form1 : Form, IComparer<Item> {
    #region initialisers
    //: instansiatating own
    //SupplyLines SupplyLines = new SupplyLines();
    //StockSystem stockSystem = new StockSystem();
    //AllCustomers allCustomers = new AllCustomers();

    private enum ItemType { Shoe, Clothing, Accessory }
    public enum CompareItem { Price, Stock, Name }
    private enum AccessoryType { Watch, Bag, Drink }

    private int numberOfDetails;
    private CompareItem attribute;

    private Dictionary<string, int> shoppingCart = new Dictionary<string, int>();
    public Form1() {
        InitializeComponent();
    }
    #endregion
    #region redundant (but deletion means GUI designer breaking)
    private void comboboxType_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void button2_Click(object sender, EventArgs e) {

    }

    private void comboboxStorageExtrafilter_SelectedIndexChanged(object sender, EventArgs e) {

    }
    private void comboboxAddExtra_SelectedIndexChanged(object sender, EventArgs e) {

    }
    #endregion

    #region tab - Storage
    public int Compare(Item item1, Item item2) {

        CompareItem compare = attribute;
        //: different ways of comparison - dependent on data type
        switch (compare) {
            case CompareItem.Price:
                if (item1.Price > item2.Price) { return 1; }
                return 0;
            case CompareItem.Stock:
                if (item1.Stock > item2.Stock) { return 1; }
                return 0;
            default: //< if 'compare' = 'Compare.Name' 
                int length;
                if (item1.Name.Length < item2.Name.Length) { length = item1.Name.Length; }
                else { length = item2.Name.Length; }
                for (int i = 0; i < item1.Name.Length; i++) {
                    if (item1.Name[i] > item2.Name[i]) { return 1; }
                    if (item1.Name[i] < item2.Name[i]) { return 0; }
                }
                return 0;
        }
    }
    private Item[] bubbleSort(Item[] itemArr, CompareItem compareAttribute) {
        int len = itemArr.Length;
        Item temp;
        bool inactiveLoop;

        attribute = compareAttribute;
        for (int index1 = 0; index1 < len - 1; index1++) {
            inactiveLoop = true;
            for (int index2 = 0; index2 < len - 1; index2++) {

                if (Compare(itemArr[index2], itemArr[index2 + 1]) == 1) {
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

    private void UIStorageUpdate() {
        //int type = comboboxStorageType.SelectedIndex;
        ItemType itemType = (ItemType)comboboxStorageType.SelectedIndex;
        //int sort = comboboxStorageSort.SelectedIndex;
        CompareItem sort = (CompareItem)comboboxStorageSort.SelectedIndex;
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

        //: The filtering part
        foreach (Item item in StockSystem.obj.Items.Values) {
            switch (itemType) {
                case ItemType.Shoe:
                    if (item is Shoe) { itemList.Add(item); }
                    break;
                case ItemType.Clothing:
                    if (item is Clothing) { itemList.Add(item); }
                    break;
                default: //< if 'itemType' is 'ItemType.Accessory'
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

        //: displaying info to user
        for (int i = 0; i < itemArr.Length; i++) {
            labelStorageListName.Text += itemArr[i].Name + "\n\n";
            labelStorageListPrice.Text += "\u00A3" + itemArr[i].Price + "\n\n";
            labelStorageListStock.Text += itemArr[i].Stock + "\n\n";
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
    private bool tryBool(string input, out bool result) {
        //* convert user's input to a boolean
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
    private string[] verifyDetailsInput(string input, int count) {
        //* converts user's singular input to a string array
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
        //* when user wants to add a new kind of item
        string[] saperatedInputs = verifyDetailsInput(textboxAddDetails.Text, numberOfDetails);
        string name;
        int stock;
        decimal price;
        ItemType itemType;

        if (comboboxAddType.SelectedIndex == -1) { MessageBox.Show("You didn't select anything the combobox", "ERROR"); }
        itemType = (ItemType)comboboxAddType.SelectedIndex;

        //: critical verification
        if (saperatedInputs.Length == 0) {
            MessageBox.Show("You did not type the details in the text box properly!", "ERROR");
            return;
        }

        List<bool> groupVerification = new List<bool>();
        name = saperatedInputs[0];
        groupVerification.Add(int.TryParse(saperatedInputs[1], out stock));
        groupVerification.Add(decimal.TryParse(saperatedInputs[2], out price));
        if (!(decimal.Round(price, 2) == price)) { groupVerification.Add(false); }
        //: different ways to add item - depending on the type of item
        switch (itemType) {
            case ItemType.Shoe:
                groupVerification.Add(decimal.TryParse(saperatedInputs[3], out decimal shoeSize));
                string shoeType = saperatedInputs[4];
                if (groupVerification.Contains(false)) {
                    MessageBox.Show("atleast one of the properites in the detail entry was in the wrong format", "ERROR");
                    break;
                }
                Shoe shoeObj = new Shoe(name, price, stock, shoeSize, shoeType);
                if (!StockSystem.obj.add(shoeObj)) {
                    MessageBox.Show("Item (by name) aleady exists", "ERROR");
                    break;
                }
                MessageBox.Show("Item creation successful", "successful action");
                break;
            case ItemType.Clothing:
                groupVerification.Add(int.TryParse(saperatedInputs[3], out int clothingSize));
                string clothingType = saperatedInputs[4];
                string style = saperatedInputs[5];
                if (groupVerification.Contains(false)) {
                    MessageBox.Show("atleast one of the properites in the detail entry was in the wrong format", "ERROR");
                    break;
                }
                Clothing clothingObj = new Clothing(name, price, stock, clothingSize, clothingType, style);
                if (!StockSystem.obj.add(clothingObj)) {
                    MessageBox.Show("Item (by name) aleady exists", "ERROR");
                    break;
                }
                MessageBox.Show("Item creation successful", "successful action");
                break;
            default: //< if item is acessory ('ItemType.Accessory')
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
        UIStorageUpdate();
    }
    private bool addAccessory(string type, string name, decimal price, int stock) {
        //* determine what type accessory the user wants to add and does it
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
                if (!StockSystem.obj.add(watch)) {
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
                if (!StockSystem.obj.add(bag)) {
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
                if (!StockSystem.obj.add(drink)) {
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
    #endregion

    #region tab - Supplier
    private void supplierViewRefresh() {

        //* allows user to see all suppliers, and thier stock, accurently (so they don't add the same supplier and stock twice)
        if (SupplyLines.obj.Accounts.Count == 0) { return; }

        labelSupplierViewName.Text = string.Empty;
        labelSupplierViewStock.Text = string.Empty;
        string[] supplierNames = SupplyLines.obj.Accounts.Keys.ToArray();
        string[] supplierStock = new string[supplierNames.Length];

        for (int i = 0; i < supplierNames.Length; i++) {
            if (SupplyLines.obj.Accounts[supplierNames[i]].StockDict.Count == 0) {
                supplierStock[i] = "None!";
                continue;
            }
            foreach (KeyValuePair<string, int> pair in SupplyLines.obj.Accounts[supplierNames[i]].StockDict) {
                supplierStock[i] += $"{pair.Key} - {pair.Value}, ";
            }
        }
        for (int i = 0; i < supplierNames.Length; i++) {
            labelSupplierViewName.Text += supplierNames[i] + "\n";
            labelSupplierViewStock.Text += supplierStock[i] + "\n";
        }
    }
    private bool verifyInputsSupplier(string supplier, string item, string qty) {
        //* verify user's input to restock or order to a specified supplier
        int qtyInt;

        if (supplier == "" || item == "" || qty == "") {
            MessageBox.Show("can't leave any textbox blank!", "error");
            return false;
        }
        if (!SupplyLines.obj.Accounts.ContainsKey(supplier)) {
            MessageBox.Show("supplier doesn't exist!", "error");
            return false;
        }
        if (!StockSystem.obj.Items.ContainsKey(item)) {
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
        //* verifies and adds a new supplier
        string input = textboxSupplierAdd.Text.Trim().ToUpper();

        if (input == "") {
            MessageBox.Show("can't leave the name blank!", "error");
            return;
        }
        if (SupplyLines.obj.add(input) == false) {
            MessageBox.Show("supplier name already exists!", "error");
            return;
        }
        supplierViewRefresh();
    }
    private void ButtonSupplierRestock_Click(object sender, EventArgs e) {
        //* verifies and restock to a specified supplier
        string inputSupplier = textboxSupplierRestockSupplier.Text.Trim().ToUpper();
        string inputItem = textboxSupplierRestockItem.Text.Trim().ToUpper();
        string inputQty = textboxSupplierRestockQty.Text.Trim().ToUpper();
        int qty;

        if (!verifyInputsSupplier(inputSupplier, inputItem, inputQty)) { return; }
        qty = int.Parse(inputQty);

        if (!SupplyLines.obj.Accounts[inputSupplier].restock(inputItem, qty)) {
            MessageBox.Show("supplier currently doesn't have that order/quantity", "error");
            return;
        }

        //stockSystem.Items[inputItem].Stock += qty;
        StockSystem.obj.stock(inputItem, qty);
        supplierViewRefresh();
        UIStorageUpdate();
        MessageBox.Show("restock successful", "info");
    }
    private void ButtonSupplierOrder_Click(object sender, EventArgs e) {
        //* verifies and order to a specified supplier
        string inputSupplier = textboxSupplierOrderSupplier.Text.Trim().ToUpper();
        string inputItem = textboxSupplierOrderItem.Text.Trim().ToUpper();
        string inputQty = textboxSupplierOrderQty.Text.Trim().ToUpper();
        int qty;

        if (!verifyInputsSupplier(inputSupplier, inputItem, inputQty)) { return; }
        qty = int.Parse(inputQty);

        SupplyLines.obj.Accounts[inputSupplier].order(inputItem, qty);
        supplierViewRefresh();
        MessageBox.Show("order successful", "info");
    }
    #endregion

    #region tab - customer
    private char[] generateValidEmailChars() {
        //* generates constant data for the the 'verifyEmail' method 
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
        //* verifies if email is both valid and appropiate
        char[] validChars = generateValidEmailChars();
        int atSymbolCount = 0;

        if (email == "") { return false; }
        if (email.StartsWith('@') || email.EndsWith('@')) { return false; }
        //^ I keep char count of each code line below 128 <-- I have no idea why I mentioned that here but it's true
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
        //* verifies and add a new customer
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
        if (AllCustomers.obj.findEmail(email)) {
            MessageBox.Show("customer (by email) already exists", "error");
            return;
        }
        AllCustomers.obj.add(email, name);
        MessageBox.Show("customer (with email) added successfully", "successful action");
        refreshRecents();
    }

    private void refreshRecents() {
        //* refresh the display of all customers - to prevent user attempting to add the same customer again
        string[] emails = AllCustomers.obj.viewAllEmails();
        string[] names = AllCustomers.obj.viewAllNames();

        labelCustomerAddRecentEmail.Text = "";
        labelCustomerAddRecentName.Text = "";
        for (int i = 0; i < emails.Length; i++) {
            labelCustomerAddRecentEmail.Text += (emails[i] + "\n");
            labelCustomerAddRecentName.Text += (names[i] + "\n");
        }
    }
    private void buttonCustomerViewInspect_Click(object sender, EventArgs e) {
        //* validates and show specified customer's purchase history
        string email = textboxCustomerView.Text.Trim().ToUpper();
        Purchase[] purchases;

        labelCustomerViewPurchaseDate.Text = "";
        labelCustomerViewPurchaseItems.Text = "";
        labelCustomerViewPurchaseCost.Text = "";

        if (!AllCustomers.obj.findEmail(email)) {
            MessageBox.Show("customer (by email) does not exist", "error");
            return;
        }

        purchases = AllCustomers.obj.viewCustomer(email).Purchases.ToArray();
        if (purchases.Length == 0) { return; }
        foreach (Purchase purchase in purchases) {
            labelCustomerViewPurchaseDate.Text += (purchase.SaleDate + "\n");
            labelCustomerViewPurchaseItems.Text += purchasedItemsToString(purchase.Items);
            labelCustomerViewPurchaseCost.Text += ("\u00A3" + purchase.Price + "\n");
        }
    }

    private string purchasedItemsToString(Dictionary<string, int> purchased) {
        //* convert dictionary to an informative string for display
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
        //* check if a customer (by inputted email) exists
        string email = textboxCheckoutEmail.Text.Trim().ToUpper();
        if (AllCustomers.obj.findEmail(email)) {
            MessageBox.Show("customer (by email) is confirmed to exist", "check successful");
            return true;
        }
        MessageBox.Show("customer (by email) does not exist", "check unsuccessful");
        return false;
    }
    private void buttonCheckoutInspect_Click(object sender, EventArgs e) {
        //* redirects to method
        inspectEmail();
    }
    private decimal refresh() {
        //* displays current items in shopping cart so the user won't do the same intension twice
        //* (responsiveness concept thing)
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
            multipliedPrice = StockSystem.obj.Items[items[i]].Price * qtys[i];
            labelCheckoutPrices.Text += "\u00A3" + multipliedPrice.ToString() + "\n";
            totalPrice += multipliedPrice;
        }
        labelCheckoutTotalPrice.Text = "\u00A3" + totalPrice.ToString();
        return totalPrice;
    }
    private void buttonCheckoutAdd_Click(object sender, EventArgs e) {
        //* vaidates and add a qty of a specified kind of item to the shopping cart
        string inputItem = textboxCheckoutItem.Text.Trim().ToUpper();
        string inputQty = textboxCheckoutQty.Text.Trim().ToUpper();
        int intQty;

        if (!StockSystem.obj.check(inputItem) || !int.TryParse(inputQty, out intQty)) {
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
        //* vaidates and remove a qty of a specified kind of item to the shopping cart
        string inputItem = textboxCheckoutItem.Text.Trim().ToUpper();
        string inputQty = textboxCheckoutQty.Text.Trim().ToUpper();
        int intQty;

        if (!StockSystem.obj.check(inputItem) || !int.TryParse(inputQty, out intQty)) {
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
        //* final validation and executing shopping cart order
        decimal totalPrice = refresh();
        Purchase purchase;

        if (!inspectEmail()) { return; }
        if (!checkStock(shoppingCart)) { return; }

        purchase = new Purchase(DateTime.Now, totalPrice, shoppingCart);
        AllCustomers.obj.addPurchase(textboxCheckoutEmail.Text.Trim().ToUpper(), purchase);
        //: remove stock
        foreach (KeyValuePair<string, int> item in shoppingCart) {
            StockSystem.obj.sell(item.Key, item.Value);
        }

        MessageBox.Show("purchase successful", "successful action");
    }
    private bool checkStock(Dictionary<string, int> shoppingCart) {
        //* validates that starage has enough stock to carry out the current order
        foreach (KeyValuePair<string, int> item in shoppingCart) {
            if (StockSystem.obj.Items[item.Key].Stock < item.Value) {
                MessageBox.Show("atleast one type of item has a higher qty than stock!", "ERROR");
                return false;
            }
        }
        return true;
    }
    private void buttonCheckoutCancel_Click(object sender, EventArgs e) {
        //* removes all infomation on current order - so user won't accidently carry out another order with the wrong data
        shoppingCart.Clear();
        textboxCheckoutEmail.Text = "";
        textboxCheckoutItem.Text = "";
        textboxCheckoutQty.Text = "";
        MessageBox.Show("cancellation sucessful", "succesful action");
    }
    #endregion


}
