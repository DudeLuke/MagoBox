using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using RDLLVL;
using System.Security.Principal;

namespace RDLLVL
{
    public class Level
    {
        public uint Height;
        public uint Width;
        public uint Background;
        public uint Tileset;
        public Stage StageData;
        public byte[] header;
        public List<Block> TileBlock = new List<Block>();
        public List<Collision> TileCollision = new List<Collision>();
        public List<Decoration> BLandDecoration = new List<Decoration>();
        public List<Decoration> FLandDecoration = new List<Decoration>();
        public List<Decoration> MLandDecoration = new List<Decoration>();
        public List<DynamicTerrain> DynamicTerrain = new List<DynamicTerrain>();
        public List<DynamicAction> ActionTable = new List<DynamicAction>();
        public List<Section4D> All4DSections = new List<Section4D>();
        public List<Object> Objects = new List<Object>();
        public List<SpecialItem> Carriables = new List<SpecialItem>();
        public List<Item> Items = new List<Item>();
        public List<Boss> Bosses = new List<Boss>();
        public List<Enemy> Enemies = new List<Enemy>();
        public DynamicAction defaultDAction = new DynamicAction();

        public Level()
        {
            header = new byte[] { 0x00, 0x00, 0x00, 0x00 };
            Height = 1;
            Width = 1;
            Background = 1;
            Tileset = 1;
            StageData = new Stage();
            TileBlock = new List<Block>();
            TileCollision = new List<Collision>();
            BLandDecoration = new List<Decoration>();
            FLandDecoration = new List<Decoration>();
            MLandDecoration = new List<Decoration>();
            All4DSections = new List<Section4D>();
            DynamicTerrain = new List<DynamicTerrain>();
            ActionTable = new List<DynamicAction>();
            Objects = new List<Object>();
            Carriables = new List<SpecialItem>();
            Items = new List<Item>();
            Bosses = new List<Boss>();
            Enemies = new List<Enemy>();
        }
        public Level(string filePath)
        {
            using (BigEndianBinaryReader reader = new BigEndianBinaryReader(new FileStream(filePath, FileMode.Open)))
            {
                Read(reader);
            }
        }

        public void Read(BigEndianBinaryReader reader)
        {
            // Default Dynamic Terrain & Actions
            defaultDAction = new DynamicAction();
            defaultDAction.EventID = -1;
            defaultDAction.Parameter1 = 0;
            defaultDAction.Parameter2 = 0;
            defaultDAction.autoStart = true;
            for (int i = 0; i < 16; i++)
            {
                ActionTable.Add(defaultDAction);
                DynamicTerrain.Add(null);
            }

            // Record Header
            header = reader.ReadBytes(60);
            reader.BaseStream.Seek(0x14, SeekOrigin.Begin);

            // Bosses
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            uint count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                Boss boss = new Boss();
                boss.Type = reader.ReadUInt32();
                boss.Subtype = reader.ReadUInt32();
                boss.Level = reader.ReadUInt32();
                boss.MovingTerrainID = reader.ReadInt32();
                boss.HasSuperAbility = Convert.ToBoolean(reader.ReadUInt32());
                uint[] x = ConvertCoords(reader.ReadUInt32());
                uint[] y = ConvertCoords(reader.ReadUInt32());
                boss.X = x[0];
                boss.XOffset = x[1];
                boss.Y = y[0];
                boss.YOffset = y[1];
                boss.Unknown = reader.ReadUInt32();
                Bosses.Add(boss);
            }

            // Carriables
            reader.BaseStream.Seek(0x18, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                SpecialItem specItem = new SpecialItem();
                specItem.Type = reader.ReadUInt32();
                specItem.AppearID = reader.ReadUInt32();
                specItem.Respawn = Convert.ToBoolean(reader.ReadUInt32());
                specItem.MovingTerrainID = reader.ReadInt32();
                uint[] x = ConvertCoords(reader.ReadUInt32());
                uint[] y = ConvertCoords(reader.ReadUInt32());
                specItem.X = x[0];
                specItem.XOffset = x[1];
                specItem.Y = y[0];
                specItem.YOffset = y[1];
                Carriables.Add(specItem);
            }

            // Collision
            reader.BaseStream.Seek(0x1C, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32() + 0x4, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            Width = reader.ReadUInt32();
            Height = reader.ReadUInt32();
            for (int i = 0; i < Width * Height; i++)
            {
                Collision coll = new Collision();
                coll.Shape = reader.ReadByte();
                coll.Modifier = reader.ReadByte();
                coll.Material = reader.ReadByte();
                coll.AutoMoveSpeed = reader.ReadSByte();
                TileCollision.Add(coll);
            }

            // Dynamic Terrain
            reader.BaseStream.Seek(0x20, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            long pos = reader.BaseStream.Position;
            uint dynamicCount = reader.ReadUInt32();
            string binary = Convert.ToString(dynamicCount, 2);
            for (int b = binary.Length; b < 16; b++)
            {
                // Add zeroes to start of string until it's 16 characters long
                binary = "0" + binary;
            }

            // Define whether each Dynamic Terrain slot is empty or occupied
            Dictionary<int, bool> isNullTerrain = new Dictionary<int, bool>();
            for (int i = 0; i < 16; i++)
            {
                byte nullByte = byte.Parse(binary.Substring((binary.Length - 1) - i, 1));
                if (nullByte == 0) isNullTerrain.Add(i, true);
                else isNullTerrain.Add(i, false);
            }

            // Dynamic Terrain Collision
            if (dynamicCount > 0)
            {
                Console.WriteLine("Read Binary: " + binary + ", raw count was " + dynamicCount.ToString("X8"));

                Dictionary<int, uint> moveTileSectionPositions = new Dictionary<int, uint>();
                for (int i = 0; i < 16; i++)
                {
                    if (!isNullTerrain[i] && i < dynamicCount) moveTileSectionPositions.Add(i, reader.ReadUInt32());
                    else reader.ReadUInt32();
                }

                for (int i = 0; i < 16; i++)
                {
                    if (!isNullTerrain[i])
                    {
                        reader.BaseStream.Seek(moveTileSectionPositions[i], SeekOrigin.Begin);
                        DynamicTerrain slice = new DynamicTerrain();
                        slice.X = reader.ReadInt16();
                        Console.WriteLine("Tile " + i + " X: " + slice.X);
                        slice.Y = reader.ReadInt16();
                        Console.WriteLine("Tile " + i + " Y: " + slice.Y);
                        slice.Width = reader.ReadInt16();
                        Console.WriteLine("Tile " + i + " W: " + slice.Width);
                        slice.Height = reader.ReadInt16();
                        Console.WriteLine("Tile " + i + " H: " + slice.Height);
                        uint tileCount = reader.ReadUInt32();
                        Console.WriteLine("Tile " + i + " Count: " + tileCount);

                        // Skip past Duplicate(?) X and Y Position Data
                        reader.ReadUInt32();
                        reader.ReadUInt32();

                        // Get Start of Tiling Section
                        reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
                        for (int m = 0; m < tileCount; m++)
                        {
                            MoveTile tile = new MoveTile();
                            tile.X = reader.ReadByte();
                            tile.Y = reader.ReadByte();
                            tile.Shape = reader.ReadByte();
                            tile.Material = reader.ReadByte();
                            slice.tiles.Add(tile);
                            Console.WriteLine("Added Tile: " + tile.X + ", " + tile.Y + ", " + tile.Shape + ", " + tile.Material);
                        }
                        DynamicTerrain[i] = slice;
                    }
                }
            }
            else
            {
                Console.WriteLine("No Dynamic Terrain Found");
            }

            // Background And Tileset
            reader.BaseStream.Seek(0x24, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            Background = reader.ReadUInt32();
            Tileset = reader.ReadUInt32();
            pos = reader.BaseStream.Position;

            // FLand
            reader.BaseStream.Seek(reader.ReadUInt32() + 0x8, SeekOrigin.Begin);
            for (int i = 0; i < Width * Height; i++)
            {
                Decoration deco = new Decoration();
                deco.DecoID = reader.ReadInt16();
                deco.Unk_3 = reader.ReadByte();
                deco.MovingTerrainID = reader.ReadSByte();
                FLandDecoration.Add(deco);
            }

            // MLand
            reader.BaseStream.Seek(pos + 0x4, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32() + 0x8, SeekOrigin.Begin);
            for (int i = 0; i < Width * Height; i++)
            {
                Decoration deco = new Decoration();
                deco.DecoID = reader.ReadInt16();
                deco.Unk_3 = reader.ReadByte();
                deco.MovingTerrainID = reader.ReadSByte();
                MLandDecoration.Add(deco);
            }

            // BLand
            reader.BaseStream.Seek(pos + 0x8, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32() + 0x8, SeekOrigin.Begin);
            for (int i = 0; i < Width * Height; i++)
            {
                Decoration deco = new Decoration();
                deco.DecoID = reader.ReadInt16();
                deco.Unk_3 = reader.ReadByte();
                deco.MovingTerrainID = reader.ReadSByte();
                BLandDecoration.Add(deco);
            }

            // Section 4D
            count = reader.ReadUInt32();
            Console.WriteLine("Section 4D Count: " + count + ", Position: " + reader.BaseStream.Position.ToString("X8"));
            for (int i = 0; i < count; i++)
            {
                Section4D section4D = new Section4D();
                section4D.Type = reader.ReadUInt32();
                section4D.Param1 = reader.ReadUInt32();
                section4D.Param2 = reader.ReadUInt32();
                section4D.Param3 = reader.ReadUInt32();
                section4D.Param4 = reader.ReadUInt32();
                section4D.Param5 = reader.ReadUInt32();
                section4D.Param6 = reader.ReadUInt32();
                section4D.Param7 = reader.ReadUInt32();
                section4D.Param8 = reader.ReadUInt32();
                section4D.Param9 = reader.ReadUInt32();
                section4D.Param10 = reader.ReadUInt32();
                section4D.Param11 = reader.ReadUInt32();
                section4D.Param12 = reader.ReadUInt32();
                section4D.Param13 = reader.ReadUInt32();
                section4D.Param14 = reader.ReadUInt32();
                section4D.Param15 = reader.ReadUInt32();
                section4D.Param16 = reader.ReadUInt32();
                All4DSections.Add(section4D);
            }

            // Enemies
            reader.BaseStream.Seek(0x28, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                Enemy enemy = new Enemy();
                enemy.Type = reader.ReadUInt32();
                enemy.Behavior = reader.ReadUInt32();
                enemy.Level = reader.ReadUInt32();
                enemy.DirectionType = reader.ReadUInt32();
                enemy.SizeAD = reader.ReadUInt32();
                enemy.SizeEX = reader.ReadUInt32();
                enemy.MovingTerrainID = reader.ReadInt32();
                enemy.HasSuperAbility = Convert.ToBoolean(reader.ReadUInt32());
                uint[] x = ConvertCoords(reader.ReadUInt32());
                uint[] y = ConvertCoords(reader.ReadUInt32());
                enemy.X = x[0];
                enemy.XOffset = x[1];
                enemy.Y = y[0];
                enemy.YOffset = y[1];
                Enemies.Add(enemy);
            }

            // Stage Data
            reader.BaseStream.Seek(0x2C, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            pos = reader.BaseStream.Position;
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            StageData = new Stage();
            StageData.BGM = Encoding.UTF8.GetString(reader.ReadBytes(reader.ReadInt32()));
            reader.BaseStream.Seek(pos + 0x4, SeekOrigin.Begin);
            StageData.BgX = reader.ReadSingle();
            StageData.BgY = reader.ReadSingle();
            StageData.BgZ = reader.ReadSingle();
            StageData.BgRotX = reader.ReadSingle();
            StageData.BgRotY = reader.ReadSingle();
            StageData.BgRotZ = reader.ReadSingle();
            StageData.BgDistance = reader.ReadSingle();
            StageData.BgScrollSpeedX = reader.ReadSingle();
            StageData.BgScrollDownX = reader.ReadSingle();
            StageData.BgScrollBackX = reader.ReadSingle();
            StageData.BgScrollRightY = reader.ReadSingle();
            StageData.BgScrollSpeedY = reader.ReadSingle();
            StageData.BgScrollBackY = reader.ReadSingle();
            StageData.Filter = reader.ReadUInt32();
            StageData.RunEffect = reader.ReadUInt32();
            StageData.DeathStepFlag = reader.ReadUInt32();
            StageData.DeathStepChange = reader.ReadInt32();
            StageData.DeathStartID = reader.ReadUInt32();

            // Blocks
            reader.BaseStream.Seek(0x30, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            pos = reader.BaseStream.Position;
            reader.BaseStream.Seek(reader.ReadUInt32() + 0x8, SeekOrigin.Begin);
            for (int i = 0; i < Width * Height; i++)
            {
                Block block = new Block();
                block.ID = reader.ReadInt16();
                TileBlock.Add(block);
            }

            // Objects
            reader.BaseStream.Seek(pos + 0x4, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                Object obj = new Object();
                obj.Type = reader.ReadUInt32();
                uint[] x = ConvertCoords(reader.ReadUInt32());
                uint[] y = ConvertCoords(reader.ReadUInt32());
                obj.X = x[0];
                obj.XOffset = x[1];
                obj.Y = y[0];
                obj.YOffset = y[1];
                obj.Param1 = reader.ReadUInt32();
                obj.Param2 = reader.ReadUInt32();
                obj.Param3 = reader.ReadUInt32();
                obj.Param4 = reader.ReadUInt32();
                obj.Param5 = reader.ReadUInt32();
                obj.Param6 = reader.ReadUInt32();
                obj.Param7 = reader.ReadUInt32();
                obj.Param8 = reader.ReadUInt32();
                obj.Param9 = reader.ReadUInt32();
                obj.Param10 = reader.ReadUInt32();
                obj.Param11 = reader.ReadUInt32();
                obj.Param12 = reader.ReadUInt32();
                obj.Unknown = reader.ReadUInt32();
                Objects.Add(obj);
            }

            // New List For Dynamic Action Start Positions
            List<uint> actionPositions = new List<uint>();

            // Skip past count reading, it uses the same value as the Dynamic Terrain
            reader.ReadUInt32();
            for (int i = 0; i < 16; i++)
            {
                actionPositions.Add(reader.ReadUInt32());
                Console.WriteLine("Wrote New Dynamic Action Start Position: " + actionPositions[actionPositions.Count - 1].ToString("X"));
            }

            // Dynamic Actions
            for (int i = 0; i < 16; i++)
            {
                reader.BaseStream.Seek(actionPositions[i], SeekOrigin.Begin);
                Console.WriteLine("Arrived At: " + reader.BaseStream.Position.ToString("X"));
                DynamicAction actionEvent = new DynamicAction();
                int eventID = reader.ReadByte();
                if (eventID == 0xFF) actionEvent.EventID = -1;
                actionEvent.EventID = eventID;
                Console.WriteLine("Event ID: " + eventID);
                actionEvent.Parameter1 = reader.ReadByte();
                Console.WriteLine("Unk1: " + actionEvent.Parameter1);
                actionEvent.Parameter2 = reader.ReadByte();
                Console.WriteLine("Unk2: " + actionEvent.Parameter2);
                uint phaseCount = reader.ReadByte();
                Console.WriteLine("Phase Count: " + phaseCount.ToString("X"));
                int autoStartInt = reader.ReadInt32();
                Console.WriteLine("Parameter 2: " + autoStartInt.ToString("X8"));
                actionEvent.autoStart = false;
                if (autoStartInt != 0) actionEvent.autoStart = true;

                reader.BaseStream.Seek((uint)reader.ReadInt32(), SeekOrigin.Begin);
                Console.WriteLine("Relocated to: " + ((uint)reader.BaseStream.Position).ToString("X"));

                for (int p = 0; p < phaseCount; p++)
                {
                    ActionPhase phase = new ActionPhase();
                    Console.WriteLine("New Phase: " + p);

                    phase.Direction = reader.ReadByte();
                    Console.WriteLine("Direction: " + phase.Direction);
                    phase.Distance = reader.ReadByte();
                    Console.WriteLine("Distance: " + phase.Distance);

                    phase.Delay = reader.ReadInt16();
                    Console.WriteLine("Delay: " + phase.Delay);
                    phase.Unknown1 = reader.ReadInt16();
                    Console.WriteLine("Unk1: " + phase.Unknown1);
                    phase.Duration = reader.ReadInt16();
                    Console.WriteLine("Duration: " + phase.Duration);

                    int endInt = reader.ReadByte();
                    phase.EndPhase = false;
                    if (endInt == 0) phase.EndPhase = true;
                    Console.WriteLine("Ends: " + phase.EndPhase);

                    phase.Unknown2 = reader.ReadByte();
                    Console.WriteLine("Unk2: " + phase.Unknown2);
                    phase.Addendum = reader.ReadBytes(10);
                    phase.AccelType = reader.ReadByte();
                    Console.WriteLine("AccelType: " + phase.AccelType);
                    phase.AccelTime = reader.ReadByte();
                    Console.WriteLine("AccelTime: " + phase.AccelTime);
                    phase.Unknown3 = reader.ReadInt16();
                    Console.WriteLine("Unk3: " + phase.Unknown3);
                    actionEvent.phases.Add(phase);
                }
                ActionTable[i] = actionEvent;
            }

            // Items
            reader.BaseStream.Seek(0x34, SeekOrigin.Begin);
            reader.BaseStream.Seek(reader.ReadUInt32(), SeekOrigin.Begin);
            count = reader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                Item item = new Item();
                item.Type = reader.ReadUInt32();
                item.Behavior = reader.ReadUInt32();
                item.Level = reader.ReadUInt32();
                item.MovingTerrainID = reader.ReadInt32();
                uint[] x = ConvertCoords(reader.ReadUInt32());
                uint[] y = ConvertCoords(reader.ReadUInt32());
                item.X = x[0];
                item.XOffset = x[1];
                item.Y = y[0];
                item.YOffset = y[1];
                Items.Add(item);
            }

            reader.Dispose();
            reader.Close();
        }

        public void Write(BigEndianBinaryWriter writer)
        {
            // Write Temporary Header
            writer.Write(header);

            // Bosses
            writer.Write(Bosses.Count);
            for (int i = 0; i < Bosses.Count; i++)
            {
                writer.Write(Bosses[i].Type);
                writer.Write(Bosses[i].Subtype);
                writer.Write(Bosses[i].Level);
                writer.Write(Bosses[i].MovingTerrainID);
                writer.Write(Convert.ToUInt32(Bosses[i].HasSuperAbility));
                writer.Write(ConvertCoords(new uint[] { Bosses[i].X, Bosses[i].XOffset }));
                writer.Write(ConvertCoords(new uint[] { Bosses[i].Y, Bosses[i].YOffset }));
                writer.Write(Bosses[i].Unknown);
            }

            // Carriables
            uint pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x18, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);
            writer.Write(Carriables.Count);
            for (int i = 0; i < Carriables.Count; i++)
            {
                writer.Write(Carriables[i].Type);
                writer.Write(Carriables[i].AppearID);
                writer.Write(Convert.ToUInt32(Carriables[i].Respawn));
                writer.Write(Carriables[i].MovingTerrainID);
                writer.Write(ConvertCoords(new uint[] { Carriables[i].X, Carriables[i].XOffset }));
                writer.Write(ConvertCoords(new uint[] { Carriables[i].Y, Carriables[i].YOffset }));
            }

            // Collision
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x1C, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);
            writer.Write(1);
            writer.Write((uint)writer.BaseStream.Position + 0x4);
            writer.Write(Width);
            writer.Write(Height);
            for (int i = 0; i < TileCollision.Count; i++)
            {
                writer.Write(TileCollision[i].Shape);
                writer.Write(TileCollision[i].Modifier);
                writer.Write(TileCollision[i].Material);
                writer.Write(TileCollision[i].AutoMoveSpeed);
            }

            // Dynamic Terrain
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x20, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(pos, SeekOrigin.Begin);
            string dynamicBinary = "";
            for (int i = 0; i < 16; i++)
            {
                string addition = "0";
                if (DynamicTerrain[i] != null) addition = "1";
                dynamicBinary = addition + dynamicBinary;
            }
            int dynamicCount = Convert.ToInt32(dynamicBinary, 2);
            Console.WriteLine(dynamicBinary + ", " + dynamicCount);
            writer.Write(dynamicCount);
            uint terrainNexus = (uint)writer.BaseStream.Position;
            for (int i = 0; i < 16; i++)
            {
                writer.Write(0);
            }
            pos = (uint)writer.BaseStream.Position;
            for (int i = 0; i < 16; i++)
            {
                if (DynamicTerrain[i] != null)
                {
                    pos = (uint)writer.BaseStream.Position;
                    writer.BaseStream.Seek(terrainNexus + (i * 0x4), SeekOrigin.Begin);
                    writer.Write(pos);
                    writer.BaseStream.Seek(pos, SeekOrigin.Begin);
                    writer.Write(DynamicTerrain[i].X);
                    writer.Write(DynamicTerrain[i].Y);
                    writer.Write(DynamicTerrain[i].Width);
                    writer.Write(DynamicTerrain[i].Height);
                    writer.Write(DynamicTerrain[i].tiles.Count);
                    writer.Write((uint)DynamicTerrain[i].X);
                    writer.Write((uint)DynamicTerrain[i].Y);
                    writer.Write((uint)writer.BaseStream.Position + 0x4);
                    for (int t = 0; t < DynamicTerrain[i].tiles.Count; t++)
                    {
                        writer.Write(DynamicTerrain[i].tiles[t].X);
                        writer.Write(DynamicTerrain[i].tiles[t].Y);
                        writer.Write(DynamicTerrain[i].tiles[t].Shape);
                        writer.Write(DynamicTerrain[i].tiles[t].Material);
                    }
                } else
                {
                    uint skipPos = (uint)writer.BaseStream.Position;
                    writer.BaseStream.Seek(terrainNexus + (i * 0x4), SeekOrigin.Begin);
                    writer.Write(pos);
                    writer.BaseStream.Seek(skipPos, SeekOrigin.Begin);
                }
            }

            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x24, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Background);
            writer.Write(Tileset);
            pos = (uint)writer.BaseStream.Position;
            writer.Write((uint)(pos + (4 * 4)));
            writer.Write(0);
            writer.Write(0);
            writer.Write(0);

            writer.Write(Width);
            writer.Write(Height);
            for (int i = 0; i < FLandDecoration.Count; i++)
            {
                writer.Write(FLandDecoration[i].DecoID);
                writer.Write(FLandDecoration[i].Unk_3);
                writer.Write(FLandDecoration[i].MovingTerrainID);
            }
            writer.BaseStream.Seek(pos + 0x4, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Width);
            writer.Write(Height);
            for (int i = 0; i < MLandDecoration.Count; i++)
            {
                writer.Write(MLandDecoration[i].DecoID);
                writer.Write(MLandDecoration[i].Unk_3);
                writer.Write(MLandDecoration[i].MovingTerrainID);
            }
            writer.BaseStream.Seek(pos + 0x8, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Width);
            writer.Write(Height);
            for (int i = 0; i < BLandDecoration.Count; i++)
            {
                writer.Write(BLandDecoration[i].DecoID);
                writer.Write(BLandDecoration[i].Unk_3);
                writer.Write(BLandDecoration[i].MovingTerrainID);
            }
            writer.BaseStream.Seek(pos + 0xC, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(All4DSections.Count);
            for (int i = 0; i < All4DSections.Count; i++)
            {
                writer.Write(All4DSections[i].Type);
                writer.Write(All4DSections[i].Param1);
                writer.Write(All4DSections[i].Param2);
                writer.Write(All4DSections[i].Param3);
                writer.Write(All4DSections[i].Param4);
                writer.Write(All4DSections[i].Param5);
                writer.Write(All4DSections[i].Param6);
                writer.Write(All4DSections[i].Param7);
                writer.Write(All4DSections[i].Param8);
                writer.Write(All4DSections[i].Param9);
                writer.Write(All4DSections[i].Param10);
                writer.Write(All4DSections[i].Param11);
                writer.Write(All4DSections[i].Param12);
                writer.Write(All4DSections[i].Param13);
                writer.Write(All4DSections[i].Param14);
                writer.Write(All4DSections[i].Param15);
                writer.Write(All4DSections[i].Param16);
            }

            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x28, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Enemies.Count);
            for (int i = 0; i < Enemies.Count; i++)
            {
                writer.Write(Enemies[i].Type);
                writer.Write(Enemies[i].Behavior);
                writer.Write(Enemies[i].Level);
                writer.Write(Enemies[i].DirectionType);
                writer.Write(Enemies[i].SizeAD);
                writer.Write(Enemies[i].SizeEX);
                writer.Write(Enemies[i].MovingTerrainID);
                writer.Write(Convert.ToUInt32(Enemies[i].HasSuperAbility));
                writer.Write(ConvertCoords(new uint[] { Enemies[i].X, Enemies[i].XOffset }));
                writer.Write(ConvertCoords(new uint[] { Enemies[i].Y, Enemies[i].YOffset }));
            }
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x2C, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            uint bgmOffset = (uint)writer.BaseStream.Position;
            writer.Write(0);
            writer.Write(StageData.BgX);
            writer.Write(StageData.BgY);
            writer.Write(StageData.BgZ);
            writer.Write(StageData.BgRotX);
            writer.Write(StageData.BgRotY);
            writer.Write(StageData.BgRotZ);
            writer.Write(StageData.BgDistance);
            writer.Write(StageData.BgScrollSpeedX);
            writer.Write(StageData.BgScrollDownX);
            writer.Write(StageData.BgScrollBackX);
            writer.Write(StageData.BgScrollRightY);
            writer.Write(StageData.BgScrollSpeedY);
            writer.Write(StageData.BgScrollBackY);
            writer.Write(StageData.Filter);
            writer.Write(StageData.RunEffect);
            writer.Write(StageData.DeathStepFlag);
            writer.Write(StageData.DeathStepChange);
            writer.Write(StageData.DeathStartID);
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x30, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            pos = (uint)writer.BaseStream.Position;
            writer.Write(pos + (3 * 4));
            writer.Write(0);
            writer.Write(0);

            writer.Write(Width);
            writer.Write(Height);
            for (int i = 0; i < TileBlock.Count; i++)
            {
                writer.Write(TileBlock[i].ID);
            }
            writer.BaseStream.Seek(pos + 0x4, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Objects.Count);
            for (int i = 0; i < Objects.Count; i++)
            {
                writer.Write(Objects[i].Type);
                writer.Write(ConvertCoords(new uint[] { Objects[i].X, Objects[i].XOffset }));
                writer.Write(ConvertCoords(new uint[] { Objects[i].Y, Objects[i].YOffset }));
                writer.Write(Objects[i].Param1);
                writer.Write(Objects[i].Param2);
                writer.Write(Objects[i].Param3);
                writer.Write(Objects[i].Param4);
                writer.Write(Objects[i].Param5);
                writer.Write(Objects[i].Param6);
                writer.Write(Objects[i].Param7);
                writer.Write(Objects[i].Param8);
                writer.Write(Objects[i].Param9);
                writer.Write(Objects[i].Param10);
                writer.Write(Objects[i].Param11);
                writer.Write(Objects[i].Param12);
                writer.Write(Objects[i].Unknown);
            }
            writer.BaseStream.Seek(pos + 0x8, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0, SeekOrigin.End);
            writer.Write(dynamicCount);

            uint actionNexus = (uint)writer.BaseStream.Position;
            for (int i = 0; i < 16; i++)
            {
                writer.Write(0);
            }
            for (int i = 0; i < 16; i++)
            {
                pos = (uint)writer.BaseStream.Position;
                writer.BaseStream.Seek(actionNexus + (i * 0x4), SeekOrigin.Begin);
                writer.Write(pos);
                writer.BaseStream.Seek(pos, SeekOrigin.Begin);
                writer.Write((byte)ActionTable[i].EventID);
                writer.Write(ActionTable[i].Parameter1);
                writer.Write(ActionTable[i].Parameter2);
                writer.Write((byte)ActionTable[i].phases.Count);
                uint prm2 = 0x0;
                if (ActionTable[i].autoStart) prm2 = 0x1;
                writer.Write(prm2);
                writer.Write((uint)(writer.BaseStream.Position + 0x4));

                for (int p = 0; p < ActionTable[i].phases.Count; p++)
                {
                    writer.Write(ActionTable[i].phases[p].Direction);
                    writer.Write(ActionTable[i].phases[p].Distance);
                    writer.Write(ActionTable[i].phases[p].Delay);
                    writer.Write(ActionTable[i].phases[p].Unknown1);
                    writer.Write(ActionTable[i].phases[p].Duration);

                    byte endByte = 0x0;
                    if (!ActionTable[i].phases[p].EndPhase) endByte = 0x1;
                    writer.Write(endByte);
                    writer.Write(ActionTable[i].phases[p].Unknown2);

                    for (int a = 0; a < ActionTable[i].phases[p].Addendum.Length; a++)
                    {
                        writer.Write(ActionTable[i].phases[p].Addendum[a]);
                    }

                    writer.Write(ActionTable[i].phases[p].AccelType);
                    writer.Write(ActionTable[i].phases[p].AccelTime);
                    writer.Write(ActionTable[i].phases[p].Unknown3);
                }
            }

            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(0x34, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);

            writer.Write(Items.Count);
            for (int i = 0; i < Items.Count; i++)
            {
                writer.Write(Items[i].Type);
                writer.Write(Items[i].Behavior);
                writer.Write(Items[i].Level);
                writer.Write(Items[i].MovingTerrainID);
                writer.Write(ConvertCoords(new uint[] { Items[i].X, Items[i].XOffset }));
                writer.Write(ConvertCoords(new uint[] { Items[i].Y, Items[i].YOffset }));
            }
            pos = (uint)writer.BaseStream.Position;
            writer.BaseStream.Seek(bgmOffset, SeekOrigin.Begin);
            writer.Write(pos);
            writer.BaseStream.Seek(0, SeekOrigin.End);
            writer.Write(StageData.BGM.Length);
            writer.Write(Encoding.UTF8.GetBytes(StageData.BGM));
            writer.Write(0);

            writer.BaseStream.Seek(0x8, SeekOrigin.Begin);
            writer.Write((uint)writer.BaseStream.Length);
            writer.BaseStream.Seek(0x8, SeekOrigin.Begin);


            writer.Flush();
            writer.Dispose();
            writer.Close();
        }

        private uint[] ConvertCoords(uint coord)
        {
            string c = coord.ToString("X8").Remove(7, 1);
            string o = coord.ToString("X8").Remove(0, 7);
            return new uint[] { uint.Parse(c, System.Globalization.NumberStyles.HexNumber), uint.Parse(o, System.Globalization.NumberStyles.HexNumber) };
        }
        private uint ConvertCoords(uint[] coord)
        {
            string c = coord[0].ToString("X7") + coord[1].ToString("X1");
            return uint.Parse(c, System.Globalization.NumberStyles.HexNumber);
        }
    }
}
