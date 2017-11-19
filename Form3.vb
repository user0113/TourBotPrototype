Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Enabled = False
        Form1.Hide()
        Form1.Timer2.Stop()
        Form1.Timer2.Enabled = False
        Form2.Enabled = False
        Form2.Hide()
        Me.Enabled = False
        Me.Hide()
        Form4.Enabled = True
        Form4.LeftButton.Enabled = True
        Form4.RightButton.Enabled = True
        Form4.DownButton.Enabled = True
        Form4.UpButton.Enabled = True
        Form4.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Please accept turn.")
    End Sub
End Class