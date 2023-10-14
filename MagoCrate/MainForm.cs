using IniParser;
using IniParser.Model;
using MagoBox.Editors;
using MagoBox.Rendering;
using MagoCrate;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using RDLLVL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagoBox
{
    public partial class MainForm : Form
    {
        public Level level;
        public string filePath;
        IniData plt = new IniData();
        List<IniData> tilePalettes = new List<IniData>();
        System.Windows.Forms.Button selPaletteButton;

        BmFont font;
        Objects objs = new Objects();

        public List<int> utilityTexIds = new List<int>();
        public List<int> shapeTexIds = new List<int>();
        public List<int> modTexIds = new List<int>();
        public List<int> propertyTexIds = new List<int>();
        List<int> hexTexIds = new List<int>();
        List<int> zoneTexIds = new List<int>();

        Dictionary<short, int> blockTexIds = new Dictionary<short, int>();
        public Dictionary<string, int> spriteTexIds = new Dictionary<string, int>();
        public IniData spriteParameters = new IniData();

        public Texturing texturing;
        Renderer renderer;
        Camera camera;

        private System.Timers.Timer t;
        public int collViewType = 0;
        public int optionsPixelPerTile = 20;
        int moveObj;
        int tool = -1;
        bool moveCam = false;
        bool clickedEntity = false;
        public bool refreshing = false;
        bool focused = true;
        int mouseX = 0;
        int mouseY = 0;

        private uint tileX, tileY;
        private int tileStartX, tileStartY, tileEndX, tileEndY;
        private Vector2 vec_scale;
        private Vector2 hexTextOffset;

        private KirbyFDGH.FDGH fdgArchive;
        private KirbyFDGH.FDGH2 fdgArchive2;
        private Dictionary<string, int> fdgSceneList = new Dictionary<string, int>();
        private string fdgFilePath;
        private string fdgScn;
        private string notesFilepath;
        List<string> checkedThings = new List<string>();

        public string debugString;

        public MainForm(string path)
        {
            InitializeComponent();
            filePath = path;
            Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshColors();
        }
        private void MainForm_Enter(object sender, EventArgs e)
        {
            focused = true;
        }
        private void MainForm_Leave(object sender, EventArgs e)
        {
            focused = false;
        }
        private void glControl_Load(object sender, EventArgs e)
        {
            viewType.SelectedIndex = 0;
            blockList.SelectedIndex = 0;
            materialList.SelectedIndex = 0;

            glControl.MakeCurrent();
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.ClearColor(Color.FromArgb(200, 200, 200));

            Console.WriteLine(Directory.GetCurrentDirectory());

            renderer = new Renderer();
            texturing = new Texturing();
            camera = new Camera(new Vector2(0, 0), 1.1);
            string d = Directory.GetCurrentDirectory();

            for (int i = 0; i < 52; i++)
            {
                shapeTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/" + i + ".png"));
            }
            shapeTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/select.png"));
            shapeTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/-1.png"));


            modTexIds.Add(texturing.LoadTexture(d + "/Resources/modifiers/ladder.png"));
            modTexIds.Add(texturing.LoadTexture(d + "/Resources/modifiers/boundary.png"));
            modTexIds.Add(texturing.LoadTexture(d + "/Resources/modifiers/water.png"));
            modTexIds.Add(texturing.LoadTexture(d + "/Resources/modifiers/spike.png"));
            modTexIds.Add(texturing.LoadTexture(d + "/Resources/modifiers/ice.png"));
            modTexIds.Add(texturing.LoadTexture(d + "/Resources/modifiers/lava.png"));

            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/mat_Grass.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/mat_Wood.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/mat_Stone.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/mat_Sand.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/mat_Snow.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/mat_Clouds.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/mat_Metal.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/auto_1.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/auto_2.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/auto_3.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/auto_-1.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/auto_-2.png"));
            propertyTexIds.Add(texturing.LoadTexture(d + "/Resources/properties/auto_-3.png"));

            utilityTexIds.Add(texturing.LoadTexture(d + "/Resources/entities/object.png"));
            utilityTexIds.Add(texturing.LoadTexture(d + "/Resources/entities/select.png"));
            utilityTexIds.Add(texturing.LoadTexture(d + "/Resources/entities/selectFull.png"));
            utilityTexIds.Add(texturing.LoadTexture(d + "/Resources/entities/Super.png"));

            zoneTexIds.Add(texturing.LoadTexture(d + "/Resources/entities/objects/hardcoded/wind_zone.png"));
            zoneTexIds.Add(texturing.LoadTexture(d + "/Resources/entities/objects/hardcoded/trigger_zone.png"));
            zoneTexIds.Add(texturing.LoadTexture(d + "/Resources/entities/objects/hardcoded/bubble_zone.png"));
            zoneTexIds.Add(texturing.LoadTexture(d + "/Resources/entities/objects/hardcoded/super_zone.png"));

            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/h0.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/h1.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/h2.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/h3.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/h4.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/h5.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/h6.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/h7.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/h8.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/h9.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/hA.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/hB.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/hC.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/hD.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/hE.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/hF.png"));
            hexTexIds.Add(texturing.LoadTexture(d + "/Resources/tiles/Hex/hBack.png"));

            blockTexIds.Add(0xFF, texturing.LoadTexture(d + "/Resources/blocks/Unknown.png"));
            blockTexIds.Add(0, texturing.LoadTexture(d + "/Resources/blocks/Star.png"));
            blockTexIds.Add(1, texturing.LoadTexture(d + "/Resources/blocks/Super.png"));
            blockTexIds.Add(2, texturing.LoadTexture(d + "/Resources/blocks/Stone 2x2.png"));
            blockTexIds.Add(3, texturing.LoadTexture(d + "/Resources/blocks/Super Top 2x2.png"));
            blockTexIds.Add(4, texturing.LoadTexture(d + "/Resources/blocks/Stone.png"));
            blockTexIds.Add(5, texturing.LoadTexture(d + "/Resources/blocks/Stone 3x3.png"));
            blockTexIds.Add(6, texturing.LoadTexture(d + "/Resources/blocks/Super (Alt).png"));
            blockTexIds.Add(7, texturing.LoadTexture(d + "/Resources/blocks/Super 2x2.png"));
            blockTexIds.Add(10, texturing.LoadTexture(d + "/Resources/blocks/Tree Top.png"));
            blockTexIds.Add(11, texturing.LoadTexture(d + "/Resources/blocks/Tree Bottom.png"));
            blockTexIds.Add(13, texturing.LoadTexture(d + "/Resources/blocks/Giant Tree Right Corner.png"));
            blockTexIds.Add(15, texturing.LoadTexture(d + "/Resources/blocks/Giant Tree Bottom.png"));
            blockTexIds.Add(17, texturing.LoadTexture(d + "/Resources/blocks/Giant Tree Left Corner.png"));
            blockTexIds.Add(18, texturing.LoadTexture(d + "/Resources/blocks/Bomb.png"));
            blockTexIds.Add(19, texturing.LoadTexture(d + "/Resources/blocks/Bomb Chain.png"));
            blockTexIds.Add(20, texturing.LoadTexture(d + "/Resources/blocks/Invisible Bomb Chain.png"));
            blockTexIds.Add(21, texturing.LoadTexture(d + "/Resources/blocks/Bomb Generated.png"));
            blockTexIds.Add(22, texturing.LoadTexture(d + "/Resources/blocks/Stone 4x4.png"));
            blockTexIds.Add(23, texturing.LoadTexture(d + "/Resources/blocks/Tree.png"));
            blockTexIds.Add(24, texturing.LoadTexture(d + "/Resources/blocks/Stone Reverse T.png"));
            blockTexIds.Add(25, texturing.LoadTexture(d + "/Resources/blocks/Stone T.png"));
            blockTexIds.Add(26, texturing.LoadTexture(d + "/Resources/blocks/Stone Stair Left.png"));
            blockTexIds.Add(27, texturing.LoadTexture(d + "/Resources/blocks/Stone 3x1.png"));
            blockTexIds.Add(28, texturing.LoadTexture(d + "/Resources/blocks/Stone 1x3.png"));
            blockTexIds.Add(29, texturing.LoadTexture(d + "/Resources/blocks/Stone 2x4x4x2.png"));
            blockTexIds.Add(30, texturing.LoadTexture(d + "/Resources/blocks/Breakable.png"));
            blockTexIds.Add(31, texturing.LoadTexture(d + "/Resources/blocks/Stone Stair Right.png"));
            blockTexIds.Add(32, texturing.LoadTexture(d + "/Resources/blocks/Fire.png"));
            blockTexIds.Add(33, texturing.LoadTexture(d + "/Resources/blocks/Crumble.png"));
            blockTexIds.Add(34, texturing.LoadTexture(d + "/Resources/blocks/Metal.png"));
            blockTexIds.Add(36, texturing.LoadTexture(d + "/Resources/blocks/Ice.png"));
            blockTexIds.Add(37, texturing.LoadTexture(d + "/Resources/blocks/Snow.png"));
            blockTexIds.Add(38, texturing.LoadTexture(d + "/Resources/blocks/Snow (Wide).png"));
            blockTexIds.Add(39, texturing.LoadTexture(d + "/Resources/blocks/Iced Snow.png"));
            blockTexIds.Add(40, texturing.LoadTexture(d + "/Resources/blocks/Iced Snow (Wide).png"));
            blockTexIds.Add(41, texturing.LoadTexture(d + "/Resources/blocks/Gold 2x2.png"));
            blockTexIds.Add(42, texturing.LoadTexture(d + "/Resources/blocks/Giant Tree Right.png"));
            blockTexIds.Add(43, texturing.LoadTexture(d + "/Resources/blocks/Giant Tree.png"));
            blockTexIds.Add(44, texturing.LoadTexture(d + "/Resources/blocks/Giant Tree Left.png"));
            blockTexIds.Add(45, texturing.LoadTexture(d + "/Resources/blocks/Tree Bottom (Alt).png"));
            blockTexIds.Add(46, texturing.LoadTexture(d + "/Resources/blocks/Tree (Alt).png"));
            blockTexIds.Add(47, texturing.LoadTexture(d + "/Resources/blocks/Metal Crumble.png"));
            blockTexIds.Add(48, texturing.LoadTexture(d + "/Resources/blocks/Super (Alt 2).png"));
            blockTexIds.Add(49, texturing.LoadTexture(d + "/Resources/blocks/Super 1x2.png"));
            blockTexIds.Add(50, texturing.LoadTexture(d + "/Resources/blocks/Super 2x2 (Alt).png"));
            blockTexIds.Add(52, texturing.LoadTexture(d + "/Resources/blocks/Super 4x2.png"));
            blockTexIds.Add(53, texturing.LoadTexture(d + "/Resources/blocks/Gold 3x3.png"));
            blockTexIds.Add(54, texturing.LoadTexture(d + "/Resources/blocks/Fire (Fragile).png"));
            blockTexIds.Add(55, texturing.LoadTexture(d + "/Resources/blocks/Super Top.png"));
            blockTexIds.Add(56, texturing.LoadTexture(d + "/Resources/blocks/Super Top 2x2 (Alt).png"));
            blockTexIds.Add(57, texturing.LoadTexture(d + "/Resources/blocks/Super 4x4.png"));
            blockTexIds.Add(58, texturing.LoadTexture(d + "/Resources/blocks/Super 3x3.png"));
            blockTexIds.Add(59, texturing.LoadTexture(d + "/Resources/blocks/Fire 2x2 (Fragile).png"));
            try
            {
                font = new BmFont(texturing, "a");
            } catch { MessageBox.Show("Failed to load Font files"); }
            notesFilepath = (d + "/CustomData/EntityNotes.txt");

            RefreshEntitySprites();
            RefreshPaletteList();

            t = new System.Timers.Timer(1000.0 / 60.0);
            t.Elapsed += t_Elapsed;
            t.Start();
            if (!string.IsNullOrEmpty(filePath)) 
            {
                LoadLevel(filePath);
            }
        }

        public async void RefreshEntityLists()
        {
            if (level != null)
            {
                Objects objs = new Objects();
                int selIndex = 0;
                refreshing = true;

                // Objects
                selIndex = objList.SelectedIndex;
                objList.Items.Clear();
                objList.BeginUpdate();
                for (int i = 0; i < level.Objects.Count; i++)
                {
                    if (objs.ObjectList.ContainsKey(level.Objects[i].Type))
                    {
                        objList.Items.Add(objs.ObjectList[level.Objects[i].Type]);
                    }
                    else
                    {
                        objList.Items.Add($"Unknown ({level.Objects[i].Type})");
                    }
                }
                if (objList.Items.Count >= selIndex + 1) objList.SelectedIndex = selIndex;
                objList.EndUpdate();

                // Carriables
                selIndex = carriablesList.SelectedIndex;
                carriablesList.Items.Clear();
                carriablesList.BeginUpdate();
                for (int i = 0; i < level.Carriables.Count; i++)
                {
                    if (objs.CarriablesList.ContainsKey(level.Carriables[i].Type))
                    {
                        carriablesList.Items.Add(objs.CarriablesList[level.Carriables[i].Type]);
                    }
                    else
                    {
                        carriablesList.Items.Add($"Unknown ({level.Carriables[i].Type})");
                    }
                }
                if (carriablesList.Items.Count >= selIndex + 1) carriablesList.SelectedIndex = selIndex;
                carriablesList.EndUpdate();

                // Items
                selIndex = itemList.SelectedIndex;
                itemList.Items.Clear();
                itemList.BeginUpdate();
                for (int i = 0; i < level.Items.Count; i++)
                {
                    if (objs.ItemList.ContainsKey(level.Items[i].Type))
                    {
                        itemList.Items.Add(objs.ItemList[level.Items[i].Type]);
                    }
                    else
                    {
                        itemList.Items.Add($"Unknown ({level.Items[i].Type})");
                    }
                }
                if (itemList.Items.Count >= selIndex + 1) itemList.SelectedIndex = selIndex;
                itemList.EndUpdate();

                // Bosses
                selIndex = bossList.SelectedIndex;
                bossList.Items.Clear();
                bossList.BeginUpdate();
                for (int i = 0; i < level.Bosses.Count; i++)
                {
                    if (objs.BossList.ContainsKey(level.Bosses[i].Type))
                    {
                        bossList.Items.Add(objs.BossList[level.Bosses[i].Type]);
                    }
                    else
                    {
                        bossList.Items.Add($"Unknown ({level.Bosses[i].Type})");
                    }
                }
                if (bossList.Items.Count >= selIndex + 1) bossList.SelectedIndex = selIndex;
                bossList.EndUpdate();

                // Enemies
                selIndex = enemyList.SelectedIndex;
                enemyList.Items.Clear();
                enemyList.BeginUpdate();
                for (int i = 0; i < level.Enemies.Count; i++)
                {
                    if (objs.EnemyList.ContainsKey(level.Enemies[i].Type))
                    {
                        enemyList.Items.Add(objs.EnemyList[level.Enemies[i].Type]);
                    }
                    else
                    {
                        enemyList.Items.Add($"Unknown ({level.Enemies[i].Type})");
                    }
                }
                if (enemyList.Items.Count >= selIndex + 1) enemyList.SelectedIndex = selIndex;
                enemyList.EndUpdate();

                // Dynamic Sections
                selIndex = dynamicList.SelectedIndex;
                dynamicList.Items.Clear();
                dynamicList.BeginUpdate();
                for (int i = 0; i < level.DynamicTerrain.Count; i++)
                {
                    if (level.DynamicTerrain[i] != null) dynamicList.Items.Add(i + $" - Section ({level.DynamicTerrain[i].X}, {level.DynamicTerrain[i].Y})");
                    else dynamicList.Items.Add(i + $" - Empty");
                }
                if (dynamicList.Items.Count >= selIndex + 1) dynamicList.SelectedIndex = selIndex;
                dynamicList.EndUpdate();

                await Task.Delay(20);
                refreshing = false;
            }
        }
        public void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            enemyList.BackColor = MagoCrate.Properties.Settings.Default.EnemyColor;
            bossList.BackColor = MagoCrate.Properties.Settings.Default.BossColor;
            objList.BackColor = MagoCrate.Properties.Settings.Default.ObjColor;
            itemList.BackColor = MagoCrate.Properties.Settings.Default.ItemColor;
            carriablesList.BackColor = MagoCrate.Properties.Settings.Default.CarryColor;
            dynamicList.BackColor = MagoCrate.Properties.Settings.Default.DynamicSectionColor;
        }
        private void RefreshTileDataEditorColors()
        {
            int v = viewType.SelectedIndex;
            vShape.BackColor = Color.White;
            vMat.BackColor = Color.White;
            materialList.BackColor = Color.White;
            vAutomove.BackColor = Color.White;
            vBlock.BackColor = Color.White;
            blockList.BackColor = Color.White;
            dB_ID.BackColor = Color.White;
            dB_Unk.BackColor = Color.White;
            dB_Dynamic.BackColor = Color.White;
            dB_hex.BackColor = Color.White;
            dM_ID.BackColor = Color.White;
            dM_Unk.BackColor = Color.White;
            dM_Dynamic.BackColor = Color.White;
            dM_hex.BackColor = Color.White;
            dF_ID.BackColor = Color.White;
            dF_Unk.BackColor = Color.White;
            dF_Dynamic.BackColor = Color.White;
            dF_hex.BackColor = Color.White;

            if ((v != 0 && v != 2) || !editCollisionShapeToolStripMenuItem.Checked) vShape.BackColor = Color.Silver;
            if ((v != 0 && v != 2) || !editAutoMovementToolStripMenuItem.Checked) vAutomove.BackColor = Color.Silver;
            if ((v != 0 && v != 2) || !editMaterialsToolStripMenuItem.Checked)
            {
                vMat.BackColor = Color.Silver;
                materialList.BackColor = Color.Silver;
            }
            if ((v != 0 && v != 2) || !editBlocksToolStripMenuItem.Checked)
            {
                vBlock.BackColor = Color.Silver;
                blockList.BackColor = Color.Silver;
            }
            if (v == 2 || v == 3 || v == 4 || !editBLandToolStripMenuItem.Checked)
            {
                dB_ID.BackColor = Color.Silver;
                dB_Unk.BackColor = Color.Silver;
                dB_Dynamic.BackColor = Color.Silver;
                dB_hex.BackColor = Color.Silver;
            }
            if (v == 1 || v == 3 || v == 4 || !editMLandToolStripMenuItem.Checked)
            {
                dM_ID.BackColor = Color.Silver;
                dM_Unk.BackColor = Color.Silver;
                dM_Dynamic.BackColor = Color.Silver;
                dM_hex.BackColor = Color.Silver;
            }
            if (v == 1 || v == 2 || v == 4 || !editFLandToolStripMenuItem.Checked)
            {
                dF_ID.BackColor = Color.Silver;
                dF_Unk.BackColor = Color.Silver;
                dF_Dynamic.BackColor = Color.Silver;
                dF_hex.BackColor = Color.Silver;
            }

            if (v == 4)
            {
                if (editBLandToolStripMenuItem.Checked)
                {
                    dB_Dynamic.BackColor = Color.White;
                    dB_hex.BackColor = Color.White;
                }
                if (editMLandToolStripMenuItem.Checked)
                {
                    dM_Dynamic.BackColor = Color.White;
                    dM_hex.BackColor = Color.White;
                }
                if (editFLandToolStripMenuItem.Checked)
                {
                    dF_Dynamic.BackColor = Color.White;
                    dF_hex.BackColor = Color.White;
                }
            }
        }
        public void Save()
        {
            Enabled = false;
            Cursor = Cursors.WaitCursor;
            Text = $"MagoCrate - Saving {filePath}...";

            BigEndianBinaryWriter writer = new BigEndianBinaryWriter(new FileStream(filePath, FileMode.Create));
            level.Write(writer);

            Enabled = true;
            Text = $"MagoCrate - {filePath}";
            Cursor = Cursors.Arrow;
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLevel newlvl = new NewLevel();
            if (newlvl.ShowDialog() == DialogResult.OK)
            {
                a = true;

                objList.Items.Clear();
                carriablesList.Items.Clear();
                itemList.Items.Clear();
                bossList.Items.Clear();
                enemyList.Items.Clear();

                level = newlvl.level;

                camera.pos = Vector2.Zero;
                camera.zoom = 1.1;
                RefreshEntityLists();

                sizeH.Value = level.Height;
                sizeW.Value = level.Width;

                Text = $"MagoCrate - New Level";

                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;

                a = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Kirby's Return to Dream Land Level Files|*.dat";
                open.DefaultExt = ".dat";
                open.CheckFileExists = true;
                open.Title = "Open Level File";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    LoadLevel(open.FileName);
                }
            } catch
            {
                MessageBox.Show("Failed To Open File");
                Enabled = true;
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = null;
            objList.Items.Clear();
            carriablesList.Items.Clear();
            itemList.Items.Clear();
            bossList.Items.Clear();
            enemyList.Items.Clear();
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            SwitchTool(-1);
        }
        private void LoadLevel(string path)
        {
            a = true;

            filePath = path;
            objList.Items.Clear();
            carriablesList.Items.Clear();
            itemList.Items.Clear();
            bossList.Items.Clear();
            enemyList.Items.Clear();

            Enabled = false;
            Cursor = Cursors.WaitCursor;
            Text = $"MagoCrate - Opening {filePath}...";

            level = new Level(path);

            camera.pos = Vector2.Zero;
            camera.zoom = 1.1;
            RefreshEntityLists();

            sizeH.Value = level.Height;
            sizeW.Value = level.Width;

            Text = $"MagoCrate - {filePath}";
            a = false;

            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;

            Cursor = Cursors.Arrow;
            Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Kirby's Return to Dream Land Level Files|*.dat";
            save.DefaultExt = ".dat";
            save.Title = "Save Level File";
            if (save.ShowDialog() == DialogResult.OK)
            {
                filePath = save.FileName;
                Save();
            }
        }
        private void viewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTileDataEditorColors();
        }
        private void exportPalette_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Path.GetFullPath(Directory.GetCurrentDirectory() + "/CustomData/TilePalettes");
            save.RestoreDirectory = true;
            save.FileName = "New Palette";
            save.AddExtension = true;
            save.Filter = "Palette INI File|*.ini";
            if (save.ShowDialog() == DialogResult.OK)
            {
                new FileIniDataParser().WriteFile(save.FileName, plt);
                RefreshPaletteList();
                if (paletteList.Items.Count > 0) paletteList.SelectedIndex = paletteList.Items.Count - 1;
            }
        }
        private void refreshPalette_Click(object sender, EventArgs e)
        {
            RefreshPaletteList();
        }
        private void RefreshPaletteList()
        {
            string path = Directory.GetCurrentDirectory() + "/CustomData/TilePalettes";
            string[] files = Directory.GetFiles(path);

            int prevIndex = 0;
            if (paletteList.Items.Count > 0 && paletteList.SelectedIndex != null) prevIndex = paletteList.SelectedIndex;
            paletteList.Items.Clear();
            tilePalettes.Clear();

            foreach (string file in files)
            {
                if (file.EndsWith(".ini"))
                {
                    string name = Path.GetFileName(file);
                    name = name.Substring(0, name.Length - 4);

                    if (!paletteList.Items.Contains(name))
                    {
                        tilePalettes.Add(new FileIniDataParser().ReadFile(file));
                        paletteList.Items.Add(name);
                    }
                }
            }

            if (paletteList.Items.Count > 0) paletteList.SelectedIndex = prevIndex;

        }
        private void paletteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePaletteTiles();
        }
        private void UpdatePaletteTiles()
        {
            try
            {
                if (paletteList.Items.Count == 0) return;
                plt = tilePalettes[paletteList.SelectedIndex];
                for (int i = 1; i <= plt.Sections.Count; i++)
                {
                    string ID = i.ToString();
                    UpdatePaletteButton(PaletteTileButtonFromIndex(i),
                        plt.Sections[ID]["BLand"],
                        plt.Sections[ID]["MLand"],
                        plt.Sections[ID]["FLand"],
                        plt.Sections[ID]["Shape"],
                        plt.Sections[ID]["Mod"],
                        plt.Sections[ID]["Name"]);
                }
                if (plt.Sections.Count < 32)
                {
                    for (int i = plt.Sections.Count + 1; i <= 32; i++)
                    {
                        string ID = i.ToString();
                        plt.Sections.AddSection(ID);
                        plt.Sections[ID].AddKey("Name", "Empty");
                        plt.Sections[ID].AddKey("BLand", "FFFF00FF");
                        plt.Sections[ID].AddKey("MLand", "FFFF00FF");
                        plt.Sections[ID].AddKey("FLand", "FFFF00FF");
                        plt.Sections[ID].AddKey("Shape", "0");
                        plt.Sections[ID].AddKey("Mod", "0");
                        plt.Sections[ID].AddKey("Mat", "0");
                        plt.Sections[ID].AddKey("Auto", "0");
                        plt.Sections[ID].AddKey("Block", "-1");
                        UpdatePaletteButton(PaletteTileButtonFromIndex(i), "FFFF00FF", "FFFF00FF", "FFFF00FF", "0", "0", "Empty");
                    }
                }
            } catch { }
        }

        private void UpdatePaletteButton(System.Windows.Forms.Button target, string bHex, string mHex, string fHex, string shape, string modifier, string name)
        {
            // Color
            toolTip1.SetToolTip(target, name);

            byte val1 = byte.Parse(mHex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte val2 = byte.Parse(mHex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte val3 = byte.Parse(mHex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            if (mHex != "FFFF00FF")
            {
                target.BackColor = DecorColorFromBytes(val1, val2, val3);
            } else if (bHex != "FFFF00FF")
            {
                val1 = byte.Parse(bHex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                val2 = byte.Parse(bHex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                val3 = byte.Parse(bHex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                target.BackColor = DecorColorFromBytes(val1, val2, val3);
            } else if (fHex != "FFFF00FF")
            {
                val1 = byte.Parse(fHex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                val2 = byte.Parse(fHex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                val3 = byte.Parse(fHex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                target.BackColor = DecorColorFromBytes(val1, val2, val3);
            } else target.BackColor = Color.White;

            // Shape
            target.BackgroundImage = Image.FromFile("Resources/tiles/" + shape + ".png");

            // Modifiers
            int mod = int.Parse(modifier);
            target.Image = null;
            if ((mod & (1 << 1)) != 0) // Ladder
            {
                target.Image = Image.FromFile("Resources/modifiers/ladder.png");
            }
            else if ((mod & (1 << 2)) != 0) // Boundary
            {
                target.Image = Image.FromFile("Resources/modifiers/boundary.png");
            }
            else if ((mod & (1 << 3)) != 0) // Water
            {
                target.Image = Image.FromFile("Resources/modifiers/water.png");
            }
            else if ((mod & (1 << 4)) != 0) // Spike
            {
                target.Image = Image.FromFile("Resources/modifiers/spike.png");
            }
            else if ((mod & (1 << 5)) != 0) // Ice
            {
                target.Image = Image.FromFile("Resources/modifiers/ice.png");
            }
            else if ((mod & (1 << 6)) != 0) // Lava
            {
                target.Image = Image.FromFile("Resources/modifiers/lava.png");
            }
        }
        private void paletteButton_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                plt = tilePalettes[paletteList.SelectedIndex];
                selPaletteButton = (System.Windows.Forms.Button)sender;
                string ID = (selPaletteButton).Name.Substring(5, (selPaletteButton).Name.Length - 5);

                if (e.Button == MouseButtons.Right)
                {
                    // Save Current Tile Data over that palette

                    int mod = 0;
                    if (ladder.Checked) mod += 2;
                    if (boundary.Checked) mod += 4;
                    if (water.Checked) mod += 8;
                    if (spike.Checked) mod += 16;
                    if (ice.Checked) mod += 32;
                    if (lava.Checked) mod += 64;
                    plt.Sections[ID]["Mod"] = mod.ToString();


                    plt.Sections[ID]["Shape"] = vShape.Value.ToString();
                    plt.Sections[ID]["Mat"] = vMat.Value.ToString();
                    plt.Sections[ID]["Auto"] = vAutomove.Value.ToString();
                    plt.Sections[ID]["Block"] = vBlock.Value.ToString();
                    plt.Sections[ID]["Name"] = tileName.Text.ToString();

                    dB_hex.Text = ((short)dB_ID.Value).ToString("X4") + ((byte)dB_Unk.Value).ToString("X2") + ((sbyte)dB_Dynamic.Value).ToString("X2");
                    dF_hex.Text = ((short)dF_ID.Value).ToString("X4") + ((byte)dF_Unk.Value).ToString("X2") + ((sbyte)dF_Dynamic.Value).ToString("X2");
                    dM_hex.Text = ((short)dM_ID.Value).ToString("X4") + ((byte)dM_Unk.Value).ToString("X2") + ((sbyte)dM_Dynamic.Value).ToString("X2");

                    plt.Sections[ID]["BLand"] = dB_hex.Text;
                    plt.Sections[ID]["MLand"] = dM_hex.Text;
                    plt.Sections[ID]["FLand"] = dF_hex.Text;

                    UpdatePaletteTiles();
                }
                else if (e.Button == MouseButtons.Left)
                {
                    // Get That Tile's Data

                    ladder.Checked = false;
                    boundary.Checked = false;
                    water.Checked = false;
                    spike.Checked = false;
                    ice.Checked = false;
                    lava.Checked = false;

                    short mod = short.Parse(plt.Sections[ID]["Mod"]);
                    if ((mod & (1 << 1)) != 0) ladder.Checked = true;
                    if ((mod & (1 << 2)) != 0) boundary.Checked = true;
                    if ((mod & (1 << 3)) != 0) water.Checked = true;
                    if ((mod & (1 << 4)) != 0) spike.Checked = true;
                    if ((mod & (1 << 5)) != 0) ice.Checked = true;
                    if ((mod & (1 << 6)) != 0) lava.Checked = true;

                    vShape.Value = int.Parse(plt.Sections[ID]["Shape"]);
                    vMat.Value = decimal.Parse(plt.Sections[ID]["Mat"]);
                    vAutomove.Value = decimal.Parse(plt.Sections[ID]["Auto"]);
                    vBlock.Value = decimal.Parse(plt.Sections[ID]["Block"]);
                    if (plt.Sections[ID]["BLand"] != "FFFF00FF" || ModifierKeys != Keys.Shift) dB_hex.Text = plt.Sections[ID]["BLand"];
                    if (plt.Sections[ID]["MLand"] != "FFFF00FF" || ModifierKeys != Keys.Shift) dM_hex.Text = plt.Sections[ID]["MLand"];
                    if (plt.Sections[ID]["FLand"] != "FFFF00FF" || ModifierKeys != Keys.Shift) dF_hex.Text = plt.Sections[ID]["FLand"];
                    tileName.Text = plt.Sections[ID]["Name"];
                }
            } catch { }
        }
        private System.Windows.Forms.Button PaletteTileButtonFromIndex(int index)
        {
            switch (index)
            {
                case 1: return pTile1;
                case 2: return pTile2;
                case 3: return pTile3;
                case 4: return pTile4;
                case 5: return pTile5;
                case 6: return pTile6;
                case 7: return pTile7;
                case 8: return pTile8;
                case 9: return pTile9;
                case 10: return pTile10;
                case 11: return pTile11;
                case 12: return pTile12;
                case 13: return pTile13;
                case 14: return pTile14;
                case 15: return pTile15;
                case 16: return pTile16;
                case 17: return pTile17;
                case 18: return pTile18;
                case 19: return pTile19;
                case 20: return pTile20;
                case 21: return pTile21;
                case 22: return pTile22;
                case 23: return pTile23;
                case 24: return pTile24;
                case 25: return pTile25;
                case 26: return pTile26;
                case 27: return pTile27;
                case 28: return pTile28;
                case 29: return pTile29;
                case 30: return pTile30;
                case 31: return pTile31;
                case 32: return pTile32;
            }
            return pTile1;
        }
        private void RefreshEntitySprites()
        {
            Objects objs = new Objects();
            Image img = Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\tiles\\0.png");

            string paramPath = Directory.GetCurrentDirectory() + "\\CustomData\\SpriteParameters.ini";
            if (!File.Exists(paramPath)) spriteParameters = new IniData();
            else spriteParameters = new FileIniDataParser().ReadFile(paramPath);

            spriteTexIds.Clear();

            string entPath = Directory.GetCurrentDirectory() + "\\Resources\\entities";
            string[] files = new string[0];
            string categ = "";
            string resourcePath = "";
            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        files = Directory.GetFiles(entPath + "\\enemies");
                        categ = "E.";
                        resourcePath = "Resources/entities/enemies/";
                        break;
                    case 1:
                        files = Directory.GetFiles(entPath + "\\bosses");
                        categ = "B.";
                        resourcePath = "Resources/entities/bosses/";
                        break;
                    case 2:
                        files = Directory.GetFiles(entPath + "\\carriables");
                        categ = "C.";
                        resourcePath = "Resources/entities/carriables/";
                        break;
                    case 3:
                        files = Directory.GetFiles(entPath + "\\items");
                        categ = "I.";
                        resourcePath = "Resources/entities/items/";
                        break;
                    case 4:
                        files = Directory.GetFiles(entPath + "\\objects");
                        categ = "O.";
                        resourcePath = "Resources/entities/objects/";
                        break;
                    case 5:
                        files = Directory.GetFiles(entPath + "\\objects\\hardcoded");
                        categ = "X.";
                        resourcePath = "Resources/entities/objects/hardcoded/";
                        break;
                }

                foreach (string file in files)
                {
                    string fileName = (Path.GetFileName(file));
                    string trueName = fileName.Substring(0, fileName.Length - 4);
                    spriteTexIds.Add(categ + trueName, texturing.LoadTexture(resourcePath + fileName));

                    debugString = resourcePath + fileName;

                    bool complexSprite = false;
                    if (trueName.Any(char.IsDigit)) complexSprite = true;

                    if (!complexSprite)
                    {
                        try
                        {
                            img = Image.FromFile(file);
                        }
                        catch { }

                        if (!spriteParameters.Sections.ContainsSection(categ + trueName))
                        {
                            spriteParameters.Sections.AddSection(categ + trueName);
                            spriteParameters.Sections[categ + trueName].AddKey("W");
                            spriteParameters.Sections[categ + trueName]["W"] = img.Width.ToString();
                            spriteParameters.Sections[categ + trueName].AddKey("H");
                            spriteParameters.Sections[categ + trueName]["H"] = img.Height.ToString();
                            spriteParameters.Sections[categ + trueName].AddKey("X");
                            spriteParameters.Sections[categ + trueName]["X"] = "0";
                            spriteParameters.Sections[categ + trueName].AddKey("Y");
                            spriteParameters.Sections[categ + trueName]["Y"] = "0";
                        }
                    }
                }

                StreamWriter stream = new StreamWriter(paramPath);
                new FileIniDataParser().WriteData(stream, spriteParameters);
                stream.Close();
                stream.Dispose();
            }
        }
        private void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            glControl.Invalidate();
            t.Start();
        }
        private void glControl_Resize(object sender, EventArgs e)
        {
            int w = glControl.Width;
            int h = glControl.Height;
            GL.Viewport(0, 0, (int)w, (int)h);
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.FromArgb(200, 200, 200));

            if (refreshing || !focused) return;

            renderer.Begin(glControl.Width, glControl.Height);
            camera.Transform();

            if (level != null)
            {
                //Crop Tiles outside camera view.

                tileStartX = (int)Math.Max(0, Math.Floor(
                        (camera.pos.X - glControl.Width / camera.zoom * 0.5f) / 16.0f
                    ));
                tileEndX = (int)Math.Min(level.Width, Math.Ceiling(
                        (camera.pos.X + glControl.Width / camera.zoom * 0.5f) / 16.0f
                    ));
                tileStartY = (int)Math.Max(0, 1 + Math.Floor(
                        -(camera.pos.Y + glControl.Height / camera.zoom * 0.5f) / 16.0f
                    ));
                tileEndY = (int)Math.Min(level.Height, 1 + Math.Ceiling(
                        -(camera.pos.Y - glControl.Height / camera.zoom * 0.5f) / 16.0f
                    ));

                vec_scale = new Vector2(1.0f, 1.0f);
                hexTextOffset = new Vector2(8, 8);
                float range = MagoCrate.Properties.Settings.Default.entityCullRange;
                bool colored = false;
                if (viewType.SelectedIndex != 0 && viewType.SelectedIndex != 4 && MagoCrate.Properties.Settings.Default.decorSetting == 0) colored = true;

                RenderCollisions(colored);
                if (renderTileModifiersToolStripMenuItem.Checked) RenderModifiers();
                if (renderMaterialsToolStripMenuItem.Checked) RenderMaterials();
                if (renderAutoMovementToolStripMenuItem.Checked) RenderAutoMovement();
                if (renderDynamicTerrainToolStripMenuItem.Checked) RenderDynamicTerrain();
                if (renderBlocksToolStripMenuItem.Checked) RenderBlocks();

                if (renderObjectPointsToolStripMenuItem.Checked)
                {
                    RenderZones();
                    RenderObjects(range);
                    RenderCarriables(range);
                    RenderItems(range);
                    RenderBosses(range);
                    RenderEnemies(range);
                }

                if ((viewType.SelectedIndex != 0 && MagoCrate.Properties.Settings.Default.decorSetting != 0) || viewType.SelectedIndex == 4) RenderDecoHex();

                // Render Select Cursor
                Vector2 v = new Vector2(tileX * 16f, -tileY * 16f);
                renderer.Draw(shapeTexIds[52], v, vec_scale, 17, 17);
            }
            glControl.SwapBuffers();
        }
        private void RenderCollisions(bool colored)
        {
            //Collisions
            for (int ty = tileStartY; ty < tileEndY; ty++)
            {
                for (int tx = tileStartX; tx < tileEndX; tx++)
                {
                    bool empty = true;
                    int ix = ty * (int)level.Width + tx;
                    Vector2 v = new Vector2(tx * 16f, -ty * 16f);
                    if (renderCollisionToolStripMenuItem.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        renderer.Draw(shapeTexIds[c.Shape], v, vec_scale, 17, 17);
                    } else renderer.Draw(shapeTexIds[0], v, vec_scale, 17, 17);


                    if (colored)
                    {
                        switch (viewType.SelectedIndex)
                        {
                            case 1:
                                Decoration bDeco = level.BLandDecoration[ix];
                                if (bDeco.DecoID != -1 || bDeco.Unk_3 != 0) empty = false;
                                if (!empty)
                                {
                                    byte[] halfs = BitConverter.GetBytes(bDeco.DecoID);
                                    Color bCol = DecorColorFromBytes(halfs[1], halfs[0], bDeco.Unk_3);
                                    renderer.DrawColor(bCol, hexTexIds[16], v, vec_scale, 17, 17);
                                }
                                break;
                            case 2:
                                Decoration fDeco = level.MLandDecoration[ix];
                                if (fDeco.DecoID != -1 || fDeco.Unk_3 != 0) empty = false;
                                if (!empty)
                                {
                                    byte[] halfs = BitConverter.GetBytes(fDeco.DecoID);
                                    Color fCol = DecorColorFromBytes(halfs[1], halfs[0], fDeco.Unk_3);
                                    renderer.DrawColor(fCol, hexTexIds[16], v, vec_scale, 17, 17);
                                }
                                break;
                            case 3:
                                Decoration mDeco = level.FLandDecoration[ix];
                                if (mDeco.DecoID != -1 || mDeco.Unk_3 != 0) empty = false;
                                if (!empty)
                                {
                                    byte[] halfs = BitConverter.GetBytes(mDeco.DecoID);
                                    Console.Write($"Rendered {tx} using bytes: {halfs[0]}, {halfs[1]}");
                                    Color mCol = DecorColorFromBytes(halfs[1], halfs[0], mDeco.Unk_3);
                                    renderer.DrawColor(mCol, hexTexIds[16], v, vec_scale, 17, 17);
                                }
                                break;
                        }
                    }
                }
            }
        }
        private void RenderBlocks()
        {
            for (int ty = tileStartY; ty < tileEndY; ty++)
            {
                for (int tx = tileStartX; tx < tileEndX; tx++)
                {
                    int ix = ty * (int)level.Width + tx;
                    Block b = level.TileBlock[ix];
                    Vector2 v = new Vector2(tx * 16f, -ty * 16f);

                    if (b.ID != -1)
                    {
                        short t = 0xFF;
                        Vector2 offset = Vector2.Zero;
                        Vector2 scale = new Vector2(17, 17);
                        if (blockTexIds.ContainsKey(b.ID)) t = b.ID;

                        if (b.ID == 2 || b.ID == 3 || b.ID == 7 || b.ID == 10 || b.ID == 11 || b.ID == 13 || b.ID == 15
                            || b.ID == 17 || b.ID == 23 || b.ID == 41 || b.ID == 42 || b.ID == 43 || b.ID == 44
                            || b.ID == 45 || b.ID == 46 || b.ID == 49 || b.ID == 50 || b.ID == 56 || b.ID == 59) // 2x2
                        {
                            offset = new Vector2(0, -16);
                            scale = new Vector2(33, 33);
                        }
                        else if (b.ID == 5 || b.ID == 24 || b.ID == 26 || b.ID == 27
                            || b.ID == 28 || b.ID == 31 || b.ID == 53 || b.ID == 58) // 3x3
                        {
                            offset = new Vector2(0, -32);
                            scale = new Vector2(49, 49);
                        }
                        else if (b.ID == 22 || b.ID == 29 || b.ID == 52 || b.ID == 57) // 4x4
                        {
                            offset = new Vector2(0, -48);
                            scale = new Vector2(65, 65);
                        }
                        else if (b.ID == 25) // Reverse T
                        {
                            scale = new Vector2(49, 33);
                        }

                        renderer.Draw(blockTexIds[t], v + offset, vec_scale, (int)scale.X, (int)scale.Y);
                    }
                }
            }
        }
        private void RenderModifiers()
        {
            for (int ty = tileStartY; ty < tileEndY; ty++)
            {
                for (int tx = tileStartX; tx < tileEndX; tx++)
                {
                    int ix = ty * (int)level.Width + tx;
                    Collision c = level.TileCollision[ix];
                    Vector2 v = new Vector2(tx * 16f, -ty * 16f);

                    if ((c.Modifier & (1 << 1)) != 0) //Ladder
                    {
                        renderer.Draw(modTexIds[0], v, vec_scale, 17, 17);
                    }
                    if ((c.Modifier & (1 << 2)) != 0) //Boundary
                    {
                        renderer.Draw(modTexIds[1], v, vec_scale, 17, 17);
                    }
                    if ((c.Modifier & (1 << 3)) != 0) //Water
                    {
                        renderer.Draw(modTexIds[2], v, vec_scale, 17, 17);
                    }
                    if ((c.Modifier & (1 << 4)) != 0) //Spike
                    {
                        renderer.Draw(modTexIds[3], v, vec_scale, 17, 17);
                    }
                    if ((c.Modifier & (1 << 5)) != 0) //Ice
                    {
                        renderer.Draw(modTexIds[4], v, vec_scale, 17, 17);
                    }
                    if ((c.Modifier & (1 << 6)) != 0) //Lava
                    {
                        renderer.Draw(modTexIds[5], v, vec_scale, 17, 17);
                    }
                }
            }
        }
        private void RenderMaterials()
        {
            for (int ty = tileStartY; ty < tileEndY; ty++)
            {
                for (int tx = tileStartX; tx < tileEndX; tx++)
                {
                    int ix = ty * (int)level.Width + tx;
                    Collision t = level.TileCollision[ix];
                    Vector2 v = new Vector2(tx * 16f, -ty * 16f);

                    if (t.Material > 7)
                    {
                        if (t.Material < 16) renderer.Draw(propertyTexIds[0], v, vec_scale, 17, 17);
                        else if (t.Material < 24) renderer.Draw(propertyTexIds[1], v, vec_scale, 17, 17);
                        else if (t.Material < 32) renderer.Draw(propertyTexIds[2], v, vec_scale, 17, 17);
                        else if (t.Material < 40) renderer.Draw(propertyTexIds[3], v, vec_scale, 17, 17);
                        else if (t.Material < 48) renderer.Draw(propertyTexIds[4], v, vec_scale, 17, 17);
                        else if (t.Material < 56) renderer.Draw(propertyTexIds[5], v, vec_scale, 17, 17);
                        else renderer.Draw(propertyTexIds[6], v, vec_scale, 17, 17);
                    }
                }
            }
        }
        private void RenderAutoMovement()
        {
            for (int ty = tileStartY; ty < tileEndY; ty++)
            {
                for (int tx = tileStartX; tx < tileEndX; tx++)
                {
                    int ix = ty * (int)level.Width + tx;
                    Collision t = level.TileCollision[ix];
                    Vector2 v = new Vector2(tx * 16f, -ty * 16f);

                    switch (t.AutoMoveSpeed)
                    {
                        case 1:
                            renderer.Draw(propertyTexIds[7], v, vec_scale, 17, 17);
                            break;
                        case 2:
                            renderer.Draw(propertyTexIds[8], v, vec_scale, 17, 17);
                            break;
                        case 3:
                            renderer.Draw(propertyTexIds[9], v, vec_scale, 17, 17);
                            break;
                        case -1:
                            renderer.Draw(propertyTexIds[10], v, vec_scale, 17, 17);
                            break;
                        case -2:
                            renderer.Draw(propertyTexIds[11], v, vec_scale, 17, 17);
                            break;
                        case -3:
                            renderer.Draw(propertyTexIds[12], v, vec_scale, 17, 17);
                            break;
                    }
                }
            }
        }
        private void RenderDecoHex()
        {
            for (int ty = tileStartY; ty < tileEndY; ty++)
            {
                for (int tx = tileStartX; tx < tileEndX; tx++)
                {
                    int ix = ty * (int)level.Width + tx;
                    Vector2 v = new Vector2(tx * 16f, -ty * 16f);
                    string hex = "";

                    if (viewType.SelectedIndex == 4)
                    {
                        // Render Dynamic Tile View and break early
                        Vector4 col = new Vector4(0, 0, 0, 1);
                        renderer.Draw(hexTexIds[16], v, vec_scale, 17, 17, col);
                        Decoration bDeco = level.BLandDecoration[ix];
                        Decoration mDeco = level.MLandDecoration[ix];
                        Decoration fDeco = level.FLandDecoration[ix];
                        if (mDeco.MovingTerrainID != -1)
                        {
                            hex = mDeco.MovingTerrainID.ToString("X2");
                        } 
                        else if (bDeco.MovingTerrainID != -1)
                        {
                            hex = bDeco.MovingTerrainID.ToString("X2");
                        }
                        else if (fDeco.MovingTerrainID != -1)
                        {
                            hex = fDeco.MovingTerrainID.ToString("X2");
                        }

                        if (!string.IsNullOrEmpty(hex))
                        {
                            renderer.Draw(hexTexIds[int.Parse(hex.Substring(0, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-5f, -4.25f), vec_scale * 0.8f, 6, 12);
                            renderer.Draw(hexTexIds[int.Parse(hex.Substring(1, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(1f, -4.25f), vec_scale * 0.8f, 6, 12);
                        }
                        
                    } else
                    {
                        switch (MagoCrate.Properties.Settings.Default.decorSetting)
                        {
                            case 1:
                                // 8 Hex Number View
                                Vector4 col = new Vector4(0, 0, 0, 1);
                                renderer.Draw(hexTexIds[16], v, vec_scale, 17, 17, col);
                                switch (viewType.SelectedIndex)
                                {
                                    case 1:
                                        Decoration bDeco = level.BLandDecoration[ix];
                                        hex = bDeco.DecoID.ToString("X4") + bDeco.Unk_3.ToString("X2") + bDeco.MovingTerrainID.ToString("X2");
                                        break;
                                    case 2:
                                        Decoration mDeco = level.MLandDecoration[ix];
                                        hex = mDeco.DecoID.ToString("X4") + mDeco.Unk_3.ToString("X2") + mDeco.MovingTerrainID.ToString("X2");
                                        break;
                                    case 3:
                                        Decoration fDeco = level.FLandDecoration[ix];
                                        hex = fDeco.DecoID.ToString("X4") + fDeco.Unk_3.ToString("X2") + fDeco.MovingTerrainID.ToString("X2");
                                        break;
                                }
                                if (hex != "FFFF00FF")
                                {
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(0, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-6.75f, -5.25f), vec_scale * 0.8f, 3, 6);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(1, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-3f, -5.25f), vec_scale * 0.8f, 3, 6);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(2, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(1.5f, -5.25f), vec_scale * 0.8f, 3, 6);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(3, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(5.25f, -5.25f), vec_scale * 0.8f, 3, 6);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(4, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-6.75f, 1.75f), vec_scale * 0.8f, 3, 6);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(5, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-3f, 1.75f), vec_scale * 0.8f, 3, 6);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(6, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(1.5f, 1.75f), vec_scale * 0.8f, 3, 6);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(7, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(5.25f, 1.75f), vec_scale * 0.8f, 3, 6);
                                }
                                break;

                            case 2:

                                // 4 Hex Number View
                                renderer.DrawColor(Color.Black, hexTexIds[16], v, vec_scale, 17, 17);
                                switch (viewType.SelectedIndex)
                                {
                                    case 1:
                                        Decoration bDeco = level.BLandDecoration[ix];
                                        hex = bDeco.DecoID.ToString("X4") + bDeco.Unk_3.ToString("X2") + bDeco.MovingTerrainID.ToString("X2");
                                        break;
                                    case 2:
                                        Decoration fDeco = level.MLandDecoration[ix];
                                        hex = fDeco.DecoID.ToString("X4") + fDeco.Unk_3.ToString("X2") + fDeco.MovingTerrainID.ToString("X2");
                                        break;
                                    case 3:
                                        Decoration mDeco = level.FLandDecoration[ix];
                                        hex = mDeco.DecoID.ToString("X4") + mDeco.Unk_3.ToString("X2") + mDeco.MovingTerrainID.ToString("X2");
                                        break;
                                }
                                if (hex != "FFFF00FF")
                                {
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(0, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-6.75f, -1.75f), vec_scale * 0.8f, 4, 8);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(1, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-3f, -1.75f), vec_scale * 0.8f, 4, 8);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(2, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(1.5f, -1.75f), vec_scale * 0.8f, 4, 8);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(3, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(5.25f, -1.75f), vec_scale * 0.8f, 4, 8);
                                }
                                break;

                            case 3:

                                // 2 Hex Number View
                                renderer.DrawColor(Color.Black, hexTexIds[16], v, vec_scale, 17, 17);
                                switch (viewType.SelectedIndex)
                                {
                                    case 1:
                                        Decoration bDeco = level.BLandDecoration[ix];
                                        hex = bDeco.DecoID.ToString("X4") + bDeco.Unk_3.ToString("X2") + bDeco.MovingTerrainID.ToString("X2");
                                        break;
                                    case 2:
                                        Decoration fDeco = level.MLandDecoration[ix];
                                        hex = fDeco.DecoID.ToString("X4") + fDeco.Unk_3.ToString("X2") + fDeco.MovingTerrainID.ToString("X2");
                                        break;
                                    case 3:
                                        Decoration mDeco = level.FLandDecoration[ix];
                                        hex = mDeco.DecoID.ToString("X4") + mDeco.Unk_3.ToString("X2") + mDeco.MovingTerrainID.ToString("X2");
                                        break;
                                }
                                if (hex != "FFFF00FF")
                                {
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(2, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-5f, -4.25f), vec_scale * 0.8f, 6, 12);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(3, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(1f, -4.25f), vec_scale * 0.8f, 6, 12);
                                }
                                break;
                        }
                    }
                }
            }
        }
        private bool inRenderRange(float X, float Y, float range)
        {
            bool withinRange = false;
            if (X > tileStartX - range && Y > tileStartY - range && X < tileEndX + range && Y < tileEndY + range) withinRange = true;
            return withinRange;
        }
        private void RenderZones()
        {
            for (int i = 0; i < level.Objects.Count; i++)
            {
                try
                {
                    uint objType = level.Objects[i].Type;
                    if (objType == 42 || objType == 44 || objType == 45)
                    {
                        // "Typical" Zone Objects
                        string prm6 = level.Objects[i].Param6.ToString("X8");
                        string prm7 = level.Objects[i].Param7.ToString("X8");

                        uint xPos = uint.Parse(prm6.Substring(0, 4), System.Globalization.NumberStyles.HexNumber);
                        uint yPos = uint.Parse(prm6.Substring(4, 4), System.Globalization.NumberStyles.HexNumber);
                        int xDist = int.Parse(prm7.Substring(0, 3), System.Globalization.NumberStyles.HexNumber);
                        int yDist = int.Parse(prm7.Substring(3, 3), System.Globalization.NumberStyles.HexNumber);

                        Vector2 tempV = new Vector2(xPos, (-yPos + 16));

                        int zoneType = 0;
                        if (objType == 44) zoneType = 1;
                        if (objType == 45) zoneType = 2;
                        renderer.Draw(zoneTexIds[zoneType], tempV, new Vector2(1f, 1f), xDist, yDist);
                    }
                    else if (objType == 90)
                    {
                        // Super Enemy Spawner Zone
                        string prm6 = level.Objects[i].Param6.ToString("X8");
                        string prm7 = level.Objects[i].Param7.ToString("X8");
                        string prm8 = level.Objects[i].Param8.ToString("X8");
                        string prm9 = level.Objects[i].Param9.ToString("X8");

                        uint xPos = uint.Parse(prm6, System.Globalization.NumberStyles.HexNumber);
                        uint yPos = uint.Parse(prm7, System.Globalization.NumberStyles.HexNumber);
                        int xDist = int.Parse(prm8, System.Globalization.NumberStyles.HexNumber);
                        int yDist = int.Parse(prm9, System.Globalization.NumberStyles.HexNumber);

                        Vector2 tempV = new Vector2(xPos, (-yPos + 16));
                        renderer.Draw(zoneTexIds[3], tempV, new Vector2(1f, 1f), xDist, yDist);
                    }
                }
                catch { }
            }
        }
        private void RenderObjects(float entRange)
        {
            // Objects
            for (int i = 0; i < level.Objects.Count; i++)
            {
                bool exceptionTexUsed;
                uint objType = level.Objects[i].Type;
                Vector2 nodePos = new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f));
                bool select = false;
                if (i == objList.SelectedIndex) select = true;

                string name = "Unknown (" + objType.ToString() + ")";
                if (objs.ObjectList.ContainsKey(objType))
                {
                    name = objs.ObjectList[objType];
                }

                if (inRenderRange(level.Objects[i].X, level.Objects[i].Y, entRange))
                {
                    if (useAvailableSpritesToolStripMenuItem.Checked)
                    {
                        try
                        {
                            RenderExceptionObjects(objType, i, name, select, out exceptionTexUsed);

                            if (!exceptionTexUsed)
                            {
                                Vector2 v = new Vector2((level.Objects[i].X * 16f) + (level.Objects[i].XOffset), (-level.Objects[i].Y * 16f) - (level.Objects[i].YOffset));
                                Vector2 o = Vector2.Zero;
                                int w = 0;
                                int h = 0;
                                string spritePath = "";
                                if (spriteParameters.Sections.ContainsSection("O." + name + "." + level.Objects[i].Param6))
                                    spritePath = "O." + name + "." + level.Objects[i].Param6;
                                if (spriteParameters.Sections.ContainsSection("O." + name))
                                {
                                    if (string.IsNullOrEmpty(spritePath)) spritePath = "O." + name;

                                    w = int.Parse(spriteParameters[spritePath]["W"]);
                                    h = int.Parse(spriteParameters[spritePath]["H"]);
                                    o = new Vector2(
                                        (0.5f + (float)-w / 2) + (float.Parse(spriteParameters[spritePath]["X"]) * 16),
                                        (17 + -h + -(float.Parse(spriteParameters[spritePath]["Y"]) * 16)));

                                    if (select) renderer.Draw(utilityTexIds[2], v + o, vec_scale, w, h);
                                    if (spriteTexIds.ContainsKey("O." + name + "." + level.Objects[i].Param6))
                                    {
                                        renderer.Draw(spriteTexIds["O." + name + "." + level.Objects[i].Param6], v + o, vec_scale, w, h);
                                    }
                                    else renderer.Draw(spriteTexIds["O." + name], v + o, vec_scale, w, h);
                                }
                                else RenderEntityNode(0, nodePos, select, name);
                            }
                        }
                        catch { RenderEntityNode(0, nodePos, select, name); }
                    }
                    else RenderEntityNode(0, nodePos, select, name);
                }
            }
        }
        private void RenderCarriables(float entRange)
        {
            // Carriables
            for (int i = 0; i < level.Carriables.Count; i++)
            {
                uint carryType = level.Carriables[i].Type;
                Vector2 nodePos = new Vector2(((level.Carriables[i].X * 16f) - 3f) + (level.Carriables[i].XOffset * 0.95f), ((-level.Carriables[i].Y * 16f) + 13f) - (level.Carriables[i].YOffset * 0.95f));
                bool select = false;
                if (i == carriablesList.SelectedIndex) select = true;

                string name = "Unknown (" + carryType.ToString() + ")";
                if (objs.CarriablesList.ContainsKey(carryType))
                {
                    name = objs.CarriablesList[carryType];
                }

                if (inRenderRange(level.Carriables[i].X, level.Carriables[i].Y, entRange))
                {
                    if (useAvailableSpritesToolStripMenuItem.Checked)
                    {
                        try
                        {
                            Vector2 v = new Vector2((level.Carriables[i].X * 16f) + (level.Carriables[i].XOffset), (-level.Carriables[i].Y * 16f) - (level.Carriables[i].YOffset));
                            Vector2 o = Vector2.Zero;
                            int w = 0;
                            int h = 0;
                            string spritePath = "";
                            if (spriteParameters.Sections.ContainsSection("C." + name + "." + level.Carriables[i].AppearID))
                                spritePath = "C." + name + "." + level.Carriables[i].AppearID;
                            if (spriteParameters.Sections.ContainsSection("C." + name))
                            {
                                if (string.IsNullOrEmpty(spritePath)) spritePath = "C." + name;

                                w = int.Parse(spriteParameters[spritePath]["W"]);
                                h = int.Parse(spriteParameters[spritePath]["H"]);
                                o = new Vector2(
                                    (0.5f + (float)-w / 2) + (float.Parse(spriteParameters[spritePath]["X"]) * 16),
                                    (17 + -h + -(float.Parse(spriteParameters[spritePath]["Y"]) * 16)));

                                if (select) renderer.Draw(utilityTexIds[2], v + o, vec_scale, w, h);
                                if (spriteTexIds.ContainsKey("C." + name + "." + level.Carriables[i].AppearID))
                                {
                                    renderer.Draw(spriteTexIds["C." + name + "." + level.Carriables[i].AppearID], v + o, vec_scale, w, h);
                                }
                                else renderer.Draw(spriteTexIds["C." + name], v + o, vec_scale, w, h);
                            }
                            else RenderEntityNode(1, nodePos, select, name);
                        }
                        catch { RenderEntityNode(1, nodePos, select, name); }
                    }
                    else RenderEntityNode(1, nodePos, select, name);
                }
            }
        }
        private void RenderItems(float entRange)
        {
            // Items
            for (int i = 0; i < level.Items.Count; i++)
            {
                uint itemType = level.Items[i].Type;
                Vector2 nodePos = new Vector2(((level.Items[i].X * 16f) - 3f) + (level.Items[i].XOffset * 0.95f), ((-level.Items[i].Y * 16f) + 13f) - (level.Items[i].YOffset * 0.95f));
                bool select = false;
                if (i == itemList.SelectedIndex) select = true;

                string name = "Unknown (" + itemType.ToString() + ")";
                if (objs.ItemList.ContainsKey(itemType))
                {
                    name = objs.ItemList[itemType];
                }

                if (inRenderRange(level.Items[i].X, level.Items[i].Y, entRange))
                {
                    if (useAvailableSpritesToolStripMenuItem.Checked)
                    {
                        try
                        {
                            Vector2 v = new Vector2((level.Items[i].X * 16f) + (level.Items[i].XOffset), (-level.Items[i].Y * 16f) - (level.Items[i].YOffset));
                            Vector2 o = Vector2.Zero;
                            int w = 0;
                            int h = 0;
                            string spritePath = "";
                            if (spriteParameters.Sections.ContainsSection("I." + name + "." + level.Items[i].Level))
                                spritePath = "I." + name + "." + level.Items[i].Level;
                            if (spriteParameters.Sections.ContainsSection("I." + name))
                            {
                                if (string.IsNullOrEmpty(spritePath)) spritePath = "I." + name;

                                w = int.Parse(spriteParameters[spritePath]["W"]);
                                h = int.Parse(spriteParameters[spritePath]["H"]);
                                o = new Vector2(
                                    (0.5f + (float)-w / 2) + (float.Parse(spriteParameters[spritePath]["X"]) * 16),
                                    (17 + -h + -(float.Parse(spriteParameters[spritePath]["Y"]) * 16)));

                                if (select) renderer.Draw(utilityTexIds[2], v + o, vec_scale, w, h);
                                if (spriteTexIds.ContainsKey("I." + name + "." + level.Items[i].Level))
                                {
                                    renderer.Draw(spriteTexIds["I." + name + "." + level.Items[i].Level], v + o, vec_scale, w, h);
                                }
                                else renderer.Draw(spriteTexIds["I." + name], v + o, vec_scale, w, h);
                            }
                            else RenderEntityNode(2, nodePos, select, name);
                        }
                        catch { RenderEntityNode(2, nodePos, select, name); }
                    }
                    else RenderEntityNode(2, nodePos, select, name);
                }
            }
        }
        private void RenderBosses(float entRange)
        {
            // Bosses
            for (int i = 0; i < level.Bosses.Count; i++)
            {
                uint bossType = level.Bosses[i].Type;
                Vector2 nodePos = new Vector2(((level.Bosses[i].X * 16f) - 3f) + (level.Bosses[i].XOffset * 0.95f), ((-level.Bosses[i].Y * 16f) + 13f) - (level.Bosses[i].YOffset * 0.95f));
                bool select = false;
                if (i == bossList.SelectedIndex) select = true;

                string name = "Unknown (" + bossType.ToString() + ")";
                if (objs.BossList.ContainsKey(bossType))
                {
                    name = objs.BossList[bossType];
                }

                if (inRenderRange(level.Bosses[i].X, level.Bosses[i].Y, entRange))
                {
                    if (useAvailableSpritesToolStripMenuItem.Checked)
                    {
                        try
                        {
                            Vector2 v = new Vector2((level.Bosses[i].X * 16f) + (level.Bosses[i].XOffset), (-level.Bosses[i].Y * 16f) - (level.Bosses[i].YOffset));
                            Vector2 o = Vector2.Zero;
                            int w = 0;
                            int h = 0;
                            string spritePath = "";
                            if (spriteParameters.Sections.ContainsSection("B." + name + "." + level.Bosses[i].Level))
                                spritePath = "B." + name + "." + level.Bosses[i].Level;
                            if (spriteParameters.Sections.ContainsSection("B." + name))
                            {
                                if (string.IsNullOrEmpty(spritePath)) spritePath = "B." + name;

                                w = int.Parse(spriteParameters[spritePath]["W"]);
                                h = int.Parse(spriteParameters[spritePath]["H"]);
                                o = new Vector2(
                                    (0.5f + (float)-w / 2) + (float.Parse(spriteParameters[spritePath]["X"]) * 16),
                                    (17 + -h + -(float.Parse(spriteParameters[spritePath]["Y"]) * 16)));

                                if (select) renderer.Draw(utilityTexIds[2], v + o, vec_scale, w, h);
                                if (level.Bosses[i].HasSuperAbility)
                                {
                                    // Draw Super Effect with its own offset
                                    Vector2 s = new Vector2(-34.5f, -34);
                                    renderer.Draw(utilityTexIds[3], v + s, vec_scale, 68, 68);
                                }

                                if (spriteTexIds.ContainsKey("B." + name + "." + level.Bosses[i].Level))
                                {
                                    renderer.Draw(spriteTexIds["B." + name + "." + level.Bosses[i].Level], v + o, vec_scale, w, h);
                                }
                                else renderer.Draw(spriteTexIds["B." + name], v + o, vec_scale, w, h);
                            }
                            else RenderEntityNode(3, nodePos, select, name);
                        }
                        catch { RenderEntityNode(3, nodePos, select, name); }
                    }
                    else RenderEntityNode(3, nodePos, select, name);
                }
            }
        }
        private void RenderEnemies(float entRange)
        {
            // Enemies
            for (int i = 0; i < level.Enemies.Count; i++)
            {
                uint enemyType = level.Enemies[i].Type;
                Vector2 nodePos = new Vector2(((level.Enemies[i].X * 16f) - 3f) + (level.Enemies[i].XOffset * 0.95f), ((-level.Enemies[i].Y * 16f) + 13f) - (level.Enemies[i].YOffset * 0.95f));
                bool select = false;
                if (i == enemyList.SelectedIndex) select = true;

                string name = "Unknown (" + enemyType.ToString() + ")";
                if (objs.EnemyList.ContainsKey(enemyType))
                {
                    name = objs.EnemyList[enemyType];
                }

                if (inRenderRange(level.Enemies[i].X, level.Enemies[i].Y, entRange))
                {
                    if (useAvailableSpritesToolStripMenuItem.Checked)
                    {
                        try
                        {
                            Vector2 v = new Vector2((level.Enemies[i].X * 16f) + (level.Enemies[i].XOffset), (-level.Enemies[i].Y * 16f) - (level.Enemies[i].YOffset));
                            Vector2 o = Vector2.Zero;
                            int w = 0;
                            int h = 0;
                            string spritePath = "";
                            if (spriteParameters.Sections.ContainsSection("E." + name + "." + level.Enemies[i].Behavior))
                                spritePath = "E." + name + "." + level.Enemies[i].Behavior;
                            if (spriteParameters.Sections.ContainsSection("E." + name))
                            {
                                if (string.IsNullOrEmpty(spritePath)) spritePath = "E." + name;

                                w = int.Parse(spriteParameters[spritePath]["W"]);
                                h = int.Parse(spriteParameters[spritePath]["H"]);
                                o = new Vector2(
                                    (0.5f + (float)-w / 2) + (float.Parse(spriteParameters[spritePath]["X"]) * 16),
                                    (17 + -h + -(float.Parse(spriteParameters[spritePath]["Y"]) * 16)));


                                if (select) renderer.Draw(utilityTexIds[2], v + o, vec_scale, w, h);
                                if (level.Enemies[i].HasSuperAbility)
                                {
                                    // Draw Super Effect with its own offset
                                    Vector2 s = new Vector2(-17.5f, -8);
                                    renderer.Draw(utilityTexIds[3], v + s, vec_scale, 34, 34);
                                }

                                if (spriteTexIds.ContainsKey("E." + name + "." + level.Enemies[i].Behavior))
                                {
                                    renderer.Draw(spriteTexIds["E." + name + "." + level.Enemies[i].Behavior], v + o, vec_scale, w, h);
                                }
                                else renderer.Draw(spriteTexIds["E." + name], v + o, vec_scale, w, h);
                            }
                            else RenderEntityNode(4, nodePos, select, name);
                        }
                        catch { RenderEntityNode(4, nodePos, select, name); }
                    }
                    else RenderEntityNode(4, nodePos, select, name);
                }
            }
        }
        private void RenderDynamicTerrain()
        {
            Color col = MagoCrate.Properties.Settings.Default.DynamicSectionColor;
            Vector3 col3 = new Vector3((float)(col.R) / 255, (float)(col.G) / 255, (float)(col.B) / 255);
            Vector4 col4 = new Vector4(col3.X, col3.Y, col3.Z, 0.75f);
            for (int i = 0; i < level.DynamicTerrain.Count; i++)
            {
                if (level.DynamicTerrain[i] != null)
                {
                    Vector2 nodePos = new Vector2((level.DynamicTerrain[i].X * 16f) - 3f, (-level.DynamicTerrain[i].Y * 16f) + 13f);
                    bool select = false;
                    if (i == dynamicList.SelectedIndex) select = true;

                    for (int t = 0; t < level.DynamicTerrain[i].tiles.Count; t++)
                    {
                        MoveTile curTile = level.DynamicTerrain[i].tiles[t];
                        Vector2 v = new Vector2((level.DynamicTerrain[i].X + (float)curTile.X) * 16f, -(level.DynamicTerrain[i].Y + (float)curTile.Y) * 16f);
                        renderer.Draw(shapeTexIds[curTile.Shape], v, vec_scale, 17, 17, col4);

                        if (curTile.Material > 7)
                        {
                            if (curTile.Material < 16) renderer.Draw(propertyTexIds[0], v, vec_scale, 17, 17);
                            else if (curTile.Material < 24) renderer.Draw(propertyTexIds[1], v, vec_scale, 17, 17);
                            else if (curTile.Material < 32) renderer.Draw(propertyTexIds[2], v, vec_scale, 17, 17);
                            else if (curTile.Material < 40) renderer.Draw(propertyTexIds[3], v, vec_scale, 17, 17);
                            else if (curTile.Material < 48) renderer.Draw(propertyTexIds[4], v, vec_scale, 17, 17);
                            else if (curTile.Material < 56) renderer.Draw(propertyTexIds[5], v, vec_scale, 17, 17);
                            else renderer.Draw(propertyTexIds[6], v, vec_scale, 17, 17);
                        }

                        if ((curTile.Material % 8) == 4) renderer.Draw(modTexIds[3], v, vec_scale, 17, 17);
                        else if ((curTile.Material % 8) == 5) renderer.Draw(modTexIds[4], v, vec_scale, 17, 17);
                        else if ((curTile.Material % 8) == 6) renderer.Draw(modTexIds[5], v, vec_scale, 17, 17);
                    }
                    RenderEntityNode(5, nodePos, select, "");
                }
            }
        }
        private void RenderEntityNode(int type, Vector2 position, bool selected, string name)
        {
            Color col = Color.White;
            switch (type)
            {
                case 0:
                    col = BrightColor(MagoCrate.Properties.Settings.Default.ObjColor);
                    break;
                case 1:
                    col = BrightColor(MagoCrate.Properties.Settings.Default.CarryColor);
                    break;
                case 2:
                    col = BrightColor(MagoCrate.Properties.Settings.Default.ItemColor);
                    break;
                case 3:
                    col = BrightColor(MagoCrate.Properties.Settings.Default.BossColor);
                    break;
                case 4:
                    col = BrightColor(MagoCrate.Properties.Settings.Default.EnemyColor);
                    break;
                case 5:
                    col = BrightColor(MagoCrate.Properties.Settings.Default.DynamicSectionColor);
                    break;
            }
            renderer.DrawColor(col, utilityTexIds[0], position, vec_scale, 7, 7);
            if (selected) renderer.Draw(utilityTexIds[1], position, vec_scale, 7, 7);

            if (renderEntityNamesToolStripMenuItem.Checked && !String.IsNullOrEmpty(name))
            {
                Vector4 adjustCol = new Vector4((float)col.R / 255, (float)col.G / 255, (float)col.B / 255, 1);
                RenderNames(name, position + new Vector2(0, -2), adjustCol);
            }
        }
        private void RenderNames(string text, Vector2 position, Vector4 color)
        {
            renderer.DrawString(text, font, position, new Vector2(0.5f / (float)camera.zoom, 0.5f / (float)camera.zoom), color);
        }
        private void RenderExceptionObjects(uint type, int i, string name, bool select, out bool exception)
        {
            exception = false;
            Vector2 v = new Vector2((level.Objects[i].X * 16f) + (level.Objects[i].XOffset), (-level.Objects[i].Y * 16f) - (level.Objects[i].YOffset));

            if (type == 10)
            {
                // Rope Platform
                exception = true;
                string prm7 = level.Objects[i].Param7.ToString("X8");
                string solidType = "";
                string lengthType = "";
                if (prm7.Substring(7, 1) == "1") solidType = " Semisolid";
                if (prm7.Substring(1, 1) == "1") lengthType = " Long";

                int w = int.Parse(spriteParameters["X." + name + solidType + lengthType]["W"]);
                int h = int.Parse(spriteParameters["X." + name + solidType + lengthType]["H"]);
                Vector2 o = new Vector2(
                    (0.5f + (float)-w / 2) + (float.Parse(spriteParameters["X." + name + solidType + lengthType]["X"]) * 16),
                    (17 + -h + -(float.Parse(spriteParameters["X." + name + solidType + lengthType]["Y"]) * 16)));

                if (select) renderer.Draw(utilityTexIds[2], v + o, vec_scale, w, h);
                renderer.Draw(spriteTexIds["X." + name + solidType + lengthType], v + o, vec_scale, w, h);
            }
            else if (type == 19)
            {
                exception = true;
                string prm6 = level.Objects[i].Param6.ToString("X8");
                string prm7 = level.Objects[i].Param7.ToString("X8");
                string cannonType = "";
                uint rot = uint.Parse(prm6.Substring(3, 1));
                if (prm7.Substring(3, 1) == "1") cannonType = " Manual";

                if (rot > 7) rot = 0;
                string rotType = "";
                if (rot != 0) rotType = "." + rot.ToString();

                int w = int.Parse(spriteParameters["X." + name]["W"]);
                int h = int.Parse(spriteParameters["X." + name]["H"]);
                Vector2 o = new Vector2(
                    (0.5f + (float)-w / 2) + (float.Parse(spriteParameters["X." + name]["X"]) * 16),
                    (17 + -h + -(float.Parse(spriteParameters["X." + name]["Y"]) * 16)));

                if (select) renderer.Draw(utilityTexIds[2], v + o, vec_scale, w, h);
                renderer.Draw(spriteTexIds["X." + name + cannonType + rotType], v + o, vec_scale, w, h);
            }
            else if (type == 30)
            {
                exception = true;
                string prm6 = level.Objects[i].Param6.ToString("X8");
                string directionType = "";
                string sizeType = "";

                if (prm6.Substring(3, 1) == "1") directionType = " Right";
                else if (prm6.Substring(3, 1) == "2") directionType = " Left";
                if (prm6.Substring(5, 1) == "1") sizeType = " Super";

                int w = int.Parse(spriteParameters["X." + name + sizeType + directionType]["W"]);
                int h = int.Parse(spriteParameters["X." + name + sizeType + directionType]["H"]);
                Vector2 o = new Vector2(
                    (0.5f + (float)-w / 2) + (float.Parse(spriteParameters["X." + name + sizeType + directionType]["X"]) * 16),
                    (17 + -h + -(float.Parse(spriteParameters["X." + name + sizeType + directionType]["Y"]) * 16)));

                if (select) renderer.Draw(utilityTexIds[2], v + o, vec_scale, w, h);
                renderer.Draw(spriteTexIds["X." + name + sizeType + directionType], v + o, vec_scale, w, h);
            }
        }
        private void glControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (level != null)
            {
                Vector2 p = ConvertMouseCoords(new Vector2(e.X, e.Y));
                if (p.X > level.Width - 1)
                {
                    tileX = level.Width - 1;
                }
                else if (p.X > 0)
                {
                    tileX = (uint)p.X;
                }
                else { tileX = 0; }
                if (p.Y < -(level.Height - 1))
                {
                    tileY = level.Height - 1;
                }
                else if (p.Y < 0)
                {
                    tileY = (uint)-p.Y + 1;
                }
                else { tileY = 0; }
                int ix = (int)((tileY * level.Width) + tileX);

                if (e.Button == MouseButtons.Right)
                {
                    if (MagoCrate.Properties.Settings.Default.quickPickON)
                    {
                        if (tool == 0) Pick(ix);
                    }
                    else
                    {
                        moveCam = true;
                        mouseX = e.X;
                        mouseY = e.Y;
                    }
                }
                else if (e.Button == MouseButtons.Left)
                {
                    if (tool == 0) Pencil(ix);
                    else if (tool == 1) Pick(ix);
                    else if (tool == 2) Grab();
                } else if (e.Button == MouseButtons.Middle)
                {
                    moveCam = true;
                    mouseX = e.X;
                    mouseY = e.Y;
                }
            }
        }
        private void glControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (level != null)
            {
                Vector2 p = ConvertMouseCoords(new Vector2(e.X, e.Y));
                if (p.X > level.Width - 1)
                {
                    tileX = level.Width - 1;
                }
                else if (p.X > 0)
                {
                    tileX = (uint)p.X;
                }
                else { tileX = 0; }
                if (p.Y < -(level.Height - 1))
                {
                    tileY = level.Height - 1;
                }
                else if (p.Y < 0)
                {
                    tileY = (uint)-p.Y + 1;
                }
                else { tileY = 0; }
                int ix = (int)((tileY * level.Width) + tileX);

                if (e.Button == MouseButtons.Right)
                {
                    if (!MagoCrate.Properties.Settings.Default.quickPickON)
                    {
                        float moveSpeed = 1.0f / (float)camera.zoom;
                        camera.pos.X += (mouseX - e.X) * moveSpeed;
                        camera.pos.Y += (mouseY - e.Y) * moveSpeed;
                        mouseX = e.X;
                        mouseY = e.Y;
                    }
                }
                else if (e.Button == MouseButtons.Left)
                {
                    if (tool == 0)
                    {
                        Pencil(ix);
                    }
                    else if (tool == 2)
                    {
                        // Move
                        try
                        {
                            xCoord.Value = tileX;
                            yCoord.Value = tileY;
                            UpdateCoords();
                        }
                        catch { }
                    }
                }
                else if (e.Button == MouseButtons.Middle)
                {
                    float moveSpeed = 1.0f / (float)camera.zoom;
                    camera.pos.X += (mouseX - e.X) * moveSpeed;
                    camera.pos.Y += (mouseY - e.Y) * moveSpeed;
                    mouseX = e.X;
                    mouseY = e.Y;
                }
            }
        }
        private void glControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                moveCam = false;
                mouseX = 0;
                mouseY = 0;
            } else if (e.Button == MouseButtons.Right && !MagoCrate.Properties.Settings.Default.quickPickON)
            {
                moveCam = false;
                mouseX = 0;
                mouseY = 0;
            }
        }

        private void glControl_MouseLeave(object sender, EventArgs e)
        {
            moveCam = false;
            mouseX = 0;
            mouseY = 0;
        }
        private void Pencil(int ix)
        {
            // Draw
            if (!a)
            {
                Collision c = level.TileCollision[ix];
                Block b = level.TileBlock[ix];
                Decoration bl = level.BLandDecoration[ix];
                Decoration fl = level.FLandDecoration[ix];
                Decoration ml = level.MLandDecoration[ix];

                switch (viewType.SelectedIndex)
                {
                    case 0:
                        // Collision View

                        if (editCollisionShapeToolStripMenuItem.Checked) c.Shape = (byte)vShape.Value;
                        if (editModifiersToolStripMenuItem.Checked)
                        {
                            c.Modifier = 0;
                            if (ladder.Checked) c.Modifier += 2;
                            if (boundary.Checked) c.Modifier += 4;
                            if (water.Checked) c.Modifier += 8;
                            if (spike.Checked) c.Modifier += 16;
                            if (ice.Checked) c.Modifier += 32;
                            if (lava.Checked) c.Modifier += 64;
                        }
                        if (editMaterialsToolStripMenuItem.Checked) c.Material = (byte)vMat.Value;
                        if (editAutoMovementToolStripMenuItem.Checked) c.AutoMoveSpeed = (sbyte)vAutomove.Value;
                        level.TileCollision[ix] = c;
                        if (editBlocksToolStripMenuItem.Checked)
                        {
                            b.ID = (short)vBlock.Value;
                            level.TileBlock[ix] = b;
                        }
                        if (editBLandToolStripMenuItem.Checked)
                        {
                            bl.DecoID = (short)dB_ID.Value;
                            bl.Unk_3 = (byte)dB_Unk.Value;
                            bl.MovingTerrainID = (sbyte)dB_Dynamic.Value;
                            level.BLandDecoration[ix] = bl;
                        }
                        if (editFLandToolStripMenuItem.Checked)
                        {
                            fl.DecoID = (short)dF_ID.Value;
                            fl.Unk_3 = (byte)dF_Unk.Value;
                            fl.MovingTerrainID = (sbyte)dF_Dynamic.Value;
                            level.FLandDecoration[ix] = fl;
                        }
                        if (editMLandToolStripMenuItem.Checked)
                        {
                            ml.DecoID = (short)dM_ID.Value;
                            ml.Unk_3 = (byte)dM_Unk.Value;
                            ml.MovingTerrainID = (sbyte)dM_Dynamic.Value;
                            level.MLandDecoration[ix] = ml;
                        }
                        return;
                    case 1:
                        // BLand View

                        if (editBLandToolStripMenuItem.Checked)
                        {
                            bl.DecoID = (short)dB_ID.Value;
                            bl.Unk_3 = (byte)dB_Unk.Value;
                            bl.MovingTerrainID = (sbyte)dB_Dynamic.Value;
                            level.BLandDecoration[ix] = bl;
                        }
                        return;
                    case 2:
                        // MLand View

                        if (editCollisionShapeToolStripMenuItem.Checked) c.Shape = (byte)vShape.Value;
                        if (editModifiersToolStripMenuItem.Checked)
                        {
                            c.Modifier = 0;
                            if (ladder.Checked) c.Modifier += 2;
                            if (boundary.Checked) c.Modifier += 4;
                            if (water.Checked) c.Modifier += 8;
                            if (spike.Checked) c.Modifier += 16;
                            if (ice.Checked) c.Modifier += 32;
                            if (lava.Checked) c.Modifier += 64;
                        }
                        if (editMaterialsToolStripMenuItem.Checked) c.Material = (byte)vMat.Value;
                        if (editAutoMovementToolStripMenuItem.Checked) c.AutoMoveSpeed = (sbyte)vAutomove.Value;
                        level.TileCollision[ix] = c;
                        if (editBlocksToolStripMenuItem.Checked)
                        {
                            b.ID = (short)vBlock.Value;
                            level.TileBlock[ix] = b;
                        }
                        if (editMLandToolStripMenuItem.Checked)
                        {
                            ml.DecoID = (short)dM_ID.Value;
                            ml.Unk_3 = (byte)dM_Unk.Value;
                            ml.MovingTerrainID = (sbyte)dM_Dynamic.Value;
                            level.MLandDecoration[ix] = ml;
                        }
                        return;
                    case 3:
                        // FLand View

                        if (editFLandToolStripMenuItem.Checked)
                        {
                            fl.DecoID = (short)dF_ID.Value;
                            fl.Unk_3 = (byte)dF_Unk.Value;
                            fl.MovingTerrainID = (sbyte)dF_Dynamic.Value;
                            level.FLandDecoration[ix] = fl;
                        }
                        return;
                    case 4:
                        // Dynamic Tile ID View

                        if (editBLandToolStripMenuItem.Checked)
                        {
                            bl.MovingTerrainID = (sbyte)dB_Dynamic.Value;
                            level.BLandDecoration[ix] = bl;
                        }
                        if (editFLandToolStripMenuItem.Checked)
                        {
                            fl.MovingTerrainID = (sbyte)dF_Dynamic.Value;
                            level.FLandDecoration[ix] = fl;
                        }
                        if (editMLandToolStripMenuItem.Checked)
                        {
                            ml.MovingTerrainID = (sbyte)dM_Dynamic.Value;
                            level.MLandDecoration[ix] = ml;
                        }
                        return;
                }
            }
        }
        private void Pick(int ix)
        {
            // Pick
            Collision c = level.TileCollision[ix];
            Block b = level.TileBlock[ix];
            Decoration fl = level.FLandDecoration[ix];
            Decoration bl = level.BLandDecoration[ix];
            Decoration ml = level.MLandDecoration[ix];

            ladder.Checked = false;
            boundary.Checked = false;
            water.Checked = false;
            spike.Checked = false;
            ice.Checked = false;
            lava.Checked = false;

            vShape.Value = c.Shape;
            if ((c.Modifier & (1 << 1)) != 0) ladder.Checked = true;
            if ((c.Modifier & (1 << 2)) != 0) boundary.Checked = true;
            if ((c.Modifier & (1 << 3)) != 0) water.Checked = true;
            if ((c.Modifier & (1 << 4)) != 0) spike.Checked = true;
            if ((c.Modifier & (1 << 5)) != 0) ice.Checked = true;
            if ((c.Modifier & (1 << 6)) != 0) lava.Checked = true;

            vMat.Value = c.Material;
            vAutomove.Value = c.AutoMoveSpeed;
            vBlock.Value = b.ID;

            if (bl.DecoID != -1 || bl.Unk_3 != 0 || bl.MovingTerrainID != -1 || ModifierKeys != Keys.Shift)
            {
                dB_ID.Value = bl.DecoID;
                dB_Unk.Value = bl.Unk_3;
                dB_Dynamic.Value = bl.MovingTerrainID;
                dB_hex.Text = ((short)dB_ID.Value).ToString("X4") + ((byte)dB_Unk.Value).ToString("X2") + ((sbyte)dB_Dynamic.Value).ToString("X2");
            }
            
            if (fl.DecoID != -1 || fl.Unk_3 != 0 || fl.MovingTerrainID != -1 || ModifierKeys != Keys.Shift)
            {
                dF_ID.Value = fl.DecoID;
                dF_Unk.Value = fl.Unk_3;
                dF_Dynamic.Value = fl.MovingTerrainID;
                dF_hex.Text = ((short)dF_ID.Value).ToString("X4") + ((byte)dF_Unk.Value).ToString("X2") + ((sbyte)dF_Dynamic.Value).ToString("X2");
            }

            if (ml.DecoID != -1 || ml.Unk_3 != 0 || ml.MovingTerrainID != -1 || ModifierKeys != Keys.Shift)
            {
                dM_ID.Value = ml.DecoID;
                dM_Unk.Value = ml.Unk_3;
                dM_Dynamic.Value = ml.MovingTerrainID;
                dM_hex.Text = ((short)dM_ID.Value).ToString("X4") + ((byte)dM_Unk.Value).ToString("X2") + ((sbyte)dM_Dynamic.Value).ToString("X2");
            }
        }
        private void Grab()
        {
            // Move
            clickedEntity = false;
            if (ModifierKeys != Keys.Shift)
            {
                if (!clickedEntity)
                {
                    for (int i = 0; i < level.Objects.Count; i++)
                    {
                        if (level.Objects[i].X == tileX && level.Objects[i].Y == tileY && objList.SelectedIndex != i)
                        {
                            clickedEntity = true;
                            tabControl1.SelectedIndex = 0;
                            objList.SelectedIndex = i;
                            break;
                        }
                    }
                }
                if (!clickedEntity)
                {
                    for (int i = 0; i < level.Carriables.Count; i++)
                    {
                        if (level.Carriables[i].X == tileX && level.Carriables[i].Y == tileY && carriablesList.SelectedIndex != i)
                        {
                            clickedEntity = true;
                            tabControl1.SelectedIndex = 1;
                            carriablesList.SelectedIndex = i;
                            break;
                        }
                    }
                }
                if (!clickedEntity)
                {
                    for (int i = 0; i < level.Items.Count; i++)
                    {
                        if (level.Items[i].X == tileX && level.Items[i].Y == tileY && itemList.SelectedIndex != i)
                        {
                            clickedEntity = true;
                            tabControl1.SelectedIndex = 2;
                            itemList.SelectedIndex = i;
                            break;
                        }
                    }
                }
                if (!clickedEntity)
                {
                    for (int i = 0; i < level.Bosses.Count; i++)
                    {
                        if (level.Bosses[i].X == tileX && level.Bosses[i].Y == tileY && bossList.SelectedIndex != i)
                        {
                            clickedEntity = true;
                            tabControl1.SelectedIndex = 3;
                            bossList.SelectedIndex = i;
                            break;
                        }
                    }
                }
                if (!clickedEntity)
                {
                    for (int i = 0; i < level.Enemies.Count; i++)
                    {
                        if (level.Enemies[i].X == tileX && level.Enemies[i].Y == tileY && enemyList.SelectedIndex != i)
                        {
                            clickedEntity = true;
                            tabControl1.SelectedIndex = 4;
                            enemyList.SelectedIndex = i;
                            break;
                        }
                    }
                }
                if (!clickedEntity)
                {
                    for (int i = 0; i < level.DynamicTerrain.Count; i++)
                    {
                        if (level.DynamicTerrain[i] != null)
                        {
                            if (level.DynamicTerrain[i].X == tileX && level.DynamicTerrain[i].Y == tileY && dynamicList.SelectedIndex != i)
                            {
                                clickedEntity = true;
                                tabControl1.SelectedIndex = 5;
                                dynamicList.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }
            }
            if (!clickedEntity)
            {
                xCoord.Value = tileX;
                yCoord.Value = tileY;
                UpdateCoords();
            }
        }

        private void glControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                camera.zoom += 0.1 * camera.zoom;
                if (camera.zoom > 4)
                {
                    camera.zoom = 4;
                }
            }
            else if (e.Delta < 0)
            {
                camera.zoom -= 0.1 * camera.zoom;
                if (camera.zoom < 0.25)
                {
                    camera.zoom = 0.25;
                }
            }
        }
        private void draw_Click(object sender, EventArgs e)
        {
            SwitchTool(0);
        }
        private void dropper_Click(object sender, EventArgs e)
        {
            SwitchTool(1);
        }
        private void move_Click(object sender, EventArgs e)
        {
            SwitchTool(2);
        }
        public void SwitchTool(int ID)
        {
            if (ID == 1 && MagoCrate.Properties.Settings.Default.quickPickON) ID = 0;

            tool = ID;
            draw.BackColor = Color.White;
            dropper.BackColor = Color.White;
            move.BackColor = Color.White;
            draw.Enabled = true;
            dropper.Enabled = true;
            move.Enabled = true;

            switch (tool)
            {
                case 0:
                    draw.Enabled = false;
                    draw.BackColor = Color.LightSteelBlue;
                    if (MagoCrate.Properties.Settings.Default.quickPickON)
                    {
                        dropper.Enabled = false;
                        dropper.BackColor = Color.LightSteelBlue;
                    }
                    return;
                case 1:
                    dropper.Enabled = false;
                    dropper.BackColor = Color.LightSteelBlue;
                    return;
                case 2:
                    move.Enabled = false;
                    move.BackColor = Color.LightSteelBlue;
                    return;
            }
        }

        private void resetCamera_Click(object sender, EventArgs e)
        {
            try
            {
                // Move Camera into Level Bounds
                camera.zoom = 1.1;
                camera.pos.X = Math.Max(0, Math.Min(level.Width * 15, camera.pos.X));
                camera.pos.Y = Math.Max(-level.Height * 15, Math.Min(0, camera.pos.Y));
            } catch { }
        }
        private void UpdateLevelSize(object sender, EventArgs e)
        {
            if (!a)
            {
                Collision c = new Collision();
                Block b = new Block();
                Decoration d = new Decoration();
                b.ID = -1;
                d.DecoID = -1;
                d.Unk_3 = 0;
                d.MovingTerrainID = -1;

                int widthDifference = (int)sizeW.Value - (int)level.Width;
                int heightDifference = (int)sizeH.Value - (int)level.Height;

                if (widthDifference > 0)
                {
                    for (int i = 0; i < widthDifference; i++)
                    {
                        for (int h = 0; h < sizeH.Value; h++)
                        {
                            level.TileCollision.Insert(((h * (int)level.Width) + (int)level.Width) + h, c);
                            level.TileBlock.Insert(((h * (int)level.Width) + (int)level.Width) + h, b);
                            level.BLandDecoration.Insert(((h * (int)level.Width) + (int)level.Width) + h, d);
                            level.FLandDecoration.Insert(((h * (int)level.Width) + (int)level.Width) + h, d);
                            level.MLandDecoration.Insert(((h * (int)level.Width) + (int)level.Width) + h, d);
                        }
                        level.Width++;
                    }
                }
                else if (widthDifference < 0)
                {
                    for (int i = 0; i < -widthDifference; i++)
                    {
                        for (int h = 0; h < sizeH.Value; h++)
                        {
                            level.TileCollision.RemoveAt(((h * (int)level.Width) + (int)level.Width) - (h + 1));
                            level.TileBlock.RemoveAt(((h * (int)level.Width) + (int)level.Width) - (h + 1));
                            level.BLandDecoration.RemoveAt(((h * (int)level.Width) + (int)level.Width) - (h + 1));
                            level.FLandDecoration.RemoveAt(((h * (int)level.Width) + (int)level.Width) - (h + 1));
                            level.MLandDecoration.RemoveAt(((h * (int)level.Width) + (int)level.Width) - (h + 1));
                        }
                        level.Width--;
                    }
                }
                else if (heightDifference > 0)
                {
                    for (int i = 0; i < heightDifference; i++)
                    {
                        for (int w = 0; w < level.Width; w++)
                        {
                            level.TileCollision.Add(c);
                            level.TileBlock.Add(b);
                            level.BLandDecoration.Add(d);
                            level.FLandDecoration.Add(d);
                            level.MLandDecoration.Add(d);
                        }
                        level.Height++;
                    }
                }
                else if (heightDifference < 0)
                {
                    for (int i = 0; i < -heightDifference; i++)
                    {
                        level.TileCollision.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                        level.TileBlock.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                        level.BLandDecoration.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                        level.FLandDecoration.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                        level.MLandDecoration.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                        level.Height--;
                    }
                }
            }
        }

        private Vector2 ConvertMouseCoords(Vector2 i)
        {
            i -= new Vector2(glControl.Width, glControl.Height) / 2f;
            i /= (float)camera.zoom;
            return (camera.pos + i)/16f;
        }

        bool a;

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                try
                {
                    moveObj = 0;
                    xCoord.Value = level.Objects[objList.SelectedIndex].X;
                    xOffset.Value = level.Objects[objList.SelectedIndex].XOffset;
                    yCoord.Value = level.Objects[objList.SelectedIndex].Y;
                    yOffset.Value = level.Objects[objList.SelectedIndex].YOffset;

                    if (!clickedEntity)
                    {
                        Vector2 newCamPos = new Vector2((16 * (float)xCoord.Value) + (float)xOffset.Value, (16 * -(float)yCoord.Value) - (float)yOffset.Value);
                        camera.pos = newCamPos;
                    }
                } catch { }
                carriablesList.ClearSelected();
                itemList.ClearSelected();
                bossList.ClearSelected();
                enemyList.ClearSelected();
                dynamicList.ClearSelected();
                a = false;
            }
        }

        private void specItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                try
                {
                    moveObj = 1;
                    xCoord.Value = level.Carriables[carriablesList.SelectedIndex].X;
                    xOffset.Value = level.Carriables[carriablesList.SelectedIndex].XOffset;
                    yCoord.Value = level.Carriables[carriablesList.SelectedIndex].Y;
                    yOffset.Value = level.Carriables[carriablesList.SelectedIndex].YOffset;

                    if (!clickedEntity)
                    {
                        Vector2 newCamPos = new Vector2((16 * (float)xCoord.Value) + (float)xOffset.Value, (16 * -(float)yCoord.Value) - (float)yOffset.Value);
                        camera.pos = newCamPos;
                    }
                } catch { }
                objList.ClearSelected();
                itemList.ClearSelected();
                bossList.ClearSelected();
                enemyList.ClearSelected();
                dynamicList.ClearSelected();
                a = false;
            }
        }

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                try
                {
                    moveObj = 2;
                    xCoord.Value = level.Items[itemList.SelectedIndex].X;
                    xOffset.Value = level.Items[itemList.SelectedIndex].XOffset;
                    yCoord.Value = level.Items[itemList.SelectedIndex].Y;
                    yOffset.Value = level.Items[itemList.SelectedIndex].YOffset;

                    if (!clickedEntity)
                    {
                        Vector2 newCamPos = new Vector2((16 * (float)xCoord.Value) + (float)xOffset.Value, (16 * -(float)yCoord.Value) - (float)yOffset.Value);
                        camera.pos = newCamPos;
                    }
                } catch { }
                objList.ClearSelected();
                carriablesList.ClearSelected();
                bossList.ClearSelected();
                enemyList.ClearSelected();
                dynamicList.ClearSelected();
                a = false;
            }
        }

        private void bossList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                try
                {
                    moveObj = 3;
                    xCoord.Value = level.Bosses[bossList.SelectedIndex].X;
                    xOffset.Value = level.Bosses[bossList.SelectedIndex].XOffset;
                    yCoord.Value = level.Bosses[bossList.SelectedIndex].Y;
                    yOffset.Value = level.Bosses[bossList.SelectedIndex].YOffset;

                    if (!clickedEntity)
                    {
                        Vector2 newCamPos = new Vector2((16 * (float)xCoord.Value) + (float)xOffset.Value, (16 * -(float)yCoord.Value) - (float)yOffset.Value);
                        camera.pos = newCamPos;
                    }
                } catch { }
                objList.ClearSelected();
                carriablesList.ClearSelected();
                itemList.ClearSelected();
                enemyList.ClearSelected();
                dynamicList.ClearSelected();
                a = false;
            }
        }

        private void enemyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                try
                {
                    moveObj = 4;
                    xCoord.Value = level.Enemies[enemyList.SelectedIndex].X;
                    xOffset.Value = level.Enemies[enemyList.SelectedIndex].XOffset;
                    yCoord.Value = level.Enemies[enemyList.SelectedIndex].Y;
                    yOffset.Value = level.Enemies[enemyList.SelectedIndex].YOffset;

                    if (!clickedEntity)
                    {
                        Vector2 newCamPos = new Vector2((16 * (float)xCoord.Value) + (float)xOffset.Value, (16 * -(float)yCoord.Value) - (float)yOffset.Value);
                        camera.pos = newCamPos;
                    }
                } catch { }
                objList.ClearSelected();
                carriablesList.ClearSelected();
                itemList.ClearSelected();
                bossList.ClearSelected();
                dynamicList.ClearSelected();
                a = false;
            }
        }
        private void dynamicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                if (level.DynamicTerrain[dynamicList.SelectedIndex] != null)
                {
                    a = true;
                    try
                    {
                        moveObj = 5;
                        xCoord.Value = level.DynamicTerrain[dynamicList.SelectedIndex].X;
                        yCoord.Value = level.DynamicTerrain[dynamicList.SelectedIndex].Y;

                        if (!clickedEntity)
                        {
                            Vector2 newCamPos = new Vector2((16 * (float)xCoord.Value) + (float)xOffset.Value, (16 * -(float)yCoord.Value) - (float)yOffset.Value);
                            camera.pos = newCamPos;
                        }
                    }
                    catch { }
                    objList.ClearSelected();
                    carriablesList.ClearSelected();
                    itemList.ClearSelected();
                    bossList.ClearSelected();
                    enemyList.ClearSelected();
                    a = false;
                }
            }
        }

        void UpdateCoords()
        {
            try
            {
                switch (moveObj)
                {
                    case 0:
                        {
                            RDLLVL.Object obj = level.Objects[objList.SelectedIndex];
                            obj.X = (uint)xCoord.Value;
                            obj.XOffset = (uint)xOffset.Value;
                            obj.Y = (uint)yCoord.Value;
                            obj.YOffset = (uint)yOffset.Value;
                            level.Objects[objList.SelectedIndex] = obj;
                            break;
                        }
                    case 1:
                        {
                            SpecialItem obj = level.Carriables[carriablesList.SelectedIndex];
                            obj.X = (uint)xCoord.Value;
                            obj.XOffset = (uint)xOffset.Value;
                            obj.Y = (uint)yCoord.Value;
                            obj.YOffset = (uint)yOffset.Value;
                            level.Carriables[carriablesList.SelectedIndex] = obj;
                            break;
                        }
                    case 2:
                        {
                            Item obj = level.Items[itemList.SelectedIndex];
                            obj.X = (uint)xCoord.Value;
                            obj.XOffset = (uint)xOffset.Value;
                            obj.Y = (uint)yCoord.Value;
                            obj.YOffset = (uint)yOffset.Value;
                            level.Items[itemList.SelectedIndex] = obj;
                            break;
                        }
                    case 3:
                        {
                            Boss obj = level.Bosses[bossList.SelectedIndex];
                            obj.X = (uint)xCoord.Value;
                            obj.XOffset = (uint)xOffset.Value;
                            obj.Y = (uint)yCoord.Value;
                            obj.YOffset = (uint)yOffset.Value;
                            level.Bosses[bossList.SelectedIndex] = obj;
                            break;
                        }
                    case 4:
                        {
                            Enemy obj = level.Enemies[enemyList.SelectedIndex];
                            obj.X = (uint)xCoord.Value;
                            obj.XOffset = (uint)xOffset.Value;
                            obj.Y = (uint)yCoord.Value;
                            obj.YOffset = (uint)yOffset.Value;
                            level.Enemies[enemyList.SelectedIndex] = obj;
                            break;
                        }
                    case 5:
                        {
                            a = true;
                            DynamicTerrain obj = level.DynamicTerrain[dynamicList.SelectedIndex];
                            obj.X = (short)xCoord.Value;
                            obj.Y = (short)yCoord.Value;
                            level.DynamicTerrain[dynamicList.SelectedIndex] = obj;
                            RefreshEntityLists();
                            a = false;
                            break;
                        }
                }
            } catch { }
        }

        private void xCoord_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != -1 && !a)
            {
                UpdateCoords();
            }
        }

        private void xOffset_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != -1 && !a)
            {
                // Allow for overflow and underflow to the offset values that loop around
                if (xOffset.Value > 15)
                {
                    xOffset.Value -= 16;
                    xCoord.Value++;
                }
                if (xOffset.Value < 0)
                {
                    xOffset.Value += 16;
                    xCoord.Value--;
                }

                UpdateCoords();
            }
        }

        private void yCoord_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != -1 && !a)
            {
                UpdateCoords();
            }
        }

        private void yOffset_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != -1 && !a)
            {
                // Allow for overflow and underflow to the offset values that loop around
                if (yOffset.Value > 15)
                {
                    yOffset.Value -= 16;
                    yCoord.Value++;
                }
                if (yOffset.Value < 0)
                {
                    yOffset.Value += 16;
                    yCoord.Value--;
                }
                UpdateCoords();
            }
        }

        private void addObj_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                try
                {
                    switch (tabControl1.SelectedIndex)
                    {
                        case 0:
                            level.Objects.Add(new RDLLVL.Object());
                            RefreshEntityLists();
                            break;
                        case 1:
                            level.Carriables.Add(new SpecialItem());
                            RefreshEntityLists();
                            break;
                        case 2:
                            level.Items.Add(new Item());
                            RefreshEntityLists();
                            break;
                        case 3:
                            level.Bosses.Add(new Boss());
                            RefreshEntityLists();
                            break;
                        case 4:
                            level.Enemies.Add(new Enemy());
                            RefreshEntityLists();
                            break;
                        case 5:
                            bool newDynamicAdded = false;
                            for (int i = 0; i < 16; i++)
                            {
                                if (level.DynamicTerrain[i] == null)
                                {
                                    newDynamicAdded = true;

                                    DynamicTerrain newSlice = new DynamicTerrain();
                                    newSlice.Width = 1;
                                    newSlice.Height = 1;
                                    newSlice.tiles = new List<MoveTile>();
                                    MoveTile newTile = new MoveTile();
                                    newSlice.tiles.Add(newTile);
                                    level.DynamicTerrain[i] = newSlice;
                                    RefreshEntityLists();
                                    break;
                                }
                            }
                            if (!newDynamicAdded) MessageBox.Show("Stages are limited to only 16 Dynamic Tile Sections");

                            
                            break;
                    }
                } catch { }
            }
        }
        private void delObj_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                try
                {
                    switch (tabControl1.SelectedIndex)
                    {
                        case 0:
                            level.Objects.RemoveAt(objList.SelectedIndex);
                            RefreshEntityLists();
                            break;
                        case 1:
                            level.Carriables.RemoveAt(carriablesList.SelectedIndex);
                            RefreshEntityLists();
                            break;
                        case 2:
                            level.Items.RemoveAt(itemList.SelectedIndex);
                            RefreshEntityLists();
                            break;
                        case 3:
                            level.Bosses.RemoveAt(bossList.SelectedIndex);
                            RefreshEntityLists();
                            break;
                        case 4:
                            level.Enemies.RemoveAt(enemyList.SelectedIndex);
                            RefreshEntityLists();
                            break;
                        case 5:
                            level.DynamicTerrain[dynamicList.SelectedIndex] = null;
                            level.ActionTable[dynamicList.SelectedIndex] = new DynamicAction();
                            RefreshEntityLists();
                            break;
                    }
                } catch { }
            }
        }
        private void editObj_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                try
                {
                    switch (tabControl1.SelectedIndex)
                    {
                        case 0:
                            ObjectEditor editor0 = new ObjectEditor(this);
                            editor0.obj = level.Objects[objList.SelectedIndex];
                            if (editor0.ShowDialog() == DialogResult.OK)
                            {
                                level.Objects[objList.SelectedIndex] = editor0.obj;
                                RefreshEntityLists();
                            }
                            break;
                        case 1:
                            SpecialItemEditor editor1 = new SpecialItemEditor(this);
                            editor1.obj = level.Carriables[carriablesList.SelectedIndex];
                            if (editor1.ShowDialog() == DialogResult.OK)
                            {
                                level.Carriables[carriablesList.SelectedIndex] = editor1.obj;
                                RefreshEntityLists();
                            }
                            break;
                        case 2:
                            ItemEditor editor2 = new ItemEditor(this);
                            editor2.obj = level.Items[itemList.SelectedIndex];
                            if (editor2.ShowDialog() == DialogResult.OK)
                            {
                                level.Items[itemList.SelectedIndex] = editor2.obj;
                                RefreshEntityLists();
                            }
                            break;
                        case 3:
                            BossEditor editor3 = new BossEditor(this);
                            editor3.obj = level.Bosses[bossList.SelectedIndex];
                            if (editor3.ShowDialog() == DialogResult.OK)
                            {
                                level.Bosses[bossList.SelectedIndex] = editor3.obj;
                                RefreshEntityLists();
                            }
                            break;
                        case 4:
                            EnemyEditor editor4 = new EnemyEditor(this);
                            editor4.obj = level.Enemies[enemyList.SelectedIndex];
                            if (editor4.ShowDialog() == DialogResult.OK)
                            {
                                level.Enemies[enemyList.SelectedIndex] = editor4.obj;
                                RefreshEntityLists();
                            }
                            break;
                        case 5:
                            if (level.DynamicTerrain[dynamicList.SelectedIndex] == null)
                            {
                                DynamicTerrain newSlice = new DynamicTerrain();
                                newSlice.Width = 1;
                                newSlice.Height = 1;
                                newSlice.tiles = new List<MoveTile>();
                                MoveTile newTile = new MoveTile();
                                newSlice.tiles.Add(newTile);
                                level.DynamicTerrain[dynamicList.SelectedIndex] = newSlice;
                            }
                            DynamicTerrainEditor editor5 = new DynamicTerrainEditor(this);
                            editor5.baseObj = level.DynamicTerrain[dynamicList.SelectedIndex];
                            editor5.baseAction = level.ActionTable[dynamicList.SelectedIndex];
                            if (editor5.ShowDialog() == DialogResult.Yes)
                            {
                                level.DynamicTerrain[dynamicList.SelectedIndex] = editor5.obj;
                                level.ActionTable[dynamicList.SelectedIndex] = editor5.action;
                                RefreshEntityLists();
                            }

                            break;
                    }
                } catch { }
            }
        }
        private void entityLists_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null) editObj_Click(this, new EventArgs());
        }
        private void cloneObj_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                try
                {
                    switch (tabControl1.SelectedIndex)
                    {
                        case 0:
                            level.Objects.Add(level.Objects[objList.SelectedIndex]);
                            RefreshEntityLists();
                            break;
                        case 1:
                            level.Carriables.Add(level.Carriables[carriablesList.SelectedIndex]);
                            RefreshEntityLists();
                            break;
                        case 2:
                            level.Items.Add(level.Items[itemList.SelectedIndex]);
                            RefreshEntityLists();
                            break;
                        case 3:
                            level.Bosses.Add(level.Bosses[bossList.SelectedIndex]);
                            RefreshEntityLists();
                            break;
                        case 4:
                            level.Enemies.Add(level.Enemies[enemyList.SelectedIndex]);
                            RefreshEntityLists();
                            break;
                        case 5:
                            bool newDynamicAdded = false;
                            for (int i = 0; i < 16; i++)
                            {
                                if (level.DynamicTerrain[i] == null)
                                {
                                    newDynamicAdded = true;
                                    DynamicTerrain newTerrain = new DynamicTerrain();
                                    newTerrain.X = level.DynamicTerrain[dynamicList.SelectedIndex].X;
                                    newTerrain.Y = level.DynamicTerrain[dynamicList.SelectedIndex].Y;
                                    newTerrain.Width = level.DynamicTerrain[dynamicList.SelectedIndex].Width;
                                    newTerrain.Height = level.DynamicTerrain[dynamicList.SelectedIndex].Height;
                                    newTerrain.tiles = level.DynamicTerrain[dynamicList.SelectedIndex].tiles;

                                    DynamicAction newAction = new DynamicAction();
                                    newAction.EventID = level.ActionTable[dynamicList.SelectedIndex].EventID;
                                    newAction.Parameter1 = level.ActionTable[dynamicList.SelectedIndex].Parameter1;
                                    newAction.Parameter2 = level.ActionTable[dynamicList.SelectedIndex].Parameter2;
                                    newAction.autoStart = level.ActionTable[dynamicList.SelectedIndex].autoStart;
                                    newAction.phases = new List<ActionPhase>();
                                    for (int p = 0; p < level.ActionTable[dynamicList.SelectedIndex].phases.Count; p++)
                                    {
                                        newAction.phases.Add(level.ActionTable[dynamicList.SelectedIndex].phases[p]);
                                    }

                                    level.DynamicTerrain[i] = newTerrain;
                                    level.ActionTable[i] = newAction;
                                    RefreshEntityLists();
                                    break;
                                }
                            }
                            if (!newDynamicAdded) MessageBox.Show("Stages are limited to only 16 Dynamic Tile Sections");
                            break;
                    }
                } catch { }
            }
        }

        private void stageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                StageSettings settings = new StageSettings(this);
                settings.data = level.StageData;
                settings.background = level.Background;
                settings.tileset = level.Tileset;
                settings.temp4DSections = level.All4DSections;
                settings.tempEvents = level.ActionTable;
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    level.StageData = settings.data;
                    level.Background = settings.background;
                    level.Tileset = settings.tileset;
                    level.All4DSections = settings.temp4DSections;
                    level.ActionTable = settings.tempEvents;
                }
            }
        }
        private void materialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialList.SelectedIndex)
            {
                case 0:
                    vMat.Value = 0;
                    break;
                case 1:
                    vMat.Value = 8;
                    break;
                case 2:
                    vMat.Value = 16;
                    break;
                case 3:
                    vMat.Value = 24;
                    break;
                case 4:
                    vMat.Value = 32;
                    break;
                case 5:
                    vMat.Value = 40;
                    break;
                case 6:
                    vMat.Value = 48;
                    break;
                case 7:
                    vMat.Value = 56;
                    break;
            }
        }
        private void vmat_ValueChanged(object sender, EventArgs e)
        {
            if (vMat.Value < 8)
            {
                materialList.SelectedIndex = 0;
            }
            else if (vMat.Value < 16)
            {
                materialList.SelectedIndex = 1;
            }
            else if (vMat.Value < 24)
            {
                materialList.SelectedIndex = 2;
            }
            else if (vMat.Value < 32)
            {
                materialList.SelectedIndex = 3;
            }
            else if (vMat.Value < 40)
            {
                materialList.SelectedIndex = 4;
            }
            else if (vMat.Value < 48)
            {
                materialList.SelectedIndex = 5;
            }
            else if (vMat.Value < 56)
            {
                materialList.SelectedIndex = 6;
            }
            else
            {
                materialList.SelectedIndex = 7;
            }
        }
        private void vBlock_ValueChanged_1(object sender, EventArgs e)
        {
            Objects objs = new Objects();
            if (objs.blockIDs.ContainsKey(vBlock.Value))
            {
                blockImg.Image = new Bitmap("Resources/blocks/" + objs.blockIDs[vBlock.Value] + ".png");
                blockList.Text = objs.blockIDs[vBlock.Value];
            }
            else if (vBlock.Value == -1)
            {
                blockImg.Image = new Bitmap("Resources/tiles/0.png");
                blockList.Text = "No Block";
            }
            else
            {
                blockImg.Image = new Bitmap("Resources/blocks/Unknown.png");
                blockList.Text = "Unknown (" + vBlock.Value + ")";
            }
        }
        private void blockList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Objects objs = new Objects();
            if (blockList.SelectedIndex == 0)
            {
                vBlock.Value = -1;
            } else
            {
                vBlock.Value = objs.blockIDs.FirstOrDefault(x => x.Value == blockList.Text).Key;
            }
        }
        private void vShape_ValueChanged_1(object sender, EventArgs e)
        {
            Image previewImage = new Bitmap("Resources/tiles/" + vShape.Value + ".png");
            if (previewImage != null)
            {
                colImg.Image = previewImage;
            }
            else
            {
                colImg.Image = new Bitmap("Resources/blocks/unknown.png");
            }
        }
        private void halfTileLock_CheckedChanged(object sender, EventArgs e)
        {
            if(halfTileLock.Checked)
            {
                xOffset.Increment = 8;
                yOffset.Increment = 8;
            } else
            {
                xOffset.Increment = 1;
                yOffset.Increment = 1;
            }
        }
        private void editCol_Click(object sender, EventArgs e)
        {
            editCollisionShapeToolStripMenuItem.Checked = !editCollisionShapeToolStripMenuItem.Checked;
            RefreshTileDataEditorColors();
            if (editCollisionShapeToolStripMenuItem.Checked)
            {
                editCol.BackColor = Color.LightSteelBlue;
            } else editCol.BackColor = Color.White;
        }
        private void editMod_Click(object sender, EventArgs e)
        {
            editModifiersToolStripMenuItem.Checked = !editModifiersToolStripMenuItem.Checked;
            RefreshTileDataEditorColors();
            if (editModifiersToolStripMenuItem.Checked)
            {
                editMod.BackColor = Color.LightSteelBlue;
            }
            else editMod.BackColor = Color.White;
        }
        private void editMat_Click(object sender, EventArgs e)
        {
            editMaterialsToolStripMenuItem.Checked = !editMaterialsToolStripMenuItem.Checked;
            RefreshTileDataEditorColors();
            if (editMaterialsToolStripMenuItem.Checked)
            {
                editMat.BackColor = Color.LightSteelBlue;
            }
            else editMat.BackColor = Color.White;
        }
        private void editAuto_Click(object sender, EventArgs e)
        {
            editAutoMovementToolStripMenuItem.Checked = !editAutoMovementToolStripMenuItem.Checked;
            RefreshTileDataEditorColors();
            if (editAutoMovementToolStripMenuItem.Checked)
            {
                editAuto.BackColor = Color.LightSteelBlue;
            }
            else editAuto.BackColor = Color.White;
        }
        private void editBlock_Click(object sender, EventArgs e)
        {
            editBlocksToolStripMenuItem.Checked = !editBlocksToolStripMenuItem.Checked;
            RefreshTileDataEditorColors();
            if (editBlocksToolStripMenuItem.Checked)
            {
                editBlock.BackColor = Color.LightSteelBlue;
            }
            else editBlock.BackColor = Color.White;
        }
        private void editDecoB_Click(object sender, EventArgs e)
        {
            editBLandToolStripMenuItem.Checked = !editBLandToolStripMenuItem.Checked;
            RefreshTileDataEditorColors();
            if (editBLandToolStripMenuItem.Checked)
            {
                editDecoB.BackColor = Color.LightSteelBlue;
            }
            else editDecoB.BackColor = Color.White;
        }
        private void editDecoM_Click(object sender, EventArgs e)
        {
            editMLandToolStripMenuItem.Checked = !editMLandToolStripMenuItem.Checked;
            RefreshTileDataEditorColors();
            if (editMLandToolStripMenuItem.Checked)
            {
                editDecoM.BackColor = Color.LightSteelBlue;
            }
            else editDecoM.BackColor = Color.White;
        }
        private void editDecoF_Click(object sender, EventArgs e)
        {
            editFLandToolStripMenuItem.Checked = !editFLandToolStripMenuItem.Checked;
            RefreshTileDataEditorColors();
            if (editFLandToolStripMenuItem.Checked)
            {
                editDecoF.BackColor = Color.LightSteelBlue;
            }
            else editDecoF.BackColor = Color.White;
        }
        private void unlockAll_Click(object sender, EventArgs e)
        {
            bool allOn = true;
            if (editCollisionShapeToolStripMenuItem.Checked && editModifiersToolStripMenuItem.Checked &&
                editMaterialsToolStripMenuItem.Checked && editAutoMovementToolStripMenuItem.Checked &&
                editBlocksToolStripMenuItem.Checked && editBLandToolStripMenuItem.Checked &&
                editMLandToolStripMenuItem.Checked && editFLandToolStripMenuItem.Checked) allOn = false;

            editCollisionShapeToolStripMenuItem.Checked = !allOn;
            editModifiersToolStripMenuItem.Checked = !allOn;
            editMaterialsToolStripMenuItem.Checked = !allOn;
            editAutoMovementToolStripMenuItem.Checked = !allOn;
            editBlocksToolStripMenuItem.Checked = !allOn;
            editBLandToolStripMenuItem.Checked = !allOn;
            editMLandToolStripMenuItem.Checked = !allOn;
            editFLandToolStripMenuItem.Checked = !allOn;

            editCol_Click(this, new EventArgs());
            editMod_Click(this, new EventArgs());
            editMat_Click(this, new EventArgs());
            editAuto_Click(this, new EventArgs());
            editBlock_Click(this, new EventArgs());
            editDecoB_Click(this, new EventArgs());
            editDecoM_Click(this, new EventArgs());
            editDecoF_Click(this, new EventArgs());
        }
        public string ReadNotes(string category, string key)
        {
            string notes = "";
            if (File.Exists(notesFilepath))
            {
                String line;
                try
                {
                    StreamReader noteStream = new StreamReader(notesFilepath);
                    line = noteStream.ReadLine();
                    while (!line.Contains("/" + category + " [" + key + "]"))
                    {
                        line = noteStream.ReadLine();
                        if (line == null)
                        {
                            noteStream.Close();
                            noteStream.Dispose();
                            return notes;
                        }
                    }
                    bool firstLine = true;
                    while (line != null)
                    {
                        line = noteStream.ReadLine();
                        if (line.Contains("/;")) 
                        {
                            noteStream.Close();
                            noteStream.Dispose();
                            return notes;
                        }
                        else
                        {
                            if (firstLine) 
                            {
                                notes += line;
                                firstLine = false;
                            } 
                            else notes += Environment.NewLine + line;
                        }
                    }
                    noteStream.Close();
                    noteStream.Dispose();
                }
                catch { MessageBox.Show("Failed To Read Notes: " + category + ": [" + key + "]"); }
            }
            return notes;
        }
        public void WriteNotes(string category, string key, string newNotes)
        {
            if (File.Exists(notesFilepath))
            {
                String line;
                String notes = "";

                try
                {
                    StreamReader noteStream = new StreamReader(notesFilepath);
                    line = noteStream.ReadLine();
                    notes += line + Environment.NewLine;


                    while (!line.Contains("/" + category + " [" + key + "]"))
                    {
                        line = noteStream.ReadLine();
                        if (line != null)
                        {
                            notes += line + Environment.NewLine;
                        }
                        else
                        {
                            // Write Notes at the end of the txt file
                            noteStream.Close();
                            noteStream.Dispose();
                            StreamWriter noteInitWriter = new StreamWriter(notesFilepath);
                            notes += Environment.NewLine + "/" + category + " [" + key + "]" + Environment.NewLine + newNotes + Environment.NewLine + "/;";
                            noteInitWriter.Write(notes);
                            noteInitWriter.Close();
                            noteInitWriter.Dispose();
                            return;
                        }
                    }
                    // Save all previous text to "PreNotes"
                    line = noteStream.ReadLine();
                    string preNotes = notes;
                    notes = "";
                    while (!line.Contains("/;"))
                    {
                        line = noteStream.ReadLine();
                    }
                    line = noteStream.ReadLine();

                    // Record all notes then save to "PostNotes"
                    while (line != null)
                    {
                        notes += line + Environment.NewLine;
                        line = noteStream.ReadLine();
                    }
                    string postNotes = notes;
                    notes = preNotes + newNotes + Environment.NewLine + "/;" + Environment.NewLine + postNotes;

                    noteStream.Close();
                    noteStream.Dispose();

                    StreamWriter noteInsertWriter = new StreamWriter(notesFilepath);
                    noteInsertWriter.Write(notes);
                    noteInsertWriter.Close();
                    noteInsertWriter.Dispose();
                }
                catch { MessageBox.Show("Failed To Write Notes: " + category + ": [" + key + "]"); }
            }
        }

        private void optionsAndHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options opt = new Options(this);
            opt.Refresh();
            opt.ShowDialog();
        }
        private void spriteEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpriteEditor spr = new SpriteEditor(this);
            spr.Refresh();
            spr.ShowDialog();
        }
        private void cleanMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < level.TileCollision.Count; i++)
            {
                Collision newCol = level.TileCollision[i];
                if (((newCol.Modifier & (1 << 2)) != 0) || newCol.Shape == 0) newCol.Material = 0;
                level.TileCollision[i] = newCol;
            }
        }
        private Vector2 coordFromIX(int ix)
        {
            int curX = 0;
            int curY = 0;
            for (int i = 0; i < ix; i++)
            {
                curX++;
                if (curX == level.Width)
                {
                    curY++;
                    curX = 0;
                }
            }
            return new Vector2(curX, curY);
        }
        private void clearBoundariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < level.TileCollision.Count; i++)
            {
                Collision newCol = level.TileCollision[i];
                if ((newCol.Modifier & (1 << 2)) != 0)
                {
                    newCol.Modifier -= 4;
                    if (newCol.Shape == 1) newCol.Shape = 0;
                    level.TileCollision[i] = newCol;
                }
            }
        }
        private void generateBoundariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < level.TileCollision.Count; i++)
            {
                Collision newCol = level.TileCollision[i];
                int boundCount = 2;
                if (newCol.Shape != 1)
                {
                    Vector2 v = coordFromIX(i);
                    if (v.X < boundCount || v.X >= (level.Width - boundCount) || v.Y >= (level.Height - boundCount))
                    {
                        newCol.Shape = 1;
                        newCol.Modifier = 4;
                        level.TileCollision[i] = newCol;
                    }
                }
            }
        }
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl2.SelectedIndex == 1)
                {
                    dB_hex.Text = ((short)dB_ID.Value).ToString("X4") + ((byte)dB_Unk.Value).ToString("X2") + ((sbyte)dB_Dynamic.Value).ToString("X2");
                    dF_hex.Text = ((short)dF_ID.Value).ToString("X4") + ((byte)dF_Unk.Value).ToString("X2") + ((sbyte)dF_Dynamic.Value).ToString("X2");
                    dM_hex.Text = ((short)dM_ID.Value).ToString("X4") + ((byte)dM_Unk.Value).ToString("X2") + ((sbyte)dM_Dynamic.Value).ToString("X2");
                }
                else
                {
                    uint b = uint.Parse(dB_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                    dB_ID.Value = short.Parse(dB_hex.Text.Substring(0, 4), System.Globalization.NumberStyles.HexNumber);
                    dB_Unk.Value = uint.Parse(dB_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    if (b < 16) dB_Dynamic.Value = b;
                    else dB_Dynamic.Value = -1;

                    uint f = uint.Parse(dF_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                    dF_ID.Value = short.Parse(dF_hex.Text.Substring(0, 4), System.Globalization.NumberStyles.HexNumber);
                    dF_Unk.Value = uint.Parse(dF_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    if (f < 16) dF_Dynamic.Value = f;
                    else dF_Dynamic.Value = -1;

                    uint m = uint.Parse(dM_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                    dM_ID.Value = short.Parse(dM_hex.Text.Substring(0, 4), System.Globalization.NumberStyles.HexNumber);
                    dM_Unk.Value = uint.Parse(dM_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    if (m < 16) dM_Dynamic.Value = m;
                    else dM_Dynamic.Value = -1;
                }
            } catch { }
        }
        private void d1_hex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                uint b = uint.Parse(dB_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                dB_ID.Value = short.Parse(dB_hex.Text.Substring(0, 4), System.Globalization.NumberStyles.HexNumber);
                dB_Unk.Value = uint.Parse(dB_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                if (b < 16) dB_Dynamic.Value = b;
                else dB_Dynamic.Value = -1;
            } catch { }
        }
        private void d2_hex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                uint f = uint.Parse(dF_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                dF_ID.Value = short.Parse(dF_hex.Text.Substring(0, 4), System.Globalization.NumberStyles.HexNumber);
                dF_Unk.Value = uint.Parse(dF_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                if (f < 16) dF_Dynamic.Value = f;
                else dF_Dynamic.Value = -1;
            } catch { }
        }
        private void d3_hex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                uint m = uint.Parse(dM_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                dM_ID.Value = short.Parse(dM_hex.Text.Substring(0, 4), System.Globalization.NumberStyles.HexNumber);
                dM_Unk.Value = uint.Parse(dM_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                if (m < 16) dM_Dynamic.Value = m;
                else dM_Dynamic.Value = -1;
            } catch { }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshEditor();
        }

        public async void RefreshEditor()
        {
            Objects objs = new Objects();
            glControl.MakeCurrent();
            RefreshEntityLists();
            RefreshEntitySprites();
            RefreshColors();
            refreshing = true;
            await Task.Delay(1);
            refreshing = false;
        }

        private void colImg_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                ColShapeSelector select = new ColShapeSelector();
                if (select.ShowDialog() == DialogResult.OK)
                {
                    vShape.Value = select.index;
                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = true;
            TabPage current = (sender as TabControl).SelectedTab;
            objList.ClearSelected();
            carriablesList.ClearSelected();
            itemList.ClearSelected();
            bossList.ClearSelected();
            enemyList.ClearSelected();
            dynamicList.ClearSelected();
            RefreshEntityLists();
            a = false;
        }
        private void patchFDGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                patchFDG();
            }
        }
        void patchFDG()
        {
            if (!string.IsNullOrEmpty(MagoCrate.Properties.Settings.Default.FDGAutoFilePath) && File.Exists(MagoCrate.Properties.Settings.Default.FDGAutoFilePath))
            {
                EditFDGArchive(MagoCrate.Properties.Settings.Default.FDGAutoFilePath);
            }
            else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "FDGH Data Files|*.dat";
                open.CheckFileExists = true;
                open.Multiselect = false;
                open.RestoreDirectory = true;
                open.Title = "Select an FDGH Data File";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    EditFDGArchive(open.FileName);
                }
            }
        }
        void EditFDGArchive(string path)
        {
            fdgFilePath = path;
            fdgArchive = new KirbyFDGH.FDGH(fdgFilePath);
            fdgSceneList.Clear();

            for (int i = 0; i < fdgArchive.SceneList.Count; i++)
                fdgSceneList.Add(fdgArchive.SceneList[i].Name, i);

            checkedThings.Clear();

            // Open Scene List
            FDGScene fdg = new FDGScene();
            if (fdg.ShowDialog() == DialogResult.OK)
            {
                Enabled = false;
                fdgScn = fdg.selectedScene;
                Cursor = Cursors.WaitCursor;

                try
                {
                    if (fdg.clearing)
                    {
                        fdgArchive.SceneList[fdgSceneList[fdgScn]].Dependencies.Clear();
                        fdgArchive.SceneList[fdgSceneList[fdgScn]].AssetList.Clear();
                    }

                    String fdgFilepath = Directory.GetCurrentDirectory() + "\\CustomData\\FDGPatching.txt";
                    if (File.Exists(fdgFilepath) && fdgArchive != null && level != null)
                    {
                        StreamReader fdgStream = new StreamReader(fdgFilepath);
                        String line = fdgStream.ReadLine();


                        while (line != null)
                        {
                            if (line.StartsWith("---"))
                            {
                                string key = line.Substring(4, line.Length - 4);
                                List<string> additions = new List<string>();
                                line = fdgStream.ReadLine();
                                while (line != null)
                                {
                                    if (!line.StartsWith("---") && line != "")
                                    {
                                        additions.Add(line);
                                        line = fdgStream.ReadLine();
                                    }
                                    else break;
                                }
                                AddFDGData(key, additions);
                            }
                            else line = fdgStream.ReadLine();
                        }
                        fdgStream.Close();
                        fdgStream.Dispose();


                    }
                    Objects objs = new Objects();
                    if (!fdgArchive.SceneList[fdgSceneList[fdgScn]].AssetList.Contains(objs.levelFDGs[fdgScn]) && fdg.clearing)
                    {
                        fdgArchive.SceneList[fdgSceneList[fdgScn]].AssetList.Add(objs.levelFDGs[fdgScn]);
                    }
                    fdgArchive.Write(fdgFilePath);

                    // Open and re-save the archive with 1.0 FDGH.
                    fdgArchive2 = new KirbyFDGH.FDGH2(fdgFilePath);
                    fdgArchive2.Write(fdgFilePath);
                }
                catch { MessageBox.Show("Failed To Write FDG Data"); }
                Enabled = true;
                Cursor = Cursors.Arrow;
            }
        }
        void AddFDGData(string key, List<string> additions)
        {
            Objects objs = new Objects();
            bool succeeded = false;
            Console.WriteLine("Checking Key: " + key);

            // Every Specific Key Combination
            if (checkedThings.Contains(key))
            {
                succeeded = false;
            }
            else if ((key == "objects/Common" && level.Objects.Count > 0) || (key == "carriables/Common" && level.Carriables.Count > 0) || (key == "items/Common" && level.Items.Count > 0) || (key == "bosses/Common" && level.Bosses.Count > 0) || (key == "enemies/Common" && level.Objects.Count > 0) || (key == "Common"))
            {
                succeeded = true;
            }
            else if (key.StartsWith("objects/"))
            {
                if (objList.Items.Contains(key.Substring(8, key.Length - 8)))
                {
                    checkedThings.Add(key);
                    succeeded = true;
                }
            }
            else if (key.StartsWith("carriables/"))
            {
                if (key.Contains("_a."))
                {
                    for (int i = 0; i < level.Carriables.Count; i++)
                    {
                        if (key.Contains("[" + level.Carriables[i].AppearID + "]") && key.Contains(objs.CarriablesList[level.Carriables[i].Type]))
                        {
                            checkedThings.Add(key);
                            succeeded = true;
                        }
                    }
                }
                else if (carriablesList.Items.Contains(key.Substring(11, key.Length - 11)))
                {
                    checkedThings.Add(key);
                    succeeded = true;
                }
            }
            else if (key.StartsWith("items/"))
            {
                if (key.Contains("_b."))
                {
                    for (int i = 0; i < level.Items.Count; i++)
                    {
                        if (key.Contains("[" + level.Items[i].Level + "]") && key.Contains(objs.ItemList[level.Items[i].Type]))
                        {
                            checkedThings.Add(key);
                            succeeded = true;
                        }
                    }
                }
                else if (itemList.Items.Contains(key.Substring(6, key.Length - 6)))
                {
                    checkedThings.Add(key);
                    succeeded = true;
                }
            }
            else if (key.StartsWith("bosses/"))
            {
                if (key.Contains("_l."))
                {
                    for (int i = 0; i < level.Bosses.Count; i++)
                    {
                        if (key.Contains("[" + level.Bosses[i].Level + "]") && key.Contains(objs.BossList[level.Bosses[i].Type]))
                        {
                            checkedThings.Add(key);
                            succeeded = true;
                        }
                    }
                }
                else if (key.Contains("_super"))
                {
                    for (int i = 0; i < level.Bosses.Count; i++)
                    {
                        if (level.Bosses[i].HasSuperAbility && key.Contains(objs.BossList[level.Bosses[i].Type]))
                        {
                            checkedThings.Add(key);
                            succeeded = true;
                        }
                    }
                }
                else if (bossList.Items.Contains(key.Substring(7, key.Length - 7)))
                {
                    checkedThings.Add(key);
                    succeeded = true;
                }
            }
            else if (key.StartsWith("enemies/"))
            {
                if (key.Contains("_l."))
                {
                    for (int i = 0; i < level.Enemies.Count; i++)
                    {
                        if (key.Contains("[" + level.Enemies[i].Level + "]") && key.Contains(objs.EnemyList[level.Enemies[i].Type]))
                        {
                            checkedThings.Add(key);
                            succeeded = true;
                        }
                    }
                }
                else if (key.Contains("_super"))
                {
                    for (int i = 0; i < level.Enemies.Count; i++)
                    {
                        if (level.Enemies[i].HasSuperAbility && key.Contains(objs.EnemyList[level.Enemies[i].Type]))
                        {
                            checkedThings.Add(key);
                            succeeded = true;
                        }
                    }
                }
                else if (enemyList.Items.Contains(key.Substring(8, key.Length - 8)))
                {
                    checkedThings.Add(key);
                    succeeded = true;
                }
            }
            else if (key.StartsWith("blocks/"))
            {
                for (int i = 0; i < level.TileBlock.Count; i++)
                {
                    if (!checkedThings.Contains(key) && objs.blockIDs.ContainsKey(level.TileBlock[i].ID))
                    {
                        if (objs.blockIDs[level.TileBlock[i].ID] == (key.Substring(7, key.Length - 7)))
                        {
                            checkedThings.Add(key);
                            succeeded = true;
                        }
                    }
                }
            }
            else if (key.StartsWith("backgrounds/"))
            {
                if (key.Contains(objs.DecorationList[level.Background]))
                {
                    succeeded = true;
                }
            }
            else if (key.StartsWith("tilesets/"))
            {
                if (key.Contains(objs.DecorationList[level.Tileset]))
                {
                    succeeded = true;
                }
            }

            // Add the additions if the key checks succeeded
            if (succeeded)
            {
                for (int i = 0; i < additions.Count; i++)
                {
                    if (additions[i].EndsWith("dn") && !fdgArchive.SceneList[fdgSceneList[fdgScn]].Dependencies.Contains(additions[i]))
                    {
                        fdgArchive.SceneList[fdgSceneList[fdgScn]].Dependencies.Add(additions[i]);
                        Console.WriteLine("Adding Dependency " + additions[i]);
                    }
                    else if (!fdgArchive.SceneList[fdgSceneList[fdgScn]].AssetList.Contains(additions[i]))
                    {
                        fdgArchive.SceneList[fdgSceneList[fdgScn]].AssetList.Add(additions[i]);
                        Console.WriteLine("Adding Asset " + additions[i]);
                    }
                }
            }
            else Console.WriteLine("Key not found in present level");
        }
        public static Color DecorColorFromBytes(byte unk_1, byte unk_2, byte unk_3)
        {
            double hue = unk_2 * 1.3f;

            double saturation = 1 - ((float)unk_3 / 30);
            if (saturation < 0.2) saturation = 0.2;
            else if (saturation > 1) saturation = 1;

            double value = 1 - ((float)unk_1 / 3);
            if (value < 0.2) value = 0.2;
            else if (value > 1) value = 1;

            return ColorFromHSV(hue, saturation, value);
        }
        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
        public static Color BrightColor(Color baseCol)
        {
            double h = baseCol.GetHue();
            double s = baseCol.GetSaturation();
            //if (s != 0) s = 1;
            return ColorFromHSV(h, s, 1);
        }
    }
}
