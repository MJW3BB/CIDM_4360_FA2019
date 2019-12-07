using System;
using System.Collections.Generic;

class CreditCard : Payment //  Derived from Payment class 
{
    private string CCNum; //credit card number
    private string expDate; //Expiration date
    private string CHolderName; //Card holder name
    private string CType; //Visa,Mastercard,etc... 

    // CreditCard CONSTRUCTOR
    public CreditCard(double amount, string CCNum, string CType, string expDate, string CCHolderName, string paymentDate ) : base(amount, paymentDate){
        this.CCNum = CCNum;
        this.CType = CType; 
        this.expDate = expDate;
        this.CHolderName = CCHolderName;
    }
    // verify METHOD
    public override bool verify(){ // Overrides the base class method, it writes to the console the message "Credit card verified" and returns true.
        Console.WriteLine("Credit Card verified...");
        return true;
    }
    // getPaymentType METHOD
    public override string getPaymentType(){ // Overrides the base class abstract method. It returns the string “Credit Card” that represents the payment type of this class.
        return "Credit Card";
    }
}