using System.Drawing;

namespace property_type2602
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            if (rectangle is { Height : 9 } )
            {
                Console.WriteLine("The rectangle's height is 0, it will look like a sleeping line.");
            }
            else
            {
                Console.WriteLine("The rectangle's height is not zero, it will look like a not sleeping line.");
            }
            Console.Read();
        }
    }
}
