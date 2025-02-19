namespace ProgramOne
{
    public static class InputUtilities
    {
        public static string GetValidInput(string inputType, string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                switch (inputType)
                {
                    case "number":
                        if (double.TryParse(input, out _))
                            return input;
                        Console.WriteLine("Error: Please enter a valid number.");
                        break;

                    case "text":
                        if (!string.IsNullOrWhiteSpace(input) && !input.Contains('\n'))
                            return input;
                        Console.WriteLine("Error: Please enter valid text.");
                        break;

                    case "mathOperator":
                        if (input.Length == 1 && "+-*/".Contains(input))
                            return input;
                        Console.WriteLine("Error: Please enter a valid operator (+, -, *, /).");
                        break;
                }
            }
        }
    }
}
