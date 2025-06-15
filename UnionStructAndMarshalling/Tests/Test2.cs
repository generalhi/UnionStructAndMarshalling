using System;
using StructUnionAndMarshalling.Entities;

namespace StructUnionAndMarshalling.Tests
{
    public class Test2
    {
        public void Run()
        {
            var u = new Union
            {
                DataByte = new byte[Constants.DataSize]
            };

            u.DataWord[0].Value = 0xffaa;
            u.DataWord[1].Value = 0x1122;
            u.DataWord[7].Value = 0xaaff;

            Console.WriteLine();
            Console.WriteLine("Test 2");
            u.PrintByteArray();
            u.PrintWordArray();
        }
    }
}
