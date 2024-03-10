namespace greater_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.Write("Enter no.1 : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no.2 : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no.3 : ");
            c=Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if(a>c)
                {
                    Console.WriteLine("a greater than c");
                }
                else
                {
                    Console.WriteLine("a is not greater than c");
                }
                if (b > c)
                {
                    Console.WriteLine("b is greater than c");
                }
                else
                {
                    Console.WriteLine("b is not greater than c");
                }
            }
            else
            {
                if (c > a)
                {
                    Console.WriteLine("c is greater than a");
                }
                else
                {
                    Console.WriteLine("c is not greater than a");
                }
            }
        }
    }
}