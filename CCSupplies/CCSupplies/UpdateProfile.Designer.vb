<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProfile
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(47, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 25)
        Label1.TabIndex = 0
        Label1.Text = "First name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top
        TextBox1.BackColor = Color.FromArgb(CByte(219), CByte(233), CByte(238))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(86, 53)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(389, 28)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top
        TextBox2.BackColor = Color.FromArgb(CByte(219), CByte(233), CByte(238))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(86, 120)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(389, 28)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(47, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 25)
        Label2.TabIndex = 2
        Label2.Text = "Last name"
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top
        TextBox4.BackColor = Color.FromArgb(CByte(219), CByte(233), CByte(238))
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(86, 189)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(389, 28)
        TextBox4.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(47, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 25)
        Label4.TabIndex = 6
        Label4.Text = "Address"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.BackColor = Color.FromArgb(CByte(43), CByte(240), CByte(122))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(195, 241)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 43)
        Button1.TabIndex = 8
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' UpdateProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(558, 366)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "UpdateProfile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UpdateProfile"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
