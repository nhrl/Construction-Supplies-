﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        username = New TextBox()
        password = New TextBox()
        Button1 = New Button()
        Label5 = New Label()
        LinkLabel1 = New LinkLabel()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        usernameErr = New Label()
        passErr = New Label()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' username
        ' 
        username.Anchor = AnchorStyles.Top
        username.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        username.BorderStyle = BorderStyle.FixedSingle
        username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        username.ForeColor = SystemColors.WindowText
        username.Location = New Point(134, 187)
        username.Multiline = True
        username.Name = "username"
        username.Size = New Size(380, 27)
        username.TabIndex = 3
        ' 
        ' password
        ' 
        password.Anchor = AnchorStyles.Top
        password.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        password.BorderStyle = BorderStyle.FixedSingle
        password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        password.Location = New Point(134, 270)
        password.Margin = New Padding(5, 3, 3, 3)
        password.Name = "password"
        password.Size = New Size(380, 29)
        password.TabIndex = 4
        password.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.BackColor = Color.FromArgb(CByte(17), CByte(33), CByte(51))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(267, 332)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 37)
        Button1.TabIndex = 7
        Button1.Text = "Log in"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Location = New Point(234, 388)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 15)
        Label5.TabIndex = 8
        Label5.Text = "Don't have an account?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Anchor = AnchorStyles.Top
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(362, 388)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(50, 15)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sign up "
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(17), CByte(33), CByte(51))
        Label3.Location = New Point(101, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 21)
        Label3.TabIndex = 10
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(17), CByte(33), CByte(51))
        Label4.Location = New Point(101, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 21)
        Label4.TabIndex = 11
        Label4.Text = "Password"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Location = New Point(214, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(231, 183)
        Panel1.TabIndex = 12
        ' 
        ' usernameErr
        ' 
        usernameErr.AutoSize = True
        usernameErr.ForeColor = Color.Red
        usernameErr.Location = New Point(134, 217)
        usernameErr.Name = "usernameErr"
        usernameErr.Size = New Size(0, 15)
        usernameErr.TabIndex = 15
        ' 
        ' passErr
        ' 
        passErr.AutoSize = True
        passErr.ForeColor = Color.Red
        passErr.Location = New Point(134, 300)
        passErr.Name = "passErr"
        passErr.Size = New Size(0, 15)
        passErr.TabIndex = 16
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Cursor = Cursors.Hand
        CheckBox1.FlatStyle = FlatStyle.Flat
        CheckBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.Location = New Point(520, 274)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(57, 21)
        CheckBox1.TabIndex = 17
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ClientSize = New Size(654, 461)
        Controls.Add(CheckBox1)
        Controls.Add(passErr)
        Controls.Add(usernameErr)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(LinkLabel1)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(password)
        Controls.Add(username)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents usernameErr As Label
    Friend WithEvents passErr As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
