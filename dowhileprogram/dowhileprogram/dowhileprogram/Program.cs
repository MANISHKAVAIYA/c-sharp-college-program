namespace dowhileprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1, old = 2, New = 3;
            do
            {
                if (i <= 3)
                {
                    Console.Write(i + " ");
                    i++;
                }
                else
                {
                    i = old * New;
                    if (i >= n)
                    {
                        break;
                    }
                    Console.Write(i + " ");
                    old = New;
                    New = i;
                }
            } while (i <= n);
            Console.Read();
        }
    }
}
