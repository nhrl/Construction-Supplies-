<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(39, 63)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(281, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 21)
        Label1.TabIndex = 1
        Label1.Text = "Product Name"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top
        ComboBox1.FlatStyle = FlatStyle.Popup
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Tools and Equipment", "Concrete and Mansonry", "Paints", "Wires and Cables", "Appliances"})
        ComboBox1.Location = New Point(39, 156)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(281, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 21)
        Label2.TabIndex = 3
        Label2.Text = "Category"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 21)
        Label3.TabIndex = 5
        Label3.Text = "Quantity"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(39, 239)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(281, 27)
        TextBox2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(12, 302)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 21)
        Label4.TabIndex = 7
        Label4.Text = "Price"
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(39, 342)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(281, 27)
        TextBox3.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.BackColor = SystemColors.AppWorkspace
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(373, 63)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(263, 174)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(450, 269)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 49)
        Button1.TabIndex = 9
        Button1.Text = "Browse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button2.Location = New Point(249, 400)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 38)
        Button2.TabIndex = 10
        Button2.Text = "Add Product"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(39, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 17)
        Label5.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(39, 182)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 17)
        Label6.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(39, 269)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 17)
        Label7.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(39, 372)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 17)
        Label8.TabIndex = 14
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(373, 244)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 17)
        Label9.TabIndex = 15
        ' 
        ' AddProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(658, 463)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "AddProduct"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddProduct"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
