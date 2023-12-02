#region dependent classes
public class SupplyLines { //* dependent on 'Supplier' (struct)
    #region singleton

    #endregion
    #region initialisers

    public SupplyLines() {
        SupplierDict = new Dictionary<string, Supplier>();
    }

    public Dictionary<string, Supplier> SupplierDict { get; }
    //^ to be accessed by 'Form1.cs'
    #endregion
    #region methods
    public bool Add(string name) { //* mutator, validator

        if (SupplierDict.ContainsKey(name)) {  return false; }
        //^ validates that supplier doesn't exist
        SupplierDict[name] = new Supplier();
        //^ creates and store new supplier
        return true;
        //^ method call is successful
    }
    #endregion
}
#endregion
#region independent classes
public struct Supplier { //* independent
    #region initialisers

    public Supplier() {
        StockDict = new Dictionary<string, int>();
        //^ stock is ordered but haven't arrived yet
    }

    public Dictionary<string, int> StockDict { get; }
    //^ to be accessed by 'Form1.cs'
    #endregion
    #region methods
    public void order(string itemName, int qty) { //* mutator
         
        if (!StockDict.ContainsKey(itemName)) {
            //: if specified stock doesn't exist
            StockDict[itemName] = qty;
            return;
        }
        //: specified stock exist:
        StockDict[itemName] += qty;
    }
    public bool restock(string itemName, int qty) { //* mutator, validator

        if (!StockDict.ContainsKey(itemName)) { return false; }
        //^ validates that stock exists
        if ((StockDict[itemName] - qty) < 0) { return false; }
        //^ validates that stock qty is positive
        StockDict[itemName] -= qty;
        //^ restocking
        return true;
        //^ method call is sucessful
    }
    #endregion
}
#endregion