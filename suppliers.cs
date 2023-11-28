#region dependent classes
public class SupplyLines { //* dependent on 'Supplier' (struct)
    #region initialisers

    public SupplyLines() {
        SupplierDict = new Dictionary<string, Supplier>();
    }

    public Dictionary<string, Supplier> SupplierDict { get; }
    #endregion
    #region methods
    public Boolean Add(string name) {
        if (SupplierDict.ContainsKey(name)) {  return false; }
        SupplierDict[name] = new Supplier();
        return true;
    }
    #endregion
}
#endregion
#region independent classes
public struct Supplier { //* independent
    #region initialisers

    public Supplier() {

        StockDict = new Dictionary<string, int>();
    }

    public Dictionary<string, int> StockDict { get; }
    #endregion
    public void order(string itemName, int qty) {
        
        if (!StockDict.ContainsKey(itemName)) {
            StockDict[itemName] = qty;
            return;
        }
        StockDict[itemName] += qty;
    }
    public bool restock(string itemName, int qty) {

        if (!StockDict.ContainsKey(itemName)) { return false; }
        if ((StockDict[itemName] - qty) < 0) { return false; }
        StockDict[itemName] -= qty;
        return true;
    }
}
#endregion