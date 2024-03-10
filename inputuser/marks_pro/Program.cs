namespace marks_pro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mark;
            Console.Write("Enter your Marks : ");
            mark = Convert.ToInt32(Console.ReadLine());

            if (mark >= 80 && mark <= 100)
            {
                Console.WriteLine("A Grade");
            }
            else if (mark >= 70 && mark <= 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (mark >= 50 && mark <= 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (mark >= 40 && mark <= 50)
            {
                Console.WriteLine("D Grade");
            }
            else if(mark >= 33 && mark <= 40)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
