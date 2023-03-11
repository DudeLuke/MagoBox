
namespace MagoCrate
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.rtmColors = new System.Windows.Forms.CheckBox();
            this.rtmLabels = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fdgFilePathBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spriteRangeValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DecoViewType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EnemyColorButton = new System.Windows.Forms.Button();
            this.BossColorButton = new System.Windows.Forms.Button();
            this.CarryColorButton = new System.Windows.Forms.Button();
            this.itemColorButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.objColorButton = new System.Windows.Forms.Button();
            this.mainColorButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.mainColorDLG = new System.Windows.Forms.ColorDialog();
            this.behaviorBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteRangeValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtmColors
            // 
            this.rtmColors.AutoSize = true;
            this.rtmColors.ForeColor = System.Drawing.SystemColors.Control;
            this.rtmColors.Location = new System.Drawing.Point(9, 27);
            this.rtmColors.Name = "rtmColors";
            this.rtmColors.Size = new System.Drawing.Size(161, 21);
            this.rtmColors.TabIndex = 0;
            this.rtmColors.Text = "ReturnToMap Colors";
            this.toolTip1.SetToolTip(this.rtmColors, resources.GetString("rtmColors.ToolTip"));
            this.rtmColors.UseVisualStyleBackColor = true;
            this.rtmColors.CheckedChanged += new System.EventHandler(this.rtmColors_CheckedChanged);
            // 
            // rtmLabels
            // 
            this.rtmLabels.AutoSize = true;
            this.rtmLabels.ForeColor = System.Drawing.SystemColors.Control;
            this.rtmLabels.Location = new System.Drawing.Point(222, 27);
            this.rtmLabels.Name = "rtmLabels";
            this.rtmLabels.Size = new System.Drawing.Size(235, 21);
            this.rtmLabels.TabIndex = 1;
            this.rtmLabels.Text = "ReturnToMap Parameter Names";
            this.toolTip1.SetToolTip(this.rtmLabels, "Return To Map, another level\r\neditor for KRtDL, uses different\r\nparameter names f" +
        "or objects\r\nand a few other entity categories.\r\n");
            this.rtmLabels.UseVisualStyleBackColor = true;
            this.rtmLabels.CheckedChanged += new System.EventHandler(this.rtmLabels_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MagoCrate.Properties.Resources.about;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(831, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "MagoBox";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(88, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "GameBanana";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(189, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Discord Server";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(297, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "YouTube";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About";
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(545, 74);
            this.label9.MaximumSize = new System.Drawing.Size(650, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "- Luke \"DudeLuke\" Nilsson\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.MaximumSize = new System.Drawing.Size(775, 0);
            this.label8.MinimumSize = new System.Drawing.Size(775, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(775, 34);
            this.label8.TabIndex = 3;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.behaviorBox);
            this.groupBox2.Controls.Add(this.fdgFilePathBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.spriteRangeValue);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(481, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor Settings";
            // 
            // fdgFilePathBox
            // 
            this.fdgFilePathBox.Location = new System.Drawing.Point(6, 128);
            this.fdgFilePathBox.Name = "fdgFilePathBox";
            this.fdgFilePathBox.ReadOnly = true;
            this.fdgFilePathBox.Size = new System.Drawing.Size(315, 22);
            this.fdgFilePathBox.TabIndex = 14;
            this.fdgFilePathBox.Text = "Click to set the FDG Archive Filepath";
            this.fdgFilePathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.fdgFilePathBox, "When patching an FDG archive, if will use\r\nthis filepath if it isn\'t empty. Good " +
        "for\r\npatching more than one level without\r\nneeding to repeatedly select the FDG\r" +
        "\narchive to patch.");
            this.fdgFilePathBox.Click += new System.EventHandler(this.fdgFilePathBox_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(233, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.toolTip1.SetToolTip(this.button1, "When patching an FDG archive, if will use\r\nthis filepath if it isn\'t empty. Good " +
        "for\r\npatching more than one level without\r\nneeding to repeatedly select the FDG\r" +
        "\narchive to patch.\r\n");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "FDG Automatic Filepath";
            this.toolTip1.SetToolTip(this.label5, "When patching an FDG archive, if will use\r\nthis filepath if it isn\'t empty. Good " +
        "for\r\npatching more than one level without\r\nneeding to repeatedly select the FDG\r" +
        "\narchive to patch.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sprite Range";
            this.toolTip1.SetToolTip(this.label6, "How far out of the camera an entity\r\nhas to be to stop calling for a sprite.\r\n");
            // 
            // spriteRangeValue
            // 
            this.spriteRangeValue.DecimalPlaces = 1;
            this.spriteRangeValue.Location = new System.Drawing.Point(18, 51);
            this.spriteRangeValue.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.spriteRangeValue.Name = "spriteRangeValue";
            this.spriteRangeValue.Size = new System.Drawing.Size(72, 22);
            this.spriteRangeValue.TabIndex = 2;
            this.spriteRangeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.spriteRangeValue, "How far out of the camera an entity\r\nhas to be to stop calling for a sprite.");
            this.spriteRangeValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spriteRangeValue.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DecoViewType);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.EnemyColorButton);
            this.groupBox3.Controls.Add(this.BossColorButton);
            this.groupBox3.Controls.Add(this.CarryColorButton);
            this.groupBox3.Controls.Add(this.itemColorButton);
            this.groupBox3.Controls.Add(this.colorLabel);
            this.groupBox3.Controls.Add(this.objColorButton);
            this.groupBox3.Controls.Add(this.mainColorButton);
            this.groupBox3.Controls.Add(this.rtmColors);
            this.groupBox3.Controls.Add(this.rtmLabels);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 186);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visual Settings";
            // 
            // DecoViewType
            // 
            this.DecoViewType.FormattingEnabled = true;
            this.DecoViewType.Items.AddRange(new object[] {
            "Show All 4 Byte Values",
            "Show 2 Byte Values (Byte 1 and 2)",
            "Show 1 Byte Value (Byte 2)"});
            this.DecoViewType.Location = new System.Drawing.Point(222, 63);
            this.DecoViewType.Name = "DecoViewType";
            this.DecoViewType.Size = new System.Drawing.Size(231, 24);
            this.DecoViewType.TabIndex = 11;
            this.toolTip1.SetToolTip(this.DecoViewType, "Change how many bytes are\r\nused the decoration views.\r\n1 Byte is best used for\r\ne" +
        "diting the MLand.\r\n");
            this.DecoViewType.SelectedIndexChanged += new System.EventHandler(this.DecoViewType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Decoration View Setting:";
            this.toolTip1.SetToolTip(this.label10, "Change how many bytes are\r\nused the decoration views.\r\n1 Byte is best used for\r\ne" +
        "diting the MLand.\r\n");
            // 
            // EnemyColorButton
            // 
            this.EnemyColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EnemyColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.EnemyColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnemyColorButton.Location = new System.Drawing.Point(384, 142);
            this.EnemyColorButton.Name = "EnemyColorButton";
            this.EnemyColorButton.Size = new System.Drawing.Size(69, 38);
            this.EnemyColorButton.TabIndex = 7;
            this.EnemyColorButton.Text = "Enemy";
            this.toolTip1.SetToolTip(this.EnemyColorButton, "Select a custom color for object\r\nwindows. Doesn\'t affect the\r\nentity dots in the" +
        " renderer,\r\nbut you can edit those in\r\n[ Resources/obj ].\r\n");
            this.EnemyColorButton.UseVisualStyleBackColor = false;
            this.EnemyColorButton.Click += new System.EventHandler(this.EnemyColorButton_Click);
            // 
            // BossColorButton
            // 
            this.BossColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BossColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.BossColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BossColorButton.Location = new System.Drawing.Point(309, 142);
            this.BossColorButton.Name = "BossColorButton";
            this.BossColorButton.Size = new System.Drawing.Size(69, 38);
            this.BossColorButton.TabIndex = 6;
            this.BossColorButton.Text = "Boss";
            this.toolTip1.SetToolTip(this.BossColorButton, "Select a custom color for boss\r\nwindows. Doesn\'t affect the\r\nentity dots in the r" +
        "enderer,\r\nbut you can edit those in\r\n[ Resources/obj ].\r\n");
            this.BossColorButton.UseVisualStyleBackColor = false;
            this.BossColorButton.Click += new System.EventHandler(this.BossColorButton_Click);
            // 
            // CarryColorButton
            // 
            this.CarryColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CarryColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.CarryColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CarryColorButton.Location = new System.Drawing.Point(159, 142);
            this.CarryColorButton.Name = "CarryColorButton";
            this.CarryColorButton.Size = new System.Drawing.Size(69, 38);
            this.CarryColorButton.TabIndex = 5;
            this.CarryColorButton.Text = "Carry";
            this.toolTip1.SetToolTip(this.CarryColorButton, "Select a custom color for \r\ncarriables windows. Doesn\'t \r\naffect the entity dots " +
        "in the\r\nrenderer, but you can edit \r\nthose in [ Resources/obj ].\r\n");
            this.CarryColorButton.UseVisualStyleBackColor = false;
            this.CarryColorButton.Click += new System.EventHandler(this.CarryColorButton_Click);
            // 
            // itemColorButton
            // 
            this.itemColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.itemColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.itemColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemColorButton.Location = new System.Drawing.Point(234, 142);
            this.itemColorButton.Name = "itemColorButton";
            this.itemColorButton.Size = new System.Drawing.Size(69, 38);
            this.itemColorButton.TabIndex = 4;
            this.itemColorButton.Text = "Item";
            this.toolTip1.SetToolTip(this.itemColorButton, "Select a custom color for item\r\nwindows. Doesn\'t affect the\r\nentity dots in the r" +
        "enderer,\r\nbut you can edit those in\r\n[ Resources/obj ].\r\n");
            this.itemColorButton.UseVisualStyleBackColor = false;
            this.itemColorButton.Click += new System.EventHandler(this.itemColorButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.ForeColor = System.Drawing.Color.Yellow;
            this.colorLabel.Location = new System.Drawing.Point(16, 117);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(304, 17);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.Text = "Edit Colors: (Only available if a level isn\'t open)";
            this.toolTip1.SetToolTip(this.colorLabel, "How far out of view from the camera it takes for\r\nan entity to use a custom textu" +
        "re. As a lot of them\r\nloaded at once greatly worsens performance.");
            // 
            // objColorButton
            // 
            this.objColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.objColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.objColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.objColorButton.Location = new System.Drawing.Point(84, 142);
            this.objColorButton.Name = "objColorButton";
            this.objColorButton.Size = new System.Drawing.Size(69, 38);
            this.objColorButton.TabIndex = 3;
            this.objColorButton.Text = "Objects";
            this.toolTip1.SetToolTip(this.objColorButton, "Select a custom color for object\r\nwindows. Doesn\'t affect the\r\nentity dots in the" +
        " renderer,\r\nbut you can edit those in\r\n[ Resources/obj ].");
            this.objColorButton.UseVisualStyleBackColor = false;
            this.objColorButton.Click += new System.EventHandler(this.objColorButton_Click);
            // 
            // mainColorButton
            // 
            this.mainColorButton.BackColor = System.Drawing.Color.Gray;
            this.mainColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.mainColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainColorButton.Location = new System.Drawing.Point(9, 142);
            this.mainColorButton.Name = "mainColorButton";
            this.mainColorButton.Size = new System.Drawing.Size(69, 38);
            this.mainColorButton.TabIndex = 2;
            this.mainColorButton.Text = "Main";
            this.toolTip1.SetToolTip(this.mainColorButton, "Changes the Background color, the\r\nmain window will require you to hit\r\nthe \"Refr" +
        "esh\" button to see changes.");
            this.mainColorButton.UseVisualStyleBackColor = false;
            this.mainColorButton.Click += new System.EventHandler(this.mainColorButton_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.White;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reset.Location = new System.Drawing.Point(547, 175);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(186, 23);
            this.reset.TabIndex = 12;
            this.reset.Text = "Reset Settings To Default";
            this.toolTip1.SetToolTip(this.reset, "Resets all options back to\r\nthe default values.");
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // mainColorDLG
            // 
            this.mainColorDLG.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // behaviorBox
            // 
            this.behaviorBox.AutoSize = true;
            this.behaviorBox.Checked = true;
            this.behaviorBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.behaviorBox.ForeColor = System.Drawing.SystemColors.Control;
            this.behaviorBox.Location = new System.Drawing.Point(140, 27);
            this.behaviorBox.MaximumSize = new System.Drawing.Size(165, 50);
            this.behaviorBox.MinimumSize = new System.Drawing.Size(165, 50);
            this.behaviorBox.Name = "behaviorBox";
            this.behaviorBox.Size = new System.Drawing.Size(165, 50);
            this.behaviorBox.TabIndex = 12;
            this.behaviorBox.Text = "Automatically Assign Enemy Behaviors";
            this.toolTip1.SetToolTip(this.behaviorBox, "When editing an enemy\'s type,\r\nit will automatically give it a\r\nbehavior that mak" +
        "es it function\r\nhow it\'s usually intended to.");
            this.behaviorBox.UseVisualStyleBackColor = true;
            this.behaviorBox.CheckedChanged += new System.EventHandler(this.behaviorBox_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(820, 629);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Options";
            this.ShowIcon = false;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteRangeValue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox rtmColors;
        private System.Windows.Forms.CheckBox rtmLabels;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown spriteRangeValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog mainColorDLG;
        private System.Windows.Forms.Button BossColorButton;
        private System.Windows.Forms.Button CarryColorButton;
        private System.Windows.Forms.Button itemColorButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Button objColorButton;
        private System.Windows.Forms.Button mainColorButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EnemyColorButton;
        private System.Windows.Forms.ComboBox DecoViewType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox fdgFilePathBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox behaviorBox;
    }
}