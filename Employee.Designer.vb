<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox6 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        Label10 = New Label()
        TextBox4 = New TextBox()
        Label11 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Green
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(-1, -1)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1187, 78)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Green
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(12, -1)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 78)
        Label2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Green
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(114, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 31)
        Label1.TabIndex = 4
        Label1.Text = "Manage Employee"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(12, 175)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(223, 39)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(26, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 31)
        Label3.TabIndex = 6
        Label3.Text = "Employee Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(294, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(209, 31)
        Label4.TabIndex = 8
        Label4.Text = "Employee Address"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(280, 175)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(223, 39)
        TextBox3.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Green
        Label5.Location = New Point(26, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(201, 31)
        Label5.TabIndex = 10
        Label5.Text = "Employee Gender"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(291, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(212, 31)
        Label6.TabIndex = 12
        Label6.Text = "Employee Position"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Green
        Label7.Location = New Point(18, 332)
        Label7.Name = "Label7"
        Label7.Size = New Size(192, 31)
        Label7.TabIndex = 14
        Label7.Text = "Employee Phone"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(13, 382)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(222, 37)
        TextBox6.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Green
        Label8.Location = New Point(272, 332)
        Label8.Name = "Label8"
        Label8.Size = New Size(231, 31)
        Label8.TabIndex = 16
        Label8.Text = "Employee Education"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Green
        Label9.Location = New Point(174, 445)
        Label9.Name = "Label9"
        Label9.Size = New Size(173, 31)
        Label9.TabIndex = 18
        Label9.Text = "Employee DOB"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Diploma Engineering ", "Engineering (BE/BTECH)", "Engineering (ME/MTECH)", "Master of Computer Applications (MCA)", "Bachelor of Computer Applications (BCA)", "Commerce (B.Com)", "Commerce (M.COM)", "Master of Business Administration (MBA)", "Business Administration (BBA)", "Marketing (BBA Marketing)", "Humanities (History, English, Philosophy, etc.)"})
        ComboBox1.Location = New Point(280, 384)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(215, 36)
        ComboBox1.TabIndex = 19
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Programmer_Analyst_Trainee ", "Programer_Analyst", "Software_Engineer", "Software_Tester", "Associate_Manager", "Associate_Manager-Projects", "Senior_Project_Manager", "Scrum_Manager", "Engagement_Delivary_Lead"})
        ComboBox2.Location = New Point(280, 275)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(223, 36)
        ComboBox2.TabIndex = 20
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"MALE", "FEMALE", "NONE"})
        ComboBox3.Location = New Point(12, 275)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(223, 36)
        ComboBox3.TabIndex = 21
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(130, 493)
        DateTimePicker1.MaximumSize = New Size(400, 400)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 38)
        DateTimePicker1.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(57, 555)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 52)
        Button1.TabIndex = 23
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(207, 555)
        Button2.Name = "Button2"
        Button2.Size = New Size(133, 52)
        Button2.TabIndex = 24
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(366, 555)
        Button3.Name = "Button3"
        Button3.Size = New Size(129, 52)
        Button3.TabIndex = 25
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(599, 93)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(580, 514)
        DataGridView1.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(34, 83)
        Label10.Name = "Label10"
        Label10.Size = New Size(148, 31)
        Label10.TabIndex = 28
        Label10.Text = "Employee ID"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(280, 83)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(223, 39)
        TextBox4.TabIndex = 27
        ' 
        ' Label11
        ' 
        Label11.Image = CType(resources.GetObject("Label11.Image"), Image)
        Label11.Location = New Point(1118, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(50, 41)
        Label11.TabIndex = 79
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1180, 630)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(TextBox4)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee"
        Text = "Employee"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
