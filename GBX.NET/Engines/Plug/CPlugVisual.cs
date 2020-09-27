using System;
using System.Collections.Generic;
using System.Text;

namespace GBX.NET.Engines.Plug
{
    [Node(0x09006000)]
    public class CPlugVisual : CPlug
    {
        [Chunk(0x09006001)]
        public class Chunk09006001 : Chunk<CPlugVisual>
        {
            public override void ReadWrite(CPlugVisual n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x09006004)]
        public class Chunk09006004 : Chunk<CPlugVisual>
        {
            public override void ReadWrite(CPlugVisual n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x09006005)]
        public class Chunk09006005 : Chunk<CPlugVisual>
        {
            public override void ReadWrite(CPlugVisual n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x09006009)]
        public class Chunk09006009 : Chunk<CPlugVisual>
        {
            public override void ReadWrite(CPlugVisual n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x0900600B)]
        public class Chunk0900600B : Chunk<CPlugVisual>
        {
            public override void ReadWrite(CPlugVisual n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x0900600F)]
        public class Chunk0900600F : Chunk<CPlugVisual>
        {
            public override void ReadWrite(CPlugVisual n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                rw.Reader.ReadNodeRef<CPlugVertexStream>();
                rw.Reader.ReadArray<float>(8);
            }
        }

        [Chunk(0x09006010)]
        public class Chunk09006010 : Chunk<CPlugVisual>
        {
            public override void ReadWrite(CPlugVisual n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
                rw.Int32(Unknown);
            }
        }
    }
}
