// This file contains code for checking if user input is valid
namespace ProgramOne
{
    // A utility class that contains helper methods for getting user input
    public static class InputUtilities
    {
        // This method keeps asking for input until the user provides a valid value
        // inputType tells us what kind of input we want (number, text, or math operator)
        // prompt is the message we show to the user
        public static string GetValidInput(string inputType, string prompt)
        {
            // Keep asking until we get valid input
            while (true)
            {
                // Show the prompt and get user input
                Console.WriteLine(prompt);
                string? input = Console.ReadLine();

                // Make sure input is not null (nothing entered)
                if (input == null)
                {
                    Console.WriteLine("Error: Input cannot be null.");
                    continue;  // Go back to start of loop
                }

                // Check if input is valid based on what type we want
                switch (inputType)
                {
                    case "number":
                        // Try to convert input to a number
                        if (double.TryParse(input, out _))
                            return input;
                        Console.WriteLine("Error: Please enter a valid number.");
                        break;

                    case "text":
                        // Make sure text is not empty and doesn't contain line breaks
                        if (!string.IsNullOrWhiteSpace(input) && !input.Contains('\n'))
                            return input;
                        Console.WriteLine("Error: Please enter valid text.");
                        break;

                    case "mathOperator":
                        // Check that input is exactly one character
                        // AND (&&)
                        // Check if input is one of: +, -, *, /
                        if (input.Length == 1 && "+-*/".Contains(input))
                        {
                            return input;
                        } 
                        else
                        {
                            Console.WriteLine("Error: Please enter a valid operator (+, -, *, /).");
                        }
                        break;
                }
            }
        }
    }
}
