<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ltbLocation = New System.Windows.Forms.ListBox()
        Me.TBirdBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BirdDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BirdDBDataSet = New BirdApplication.BirdDBDataSet()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboSearchName = New System.Windows.Forms.ComboBox()
        Me.TBirdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.T_BirdTableAdapter = New BirdApplication.BirdDBDataSetTableAdapters.T_BirdTableAdapter()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Bird_NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Bird_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TBirdBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TBirdBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirdDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirdDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBirdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        Me.FillByNameToolStrip.SuspendLayout()
        CType(Me.TBirdBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ltbLocation)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblResults)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboSearchName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblInstruct)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1630, 767)
        Me.SplitContainer1.SplitterDistance = 393
        Me.SplitContainer1.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(104, 320)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 54)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ltbLocation
        '
        Me.ltbLocation.DataSource = Me.TBirdBindingSource1
        Me.ltbLocation.DisplayMember = "Location"
        Me.ltbLocation.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbLocation.FormattingEnabled = True
        Me.ltbLocation.ItemHeight = 40
        Me.ltbLocation.Location = New System.Drawing.Point(21, 551)
        Me.ltbLocation.Name = "ltbLocation"
        Me.ltbLocation.Size = New System.Drawing.Size(310, 84)
        Me.ltbLocation.TabIndex = 4
        Me.ltbLocation.Visible = False
        '
        'TBirdBindingSource1
        '
        Me.TBirdBindingSource1.DataMember = "T_Bird"
        Me.TBirdBindingSource1.DataSource = Me.BirdDBDataSetBindingSource
        '
        'BirdDBDataSetBindingSource
        '
        Me.BirdDBDataSetBindingSource.DataSource = Me.BirdDBDataSet
        Me.BirdDBDataSetBindingSource.Position = 0
        '
        'BirdDBDataSet
        '
        Me.BirdDBDataSet.DataSetName = "BirdDBDataSet"
        Me.BirdDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(74, 415)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(0, 40)
        Me.lblResults.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(104, 249)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(142, 54)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboSearchName
        '
        Me.cboSearchName.FormattingEnabled = True
        Me.cboSearchName.Items.AddRange(New Object() {"American Goldfinch", "Bald Eagle", "Blue Jay", "Canadian Goose", "Common Finch", "Eastern Bluebird", "Great Blue Heron", "Great Egret", "Mallard Duck", "Mourning Dove", "Northern Shoveler", "Pileated Woodpecker", "Red-Bellied Woodpecker", "Red Tailed Hawk", "Sandhill Crane", "Tree Swallow", "Tufted Titmouse", "Wood Duck"})
        Me.cboSearchName.Location = New System.Drawing.Point(83, 178)
        Me.cboSearchName.Name = "cboSearchName"
        Me.cboSearchName.Size = New System.Drawing.Size(189, 33)
        Me.cboSearchName.Sorted = True
        Me.cboSearchName.TabIndex = 1
        '
        'TBirdBindingSource
        '
        Me.TBirdBindingSource.DataMember = "T_Bird"
        Me.TBirdBindingSource.DataSource = Me.BirdDBDataSetBindingSource
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct.Location = New System.Drawing.Point(14, 91)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(353, 40)
        Me.lblInstruct.TabIndex = 0
        Me.lblInstruct.Text = "Enter the name of the bird"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1233, 767)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'T_BirdTableAdapter
        '
        Me.T_BirdTableAdapter.ClearBeforeFill = True
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(1630, 42)
        Me.FillBy1ToolStrip.TabIndex = 1
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Visible = False
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(88, 36)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        '
        'FillByNameToolStrip
        '
        Me.FillByNameToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FillByNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bird_NameToolStripLabel, Me.Bird_NameToolStripTextBox, Me.FillByNameToolStripButton})
        Me.FillByNameToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByNameToolStrip.Name = "FillByNameToolStrip"
        Me.FillByNameToolStrip.Size = New System.Drawing.Size(1630, 42)
        Me.FillByNameToolStrip.TabIndex = 2
        Me.FillByNameToolStrip.Text = "FillByNameToolStrip"
        Me.FillByNameToolStrip.Visible = False
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
        'FillByNameToolStripButton
        '
        Me.FillByNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByNameToolStripButton.Name = "FillByNameToolStripButton"
        Me.FillByNameToolStripButton.Size = New System.Drawing.Size(139, 36)
        Me.FillByNameToolStripButton.Text = "FillByName"
        '
        'TBirdBindingSource2
        '
        Me.TBirdBindingSource2.DataMember = "T_Bird"
        Me.TBirdBindingSource2.DataSource = Me.BirdDBDataSetBindingSource
        '
        'MapView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1630, 767)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.FillByNameToolStrip)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MapView"
        Me.Text = "MapView"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TBirdBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirdDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirdDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBirdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        Me.FillByNameToolStrip.ResumeLayout(False)
        Me.FillByNameToolStrip.PerformLayout()
        CType(Me.TBirdBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnSearch As Button
    Friend WithEvents cboSearchName As ComboBox
    Friend WithEvents lblInstruct As Label
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents BirdDBDataSetBindingSource As BindingSource
    Friend WithEvents BirdDBDataSet As BirdDBDataSet
    Friend WithEvents TBirdBindingSource As BindingSource
    Friend WithEvents T_BirdTableAdapter As BirdDBDataSetTableAdapters.T_BirdTableAdapter
    Friend WithEvents lblResults As Label
    Friend WithEvents ltbLocation As ListBox
    Friend WithEvents TBirdBindingSource1 As BindingSource
    Friend WithEvents FillBy1ToolStrip As ToolStrip
    Friend WithEvents FillBy1ToolStripButton As ToolStripButton
    Friend WithEvents FillByNameToolStrip As ToolStrip
    Friend WithEvents Bird_NameToolStripLabel As ToolStripLabel
    Friend WithEvents Bird_NameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByNameToolStripButton As ToolStripButton
    Friend WithEvents btnClear As Button
    Friend WithEvents TBirdBindingSource2 As BindingSource
End Class
