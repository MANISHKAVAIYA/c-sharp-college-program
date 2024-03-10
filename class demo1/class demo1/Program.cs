using System.Security.Cryptography.X509Certificates;

namespace class_demo1
{
    public class A
    {
        public void print()
        {
            Console.WriteLine("This super class.");
        }
    }
    public class B: A 
    { 
        public void Print()
        {
            
            Console.WriteLine("This is sub class");
        }   
    }
}
