Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Firebase.Storage
Imports FireSharp.Config
Imports FireSharp.Interfaces

Public Class EditProduct
    Public prdID As String
    Public imageCheck As String
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "F1e80Y0lU7wAbWgDUPpRyeOo0wOcb4wudvGe4QUz",
        .BasePath = "https://construction-c1b8c-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }
    Private client As IFirebaseClient
    Private Sub EditProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Async Sub LoadData()
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client IsNot Nothing Then
                Dim res = client.Get("Product/" + prdID)
                If res IsNot Nothing AndAlso res.Body IsNot Nothing Then
                    Dim prod As Product = res.ResultAs(Of Product)
                    TextBox1.Text = prod.Product_Name
                    ComboBox1.Text = prod.Category
                    TextBox2.Text = prod.Quantity
                    TextBox3.Text = prod.Price
                    PictureBox1.Tag = prod.Image
                    imageCheck = prod.Image
                    Using client As New HttpClient()
                        Dim imgResponse As HttpResponseMessage = Await client.GetAsync(prod.Image)
                        If imgResponse.IsSuccessStatusCode Then
                            Dim imgStream As Stream = Await imgResponse.Content.ReadAsStreamAsync()
                            PictureBox1.BackgroundImage = Image.FromStream(imgStream)
                        Else
                            MessageBox.Show("Failed to load image. Status code: " & imgResponse.StatusCode.ToString())
                        End If
                    End Using
                End If
            Else
                MessageBox.Show("Firebase connection failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private rowData As List(Of Object)

    Public Sub SetRowData(data As List(Of Object))
        rowData = data
        prdID = rowData(0).ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog1.FileName
            Using fs As New FileStream(imagePath, FileMode.Open, FileAccess.Read)
                PictureBox1.Image = Image.FromStream(fs)
                PictureBox1.Tag = imagePath
            End Using
        End If
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Loader.Show()

        ' Validate input fields
        Dim errorMessage As String = ""

        errorMessage &= ValidateField(TextBox1.Text, "Product Name is required.", Label10)
        errorMessage &= ValidateField(ComboBox1.Text, "Category is required.", Label11)

        Dim quantity As Integer
        errorMessage &= ValidateNumericField(TextBox2.Text, "Quantity", Label12, quantity)

        Dim price As Decimal
        errorMessage &= ValidateNumericField(TextBox3.Text, "Price", Label13, price)

        errorMessage &= ValidateField(PictureBox1.Tag, "Product Image is required.", Label14)

        ' Check if there are any validation errors
        If errorMessage = "" Then
            ' If inputs are valid, proceed with updating data
            Dim dataToUpdate As New Product With {
            .Product_ID = prdID,
            .Product_Name = TextBox1.Text,
            .Category = ComboBox1.Text,
            .Quantity = quantity,
            .Price = price
        }

            ' Check if the image has changed
            If imageCheck <> PictureBox1.Tag Then
                ' Upload new product image
                Dim downloadUrl As String = Await UploadToFirebase(PictureBox1.Tag)
                If Not String.IsNullOrEmpty(downloadUrl) Then
                    dataToUpdate.Image = downloadUrl

                    Try
                        Dim response = client.UpdateAsync("Product/" & prdID, dataToUpdate)
                        If response IsNot Nothing Then
                            Await DeleteFromFirebaseStorage(imageCheck)
                            MessageBox.Show("Product data updated successfully")
                        Else
                            MessageBox.Show("Failed to update Product data")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End If
            Else
                ' If nothing changed in the image, update data without uploading
                dataToUpdate.Image = PictureBox1.Tag

                Try
                    Dim response = client.UpdateAsync("Product/" & prdID, dataToUpdate)
                    If response IsNot Nothing Then
                        MessageBox.Show("Product data updated successfully")
                    Else
                        MessageBox.Show("Failed to update Product data")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End If

            Loader.Close()
            Me.Close()
            inv.LoadData()
        Else
            ' Display error messages
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Loader.Close()
        End If
    End Sub

    Private Function ValidateField(fieldValue As String, errorMessage As String, errorLabel As Label) As String
        If String.IsNullOrWhiteSpace(fieldValue) Then
            errorLabel.Text = errorMessage
            Return errorMessage & vbCrLf
        Else
            errorLabel.Text = ""
            Return ""
        End If
    End Function

    Private Function ValidateNumericField(fieldValue As String, fieldName As String, errorLabel As Label, ByRef fieldValueParsed As Object) As String
        If String.IsNullOrWhiteSpace(fieldValue) Then
            errorLabel.Text = fieldName & " is required"
            Return fieldName & " is required" & vbCrLf
        Else
            Dim parsedInt As Integer
            Dim parsedDecimal As Decimal

            If Integer.TryParse(fieldValue.Trim(), parsedInt) Then
                fieldValueParsed = parsedInt
                errorLabel.Text = ""
                Return ""
            ElseIf Decimal.TryParse(fieldValue.Trim(), parsedDecimal) Then
                fieldValueParsed = parsedDecimal
                errorLabel.Text = ""
                Return ""
            Else
                errorLabel.Text = fieldName & " must be a valid number."
                Return fieldName & " must be a valid number." & vbCrLf
            End If
        End If
    End Function

    Private Async Function UploadToFirebase(imagePath As String) As Task(Of String)
        Try
            Dim storageBucketUrl As String = "construction-c1b8c.appspot.com"

            ' Initialize Firebase storage with the storage bucket URL
            Dim storage = New FirebaseStorage(storageBucketUrl)

            ' Upload the image
            Dim uploadTask = storage.Child("Products").Child(Path.GetFileName(imagePath)).PutAsync(File.Open(imagePath, FileMode.Open))

            ' Get the download URL
            Dim downloadUrl = Await uploadTask

            ' Return the download URL
            Return downloadUrl
        Catch ex As Exception
            MsgBox("Error uploading image: " & ex.Message)
            Return Nothing
        End Try
    End Function

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