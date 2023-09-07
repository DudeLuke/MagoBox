namespace MagoBox.Editors
{
    partial class BossEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveNotes = new System.Windows.Forms.Button();
            this.categNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.unk = new System.Windows.Forms.TextBox();
            this.bossNotes = new System.Windows.Forms.TextBox();
            this.level = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.super = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.yOffs = new System.Windows.Forms.NumericUpDown();
            this.xOffs = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.yCoord = new System.Windows.Forms.NumericUpDown();
            this.xCoord = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.objDropDown = new System.Windows.Forms.ComboBox();
            this.movingId = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yOffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingId)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.movingId);
            this.groupBox1.Controls.Add(this.saveNotes);
            this.groupBox1.Controls.Add(this.categNotes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.unk);
            this.groupBox1.Controls.Add(this.bossNotes);
            this.groupBox1.Controls.Add(this.level);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.subType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.super);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.yOffs);
            this.groupBox1.Controls.Add(this.xOffs);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.yCoord);
            this.groupBox1.Controls.Add(this.xCoord);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.objDropDown);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(537, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Properties";
            // 
            // saveNotes
            // 
            this.saveNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.saveNotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveNotes.Location = new System.Drawing.Point(218, 345);
            this.saveNotes.Margin = new System.Windows.Forms.Padding(4);
            this.saveNotes.Name = "saveNotes";
            this.saveNotes.Size = new System.Drawing.Size(301, 28);
            this.saveNotes.TabIndex = 47;
            this.saveNotes.Text = "Save Notes";
            this.saveNotes.UseVisualStyleBackColor = false;
            this.saveNotes.Click += new System.EventHandler(this.saveNotes_Click);
            // 
            // categNotes
            // 
            this.categNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.categNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.categNotes.Location = new System.Drawing.Point(218, 55);
            this.categNotes.Margin = new System.Windows.Forms.Padding(4);
            this.categNotes.Multiline = true;
            this.categNotes.Name = "categNotes";
            this.categNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.categNotes.Size = new System.Drawing.Size(301, 87);
            this.categNotes.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Unknown";
            // 
            // p4
            // 
            this.unk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.unk.Location = new System.Drawing.Point(102, 120);
            this.unk.Margin = new System.Windows.Forms.Padding(4);
            this.unk.Name = "p4";
            this.unk.Size = new System.Drawing.Size(108, 22);
            this.unk.TabIndex = 44;
            // 
            // bossNotes
            // 
            this.bossNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bossNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bossNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.bossNotes.Location = new System.Drawing.Point(218, 152);
            this.bossNotes.Margin = new System.Windows.Forms.Padding(4);
            this.bossNotes.Multiline = true;
            this.bossNotes.Name = "bossNotes";
            this.bossNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bossNotes.Size = new System.Drawing.Size(301, 195);
            this.bossNotes.TabIndex = 43;
            // 
            // p2
            // 
            this.level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.level.Location = new System.Drawing.Point(102, 88);
            this.level.Margin = new System.Windows.Forms.Padding(4);
            this.level.Name = "p2";
            this.level.Size = new System.Drawing.Size(108, 22);
            this.level.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Level";
            // 
            // p1
            // 
            this.subType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.subType.Location = new System.Drawing.Point(102, 56);
            this.subType.Margin = new System.Windows.Forms.Padding(4);
            this.subType.Name = "p1";
            this.subType.Size = new System.Drawing.Size(108, 22);
            this.subType.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Subtype";
            // 
            // super
            // 
            this.super.AutoSize = true;
            this.super.ForeColor = System.Drawing.SystemColors.Control;
            this.super.Location = new System.Drawing.Point(39, 317);
            this.super.Margin = new System.Windows.Forms.Padding(4);
            this.super.Name = "super";
            this.super.Size = new System.Drawing.Size(132, 20);
            this.super.TabIndex = 38;
            this.super.Text = "Has Super Ability";
            this.super.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save.Location = new System.Drawing.Point(57, 345);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 28);
            this.save.TabIndex = 36;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // yOffs
            // 
            this.yOffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.yOffs.Location = new System.Drawing.Point(155, 275);
            this.yOffs.Margin = new System.Windows.Forms.Padding(4);
            this.yOffs.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.yOffs.Name = "yOffs";
            this.yOffs.Size = new System.Drawing.Size(55, 22);
            this.yOffs.TabIndex = 35;
            // 
            // xOffs
            // 
            this.xOffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.xOffs.Location = new System.Drawing.Point(155, 215);
            this.xOffs.Margin = new System.Windows.Forms.Padding(4);
            this.xOffs.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.xOffs.Name = "xOffs";
            this.xOffs.Size = new System.Drawing.Size(55, 22);
            this.xOffs.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(86, 277);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "Y Offset";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(86, 217);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "X Offset";
            // 
            // yCoord
            // 
            this.yCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.yCoord.Location = new System.Drawing.Point(102, 245);
            this.yCoord.Margin = new System.Windows.Forms.Padding(4);
            this.yCoord.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.yCoord.Name = "yCoord";
            this.yCoord.Size = new System.Drawing.Size(108, 22);
            this.yCoord.TabIndex = 31;
            // 
            // xCoord
            // 
            this.xCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.xCoord.Location = new System.Drawing.Point(102, 185);
            this.xCoord.Margin = new System.Windows.Forms.Padding(4);
            this.xCoord.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.xCoord.Name = "xCoord";
            this.xCoord.Size = new System.Drawing.Size(108, 22);
            this.xCoord.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(8, 247);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Y Position";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(8, 187);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "X Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moving Terrain ID";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.type.Location = new System.Drawing.Point(102, 24);
            this.type.Margin = new System.Windows.Forms.Padding(4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(108, 22);
            this.type.TabIndex = 2;
            this.type.TextChanged += new System.EventHandler(this.type_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // objDropDown
            // 
            this.objDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.objDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objDropDown.FormattingEnabled = true;
            this.objDropDown.Location = new System.Drawing.Point(218, 23);
            this.objDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.objDropDown.Name = "objDropDown";
            this.objDropDown.Size = new System.Drawing.Size(301, 24);
            this.objDropDown.TabIndex = 0;
            this.objDropDown.SelectedIndexChanged += new System.EventHandler(this.objDropDown_SelectedIndexChanged);
            // 
            // movingId
            // 
            this.movingId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.movingId.Location = new System.Drawing.Point(155, 152);
            this.movingId.Margin = new System.Windows.Forms.Padding(4);
            this.movingId.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.movingId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.movingId.Name = "movingId";
            this.movingId.Size = new System.Drawing.Size(55, 22);
            this.movingId.TabIndex = 48;
            // 
            // BossEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(567, 410);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(585, 457);
            this.Name = "BossEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enemy Editor";
            this.Load += new System.EventHandler(this.ObjectEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yOffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown yOffs;
        private System.Windows.Forms.NumericUpDown xOffs;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown yCoord;
        private System.Windows.Forms.NumericUpDown xCoord;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox objDropDown;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox super;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bossNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox unk;
        private System.Windows.Forms.Button saveNotes;
        private System.Windows.Forms.TextBox categNotes;
        private System.Windows.Forms.NumericUpDown movingId;
    }
}