Public Class Form1
    Dim min As Double
    Dim sec As Double
    Dim theTime As Double
    Dim timeLimit As Double
    Dim timeLeft As String

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Enabled = True

        DataGridView1.Rows.Add("Elephant", 2)
        DataGridView1.Rows.Add("Lion", 1)
        DataGridView1.Rows.Add("Giraffe", 3)
        DataGridView1.Rows.Add("Tiger", 0)

        theTime = 30
        timeLimit = 300
    End Sub

    Public Sub Timer1_Timer(sender As Object, e As EventArgs) Handles Timer1.Tick
        If theTime > 0 Then
            theTime -= 1
            sec = theTime Mod 60
            min = ((theTime - sec) / 60) Mod 6
            timeLeft = Format(min, "00") & ":" & Format(sec, "00")
            Time1.Text = timeLeft
            Form2.Time1.Text = timeLeft
        Else
            Me.Hide()
            Form2.Close()
            Timer1.Enabled = False
            Timer1.Stop()
            Timer2.Enabled = True
            Timer2.Start()
            Form3.Show()
            Button4.Enabled = False
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Enabled = False
        Form2.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        timeLimit -= 1
        If timeLimit = 0 Then
            Timer2.Enabled = False
            Timer2.Stop()
            MsgBox("Your turn has expired.")
            Me.Enabled = True
            Me.Show()
            Form3.Enabled = False
            Form3.Hide()
            Button4.Enabled = True
        End If
    End Sub
End Class
