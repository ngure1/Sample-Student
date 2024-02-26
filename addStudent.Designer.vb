<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudent
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        addBtn = New Button()
        LocationTextBox = New TextBox()
        RegNoTextBox = New TextBox()
        NameTextBox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' addBtn
        ' 
        addBtn.BackColor = SystemColors.HotTrack
        addBtn.FlatAppearance.BorderColor = SystemColors.HotTrack
        addBtn.FlatAppearance.BorderSize = 0
        addBtn.FlatStyle = FlatStyle.Flat
        addBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addBtn.ForeColor = SystemColors.HighlightText
        addBtn.Location = New Point(609, 411)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(172, 63)
        addBtn.TabIndex = 13
        addBtn.Text = "ADD"
        addBtn.UseVisualStyleBackColor = False
        ' 
        ' LocationTextBox
        ' 
        LocationTextBox.BorderStyle = BorderStyle.FixedSingle
        LocationTextBox.Font = New Font("Segoe UI", 10F)
        LocationTextBox.Location = New Point(320, 315)
        LocationTextBox.Name = "LocationTextBox"
        LocationTextBox.Size = New Size(252, 34)
        LocationTextBox.TabIndex = 12
        ' 
        ' RegNoTextBox
        ' 
        RegNoTextBox.BorderStyle = BorderStyle.FixedSingle
        RegNoTextBox.Font = New Font("Segoe UI", 10F)
        RegNoTextBox.Location = New Point(320, 214)
        RegNoTextBox.Name = "RegNoTextBox"
        RegNoTextBox.Size = New Size(252, 34)
        RegNoTextBox.TabIndex = 11
        ' 
        ' NameTextBox
        ' 
        NameTextBox.BorderStyle = BorderStyle.FixedSingle
        NameTextBox.Font = New Font("Segoe UI", 10F)
        NameTextBox.Location = New Point(320, 122)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(252, 34)
        NameTextBox.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(176, 320)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 29)
        Label3.TabIndex = 9
        Label3.Text = "Location"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(45, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(235, 29)
        Label2.TabIndex = 8
        Label2.Text = "Registration Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(202, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 29)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' addStudent
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(addBtn)
        Controls.Add(LocationTextBox)
        Controls.Add(RegNoTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "addStudent"
        Size = New Size(936, 576)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addBtn As Button
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents RegNoTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
