/*
Matthew Webb
CIDM-4360-70
Object Orieted Analysis and Design
*/
using System;
using System.Collections.Generic;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initially set the score and expressions counters to 0’s 
            int queryCounter = 0; // counts the number of expressions or "queries" the user has made.
            int scoreCounter = 0; // counts the number of expressions or "queries" the user correctly entered.
            string blank = ""; // A blank variable that can be used to end different loops.
            bool endApp = false; // Ends the Switch Case loop below when the user selects option D.

            while(!endApp)
            {
                // Call the Menu method in the Main method 
                string loop = Menu();
                // Create a loop that can route options to different methods
                switch (loop)
                {
                    case "a": ReadExpression(ref queryCounter,ref blank); // Routes to the ReadExpression Method
                    break;
                    case "b": CheckAnswer(ref scoreCounter,ref blank); // Routes to the CheckAnwser Method
                    break;
                    case "c": DisplayScore(queryCounter,scoreCounter); // Routes to the Display Score Method
                    break;
                    case "d": endApp = true; // Exits the loop, thereby exiting the application.
                    break;
                }
            }
        }
        static void ReadExpression(ref int queryCounter, ref string multiplicationExpression)
        {
            // When the user selects option (a), he/she will be asked to enter a multiplication expression with an answer. 
            Console.WriteLine("Enter a multiplication problem with the correct symbols. (Example: 2*2=4)");
            // Store the user response as a string so that we can parse the data.
            multiplicationExpression = Console.ReadLine();
            // Removes any of the following numbers from the data stored in the expression variable
            char[] delimiterChars = {'0','1','2','3','4','5','6','7','8','9'};
            // Parses out the numbers from the user input and stores the * and = in a list object.
            string[] operators = multiplicationExpression.Split(delimiterChars);
            // Creates a List object of the * and = operators
            List<string> listOfOperators = new List<string>();
            // For every instance of a * and = symbol, name it as a pieceOfOperator and add it to the listOfOperators List object.
            foreach (var pieceOfOperator in operators)
            {
                string input = pieceOfOperator;
                listOfOperators.Add(pieceOfOperator);
            }
            // Increment the expressions Counter if correct expression criteria is met.
            if ((listOfOperators.Contains(".") && listOfOperators.Contains("*") && listOfOperators.Contains("=")) || (listOfOperators.Contains("*") && listOfOperators.Contains("=")))
            {
                queryCounter ++;
            }
            else
            {   
                // Verification of user inputs.
                Console.WriteLine("Error: PLease enter a valid expression.");
                // Return to the main menu by creating what qualifies as invalid input.
                multiplicationExpression="";
            }
        }

        static void CheckAnswer(ref int scoreCounter,ref string multiplicationExpression)
        {
            // When the user selects (b), the program evaluates the expression to get the correct answer and compares it with the user’s answer
            if (multiplicationExpression == "")
            {
                // Verification of user inputs 
                Console.WriteLine("Error: Please enter a valid expression.");
            }
            else 
            {
                // Delimit the operators from the expression.
                char[] delimiterChars = {'*', '='};
                // Store the user response as a string so that we can parse it 
                string[] operators = multiplicationExpression.Split(delimiterChars);
                // A list object that stores just numbers and omits the * and = operators
                List<float> listOfNumbers = new List<float>();
                // Name each individual number a pieceOfOperator and add it to the listOfNumbers list object. 
                foreach (var pieceOfOperator in operators)
                {
                    float number = float.Parse(pieceOfOperator);
                    listOfNumbers.Add(number);
                }
                // Checks the anwser by using numbers stored in the list object, if it passes the logic test the the first option is printed
                if(listOfNumbers[2] == listOfNumbers[0] * listOfNumbers[1])
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Correct anwser, you're score has increased by 1 point");
                    Console.WriteLine($"You entered: {listOfNumbers[0]} * {listOfNumbers[1]} = {listOfNumbers[2]}");
                    Console.WriteLine("\n");
                    scoreCounter++; // add one point to the scorecounter.
                    multiplicationExpression = "";
                }
                // If the logic test fails then the second part of the loop is printed to the screen and nothing is added to the score. 
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"You're anwser was incorrect.");
                    Console.WriteLine($"You entered: {listOfNumbers[0]} * {listOfNumbers[1]} = {listOfNumbers[2]}");
                    Console.WriteLine($"The correct anwser was: {listOfNumbers[0]} * {listOfNumbers[1]} = {listOfNumbers[0] * listOfNumbers[1]} ");
                    Console.WriteLine("\n");
                    multiplicationExpression= "";
                }
            }
        }

        static void DisplayScore(int queryCounter,int scoreCounter)
        {
            // When the user selects option (c), the program will display the score and expressions counter.
            Console.WriteLine("\n");
            Console.WriteLine($"Expressions Entered: {queryCounter}"); // Prints the current value of the queryCounter int variable.
            Console.WriteLine($"Expressions Entered Correctly: {scoreCounter}"); // Prints the current value of the scoreCounter int variable. 
            Console.WriteLine("\n");
        }
        static string Menu()
        {
            // Display title.
            Console.WriteLine("Assignment 1 - Matthew Webb [CIDM-4360]\r");
            Console.WriteLine("=========================================");
            // Displays a menu with choices
            Console.WriteLine("Choose and option.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("a. - Enter expression");
            Console.WriteLine("b. - Check the anwser");
            Console.WriteLine("c. - Display Score");
            Console.WriteLine("d. - Exit");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Your option?: ");

            string returnMenu = Console.ReadLine();
            return returnMenu;
        }
    }
}
