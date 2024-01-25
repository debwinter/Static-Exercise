namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you American? (enter 'Y' for yes or 'N' for no): ");
            char input1 = ValidateInput(UserInput(), 'Y', 'y', 'N', 'n');
            Console.WriteLine();

            if (input1 == 'Y' || input1 == 'y')
            {
                Console.Write("Enter the temperature in degrees Fahrenheit: ");
                double temp = UserDouble();
                Console.WriteLine();
                Console.WriteLine($"The temperature in Celsius is: {TempConverter.FahrenheitToCelsius(temp)}");
            }
            else
            {
                Console.Write("Enter the temperature in degrees Celsius: ");
                double temp = UserDouble();
                Console.WriteLine();
                Console.WriteLine($"The temperature in Fahrenheit is: {TempConverter.CelsiusToFahrenheit(temp)}");
            }
        }

        static char UserInput()
        {
            bool isChar = char.TryParse(Console.ReadLine(), out char userInput);
            while (!isChar)
            {
                Console.WriteLine("I'm sorry, I don't understand. Please try again: ");
                isChar = char.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }

        static char ValidateInput(char entry, char a, char b)
        {
            bool isValidEntry = entry == a || entry == b;
            if (isValidEntry)
            {
                return entry;
            }
            else
            {
                char userInput;
                do
                {
                    Console.WriteLine("Invalid entry. Please try again: ");
                    userInput = UserInput();
                    isValidEntry = userInput == a || userInput == b;
                } while (!isValidEntry);
                return userInput;
            }
        }

        static char ValidateInput(char entry, char a, char b, char c, char d)
        {
            bool isValidEntry = entry == a || entry == b || entry == c || entry == d;
            if (isValidEntry)
            {
                return entry;
            }
            else
            {
                char userInput;
                do
                {
                    Console.WriteLine("Invalid entry. Please try again: ");
                    userInput = UserInput();
                    isValidEntry = userInput == a || userInput == b || userInput == c || userInput == d;
                } while (!isValidEntry);
                return userInput;
            }
        }

        static double UserDouble()
        {
            bool isDouble = double.TryParse(Console.ReadLine(), out double userInput);
            while (!isDouble)
            {
                Console.WriteLine("I'm sorry, I don't understand. Please try again: ");
                isDouble = double.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }
    }
}
