Public Class Form4
    Private exibitPics(2, 2) As Image
    Dim currentPos As Image
    Dim x As Integer
    Dim y As Integer

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exibitPics(0, 0) = My.Resources.Safari1
        exibitPics(0, 1) = My.Resources.Safari2
        exibitPics(0, 2) = My.Resources.Safari3
        exibitPics(1, 0) = My.Resources.Safari4
        exibitPics(1, 1) = My.Resources.Safari5
        exibitPics(1, 2) = My.Resources.Safari6
        exibitPics(2, 0) = My.Resources.Safari7
        exibitPics(2, 1) = My.Resources.Safari8
        exibitPics(2, 2) = My.Resources.Lions
        x = 0
        y = 0
        currentPos = exibitPics(x, y)
        Me.BackgroundImage = currentPos
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Enabled = True
        Form1.Show()
        Form1.Button4.Enabled = True
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles LeftButton.Click, RightButton.Click, DownButton.Click, UpButton.Click
        If sender.Equals(Me.LeftButton) Then
            If (x > 0) Then
                x -= 1
                Me.BackgroundImage = exibitPics(x, y)
            Else
                x = 2
                Me.BackgroundImage = exibitPics(x, y)
            End If
        ElseIf sender.Equals(Me.RightButton) Then
            If (x < 2) Then
                x += 1
                Me.BackgroundImage = exibitPics(x, y)
            Else
                x = 0
                Me.BackgroundImage = exibitPics(x, y)
            End If
        ElseIf sender.Equals(Me.DownButton) Then
            If (y > 0) Then
                y -= 1
                Me.BackgroundImage = exibitPics(x, y)
            Else
                y = 2
                Me.BackgroundImage = exibitPics(x, y)
            End If
        ElseIf sender.Equals(Me.UpButton) Then
            If (y < 2) Then
                y += 1
                Me.BackgroundImage = exibitPics(x, y)
            Else
                y = 0
                Me.BackgroundImage = exibitPics(x, y)
            End If
        End If
    End Sub

End Class