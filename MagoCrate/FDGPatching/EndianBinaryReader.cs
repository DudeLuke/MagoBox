using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KirbyFDGH
{
    public class EndianBinaryReader : BinaryReader
    {
        public Endianness Endianness = Endianness.Little;

        public EndianBinaryReader(Stream stream) : base(stream) { Endianness = Endianness.Little; }
        public EndianBinaryReader(Stream stream, Endianness endian) : base(stream) { Endianness = endian; }

        public override short ReadInt16()
        {
            var data = base.ReadBytes(2);
            if (Endianness == Endianness.Little)
            {
                return BitConverter.ToInt16(data.ToArray(), 0);
            }
            else
            {
                return BitConverter.ToInt16(data.Reverse().ToArray(), 0);
            }
        }

        public override ushort ReadUInt16()
        {
            var data = base.ReadBytes(2);
            if (Endianness == Endianness.Little)
            {
                return BitConverter.ToUInt16(data.ToArray(), 0);
            }
            else
            {
                return BitConverter.ToUInt16(data.Reverse().ToArray(), 0);
            }
        }

        public override int ReadInt32()
        {
            var data = base.ReadBytes(4);
            if (Endianness == Endianness.Little)
            {
                return BitConverter.ToInt32(data.ToArray(), 0);
            }
            else
            {
                return BitConverter.ToInt32(data.Reverse().ToArray(), 0);
            }
        }

        public override uint ReadUInt32()
        {
            var data = base.ReadBytes(4);
            if (Endianness == Endianness.Little)
            {
                return BitConverter.ToUInt32(data.ToArray(), 0);
            }
            else
            {
                return BitConverter.ToUInt32(data.Reverse().ToArray(), 0);
            }
        }

        public override long ReadInt64()
        {
            var data = base.ReadBytes(8);
            if (Endianness == Endianness.Little)
            {
                return BitConverter.ToInt64(data.ToArray(), 0);
            }
            else
            {
                return BitConverter.ToInt64(data.Reverse().ToArray(), 0);
            }
        }

        public override ulong ReadUInt64()
        {
            var data = base.ReadBytes(8);
            if (Endianness == Endianness.Little)
            {
                return BitConverter.ToUInt64(data.ToArray(), 0);
            }
            else
            {
                return BitConverter.ToUInt64(data.Reverse().ToArray(), 0);
            }
        }

        public override float ReadSingle()
        {
            var data = base.ReadBytes(4);
            if (Endianness == Endianness.Little)
            {
                return BitConverter.ToSingle(data.ToArray(), 0);
            }
            else
            {
                return BitConverter.ToSingle(data.Reverse().ToArray(), 0);
            }
        }
    }
}
