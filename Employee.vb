
Imports System.Data.OleDb
Public Class Employee
    Dim stReader As OleDb.OleDbDataReader
    Dim stcommand As OleDb.OleDbCommand
    Dim stdataadapter As New OleDb.OleDbDataAdapter
    Dim source1 As New BindingSource()
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCONNECT.ConnectDB()
        Fill()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim saveSQL As String
            saveSQL = "insert into EMPLOYEE values (@EMP_ID,@EMP_NAME,@EMP_ADDRESS,@GENDER,@POSITION,@PHONE,@EDUCATION,@DOB)"
            stcommand = New OleDb.OleDbCommand(saveSQL, dbcon)
            stcommand.Parameters.AddWithValue("@EMP_ID", TextBox4.Text)
            stcommand.Parameters.AddWithValue("@EMP_NAME", TextBox2.Text)
            stcommand.Parameters.AddWithValue("@EMP_ADDRESS", TextBox3.Text)
            stcommand.Parameters.AddWithValue("@GENDER", ComboBox3.SelectedItem.ToString())
            stcommand.Parameters.AddWithValue("@POSITION", ComboBox2.SelectedItem.ToString())
            stcommand.Parameters.AddWithValue("@PHONE", TextBox6.Text)
            stcommand.Parameters.AddWithValue("@EDUCATION", ComboBox1.SelectedItem.ToString())
            stcommand.Parameters.AddWithValue("@DOB", DateTimePicker1.Text)
            stcommand.ExecuteNonQuery()
            dbcon.Close()
            Fill()
            MsgBox("Record inserted successfully!!", vbInformation)
            dbcon.Open()
        Catch ex As Exception
            MsgBox("Please Enter Valid Data!!!", MsgBoxStyle.Critical)
        End Try

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
        DateTimePicker1.ResetText()
        TextBox6.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim saveSQL As String
            saveSQL = ("update EMPLOYEE set [EMP_NAME] =  '" & TextBox2.Text & "',[EMP_ADDRESS] = '" & TextBox3.Text & "',[GENDER] = '" & ComboBox3.Text.ToString() & "',[POSITION] = '" & ComboBox2.Text.ToString() & "',[PHONE] = '" & TextBox6.Text & "', [EDUCATION] = '" & ComboBox1.Text.ToString() & "' ,[DOB] = '" & DateTimePicker1.Text & "' WHERE [EMP_ID] = " & TextBox4.Text)
            stcommand = New OleDb.OleDbCommand(saveSQL, dbcon)
            stcommand.Parameters.AddWithValue("@EMP_NAME", TextBox2.Text)
            stcommand.Parameters.AddWithValue("@EMP_ADDRESS", TextBox3.Text)
            stcommand.Parameters.AddWithValue("@GENDER", ComboBox3.Text.ToString())
            stcommand.Parameters.AddWithValue("@POSITION", ComboBox2.Text.ToString())
            stcommand.Parameters.AddWithValue("@EDUCATION", ComboBox1.Text.ToString())
            stcommand.Parameters.AddWithValue("@PHONE", TextBox6.Text)
            stcommand.Parameters.AddWithValue("@DOB", DateTimePicker1.Text)
            stcommand.ExecuteNonQuery()
        MsgBox("Are you sure you want to Update?", MessageBoxButtons.OKCancel)
        dbcon.Close()
        Fill()
            MsgBox("Record Updated successfully!!", vbInformation)
            dbcon.Open()
        Catch ex As Exception
            MsgBox("Please Select Valid Data!!!", MsgBoxStyle.Critical)
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
        DateTimePicker1.ResetText()
        TextBox6.Clear()

    End Sub

    Sub Fill()
        Dim dt As New DataTable
        Dim str As String = "Select EMP_ID,EMP_NAME, EMP_ADDRESS,GENDER, POSITION , PHONE , EDUCATION, DOB from EMPLOYEE "
        Dim stdataadapter As New OleDb.OleDbDataAdapter(str, dbcon)
        stdataadapter.Fill(dt)
        stdataadapter.Dispose()
        source1.DataSource = dt
        DataGridView1.DataSource = dt
        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        DataGridView1.Refresh()
        DataGridView1.Columns(4).Width = 150
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim delquery As String
        delquery = "Delete from EMPLOYEE where EMP_ID=@EMP_ID"
        stcommand = New OleDb.OleDbCommand(delquery, dbcon)
        If IsNumeric(TextBox4.Text) Then
            stcommand.Parameters.AddWithValue("@EMP_ID", TextBox4.Text)
            Dim rowsAffected As Integer = stcommand.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Record deleted successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record found with the provided ID!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No record found with the provided ID!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Fill()
        dbcon.Close()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
        DateTimePicker1.ResetText()
        TextBox6.Clear()
        dbcon.Open()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim exp As New Text.RegularExpressions.Regex("[0-9]{3}")

        If exp.IsMatch(TextBox4.Text) Then
            ErrorProvider1.SetError(TextBox4, "")
        Else
            ErrorProvider1.SetError(TextBox4, "Invalid Employee Id")
        End If

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

        Dim exp As New Text.RegularExpressions.Regex("[0-9]{10}")

        If exp.IsMatch(TextBox6.Text) Then
            ErrorProvider1.SetError(TextBox6, "")
        Else
            ErrorProvider1.SetError(TextBox6, "Invalid Phone Number")
        End If


    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            TextBox4.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            TextBox2.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            TextBox3.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
            ComboBox3.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
            ComboBox2.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
            TextBox6.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()
            ComboBox1.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
            DateTimePicker1.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString()
        Catch ex As Exception
            MsgBox("Please Click Appropriate Column!!!!", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class