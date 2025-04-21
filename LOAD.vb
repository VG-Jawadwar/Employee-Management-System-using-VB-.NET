Public Class LOAD
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 1
            Label1.Text = ProgressBar1.Value & " %"
        End If

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            LOGIN.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub LOAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class