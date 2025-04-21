<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        TextBox2 = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Button2 = New Button()
        Label18 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Green
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(-2, -3)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1220, 78)
        TextBox1.TabIndex = 27
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Green
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(11, -3)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 78)
        Label2.TabIndex = 28
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Green
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(113, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 31)
        Label1.TabIndex = 29
        Label1.Text = "Employee Details"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(35, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 31)
        Label3.TabIndex = 31
        Label3.Text = "Employee Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(559, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(209, 31)
        Label4.TabIndex = 33
        Label4.Text = "Employee Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Green
        Label5.Location = New Point(35, 305)
        Label5.Name = "Label5"
        Label5.Size = New Size(201, 31)
        Label5.TabIndex = 34
        Label5.Text = "Employee Gender"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(559, 305)
        Label6.Name = "Label6"
        Label6.Size = New Size(212, 31)
        Label6.TabIndex = 35
        Label6.Text = "Employee Position"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Green
        Label7.Location = New Point(35, 414)
        Label7.Name = "Label7"
        Label7.Size = New Size(192, 31)
        Label7.TabIndex = 37
        Label7.Text = "Employee Phone"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Green
        Label8.Location = New Point(559, 414)
        Label8.Name = "Label8"
        Label8.Size = New Size(231, 31)
        Label8.TabIndex = 38
        Label8.Text = "Employee Education"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Green
        Label9.Location = New Point(267, 501)
        Label9.Name = "Label9"
        Label9.Size = New Size(173, 31)
        Label9.TabIndex = 39
        Label9.Text = "Employee DOB"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(267, 110)
        Label10.Name = "Label10"
        Label10.Size = New Size(148, 31)
        Label10.TabIndex = 45
        Label10.Text = "Employee ID"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(464, 106)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(225, 35)
        TextBox2.TabIndex = 46
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Maroon
        Label11.Location = New Point(796, 414)
        Label11.Name = "Label11"
        Label11.Size = New Size(231, 31)
        Label11.TabIndex = 52
        Label11.Text = "Employee Education"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.White
        Label12.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Maroon
        Label12.Location = New Point(265, 414)
        Label12.Name = "Label12"
        Label12.Size = New Size(192, 31)
        Label12.TabIndex = 51
        Label12.Text = "Employee Phone"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.White
        Label13.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Maroon
        Label13.Location = New Point(796, 305)
        Label13.Name = "Label13"
        Label13.Size = New Size(212, 31)
        Label13.TabIndex = 50
        Label13.Text = "Employee Position"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.White
        Label14.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Maroon
        Label14.Location = New Point(265, 305)
        Label14.Name = "Label14"
        Label14.Size = New Size(201, 31)
        Label14.TabIndex = 49
        Label14.Text = "Employee Gender"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.White
        Label15.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Maroon
        Label15.Location = New Point(796, 202)
        Label15.Name = "Label15"
        Label15.Size = New Size(209, 31)
        Label15.TabIndex = 48
        Label15.Text = "Employee Address"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.White
        Label16.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.Maroon
        Label16.Location = New Point(265, 202)
        Label16.Name = "Label16"
        Label16.Size = New Size(187, 31)
        Label16.TabIndex = 47
        Label16.Text = "Employee Name"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.White
        Label17.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.Maroon
        Label17.Location = New Point(483, 501)
        Label17.Name = "Label17"
        Label17.Size = New Size(173, 31)
        Label17.TabIndex = 53
        Label17.Text = "Employee DOB"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(755, 106)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 45)
        Button2.TabIndex = 54
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.Image = CType(resources.GetObject("Label18.Image"), Image)
        Label18.Location = New Point(1156, 9)
        Label18.Name = "Label18"
        Label18.Size = New Size(50, 41)
        Label18.TabIndex = 79
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Details
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1218, 592)
        Controls.Add(Label18)
        Controls.Add(Button2)
        Controls.Add(Label17)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Label16)
        Controls.Add(TextBox2)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Details"
        Text = "Details"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
