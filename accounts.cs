public class Customer {
    public string name;
    public string email;
    public 
}

public class Purchase {
    public DateTime saleDate;
    public decimal price;
    public Dictionary<string, Item> items = new Dictionary<string, Item>();
}