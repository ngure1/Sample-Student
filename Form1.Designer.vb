<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Welcome1 = New Welcome()
        RudStudent1 = New RUDStudent()
        AddStudent1 = New addStudent()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 610)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(33, 237)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 67)
        Button2.TabIndex = 1
        Button2.Text = "RUD Students"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(33, 127)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 65)
        Button1.TabIndex = 1
        Button1.Text = "Add Student"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Welcome1)
        Panel2.Controls.Add(RudStudent1)
        Panel2.Controls.Add(AddStudent1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(300, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1026, 610)
        Panel2.TabIndex = 1
        ' 
        ' Welcome1
        ' 
        Welcome1.Location = New Point(21, 29)
        Welcome1.Name = "Welcome1"
        Welcome1.Size = New Size(1002, 569)
        Welcome1.TabIndex = 2
        ' 
        ' RudStudent1
        ' 
        RudStudent1.Location = New Point(21, 29)
        RudStudent1.Name = "RudStudent1"
        RudStudent1.Size = New Size(1002, 569)
        RudStudent1.TabIndex = 1
        ' 
        ' AddStudent1
        ' 
        AddStudent1.Location = New Point(21, 29)
        AddStudent1.Name = "AddStudent1"
        AddStudent1.Size = New Size(835, 516)
        AddStudent1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1326, 610)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "StudentTest"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents AddStudent1 As addStudent
    Friend WithEvents RudStudent1 As RUDStudent
    Friend WithEvents Welcome1 As Welcome
End Class
