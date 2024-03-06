namespace call_by_value_function
{
    internal class Program
    {
        public void value(int a, int b)
        {
            int c= a + b;
            Console.WriteLine(c);
        }
        public float changevalue(float c)
        {
            c = c * c;
            return c;
        }
        static void Main(String[] args)
        {
            Program p= new Program();
            float c = 2.2f;
            Console.WriteLine("value for function" +p.changevalue(c));
            Console.WriteLine("Actual value of function" +c);
            Console.ReadLine();
        }
    }   
}
