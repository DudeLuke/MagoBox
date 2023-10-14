using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagoBox;
using System.Drawing.Drawing2D;
using MagoBox.Rendering;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using static OpenTK.Graphics.OpenGL.GL;
using System.Xml.Linq;
using RDLLVL;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using IniParser;

namespace MagoCrate
{
    public partial class DynamicTerrainEditor : Form
    {
        MainForm main;
        Renderer renderer;
        Camera camera;
        private System.Timers.Timer t;
        public DynamicTerrain baseObj, obj;
        public DynamicAction action, baseAction;
        public int tool = 0;
        int mouseX = 0;
        int mouseY = 0;
        private uint tileX, tileY;
        private int tileStartX, tileStartY, tileEndX, tileEndY;
        bool updateAvailable = false;
        private List<SimpleMoveTile> simpleTiles = new List<SimpleMoveTile>();

        public DynamicTerrainEditor(MainForm parent)
        {
            InitializeComponent();
            RefreshColors();
            main = parent;
            obj = new DynamicTerrain();
            action = new DynamicAction();
            glControl.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseWheel);
        }
        public void RefreshColors()
        {
            Color col = MagoCrate.Properties.Settings.Default.DynamicSectionColor;
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            resetCamera.BackColor = col;
            vShape.BackColor = col;
            vmat.BackColor = col;
            materialList.BackColor = col;
            width.BackColor = col;
            height.BackColor = col;
            prm1.BackColor = col;
            prm2.BackColor = col;
            eventID.BackColor = col;
            save.BackColor = col;
            phaseList.BackColor = col;
            addPhase.BackColor = col;
            clonePhase.BackColor = col;
            delPhase.BackColor = col;
            direction.BackColor = col;
            distance.BackColor = col;
            delay.BackColor = col;
            duration.BackColor = col;
            unk1.BackColor = col;
            unk2.BackColor = col;
            addendum.BackColor = col;
            acceleration.BackColor = col;
            accelTime.BackColor = col;
            unk3.BackColor = col;
        }
        private void glControl_Load(object sender, EventArgs e)
        {
            glControl.MakeCurrent();
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.ClearColor(Color.FromArgb(200, 200, 200));

            materialList.SelectedIndex = 0;
            modifierList.SelectedIndex = 0;

            obj.X = baseObj.X;
            obj.Y = baseObj.Y;
            obj.Width = baseObj.Width;
            obj.Height = baseObj.Height;
            obj.tiles = baseObj.tiles;
            getTiles();

            action.EventID = baseAction.EventID;
            action.Parameter1 = baseAction.Parameter1;
            action.Parameter2 = baseAction.Parameter2;
            action.autoStart = baseAction.autoStart;
            action.phases.Clear();
            for (int i = 0; i < baseAction.phases.Count; i++)
            {
                action.phases.Add(baseAction.phases[i]);
            }
            autoStart.Checked = action.autoStart;
            if (action.autoStart) eventID.Enabled = false;
            decimal newValue = action.EventID;
            if (newValue > 254) newValue = -1;
            eventID.Value = newValue;
            prm1.Value = action.Parameter1;
            prm2.Value = action.Parameter2;

            width.Value = obj.Width;
            height.Value = obj.Height;

            renderer = new Renderer();
            camera = new Camera(new Vector2(16 * ((float)width.Value / 2), -16 * ((float)height.Value / 2)), 1.8);

            SwitchTool(0);
            updateAvailable = true;
            UpdatePhaseList(-1);
            if (phaseList.Items.Count > 0) phaseList.SelectedIndex = 0;

            t = new System.Timers.Timer(1000.0 / 60.0);
            t.Elapsed += t_Elapsed;
            t.Start();
        }
        private void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            glControl.Invalidate();
            t.Start();
        }
        private Vector2 ConvertMouseCoords(Vector2 i)
        {
            i -= new Vector2(glControl.Width, glControl.Height) / 2f;
            i /= (float)camera.zoom;
            return (camera.pos + i) / 16f;
        }
        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            if (updateAvailable)
            {
                updateAvailable = false;
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                GL.ClearColor(Color.FromArgb(200, 200, 200));

                renderer.Begin(glControl.Width, glControl.Height);
                camera.Transform();
                Vector2 vec_scale = Vector2.One;

                //Crop Tiles outside camera view.

                tileStartX = (int)Math.Max(0, Math.Floor(
                        (camera.pos.X - glControl.Width / camera.zoom * 0.5f) / 16.0f
                    ));
                tileEndX = (int)Math.Min(obj.Width, Math.Ceiling(
                        (camera.pos.X + glControl.Width / camera.zoom * 0.5f) / 16.0f
                    ));
                tileStartY = (int)Math.Max(0, 1 + Math.Floor(
                        -(camera.pos.Y + glControl.Height / camera.zoom * 0.5f) / 16.0f
                    ));
                tileEndY = (int)Math.Min(obj.Height, 1 + Math.Ceiling(
                        -(camera.pos.Y - glControl.Height / camera.zoom * 0.5f) / 16.0f
                    ));

                
                for (int ty = tileStartY; ty < tileEndY; ty++)
                {
                    for (int tx = tileStartX; tx < tileEndX; tx++)
                    {
                        int ix = ty * obj.Width + tx;
                        Vector2 tPos = new Vector2(tx * 16f, -ty * 16f);

                        if (!simpleTiles[ix].NullTile)
                        {
                            // Render Collision
                            renderer.Draw(main.shapeTexIds[simpleTiles[ix].Shape], tPos, vec_scale, 17, 17);

                            // Render Materials
                            int m = simpleTiles[ix].Material;
                            if (m > 7)
                            {
                                if (m < 16) renderer.Draw(main.propertyTexIds[0], tPos, vec_scale, 17, 17);
                                else if (m < 24) renderer.Draw(main.propertyTexIds[1], tPos, vec_scale, 17, 17);
                                else if (m < 32) renderer.Draw(main.propertyTexIds[2], tPos, vec_scale, 17, 17);
                                else if (m < 40) renderer.Draw(main.propertyTexIds[3], tPos, vec_scale, 17, 17);
                                else if (m < 48) renderer.Draw(main.propertyTexIds[4], tPos, vec_scale, 17, 17);
                                else if (m < 56) renderer.Draw(main.propertyTexIds[5], tPos, vec_scale, 17, 17);
                                else renderer.Draw(main.propertyTexIds[6], tPos, vec_scale, 17, 17);
                            }

                            // Render Modifiers
                            if ((m % 8) == 4) renderer.Draw(main.modTexIds[3], tPos, vec_scale, 17, 17);
                            else if ((m % 8) == 5) renderer.Draw(main.modTexIds[4], tPos, vec_scale, 17, 17);
                            else if ((m % 8) == 6) renderer.Draw(main.modTexIds[5], tPos, vec_scale, 17, 17);
                        }
                        else renderer.Draw(main.shapeTexIds[53], tPos, vec_scale, 17, 17);
                    }
                }
                // Render Select Cursor
                Vector2 v = new Vector2(tileX * 16f, -tileY * 16f);
                renderer.Draw(main.shapeTexIds[52], v, vec_scale, 17, 17);
                glControl.SwapBuffers();
                updateAvailable = true;
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Width = (short)width.Value;
                obj.Height = (short)height.Value;

                action.autoStart = autoStart.Checked;
                action.EventID = (int)eventID.Value;
                action.Parameter1 = (byte)prm1.Value;
                action.Parameter2 = (byte)prm2.Value;

                obj.tiles = cleanTiles();
                DialogResult = DialogResult.Yes;
            } catch { MessageBox.Show("Failed To Save Data"); }
        }
        private void SpriteEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.RefreshEditor();
        }
        private void glControl_MouseDown(object sender, MouseEventArgs e)
        {
            Vector2 p = ConvertMouseCoords(new Vector2(e.X, e.Y));
            if (p.X > (float)width.Value - 1)
            {
                tileX = (uint)width.Value - 1;
            }
            else if (p.X > 0)
            {
                tileX = (uint)p.X;
            }
            else { tileX = 0; }
            if (p.Y < -((float)height.Value - 1))
            {
                tileY = (uint)height.Value - 1;
            }
            else if (p.Y < 0)
            {
                tileY = (uint)-p.Y + 1;
            }
            else { tileY = 0; }
            int ix = (int)((tileY * width.Value) + tileX);

            if (e.Button == MouseButtons.Right)
            {
                if (MagoCrate.Properties.Settings.Default.quickPickON)
                {
                    if (tool == 0) Pick(ix);
                }
                else
                {
                    mouseX = e.X;
                    mouseY = e.Y;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (tool == 0) Pencil(ix);
                else if (tool == 1) Pick(ix);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                mouseX = e.X;
                mouseY = e.Y;
            }

        }
        private void glControl_MouseMove(object sender, MouseEventArgs e)
        {
            Vector2 p = ConvertMouseCoords(new Vector2(e.X, e.Y));
            if (p.X > (uint)width.Value - 1)
            {
                tileX = (uint)width.Value - 1;
            }
            else if (p.X > 0)
            {
                tileX = (uint)p.X;
            }
            else { tileX = 0; }
            if (p.Y < -((uint)height.Value - 1))
            {
                tileY = (uint)height.Value - 1;
            }
            else if (p.Y < 0)
            {
                tileY = (uint)-p.Y + 1;
            }
            else { tileY = 0; }
            int ix = (int)((tileY * width.Value) + tileX);


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
            if (e.Button == MouseButtons.Left && tool == 0)
            {
                Pencil(ix);
            } else if (e.Button == MouseButtons.Middle)
            {
                float moveSpeed = 1.0f / (float)camera.zoom;
                camera.pos.X += (mouseX - e.X) * moveSpeed;
                camera.pos.Y += (mouseY - e.Y) * moveSpeed;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }
        private void glControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                mouseX = 0;
                mouseY = 0;
            }
            else if (e.Button == MouseButtons.Right && !MagoCrate.Properties.Settings.Default.quickPickON)
            {
                mouseX = 0;
                mouseY = 0;
            }
        }
        private void resetCamera_Click(object sender, EventArgs e)
        {
            camera.pos = new Vector2(16 * ((float)width.Value / 2), -16 * ((float)height.Value / 2));
        }
        private void Pencil(int ix)
        {
            if (ix < simpleTiles.Count && ix >= 0)
            {
                Console.WriteLine("Count is: " + simpleTiles.Count + ", ix: " + ix.ToString("X"));
                SimpleMoveTile newTile = new SimpleMoveTile();
                newTile.NullTile = true;
                if (modifierList.SelectedIndex != 1)
                {
                    newTile.NullTile = false;
                    newTile.Shape = (byte)vShape.Value;
                    newTile.Material = (byte)vmat.Value;
                }
                simpleTiles[ix] = newTile;
            }
        }
        private void Pick(int ix)
        {
            if (ix < simpleTiles.Count)
            {
                bool nullTile = simpleTiles[ix].NullTile;
                if (!nullTile)
                {
                    vShape.Value = simpleTiles[ix].Shape;
                    vmat.Value = simpleTiles[ix].Material;

                    updateAvailable = false;
                    if ((vmat.Value % 8) == 4) modifierList.SelectedIndex = 2;
                    else if ((vmat.Value % 8) == 5) modifierList.SelectedIndex = 3;
                    else if ((vmat.Value % 8) == 6) modifierList.SelectedIndex = 4;
                    else modifierList.SelectedIndex = 0;
                    updateAvailable = true;
                }
                else modifierList.SelectedIndex = 1;
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
        private void zoomIn_Click(object sender, EventArgs e)
        {
            camera.zoom += 0.2 * camera.zoom;
            if (camera.zoom > 4)
            {
                camera.zoom = 4;
            }

            int w = glControl.Width;
            int h = glControl.Height;
            GL.Viewport(0, 0, (int)w, (int)h);
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            camera.zoom -= 0.2 * camera.zoom;
            if (camera.zoom < 1)
            {
                camera.zoom = 1;
            }

            int w = glControl.Width;
            int h = glControl.Height;
            GL.Viewport(0, 0, (int)w, (int)h);
        }
        private void getTiles()
        {
            simpleTiles.Clear();
            for (int i = 0; i < obj.Width * obj.Height; i++)
            {
                SimpleMoveTile newSimple = new SimpleMoveTile();
                newSimple.NullTile = true;
                simpleTiles.Add(newSimple);
            }

            for (int i = 0; i < obj.tiles.Count; i++)
            {
                SimpleMoveTile newSimple = new SimpleMoveTile();
                newSimple.Shape = obj.tiles[i].Shape;
                newSimple.Material = obj.tiles[i].Material;
                newSimple.NullTile = false;
                int index = (obj.Width * obj.tiles[i].Y) + obj.tiles[i].X;
                if (index < simpleTiles.Count) simpleTiles[index] = newSimple;
            }
        }
        private void UpdatePhaseList(int prevIndex)
        {
            phaseList.Items.Clear();
            for (int i = 0; i < action.phases.Count; i++)
            {
                string dir = direction.Items[action.phases[i].Direction].ToString();
                phaseList.Items.Add($"{dir} {action.phases[i].Distance}");
            }
            if (prevIndex >= 0 && prevIndex < phaseList.Items.Count) phaseList.SelectedIndex = prevIndex;
        }
        private void phaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (phaseList.SelectedIndex >= 0 && phaseList.SelectedIndex < phaseList.Items.Count && updateAvailable)
            {
                try
                {
                    updateAvailable = false;
                    direction.SelectedIndex = action.phases[phaseList.SelectedIndex].Direction;
                    distance.Value = action.phases[phaseList.SelectedIndex].Distance;
                    delay.Value = action.phases[phaseList.SelectedIndex].Delay;
                    duration.Value = action.phases[phaseList.SelectedIndex].Duration;
                    unk1.Value = action.phases[phaseList.SelectedIndex].Unknown1;
                    unk2.Value = action.phases[phaseList.SelectedIndex].Unknown2;
                    unk3.Value = action.phases[phaseList.SelectedIndex].Unknown3;
                    isEnd.Checked = action.phases[phaseList.SelectedIndex].EndPhase;
                    if (action.phases[phaseList.SelectedIndex].AccelType > 4) acceleration.Text = "";
                    else acceleration.SelectedIndex = action.phases[phaseList.SelectedIndex].AccelType;
                    accelTime.Value = action.phases[phaseList.SelectedIndex].AccelTime;

                    string additions = "";
                    for (int i = 0; i < 10; i++)
                    {
                        additions += action.phases[phaseList.SelectedIndex].Addendum[i].ToString("X2");
                        additions += " ";
                    }
                    addendum.Text = additions.Trim();

                    updateAvailable = true;
                }
                catch
                {
                    MessageBox.Show("Failed To Update Phase Data");
                }
            }
        }
        private void UpdateAddendum(out byte[] outAddendum)
        {
            outAddendum = new byte[0];
            try
            {
                addendum.ForeColor = Color.Black;
                outAddendum = new byte[10];
                char[] cleanAddendumChars = addendum.Text.ToCharArray();
                string cleanAddendum = "";
                foreach (char character in cleanAddendumChars)
                {
                    if (Uri.IsHexDigit(character)) cleanAddendum += character;
                }
                for (int i = 0; i < 10; i++)
                {
                    outAddendum[i] = (byte)uint.Parse(cleanAddendum.Substring(2 * i, 2), System.Globalization.NumberStyles.HexNumber);
                    Console.WriteLine("Adding New Addendum Byte: " + outAddendum[i].ToString("X2"));
                }
            }
            catch
            {
                addendum.ForeColor = Color.Red;
            }
        }
        private void UpdatePhaseData(object sender, EventArgs e)
        {
            if (updateAvailable)
            {
                try
                {
                    updateAvailable = false;
                    ActionPhase newPhase = new ActionPhase();
                    newPhase.Direction = (byte)direction.SelectedIndex;
                    newPhase.Distance = (byte)distance.Value;
                    newPhase.Delay = (short)delay.Value;
                    newPhase.Duration = (short)duration.Value;
                    newPhase.Unknown1 = (short)unk1.Value;
                    newPhase.Unknown2 = (byte)unk2.Value;
                    newPhase.Unknown3 = (short)unk3.Value;
                    newPhase.EndPhase = isEnd.Checked;
                    newPhase.AccelType = (byte)acceleration.SelectedIndex;
                    newPhase.AccelTime = (byte)accelTime.Value;


                    byte[] newAddendum = new byte[0];
                    UpdateAddendum(out newAddendum);
                    if (newAddendum.Length < 10) newAddendum = action.phases[phaseList.SelectedIndex].Addendum;
                    newPhase.Addendum = newAddendum;

                    action.phases[phaseList.SelectedIndex] = newPhase;
                    UpdatePhaseList(phaseList.SelectedIndex);
                    updateAvailable = true;
                }
                catch { }
            }
        }
        private void addPhase_Click(object sender, EventArgs e)
        {
            ActionPhase defaultAP = new ActionPhase();
            defaultAP.Addendum = new byte[] { 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x00 };
            defaultAP.Duration = 0x1E;
            defaultAP.Unknown2 = 0xFF;
            action.phases.Add(defaultAP);
            UpdatePhaseList(-1);
            phaseList.SelectedIndex = phaseList.Items.Count - 1;
        }
        private void clonePhase_Click(object sender, EventArgs e)
        {
            action.phases.Insert(phaseList.SelectedIndex + 1, action.phases[phaseList.SelectedIndex]);
            UpdatePhaseList(phaseList.SelectedIndex + 1);
        }

        private void delPhase_Click(object sender, EventArgs e)
        {
            try
            {
                action.phases.RemoveAt(phaseList.SelectedIndex);
                UpdatePhaseList(-1);
                if (action.phases.Count > 0) phaseList.SelectedIndex -= 1;
            } catch { }
        }
        private List<MoveTile> cleanTiles()
        {
            int curX = 0;
            int curY = 0;
            List<MoveTile> cleanList = new List<MoveTile>();
            for (int i = 0; i < ((int)width.Value * (int)height.Value); i++)
            {
                if (!simpleTiles[i].NullTile)
                {
                    MoveTile cleanTile = new MoveTile();
                    cleanTile.Shape = simpleTiles[i].Shape;
                    cleanTile.Material = simpleTiles[i].Material;
                    cleanTile.X = (byte)curX;
                    cleanTile.Y = (byte)curY;
                    cleanList.Add(cleanTile);
                    Console.WriteLine($"Added Cleaned Tile: {cleanTile.Shape}, {cleanTile.Material}, {cleanTile.X}, {cleanTile.Y}");
                }

                curX++;
                if (curX == obj.Width)
                {
                    curX = 0;
                    curY++;
                }
            }
            return cleanList;
        }
        private void ModifierChanged(object sender, EventArgs e)
        {
            bool nullTile = false;
            if (modifierList.SelectedIndex == 1) nullTile = true;

            if (nullTile)
            {
                vShape.Minimum = -1;
                vShape.Value = -1;
                updateAvailable = false;
                vmat.Value = 0;
                materialList.SelectedIndex = 0;
                updateAvailable = true;
            }
            else
            {
                if (vShape.Value < 0) vShape.Value = 0;
                vShape.Minimum = 0;
            }

            colImg.Enabled = !nullTile;
            vShape.Enabled = !nullTile;
            vmat.Enabled = !nullTile;
            materialList.Enabled = !nullTile;

            if (updateAvailable)
            {
                updateAvailable = false;
                if (modifierList.SelectedIndex > 1)
                {
                    vmat.Value = (materialList.SelectedIndex * 8) + modifierList.SelectedIndex + 2;
                }
                else if (modifierList.SelectedIndex == 0) vmat.Value = (materialList.SelectedIndex * 8);
                updateAvailable = true;
            }
        }
        private void vShape_ValueChanged(object sender, EventArgs e)
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
        private void colImg_Click(object sender, EventArgs e)
        {
            ColShapeSelector select = new ColShapeSelector();
            if (select.ShowDialog() == DialogResult.OK)
            {
                vShape.Value = select.index;
            }
        }

        private void materialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateAvailable)
            {
                updateAvailable = false;
                vmat.Value = materialList.SelectedIndex * 8;
                if (modifierList.SelectedIndex == 2) vmat.Value += 4;
                else if (modifierList.SelectedIndex == 3) vmat.Value += 5;
                else if (modifierList.SelectedIndex == 4) vmat.Value += 6;
                updateAvailable = true;
            }
        }
        private void vmat_ValueChanged(object sender, EventArgs e)
        {
            if (updateAvailable)
            {
                updateAvailable = false;
                materialList.SelectedIndex = (int)vmat.Value / 8;
                if ((vmat.Value % 8) == 4) modifierList.SelectedIndex = 2;
                else if ((vmat.Value % 8) == 5) modifierList.SelectedIndex = 3;
                else if ((vmat.Value % 8) == 6) modifierList.SelectedIndex = 4;
                else modifierList.SelectedIndex = 0;
                updateAvailable = true;
            }
        }
        private void UpdateLevelSize(object sender, EventArgs e)
        {
            if (updateAvailable)
            {
                updateAvailable = false;
                try
                {
                    int widthDifference = (int)width.Value - (int)obj.Width;
                    int heightDifference = (int)height.Value - (int)obj.Height;

                    SimpleMoveTile t = new SimpleMoveTile();
                    t.NullTile = true;

                    if (widthDifference > 0)
                    {
                        for (int i = 0; i < widthDifference; i++)
                        {
                            for (int h = 0; h < height.Value; h++)
                            {
                                simpleTiles.Insert(((h * obj.Width) + obj.Width) + h, t);
                            }
                            obj.Width++;
                        }
                        
                    }
                    else if (widthDifference < 0)
                    {
                        for (int i = 0; i < -widthDifference; i++)
                        {
                            for (int h = 0; h < height.Value; h++)
                            {
                                simpleTiles.RemoveAt(((h * (int)obj.Width) + (int)obj.Width) - (h + 1));
                            }
                            obj.Width--;
                        }
                    }
                    else if (heightDifference > 0)
                    {
                        for (int i = 0; i < heightDifference; i++)
                        {
                            for (int w = 0; w < obj.Width; w++)
                            {
                                simpleTiles.Add(t);
                            }
                            obj.Height++;
                        }
                    }
                    else if (heightDifference < 0)
                    {
                        for (int i = 0; i < -heightDifference; i++)
                        {
                            simpleTiles.RemoveRange((int)((obj.Height - 1) * (int)obj.Width), (int)obj.Width);
                            obj.Height--;
                        }
                    }
                    Console.WriteLine("New Tile Count: " + simpleTiles.Count);
                }
                catch { }

                int glW = glControl.Width;
                int glH = glControl.Height;
                GL.Viewport(0, 0, (int)glW, (int)glH);
                updateAvailable = true;
            }
        }

        private void autoStart_CheckedChanged(object sender, EventArgs e)
        {
            if (updateAvailable)
            {
                eventID.Minimum = -1;
                if (autoStart.Checked) eventID.Value = -1;
                else eventID.Value = 0;
                eventID.Minimum = eventID.Value;
                eventID.Enabled = !autoStart.Checked;
            }
        }

        public void SwitchTool(int ID)
        {
            if (ID == 1 && MagoCrate.Properties.Settings.Default.quickPickON) ID = 0;

            tool = ID;
            draw.BackColor = Color.White;
            pick.BackColor = Color.White;
            draw.Enabled = true;
            pick.Enabled = true;

            switch (tool)
            {
                case 0:
                    draw.Enabled = false;
                    draw.BackColor = MagoCrate.Properties.Settings.Default.DynamicSectionColor;
                    if (MagoCrate.Properties.Settings.Default.quickPickON)
                    {
                        pick.Enabled = false;
                        pick.BackColor = MagoCrate.Properties.Settings.Default.DynamicSectionColor;
                    }
                    return;
                case 1:
                    pick.Enabled = false;
                    pick.BackColor = MagoCrate.Properties.Settings.Default.DynamicSectionColor;
                    return;
            }
        }
        private void draw_Click(object sender, EventArgs e)
        {
            SwitchTool(0);
        }
        private void pick_Click(object sender, EventArgs e)
        {
            SwitchTool(1);
        }
    }
}