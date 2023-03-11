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
    public partial class SpecialItemEditor : Form
    {
        public RDLLVL.SpecialItem obj;
        Objects objs = new Objects();
        MainForm main = new MainForm("");

        public SpecialItemEditor()
        {
            InitializeComponent();
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            RefreshColors();
            objDropDown.Items.AddRange(objs.CarriablesList.Values.ToArray());
            type.Text = obj.Type.ToString();
            appearId.Text = obj.AppearID.ToString();
            movingId.Value = obj.MovingTerrainID;
            respawn.Checked = obj.Respawn;
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
            specItemNotes.Text = main.UpdateNotes("Carriable", type.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);
            obj.AppearID = uint.Parse(appearId.Text);
            obj.MovingTerrainID = (int)movingId.Value;
            obj.Respawn = respawn.Checked;
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
                if (objs.CarriablesList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.CarriablesList[uint.Parse(type.Text)];
                }
                else
                {
                    objDropDown.Text = "";
                }

                // Refresh enemy notes on type change via typing
                specItemNotes.Text = main.UpdateNotes("Carriable", type.Text);

            } catch { }
        }

        private void objDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            type.Text = objs.CarriablesList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();

            // Refresh enemy notes on type change via drop down
            specItemNotes.Text = main.UpdateNotes("Carriable", type.Text);
        }
        void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            Color setColor = MagoCrate.Properties.Settings.Default.CarryColor;
            if (MagoCrate.Properties.Settings.Default.rtmColorsON) setColor = MagoCrate.Properties.Settings.Default.ObjColor;

            type.BackColor = setColor;
            appearId.BackColor = setColor;
            movingId.BackColor = setColor;
            xCoord.BackColor = setColor;
            xOffs.BackColor = setColor;
            yCoord.BackColor = setColor;
            yOffs.BackColor = setColor;
            specItemNotes.BackColor = setColor;
            save.BackColor = setColor;
            objDropDown.BackColor = setColor;
        }
    }
}
