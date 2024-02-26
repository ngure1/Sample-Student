<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RUDStudent
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
        UpdateBtn = New Button()
        DataGridView1 = New DataGridView()
        DeleteBtn = New Button()
        LocationTextBox = New TextBox()
        RegNoTextBox = New TextBox()
        NameTextBox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        IdTextBox = New TextBox()
        Label4 = New Label()
        Panel1 = New Panel()
        RefreshBtn = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' UpdateBtn
        ' 
        UpdateBtn.BackColor = SystemColors.HotTrack
        UpdateBtn.FlatStyle = FlatStyle.Flat
        UpdateBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateBtn.ForeColor = SystemColors.ButtonHighlight
        UpdateBtn.Location = New Point(677, 462)
        UpdateBtn.Name = "UpdateBtn"
        UpdateBtn.Size = New Size(138, 59)
        UpdateBtn.TabIndex = 0
        UpdateBtn.Text = "UPDATE"
        UpdateBtn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 17)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1008, 287)
        DataGridView1.TabIndex = 3
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.Firebrick
        DeleteBtn.FlatStyle = FlatStyle.Flat
        DeleteBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleteBtn.ForeColor = SystemColors.ButtonHighlight
        DeleteBtn.Location = New Point(677, 380)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(138, 59)
        DeleteBtn.TabIndex = 0
        DeleteBtn.Text = "DELETE"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' LocationTextBox
        ' 
        LocationTextBox.BorderStyle = BorderStyle.FixedSingle
        LocationTextBox.Font = New Font("Segoe UI", 10F)
        LocationTextBox.Location = New Point(285, 498)
        LocationTextBox.Name = "LocationTextBox"
        LocationTextBox.Size = New Size(252, 34)
        LocationTextBox.TabIndex = 18
        ' 
        ' RegNoTextBox
        ' 
        RegNoTextBox.BorderStyle = BorderStyle.FixedSingle
        RegNoTextBox.Font = New Font("Segoe UI", 10F)
        RegNoTextBox.Location = New Point(285, 440)
        RegNoTextBox.Name = "RegNoTextBox"
        RegNoTextBox.Size = New Size(252, 34)
        RegNoTextBox.TabIndex = 17
        ' 
        ' NameTextBox
        ' 
        NameTextBox.BorderStyle = BorderStyle.FixedSingle
        NameTextBox.Font = New Font("Segoe UI", 10F)
        NameTextBox.Location = New Point(285, 385)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(252, 34)
        NameTextBox.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(141, 503)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 29)
        Label3.TabIndex = 15
        Label3.Text = "Location"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(10, 440)
        Label2.Name = "Label2"
        Label2.Size = New Size(235, 29)
        Label2.TabIndex = 14
        Label2.Text = "Registration Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(167, 390)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 29)
        Label1.TabIndex = 13
        Label1.Text = "Name"
        ' 
        ' IdTextBox
        ' 
        IdTextBox.BorderStyle = BorderStyle.FixedSingle
        IdTextBox.Font = New Font("Segoe UI", 10F)
        IdTextBox.Location = New Point(285, 332)
        IdTextBox.Name = "IdTextBox"
        IdTextBox.Size = New Size(252, 34)
        IdTextBox.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(209, 337)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 29)
        Label4.TabIndex = 19
        Label4.Text = "ID"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1008, 312)
        Panel1.TabIndex = 21
        ' 
        ' RefreshBtn
        ' 
        RefreshBtn.BackColor = SystemColors.InfoText
        RefreshBtn.FlatStyle = FlatStyle.Flat
        RefreshBtn.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RefreshBtn.ForeColor = SystemColors.ButtonHighlight
        RefreshBtn.Location = New Point(848, 380)
        RefreshBtn.Name = "RefreshBtn"
        RefreshBtn.Size = New Size(128, 59)
        RefreshBtn.TabIndex = 22
        RefreshBtn.Text = "REFRESH"
        RefreshBtn.UseVisualStyleBackColor = False
        ' 
        ' RUDStudent
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(RefreshBtn)
        Controls.Add(Panel1)
        Controls.Add(IdTextBox)
        Controls.Add(Label4)
        Controls.Add(LocationTextBox)
        Controls.Add(RegNoTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DeleteBtn)
        Controls.Add(UpdateBtn)
        Name = "RUDStudent"
        Size = New Size(1014, 591)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UpdateBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents RegNoTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RefreshBtn As Button

End Class
