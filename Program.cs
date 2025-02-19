// This program demonstrates the basic structure of a C# console application
// and serves as an introduction to C# programming fundamentals.

// The namespace organizes code and prevents naming conflicts
namespace ProgramOne
{
    // The main class that contains the entry point of the program
    class HelloWorld
    {
        // The Main method is the entry point of a C# program
        // It receives command-line arguments as a string array
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Math Solver!");

            double number1 = double.Parse(InputUtilities.GetValidInput("number", "Please enter the first number:"));
            double number2 = double.Parse(InputUtilities.GetValidInput("number", "Please enter the second number:"));
            char operatorSymbol = InputUtilities.GetValidInput("mathOperator", "Please enter the operator (+, -, *, /):")[0];

            double result = 0;
            switch (operatorSymbol)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
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
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    return;
            }

            Console.WriteLine($"The result of {number1} {operatorSymbol} {number2} is {result}");
        }
    }
}


