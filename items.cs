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
        bool checkStock;

        if (!items.ContainsKey(name)) { return false; }
        if (!items[name].sell(qty)) { return false; }
        return true;
    }
    public bool add(string name, int qty) {
        if (!items.ContainsKey(name)) { return false; }
        items[name].add(qty);
        return true;
    }
}

public class Item {
    public string name;
    public decimal price;
    public int stock; // USING "{get; set;}" DEFEATS THE PURPOSE OF USING PRIVATE ACCESS MODIFIER! (hence why I used public instead)
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
    public Accessory(string name, decimal price, int stock) : base(name, price, stock) {
    }
}
/*
public class Bag : Accessory {
    public decimal capacity;
}
public class Watch : Accessory {
    public bool hasGPS;
    public bool hasRate;
}
public class Drink : Accessory {
    public decimal capacity;
    public string type;
}
*/