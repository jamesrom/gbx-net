using System;
using System.Collections.Generic;
using System.Text;

namespace GBX.NET.Engines.Plug
{
    [Node(0x09015000)]
    public class CPlugTreeVisualMip : CPlugTree
    {
        [Chunk(0x09015000)]
        public class Chunk09015000 : Chunk<CPlugTreeVisualMip>
        {
            public override void ReadWrite(CPlugTreeVisualMip n, GameBoxReaderWriter rw)
            {
                
            }
        }

        [Chunk(0x09015002)]
        public class Chunk09015002 : Chunk<CPlugTreeVisualMip>
        {
            public override void ReadWrite(CPlugTreeVisualMip n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
                rw.Single(Unknown);
                rw.Int32(Unknown);
                Parse<CPlugTree>(rw.Reader);
            }
        }
    }
}
