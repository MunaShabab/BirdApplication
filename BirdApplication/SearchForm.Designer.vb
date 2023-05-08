<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchForm))
        Me.gbOption = New System.Windows.Forms.GroupBox()
        Me.rbMonth = New System.Windows.Forms.RadioButton()
        Me.rbLocation = New System.Windows.Forms.RadioButton()
        Me.rbName = New System.Windows.Forms.RadioButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BirdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SightingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBirdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BirdDBDataSet = New BirdApplication.BirdDBDataSet()
        Me.FillByBirdNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Bird_NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Bird_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByBirdNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByLocationToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LocationToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.LocationToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByLocationToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.T_BirdTableAdapter = New BirdApplication.BirdDBDataSetTableAdapters.T_BirdTableAdapter()
        Me.FillByMonthToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MonthToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MonthToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByMonthToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordASightingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.pddPrintDialog = New System.Windows.Forms.PrintDialog()
        Me.BirdNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.BirdNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByLikeNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByLikeNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.gbOption.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBirdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirdDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByBirdNameToolStrip.SuspendLayout()
        Me.FillByLocationToolStrip.SuspendLayout()
        Me.FillByMonthToolStrip.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.FillByLikeNameToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbOption
        '
        Me.gbOption.Controls.Add(Me.rbMonth)
        Me.gbOption.Controls.Add(Me.rbLocation)
        Me.gbOption.Controls.Add(Me.rbName)
        Me.gbOption.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOption.Location = New System.Drawing.Point(56, 66)
        Me.gbOption.Name = "gbOption"
        Me.gbOption.Size = New System.Drawing.Size(293, 232)
        Me.gbOption.TabIndex = 1
        Me.gbOption.TabStop = False
        Me.gbOption.Text = "Search By:"
        '
        'rbMonth
        '
        Me.rbMonth.AutoSize = True
        Me.rbMonth.Location = New System.Drawing.Point(49, 155)
        Me.rbMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbMonth.Name = "rbMonth"
        Me.rbMonth.Size = New System.Drawing.Size(133, 44)
        Me.rbMonth.TabIndex = 2
        Me.rbMonth.TabStop = True
        Me.rbMonth.Text = "Month"
        Me.rbMonth.UseVisualStyleBackColor = True
        '
        'rbLocation
        '
        Me.rbLocation.AutoSize = True
        Me.rbLocation.Location = New System.Drawing.Point(49, 105)
        Me.rbLocation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbLocation.Name = "rbLocation"
        Me.rbLocation.Size = New System.Drawing.Size(157, 44)
        Me.rbLocation.TabIndex = 1
        Me.rbLocation.TabStop = True
        Me.rbLocation.Text = "Location"
        Me.rbLocation.UseVisualStyleBackColor = True
        '
        'rbName
        '
        Me.rbName.AutoSize = True
        Me.rbName.Location = New System.Drawing.Point(49, 48)
        Me.rbName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbName.Name = "rbName"
        Me.rbName.Size = New System.Drawing.Size(184, 44)
        Me.rbName.TabIndex = 0
        Me.rbName.TabStop = True
        Me.rbName.Text = "Bird Name"
        Me.rbName.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(385, 80)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(205, 46)
        Me.txtSearch.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(385, 147)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(204, 66)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BirdNameDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.SightingDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBirdBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(75, 313)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(488, 144)
        Me.DataGridView1.TabIndex = 4
        Me.DataGridView1.Visible = False
        '
        'BirdNameDataGridViewTextBoxColumn
        '
        Me.BirdNameDataGridViewTextBoxColumn.DataPropertyName = "Bird_Name"
        Me.BirdNameDataGridViewTextBoxColumn.HeaderText = "Bird_Name"
        Me.BirdNameDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.BirdNameDataGridViewTextBoxColumn.Name = "BirdNameDataGridViewTextBoxColumn"
        Me.BirdNameDataGridViewTextBoxColumn.Width = 163
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.Width = 139
        '
        'SightingDateDataGridViewTextBoxColumn
        '
        Me.SightingDateDataGridViewTextBoxColumn.DataPropertyName = "Sighting_Date"
        Me.SightingDateDataGridViewTextBoxColumn.HeaderText = "Sighting_Date"
        Me.SightingDateDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.SightingDateDataGridViewTextBoxColumn.Name = "SightingDateDataGridViewTextBoxColumn"
        Me.SightingDateDataGridViewTextBoxColumn.Width = 192
        '
        'TBirdBindingSource
        '
        Me.TBirdBindingSource.DataMember = "T_Bird"
        Me.TBirdBindingSource.DataSource = Me.BirdDBDataSet
        '
        'BirdDBDataSet
        '
        Me.BirdDBDataSet.DataSetName = "BirdDBDataSet"
        Me.BirdDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FillByBirdNameToolStrip
        '
        Me.FillByBirdNameToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FillByBirdNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bird_NameToolStripLabel, Me.Bird_NameToolStripTextBox, Me.FillByBirdNameToolStripButton})
        Me.FillByBirdNameToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByBirdNameToolStrip.Name = "FillByBirdNameToolStrip"
        Me.FillByBirdNameToolStrip.Size = New System.Drawing.Size(707, 42)
        Me.FillByBirdNameToolStrip.TabIndex = 5
        Me.FillByBirdNameToolStrip.Text = "FillByBirdNameToolStrip"
        Me.FillByBirdNameToolStrip.Visible = False
        '
        'Bird_NameToolStripLabel
        '
        Me.Bird_NameToolStripLabel.Name = "Bird_NameToolStripLabel"
        Me.Bird_NameToolStripLabel.Size = New System.Drawing.Size(136, 36)
        Me.Bird_NameToolStripLabel.Text = "Bird_Name:"
        '
        'Bird_NameToolStripTextBox
        '
        Me.Bird_NameToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bird_NameToolStripTextBox.Name = "Bird_NameToolStripTextBox"
        Me.Bird_NameToolStripTextBox.Size = New System.Drawing.Size(100, 42)
        '
        'FillByBirdNameToolStripButton
        '
        Me.FillByBirdNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByBirdNameToolStripButton.Name = "FillByBirdNameToolStripButton"
        Me.FillByBirdNameToolStripButton.Size = New System.Drawing.Size(181, 36)
        Me.FillByBirdNameToolStripButton.Text = "FillByBirdName"
        '
        'FillByLocationToolStrip
        '
        Me.FillByLocationToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FillByLocationToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocationToolStripLabel, Me.LocationToolStripTextBox, Me.FillByLocationToolStripButton})
        Me.FillByLocationToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByLocationToolStrip.Name = "FillByLocationToolStrip"
        Me.FillByLocationToolStrip.Size = New System.Drawing.Size(867, 42)
        Me.FillByLocationToolStrip.TabIndex = 6
        Me.FillByLocationToolStrip.Text = "FillByLocationToolStrip"
        Me.FillByLocationToolStrip.Visible = False
        '
        'LocationToolStripLabel
        '
        Me.LocationToolStripLabel.Name = "LocationToolStripLabel"
        Me.LocationToolStripLabel.Size = New System.Drawing.Size(110, 36)
        Me.LocationToolStripLabel.Text = "Location:"
        '
        'LocationToolStripTextBox
        '
        Me.LocationToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LocationToolStripTextBox.Name = "LocationToolStripTextBox"
        Me.LocationToolStripTextBox.Size = New System.Drawing.Size(100, 42)
        '
        'FillByLocationToolStripButton
        '
        Me.FillByLocationToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByLocationToolStripButton.Name = "FillByLocationToolStripButton"
        Me.FillByLocationToolStripButton.Size = New System.Drawing.Size(165, 36)
        Me.FillByLocationToolStripButton.Text = "FillByLocation"
        '
        'T_BirdTableAdapter
        '
        Me.T_BirdTableAdapter.ClearBeforeFill = True
        '
        'FillByMonthToolStrip
        '
        Me.FillByMonthToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FillByMonthToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthToolStripLabel, Me.MonthToolStripTextBox, Me.FillByMonthToolStripButton})
        Me.FillByMonthToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByMonthToolStrip.Name = "FillByMonthToolStrip"
        Me.FillByMonthToolStrip.Size = New System.Drawing.Size(707, 42)
        Me.FillByMonthToolStrip.TabIndex = 7
        Me.FillByMonthToolStrip.Text = "FillByMonthToolStrip"
        Me.FillByMonthToolStrip.Visible = False
        '
        'MonthToolStripLabel
        '
        Me.MonthToolStripLabel.Name = "MonthToolStripLabel"
        Me.MonthToolStripLabel.Size = New System.Drawing.Size(91, 36)
        Me.MonthToolStripLabel.Text = "month:"
        '
        'MonthToolStripTextBox
        '
        Me.MonthToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MonthToolStripTextBox.Name = "MonthToolStripTextBox"
        Me.MonthToolStripTextBox.Size = New System.Drawing.Size(100, 42)
        '
        'FillByMonthToolStripButton
        '
        Me.FillByMonthToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByMonthToolStripButton.Name = "FillByMonthToolStripButton"
        Me.FillByMonthToolStripButton.Size = New System.Drawing.Size(147, 36)
        Me.FillByMonthToolStripButton.Text = "FillByMonth"
        '
        'btnViewAll
        '
        Me.btnViewAll.FlatAppearance.BorderSize = 0
        Me.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAll.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.Location = New System.Drawing.Point(386, 221)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(204, 66)
        Me.btnViewAll.TabIndex = 9
        Me.btnViewAll.Text = "View All"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RecordToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(640, 40)
        Me.MenuStrip2.TabIndex = 10
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.mnuPrintPreview, Me.mnuPrint, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(287, 44)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'mnuPrintPreview
        '
        Me.mnuPrintPreview.Enabled = False
        Me.mnuPrintPreview.Name = "mnuPrintPreview"
        Me.mnuPrintPreview.Size = New System.Drawing.Size(287, 44)
        Me.mnuPrintPreview.Text = "Print Preview"
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(287, 44)
        Me.mnuPrint.Text = "Print "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(284, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(287, 44)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'RecordToolStripMenuItem
        '
        Me.RecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordASightingToolStripMenuItem})
        Me.RecordToolStripMenuItem.Name = "RecordToolStripMenuItem"
        Me.RecordToolStripMenuItem.Size = New System.Drawing.Size(108, 36)
        Me.RecordToolStripMenuItem.Text = "Record"
        '
        'RecordASightingToolStripMenuItem
        '
        Me.RecordASightingToolStripMenuItem.Name = "RecordASightingToolStripMenuItem"
        Me.RecordASightingToolStripMenuItem.Size = New System.Drawing.Size(340, 44)
        Me.RecordASightingToolStripMenuItem.Text = "Record A Sighting"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutSearchToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(85, 36)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'AboutSearchToolStripMenuItem
        '
        Me.AboutSearchToolStripMenuItem.Name = "AboutSearchToolStripMenuItem"
        Me.AboutSearchToolStripMenuItem.Size = New System.Drawing.Size(292, 44)
        Me.AboutSearchToolStripMenuItem.Text = "About Search"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'pddPrintDialog
        '
        Me.pddPrintDialog.UseEXDialog = True
        '
        'BirdNameToolStripLabel
        '
        Me.BirdNameToolStripLabel.Name = "BirdNameToolStripLabel"
        Me.BirdNameToolStripLabel.Size = New System.Drawing.Size(126, 36)
        Me.BirdNameToolStripLabel.Text = "BirdName:"
        '
        'BirdNameToolStripTextBox
        '
        Me.BirdNameToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BirdNameToolStripTextBox.Name = "BirdNameToolStripTextBox"
        Me.BirdNameToolStripTextBox.Size = New System.Drawing.Size(100, 42)
        '
        'FillByLikeNameToolStripButton
        '
        Me.FillByLikeNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByLikeNameToolStripButton.Name = "FillByLikeNameToolStripButton"
        Me.FillByLikeNameToolStripButton.Size = New System.Drawing.Size(181, 36)
        Me.FillByLikeNameToolStripButton.Text = "FillByLikeName"
        '
        'FillByLikeNameToolStrip
        '
        Me.FillByLikeNameToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FillByLikeNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BirdNameToolStripLabel, Me.BirdNameToolStripTextBox, Me.FillByLikeNameToolStripButton})
        Me.FillByLikeNameToolStrip.Location = New System.Drawing.Point(0, 40)
        Me.FillByLikeNameToolStrip.Name = "FillByLikeNameToolStrip"
        Me.FillByLikeNameToolStrip.Size = New System.Drawing.Size(640, 42)
        Me.FillByLikeNameToolStrip.TabIndex = 11
        Me.FillByLikeNameToolStrip.Text = "FillByLikeNameToolStrip"
        Me.FillByLikeNameToolStrip.Visible = False
        '
        'SearchForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 483)
        Me.Controls.Add(Me.FillByLikeNameToolStrip)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.gbOption)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.FillByBirdNameToolStrip)
        Me.Controls.Add(Me.FillByLocationToolStrip)
        Me.Controls.Add(Me.FillByMonthToolStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SearchForm"
        Me.Text = "Search"
        Me.gbOption.ResumeLayout(False)
        Me.gbOption.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBirdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirdDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByBirdNameToolStrip.ResumeLayout(False)
        Me.FillByBirdNameToolStrip.PerformLayout()
        Me.FillByLocationToolStrip.ResumeLayout(False)
        Me.FillByLocationToolStrip.PerformLayout()
        Me.FillByMonthToolStrip.ResumeLayout(False)
        Me.FillByMonthToolStrip.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.FillByLikeNameToolStrip.ResumeLayout(False)
        Me.FillByLikeNameToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbOption As GroupBox
    Friend WithEvents rbMonth As RadioButton
    Friend WithEvents rbLocation As RadioButton
    Friend WithEvents rbName As RadioButton
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BirdDBDataSet As BirdDBDataSet
    Friend WithEvents TBirdBindingSource As BindingSource
    Friend WithEvents T_BirdTableAdapter As BirdDBDataSetTableAdapters.T_BirdTableAdapter
    Friend WithEvents FillByBirdNameToolStrip As ToolStrip
    Friend WithEvents Bird_NameToolStripLabel As ToolStripLabel
    Friend WithEvents Bird_NameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByBirdNameToolStripButton As ToolStripButton
    Friend WithEvents FillByLocationToolStrip As ToolStrip
    Friend WithEvents LocationToolStripLabel As ToolStripLabel
    Friend WithEvents LocationToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByLocationToolStripButton As ToolStripButton
    Friend WithEvents FillByMonthToolStrip As ToolStrip
    Friend WithEvents MonthToolStripLabel As ToolStripLabel
    Friend WithEvents MonthToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByMonthToolStripButton As ToolStripButton
    Friend WithEvents BirdNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SightingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnViewAll As Button
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordASightingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPrint As ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents mnuPrintPreview As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents pddPrintDialog As PrintDialog
    Friend WithEvents BirdNameToolStripLabel As ToolStripLabel
    Friend WithEvents BirdNameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByLikeNameToolStripButton As ToolStripButton
    Friend WithEvents FillByLikeNameToolStrip As ToolStrip
End Class
