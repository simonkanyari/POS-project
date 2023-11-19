Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        Timer1.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pass, user As String

        pass = TextBox2.Text
        user = TextBox1.Text

        If pass = "1234" And user = "admin" Then
            Timer1.Enabled = True

        Else
            MessageBox.Show("Wrong credentials")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1

        If ProgressBar1.Value >= 100 Then
            ProgressBar1.Value = 0
            Timer1.Enabled = False
            main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
