using System.Transactions;

namespace if_else
{
    internal class if_else_pro
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter your age : ");
            a = Convert.ToInt32 (Console.ReadLine());

            if (a > 18)
            {
                Console.WriteLine("You are eligable.");
            }
            else if(a<18)
            {
                Console.WriteLine("You are child.");
            }
            else if(a<60)
            {
                Console.WriteLine("You are grandfather");
            }
            else
            {
                Console.WriteLine("this is age Program.");
            }
        }
    }
}
