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
    public partial class SpriteEditor : Form
    {
        MainForm main;
        Renderer renderer;
        Texturing texturer;
        Camera camera;
        Objects objs = new Objects();
        int tempTex;
        string path;

        public SpriteEditor(MainForm parent)
        {
            InitializeComponent();
            RefreshColors();
            main = parent;
        }
        private void glControl_Load(object sender, EventArgs e)
        {
            glControl.MakeCurrent();
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.ClearColor(Color.FromArgb(200, 200, 200));

            renderer = new Renderer();
            camera = new Camera(new Vector2(16 * 5, -16 * 3.5f), 1.8);

            categDrop.SelectedIndex = 0;
            typeDrop.Items.AddRange(objs.ObjectList.Values.ToArray());
        }
        private void save_Click(object sender, EventArgs e)
        {
            SaveImage();
        }
        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File|*.png";
            open.DefaultExt = ".png";
            open.CheckFileExists = true;
            open.Title = "Open Image";
            if (open.ShowDialog() == DialogResult.OK)
            {
                LoadImage(open.FileName);
            }
        }
        private void LoadImage(string filepath)
        {
            width.Enabled = true;
            height.Enabled = true;
            offsetX.Enabled = true;
            offsetY.Enabled = true;
            categDrop.Enabled = true;
            typeDrop.Enabled = true;
            type.Enabled = true;
            save.Enabled = true;
            zoomIn.Enabled = true;
            zoomOut.Enabled = true;
           
            path = filepath;
            texturer = new Texturing();
            tempTex = texturer.LoadTexture(path);
            Image img = Image.FromFile(path);
            width.Value = img.Width;
            height.Value = img.Height;
            offsetX.Value = 0;
            offsetY.Value = 0;
        }
        private void SaveImage()
        {
            string fileTarget = Directory.GetCurrentDirectory() + "/Resources/entities/";

            if (File.Exists(path))
            {
                switch (categDrop.SelectedIndex)
                {
                    case 0:
                        fileTarget += "objects/";
                        break;
                    case 1:
                        fileTarget += "carriables/";
                        break;
                    case 2:
                        fileTarget += "items/";
                        break;
                    case 3:
                        fileTarget += "bosses/";
                        break;
                    case 4:
                        fileTarget += "enemies/";
                        break;
                }
                fileTarget += typeDrop.Text;
                if (checkBox1.Checked) fileTarget += "." + param.Value;
                fileTarget += ".png";
                if (File.Exists(fileTarget))
                {
                    var confirmResult = MessageBox.Show("Sprite already exists. Replace?",
                                     "Confirm Replace",
                                     MessageBoxButtons.YesNo);

                    if (confirmResult != DialogResult.Yes) return;
                }
                if (Path.GetFullPath(path) != Path.GetFullPath(fileTarget)) File.Delete(fileTarget);

                string prmTarget = "";
                switch (categDrop.SelectedIndex)
                {
                    case 0:
                        prmTarget += "O.";
                        break;
                    case 1:
                        prmTarget += "C.";
                        break;
                    case 2:
                        prmTarget += "I.";
                        break;
                    case 3:
                        prmTarget += "B.";
                        break;
                    case 4:
                        prmTarget += "E.";
                        break;
                }
                if (string.IsNullOrEmpty(typeDrop.Text)) prmTarget += "Unknown (" + type.Value + ")";
                else prmTarget += typeDrop.Text;

                if (checkBox1.Checked) prmTarget += "." + param.Value;

                if (main.spriteParameters.Sections.ContainsSection(prmTarget))
                {
                    main.spriteParameters.Sections[prmTarget].RemoveAllKeys();
                    main.spriteParameters.Sections.RemoveSection(prmTarget);
                }
                main.spriteParameters.Sections.AddSection(prmTarget);
                main.spriteParameters.Sections[prmTarget].AddKey("W");
                main.spriteParameters.Sections[prmTarget].AddKey("H");
                main.spriteParameters.Sections[prmTarget].AddKey("X");
                main.spriteParameters.Sections[prmTarget].AddKey("Y");
                main.spriteParameters.Sections[prmTarget]["W"] = width.Value.ToString();
                main.spriteParameters.Sections[prmTarget]["H"] = height.Value.ToString();
                main.spriteParameters.Sections[prmTarget]["X"] = offsetX.Value.ToString();
                main.spriteParameters.Sections[prmTarget]["Y"] = offsetY.Value.ToString();

                StreamWriter stream = new StreamWriter(Directory.GetCurrentDirectory() + "\\CustomData\\SpriteParameters.ini");
                new FileIniDataParser().WriteData(stream, main.spriteParameters);
                stream.Close();
                stream.Dispose();

                if (Path.GetFullPath(path) != Path.GetFullPath(fileTarget)) File.Copy(path, fileTarget);
            }
            else MessageBox.Show("Failed to save image");
        }
        private void UpdateRender()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.FromArgb(200, 200, 200));

            renderer.Begin(glControl.Width, glControl.Height);
            camera.Transform();
            Vector2 v = new Vector2(5 * 16f, -3 * 16f);
            Vector2 vec_scale = Vector2.One;

            // Render Tiles
            for (int ty = 0; ty < 10; ty++)
            {
                for (int tx = 0; tx < 10; tx++)
                {
                    int ix = ty * 10 + tx;
                    Vector2 tPos = new Vector2(tx * 16f, -ty * 16f);
                    int shape = 0;
                    if (ty < 3) shape = 1;
                    renderer.Draw(main.shapeTexIds[shape], tPos, vec_scale, 17, 17);
                }
            }

            // Render origin Point
            Color col = Color.White;
            switch (categDrop.SelectedIndex)
            {
                case 0:
                    col = MainForm.BrightColor(MagoCrate.Properties.Settings.Default.ObjColor);
                    break;
                case 1:
                    col = MainForm.BrightColor(MagoCrate.Properties.Settings.Default.CarryColor);
                    break;
                case 2:
                    col = MainForm.BrightColor(MagoCrate.Properties.Settings.Default.ItemColor);
                    break;
                case 3:
                    col = MainForm.BrightColor(MagoCrate.Properties.Settings.Default.BossColor);
                    break;
                case 4:
                    col = MainForm.BrightColor(MagoCrate.Properties.Settings.Default.EnemyColor);
                    break;
                case 5:
                    col = MainForm.BrightColor(MagoCrate.Properties.Settings.Default.DynamicSectionColor);
                    break;
            }
            Vector2 nodePos = new Vector2(v.X - 3f, v.Y + 13f);
            renderer.DrawColor(col, main.utilityTexIds[0], nodePos, vec_scale, 7, 7);

            int w = (int)width.Value;
            int h = (int)height.Value;
            Vector2 o = new Vector2(
            (0.5f + (float)-w / 2) + ((float)offsetX.Value * 16),
            (17 + -h + -((float)offsetY.Value * 16)));

            renderer.Draw(tempTex, v + o, vec_scale, w, h);
            glControl.SwapBuffers();
        }
        private void zoomIn_Click(object sender, EventArgs e)
        {
            camera.zoom += 0.2 * camera.zoom;
            if (camera.zoom > 4)
            {
                camera.zoom = 4;
            }
            UpdateRender();
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            camera.zoom -= 0.2 * camera.zoom;
            if (camera.zoom < 1)
            {
                camera.zoom = 1;
            }
            UpdateRender();
        }


        private void type_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                switch (categDrop.SelectedIndex)
                {
                    case 0:
                        typeDrop.Text = objs.ObjectList[(uint)type.Value];
                        return;
                    case 1:
                        typeDrop.Text = objs.CarriablesList[(uint)type.Value];
                        return;
                    case 2:
                        typeDrop.Text = objs.ItemList[(uint)type.Value];
                        return;
                    case 3:
                        typeDrop.Text = objs.BossList[(uint)type.Value];
                        return;
                    case 4:
                        typeDrop.Text = objs.EnemyList[(uint)type.Value];
                        return;
                }
            }
            catch { typeDrop.Text = ""; }
        }

        private void imageValueChanged(object sender, EventArgs e)
        {
            UpdateRender();
        }

        private void categDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeDrop.Items.Clear();
            type.Value = 0;
            param.Value = 0;
            switch (categDrop.SelectedIndex)
            {
                case 0:
                    typeDrop.Items.AddRange(objs.ObjectList.Values.ToArray());
                    prmLabel.Text = "Parameter 6";
                    break;
                case 1:
                    typeDrop.Items.AddRange(objs.CarriablesList.Values.ToArray());
                    prmLabel.Text = "Appear ID";
                    break;
                case 2:
                    typeDrop.Items.AddRange(objs.ItemList.Values.ToArray());
                    prmLabel.Text = "Level";
                    break;
                case 3:
                    typeDrop.Items.AddRange(objs.BossList.Values.ToArray());
                    prmLabel.Text = "Level";
                    break;
                case 4:
                    typeDrop.Items.AddRange(objs.EnemyList.Values.ToArray());
                    prmLabel.Text = "Behavior";
                    break;
            }
            typeDrop.SelectedIndex = 0;
            UpdateRender();
        }

        private void typeDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (categDrop.SelectedIndex)
            {
                case 0:
                    type.Value = objs.ObjectList.FirstOrDefault(x => x.Value == typeDrop.Text).Key;
                    return;
                case 1:
                    type.Value = objs.CarriablesList.FirstOrDefault(x => x.Value == typeDrop.Text).Key;
                    return;
                case 2:
                    type.Value = objs.ItemList.FirstOrDefault(x => x.Value == typeDrop.Text).Key;
                    return;
                case 3:
                    type.Value = objs.BossList.FirstOrDefault(x => x.Value == typeDrop.Text).Key;
                    return;
                case 4:
                    type.Value = objs.EnemyList.FirstOrDefault(x => x.Value == typeDrop.Text).Key;
                    return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            param.Value = 0;
            param.Enabled = checkBox1.Checked;
        }
        public void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
        }

        private void SpriteEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.RefreshEditor();
        }
    }
}