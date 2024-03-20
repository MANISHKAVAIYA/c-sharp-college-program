using System.Diagnostics;

namespace simple_calculator
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            //creating a simple calculator :
            int result = 0;

            Console.WriteLine("Enter First number : ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number : ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the option : +, -, *, /, %, 2x");
            string op = Console.ReadLine(); 

            // Using switch case
            switch (op)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "/":
                    result = value1 / value2;
                    break;
                case "%":
                    result = value1 % value2;
                    break;
                case "2x": 
                    result = value1 * value1;
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }
            Console.WriteLine("Your result is : " + result);
            Console.ReadLine();
        }
    }
}
