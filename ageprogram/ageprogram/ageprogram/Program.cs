using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageprogram
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter your age:");
            int age = Convert.ToInt32(Console.Read());
            if (age > 0)
            {
                if (age >= 18 && age < 60)
                {
                    Console.Write("Adult");

                }
                else if (age < 18)
                {
                    Console.Write("Teenage");
                }
                else if (age >= 60)
                {
                    Console.Write("Senior citizen");
                }
            }
            else
            {
                Console.Write("Birth Pending");
            }
            Console.ReadKey();
        }
    }
}