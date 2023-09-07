
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
            this.quickPickBox = new System.Windows.Forms.CheckBox();
            this.behaviorBox = new System.Windows.Forms.CheckBox();
            this.fdgFilePathBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spriteRangeValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DecorType = new System.Windows.Forms.ComboBox();
            this.Section4DColorButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteRangeValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtmLabels
            // 
            this.rtmLabels.AutoSize = true;
            this.rtmLabels.ForeColor = System.Drawing.SystemColors.Control;
            this.rtmLabels.Location = new System.Drawing.Point(19, 88);
            this.rtmLabels.Name = "rtmLabels";
            this.rtmLabels.Size = new System.Drawing.Size(225, 20);
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
            this.label1.Size = new System.Drawing.Size(65, 16);
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
            this.label2.Size = new System.Drawing.Size(91, 16);
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
            this.label3.Size = new System.Drawing.Size(97, 16);
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
            this.label4.Size = new System.Drawing.Size(63, 16);
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
            this.groupBox2.Controls.Add(this.quickPickBox);
            this.groupBox2.Controls.Add(this.behaviorBox);
            this.groupBox2.Controls.Add(this.fdgFilePathBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(481, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor Settings";
            // 
            // quickPickBox
            // 
            this.quickPickBox.AutoSize = true;
            this.quickPickBox.ForeColor = System.Drawing.SystemColors.Control;
            this.quickPickBox.Location = new System.Drawing.Point(6, 47);
            this.quickPickBox.Name = "quickPickBox";
            this.quickPickBox.Size = new System.Drawing.Size(135, 20);
            this.quickPickBox.TabIndex = 14;
            this.quickPickBox.Text = "Enable QuickPick";
            this.quickPickBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.quickPickBox, "Combine the Draw and \r\nPick tools. Use Left-Click\r\nto draw, and Right to pick.\r\n");
            this.quickPickBox.UseVisualStyleBackColor = true;
            this.quickPickBox.CheckedChanged += new System.EventHandler(this.quickPickBox_CheckedChanged);
            // 
            // behaviorBox
            // 
            this.behaviorBox.AutoSize = true;
            this.behaviorBox.Checked = true;
            this.behaviorBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.behaviorBox.ForeColor = System.Drawing.SystemColors.Control;
            this.behaviorBox.Location = new System.Drawing.Point(6, 21);
            this.behaviorBox.Name = "behaviorBox";
            this.behaviorBox.Size = new System.Drawing.Size(160, 20);
            this.behaviorBox.TabIndex = 12;
            this.behaviorBox.Text = "Enable Auto-Behavior";
            this.toolTip1.SetToolTip(this.behaviorBox, "When editing an enemy\'s type,\r\nit will automatically give it a\r\nbehavior that mak" +
        "es it function\r\nhow it\'s usually intended to.");
            this.behaviorBox.UseVisualStyleBackColor = true;
            this.behaviorBox.CheckedChanged += new System.EventHandler(this.behaviorBox_CheckedChanged);
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
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "FDG Automatic Filepath";
            this.toolTip1.SetToolTip(this.label5, "When patching an FDG archive, if will use\r\nthis filepath if it isn\'t empty. Good " +
        "for\r\npatching more than one level without\r\nneeding to repeatedly select the FDG\r" +
        "\narchive to patch.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sprite Range";
            this.toolTip1.SetToolTip(this.label6, "How far out of the camera an entity\r\nhas to be to stop calling for a sprite.\r\n");
            // 
            // spriteRangeValue
            // 
            this.spriteRangeValue.DecimalPlaces = 1;
            this.spriteRangeValue.Location = new System.Drawing.Point(108, 56);
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
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.DecorType);
            this.groupBox3.Controls.Add(this.Section4DColorButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.spriteRangeValue);
            this.groupBox3.Controls.Add(this.EnemyColorButton);
            this.groupBox3.Controls.Add(this.BossColorButton);
            this.groupBox3.Controls.Add(this.CarryColorButton);
            this.groupBox3.Controls.Add(this.itemColorButton);
            this.groupBox3.Controls.Add(this.colorLabel);
            this.groupBox3.Controls.Add(this.objColorButton);
            this.groupBox3.Controls.Add(this.mainColorButton);
            this.groupBox3.Controls.Add(this.rtmLabels);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 186);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visual Settings";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(16, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Decoration View Setting";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecorType
            // 
            this.DecorType.FormattingEnabled = true;
            this.DecorType.Items.AddRange(new object[] {
            "Colors",
            "4 Bytes",
            "2 Bytes",
            "1 Byte"});
            this.DecorType.Location = new System.Drawing.Point(192, 25);
            this.DecorType.Name = "DecorType";
            this.DecorType.Size = new System.Drawing.Size(261, 24);
            this.DecorType.TabIndex = 13;
            this.DecorType.SelectedIndexChanged += new System.EventHandler(this.DecorType_SelectedIndexChanged);
            // 
            // Section4DColorButton
            // 
            this.Section4DColorButton.BackColor = System.Drawing.Color.White;
            this.Section4DColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.Section4DColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Section4DColorButton.Location = new System.Drawing.Point(423, 146);
            this.Section4DColorButton.Name = "Section4DColorButton";
            this.Section4DColorButton.Size = new System.Drawing.Size(30, 30);
            this.Section4DColorButton.TabIndex = 12;
            this.toolTip1.SetToolTip(this.Section4DColorButton, "Section 4D\r\n");
            this.Section4DColorButton.UseVisualStyleBackColor = false;
            this.Section4DColorButton.Click += new System.EventHandler(this.section4DColorButton_Click);
            // 
            // EnemyColorButton
            // 
            this.EnemyColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EnemyColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.EnemyColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnemyColorButton.Location = new System.Drawing.Point(387, 146);
            this.EnemyColorButton.Name = "EnemyColorButton";
            this.EnemyColorButton.Size = new System.Drawing.Size(30, 30);
            this.EnemyColorButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.EnemyColorButton, "Enemies\r\n");
            this.EnemyColorButton.UseVisualStyleBackColor = false;
            this.EnemyColorButton.Click += new System.EventHandler(this.EnemyColorButton_Click);
            // 
            // BossColorButton
            // 
            this.BossColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BossColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.BossColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BossColorButton.Location = new System.Drawing.Point(351, 146);
            this.BossColorButton.Name = "BossColorButton";
            this.BossColorButton.Size = new System.Drawing.Size(30, 30);
            this.BossColorButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.BossColorButton, "Bosses\r\n");
            this.BossColorButton.UseVisualStyleBackColor = false;
            this.BossColorButton.Click += new System.EventHandler(this.BossColorButton_Click);
            // 
            // CarryColorButton
            // 
            this.CarryColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CarryColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.CarryColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CarryColorButton.Location = new System.Drawing.Point(387, 110);
            this.CarryColorButton.Name = "CarryColorButton";
            this.CarryColorButton.Size = new System.Drawing.Size(30, 30);
            this.CarryColorButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.CarryColorButton, "Carriables\r\n");
            this.CarryColorButton.UseVisualStyleBackColor = false;
            this.CarryColorButton.Click += new System.EventHandler(this.CarryColorButton_Click);
            // 
            // itemColorButton
            // 
            this.itemColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.itemColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.itemColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemColorButton.Location = new System.Drawing.Point(423, 110);
            this.itemColorButton.Name = "itemColorButton";
            this.itemColorButton.Size = new System.Drawing.Size(30, 30);
            this.itemColorButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.itemColorButton, "Items\r\n");
            this.itemColorButton.UseVisualStyleBackColor = false;
            this.itemColorButton.Click += new System.EventHandler(this.itemColorButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.ForeColor = System.Drawing.Color.White;
            this.colorLabel.Location = new System.Drawing.Point(369, 55);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(72, 16);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.Text = "Edit Colors\r\n";
            this.toolTip1.SetToolTip(this.colorLabel, "How far out of view from the camera it takes for\r\nan entity to use a custom textu" +
        "re. As a lot of them\r\nloaded at once greatly worsens performance.");
            // 
            // objColorButton
            // 
            this.objColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.objColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.objColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.objColorButton.Location = new System.Drawing.Point(351, 110);
            this.objColorButton.Name = "objColorButton";
            this.objColorButton.Size = new System.Drawing.Size(30, 30);
            this.objColorButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.objColorButton, "Objects");
            this.objColorButton.UseVisualStyleBackColor = false;
            this.objColorButton.Click += new System.EventHandler(this.objColorButton_Click);
            // 
            // mainColorButton
            // 
            this.mainColorButton.BackColor = System.Drawing.Color.Gray;
            this.mainColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.mainColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainColorButton.Location = new System.Drawing.Point(351, 74);
            this.mainColorButton.Name = "mainColorButton";
            this.mainColorButton.Size = new System.Drawing.Size(102, 30);
            this.mainColorButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.mainColorButton, "Main");
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
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
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox fdgFilePathBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox behaviorBox;
        private System.Windows.Forms.Button Section4DColorButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DecorType;
        private System.Windows.Forms.CheckBox quickPickBox;
    }
}