<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salary))
        Label14 = New Label()
        Label16 = New Label()
        TextBox2 = New TextBox()
        Label10 = New Label()
        Button1 = New Button()
        Label7 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        TextBox3 = New TextBox()
        RichTextBox1 = New RichTextBox()
        Button3 = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Label4 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.White
        Label14.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Maroon
        Label14.Location = New Point(27, 362)
        Label14.Name = "Label14"
        Label14.Size = New Size(212, 31)
        Label14.TabIndex = 69
        Label14.Text = "Employee Position"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.White
        Label16.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.Maroon
        Label16.Location = New Point(27, 262)
        Label16.Name = "Label16"
        Label16.Size = New Size(187, 31)
        Label16.TabIndex = 67
        Label16.Text = "Employee Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(27, 150)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(225, 35)
        TextBox2.TabIndex = 66
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(27, 96)
        Label10.Name = "Label10"
        Label10.Size = New Size(148, 31)
        Label10.TabIndex = 65
        Label10.Text = "Employee ID"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(50, 560)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 52)
        Button1.TabIndex = 64
        Button1.Text = "View"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Green
        Label7.Location = New Point(27, 420)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 31)
        Label7.TabIndex = 61
        Label7.Text = "Worked Days"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Green
        Label5.Location = New Point(27, 311)
        Label5.Name = "Label5"
        Label5.Size = New Size(212, 31)
        Label5.TabIndex = 59
        Label5.Text = "Employee Position"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(27, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 31)
        Label3.TabIndex = 57
        Label3.Text = "Employee Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Green
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(119, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 31)
        Label1.TabIndex = 56
        Label1.Text = "Salary"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Green
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(17, -7)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 78)
        Label2.TabIndex = 55
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Green
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(-5, -7)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1171, 78)
        TextBox1.TabIndex = 54
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(293, 140)
        Button2.Name = "Button2"
        Button2.Size = New Size(206, 45)
        Button2.TabIndex = 74
        Button2.Text = "Fetch Data"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(27, 479)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(225, 35)
        TextBox3.TabIndex = 75
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.White
        RichTextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(531, 77)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(621, 461)
        RichTextBox1.TabIndex = 76
        RichTextBox1.Text = ""
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(755, 569)
        Button3.Name = "Button3"
        Button3.Size = New Size(125, 52)
        Button3.TabIndex = 77
        Button3.Text = "Print"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
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
        ' Label4
        ' 
        Label4.Image = CType(resources.GetObject("Label4.Image"), Image)
        Label4.Location = New Point(1102, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 41)
        Label4.TabIndex = 78
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Salary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1164, 633)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(RichTextBox1)
        Controls.Add(TextBox3)
        Controls.Add(Button2)
        Controls.Add(Label14)
        Controls.Add(Label16)
        Controls.Add(TextBox2)
        Controls.Add(Label10)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Salary"
        Text = "Salary"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
