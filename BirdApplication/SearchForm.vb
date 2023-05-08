Public Class SearchForm
    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BirdDBDataSet.T_Bird' table. You can move, or remove it, as needed.
        Me.T_BirdTableAdapter.FillBy(Me.BirdDBDataSet.T_Bird)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DataGridView1.Visible = True
        If rbName.Checked Then
            Me.T_BirdTableAdapter.FillByLikeName(Me.BirdDBDataSet.T_Bird, txtSearch.Text)

        ElseIf rbLocation.Checked Then
            Me.T_BirdTableAdapter.FillByLocation(Me.BirdDBDataSet.T_Bird, txtSearch.Text)
        ElseIf rbMonth.Checked Then
            Try
                Dim month As Integer = CInt(txtSearch.Text)

                If month > 0 And month < 13 Then
                    Me.T_BirdTableAdapter.FillByMonth(Me.BirdDBDataSet.T_Bird, month)
                Else
                    MessageBox.Show("enter a number between 1 and 12 for month")
                End If
            Catch ex As Exception

            End Try

        End If
        mnuPrintPreview.Enabled = True
        mnuPrint.Enabled = True
    End Sub

    Private Sub FillByBirdNameToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByBirdNameToolStripButton.Click
        Try
            Me.T_BirdTableAdapter.FillByBirdName(Me.BirdDBDataSet.T_Bird, Bird_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByLocationToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByLocationToolStripButton.Click
        Try
            Me.T_BirdTableAdapter.FillByLocation(Me.BirdDBDataSet.T_Bird, LocationToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByMonthToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByMonthToolStripButton.Click
        Try
            Me.T_BirdTableAdapter.FillByMonth(Me.BirdDBDataSet.T_Bird, CType(MonthToolStripTextBox.Text, Decimal))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        DataGridView1.Visible = True
        Me.T_BirdTableAdapter.Fill(Me.BirdDBDataSet.T_Bird)
        mnuPrintPreview.Enabled = True
        mnuPrint.Enabled = True
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim frmSearch As New SearchForm
        frmSearch.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RecordASightingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordASightingToolStripMenuItem.Click
        Dim frmRecord As New RecordForm
        frmRecord.ShowDialog()
    End Sub

    Private Sub AboutSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSearchToolStripMenuItem.Click
        Dim frmAboutSearch As New AboutSearch
        frmAboutSearch.ShowDialog()
    End Sub

    Private Sub mnuPrint_Click(sender As Object, e As EventArgs) Handles mnuPrint.Click
        pddPrintDialog.Document = PrintDocument1
        If pddPrintDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument1.PrinterSettings = pddPrintDialog.PrinterSettings
            PrintDocument1.Print()

        End If
        DataGridView1.Dock = DockStyle.None
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        DataGridView1.Dock = DockStyle.Fill
        Dim imageBmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imageBmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imageBmp, 0, 0)
    End Sub

    Private Sub mnuPrintPreview_Click(sender As Object, e As EventArgs) Handles mnuPrintPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Dock = DockStyle.None
    End Sub

    Private Sub FillByLikeNameToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByLikeNameToolStripButton.Click
        Try
            Me.T_BirdTableAdapter.FillByLikeName(Me.BirdDBDataSet.T_Bird, BirdNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class