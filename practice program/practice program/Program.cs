
using System.Reflection;
namespace practice_program
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly? myApp = Assembly.GetEntryAssembly();
            if (myApp is null) return;
            foreach (AssemblyName name in myApp.GetReferencedAssemblies())
            {
                Assembly a = Assembly.Load(name);
                int methodCount = 0;
                foreach (TypeInfo t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Length;
                }
                Console.WriteLine("{0:NO} type with {1:NO} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2:name.Name);
                Console.WriteLine("Hello World!");
                Console.ReadKey();
            }
        }
    }
}
