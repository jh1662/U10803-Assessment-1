#region dependent classes
using System.Web;
using System.Xml.Linq;

public class AllCustomers {
    public AllCustomers() {

        Accounts = new Dictionary<string, Customer>();
    }
    public Dictionary<string, Customer> Accounts { get; }
    public bool findEmail(string email) {
        if (Accounts.ContainsKey(email)) { return true; }; 
        return false;
    }
    public void addCustomer(string email, string name) {
        Accounts.Add(email, new Customer(name, email));
    }
    public Customer viewCustomer(string email) {
        return Accounts[email];
    }
    public string[] viewAllEmails() {
        return Accounts.Keys.ToArray();
    }
    public string[] viewAllNames() {
        string[] names = new string[Accounts.Count];
        Customer[] customersObjs = Accounts.Values.ToArray();
        for (int i = 0; i < names.Length; i++) { names[i] = customersObjs[i].Name; }
        return names;
    }
    public void addPurchase(string email, Purchase purchase) {
        Accounts[email].addPurchase(purchase);
    }
}
public struct Customer {
    public Customer(string name, string email) {
        Name = name;
        Email = email;

        Purchases = new List<Purchase>();
    }
    public string Name { get; }
    public string Email { get; }
    public List<Purchase> Purchases { get; }
    public void addPurchase (Purchase purchase) {
        Purchases.Add(purchase);
    }
}
#endregion
#region independent classes
public struct Purchase {
    public Purchase(DateTime saleDate, decimal price, Dictionary<string, int> items) {
        SaleDate = saleDate;
        Price = price;
        Items = items;
    }
    public DateTime SaleDate { get; }
    public decimal Price { get; }
    public Dictionary<string, int> Items { get; }
}
#endregion