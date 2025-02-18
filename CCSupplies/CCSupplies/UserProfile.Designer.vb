<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
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
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        DisplayName = New Label()
        DisplayLastName = New Label()
        DisplayAddress = New Label()
        Button2 = New Button()
        Profile_picture = New PictureBox()
        CType(Profile_picture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(32, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 25)
        Label1.TabIndex = 0
        Label1.Text = "Account Details"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(375, 242)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 35)
        Button1.TabIndex = 2
        Button1.Text = "Update Profile"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(257, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 25)
        Label2.TabIndex = 3
        Label2.Text = "First name: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(257, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 25)
        Label3.TabIndex = 4
        Label3.Text = "Last name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(257, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 25)
        Label5.TabIndex = 6
        Label5.Text = "Address:"
        ' 
        ' DisplayName
        ' 
        DisplayName.AutoSize = True
        DisplayName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayName.Location = New Point(375, 113)
        DisplayName.Name = "DisplayName"
        DisplayName.Size = New Size(0, 21)
        DisplayName.TabIndex = 7
        ' 
        ' DisplayLastName
        ' 
        DisplayLastName.AutoSize = True
        DisplayLastName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayLastName.Location = New Point(375, 150)
        DisplayLastName.Name = "DisplayLastName"
        DisplayLastName.Size = New Size(0, 21)
        DisplayLastName.TabIndex = 8
        ' 
        ' DisplayAddress
        ' 
        DisplayAddress.AutoSize = True
        DisplayAddress.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayAddress.Location = New Point(375, 192)
        DisplayAddress.Name = "DisplayAddress"
        DisplayAddress.Size = New Size(0, 21)
        DisplayAddress.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(32, 242)
        Button2.Name = "Button2"
        Button2.Size = New Size(186, 35)
        Button2.TabIndex = 10
        Button2.Text = "Change Profile Picture"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Profile_picture
        ' 
        Profile_picture.BackgroundImageLayout = ImageLayout.Zoom
        Profile_picture.Location = New Point(32, 86)
        Profile_picture.Name = "Profile_picture"
        Profile_picture.Size = New Size(186, 150)
        Profile_picture.TabIndex = 11
        Profile_picture.TabStop = False
        ' 
        ' UserProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        ClientSize = New Size(800, 450)
        Controls.Add(Profile_picture)
        Controls.Add(Button2)
        Controls.Add(DisplayAddress)
        Controls.Add(DisplayLastName)
        Controls.Add(DisplayName)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "UserProfile"
        Text = "UserProfile"
        CType(Profile_picture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DisplayName As Label
    Friend WithEvents DisplayLastName As Label
    Friend WithEvents DisplayAddress As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Profile_picture As PictureBox
End Class
