using System;
using StructUnionAndMarshalling.Entities;

namespace StructUnionAndMarshalling.Tests
{
    public class Test1
    {
        public void Run()
        {
            var u = new Union
            {
                DataByte = new byte[Constants.DataSize]
            };
            
            for (var i = 0; i < Constants.DataSize; i++)
            {
                u.DataByte[i] = (byte) i;
            }

            Console.WriteLine("Test 1");
            u.PrintByteArray();
            u.PrintWordArray();
        }
    }
}
