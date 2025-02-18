<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Overview))
        Panel8 = New Panel()
        TotalProduct = New Label()
        Label4 = New Label()
        Panel6 = New Panel()
        user = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel8
        ' 
        Panel8.Anchor = AnchorStyles.Bottom
        Panel8.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        Panel8.Controls.Add(TotalProduct)
        Panel8.Controls.Add(Label4)
        Panel8.Location = New Point(427, 345)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(148, 87)
        Panel8.TabIndex = 9
        ' 
        ' TotalProduct
        ' 
        TotalProduct.AutoSize = True
        TotalProduct.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TotalProduct.Location = New Point(61, 40)
        TotalProduct.Name = "TotalProduct"
        TotalProduct.Size = New Size(25, 30)
        TotalProduct.TabIndex = 2
        TotalProduct.Text = "2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(3, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 21)
        Label4.TabIndex = 0
        Label4.Text = "Product"
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.Bottom
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(user)
        Panel6.Controls.Add(Label2)
        Panel6.Location = New Point(238, 345)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(148, 87)
        Panel6.TabIndex = 7
        ' 
        ' user
        ' 
        user.AutoSize = True
        user.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        user.Location = New Point(58, 40)
        user.Name = "user"
        user.Size = New Size(37, 30)
        user.TabIndex = 1
        user.Text = "10"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(3, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 0
        Label2.Text = "Customer"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Location = New Point(59, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(687, 291)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(62, 27)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(687, 303)
        AxWindowsMediaPlayer1.TabIndex = 11
        ' 
        ' Overview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(219), CByte(233), CByte(238))
        ClientSize = New Size(805, 460)
        Controls.Add(AxWindowsMediaPlayer1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel8)
        Controls.Add(Panel6)
        FormBorderStyle = FormBorderStyle.None
        Name = "Overview"
        Text = "Overview"
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TotalProduct As Label
    Friend WithEvents user As Label
End Class
