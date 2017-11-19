Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Enabled = True
        Form4.LeftButton.Enabled = False
        Form4.RightButton.Enabled = False
        Form4.DownButton.Enabled = False
        Form4.UpButton.Enabled = False
        Form4.Show()
    End Sub
End Class