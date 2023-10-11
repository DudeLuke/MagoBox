
namespace MagoCrate
{
    partial class DynamicTerrainEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.materialList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vmat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.acceleration = new System.Windows.Forms.ComboBox();
            this.prm1 = new System.Windows.Forms.NumericUpDown();
            this.prm2 = new System.Windows.Forms.NumericUpDown();
            this.accelTime = new System.Windows.Forms.NumericUpDown();
            this.unk3 = new System.Windows.Forms.NumericUpDown();
            this.addendum = new System.Windows.Forms.TextBox();
            this.resetCamera = new System.Windows.Forms.Button();
            this.direction = new System.Windows.Forms.ComboBox();
            this.distance = new System.Windows.Forms.NumericUpDown();
            this.mainColorDLG = new System.Windows.Forms.ColorDialog();
            this.glControl = new OpenTK.GLControl();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nullTile = new System.Windows.Forms.CheckBox();
            this.vShape = new System.Windows.Forms.NumericUpDown();
            this.colImg = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.autoStart = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eventID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pick = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clonePhase = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.unk2 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.isEnd = new System.Windows.Forms.CheckBox();
            this.delPhase = new System.Windows.Forms.Button();
            this.addPhase = new System.Windows.Forms.Button();
            this.duration = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.unk1 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phaseList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.vmat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colImg)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventID)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).BeginInit();
            this.SuspendLayout();
            // 
            // materialList
            // 
            this.materialList.FormattingEnabled = true;
            this.materialList.Items.AddRange(new object[] {
            "Default",
            "Grass",
            "Wood",
            "Stone",
            "Sand",
            "Snow",
            "Clouds",
            "Metal"});
            this.materialList.Location = new System.Drawing.Point(68, 71);
            this.materialList.Name = "materialList";
            this.materialList.Size = new System.Drawing.Size(81, 24);
            this.materialList.TabIndex = 114;
            this.toolTip1.SetToolTip(this.materialList, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.");
            this.materialList.SelectedIndexChanged += new System.EventHandler(this.materialList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 110;
            this.label8.Text = "Material";
            this.toolTip1.SetToolTip(this.label8, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.");
            // 
            // vmat
            // 
            this.vmat.Location = new System.Drawing.Point(156, 72);
            this.vmat.Margin = new System.Windows.Forms.Padding(4);
            this.vmat.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.vmat.Name = "vmat";
            this.vmat.Size = new System.Drawing.Size(55, 22);
            this.vmat.TabIndex = 111;
            this.toolTip1.SetToolTip(this.vmat, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.\r\n");
            this.vmat.ValueChanged += new System.EventHandler(this.vmat_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 116;
            this.label1.Text = "Event ID";
            this.toolTip1.SetToolTip(this.label1, "Change the event ID that starts\r\nthe movement for this section.\r\n(Only available " +
        "when this section\r\ndoesn\'t automatically move.)");
            // 
            // acceleration
            // 
            this.acceleration.FormattingEnabled = true;
            this.acceleration.Items.AddRange(new object[] {
            "Instant Acceleration",
            "Unknown",
            "Unknown",
            "Unknown",
            "Ease In And Out"});
            this.acceleration.Location = new System.Drawing.Point(113, 415);
            this.acceleration.Name = "acceleration";
            this.acceleration.Size = new System.Drawing.Size(143, 24);
            this.acceleration.TabIndex = 119;
            this.toolTip1.SetToolTip(this.acceleration, "The type of acceleration that\r\nthis movement phase will use\r\nwhen calculating its" +
        " speed.");
            this.acceleration.SelectedIndexChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // prm1
            // 
            this.prm1.Location = new System.Drawing.Point(139, 85);
            this.prm1.Margin = new System.Windows.Forms.Padding(4);
            this.prm1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.prm1.Name = "prm1";
            this.prm1.Size = new System.Drawing.Size(71, 22);
            this.prm1.TabIndex = 143;
            this.toolTip1.SetToolTip(this.prm1, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.\r\n");
            // 
            // prm2
            // 
            this.prm2.Location = new System.Drawing.Point(139, 115);
            this.prm2.Margin = new System.Windows.Forms.Padding(4);
            this.prm2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.prm2.Name = "prm2";
            this.prm2.Size = new System.Drawing.Size(71, 22);
            this.prm2.TabIndex = 144;
            this.toolTip1.SetToolTip(this.prm2, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.\r\n");
            // 
            // accelTime
            // 
            this.accelTime.Location = new System.Drawing.Point(190, 446);
            this.accelTime.Margin = new System.Windows.Forms.Padding(4);
            this.accelTime.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.accelTime.Name = "accelTime";
            this.accelTime.Size = new System.Drawing.Size(66, 22);
            this.accelTime.TabIndex = 143;
            this.toolTip1.SetToolTip(this.accelTime, "Hard to tell, but from most cases while\r\ntesting, this controls roughly how many\r" +
        "\nframes it takes for this section to reach\r\nfull speed when acceleration isn\'t i" +
        "nstant.\r\n");
            this.accelTime.ValueChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // unk3
            // 
            this.unk3.Location = new System.Drawing.Point(156, 476);
            this.unk3.Margin = new System.Windows.Forms.Padding(4);
            this.unk3.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.unk3.Name = "unk3";
            this.unk3.Size = new System.Drawing.Size(101, 22);
            this.unk3.TabIndex = 148;
            this.toolTip1.SetToolTip(this.unk3, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.\r\n");
            this.unk3.ValueChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // addendum
            // 
            this.addendum.Location = new System.Drawing.Point(8, 387);
            this.addendum.Name = "addendum";
            this.addendum.Size = new System.Drawing.Size(249, 22);
            this.addendum.TabIndex = 149;
            this.toolTip1.SetToolTip(this.addendum, "Additional Hexadecimal values that\r\nare leftover that I don\'t yet understand.\r\nLe" +
        "t me know if you find anything!");
            this.addendum.TextChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // resetCamera
            // 
            this.resetCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetCamera.Location = new System.Drawing.Point(630, 41);
            this.resetCamera.Margin = new System.Windows.Forms.Padding(4);
            this.resetCamera.Name = "resetCamera";
            this.resetCamera.Size = new System.Drawing.Size(109, 41);
            this.resetCamera.TabIndex = 141;
            this.resetCamera.Text = "Reset Camera";
            this.toolTip1.SetToolTip(this.resetCamera, "Moves the camera back to the\r\nwithin the level\'s boundaries.\r\n");
            this.resetCamera.UseVisualStyleBackColor = true;
            this.resetCamera.Click += new System.EventHandler(this.resetCamera_Click);
            // 
            // direction
            // 
            this.direction.FormattingEnabled = true;
            this.direction.Items.AddRange(new object[] {
            "Up",
            "Right",
            "Down",
            "Left",
            "Unknown"});
            this.direction.Location = new System.Drawing.Point(155, 162);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(102, 24);
            this.direction.TabIndex = 116;
            this.toolTip1.SetToolTip(this.direction, "Change which direction\r\nthis movement phase\r\nwill travel.");
            this.direction.SelectedIndexChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(155, 193);
            this.distance.Margin = new System.Windows.Forms.Padding(4);
            this.distance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(102, 22);
            this.distance.TabIndex = 116;
            this.toolTip1.SetToolTip(this.distance, "Change the distance (In tiles) that\r\nthat this movement phase will travel.\r\n");
            this.distance.ValueChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // mainColorDLG
            // 
            this.mainColorDLG.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // glControl
            // 
            this.glControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Location = new System.Drawing.Point(14, 14);
            this.glControl.Margin = new System.Windows.Forms.Padding(5);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(500, 500);
            this.glControl.TabIndex = 3;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseDown);
            this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseMove);
            this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseUp);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(139, 25);
            this.width.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(71, 22);
            this.width.TabIndex = 7;
            this.toolTip1.SetToolTip(this.width, "Width of this\r\nDynamic Terrain\r\n");
            this.width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.UpdateLevelSize);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(139, 55);
            this.height.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(71, 22);
            this.height.TabIndex = 8;
            this.toolTip1.SetToolTip(this.height, "Height of this\r\nDynamic Terrain");
            this.height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height.ValueChanged += new System.EventHandler(this.UpdateLevelSize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Width";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label2, "Width of this\r\nDynamic Terrain");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nullTile);
            this.groupBox1.Controls.Add(this.materialList);
            this.groupBox1.Controls.Add(this.vShape);
            this.groupBox1.Controls.Add(this.colImg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.vmat);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(522, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 136);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Collision";
            // 
            // nullTile
            // 
            this.nullTile.AutoSize = true;
            this.nullTile.Location = new System.Drawing.Point(129, 105);
            this.nullTile.Name = "nullTile";
            this.nullTile.Size = new System.Drawing.Size(81, 21);
            this.nullTile.TabIndex = 115;
            this.nullTile.Text = "Null Tile";
            this.toolTip1.SetToolTip(this.nullTile, "Null tiles get skipped over\r\nover when saved, taking up \r\nless space in the level" +
        " file.");
            this.nullTile.UseVisualStyleBackColor = true;
            this.nullTile.CheckedChanged += new System.EventHandler(this.nullTile_CheckedChanged);
            // 
            // vShape
            // 
            this.vShape.Location = new System.Drawing.Point(156, 28);
            this.vShape.Margin = new System.Windows.Forms.Padding(4);
            this.vShape.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.vShape.Name = "vShape";
            this.vShape.Size = new System.Drawing.Size(55, 22);
            this.vShape.TabIndex = 113;
            this.toolTip1.SetToolTip(this.vShape, "The shape\r\nof the tile.");
            this.vShape.ValueChanged += new System.EventHandler(this.vShape_ValueChanged);
            // 
            // colImg
            // 
            this.colImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colImg.Image = global::MagoCrate.Properties.Resources._0;
            this.colImg.Location = new System.Drawing.Point(109, 22);
            this.colImg.Margin = new System.Windows.Forms.Padding(4);
            this.colImg.Name = "colImg";
            this.colImg.Size = new System.Drawing.Size(40, 37);
            this.colImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colImg.TabIndex = 112;
            this.colImg.TabStop = false;
            this.toolTip1.SetToolTip(this.colImg, "Click here to select\r\na collision shape!");
            this.colImg.Click += new System.EventHandler(this.colImg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(8, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 109;
            this.label7.Text = "Shape\r\n";
            this.toolTip1.SetToolTip(this.label7, "The shape\r\nof the tile.");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prm2);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Controls.Add(this.prm1);
            this.groupBox2.Controls.Add(this.autoStart);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.eventID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.width);
            this.groupBox2.Controls.Add(this.height);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(522, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 289);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Values";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.White;
            this.save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save.Location = new System.Drawing.Point(7, 254);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(204, 28);
            this.save.TabIndex = 139;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.Checked = true;
            this.autoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoStart.Location = new System.Drawing.Point(16, 161);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(158, 21);
            this.autoStart.TabIndex = 116;
            this.autoStart.Text = "Moves Automatically";
            this.toolTip1.SetToolTip(this.autoStart, "Choose whether this section will\r\nmove as soon as it\'s loaded, or \r\nwhen an event" +
        " ID, i.e. a switch, \r\nis activated.");
            this.autoStart.UseVisualStyleBackColor = true;
            this.autoStart.CheckedChanged += new System.EventHandler(this.autoStart_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(13, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Parameter 2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventID
            // 
            this.eventID.Location = new System.Drawing.Point(140, 189);
            this.eventID.Margin = new System.Windows.Forms.Padding(4);
            this.eventID.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.eventID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.eventID.Name = "eventID";
            this.eventID.Size = new System.Drawing.Size(71, 22);
            this.eventID.TabIndex = 116;
            this.toolTip1.SetToolTip(this.eventID, "Change the event ID that starts\r\nthe movement for this section.\r\n(Only available " +
        "when this section\r\ndoesn\'t automatically move.)");
            this.eventID.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label4, "Height of this\r\nDynamic Terrain\r\n");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Parameter 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pick
            // 
            this.pick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pick.BackgroundImage = global::MagoCrate.Properties.Resources.pick;
            this.pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pick.Location = new System.Drawing.Point(571, 41);
            this.pick.Margin = new System.Windows.Forms.Padding(4);
            this.pick.Name = "pick";
            this.pick.Size = new System.Drawing.Size(41, 41);
            this.pick.TabIndex = 137;
            this.toolTip1.SetToolTip(this.pick, "Copy tile data by\r\nclicking on a tile.");
            this.pick.UseVisualStyleBackColor = false;
            this.pick.Click += new System.EventHandler(this.pick_Click);
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.draw.BackgroundImage = global::MagoCrate.Properties.Resources.draw;
            this.draw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.draw.Location = new System.Drawing.Point(522, 41);
            this.draw.Margin = new System.Windows.Forms.Padding(4);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(41, 41);
            this.draw.TabIndex = 136;
            this.toolTip1.SetToolTip(this.draw, "Click tiles to overwrite\r\ntheir tile data.");
            this.draw.UseVisualStyleBackColor = false;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(548, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 138;
            this.label11.Text = "Tools";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clonePhase);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.addendum);
            this.groupBox3.Controls.Add(this.unk3);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.unk2);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.accelTime);
            this.groupBox3.Controls.Add(this.isEnd);
            this.groupBox3.Controls.Add(this.delPhase);
            this.groupBox3.Controls.Add(this.addPhase);
            this.groupBox3.Controls.Add(this.duration);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.unk1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.delay);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.acceleration);
            this.groupBox3.Controls.Add(this.distance);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.direction);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.phaseList);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(747, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 507);
            this.groupBox3.TabIndex = 140;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movement";
            // 
            // clonePhase
            // 
            this.clonePhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.clonePhase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clonePhase.Location = new System.Drawing.Point(92, 127);
            this.clonePhase.Name = "clonePhase";
            this.clonePhase.Size = new System.Drawing.Size(80, 29);
            this.clonePhase.TabIndex = 151;
            this.clonePhase.Text = "Clone";
            this.toolTip1.SetToolTip(this.clonePhase, "Create a copy of the\r\nselected movement\r\nphase for this section.");
            this.clonePhase.UseVisualStyleBackColor = true;
            this.clonePhase.Click += new System.EventHandler(this.clonePhase_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(10, 367);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 17);
            this.label19.TabIndex = 150;
            this.label19.Text = "Addendum";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(12, 478);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 17);
            this.label18.TabIndex = 147;
            this.label18.Text = "Unknown 3";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unk2
            // 
            this.unk2.Location = new System.Drawing.Point(191, 309);
            this.unk2.Margin = new System.Windows.Forms.Padding(4);
            this.unk2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.unk2.Name = "unk2";
            this.unk2.Size = new System.Drawing.Size(66, 22);
            this.unk2.TabIndex = 146;
            this.unk2.ValueChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(10, 311);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 17);
            this.label17.TabIndex = 145;
            this.label17.Text = "Unknown 2";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(12, 448);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 17);
            this.label16.TabIndex = 144;
            this.label16.Text = "Acceleration Time";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label16, "Hard to tell, but from most cases while\r\ntesting, this controls roughly how many\r" +
        "\nframes it takes for this section to reach\r\nfull speed when acceleration isn\'t i" +
        "nstant.\r\n");
            // 
            // isEnd
            // 
            this.isEnd.AutoSize = true;
            this.isEnd.Location = new System.Drawing.Point(13, 340);
            this.isEnd.Name = "isEnd";
            this.isEnd.Size = new System.Drawing.Size(185, 21);
            this.isEnd.TabIndex = 116;
            this.isEnd.Text = "All Movement Ends Here";
            this.toolTip1.SetToolTip(this.isEnd, "If checked, this section will no longer \r\nmove after this phase ends. It\'s used t" +
        "o\r\nmake non-looping dynamic terrain.\r\n");
            this.isEnd.UseVisualStyleBackColor = true;
            this.isEnd.CheckedChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // delPhase
            // 
            this.delPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.delPhase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delPhase.Location = new System.Drawing.Point(177, 127);
            this.delPhase.Name = "delPhase";
            this.delPhase.Size = new System.Drawing.Size(80, 29);
            this.delPhase.TabIndex = 142;
            this.delPhase.Text = "Delete";
            this.toolTip1.SetToolTip(this.delPhase, "Delete the selected\r\nmovement phase.");
            this.delPhase.UseVisualStyleBackColor = true;
            this.delPhase.Click += new System.EventHandler(this.delPhase_Click);
            // 
            // addPhase
            // 
            this.addPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.addPhase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addPhase.Location = new System.Drawing.Point(6, 127);
            this.addPhase.Name = "addPhase";
            this.addPhase.Size = new System.Drawing.Size(80, 29);
            this.addPhase.TabIndex = 141;
            this.addPhase.Text = "Add";
            this.toolTip1.SetToolTip(this.addPhase, "Add a new movement\r\nphase for this section.");
            this.addPhase.UseVisualStyleBackColor = true;
            this.addPhase.Click += new System.EventHandler(this.addPhase_Click);
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(155, 250);
            this.duration.Margin = new System.Windows.Forms.Padding(4);
            this.duration.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(102, 22);
            this.duration.TabIndex = 126;
            this.toolTip1.SetToolTip(this.duration, "Change how many frames it\'ll\r\ntake this movement phase to\r\nreach its destination." +
        "");
            this.duration.ValueChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(10, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 125;
            this.label15.Text = "Unknown 1";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unk1
            // 
            this.unk1.Location = new System.Drawing.Point(155, 279);
            this.unk1.Margin = new System.Windows.Forms.Padding(4);
            this.unk1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.unk1.Name = "unk1";
            this.unk1.Size = new System.Drawing.Size(102, 22);
            this.unk1.TabIndex = 124;
            this.unk1.ValueChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(10, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 123;
            this.label14.Text = "Duration";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label14, "Change how many frames it\'ll\r\ntake this movement phase to\r\nreach its destination." +
        "\r\n");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(10, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 122;
            this.label13.Text = "Delay";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label13, "Change how many frames it\'ll\r\ntake this movement phase to\r\nstart moving.");
            // 
            // delay
            // 
            this.delay.Location = new System.Drawing.Point(155, 221);
            this.delay.Margin = new System.Windows.Forms.Padding(4);
            this.delay.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(102, 22);
            this.delay.TabIndex = 121;
            this.toolTip1.SetToolTip(this.delay, "Change how many frames it\'ll\r\ntake this movement phase to\r\nstart moving.");
            this.delay.ValueChanged += new System.EventHandler(this.UpdatePhaseData);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(12, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 120;
            this.label12.Text = "Acceleration";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label12, "The type of acceleration that\r\nthis movement phase will use\r\nwhen calculating its" +
        " speed.\r\n");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(10, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 118;
            this.label9.Text = "Distance";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label9, "Change the distance (In tiles) that\r\nthat this movement phase will travel.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(10, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 117;
            this.label5.Text = "Direction";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label5, "Change which direction\r\nthis movement phase\r\nwill travel.");
            // 
            // phaseList
            // 
            this.phaseList.FormattingEnabled = true;
            this.phaseList.ItemHeight = 16;
            this.phaseList.Location = new System.Drawing.Point(6, 21);
            this.phaseList.Name = "phaseList";
            this.phaseList.ScrollAlwaysVisible = true;
            this.phaseList.Size = new System.Drawing.Size(251, 100);
            this.phaseList.TabIndex = 0;
            this.phaseList.SelectedIndexChanged += new System.EventHandler(this.phaseList_SelectedIndexChanged);
            // 
            // DynamicTerrainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1022, 533);
            this.Controls.Add(this.resetCamera);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.pick);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.glControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DynamicTerrainEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Terrain Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpriteEditor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.vmat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colImg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventID)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog mainColorDLG;
        private OpenTK.GLControl glControl;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox materialList;
        private System.Windows.Forms.NumericUpDown vShape;
        private System.Windows.Forms.PictureBox colImg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown vmat;
        private System.Windows.Forms.Button pick;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox nullTile;
        private System.Windows.Forms.NumericUpDown eventID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown distance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox direction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox phaseList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox acceleration;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown delay;
        private System.Windows.Forms.NumericUpDown unk1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button delPhase;
        private System.Windows.Forms.Button addPhase;
        private System.Windows.Forms.NumericUpDown duration;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox isEnd;
        private System.Windows.Forms.CheckBox autoStart;
        private System.Windows.Forms.NumericUpDown prm2;
        private System.Windows.Forms.NumericUpDown prm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown accelTime;
        private System.Windows.Forms.NumericUpDown unk2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown unk3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox addendum;
        private System.Windows.Forms.Button resetCamera;
        private System.Windows.Forms.Button clonePhase;
    }
}