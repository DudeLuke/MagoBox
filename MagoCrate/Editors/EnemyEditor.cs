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
    public partial class EnemyEditor : Form
    {
        public RDLLVL.Enemy obj;
        Objects objs = new Objects();
        MainForm main = new MainForm("");

        public EnemyEditor()
        {
            InitializeComponent();
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            objDropDown.Items.AddRange(objs.EnemyList.Values.ToArray());
            RefreshColors();
            type.Text = obj.Type.ToString();
            behavior.Text = obj.Behavior.ToString();
            p1.Text = obj.Param1.ToString();
            p2.Text = obj.Param2.ToString();
            sizeAd.Value = obj.SizeAD;
            sizeEx.Value = obj.SizeEX;
            movingId.Value = obj.MovingTerrainID;
            super.Checked = obj.HasSuperAbility;
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
            enemyNotes.Text = main.UpdateNotes("Enemy", type.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);
            obj.Behavior = uint.Parse(behavior.Text);
            obj.Param1 = uint.Parse(p1.Text);
            obj.Param2 = uint.Parse(p2.Text);
            obj.SizeAD = (uint)sizeAd.Value;
            obj.SizeEX = (uint)sizeEx.Value;
            obj.MovingTerrainID = (int)movingId.Value;
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
                if (objs.EnemyList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.EnemyList[uint.Parse(type.Text)];
                }
                else
                {
                    objDropDown.Text = "";
                }

                // Refresh enemy notes on type change via typing
                enemyNotes.Text = main.UpdateNotes("Enemy", type.Text);

                if (MagoCrate.Properties.Settings.Default.autoBehavior)
                {
                    // Behavior value changes to the most commonly used behavior of that enemy type.
                    if (objs.MostLikelyBehaviorList.ContainsKey(uint.Parse(type.Text)))
                    {
                        behavior.Text = objs.MostLikelyBehaviorList[uint.Parse(type.Text)];
                    }
                }
            }
            catch { }
        }

        private void objDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            type.Text = objs.EnemyList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();

            // Refresh enemy notes on type change via drop down
            enemyNotes.Text = main.UpdateNotes("Enemy", type.Text);

            if (MagoCrate.Properties.Settings.Default.autoBehavior)
            {
                // Behavior value changes to the most commonly used behavior of that enemy type.
                if (objs.MostLikelyBehaviorList.ContainsKey(uint.Parse(type.Text)))
                {
                    behavior.Text = objs.MostLikelyBehaviorList[uint.Parse(type.Text)];
                }
            }
        }
        public void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            Color setColor = MagoCrate.Properties.Settings.Default.EnemyColor;
            type.BackColor = setColor;
            behavior.BackColor = setColor;
            p1.BackColor = setColor;
            p2.BackColor = setColor;
            movingId.BackColor = setColor;
            sizeAd.BackColor = setColor;
            sizeEx.BackColor = setColor;
            enemyNotes.BackColor = setColor;
            xCoord.BackColor = setColor;
            xOffs.BackColor = setColor;
            yCoord.BackColor = setColor;
            yOffs.BackColor = setColor;
            save.BackColor = setColor;
            objDropDown.BackColor = setColor;
        }
    }
}
