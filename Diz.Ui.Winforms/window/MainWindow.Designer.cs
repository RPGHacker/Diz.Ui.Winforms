namespace Diz.Ui.Winforms.window;

partial class MainWindow
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
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
        table = new DataGridView();
        ColumnAlias = new DataGridViewTextBoxColumn();
        ColumnPC = new DataGridViewTextBoxColumn();
        ColumnChar = new DataGridViewTextBoxColumn();
        ColumnHex = new DataGridViewTextBoxColumn();
        ColumnPoints = new DataGridViewTextBoxColumn();
        ColumnInstruction = new DataGridViewTextBoxColumn();
        ColumnIA = new DataGridViewTextBoxColumn();
        ColumnFlag = new DataGridViewTextBoxColumn();
        ColumnDB = new DataGridViewTextBoxColumn();
        ColumnDP = new DataGridViewTextBoxColumn();
        ColumnM = new DataGridViewTextBoxColumn();
        ColumnX = new DataGridViewTextBoxColumn();
        ColumnComment = new DataGridViewTextBoxColumn();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        newProjectToolStripMenuItem = new ToolStripMenuItem();
        openProjectToolStripMenuItem = new ToolStripMenuItem();
        toolStripOpenLast = new ToolStripMenuItem();
        closeProjectToolStripMenuItem = new ToolStripMenuItem();
        saveProjectToolStripMenuItem = new ToolStripMenuItem();
        saveProjectAsToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        toolStripMenuItem2 = new ToolStripMenuItem();
        importUsageMapToolStripMenuItem = new ToolStripMenuItem();
        importCDLToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator8 = new ToolStripSeparator();
        importTraceLogText = new ToolStripMenuItem();
        exportToolStripMenuItem = new ToolStripMenuItem();
        toolStrip_exportDisassemblyUseCurrentSettings = new ToolStripMenuItem();
        toolStrip_exportDisassemblyEditSettingsFirst = new ToolStripMenuItem();
        toolStripSeparator11 = new ToolStripSeparator();
        toolStrip_openExportDirectory = new ToolStripMenuItem();
        toolStripSeparator7 = new ToolStripSeparator();
        exitToolStripMenuItem = new ToolStripMenuItem();
        editToolStripMenuItem = new ToolStripMenuItem();
        stepOverToolStripMenuItem = new ToolStripMenuItem();
        stepInToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator2 = new ToolStripSeparator();
        autoStepSafeToolStripMenuItem = new ToolStripMenuItem();
        autoStepHarshToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator3 = new ToolStripSeparator();
        markOneToolStripMenuItem = new ToolStripMenuItem();
        markManyToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator5 = new ToolStripSeparator();
        addLabelToolStripMenuItem = new ToolStripMenuItem();
        setDataBankToolStripMenuItem = new ToolStripMenuItem();
        setDirectPageToolStripMenuItem = new ToolStripMenuItem();
        toggleAccumulatorSizeMToolStripMenuItem = new ToolStripMenuItem();
        toggleIndexSizeToolStripMenuItem = new ToolStripMenuItem();
        addCommentToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator6 = new ToolStripSeparator();
        fixMisalignedInstructionsToolStripMenuItem = new ToolStripMenuItem();
        rescanForInOutPointsToolStripMenuItem = new ToolStripMenuItem();
        navigateToolStripMenuItem = new ToolStripMenuItem();
        showHistoryToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator9 = new ToolStripSeparator();
        goBackToolStripMenuItem = new ToolStripMenuItem();
        goForwardToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator10 = new ToolStripSeparator();
        gotoToolStripMenuItem = new ToolStripMenuItem();
        gotoIntermediateAddressToolStripMenuItem = new ToolStripMenuItem();
        gotoFirstUnreachedToolStripMenuItem = new ToolStripMenuItem();
        gotoNearUnreachedToolStripMenuItem = new ToolStripMenuItem();
        gotoNextUnreachedToolStripMenuItem = new ToolStripMenuItem();
        gotoNextUnreachedInPointToolStripMenuItem = new ToolStripMenuItem();
        selectMarkerToolStripMenuItem = new ToolStripMenuItem();
        unreachedToolStripMenuItem = new ToolStripMenuItem();
        opcodeToolStripMenuItem = new ToolStripMenuItem();
        operandToolStripMenuItem = new ToolStripMenuItem();
        bitDataToolStripMenuItem = new ToolStripMenuItem();
        graphicsToolStripMenuItem = new ToolStripMenuItem();
        musicToolStripMenuItem = new ToolStripMenuItem();
        emptyToolStripMenuItem = new ToolStripMenuItem();
        bitDataToolStripMenuItem1 = new ToolStripMenuItem();
        wordPointerToolStripMenuItem = new ToolStripMenuItem();
        bitDataToolStripMenuItem2 = new ToolStripMenuItem();
        longPointerToolStripMenuItem = new ToolStripMenuItem();
        bitDataToolStripMenuItem3 = new ToolStripMenuItem();
        dWordPointerToolStripMenuItem = new ToolStripMenuItem();
        textToolStripMenuItem = new ToolStripMenuItem();
        viewToolStripMenuItem = new ToolStripMenuItem();
        visualMapToolStripMenuItem = new ToolStripMenuItem();
        graphicsWindowToolStripMenuItem = new ToolStripMenuItem();
        constantsToolStripMenuItem = new ToolStripMenuItem();
        decimalToolStripMenuItem = new ToolStripMenuItem();
        hexadecimalToolStripMenuItem = new ToolStripMenuItem();
        binaryToolStripMenuItem = new ToolStripMenuItem();
        optionsToolStripMenuItem = new ToolStripMenuItem();
        moveWithStepToolStripMenuItem = new ToolStripMenuItem();
        openLastProjectAutomaticallyToolStripMenuItem = new ToolStripMenuItem();
        projectSettingsToolStripMenuItem = new ToolStripMenuItem();
        importCaptureToolStripMenuItem = new ToolStripMenuItem();
        importTraceLogBinary = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        viewHelpToolStripMenuItem = new ToolStripMenuItem();
        githubToolStripMenuItem = new ToolStripMenuItem();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        statusStrip1 = new StatusStrip();
        percentComplete = new ToolStripStatusLabel();
        seperator1 = new ToolStripStatusLabel();
        currentMarker = new ToolStripStatusLabel();
        openFileDialog = new OpenFileDialog();
        openProjectFile = new OpenFileDialog();
        saveProjectFile = new SaveFileDialog();
        vScrollBar1 = new VScrollBar();
        openUsageMapFile = new OpenFileDialog();
        openTraceLogDialog = new OpenFileDialog();
        openCDLDialog = new OpenFileDialog();
        timer1 = new System.Windows.Forms.Timer(components);
        timerLifeCaptureUpdate = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)table).BeginInit();
        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // table
        // 
        table.AllowUserToAddRows = false;
        table.AllowUserToDeleteRows = false;
        table.AllowUserToResizeRows = false;
        table.BorderStyle = BorderStyle.None;
        table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        table.Columns.AddRange(new DataGridViewColumn[] { ColumnAlias, ColumnPC, ColumnChar, ColumnHex, ColumnPoints, ColumnInstruction, ColumnIA, ColumnFlag, ColumnDB, ColumnDP, ColumnM, ColumnX, ColumnComment });
        dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle28.BackColor = SystemColors.Window;
        dataGridViewCellStyle28.Font = new Font("Consolas", 8.25F);
        dataGridViewCellStyle28.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle28.SelectionBackColor = Color.CornflowerBlue;
        dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
        table.DefaultCellStyle = dataGridViewCellStyle28;
        table.Location = new Point(0, 24);
        table.Margin = new Padding(0);
        table.MultiSelect = false;
        table.Name = "table";
        table.RowHeadersVisible = false;
        table.RowHeadersWidth = 4;
        table.RowTemplate.Height = 15;
        table.ScrollBars = ScrollBars.None;
        table.ShowCellErrors = false;
        table.ShowCellToolTips = false;
        table.ShowEditingIcon = false;
        table.ShowRowErrors = false;
        table.Size = new Size(913, 492);
        table.TabIndex = 1;
        table.TabStop = false;
        table.VirtualMode = true;
        table.CellClick += table_CellClick;
        table.SelectionChanged += table_SelectionChanged;
        table.KeyDown += table_KeyDown;
        table.MouseDown += table_MouseDown;
        table.MouseWheel += table_MouseWheel;
        // 
        // ColumnAlias
        // 
        dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25F);
        ColumnAlias.DefaultCellStyle = dataGridViewCellStyle15;
        ColumnAlias.HeaderText = "Label";
        ColumnAlias.MaxInputLength = 60;
        ColumnAlias.MinimumWidth = 6;
        ColumnAlias.Name = "ColumnAlias";
        ColumnAlias.SortMode = DataGridViewColumnSortMode.NotSortable;
        ColumnAlias.Width = 200;
        // 
        // ColumnPC
        // 
        dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle16.Font = new Font("Consolas", 8.25F);
        ColumnPC.DefaultCellStyle = dataGridViewCellStyle16;
        ColumnPC.HeaderText = "PC";
        ColumnPC.MaxInputLength = 6;
        ColumnPC.MinimumWidth = 6;
        ColumnPC.Name = "ColumnPC";
        ColumnPC.ReadOnly = true;
        ColumnPC.SortMode = DataGridViewColumnSortMode.NotSortable;
        ColumnPC.Width = 58;
        // 
        // ColumnChar
        // 
        dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle17.Font = new Font("Consolas", 8.25F);
        ColumnChar.DefaultCellStyle = dataGridViewCellStyle17;
        ColumnChar.HeaderText = "@";
        ColumnChar.MaxInputLength = 1;
        ColumnChar.MinimumWidth = 6;
        ColumnChar.Name = "ColumnChar";
        ColumnChar.ReadOnly = true;
        ColumnChar.SortMode = DataGridViewColumnSortMode.NotSortable;
        ColumnChar.Width = 26;
        // 
        // ColumnHex
        // 
        dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle18.Font = new Font("Consolas", 8.25F);
        ColumnHex.DefaultCellStyle = dataGridViewCellStyle18;
        ColumnHex.HeaderText = "#";
        ColumnHex.MaxInputLength = 3;
        ColumnHex.MinimumWidth = 6;
        ColumnHex.Name = "ColumnHex";
        ColumnHex.ReadOnly = true;
        ColumnHex.SortMode = DataGridViewColumnSortMode.NotSortable;
        ColumnHex.Width = 26;
        // 
        // ColumnPoints
        // 
        dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle19.Font = new Font("Consolas", 8.25F);
        ColumnPoints.DefaultCellStyle = dataGridViewCellStyle19;
        ColumnPoints.HeaderText = "<*>";
        ColumnPoints.MaxInputLength = 3;
        ColumnPoints.MinimumWidth = 6;
        ColumnPoints.Name = "ColumnPoints";
        ColumnPoints.ReadOnly = true;
        ColumnPoints.Width = 34;
        // 
        // ColumnInstruction
        // 
        dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle20.Font = new Font("Consolas", 8.25F);
        ColumnInstruction.DefaultCellStyle = dataGridViewCellStyle20;
        ColumnInstruction.HeaderText = "Instruction";
        ColumnInstruction.MaxInputLength = 64;
        ColumnInstruction.MinimumWidth = 6;
        ColumnInstruction.Name = "ColumnInstruction";
        ColumnInstruction.ReadOnly = true;
        ColumnInstruction.SortMode = DataGridViewColumnSortMode.NotSortable;
        ColumnInstruction.Width = 125;
        // 
        // ColumnIA
        // 
        dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle21.Font = new Font("Consolas", 8.25F);
        ColumnIA.DefaultCellStyle = dataGridViewCellStyle21;
        ColumnIA.HeaderText = "IA";
        ColumnIA.MaxInputLength = 6;
        ColumnIA.MinimumWidth = 6;
        ColumnIA.Name = "ColumnIA";
        ColumnIA.ReadOnly = true;
        ColumnIA.SortMode = DataGridViewColumnSortMode.NotSortable;
        ColumnIA.Width = 58;
        // 
        // ColumnFlag
        // 
        dataGridViewCellStyle22.Font = new Font("Microsoft Sans Serif", 8.25F);
        ColumnFlag.DefaultCellStyle = dataGridViewCellStyle22;
        ColumnFlag.HeaderText = "Flag";
        ColumnFlag.MinimumWidth = 6;
        ColumnFlag.Name = "ColumnFlag";
        ColumnFlag.ReadOnly = true;
        ColumnFlag.Width = 86;
        // 
        // ColumnDB
        // 
        dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle23.Font = new Font("Consolas", 8.25F);
        ColumnDB.DefaultCellStyle = dataGridViewCellStyle23;
        ColumnDB.HeaderText = "B";
        ColumnDB.MaxInputLength = 2;
        ColumnDB.MinimumWidth = 6;
        ColumnDB.Name = "ColumnDB";
        ColumnDB.SortMode = DataGridViewColumnSortMode.NotSortable;
        ColumnDB.Width = 26;
        // 
        // ColumnDP
        // 
        dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle24.Font = new Font("Consolas", 8.25F);
        ColumnDP.DefaultCellStyle = dataGridViewCellStyle24;
        ColumnDP.HeaderText = "D";
        ColumnDP.MaxInputLength = 4;
        ColumnDP.MinimumWidth = 6;
        ColumnDP.Name = "ColumnDP";
        ColumnDP.SortMode = DataGridViewColumnSortMode.NotSortable;
        ColumnDP.Width = 42;
        // 
        // ColumnM
        // 
        dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle25.Font = new Font("Consolas", 8.25F);
        ColumnM.DefaultCellStyle = dataGridViewCellStyle25;
        ColumnM.HeaderText = "M";
        ColumnM.MaxInputLength = 2;
        ColumnM.MinimumWidth = 6;
        ColumnM.Name = "ColumnM";
        ColumnM.ReadOnly = true;
        ColumnM.Width = 26;
        // 
        // ColumnX
        // 
        dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle26.Font = new Font("Consolas", 8.25F);
        ColumnX.DefaultCellStyle = dataGridViewCellStyle26;
        ColumnX.HeaderText = "X";
        ColumnX.MaxInputLength = 2;
        ColumnX.MinimumWidth = 6;
        ColumnX.Name = "ColumnX";
        ColumnX.ReadOnly = true;
        ColumnX.Width = 26;
        // 
        // ColumnComment
        // 
        ColumnComment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle27.Font = new Font("Microsoft Sans Serif", 8.25F);
        ColumnComment.DefaultCellStyle = dataGridViewCellStyle27;
        ColumnComment.HeaderText = "Comment";
        ColumnComment.MinimumWidth = 6;
        ColumnComment.Name = "ColumnComment";
        ColumnComment.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, navigateToolStripMenuItem, selectMarkerToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(930, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newProjectToolStripMenuItem, openProjectToolStripMenuItem, toolStripOpenLast, closeProjectToolStripMenuItem, saveProjectToolStripMenuItem, saveProjectAsToolStripMenuItem, toolStripSeparator1, toolStripMenuItem2, exportToolStripMenuItem, toolStripSeparator7, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "&File";
        // 
        // newProjectToolStripMenuItem
        // 
        newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
        newProjectToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        newProjectToolStripMenuItem.Size = new Size(235, 22);
        newProjectToolStripMenuItem.Text = "New Project...";
        newProjectToolStripMenuItem.Click += newProjectToolStripMenuItem_Click;
        // 
        // openProjectToolStripMenuItem
        // 
        openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
        openProjectToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        openProjectToolStripMenuItem.Size = new Size(235, 22);
        openProjectToolStripMenuItem.Text = "Open Project...";
        openProjectToolStripMenuItem.Click += openProjectToolStripMenuItem_Click;
        // 
        // toolStripOpenLast
        // 
        toolStripOpenLast.Name = "toolStripOpenLast";
        toolStripOpenLast.Size = new Size(235, 22);
        toolStripOpenLast.Text = "Open Last Project";
        toolStripOpenLast.Click += toolStripOpenLast_Click;
        // 
        // closeProjectToolStripMenuItem
        // 
        closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
        closeProjectToolStripMenuItem.Size = new Size(235, 22);
        closeProjectToolStripMenuItem.Text = "Close Project";
        closeProjectToolStripMenuItem.Click += closeProjectToolStripMenuItem_Click;
        // 
        // saveProjectToolStripMenuItem
        // 
        saveProjectToolStripMenuItem.Enabled = false;
        saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
        saveProjectToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
        saveProjectToolStripMenuItem.Size = new Size(235, 22);
        saveProjectToolStripMenuItem.Text = "Save Project";
        saveProjectToolStripMenuItem.Click += saveProjectToolStripMenuItem_Click;
        // 
        // saveProjectAsToolStripMenuItem
        // 
        saveProjectAsToolStripMenuItem.Enabled = false;
        saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
        saveProjectAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
        saveProjectAsToolStripMenuItem.Size = new Size(235, 22);
        saveProjectAsToolStripMenuItem.Text = "Save Project As...";
        saveProjectAsToolStripMenuItem.Click += saveProjectAsToolStripMenuItem_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(232, 6);
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { importUsageMapToolStripMenuItem, importCDLToolStripMenuItem, toolStripSeparator8, importTraceLogText });
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new Size(235, 22);
        toolStripMenuItem2.Text = "Import";
        // 
        // importUsageMapToolStripMenuItem
        // 
        importUsageMapToolStripMenuItem.Enabled = false;
        importUsageMapToolStripMenuItem.Name = "importUsageMapToolStripMenuItem";
        importUsageMapToolStripMenuItem.Size = new Size(218, 22);
        importUsageMapToolStripMenuItem.Text = "Import BSNES Usage Map...";
        importUsageMapToolStripMenuItem.Click += importUsageMapToolStripMenuItem_Click_1;
        // 
        // importCDLToolStripMenuItem
        // 
        importCDLToolStripMenuItem.Enabled = false;
        importCDLToolStripMenuItem.Name = "importCDLToolStripMenuItem";
        importCDLToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
        importCDLToolStripMenuItem.Size = new Size(218, 22);
        importCDLToolStripMenuItem.Text = "Import CDL...";
        importCDLToolStripMenuItem.Click += importCDLToolStripMenuItem_Click_1;
        // 
        // toolStripSeparator8
        // 
        toolStripSeparator8.Name = "toolStripSeparator8";
        toolStripSeparator8.Size = new Size(215, 6);
        // 
        // importTraceLogText
        // 
        importTraceLogText.Enabled = false;
        importTraceLogText.Name = "importTraceLogText";
        importTraceLogText.Size = new Size(218, 22);
        importTraceLogText.Text = "Import BSNES Trace Log...";
        importTraceLogText.Click += importBsnesTracelogText_Click;
        // 
        // exportToolStripMenuItem
        // 
        exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStrip_exportDisassemblyUseCurrentSettings, toolStrip_exportDisassemblyEditSettingsFirst, toolStripSeparator11, toolStrip_openExportDirectory });
        exportToolStripMenuItem.Name = "exportToolStripMenuItem";
        exportToolStripMenuItem.Size = new Size(235, 22);
        exportToolStripMenuItem.Text = "Export";
        // 
        // toolStrip_exportDisassemblyUseCurrentSettings
        // 
        toolStrip_exportDisassemblyUseCurrentSettings.Enabled = false;
        toolStrip_exportDisassemblyUseCurrentSettings.Name = "toolStrip_exportDisassemblyUseCurrentSettings";
        toolStrip_exportDisassemblyUseCurrentSettings.ShortcutKeys = Keys.Control | Keys.E;
        toolStrip_exportDisassemblyUseCurrentSettings.Size = new Size(341, 22);
        toolStrip_exportDisassemblyUseCurrentSettings.Text = "Export Disassembly (Use Current Settings)";
        toolStrip_exportDisassemblyUseCurrentSettings.Click += toolStrip_exportDisassemblyUseCurrentSettings_Click;
        // 
        // toolStrip_exportDisassemblyEditSettingsFirst
        // 
        toolStrip_exportDisassemblyEditSettingsFirst.Enabled = false;
        toolStrip_exportDisassemblyEditSettingsFirst.Name = "toolStrip_exportDisassemblyEditSettingsFirst";
        toolStrip_exportDisassemblyEditSettingsFirst.ShortcutKeys = Keys.Control | Keys.Shift | Keys.E;
        toolStrip_exportDisassemblyEditSettingsFirst.Size = new Size(341, 22);
        toolStrip_exportDisassemblyEditSettingsFirst.Text = "Export Disassemly (Edit Settings First)";
        toolStrip_exportDisassemblyEditSettingsFirst.Click += toolStrip_exportDisassemblyEditSettingsFirst_Click;
        // 
        // toolStripSeparator11
        // 
        toolStripSeparator11.Name = "toolStripSeparator11";
        toolStripSeparator11.Size = new Size(338, 6);
        // 
        // toolStrip_openExportDirectory
        // 
        toolStrip_openExportDirectory.Enabled = false;
        toolStrip_openExportDirectory.Name = "toolStrip_openExportDirectory";
        toolStrip_openExportDirectory.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
        toolStrip_openExportDirectory.Size = new Size(341, 22);
        toolStrip_openExportDirectory.Text = "Open Export Directory";
        toolStrip_openExportDirectory.Click += toolStrip_openExportDirectory_Click;
        // 
        // toolStripSeparator7
        // 
        toolStripSeparator7.Name = "toolStripSeparator7";
        toolStripSeparator7.Size = new Size(232, 6);
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
        exitToolStripMenuItem.Size = new Size(235, 22);
        exitToolStripMenuItem.Text = "Exit";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
        editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stepOverToolStripMenuItem, stepInToolStripMenuItem, toolStripSeparator2, autoStepSafeToolStripMenuItem, autoStepHarshToolStripMenuItem, toolStripSeparator3, markOneToolStripMenuItem, markManyToolStripMenuItem, toolStripSeparator5, addLabelToolStripMenuItem, setDataBankToolStripMenuItem, setDirectPageToolStripMenuItem, toggleAccumulatorSizeMToolStripMenuItem, toggleIndexSizeToolStripMenuItem, addCommentToolStripMenuItem, toolStripSeparator6, fixMisalignedInstructionsToolStripMenuItem, rescanForInOutPointsToolStripMenuItem });
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new Size(39, 20);
        editToolStripMenuItem.Text = "&Edit";
        // 
        // stepOverToolStripMenuItem
        // 
        stepOverToolStripMenuItem.Name = "stepOverToolStripMenuItem";
        stepOverToolStripMenuItem.ShortcutKeyDisplayString = "S";
        stepOverToolStripMenuItem.Size = new Size(271, 22);
        stepOverToolStripMenuItem.Text = "&Step";
        stepOverToolStripMenuItem.Click += stepOverToolStripMenuItem_Click;
        // 
        // stepInToolStripMenuItem
        // 
        stepInToolStripMenuItem.Name = "stepInToolStripMenuItem";
        stepInToolStripMenuItem.ShortcutKeyDisplayString = "I";
        stepInToolStripMenuItem.Size = new Size(271, 22);
        stepInToolStripMenuItem.Text = "Step &In";
        stepInToolStripMenuItem.Click += stepInToolStripMenuItem_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(268, 6);
        // 
        // autoStepSafeToolStripMenuItem
        // 
        autoStepSafeToolStripMenuItem.Name = "autoStepSafeToolStripMenuItem";
        autoStepSafeToolStripMenuItem.ShortcutKeyDisplayString = "A";
        autoStepSafeToolStripMenuItem.Size = new Size(271, 22);
        autoStepSafeToolStripMenuItem.Text = "&Auto Step (Safe)";
        autoStepSafeToolStripMenuItem.Click += autoStepSafeToolStripMenuItem_Click;
        // 
        // autoStepHarshToolStripMenuItem
        // 
        autoStepHarshToolStripMenuItem.Name = "autoStepHarshToolStripMenuItem";
        autoStepHarshToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.A;
        autoStepHarshToolStripMenuItem.Size = new Size(271, 22);
        autoStepHarshToolStripMenuItem.Text = "Auto Step (Harsh)";
        autoStepHarshToolStripMenuItem.Click += autoStepHarshToolStripMenuItem_Click;
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(268, 6);
        // 
        // markOneToolStripMenuItem
        // 
        markOneToolStripMenuItem.Name = "markOneToolStripMenuItem";
        markOneToolStripMenuItem.ShortcutKeyDisplayString = "K";
        markOneToolStripMenuItem.Size = new Size(271, 22);
        markOneToolStripMenuItem.Text = "Mar&k One";
        markOneToolStripMenuItem.Click += markOneToolStripMenuItem_Click;
        // 
        // markManyToolStripMenuItem
        // 
        markManyToolStripMenuItem.Name = "markManyToolStripMenuItem";
        markManyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.K;
        markManyToolStripMenuItem.Size = new Size(271, 22);
        markManyToolStripMenuItem.Text = "Mark Many...";
        markManyToolStripMenuItem.Click += markManyToolStripMenuItem_Click;
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(268, 6);
        // 
        // addLabelToolStripMenuItem
        // 
        addLabelToolStripMenuItem.Name = "addLabelToolStripMenuItem";
        addLabelToolStripMenuItem.ShortcutKeyDisplayString = "L";
        addLabelToolStripMenuItem.Size = new Size(271, 22);
        addLabelToolStripMenuItem.Text = "Add &Label";
        addLabelToolStripMenuItem.Click += addLabelToolStripMenuItem_Click;
        // 
        // setDataBankToolStripMenuItem
        // 
        setDataBankToolStripMenuItem.Name = "setDataBankToolStripMenuItem";
        setDataBankToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
        setDataBankToolStripMenuItem.Size = new Size(271, 22);
        setDataBankToolStripMenuItem.Text = "Set Data &Bank...";
        setDataBankToolStripMenuItem.Click += setDataBankToolStripMenuItem_Click;
        // 
        // setDirectPageToolStripMenuItem
        // 
        setDirectPageToolStripMenuItem.Name = "setDirectPageToolStripMenuItem";
        setDirectPageToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
        setDirectPageToolStripMenuItem.Size = new Size(271, 22);
        setDirectPageToolStripMenuItem.Text = "Set &Direct Page...";
        setDirectPageToolStripMenuItem.Click += setDirectPageToolStripMenuItem_Click;
        // 
        // toggleAccumulatorSizeMToolStripMenuItem
        // 
        toggleAccumulatorSizeMToolStripMenuItem.Name = "toggleAccumulatorSizeMToolStripMenuItem";
        toggleAccumulatorSizeMToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.M;
        toggleAccumulatorSizeMToolStripMenuItem.Size = new Size(271, 22);
        toggleAccumulatorSizeMToolStripMenuItem.Text = "Set Accu&mulator Size...";
        toggleAccumulatorSizeMToolStripMenuItem.Click += toggleAccumulatorSizeMToolStripMenuItem_Click;
        // 
        // toggleIndexSizeToolStripMenuItem
        // 
        toggleIndexSizeToolStripMenuItem.Name = "toggleIndexSizeToolStripMenuItem";
        toggleIndexSizeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.X;
        toggleIndexSizeToolStripMenuItem.Size = new Size(271, 22);
        toggleIndexSizeToolStripMenuItem.Text = "Set Inde&x Size...";
        toggleIndexSizeToolStripMenuItem.Click += toggleIndexSizeToolStripMenuItem_Click;
        // 
        // addCommentToolStripMenuItem
        // 
        addCommentToolStripMenuItem.Name = "addCommentToolStripMenuItem";
        addCommentToolStripMenuItem.ShortcutKeyDisplayString = "C";
        addCommentToolStripMenuItem.Size = new Size(271, 22);
        addCommentToolStripMenuItem.Text = "Add &Comment";
        addCommentToolStripMenuItem.Click += addCommentToolStripMenuItem_Click;
        // 
        // toolStripSeparator6
        // 
        toolStripSeparator6.Name = "toolStripSeparator6";
        toolStripSeparator6.Size = new Size(268, 6);
        // 
        // fixMisalignedInstructionsToolStripMenuItem
        // 
        fixMisalignedInstructionsToolStripMenuItem.Name = "fixMisalignedInstructionsToolStripMenuItem";
        fixMisalignedInstructionsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
        fixMisalignedInstructionsToolStripMenuItem.Size = new Size(271, 22);
        fixMisalignedInstructionsToolStripMenuItem.Text = "Fix Misaligned Flags...";
        fixMisalignedInstructionsToolStripMenuItem.Click += fixMisalignedInstructionsToolStripMenuItem_Click;
        // 
        // rescanForInOutPointsToolStripMenuItem
        // 
        rescanForInOutPointsToolStripMenuItem.Name = "rescanForInOutPointsToolStripMenuItem";
        rescanForInOutPointsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
        rescanForInOutPointsToolStripMenuItem.Size = new Size(271, 22);
        rescanForInOutPointsToolStripMenuItem.Text = "Rescan for In/Out Points...";
        rescanForInOutPointsToolStripMenuItem.Click += rescanForInOutPointsToolStripMenuItem_Click;
        // 
        // navigateToolStripMenuItem
        // 
        navigateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showHistoryToolStripMenuItem, toolStripSeparator9, goBackToolStripMenuItem, goForwardToolStripMenuItem, toolStripSeparator10, gotoToolStripMenuItem, gotoIntermediateAddressToolStripMenuItem, gotoFirstUnreachedToolStripMenuItem, gotoNearUnreachedToolStripMenuItem, gotoNextUnreachedToolStripMenuItem, gotoNextUnreachedInPointToolStripMenuItem });
        navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
        navigateToolStripMenuItem.Size = new Size(66, 20);
        navigateToolStripMenuItem.Text = "&Navigate";
        // 
        // showHistoryToolStripMenuItem
        // 
        showHistoryToolStripMenuItem.Name = "showHistoryToolStripMenuItem";
        showHistoryToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.H;
        showHistoryToolStripMenuItem.Size = new Size(278, 22);
        showHistoryToolStripMenuItem.Text = "Show History";
        showHistoryToolStripMenuItem.Click += showHistoryToolStripMenuItem_Click;
        // 
        // toolStripSeparator9
        // 
        toolStripSeparator9.Name = "toolStripSeparator9";
        toolStripSeparator9.Size = new Size(275, 6);
        // 
        // goBackToolStripMenuItem
        // 
        goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
        goBackToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Left;
        goBackToolStripMenuItem.Size = new Size(278, 22);
        goBackToolStripMenuItem.Text = "Go Back";
        goBackToolStripMenuItem.Click += goBackToolStripMenuItem_Click;
        // 
        // goForwardToolStripMenuItem
        // 
        goForwardToolStripMenuItem.Name = "goForwardToolStripMenuItem";
        goForwardToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Right;
        goForwardToolStripMenuItem.Size = new Size(278, 22);
        goForwardToolStripMenuItem.Text = "Go Forward";
        goForwardToolStripMenuItem.Click += goForwardToolStripMenuItem_Click;
        // 
        // toolStripSeparator10
        // 
        toolStripSeparator10.Name = "toolStripSeparator10";
        toolStripSeparator10.Size = new Size(275, 6);
        // 
        // gotoToolStripMenuItem
        // 
        gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
        gotoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
        gotoToolStripMenuItem.Size = new Size(278, 22);
        gotoToolStripMenuItem.Text = "Goto...";
        gotoToolStripMenuItem.Click += gotoToolStripMenuItem_Click;
        // 
        // gotoIntermediateAddressToolStripMenuItem
        // 
        gotoIntermediateAddressToolStripMenuItem.Name = "gotoIntermediateAddressToolStripMenuItem";
        gotoIntermediateAddressToolStripMenuItem.ShortcutKeyDisplayString = "T";
        gotoIntermediateAddressToolStripMenuItem.Size = new Size(278, 22);
        gotoIntermediateAddressToolStripMenuItem.Text = "Goto In&termediate Address";
        gotoIntermediateAddressToolStripMenuItem.Click += gotoIntermediateAddressToolStripMenuItem_Click;
        // 
        // gotoFirstUnreachedToolStripMenuItem
        // 
        gotoFirstUnreachedToolStripMenuItem.Name = "gotoFirstUnreachedToolStripMenuItem";
        gotoFirstUnreachedToolStripMenuItem.ShortcutKeyDisplayString = "U";
        gotoFirstUnreachedToolStripMenuItem.Size = new Size(278, 22);
        gotoFirstUnreachedToolStripMenuItem.Text = "Goto First &Unreached Boundary";
        gotoFirstUnreachedToolStripMenuItem.Click += gotoFirstUnreachedToolStripMenuItem_Click;
        // 
        // gotoNearUnreachedToolStripMenuItem
        // 
        gotoNearUnreachedToolStripMenuItem.Name = "gotoNearUnreachedToolStripMenuItem";
        gotoNearUnreachedToolStripMenuItem.ShortcutKeyDisplayString = "H";
        gotoNearUnreachedToolStripMenuItem.Size = new Size(278, 22);
        gotoNearUnreachedToolStripMenuItem.Text = "Goto Previous Unreac&hed Boundary";
        gotoNearUnreachedToolStripMenuItem.Click += gotoNearUnreachedToolStripMenuItem_Click;
        // 
        // gotoNextUnreachedToolStripMenuItem
        // 
        gotoNextUnreachedToolStripMenuItem.Name = "gotoNextUnreachedToolStripMenuItem";
        gotoNextUnreachedToolStripMenuItem.ShortcutKeyDisplayString = "N";
        gotoNextUnreachedToolStripMenuItem.Size = new Size(278, 22);
        gotoNextUnreachedToolStripMenuItem.Text = "Goto &Next Unreached Boundary";
        gotoNextUnreachedToolStripMenuItem.Click += gotoNextUnreachedToolStripMenuItem_Click;
        // 
        // gotoNextUnreachedInPointToolStripMenuItem
        // 
        gotoNextUnreachedInPointToolStripMenuItem.Name = "gotoNextUnreachedInPointToolStripMenuItem";
        gotoNextUnreachedInPointToolStripMenuItem.ShortcutKeyDisplayString = "F3";
        gotoNextUnreachedInPointToolStripMenuItem.Size = new Size(278, 22);
        gotoNextUnreachedInPointToolStripMenuItem.Text = "Find Next Unreached Branch Point";
        gotoNextUnreachedInPointToolStripMenuItem.Click += gotoNextUnreachedInPointToolStripMenuItem_Click;
        // 
        // selectMarkerToolStripMenuItem
        // 
        selectMarkerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unreachedToolStripMenuItem, opcodeToolStripMenuItem, operandToolStripMenuItem, bitDataToolStripMenuItem, graphicsToolStripMenuItem, musicToolStripMenuItem, emptyToolStripMenuItem, bitDataToolStripMenuItem1, wordPointerToolStripMenuItem, bitDataToolStripMenuItem2, longPointerToolStripMenuItem, bitDataToolStripMenuItem3, dWordPointerToolStripMenuItem, textToolStripMenuItem });
        selectMarkerToolStripMenuItem.Name = "selectMarkerToolStripMenuItem";
        selectMarkerToolStripMenuItem.Size = new Size(90, 20);
        selectMarkerToolStripMenuItem.Text = "Select &Marker";
        // 
        // unreachedToolStripMenuItem
        // 
        unreachedToolStripMenuItem.Name = "unreachedToolStripMenuItem";
        unreachedToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.U;
        unreachedToolStripMenuItem.Size = new Size(205, 22);
        unreachedToolStripMenuItem.Text = "Unreached";
        unreachedToolStripMenuItem.Click += unreachedToolStripMenuItem_Click;
        // 
        // opcodeToolStripMenuItem
        // 
        opcodeToolStripMenuItem.Name = "opcodeToolStripMenuItem";
        opcodeToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.O;
        opcodeToolStripMenuItem.Size = new Size(205, 22);
        opcodeToolStripMenuItem.Text = "Opcode";
        opcodeToolStripMenuItem.Click += opcodeToolStripMenuItem_Click;
        // 
        // operandToolStripMenuItem
        // 
        operandToolStripMenuItem.Name = "operandToolStripMenuItem";
        operandToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.P;
        operandToolStripMenuItem.Size = new Size(205, 22);
        operandToolStripMenuItem.Text = "Operand";
        operandToolStripMenuItem.Click += operandToolStripMenuItem_Click;
        // 
        // bitDataToolStripMenuItem
        // 
        bitDataToolStripMenuItem.Name = "bitDataToolStripMenuItem";
        bitDataToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D1;
        bitDataToolStripMenuItem.Size = new Size(205, 22);
        bitDataToolStripMenuItem.Text = "8-Bit Data";
        bitDataToolStripMenuItem.Click += bitDataToolStripMenuItem_Click;
        // 
        // graphicsToolStripMenuItem
        // 
        graphicsToolStripMenuItem.Name = "graphicsToolStripMenuItem";
        graphicsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.G;
        graphicsToolStripMenuItem.Size = new Size(205, 22);
        graphicsToolStripMenuItem.Text = "     Graphics";
        graphicsToolStripMenuItem.Click += graphicsToolStripMenuItem_Click;
        // 
        // musicToolStripMenuItem
        // 
        musicToolStripMenuItem.Name = "musicToolStripMenuItem";
        musicToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.M;
        musicToolStripMenuItem.Size = new Size(205, 22);
        musicToolStripMenuItem.Text = "     Music";
        musicToolStripMenuItem.Click += musicToolStripMenuItem_Click;
        // 
        // emptyToolStripMenuItem
        // 
        emptyToolStripMenuItem.Name = "emptyToolStripMenuItem";
        emptyToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.E;
        emptyToolStripMenuItem.Size = new Size(205, 22);
        emptyToolStripMenuItem.Text = "     Empty";
        emptyToolStripMenuItem.Click += emptyToolStripMenuItem_Click;
        // 
        // bitDataToolStripMenuItem1
        // 
        bitDataToolStripMenuItem1.Name = "bitDataToolStripMenuItem1";
        bitDataToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.D2;
        bitDataToolStripMenuItem1.Size = new Size(205, 22);
        bitDataToolStripMenuItem1.Text = "16-Bit Data";
        bitDataToolStripMenuItem1.Click += bitDataToolStripMenuItem1_Click;
        // 
        // wordPointerToolStripMenuItem
        // 
        wordPointerToolStripMenuItem.Name = "wordPointerToolStripMenuItem";
        wordPointerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.W;
        wordPointerToolStripMenuItem.Size = new Size(205, 22);
        wordPointerToolStripMenuItem.Text = "     Word Pointer";
        wordPointerToolStripMenuItem.Click += wordPointerToolStripMenuItem_Click;
        // 
        // bitDataToolStripMenuItem2
        // 
        bitDataToolStripMenuItem2.Name = "bitDataToolStripMenuItem2";
        bitDataToolStripMenuItem2.ShortcutKeys = Keys.Alt | Keys.D3;
        bitDataToolStripMenuItem2.Size = new Size(205, 22);
        bitDataToolStripMenuItem2.Text = "24-Bit Data";
        bitDataToolStripMenuItem2.Click += bitDataToolStripMenuItem2_Click;
        // 
        // longPointerToolStripMenuItem
        // 
        longPointerToolStripMenuItem.Name = "longPointerToolStripMenuItem";
        longPointerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.L;
        longPointerToolStripMenuItem.Size = new Size(205, 22);
        longPointerToolStripMenuItem.Text = "     Long Pointer";
        longPointerToolStripMenuItem.Click += longPointerToolStripMenuItem_Click;
        // 
        // bitDataToolStripMenuItem3
        // 
        bitDataToolStripMenuItem3.Name = "bitDataToolStripMenuItem3";
        bitDataToolStripMenuItem3.ShortcutKeys = Keys.Alt | Keys.D4;
        bitDataToolStripMenuItem3.Size = new Size(205, 22);
        bitDataToolStripMenuItem3.Text = "32-Bit Data";
        bitDataToolStripMenuItem3.Click += bitDataToolStripMenuItem3_Click;
        // 
        // dWordPointerToolStripMenuItem
        // 
        dWordPointerToolStripMenuItem.Name = "dWordPointerToolStripMenuItem";
        dWordPointerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D;
        dWordPointerToolStripMenuItem.Size = new Size(205, 22);
        dWordPointerToolStripMenuItem.Text = "     DWord Pointer";
        dWordPointerToolStripMenuItem.Click += dWordPointerToolStripMenuItem_Click;
        // 
        // textToolStripMenuItem
        // 
        textToolStripMenuItem.Name = "textToolStripMenuItem";
        textToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.T;
        textToolStripMenuItem.Size = new Size(205, 22);
        textToolStripMenuItem.Text = "Text";
        textToolStripMenuItem.Click += textToolStripMenuItem_Click;
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualMapToolStripMenuItem, graphicsWindowToolStripMenuItem, constantsToolStripMenuItem, optionsToolStripMenuItem, projectSettingsToolStripMenuItem, importCaptureToolStripMenuItem });
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        viewToolStripMenuItem.Size = new Size(47, 20);
        viewToolStripMenuItem.Text = "&Tools";
        // 
        // visualMapToolStripMenuItem
        // 
        visualMapToolStripMenuItem.Name = "visualMapToolStripMenuItem";
        visualMapToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F3;
        visualMapToolStripMenuItem.Size = new Size(213, 22);
        visualMapToolStripMenuItem.Text = "Visual Map";
        visualMapToolStripMenuItem.Click += visualMapToolStripMenuItem_Click;
        // 
        // graphicsWindowToolStripMenuItem
        // 
        graphicsWindowToolStripMenuItem.Enabled = false;
        graphicsWindowToolStripMenuItem.Name = "graphicsWindowToolStripMenuItem";
        graphicsWindowToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F2;
        graphicsWindowToolStripMenuItem.Size = new Size(213, 22);
        graphicsWindowToolStripMenuItem.Text = "Graphics Window";
        graphicsWindowToolStripMenuItem.Click += graphicsWindowToolStripMenuItem_Click;
        // 
        // constantsToolStripMenuItem
        // 
        constantsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { decimalToolStripMenuItem, hexadecimalToolStripMenuItem, binaryToolStripMenuItem });
        constantsToolStripMenuItem.Name = "constantsToolStripMenuItem";
        constantsToolStripMenuItem.Size = new Size(213, 22);
        constantsToolStripMenuItem.Text = "Constants";
        // 
        // decimalToolStripMenuItem
        // 
        decimalToolStripMenuItem.Name = "decimalToolStripMenuItem";
        decimalToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
        decimalToolStripMenuItem.Size = new Size(181, 22);
        decimalToolStripMenuItem.Text = "Decimal";
        decimalToolStripMenuItem.Click += decimalToolStripMenuItem_Click;
        // 
        // hexadecimalToolStripMenuItem
        // 
        hexadecimalToolStripMenuItem.Checked = true;
        hexadecimalToolStripMenuItem.CheckState = CheckState.Checked;
        hexadecimalToolStripMenuItem.Name = "hexadecimalToolStripMenuItem";
        hexadecimalToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.H;
        hexadecimalToolStripMenuItem.Size = new Size(181, 22);
        hexadecimalToolStripMenuItem.Text = "Hexadecimal";
        hexadecimalToolStripMenuItem.Click += hexadecimalToolStripMenuItem_Click;
        // 
        // binaryToolStripMenuItem
        // 
        binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
        binaryToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.B;
        binaryToolStripMenuItem.Size = new Size(181, 22);
        binaryToolStripMenuItem.Text = "Binary";
        binaryToolStripMenuItem.Click += binaryToolStripMenuItem_Click;
        // 
        // optionsToolStripMenuItem
        // 
        optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { moveWithStepToolStripMenuItem, openLastProjectAutomaticallyToolStripMenuItem });
        optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        optionsToolStripMenuItem.Size = new Size(213, 22);
        optionsToolStripMenuItem.Text = "Options";
        // 
        // moveWithStepToolStripMenuItem
        // 
        moveWithStepToolStripMenuItem.Checked = true;
        moveWithStepToolStripMenuItem.CheckState = CheckState.Checked;
        moveWithStepToolStripMenuItem.Name = "moveWithStepToolStripMenuItem";
        moveWithStepToolStripMenuItem.Size = new Size(244, 22);
        moveWithStepToolStripMenuItem.Text = "Move With Step";
        moveWithStepToolStripMenuItem.Click += moveWithStepToolStripMenuItem_Click;
        // 
        // openLastProjectAutomaticallyToolStripMenuItem
        // 
        openLastProjectAutomaticallyToolStripMenuItem.Name = "openLastProjectAutomaticallyToolStripMenuItem";
        openLastProjectAutomaticallyToolStripMenuItem.Size = new Size(244, 22);
        openLastProjectAutomaticallyToolStripMenuItem.Text = "Open Last Project Automatically";
        openLastProjectAutomaticallyToolStripMenuItem.Click += openLastProjectAutomaticallyToolStripMenuItem_Click;
        // 
        // projectSettingsToolStripMenuItem
        // 
        projectSettingsToolStripMenuItem.Enabled = false;
        projectSettingsToolStripMenuItem.Name = "projectSettingsToolStripMenuItem";
        projectSettingsToolStripMenuItem.Size = new Size(213, 22);
        projectSettingsToolStripMenuItem.Text = "Project Settings";
        projectSettingsToolStripMenuItem.Click += projectSettingsToolStripMenuItem_Click;
        // 
        // importCaptureToolStripMenuItem
        // 
        importCaptureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importTraceLogBinary });
        importCaptureToolStripMenuItem.Name = "importCaptureToolStripMenuItem";
        importCaptureToolStripMenuItem.Size = new Size(213, 22);
        importCaptureToolStripMenuItem.Text = "Live Capture";
        // 
        // importTraceLogBinary
        // 
        importTraceLogBinary.Enabled = false;
        importTraceLogBinary.Name = "importTraceLogBinary";
        importTraceLogBinary.ShortcutKeys = Keys.Control | Keys.F5;
        importTraceLogBinary.Size = new Size(285, 22);
        importTraceLogBinary.Text = "Emulator Live Tracelog Capture";
        importTraceLogBinary.Click += importTraceLogBinary_Click;
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewHelpToolStripMenuItem, githubToolStripMenuItem, aboutToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new Size(44, 20);
        helpToolStripMenuItem.Text = "&Help";
        // 
        // viewHelpToolStripMenuItem
        // 
        viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
        viewHelpToolStripMenuItem.ShortcutKeys = Keys.F1;
        viewHelpToolStripMenuItem.Size = new Size(146, 22);
        viewHelpToolStripMenuItem.Text = "View Help";
        viewHelpToolStripMenuItem.Click += viewHelpToolStripMenuItem_Click;
        // 
        // githubToolStripMenuItem
        // 
        githubToolStripMenuItem.Name = "githubToolStripMenuItem";
        githubToolStripMenuItem.Size = new Size(146, 22);
        githubToolStripMenuItem.Text = "Github";
        githubToolStripMenuItem.Click += githubToolStripMenuItem_Click;
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new Size(146, 22);
        aboutToolStripMenuItem.Text = "About";
        aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new Size(20, 20);
        statusStrip1.Items.AddRange(new ToolStripItem[] { percentComplete, seperator1, currentMarker });
        statusStrip1.Location = new Point(0, 516);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Padding = new Padding(1, 0, 15, 0);
        statusStrip1.Size = new Size(930, 22);
        statusStrip1.TabIndex = 3;
        statusStrip1.Text = "statusStrip1";
        // 
        // percentComplete
        // 
        percentComplete.Name = "percentComplete";
        percentComplete.RightToLeft = RightToLeft.No;
        percentComplete.Size = new Size(72, 17);
        percentComplete.Text = "0.000% (0/0)";
        // 
        // seperator1
        // 
        seperator1.Name = "seperator1";
        seperator1.Size = new Size(10, 17);
        seperator1.Text = "|";
        // 
        // currentMarker
        // 
        currentMarker.Name = "currentMarker";
        currentMarker.Size = new Size(110, 17);
        currentMarker.Text = "Marker: Data (8-bit)";
        // 
        // openFileDialog
        // 
        openFileDialog.Filter = "SNES ROM Images|*.smc;*.sfc|All files|*.*";
        // 
        // openProjectFile
        // 
        openProjectFile.Filter = "DiztinGUIsh Project Files|*.diz;*.dizraw;*.dizdir|All Files|*.*";
        // 
        // saveProjectFile
        // 
        saveProjectFile.Filter = "DiztinGUIsh Project Files|*.diz;*.dizraw;*.dizdir|All Files|*.*";
        saveProjectFile.Title = "New Project.diz";
        // 
        // vScrollBar1
        // 
        vScrollBar1.Enabled = false;
        vScrollBar1.Location = new Point(913, 24);
        vScrollBar1.Maximum = 32768;
        vScrollBar1.Name = "vScrollBar1";
        vScrollBar1.Size = new Size(17, 492);
        vScrollBar1.TabIndex = 2;
        vScrollBar1.ValueChanged += vScrollBar1_ValueChanged;
        // 
        // openUsageMapFile
        // 
        openUsageMapFile.Filter = "bsnes-plus usage map files|*.bin";
        // 
        // openTraceLogDialog
        // 
        openTraceLogDialog.Filter = "bsnes-plus trace log|*.log";
        // 
        // openCDLDialog
        // 
        openCDLDialog.Filter = "BizHawk Code Data Logger Files|*.cdl|All Files|*.*";
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Interval = 2000;
        timer1.Tick += timer1_Tick;
        // 
        // timerLifeCaptureUpdate
        // 
        timerLifeCaptureUpdate.Interval = 1000;
        timerLifeCaptureUpdate.Tick += timerLifeCaptureUpdate_Tick;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(930, 538);
        Controls.Add(vScrollBar1);
        Controls.Add(statusStrip1);
        Controls.Add(table);
        Controls.Add(menuStrip1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip1;
        MinimumSize = new Size(780, 196);
        Name = "MainWindow";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "DiztinGUIsh";
        FormClosing += MainWindow_FormClosing;
        Load += MainWindow_Load;
        ResizeEnd += MainWindow_ResizeEnd;
        SizeChanged += MainWindow_SizeChanged;
        DragDrop += MainWindow_DragDrop;
        DragEnter += MainWindow_DragEnter;
        ((System.ComponentModel.ISupportInitialize)table).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView table;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveProjectAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem stepOverToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem stepInToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem autoStepSafeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem autoStepHarshToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem markOneToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem markManyToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem setDirectPageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem setDataBankToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toggleAccumulatorSizeMToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem visualMapToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem graphicsWindowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem constantsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem decimalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hexadecimalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addLabelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toggleIndexSizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addCommentToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripMenuItem fixMisalignedInstructionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel percentComplete;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.OpenFileDialog openProjectFile;
    private System.Windows.Forms.SaveFileDialog saveProjectFile;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.VScrollBar vScrollBar1;
    private System.Windows.Forms.ToolStripStatusLabel seperator1;
    private System.Windows.Forms.ToolStripStatusLabel currentMarker;
    private System.Windows.Forms.ToolStripMenuItem rescanForInOutPointsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem moveWithStepToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openUsageMapFile;
    public System.Windows.Forms.OpenFileDialog openTraceLogDialog;
    private System.Windows.Forms.ToolStripMenuItem projectSettingsToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openCDLDialog;
    private System.Windows.Forms.ToolStripMenuItem toolStripOpenLast;
    private System.Windows.Forms.ToolStripMenuItem openLastProjectAutomaticallyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem importUsageMapToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem importCDLToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripMenuItem importTraceLogText;
    private System.Windows.Forms.ToolStripMenuItem importCaptureToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem importTraceLogBinary;
    private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAlias;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPC;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChar;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHex;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPoints;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInstruction;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIA;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlag;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDB;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDP;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnM;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComment;
    private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showHistoryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem goForwardToolStripMenuItem;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gotoIntermediateAddressToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gotoFirstUnreachedToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gotoNearUnreachedToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gotoNextUnreachedToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gotoNextUnreachedInPointToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem selectMarkerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem unreachedToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem opcodeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem operandToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bitDataToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem graphicsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem emptyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bitDataToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem wordPointerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bitDataToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem longPointerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bitDataToolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem dWordPointerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStrip_exportDisassemblyUseCurrentSettings;
    private System.Windows.Forms.ToolStripMenuItem toolStrip_exportDisassemblyEditSettingsFirst;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
    private System.Windows.Forms.ToolStripMenuItem toolStrip_openExportDirectory;
    private System.Windows.Forms.Timer timerLifeCaptureUpdate;
}