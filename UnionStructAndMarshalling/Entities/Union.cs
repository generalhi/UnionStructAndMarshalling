using System;
using System.Runtime.InteropServices;

namespace StructUnionAndMarshalling.Entities
{
    [StructLayout(LayoutKind.Explicit, Pack = 0)]
    public struct Union
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.DataSize)]
        public byte[] DataByte;

        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.DataSize / 2)]
        public Word[] DataWord;

        public void PrintByteArray()
        {
            Console.WriteLine("Byte Array:");
            for (var i = 0; i < Constants.DataSize; i++)
            {
                Console.Write($"{DataByte[i]:X2} ");
            }
        }

        public void PrintWordArray()
        {
            Console.WriteLine();
            Console.WriteLine("Word Array:");
            for (var i = 0; i < Constants.DataSize / 2; i++)
            {
                Console.WriteLine(
                    $"Word[{i}]={DataWord[i].Value:X4}; " +
                    $"HiByte={DataWord[i].H:X2}; " +
                    $"LowByte={DataWord[i].L:X2};");
            }
        }
    }
}
