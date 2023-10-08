public class Customer {
    public string name;
    public string email;
    public List<Purchase> purchases = new List<Purchase>();
    public Customer(string name, string email) {
        this.name = name;
        this.email = email;
    }

    public void addPurchase (Purchase purchase) {

        purchases.Add(purchase);
    }
}

public class Purchase {
    public DateTime saleDate;
    public decimal price;
    public Dictionary<string, int> items = new Dictionary<string, int>();
    public Purchase(DateTime saleDate, decimal price, Dictionary<string, int> items) { 
        this.saleDate = saleDate;
        this.price = price;
        this.items = items;
    }
}

public class Supplier {
    string name;
    public Dictionary<string, int> stockList = new Dictionary<string, int>();
    public Supplier(string name) {
        this.name = name;
    }

    public void order(string itemName, int qty) {

        stockList[itemName] += qty;
    }
    public bool restock(string itemName, int qty) {

        if (!stockList.ContainsKey(itemName)) { return false; }
        if ((stockList[itemName]-qty)<0) { return false; }
        stockList[itemName] -= qty;
        return true;
    }
}