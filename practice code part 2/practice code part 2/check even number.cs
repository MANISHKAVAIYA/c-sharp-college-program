namespace practice_code_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //number even or not find
            Console.Write("Please enter any number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Not even number");
            }
            Console.ReadLine();
        }
    }
}
