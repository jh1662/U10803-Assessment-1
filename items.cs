using System.Transactions;

public class StockSystem {
    public Dictionary<string,Item> items = new Dictionary<string,Item>();

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
}

//------------------------------------------------------------------------------------------------------------------------------
//# classes that doesn't call non-system objects

public class Item {
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

        if(checkStock < 0) { return false; }
        return true;
    }
    public void add(int qty) { //* modifier

        this.stock += qty;
    }
}

public class Shoe : Item{
    public decimal size;
    public string type;
    public Shoe(string name, decimal price, int stock, decimal size, string type) : base(name, price, stock) {
        this.size = size;
        this.type = type;
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
}
public class Accessory : Item {
    string accessoryType;
    public Accessory(string name, decimal price, int stock) : base(name, price, stock) {
        this.accessoryType = "heuristic text";
    }
}
//------------------------------------------------------------------------------------------------------------------------------
#region children of the 'Accessory' class
public class Bag : Accessory {
    public decimal capacity;
    public Bag(string name, decimal price, int stock, decimal capacity) 
    : base(name, price, stock) {
        this.capacity = capacity;
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
}
public class Drink : Accessory {
    public decimal capacity;
    public string type;
    public Drink(string name, decimal price, int stock, decimal capacity, string type)
    : base(name, price, stock) {
        this.capacity = capacity;
        this.type = type;
    }
}
#endregion