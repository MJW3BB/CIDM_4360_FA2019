using System;
using System.Collections.Generic;

class Cash : Payment
{
    public double tenderedCash; //Cash provided by customer, e.g. $200
    public double change; // Change should be returned to customer, e.g. if payment amount is $196, the customer provided $200, then he should get back $4 

    // Cash CONSTRUCTOR
    
    public Cash(double amountCash, string dateCash, double givenCash) : base(amountCash, dateCash){ // Call the base class constructor with the needed parameters
        tenderedCash = amountCash;
        this.change = amountCash - givenCash; 
    }
    // calcChange METHOD
    public double calcChange(double change){ //  updates the change attribute, and returns the change. Change = tenderedCash – payment amount. Note that amount in base class (Payment) is private (not protected and not public)
        change = tenderedCash - amount; 
        return this.change;
    }
    public override string getPaymentType(){ // Overrides the base abstract class method,returns the string “Cash” that represents the payment type of this class. To be used when displaying Payment types, like in getBillInfo(). 
        return "Cash";
    }

}