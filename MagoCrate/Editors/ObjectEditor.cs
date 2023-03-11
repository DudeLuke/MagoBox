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
    public partial class ObjectEditor : Form
    {
        public RDLLVL.Object obj;
        Objects objs = new Objects();
        MainForm main = new MainForm("");

        public ObjectEditor()
        {
            InitializeComponent();
        }

        private void ObjectEditor_Load(object sender, EventArgs e)
        {
            objDropDown.Items.AddRange(objs.ObjectList.Values.ToArray());
            RefreshColors();

            if (MagoCrate.Properties.Settings.Default.rtmLabelsON)
            {
                label2.Text = "Parameter xC";
                label3.Text = "Parameter x10";
                label4.Text = "Parameter x14";
                label5.Text = "Parameter x18";
                label6.Text = "Parameter x1C";
                label7.Text = "Parameter x20";
                label8.Text = "Parameter x24";
                label9.Text = "Parameter x28";
                label10.Text = "Parameter x2C";
                label11.Text = "Parameter x30";
                label12.Text = "Parameter x34";
                label13.Text = "Parameter x38";
                label18.Text = "Parameter x3C";
            } else
            {
                label2.Text = "Parameter 1";
                label3.Text = "Parameter 2";
                label4.Text = "Parameter 3";
                label5.Text = "Parameter 4";
                label6.Text = "Parameter 5";
                label7.Text = "Parameter 6";
                label8.Text = "Parameter 7";
                label9.Text = "Parameter 8";
                label10.Text = "Parameter 9";
                label11.Text = "Parameter 10";
                label12.Text = "Parameter 11";
                label13.Text = "Parameter 12";
                label18.Text = "Unknown";
            }

            type.Text = obj.Type.ToString();
            p1.Text = obj.Param1.ToString();
            p2.Text = obj.Param2.ToString();
            p3.Text = obj.Param3.ToString();
            p4.Text = obj.Param4.ToString();
            p5.Text = obj.Param5.ToString();
            p6.Text = obj.Param6.ToString();
            p7.Text = obj.Param7.ToString();
            p8.Text = obj.Param8.ToString();
            p9.Text = obj.Param9.ToString();
            p10.Text = obj.Param10.ToString();
            p11.Text = obj.Param11.ToString();
            p12.Text = obj.Param12.ToString();
            unk.Text = obj.Unknown.ToString();
            xCoord.Value = obj.X;
            xOffs.Value = obj.XOffset;
            yCoord.Value = obj.Y;
            yOffs.Value = obj.YOffset;
            objNotes.Text = main.UpdateNotes("Object", type.Text);
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
                obj.Unknown = uint.Parse(unk.Text, System.Globalization.NumberStyles.HexNumber);
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
                obj.Unknown = uint.Parse(unk.Text);
            }

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
                if (objs.ObjectList.ContainsKey(uint.Parse(type.Text)))
                {
                    objDropDown.Text = objs.ObjectList[uint.Parse(type.Text)];
                }
                else
                {
                    objDropDown.Text = "";
                }

                // Refresh object notes on type change via typing
                objNotes.Text = main.UpdateNotes("Object", type.Text);
            }
            catch { }
        }

        private void objDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

            type.Text = objs.ObjectList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();

            // Refresh object notes on type change via drop down
            objNotes.Text = main.UpdateNotes("Object", type.Text);
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
                unk.Text = uint.Parse(unk.Text).ToString("X8");
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
                unk.Text = uint.Parse(unk.Text, System.Globalization.NumberStyles.HexNumber).ToString();
            } catch { }
        }

        private void decBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Convert the dec box value into hexadecimal and display that value in the hex box
                hexBox.Text = uint.Parse(decBox.Text).ToString("X");
            }
            catch { }
        }

        private void hexBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Convert the hex box value into decimal and display that value in the dec box
                decBox.Text = uint.Parse(hexBox.Text, System.Globalization.NumberStyles.HexNumber).ToString();
            }
            catch { }
        }
        public void RefreshColors()
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            Color setColor = MagoCrate.Properties.Settings.Default.ObjColor;
            if (MagoCrate.Properties.Settings.Default.rtmColorsON) setColor = MagoCrate.Properties.Settings.Default.ItemColor;

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
            unk.BackColor = setColor;
            xCoord.BackColor = setColor;
            xOffs.BackColor = setColor;
            yCoord.BackColor = setColor;
            yOffs.BackColor = setColor;
            objNotes.BackColor = setColor;
            decBox.BackColor = setColor;
            hexBox.BackColor = setColor;
            save.BackColor = setColor;
            objDropDown.BackColor = setColor;
        }
    }
}
