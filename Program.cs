using MiniCalculator;

namespace MiniCalulator {
    public class Program { 
        private static void Main(string[] args)
        {
            double a, b;
            Boolean exit = false;

            do
            {
                Console.WriteLine("Please enter variable 1: ");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter variable 2: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("What type of operation you want to perform? \n" +
                    "1 for addition \n" +
                    "2 for subtraction \n" +
                    "3 for multiplication \n" +
                    "4 for division \n");

                int choice = int.Parse(Console.ReadLine());

                CalculatorImplementation calcimp = new CalculatorImplementation();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The addition result is: " + calcimp.getAddition(a, b));
                        break;
                    case 2:
                        Console.WriteLine("The subtraction result is: " + calcimp.getSubtraction(a, b));
                        break;
                    case 3:
                        Console.WriteLine("The multiplication result is: " + calcimp.getMultiplication(a, b));
                        break;
                    case 4:
                        Console.WriteLine("The division result is: " + calcimp.getDivision(a, b));
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("Exit program? (Y/y): ");
                char response = char.Parse(Console.ReadLine());
                exit = char.ToLower(response) != 'y';

            } while (exit);
        }
    }
}