using System;
using System.Collections.Generic;

class Check : Payment
{
    private string Bank; //Bank Name
    private string custName; //Customer/client name
    private string accNum; // Account number
    // Check CONTSTRUCTOR
    public Check(double amount, string Bank, string custName, string accNum, string paymentDate) : base(amount, paymentDate){
        this.Bank = Bank; 
        this.custName = custName; 
        this.accNum = accNum;
    }

    public override bool verify(){ // Overrides the base class method, it writes to the console the message "Signature and account Balance verified" and returns true; 
        Console.WriteLine("Signature and balance verified...");
        return true;
    }

    public override string getPaymentType(){ // Overrides the base class abstract method. It returns the string “Check” that represents the payment type of this class
        return "Check";
    }
}