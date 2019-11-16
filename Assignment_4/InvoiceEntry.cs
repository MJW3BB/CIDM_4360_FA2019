using System;
using System.Collections.Generic;

class InvoiceEntry
{
    int LineNo;
    int Qnty;
    //Invoice assignedTo;
    public Item itemNumber;
  
    //List<Item> items = new List<Item>(); 
    public InvoiceEntry(Item i, int line, int quantity)
    {
        itemNumber=i;
        LineNo=line;
        Qnty=quantity;
    }
    public int getLineNumber()
    {
        return LineNo;
    }
    public int setLineNumber(int Num)
    {
        LineNo=Num;
        return LineNo;
    }
    public int getQnty()
    {
        return Qnty;
    }

}