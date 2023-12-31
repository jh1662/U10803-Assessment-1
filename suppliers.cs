﻿#region dependent classes
using U10803___Assessment_1;

public sealed class SupplyLines : DictAPI<Supplier> { //* dependent on 'Supplier' (struct)
    //^ I think using singleton pattern class is better to use over a static class.
    #region singleton
    static private readonly SupplyLines singleton = new SupplyLines();
    public static SupplyLines obj { get { return singleton; } } //< "obj" short for "object"
    #endregion
    #region initialisers
    private SupplyLines() {
        Accounts = new Dictionary<string, Supplier>();
    }

    public Dictionary<string, Supplier> Accounts { get; }
    //^ to be accessed by 'Form1.cs'
    #endregion
    #region methods
    public bool add (string name) { //* mutator, validator

        if (Accounts.ContainsKey(name)) {  return false; }
        //^ validates that supplier doesn't exist
        Accounts[name] = new Supplier();
        //^ creates and store new supplier
        return true;
        //^ method call is successful
    }
    #endregion
}
#endregion
#region independent classes
public struct Supplier { //* independent
    #region initialisers

    public Supplier() {
        StockDict = new Dictionary<string, int>();
        //^ stock is ordered but haven't arrived yet
    }

    public Dictionary<string, int> StockDict { get; }
    //^ to be accessed by 'Form1.cs'
    #endregion
    #region methods
    public void order(string itemName, int qty) { //* mutator
         
        if (!StockDict.ContainsKey(itemName)) {
            //: if specified stock doesn't exist
            StockDict[itemName] = qty;
            return;
        }
        //: specified stock exist:
        StockDict[itemName] += qty;
    }
    public bool restock(string itemName, int qty) { //* mutator, validator

        if (!StockDict.ContainsKey(itemName)) { return false; }
        //^ validates that stock exists
        if ((StockDict[itemName] - qty) < 0) { return false; }
        //^ validates that stock qty is positive
        StockDict[itemName] -= qty;
        //^ restocking
        return true;
        //^ method call is sucessful
    }
    #endregion
}
#endregion