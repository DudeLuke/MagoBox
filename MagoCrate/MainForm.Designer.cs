namespace MagoBox
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderTileModifiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderObjectPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderAutoMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useAvailableSpritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchFDGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsAndHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editObj = new System.Windows.Forms.Button();
            this.delObj = new System.Windows.Forms.Button();
            this.cloneObj = new System.Windows.Forms.Button();
            this.addObj = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.objTab = new System.Windows.Forms.TabPage();
            this.objList = new System.Windows.Forms.ListBox();
            this.carriablesTab = new System.Windows.Forms.TabPage();
            this.carriablesList = new System.Windows.Forms.ListBox();
            this.itemTab = new System.Windows.Forms.TabPage();
            this.itemList = new System.Windows.Forms.ListBox();
            this.bossTab = new System.Windows.Forms.TabPage();
            this.bossList = new System.Windows.Forms.ListBox();
            this.enemyTab = new System.Windows.Forms.TabPage();
            this.enemyList = new System.Windows.Forms.ListBox();
            this.glControl = new OpenTK.GLControl();
            this.resetCamera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xCoord = new System.Windows.Forms.NumericUpDown();
            this.xOffset = new System.Windows.Forms.NumericUpDown();
            this.yOffset = new System.Windows.Forms.NumericUpDown();
            this.yCoord = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.d1_1 = new System.Windows.Forms.NumericUpDown();
            this.d1_2 = new System.Windows.Forms.NumericUpDown();
            this.d1_3 = new System.Windows.Forms.NumericUpDown();
            this.d2_4 = new System.Windows.Forms.NumericUpDown();
            this.d3_4 = new System.Windows.Forms.NumericUpDown();
            this.d2_3 = new System.Windows.Forms.NumericUpDown();
            this.d1_4 = new System.Windows.Forms.NumericUpDown();
            this.d2_2 = new System.Windows.Forms.NumericUpDown();
            this.d3_3 = new System.Windows.Forms.NumericUpDown();
            this.d3_1 = new System.Windows.Forms.NumericUpDown();
            this.d3_2 = new System.Windows.Forms.NumericUpDown();
            this.d2_1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.d2_hex = new System.Windows.Forms.TextBox();
            this.d3_hex = new System.Windows.Forms.TextBox();
            this.d1_hex = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.editAutoMove = new System.Windows.Forms.CheckBox();
            this.editMat = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.editModf = new System.Windows.Forms.CheckBox();
            this.editFLand = new System.Windows.Forms.CheckBox();
            this.editMLand = new System.Windows.Forms.CheckBox();
            this.editBLand = new System.Windows.Forms.CheckBox();
            this.editBlock = new System.Windows.Forms.CheckBox();
            this.editCol = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vBlock = new System.Windows.Forms.NumericUpDown();
            this.blockList = new System.Windows.Forms.ComboBox();
            this.blockImg = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialList = new System.Windows.Forms.ComboBox();
            this.vShape = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.colImg = new System.Windows.Forms.PictureBox();
            this.ice = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.spike = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boundary = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vmat = new System.Windows.Forms.NumericUpDown();
            this.ladder = new System.Windows.Forms.CheckBox();
            this.vautomove = new System.Windows.Forms.NumericUpDown();
            this.water = new System.Windows.Forms.CheckBox();
            this.lava = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sizeW = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.sizeH = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.halfTileLock = new System.Windows.Forms.CheckBox();
            this.viewType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pick = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.objTab.SuspendLayout();
            this.carriablesTab.SuspendLayout();
            this.itemTab.SuspendLayout();
            this.bossTab.SuspendLayout();
            this.enemyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockImg)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vautomove)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stageSettingsToolStripMenuItem,
            this.renderSettingsToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.patchFDGToolStripMenuItem,
            this.optionsAndHelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1517, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // stageSettingsToolStripMenuItem
            // 
            this.stageSettingsToolStripMenuItem.Name = "stageSettingsToolStripMenuItem";
            this.stageSettingsToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.stageSettingsToolStripMenuItem.Text = "Stage Settings";
            this.stageSettingsToolStripMenuItem.Click += new System.EventHandler(this.stageSettingsToolStripMenuItem_Click);
            // 
            // renderSettingsToolStripMenuItem
            // 
            this.renderSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renderTileModifiersToolStripMenuItem,
            this.renderBlocksToolStripMenuItem,
            this.renderObjectPointsToolStripMenuItem,
            this.renderMaterialsToolStripMenuItem,
            this.renderAutoMovementToolStripMenuItem,
            this.useAvailableSpritesToolStripMenuItem});
            this.renderSettingsToolStripMenuItem.Name = "renderSettingsToolStripMenuItem";
            this.renderSettingsToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.renderSettingsToolStripMenuItem.Text = "Render Settings";
            // 
            // renderTileModifiersToolStripMenuItem
            // 
            this.renderTileModifiersToolStripMenuItem.Checked = true;
            this.renderTileModifiersToolStripMenuItem.CheckOnClick = true;
            this.renderTileModifiersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderTileModifiersToolStripMenuItem.Name = "renderTileModifiersToolStripMenuItem";
            this.renderTileModifiersToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.renderTileModifiersToolStripMenuItem.Text = "Render Tile Modifiers";
            // 
            // renderBlocksToolStripMenuItem
            // 
            this.renderBlocksToolStripMenuItem.Checked = true;
            this.renderBlocksToolStripMenuItem.CheckOnClick = true;
            this.renderBlocksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderBlocksToolStripMenuItem.Name = "renderBlocksToolStripMenuItem";
            this.renderBlocksToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.renderBlocksToolStripMenuItem.Text = "Render Blocks";
            // 
            // renderObjectPointsToolStripMenuItem
            // 
            this.renderObjectPointsToolStripMenuItem.Checked = true;
            this.renderObjectPointsToolStripMenuItem.CheckOnClick = true;
            this.renderObjectPointsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderObjectPointsToolStripMenuItem.Name = "renderObjectPointsToolStripMenuItem";
            this.renderObjectPointsToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.renderObjectPointsToolStripMenuItem.Text = "Render Entities";
            // 
            // renderMaterialsToolStripMenuItem
            // 
            this.renderMaterialsToolStripMenuItem.Checked = true;
            this.renderMaterialsToolStripMenuItem.CheckOnClick = true;
            this.renderMaterialsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderMaterialsToolStripMenuItem.Name = "renderMaterialsToolStripMenuItem";
            this.renderMaterialsToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.renderMaterialsToolStripMenuItem.Text = "Render Materials";
            // 
            // renderAutoMovementToolStripMenuItem
            // 
            this.renderAutoMovementToolStripMenuItem.Checked = true;
            this.renderAutoMovementToolStripMenuItem.CheckOnClick = true;
            this.renderAutoMovementToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderAutoMovementToolStripMenuItem.Name = "renderAutoMovementToolStripMenuItem";
            this.renderAutoMovementToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.renderAutoMovementToolStripMenuItem.Text = "Render Auto Movement";
            // 
            // useAvailableSpritesToolStripMenuItem
            // 
            this.useAvailableSpritesToolStripMenuItem.Checked = true;
            this.useAvailableSpritesToolStripMenuItem.CheckOnClick = true;
            this.useAvailableSpritesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useAvailableSpritesToolStripMenuItem.Name = "useAvailableSpritesToolStripMenuItem";
            this.useAvailableSpritesToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.useAvailableSpritesToolStripMenuItem.Text = "Use Sprite Icons";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // patchFDGToolStripMenuItem
            // 
            this.patchFDGToolStripMenuItem.Name = "patchFDGToolStripMenuItem";
            this.patchFDGToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.patchFDGToolStripMenuItem.Text = "Patch FDG";
            this.patchFDGToolStripMenuItem.Click += new System.EventHandler(this.patchFDGToolStripMenuItem_Click);
            // 
            // optionsAndHelpToolStripMenuItem
            // 
            this.optionsAndHelpToolStripMenuItem.Name = "optionsAndHelpToolStripMenuItem";
            this.optionsAndHelpToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.optionsAndHelpToolStripMenuItem.Text = "Options And Help";
            this.optionsAndHelpToolStripMenuItem.Click += new System.EventHandler(this.optionsAndHelpToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editObj);
            this.groupBox1.Controls.Add(this.delObj);
            this.groupBox1.Controls.Add(this.cloneObj);
            this.groupBox1.Controls.Add(this.addObj);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(369, 612);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entity Lists";
            // 
            // editObj
            // 
            this.editObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editObj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editObj.Location = new System.Drawing.Point(178, 573);
            this.editObj.Margin = new System.Windows.Forms.Padding(4);
            this.editObj.Name = "editObj";
            this.editObj.Size = new System.Drawing.Size(75, 28);
            this.editObj.TabIndex = 3;
            this.editObj.Text = "Edit";
            this.editObj.UseVisualStyleBackColor = true;
            this.editObj.Click += new System.EventHandler(this.editObj_Click);
            // 
            // delObj
            // 
            this.delObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delObj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delObj.Location = new System.Drawing.Point(95, 573);
            this.delObj.Margin = new System.Windows.Forms.Padding(4);
            this.delObj.Name = "delObj";
            this.delObj.Size = new System.Drawing.Size(75, 28);
            this.delObj.TabIndex = 2;
            this.delObj.Text = "Delete";
            this.delObj.UseVisualStyleBackColor = true;
            this.delObj.Click += new System.EventHandler(this.delObj_Click);
            // 
            // cloneObj
            // 
            this.cloneObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cloneObj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cloneObj.Location = new System.Drawing.Point(261, 573);
            this.cloneObj.Margin = new System.Windows.Forms.Padding(4);
            this.cloneObj.Name = "cloneObj";
            this.cloneObj.Size = new System.Drawing.Size(75, 28);
            this.cloneObj.TabIndex = 4;
            this.cloneObj.Text = "Clone";
            this.cloneObj.UseVisualStyleBackColor = true;
            this.cloneObj.Click += new System.EventHandler(this.cloneObj_Click);
            // 
            // addObj
            // 
            this.addObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addObj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addObj.Location = new System.Drawing.Point(12, 573);
            this.addObj.Margin = new System.Windows.Forms.Padding(4);
            this.addObj.Name = "addObj";
            this.addObj.Size = new System.Drawing.Size(75, 28);
            this.addObj.TabIndex = 1;
            this.addObj.Text = "New";
            this.addObj.UseVisualStyleBackColor = true;
            this.addObj.Click += new System.EventHandler(this.addObj_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.objTab);
            this.tabControl1.Controls.Add(this.carriablesTab);
            this.tabControl1.Controls.Add(this.itemTab);
            this.tabControl1.Controls.Add(this.bossTab);
            this.tabControl1.Controls.Add(this.enemyTab);
            this.tabControl1.Location = new System.Drawing.Point(8, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 542);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // objTab
            // 
            this.objTab.Controls.Add(this.objList);
            this.objTab.Location = new System.Drawing.Point(4, 25);
            this.objTab.Margin = new System.Windows.Forms.Padding(4);
            this.objTab.Name = "objTab";
            this.objTab.Padding = new System.Windows.Forms.Padding(4);
            this.objTab.Size = new System.Drawing.Size(347, 513);
            this.objTab.TabIndex = 0;
            this.objTab.Text = "Objects";
            this.objTab.UseVisualStyleBackColor = true;
            // 
            // objList
            // 
            this.objList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.objList.FormattingEnabled = true;
            this.objList.ItemHeight = 16;
            this.objList.Location = new System.Drawing.Point(7, 6);
            this.objList.Margin = new System.Windows.Forms.Padding(4);
            this.objList.Name = "objList";
            this.objList.Size = new System.Drawing.Size(329, 500);
            this.objList.TabIndex = 0;
            this.objList.SelectedIndexChanged += new System.EventHandler(this.objList_SelectedIndexChanged);
            this.objList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objList_MouseDoubleClick);
            // 
            // carriablesTab
            // 
            this.carriablesTab.Controls.Add(this.carriablesList);
            this.carriablesTab.Location = new System.Drawing.Point(4, 25);
            this.carriablesTab.Margin = new System.Windows.Forms.Padding(4);
            this.carriablesTab.Name = "carriablesTab";
            this.carriablesTab.Padding = new System.Windows.Forms.Padding(4);
            this.carriablesTab.Size = new System.Drawing.Size(347, 513);
            this.carriablesTab.TabIndex = 1;
            this.carriablesTab.Text = "Carriables";
            this.carriablesTab.UseVisualStyleBackColor = true;
            // 
            // carriablesList
            // 
            this.carriablesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.carriablesList.FormattingEnabled = true;
            this.carriablesList.ItemHeight = 16;
            this.carriablesList.Location = new System.Drawing.Point(7, 6);
            this.carriablesList.Margin = new System.Windows.Forms.Padding(4);
            this.carriablesList.Name = "carriablesList";
            this.carriablesList.Size = new System.Drawing.Size(329, 500);
            this.carriablesList.TabIndex = 4;
            this.carriablesList.SelectedIndexChanged += new System.EventHandler(this.specItemList_SelectedIndexChanged);
            this.carriablesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.specItemList_MouseDoubleClick);
            // 
            // itemTab
            // 
            this.itemTab.Controls.Add(this.itemList);
            this.itemTab.Location = new System.Drawing.Point(4, 25);
            this.itemTab.Margin = new System.Windows.Forms.Padding(4);
            this.itemTab.Name = "itemTab";
            this.itemTab.Size = new System.Drawing.Size(347, 513);
            this.itemTab.TabIndex = 2;
            this.itemTab.Text = "Items";
            this.itemTab.UseVisualStyleBackColor = true;
            // 
            // itemList
            // 
            this.itemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 16;
            this.itemList.Location = new System.Drawing.Point(7, 6);
            this.itemList.Margin = new System.Windows.Forms.Padding(4);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(329, 500);
            this.itemList.TabIndex = 4;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            this.itemList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemList_MouseDoubleClick);
            // 
            // bossTab
            // 
            this.bossTab.Controls.Add(this.bossList);
            this.bossTab.Location = new System.Drawing.Point(4, 25);
            this.bossTab.Margin = new System.Windows.Forms.Padding(4);
            this.bossTab.Name = "bossTab";
            this.bossTab.Size = new System.Drawing.Size(347, 513);
            this.bossTab.TabIndex = 3;
            this.bossTab.Text = "Bosses";
            this.bossTab.UseVisualStyleBackColor = true;
            // 
            // bossList
            // 
            this.bossList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bossList.FormattingEnabled = true;
            this.bossList.ItemHeight = 16;
            this.bossList.Location = new System.Drawing.Point(7, 6);
            this.bossList.Margin = new System.Windows.Forms.Padding(4);
            this.bossList.Name = "bossList";
            this.bossList.Size = new System.Drawing.Size(329, 500);
            this.bossList.TabIndex = 4;
            this.bossList.SelectedIndexChanged += new System.EventHandler(this.bossList_SelectedIndexChanged);
            this.bossList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bossList_MouseDoubleClick);
            // 
            // enemyTab
            // 
            this.enemyTab.Controls.Add(this.enemyList);
            this.enemyTab.Location = new System.Drawing.Point(4, 25);
            this.enemyTab.Margin = new System.Windows.Forms.Padding(4);
            this.enemyTab.Name = "enemyTab";
            this.enemyTab.Size = new System.Drawing.Size(347, 513);
            this.enemyTab.TabIndex = 4;
            this.enemyTab.Text = "Enemies";
            this.enemyTab.UseVisualStyleBackColor = true;
            // 
            // enemyList
            // 
            this.enemyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.enemyList.FormattingEnabled = true;
            this.enemyList.ItemHeight = 16;
            this.enemyList.Location = new System.Drawing.Point(7, 6);
            this.enemyList.Margin = new System.Windows.Forms.Padding(4);
            this.enemyList.Name = "enemyList";
            this.enemyList.Size = new System.Drawing.Size(329, 500);
            this.enemyList.TabIndex = 4;
            this.enemyList.SelectedIndexChanged += new System.EventHandler(this.enemyList_SelectedIndexChanged);
            this.enemyList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.enemyList_MouseDoubleClick);
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Location = new System.Drawing.Point(397, 84);
            this.glControl.Margin = new System.Windows.Forms.Padding(5);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(736, 449);
            this.glControl.TabIndex = 2;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseDown);
            this.glControl.MouseLeave += new System.EventHandler(this.glControl_MouseLeave);
            this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseMove);
            this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseUp);
            this.glControl.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseWheel);
            // 
            // resetCamera
            // 
            this.resetCamera.Enabled = false;
            this.resetCamera.Location = new System.Drawing.Point(1024, 41);
            this.resetCamera.Margin = new System.Windows.Forms.Padding(4);
            this.resetCamera.Name = "resetCamera";
            this.resetCamera.Size = new System.Drawing.Size(109, 38);
            this.resetCamera.TabIndex = 6;
            this.resetCamera.Text = "Reset Camera";
            this.toolTip1.SetToolTip(this.resetCamera, "Moves the camera back to the\r\nclosest position within the level\'s\r\nboundaries.");
            this.resetCamera.UseVisualStyleBackColor = true;
            this.resetCamera.Click += new System.EventHandler(this.resetCamera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(415, 538);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Coordinate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(394, 562);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(394, 592);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Y";
            // 
            // xCoord
            // 
            this.xCoord.Location = new System.Drawing.Point(418, 560);
            this.xCoord.Margin = new System.Windows.Forms.Padding(4);
            this.xCoord.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.xCoord.Name = "xCoord";
            this.xCoord.Size = new System.Drawing.Size(160, 22);
            this.xCoord.TabIndex = 23;
            this.toolTip1.SetToolTip(this.xCoord, "Change the position of the currently\r\nselected entity. Coordinate is the\r\nmain po" +
        "sition, but it can be offset to\r\nany of 16 values within a single tile.");
            this.xCoord.ValueChanged += new System.EventHandler(this.xCoord_ValueChanged);
            // 
            // xOffset
            // 
            this.xOffset.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.xOffset.Location = new System.Drawing.Point(586, 560);
            this.xOffset.Margin = new System.Windows.Forms.Padding(4);
            this.xOffset.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.xOffset.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            -2147483648});
            this.xOffset.Name = "xOffset";
            this.xOffset.Size = new System.Drawing.Size(55, 22);
            this.xOffset.TabIndex = 24;
            this.toolTip1.SetToolTip(this.xOffset, "Change the position of the currently\r\nselected entity. Coordinate is the\r\nmain po" +
        "sition, but it can be offset to\r\nany of 16 values within a single tile.\r\n");
            this.xOffset.ValueChanged += new System.EventHandler(this.xOffset_ValueChanged);
            // 
            // yOffset
            // 
            this.yOffset.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.yOffset.Location = new System.Drawing.Point(586, 590);
            this.yOffset.Margin = new System.Windows.Forms.Padding(4);
            this.yOffset.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.yOffset.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            -2147483648});
            this.yOffset.Name = "yOffset";
            this.yOffset.Size = new System.Drawing.Size(55, 22);
            this.yOffset.TabIndex = 26;
            this.toolTip1.SetToolTip(this.yOffset, "Change the position of the currently\r\nselected entity. Coordinate is the\r\nmain po" +
        "sition, but it can be offset to\r\nany of 16 values within a single tile.\r\n");
            this.yOffset.ValueChanged += new System.EventHandler(this.yOffset_ValueChanged);
            // 
            // yCoord
            // 
            this.yCoord.Location = new System.Drawing.Point(418, 590);
            this.yCoord.Margin = new System.Windows.Forms.Padding(4);
            this.yCoord.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.yCoord.Name = "yCoord";
            this.yCoord.Size = new System.Drawing.Size(160, 22);
            this.yCoord.TabIndex = 25;
            this.toolTip1.SetToolTip(this.yCoord, "Change the position of the currently\r\nselected entity. Coordinate is the\r\nmain po" +
        "sition, but it can be offset to\r\nany of 16 values within a single tile.\r\n");
            this.yCoord.ValueChanged += new System.EventHandler(this.yCoord_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.editAutoMove);
            this.groupBox2.Controls.Add(this.editMat);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.editModf);
            this.groupBox2.Controls.Add(this.editFLand);
            this.groupBox2.Controls.Add(this.editMLand);
            this.groupBox2.Controls.Add(this.editBLand);
            this.groupBox2.Controls.Add(this.editBlock);
            this.groupBox2.Controls.Add(this.editCol);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(1141, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(360, 542);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tile Data Editor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(14, 313);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 17);
            this.label15.TabIndex = 104;
            this.label15.Text = "Decoration Data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(14, 400);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 72;
            this.label13.Text = "FLand";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(74, 310);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl2.RightToLeftLayout = true;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(255, 123);
            this.tabControl2.TabIndex = 103;
            this.toolTip1.SetToolTip(this.tabControl2, "Decoration data that\'s used to make\r\nthe actual tiling of the level. Has three\r\nd" +
        "ifferent categories.\r\nBLand - Background Decor.\r\nMLand - Middle, Walkable Decor." +
        "\r\nFLand - Foreground Decor.");
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.d1_1);
            this.tabPage1.Controls.Add(this.d1_2);
            this.tabPage1.Controls.Add(this.d1_3);
            this.tabPage1.Controls.Add(this.d2_4);
            this.tabPage1.Controls.Add(this.d3_4);
            this.tabPage1.Controls.Add(this.d2_3);
            this.tabPage1.Controls.Add(this.d1_4);
            this.tabPage1.Controls.Add(this.d2_2);
            this.tabPage1.Controls.Add(this.d3_3);
            this.tabPage1.Controls.Add(this.d3_1);
            this.tabPage1.Controls.Add(this.d3_2);
            this.tabPage1.Controls.Add(this.d2_1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(247, 94);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Byte Values";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // d1_1
            // 
            this.d1_1.Location = new System.Drawing.Point(7, 9);
            this.d1_1.Margin = new System.Windows.Forms.Padding(4);
            this.d1_1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d1_1.Name = "d1_1";
            this.d1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d1_1.Size = new System.Drawing.Size(52, 22);
            this.d1_1.TabIndex = 73;
            this.d1_1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // d1_2
            // 
            this.d1_2.Location = new System.Drawing.Point(67, 9);
            this.d1_2.Margin = new System.Windows.Forms.Padding(4);
            this.d1_2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d1_2.Name = "d1_2";
            this.d1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d1_2.Size = new System.Drawing.Size(52, 22);
            this.d1_2.TabIndex = 74;
            this.d1_2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // d1_3
            // 
            this.d1_3.Location = new System.Drawing.Point(127, 9);
            this.d1_3.Margin = new System.Windows.Forms.Padding(4);
            this.d1_3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d1_3.Name = "d1_3";
            this.d1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d1_3.Size = new System.Drawing.Size(52, 22);
            this.d1_3.TabIndex = 75;
            // 
            // d2_4
            // 
            this.d2_4.Location = new System.Drawing.Point(187, 63);
            this.d2_4.Margin = new System.Windows.Forms.Padding(4);
            this.d2_4.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.d2_4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.d2_4.Name = "d2_4";
            this.d2_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d2_4.Size = new System.Drawing.Size(52, 22);
            this.d2_4.TabIndex = 80;
            this.d2_4.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // d3_4
            // 
            this.d3_4.Location = new System.Drawing.Point(187, 36);
            this.d3_4.Margin = new System.Windows.Forms.Padding(4);
            this.d3_4.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.d3_4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.d3_4.Name = "d3_4";
            this.d3_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d3_4.Size = new System.Drawing.Size(52, 22);
            this.d3_4.TabIndex = 84;
            this.d3_4.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // d2_3
            // 
            this.d2_3.Location = new System.Drawing.Point(127, 63);
            this.d2_3.Margin = new System.Windows.Forms.Padding(4);
            this.d2_3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d2_3.Name = "d2_3";
            this.d2_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d2_3.Size = new System.Drawing.Size(52, 22);
            this.d2_3.TabIndex = 79;
            // 
            // d1_4
            // 
            this.d1_4.Location = new System.Drawing.Point(187, 9);
            this.d1_4.Margin = new System.Windows.Forms.Padding(4);
            this.d1_4.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.d1_4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.d1_4.Name = "d1_4";
            this.d1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d1_4.Size = new System.Drawing.Size(52, 22);
            this.d1_4.TabIndex = 76;
            this.d1_4.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // d2_2
            // 
            this.d2_2.Location = new System.Drawing.Point(67, 63);
            this.d2_2.Margin = new System.Windows.Forms.Padding(4);
            this.d2_2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d2_2.Name = "d2_2";
            this.d2_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d2_2.Size = new System.Drawing.Size(52, 22);
            this.d2_2.TabIndex = 78;
            this.d2_2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // d3_3
            // 
            this.d3_3.Location = new System.Drawing.Point(127, 36);
            this.d3_3.Margin = new System.Windows.Forms.Padding(4);
            this.d3_3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d3_3.Name = "d3_3";
            this.d3_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d3_3.Size = new System.Drawing.Size(52, 22);
            this.d3_3.TabIndex = 83;
            // 
            // d3_1
            // 
            this.d3_1.Location = new System.Drawing.Point(7, 36);
            this.d3_1.Margin = new System.Windows.Forms.Padding(4);
            this.d3_1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d3_1.Name = "d3_1";
            this.d3_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d3_1.Size = new System.Drawing.Size(52, 22);
            this.d3_1.TabIndex = 81;
            this.d3_1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // d3_2
            // 
            this.d3_2.Location = new System.Drawing.Point(67, 36);
            this.d3_2.Margin = new System.Windows.Forms.Padding(4);
            this.d3_2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d3_2.Name = "d3_2";
            this.d3_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d3_2.Size = new System.Drawing.Size(52, 22);
            this.d3_2.TabIndex = 82;
            this.d3_2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // d2_1
            // 
            this.d2_1.Location = new System.Drawing.Point(7, 63);
            this.d2_1.Margin = new System.Windows.Forms.Padding(4);
            this.d2_1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.d2_1.Name = "d2_1";
            this.d2_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d2_1.Size = new System.Drawing.Size(52, 22);
            this.d2_1.TabIndex = 77;
            this.d2_1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.d2_hex);
            this.tabPage2.Controls.Add(this.d3_hex);
            this.tabPage2.Controls.Add(this.d1_hex);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(247, 94);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hex Values";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // d2_hex
            // 
            this.d2_hex.Location = new System.Drawing.Point(29, 62);
            this.d2_hex.MaxLength = 8;
            this.d2_hex.Name = "d2_hex";
            this.d2_hex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d2_hex.Size = new System.Drawing.Size(188, 22);
            this.d2_hex.TabIndex = 2;
            this.d2_hex.Text = "FFFF00FF";
            this.d2_hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d3_hex
            // 
            this.d3_hex.Location = new System.Drawing.Point(29, 35);
            this.d3_hex.MaxLength = 8;
            this.d3_hex.Name = "d3_hex";
            this.d3_hex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d3_hex.Size = new System.Drawing.Size(188, 22);
            this.d3_hex.TabIndex = 1;
            this.d3_hex.Text = "FFFF00FF";
            this.d3_hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d1_hex
            // 
            this.d1_hex.Location = new System.Drawing.Point(29, 8);
            this.d1_hex.MaxLength = 8;
            this.d1_hex.Name = "d1_hex";
            this.d1_hex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d1_hex.Size = new System.Drawing.Size(188, 22);
            this.d1_hex.TabIndex = 0;
            this.d1_hex.Text = "FFFF00FF";
            this.d1_hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(14, 346);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 70;
            this.label11.Text = "BLand";
            // 
            // editAutoMove
            // 
            this.editAutoMove.AutoSize = true;
            this.editAutoMove.Checked = true;
            this.editAutoMove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editAutoMove.ForeColor = System.Drawing.SystemColors.Control;
            this.editAutoMove.Location = new System.Drawing.Point(17, 513);
            this.editAutoMove.Margin = new System.Windows.Forms.Padding(4);
            this.editAutoMove.Name = "editAutoMove";
            this.editAutoMove.Size = new System.Drawing.Size(170, 21);
            this.editAutoMove.TabIndex = 101;
            this.editAutoMove.Text = "Edit Auto Move Speed";
            this.editAutoMove.UseVisualStyleBackColor = true;
            this.editAutoMove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // editMat
            // 
            this.editMat.AutoSize = true;
            this.editMat.Checked = true;
            this.editMat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editMat.ForeColor = System.Drawing.SystemColors.Control;
            this.editMat.Location = new System.Drawing.Point(17, 488);
            this.editMat.Margin = new System.Windows.Forms.Padding(4);
            this.editMat.Name = "editMat";
            this.editMat.Size = new System.Drawing.Size(115, 21);
            this.editMat.TabIndex = 100;
            this.editMat.Text = "Edit Materials";
            this.editMat.UseVisualStyleBackColor = true;
            this.editMat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(14, 373);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 71;
            this.label12.Text = "MLand";
            // 
            // editModf
            // 
            this.editModf.AutoSize = true;
            this.editModf.Checked = true;
            this.editModf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editModf.ForeColor = System.Drawing.SystemColors.Control;
            this.editModf.Location = new System.Drawing.Point(17, 463);
            this.editModf.Margin = new System.Windows.Forms.Padding(4);
            this.editModf.Name = "editModf";
            this.editModf.Size = new System.Drawing.Size(115, 21);
            this.editModf.TabIndex = 99;
            this.editModf.Text = "Edit Modifiers";
            this.editModf.UseVisualStyleBackColor = true;
            this.editModf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // editFLand
            // 
            this.editFLand.AutoSize = true;
            this.editFLand.Checked = true;
            this.editFLand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editFLand.Location = new System.Drawing.Point(212, 513);
            this.editFLand.Margin = new System.Windows.Forms.Padding(4);
            this.editFLand.Name = "editFLand";
            this.editFLand.Size = new System.Drawing.Size(98, 21);
            this.editFLand.TabIndex = 98;
            this.editFLand.Text = "Edit FLand";
            this.editFLand.UseVisualStyleBackColor = true;
            this.editFLand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // editMLand
            // 
            this.editMLand.AutoSize = true;
            this.editMLand.Checked = true;
            this.editMLand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editMLand.ForeColor = System.Drawing.SystemColors.Control;
            this.editMLand.Location = new System.Drawing.Point(212, 488);
            this.editMLand.Margin = new System.Windows.Forms.Padding(4);
            this.editMLand.Name = "editMLand";
            this.editMLand.Size = new System.Drawing.Size(101, 21);
            this.editMLand.TabIndex = 97;
            this.editMLand.Text = "Edit MLand";
            this.editMLand.UseVisualStyleBackColor = true;
            this.editMLand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // editBLand
            // 
            this.editBLand.AutoSize = true;
            this.editBLand.Checked = true;
            this.editBLand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editBLand.ForeColor = System.Drawing.SystemColors.Control;
            this.editBLand.Location = new System.Drawing.Point(212, 463);
            this.editBLand.Margin = new System.Windows.Forms.Padding(4);
            this.editBLand.Name = "editBLand";
            this.editBLand.Size = new System.Drawing.Size(99, 21);
            this.editBLand.TabIndex = 96;
            this.editBLand.Text = "Edit BLand";
            this.editBLand.UseVisualStyleBackColor = true;
            this.editBLand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // editBlock
            // 
            this.editBlock.AutoSize = true;
            this.editBlock.Checked = true;
            this.editBlock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editBlock.ForeColor = System.Drawing.SystemColors.Control;
            this.editBlock.Location = new System.Drawing.Point(212, 438);
            this.editBlock.Margin = new System.Windows.Forms.Padding(4);
            this.editBlock.Name = "editBlock";
            this.editBlock.Size = new System.Drawing.Size(99, 21);
            this.editBlock.TabIndex = 95;
            this.editBlock.Text = "Edit Blocks";
            this.editBlock.UseVisualStyleBackColor = true;
            this.editBlock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // editCol
            // 
            this.editCol.AutoSize = true;
            this.editCol.Checked = true;
            this.editCol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editCol.ForeColor = System.Drawing.SystemColors.Control;
            this.editCol.Location = new System.Drawing.Point(17, 438);
            this.editCol.Margin = new System.Windows.Forms.Padding(4);
            this.editCol.Name = "editCol";
            this.editCol.Size = new System.Drawing.Size(155, 21);
            this.editCol.TabIndex = 94;
            this.editCol.Text = "Edit Collision Shape";
            this.editCol.UseVisualStyleBackColor = true;
            this.editCol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.vBlock);
            this.groupBox4.Controls.Add(this.blockList);
            this.groupBox4.Controls.Add(this.blockImg);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(9, 236);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(340, 65);
            this.groupBox4.TabIndex = 92;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Block Data";
            // 
            // vBlock
            // 
            this.vBlock.Enabled = false;
            this.vBlock.Location = new System.Drawing.Point(265, 26);
            this.vBlock.Margin = new System.Windows.Forms.Padding(4);
            this.vBlock.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.vBlock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.vBlock.Name = "vBlock";
            this.vBlock.Size = new System.Drawing.Size(55, 22);
            this.vBlock.TabIndex = 107;
            this.toolTip1.SetToolTip(this.vBlock, "The block that\'s placed on a tile,\r\nthe \"origin point\" of most blocks\r\nbigger tha" +
        "n a single tile is their\r\nbottom-left corner.\r\n");
            this.vBlock.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.vBlock.ValueChanged += new System.EventHandler(this.vBlock_ValueChanged_1);
            // 
            // blockList
            // 
            this.blockList.Enabled = false;
            this.blockList.FormattingEnabled = true;
            this.blockList.Items.AddRange(new object[] {
            "No Block",
            "Star",
            "Breakable",
            "Fire",
            "Ice",
            "Metal",
            "Crumble",
            "Metal Crumble",
            "Bomb",
            "Bomb Chain",
            "Invisible Bomb Chain",
            "Bomb Generated",
            "Stone",
            "Stone 2x2",
            "Stone T",
            "Stone Reverse T",
            "Stone 3x3",
            "Stone 3x1",
            "Stone 1x3",
            "Stone Stair Left",
            "Stone Stair Right",
            "Stone 4x4",
            "Stone 2x4x4x2",
            "Gold 2x2",
            "Gold 3x3",
            "Super",
            "Super (Alt)",
            "Super (Alt 2)",
            "Super 2x2",
            "Super 2x2 (Alt)",
            "Super 1x2",
            "Super 4x2",
            "Super 3x3",
            "Super 4x4",
            "Super Top",
            "Super Top 2x2",
            "Super Top 2x2 (Alt)",
            "Tree Bottom",
            "Tree Bottom (Alt)",
            "Tree",
            "Tree (Alt)",
            "Tree Top",
            "Giant Tree Right Corner",
            "Giant Tree Bottom",
            "Giant Tree Left Corner",
            "Giant Tree Right",
            "Giant Tree",
            "Giant Tree Left",
            "Snow",
            "Snow (Wide)",
            "Iced Snow",
            "Iced Snow (Wide)",
            "Fire (Fragile)",
            "Fire 2x2 (Fragile)"});
            this.blockList.Location = new System.Drawing.Point(11, 25);
            this.blockList.Name = "blockList";
            this.blockList.Size = new System.Drawing.Size(195, 24);
            this.blockList.TabIndex = 106;
            this.toolTip1.SetToolTip(this.blockList, "The block that\'s placed on a tile,\r\nthe \"origin point\" of most blocks\r\nbigger tha" +
        "n a single tile is their\r\nbottom-left corner.");
            this.blockList.SelectedIndexChanged += new System.EventHandler(this.blockList_SelectedIndexChanged);
            // 
            // blockImg
            // 
            this.blockImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.blockImg.Image = global::MagoCrate.Properties.Resources._0;
            this.blockImg.Location = new System.Drawing.Point(215, 17);
            this.blockImg.Margin = new System.Windows.Forms.Padding(4);
            this.blockImg.Name = "blockImg";
            this.blockImg.Size = new System.Drawing.Size(40, 37);
            this.blockImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blockImg.TabIndex = 92;
            this.blockImg.TabStop = false;
            this.toolTip1.SetToolTip(this.blockImg, "The block that\'s placed on a tile,\r\nthe \"origin point\" of most blocks\r\nbigger tha" +
        "n a single tile is their\r\nbottom-left corner.\r\n");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialList);
            this.groupBox3.Controls.Add(this.vShape);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.colImg);
            this.groupBox3.Controls.Add(this.ice);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.spike);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.boundary);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.vmat);
            this.groupBox3.Controls.Add(this.ladder);
            this.groupBox3.Controls.Add(this.vautomove);
            this.groupBox3.Controls.Add(this.water);
            this.groupBox3.Controls.Add(this.lava);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(9, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(340, 210);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Collision Data";
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
            this.materialList.Location = new System.Drawing.Point(185, 141);
            this.materialList.Name = "materialList";
            this.materialList.Size = new System.Drawing.Size(94, 24);
            this.materialList.TabIndex = 108;
            this.toolTip1.SetToolTip(this.materialList, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.");
            this.materialList.SelectedIndexChanged += new System.EventHandler(this.materialList_SelectedIndexChanged);
            // 
            // vShape
            // 
            this.vShape.Location = new System.Drawing.Point(265, 23);
            this.vShape.Margin = new System.Windows.Forms.Padding(4);
            this.vShape.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.vShape.Name = "vShape";
            this.vShape.Size = new System.Drawing.Size(55, 22);
            this.vShape.TabIndex = 106;
            this.vShape.ValueChanged += new System.EventHandler(this.vShape_ValueChanged_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(18, 84);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 92;
            this.label14.Text = "Modifiers";
            // 
            // colImg
            // 
            this.colImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colImg.Image = global::MagoCrate.Properties.Resources._0;
            this.colImg.Location = new System.Drawing.Point(215, 15);
            this.colImg.Margin = new System.Windows.Forms.Padding(4);
            this.colImg.Name = "colImg";
            this.colImg.Size = new System.Drawing.Size(40, 37);
            this.colImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colImg.TabIndex = 91;
            this.colImg.TabStop = false;
            this.colImg.Click += new System.EventHandler(this.colImg_Click);
            // 
            // ice
            // 
            this.ice.AutoSize = true;
            this.ice.ForeColor = System.Drawing.SystemColors.Control;
            this.ice.Image = global::MagoCrate.Properties.Resources.ice;
            this.ice.Location = new System.Drawing.Point(198, 111);
            this.ice.Margin = new System.Windows.Forms.Padding(4);
            this.ice.Name = "ice";
            this.ice.Size = new System.Drawing.Size(65, 21);
            this.ice.TabIndex = 90;
            this.ice.Text = "Ice";
            this.ice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.ice, "Makes the collision of its\r\nrespective tile slippery.");
            this.ice.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Shape (Click Box to Select)";
            // 
            // spike
            // 
            this.spike.AutoSize = true;
            this.spike.ForeColor = System.Drawing.SystemColors.Control;
            this.spike.Image = global::MagoCrate.Properties.Resources.spike;
            this.spike.Location = new System.Drawing.Point(198, 83);
            this.spike.Margin = new System.Windows.Forms.Padding(4);
            this.spike.Name = "spike";
            this.spike.Size = new System.Drawing.Size(82, 21);
            this.spike.TabIndex = 89;
            this.spike.Text = "Spike";
            this.spike.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.spike, "Spikes are part of a tile\'s MLand\r\nDecoration, enabling this allows\r\na tile to fu" +
        "nction like spikes.");
            this.spike.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Collision Material";
            this.toolTip1.SetToolTip(this.label7, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.");
            // 
            // boundary
            // 
            this.boundary.AutoSize = true;
            this.boundary.ForeColor = System.Drawing.SystemColors.Control;
            this.boundary.Image = global::MagoCrate.Properties.Resources.boundary;
            this.boundary.Location = new System.Drawing.Point(198, 55);
            this.boundary.Margin = new System.Windows.Forms.Padding(4);
            this.boundary.Name = "boundary";
            this.boundary.Size = new System.Drawing.Size(108, 21);
            this.boundary.TabIndex = 88;
            this.boundary.Text = "Boundary";
            this.boundary.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.boundary, "Prevents certain things from getting\r\nthrough like players and enemies.\r\nUsually " +
        "combined with collision 1\r\nto create level boundaries while\r\nstill allowing for " +
        "decoration data\r\non those tiles.");
            this.boundary.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Auto Move Speed";
            this.toolTip1.SetToolTip(this.label8, "Auto-movement for that tile. It\'s\r\nalmost exclusively used for the\r\nEgg Engines c" +
        "onveyer belts.\r\nNegative values move you left\r\ninstead of right.");
            // 
            // vmat
            // 
            this.vmat.Location = new System.Drawing.Point(286, 142);
            this.vmat.Margin = new System.Windows.Forms.Padding(4);
            this.vmat.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.vmat.Name = "vmat";
            this.vmat.Size = new System.Drawing.Size(48, 22);
            this.vmat.TabIndex = 87;
            this.toolTip1.SetToolTip(this.vmat, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.\r\n");
            this.vmat.ValueChanged += new System.EventHandler(this.vmat_ValueChanged);
            // 
            // ladder
            // 
            this.ladder.AutoSize = true;
            this.ladder.ForeColor = System.Drawing.SystemColors.Control;
            this.ladder.Image = global::MagoCrate.Properties.Resources.ladder;
            this.ladder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ladder.Location = new System.Drawing.Point(98, 55);
            this.ladder.Margin = new System.Windows.Forms.Padding(4);
            this.ladder.Name = "ladder";
            this.ladder.Size = new System.Drawing.Size(92, 21);
            this.ladder.TabIndex = 62;
            this.ladder.Text = "Ladder";
            this.ladder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.ladder, "Allows you to climb up and down on\r\nthat tile, still requires the decoration\r\ndat" +
        "a to look like a ladder.");
            this.ladder.UseVisualStyleBackColor = true;
            // 
            // vautomove
            // 
            this.vautomove.Location = new System.Drawing.Point(185, 174);
            this.vautomove.Margin = new System.Windows.Forms.Padding(4);
            this.vautomove.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.vautomove.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.vautomove.Name = "vautomove";
            this.vautomove.Size = new System.Drawing.Size(149, 22);
            this.vautomove.TabIndex = 86;
            // 
            // water
            // 
            this.water.AutoSize = true;
            this.water.ForeColor = System.Drawing.SystemColors.Control;
            this.water.Image = global::MagoCrate.Properties.Resources.water;
            this.water.Location = new System.Drawing.Point(98, 83);
            this.water.Margin = new System.Windows.Forms.Padding(4);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(85, 21);
            this.water.TabIndex = 63;
            this.water.Text = "Water";
            this.water.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.water, "Fills that tile with water collision,\r\nmaking Kirby swim when within it.\r\nStill r" +
        "equires decoration data to\r\nlook like water.");
            this.water.UseVisualStyleBackColor = true;
            // 
            // lava
            // 
            this.lava.AutoSize = true;
            this.lava.ForeColor = System.Drawing.SystemColors.Control;
            this.lava.Image = global::MagoCrate.Properties.Resources.lava;
            this.lava.Location = new System.Drawing.Point(98, 111);
            this.lava.Margin = new System.Windows.Forms.Padding(4);
            this.lava.Name = "lava";
            this.lava.Size = new System.Drawing.Size(78, 21);
            this.lava.TabIndex = 64;
            this.lava.Text = "Lava";
            this.lava.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.lava, "Makes the collision of its\r\nrespective tile burn you.\r\n");
            this.lava.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(583, 538);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Offset";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sizeW);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.sizeH);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Location = new System.Drawing.Point(1141, 583);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(360, 62);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Level Size";
            // 
            // sizeW
            // 
            this.sizeW.Location = new System.Drawing.Point(239, 27);
            this.sizeW.Margin = new System.Windows.Forms.Padding(4);
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
            this.sizeW.TabIndex = 3;
            this.toolTip1.SetToolTip(this.sizeW, "Change the level size, expands");
            this.sizeW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeW.ValueChanged += new System.EventHandler(this.UpdateLevelSize);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(187, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Width";
            this.toolTip1.SetToolTip(this.label9, "Change the level size, expands\r\nfrom left to right and down\r\nto up.\r\n");
            // 
            // sizeH
            // 
            this.sizeH.Location = new System.Drawing.Point(77, 27);
            this.sizeH.Margin = new System.Windows.Forms.Padding(4);
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
            this.sizeH.TabIndex = 1;
            this.toolTip1.SetToolTip(this.sizeH, "Change the level size, expands\r\nfrom left to right and down\r\nto up.");
            this.sizeH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeH.ValueChanged += new System.EventHandler(this.UpdateLevelSize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height";
            this.toolTip1.SetToolTip(this.label2, "Change the level size, expands\r\nfrom left to right and down\r\nto up.\r\n");
            // 
            // halfTileLock
            // 
            this.halfTileLock.AutoSize = true;
            this.halfTileLock.Checked = true;
            this.halfTileLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.halfTileLock.ForeColor = System.Drawing.SystemColors.Control;
            this.halfTileLock.Location = new System.Drawing.Point(397, 625);
            this.halfTileLock.Margin = new System.Windows.Forms.Padding(4);
            this.halfTileLock.Name = "halfTileLock";
            this.halfTileLock.Size = new System.Drawing.Size(260, 21);
            this.halfTileLock.TabIndex = 102;
            this.halfTileLock.Text = "Increment Offset Values in Half-Tiles";
            this.toolTip1.SetToolTip(this.halfTileLock, "Determine whether incrementing\r\nthe offset values will change by 1\r\nor 8 units. 8" +
        " units being equivalent\r\nto half a tile.");
            this.halfTileLock.UseVisualStyleBackColor = true;
            this.halfTileLock.CheckedChanged += new System.EventHandler(this.halfTileLock_CheckedChanged);
            // 
            // viewType
            // 
            this.viewType.Enabled = false;
            this.viewType.FormattingEnabled = true;
            this.viewType.Items.AddRange(new object[] {
            "Collision",
            "Decoration: BLand",
            "Decoration: MLand",
            "Decoration: FLand"});
            this.viewType.Location = new System.Drawing.Point(862, 49);
            this.viewType.Name = "viewType";
            this.viewType.Size = new System.Drawing.Size(155, 24);
            this.viewType.TabIndex = 103;
            this.toolTip1.SetToolTip(this.viewType, "Change the view type between being\r\nable to view the level normally or\r\nbeing abl" +
        "e to view a single category\r\nof decoration data.");
            this.viewType.SelectedIndexChanged += new System.EventHandler(this.viewType_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(782, 52);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 104;
            this.label16.Text = "View Type";
            this.toolTip1.SetToolTip(this.label16, "Change the view type between being\r\nable to view the level normally or\r\nbeing abl" +
        "e to view a single category\r\nof decoration data.");
            // 
            // pick
            // 
            this.pick.BackgroundImage = global::MagoCrate.Properties.Resources.pick;
            this.pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pick.Location = new System.Drawing.Point(446, 40);
            this.pick.Margin = new System.Windows.Forms.Padding(4);
            this.pick.Name = "pick";
            this.pick.Size = new System.Drawing.Size(41, 41);
            this.pick.TabIndex = 30;
            this.toolTip1.SetToolTip(this.pick, "Click tiles to copy their data\r\ninto the right-hand \r\n\"Tile Data Editor\"\r\n");
            this.pick.UseVisualStyleBackColor = true;
            this.pick.Click += new System.EventHandler(this.pick_Click);
            // 
            // draw
            // 
            this.draw.BackgroundImage = global::MagoCrate.Properties.Resources.draw;
            this.draw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.draw.Location = new System.Drawing.Point(397, 40);
            this.draw.Margin = new System.Windows.Forms.Padding(4);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(41, 41);
            this.draw.TabIndex = 5;
            this.toolTip1.SetToolTip(this.draw, "Click tiles to overwrite their\r\ntile data with the data in the\r\nright-hand \"Tile " +
        "Data Editor\"");
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1517, 658);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.viewType);
            this.Controls.Add(this.halfTileLock);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pick);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.yOffset);
            this.Controls.Add(this.yCoord);
            this.Controls.Add(this.xOffset);
            this.Controls.Add(this.xCoord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetCamera);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.glControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagoCrate";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Enter += new System.EventHandler(this.MainForm_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.objTab.ResumeLayout(false);
            this.carriablesTab.ResumeLayout(false);
            this.itemTab.ResumeLayout(false);
            this.bossTab.ResumeLayout(false);
            this.enemyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.d1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2_1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockImg)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vautomove)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage objTab;
        private System.Windows.Forms.Button editObj;
        private System.Windows.Forms.Button delObj;
        private System.Windows.Forms.Button addObj;
        private System.Windows.Forms.ListBox objList;
        private System.Windows.Forms.TabPage carriablesTab;
        private System.Windows.Forms.ListBox carriablesList;
        private System.Windows.Forms.TabPage itemTab;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.TabPage bossTab;
        private System.Windows.Forms.ListBox bossList;
        private System.Windows.Forms.TabPage enemyTab;
        private System.Windows.Forms.ListBox enemyList;
        private OpenTK.GLControl glControl;
        private System.Windows.Forms.ToolStripMenuItem stageSettingsToolStripMenuItem;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button resetCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown xCoord;
        private System.Windows.Forms.NumericUpDown xOffset;
        private System.Windows.Forms.NumericUpDown yOffset;
        private System.Windows.Forms.NumericUpDown yCoord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cloneObj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem renderSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderTileModifiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderObjectPointsToolStripMenuItem;
        private System.Windows.Forms.CheckBox ice;
        private System.Windows.Forms.CheckBox spike;
        private System.Windows.Forms.CheckBox boundary;
        private System.Windows.Forms.NumericUpDown vmat;
        private System.Windows.Forms.NumericUpDown vautomove;
        private System.Windows.Forms.NumericUpDown d1_1;
        private System.Windows.Forms.CheckBox lava;
        private System.Windows.Forms.CheckBox water;
        private System.Windows.Forms.CheckBox ladder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox editCol;
        private System.Windows.Forms.CheckBox editBLand;
        private System.Windows.Forms.CheckBox editBlock;
        private System.Windows.Forms.PictureBox colImg;
        private System.Windows.Forms.PictureBox blockImg;
        private System.Windows.Forms.Button pick;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown sizeW;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown sizeH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.CheckBox editFLand;
        private System.Windows.Forms.CheckBox editMLand;
        private System.Windows.Forms.CheckBox editAutoMove;
        private System.Windows.Forms.CheckBox editMat;
        private System.Windows.Forms.CheckBox editModf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem useAvailableSpritesToolStripMenuItem;
        private System.Windows.Forms.CheckBox halfTileLock;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown d1_2;
        private System.Windows.Forms.NumericUpDown d1_3;
        private System.Windows.Forms.NumericUpDown d2_4;
        private System.Windows.Forms.NumericUpDown d3_4;
        private System.Windows.Forms.NumericUpDown d2_3;
        private System.Windows.Forms.NumericUpDown d1_4;
        private System.Windows.Forms.NumericUpDown d2_2;
        private System.Windows.Forms.NumericUpDown d3_3;
        private System.Windows.Forms.NumericUpDown d3_1;
        private System.Windows.Forms.NumericUpDown d3_2;
        private System.Windows.Forms.NumericUpDown d2_1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox d2_hex;
        private System.Windows.Forms.TextBox d3_hex;
        private System.Windows.Forms.TextBox d1_hex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem optionsAndHelpToolStripMenuItem;
        private System.Windows.Forms.ComboBox viewType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem renderMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderAutoMovementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox blockList;
        private System.Windows.Forms.NumericUpDown vBlock;
        private System.Windows.Forms.NumericUpDown vShape;
        private System.Windows.Forms.ComboBox materialList;
        private System.Windows.Forms.ToolStripMenuItem patchFDGToolStripMenuItem;
    }
}

