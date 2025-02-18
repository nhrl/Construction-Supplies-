<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sign_in
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_in))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label8 = New Label()
        TextBox6 = New TextBox()
        Button1 = New Button()
        Label9 = New Label()
        LinkLabel1 = New LinkLabel()
        Panel1 = New Panel()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top
        TextBox1.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(152, 181)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(293, 28)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top
        TextBox2.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(152, 264)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(293, 28)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top
        TextBox4.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(152, 334)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(293, 28)
        TextBox4.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(80, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 21)
        Label3.TabIndex = 6
        Label3.Text = "First name"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(82, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 21)
        Label4.TabIndex = 7
        Label4.Text = "Last name"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(82, 312)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 21)
        Label6.TabIndex = 9
        Label6.Text = "Address"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(80, 380)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 21)
        Label7.TabIndex = 11
        Label7.Text = "Username"
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top
        TextBox5.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(152, 413)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(293, 28)
        TextBox5.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(82, 459)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 21)
        Label8.TabIndex = 13
        Label8.Text = "Password"
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.Top
        TextBox6.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox6.Location = New Point(152, 496)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(293, 29)
        TextBox6.TabIndex = 12
        TextBox6.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.BackColor = Color.FromArgb(CByte(17), CByte(33), CByte(51))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(235, 554)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 37)
        Button1.TabIndex = 14
        Button1.Text = "Sign up"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Location = New Point(202, 612)
        Label9.Name = "Label9"
        Label9.Size = New Size(142, 15)
        Label9.TabIndex = 15
        Label9.Text = "Already have an account?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Anchor = AnchorStyles.Top
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(349, 612)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(40, 15)
        LinkLabel1.TabIndex = 16
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Log in"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Location = New Point(152, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(293, 122)
        Panel1.TabIndex = 17
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.Red
        Label12.Location = New Point(152, 212)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 15)
        Label12.TabIndex = 23
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = Color.Red
        Label13.Location = New Point(152, 295)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 15)
        Label13.TabIndex = 24
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = Color.Red
        Label14.Location = New Point(152, 365)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 15)
        Label14.TabIndex = 25
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.ForeColor = Color.Red
        Label15.Location = New Point(152, 444)
        Label15.Name = "Label15"
        Label15.Size = New Size(0, 15)
        Label15.TabIndex = 26
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.ForeColor = Color.Red
        Label16.Location = New Point(152, 527)
        Label16.Name = "Label16"
        Label16.Size = New Size(0, 15)
        Label16.TabIndex = 27
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.Top
        CheckBox1.AutoSize = True
        CheckBox1.Cursor = Cursors.Hand
        CheckBox1.FlatStyle = FlatStyle.Flat
        CheckBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.Location = New Point(451, 499)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(57, 21)
        CheckBox1.TabIndex = 28
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Sign_in
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ClientSize = New Size(587, 677)
        Controls.Add(CheckBox1)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Panel1)
        Controls.Add(LinkLabel1)
        Controls.Add(Label9)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Name = "Sign_in"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign_in"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
