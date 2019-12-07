// CIDM-4360-70
    // Vanessa Valenzuela
    // Matthew Webb
    // 12/06/2019

using System;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill b = new Bill("01/02/2019","Utility Nov 1, 2018 to Dec 31, 2018",500);
            Payment p1 = new Cash(230,"01/15/2019", 240);
            Payment p2 = new Check(100,"Chase","John Doe","111111","01/01/2019");
            Payment p3 = new CreditCard(100,"1234-5678-9012-3456","Visa","01/01/2022","John Doe","01/01/2019");
            
            Console.WriteLine($"Bill Info.:\n{b.getBillInfo()}");


            
            Console.WriteLine("\n--------------new payment-------------------------");
            b.addPayment(p1);
            Console.WriteLine($"Bill Info.:\n{b.getBillInfo()}");
            
            Console.WriteLine("\n--------------new payment-------------------------");
            b.addPayment(p2);
            Console.WriteLine($"Bill Info.:\n{b.getBillInfo()}");
            
            Console.WriteLine("\n--------------new payment-------------------------");
            b.addPayment(p3);
            Console.WriteLine($"Bill Info.:\n{b.getBillInfo()}");
            
	   // Uncomment the following line to test Task B.2 of CIDM 5360 assignment
            //b.makePaymentPlan(5);
        }
    }
}
