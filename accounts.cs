using System.Web;
using System.Xml.Linq;
using U10803___Assessment_1;
#region dependent classes
public sealed class AllCustomers : DictAPI<Customer> { //* dependent on 'Customer' struct class
    #region singleton
    static private readonly AllCustomers singleton = new AllCustomers();
    public static AllCustomers obj { get { return singleton; } }
    #endregion
    #region intialiser

    private AllCustomers() {
        Accounts = new Dictionary<string, Customer>();
    }
    public Dictionary<string, Customer> Accounts { get; }
    #endregion
    #region methods
    public bool findEmail(string email) { //* validator

        if (Accounts.ContainsKey(email)) { return true; }; 
        return false;
    }
    public void add(string email, string name) { //* mutator

        Accounts.Add(email, new Customer(name, email));
    }
    public Customer viewCustomer(string email) { //* accessor

        return Accounts[email];
    }
    public string[] viewAllEmails() { //* accessor

        return Accounts.Keys.ToArray();
    }
    public string[] viewAllNames() { //* accessor
        string[] names = new string[Accounts.Count];
        Customer[] customersObjs = Accounts.Values.ToArray();
        //^ get customers to see thier names


        for (int i = 0; i < names.Length; i++) { names[i] = customersObjs[i].Name; }
        //^ stores all wanted strings into an array
        return names;
    }
    public void addPurchase(string email, Purchase purchase) { //* mutator

        Accounts[email].addPurchase(purchase);
    }
    #endregion
}
public struct Customer { //* dependent on 'Purchase' struct class
    #region initialiser

    public Customer(string name, string email) {
        Name = name;
        Email = email;
        Purchases = new List<Purchase>();
    }
    public string Name { get; }
    //^ to be accessed by 'AllCustomers' class
    public string Email { get; }
    //^ to be accessed by 'AllCustomers' class
    public List<Purchase> Purchases { get; }
    //^ to be accessed by 'Form1.cs'
    #endregion
    #region methods
    public void addPurchase (Purchase purchase) { //* mutator

        Purchases.Add(purchase);
    }
    #endregion
}
#endregion
#region independent classes
public struct Purchase { //* dependent, no methods
    #region initialisers

    public Purchase(DateTime saleDate, decimal price, Dictionary<string, int> items) {
        SaleDate = saleDate;
        Price = price;
        Items = items;
    }
    public DateTime SaleDate { get; }
    //^ to be accessed by 'Form1.cs'
    public decimal Price { get; }
    //^ to be accessed by 'Form1.cs'
    public Dictionary<string, int> Items { get; }
    //^ to be accessed by 'Form1.cs'
    #endregion
}
#endregion