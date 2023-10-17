#region dependent classes
public class SupplyLines { //* dependent
    public Dictionary<string, Supplier> SupplierDict = new Dictionary<string, Supplier>();
    public Boolean Add(string name) {
        if (SupplierDict.ContainsKey(name)) {  return false; }
        SupplierDict[name] = new Supplier(name);
        return true;
    }
}
#endregion
#region independent classes
public class Supplier { //* independent
    string name;
    public Dictionary<string, int> stockDict = new Dictionary<string, int>();
    public Supplier(string name) {
        this.name = name;
    }
    public void order(string itemName, int qty) {

        stockDict[itemName] += qty;
    }
    public bool restock(string itemName, int qty) {

        if (!stockDict.ContainsKey(itemName)) { return false; }
        if ((stockDict[itemName] - qty) < 0) { return false; }
        stockDict[itemName] -= qty;
        return true;
    }
}
#endregion