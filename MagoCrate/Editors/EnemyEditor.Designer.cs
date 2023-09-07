namespace MagoBox.Editors
{
    partial class EnemyEditor
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
            this.behaviorDropDown = new System.Windows.Forms.ComboBox();
            this.enemyNotes = new System.Windows.Forms.TextBox();
            this.sizeEx = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.sizeAd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dirType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.super = new System.Windows.Forms.CheckBox();
            this.movingId = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            this.yOffs = new System.Windows.Forms.NumericUpDown();
            this.xOffs = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.yCoord = new System.Windows.Forms.NumericUpDown();
            this.xCoord = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.behavior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.objDropDown = new System.Windows.Forms.ComboBox();
            this.categNotes = new System.Windows.Forms.TextBox();
            this.saveNotes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.saveNotes);
            this.groupBox1.Controls.Add(this.categNotes);
            this.groupBox1.Controls.Add(this.behaviorDropDown);
            this.groupBox1.Controls.Add(this.enemyNotes);
            this.groupBox1.Controls.Add(this.sizeEx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.sizeAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dirType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.level);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.super);
            this.groupBox1.Controls.Add(this.movingId);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.yOffs);
            this.groupBox1.Controls.Add(this.xOffs);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.yCoord);
            this.groupBox1.Controls.Add(this.xCoord);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.behavior);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.objDropDown);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(537, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Properties";
            // 
            // behaviorDropDown
            // 
            this.behaviorDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.behaviorDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.behaviorDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.behaviorDropDown.FormattingEnabled = true;
            this.behaviorDropDown.Location = new System.Drawing.Point(230, 56);
            this.behaviorDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.behaviorDropDown.Name = "behaviorDropDown";
            this.behaviorDropDown.Size = new System.Drawing.Size(289, 24);
            this.behaviorDropDown.TabIndex = 48;
            this.behaviorDropDown.SelectedIndexChanged += new System.EventHandler(this.behaviorDropDown_SelectedIndexChanged);
            // 
            // enemyNotes
            // 
            this.enemyNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enemyNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.enemyNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.enemyNotes.Location = new System.Drawing.Point(230, 312);
            this.enemyNotes.Margin = new System.Windows.Forms.Padding(4);
            this.enemyNotes.Multiline = true;
            this.enemyNotes.Name = "enemyNotes";
            this.enemyNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.enemyNotes.Size = new System.Drawing.Size(289, 112);
            this.enemyNotes.TabIndex = 47;
            // 
            // sizeEx
            // 
            this.sizeEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.sizeEx.Location = new System.Drawing.Point(147, 183);
            this.sizeEx.Margin = new System.Windows.Forms.Padding(4);
            this.sizeEx.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sizeEx.Name = "sizeEx";
            this.sizeEx.Size = new System.Drawing.Size(75, 22);
            this.sizeEx.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(8, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Size (EX)";
            // 
            // sizeAd
            // 
            this.sizeAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.sizeAd.Location = new System.Drawing.Point(147, 152);
            this.sizeAd.Margin = new System.Windows.Forms.Padding(4);
            this.sizeAd.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sizeAd.Name = "sizeAd";
            this.sizeAd.Size = new System.Drawing.Size(75, 22);
            this.sizeAd.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Size (AD)";
            // 
            // p2
            // 
            this.dirType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dirType.Location = new System.Drawing.Point(147, 120);
            this.dirType.Margin = new System.Windows.Forms.Padding(4);
            this.dirType.Name = "p2";
            this.dirType.Size = new System.Drawing.Size(75, 22);
            this.dirType.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Direction Type";
            // 
            // p1
            // 
            this.level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.level.Location = new System.Drawing.Point(147, 88);
            this.level.Margin = new System.Windows.Forms.Padding(4);
            this.level.Name = "p1";
            this.level.Size = new System.Drawing.Size(75, 22);
            this.level.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Level";
            // 
            // super
            // 
            this.super.AutoSize = true;
            this.super.ForeColor = System.Drawing.SystemColors.Control;
            this.super.Location = new System.Drawing.Point(47, 372);
            this.super.Margin = new System.Windows.Forms.Padding(4);
            this.super.Name = "super";
            this.super.Size = new System.Drawing.Size(132, 20);
            this.super.TabIndex = 38;
            this.super.Text = "Has Super Ability";
            this.super.UseVisualStyleBackColor = true;
            // 
            // movingId
            // 
            this.movingId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.movingId.Location = new System.Drawing.Point(147, 213);
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
            this.movingId.Size = new System.Drawing.Size(75, 22);
            this.movingId.TabIndex = 37;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save.Location = new System.Drawing.Point(65, 422);
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
            this.yOffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.yOffs.Location = new System.Drawing.Point(147, 342);
            this.yOffs.Margin = new System.Windows.Forms.Padding(4);
            this.yOffs.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.yOffs.Name = "yOffs";
            this.yOffs.Size = new System.Drawing.Size(75, 22);
            this.yOffs.TabIndex = 35;
            // 
            // xOffs
            // 
            this.xOffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.xOffs.Location = new System.Drawing.Point(147, 279);
            this.xOffs.Margin = new System.Windows.Forms.Padding(4);
            this.xOffs.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.xOffs.Name = "xOffs";
            this.xOffs.Size = new System.Drawing.Size(75, 22);
            this.xOffs.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(69, 344);
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
            this.label16.Location = new System.Drawing.Point(62, 281);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "X Offset";
            // 
            // yCoord
            // 
            this.yCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.yCoord.Location = new System.Drawing.Point(107, 312);
            this.yCoord.Margin = new System.Windows.Forms.Padding(4);
            this.yCoord.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.yCoord.Name = "yCoord";
            this.yCoord.Size = new System.Drawing.Size(115, 22);
            this.yCoord.TabIndex = 31;
            // 
            // xCoord
            // 
            this.xCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.xCoord.Location = new System.Drawing.Point(107, 247);
            this.xCoord.Margin = new System.Windows.Forms.Padding(4);
            this.xCoord.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.xCoord.Name = "xCoord";
            this.xCoord.Size = new System.Drawing.Size(115, 22);
            this.xCoord.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(8, 314);
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
            this.label14.Location = new System.Drawing.Point(8, 249);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "X Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moving Terrain ID";
            // 
            // behavior
            // 
            this.behavior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.behavior.Location = new System.Drawing.Point(147, 56);
            this.behavior.Margin = new System.Windows.Forms.Padding(4);
            this.behavior.Name = "behavior";
            this.behavior.Size = new System.Drawing.Size(75, 22);
            this.behavior.TabIndex = 4;
            this.behavior.TextChanged += new System.EventHandler(this.behavior_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Behavior";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.type.Location = new System.Drawing.Point(147, 24);
            this.type.Margin = new System.Windows.Forms.Padding(4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(75, 22);
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
            this.objDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.objDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objDropDown.FormattingEnabled = true;
            this.objDropDown.Location = new System.Drawing.Point(230, 23);
            this.objDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.objDropDown.Name = "objDropDown";
            this.objDropDown.Size = new System.Drawing.Size(289, 24);
            this.objDropDown.TabIndex = 0;
            this.objDropDown.SelectedIndexChanged += new System.EventHandler(this.objDropDown_SelectedIndexChanged);
            // 
            // categNotes
            // 
            this.categNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.categNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.categNotes.Location = new System.Drawing.Point(230, 88);
            this.categNotes.Margin = new System.Windows.Forms.Padding(4);
            this.categNotes.Multiline = true;
            this.categNotes.Name = "categNotes";
            this.categNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.categNotes.Size = new System.Drawing.Size(289, 213);
            this.categNotes.TabIndex = 49;
            // 
            // saveNotes
            // 
            this.saveNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.saveNotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveNotes.Location = new System.Drawing.Point(230, 422);
            this.saveNotes.Margin = new System.Windows.Forms.Padding(4);
            this.saveNotes.Name = "saveNotes";
            this.saveNotes.Size = new System.Drawing.Size(289, 28);
            this.saveNotes.TabIndex = 50;
            this.saveNotes.Text = "Save Notes";
            this.saveNotes.UseVisualStyleBackColor = false;
            this.saveNotes.Click += new System.EventHandler(this.saveNotes_Click);
            // 
            // EnemyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(567, 487);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(585, 534);
            this.Name = "EnemyEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enemy Editor";
            this.Load += new System.EventHandler(this.ObjectEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox behavior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox objDropDown;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.NumericUpDown movingId;
        private System.Windows.Forms.CheckBox super;
        private System.Windows.Forms.TextBox dirType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sizeEx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown sizeAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enemyNotes;
        private System.Windows.Forms.ComboBox behaviorDropDown;
        private System.Windows.Forms.Button saveNotes;
        private System.Windows.Forms.TextBox categNotes;
    }
}