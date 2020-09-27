namespace GBX.NET.Engines.Plug
{
    [Node(0x904F000)]
    public class CPlugTree : CPlug
    {
        public CPlugTree[] Childs { get; set; }

        [Chunk(0x904F006)]
        public class Chunk904F006 : Chunk<CPlugTree>
        {
            public override void ReadWrite(CPlugTree n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown); // version

                n.Childs = rw.Array(n.Childs, i => rw.Reader.ReadNodeRef<CPlugTree>(), x => rw.Writer.Write(x));
            }
        }

        [Chunk(0x904F00D)]
        public class Chunk904F00D : Chunk<CPlugTree>
        {
            public override void ReadWrite(CPlugTree n, GameBoxReaderWriter rw)
            {
                rw.Reader.ReadLookbackString();
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x904F011)]
        public class Chunk904F011 : Chunk<CPlugTree>
        {
            public override void ReadWrite(CPlugTree n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x904F016)]
        public class Chunk904F016 : Chunk<CPlugTree>
        {
            public override void ReadWrite(CPlugTree n, GameBoxReaderWriter rw)
            {
                rw.Reader.ReadNodeRef<CPlugVisualIndexedTriangles>();
                rw.Int32(Unknown);
                rw.Reader.ReadNodeRef<CPlugSurface>();
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x904F01A)]
        public class Chunk904F01A : Chunk<CPlugTree>
        {
            public override void ReadWrite(CPlugTree n, GameBoxReaderWriter rw)
            {
                var version = rw.Reader.ReadByte();
                rw.Reader.ReadByte();
                rw.Reader.ReadInt16();
                if (version == 6)
                {
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                    rw.Single(Unknown);
                }
            }
        }
    }
}