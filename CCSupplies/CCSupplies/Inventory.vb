Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports Firebase.Storage
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class inv

    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "F1e80Y0lU7wAbWgDUPpRyeOo0wOcb4wudvGe4QUz",
        .BasePath = "https://construction-c1b8c-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }
    Private client As IFirebaseClient

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Async Sub LoadData()
        DataGridView1.Rows.Clear()
        DataGridView1.AllowUserToAddRows = False
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client IsNot Nothing Then
                Dim load As FirebaseResponse = client.Get("Product")

                ' Check if the response is successful and data is available
                If load IsNot Nothing AndAlso load.Body IsNot Nothing Then
                    Dim data As Dictionary(Of String, Product) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Product))(load.Body.ToString())

                    If data IsNot Nothing Then
                        For Each item As KeyValuePair(Of String, Product) In data
                            ' Add the row to the DataGridView
                            Dim rowIndex As Integer = DataGridView1.Rows.Add(item.Value.Product_ID, item.Value.Product_Name,
                                               item.Value.Category, item.Value.Quantity, item.Value.Price)

                            ' Load the image from the URL
                            Using client As New HttpClient()
                                Dim imgResponse As HttpResponseMessage = Await client.GetAsync(item.Value.Image)
                                If imgResponse.IsSuccessStatusCode Then
                                    Dim imgStream As Stream = Await imgResponse.Content.ReadAsStreamAsync()
                                    Dim product_pic As Image = Image.FromStream(imgStream)
                                    DataGridView1.Rows(rowIndex).Cells("pic").Value = product_pic
                                Else
                                    MessageBox.Show("Failed to load image. Status code: " & imgResponse.StatusCode.ToString())
                                End If
                            End Using
                        Next
                    Else
                        MessageBox.Show("No data found.")
                    End If
                Else
                    MessageBox.Show("No response from Firebase.")
                End If
            Else
                MessageBox.Show("Firebase connection failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddProduct.Show()
    End Sub

    Private lastSelectedCategory As String = "All" ' Default value

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Dim searchTerm As String = TextBox1.Text.Trim().ToLower()

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim productName As String = row.Cells("pname").Value?.ToString().ToLower() ' Using null conditional operator
                Dim rowCategory As String = row.Cells("category").Value?.ToString()

                ' Check if the row is in edit mode
                If Not row.IsNewRow AndAlso Not row.Cells("pname").IsInEditMode Then
                    ' Check if the row belongs to the last selected category and matches the search term
                    row.Visible = (rowCategory = lastSelectedCategory OrElse lastSelectedCategory = "All") AndAlso
                              (String.IsNullOrEmpty(searchTerm) OrElse productName.Contains(searchTerm))
                End If
            End If
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedCategory As String = ComboBox1.SelectedItem?.ToString()

        ' If ComboBox is blank, reset DataGridView to display all products
        If String.IsNullOrEmpty(selectedCategory) Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    row.Visible = True
                End If
            Next
        Else
            ' ComboBox has a category selected
            lastSelectedCategory = selectedCategory

            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim rowCategory As String = row.Cells("category").Value?.ToString()

                    ' Check if the row is in edit mode
                    If Not row.Cells("category").IsInEditMode Then
                        ' Check if the row belongs to the selected category or matches the "All" category
                        row.Visible = (rowCategory = lastSelectedCategory OrElse lastSelectedCategory = "All")
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is in the 6th column
        If e.ColumnIndex = 6 AndAlso e.RowIndex >= 0 Then
            ' Get the data from the clicked row
            Dim rowData As New List(Of Object)()
            For Each cell As DataGridViewCell In DataGridView1.Rows(e.RowIndex).Cells
                rowData.Add(cell.Value)
            Next
            EditProduct.SetRowData(rowData)
            EditProduct.Show()
        ElseIf e.ColumnIndex = 7 AndAlso e.RowIndex >= 0 Then
            Dim rowData As New List(Of Object)()
            For Each cell As DataGridViewCell In DataGridView1.Rows(e.RowIndex).Cells
                rowData.Add(cell.Value)
            Next
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this Product " + rowData(1) + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Loader.Show()
                Dim produt_Id As String = rowData(0).ToString
                DeleteProduct(produt_Id)
            End If
        End If
    End Sub

    Public Async Sub DeleteProduct(productId As String)
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client IsNot Nothing Then
                Dim res = client.Get("Product/" + productId)
                If res IsNot Nothing AndAlso res.Body IsNot Nothing Then
                    Dim prod As Product = res.ResultAs(Of Product)
                    Dim image As String = prod.Image
                    Dim deleteResponse As FirebaseResponse = Await client.DeleteAsync("Product/" & productId)
                    If deleteResponse.StatusCode = 200 Then
                        Await DeleteFromFirebaseStorage(image)
                        Loader.Close()
                        MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadData() ' Refresh the DataGridView after deletion
                    Else
                        Loader.Close()
                        MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                Loader.Close()
                MessageBox.Show("Firebase connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Loader.Close()
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Async Function DeleteFromFirebaseStorage(imageUrl As String) As Task
        Try
            If Not String.IsNullOrEmpty(imageUrl) Then
                ' Decode the URL
                Dim decodedUrl As String = WebUtility.UrlDecode(imageUrl)
                ' Extract filename from decoded URL
                Dim fileName As String = Path.GetFileName(New Uri(decodedUrl).AbsolutePath)
                If fileName = "user%20(1).png" Then
                    Return
                Else
                    ' Initialize Firebase storage with the default bucket
                    Dim storageBucketUrl As String = "construction-c1b8c.appspot.com"
                    Dim storage = New FirebaseStorage(storageBucketUrl)

                    ' Delete file from Firebase Storage
                    Await storage.Child("Products").Child(fileName).DeleteAsync()

                    ' Log deletion success
                    Console.WriteLine("Successfully deleted file: " & fileName)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting file from Firebase Storage: " & ex.Message)
        End Try
    End Function
End Class
