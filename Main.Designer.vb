<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Green
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(0, -2)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1067, 78)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Green
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(127, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 31)
        Label1.TabIndex = 1
        Label1.Text = "Manage Employee"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Green
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(12, -2)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 78)
        Label2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Green
        Label3.Location = New Point(0, 503)
        Label3.Name = "Label3"
        Label3.Size = New Size(1067, 55)
        Label3.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(210, 344)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 41)
        Label4.TabIndex = 4
        Label4.Text = "Employee"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Green
        Label5.Location = New Point(487, 355)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 30)
        Label5.TabIndex = 5
        Label5.Text = "Details "
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(733, 351)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 28)
        Label6.TabIndex = 6
        Label6.Text = "Salary"
        ' 
        ' Button1
        ' 
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(226, 150)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 195)
        Button1.TabIndex = 7
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(448, 150)
        Button2.Name = "Button2"
        Button2.Size = New Size(151, 185)
        Button2.TabIndex = 8
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(685, 150)
        Button3.Name = "Button3"
        Button3.Size = New Size(151, 185)
        Button3.TabIndex = 9
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Image = CType(resources.GetObject("Label7.Image"), Image)
        Label7.Location = New Point(930, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 44)
        Label7.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Green
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(977, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 28)
        Label8.TabIndex = 11
        Label8.Text = "Logout"
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1067, 553)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Main"
        Text = "Main"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
