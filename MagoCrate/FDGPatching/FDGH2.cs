using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KirbyFDGH
{
    public class FDGH2
    {
        public struct Scene
        {
            public string Name;
            public List<string> AssetGroup1;
            public List<string> AssetGroup2;
        }

        public List<string> FileList;
        public List<Scene> SceneList;
        public List<string> StringList;

        public Endianness Endianness;
        public byte XbinVersion;

        public FDGH2() { }
        public FDGH2(string path)
        {
            Read(path);
        }

        public void Read(string path)
        {
            FileList = new List<string>();
            SceneList = new List<Scene>();
            StringList = new List<string>();

            EndianBinaryReader reader = new EndianBinaryReader(new FileStream(path, FileMode.Open));

            uint fileListOffs = 0;
            uint sceneListOffs = 0;
            uint stringListOffs = 0;

            reader.BaseStream.Seek(0x4, SeekOrigin.Begin);
            byte[] endianness = reader.ReadBytes(2);
            if (endianness.SequenceEqual(new byte[] { 0x34, 0x12 }))
            {
                Endianness = Endianness.Little;
            }
            else
            {
                Endianness = Endianness.Big;
            }
            reader.Endianness = Endianness;
            XbinVersion = reader.ReadByte();
            if (XbinVersion == 4)
            {
                fileListOffs = 0x1C;
                sceneListOffs = 0x20;
                stringListOffs = 0x24;
            }
            else
            {
                fileListOffs = 0x18;
                sceneListOffs = 0x1C;
                stringListOffs = 0x20;
            }

            reader.BaseStream.Seek(stringListOffs, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            uint count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                uint pos = (uint)reader.BaseStream.Position + 4;
                reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
                StringList.Add(Encoding.UTF8.GetString(reader.ReadBytes(reader.ReadInt32())));
                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
            }

            reader.BaseStream.Seek(sceneListOffs, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                Scene scene = new Scene();

                uint pos = (uint)reader.BaseStream.Position + 4;
                reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
                scene.Name = Encoding.UTF8.GetString(reader.ReadBytes(reader.ReadInt32()));
                reader.BaseStream.Seek(pos, SeekOrigin.Begin);

                pos = (uint)reader.BaseStream.Position + 4;
                reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
                uint datacount = reader.ReadUInt32();
                List<string> data = new List<string>();
                for (int d = 0; d < datacount; d++)
                {
                    data.Add(StringList[reader.ReadInt32()]);
                }
                scene.AssetGroup1 = data;
                reader.BaseStream.Seek(pos, SeekOrigin.Begin);


                pos = (uint)reader.BaseStream.Position + 4;
                reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
                datacount = reader.ReadUInt32();
                scene.AssetGroup2 = new List<string>();
                for (int d = 0; d < datacount; d++)
                {
                    int s = reader.ReadInt32();
                    scene.AssetGroup2.Add(StringList[s]);
                }
                
                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                SceneList.Add(scene);
            }

            reader.BaseStream.Seek(fileListOffs, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                FileList.Add(StringList[reader.ReadInt32()]);
            }

            reader.Close();
            reader.Dispose();

        }

        public void Write(string path)
        {
            EndianBinaryWriter writer = new EndianBinaryWriter(new FileStream(path, FileMode.Create), Endianness);

            writer.Write("XBIN".ToCharArray()); //XBIN Magic
            writer.Write((ushort)0x1234); //BOM
            writer.Write(XbinVersion); //version
            writer.Write((byte)0);
            writer.Write(0x00); //RLOC/File end Offset placeholder
            writer.Write((uint)0x0000FDE9); //Unk value
            if (XbinVersion == 4)
            {
                writer.Write(0x00); //RLOC Offset placeholder for version 4
            }

            if (Endianness == Endianness.Big) //FDGH Magic
            {
                writer.Write("FDGH".ToCharArray());
            }
            else
            {
                writer.Write("HGDF".ToCharArray());
            }
            writer.Write(0x02); //Unk, but it's there
            uint fileListOffset = (uint)writer.BaseStream.Position;
            writer.Write(0x00); //File List offset placeholder
            uint sceneDataOffset = (uint)writer.BaseStream.Position;
            writer.Write(0x00); //Scene Data List offset placeholder
            uint stringListOffset = (uint)writer.BaseStream.Position;
            writer.Write(0x00); //String List offset placeholder

            uint pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(fileListOffset, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(FileList.Count);
            for (int i = 0; i < FileList.Count; i++)
            {
                writer.Write(StringList.IndexOf(FileList[i]));
            }

            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(sceneDataOffset, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(SceneList.Count);
            List<uint> sceneStringOffsets = new List<uint>();
            List<uint> sceneAg1Offsets = new List<uint>();
            List<uint> sceneAg2Offsets = new List<uint>();
            for (int i = 0; i < SceneList.Count; i++)
            {
                sceneStringOffsets.Add((uint)writer.BaseStream.Position);
                writer.Write(0);
                sceneAg1Offsets.Add((uint)writer.BaseStream.Position);
                writer.Write(0);
                sceneAg2Offsets.Add((uint)writer.BaseStream.Position);
                writer.Write(0);
            }
            for (int i = 0; i < SceneList.Count; i++)
            {
                writer.BaseStream.Seek(0, SeekOrigin.End);
                pos = (uint)writer.BaseStream.Position;
                writer.BaseStream.Seek(sceneStringOffsets[i], SeekOrigin.Begin);
                writer.Write(pos);
                writer.BaseStream.Seek(0, SeekOrigin.End);

                writer.Write(SceneList[i].Name.Length);
                writer.Write(Encoding.UTF8.GetBytes(SceneList[i].Name));
                writer.Write(0x00);
                while (writer.BaseStream.Length.ToString("X").Last() != '4' && writer.BaseStream.Length.ToString("X").Last() != '8' && writer.BaseStream.Length.ToString("X").Last() != 'C' && writer.BaseStream.Length.ToString("X").Last() != 'F')
                {
                    writer.Write((byte)0x00);
                }

                pos = (uint)writer.BaseStream.Position;
                writer.BaseStream.Seek(sceneAg1Offsets[i], SeekOrigin.Begin);
                writer.Write(pos);
                writer.BaseStream.Seek(0, SeekOrigin.End);

                writer.Write(SceneList[i].AssetGroup1.Count);
                for (int a = 0; a < SceneList[i].AssetGroup1.Count; a++)
                {
                    writer.Write(StringList.IndexOf(SceneList[i].AssetGroup1[a]));
                }

                pos = (uint)writer.BaseStream.Position;
                writer.BaseStream.Seek(sceneAg2Offsets[i], SeekOrigin.Begin);
                writer.Write(pos);
                writer.BaseStream.Seek(0, SeekOrigin.End);

                writer.Write(SceneList[i].AssetGroup2.Count);
                for (int a = 0; a < SceneList[i].AssetGroup2.Count; a++)
                {
                    writer.Write(StringList.IndexOf(SceneList[i].AssetGroup2[a]));
                }
            }
            writer.BaseStream.Seek(0, SeekOrigin.End);

            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(stringListOffset, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(StringList.Count);
            List<uint> stringOffsets = new List<uint>();
            for (int i = 0; i < StringList.Count; i++)
            {
                stringOffsets.Add((uint)writer.BaseStream.Position);
                writer.Write(0);
            }
            for (int i = 0; i < StringList.Count; i++)
            {
                writer.BaseStream.Seek(0, SeekOrigin.End);
                pos = (uint)writer.BaseStream.Position;
                writer.BaseStream.Seek(stringOffsets[i], SeekOrigin.Begin);
                writer.Write(pos);
                writer.BaseStream.Seek(0, SeekOrigin.End);

                writer.Write(StringList[i].Length);
                writer.Write(Encoding.UTF8.GetBytes(StringList[i]));
                writer.Write(0x00);
                while (writer.BaseStream.Length.ToString("X").Last() != '4' && writer.BaseStream.Length.ToString("X").Last() != '8' && writer.BaseStream.Length.ToString("X").Last() != 'C' && writer.BaseStream.Length.ToString("X").Last() != 'F')
                {
                    writer.Write((byte)0x00);
                }
            }

            writer.BaseStream.Seek(0, SeekOrigin.End);
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x8, SeekOrigin.Begin);
            writer.Write(pos);
            if (XbinVersion == 4)
            {
                writer.BaseStream.Seek(0x10, SeekOrigin.Begin);
                writer.Write(pos);
                writer.BaseStream.Seek(0, SeekOrigin.End);

                writer.Write("RLOC".ToCharArray());
                writer.Write(0);
                writer.Write(0);
            }
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Flush();
            writer.Close();
            writer.Dispose();
        }
    }
}
