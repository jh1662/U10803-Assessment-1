using System.Transactions;

public class StockSystem {
    private Dictionary<string,Item> items = new Dictionary<string,Item>();
    public Dictionary<string, Item> Items { get { return items; } }

    public bool newItem(string name, Item itemObject) {
        if (items.ContainsKey(name)) { return false; }
        //! need to check if attributes of objects match 
        items.Add(name, itemObject);
        return true;
    }
    public bool sell(string name, int qty) {

        if (!items.ContainsKey(name)) { return false; }
        if (!items[name].sell(qty)) { return false; }
        return true;
    }
    public bool stock(string name, int qty) {
        if (!items.ContainsKey(name)) { return false; }
        items[name].add(qty);
        return true;
    }
    public bool add(Item item) {
        if (items.ContainsKey(item.name)) { return false; }
        items[item.name] = item;
        return true;
    }
    public bool check(string name) {
        if (!items.ContainsKey(name)) { return false; }
        return true;
    }

}

//------------------------------------------------------------------------------------------------------------------------------
//# classes that doesn't call non-system objects

public abstract class Item {
    public string name;
    public decimal price;
    public int stock;
    //^ USING "{get; set;}" DEFEATS THE PURPOSE OF USING PRIVATE ACCESS MODIFIER! (hence why I used public instead)
    // public int orderStockLevel;
    public Item(string name, decimal price, int stock) {
        this.name = name;
        this.price = price;
        this.stock = stock;
    }

    public bool sell(int qty) { //* modifier
        int checkStock = this.stock - qty;

        if (checkStock < 0) { return false; }
        return true;
    }
    public void add(int qty) { //* modifier
        this.stock += qty;
    }
    public abstract string giveUniqueDetails();
}

public class Shoe : Item{
    public decimal size;
    public string type;
    public Shoe(string name, decimal price, int stock, decimal size, string type) : base(name, price, stock) {
        this.size = size;
        this.type = type;
    }
    override public string giveUniqueDetails() { //* accessor
        return $"size - {this.size}, type - {this.type}";
    }
}
public class Clothing : Item {
    public int size;
    public string type;
    public string style;
    public Clothing(string name, decimal price, int stock, int size, string type, string style) : base(name, price, stock) {
        this.size = size;
        this.type = type;
        this.style = style;
    }
    override public string giveUniqueDetails() { //* accessor
        return $"size - {this.size}, type - {this.type}, style - {this.style}";
    }
}
//# A clothing shop doesn't primarily sell accessories but if the shop decides to sell them as side-prodcts then they will
//# most likely sell more types, of accessories, than what the developer can think of (watch, bag, drink, etc). Because of
//# this, making a class for each accessory type is beyond inpractical unless the program itself can create more classes
//# during runtime at the user's need/command which makes it besically AI - code that makes more code - at this point.
//# I would just put the accessories' type and each of thier unique qualities as extra attributes in the only
//# accessory class but the course-work assesses polymorphism so I'll pretend that those 3 accessories are the only ones
//# that the shop will ever need.
public abstract class Accessory : Item {

    public Accessory(string name, decimal price, int stock) : base(name, price, stock) { }
}
//------------------------------------------------------------------------------------------------------------------------------

#region children of the 'Accessory' class
public class Bag : Accessory {
    public decimal capacity;
    public Bag(string name, decimal price, int stock, decimal capacity) 
    : base(name, price, stock) {
        this.capacity = capacity;
    }
    override public string giveUniqueDetails() { //* accessor
        return $"capacity - {this.capacity}";
    }
}
public class Watch : Accessory {
    public bool hasGPS;
    public bool hasRate;
    public Watch(string name, decimal price, int stock, bool hasGPS, bool hasRate)
    : base(name, price, stock) {
        this.hasGPS = hasGPS;
        this.hasRate = hasRate;
    }
    override public string giveUniqueDetails() { //* accessor
        return $"has GPS? - {this.hasGPS}, has heart rate? - {this.hasRate}";
    }
}
public class Drink : Accessory {
    public decimal capacity;
    public string type;
    public Drink(string name, decimal price, int stock, decimal capacity, string type)
    : base(name, price, stock) {
        this.capacity = capacity;
        this.type = type;
    }
    override public string giveUniqueDetails() { //* accessor
        return $"capacity - {this.capacity}, type - {this.type}";
    }
}
#endregion
