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
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchFDGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanMaterialsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBoundariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateBoundariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileDataEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCollisionShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editModifiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAutoMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBLandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMLandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFLandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderCollisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderTileModifiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderDynamicTerrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderObjectPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderEntityNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderAutoMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useAvailableSpritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dynamicTab = new System.Windows.Forms.TabPage();
            this.dynamicList = new System.Windows.Forms.ListBox();
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
            this.unlockAll = new System.Windows.Forms.Button();
            this.editDecoF = new System.Windows.Forms.Button();
            this.editDecoM = new System.Windows.Forms.Button();
            this.editDecoB = new System.Windows.Forms.Button();
            this.editBlock = new System.Windows.Forms.Button();
            this.editAuto = new System.Windows.Forms.Button();
            this.editMat = new System.Windows.Forms.Button();
            this.editMod = new System.Windows.Forms.Button();
            this.editCol = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dB_ID = new System.Windows.Forms.NumericUpDown();
            this.dB_Unk = new System.Windows.Forms.NumericUpDown();
            this.dF_Dynamic = new System.Windows.Forms.NumericUpDown();
            this.dM_Dynamic = new System.Windows.Forms.NumericUpDown();
            this.dF_Unk = new System.Windows.Forms.NumericUpDown();
            this.dB_Dynamic = new System.Windows.Forms.NumericUpDown();
            this.dM_Unk = new System.Windows.Forms.NumericUpDown();
            this.dM_ID = new System.Windows.Forms.NumericUpDown();
            this.dF_ID = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dF_hex = new System.Windows.Forms.TextBox();
            this.dM_hex = new System.Windows.Forms.TextBox();
            this.dB_hex = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.vMat = new System.Windows.Forms.NumericUpDown();
            this.ladder = new System.Windows.Forms.CheckBox();
            this.vAutomove = new System.Windows.Forms.NumericUpDown();
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
            this.paletteList = new System.Windows.Forms.ComboBox();
            this.dropper = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.tileName = new System.Windows.Forms.TextBox();
            this.savePalette = new System.Windows.Forms.Button();
            this.createPalette = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pTile22 = new System.Windows.Forms.Button();
            this.pTile21 = new System.Windows.Forms.Button();
            this.pTile23 = new System.Windows.Forms.Button();
            this.pTile20 = new System.Windows.Forms.Button();
            this.pTile15 = new System.Windows.Forms.Button();
            this.pTile14 = new System.Windows.Forms.Button();
            this.pTile13 = new System.Windows.Forms.Button();
            this.pTile12 = new System.Windows.Forms.Button();
            this.pTile19 = new System.Windows.Forms.Button();
            this.pTile11 = new System.Windows.Forms.Button();
            this.pTile18 = new System.Windows.Forms.Button();
            this.pTile10 = new System.Windows.Forms.Button();
            this.pTile2 = new System.Windows.Forms.Button();
            this.pTile6 = new System.Windows.Forms.Button();
            this.pTile8 = new System.Windows.Forms.Button();
            this.pTile7 = new System.Windows.Forms.Button();
            this.pTile5 = new System.Windows.Forms.Button();
            this.pTile4 = new System.Windows.Forms.Button();
            this.pTile24 = new System.Windows.Forms.Button();
            this.pTile16 = new System.Windows.Forms.Button();
            this.pTile3 = new System.Windows.Forms.Button();
            this.pTile17 = new System.Windows.Forms.Button();
            this.pTile9 = new System.Windows.Forms.Button();
            this.pTile1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pTile32 = new System.Windows.Forms.Button();
            this.pTile31 = new System.Windows.Forms.Button();
            this.pTile30 = new System.Windows.Forms.Button();
            this.pTile29 = new System.Windows.Forms.Button();
            this.pTile28 = new System.Windows.Forms.Button();
            this.pTile27 = new System.Windows.Forms.Button();
            this.pTile26 = new System.Windows.Forms.Button();
            this.pTile25 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.objTab.SuspendLayout();
            this.carriablesTab.SuspendLayout();
            this.itemTab.SuspendLayout();
            this.bossTab.SuspendLayout();
            this.enemyTab.SuspendLayout();
            this.dynamicTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Unk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dF_Dynamic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_Dynamic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dF_Unk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Dynamic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_Unk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dF_ID)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockImg)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAutomove)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.renderSettingsToolStripMenuItem,
            this.optionsAndHelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1504, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.clearToolStripMenuItem});
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
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.stageSettingsToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.tileDataEditorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // stageSettingsToolStripMenuItem
            // 
            this.stageSettingsToolStripMenuItem.Name = "stageSettingsToolStripMenuItem";
            this.stageSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.stageSettingsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.stageSettingsToolStripMenuItem.Text = "Stage Settings";
            this.stageSettingsToolStripMenuItem.Click += new System.EventHandler(this.stageSettingsToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patchFDGToolStripMenuItem1,
            this.importSpriteToolStripMenuItem,
            this.cleanMaterialsToolStripMenuItem1,
            this.clearBoundariesToolStripMenuItem,
            this.generateBoundariesToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // patchFDGToolStripMenuItem1
            // 
            this.patchFDGToolStripMenuItem1.Name = "patchFDGToolStripMenuItem1";
            this.patchFDGToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.patchFDGToolStripMenuItem1.Size = new System.Drawing.Size(230, 26);
            this.patchFDGToolStripMenuItem1.Text = "Patch FDG";
            this.patchFDGToolStripMenuItem1.Click += new System.EventHandler(this.patchFDGToolStripMenuItem_Click);
            // 
            // importSpriteToolStripMenuItem
            // 
            this.importSpriteToolStripMenuItem.Name = "importSpriteToolStripMenuItem";
            this.importSpriteToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.importSpriteToolStripMenuItem.Text = "Import Sprite";
            this.importSpriteToolStripMenuItem.Click += new System.EventHandler(this.spriteEditorToolStripMenuItem_Click);
            // 
            // cleanMaterialsToolStripMenuItem1
            // 
            this.cleanMaterialsToolStripMenuItem1.Name = "cleanMaterialsToolStripMenuItem1";
            this.cleanMaterialsToolStripMenuItem1.Size = new System.Drawing.Size(230, 26);
            this.cleanMaterialsToolStripMenuItem1.Text = "Clean Materials";
            this.cleanMaterialsToolStripMenuItem1.Click += new System.EventHandler(this.cleanMaterialsToolStripMenuItem_Click);
            // 
            // clearBoundariesToolStripMenuItem
            // 
            this.clearBoundariesToolStripMenuItem.Name = "clearBoundariesToolStripMenuItem";
            this.clearBoundariesToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.clearBoundariesToolStripMenuItem.Text = "Clear Boundaries";
            this.clearBoundariesToolStripMenuItem.Click += new System.EventHandler(this.clearBoundariesToolStripMenuItem_Click);
            // 
            // generateBoundariesToolStripMenuItem
            // 
            this.generateBoundariesToolStripMenuItem.Name = "generateBoundariesToolStripMenuItem";
            this.generateBoundariesToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.generateBoundariesToolStripMenuItem.Text = "Generate Boundaries";
            this.generateBoundariesToolStripMenuItem.Click += new System.EventHandler(this.generateBoundariesToolStripMenuItem_Click);
            // 
            // tileDataEditorToolStripMenuItem
            // 
            this.tileDataEditorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCollisionShapeToolStripMenuItem,
            this.editModifiersToolStripMenuItem,
            this.editMaterialsToolStripMenuItem,
            this.editAutoMovementToolStripMenuItem,
            this.editBlocksToolStripMenuItem,
            this.editBLandToolStripMenuItem,
            this.editMLandToolStripMenuItem,
            this.editFLandToolStripMenuItem,
            this.toggleAllToolStripMenuItem});
            this.tileDataEditorToolStripMenuItem.Name = "tileDataEditorToolStripMenuItem";
            this.tileDataEditorToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.tileDataEditorToolStripMenuItem.Text = "Tile Data Editor";
            // 
            // editCollisionShapeToolStripMenuItem
            // 
            this.editCollisionShapeToolStripMenuItem.Checked = true;
            this.editCollisionShapeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editCollisionShapeToolStripMenuItem.Name = "editCollisionShapeToolStripMenuItem";
            this.editCollisionShapeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.editCollisionShapeToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.editCollisionShapeToolStripMenuItem.Text = "Edit Collision Shape";
            this.editCollisionShapeToolStripMenuItem.Click += new System.EventHandler(this.editCol_Click);
            // 
            // editModifiersToolStripMenuItem
            // 
            this.editModifiersToolStripMenuItem.Checked = true;
            this.editModifiersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editModifiersToolStripMenuItem.Name = "editModifiersToolStripMenuItem";
            this.editModifiersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.editModifiersToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.editModifiersToolStripMenuItem.Text = "Edit Modifiers";
            this.editModifiersToolStripMenuItem.Click += new System.EventHandler(this.editMod_Click);
            // 
            // editMaterialsToolStripMenuItem
            // 
            this.editMaterialsToolStripMenuItem.Checked = true;
            this.editMaterialsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editMaterialsToolStripMenuItem.Name = "editMaterialsToolStripMenuItem";
            this.editMaterialsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.editMaterialsToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.editMaterialsToolStripMenuItem.Text = "Edit Materials";
            this.editMaterialsToolStripMenuItem.Click += new System.EventHandler(this.editMat_Click);
            // 
            // editAutoMovementToolStripMenuItem
            // 
            this.editAutoMovementToolStripMenuItem.Checked = true;
            this.editAutoMovementToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editAutoMovementToolStripMenuItem.Name = "editAutoMovementToolStripMenuItem";
            this.editAutoMovementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.editAutoMovementToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.editAutoMovementToolStripMenuItem.Text = "Edit Auto Movement";
            this.editAutoMovementToolStripMenuItem.Click += new System.EventHandler(this.editAuto_Click);
            // 
            // editBlocksToolStripMenuItem
            // 
            this.editBlocksToolStripMenuItem.Checked = true;
            this.editBlocksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editBlocksToolStripMenuItem.Name = "editBlocksToolStripMenuItem";
            this.editBlocksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.editBlocksToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.editBlocksToolStripMenuItem.Text = "Edit Blocks";
            this.editBlocksToolStripMenuItem.Click += new System.EventHandler(this.editBlock_Click);
            // 
            // editBLandToolStripMenuItem
            // 
            this.editBLandToolStripMenuItem.Checked = true;
            this.editBLandToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editBLandToolStripMenuItem.Name = "editBLandToolStripMenuItem";
            this.editBLandToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.editBLandToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.editBLandToolStripMenuItem.Text = "Edit BLand";
            this.editBLandToolStripMenuItem.Click += new System.EventHandler(this.editDecoB_Click);
            // 
            // editMLandToolStripMenuItem
            // 
            this.editMLandToolStripMenuItem.Checked = true;
            this.editMLandToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editMLandToolStripMenuItem.Name = "editMLandToolStripMenuItem";
            this.editMLandToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.editMLandToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.editMLandToolStripMenuItem.Text = "Edit MLand";
            this.editMLandToolStripMenuItem.Click += new System.EventHandler(this.editDecoM_Click);
            // 
            // editFLandToolStripMenuItem
            // 
            this.editFLandToolStripMenuItem.Checked = true;
            this.editFLandToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editFLandToolStripMenuItem.Name = "editFLandToolStripMenuItem";
            this.editFLandToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.editFLandToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.editFLandToolStripMenuItem.Text = "Edit FLand";
            this.editFLandToolStripMenuItem.Click += new System.EventHandler(this.editDecoF_Click);
            // 
            // toggleAllToolStripMenuItem
            // 
            this.toggleAllToolStripMenuItem.Name = "toggleAllToolStripMenuItem";
            this.toggleAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.toggleAllToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.toggleAllToolStripMenuItem.Text = "Toggle All";
            this.toggleAllToolStripMenuItem.Click += new System.EventHandler(this.unlockAll_Click);
            // 
            // renderSettingsToolStripMenuItem
            // 
            this.renderSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renderCollisionToolStripMenuItem,
            this.renderTileModifiersToolStripMenuItem,
            this.renderDynamicTerrainToolStripMenuItem,
            this.renderBlocksToolStripMenuItem,
            this.renderObjectPointsToolStripMenuItem,
            this.renderEntityNamesToolStripMenuItem,
            this.renderMaterialsToolStripMenuItem,
            this.renderAutoMovementToolStripMenuItem,
            this.useAvailableSpritesToolStripMenuItem});
            this.renderSettingsToolStripMenuItem.Name = "renderSettingsToolStripMenuItem";
            this.renderSettingsToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.renderSettingsToolStripMenuItem.Text = "Render Settings";
            // 
            // renderCollisionToolStripMenuItem
            // 
            this.renderCollisionToolStripMenuItem.Checked = true;
            this.renderCollisionToolStripMenuItem.CheckOnClick = true;
            this.renderCollisionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderCollisionToolStripMenuItem.Name = "renderCollisionToolStripMenuItem";
            this.renderCollisionToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.renderCollisionToolStripMenuItem.Text = "Render Collision";
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
            // renderDynamicTerrainToolStripMenuItem
            // 
            this.renderDynamicTerrainToolStripMenuItem.Checked = true;
            this.renderDynamicTerrainToolStripMenuItem.CheckOnClick = true;
            this.renderDynamicTerrainToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderDynamicTerrainToolStripMenuItem.Name = "renderDynamicTerrainToolStripMenuItem";
            this.renderDynamicTerrainToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.renderDynamicTerrainToolStripMenuItem.Text = "Render Dynamic Terrain";
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
            // renderEntityNamesToolStripMenuItem
            // 
            this.renderEntityNamesToolStripMenuItem.Checked = true;
            this.renderEntityNamesToolStripMenuItem.CheckOnClick = true;
            this.renderEntityNamesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renderEntityNamesToolStripMenuItem.Name = "renderEntityNamesToolStripMenuItem";
            this.renderEntityNamesToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.renderEntityNamesToolStripMenuItem.Text = "Render Entity Names";
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
            // optionsAndHelpToolStripMenuItem
            // 
            this.optionsAndHelpToolStripMenuItem.Name = "optionsAndHelpToolStripMenuItem";
            this.optionsAndHelpToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.optionsAndHelpToolStripMenuItem.Text = "Options And Help";
            this.optionsAndHelpToolStripMenuItem.Click += new System.EventHandler(this.optionsAndHelpToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.groupBox1.Size = new System.Drawing.Size(469, 668);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entity Lists";
            // 
            // editObj
            // 
            this.editObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editObj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editObj.Location = new System.Drawing.Point(179, 629);
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
            this.delObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delObj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delObj.Location = new System.Drawing.Point(95, 629);
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
            this.cloneObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cloneObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cloneObj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cloneObj.Location = new System.Drawing.Point(261, 629);
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
            this.addObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addObj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addObj.Location = new System.Drawing.Point(12, 629);
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
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.objTab);
            this.tabControl1.Controls.Add(this.carriablesTab);
            this.tabControl1.Controls.Add(this.itemTab);
            this.tabControl1.Controls.Add(this.bossTab);
            this.tabControl1.Controls.Add(this.enemyTab);
            this.tabControl1.Controls.Add(this.dynamicTab);
            this.tabControl1.Location = new System.Drawing.Point(8, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 598);
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
            this.objTab.Size = new System.Drawing.Size(445, 569);
            this.objTab.TabIndex = 0;
            this.objTab.Text = "Objects";
            this.objTab.UseVisualStyleBackColor = true;
            // 
            // objList
            // 
            this.objList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.objList.FormattingEnabled = true;
            this.objList.ItemHeight = 16;
            this.objList.Location = new System.Drawing.Point(7, 6);
            this.objList.Margin = new System.Windows.Forms.Padding(4);
            this.objList.Name = "objList";
            this.objList.Size = new System.Drawing.Size(429, 564);
            this.objList.TabIndex = 0;
            this.objList.SelectedIndexChanged += new System.EventHandler(this.objList_SelectedIndexChanged);
            this.objList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.entityLists_MouseDoubleClick);
            // 
            // carriablesTab
            // 
            this.carriablesTab.Controls.Add(this.carriablesList);
            this.carriablesTab.Location = new System.Drawing.Point(4, 25);
            this.carriablesTab.Margin = new System.Windows.Forms.Padding(4);
            this.carriablesTab.Name = "carriablesTab";
            this.carriablesTab.Padding = new System.Windows.Forms.Padding(4);
            this.carriablesTab.Size = new System.Drawing.Size(445, 569);
            this.carriablesTab.TabIndex = 1;
            this.carriablesTab.Text = "Carriables";
            this.carriablesTab.UseVisualStyleBackColor = true;
            // 
            // carriablesList
            // 
            this.carriablesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carriablesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.carriablesList.FormattingEnabled = true;
            this.carriablesList.ItemHeight = 16;
            this.carriablesList.Location = new System.Drawing.Point(7, 6);
            this.carriablesList.Margin = new System.Windows.Forms.Padding(4);
            this.carriablesList.Name = "carriablesList";
            this.carriablesList.Size = new System.Drawing.Size(429, 564);
            this.carriablesList.TabIndex = 4;
            this.carriablesList.SelectedIndexChanged += new System.EventHandler(this.specItemList_SelectedIndexChanged);
            this.carriablesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.entityLists_MouseDoubleClick);
            // 
            // itemTab
            // 
            this.itemTab.Controls.Add(this.itemList);
            this.itemTab.Location = new System.Drawing.Point(4, 25);
            this.itemTab.Margin = new System.Windows.Forms.Padding(4);
            this.itemTab.Name = "itemTab";
            this.itemTab.Size = new System.Drawing.Size(445, 569);
            this.itemTab.TabIndex = 2;
            this.itemTab.Text = "Items";
            this.itemTab.UseVisualStyleBackColor = true;
            // 
            // itemList
            // 
            this.itemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 16;
            this.itemList.Location = new System.Drawing.Point(7, 6);
            this.itemList.Margin = new System.Windows.Forms.Padding(4);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(429, 564);
            this.itemList.TabIndex = 4;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            this.itemList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.entityLists_MouseDoubleClick);
            // 
            // bossTab
            // 
            this.bossTab.Controls.Add(this.bossList);
            this.bossTab.Location = new System.Drawing.Point(4, 25);
            this.bossTab.Margin = new System.Windows.Forms.Padding(4);
            this.bossTab.Name = "bossTab";
            this.bossTab.Size = new System.Drawing.Size(445, 569);
            this.bossTab.TabIndex = 3;
            this.bossTab.Text = "Bosses";
            this.bossTab.UseVisualStyleBackColor = true;
            // 
            // bossList
            // 
            this.bossList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bossList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bossList.FormattingEnabled = true;
            this.bossList.ItemHeight = 16;
            this.bossList.Location = new System.Drawing.Point(7, 6);
            this.bossList.Margin = new System.Windows.Forms.Padding(4);
            this.bossList.Name = "bossList";
            this.bossList.Size = new System.Drawing.Size(429, 564);
            this.bossList.TabIndex = 4;
            this.bossList.SelectedIndexChanged += new System.EventHandler(this.bossList_SelectedIndexChanged);
            this.bossList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.entityLists_MouseDoubleClick);
            // 
            // enemyTab
            // 
            this.enemyTab.Controls.Add(this.enemyList);
            this.enemyTab.Location = new System.Drawing.Point(4, 25);
            this.enemyTab.Margin = new System.Windows.Forms.Padding(4);
            this.enemyTab.Name = "enemyTab";
            this.enemyTab.Size = new System.Drawing.Size(445, 569);
            this.enemyTab.TabIndex = 4;
            this.enemyTab.Text = "Enemies";
            this.enemyTab.UseVisualStyleBackColor = true;
            // 
            // enemyList
            // 
            this.enemyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enemyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.enemyList.FormattingEnabled = true;
            this.enemyList.ItemHeight = 16;
            this.enemyList.Location = new System.Drawing.Point(7, 6);
            this.enemyList.Margin = new System.Windows.Forms.Padding(4);
            this.enemyList.Name = "enemyList";
            this.enemyList.Size = new System.Drawing.Size(429, 564);
            this.enemyList.TabIndex = 4;
            this.enemyList.SelectedIndexChanged += new System.EventHandler(this.enemyList_SelectedIndexChanged);
            this.enemyList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.entityLists_MouseDoubleClick);
            // 
            // dynamicTab
            // 
            this.dynamicTab.Controls.Add(this.dynamicList);
            this.dynamicTab.Location = new System.Drawing.Point(4, 25);
            this.dynamicTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dynamicTab.Name = "dynamicTab";
            this.dynamicTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dynamicTab.Size = new System.Drawing.Size(445, 569);
            this.dynamicTab.TabIndex = 5;
            this.dynamicTab.Text = "Dynamic Terrain";
            this.dynamicTab.UseVisualStyleBackColor = true;
            // 
            // dynamicList
            // 
            this.dynamicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dynamicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dynamicList.FormattingEnabled = true;
            this.dynamicList.ItemHeight = 16;
            this.dynamicList.Location = new System.Drawing.Point(7, 6);
            this.dynamicList.Margin = new System.Windows.Forms.Padding(4);
            this.dynamicList.Name = "dynamicList";
            this.dynamicList.Size = new System.Drawing.Size(429, 564);
            this.dynamicList.TabIndex = 5;
            this.dynamicList.SelectedIndexChanged += new System.EventHandler(this.dynamicList_SelectedIndexChanged);
            this.dynamicList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.entityLists_MouseDoubleClick);
            // 
            // glControl
            // 
            this.glControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Location = new System.Drawing.Point(493, 87);
            this.glControl.Margin = new System.Windows.Forms.Padding(5);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(676, 449);
            this.glControl.TabIndex = 2;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseDown);
            this.glControl.MouseLeave += new System.EventHandler(this.glControl_MouseLeave);
            this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseMove);
            this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseUp);
            this.glControl.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseWheel);
            this.glControl.Resize += new System.EventHandler(this.glControl_Resize);
            // 
            // resetCamera
            // 
            this.resetCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetCamera.Location = new System.Drawing.Point(1061, 42);
            this.resetCamera.Margin = new System.Windows.Forms.Padding(4);
            this.resetCamera.Name = "resetCamera";
            this.resetCamera.Size = new System.Drawing.Size(109, 38);
            this.resetCamera.TabIndex = 6;
            this.resetCamera.Text = "Reset Camera";
            this.toolTip1.SetToolTip(this.resetCamera, "Moves the camera back to the\r\nwithin the level\'s boundaries.");
            this.resetCamera.UseVisualStyleBackColor = true;
            this.resetCamera.Click += new System.EventHandler(this.resetCamera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Coordinate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 46);
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
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Y";
            // 
            // xCoord
            // 
            this.xCoord.Location = new System.Drawing.Point(29, 43);
            this.xCoord.Margin = new System.Windows.Forms.Padding(4);
            this.xCoord.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.xCoord.Name = "xCoord";
            this.xCoord.Size = new System.Drawing.Size(120, 22);
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
            this.xOffset.Location = new System.Drawing.Point(157, 43);
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
            this.xOffset.Size = new System.Drawing.Size(51, 22);
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
            this.yOffset.Location = new System.Drawing.Point(157, 74);
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
            this.yOffset.Size = new System.Drawing.Size(51, 22);
            this.yOffset.TabIndex = 26;
            this.toolTip1.SetToolTip(this.yOffset, "Change the position of the currently\r\nselected entity. Coordinate is the\r\nmain po" +
        "sition, but it can be offset to\r\nany of 16 values within a single tile.\r\n");
            this.yOffset.ValueChanged += new System.EventHandler(this.yOffset_ValueChanged);
            // 
            // yCoord
            // 
            this.yCoord.Location = new System.Drawing.Point(29, 74);
            this.yCoord.Margin = new System.Windows.Forms.Padding(4);
            this.yCoord.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.yCoord.Name = "yCoord";
            this.yCoord.Size = new System.Drawing.Size(120, 22);
            this.yCoord.TabIndex = 25;
            this.toolTip1.SetToolTip(this.yCoord, "Change the position of the currently\r\nselected entity. Coordinate is the\r\nmain po" +
        "sition, but it can be offset to\r\nany of 16 values within a single tile.\r\n");
            this.yCoord.ValueChanged += new System.EventHandler(this.yCoord_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.unlockAll);
            this.groupBox2.Controls.Add(this.editDecoF);
            this.groupBox2.Controls.Add(this.editDecoM);
            this.groupBox2.Controls.Add(this.editDecoB);
            this.groupBox2.Controls.Add(this.editBlock);
            this.groupBox2.Controls.Add(this.editAuto);
            this.groupBox2.Controls.Add(this.editMat);
            this.groupBox2.Controls.Add(this.editMod);
            this.groupBox2.Controls.Add(this.editCol);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(1179, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(309, 597);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tile Data Editor";
            // 
            // unlockAll
            // 
            this.unlockAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unlockAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unlockAll.Location = new System.Drawing.Point(9, 556);
            this.unlockAll.Margin = new System.Windows.Forms.Padding(4);
            this.unlockAll.Name = "unlockAll";
            this.unlockAll.Size = new System.Drawing.Size(293, 28);
            this.unlockAll.TabIndex = 145;
            this.unlockAll.Text = "Toggle All";
            this.toolTip1.SetToolTip(this.unlockAll, "Re-enables all buttons, press\r\nwhile all are enabled to\r\ninstead disable all valu" +
        "es.");
            this.unlockAll.UseVisualStyleBackColor = true;
            this.unlockAll.Click += new System.EventHandler(this.unlockAll_Click);
            // 
            // editDecoF
            // 
            this.editDecoF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editDecoF.BackColor = System.Drawing.Color.LightSteelBlue;
            this.editDecoF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editDecoF.Location = new System.Drawing.Point(172, 527);
            this.editDecoF.Margin = new System.Windows.Forms.Padding(4);
            this.editDecoF.Name = "editDecoF";
            this.editDecoF.Size = new System.Drawing.Size(131, 28);
            this.editDecoF.TabIndex = 143;
            this.editDecoF.Text = "Edit FLand";
            this.toolTip1.SetToolTip(this.editDecoF, "Disabling this wil prevent any changes\r\nto foreground decoration in the level \r\ni" +
        "tself and here in the Tile Data Editor.");
            this.editDecoF.UseVisualStyleBackColor = false;
            this.editDecoF.Click += new System.EventHandler(this.editDecoF_Click);
            // 
            // editDecoM
            // 
            this.editDecoM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editDecoM.BackColor = System.Drawing.Color.LightSteelBlue;
            this.editDecoM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editDecoM.Location = new System.Drawing.Point(172, 498);
            this.editDecoM.Margin = new System.Windows.Forms.Padding(4);
            this.editDecoM.Name = "editDecoM";
            this.editDecoM.Size = new System.Drawing.Size(131, 28);
            this.editDecoM.TabIndex = 142;
            this.editDecoM.Text = "Edit MLand";
            this.toolTip1.SetToolTip(this.editDecoM, "Disabling this wil prevent any changes\r\nto middle (stood on) land in the level \r\n" +
        "itself and here in the Tile Data Editor.");
            this.editDecoM.UseVisualStyleBackColor = false;
            this.editDecoM.Click += new System.EventHandler(this.editDecoM_Click);
            // 
            // editDecoB
            // 
            this.editDecoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editDecoB.BackColor = System.Drawing.Color.LightSteelBlue;
            this.editDecoB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editDecoB.Location = new System.Drawing.Point(172, 470);
            this.editDecoB.Margin = new System.Windows.Forms.Padding(4);
            this.editDecoB.Name = "editDecoB";
            this.editDecoB.Size = new System.Drawing.Size(131, 28);
            this.editDecoB.TabIndex = 141;
            this.editDecoB.Text = "Edit BLand";
            this.toolTip1.SetToolTip(this.editDecoB, "Disabling this wil prevent any changes\r\nto background land in the level \r\nitself " +
        "and here in the Tile Data Editor.");
            this.editDecoB.UseVisualStyleBackColor = false;
            this.editDecoB.Click += new System.EventHandler(this.editDecoB_Click);
            // 
            // editBlock
            // 
            this.editBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBlock.BackColor = System.Drawing.Color.LightSteelBlue;
            this.editBlock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editBlock.Location = new System.Drawing.Point(172, 442);
            this.editBlock.Margin = new System.Windows.Forms.Padding(4);
            this.editBlock.Name = "editBlock";
            this.editBlock.Size = new System.Drawing.Size(131, 28);
            this.editBlock.TabIndex = 140;
            this.editBlock.Text = "Edit Blocks";
            this.toolTip1.SetToolTip(this.editBlock, "Disabling this wil prevent any changes\r\nto block ID in the level itself \r\nand her" +
        "e in the Tile Data Editor.");
            this.editBlock.UseVisualStyleBackColor = false;
            this.editBlock.Click += new System.EventHandler(this.editBlock_Click);
            // 
            // editAuto
            // 
            this.editAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editAuto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.editAuto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editAuto.Location = new System.Drawing.Point(9, 527);
            this.editAuto.Margin = new System.Windows.Forms.Padding(4);
            this.editAuto.Name = "editAuto";
            this.editAuto.Size = new System.Drawing.Size(160, 28);
            this.editAuto.TabIndex = 139;
            this.editAuto.Text = "Edit Auto Movement";
            this.toolTip1.SetToolTip(this.editAuto, "Disabling this wil prevent any changes\r\nto auto-movement in the level itself \r\nan" +
        "d here in the Tile Data Editor.");
            this.editAuto.UseVisualStyleBackColor = false;
            this.editAuto.Click += new System.EventHandler(this.editAuto_Click);
            // 
            // editMat
            // 
            this.editMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editMat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.editMat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editMat.Location = new System.Drawing.Point(9, 498);
            this.editMat.Margin = new System.Windows.Forms.Padding(4);
            this.editMat.Name = "editMat";
            this.editMat.Size = new System.Drawing.Size(160, 28);
            this.editMat.TabIndex = 138;
            this.editMat.Text = "Edit Materials";
            this.toolTip1.SetToolTip(this.editMat, "Disabling this wil prevent any changes\r\nto collision materials in the level itsel" +
        "f \r\nand here in the Tile Data Editor.");
            this.editMat.UseVisualStyleBackColor = false;
            this.editMat.Click += new System.EventHandler(this.editMat_Click);
            // 
            // editMod
            // 
            this.editMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editMod.BackColor = System.Drawing.Color.LightSteelBlue;
            this.editMod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editMod.Location = new System.Drawing.Point(9, 470);
            this.editMod.Margin = new System.Windows.Forms.Padding(4);
            this.editMod.Name = "editMod";
            this.editMod.Size = new System.Drawing.Size(160, 28);
            this.editMod.TabIndex = 137;
            this.editMod.Text = "Edit Modifiers";
            this.toolTip1.SetToolTip(this.editMod, "Disabling this wil prevent any changes\r\nto collision modifiers in the level itsel" +
        "f \r\nand here in the Tile Data Editor.");
            this.editMod.UseVisualStyleBackColor = false;
            this.editMod.Click += new System.EventHandler(this.editMod_Click);
            // 
            // editCol
            // 
            this.editCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editCol.BackColor = System.Drawing.Color.LightSteelBlue;
            this.editCol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editCol.Location = new System.Drawing.Point(9, 442);
            this.editCol.Margin = new System.Windows.Forms.Padding(4);
            this.editCol.Name = "editCol";
            this.editCol.Size = new System.Drawing.Size(160, 28);
            this.editCol.TabIndex = 136;
            this.editCol.Text = "Edit Collision Shape";
            this.toolTip1.SetToolTip(this.editCol, "Disabling this wil prevent any changes\r\nto collision shape in the level itself an" +
        "d\r\nhere in the Tile Data Editor.");
            this.editCol.UseVisualStyleBackColor = false;
            this.editCol.Click += new System.EventHandler(this.editCol_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(13, 313);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 104;
            this.label15.Text = "Decoration";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(8, 400);
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
            this.tabControl2.Location = new System.Drawing.Point(63, 308);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl2.RightToLeftLayout = true;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(240, 123);
            this.tabControl2.TabIndex = 103;
            this.toolTip1.SetToolTip(this.tabControl2, "Decoration data that\'s used to make\r\nthe actual tiling of the level. Has three\r\nd" +
        "ifferent categories.\r\nBLand - Background Decor.\r\nMLand - Middle, Walkable Decor." +
        "\r\nFLand - Foreground Decor.");
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dB_ID);
            this.tabPage1.Controls.Add(this.dB_Unk);
            this.tabPage1.Controls.Add(this.dF_Dynamic);
            this.tabPage1.Controls.Add(this.dM_Dynamic);
            this.tabPage1.Controls.Add(this.dF_Unk);
            this.tabPage1.Controls.Add(this.dB_Dynamic);
            this.tabPage1.Controls.Add(this.dM_Unk);
            this.tabPage1.Controls.Add(this.dM_ID);
            this.tabPage1.Controls.Add(this.dF_ID);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(232, 94);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Byte Values";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dB_ID
            // 
            this.dB_ID.Location = new System.Drawing.Point(7, 9);
            this.dB_ID.Margin = new System.Windows.Forms.Padding(4);
            this.dB_ID.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.dB_ID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dB_ID.Name = "dB_ID";
            this.dB_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dB_ID.Size = new System.Drawing.Size(112, 22);
            this.dB_ID.TabIndex = 73;
            this.toolTip1.SetToolTip(this.dB_ID, "Background Decoration ID\r\n-1 means no decoration.");
            this.dB_ID.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // dB_Unk
            // 
            this.dB_Unk.Location = new System.Drawing.Point(123, 9);
            this.dB_Unk.Margin = new System.Windows.Forms.Padding(4);
            this.dB_Unk.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.dB_Unk.Name = "dB_Unk";
            this.dB_Unk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dB_Unk.Size = new System.Drawing.Size(52, 22);
            this.dB_Unk.TabIndex = 75;
            this.toolTip1.SetToolTip(this.dB_Unk, "Background unknown value.\r\nIt\'s usually set to 0 or 17\r\n");
            // 
            // dF_Dynamic
            // 
            this.dF_Dynamic.Location = new System.Drawing.Point(179, 62);
            this.dF_Dynamic.Margin = new System.Windows.Forms.Padding(4);
            this.dF_Dynamic.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dF_Dynamic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dF_Dynamic.Name = "dF_Dynamic";
            this.dF_Dynamic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dF_Dynamic.Size = new System.Drawing.Size(51, 22);
            this.dF_Dynamic.TabIndex = 80;
            this.toolTip1.SetToolTip(this.dF_Dynamic, "Foreground Dynamic ID. Follows the same\r\nindex Dynamic Terrain when it moves.\r\nTi" +
        "les with Dynamic Terrain ID 0 will follow\r\nDynamic Terrain 0 for example.");
            this.dF_Dynamic.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // dM_Dynamic
            // 
            this.dM_Dynamic.Location = new System.Drawing.Point(179, 36);
            this.dM_Dynamic.Margin = new System.Windows.Forms.Padding(4);
            this.dM_Dynamic.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dM_Dynamic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dM_Dynamic.Name = "dM_Dynamic";
            this.dM_Dynamic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dM_Dynamic.Size = new System.Drawing.Size(51, 22);
            this.dM_Dynamic.TabIndex = 84;
            this.toolTip1.SetToolTip(this.dM_Dynamic, "Middleground Dynamic ID. Follows the same\r\nindex Dynamic Terrain when it moves.\r\n" +
        "Tiles with Dynamic Terrain ID 0 will follow\r\nDynamic Terrain 0 for example.");
            this.dM_Dynamic.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // dF_Unk
            // 
            this.dF_Unk.Location = new System.Drawing.Point(123, 62);
            this.dF_Unk.Margin = new System.Windows.Forms.Padding(4);
            this.dF_Unk.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.dF_Unk.Name = "dF_Unk";
            this.dF_Unk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dF_Unk.Size = new System.Drawing.Size(52, 22);
            this.dF_Unk.TabIndex = 79;
            this.toolTip1.SetToolTip(this.dF_Unk, "Foreground unknown value.\r\nIt\'s usually set to 0 or 17");
            // 
            // dB_Dynamic
            // 
            this.dB_Dynamic.Location = new System.Drawing.Point(179, 9);
            this.dB_Dynamic.Margin = new System.Windows.Forms.Padding(4);
            this.dB_Dynamic.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.dB_Dynamic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dB_Dynamic.Name = "dB_Dynamic";
            this.dB_Dynamic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dB_Dynamic.Size = new System.Drawing.Size(51, 22);
            this.dB_Dynamic.TabIndex = 76;
            this.toolTip1.SetToolTip(this.dB_Dynamic, "Background Dynamic ID. Follows the same\r\nindex Dynamic Terrain when it moves.\r\nTi" +
        "les with Dynamic Terrain ID 0 will follow\r\nDynamic Terrain 0 for example.");
            this.dB_Dynamic.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // dM_Unk
            // 
            this.dM_Unk.Location = new System.Drawing.Point(123, 36);
            this.dM_Unk.Margin = new System.Windows.Forms.Padding(4);
            this.dM_Unk.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.dM_Unk.Name = "dM_Unk";
            this.dM_Unk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dM_Unk.Size = new System.Drawing.Size(52, 22);
            this.dM_Unk.TabIndex = 83;
            this.toolTip1.SetToolTip(this.dM_Unk, "Middleground unknown value.\r\nIt\'s usually set to 0 or 17\r\n");
            // 
            // dM_ID
            // 
            this.dM_ID.Location = new System.Drawing.Point(7, 36);
            this.dM_ID.Margin = new System.Windows.Forms.Padding(4);
            this.dM_ID.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.dM_ID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dM_ID.Name = "dM_ID";
            this.dM_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dM_ID.Size = new System.Drawing.Size(112, 22);
            this.dM_ID.TabIndex = 81;
            this.toolTip1.SetToolTip(this.dM_ID, "Middle (Stood on) Decoration ID\r\n-1 means no decoration.\r\n");
            this.dM_ID.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // dF_ID
            // 
            this.dF_ID.Location = new System.Drawing.Point(7, 62);
            this.dF_ID.Margin = new System.Windows.Forms.Padding(4);
            this.dF_ID.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.dF_ID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dF_ID.Name = "dF_ID";
            this.dF_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dF_ID.Size = new System.Drawing.Size(112, 22);
            this.dF_ID.TabIndex = 77;
            this.toolTip1.SetToolTip(this.dF_ID, "Foreground Decoration ID\r\n-1 means no decoration.");
            this.dF_ID.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dF_hex);
            this.tabPage2.Controls.Add(this.dM_hex);
            this.tabPage2.Controls.Add(this.dB_hex);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(232, 94);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hex Values";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dF_hex
            // 
            this.dF_hex.Location = new System.Drawing.Point(5, 63);
            this.dF_hex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dF_hex.MaxLength = 8;
            this.dF_hex.Name = "dF_hex";
            this.dF_hex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dF_hex.Size = new System.Drawing.Size(220, 22);
            this.dF_hex.TabIndex = 2;
            this.dF_hex.Text = "FFFF00FF";
            this.dF_hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dF_hex.TextChanged += new System.EventHandler(this.d2_hex_TextChanged);
            // 
            // dM_hex
            // 
            this.dM_hex.Location = new System.Drawing.Point(5, 34);
            this.dM_hex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dM_hex.MaxLength = 8;
            this.dM_hex.Name = "dM_hex";
            this.dM_hex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dM_hex.Size = new System.Drawing.Size(220, 22);
            this.dM_hex.TabIndex = 1;
            this.dM_hex.Text = "FFFF00FF";
            this.dM_hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dM_hex.TextChanged += new System.EventHandler(this.d3_hex_TextChanged);
            // 
            // dB_hex
            // 
            this.dB_hex.Location = new System.Drawing.Point(5, 7);
            this.dB_hex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dB_hex.MaxLength = 8;
            this.dB_hex.Name = "dB_hex";
            this.dB_hex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dB_hex.Size = new System.Drawing.Size(220, 22);
            this.dB_hex.TabIndex = 0;
            this.dB_hex.Text = "FFFF00FF";
            this.dB_hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dB_hex.TextChanged += new System.EventHandler(this.d1_hex_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(8, 346);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 70;
            this.label11.Text = "BLand";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(8, 373);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 71;
            this.label12.Text = "MLand";
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
            this.groupBox4.Size = new System.Drawing.Size(293, 65);
            this.groupBox4.TabIndex = 92;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Block Data";
            // 
            // vBlock
            // 
            this.vBlock.Location = new System.Drawing.Point(229, 27);
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
            this.blockList.BackColor = System.Drawing.Color.White;
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
            this.blockList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blockList.Name = "blockList";
            this.blockList.Size = new System.Drawing.Size(172, 24);
            this.blockList.TabIndex = 106;
            this.toolTip1.SetToolTip(this.blockList, "The block that\'s placed on a tile,\r\nthe \"origin point\" of most blocks\r\nbigger tha" +
        "n a single tile is their\r\nbottom-left corner.");
            this.blockList.SelectedIndexChanged += new System.EventHandler(this.blockList_SelectedIndexChanged);
            // 
            // blockImg
            // 
            this.blockImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.blockImg.Image = global::MagoCrate.Properties.Resources._0;
            this.blockImg.Location = new System.Drawing.Point(187, 17);
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
            this.groupBox3.Controls.Add(this.vMat);
            this.groupBox3.Controls.Add(this.ladder);
            this.groupBox3.Controls.Add(this.vAutomove);
            this.groupBox3.Controls.Add(this.water);
            this.groupBox3.Controls.Add(this.lava);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(9, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(293, 210);
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
            this.materialList.Location = new System.Drawing.Point(131, 143);
            this.materialList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialList.Name = "materialList";
            this.materialList.Size = new System.Drawing.Size(99, 24);
            this.materialList.TabIndex = 108;
            this.toolTip1.SetToolTip(this.materialList, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.");
            this.materialList.SelectedIndexChanged += new System.EventHandler(this.materialList_SelectedIndexChanged);
            // 
            // vShape
            // 
            this.vShape.Location = new System.Drawing.Point(229, 23);
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
            this.label14.Location = new System.Drawing.Point(8, 82);
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
            this.colImg.Location = new System.Drawing.Point(185, 15);
            this.colImg.Margin = new System.Windows.Forms.Padding(4);
            this.colImg.Name = "colImg";
            this.colImg.Size = new System.Drawing.Size(40, 37);
            this.colImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colImg.TabIndex = 91;
            this.colImg.TabStop = false;
            this.toolTip1.SetToolTip(this.colImg, "Click here to select\r\na collision shape!\r\n");
            this.colImg.Click += new System.EventHandler(this.colImg_Click);
            // 
            // ice
            // 
            this.ice.AutoSize = true;
            this.ice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ice.Location = new System.Drawing.Point(171, 110);
            this.ice.Margin = new System.Windows.Forms.Padding(4);
            this.ice.Name = "ice";
            this.ice.Size = new System.Drawing.Size(48, 21);
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
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Collision Shape\r\n";
            // 
            // spike
            // 
            this.spike.AutoSize = true;
            this.spike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.spike.Location = new System.Drawing.Point(171, 85);
            this.spike.Margin = new System.Windows.Forms.Padding(4);
            this.spike.Name = "spike";
            this.spike.Size = new System.Drawing.Size(65, 21);
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
            this.label7.Location = new System.Drawing.Point(8, 146);
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
            this.boundary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.boundary.Location = new System.Drawing.Point(171, 60);
            this.boundary.Margin = new System.Windows.Forms.Padding(4);
            this.boundary.Name = "boundary";
            this.boundary.Size = new System.Drawing.Size(91, 21);
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
            this.label8.Location = new System.Drawing.Point(8, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Auto Movement";
            this.toolTip1.SetToolTip(this.label8, "Auto-movement for that tile. It\'s\r\nalmost exclusively used for the\r\nEgg Engines c" +
        "onveyer belts.\r\nNegative values move you left\r\ninstead of right.");
            // 
            // vMat
            // 
            this.vMat.Location = new System.Drawing.Point(237, 143);
            this.vMat.Margin = new System.Windows.Forms.Padding(4);
            this.vMat.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.vMat.Name = "vMat";
            this.vMat.Size = new System.Drawing.Size(48, 22);
            this.vMat.TabIndex = 87;
            this.toolTip1.SetToolTip(this.vMat, "The \"Material\" of the collision\r\non that tile, used to create unique\r\nfootstep so" +
        "unds and effects.\r\n");
            this.vMat.ValueChanged += new System.EventHandler(this.vmat_ValueChanged);
            // 
            // ladder
            // 
            this.ladder.AutoSize = true;
            this.ladder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ladder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ladder.Location = new System.Drawing.Point(85, 60);
            this.ladder.Margin = new System.Windows.Forms.Padding(4);
            this.ladder.Name = "ladder";
            this.ladder.Size = new System.Drawing.Size(75, 21);
            this.ladder.TabIndex = 62;
            this.ladder.Text = "Ladder";
            this.ladder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.ladder, "Allows you to climb up and down on\r\nthat tile, still requires the decoration\r\ndat" +
        "a to look like a ladder.");
            this.ladder.UseVisualStyleBackColor = true;
            // 
            // vAutomove
            // 
            this.vAutomove.Location = new System.Drawing.Point(131, 174);
            this.vAutomove.Margin = new System.Windows.Forms.Padding(4);
            this.vAutomove.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.vAutomove.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.vAutomove.Name = "vAutomove";
            this.vAutomove.Size = new System.Drawing.Size(155, 22);
            this.vAutomove.TabIndex = 86;
            // 
            // water
            // 
            this.water.AutoSize = true;
            this.water.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.water.Location = new System.Drawing.Point(85, 85);
            this.water.Margin = new System.Windows.Forms.Padding(4);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(68, 21);
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
            this.lava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lava.Location = new System.Drawing.Point(85, 110);
            this.lava.Margin = new System.Windows.Forms.Padding(4);
            this.lava.Name = "lava";
            this.lava.Size = new System.Drawing.Size(61, 21);
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
            this.label6.Location = new System.Drawing.Point(157, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.MinimumSize = new System.Drawing.Size(51, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Offset";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.sizeW);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.sizeH);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Location = new System.Drawing.Point(1179, 635);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(309, 66);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Level Size";
            // 
            // sizeW
            // 
            this.sizeW.Location = new System.Drawing.Point(217, 27);
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
            this.sizeW.Size = new System.Drawing.Size(77, 22);
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
            this.label9.Location = new System.Drawing.Point(168, 30);
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
            this.sizeH.Size = new System.Drawing.Size(83, 22);
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
            this.label2.Location = new System.Drawing.Point(20, 30);
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
            this.halfTileLock.Location = new System.Drawing.Point(33, 106);
            this.halfTileLock.Margin = new System.Windows.Forms.Padding(4);
            this.halfTileLock.Name = "halfTileLock";
            this.halfTileLock.Size = new System.Drawing.Size(152, 38);
            this.halfTileLock.TabIndex = 102;
            this.halfTileLock.Text = "Increment Offset \r\nValues in Half-Tiles";
            this.toolTip1.SetToolTip(this.halfTileLock, "Determine whether incrementing\r\nthe offset values will change by 1\r\nor 8 units. 8" +
        " units being equivalent\r\nto half a tile.");
            this.halfTileLock.UseVisualStyleBackColor = true;
            this.halfTileLock.CheckedChanged += new System.EventHandler(this.halfTileLock_CheckedChanged);
            // 
            // viewType
            // 
            this.viewType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewType.FormattingEnabled = true;
            this.viewType.Items.AddRange(new object[] {
            "Default",
            "Decoration: BLand",
            "Decoration: MLand",
            "Decoration: FLand",
            "Dynamic Tile IDs"});
            this.viewType.Location = new System.Drawing.Point(899, 50);
            this.viewType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewType.Name = "viewType";
            this.viewType.Size = new System.Drawing.Size(155, 24);
            this.viewType.TabIndex = 103;
            this.toolTip1.SetToolTip(this.viewType, "Change the view type between being\r\nable to view the level normally or\r\nbeing abl" +
        "e to view a single category\r\nof decoration data.");
            this.viewType.SelectedIndexChanged += new System.EventHandler(this.viewType_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(821, 53);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 104;
            this.label16.Text = "View Type";
            this.toolTip1.SetToolTip(this.label16, "Change the view type between being\r\nable to view the level normally or\r\nbeing abl" +
        "e to view a single category\r\nof decoration data.");
            // 
            // paletteList
            // 
            this.paletteList.FormattingEnabled = true;
            this.paletteList.Location = new System.Drawing.Point(7, 21);
            this.paletteList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paletteList.Name = "paletteList";
            this.paletteList.Size = new System.Drawing.Size(147, 24);
            this.paletteList.TabIndex = 108;
            this.toolTip1.SetToolTip(this.paletteList, "Select a tile palette, which\r\ngives you 24 tile data slots\r\nto quickly load and s" +
        "ave\r\nfor faster tiling!");
            this.paletteList.SelectedIndexChanged += new System.EventHandler(this.paletteList_SelectedIndexChanged);
            // 
            // dropper
            // 
            this.dropper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dropper.BackgroundImage = global::MagoCrate.Properties.Resources.pick;
            this.dropper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dropper.Location = new System.Drawing.Point(543, 42);
            this.dropper.Margin = new System.Windows.Forms.Padding(4);
            this.dropper.Name = "dropper";
            this.dropper.Size = new System.Drawing.Size(41, 41);
            this.dropper.TabIndex = 135;
            this.toolTip1.SetToolTip(this.dropper, "Copy tile data by\r\nclicking on a tile.");
            this.dropper.UseVisualStyleBackColor = false;
            this.dropper.Click += new System.EventHandler(this.dropper_Click);
            // 
            // move
            // 
            this.move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.move.BackgroundImage = global::MagoCrate.Properties.Resources.move;
            this.move.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.move.Location = new System.Drawing.Point(592, 42);
            this.move.Margin = new System.Windows.Forms.Padding(4);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(41, 41);
            this.move.TabIndex = 105;
            this.toolTip1.SetToolTip(this.move, "Select entities by clicking on \r\nthem, clicking or dragging to\r\nempty space will " +
        "move that\r\nentity there.");
            this.move.UseVisualStyleBackColor = false;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.draw.BackgroundImage = global::MagoCrate.Properties.Resources.draw;
            this.draw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.draw.Location = new System.Drawing.Point(493, 42);
            this.draw.Margin = new System.Windows.Forms.Padding(4);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(41, 41);
            this.draw.TabIndex = 5;
            this.toolTip1.SetToolTip(this.draw, "Click tiles to overwrite\r\ntheir tile data.");
            this.draw.UseVisualStyleBackColor = false;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // tileName
            // 
            this.tileName.BackColor = System.Drawing.Color.White;
            this.tileName.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileName.Location = new System.Drawing.Point(7, 128);
            this.tileName.Margin = new System.Windows.Forms.Padding(4);
            this.tileName.Name = "tileName";
            this.tileName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tileName.Size = new System.Drawing.Size(144, 22);
            this.tileName.TabIndex = 109;
            this.tileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tileName, "Edit this textbox to save\r\na custom name for each\r\nof your 24 palette tiles.");
            // 
            // savePalette
            // 
            this.savePalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savePalette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.savePalette.ForeColor = System.Drawing.SystemColors.ControlText;
            this.savePalette.Location = new System.Drawing.Point(81, 49);
            this.savePalette.Margin = new System.Windows.Forms.Padding(4);
            this.savePalette.Name = "savePalette";
            this.savePalette.Size = new System.Drawing.Size(73, 44);
            this.savePalette.TabIndex = 147;
            this.savePalette.Text = "Reload\r\nPalettes";
            this.toolTip1.SetToolTip(this.savePalette, "Reloads the tile palettes, it also\r\nwill undo any unsaved changes!");
            this.savePalette.UseVisualStyleBackColor = true;
            this.savePalette.Click += new System.EventHandler(this.refreshPalette_Click);
            // 
            // createPalette
            // 
            this.createPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createPalette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.createPalette.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createPalette.Location = new System.Drawing.Point(7, 49);
            this.createPalette.Margin = new System.Windows.Forms.Padding(4);
            this.createPalette.Name = "createPalette";
            this.createPalette.Size = new System.Drawing.Size(73, 44);
            this.createPalette.TabIndex = 146;
            this.createPalette.Text = "Export\r\nPalette";
            this.toolTip1.SetToolTip(this.createPalette, "Export the currently loaded tile \r\npalette to an ini file for later use.");
            this.createPalette.UseVisualStyleBackColor = true;
            this.createPalette.Click += new System.EventHandler(this.exportPalette_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(8, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.MinimumSize = new System.Drawing.Size(145, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 17);
            this.label10.TabIndex = 103;
            this.label10.Text = "Palette Tile Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.label10, "Edit this textbox to save\r\na custom name for each\r\nof your 24 palette tiles.");
            // 
            // pTile22
            // 
            this.pTile22.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile22.Location = new System.Drawing.Point(336, 84);
            this.pTile22.Margin = new System.Windows.Forms.Padding(4);
            this.pTile22.Name = "pTile22";
            this.pTile22.Size = new System.Drawing.Size(35, 34);
            this.pTile22.TabIndex = 134;
            this.pTile22.UseVisualStyleBackColor = true;
            this.pTile22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile21
            // 
            this.pTile21.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile21.Location = new System.Drawing.Point(300, 84);
            this.pTile21.Margin = new System.Windows.Forms.Padding(4);
            this.pTile21.Name = "pTile21";
            this.pTile21.Size = new System.Drawing.Size(35, 34);
            this.pTile21.TabIndex = 133;
            this.pTile21.UseVisualStyleBackColor = true;
            this.pTile21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile23
            // 
            this.pTile23.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile23.Location = new System.Drawing.Point(371, 84);
            this.pTile23.Margin = new System.Windows.Forms.Padding(4);
            this.pTile23.Name = "pTile23";
            this.pTile23.Size = new System.Drawing.Size(35, 34);
            this.pTile23.TabIndex = 132;
            this.pTile23.UseVisualStyleBackColor = true;
            this.pTile23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile20
            // 
            this.pTile20.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile20.Location = new System.Drawing.Point(265, 84);
            this.pTile20.Margin = new System.Windows.Forms.Padding(4);
            this.pTile20.Name = "pTile20";
            this.pTile20.Size = new System.Drawing.Size(35, 34);
            this.pTile20.TabIndex = 131;
            this.pTile20.UseVisualStyleBackColor = true;
            this.pTile20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile15
            // 
            this.pTile15.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile15.Location = new System.Drawing.Point(371, 49);
            this.pTile15.Margin = new System.Windows.Forms.Padding(4);
            this.pTile15.Name = "pTile15";
            this.pTile15.Size = new System.Drawing.Size(35, 34);
            this.pTile15.TabIndex = 130;
            this.pTile15.UseVisualStyleBackColor = true;
            this.pTile15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile14
            // 
            this.pTile14.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile14.Location = new System.Drawing.Point(336, 49);
            this.pTile14.Margin = new System.Windows.Forms.Padding(4);
            this.pTile14.Name = "pTile14";
            this.pTile14.Size = new System.Drawing.Size(35, 34);
            this.pTile14.TabIndex = 129;
            this.pTile14.UseVisualStyleBackColor = true;
            this.pTile14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile13
            // 
            this.pTile13.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile13.Location = new System.Drawing.Point(300, 49);
            this.pTile13.Margin = new System.Windows.Forms.Padding(4);
            this.pTile13.Name = "pTile13";
            this.pTile13.Size = new System.Drawing.Size(35, 34);
            this.pTile13.TabIndex = 128;
            this.pTile13.UseVisualStyleBackColor = true;
            this.pTile13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile12
            // 
            this.pTile12.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile12.Location = new System.Drawing.Point(265, 49);
            this.pTile12.Margin = new System.Windows.Forms.Padding(4);
            this.pTile12.Name = "pTile12";
            this.pTile12.Size = new System.Drawing.Size(35, 34);
            this.pTile12.TabIndex = 127;
            this.pTile12.UseVisualStyleBackColor = true;
            this.pTile12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile19
            // 
            this.pTile19.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile19.Location = new System.Drawing.Point(231, 84);
            this.pTile19.Margin = new System.Windows.Forms.Padding(4);
            this.pTile19.Name = "pTile19";
            this.pTile19.Size = new System.Drawing.Size(35, 34);
            this.pTile19.TabIndex = 126;
            this.pTile19.UseVisualStyleBackColor = true;
            this.pTile19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile11
            // 
            this.pTile11.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile11.Location = new System.Drawing.Point(231, 49);
            this.pTile11.Margin = new System.Windows.Forms.Padding(4);
            this.pTile11.Name = "pTile11";
            this.pTile11.Size = new System.Drawing.Size(35, 34);
            this.pTile11.TabIndex = 125;
            this.pTile11.UseVisualStyleBackColor = true;
            this.pTile11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile18
            // 
            this.pTile18.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile18.Location = new System.Drawing.Point(196, 84);
            this.pTile18.Margin = new System.Windows.Forms.Padding(4);
            this.pTile18.Name = "pTile18";
            this.pTile18.Size = new System.Drawing.Size(35, 34);
            this.pTile18.TabIndex = 124;
            this.pTile18.UseVisualStyleBackColor = true;
            this.pTile18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile10
            // 
            this.pTile10.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile10.Location = new System.Drawing.Point(196, 49);
            this.pTile10.Margin = new System.Windows.Forms.Padding(4);
            this.pTile10.Name = "pTile10";
            this.pTile10.Size = new System.Drawing.Size(35, 34);
            this.pTile10.TabIndex = 123;
            this.pTile10.UseVisualStyleBackColor = true;
            this.pTile10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile2
            // 
            this.pTile2.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile2.Location = new System.Drawing.Point(196, 15);
            this.pTile2.Margin = new System.Windows.Forms.Padding(4);
            this.pTile2.Name = "pTile2";
            this.pTile2.Size = new System.Drawing.Size(35, 34);
            this.pTile2.TabIndex = 122;
            this.pTile2.UseVisualStyleBackColor = true;
            this.pTile2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile6
            // 
            this.pTile6.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile6.Location = new System.Drawing.Point(336, 15);
            this.pTile6.Margin = new System.Windows.Forms.Padding(4);
            this.pTile6.Name = "pTile6";
            this.pTile6.Size = new System.Drawing.Size(35, 34);
            this.pTile6.TabIndex = 121;
            this.pTile6.UseVisualStyleBackColor = true;
            this.pTile6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile8
            // 
            this.pTile8.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile8.Location = new System.Drawing.Point(405, 15);
            this.pTile8.Margin = new System.Windows.Forms.Padding(4);
            this.pTile8.Name = "pTile8";
            this.pTile8.Size = new System.Drawing.Size(35, 34);
            this.pTile8.TabIndex = 120;
            this.pTile8.UseVisualStyleBackColor = true;
            this.pTile8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile7
            // 
            this.pTile7.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile7.Location = new System.Drawing.Point(371, 15);
            this.pTile7.Margin = new System.Windows.Forms.Padding(4);
            this.pTile7.Name = "pTile7";
            this.pTile7.Size = new System.Drawing.Size(35, 34);
            this.pTile7.TabIndex = 119;
            this.pTile7.UseVisualStyleBackColor = true;
            this.pTile7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile5
            // 
            this.pTile5.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile5.Location = new System.Drawing.Point(300, 15);
            this.pTile5.Margin = new System.Windows.Forms.Padding(4);
            this.pTile5.Name = "pTile5";
            this.pTile5.Size = new System.Drawing.Size(35, 34);
            this.pTile5.TabIndex = 118;
            this.pTile5.UseVisualStyleBackColor = true;
            this.pTile5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile4
            // 
            this.pTile4.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile4.Location = new System.Drawing.Point(265, 15);
            this.pTile4.Margin = new System.Windows.Forms.Padding(4);
            this.pTile4.Name = "pTile4";
            this.pTile4.Size = new System.Drawing.Size(35, 34);
            this.pTile4.TabIndex = 117;
            this.pTile4.UseVisualStyleBackColor = true;
            this.pTile4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile24
            // 
            this.pTile24.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile24.Location = new System.Drawing.Point(405, 84);
            this.pTile24.Margin = new System.Windows.Forms.Padding(4);
            this.pTile24.Name = "pTile24";
            this.pTile24.Size = new System.Drawing.Size(35, 34);
            this.pTile24.TabIndex = 116;
            this.pTile24.UseVisualStyleBackColor = true;
            this.pTile24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile16
            // 
            this.pTile16.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile16.Location = new System.Drawing.Point(405, 49);
            this.pTile16.Margin = new System.Windows.Forms.Padding(4);
            this.pTile16.Name = "pTile16";
            this.pTile16.Size = new System.Drawing.Size(35, 34);
            this.pTile16.TabIndex = 115;
            this.pTile16.UseVisualStyleBackColor = true;
            this.pTile16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile3
            // 
            this.pTile3.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile3.Location = new System.Drawing.Point(231, 15);
            this.pTile3.Margin = new System.Windows.Forms.Padding(4);
            this.pTile3.Name = "pTile3";
            this.pTile3.Size = new System.Drawing.Size(35, 34);
            this.pTile3.TabIndex = 114;
            this.pTile3.UseVisualStyleBackColor = true;
            this.pTile3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile17
            // 
            this.pTile17.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile17.Location = new System.Drawing.Point(161, 84);
            this.pTile17.Margin = new System.Windows.Forms.Padding(4);
            this.pTile17.Name = "pTile17";
            this.pTile17.Size = new System.Drawing.Size(35, 34);
            this.pTile17.TabIndex = 113;
            this.pTile17.UseVisualStyleBackColor = true;
            this.pTile17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile9
            // 
            this.pTile9.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile9.Location = new System.Drawing.Point(161, 49);
            this.pTile9.Margin = new System.Windows.Forms.Padding(4);
            this.pTile9.Name = "pTile9";
            this.pTile9.Size = new System.Drawing.Size(35, 34);
            this.pTile9.TabIndex = 112;
            this.pTile9.UseVisualStyleBackColor = true;
            this.pTile9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile1
            // 
            this.pTile1.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile1.Location = new System.Drawing.Point(161, 15);
            this.pTile1.Margin = new System.Windows.Forms.Padding(4);
            this.pTile1.Name = "pTile1";
            this.pTile1.Size = new System.Drawing.Size(35, 34);
            this.pTile1.TabIndex = 111;
            this.pTile1.UseVisualStyleBackColor = true;
            this.pTile1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.pTile32);
            this.groupBox5.Controls.Add(this.pTile31);
            this.groupBox5.Controls.Add(this.pTile30);
            this.groupBox5.Controls.Add(this.pTile29);
            this.groupBox5.Controls.Add(this.pTile28);
            this.groupBox5.Controls.Add(this.pTile27);
            this.groupBox5.Controls.Add(this.pTile26);
            this.groupBox5.Controls.Add(this.pTile25);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.savePalette);
            this.groupBox5.Controls.Add(this.createPalette);
            this.groupBox5.Controls.Add(this.paletteList);
            this.groupBox5.Controls.Add(this.tileName);
            this.groupBox5.Controls.Add(this.pTile22);
            this.groupBox5.Controls.Add(this.pTile8);
            this.groupBox5.Controls.Add(this.pTile21);
            this.groupBox5.Controls.Add(this.pTile1);
            this.groupBox5.Controls.Add(this.pTile23);
            this.groupBox5.Controls.Add(this.pTile9);
            this.groupBox5.Controls.Add(this.pTile20);
            this.groupBox5.Controls.Add(this.pTile17);
            this.groupBox5.Controls.Add(this.pTile15);
            this.groupBox5.Controls.Add(this.pTile3);
            this.groupBox5.Controls.Add(this.pTile14);
            this.groupBox5.Controls.Add(this.pTile16);
            this.groupBox5.Controls.Add(this.pTile13);
            this.groupBox5.Controls.Add(this.pTile24);
            this.groupBox5.Controls.Add(this.pTile12);
            this.groupBox5.Controls.Add(this.pTile4);
            this.groupBox5.Controls.Add(this.pTile19);
            this.groupBox5.Controls.Add(this.pTile5);
            this.groupBox5.Controls.Add(this.pTile11);
            this.groupBox5.Controls.Add(this.pTile7);
            this.groupBox5.Controls.Add(this.pTile18);
            this.groupBox5.Controls.Add(this.pTile6);
            this.groupBox5.Controls.Add(this.pTile10);
            this.groupBox5.Controls.Add(this.pTile2);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(723, 538);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(448, 164);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tile Palette";
            // 
            // pTile32
            // 
            this.pTile32.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile32.Location = new System.Drawing.Point(405, 118);
            this.pTile32.Margin = new System.Windows.Forms.Padding(4);
            this.pTile32.Name = "pTile32";
            this.pTile32.Size = new System.Drawing.Size(35, 34);
            this.pTile32.TabIndex = 155;
            this.pTile32.UseVisualStyleBackColor = true;
            this.pTile32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile31
            // 
            this.pTile31.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile31.Location = new System.Drawing.Point(371, 118);
            this.pTile31.Margin = new System.Windows.Forms.Padding(4);
            this.pTile31.Name = "pTile31";
            this.pTile31.Size = new System.Drawing.Size(35, 34);
            this.pTile31.TabIndex = 154;
            this.pTile31.UseVisualStyleBackColor = true;
            this.pTile31.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile30
            // 
            this.pTile30.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile30.Location = new System.Drawing.Point(336, 118);
            this.pTile30.Margin = new System.Windows.Forms.Padding(4);
            this.pTile30.Name = "pTile30";
            this.pTile30.Size = new System.Drawing.Size(35, 34);
            this.pTile30.TabIndex = 153;
            this.pTile30.UseVisualStyleBackColor = true;
            this.pTile30.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile29
            // 
            this.pTile29.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile29.Location = new System.Drawing.Point(300, 118);
            this.pTile29.Margin = new System.Windows.Forms.Padding(4);
            this.pTile29.Name = "pTile29";
            this.pTile29.Size = new System.Drawing.Size(35, 34);
            this.pTile29.TabIndex = 152;
            this.pTile29.UseVisualStyleBackColor = true;
            this.pTile29.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile28
            // 
            this.pTile28.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile28.Location = new System.Drawing.Point(265, 118);
            this.pTile28.Margin = new System.Windows.Forms.Padding(4);
            this.pTile28.Name = "pTile28";
            this.pTile28.Size = new System.Drawing.Size(35, 34);
            this.pTile28.TabIndex = 151;
            this.pTile28.UseVisualStyleBackColor = true;
            this.pTile28.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile27
            // 
            this.pTile27.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile27.Location = new System.Drawing.Point(231, 118);
            this.pTile27.Margin = new System.Windows.Forms.Padding(4);
            this.pTile27.Name = "pTile27";
            this.pTile27.Size = new System.Drawing.Size(35, 34);
            this.pTile27.TabIndex = 150;
            this.pTile27.UseVisualStyleBackColor = true;
            this.pTile27.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile26
            // 
            this.pTile26.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile26.Location = new System.Drawing.Point(196, 118);
            this.pTile26.Margin = new System.Windows.Forms.Padding(4);
            this.pTile26.Name = "pTile26";
            this.pTile26.Size = new System.Drawing.Size(35, 34);
            this.pTile26.TabIndex = 149;
            this.pTile26.UseVisualStyleBackColor = true;
            this.pTile26.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // pTile25
            // 
            this.pTile25.BackgroundImage = global::MagoCrate.Properties.Resources._0;
            this.pTile25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pTile25.Location = new System.Drawing.Point(161, 118);
            this.pTile25.Margin = new System.Windows.Forms.Padding(4);
            this.pTile25.Name = "pTile25";
            this.pTile25.Size = new System.Drawing.Size(35, 34);
            this.pTile25.TabIndex = 148;
            this.pTile25.UseVisualStyleBackColor = true;
            this.pTile25.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteButton_MouseDown);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.xCoord);
            this.groupBox7.Controls.Add(this.xOffset);
            this.groupBox7.Controls.Add(this.yCoord);
            this.groupBox7.Controls.Add(this.halfTileLock);
            this.groupBox7.Controls.Add(this.yOffset);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Location = new System.Drawing.Point(493, 538);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(221, 164);
            this.groupBox7.TabIndex = 136;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Position Editor";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1504, 709);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dropper);
            this.Controls.Add(this.move);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.viewType);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resetCamera);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.glControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1522, 756);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagoCrate";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Enter += new System.EventHandler(this.MainForm_Enter);
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
            this.dynamicTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xCoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoord)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dB_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Unk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dF_Dynamic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_Dynamic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dF_Unk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Dynamic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_Unk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dF_ID)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockImg)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAutomove)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeH)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown vMat;
        private System.Windows.Forms.NumericUpDown vAutomove;
        private System.Windows.Forms.NumericUpDown dB_ID;
        private System.Windows.Forms.CheckBox lava;
        private System.Windows.Forms.CheckBox water;
        private System.Windows.Forms.CheckBox ladder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox colImg;
        private System.Windows.Forms.PictureBox blockImg;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown sizeW;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown sizeH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem useAvailableSpritesToolStripMenuItem;
        private System.Windows.Forms.CheckBox halfTileLock;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown dB_Unk;
        private System.Windows.Forms.NumericUpDown dF_Dynamic;
        private System.Windows.Forms.NumericUpDown dM_Dynamic;
        private System.Windows.Forms.NumericUpDown dF_Unk;
        private System.Windows.Forms.NumericUpDown dB_Dynamic;
        private System.Windows.Forms.NumericUpDown dM_Unk;
        private System.Windows.Forms.NumericUpDown dM_ID;
        private System.Windows.Forms.NumericUpDown dF_ID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox dF_hex;
        private System.Windows.Forms.TextBox dM_hex;
        private System.Windows.Forms.TextBox dB_hex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem optionsAndHelpToolStripMenuItem;
        private System.Windows.Forms.ComboBox viewType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem renderMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderAutoMovementToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox blockList;
        private System.Windows.Forms.NumericUpDown vBlock;
        private System.Windows.Forms.NumericUpDown vShape;
        private System.Windows.Forms.ComboBox materialList;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.TabPage dynamicTab;
        private System.Windows.Forms.ListBox dynamicList;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stageSettingsToolStripMenuItem;
        private System.Windows.Forms.ComboBox paletteList;
        private System.Windows.Forms.TextBox tileName;
        private System.Windows.Forms.Button pTile1;
        private System.Windows.Forms.Button pTile9;
        private System.Windows.Forms.Button pTile17;
        private System.Windows.Forms.Button pTile3;
        private System.Windows.Forms.Button pTile16;
        private System.Windows.Forms.Button pTile24;
        private System.Windows.Forms.Button pTile4;
        private System.Windows.Forms.Button pTile5;
        private System.Windows.Forms.Button pTile7;
        private System.Windows.Forms.Button pTile8;
        private System.Windows.Forms.Button pTile6;
        private System.Windows.Forms.Button pTile2;
        private System.Windows.Forms.Button pTile10;
        private System.Windows.Forms.Button pTile18;
        private System.Windows.Forms.Button pTile11;
        private System.Windows.Forms.Button pTile19;
        private System.Windows.Forms.Button pTile12;
        private System.Windows.Forms.Button pTile13;
        private System.Windows.Forms.Button pTile14;
        private System.Windows.Forms.Button pTile15;
        private System.Windows.Forms.Button pTile20;
        private System.Windows.Forms.Button pTile23;
        private System.Windows.Forms.Button pTile21;
        private System.Windows.Forms.Button pTile22;
        private System.Windows.Forms.ToolStripMenuItem renderEntityNamesToolStripMenuItem;
        private System.Windows.Forms.Button dropper;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderDynamicTerrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderCollisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patchFDGToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importSpriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanMaterialsToolStripMenuItem1;
        private System.Windows.Forms.Button editBlock;
        private System.Windows.Forms.Button editAuto;
        private System.Windows.Forms.Button editMat;
        private System.Windows.Forms.Button editMod;
        private System.Windows.Forms.Button editCol;
        private System.Windows.Forms.Button unlockAll;
        private System.Windows.Forms.Button editDecoF;
        private System.Windows.Forms.Button editDecoM;
        private System.Windows.Forms.Button editDecoB;
        private System.Windows.Forms.ToolStripMenuItem tileDataEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCollisionShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editModifiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAutoMovementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBLandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMLandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFLandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleAllToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button savePalette;
        private System.Windows.Forms.Button pTile32;
        private System.Windows.Forms.Button pTile31;
        private System.Windows.Forms.Button pTile30;
        private System.Windows.Forms.Button pTile29;
        private System.Windows.Forms.Button pTile28;
        private System.Windows.Forms.Button pTile27;
        private System.Windows.Forms.Button pTile26;
        private System.Windows.Forms.Button pTile25;
        private System.Windows.Forms.Button createPalette;
        private System.Windows.Forms.ToolStripMenuItem clearBoundariesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateBoundariesToolStripMenuItem;
    }
}

