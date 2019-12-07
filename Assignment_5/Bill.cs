using System;
using System.Collections.Generic;

class Bill
{
    public string billDate; // Date of Bill Paid
    public string description; // Summary of Bill 
    public double amount; // Bill total amount
    // Bill CONSTRUCTOR
    public Bill(string dateOfBill, string descOfBill, double amountOfBill){
        this.billDate = dateOfBill; 
        this.description = descOfBill;
        this.amount = amountOfBill;
    }
    // getBillInfo METHOD
    public string getBillInfo(){ // Return string contains all information in the bill including the payments. See the main() method and sample output to see what information is returned and then printed.
            string consolePrint = $"\nDate: {billDate} \nDescription: {description} \nAmount Due: ${amount}";
            foreach(var p in PaymentList)
            {
                consolePrint += $"\nOn {p.getPaymentDate()} payment with {p.getPaymentType()} the amount ${p.amount} was processed.";
            }
            consolePrint += $"\nTotal paid: {getAmountPaid()} \nRemaining Balance: {amount - getAmountPaid()}";
            return consolePrint;
    }
    List<Payment> PaymentList = new List<Payment>(); // List Object contains the details regarding Payments
    // getBalance METHOD
    public double getBalance(double total, double balance){ // Calculate the remaining balance by calculating the difference between the total of payments and the bill’s original amount 
        double getBalanceTotal = 0;
        foreach (var a in PaymentList)
        {
            getBalanceTotal = total;
        }
        return amount - getAmountPaid();
    }
    // getAmountPaid METHOD
    public double getAmountPaid(){ // Calculates the total paid on the balance in any given account. 
        double Total=0;
        foreach(var b in PaymentList)
        {
            Total=Total+b.getAmount();
        }
        return Total;
    } 

    // addPayment METHOD
    public bool addPayment(Payment p){ // It calls verify() method first, and if verify is successful it adds the payment to the bill payments. 
        if(p.verify() == true){
            PaymentList.Add(p);
            return true;
        }
        return false;
    }
}