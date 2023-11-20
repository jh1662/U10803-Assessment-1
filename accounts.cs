#region dependent classes
using System.Web;

public class AllCustomers {
    public Dictionary<string, Customer> accounts = new Dictionary<string,Customer>();
    public bool findEmail(string email) {
        if (accounts.ContainsKey(email)) { return true; }; 
        return false;
    }
    public void addCustomer(string email, string name) {
        accounts.Add(email, new Customer(name, email));
    }
    public Customer viewCustomer(string email) {
        return accounts[email];
    }
    public string[] viewAllEmails() {
        return accounts.Keys.ToArray();
    }
    public string[] viewAllNames() {
        string[] names = new string[accounts.Count];
        Customer[] customersObjs = accounts.Values.ToArray();
        for (int i = 0; i < names.Length; i++) { names[i] = customersObjs[i].name; }
        return names;
    }
}
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
#endregion
#region independent classes
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
#endregion