
Public Class LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "Password" Then
            MsgBox("Welcome to EMS!...", MsgBoxStyle.Information)
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()
            Main.Show()
        ElseIf TextBox1.Text IsNot "Admin" And TextBox2.Text = "Password" Then
            MsgBox("Invalid Username", MsgBoxStyle.Critical)
        ElseIf TextBox1.Text = "Admin" And TextBox2.Text IsNot "Password" Then
            MsgBox("Invalid Password", MsgBoxStyle.Critical)
        Else
            MsgBox("Unauthorised User", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

End Class
