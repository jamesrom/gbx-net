using System;
using System.Collections.Generic;
using System.Text;

namespace GBX.NET.Engines.Plug
{
    [Node(0x0906A000)]
    public class CPlugVisualIndexed : CPlugVisual3D
    {
        [Chunk(0x0906A001)]
        public class Chunk0906A001 : Chunk<CPlugVisualIndexed>
        {
            public override void ReadWrite(CPlugVisualIndexed n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);

                rw.Int32(Unknown); // CPlugIndexBuffer
                rw.Int32(Unknown);
                var indicies = rw.Reader.ReadArray<short>();
                rw.Int32(Unknown); // FACADE
            }
        }
    }
}
