using System.Runtime.InteropServices;

namespace StructUnionAndMarshalling.Entities
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Word
    {
        [FieldOffset(0)]
        public ushort Value;

        [FieldOffset(0)]
        public byte L;

        [FieldOffset(1)]
        public byte H;
    }
}
