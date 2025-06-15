using System;
using StructUnionAndMarshalling.Tests;

namespace StructUnionAndMarshalling
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var test1 = new Test1();
            test1.Run();

            var test2 = new Test2();
            test2.Run();
            
            Console.WriteLine("\nOk");
            Console.ReadKey();
        }
    }
}
