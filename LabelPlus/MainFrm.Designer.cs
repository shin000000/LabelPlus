﻿namespace LabelPlus
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputPhotoshopScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.langToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_EditLabelMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_HideLabel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_HideWindow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_SetCategory1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_SetCategory2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_SetCategory3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_SetCategory4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox_File = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton_Left = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Right = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelLabels = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripLabels = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_EditBig = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_EditSmall = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelTipSetCategory = new System.Windows.Forms.ToolStripLabel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextBox_GroupBox = new System.Windows.Forms.GroupBox();
            this.labelCtrlEnterTip = new System.Windows.Forms.Label();
            this.TranslateTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.picView = new LabelPlus.PicView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanelLabels.SuspendLayout();
            this.toolStripLabels.SuspendLayout();
            this.TextBox_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.outputPToolStripMenuItem,
            this.aboutAToolStripMenuItem,
            this.langToolStripComboBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveProjectSToolStripMenuItem,
            this.saveAsDToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitEToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newToolStripMenuItem.Text = "New(&N)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openToolStripMenuItem.Text = "Open(&O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveProjectSToolStripMenuItem
            // 
            this.saveProjectSToolStripMenuItem.Name = "saveProjectSToolStripMenuItem";
            this.saveProjectSToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveProjectSToolStripMenuItem.Text = "Save(&S)";
            this.saveProjectSToolStripMenuItem.Click += new System.EventHandler(this.saveSToolStripMenuItem_Click);
            // 
            // saveAsDToolStripMenuItem
            // 
            this.saveAsDToolStripMenuItem.Name = "saveAsDToolStripMenuItem";
            this.saveAsDToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveAsDToolStripMenuItem.Text = "Save As(&S)";
            this.saveAsDToolStripMenuItem.Click += new System.EventHandler(this.saveAsDToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 6);
            // 
            // exitEToolStripMenuItem
            // 
            this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
            this.exitEToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitEToolStripMenuItem.Text = "Exit(&E)";
            this.exitEToolStripMenuItem.Click += new System.EventHandler(this.exitEToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(126, 25);
            this.imageToolStripMenuItem.Text = "Image Manager(&I)";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // outputPToolStripMenuItem
            // 
            this.outputPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputAllToolStripMenuItem,
            this.outputPhotoshopScriptToolStripMenuItem});
            this.outputPToolStripMenuItem.Name = "outputPToolStripMenuItem";
            this.outputPToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.outputPToolStripMenuItem.Text = "Output(&P)";
            // 
            // outputAllToolStripMenuItem
            // 
            this.outputAllToolStripMenuItem.Name = "outputAllToolStripMenuItem";
            this.outputAllToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.outputAllToolStripMenuItem.Text = "OutputAllImage(&O)";
            this.outputAllToolStripMenuItem.Click += new System.EventHandler(this.outputAllToolStripMenuItem_Click);
            // 
            // outputPhotoshopScriptToolStripMenuItem
            // 
            this.outputPhotoshopScriptToolStripMenuItem.Name = "outputPhotoshopScriptToolStripMenuItem";
            this.outputPhotoshopScriptToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.outputPhotoshopScriptToolStripMenuItem.Text = "OutputPhotoshopScript(&P)";
            this.outputPhotoshopScriptToolStripMenuItem.Click += new System.EventHandler(this.outputPhotoshopScriptToolStripMenuItem_Click);
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.aboutAToolStripMenuItem.Text = "About(&A)";
            this.aboutAToolStripMenuItem.Click += new System.EventHandler(this.aboutAToolStripMenuItem_Click);
            // 
            // langToolStripComboBox
            // 
            this.langToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langToolStripComboBox.Name = "langToolStripComboBox";
            this.langToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_EditLabelMode,
            this.toolStripButton_HideLabel,
            this.toolStripButton_HideWindow,
            this.toolStripSeparator3,
            this.toolStripButton_SetCategory1,
            this.toolStripButton_SetCategory2,
            this.toolStripButton_SetCategory3,
            this.toolStripButton_SetCategory4,
            this.toolStripSeparator5,
            this.toolStripComboBox_File,
            this.toolStripButton_Left,
            this.toolStripButton_Right,
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 29);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(711, 28);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "text";
            // 
            // toolStripButton_EditLabelMode
            // 
            this.toolStripButton_EditLabelMode.CheckOnClick = true;
            this.toolStripButton_EditLabelMode.Image = global::LabelPlus.Properties.Resources.LabelMode;
            this.toolStripButton_EditLabelMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_EditLabelMode.Name = "toolStripButton_EditLabelMode";
            this.toolStripButton_EditLabelMode.Size = new System.Drawing.Size(49, 25);
            this.toolStripButton_EditLabelMode.Text = "text";
            // 
            // toolStripButton_HideLabel
            // 
            this.toolStripButton_HideLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_HideLabel.Name = "toolStripButton_HideLabel";
            this.toolStripButton_HideLabel.Size = new System.Drawing.Size(49, 25);
            this.toolStripButton_HideLabel.Text = "text(&V)";
            // 
            // toolStripButton_HideWindow
            // 
            this.toolStripButton_HideWindow.Image = global::LabelPlus.Properties.Resources.Hide;
            this.toolStripButton_HideWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_HideWindow.Name = "toolStripButton_HideWindow";
            this.toolStripButton_HideWindow.Size = new System.Drawing.Size(67, 25);
            this.toolStripButton_HideWindow.Text = "text(&Q)";
            this.toolStripButton_HideWindow.Click += new System.EventHandler(this.toolStripButton_HideWindow_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton_SetCategory1
            // 
            this.toolStripButton_SetCategory1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_SetCategory1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_SetCategory1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_SetCategory1.Image")));
            this.toolStripButton_SetCategory1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SetCategory1.Name = "toolStripButton_SetCategory1";
            this.toolStripButton_SetCategory1.Size = new System.Drawing.Size(35, 25);
            this.toolStripButton_SetCategory1.Text = "G1";
            // 
            // toolStripButton_SetCategory2
            // 
            this.toolStripButton_SetCategory2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_SetCategory2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_SetCategory2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_SetCategory2.Image")));
            this.toolStripButton_SetCategory2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SetCategory2.Name = "toolStripButton_SetCategory2";
            this.toolStripButton_SetCategory2.Size = new System.Drawing.Size(35, 25);
            this.toolStripButton_SetCategory2.Text = "G2";

            // 
            // toolStripButton_SetCategory3
            // 
            this.toolStripButton_SetCategory3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_SetCategory3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_SetCategory3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_SetCategory3.Image")));
            this.toolStripButton_SetCategory3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SetCategory3.Name = "toolStripButton_SetCategory3";
            this.toolStripButton_SetCategory3.Size = new System.Drawing.Size(35, 25);
            this.toolStripButton_SetCategory3.Text = "G3";
            
            // 
            // toolStripButton_SetCategory4
            // 
            this.toolStripButton_SetCategory4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_SetCategory4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_SetCategory4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_SetCategory4.Image")));
            this.toolStripButton_SetCategory4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SetCategory4.Name = "toolStripButton_SetCategory4";
            this.toolStripButton_SetCategory4.Size = new System.Drawing.Size(35, 25);
            this.toolStripButton_SetCategory4.Text = "G4";
            this.toolStripButton_SetCategory4.ToolTipText = "G4";
            
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripComboBox_File
            // 
            this.toolStripComboBox_File.DropDownWidth = 250;
            this.toolStripComboBox_File.Name = "toolStripComboBox_File";
            this.toolStripComboBox_File.Size = new System.Drawing.Size(200, 28);
            // 
            // toolStripButton_Left
            // 
            this.toolStripButton_Left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Left.Image = global::LabelPlus.Properties.Resources.left;
            this.toolStripButton_Left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Left.Name = "toolStripButton_Left";
            this.toolStripButton_Left.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton_Left.Text = "text";
            this.toolStripButton_Left.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton_Left.Click += new System.EventHandler(this.toolStripButton_Left_Click);
            // 
            // toolStripButton_Right
            // 
            this.toolStripButton_Right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Right.Image = global::LabelPlus.Properties.Resources.right;
            this.toolStripButton_Right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Right.Name = "toolStripButton_Right";
            this.toolStripButton_Right.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton_Right.Text = "text";
            this.toolStripButton_Right.Click += new System.EventHandler(this.toolStripButton_Right_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 57);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.picView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer.Size = new System.Drawing.Size(711, 399);
            this.splitContainer.SplitterDistance = 443;
            this.splitContainer.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanelLabels);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_GroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(262, 397);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanelLabels
            // 
            this.tableLayoutPanelLabels.ColumnCount = 1;
            this.tableLayoutPanelLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLabels.Controls.Add(this.toolStripLabels, 0, 0);
            this.tableLayoutPanelLabels.Controls.Add(this.listView, 0, 1);
            this.tableLayoutPanelLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLabels.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLabels.Name = "tableLayoutPanelLabels";
            this.tableLayoutPanelLabels.RowCount = 2;
            this.tableLayoutPanelLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLabels.Size = new System.Drawing.Size(262, 234);
            this.tableLayoutPanelLabels.TabIndex = 3;
            // 
            // toolStripLabels
            // 
            this.toolStripLabels.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripLabels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_EditBig,
            this.toolStripButton_EditSmall,
            this.toolStripSeparator2,
            this.toolStripButton_Clear,
            this.toolStripSeparator4,
            this.toolStripLabelTipSetCategory});
            this.toolStripLabels.Location = new System.Drawing.Point(0, 0);
            this.toolStripLabels.Name = "toolStripLabels";
            this.toolStripLabels.Size = new System.Drawing.Size(262, 25);
            this.toolStripLabels.TabIndex = 0;
            // 
            // toolStripButton_EditBig
            // 
            this.toolStripButton_EditBig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_EditBig.Image = global::LabelPlus.Properties.Resources.plus;
            this.toolStripButton_EditBig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_EditBig.Name = "toolStripButton_EditBig";
            this.toolStripButton_EditBig.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_EditBig.Text = "text";
            this.toolStripButton_EditBig.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton_EditBig.Click += new System.EventHandler(this.toolStripButton_EditBig_Click);
            // 
            // toolStripButton_EditSmall
            // 
            this.toolStripButton_EditSmall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_EditSmall.Image = global::LabelPlus.Properties.Resources.minis;
            this.toolStripButton_EditSmall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_EditSmall.Name = "toolStripButton_EditSmall";
            this.toolStripButton_EditSmall.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_EditSmall.Text = "text";
            this.toolStripButton_EditSmall.Click += new System.EventHandler(this.toolStripButton_EditSmall_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Clear
            // 
            this.toolStripButton_Clear.Image = global::LabelPlus.Properties.Resources.clear;
            this.toolStripButton_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Clear.Name = "toolStripButton_Clear";
            this.toolStripButton_Clear.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton_Clear.Text = "text";
            this.toolStripButton_Clear.Click += new System.EventHandler(this.toolStripButton_Clear_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelTipSetCategory
            // 
            this.toolStripLabelTipSetCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabelTipSetCategory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabelTipSetCategory.Image")));
            this.toolStripLabelTipSetCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabelTipSetCategory.Name = "toolStripLabelTipSetCategory";
            this.toolStripLabelTipSetCategory.Size = new System.Drawing.Size(87, 22);
            this.toolStripLabelTipSetCategory.Text = "1-4键设置分类";
            this.toolStripLabelTipSetCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(3, 28);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(256, 203);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Group";
            this.columnHeader2.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "Text";
            // 
            // TextBox_GroupBox
            // 
            this.TextBox_GroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_GroupBox.Controls.Add(this.labelCtrlEnterTip);
            this.TextBox_GroupBox.Controls.Add(this.TranslateTextBox);
            this.TextBox_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_GroupBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_GroupBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox_GroupBox.Name = "TextBox_GroupBox";
            this.TextBox_GroupBox.Size = new System.Drawing.Size(262, 159);
            this.TextBox_GroupBox.TabIndex = 0;
            this.TextBox_GroupBox.TabStop = false;
            // 
            // labelCtrlEnterTip
            // 
            this.labelCtrlEnterTip.AutoSize = true;
            this.labelCtrlEnterTip.BackColor = System.Drawing.SystemColors.Window;
            this.labelCtrlEnterTip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCtrlEnterTip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCtrlEnterTip.Location = new System.Drawing.Point(3, 144);
            this.labelCtrlEnterTip.Name = "labelCtrlEnterTip";
            this.labelCtrlEnterTip.Size = new System.Drawing.Size(65, 12);
            this.labelCtrlEnterTip.TabIndex = 6;
            this.labelCtrlEnterTip.Text = "Ctrl+Enter";
            // 
            // TranslateTextBox
            // 
            this.TranslateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TranslateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TranslateTextBox.Location = new System.Drawing.Point(3, 22);
            this.TranslateTextBox.Multiline = true;
            this.TranslateTextBox.Name = "TranslateTextBox";
            this.TranslateTextBox.Size = new System.Drawing.Size(256, 134);
            this.TranslateTextBox.TabIndex = 5;
            this.TranslateTextBox.WordWrap = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "TEXT|*.txt";
            this.openFileDialog.Title = "Open";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "TEXT|*.txt";
            this.saveFileDialog.Title = "Save";
            // 
            // timerAutoSave
            // 
            this.timerAutoSave.Enabled = true;
            this.timerAutoSave.Interval = 30000;
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LabelPlus";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // picView
            // 
            this.picView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picView.Location = new System.Drawing.Point(0, 0);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(441, 397);
            this.picView.TabIndex = 5;
            this.picView.Zoom = 0.05F;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 456);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "LabelPlus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.SizeChanged += new System.EventHandler(this.MainFrm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanelLabels.ResumeLayout(false);
            this.tableLayoutPanelLabels.PerformLayout();
            this.toolStripLabels.ResumeLayout(false);
            this.toolStripLabels.PerformLayout();
            this.TextBox_GroupBox.ResumeLayout(false);
            this.TextBox_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputAllToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private PicView picView;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_File;
        private System.Windows.Forms.ToolStripButton toolStripButton_Left;
        private System.Windows.Forms.ToolStripButton toolStripButton_Right;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputPhotoshopScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox TextBox_GroupBox;
        private System.Windows.Forms.TextBox TranslateTextBox;
        private System.Windows.Forms.ToolStripMenuItem saveAsDToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox langToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.Timer timerAutoSave;
        private System.Windows.Forms.Label labelCtrlEnterTip;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripButton toolStripButton_EditLabelMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_HideWindow;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripButton toolStripButton_HideLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLabels;
        private System.Windows.Forms.ToolStrip toolStripLabels;
        private System.Windows.Forms.ToolStripButton toolStripButton_EditBig;
        private System.Windows.Forms.ToolStripButton toolStripButton_EditSmall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Clear;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTipSetCategory;
        private System.Windows.Forms.ToolStripButton toolStripButton_SetCategory1;
        private System.Windows.Forms.ToolStripButton toolStripButton_SetCategory2;
        private System.Windows.Forms.ToolStripButton toolStripButton_SetCategory3;
        private System.Windows.Forms.ToolStripButton toolStripButton_SetCategory4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

    }
}

