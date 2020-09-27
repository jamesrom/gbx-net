using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GBX.NET.Engines.Plug
{
    [Node(0x0900C000)]
    public class CPlugSurface : CPlug
    {
        [Chunk(0x0900C003)]
        public class Chunk0900C003 : Chunk<CPlugSurface>
        {
            public override void ReadWrite(CPlugSurface n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                var verticies = rw.Reader.ReadArray(i => rw.Reader.ReadVec3());
                rw.Reader.ReadArrayTillFacade<int>();
            }
        }
    }
}
