
namespace MagoCrate
{
    partial class SpriteEditor
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
            this.mainColorDLG = new System.Windows.Forms.ColorDialog();
            this.glControl = new OpenTK.GLControl();
            this.zoomIn = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.offsetX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.offsetY = new System.Windows.Forms.NumericUpDown();
            this.categDrop = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.param = new System.Windows.Forms.NumericUpDown();
            this.prmLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.NumericUpDown();
            this.typeDrop = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.type)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.glControl.Size = new System.Drawing.Size(400, 422);
            this.glControl.TabIndex = 3;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            // 
            // zoomIn
            // 
            this.zoomIn.Enabled = false;
            this.zoomIn.Location = new System.Drawing.Point(534, 390);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(50, 41);
            this.zoomIn.TabIndex = 4;
            this.zoomIn.Text = "+";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Enabled = false;
            this.zoomOut.Location = new System.Drawing.Point(589, 390);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(50, 41);
            this.zoomOut.TabIndex = 5;
            this.zoomOut.Text = "-";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(486, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zoom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // width
            // 
            this.width.Enabled = false;
            this.width.Location = new System.Drawing.Point(152, 28);
            this.width.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(59, 22);
            this.width.TabIndex = 7;
            this.width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.imageValueChanged);
            // 
            // height
            // 
            this.height.Enabled = false;
            this.height.Location = new System.Drawing.Point(152, 56);
            this.height.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(59, 22);
            this.height.TabIndex = 8;
            this.height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height.ValueChanged += new System.EventHandler(this.imageValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Width";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // offsetX
            // 
            this.offsetX.DecimalPlaces = 2;
            this.offsetX.Enabled = false;
            this.offsetX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.offsetX.Location = new System.Drawing.Point(152, 95);
            this.offsetX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.offsetX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(59, 22);
            this.offsetX.TabIndex = 10;
            this.offsetX.ValueChanged += new System.EventHandler(this.imageValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "X Offset";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(420, 14);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(108, 26);
            this.open.TabIndex = 12;
            this.open.Text = "Open Image";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // offsetY
            // 
            this.offsetY.DecimalPlaces = 2;
            this.offsetY.Enabled = false;
            this.offsetY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.offsetY.Location = new System.Drawing.Point(152, 123);
            this.offsetY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.offsetY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(59, 22);
            this.offsetY.TabIndex = 13;
            this.offsetY.ValueChanged += new System.EventHandler(this.imageValueChanged);
            // 
            // categDrop
            // 
            this.categDrop.Enabled = false;
            this.categDrop.FormattingEnabled = true;
            this.categDrop.Items.AddRange(new object[] {
            "Object",
            "Carriable",
            "Item",
            "Boss",
            "Enemy"});
            this.categDrop.Location = new System.Drawing.Point(6, 21);
            this.categDrop.Name = "categDrop";
            this.categDrop.Size = new System.Drawing.Size(207, 24);
            this.categDrop.TabIndex = 14;
            this.categDrop.Text = "Object";
            this.categDrop.SelectedIndexChanged += new System.EventHandler(this.categDrop_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(7, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 20);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Make Parameter-Specific";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // param
            // 
            this.param.Enabled = false;
            this.param.Location = new System.Drawing.Point(114, 142);
            this.param.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.param.Name = "param";
            this.param.Size = new System.Drawing.Size(99, 22);
            this.param.TabIndex = 17;
            // 
            // prmLabel
            // 
            this.prmLabel.AutoSize = true;
            this.prmLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.prmLabel.Location = new System.Drawing.Point(111, 123);
            this.prmLabel.Name = "prmLabel";
            this.prmLabel.Size = new System.Drawing.Size(80, 16);
            this.prmLabel.TabIndex = 18;
            this.prmLabel.Text = "Parameter 6";
            this.prmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.typeDrop);
            this.groupBox1.Controls.Add(this.prmLabel);
            this.groupBox1.Controls.Add(this.categDrop);
            this.groupBox1.Controls.Add(this.param);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(420, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 173);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(9, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type
            // 
            this.type.Enabled = false;
            this.type.Location = new System.Drawing.Point(6, 142);
            this.type.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(101, 22);
            this.type.TabIndex = 19;
            this.type.ValueChanged += new System.EventHandler(this.type_ValueChanged);
            // 
            // typeDrop
            // 
            this.typeDrop.Enabled = false;
            this.typeDrop.FormattingEnabled = true;
            this.typeDrop.Location = new System.Drawing.Point(6, 51);
            this.typeDrop.Name = "typeDrop";
            this.typeDrop.Size = new System.Drawing.Size(207, 24);
            this.typeDrop.TabIndex = 15;
            this.typeDrop.Text = "Door";
            this.typeDrop.SelectedIndexChanged += new System.EventHandler(this.typeDrop_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.offsetY);
            this.groupBox2.Controls.Add(this.width);
            this.groupBox2.Controls.Add(this.height);
            this.groupBox2.Controls.Add(this.offsetX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(422, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 161);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Values";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(7, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Y Offset";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(531, 14);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(108, 26);
            this.save.TabIndex = 21;
            this.save.Text = "Save Image";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // SpriteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.glControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpriteEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpriteEditor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.type)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog mainColorDLG;
        private OpenTK.GLControl glControl;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown offsetX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.NumericUpDown offsetY;
        private System.Windows.Forms.ComboBox categDrop;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown param;
        private System.Windows.Forms.Label prmLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox typeDrop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown type;
        private System.Windows.Forms.Button save;
    }
}