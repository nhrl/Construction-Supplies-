<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        Profile_picture = New PictureBox()
        TitleName = New Label()
        Panel5 = New Panel()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(Profile_picture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = Color.FromArgb(CByte(17), CByte(33), CByte(51))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-8, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(237, 568)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(231, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(205, 56)
        Panel2.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button4.BackColor = Color.FromArgb(CByte(17), CByte(33), CByte(51))
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(16, 461)
        Button4.Name = "Button4"
        Button4.Size = New Size(211, 53)
        Button4.TabIndex = 4
        Button4.Text = "Logout"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(17), CByte(33), CByte(51))
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(16, 243)
        Button3.Name = "Button3"
        Button3.Size = New Size(211, 53)
        Button3.TabIndex = 3
        Button3.Text = "Inventory"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(17), CByte(33), CByte(51))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(16, 184)
        Button2.Name = "Button2"
        Button2.Size = New Size(211, 53)
        Button2.TabIndex = 2
        Button2.Text = "Orders"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(17), CByte(33), CByte(51))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(16, 125)
        Button1.Name = "Button1"
        Button1.Size = New Size(211, 53)
        Button1.TabIndex = 1
        Button1.Text = "Main"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Profile_picture)
        Panel3.Controls.Add(TitleName)
        Panel3.Location = New Point(227, -1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1066, 66)
        Panel3.TabIndex = 1
        ' 
        ' Profile_picture
        ' 
        Profile_picture.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Profile_picture.BackgroundImageLayout = ImageLayout.Zoom
        Profile_picture.Cursor = Cursors.Hand
        Profile_picture.Location = New Point(979, 6)
        Profile_picture.Name = "Profile_picture"
        Profile_picture.Size = New Size(54, 50)
        Profile_picture.TabIndex = 2
        Profile_picture.TabStop = False
        ' 
        ' TitleName
        ' 
        TitleName.AutoSize = True
        TitleName.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        TitleName.Location = New Point(8, 12)
        TitleName.Name = "TitleName"
        TitleName.Size = New Size(0, 37)
        TitleName.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.BackColor = Color.Transparent
        Panel5.Location = New Point(235, 71)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1043, 478)
        Panel5.TabIndex = 2
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(219), CByte(233), CByte(238))
        ClientSize = New Size(1290, 561)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "MainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(Profile_picture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TitleName As Label
    Friend WithEvents Profile_picture As PictureBox
End Class
