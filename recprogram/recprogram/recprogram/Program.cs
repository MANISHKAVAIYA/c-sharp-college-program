namespace recprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] b = new int[3, 3, 3];
            b[0, 0, 0] = 1;
            b[0, 0, 1] = 2;
            b[0, 0, 2] = 3;
            b[0, 1, 0] = 4;
            b[0, 1, 1] = 5;
            b[0, 1, 2] = 6;
            foreach (int c in b)
            {
                Console.Write(c);
            }
            Console.Read();
        }
    }
}
