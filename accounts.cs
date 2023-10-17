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