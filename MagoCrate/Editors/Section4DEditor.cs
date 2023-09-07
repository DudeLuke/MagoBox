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
    public partial class Section4DEditor : Form
    {
        public Section4D obj;
        Objects objs = new Objects();
        MainForm main;

        public Section4DEditor(MainForm parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            RefreshColors();
            type.Text = obj.Type.ToString("X8");
            p1.Text = obj.Param1.ToString("X8");
            p2.Text = obj.Param2.ToString("X8");
            p3.Text = obj.Param3.ToString("X8");
            p4.Text = obj.Param4.ToString("X8");
            p5.Text = obj.Param5.ToString("X8");
            p6.Text = obj.Param6.ToString("X8");
            p7.Text = obj.Param7.ToString("X8");
            p8.Text = obj.Param8.ToString("X8");
            p9.Text = obj.Param9.ToString("X8");
            p10.Text = obj.Param10.ToString("X8");
            p11.Text = obj.Param11.ToString("X8");
            p12.Text = obj.Param12.ToString("X8");
            p13.Text = obj.Param13.ToString("X8");
            p14.Text = obj.Param14.ToString("X8");
            p15.Text = obj.Param15.ToString("X8");
            p16.Text = obj.Param16.ToString("X8");
        }

        private void save_Click(object sender, EventArgs e)
        {
            obj.Type = uint.Parse(type.Text);

            if (inHex.Checked)
            {
                obj.Param1 = uint.Parse(p1.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param2 = uint.Parse(p2.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param3 = uint.Parse(p3.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param4 = uint.Parse(p4.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param5 = uint.Parse(p5.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param6 = uint.Parse(p6.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param7 = uint.Parse(p7.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param8 = uint.Parse(p8.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param9 = uint.Parse(p9.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param10 = uint.Parse(p10.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param11 = uint.Parse(p11.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param12 = uint.Parse(p12.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param13 = uint.Parse(p13.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param14 = uint.Parse(p14.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param15 = uint.Parse(p15.Text, System.Globalization.NumberStyles.HexNumber);
                obj.Param16 = uint.Parse(p16.Text, System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                obj.Param1 = uint.Parse(p1.Text);
                obj.Param2 = uint.Parse(p2.Text);
                obj.Param3 = uint.Parse(p3.Text);
                obj.Param4 = uint.Parse(p4.Text);
                obj.Param5 = uint.Parse(p5.Text);
                obj.Param6 = uint.Parse(p6.Text);
                obj.Param7 = uint.Parse(p7.Text);
                obj.Param8 = uint.Parse(p8.Text);
                obj.Param9 = uint.Parse(p9.Text);
                obj.Param10 = uint.Parse(p10.Text);
                obj.Param11 = uint.Parse(p11.Text);
                obj.Param12 = uint.Parse(p12.Text);
                obj.Param13 = uint.Parse(p13.Text);
                obj.Param14 = uint.Parse(p14.Text);
                obj.Param15 = uint.Parse(p15.Text);
                obj.Param16 = uint.Parse(p16.Text);
            }
            DialogResult = DialogResult.OK;
        }
        private void inHex_CheckedChanged(object sender, EventArgs e)
        {
            if (inHex.Checked) try
            {
                p1.Text = uint.Parse(p1.Text).ToString("X8");
                p2.Text = uint.Parse(p2.Text).ToString("X8");
                p3.Text = uint.Parse(p3.Text).ToString("X8");
                p4.Text = uint.Parse(p4.Text).ToString("X8");
                p5.Text = uint.Parse(p5.Text).ToString("X8");
                p6.Text = uint.Parse(p6.Text).ToString("X8");
                p7.Text = uint.Parse(p7.Text).ToString("X8");
                p8.Text = uint.Parse(p8.Text).ToString("X8");
                p9.Text = uint.Parse(p9.Text).ToString("X8");
                p10.Text = uint.Parse(p10.Text).ToString("X8");
                p11.Text = uint.Parse(p11.Text).ToString("X8");
                p12.Text = uint.Parse(p12.Text).ToString("X8");
                p13.Text = uint.Parse(p13.Text).ToString("X8");
                p14.Text = uint.Parse(p14.Text).ToString("X8");
                p15.Text = uint.Parse(p15.Text).ToString("X8");
                p16.Text = uint.Parse(p16.Text).ToString("X8");
            }
            catch { }
            else try
            {
                p1.Text = uint.Parse(p1.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p2.Text = uint.Parse(p2.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p3.Text = uint.Parse(p3.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p4.Text = uint.Parse(p4.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p5.Text = uint.Parse(p5.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p6.Text = uint.Parse(p6.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p7.Text = uint.Parse(p7.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p8.Text = uint.Parse(p8.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p9.Text = uint.Parse(p9.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p10.Text = uint.Parse(p10.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p11.Text = uint.Parse(p11.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p12.Text = uint.Parse(p12.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p13.Text = uint.Parse(p13.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p14.Text = uint.Parse(p14.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p15.Text = uint.Parse(p15.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                p16.Text = uint.Parse(p16.Text, System.Globalization.NumberStyles.HexNumber).ToString();
            } catch { }
        }
        public void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            Color setColor = MagoCrate.Properties.Settings.Default.Section4DColor;
            type.BackColor = setColor;
            p1.BackColor = setColor;
            p2.BackColor = setColor;
            p3.BackColor = setColor;
            p4.BackColor = setColor;
            p5.BackColor = setColor;
            p6.BackColor = setColor;
            p7.BackColor = setColor;
            p8.BackColor = setColor;
            p9.BackColor = setColor;
            p10.BackColor = setColor;
            p11.BackColor = setColor;
            p12.BackColor = setColor;
            p13.BackColor = setColor;
            p14.BackColor = setColor;
            p15.BackColor = setColor;
            p16.BackColor = setColor;
            save.BackColor = setColor;
        }
    }
}
