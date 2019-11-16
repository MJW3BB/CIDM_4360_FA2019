using System;
using System.Collections.Generic;

class Item
{
    int ID;
    string Description;
    float AvailableQty;
    float UnitPrice;
    //InvoiceEntry line;
    
    public Item (int itemID, string desc, float price, float aQTY)
    {
        ID=itemID;
        Description=desc;
        AvailableQty=aQTY;
        UnitPrice=price;
    }

    public bool updateAvlblQty(float passedValue)
    {
        if(AvailableQty-passedValue >=0)
        {
            AvailableQty=AvailableQty-passedValue;
            Console.WriteLine("The new quantity of this item is " + AvailableQty);
            return true;
        }else
        {
            return false;
        }
        
    }
    public float getPrice()
    {
        return UnitPrice;
    }
    public string getItemDescription()
    {
        return Description;
    }
    public int getItemID()
    {
        return ID;
    }
    public void displayItem() 
    {
        Console.WriteLine($"\t{Convert.ToString(ID)}   {Description}\t {UnitPrice}\t {AvailableQty}");
    }

}