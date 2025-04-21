
Imports System.Data.OleDb

Public Class Details
    Dim stReader As OleDb.OleDbDataReader
    Dim stcommand As OleDb.OleDbCommand
    Private Sub FetchEmployeeData()
        Try
            Dim query = "select * from EMPLOYEE where EMP_ID=" & TextBox2.Text & ""
            stcommand = New OleDbCommand(query, dbcon)
            stReader = stcommand.ExecuteReader()
            stReader.Read()
            Label16.Text = stReader(1).ToString()
            Label15.Text = stReader(2).ToString()
            Label14.Text = stReader(3).ToString()
            Label13.Text = stReader(4).ToString()
            Label12.Text = stReader(5).ToString()
            Label11.Text = stReader(6).ToString()
            Label17.Text = stReader(7).ToString()
            MsgBox("Record Found!!!", MsgBoxStyle.Information)
            dbcon.Close()
        Catch ex As Exception
            MsgBox("No Data Found For Given Id!!!", MsgBoxStyle.Critical)
        End Try
        dbcon.Close()
        dbcon.Open()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchEmployeeData()

    End Sub

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCONNECT.ConnectDB()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Hide()
        Main.Show()
        TextBox2.Clear()
        Label16.Text = "Employee Name"
        Label15.Text = "Employee Address"
        Label14.Text = "Employee Gender"
        Label13.Text = "Employee Position"
        Label12.Text = "Employee Phone"
        Label11.Text = "Employee Education"
        Label17.Text = "Employee DOB"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim exp As New Text.RegularExpressions.Regex("[0-9]{3}")
        If exp.IsMatch(TextBox2.Text) Then
            ErrorProvider1.SetError(TextBox2, "")
        Else
            ErrorProvider1.SetError(TextBox2, "Invalid Employee Id")
        End If
    End Sub
End Class