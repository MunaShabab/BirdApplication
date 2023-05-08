<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordForm
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.cboBirdName = New System.Windows.Forms.ComboBox()
        Me.TBirdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BirdDBDataSet = New BirdApplication.BirdDBDataSet()
        Me.T_BirdTableAdapter = New BirdApplication.BirdDBDataSetTableAdapters.T_BirdTableAdapter()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDateSeen = New System.Windows.Forms.DateTimePicker()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.TBirdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirdDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(242, 96)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(175, 40)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Bird Name : "
        '
        'cboBirdName
        '
        Me.cboBirdName.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBirdName.FormattingEnabled = True
        Me.cboBirdName.Items.AddRange(New Object() {"American Goldfinch", "Bald Eagle", "Blue Jay", "Canadian Goose", "Common Finch", "Eastern Bluebird", "Great Blue Heron", "Great Egret", "Mallard Duck", "Mourning Dove", "Northern Shoveler", "Pileated Woodpecker", "Red-Bellied Woodpecker", "Red Tailed Hawk", "Sandhill Crane", "Tree Swallow", "Tufted Titmouse", "Wood Duck"})
        Me.cboBirdName.Location = New System.Drawing.Point(430, 79)
        Me.cboBirdName.Name = "cboBirdName"
        Me.cboBirdName.Size = New System.Drawing.Size(277, 48)
        Me.cboBirdName.Sorted = True
        Me.cboBirdName.TabIndex = 1
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
        'T_BirdTableAdapter
        '
        Me.T_BirdTableAdapter.ClearBeforeFill = True
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(247, 176)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(140, 40)
        Me.lblLocation.TabIndex = 2
        Me.lblLocation.Text = "Location :"
        '
        'cboLocation
        '
        Me.cboLocation.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Babb Run Bird and Wildlife Sanctuary", "Brecksville Nature Center", "Cuyahoga Valley National Park", "Hach-Otis Sanctuary State Nature Preserve", "Magee Marsh Wildlife Area", "Peak Nature Preserve", "Pelee Island Bird Observatory", "Sandy Ridge Reservation"})
        Me.cboLocation.Location = New System.Drawing.Point(430, 168)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(277, 48)
        Me.cboLocation.Sorted = True
        Me.cboLocation.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(247, 256)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(160, 40)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date Seen :"
        '
        'dtpDateSeen
        '
        Me.dtpDateSeen.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateSeen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateSeen.Location = New System.Drawing.Point(430, 256)
        Me.dtpDateSeen.Name = "dtpDateSeen"
        Me.dtpDateSeen.Size = New System.Drawing.Size(277, 46)
        Me.dtpDateSeen.TabIndex = 5
        '
        'btnRecord
        '
        Me.btnRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnRecord.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnRecord.FlatAppearance.BorderSize = 0
        Me.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecord.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.Location = New System.Drawing.Point(375, 386)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(194, 76)
        Me.btnRecord.TabIndex = 6
        Me.btnRecord.Text = "Record"
        Me.btnRecord.UseVisualStyleBackColor = False
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(919, 42)
        Me.FillByToolStrip.TabIndex = 7
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(75, 36)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(174, 516)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 40)
        Me.lblResult.TabIndex = 8
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 697)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.dtpDateSeen)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.cboBirdName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "RecordForm"
        Me.Text = "Record Sighting"
        CType(Me.TBirdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirdDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents cboBirdName As ComboBox
    Friend WithEvents BirdDBDataSet As BirdDBDataSet
    Friend WithEvents TBirdBindingSource As BindingSource
    Friend WithEvents T_BirdTableAdapter As BirdDBDataSetTableAdapters.T_BirdTableAdapter
    Friend WithEvents lblLocation As Label
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDateSeen As DateTimePicker
    Friend WithEvents btnRecord As Button
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents lblResult As Label
End Class
