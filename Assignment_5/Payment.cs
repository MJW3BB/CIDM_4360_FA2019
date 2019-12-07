using System;
using System.Collections.Generic;

abstract class Payment
{
    public double amount; // Amount of this payment
    public string paymentDate; // Date of this payment

    // Payment CONSTRUCTOR
    public Payment(double payAmount, string payDate){ // Constructor to be called by derived classes
        amount = payAmount;
        paymentDate = payDate; 
    }
    // getAmount METHOD
    public double getAmount(/*double amount*/){ // returns the payment amount attribute
        // this.amount = amount;
        return amount;
    }
    // getPaymentDate METHOD
    public string getPaymentDate(/*string paymentDate*/){ // Returns the paymentDate attribute
        // this.paymentDate = paymentDate;
        return paymentDate;
    }
    // verify METHOD
    public virtual bool verify(){ // Writes to the console the message “Payment verified“, and returns true. Need to be overloaded by derived classes if needed.
        Console.WriteLine("\tPayment verified...\n");
        return true;
    }
    public abstract string getPaymentType(); // Has no implementation (abstract) in this class, and it need to be implemented in all derived classes.
}