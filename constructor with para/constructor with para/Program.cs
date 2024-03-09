using System.Security.Cryptography;

namespace constructor_with_para
{
    public class conswith
    {
        public int number1, number2;

        public conswith(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static conswith operator -(conswith c1)
        {
            c1.number1 = -c1.number1;
            c1.number2 = -c1.number2;
            return c1;
        }
        public void print()
        {
            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            conswith c1 = new conswith(25, -100);
            c1 = -c1;
            c1.print();
            Console.Read();
        }
    }
}