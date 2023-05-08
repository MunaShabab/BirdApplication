Public Class MainForm
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mapView As New MapView
        mapView.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim recordForm As New RecordForm()
        recordForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim searchForm As New SearchForm()
        searchForm.ShowDialog()
    End Sub
End Class
