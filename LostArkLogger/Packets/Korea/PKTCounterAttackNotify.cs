using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class PKTCounterAttackNotify
    {
        public void KoreaDecode(BitReader reader)
        {
            bytearray_2 = reader.ReadBytes(4072);
            TargetId = reader.ReadUInt64();
            bytearray_0 = reader.ReadBytes(16);
            SourceId = reader.ReadUInt64();
            bytearray_1 = reader.ReadBytes(15);
        }
    }
}
