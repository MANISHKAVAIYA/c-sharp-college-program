using System.Timers;

namespace loops_practice_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initilize the for loop
            Console.Write("Please enter any number in 500 : ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            if (value1 >= 500)
            {
                Console.WriteLine("Please enter value only less than 500 ");
            }
            else
            {
                for (int i = 0; i <= value1; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            // initilize the while loop
            Console.WriteLine("While loop Example");
            Console.Write("Please enter any number under 500 : ");
            int whilevalue = Convert.ToInt32(Console.ReadLine());

            if (whilevalue >= 500)
            {
                Console.WriteLine("Please enter value less than 500.");
            }
            else
            {
                int b = 0;
                while (b <= whilevalue)
                {
                    Console.WriteLine("Your value : " + b);
                    b++;
                }
            }

            // initilize the do while loop
            Console.WriteLine("Do while loop Example");
            int dovalue;
            do
            {
                Console.Write("Please enter any number under 500 : ");
                dovalue = Convert.ToInt32(Console.ReadLine());

                if (dovalue <= 500)
                {
                    for (int y = 0; y <= dovalue; y++)
                    {
                        Console.WriteLine(y);
                    }
                }
                else
                {
                    Console.WriteLine("please enter value less than 500.");
                }
            }
            while (value1 > 500);

            Console.ReadLine();
        }
    }
}