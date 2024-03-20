/**
 * This program basically user input value
 * Main : user input value and which number of stop the print user control start and stop.
 * author = Manish Kavaiya
 * **/

namespace break_statement_inner_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int txt1,txt2;

            Console.WriteLine("Enter number : ");
            txt1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your break number : ");
            txt2 = Convert.ToInt32(Console.ReadLine());

            if (txt1>200)
            {
                Console.WriteLine("Please enter value less than 200");
            }
            else
            {
                for (int i = 1; i <= txt1; i++)
                {

                    for (int j = 0; j <= txt2; j++)
                    {
                        if (j == txt2)
                            break;

                        Console.WriteLine(i + " " + j);
                    }
                }
            }
            Console.WriteLine("Loop stopped.....please enter any key.");
            Console.ReadLine();
        }
    }
}