
Imports System.Data.OleDb
Public Class Salary
    Dim stReader As OleDb.OleDbDataReader
    Dim stcommand As OleDb.OleDbCommand
    Dim dailypay, total, incentive, HRA As Integer
    Dim phone As String
    Private Sub FetchEmployeeData()
        Try
            If (TextBox2.Text = "") Then
                MsgBox("Enter Employee Id Please..", MsgBoxStyle.Critical)
            Else
                Dim query = "select * from EMPLOYEE where EMP_ID=" & TextBox2.Text & ""
                stcommand = New OleDbCommand(query, dbcon)
                stReader = stcommand.ExecuteReader()
                stReader.Read()

                Label16.Text = stReader(1).ToString()
                Label14.Text = stReader(4).ToString()
            End If
        Catch ex As Exception
            MsgBox("No Data Found For Given Employee Id!!!", MsgBoxStyle.Critical)
        End Try
        dbcon.Close()
        dbcon.Open()
    End Sub
    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCONNECT.ConnectDB()
        PrintPreviewDialog1.Document = PrintDocument1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchEmployeeData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        incentive = 1000
        HRA = 500
        Try
            Dim query = "select * from EMPLOYEE where EMP_ID=" & TextBox2.Text & ""
            stcommand = New OleDbCommand(query, dbcon)
            stReader = stcommand.ExecuteReader()
            stReader.Read()

            If (Label14.Text = "") Then
                MsgBox("Please select An Employee...", MsgBoxStyle.Critical)
            ElseIf TextBox3.Text = "" Or Val(TextBox3.Text) > 30 Then
                MsgBox("Enter the valid working days...", MsgBoxStyle.Critical)
            Else
                If Label14.Text = "Programmer_Analyst_Trainee" Then
                    dailypay = 600
                ElseIf Label14.Text = "Programer_Analyst" Then
                    dailypay = 800
                ElseIf Label14.Text = "Software_Engineer" Then
                    dailypay = 1200
                ElseIf Label14.Text = "Software_Tester" Then
                    dailypay = 1300
                ElseIf Label14.Text = "Associate_Manager" Then
                    dailypay = 1400
                ElseIf Label14.Text = "Associate_Manager-Projects" Then
                    dailypay = 1700
                ElseIf Label14.Text = "Senior_Project_Manager" Then
                    dailypay = 2000
                ElseIf Label14.Text = "Scrum_Manager" Then
                    dailypay = 3000
                ElseIf Label14.Text = "Engagement_Delivary_Lead" Then
                    dailypay = 5000
                End If
                total = dailypay * Val(TextBox3.Text) + incentive + HRA

                RichTextBox1.Text = ("Associate Id: " & stReader(0).ToString() & vbTab & vbTab & vbTab & " DOB: " & stReader(7).ToString() & vbCrLf & vbCrLf & "Associate Name: " + Label16.Text & vbTab & "  Phone: " & stReader(5).ToString() & vbCrLf & vbCrLf & "Designation: " + stReader(4).ToString() & "     Worked Days: " + TextBox3.Text & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbTab & "Basic " & vbTab & vbTab & vbTab & dailypay.ToString() & vbCrLf & vbCrLf & vbTab & "Incentive Pay " & vbTab & vbTab & +incentive & vbCrLf & vbCrLf & vbTab & "HRA " & vbTab & vbTab & vbTab & +HRA & vbCrLf & vbCrLf & vbTab & "Total Earnings" & vbTab & vbTab & total.ToString())
            End If

        Catch ex As Exception
            MsgBox("Enter the Valid Employee Id!!!", MsgBoxStyle.Critical)
        End Try
        dbcon.Close()
        dbcon.Open()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim rectpen As New Pen(Color.Black, 1)  ' Adjust color and thickness as needed
        ' Define rectangle properties (location, size)
        Dim rectangleX As Integer = 10  ' Adjust x-coordinate for top-left corner
        Dim rectangleY As Integer = 10  ' Adjust y-coordinate for top-left corner
        Dim width As Integer = 810      ' Adjust width of the rectangle
        Dim height As Integer = 1150    ' Adjust height of the rectangle

        ' Draw the rectangle
        e.Graphics.DrawRectangle(rectpen, rectangleX, rectangleY, width, height)

        Dim font As New Font("Times New Roman", 24, FontStyle.Bold)
        Dim font1 As New Font("Arial", 20, FontStyle.Bold)
        e.Graphics.DrawString("Employee Management System", font, Brushes.Red, 190, 100)
        e.Graphics.DrawString("Earnings: ", font1, Brushes.Black, 50, 450)
        e.Graphics.DrawString("Amount: ", font1, Brushes.Black, 400, 450)
        e.Graphics.DrawString("*** PAYSLIP ***", New Font("Arial", 20), Brushes.Green, 330, 190)
        e.Graphics.DrawString(RichTextBox1.Text, New Font("Times New Roman", 20, FontStyle.Regular), Brushes.Black, 50, 250)
        e.Graphics.DrawString("Employeer Signature ", New Font("Arial", 20), Brushes.Black, 80, 850)
        e.Graphics.DrawString("Employee Signature ", New Font("Arial", 20), Brushes.Black, 480, 850)
        e.Graphics.DrawString("*** Thanks for Your Services ***", New Font("Arial", 28), Brushes.Red, 130, 1000)

        Dim pen As New Pen(Color.Black, 2)  ' Adjust color and thickness as needed

        Dim Signx As Integer = 50  ' Adjust x-coordinate for starting position
        Dim Signy As Integer = 930  ' Adjust y-coordinate for starting position
        Dim Signend As Integer = 400  ' Use form width for horizontal line

        ' Draw the horizontal line
        e.Graphics.DrawLine(pen, Signx, Signy, Signend, Signy)


        Dim Sign2x As Integer = 800  ' Adjust x-coordinate for starting position
        Dim Sign2y As Integer = 930  ' Adjust y-coordinate for starting position
        Dim Sign2end As Integer = 450  ' Use form width for horizontal line

        ' Draw the horizontal line
        e.Graphics.DrawLine(pen, Sign2x, Sign2y, Sign2end, Sign2y)

        ' Define starting and ending points for the vertical line
        Dim startX As Integer = 400  ' Adjust x-coordinate for starting position
        Dim startY As Integer = 430  ' Adjust y-coordinate for starting position
        Dim endY As Integer = 700  ' Use form height for vertical line

        ' Draw the vertical line
        e.Graphics.DrawLine(pen, startX, startY, startX, endY)


        ' Define starting and ending points for the vertical line
        Dim ver1x As Integer = 800  ' Adjust x-coordinate for starting position
        Dim ver1y As Integer = 250  ' Adjust y-coordinate for starting position
        Dim ver1end As Integer = 770  ' Use form height for vertical line

        ' Draw the vertical line
        e.Graphics.DrawLine(pen, ver1x, ver1y, ver1x, ver1end)

        ' Define starting and ending points for the vertical line
        Dim ver2x As Integer = 50  ' Adjust x-coordinate for starting position
        Dim ver2y As Integer = 250  ' Adjust y-coordinate for starting position
        Dim ver2end As Integer = 770  ' Use form height for vertical line

        ' Draw the vertical line
        e.Graphics.DrawLine(pen, ver2x, ver2y, ver2x, ver2end)


        ' Define starting and ending points for the horizontal line
        Dim horx As Integer = 50  ' Adjust x-coordinate for starting position
        Dim hory As Integer = 500  ' Adjust y-coordinate for starting position
        Dim horend As Integer = 800  ' Use form width for horizontal line

        ' Draw the horizontal line
        e.Graphics.DrawLine(pen, horx, hory, horend, hory)

        Dim hor2x As Integer = 50  ' Adjust x-coordinate for starting position
        Dim hor2y As Integer = 570  ' Adjust y-coordinate for starting position
        Dim hor2end As Integer = 800  ' Use form width for horizontal line

        ' Draw the horizontal line
        e.Graphics.DrawLine(pen, hor2x, hor2y, hor2end, hor2y)

        Dim hor3x As Integer = 50  ' adjust x-coordinate for starting position
        Dim hor3y As Integer = 630  ' adjust y-coordinate for starting position
        Dim hor3end As Integer = 800  ' use form width for horizontal line

        ' draw the horizontal line
        e.Graphics.DrawLine(pen, hor3x, hor3y, hor3end, hor3y)


        Dim hor4x As Integer = 50  ' adjust x-coordinate for starting position
        Dim hor4y As Integer = 700  ' adjust y-coordinate for starting position
        Dim hor4end As Integer = 800  ' use form width for horizontal line

        ' draw the horizontal line
        e.Graphics.DrawLine(pen, hor4x, hor4y, hor4end, hor4y)


        Dim hor5x As Integer = 50  ' adjust x-coordinate for starting position
        Dim hor5y As Integer = 770  ' adjust y-coordinate for starting position
        Dim hor5end As Integer = 800  ' use form width for horizontal line

        ' draw the horizontal line
        e.Graphics.DrawLine(pen, hor5x, hor5y, hor5end, hor5y)


        Dim hor6x As Integer = 50  ' adjust x-coordinate for starting position
        Dim hor6y As Integer = 430  ' adjust y-coordinate for starting position
        Dim hor6end As Integer = 800  ' use form width for horizontal line

        ' draw the horizontal line
        e.Graphics.DrawLine(pen, hor6x, hor6y, hor6end, hor6y)

        ' Define starting and ending points for the horizontal line
        Dim hor7x As Integer = 50  ' Adjust x-coordinate for starting position
        Dim hor7y As Integer = 250  ' Adjust y-coordinate for starting position
        Dim hor7end As Integer = 800  ' Use form width for horizontal line

        ' Draw the horizontal line
        e.Graphics.DrawLine(pen, hor7x, hor7y, hor7end, hor7y)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Main.Show()
        Label16.Text = "Employee Name"
        Label14.Text = "Employee Position"
        TextBox2.Clear()
        TextBox3.Clear()
        RichTextBox1.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim exp As New Text.RegularExpressions.Regex("[0-9]")

        If exp.IsMatch(TextBox3.Text) And Val(TextBox3.Text) <= 30 Then
            ErrorProvider1.SetError(TextBox3, "")
        Else
            ErrorProvider1.SetError(TextBox3, "Invalid Number of Worked Days")
        End If
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