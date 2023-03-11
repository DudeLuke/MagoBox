namespace MagoBox
{
    partial class NewLevel
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
            this.sizeW = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.sizeH = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.createLevel = new System.Windows.Forms.Button();
            this.bg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tileset = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bgm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeW
            // 
            this.sizeW.Location = new System.Drawing.Point(111, 9);
            this.sizeW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeW.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.sizeW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeW.Name = "sizeW";
            this.sizeW.Size = new System.Drawing.Size(104, 22);
            this.sizeW.TabIndex = 7;
            this.sizeW.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(16, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Height";
            // 
            // sizeH
            // 
            this.sizeH.Location = new System.Drawing.Point(111, 41);
            this.sizeH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeH.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.sizeH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeH.Name = "sizeH";
            this.sizeH.Size = new System.Drawing.Size(104, 22);
            this.sizeH.TabIndex = 5;
            this.sizeH.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // createLevel
            // 
            this.createLevel.Location = new System.Drawing.Point(171, 175);
            this.createLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createLevel.Name = "createLevel";
            this.createLevel.Size = new System.Drawing.Size(100, 28);
            this.createLevel.TabIndex = 8;
            this.createLevel.Text = "Create";
            this.createLevel.UseVisualStyleBackColor = true;
            this.createLevel.Click += new System.EventHandler(this.createLevel_Click);
            // 
            // bg
            // 
            this.bg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bg.FormattingEnabled = true;
            this.bg.Location = new System.Drawing.Point(111, 73);
            this.bg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(287, 24);
            this.bg.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Background";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tileset";
            // 
            // tileset
            // 
            this.tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tileset.FormattingEnabled = true;
            this.tileset.Location = new System.Drawing.Point(111, 106);
            this.tileset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileset.Name = "tileset";
            this.tileset.Size = new System.Drawing.Size(287, 24);
            this.tileset.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "BGM";
            // 
            // bgm
            // 
            this.bgm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bgm.FormattingEnabled = true;
            this.bgm.Location = new System.Drawing.Point(111, 139);
            this.bgm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bgm.Name = "bgm";
            this.bgm.Size = new System.Drawing.Size(287, 24);
            this.bgm.TabIndex = 13;
            // 
            // NewLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(413, 218);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bgm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tileset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bg);
            this.Controls.Add(this.createLevel);
            this.Controls.Add(this.sizeW);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sizeH);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Level";
            this.Load += new System.EventHandler(this.NewLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sizeW;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown sizeH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createLevel;
        private System.Windows.Forms.ComboBox bg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tileset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bgm;
    }
}