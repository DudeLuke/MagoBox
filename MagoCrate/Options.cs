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
        MainForm main;
        public Options(MainForm parent)
        {
            InitializeComponent();
            ReadOptions();
            main = parent;
        }
        private void ReadOptions()
        {
            try
            {
                rtmLabels.Checked = Properties.Settings.Default.rtmLabelsON;
                quickPickBox.Checked = Properties.Settings.Default.quickPickON;
                DecorType.SelectedIndex = Properties.Settings.Default.decorSetting;
                spriteRangeValue.Value = (decimal)Properties.Settings.Default.entityCullRange;
                BackColor = Properties.Settings.Default.MainColor;
                mainColorButton.BackColor = Properties.Settings.Default.MainColor;
                objColorButton.BackColor = Properties.Settings.Default.ObjColor;
                CarryColorButton.BackColor = Properties.Settings.Default.CarryColor;
                itemColorButton.BackColor = Properties.Settings.Default.ItemColor;
                BossColorButton.BackColor = Properties.Settings.Default.BossColor;
                EnemyColorButton.BackColor = Properties.Settings.Default.EnemyColor;
                DynamicColorButton.BackColor = Properties.Settings.Default.DynamicSectionColor;
                behaviorBox.Checked = Properties.Settings.Default.autoBehavior;
            }
            catch 
            {
                MessageBox.Show("Failed to load options, Resetting");
                Reset();
            }
            
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

        private void rtmLabels_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.rtmLabelsON = rtmLabels.Checked;
            Properties.Settings.Default.Save();
        }
        private void quickPickBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.quickPickON = quickPickBox.Checked;
            Properties.Settings.Default.Save();
        }
        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.RefreshEditor();
            main.SwitchTool(0);
        }
        private void Reset()
        {
            Properties.Settings.Default.PixelsPerTile = 20;
            Properties.Settings.Default.rtmLabelsON = false;
            Properties.Settings.Default.quickPickON = false;
            Properties.Settings.Default.decorSetting = 0;
            Properties.Settings.Default.entityCullRange = 5;
            Properties.Settings.Default.MainColor = Color.FromArgb(64, 64, 64);
            Properties.Settings.Default.ObjColor = Color.FromArgb(210, 255, 210);
            Properties.Settings.Default.CarryColor = Color.FromArgb(210, 210, 255);
            Properties.Settings.Default.ItemColor = Color.FromArgb(255, 255, 210);
            Properties.Settings.Default.BossColor = Color.FromArgb(250, 210, 255);
            Properties.Settings.Default.EnemyColor = Color.FromArgb(255, 210, 210);
            Properties.Settings.Default.DynamicSectionColor = Color.FromArgb(255, 220, 170);
            Properties.Settings.Default.FDGAutoFilePath = "";
            Properties.Settings.Default.autoBehavior = true;
            Properties.Settings.Default.Save();
            ReadOptions();
        }
        private void mainColorButton_Click(object sender, EventArgs e)
        {
            mainColorDLG.Color = Properties.Settings.Default.MainColor;
            if (mainColorDLG.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.MainColor = mainColorDLG.Color;
                Properties.Settings.Default.Save();
                mainColorButton.BackColor = mainColorDLG.Color;
                BackColor = Properties.Settings.Default.MainColor;
                main.RefreshColors();
            }
        }

        private void objColorButton_Click(object sender, EventArgs e)
        {
            mainColorDLG.Color = Properties.Settings.Default.ObjColor;
            if (mainColorDLG.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ObjColor = mainColorDLG.Color;
                Properties.Settings.Default.Save();
                objColorButton.BackColor = mainColorDLG.Color;
                main.RefreshColors();
            }
        }

        private void CarryColorButton_Click(object sender, EventArgs e)
        {
            mainColorDLG.Color = Properties.Settings.Default.CarryColor;
            if (mainColorDLG.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.CarryColor = mainColorDLG.Color;
                Properties.Settings.Default.Save();
                CarryColorButton.BackColor = mainColorDLG.Color;
                main.RefreshColors();
            }
        }

        private void itemColorButton_Click(object sender, EventArgs e)
        {
            mainColorDLG.Color = Properties.Settings.Default.ItemColor;
            if (mainColorDLG.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ItemColor = mainColorDLG.Color;
                Properties.Settings.Default.Save();
                itemColorButton.BackColor = mainColorDLG.Color;
                main.RefreshColors();
            }
        }

        private void BossColorButton_Click(object sender, EventArgs e)
        {
            mainColorDLG.Color = Properties.Settings.Default.BossColor;
            if (mainColorDLG.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BossColor = mainColorDLG.Color;
                Properties.Settings.Default.Save();
                BossColorButton.BackColor = mainColorDLG.Color;
                main.RefreshColors();
            }
        }

        private void EnemyColorButton_Click(object sender, EventArgs e)
        {
            mainColorDLG.Color = Properties.Settings.Default.EnemyColor;
            if (mainColorDLG.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.EnemyColor = mainColorDLG.Color;
                Properties.Settings.Default.Save();
                EnemyColorButton.BackColor = mainColorDLG.Color;
                main.RefreshColors();
            }
        }
        private void section4DColorButton_Click(object sender, EventArgs e)
        {
            mainColorDLG.Color = Properties.Settings.Default.DynamicSectionColor;
            if (mainColorDLG.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DynamicSectionColor = mainColorDLG.Color;
                Properties.Settings.Default.Save();
                DynamicColorButton.BackColor = mainColorDLG.Color;
                main.RefreshColors();
            }
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

        private void DecorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.decorSetting = DecorType.SelectedIndex;
            Properties.Settings.Default.Save();
        }
    }
}
