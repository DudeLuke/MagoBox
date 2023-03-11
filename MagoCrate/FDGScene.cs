using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDLLVL;

namespace MagoCrate
{
    public partial class FDGScene : Form
    {
        public string selectedScene;
        public bool clearing;
        Objects objs = new Objects();
        public FDGScene()
        {
            InitializeComponent();
        }
        private void FDGScene_Load(object sender, EventArgs e)
        {
            BackColor = Properties.Settings.Default.MainColor;
            scene.Items.AddRange(objs.levelFDGs.Values.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(scene.Text))
            {
                clearing = clearBox.Checked;
                selectedScene = objs.levelFDGs.FirstOrDefault(x => x.Value == scene.Text).Key;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
