using System;
using System.Collections.Generic;
using System.Text;

namespace GBX.NET.Engines.Plug
{
    [Node(0x09056000)]
    public class CPlugVertexStream : CPlug
    {
        [Chunk(0x09056000)]
        public class Chunk09056000 : Chunk<CPlugVertexStream>
        {
            public override void ReadWrite(CPlugVertexStream n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
                var numVerticies = rw.Reader.ReadInt32();
                rw.Int32(Unknown); // 3
                rw.Int32(Unknown); // -1
                rw.Reader.ReadArray(i => new object[] { rw.Reader.ReadInt16(), rw.Reader.ReadInt16(), rw.Reader.ReadInt16(), rw.Reader.ReadInt16(), rw.Reader.ReadInt32() });

                var verts = new Vec3[numVerticies];
                for(var i = 0; i < numVerticies; i++)
                    verts[i] = rw.Reader.ReadVec3();

                var unknown = new float[numVerticies];
                for (var i = 0; i < numVerticies; i++)
                    unknown[i] = rw.Reader.ReadSingle();

                var uvs = rw.Reader.ReadArrayTillFacade<float>();
            }
        }
    }
}
