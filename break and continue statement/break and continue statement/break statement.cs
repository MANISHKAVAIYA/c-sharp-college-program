/**
 * This program basically user input value
 * Then after half of value print the output screen.
 * author = Manish Kavaiya
 * **/

namespace break_and_continue_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //simple break statement example
            Console.Write("Enter the value : ");
            int value1;
            value1=Convert.ToInt32(Console.ReadLine());

            //using if condition
            if (value1 > 1000)
            {
                Console.WriteLine("Please Enter value of less than 1000");
            }
            else
            {
                //use to for loop
                //if you print even number you can also change the i++ replace i=i+2;
                for (int i = 1; i <= value1; i++)
                {
                    Console.WriteLine(i);
                    if (i == value1/2)
                        break;
                }
            }
            Console.WriteLine("Using break statement");
            Console.ReadLine();
        }
    }
}