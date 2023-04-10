using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MagoCrate;
using MagoBox.Editors;
using MagoBox.Rendering;
using RDLLVL;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace MagoBox
{
    public partial class MainForm : Form
    {
        public Level level;
        public string filePath;
        public string instantFilePath;

        List<int> texIds = new List<int>();
        List<int> modTexIds = new List<int>();
        List<int> entityTexIds = new List<int>();
        List<int> propertyTexIds = new List<int>();
        List<int> hexTexIds = new List<int>();
        List<int> zoneTexIds = new List<int>();

        Dictionary<string, Image> objSprites = new Dictionary<string, Image>();
        Dictionary<string, Image> carrySprites = new Dictionary<string, Image>();
        Dictionary<string, Image> itemSprites = new Dictionary<string, Image>();
        Dictionary<string, Image> bossSprites = new Dictionary<string, Image>();
        Dictionary<string, Image> enemySprites = new Dictionary<string, Image>();
        Dictionary<string, Image> exceptionSprites = new Dictionary<string, Image>();

        Dictionary<string, Image> complexObjSprites = new Dictionary<string, Image>();
        Dictionary<string, Image> complexCarrySprites = new Dictionary<string, Image>();
        Dictionary<string, Image> complexItemSprites = new Dictionary<string, Image>();
        Dictionary<string, Image> complexBossSprites = new Dictionary<string, Image>();
        Dictionary<string, Image> complexEnemySprites = new Dictionary<string, Image>();

        Dictionary<string, Vector2> spriteOffsets = new Dictionary<string, Vector2>();
        private Dictionary<string, Vector2> spriteDimensions = new Dictionary<string, Vector2>();
        private Dictionary<string, Vector2> complexSpriteDimensions = new Dictionary<string, Vector2>();

        Renderer renderer;
        Texturing texturing;
        Camera camera;

        private System.Timers.Timer t;

        bool moveCam = false;
        bool refreshing = false;
        bool focused = true;
        int mouseX = 0;
        int mouseY = 0;

        int moveObj;

        int tool;

        uint tileX;
        uint tileY;

        public int collViewType = 0;
        public int optionsPixelPerTile = 20;
        bool instantLoad = false;

        private KirbyFDGH.FDGH fdgArchive;
        private KirbyFDGH.FDGH2 fdgArchive2;
        private Dictionary<string, int> fdgSceneList = new Dictionary<string, int>();
        private string fdgFilePath;
        private string fdgScn;
        List<string> checkedThings = new List<string>();

        public MainForm(string path)
        {
            InitializeComponent();
            instantFilePath = path;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshColors();
            if (instantFilePath != null && instantFilePath.Length > 0)
            {
                instantLoad = true;
            }
        }
        private void MainForm_Enter(object sender, EventArgs e)
        {
            focused = true;
        }
        private void MainForm_Leave(object sender, EventArgs e)
        {
            focused = false;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                // Collision Preset
                editCol.Checked = true;
                editModf.Checked = true;
                editMat.Checked = true;
                editAutoMove.Checked = true;
                editBlock.Checked = false;
                editBLand.Checked = false;
                editMLand.Checked = false;
                editFLand.Checked = false;
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                // Blocks Preset
                editCol.Checked = false;
                editModf.Checked = false;
                editMat.Checked = false;
                editAutoMove.Checked = false;
                editBlock.Checked = true;
                editBLand.Checked = false;
                editMLand.Checked = false;
                editFLand.Checked = false;
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                // Decoration Preset
                editCol.Checked = false;
                editModf.Checked = false;
                editMat.Checked = false;
                editAutoMove.Checked = false;
                editBlock.Checked = false;
                editBLand.Checked = true;
                editMLand.Checked = true;
                editFLand.Checked = true;
            }
        }
        public async void RefreshObjectLists()
        {
            if (level != null)
            {
                Objects objs = new Objects();
                int selIndex = 0;
                refreshing = true;
                complexSpriteDimensions.Clear();

                // Objects
                selIndex = objList.SelectedIndex;
                objList.Items.Clear();
                complexObjSprites.Clear();
                objList.BeginUpdate();
                for (int i = 0; i < level.Objects.Count; i++)
                {
                    if (objs.ObjectList.ContainsKey(level.Objects[i].Type))
                    {
                        objList.Items.Add(objs.ObjectList[level.Objects[i].Type]);
                        if (!complexObjSprites.ContainsKey(objs.ObjectList[level.Objects[i].Type] + "_p6." + level.Objects[i].Param6))
                        {
                            
                            if (File.Exists("Resources/obj/objects/" + objs.ObjectList[level.Objects[i].Type] + "_p6." + level.Objects[i].Param6 + ".png"))
                            {
                                Image img = Image.FromFile("Resources/obj/objects/" + objs.ObjectList[level.Objects[i].Type] + "_p6." + level.Objects[i].Param6 + ".png");
                                complexObjSprites.Add(objs.ObjectList[level.Objects[i].Type] + "_p6." + level.Objects[i].Param6, img);
                                complexSpriteDimensions.Add("objects/" + objs.ObjectList[level.Objects[i].Type] + "_p6." + level.Objects[i].Param6, new Vector2(img.Width, img.Height));
                            }
                        }
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
                complexCarrySprites.Clear();
                carriablesList.BeginUpdate();
                for (int i = 0; i < level.Carriables.Count; i++)
                {
                    if (objs.CarriablesList.ContainsKey(level.Carriables[i].Type))
                    {
                        carriablesList.Items.Add(objs.CarriablesList[level.Carriables[i].Type]);
                        if (!complexCarrySprites.ContainsKey(objs.CarriablesList[level.Carriables[i].Type] + "_a." + level.Carriables[i].AppearID))
                        {
                            
                            if (File.Exists("Resources/obj/carriables/" + objs.CarriablesList[level.Carriables[i].Type] + "_a." + level.Carriables[i].AppearID + ".png"))
                            {
                                Image img = Image.FromFile("Resources/obj/carriables/" + objs.CarriablesList[level.Carriables[i].Type] + "_a." + level.Carriables[i].AppearID + ".png");
                                complexCarrySprites.Add(objs.CarriablesList[level.Carriables[i].Type] + "_a." + level.Carriables[i].AppearID, img);
                                complexSpriteDimensions.Add("carriables/" + objs.CarriablesList[level.Carriables[i].Type] + "_a." + level.Carriables[i].AppearID, new Vector2(img.Width, img.Height));
                            }
                        }
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
                complexItemSprites.Clear();
                itemList.BeginUpdate();
                for (int i = 0; i < level.Items.Count; i++)
                {
                    if (objs.ItemList.ContainsKey(level.Items[i].Type))
                    {
                        itemList.Items.Add(objs.ItemList[level.Items[i].Type]);
                        if (!complexItemSprites.ContainsKey(objs.ItemList[level.Items[i].Type] + "_b." + level.Items[i].Behavior))
                        {
                            if (File.Exists("Resources/obj/items/" + objs.ItemList[level.Items[i].Type] + "_b." + level.Items[i].Behavior + ".png"))
                            {
                                Image img = Image.FromFile("Resources/obj/items/" + objs.ItemList[level.Items[i].Type] + "_b." + level.Items[i].Behavior + ".png");
                                complexItemSprites.Add(objs.ItemList[level.Items[i].Type] + "_b." + level.Items[i].Behavior, img);
                                complexSpriteDimensions.Add("items/" + objs.ItemList[level.Items[i].Type] + "_b." + level.Items[i].Behavior, new Vector2(img.Width, img.Height));
                            }
                        }
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
                complexBossSprites.Clear();
                bossList.BeginUpdate();
                for (int i = 0; i < level.Bosses.Count; i++)
                {
                    if (objs.BossList.ContainsKey(level.Bosses[i].Type))
                    {
                        bossList.Items.Add(objs.BossList[level.Bosses[i].Type]);
                        if (!complexBossSprites.ContainsKey(objs.BossList[level.Bosses[i].Type] + "_l." + level.Bosses[i].Param2))
                        {
                            if (File.Exists("Resources/obj/bosses/" + objs.BossList[level.Bosses[i].Type] + "_l." + level.Bosses[i].Param2 + ".png"))
                            {
                                Image img = Image.FromFile("Resources/obj/bosses/" + objs.BossList[level.Bosses[i].Type] + "_l." + level.Bosses[i].Param2 + ".png");
                                complexBossSprites.Add(objs.BossList[level.Bosses[i].Type] + "_l." + level.Bosses[i].Param2, img);
                                complexSpriteDimensions.Add("bosses/" + objs.BossList[level.Bosses[i].Type] + "_l." + level.Bosses[i].Param2, new Vector2(img.Width, img.Height));
                            }
                        }
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
                complexEnemySprites.Clear();
                enemyList.BeginUpdate();
                for (int i = 0; i < level.Enemies.Count; i++)
                {
                    if (objs.EnemyList.ContainsKey(level.Enemies[i].Type))
                    {
                        enemyList.Items.Add(objs.EnemyList[level.Enemies[i].Type]);
                        if (!complexEnemySprites.ContainsKey(objs.EnemyList[level.Enemies[i].Type] + "_l." + level.Enemies[i].Param1))
                        {
                            if (File.Exists("Resources/obj/enemies/" + objs.EnemyList[level.Enemies[i].Type] + "_l." + level.Enemies[i].Param1 + ".png"))
                            {
                                Image img = Image.FromFile("Resources/obj/enemies/" + objs.EnemyList[level.Enemies[i].Type] + "_l." + level.Enemies[i].Param1 + ".png");
                                complexEnemySprites.Add(objs.EnemyList[level.Enemies[i].Type] + "_l." + level.Enemies[i].Param1, img);
                                complexSpriteDimensions.Add("enemies/" + objs.EnemyList[level.Enemies[i].Type] + "_l." + level.Enemies[i].Param1, new Vector2(img.Width, img.Height));
                            }
                        }
                    }
                    else
                    {
                        enemyList.Items.Add($"Unknown ({level.Enemies[i].Type})");
                    }
                }
                if (enemyList.Items.Count >= selIndex + 1) enemyList.SelectedIndex = selIndex;
                enemyList.EndUpdate();

                await Task.Delay(20);
                refreshing = false;
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
            } else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "FDGH Data Files|*.dat";
                open.CheckFileExists = true;
                open.Multiselect = false;
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
                if (fdg.clearing)
                {
                    fdgArchive.SceneList[fdgSceneList[fdgScn]].Dependencies.Clear();
                    fdgArchive.SceneList[fdgSceneList[fdgScn]].AssetList.Clear();
                }

                String fdgFilepath = Directory.GetCurrentDirectory() + "\\CustomData\\FDGPatching.txt";
                if (File.Exists(fdgFilepath) && fdgArchive != null && level != null)
                {
                    try
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
                                while (!line.Contains("---") && line != null)
                                {
                                    if (line != "") additions.Add(line);
                                    line = fdgStream.ReadLine();
                                }
                                AddFDGData(key, additions);
                            }
                            if (!line.Contains("---")) line = fdgStream.ReadLine();
                        }
                        fdgStream.Close();
                        fdgStream.Dispose();
                    }
                    catch { }
                }
                Objects objs = new Objects();
                if (!fdgArchive.SceneList[fdgSceneList[fdgScn]].AssetList.Contains(objs.levelFDGs[fdgScn]) && fdg.clearing)
                {
                    fdgArchive.SceneList[fdgSceneList[fdgScn]].AssetList.Add(objs.levelFDGs[fdgScn]);
                }
                fdgArchive.Write(fdgFilePath);

                // Open and re-save the archive with 1.0 FDGH. It's a messy, unoptimized solution, but I'll clean it up later.
                fdgArchive2 = new KirbyFDGH.FDGH2(fdgFilePath);
                fdgArchive2.Write(fdgFilePath);

                Enabled = true;
            }
        }
        void AddFDGData(string key, List<string> additions)
        {
            Objects objs = new Objects();
            bool succeeded = false;

            // Every Specific Key Combination
            if (checkedThings.Contains(key))
            {
                succeeded = false;
            } else if ((key == "objects/Common" && level.Objects.Count > 0) || (key == "carriables/Common" && level.Carriables.Count > 0) || (key == "items/Common" && level.Items.Count > 0) || (key == "bosses/Common" && level.Bosses.Count > 0) || (key == "enemies/Common" && level.Objects.Count > 0) || (key == "Common"))
            {
                succeeded = true;
            } else if (key.StartsWith("objects/"))
            {
                if (objList.Items.Contains(key.Substring(8, key.Length - 8)))
                {
                    checkedThings.Add(key);
                    succeeded = true;
                }
            } else if (key.StartsWith("carriables/"))
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
            } else if (key.StartsWith("items/"))
            {
                if (key.Contains("_b."))
                {
                    for (int i = 0; i < level.Items.Count; i++)
                    {
                        if (key.Contains("[" + level.Items[i].Behavior + "]") && key.Contains(objs.ItemList[level.Items[i].Type]))
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
            } else if (key.StartsWith("bosses/"))
            {
                if (key.Contains("_l."))
                {
                    for (int i = 0; i < level.Bosses.Count; i++)
                    {
                        if (key.Contains("[" + level.Bosses[i].Param2 + "]") && key.Contains(objs.BossList[level.Bosses[i].Type]))
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
            } else if (key.StartsWith("enemies/"))
            {
                if (key.Contains("_l."))
                {
                    for (int i = 0; i < level.Enemies.Count; i++)
                    {
                        if (key.Contains("[" + level.Enemies[i].Param1 + "]") && key.Contains(objs.EnemyList[level.Enemies[i].Type]))
                        {
                            checkedThings.Add(key);
                            succeeded = true;
                        }
                    }
                } else if (key.Contains("_super"))
                {
                    for (int i = 0; i < level.Enemies.Count; i++)
                    {
                        if (level.Enemies[i].HasSuperAbility && key.Contains(objs.EnemyList[level.Enemies[i].Type]))
                        {
                            checkedThings.Add(key);
                            succeeded = true;
                        }
                    }
                } else if (enemyList.Items.Contains(key.Substring(8, key.Length - 8)))
                {
                    checkedThings.Add(key);
                    succeeded = true;
                }
            } else if (key.StartsWith("blocks/"))
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
            } else if (key.StartsWith("backgrounds/"))
            {
                if (key.Contains(objs.DecorationList[level.Background]))
                {
                    succeeded = true;
                }
            } else if (key.StartsWith("tilesets/"))
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
                    }
                    else if (!fdgArchive.SceneList[fdgSceneList[fdgScn]].AssetList.Contains(additions[i]))
                    {
                        fdgArchive.SceneList[fdgSceneList[fdgScn]].AssetList.Add(additions[i]);
                    }
                }
            }
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
                RefreshObjectLists();

                sizeH.Value = level.Height;
                sizeW.Value = level.Width;

                Text = $"MagoCrate - New Level";

                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                viewType.SelectedIndex = 0;
                viewType.Enabled = true;
                resetCamera.Enabled = true;
                vShape.Enabled = true;
                vBlock.Enabled = true;
                blockList.Enabled = true;

                a = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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

            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            viewType.SelectedIndex = 0;
            viewType.Enabled = true;
            resetCamera.Enabled = true;
            vShape.Enabled = true;
            vBlock.Enabled = true;
            blockList.Enabled = true;

            Cursor = Cursors.Arrow;
            Enabled = true;
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
            RefreshObjectLists();

            sizeH.Value = level.Height;
            sizeW.Value = level.Width;

            Text = $"MagoCrate - {filePath}";
            a = false;
        }

        private async void InstantLoadOpen()
        {
            if (filePath != null && filePath.Length > 0)
            {
                Enabled = false;
                instantLoad = false;

                await Task.Delay(10000);
                LoadLevel(instantFilePath);

                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                viewType.SelectedIndex = 0;
                viewType.Enabled = true;
                resetCamera.Enabled = true;
                vShape.Enabled = true;
                vBlock.Enabled = true;

                Cursor = Cursors.Arrow;
                Enabled = true;
                refreshing = true;
                await Task.Delay(1);
                refreshing = false;
            }
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

        private async void glControl_Load(object sender, EventArgs e)
        {
            glControl.MakeCurrent();
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.ClearColor(Color.FromArgb(200, 200, 200));

            renderer = new Renderer();
            texturing = new Texturing();
            camera = new Camera(new Vector2(0, 0), 1.1);

            if (instantLoad)
            {
                await Task.Delay(1000);
            }

            for (int i = 0; i < 52; i++)
            {
                texIds.Add(texturing.LoadTexture("Resources/tiles/" + i + ".png"));
            }
            texIds.Add(texturing.LoadTexture("Resources/tiles/select.png"));

            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/h0.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/h1.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/h2.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/h3.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/h4.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/h5.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/h6.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/h7.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/h8.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/h9.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/hA.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/hB.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/hC.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/hD.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/hE.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/hF.png"));
            hexTexIds.Add(texturing.LoadTexture("Resources/tiles/Hex/hBack.png"));

            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/ladder.png"));
            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/boundary.png"));
            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/water.png"));
            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/spike.png"));
            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/ice.png"));
            modTexIds.Add(texturing.LoadTexture("Resources/modifiers/lava.png"));

            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/mat_Grass.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/mat_Wood.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/mat_Stone.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/mat_Sand.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/mat_Snow.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/mat_Clouds.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/mat_Metal.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/auto_1.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/auto_2.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/auto_3.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/auto_-1.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/auto_-2.png"));
            propertyTexIds.Add(texturing.LoadTexture("Resources/properties/auto_-3.png"));

            entityTexIds.Add(texturing.LoadTexture("Resources/obj/object.png"));
            entityTexIds.Add(texturing.LoadTexture("Resources/obj/carriable.png"));
            entityTexIds.Add(texturing.LoadTexture("Resources/obj/item.png"));
            entityTexIds.Add(texturing.LoadTexture("Resources/obj/boss.png"));
            entityTexIds.Add(texturing.LoadTexture("Resources/obj/enemy.png"));
            entityTexIds.Add(texturing.LoadTexture("Resources/obj/select.png"));
            entityTexIds.Add(texturing.LoadTexture("Resources/obj/selectFull.png"));

            RefreshObjectSprites();
            UpdateSpriteOffsetDictionary();

            t = new System.Timers.Timer(1000.0 / 60.0);
            t.Elapsed += t_Elapsed;
            t.Start();

            if (instantLoad)
            {
                InstantLoadOpen();
            }
        }
        private void RefreshObjectSprites()
        {
            Objects objs = new Objects();
            Image img = Image.FromFile("Resources/tiles/0.png");

            objSprites.Clear();
            carrySprites.Clear();
            itemSprites.Clear();
            bossSprites.Clear();
            enemySprites.Clear();
            zoneTexIds.Clear();
            exceptionSprites.Clear();
            spriteDimensions.Clear();

            for (uint i = 0; i <= objs.ObjectList.Keys.Last(); i++)
            {
                if (objs.ObjectList.ContainsKey(i))
                {
                    if (File.Exists("Resources/obj/objects/" + objs.ObjectList[i] + ".png"))
                    {
                        img = Image.FromFile("Resources/obj/objects/" + objs.ObjectList[i] + ".png");
                        objSprites.Add(objs.ObjectList[i], img);
                        spriteDimensions.Add("objects/" + objs.ObjectList[i], new Vector2(img.Width, img.Height));
                    }
                }
            }

            for (uint i = 0; i <= objs.CarriablesList.Keys.Last(); i++)
            {
                if (objs.CarriablesList.ContainsKey(i))
                {
                    if (File.Exists("Resources/obj/carriables/" + objs.CarriablesList[i] + ".png"))
                    {
                        img = Image.FromFile("Resources/obj/carriables/" + objs.CarriablesList[i] + ".png");
                        carrySprites.Add(objs.CarriablesList[i], img);
                        spriteDimensions.Add("carriables/" + objs.CarriablesList[i], new Vector2(img.Width, img.Height));
                    }
                }
            }

            for (uint i = 0; i <= objs.ItemList.Keys.Last(); i++)
            {
                if (objs.ItemList.ContainsKey(i))
                {
                    if (File.Exists("Resources/obj/items/" + objs.ItemList[i] + ".png"))
                    {
                        img = Image.FromFile("Resources/obj/items/" + objs.ItemList[i] + ".png");
                        itemSprites.Add(objs.ItemList[i], Image.FromFile("Resources/obj/items/" + objs.ItemList[i] + ".png"));
                        spriteDimensions.Add("items/" + objs.ItemList[i], new Vector2(img.Width, img.Height));
                    }
                }
            }

            for (uint i = 0; i <= objs.BossList.Keys.Last(); i++)
            {
                if (objs.BossList.ContainsKey(i))
                {
                    if (File.Exists("Resources/obj/bosses/" + objs.BossList[i] + ".png"))
                    {
                        img = Image.FromFile("Resources/obj/bosses/" + objs.BossList[i] + ".png");
                        bossSprites.Add(objs.BossList[i], Image.FromFile("Resources/obj/bosses/" + objs.BossList[i] + ".png"));
                        spriteDimensions.Add("bosses/" + objs.BossList[i], new Vector2(img.Width, img.Height));
                    }
                }
            }

            for (uint i = 0; i <= objs.EnemyList.Keys.Last(); i++)
            {
                if (objs.EnemyList.ContainsKey(i))
                {
                    if (File.Exists("Resources/obj/enemies/" + objs.EnemyList[i] + ".png"))
                    {
                        img = Image.FromFile("Resources/obj/enemies/" + objs.EnemyList[i] + ".png");
                        enemySprites.Add(objs.EnemyList[i], Image.FromFile("Resources/obj/enemies/" + objs.EnemyList[i] + ".png"));
                        spriteDimensions.Add("enemies/" + objs.EnemyList[i], new Vector2(img.Width, img.Height));
                    }
                }
            }

            zoneTexIds.Add(texturing.LoadTexture("Resources/obj/objects/wind_zone.png"));
            zoneTexIds.Add(texturing.LoadTexture("Resources/obj/objects/trigger_zone.png"));
            zoneTexIds.Add(texturing.LoadTexture("Resources/obj/objects/bubble_zone.png"));
            zoneTexIds.Add(texturing.LoadTexture("Resources/obj/objects/super_zone.png"));

            img = Image.FromFile("Resources/obj/objects/Floating Cannon.png");
            spriteDimensions.Add("exceptions/Floating Cannon", new Vector2(img.Width, img.Height));
            exceptionSprites.Add("Floating Cannon.1", Image.FromFile("Resources/obj/objects/Floating Cannon.1.png"));
            exceptionSprites.Add("Floating Cannon.2", Image.FromFile("Resources/obj/objects/Floating Cannon.2.png"));
            exceptionSprites.Add("Floating Cannon.3", Image.FromFile("Resources/obj/objects/Floating Cannon.3.png"));
            exceptionSprites.Add("Floating Cannon.4", Image.FromFile("Resources/obj/objects/Floating Cannon.4.png"));
            exceptionSprites.Add("Floating Cannon.5", Image.FromFile("Resources/obj/objects/Floating Cannon.5.png"));
            exceptionSprites.Add("Floating Cannon.6", Image.FromFile("Resources/obj/objects/Floating Cannon.6.png"));
            exceptionSprites.Add("Floating Cannon.7", Image.FromFile("Resources/obj/objects/Floating Cannon.7.png"));
            exceptionSprites.Add("Floating Cannon Manual", Image.FromFile("Resources/obj/objects/Floating Cannon Manual.png"));
            exceptionSprites.Add("Floating Cannon Manual.1", Image.FromFile("Resources/obj/objects/Floating Cannon Manual.1.png"));
            exceptionSprites.Add("Floating Cannon Manual.2", Image.FromFile("Resources/obj/objects/Floating Cannon Manual.2.png"));
            exceptionSprites.Add("Floating Cannon Manual.3", Image.FromFile("Resources/obj/objects/Floating Cannon Manual.3.png"));
            exceptionSprites.Add("Floating Cannon Manual.4", Image.FromFile("Resources/obj/objects/Floating Cannon Manual.4.png"));
            exceptionSprites.Add("Floating Cannon Manual.5", Image.FromFile("Resources/obj/objects/Floating Cannon Manual.5.png"));
            exceptionSprites.Add("Floating Cannon Manual.6", Image.FromFile("Resources/obj/objects/Floating Cannon Manual.6.png"));

            img = Image.FromFile("Resources/obj/objects/Shutter Door Left.png");
            exceptionSprites.Add("Shutter Door Left", img);
            spriteDimensions.Add("exceptions/Shutter Door Left", new Vector2(img.Width, img.Height));

            img = Image.FromFile("Resources/obj/objects/Shutter Door Right.png");
            exceptionSprites.Add("Shutter Door Right", img);
            spriteDimensions.Add("exceptions/Shutter Door Right", new Vector2(img.Width, img.Height));

            img = Image.FromFile("Resources/obj/objects/Shutter Door Super.png");
            exceptionSprites.Add("Shutter Door Super", img);
            spriteDimensions.Add("exceptions/Shutter Door Super", new Vector2(img.Width, img.Height));

            img = Image.FromFile("Resources/obj/objects/Shutter Door Super Left.png");
            exceptionSprites.Add("Shutter Door Super Left", img);
            spriteDimensions.Add("exceptions/Shutter Door Super Left", new Vector2(img.Width, img.Height));

            img = Image.FromFile("Resources/obj/objects/Shutter Door Super Right.png");
            exceptionSprites.Add("Shutter Door Super Right", img);
            spriteDimensions.Add("exceptions/Shutter Door Super Right", new Vector2(img.Width, img.Height));

            img = Image.FromFile("Resources/obj/objects/Rope Platform.png");
            exceptionSprites.Add("Rope Platform", img);
            spriteDimensions.Add("exceptions/Rope Platform", new Vector2(img.Width, img.Height));
            img = Image.FromFile("Resources/obj/objects/Rope Platform Semisolid.png");
            exceptionSprites.Add("Rope Platform Semisolid", img);

            img = Image.FromFile("Resources/obj/objects/Rope Platform Long.png");
            exceptionSprites.Add("Rope Platform Long", img);
            spriteDimensions.Add("exceptions/Rope Platform Long", new Vector2(img.Width, img.Height));
            img = Image.FromFile("Resources/obj/objects/Rope Platform Semisolid Long.png");
            exceptionSprites.Add("Rope Platform Semisolid Long", img);
        }
        private void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            glControl.Invalidate();
            t.Start();
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.FromArgb(200, 200, 200));

            renderer.Begin(glControl.Width, glControl.Height);
            camera.Transform();

            if (level != null)
            {
                //Crop Tiles outside camera view.

                int tileStartX = 0;
                int tileEndX = (int)level.Width;
                int tileStartY = 0;
                int tileEndY = (int)level.Height;

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

                Vector2 vec_scale = new Vector2(1.0f, 1.0f);
                Vector2 hexTextOffset = new Vector2(8, 8);

                if (refreshing || !focused)
                {
                    tileStartX = 0;
                    tileStartY = 0;
                    tileEndX = 0;
                    tileEndY = 0;
                }

                //Collisions
                for (int ty = tileStartY; ty < tileEndY; ty++)
                {
                    for (int tx = tileStartX; tx < tileEndX; tx++)
                    {
                        int ix = ty * (int)level.Width + tx;
                        Collision c = level.TileCollision[ix];
                        Vector2 v = new Vector2(tx * 16f, -ty * 16f);
                        renderer.Draw(texIds[c.Shape], v, vec_scale, 17, 17);
                    }
                }

                //Blocks
                if (renderBlocksToolStripMenuItem.Checked && viewType.SelectedIndex == 0)
                {
                    for (int ty = tileStartY; ty < tileEndY; ty++)
                    {
                        for (int tx = tileStartX; tx < tileEndX; tx++)
                        {
                            Objects objs = new Objects();
                            int ix = ty * (int)level.Width + tx;
                            Block b = level.TileBlock[ix];
                            Vector2 v = new Vector2(tx * 16f, -ty * 16f);

                            if (b.ID != -1)
                            {
                                try
                                {
                                    Image img = Image.FromFile("Resources/blocks/Unknown.png");
                                    int w = Convert.ToInt32(img.Width * 1.015f);
                                    int h = Convert.ToInt32(img.Height * 1.015f);
                                    if (objs.blockIDs.ContainsKey(b.ID))
                                    {
                                        img = Image.FromFile("Resources/blocks/" + objs.blockIDs[b.ID] + ".png");
                                        w = (int)Math.Ceiling(img.Width * 1.015f);
                                        h = (int)Math.Ceiling(img.Height * 1.015f);
                                    }
                                    if (b.ID != 25)
                                        v -= new Vector2(0, (img.Height - 16));
                                    renderer.Draw(texturing.LoadTexture("Resources/blocks/" + objs.blockIDs[b.ID] + ".png"), v - new Vector2(0, 0f), vec_scale, w, h);
                                } catch { }
                            }
                        }
                    }
                }

                //Modifiers
                if (renderTileModifiersToolStripMenuItem.Checked)
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

                //Hex Values in Decoration View
                if (viewType.SelectedIndex != 0)
                {
                    for (int ty = tileStartY; ty < tileEndY; ty++)
                    {
                        for (int tx = tileStartX; tx < tileEndX; tx++)
                        {
                            //Draw Hex Block Backdrop
                            int ix = ty * (int)level.Width + tx;
                            Vector2 v = new Vector2(tx * 16f, -ty * 16f);
                            renderer.Draw(hexTexIds[16], v + new Vector2(0, 0), vec_scale, 17, 17);

                            Decoration deco = level.BLandDecoration[ix];
                            if (viewType.SelectedIndex == 2) deco = level.FLandDecoration[ix];
                            if (viewType.SelectedIndex == 3) deco = level.MLandDecoration[ix];

                            string hex = deco.Unk_1.ToString("X2") + deco.Unk_2.ToString("X2") + deco.Unk_3.ToString("X2") + deco.MovingTerrainID.ToString("X2");
                            if (hex != ("FFFF00FF"))
                            {
                                if (MagoCrate.Properties.Settings.Default.DecoViewIndex == 1)
                                {
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(0, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-6.75f, -1.75f), vec_scale * 0.8f, 4, 8);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(1, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-3f, -1.75f), vec_scale * 0.8f, 4, 8);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(2, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(1.5f, -1.75f), vec_scale * 0.8f, 4, 8);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(3, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(5.25f, -1.75f), vec_scale * 0.8f, 4, 8);
                                }
                                else if (MagoCrate.Properties.Settings.Default.DecoViewIndex == 2)
                                {
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(2, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(-5f, -4.25f), vec_scale * 0.8f, 6, 12);
                                    renderer.Draw(hexTexIds[int.Parse(hex.Substring(3, 1), System.Globalization.NumberStyles.HexNumber)], v + hexTextOffset + new Vector2(1f, -4.25f), vec_scale * 0.8f, 6, 12);
                                }
                                else
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
                            }
                        }
                    }
                }

                //Object Zones
                if (renderObjectPointsToolStripMenuItem.Checked && viewType.SelectedIndex == 0 && (objList.Items.Contains("Pushing Wind") || objList.Items.Contains("Trigger Area") || objList.Items.Contains("Pushing Bubbles") || objList.Items.Contains("Super Enemy Spawner")))
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
                        } catch { }
                    }
                }

                //Materials
                if (renderMaterialsToolStripMenuItem.Checked && viewType.SelectedIndex == 0)
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
                                if (t.Material < 16) //Grass
                                {
                                    renderer.Draw(propertyTexIds[0], v, vec_scale, 17, 17);
                                } else if (t.Material < 24) //Wood
                                {
                                    renderer.Draw(propertyTexIds[1], v, vec_scale, 17, 17);
                                }
                                else if (t.Material < 32) //Stone
                                {
                                    renderer.Draw(propertyTexIds[2], v, vec_scale, 17, 17);
                                }
                                else if (t.Material < 40) //Sand
                                {
                                    renderer.Draw(propertyTexIds[3], v, vec_scale, 17, 17);
                                }
                                else if (t.Material < 48) //Snow
                                {
                                    renderer.Draw(propertyTexIds[4], v, vec_scale, 17, 17);
                                }
                                else if (t.Material < 56) //Clouds
                                {
                                    renderer.Draw(propertyTexIds[5], v, vec_scale, 17, 17);
                                }
                                else //Metal
                                {
                                    renderer.Draw(propertyTexIds[6], v, vec_scale, 17, 17);
                                }
                            }
                        }
                    }
                }

                //Auto Movement
                if (renderAutoMovementToolStripMenuItem.Checked && viewType.SelectedIndex == 0)
                {
                    for (int ty = tileStartY; ty < tileEndY; ty++)
                    {
                        for (int tx = tileStartX; tx < tileEndX; tx++)
                        {

                            int ix = ty * (int)level.Width + tx;
                            Collision t = level.TileCollision[ix];
                            Vector2 v = new Vector2(tx * 16f, -ty * 16f);

                            if (t.AutoMoveSpeed > 0)
                            {
                                if (t.AutoMoveSpeed == 1)
                                {
                                    renderer.Draw(propertyTexIds[7], v, vec_scale, 17, 17);
                                } else if (t.AutoMoveSpeed == 2)
                                {
                                    renderer.Draw(propertyTexIds[8], v, vec_scale, 17, 17);
                                }
                                else
                                {
                                    renderer.Draw(propertyTexIds[9], v, vec_scale, 17, 17);
                                }
                            } else if (t.AutoMoveSpeed < 0)
                            {
                                if (t.AutoMoveSpeed == -1)
                                {
                                    renderer.Draw(propertyTexIds[10], v, vec_scale, 17, 17);
                                }
                                else if (t.AutoMoveSpeed == -2)
                                {
                                    renderer.Draw(propertyTexIds[11], v, vec_scale, 17, 17);
                                }
                                else
                                {
                                    renderer.Draw(propertyTexIds[12], v, vec_scale, 17, 17);
                                }
                            }
                        }
                    }
                }

                // Select Cursor
                if (true)
                {
                    Vector2 v = new Vector2(tileX * 16f, -tileY * 16f);
                    renderer.Draw(texIds[52], v, vec_scale, 17, 17);
                }

                float entRange = MagoCrate.Properties.Settings.Default.entityCullRange;

                if (renderObjectPointsToolStripMenuItem.Checked && !refreshing && viewType.SelectedIndex == 0)
                {
                    // Objects
                    for (int i = 0; i < level.Objects.Count; i++)
                    {
                        uint objType = level.Objects[i].Type;
                        if (useAvailableSpritesToolStripMenuItem.Checked)
                        {
                            // Create default values for 1x1 sized icons.
                            Vector2 v = new Vector2(((level.Objects[i].X * 16f) - 7.2f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f)) - (level.Objects[i].YOffset * 0.95f));
                            int w = 17;
                            int h = 17;

                            try
                            {

                                bool exceptionTexUsed = false;
                                string ObjTexPath = Directory.GetCurrentDirectory() + "\\Resources\\obj\\objects\\";
                                Objects objs = new Objects();

                                string name = objType.ToString();
                                if (objs.ObjectList.ContainsKey(objType))
                                {
                                    name = objs.ObjectList[objType];
                                }

                                if (level.Objects[i].X > tileStartX - entRange && level.Objects[i].Y > tileStartY - entRange && level.Objects[i].X < tileEndX + entRange && level.Objects[i].Y < tileEndY + entRange)
                                {
                                    // Rope Platform
                                    if (objType == 10)
                                    {
                                        string prm7 = level.Objects[i].Param7.ToString("X8");
                                        string solidType = "";
                                        string lengthType = "";
                                        if (prm7.Substring(7, 1) == "1")
                                        {
                                            solidType = " Semisolid";
                                            exceptionTexUsed = true;
                                        }

                                        if (prm7.Substring(1, 1) == "1")
                                        {
                                            lengthType = " Long";
                                            exceptionTexUsed = true;
                                        }
                                        if (exceptionTexUsed)
                                        {
                                            Vector2 dim = spriteDimensions["exceptions/" + name + lengthType];
                                            v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                            w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                            h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                            v += SpriteOffset("objects/" + name);

                                            // Render same-sized select texture before rendering the main texture
                                            if (i == objList.SelectedIndex)
                                            {
                                                renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                            }
                                            renderer.Draw(texturing.LoadTexture(ObjTexPath + name + solidType + lengthType + ".png"), v, new Vector2(1f, 1f), w, h);
                                        }
                                    }

                                    //Floating Cannon Rotation and Type
                                    if (objType == 19)
                                    {
                                        string prm6 = level.Objects[i].Param6.ToString("X8");
                                        string prm7 = level.Objects[i].Param7.ToString("X8");
                                        string rotType = "";
                                        string cannonType = "";
                                        if (prm6.Substring(3, 1) == "1" || prm6.Substring(3, 1) == "2" || prm6.Substring(3, 1) == "3" || prm6.Substring(3, 1) == "4" || prm6.Substring(3, 1) == "5" || prm6.Substring(3, 1) == "6" || prm6.Substring(3, 1) == "7")
                                        {
                                            rotType = "." + prm6.Substring(3, 1);
                                            exceptionTexUsed = true;
                                        }
                                        
                                        if (prm7.Substring(3, 1) == "1")
                                        {
                                            cannonType = " Manual";
                                            exceptionTexUsed = true;
                                        }
                                        if (exceptionTexUsed)
                                        {
                                            Vector2 dim = spriteDimensions["exceptions/" + name];
                                            v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                            w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                            h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                            v += SpriteOffset("objects/" + name);

                                            // Render same-sized select texture before rendering the main texture
                                            if (i == objList.SelectedIndex)
                                            {
                                                renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                            }
                                            renderer.Draw(texturing.LoadTexture(ObjTexPath + name + cannonType + rotType + ".png"), v, new Vector2(1f, 1f), w, h);
                                        }
                                    }

                                    // Shutter Doors
                                    else if (objType == 30)
                                    {
                                        string prm6 = level.Objects[i].Param6.ToString("X8");
                                        string directionType = "";
                                        string sizeType = "";
                                        if (prm6.Substring(3, 1) == "1")
                                        {
                                            directionType = " Right";
                                            exceptionTexUsed = true;
                                        }
                                        else if (prm6.Substring(3, 1) == "2")
                                        {
                                            directionType = " Left";
                                            exceptionTexUsed = true;
                                        }

                                        if (prm6.Substring(5, 1) == "1")
                                        {
                                            sizeType = " Super";
                                            exceptionTexUsed = true;
                                        }

                                        if (exceptionTexUsed)
                                        {
                                            Vector2 dim = spriteDimensions["exceptions/" + name + sizeType + directionType];
                                            v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                            w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                            h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                            v += SpriteOffset("objects/" + name + sizeType + directionType);

                                            // Render same-sized select texture before rendering the main texture
                                            if (i == objList.SelectedIndex)
                                            {
                                                renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                            }
                                            renderer.Draw(texturing.LoadTexture(ObjTexPath + name + sizeType + directionType + ".png"), v, new Vector2(1f, 1f), w, h);
                                        }
                                    }

                                    if (!exceptionTexUsed)
                                    {
                                        if (complexObjSprites.ContainsKey(name + "_p6." + level.Objects[i].Param6))
                                        {
                                            Vector2 dim = complexSpriteDimensions["objects/" + name + "_p6." + level.Objects[i].Param6];
                                            v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                            w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                            h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                            if (spriteOffsets.ContainsKey("objects/" + name + "_p6." + level.Objects[i].Param6))
                                            {
                                                v += SpriteOffset("objects/" + name + "_p6." + level.Objects[i].Param6);
                                            }
                                            else v += SpriteOffset("objects/" + name);

                                            // Render same-sized select texture before rendering the main texture
                                            if (i == objList.SelectedIndex)
                                            {
                                                renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                            }
                                            renderer.Draw(texturing.LoadTexture(ObjTexPath + name + "_p6." + level.Objects[i].Param6 + ".png"), v, new Vector2(1f, 1f), w, h);
                                        }
                                        else if (objSprites.ContainsKey(objs.ObjectList[level.Objects[i].Type]))
                                        {
                                            Vector2 dim = spriteDimensions["objects/" + name];
                                            v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                            w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                            h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                            v += SpriteOffset("objects/" + name);

                                            // Render same-sized select texture before rendering the main texture
                                            if (i == objList.SelectedIndex)
                                            {
                                                renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                            }
                                            renderer.Draw(texturing.LoadTexture(ObjTexPath + name + ".png"), v, new Vector2(1f, 1f), w, h);
                                        }
                                        else
                                        {
                                            // Draw Regular Texture if previous file checks fail.
                                            if (MagoCrate.Properties.Settings.Default.rtmColorsON) renderer.Draw(entityTexIds[2], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                            else renderer.Draw(entityTexIds[0], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                            if (i == objList.SelectedIndex)
                                            {
                                                renderer.Draw(entityTexIds[5], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                            }
                                        }
                                    }
                                } else
                                {
                                    if (MagoCrate.Properties.Settings.Default.rtmColorsON) renderer.Draw(entityTexIds[2], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                    else renderer.Draw(entityTexIds[0], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                    if (i == objList.SelectedIndex)
                                    {
                                        renderer.Draw(entityTexIds[5], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                    }
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            try
                            {
                                // Draw Regular Texture if previous file checks fail.
                                if (MagoCrate.Properties.Settings.Default.rtmColorsON) renderer.Draw(entityTexIds[2], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                else renderer.Draw(entityTexIds[0], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                if (i == objList.SelectedIndex)
                                {
                                    renderer.Draw(entityTexIds[5], new Vector2(((level.Objects[i].X * 16f) - 3f) + (level.Objects[i].XOffset * 0.95f), ((-level.Objects[i].Y * 16f) + 13f) - (level.Objects[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                }
                            }
                            catch { }
                        }
                    }

                    // Carriables
                    for (int i = 0; i < level.Carriables.Count; i++)
                    {
                        uint carryType = level.Carriables[i].Type;
                        if (useAvailableSpritesToolStripMenuItem.Checked && (level.Carriables[i].X > tileStartX - entRange && level.Carriables[i].Y > tileStartY - entRange && level.Carriables[i].X < tileEndX + entRange && level.Carriables[i].Y < tileEndY + entRange))
                        {
                            // Create default values for 1x1 sized icons.
                            Vector2 v = new Vector2(((level.Carriables[i].X * 16f) - 7.2f) + (level.Carriables[i].XOffset * 0.95f), ((-level.Carriables[i].Y * 16f)) - (level.Carriables[i].YOffset * 0.95f));
                            int w = 17;
                            int h = 17;

                            try
                            {
                                bool exceptionTexUsed = false;

                                if (!exceptionTexUsed)
                                {
                                    Objects objs = new Objects();

                                    string name = carryType.ToString();
                                    if (objs.CarriablesList.ContainsKey(carryType))
                                    {
                                        name = objs.CarriablesList[carryType];
                                    }
                                    string CarryTexPath = Directory.GetCurrentDirectory() + "\\Resources\\obj\\carriables\\";

                                    if (complexCarrySprites.ContainsKey(name + "_a." + level.Carriables[i].AppearID))
                                    {
                                        Vector2 dim = complexSpriteDimensions["carriables/" + name + "_a." + level.Carriables[i].AppearID];
                                        v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                        w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                        h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                        v += SpriteOffset("carriables/" + name);

                                        // Render same-sized select texture before rendering the main texture
                                        if (i == carriablesList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                        }
                                        renderer.Draw(texturing.LoadTexture(CarryTexPath + name + "_a." + level.Carriables[i].AppearID + ".png"), v, new Vector2(1f, 1f), w, h);
                                    }
                                    else if(carrySprites.ContainsKey(name))
                                    {
                                        Vector2 dim = spriteDimensions["carriables/" + name];
                                        v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                        w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                        h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                        v += SpriteOffset("carriables/" + name);

                                        // Render same-sized select texture before rendering the main texture
                                        if (i == carriablesList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                        }
                                        renderer.Draw(texturing.LoadTexture(CarryTexPath + name + ".png"), v, new Vector2(1f, 1f), w, h);
                                    }
                                    else
                                    {
                                        // Draw Regular Texture if previous file checks fail.
                                        if (MagoCrate.Properties.Settings.Default.rtmColorsON) renderer.Draw(entityTexIds[0], new Vector2(((level.Carriables[i].X * 16f) - 3f) + (level.Carriables[i].XOffset * 0.95f), ((-level.Carriables[i].Y * 16f) + 13f) - (level.Carriables[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                        else renderer.Draw(entityTexIds[1], new Vector2(((level.Carriables[i].X * 16f) - 3f) + (level.Carriables[i].XOffset * 0.95f), ((-level.Carriables[i].Y * 16f) + 13f) - (level.Carriables[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                        if (i == carriablesList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[5], new Vector2(((level.Carriables[i].X * 16f) - 3f) + (level.Carriables[i].XOffset * 0.95f), ((-level.Carriables[i].Y * 16f) + 13f) - (level.Carriables[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                        }
                                    }
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            try
                            {
                                // Draw Regular Texture if previous file checks fail.
                                if (MagoCrate.Properties.Settings.Default.rtmColorsON) renderer.Draw(entityTexIds[0], new Vector2(((level.Carriables[i].X * 16f) - 3f) + (level.Carriables[i].XOffset * 0.95f), ((-level.Carriables[i].Y * 16f) + 13f) - (level.Carriables[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                else renderer.Draw(entityTexIds[1], new Vector2(((level.Carriables[i].X * 16f) - 3f) + (level.Carriables[i].XOffset * 0.95f), ((-level.Carriables[i].Y * 16f) + 13f) - (level.Carriables[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                if (i == carriablesList.SelectedIndex)
                                {
                                    renderer.Draw(entityTexIds[5], new Vector2(((level.Carriables[i].X * 16f) - 3f) + (level.Carriables[i].XOffset * 0.95f), ((-level.Carriables[i].Y * 16f) + 13f) - (level.Carriables[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                }
                            }
                            catch { }
                        }
                    }

                    // Items
                    for (int i = 0; i < level.Items.Count; i++)
                    {
                        uint itemType = level.Items[i].Type;
                        if (useAvailableSpritesToolStripMenuItem.Checked && (level.Items[i].X > tileStartX - entRange && level.Items[i].Y > tileStartY - entRange && level.Items[i].X < tileEndX + entRange && level.Items[i].Y < tileEndY + entRange))
                        {
                            // Create default values for 1x1 sized icons.
                            Vector2 v = new Vector2(((level.Items[i].X * 16f) - 7.2f) + (level.Items[i].XOffset * 0.95f), ((-level.Items[i].Y * 16f)) - (level.Items[i].YOffset * 0.95f));
                            int w = 17;
                            int h = 17;

                            try
                            {
                                bool exceptionTexUsed = false;

                                if (!exceptionTexUsed)
                                {
                                    Objects objs = new Objects();

                                    string name = itemType.ToString();
                                    if (objs.ItemList.ContainsKey(itemType))
                                    {
                                        name = objs.ItemList[itemType];
                                    }
                                    string ItemTexPath = Directory.GetCurrentDirectory() + "\\Resources\\obj\\items\\";

                                    if (complexItemSprites.ContainsKey(name + "_b." + level.Items[i].Behavior))
                                    {
                                        Vector2 dim = complexSpriteDimensions["items/" + name + "_b." + level.Items[i].Behavior];
                                        v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                        w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                        h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                        v += SpriteOffset("items/" + name);

                                        // Render same-sized select texture before rendering the main texture
                                        if (i == itemList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                        }
                                        renderer.Draw(texturing.LoadTexture(ItemTexPath + name + "_b." + level.Items[i].Behavior + ".png"), v, new Vector2(1f, 1f), w, h);
                                    }
                                    else if (itemSprites.ContainsKey(objs.ItemList[level.Items[i].Type]))
                                    {
                                        Vector2 dim = spriteDimensions["items/" + name];
                                        v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                        w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                        h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                        v += SpriteOffset("items/" + name);

                                        // Render same-sized select texture before rendering the main texture
                                        if (i == itemList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                        }
                                        renderer.Draw(texturing.LoadTexture(ItemTexPath + name + ".png"), v, new Vector2(1f, 1f), w, h);
                                    }
                                    else
                                    {
                                        // Draw Regular Texture if previous file checks fail.
                                        if (MagoCrate.Properties.Settings.Default.rtmColorsON) renderer.Draw(entityTexIds[1], new Vector2(((level.Items[i].X * 16f) - 3f) + (level.Items[i].XOffset * 0.95f), ((-level.Items[i].Y * 16f) + 13f) - (level.Items[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                        else renderer.Draw(entityTexIds[2], new Vector2(((level.Items[i].X * 16f) - 3f) + (level.Items[i].XOffset * 0.95f), ((-level.Items[i].Y * 16f) + 13f) - (level.Items[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                        if (i == itemList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[5], new Vector2(((level.Items[i].X * 16f) - 3f) + (level.Items[i].XOffset * 0.95f), ((-level.Items[i].Y * 16f) + 13f) - (level.Items[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                        }
                                    }
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            try
                            {
                                // Draw Regular Texture if previous file checks fail.
                                if (MagoCrate.Properties.Settings.Default.rtmColorsON) renderer.Draw(entityTexIds[1], new Vector2(((level.Items[i].X * 16f) - 3f) + (level.Items[i].XOffset * 0.95f), ((-level.Items[i].Y * 16f) + 13f) - (level.Items[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                else renderer.Draw(entityTexIds[2], new Vector2(((level.Items[i].X * 16f) - 3f) + (level.Items[i].XOffset * 0.95f), ((-level.Items[i].Y * 16f) + 13f) - (level.Items[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                if (i == itemList.SelectedIndex)
                                {
                                    renderer.Draw(entityTexIds[5], new Vector2(((level.Items[i].X * 16f) - 3f) + (level.Items[i].XOffset * 0.95f), ((-level.Items[i].Y * 16f) + 13f) - (level.Items[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                }
                            }
                            catch { }
                        }
                    }

                    // Bosses
                    for (int i = 0; i < level.Bosses.Count; i++)
                    {
                        uint bossType = level.Bosses[i].Type;
                        if (useAvailableSpritesToolStripMenuItem.Checked && (level.Bosses[i].X > tileStartX - entRange && level.Bosses[i].Y > tileStartY - entRange && level.Bosses[i].X < tileEndX + entRange && level.Bosses[i].Y < tileEndY + entRange))
                        {
                            // Create default values for 1x1 sized icons.
                            Vector2 v = new Vector2(((level.Bosses[i].X * 16f) - 7.2f) + (level.Bosses[i].XOffset * 0.95f), ((-level.Bosses[i].Y * 16f)) - (level.Bosses[i].YOffset * 0.95f));
                            int w = 17;
                            int h = 17;

                            try
                            {
                                bool exceptionTexUsed = false;
                                if (bossType == 0 && level.Bosses[i].Param1 == 11)
                                {
                                    if (File.Exists(Directory.GetCurrentDirectory() + "\\Resources\\obj\\bosses\\HRD3 Handler.png"))
                                    {
                                        exceptionTexUsed = true;
                                        renderer.Draw(texturing.LoadTexture(Directory.GetCurrentDirectory() + "\\Resources\\obj\\bosses\\HRD3 Handler.png"), v, new Vector2(1f, 1f), w, h);
                                    }
                                }

                                if (!exceptionTexUsed)
                                {
                                    Objects objs = new Objects();
                                    string name = level.Bosses[i].Type.ToString();
                                    if (objs.BossList.ContainsKey(bossType))
                                    {
                                        name = objs.BossList[bossType];
                                    }

                                    string BossTexPath = Directory.GetCurrentDirectory() + "\\Resources\\obj\\bosses\\";
                                    if (complexBossSprites.ContainsKey(name + "_l." + level.Bosses[i].Param2))
                                    {
                                        // Parameter 2 Specific Textures
                                        Vector2 dim = complexSpriteDimensions["bosses/" + name + "_l." + level.Bosses[i].Param2];
                                        v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                        w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                        h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                        v += SpriteOffset("bosses/" + name);

                                        // Render same-sized select texture before rendering the main texture
                                        if (i == bossList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                        }
                                        renderer.Draw(texturing.LoadTexture(BossTexPath + name + "_l." + level.Bosses[i].Param2 + ".png"), v, new Vector2(1f, 1f), w, h);
                                    }
                                    else if (bossSprites.ContainsKey(name))
                                    {
                                        Vector2 dim = spriteDimensions["bosses/" + name];
                                        v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                        w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                        h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                        v += SpriteOffset("bosses/" + name);

                                        // Render same-sized select texture before rendering the main texture
                                        if (i == bossList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                        }
                                        renderer.Draw(texturing.LoadTexture(BossTexPath + name + ".png"), v, new Vector2(1f, 1f), w, h);
                                    }
                                    else
                                    {
                                        // Draw Regular Texture if previous file checks fail.
                                        renderer.Draw(entityTexIds[3], new Vector2(((level.Bosses[i].X * 16f) - 3f) + (level.Bosses[i].XOffset * 0.95f), ((-level.Bosses[i].Y * 16f) + 13f) - (level.Bosses[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                        if (i == bossList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[5], new Vector2(((level.Bosses[i].X * 16f) - 3f) + (level.Bosses[i].XOffset * 0.95f), ((-level.Bosses[i].Y * 16f) + 13f) - (level.Bosses[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                        }
                                    }
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            try
                            {
                                renderer.Draw(entityTexIds[3], new Vector2(((level.Bosses[i].X * 16f) - 3f) + (level.Bosses[i].XOffset * 0.95f), ((-level.Bosses[i].Y * 16f) + 13f) - (level.Bosses[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                if (i == bossList.SelectedIndex)
                                {
                                    renderer.Draw(entityTexIds[5], new Vector2(((level.Bosses[i].X * 16f) - 3f) + (level.Bosses[i].XOffset * 0.95f), ((-level.Bosses[i].Y * 16f) + 13f) - (level.Bosses[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                }
                            }
                            catch { }
                        }
                    }

                    // Enemies
                    for (int i = 0; i < level.Enemies.Count; i++)
                    {
                        int enemyType = Convert.ToInt32(level.Enemies[i].Type);
                        if (useAvailableSpritesToolStripMenuItem.Checked && (level.Enemies[i].X > tileStartX - entRange && level.Enemies[i].Y > tileStartY - entRange && level.Enemies[i].X < tileEndX + entRange && level.Enemies[i].Y < tileEndY + entRange))
                        {
                            // Create default values for 1x1 sized icons.
                            Vector2 v = new Vector2(((level.Enemies[i].X * 16f) - 7.2f) + (level.Enemies[i].XOffset * 0.95f), ((-level.Enemies[i].Y * 16f)) - (level.Enemies[i].YOffset * 0.95f));
                            int w = 17;
                            int h = 17;

                            try
                            {
                                bool exceptionTexUsed = false;

                                if (!exceptionTexUsed)
                                {
                                    Objects objs = new Objects();
                                    string name = level.Enemies[i].Type.ToString();
                                    if (objs.EnemyList.ContainsKey(level.Enemies[i].Type))
                                    {
                                        name = objs.EnemyList[level.Enemies[i].Type];
                                    }
                                    string enemyTexPath = Directory.GetCurrentDirectory() + "\\Resources\\obj\\enemies\\";

                                    if (complexEnemySprites.ContainsKey(name + "_l." + level.Enemies[i].Param1))
                                    {
                                        // Parameter 1 Specific Textures
                                        Vector2 dim = complexSpriteDimensions["enemies/" + name + "_l." + level.Enemies[i].Param1];
                                        v += new Vector2((dim.X - optionsPixelPerTile) * -0.4125f, 2 * (dim.Y - optionsPixelPerTile) * -0.4125f);
                                        w = Convert.ToInt32(Math.Round(dim.X * (0.825)));
                                        h = Convert.ToInt32(Math.Round(dim.Y * (0.825)));

                                        v += SpriteOffset("enemies/" + name);

                                        // Render same-sized select texture before rendering the main texture
                                        if (i == enemyList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                        }
                                        renderer.Draw(texturing.LoadTexture(enemyTexPath + name + "_l." + level.Enemies[i].Param1 + ".png"), v, new Vector2(1f, 1f), w, h);
                                    }
                                    else if (enemySprites.ContainsKey(name))
                                    {
                                        Image img = enemySprites[name];
                                        v += new Vector2((img.Width - optionsPixelPerTile) * -0.4125f, 2 * (img.Height - optionsPixelPerTile) * -0.4125f);
                                        w = Convert.ToInt32(Math.Round(img.Width * (0.825)));
                                        h = Convert.ToInt32(Math.Round(img.Height * (0.825)));

                                        v += SpriteOffset("enemies/" + name);

                                        // Render same-sized select texture before rendering the main texture
                                        if (i == enemyList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[6], v, new Vector2(1f, 1f), w, h);
                                        }
                                        renderer.Draw(texturing.LoadTexture(enemyTexPath + name + ".png"), v, new Vector2(1f, 1f), w, h);
                                    }
                                    else
                                    {
                                        renderer.Draw(entityTexIds[4], new Vector2(((level.Enemies[i].X * 16f) - 3f) + (level.Enemies[i].XOffset * 0.95f), ((-level.Enemies[i].Y * 16f) + 13f) - (level.Enemies[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                        if (i == enemyList.SelectedIndex)
                                        {
                                            renderer.Draw(entityTexIds[5], new Vector2(((level.Enemies[i].X * 16f) - 3f) + (level.Enemies[i].XOffset * 0.95f), ((-level.Enemies[i].Y * 16f) + 13f) - (level.Enemies[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                        }
                                    }
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            try
                            {
                                renderer.Draw(entityTexIds[4], new Vector2(((level.Enemies[i].X * 16f) - 3f) + (level.Enemies[i].XOffset * 0.95f), ((-level.Enemies[i].Y * 16f) + 13f) - (level.Enemies[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                if (i == enemyList.SelectedIndex)
                                {
                                    renderer.Draw(entityTexIds[5], new Vector2(((level.Enemies[i].X * 16f) - 3f) + (level.Enemies[i].XOffset * 0.95f), ((-level.Enemies[i].Y * 16f) + 13f) - (level.Enemies[i].YOffset * 0.95f)), new Vector2(1f, 1f), 7, 7);
                                }
                            }
                            catch { }
                        }
                    }
                }
            }
            glControl.SwapBuffers();
        }
        
        private void glControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                moveCam = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (tool == 0)
                {
                    // Draw

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

                    if (editCol.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        c.Shape = (byte)vShape.Value;
                        level.TileCollision[ix] = c;
                    }
                    if (editModf.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        c.Modifier = 0;
                        if (ladder.Checked) c.Modifier += 2;
                        if (boundary.Checked) c.Modifier += 4;
                        if (water.Checked) c.Modifier += 8;
                        if (spike.Checked) c.Modifier += 16;
                        if (ice.Checked) c.Modifier += 32;
                        if (lava.Checked) c.Modifier += 64;
                        level.TileCollision[ix] = c;
                    }
                    if (editMat.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        c.Material = (byte)vmat.Value;
                        level.TileCollision[ix] = c;
                    }
                    if (editAutoMove.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        c.AutoMoveSpeed = (sbyte)vautomove.Value;
                        level.TileCollision[ix] = c;
                    }
                    if (editBlock.Checked)
                    {
                        Block b = level.TileBlock[ix];
                        b.ID = (short)vBlock.Value;
                        level.TileBlock[ix] = b;
                    }
                    if (editBLand.Checked)
                    {
                        Decoration bl = level.BLandDecoration[ix];
                        bl.Unk_1 = (byte)d1_1.Value;
                        bl.Unk_2 = (byte)d1_2.Value;
                        bl.Unk_3 = (byte)d1_3.Value;
                        bl.MovingTerrainID = (sbyte)d1_4.Value;
                        level.BLandDecoration[ix] = bl;
                    }
                    if (editFLand.Checked)
                    {
                        Decoration ml = level.MLandDecoration[ix];
                        ml.Unk_1 = (byte)d2_1.Value;
                        ml.Unk_2 = (byte)d2_2.Value;
                        ml.Unk_3 = (byte)d2_3.Value;
                        ml.MovingTerrainID = (sbyte)d2_4.Value;
                        level.MLandDecoration[ix] = ml;
                    }
                    if (editMLand.Checked)
                    {
                        Decoration fl = level.FLandDecoration[ix];
                        fl.Unk_1 = (byte)d3_1.Value;
                        fl.Unk_2 = (byte)d3_2.Value;
                        fl.Unk_3 = (byte)d3_3.Value;
                        fl.MovingTerrainID = (sbyte)d3_4.Value;
                        level.FLandDecoration[ix] = fl;
                    }
                }
                else if (tool == 1)
                {
                    // Pick

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
                    Collision c = level.TileCollision[ix];
                    Block b = level.TileBlock[ix];
                    Decoration ml = level.MLandDecoration[ix];
                    Decoration bl = level.BLandDecoration[ix];
                    Decoration fl = level.FLandDecoration[ix];

                    vShape.Value = c.Shape;
                    if ((c.Modifier & (1 << 1)) != 0)
                    {
                        ladder.Checked = true;
                    }
                    else { ladder.Checked = false; }

                    if ((c.Modifier & (1 << 2)) != 0)
                    {
                        boundary.Checked = true;
                    }
                    else { boundary.Checked = false; }

                    if ((c.Modifier & (1 << 3)) != 0)
                    {
                        water.Checked = true;
                    }
                    else { water.Checked = false; }

                    if ((c.Modifier & (1 << 4)) != 0)
                    {
                        spike.Checked = true;
                    }
                    else { spike.Checked = false; }

                    if ((c.Modifier & (1 << 5)) != 0)
                    {
                        ice.Checked = true;
                    }
                    else { ice.Checked = false; }

                    if ((c.Modifier & (1 << 6)) != 0)
                    {
                        lava.Checked = true;
                    }
                    else { lava.Checked = false; }

                    vmat.Value = c.Material;
                    vautomove.Value = c.AutoMoveSpeed;

                    vBlock.Value = b.ID;

                    d1_1.Value = bl.Unk_1;
                    d1_2.Value = bl.Unk_2;
                    d1_3.Value = bl.Unk_3;
                    d1_4.Value = bl.MovingTerrainID;

                    d2_1.Value = ml.Unk_1;
                    d2_2.Value = ml.Unk_2;
                    d2_3.Value = ml.Unk_3;
                    d2_4.Value = ml.MovingTerrainID;

                    d3_1.Value = fl.Unk_1;
                    d3_2.Value = fl.Unk_2;
                    d3_3.Value = fl.Unk_3;
                    d3_4.Value = fl.MovingTerrainID;

                    d1_hex.Text = ((byte)d1_1.Value).ToString("X2") + ((byte)d1_2.Value).ToString("X2") + ((byte)d1_3.Value).ToString("X2") + ((sbyte)d1_4.Value).ToString("X2");
                    d2_hex.Text = ((byte)d2_1.Value).ToString("X2") + ((byte)d2_2.Value).ToString("X2") + ((byte)d2_3.Value).ToString("X2") + ((sbyte)d2_4.Value).ToString("X2");
                    d3_hex.Text = ((byte)d3_1.Value).ToString("X2") + ((byte)d3_2.Value).ToString("X2") + ((byte)d3_3.Value).ToString("X2") + ((sbyte)d3_4.Value).ToString("X2");
                }
                else if (tool == 2)
                {
                    // Move

                    bool clickedEntity = false;
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


                    if (!clickedEntity)
                    {
                        for (int i = 0; i < level.Objects.Count; i++)
                        {
                            if (level.Objects[i].X == tileX && level.Objects[i].Y == tileY && objList.SelectedIndex != i)
                            {
                                clickedEntity = true;
                                tabControl1.SelectedIndex = 0;
                                objList.SelectedIndex = i;
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
                                enemyList.SelectedIndex = i;
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
            }

            if (e.Button == MouseButtons.Right)
            {
                float moveSpeed = 1.0f/(float)camera.zoom;
                camera.pos.X += (mouseX - e.X) * moveSpeed;
                camera.pos.Y += (mouseY - e.Y) * moveSpeed;
                mouseX = e.X;
                mouseY = e.Y;
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (tool == 0)
                {
                    int ix = (int)((tileY * level.Width) + tileX);

                    if (editCol.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        c.Shape = (byte)vShape.Value;
                        level.TileCollision[ix] = c;
                    }
                    if (editModf.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        c.Modifier = 0;
                        if (ladder.Checked) c.Modifier += 2;
                        if (boundary.Checked) c.Modifier += 4;
                        if (water.Checked) c.Modifier += 8;
                        if (spike.Checked) c.Modifier += 16;
                        if (ice.Checked) c.Modifier += 32;
                        if (lava.Checked) c.Modifier += 64;
                        level.TileCollision[ix] = c;
                    }
                    if (editMat.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        c.Material = (byte)vmat.Value;
                        level.TileCollision[ix] = c;
                    }
                    if (editAutoMove.Checked)
                    {
                        Collision c = level.TileCollision[ix];
                        c.AutoMoveSpeed = (sbyte)vautomove.Value;
                        level.TileCollision[ix] = c;
                    }
                    if (editBlock.Checked)
                    {
                        Block b = level.TileBlock[ix];
                        b.ID = (short)vBlock.Value;
                        level.TileBlock[ix] = b;
                    }
                    if (editBLand.Checked)
                    {
                        Decoration bl = level.BLandDecoration[ix];
                        bl.Unk_1 = (byte)d1_1.Value;
                        bl.Unk_2 = (byte)d1_2.Value;
                        bl.Unk_3 = (byte)d1_3.Value;
                        bl.MovingTerrainID = (sbyte)d1_4.Value;
                        level.BLandDecoration[ix] = bl;
                    }
                    if (editFLand.Checked)
                    {
                        Decoration ml = level.MLandDecoration[ix];
                        ml.Unk_1 = (byte)d2_1.Value;
                        ml.Unk_2 = (byte)d2_2.Value;
                        ml.Unk_3 = (byte)d2_3.Value;
                        ml.MovingTerrainID = (sbyte)d2_4.Value;
                        level.MLandDecoration[ix] = ml;
                    }
                    if (editMLand.Checked)
                    {
                        Decoration fl = level.FLandDecoration[ix];
                        fl.Unk_1 = (byte)d3_1.Value;
                        fl.Unk_2 = (byte)d3_2.Value;
                        fl.Unk_3 = (byte)d3_3.Value;
                        fl.MovingTerrainID = (sbyte)d3_4.Value;
                        level.FLandDecoration[ix] = fl;
                    }
                }
            }
        }

        private void glControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
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
            tool = 0;
            draw.Enabled = false;
            pick.Enabled = true;
            move.Enabled = true;
        }
        private void pick_Click(object sender, EventArgs e)
        {
            tool = 1;
            draw.Enabled = true;
            pick.Enabled = false;
            move.Enabled = true;
        }
        private void move_Click(object sender, EventArgs e)
        {
            tool = 2;
            draw.Enabled = true;
            pick.Enabled = true;
            move.Enabled = false;
        }

        private void resetCamera_Click(object sender, EventArgs e)
        {
            camera.zoom = 1.1;
            //Move Camera into Level Bounds
            camera.pos.X = Math.Max(0, Math.Min(level.Width*15 , camera.pos.X));
            camera.pos.Y = Math.Max(-level.Height*15, Math.Min(0, camera.pos.Y));
        }

        private void UpdateLevelSize(object sender, EventArgs e)
        {
            if (!a)
            {
                Collision c = new Collision();
                Block b = new Block();
                Decoration d = new Decoration();
                b.ID = -1;
                d.Unk_1 = 255;
                d.Unk_2 = 255;
                d.Unk_3 = 0;
                d.MovingTerrainID = -1;

                if (sizeW.Value > level.Width)
                {
                    for (int h = 0; h < sizeH.Value; h++)
                    {
                        level.TileCollision.Insert(((h * (int)level.Width) + (int)level.Width) + h, c);
                        level.TileBlock.Insert(((h * (int)level.Width) + (int)level.Width) + h, b);
                        level.BLandDecoration.Insert(((h * (int)level.Width) + (int)level.Width) + h, d);
                        level.MLandDecoration.Insert(((h * (int)level.Width) + (int)level.Width) + h, d);
                        level.FLandDecoration.Insert(((h * (int)level.Width) + (int)level.Width) + h, d);
                    }
                    level.Width = (uint)sizeW.Value;
                }
                else if (sizeW.Value < level.Width)
                {
                    for (int h = 0; h < sizeH.Value - 1; h++)
                    {
                        level.TileCollision.RemoveAt(((h * (int)level.Width) + (int)level.Width) - h);
                        level.TileBlock.RemoveAt(((h * (int)level.Width) + (int)level.Width) - h);
                        level.BLandDecoration.RemoveAt(((h * (int)level.Width) + (int)level.Width) - h);
                        level.MLandDecoration.RemoveAt(((h * (int)level.Width) + (int)level.Width) - h);
                        level.FLandDecoration.RemoveAt(((h * (int)level.Width) + (int)level.Width) - h);
                    }
                    level.Width = (uint)sizeW.Value;
                }
                else if (sizeH.Value > level.Height)
                {
                    for (int w = 0; w < level.Width; w++)
                    {
                        level.TileCollision.Add(c);
                        level.TileBlock.Add(b);
                        level.BLandDecoration.Add(d);
                        level.MLandDecoration.Add(d);
                        level.FLandDecoration.Add(d);
                    }
                    level.Height = (uint)sizeH.Value;
                }
                else if (sizeH.Value < level.Height)
                {
                    level.TileCollision.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                    level.TileBlock.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                    level.BLandDecoration.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                    level.MLandDecoration.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                    level.FLandDecoration.RemoveRange((int)((level.Height - 1) * (int)level.Width), (int)level.Width);
                    level.Height = (uint)sizeH.Value;
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
                } catch { }
                carriablesList.ClearSelected();
                itemList.ClearSelected();
                bossList.ClearSelected();
                enemyList.ClearSelected();
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
                } catch { }
                objList.ClearSelected();
                itemList.ClearSelected();
                bossList.ClearSelected();
                enemyList.ClearSelected();
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
                } catch { }
                objList.ClearSelected();
                carriablesList.ClearSelected();
                bossList.ClearSelected();
                enemyList.ClearSelected();
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
                } catch { }
                objList.ClearSelected();
                carriablesList.ClearSelected();
                itemList.ClearSelected();
                enemyList.ClearSelected();
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
                } catch { }
                objList.ClearSelected();
                carriablesList.ClearSelected();
                itemList.ClearSelected();
                bossList.ClearSelected();
                a = false;
            }
        }

        void UpdateCoords()
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
                        RDLLVL.SpecialItem obj = level.Carriables[carriablesList.SelectedIndex];
                        obj.X = (uint)xCoord.Value;
                        obj.XOffset = (uint)xOffset.Value;
                        obj.Y = (uint)yCoord.Value;
                        obj.YOffset = (uint)yOffset.Value;
                        level.Carriables[carriablesList.SelectedIndex] = obj;
                        break;
                    }
                case 2:
                    {
                        RDLLVL.Item obj = level.Items[itemList.SelectedIndex];
                        obj.X = (uint)xCoord.Value;
                        obj.XOffset = (uint)xOffset.Value;
                        obj.Y = (uint)yCoord.Value;
                        obj.YOffset = (uint)yOffset.Value;
                        level.Items[itemList.SelectedIndex] = obj;
                        break;
                    }
                case 3:
                    {
                        RDLLVL.Boss obj = level.Bosses[bossList.SelectedIndex];
                        obj.X = (uint)xCoord.Value;
                        obj.XOffset = (uint)xOffset.Value;
                        obj.Y = (uint)yCoord.Value;
                        obj.YOffset = (uint)yOffset.Value;
                        level.Bosses[bossList.SelectedIndex] = obj;
                        break;
                    }
                case 4:
                    {
                        RDLLVL.Enemy obj = level.Enemies[enemyList.SelectedIndex];
                        obj.X = (uint)xCoord.Value;
                        obj.XOffset = (uint)xOffset.Value;
                        obj.Y = (uint)yCoord.Value;
                        obj.YOffset = (uint)yOffset.Value;
                        level.Enemies[enemyList.SelectedIndex] = obj;
                        break;
                    }
            }
        }

        private void xCoord_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != null && !a)
            {
                UpdateCoords();
            }
        }

        private void xOffset_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != null && !a)
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
            if (level != null && moveObj != null && !a)
            {
                UpdateCoords();
            }
        }

        private void yOffset_ValueChanged(object sender, EventArgs e)
        {
            if (level != null && moveObj != null && !a)
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
                            RefreshObjectLists();
                            objList.SelectedIndex = level.Objects.Count - 1;
                            break;
                        case 1:
                            level.Carriables.Add(new SpecialItem());
                            RefreshObjectLists();
                            carriablesList.SelectedIndex = level.Carriables.Count - 1;
                            break;
                        case 2:
                            level.Items.Add(new Item());
                            RefreshObjectLists();
                            itemList.SelectedIndex = level.Items.Count - 1;
                            break;
                        case 3:
                            level.Bosses.Add(new Boss());
                            RefreshObjectLists();
                            bossList.SelectedIndex = level.Bosses.Count - 1;
                            break;
                        case 4:
                            level.Enemies.Add(new Enemy());
                            RefreshObjectLists();
                            enemyList.SelectedIndex = level.Enemies.Count - 1;
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
                            RefreshObjectLists();
                            break;
                        case 1:
                            level.Carriables.RemoveAt(carriablesList.SelectedIndex);
                            RefreshObjectLists();
                            break;
                        case 2:
                            level.Items.RemoveAt(itemList.SelectedIndex);
                            RefreshObjectLists();
                            break;
                        case 3:
                            level.Bosses.RemoveAt(bossList.SelectedIndex);
                            RefreshObjectLists();
                            break;
                        case 4:
                            level.Enemies.RemoveAt(enemyList.SelectedIndex);
                            RefreshObjectLists();
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
                            ObjectEditor editor0 = new ObjectEditor();
                            editor0.obj = level.Objects[objList.SelectedIndex];
                            if (editor0.ShowDialog() == DialogResult.OK)
                            {
                                level.Objects[objList.SelectedIndex] = editor0.obj;
                                RefreshObjectLists();
                            }
                            break;
                        case 1:
                            SpecialItemEditor editor1 = new SpecialItemEditor();
                            editor1.obj = level.Carriables[carriablesList.SelectedIndex];
                            if (editor1.ShowDialog() == DialogResult.OK)
                            {
                                level.Carriables[carriablesList.SelectedIndex] = editor1.obj;
                                RefreshObjectLists();
                            }
                            break;
                        case 2:
                            ItemEditor editor2 = new ItemEditor();
                            editor2.obj = level.Items[itemList.SelectedIndex];
                            if (editor2.ShowDialog() == DialogResult.OK)
                            {
                                level.Items[itemList.SelectedIndex] = editor2.obj;
                                RefreshObjectLists();
                            }
                            break;
                        case 3:
                            BossEditor editor3 = new BossEditor();
                            editor3.obj = level.Bosses[bossList.SelectedIndex];
                            if (editor3.ShowDialog() == DialogResult.OK)
                            {
                                level.Bosses[bossList.SelectedIndex] = editor3.obj;
                                RefreshObjectLists();
                            }
                            break;
                        case 4:
                            EnemyEditor editor4 = new EnemyEditor();
                            editor4.obj = level.Enemies[enemyList.SelectedIndex];
                            if (editor4.ShowDialog() == DialogResult.OK)
                            {
                                level.Enemies[enemyList.SelectedIndex] = editor4.obj;
                                RefreshObjectLists();
                            }
                            break;
                    }
                } catch { }
            }
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
                            RefreshObjectLists();
                            break;
                        case 1:
                            level.Carriables.Add(level.Carriables[carriablesList.SelectedIndex]);
                            RefreshObjectLists();
                            break;
                        case 2:
                            level.Items.Add(level.Items[itemList.SelectedIndex]);
                            RefreshObjectLists();
                            break;
                        case 3:
                            level.Bosses.Add(level.Bosses[bossList.SelectedIndex]);
                            RefreshObjectLists();
                            break;
                        case 4:
                            level.Enemies.Add(level.Enemies[enemyList.SelectedIndex]);
                            RefreshObjectLists();
                            break;
                    }
                } catch { }
            }
        }

        private void objList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null) if (objList.SelectedItem != null) editObj_Click(this, new EventArgs());
        }
        private void specItemList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null) if (carriablesList.SelectedItem != null) editObj_Click(this, new EventArgs());
        }
        private void itemList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null) if (itemList.SelectedItem != null) editObj_Click(this, new EventArgs());
        }
        private void bossList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null) if (bossList.SelectedItem != null) editObj_Click(this, new EventArgs());
        }
        private void enemyList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (level != null) if (enemyList.SelectedItem != null) editObj_Click(this, new EventArgs());
        }

        private void stageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                StageSettings settings = new StageSettings();
                settings.data = level.StageData;
                settings.background = level.Background;
                settings.tileset = level.Tileset;
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    level.StageData = settings.data;
                    level.Background = settings.background;
                    level.Tileset = settings.tileset;
                }
            }
        }
        private void materialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialList.SelectedIndex)
            {
                case 0:
                    vmat.Value = 0;
                    break;
                case 1:
                    vmat.Value = 8;
                    break;
                case 2:
                    vmat.Value = 16;
                    break;
                case 3:
                    vmat.Value = 24;
                    break;
                case 4:
                    vmat.Value = 32;
                    break;
                case 5:
                    vmat.Value = 40;
                    break;
                case 6:
                    vmat.Value = 48;
                    break;
                case 7:
                    vmat.Value = 56;
                    break;
            }
        }
        private void vmat_ValueChanged(object sender, EventArgs e)
        {
            if (vmat.Value < 8)
            {
                materialList.SelectedIndex = 0;
            }
            else if (vmat.Value < 16)
            {
                materialList.SelectedIndex = 1;
            }
            else if (vmat.Value < 24)
            {
                materialList.SelectedIndex = 2;
            }
            else if (vmat.Value < 32)
            {
                materialList.SelectedIndex = 3;
            }
            else if (vmat.Value < 40)
            {
                materialList.SelectedIndex = 4;
            }
            else if (vmat.Value < 48)
            {
                materialList.SelectedIndex = 5;
            }
            else if (vmat.Value < 56)
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
            if (level != null)
            {
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
            if (level != null)
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
        public string UpdateNotes(string category, string type)
        {
            string notes = "";

            String notesFilepath = (Directory.GetCurrentDirectory() + "\\CustomData\\EntityNotes.txt");
            if (File.Exists(notesFilepath))
            {
                String line;
                try
                {
                    StreamReader noteStream = new StreamReader(notesFilepath);
                    line = noteStream.ReadLine();
                    while (!line.Contains("/" + category + " Default") && line != null)
                    {
                        line = noteStream.ReadLine();
                    }
                    line = noteStream.ReadLine();
                    while (!line.Contains("/;"))
                    {
                        notes += line + Environment.NewLine;
                        line = noteStream.ReadLine();
                    }
                    notes += Environment.NewLine;
                    while (!line.Contains("/" + category + " [" + type + "]") && line != null)
                    {
                        line = noteStream.ReadLine();
                    }
                    line = noteStream.ReadLine();
                    while (!line.Contains("/;"))
                    {
                        notes += line + Environment.NewLine;
                        line = noteStream.ReadLine();
                    }
                    noteStream.Close();
                    noteStream.Dispose();
                }
                catch { }
            }
            return notes;
        }
        public Vector2 SpriteOffset(string key)
        {
            if (spriteOffsets.ContainsKey(key))
            {
                return 16 * (new Vector2(spriteOffsets[key].X, -spriteOffsets[key].Y));
            }
            return new Vector2(0, 0);
        }

        public void UpdateSpriteOffsetDictionary()
        {
            String offsetsFilepath = Directory.GetCurrentDirectory() + "\\CustomData\\SpriteOffsets.txt";
            if (File.Exists(offsetsFilepath))
            {
                try
                {
                    StreamReader offsetStream = new StreamReader(offsetsFilepath);
                    String line = offsetStream.ReadLine();
                    Vector2 offset = new Vector2(0, 0);
                    while (line != null)
                    {
                        if (line.Contains("=="))
                        {
                            line = offsetStream.ReadLine();
                            offset = new Vector2(float.Parse(line.Substring(3, line.Length - 3)), 0);
                            line = offsetStream.ReadLine();
                            offset += new Vector2(0, float.Parse(line.Substring(3, line.Length - 3)));
                            line = offsetStream.ReadLine();
                        }
                        if (!spriteOffsets.ContainsKey(line) && !string.IsNullOrEmpty(line) && !line.StartsWith("/;")) spriteOffsets.Add(line, offset);
                        line = offsetStream.ReadLine();
                    }
                    offsetStream.Close();
                    offsetStream.Dispose();
                } catch { }
            }
        }

        private void optionsAndHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool inLevel = false;
            if (level != null) inLevel = true;
            Options opt = new Options(inLevel);
            opt.Refresh();
            opt.ShowDialog();
        }
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl2.SelectedIndex == 1)
                {
                    d1_hex.Text = ((byte)d1_1.Value).ToString("X2") + ((byte)d1_2.Value).ToString("X2") + ((byte)d1_3.Value).ToString("X2") + ((sbyte)d1_4.Value).ToString("X2");
                    d2_hex.Text = ((byte)d2_1.Value).ToString("X2") + ((byte)d2_2.Value).ToString("X2") + ((byte)d2_3.Value).ToString("X2") + ((sbyte)d2_4.Value).ToString("X2");
                    d3_hex.Text = ((byte)d3_1.Value).ToString("X2") + ((byte)d3_2.Value).ToString("X2") + ((byte)d3_3.Value).ToString("X2") + ((sbyte)d3_4.Value).ToString("X2");
                }
                else
                {
                    uint b = uint.Parse(d1_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                    d1_1.Value = uint.Parse(d1_hex.Text.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                    d1_2.Value = uint.Parse(d1_hex.Text.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    d1_3.Value = uint.Parse(d1_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    if (b < 16) d1_4.Value = b;
                    else d1_4.Value = -1;

                    uint f = uint.Parse(d2_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                    d2_1.Value = uint.Parse(d2_hex.Text.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                    d2_2.Value = uint.Parse(d2_hex.Text.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    d2_3.Value = uint.Parse(d2_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    if (f < 16) d2_4.Value = f;
                    else d2_4.Value = -1;

                    uint m = uint.Parse(d3_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                    d3_1.Value = uint.Parse(d3_hex.Text.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                    d3_2.Value = uint.Parse(d3_hex.Text.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    d3_3.Value = uint.Parse(d3_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    if (m < 16) d3_4.Value = m;
                    else d3_4.Value = -1;
                }
            } catch { }
        }
        private void d1_hex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                uint b = uint.Parse(d1_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                d1_1.Value = uint.Parse(d1_hex.Text.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                d1_2.Value = uint.Parse(d1_hex.Text.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                d1_3.Value = uint.Parse(d1_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                if (b < 16) d1_4.Value = b;
                else d1_4.Value = -1;
            } catch { }
        }
        private void d2_hex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                uint f = uint.Parse(d2_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                d2_1.Value = uint.Parse(d2_hex.Text.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                d2_2.Value = uint.Parse(d2_hex.Text.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                d2_3.Value = uint.Parse(d2_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                if (f < 16) d2_4.Value = f;
                else d2_4.Value = -1;
            } catch { }
        }
        private void d3_hex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                uint m = uint.Parse(d3_hex.Text.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                d3_1.Value = uint.Parse(d3_hex.Text.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                d3_2.Value = uint.Parse(d3_hex.Text.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                d3_3.Value = uint.Parse(d3_hex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                if (m < 16) d3_4.Value = m;
                else d3_4.Value = -1;
            } catch { }
        }
        private void viewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            collViewType = viewType.SelectedIndex;
            RefreshObjectLists();
        }
        
        public void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            enemyList.BackColor = MagoCrate.Properties.Settings.Default.EnemyColor;
            bossList.BackColor = MagoCrate.Properties.Settings.Default.BossColor;
            if (MagoCrate.Properties.Settings.Default.rtmColorsON)
            {
                objList.BackColor = MagoCrate.Properties.Settings.Default.ItemColor;
                itemList.BackColor = MagoCrate.Properties.Settings.Default.CarryColor;
                carriablesList.BackColor = MagoCrate.Properties.Settings.Default.ObjColor;
            } else
            {
                objList.BackColor = MagoCrate.Properties.Settings.Default.ObjColor;
                itemList.BackColor = MagoCrate.Properties.Settings.Default.ItemColor;
                carriablesList.BackColor = MagoCrate.Properties.Settings.Default.CarryColor;
            }
        }
        private async void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Objects objs = new Objects();
            spriteOffsets.Clear();
            RefreshObjectLists();
            RefreshObjectSprites();
            UpdateSpriteOffsetDictionary();
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
            TabPage current = (sender as TabControl).SelectedTab;
            objList.ClearSelected();
            carriablesList.ClearSelected();
            itemList.ClearSelected();
            bossList.ClearSelected();
            enemyList.ClearSelected();
            RefreshObjectLists();
        }


    }
}
