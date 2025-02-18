<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inv))
        Button1 = New Button()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        pname = New DataGridViewTextBoxColumn()
        category = New DataGridViewTextBoxColumn()
        quantity = New DataGridViewTextBoxColumn()
        price = New DataGridViewTextBoxColumn()
        pic = New DataGridViewImageColumn()
        edit = New DataGridViewImageColumn()
        delete = New DataGridViewImageColumn()
        Panel1 = New Panel()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.BackColor = Color.FromArgb(CByte(40), CByte(217), CByte(79))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(73, 35)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 39)
        Button1.TabIndex = 0
        Button1.Text = "Add Product"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top
        TextBox1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(280, 41)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(294, 27)
        TextBox1.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"", "Tools and Equipment", "Concrete and Mansonry", "Paints", "Wires and Cables", "Appliances"})
        ComboBox1.Location = New Point(649, 45)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(179, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(591, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 21)
        Label1.TabIndex = 3
        Label1.Text = "Categories"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id, pname, category, quantity, price, pic, edit, delete})
        DataGridView1.Location = New Point(26, 85)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(841, 353)
        DataGridView1.TabIndex = 4
        ' 
        ' id
        ' 
        id.HeaderText = "No."
        id.Name = "id"
        ' 
        ' pname
        ' 
        pname.HeaderText = "Name"
        pname.Name = "pname"
        ' 
        ' category
        ' 
        category.HeaderText = "Category"
        category.Name = "category"
        ' 
        ' quantity
        ' 
        quantity.HeaderText = "Quantity"
        quantity.Name = "quantity"
        ' 
        ' price
        ' 
        price.HeaderText = "Price"
        price.Name = "price"
        ' 
        ' pic
        ' 
        pic.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        pic.HeaderText = "Image"
        pic.ImageLayout = DataGridViewImageCellLayout.Stretch
        pic.Name = "pic"
        ' 
        ' edit
        ' 
        edit.HeaderText = "Edit"
        edit.Image = CType(resources.GetObject("edit.Image"), Image)
        edit.ImageLayout = DataGridViewImageCellLayout.Zoom
        edit.Name = "edit"
        edit.Resizable = DataGridViewTriState.True
        ' 
        ' delete
        ' 
        delete.HeaderText = "Delete"
        delete.Image = CType(resources.GetObject("delete.Image"), Image)
        delete.ImageLayout = DataGridViewImageCellLayout.Zoom
        delete.Name = "delete"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Location = New Point(-5, -5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(894, 84)
        Panel1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(233, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 17)
        Label2.TabIndex = 4
        Label2.Text = "Search Item"
        ' 
        ' inv
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(887, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "inv"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents pname As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents pic As DataGridViewImageColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents delete As DataGridViewImageColumn
End Class
