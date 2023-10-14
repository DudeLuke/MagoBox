using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDLLVL
{
    public struct Object
    {
        public uint Type;
        public uint X;
        public uint XOffset;
        public uint Y;
        public uint YOffset;
        public uint Param1;
        public uint Param2;
        public uint Param3;
        public uint Param4;
        public uint Param5;
        public uint Param6;
        public uint Param7;
        public uint Param8;
        public uint Param9;
        public uint Param10;
        public uint Param11;
        public uint Param12;
        public uint Unknown;
    }

    public struct SpecialItem
    {
        public uint Type;
        public uint AppearID;
        public bool Respawn;
        public int MovingTerrainID;
        public uint X;
        public uint XOffset;
        public uint Y;
        public uint YOffset;
    }

    public struct Item
    {
        public uint Type;
        public uint Behavior;
        public uint Level;
        public int MovingTerrainID;
        public uint X;
        public uint XOffset;
        public uint Y;
        public uint YOffset;
    }

    public struct Boss
    {
        public uint Type;
        public uint Subtype;
        public uint Level;
        public uint Unknown;
        public int MovingTerrainID;
        public bool HasSuperAbility;
        public uint X;
        public uint XOffset;
        public uint Y;
        public uint YOffset;
    }

    public struct Enemy
    {
        public uint Type;
        public uint Behavior;
        public uint Level;
        public uint DirectionType;
        public uint SizeAD;
        public uint SizeEX;
        public int MovingTerrainID;
        public bool HasSuperAbility;
        public uint X;
        public uint XOffset;
        public uint Y;
        public uint YOffset;
    }

    public struct Block
    {
        public short ID;
    }

    public struct Collision
    {
        public byte Shape;
        public byte Modifier;
        public byte Material;
        public sbyte AutoMoveSpeed;
    }

    public struct Decoration
    {
        public short DecoID;
        public byte Unk_3;
        public sbyte MovingTerrainID;
    }

    public struct Section4D
    {
        public uint Type;
        public uint Param1;
        public uint Param2;
        public uint Param3;
        public uint Param4;
        public uint Param5;
        public uint Param6;
        public uint Param7;
        public uint Param8;
        public uint Param9;
        public uint Param10;
        public uint Param11;
        public uint Param12;
        public uint Param13;
        public uint Param14;
        public uint Param15;
        public uint Param16;
    }
    public struct Stage
    {
        public string BGM;
        public float BgX;
        public float BgY;
        public float BgZ;
        public float BgRotX;
        public float BgRotY;
        public float BgRotZ;
        public float BgDistance;
        public float BgScrollSpeedX;
        public float BgScrollDownX;
        public float BgScrollBackX;
        public float BgScrollRightY;
        public float BgScrollSpeedY;
        public float BgScrollBackY;
        public uint Filter;
        public uint RunEffect;
        public uint DeathStepFlag;
        public int DeathStepChange;
        public uint DeathStartID;
    }
    public struct MoveTile
    {
        public byte X;
        public byte Y;
        public byte Shape;
        public byte Material;
    }
    public struct SimpleMoveTile
    {
        public byte Shape;
        public byte Material;
        public bool NullTile;
    }
    public struct ActionPhase
    {
        public byte Direction;
        public byte Distance;
        public short Delay;
        public short Unknown1;
        public short Duration;
        public bool EndPhase;
        public byte Unknown2;
        public byte[] Addendum;
        public byte AccelType;
        public byte AccelTime;
        public short Unknown3;
    }
    public class DynamicTerrain
    {
        public short X;
        public short Y;
        public short Width;
        public short Height;
        public List<MoveTile> tiles;

        public DynamicTerrain()
        {
            tiles = new List<MoveTile>();
        }
    }
    public class DynamicAction
    {
        public int EventID = -1;
        public byte Parameter1 = 0;
        public byte Parameter2 = 0;
        public bool autoStart = true;
        public List<ActionPhase> phases;

        public DynamicAction()
        {
            phases = new List<ActionPhase>();
        }
    }
}
