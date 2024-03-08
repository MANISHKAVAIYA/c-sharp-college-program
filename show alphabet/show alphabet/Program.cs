namespace show_alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number (1-26) : ");
            int a=Convert.ToInt32(Console.ReadLine());

            if (a>=1 && a<=26)
            {
                char alphabet = (char)('a' + a - 1);
                Console.WriteLine($"The alphabet for {a} is: {alphabet}");
            }
            else
            {
                Console.WriteLine("Please enter a valid integer between 1 and 26.");
            }
            Console.Read();
        }
    }
}
