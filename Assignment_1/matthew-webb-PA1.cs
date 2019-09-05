// Matthew Webb

using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display title.
            Console.WriteLine("Assignment 1 - Matthew Webb [CIDM-4360]\r");
            Console.WriteLine("\n");

            bool endApp = false;
            while(!endApp)
            {
                // Main Menu
                Console.WriteLine("Choose and option.");
                Console.WriteLine("\ta. - Enter Expression");
                Console.WriteLine("\tb. - Check the anwser");
                Console.WriteLine("\tc. - Display Score");
                Console.WriteLine("\td. - Exit");
                Console.Write("Your option? : ");

                // Declare input variables and then initialize them to zero.
                int Number1 = 0; int Number2 = 0;
                // Declare score and then initialize to zero.
                int UserScore = 0; 
                // Declare variables that will change to zero or null throughout the program.
                int UserAnwser = 0; int CorrectAnwser = Number1 * Number2;
                
                // Operations for choices
                switch (Console.ReadLine())
                {
                    case "a":
                        // Ask the user to type the first number.
                        Console.WriteLine("Type a number, and then press Enter");
                        Number1 = Convert.ToInt32(Console.ReadLine());

                        // Ask the user to type the second number.
                        Console.WriteLine("Type another number, and then press Enter");
                        Number2 = Convert.ToInt32(Console.ReadLine());
                        
                        // Ask the user for their anwser
                        Console.WriteLine("What do beleive the anwser is? : ");
                        UserAnwser = Convert.ToInt32(Console.ReadLine());
                        
                        // Display the results of the operation.
                        if (Number1 * Number2 == UserAnwser)
                        {
                            Console.WriteLine("You're anwser was correct!");
                            // Add one point to user score.
                            UserScore = +1; 
                        }
                        else
                        {
                            Console.WriteLine("You're anwser was incorrect :(");
                            // No points if incorrect.
                        }
                        break;

                    case "b":
                        Console.Write("The correct anwser was " + Number1 * Number2);
                        Console.WriteLine("\n");
                        break;
                        
                    case "c":
                        break;
                        
                    case "d":
                        Console.WriteLine("Press q and Enter to close the application, or any other key and Enter to continue: ");
                        if (Console.ReadLine() == "q") endApp = true;
                        Console.WriteLine("\n");
                        break;
                }
            }
            return;     
        }
    }
}
