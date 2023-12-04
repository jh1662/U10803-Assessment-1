using System.Transactions;
/*
 * "The shop stocks a number of items for sale – sports clothing, running shoes and otheraccessories (Bags, Nutrition and Watches)"
 * DOES NOT SAY ANYTHING ABOUT ADDING ANY ACCESSORY AS THE USER WILL TO >:(
*/
#region dependent classes
public sealed class StockSystem { //* dependent on 'Item' abstract class (polymorphism)
    #region singleton
    static private readonly StockSystem singleton = new StockSystem();
    public static StockSystem obj { get { return singleton; } } //< "obj" short for "object"
    #endregion
    #region initialiser
    //private Dictionary<string,Item> items = new Dictionary<string,Item>();
    private StockSystem() {
        Items = new Dictionary<string, Item>();
    }
    public Dictionary<string, Item> Items { get; }
    #endregion
    #region methods
    public bool newItem(string name, Item itemObject) { //* mutator, validator

        if (Items.ContainsKey(name)) { return false; }
        //! need to check if attributes of objects match 
        Items.Add(name, itemObject);
        return true;
    }
    public bool sell(string name, int qty) { //* mutator, validator

        if (!Items.ContainsKey(name)) { return false; }
        //^ validates
        if (!Items[name].sell(qty)) { return false; }
        //^ validates and mutates
        return true;
        //^ successful method call
    }
    public bool stock(string name, int qty) { //* mutator, validator

        if (!Items.ContainsKey(name)) { return false; }
        //^ validates
        Items[name].add(qty);
        //^ mutates 
        return true;
        //^ successful method call
    }
    public bool add(Item item) { //* mutator, validator

        if (Items.ContainsKey(item.Name)) { return false; }
        //^ validates
        Items[item.Name] = item;
        //^ mutates 
        return true;
        //^ successful method call
    }
    public bool check(string name) { //* validator

        if (!Items.ContainsKey(name)) { return false; }
        return true;
        //^ successful method call
    }
    #endregion
}
#endregion
#region independent classes
public abstract class Item { //* independent, parent of classes: 'Shoe', 'Clothing', and 'Accessory'
    #region initialisers
    //public string name;
    //public decimal price;
    //public int stock;
    private int stock;
    //^ No idea why but property won't work without the attribute!!
    public Item(string name, decimal price, int stock) {
        Name = name;
        Price = price;
        this.stock = stock;
    }
    public string Name { get; }
    //^ to be accessed by 'Form1.cs' and 'StockSystem' class
    public decimal Price { get; }
    //^ to be accessed by 'Form1.cs'
    public int Stock { get { return this.stock; } }
    //^ to be accessed by 'Form1.cs'
    #endregion
    #region methods
    public bool sell(int qty) { //* validator, modifier
        int checkStock = Stock - qty;

        if (checkStock < 0) { return false; }
        stock -= qty;
        return true;
    }
    public void add(int qty) { //* modifier

        this.stock += qty;
    }
    public abstract string giveUniqueDetails();
    //^ to be specificly implemented only be the type of items.
    //^ its purpose is to format item's characteristics into a readable string
    #endregion
}

public sealed class Shoe : Item { //* independent
    #region initialisers
    private decimal size;
    private string type;
    public Shoe(string name, decimal price, int stock, decimal size, string type) : base(name, price, stock) {
        this.size = size;
        this.type = type;
    }

    #endregion
    #region methods
    override public string giveUniqueDetails() { //* accessor

        return $"size - {this.size}, type - {this.type}";
    }
    #endregion
}
public sealed class Clothing : Item { //* independent
    #region intialisers
    private int size;
    private string type;
    private string style;
    public Clothing(string name, decimal price, int stock, int size, string type, string style) : base(name, price, stock) {
        this.size = size;
        this.type = type;
        this.style = style;
    }

    #endregion
    #region methods
    override public string giveUniqueDetails() { //* accessor
        return $"size - {this.size}, type - {this.type}, style - {this.style}";
    }
    #endregion
}
//# A clothing shop doesn't primarily sell accessories but if the shop decides to sell them as side-prodcts then they will
//# most likely sell more types, of accessories, than what the developer can think of (watch, bag, drink, etc). Because of
//# this, making a class for each accessory type is beyond inpractical unless the program itself can create more classes
//# during runtime at the user's need/command which makes it besically AI - code that makes more code - at this point.
//# I would just put the accessories' type and each of thier unique qualities as extra attributes in the only
//# accessory class but the course-work assesses polymorphism so I'll pretend that those 3 accessories are the only ones
//# that the shop will ever need.
public abstract class Accessory : Item { //* independent
    #region initialisers

    public Accessory(string name, decimal price, int stock) : base(name, price, stock) { }

    #endregion
}
//------------------------------------------------------------------------------------------------------------------------------

#region children of the 'Accessory' class
public sealed class Bag : Accessory { //* independent, parent of classes: 'Watch', 'Bag', and 'Drink'
    #region initialisers
    private decimal capacity;
    public Bag(string name, decimal price, int stock, decimal capacity) 
    : base(name, price, stock) {
        this.capacity = capacity;
    }

    #endregion
    #region methods
    override public string giveUniqueDetails() { //* accessor
        return $"capacity - {this.capacity}";
    }
    #endregion
}
public sealed class Watch : Accessory { //* independent
    #region initialisers
    private bool hasGPS;
    private bool hasRate;
    public Watch(string name, decimal price, int stock, bool hasGPS, bool hasRate)
    : base(name, price, stock) {
        this.hasGPS = hasGPS;
        this.hasRate = hasRate;
    }

    #endregion
    #region methods
    override public string giveUniqueDetails() { //* accessor
        return $"has GPS? - {this.hasGPS}, has heart rate? - {this.hasRate}";
    }
    #endregion
}
public sealed class Drink : Accessory { //* independent
    #region initialisers    
    private decimal capacity;
    private string type;
    public Drink(string name, decimal price, int stock, decimal capacity, string type)
    : base(name, price, stock) {
        this.capacity = capacity;
        this.type = type;
    }

    #endregion
    #region methods
    override public string giveUniqueDetails() { //* accessor
        return $"capacity - {this.capacity}, type - {this.type}";
    }
    #endregion
}
#endregion
#endregion