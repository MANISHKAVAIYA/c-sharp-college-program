namespace jaggedarraypro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] c = new int[3][];
            c[0] = new int[5] { 1, 2, 5, 7, 6 };
            c[1] = new int[] { 11, 22, 33, 44 };
            c[2] = new int[] { 91, 92, 93, 94, 99, 100 };
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < c[i].Length; j++)
                {
                    Console.Write(c[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
