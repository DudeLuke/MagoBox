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

namespace MagoBox.Editors
{
    public partial class StageSettings : Form
    {
        public Stage data;
        public uint tileset;
        public uint background;
        Objects objs = new Objects();
        MainForm main;
        public List<DynamicAction> tempEvents = new List<DynamicAction>();
        public List<Section4D> temp4DSections = new List<Section4D>();

        public StageSettings(MainForm parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void StageSettings_Load(object sender, EventArgs e)
        {
            BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            tabPage1.BackColor = MagoCrate.Properties.Settings.Default.MainColor;
            tabPage3.BackColor = MagoCrate.Properties.Settings.Default.MainColor;

            bgDropDown.Items.AddRange(objs.DecorationList.Values.ToArray());
            tilesetDropDown.Items.AddRange(objs.DecorationList.Values.ToArray());
            filterDropDown.Items.AddRange(objs.FilterList.Values.ToArray());
            runEffectDropDown.Items.AddRange(objs.RunEffectList.Values.ToArray());
            bgmDropDown.Items.AddRange(objs.BGMList.ToArray());

            x.Text = data.BgX.ToString();
            y.Text = data.BgY.ToString();
            z.Text = data.BgZ.ToString();
            xrot.Text = data.BgRotX.ToString();
            yrot.Text = data.BgRotY.ToString();
            zrot.Text = data.BgRotZ.ToString();
            dist.Text = data.BgDistance.ToString();

            scrollx.Text = data.BgScrollSpeedX.ToString();
            scrolly.Text = data.BgScrollSpeedY.ToString();
            scrolldx.Text = data.BgScrollDownX.ToString();
            scrollbx.Text = data.BgScrollBackX.ToString();
            scrollry.Text = data.BgScrollRightY.ToString();
            scrollby.Text = data.BgScrollBackY.ToString();

            bgDropDown.Text = objs.DecorationList[background];
            tilesetDropDown.Text = objs.DecorationList[tileset];
            filterDropDown.Text = objs.FilterList[data.Filter];
            runEffectDropDown.Text = objs.RunEffectList[data.RunEffect];
            bgmDropDown.Text = data.BGM;

            respawnId.Text = data.DeathStartID.ToString();
            stepChange.Text = data.DeathStepChange.ToString();
            changeStep.Checked = Convert.ToBoolean(data.DeathStepFlag);

            UpdateSection4DList();
            if (section4DList.Items.Count > 0) section4DList.SelectedIndex = 0;
        }

        private void changeStep_CheckedChanged(object sender, EventArgs e)
        {
            stepChange.Enabled = changeStep.Checked;
            stepChange.Text = "0";
        }

        private void save_Click(object sender, EventArgs e)
        {
            data.BgX = float.Parse(x.Text);
            data.BgY = float.Parse(y.Text);
            data.BgZ = float.Parse(z.Text);
            data.BgRotX = float.Parse(xrot.Text);
            data.BgRotY = float.Parse(yrot.Text);
            data.BgRotZ = float.Parse(zrot.Text);
            data.BgDistance = float.Parse(dist.Text);

            data.BgScrollSpeedX = float.Parse(scrollx.Text);
            data.BgScrollSpeedY = float.Parse(scrolly.Text);
            data.BgScrollDownX = float.Parse(scrolldx.Text);
            data.BgScrollBackX = float.Parse(scrollbx.Text);
            data.BgScrollRightY = float.Parse(scrollry.Text);
            data.BgScrollBackY = float.Parse(scrollby.Text);

            background = objs.DecorationList.FirstOrDefault(x => x.Value == bgDropDown.Text).Key;
            tileset = objs.DecorationList.FirstOrDefault(x => x.Value == tilesetDropDown.Text).Key;
            data.Filter = objs.FilterList.FirstOrDefault(x => x.Value == filterDropDown.Text).Key;
            data.RunEffect = objs.RunEffectList.FirstOrDefault(x => x.Value == runEffectDropDown.Text).Key;
            data.BGM = bgmDropDown.Text;

            data.DeathStartID = uint.Parse(respawnId.Text);
            data.DeathStepChange = int.Parse(stepChange.Text);
            data.DeathStepFlag = Convert.ToUInt32(changeStep.Checked);
            DialogResult = DialogResult.OK;
        }
        private void UpdateSection4DList()
        {
            section4DList.Items.Clear();
            section4DList.BeginUpdate();
            for (int i = 0; i < temp4DSections.Count; i++)
            {
                section4DList.Items.Add($"Unknown ({temp4DSections[i].Type})");
            }
            section4DList.EndUpdate();
        }
        private void UpdateSelectedSection4D(int ID)
        {
            try
            {
                sec4Dtype.Text = temp4DSections[ID].Type.ToString("X8");
                sec4Dp1.Text = temp4DSections[ID].Param1.ToString("X8");
                sec4Dp2.Text = temp4DSections[ID].Param2.ToString("X8");
                sec4Dp3.Text = temp4DSections[ID].Param3.ToString("X8");
                sec4Dp4.Text = temp4DSections[ID].Param4.ToString("X8");
                sec4Dp5.Text = temp4DSections[ID].Param5.ToString("X8");
                sec4Dp6.Text = temp4DSections[ID].Param6.ToString("X8");
                sec4Dp7.Text = temp4DSections[ID].Param7.ToString("X8");
                sec4Dp8.Text = temp4DSections[ID].Param8.ToString("X8");
                sec4Dp9.Text = temp4DSections[ID].Param9.ToString("X8");
                sec4Dp10.Text = temp4DSections[ID].Param10.ToString("X8");
                sec4Dp11.Text = temp4DSections[ID].Param11.ToString("X8");
                sec4Dp12.Text = temp4DSections[ID].Param12.ToString("X8");
                sec4Dp13.Text = temp4DSections[ID].Param13.ToString("X8");
                sec4Dp14.Text = temp4DSections[ID].Param14.ToString("X8");
                sec4Dp15.Text = temp4DSections[ID].Param15.ToString("X8");
                sec4Dp16.Text = temp4DSections[ID].Param16.ToString("X8");
            } catch { }
        }
        private void section4DList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedSection4D(section4DList.SelectedIndex);
        }

        private void saveSection4D_Click(object sender, EventArgs e)
        {
            try
            {
                Section4D newSection4D = new Section4D();
                newSection4D.Type = uint.Parse(sec4Dtype.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param1 = uint.Parse(sec4Dp1.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param2 = uint.Parse(sec4Dp2.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param3 = uint.Parse(sec4Dp3.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param4 = uint.Parse(sec4Dp4.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param5 = uint.Parse(sec4Dp5.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param6 = uint.Parse(sec4Dp6.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param7 = uint.Parse(sec4Dp7.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param8 = uint.Parse(sec4Dp8.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param9 = uint.Parse(sec4Dp9.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param10 = uint.Parse(sec4Dp10.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param11 = uint.Parse(sec4Dp11.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param12 = uint.Parse(sec4Dp12.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param13 = uint.Parse(sec4Dp13.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param14 = uint.Parse(sec4Dp14.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param15 = uint.Parse(sec4Dp15.Text, System.Globalization.NumberStyles.HexNumber);
                newSection4D.Param16 = uint.Parse(sec4Dp16.Text, System.Globalization.NumberStyles.HexNumber);
                temp4DSections[section4DList.SelectedIndex] = newSection4D;
                UpdateSection4DList();
            }
            catch { MessageBox.Show("Failed To Save 4D Section"); }
        }

        private void add4DSection_Click(object sender, EventArgs e)
        {
            temp4DSections.Add(new Section4D());
            UpdateSection4DList();
        }

        private void del4DSection_Click(object sender, EventArgs e)
        {
            try
            {
                temp4DSections.RemoveAt(section4DList.SelectedIndex);
                UpdateSection4DList();
            } catch { }
        }
    }
}
