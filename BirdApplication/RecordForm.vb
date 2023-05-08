Public Class RecordForm
    Private Sub RecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'BirdDBDataSet.T_Bird' table. You can move, or remove it, as needed.
        Me.T_BirdTableAdapter.FillBy(Me.BirdDBDataSet.T_Bird)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.T_BirdTableAdapter.FillBy(Me.BirdDBDataSet.T_Bird)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        If cboBirdName.Text <> String.Empty And cboLocation.Text <> String.Empty Then
            Try
                Me.T_BirdTableAdapter.Insert(cboBirdName.Text,
                   cboLocation.Text, dtpDateSeen.Value)
                lblResult.Text = cboBirdName.Text + " at " + cboLocation.Text + "." + vbCrLf + "Sighting recorded successfully!"
                Me.T_BirdTableAdapter.FillBy(Me.BirdDBDataSet.T_Bird)
            Catch ex As Exception
                lblResult.Text = “Data Input Error- ” + ex.Message
            End Try
        Else
            lblResult.Text = "You must enter a bird name and a location"
        End If

    End Sub
End Class