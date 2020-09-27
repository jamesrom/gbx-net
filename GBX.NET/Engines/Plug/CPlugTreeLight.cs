using System;
using System.Collections.Generic;
using System.Text;

namespace GBX.NET.Engines.Plug
{
    [Node(0x09062000)]
    public class CPlugTreeLight : CPlugTree
    {
        [Chunk(0x09062004)]
        public class Chunk09062004 : Chunk<CPlugTreeLight>
        {
            public override void ReadWrite(CPlugTreeLight n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }
    }
}
