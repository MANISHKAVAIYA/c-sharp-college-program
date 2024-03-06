/// Created by Manish Kavaiya

namespace function_to_sum
{
    internal class Program
    {
        public int suj(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int x=p.suj(5, 5);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
