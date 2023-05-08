Imports System.Text
Public Class MapView


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cboSearchName.Text <> String.Empty Then
            Me.T_BirdTableAdapter.FillByName(Me.BirdDBDataSet.T_Bird, cboSearchName.Text)
            ltbLocation.Visible = True

            Try
                Dim queryAddress As New StringBuilder
                queryAddress.Append("https://www.google.com/maps?q=") 'h1=en&tab=w1
                Dim row As DataRowView = TryCast(ltbLocation.SelectedItem, DataRowView)
                If row IsNot Nothing Then
                    queryAddress.Append(CType(ltbLocation.SelectedItem, DataRowView).Item("Location").ToString())
                    WebBrowser1.Navigate(queryAddress.ToString)
                    lblResults.Text = "Found at these location(s)"
                Else
                    lblResults.Text = "Bird Not Found"
                    WebBrowser1.Navigate(queryAddress.ToString)
                End If


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            lblResults.Text = "You must enter a bird name"
        End If
        btnSearch.Enabled = False
        btnClear.Enabled = True

    End Sub

    Private Sub MapView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BirdDBDataSet.T_Bird' table. You can move, or remove it, as needed.
        Me.T_BirdTableAdapter.FillBy(Me.BirdDBDataSet.T_Bird)
        btnClear.Enabled = False
        btnSearch.Enabled = True
        lblResults.Text = String.Empty
        ltbLocation.Visible = False


    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.T_BirdTableAdapter.FillBy(Me.BirdDBDataSet.T_Bird)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByNameToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByNameToolStripButton.Click
        Try
            Me.T_BirdTableAdapter.FillByName(Me.BirdDBDataSet.T_Bird, Bird_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ltbLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbLocation.SelectedIndexChanged
        Try
            Dim queryAddress As New StringBuilder
            queryAddress.Append("https://www.google.com/maps?q=") 'h1=en&tab=w1
            Dim row As DataRowView = TryCast(ltbLocation.SelectedItem, DataRowView)
            If row IsNot Nothing Then
                queryAddress.Append(CType(ltbLocation.SelectedItem, DataRowView).Item("Location").ToString())
                WebBrowser1.Navigate(queryAddress.ToString)
            Else
                WebBrowser1.Navigate(queryAddress.ToString)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        MapView_Load(e, e)

    End Sub
End Class