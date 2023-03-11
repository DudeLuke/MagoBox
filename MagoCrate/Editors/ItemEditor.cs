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
    public partial class ItemEditor : Form
    {
        public RDLLVL.Item obj;
        Objects objs = new Objects();
        MainForm main = new MainForm("");

        public ItemEditor()
        {
            InitializeComponent();
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            objDropDown.Items.AddRange(objs.ItemList.Values.ToArray());
            RefreshColors();
            type.Text = obj.Type.ToString();
            subtype.Text = obj.SubType.ToString();
            behavior.Text = obj.Behavior.ToString();
            movingId.Value = obj.MovingTerrainID;
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
            itemNotes.Text = main.UpdateNotes("Item", type.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);
            obj.SubType = uint.Parse(subtype.Text);
            obj.Behavior = uint.Parse(behavior.Text);
            obj.MovingTerrainID = (int)movingId.Value;
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
                if (objs.ItemList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.ItemList[uint.Parse(type.Text)];
                }
                else
                {
                    objDropDown.Text = "";
                }

                // Refresh item notes on type change via typing
                itemNotes.Text = main.UpdateNotes("Item", type.Text);
            }
            catch { }
        }

        private void objDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            type.Text = objs.ItemList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();

            // Refresh item notes on type change via drop down
            itemNotes.Text = main.UpdateNotes("Item", type.Text);
        }
        void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            Color setColor = MagoCrate.Properties.Settings.Default.ItemColor;
            if (MagoCrate.Properties.Settings.Default.rtmColorsON) setColor = MagoCrate.Properties.Settings.Default.CarryColor;

            type.BackColor = setColor;
            subtype.BackColor = setColor;
            behavior.BackColor = setColor;
            movingId.BackColor = setColor;
            xCoord.BackColor = setColor;
            xOffs.BackColor = setColor;
            yCoord.BackColor = setColor;
            yOffs.BackColor = setColor;
            itemNotes.BackColor = setColor;
            save.BackColor = setColor;
            objDropDown.BackColor = setColor;
        }
    }
}
