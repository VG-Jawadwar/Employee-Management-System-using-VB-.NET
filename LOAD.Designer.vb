﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOAD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOAD))
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = Color.White
        ProgressBar1.ForeColor = Color.DarkBlue
        ProgressBar1.Location = New Point(-1, 474)
        ProgressBar1.Minimum = 1
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(779, 28)
        ProgressBar1.TabIndex = 0
        ProgressBar1.Value = 1
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(0), CByte(0))
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 403)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 50)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' LOAD
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(776, 499)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LOAD"
        Text = "LOAD"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
