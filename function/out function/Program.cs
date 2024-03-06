using System.ComponentModel.Design.Serialization;

namespace out_function
{
    internal class Program
    {
        
        public float sum(int d1,int d2, int d3,int d4, out int sum)
        {
            sum = d1 + d2 + d3 + d4;
            return sum / 4;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int a = 2, b = 3, c = 1, d = 5,sorry;
            float avg;
            avg = p.sum(a, b, c, d, out sorry);
            Console.WriteLine(sorry);
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine("Hello this is out function : \t " + avg);
            Console.ReadLine(); 
        }
    }
}
