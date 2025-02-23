// Every C# program needs these basic building blocks:
// 1. A namespace (like a container for our code)
// 2. A class (like a blueprint for our program)
// 3. A Main method (the starting point of our program)

namespace ProgramOne
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // Show welcome message to the user
            Console.WriteLine("Welcome to the Math Solver!");

            // Get two numbers and a math operator from the user
            // InputUtilities.GetValidInput makes sure the user enters correct values
            double number1 = double.Parse(InputUtilities.GetValidInput("number", "Please enter the first number:"));
            double number2 = double.Parse(InputUtilities.GetValidInput("number", "Please enter the second number:"));
            char operatorSymbol = InputUtilities.GetValidInput("mathOperator", "Please enter the operator (+, -, *, /):")[0];

            // Store the result of our calculation
            double result = 0;

            // Use switch statement to perform different calculations based on the operator
            // Like an if-else statement but cleaner for multiple choices
            switch (operatorSymbol)
            {
                case '+':     // Addition
                    result = number1 + number2;
                    break;
                case '-':     // Subtraction
                    result = number1 - number2;
                    break;
                case '*':     // Multiplication
                    result = number1 * number2;
                    break;
                case '/':     // Division
                    // Check if we're not dividing by zero (which is not allowed in math)
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:      // If the operator is not one of the above
                    Console.WriteLine("Error: Invalid operator.");
                    return;
            }

            // Show the result using string interpolation (putting variables inside a string)
            Console.WriteLine($"The result of {number1} {operatorSymbol} {number2} is {result}");
        }
    }
}


