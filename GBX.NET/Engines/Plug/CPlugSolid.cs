namespace GBX.NET.Engines.Plug
{
    [Node(0x09005000)]
    public class CPlugSolid : CPlug
    {
        [Chunk(0x09005000)]
        public class Chunk09005000 : Chunk<CPlugSolid>
        {
            public override void ReadWrite(CPlugSolid n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x0900500E)]
        public class Chunk0900500E : Chunk<CPlugSolid>
        {
            public override void ReadWrite(CPlugSolid n, GameBoxReaderWriter rw)
            {
                rw.Reader.ReadArray<float>(16);
            }
        }

        [Chunk(0x09005010)]
        public class Chunk09005010 : Chunk<CPlugSolid>
        {
            public override void ReadWrite(CPlugSolid n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
            }
        }

        [Chunk(0x09005011)]
        public class Chunk09005011 : Chunk<CPlugSolid>
        {
            public override void ReadWrite(CPlugSolid n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown);
                rw.Int32(Unknown);
                var nod = rw.Reader.ReadNodeRef<CPlugTree>();
            }
        }

        [Chunk(0x09005012)]
        public class Chunk09005012 : Chunk<CPlugSolid>
        {
            public override void ReadWrite(CPlugSolid n, GameBoxReaderWriter rw)
            {
                rw.Byte(Unknown);
            }
        }

        [Chunk(0x09005017)]
        public class Chunk09005017 : Chunk<CPlugSolid>
        {
            public override void ReadWrite(CPlugSolid n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown); // 3
                var gsdg = rw.Reader.ReadArray<float>(19);
            }
        }

        [Chunk(0x09005019)]
        public class Chunk09005019 : Chunk<CPlugSolid>
        {
            public override void ReadWrite(CPlugSolid n, GameBoxReaderWriter rw)
            {
                rw.Int32(Unknown); // 3
                var gsdg = rw.Reader.ReadArray<int>(10);
            }
        }
    }
}
