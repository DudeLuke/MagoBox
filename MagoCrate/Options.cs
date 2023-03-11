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

namespace MagoCrate
{
    public partial class Options : Form
    {
        public bool levelActive = false;
        public Options(bool inLevel)
        {
            InitializeComponent();
            ReadOptions();
            levelActive = inLevel;
        }
        private void ReadOptions()
        {
            rtmColors.Checked = Properties.Settings.Default.rtmColorsON;
            rtmLabels.Checked = Properties.Settings.Default.rtmLabelsON;
            spriteRangeValue.Value = (decimal)Properties.Settings.Default.entityCullRange;
            DecoViewType.SelectedIndex = Properties.Settings.Default.DecoViewIndex;
            ActiveForm.BackColor = Properties.Settings.Default.MainColor;
            BackColor = Properties.Settings.Default.MainColor;
            mainColorButton.BackColor = Properties.Settings.Default.MainColor;
            objColorButton.BackColor = Properties.Settings.Default.ObjColor;
            CarryColorButton.BackColor = Properties.Settings.Default.CarryColor;
            itemColorButton.BackColor = Properties.Settings.Default.ItemColor;
            BossColorButton.BackColor = Properties.Settings.Default.BossColor;
            EnemyColorButton.BackColor = Properties.Settings.Default.EnemyColor;
            behaviorBox.Checked = Properties.Settings.Default.autoBehavior;
            if (string.IsNullOrEmpty(Properties.Settings.Default.FDGAutoFilePath))
            {
                fdgFilePathBox.Text = "Click to set the FDG Archive Filepath";
            } else
            {
                fdgFilePathBox.Text = Properties.Settings.Default.FDGAutoFilePath;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Magobox Link
            System.Diagnostics.Process.Start("https://github.com/firubii/MagoBox");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //GameBanana Link
            System.Diagnostics.Process.Start("https://gamebanana.com/members/1911763");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Discord Link
            System.Diagnostics.Process.Start("https://discord.gg/CaaUeAC6xm");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Youtube Link
            System.Diagnostics.Process.Start("https://www.youtube.com/@DudeLukeRtDL");
        }

        private void rtmColors_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.rtmColorsON = rtmColors.Checked;
            Properties.Settings.Default.Save();
            if (rtmColors.Checked)
            {
                objColorButton.BackColor = Properties.Settings.Default.ItemColor;
                CarryColorButton.BackColor = Properties.Settings.Default.ObjColor;
                itemColorButton.BackColor = Properties.Settings.Default.CarryColor;
            } else
            {
                objColorButton.BackColor = Properties.Settings.Default.ObjColor;
                CarryColorButton.BackColor = Properties.Settings.Default.CarryColor;
                itemColorButton.BackColor = Properties.Settings.Default.ItemColor;
            }
        }

        private void rtmLabels_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.rtmLabelsON = rtmLabels.Checked;
            Properties.Settings.Default.Save();
        }
        private void reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PixelsPerTile = 20;
            Properties.Settings.Default.rtmColorsON = false;
            Properties.Settings.Default.rtmLabelsON = false;
            Properties.Settings.Default.entityCullRange = 5;
            Properties.Settings.Default.DecoViewIndex = 0;
            Properties.Settings.Default.MainColor = Color.FromArgb(64, 64, 64);
            Properties.Settings.Default.ObjColor = Color.FromArgb(219, 255, 215);
            Properties.Settings.Default.CarryColor = Color.FromArgb(210, 214, 255);
            Properties.Settings.Default.ItemColor = Color.FromArgb(255, 248, 208);
            Properties.Settings.Default.BossColor = Color.FromArgb(250, 208, 255);
            Properties.Settings.Default.EnemyColor = Color.FromArgb(255, 210, 210);
            Properties.Settings.Default.FDGAutoFilePath = "";
            Properties.Settings.Default.Save();
            Properties.Settings.Default.autoBehavior = true;
            ReadOptions();
        }
        private void mainColorButton_Click(object sender, EventArgs e)
        {
            if (!levelActive)
            {
                mainColorDLG.Color = Properties.Settings.Default.MainColor;
                if (mainColorDLG.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.MainColor = mainColorDLG.Color;
                    Properties.Settings.Default.Save();
                    mainColorButton.BackColor = mainColorDLG.Color;
                    BackColor = Properties.Settings.Default.MainColor;
                }
            }
        }

        private void objColorButton_Click(object sender, EventArgs e)
        {
            if (!levelActive)
            {
                if (Properties.Settings.Default.rtmColorsON)
                {
                    mainColorDLG.Color = Properties.Settings.Default.ItemColor;
                    if (mainColorDLG.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.ItemColor = mainColorDLG.Color;
                        Properties.Settings.Default.Save();
                        objColorButton.BackColor = mainColorDLG.Color;
                    }
                }
                else
                {
                    mainColorDLG.Color = Properties.Settings.Default.ObjColor;
                    if (mainColorDLG.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.ObjColor = mainColorDLG.Color;
                        Properties.Settings.Default.Save();
                        objColorButton.BackColor = mainColorDLG.Color;
                    }
                }
            }
        }

        private void CarryColorButton_Click(object sender, EventArgs e)
        {
            if (!levelActive)
            {
                if (Properties.Settings.Default.rtmColorsON)
                {
                    mainColorDLG.Color = Properties.Settings.Default.ObjColor;
                    if (mainColorDLG.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.ObjColor = mainColorDLG.Color;
                        Properties.Settings.Default.Save();
                        CarryColorButton.BackColor = mainColorDLG.Color;
                    }
                }
                else
                {
                    mainColorDLG.Color = Properties.Settings.Default.CarryColor;
                    if (mainColorDLG.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.CarryColor = mainColorDLG.Color;
                        Properties.Settings.Default.Save();
                        CarryColorButton.BackColor = mainColorDLG.Color;
                    }
                }
            }
        }

        private void itemColorButton_Click(object sender, EventArgs e)
        {
            if (!levelActive)
            {
                if (Properties.Settings.Default.rtmColorsON)
                {
                    mainColorDLG.Color = Properties.Settings.Default.CarryColor;
                    if (mainColorDLG.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.CarryColor = mainColorDLG.Color;
                        Properties.Settings.Default.Save();
                        itemColorButton.BackColor = mainColorDLG.Color;
                    }
                }
                else
                {
                    mainColorDLG.Color = Properties.Settings.Default.ItemColor;
                    if (mainColorDLG.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.ItemColor = mainColorDLG.Color;
                        Properties.Settings.Default.Save();
                        itemColorButton.BackColor = mainColorDLG.Color;
                    }
                }
            }
        }

        private void BossColorButton_Click(object sender, EventArgs e)
        {
            if (!levelActive)
            {
                mainColorDLG.Color = Properties.Settings.Default.BossColor;
                if (mainColorDLG.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.BossColor = mainColorDLG.Color;
                    Properties.Settings.Default.Save();
                    BossColorButton.BackColor = mainColorDLG.Color;
                }
            }
        }

        private void EnemyColorButton_Click(object sender, EventArgs e)
        {
            if (!levelActive)
            {
                mainColorDLG.Color = Properties.Settings.Default.EnemyColor;
                if (mainColorDLG.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.EnemyColor = mainColorDLG.Color;
                    Properties.Settings.Default.Save();
                    EnemyColorButton.BackColor = mainColorDLG.Color;
                }
            }
        }

        private void DecoViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DecoViewIndex = DecoViewType.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.entityCullRange = (float)spriteRangeValue.Value;
            Properties.Settings.Default.Save();
        }

        private void fdgFilePathBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "FDGH Data Files|*.dat";
            open.CheckFileExists = true;
            open.Multiselect = false;
            open.Title = "Select an FDGH Data File";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FDGAutoFilePath = open.FileName;
                fdgFilePathBox.Text = open.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear FDG Automatic Filepath
            Properties.Settings.Default.FDGAutoFilePath = "";
            fdgFilePathBox.Text = "Click to set the FDG Archive Filepath";
            Properties.Settings.Default.Save();
        }

        private void behaviorBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoBehavior = behaviorBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
