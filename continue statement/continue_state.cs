/**
 * This program basically user input value
 * This program is continue statement
 * author = Manish Kavaiya
 * **/

namespace continue_statement
{
    internal class continue_state
    {
        static void Main(string[] args)
        {
            l1:
            Console.WriteLine("please must be every value less than 500");

            Console.WriteLine("Please enter your start number : ");
            int convalue1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your continue number : ");
            int convalue2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter your skip number");
            int skipvalue1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your skip number 2");
            int skipvalue2=Convert.ToInt32(Console.ReadLine());

            //loop initilize
            if (convalue1 > 500 && convalue2 > 500)
            {
                Console.WriteLine("Your value is not less than 500.");
                Console.WriteLine("please enter only value that is less than 500.");
                goto l1;
            }
            else
            {
                for (int i = 1; i <= skipvalue1; i++)
                {
                    for(int j = 1; j <= skipvalue2; j++)
                    {
                        if(i == convalue1 && j == convalue2)
                        {
                            continue;
                        }
                        Console.WriteLine(i + " " + j);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
