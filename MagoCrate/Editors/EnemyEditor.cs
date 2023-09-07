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
        MainForm main;

        public EnemyEditor(MainForm parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            objDropDown.Items.AddRange(objs.EnemyList.Values.ToArray());
            behaviorDropDown.Items.AddRange(objs.EnemyBehaviorList.Values.ToArray());
            RefreshColors();
            type.Text = obj.Type.ToString();
            behavior.Text = obj.Behavior.ToString();
            level.Text = obj.Level.ToString();
            dirType.Text = obj.DirectionType.ToString();
            sizeAd.Value = obj.SizeAD;
            sizeEx.Value = obj.SizeEX;
            movingId.Value = obj.MovingTerrainID;
            super.Checked = obj.HasSuperAbility;
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
            categNotes.Text = main.ReadNotes("Enemy", "Default");
            enemyNotes.Text = main.ReadNotes("Enemy", type.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);
            obj.Behavior = uint.Parse(behavior.Text);
            obj.Level = uint.Parse(level.Text);
            obj.DirectionType = uint.Parse(dirType.Text);
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
        private void saveNotes_Click(object sender, EventArgs e)
        {
            main.WriteNotes("Enemy", type.Text, enemyNotes.Text);
            main.WriteNotes("Enemy", "Default", categNotes.Text);
        }
        private void type_TextChanged(object sender, EventArgs e)
        {
            objDropDown.Text = "";
            try
            {
                if (objs.EnemyList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.EnemyList[uint.Parse(type.Text)];
                }

                // Refresh enemy notes on type change via typing
                enemyNotes.Text = main.ReadNotes("Enemy", type.Text);

                if (MagoCrate.Properties.Settings.Default.autoBehavior)
                {
                    // Behavior value changes to the most commonly used behavior of that enemy type.
                    behavior.Text = "0";
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
            enemyNotes.Text = main.ReadNotes("Enemy", type.Text);

            if (MagoCrate.Properties.Settings.Default.autoBehavior)
            {
                // Behavior value changes to the most commonly used behavior of that enemy type.
                if (objs.MostLikelyBehaviorList.ContainsKey(uint.Parse(type.Text)))
                {
                    behavior.Text = objs.MostLikelyBehaviorList[uint.Parse(type.Text)];
                    behaviorDropDown.Text = "";
                    try
                    {
                        if (objs.EnemyBehaviorList.ContainsKey(uint.Parse(behavior.Text)))
                        {
                            behaviorDropDown.Text = objs.EnemyBehaviorList[uint.Parse(behavior.Text)];
                        }
                    } catch { }
                }
            }
        }
        private void behavior_TextChanged(object sender, EventArgs e)
        {
            behaviorDropDown.Text = "";
            try
            {
                if (objs.EnemyBehaviorList.ContainsKey(uint.Parse(behavior.Text)))
                {
                    behaviorDropDown.Text = objs.EnemyBehaviorList[uint.Parse(behavior.Text)];
                }
            } catch { }
        }
        private void behaviorDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            behavior.Text = objs.EnemyBehaviorList.FirstOrDefault(x => x.Value == behaviorDropDown.Text).Key.ToString();
        }
        public void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            Color setColor = MagoCrate.Properties.Settings.Default.EnemyColor;
            type.BackColor = setColor;
            behavior.BackColor = setColor;
            level.BackColor = setColor;
            dirType.BackColor = setColor;
            movingId.BackColor = setColor;
            sizeAd.BackColor = setColor;
            sizeEx.BackColor = setColor;
            enemyNotes.BackColor = setColor;
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
