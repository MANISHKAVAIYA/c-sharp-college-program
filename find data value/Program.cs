using System.Diagnostics;

namespace find_data_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input number using int and show how much size store in memory 

            Console.WriteLine("---------------- Integer Values ----------------");

            Console.WriteLine("Integer value : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Value: {a}, Size: {sizeof(int)} bytes");

            //show the min and max value
            Console.WriteLine("Int MinValue : " + int.MinValue);
            Console.WriteLine("Int MaxValue : " + int.MaxValue);

            Console.WriteLine();
            Console.WriteLine("--------------- uint Value ---------------------");
            //user enter value and show the size of value
            Console.WriteLine("Please Enter the number : ");
            uint ui = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Value: {ui}, Size: {sizeof(uint)} uint.");

            // show the min and max value
            Console.WriteLine("uint MinValue : " + uint.MinValue);
            Console.WriteLine("uint MaxValue : " + uint.MaxValue);

            Console.WriteLine();
            Console.WriteLine("------------- SByte Values ------------------");

            //user enter value and show the size of value 
            Console.WriteLine("Please Enter the number : ");
            SByte sb = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine($"Value: {sb}, Size: {sizeof(sbyte)} bytes.");

            //show the min and max value
            Console.WriteLine("Sbyte MinValue : " + sbyte.MinValue);
            Console.WriteLine("Sbyte MaxValue : " + sbyte.MaxValue);

            Console.WriteLine();
            Console.WriteLine("----------------- Byte Values ------------------");

            //user enter value and show the size of value
            Console.WriteLine("Please Enter the number : ");
            Byte bt = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Value: {bt}, Size: {sizeof(byte)} bytes.");

            // show the min and max value
            Console.WriteLine("byte MinValue : " + byte.MinValue);
            Console.WriteLine("byte MaxValue : " + byte.MaxValue);

            Console.WriteLine();
            Console.WriteLine("--------------- short Value ---------------------");

            //user enter value and show the size of value
            Console.WriteLine("Please Enter the number : ");
            short sh = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Value: {sh}, Size: {sizeof(short)} short.");

            // show the min and max value
            Console.WriteLine("short MinValue : " + short.MinValue);
            Console.WriteLine("short MaxValue : " + short.MaxValue);

            Console.WriteLine();
            Console.WriteLine("--------------- Unshort Value ---------------------");

            //user enter value and show the size of value
            Console.WriteLine("Please Enter the number : ");
            ushort ush = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine($"Value: {ush}, Size: {sizeof(ushort)} ushort.");

            // show the min and max value
            Console.WriteLine("ushort MinValue : " + ushort.MinValue);
            Console.WriteLine("ushort MaxValue : " + ushort.MaxValue);

            Console.WriteLine();
            Console.WriteLine("--------------- long Value ---------------------");

            //user enter value and show the size of value
            Console.WriteLine("Please Enter the number : ");
            long ln = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Value: {ln}, Size: {sizeof(long)} long.");

            // show the min and max value
            Console.WriteLine("long MinValue : " + long.MinValue);
            Console.WriteLine("long MaxValue : " + long.MaxValue);

            Console.WriteLine();
            Console.WriteLine("--------------- ulong Value ---------------------");

            //user enter value and show the size of value
            Console.WriteLine("Please Enter the number : ");
            ulong uln = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"Value: {uln}, Size: {sizeof(ulong)} ulong.");

            // show the min and max value
            Console.WriteLine("ulong MinValue : " + ulong.MinValue);
            Console.WriteLine("ulong MaxValue : " + ulong.MaxValue);

            Console.WriteLine();
            Console.WriteLine("--------------- char Value ---------------------");

            //user enter value and show the size of value
            Console.WriteLine("Please Enter any one character : ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine($"Value: {ch}, Size: {sizeof(char)} char.");

            // Show the min and max value
            Console.WriteLine($"char MinValue : {char.MinValue}");
            Console.WriteLine($"char MaxValue : {char.MaxValue}");
            Console.ReadLine();
        }
    }
}