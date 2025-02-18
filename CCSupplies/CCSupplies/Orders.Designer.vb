<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Panel1 = New Panel()
        Completebtn = New Button()
        Deliverbtn = New Button()
        Prepbtn = New Button()
        Orderbtn = New Button()
        DataGridView1 = New DataGridView()
        no = New DataGridViewTextBoxColumn()
        customer = New DataGridViewTextBoxColumn()
        product = New DataGridViewTextBoxColumn()
        quantity = New DataGridViewTextBoxColumn()
        total = New DataGridViewTextBoxColumn()
        payment = New DataGridViewTextBoxColumn()
        current_stat = New DataGridViewTextBoxColumn()
        siteadd = New DataGridViewTextBoxColumn()
        orderDate = New DataGridViewTextBoxColumn()
        recieveDate = New DataGridViewTextBoxColumn()
        stat = New DataGridViewButtonColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        Panel1.Controls.Add(Completebtn)
        Panel1.Controls.Add(Deliverbtn)
        Panel1.Controls.Add(Prepbtn)
        Panel1.Controls.Add(Orderbtn)
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(986, 53)
        Panel1.TabIndex = 0
        ' 
        ' Completebtn
        ' 
        Completebtn.Anchor = AnchorStyles.None
        Completebtn.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        Completebtn.Cursor = Cursors.Hand
        Completebtn.FlatStyle = FlatStyle.Flat
        Completebtn.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Completebtn.Location = New Point(697, 3)
        Completebtn.Name = "Completebtn"
        Completebtn.Size = New Size(164, 45)
        Completebtn.TabIndex = 2
        Completebtn.Text = "Complete"
        Completebtn.UseVisualStyleBackColor = False
        ' 
        ' Deliverbtn
        ' 
        Deliverbtn.Anchor = AnchorStyles.None
        Deliverbtn.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        Deliverbtn.Cursor = Cursors.Hand
        Deliverbtn.FlatStyle = FlatStyle.Flat
        Deliverbtn.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Deliverbtn.Location = New Point(515, 3)
        Deliverbtn.Name = "Deliverbtn"
        Deliverbtn.Size = New Size(164, 45)
        Deliverbtn.TabIndex = 2
        Deliverbtn.Text = "Deliver"
        Deliverbtn.UseVisualStyleBackColor = False
        ' 
        ' Prepbtn
        ' 
        Prepbtn.Anchor = AnchorStyles.None
        Prepbtn.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        Prepbtn.Cursor = Cursors.Hand
        Prepbtn.FlatStyle = FlatStyle.Flat
        Prepbtn.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Prepbtn.Location = New Point(332, 3)
        Prepbtn.Name = "Prepbtn"
        Prepbtn.Size = New Size(164, 45)
        Prepbtn.TabIndex = 2
        Prepbtn.Text = "Preparing"
        Prepbtn.UseVisualStyleBackColor = False
        ' 
        ' Orderbtn
        ' 
        Orderbtn.Anchor = AnchorStyles.None
        Orderbtn.BackColor = Color.FromArgb(CByte(192), CByte(214), CByte(223))
        Orderbtn.Cursor = Cursors.Hand
        Orderbtn.FlatStyle = FlatStyle.Flat
        Orderbtn.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Orderbtn.Location = New Point(152, 3)
        Orderbtn.Name = "Orderbtn"
        Orderbtn.Size = New Size(164, 45)
        Orderbtn.TabIndex = 1
        Orderbtn.Text = "Order"
        Orderbtn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {no, customer, product, quantity, total, payment, current_stat, siteadd, orderDate, recieveDate, stat})
        DataGridView1.Location = New Point(10, 58)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(964, 380)
        DataGridView1.TabIndex = 1
        ' 
        ' no
        ' 
        no.HeaderText = "Order No."
        no.Name = "no"
        no.ReadOnly = True
        ' 
        ' customer
        ' 
        customer.HeaderText = "Customer"
        customer.Name = "customer"
        customer.ReadOnly = True
        customer.Width = 150
        ' 
        ' product
        ' 
        product.HeaderText = "Product"
        product.Name = "product"
        product.ReadOnly = True
        product.Width = 150
        ' 
        ' quantity
        ' 
        quantity.HeaderText = "Quantity"
        quantity.Name = "quantity"
        quantity.ReadOnly = True
        ' 
        ' total
        ' 
        total.HeaderText = "Total"
        total.Name = "total"
        total.ReadOnly = True
        ' 
        ' payment
        ' 
        payment.HeaderText = "Delivery Method"
        payment.Name = "payment"
        payment.ReadOnly = True
        ' 
        ' current_stat
        ' 
        current_stat.HeaderText = "Status"
        current_stat.Name = "current_stat"
        current_stat.ReadOnly = True
        ' 
        ' siteadd
        ' 
        siteadd.HeaderText = "Site Address"
        siteadd.Name = "siteadd"
        siteadd.ReadOnly = True
        ' 
        ' orderDate
        ' 
        orderDate.HeaderText = "Order Date"
        orderDate.Name = "orderDate"
        orderDate.ReadOnly = True
        ' 
        ' recieveDate
        ' 
        recieveDate.HeaderText = "Date Recieve"
        recieveDate.Name = "recieveDate"
        recieveDate.ReadOnly = True
        ' 
        ' stat
        ' 
        stat.HeaderText = "Actions"
        stat.Name = "stat"
        stat.ReadOnly = True
        stat.Resizable = DataGridViewTriState.True
        stat.Width = 120
        ' 
        ' Orders
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(986, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Orders"
        Text = "Orders"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Orderbtn As Button
    Friend WithEvents Completebtn As Button
    Friend WithEvents Deliverbtn As Button
    Friend WithEvents Prepbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents customer As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents payment As DataGridViewTextBoxColumn
    Friend WithEvents current_stat As DataGridViewTextBoxColumn
    Friend WithEvents siteadd As DataGridViewTextBoxColumn
    Friend WithEvents orderDate As DataGridViewTextBoxColumn
    Friend WithEvents recieveDate As DataGridViewTextBoxColumn
    Friend WithEvents stat As DataGridViewButtonColumn
End Class
