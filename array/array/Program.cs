namespace programarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3] { 20, 32, 12 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
