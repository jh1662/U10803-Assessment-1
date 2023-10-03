public class Customer {
    public string name;
    public string email;
    public List<Purchase> purchases = new List<Purchase>();
}

public class Purchase {
    public DateTime saleDate;
    public decimal price;
    public Dictionary<string, Item> items = new Dictionary<string, Item>();
}

public class Supplier {
    string name;
    public Dictionary<string, Item> stockList = new Dictionary<string, Item>();
}