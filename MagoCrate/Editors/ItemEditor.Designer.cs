namespace MagoBox.Editors
{
    partial class ItemEditor
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
            this.itemNotes = new System.Windows.Forms.TextBox();
            this.behavior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.subtype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.objDropDown = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movingId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemNotes);
            this.groupBox1.Controls.Add(this.behavior);
            this.groupBox1.Controls.Add(this.label4);
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
            this.groupBox1.Controls.Add(this.subtype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.objDropDown);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(537, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Properties";
            // 
            // itemNotes
            // 
            this.itemNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.itemNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemNotes.Location = new System.Drawing.Point(227, 55);
            this.itemNotes.Margin = new System.Windows.Forms.Padding(4);
            this.itemNotes.Multiline = true;
            this.itemNotes.Name = "itemNotes";
            this.itemNotes.ReadOnly = true;
            this.itemNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemNotes.Size = new System.Drawing.Size(292, 321);
            this.itemNotes.TabIndex = 42;
            // 
            // behavior
            // 
            this.behavior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.behavior.Location = new System.Drawing.Point(163, 87);
            this.behavior.Margin = new System.Windows.Forms.Padding(4);
            this.behavior.Name = "behavior";
            this.behavior.Size = new System.Drawing.Size(56, 22);
            this.behavior.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Behavior";
            // 
            // movingId
            // 
            this.movingId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.movingId.Location = new System.Drawing.Point(163, 119);
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
            this.movingId.Size = new System.Drawing.Size(56, 22);
            this.movingId.TabIndex = 37;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save.Location = new System.Drawing.Point(82, 348);
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
            this.yOffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.yOffs.Location = new System.Drawing.Point(164, 247);
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
            this.xOffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.xOffs.Location = new System.Drawing.Point(164, 181);
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
            this.label17.Location = new System.Drawing.Point(97, 249);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "Y Offset";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(97, 183);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "X Offset";
            // 
            // yCoord
            // 
            this.yCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.yCoord.Location = new System.Drawing.Point(117, 213);
            this.yCoord.Margin = new System.Windows.Forms.Padding(4);
            this.yCoord.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.yCoord.Name = "yCoord";
            this.yCoord.Size = new System.Drawing.Size(102, 22);
            this.yCoord.TabIndex = 31;
            // 
            // xCoord
            // 
            this.xCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.xCoord.Location = new System.Drawing.Point(117, 151);
            this.xCoord.Margin = new System.Windows.Forms.Padding(4);
            this.xCoord.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.xCoord.Name = "xCoord";
            this.xCoord.Size = new System.Drawing.Size(102, 22);
            this.xCoord.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(8, 215);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Y Position";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(8, 153);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "X Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moving Terrain ID";
            // 
            // subtype
            // 
            this.subtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.subtype.Location = new System.Drawing.Point(163, 55);
            this.subtype.Margin = new System.Windows.Forms.Padding(4);
            this.subtype.Name = "subtype";
            this.subtype.Size = new System.Drawing.Size(56, 22);
            this.subtype.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subtype";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.type.Location = new System.Drawing.Point(163, 23);
            this.type.Margin = new System.Windows.Forms.Padding(4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(56, 22);
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
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // objDropDown
            // 
            this.objDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.objDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objDropDown.FormattingEnabled = true;
            this.objDropDown.Location = new System.Drawing.Point(227, 23);
            this.objDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.objDropDown.Name = "objDropDown";
            this.objDropDown.Size = new System.Drawing.Size(292, 24);
            this.objDropDown.TabIndex = 0;
            this.objDropDown.SelectedIndexChanged += new System.EventHandler(this.objDropDown_SelectedIndexChanged);
            // 
            // ItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(567, 413);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Editor";
            this.Load += new System.EventHandler(this.ObjectEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox subtype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox objDropDown;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.NumericUpDown movingId;
        private System.Windows.Forms.TextBox behavior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemNotes;
    }
}