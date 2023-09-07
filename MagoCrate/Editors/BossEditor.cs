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
using RDLLVL;

namespace MagoBox.Editors
{
    public partial class BossEditor : Form
    {
        public RDLLVL.Boss obj;
        Objects objs = new Objects();
        MainForm main;

        public BossEditor(MainForm parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            objDropDown.Items.AddRange(objs.BossList.Values.ToArray());
            RefreshColors();
            type.Text = obj.Type.ToString();
            subType.Text = obj.Subtype.ToString("X");
            level.Text = obj.Level.ToString("X");
            unk.Text = obj.Unknown.ToString("X");
            movingId.Value = obj.MovingTerrainID;
            super.Checked = obj.HasSuperAbility;
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
            bossNotes.Text = main.ReadNotes("Boss", type.Text);
            categNotes.Text = main.ReadNotes("Boss", "Default");
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);
            obj.Subtype = uint.Parse(subType.Text, System.Globalization.NumberStyles.HexNumber);
            obj.Level = uint.Parse(level.Text, System.Globalization.NumberStyles.HexNumber);
            obj.Unknown = uint.Parse(unk.Text, System.Globalization.NumberStyles.HexNumber);
            obj.MovingTerrainID = (int)movingId.Value;
            obj.HasSuperAbility = super.Checked;
            obj.X = (uint)xCoord.Value;
            obj.XOffset = (uint)xOffs.Value;
            obj.Y = (uint)yCoord.Value;
            obj.YOffset = (uint)yOffs.Value;
            DialogResult = DialogResult.OK;
        }
        private void saveNotes_Click(object sender, EventArgs e)
        {
            main.WriteNotes("Boss", type.Text, bossNotes.Text);
            main.WriteNotes("Boss", "Default", categNotes.Text);
        }

        private void type_TextChanged(object sender, EventArgs e)
        {
            objDropDown.Text = "";
            try
            {
                if (objs.BossList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.BossList[uint.Parse(type.Text)];
                }

                // Refresh boss notes on type change via typing
                bossNotes.Text = main.ReadNotes("Boss", type.Text);
            }
            catch { }
        }

        private void objDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            type.Text = objs.BossList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();

            // Refresh boss notes on type change via drop down
            bossNotes.Text = main.ReadNotes("Boss", type.Text);
        }

        public void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            Color setColor = MagoCrate.Properties.Settings.Default.BossColor;
            type.BackColor = setColor;
            subType.BackColor = setColor;
            level.BackColor = setColor;
            unk.BackColor = setColor;
            movingId.BackColor = setColor;
            bossNotes.BackColor = setColor;
            categNotes.BackColor = setColor;
            xCoord.BackColor = setColor;
            xOffs.BackColor = setColor;
            yCoord.BackColor = setColor;
            yOffs.BackColor = setColor;
            save.BackColor = setColor;
            saveNotes.BackColor = setColor;
            objDropDown.BackColor = setColor;
        }
    }
}
