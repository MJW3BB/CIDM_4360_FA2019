using System;
using System.Collections.Generic;

class Invoice
{
    int i = 1;
    int InvNum;
    string InvDate;
    float total=0.00f;
    List<InvoiceEntry> itemList = new List<InvoiceEntry>();
    
    //constructor
    public Invoice (int number, string date)
    {
        InvNum=number;
        InvDate=date;
    }
    //method to add inventory item
    public bool addInvEntry(Item a, int ReqQuantity)
    {  
        if(a.updateAvlblQty(ReqQuantity) == true)
        {
            InvoiceEntry name = new InvoiceEntry(a, i, ReqQuantity);
            updateTotal(a.getPrice());
            itemList.Add(name);
            i++;
            return true;
        }
        else
        {
            return false;
        }
    }
    //method to remove inventory item
    public bool removeInvEntry(int lineNumber)
    {   
        bool successful = false;
        if(itemList != null)
        {
            foreach(InvoiceEntry i in itemList.ToArray())
            {
                if(i.getLineNumber() == lineNumber)
                {
                    //get the quanity of item to remove so it can be added back to inventory
                    int quan=i.getQnty();
                    //need to add it back to the item available quanity
                    //INCOMPLETE
                    
                    //index starts at 0, so had to subtract 1 from the line number to remove it
                    //at the correct index
                    itemList.RemoveAt(lineNumber-1);
                    
                    //itemList.Remove(i);
                    updateLineNumbers();
                    printInvoice();
                    successful = true;
                    
                }
            }
            if (successful == true)
            {
                return true;
            }else 
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    //method to update total
    public void updateTotal(float newValue)
    {
        total=total+newValue;
    }
   
    //method to update line nubmer
    public void updateLineNumbers()
    {
        i=1;
        foreach(InvoiceEntry b in itemList)
        {
            b.setLineNumber(i);
            i++;
        }
    }
    //method to print invoice
    public void printInvoice() 
    {
        float entryTotal;
        total = 0.00f;
        Console.WriteLine($"\nInvoice #: {InvNum}\t Date: {InvDate}" );
        Console.WriteLine("  L#     Description  Quantity U.Price Total");
        Console.WriteLine("------- -------------- ------- ------- -------");
        foreach(InvoiceEntry c in itemList)
        {
            entryTotal = c.itemNumber.getPrice() * c.getQnty();
            Console.WriteLine($"{Convert.ToString(c.getLineNumber())}      {c.itemNumber.getItemDescription()}\t{c.getQnty()}\t{c.itemNumber.getPrice()}    {entryTotal}");
            updateTotal(entryTotal);  
        }
        Console.WriteLine("------- -------------- ------- ------- -------");
        Console.WriteLine("------- -------------- ------- ------- "+"\t"+ total);
    }
}