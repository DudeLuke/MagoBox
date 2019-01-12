﻿namespace MagoBox.Editors
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
            this.p1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sizeAd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.sizeEx = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movingId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeEx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sizeEx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.sizeAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.p2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.p1);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Properties";
            // 
            // super
            // 
            this.super.AutoSize = true;
            this.super.Location = new System.Drawing.Point(122, 253);
            this.super.Name = "super";
            this.super.Size = new System.Drawing.Size(106, 17);
            this.super.TabIndex = 38;
            this.super.Text = "Has Super Ability";
            this.super.UseVisualStyleBackColor = true;
            // 
            // movingId
            // 
            this.movingId.Location = new System.Drawing.Point(122, 175);
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
            this.movingId.Size = new System.Drawing.Size(114, 20);
            this.movingId.TabIndex = 37;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(164, 279);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 36;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // yOffs
            // 
            this.yOffs.Location = new System.Drawing.Point(283, 226);
            this.yOffs.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.yOffs.Name = "yOffs";
            this.yOffs.Size = new System.Drawing.Size(41, 20);
            this.yOffs.TabIndex = 35;
            // 
            // xOffs
            // 
            this.xOffs.Location = new System.Drawing.Point(283, 200);
            this.xOffs.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.xOffs.Name = "xOffs";
            this.xOffs.Size = new System.Drawing.Size(41, 20);
            this.xOffs.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(242, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Offset";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(242, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Offset";
            // 
            // yCoord
            // 
            this.yCoord.Location = new System.Drawing.Point(122, 226);
            this.yCoord.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.yCoord.Name = "yCoord";
            this.yCoord.Size = new System.Drawing.Size(114, 20);
            this.yCoord.TabIndex = 31;
            // 
            // xCoord
            // 
            this.xCoord.Location = new System.Drawing.Point(122, 200);
            this.xCoord.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.xCoord.Name = "xCoord";
            this.xCoord.Size = new System.Drawing.Size(114, 20);
            this.xCoord.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moving Terrain ID";
            // 
            // behavior
            // 
            this.behavior.Location = new System.Drawing.Point(122, 45);
            this.behavior.Name = "behavior";
            this.behavior.Size = new System.Drawing.Size(114, 20);
            this.behavior.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Behavior";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(122, 19);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(114, 20);
            this.type.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // objDropDown
            // 
            this.objDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objDropDown.FormattingEnabled = true;
            this.objDropDown.Location = new System.Drawing.Point(242, 19);
            this.objDropDown.Name = "objDropDown";
            this.objDropDown.Size = new System.Drawing.Size(148, 21);
            this.objDropDown.TabIndex = 0;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(122, 71);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(114, 20);
            this.p1.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Parameter 1";
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(122, 97);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(114, 20);
            this.p2.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Parameter 2";
            // 
            // sizeAd
            // 
            this.sizeAd.Location = new System.Drawing.Point(122, 123);
            this.sizeAd.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sizeAd.Name = "sizeAd";
            this.sizeAd.Size = new System.Drawing.Size(114, 20);
            this.sizeAd.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Size (AD)";
            // 
            // sizeEx
            // 
            this.sizeEx.Location = new System.Drawing.Point(122, 149);
            this.sizeEx.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sizeEx.Name = "sizeEx";
            this.sizeEx.Size = new System.Drawing.Size(114, 20);
            this.sizeEx.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Size (EX)";
            // 
            // EnemyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 340);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnemyEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enemy Editor";
            this.Load += new System.EventHandler(this.ObjectEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movingId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeEx)).EndInit();
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
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sizeEx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown sizeAd;
        private System.Windows.Forms.Label label6;
    }
}