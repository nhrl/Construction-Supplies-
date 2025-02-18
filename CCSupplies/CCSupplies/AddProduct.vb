Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports Firebase.Storage
Imports System.IO
Public Class AddProduct
    Dim ImagePath As String
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "F1e80Y0lU7wAbWgDUPpRyeOo0wOcb4wudvGe4QUz",
        .BasePath = "https://construction-c1b8c-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }
    Private client As IFirebaseClient

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client IsNot Nothing Then
                ' Connection successful
            Else
                MessageBox.Show("Firebase connection failed")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ValidateInputs()
    End Sub

    Private Sub ValidateInputs()
        Dim anyEmpty As Boolean = False

        ' Validate individual inputs
        anyEmpty = ValidateTextBox(TextBox1, Label5, "Product Name is required") Or anyEmpty
        anyEmpty = ValidateComboBox(ComboBox1, Label6, "Category is required") Or anyEmpty
        anyEmpty = ValidateNumericInput(TextBox2, Label7, "Quantity must be a valid number") Or anyEmpty
        anyEmpty = ValidateNumericInput(TextBox3, Label8, "Price must be a valid number") Or anyEmpty

        If ImagePath = "" Then
            Label9.Text = "Product Image is required"
            anyEmpty = True
        Else
            Label9.Text = ""
        End If

        If Not anyEmpty Then
            SaveDataToFirebase()
        End If
    End Sub

    Private Function ValidateNumericInput(textBox As System.Windows.Forms.TextBox, label As System.Windows.Forms.Label, errorMessage As String) As Boolean
        Dim value As Decimal
        If Not Decimal.TryParse(textBox.Text.Trim(), value) Then
            label.Text = errorMessage
            Return True
        Else
            label.Text = "" ' Clear the error message if input is a valid number
            Return False
        End If
    End Function

    Private Function ValidateTextBox(textBox As System.Windows.Forms.TextBox, label As System.Windows.Forms.Label, errorMessage As String) As Boolean
        If textBox.Text.Trim() = "" Then
            label.Text = errorMessage
            Return True
        Else
            label.Text = "" ' Clear the error message if input is not empty
            Return False
        End If
    End Function

    Private Function ValidateComboBox(comboBox As System.Windows.Forms.ComboBox, label As System.Windows.Forms.Label, errorMessage As String) As Boolean
        If comboBox.SelectedItem Is Nothing OrElse comboBox.SelectedItem.ToString().Trim() = "" Then
            label.Text = errorMessage
            Return True
        Else
            label.Text = "" ' Clear the error message if an item is selected
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ImagePath = openFileDialog1.FileName
            Using fs As New FileStream(ImagePath, FileMode.Open, FileAccess.Read)
                PictureBox1.Image = Image.FromStream(fs)
            End Using
        End If
    End Sub

    Private Async Sub SaveDataToFirebase()
        Loader.Show()
        Dim productID As String = GenerateRandomID(5)
        Dim downloadUrl As String = Await UploadToFirebase(ImagePath)

        Dim prod As New Product With {
            .Product_ID = productID,
            .Product_Name = TextBox1.Text,
            .Category = ComboBox1.SelectedItem.ToString(),
            .Quantity = Integer.Parse(TextBox2.Text),
            .Price = Decimal.Parse(TextBox3.Text),
            .Image = downloadUrl
        }
        Dim setResponse = client.Set("Product/" & productID, prod)
        If setResponse IsNot Nothing Then
            Loader.Close()
            MessageBox.Show("Product added successfully")
        Else
            Loader.Close()
            MessageBox.Show("Failed to add product")
        End If
        Me.Close()
        inv.LoadData()
    End Sub

    Private Function GenerateRandomID(length As Integer) As String
        Dim chars As String = "0123456789"
        Dim rnd As New Random()
        Dim id As String = ""

        For i As Integer = 1 To length
            Dim index As Integer = rnd.Next(0, chars.Length)
            id &= chars(index)
        Next

        Return id
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
End Class