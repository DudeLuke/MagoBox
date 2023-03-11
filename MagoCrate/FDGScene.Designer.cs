
namespace MagoCrate
{
    partial class FDGScene
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
            this.scene = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clearBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // scene
            // 
            this.scene.FormattingEnabled = true;
            this.scene.Location = new System.Drawing.Point(12, 29);
            this.scene.Name = "scene";
            this.scene.Size = new System.Drawing.Size(458, 24);
            this.scene.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.MinimumSize = new System.Drawing.Size(458, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the scene to patch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearBox
            // 
            this.clearBox.AutoSize = true;
            this.clearBox.ForeColor = System.Drawing.SystemColors.Control;
            this.clearBox.Location = new System.Drawing.Point(15, 64);
            this.clearBox.Name = "clearBox";
            this.clearBox.Size = new System.Drawing.Size(306, 21);
            this.clearBox.TabIndex = 3;
            this.clearBox.Text = "Clear FDG Scene First (Not Recommended)";
            this.toolTip1.SetToolTip(this.clearBox, "Enabling this will clear all assets from\r\nthe selected scene before adding in\r\nth" +
        "e new ones.\r\nSince FDG Data is currently incomplete,\r\nthis may likely cause MORE" +
        " lag spikes\r\nrather then lessen it.");
            this.clearBox.UseVisualStyleBackColor = true;
            // 
            // FDGScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(482, 96);
            this.Controls.Add(this.clearBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scene);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FDGScene";
            this.Text = "FDG Scene Selector";
            this.Load += new System.EventHandler(this.FDGScene_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox scene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox clearBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}