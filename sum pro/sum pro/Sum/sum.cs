using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3, a4, a5, a6, a7, a8, Sum, Sub, Multi, Div;

            Console.Write("Enter No. 1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter No. 2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Sum = a1 + a2;
            Console.WriteLine("Sum is:" + Sum);
            Console.ReadLine();

            Console.Write("Enter No. 3:");
            a3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No. 4:");
            a4 = Convert.ToInt32(Console.ReadLine());
            Sub = a3 - a4;
            Console.WriteLine("Sub is:" + Sub);
            Console.ReadLine();

            Console.Write("Enter No. 5:");
            a5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No. 6:");
            a6 = Convert.ToInt32(Console.ReadLine());
            Multi = a5 * a6;
            Console.WriteLine("Multi is:" + Multi);
            Console.ReadLine();

            Console.Write("Enter No. 7:");
            a7 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No. 8:");
            a8 = Convert.ToInt32(Console.ReadLine());
            Div = a7 / a8;
            Console.WriteLine("Div is:" + Div);
            Console.Read();
        }
    }
}