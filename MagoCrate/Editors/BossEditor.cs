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
        MainForm main = new MainForm("");

        public BossEditor()
        {
            InitializeComponent();
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            objDropDown.Items.AddRange(objs.BossList.Values.ToArray());
            RefreshColors();
            type.Text = obj.Type.ToString();
            p1.Text = obj.Param1.ToString("X");
            p2.Text = obj.Param2.ToString("X");
            p3.Text = obj.Param3.ToString("X");
            super.Checked = obj.HasSuperAbility;
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
            bossNotes.Text = main.UpdateNotes("Boss", type.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);
            obj.Param1 = uint.Parse(p1.Text, System.Globalization.NumberStyles.HexNumber);
            obj.Param2 = uint.Parse(p2.Text, System.Globalization.NumberStyles.HexNumber);
            obj.Param3 = uint.Parse(p3.Text, System.Globalization.NumberStyles.HexNumber);
            obj.HasSuperAbility = super.Checked;
            obj.X = (uint)xCoord.Value;
            obj.XOffset = (uint)xOffs.Value;
            obj.Y = (uint)yCoord.Value;
            obj.YOffset = (uint)yOffs.Value;
            DialogResult = DialogResult.OK;
        }

        private void type_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (objs.BossList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.BossList[uint.Parse(type.Text)];
                }
                else
                {
                    objDropDown.Text = "";
                }

                // Refresh boss notes on type change via typing
                bossNotes.Text = main.UpdateNotes("Boss", type.Text);
            }
            catch { }
        }

        private void objDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            type.Text = objs.BossList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();

            // Refresh boss notes on type change via drop down
            bossNotes.Text = main.UpdateNotes("Boss", type.Text);
        }

        public void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            Color setColor = MagoCrate.Properties.Settings.Default.BossColor;
            type.BackColor = setColor;
            p1.BackColor = setColor;
            p2.BackColor = setColor;
            p3.BackColor = setColor;
            bossNotes.BackColor = setColor;
            xCoord.BackColor = setColor;
            xOffs.BackColor = setColor;
            yCoord.BackColor = setColor;
            yOffs.BackColor = setColor;
            save.BackColor = setColor;
            objDropDown.BackColor = setColor;
        }
    }
}
