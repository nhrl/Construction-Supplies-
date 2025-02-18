Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Firebase.Storage
Imports System.IO
Imports System.Net.Http
Imports System.Net

Public Class UserProfile
    Public Shared Firstname As String
    Public Shared Lastname As String
    Public Shared Address As String
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "F1e80Y0lU7wAbWgDUPpRyeOo0wOcb4wudvGe4QUz",
        .BasePath = "https://construction-c1b8c-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }
    Private client As IFirebaseClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateProfile.Show()
    End Sub

    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Async Sub LoadData()
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client IsNot Nothing Then
                Dim res = client.Get("Employees/" + Login.ID)
                If res IsNot Nothing Then
                    If res.Body IsNot Nothing Then
                        Dim employee As Employee = res.ResultAs(Of Employee)()
                        DisplayName.Text = employee.firstname
                        DisplayLastName.Text = employee.lastname
                        DisplayAddress.Text = employee.address
                        Firstname = employee.firstname
                        Lastname = employee.lastname
                        Address = employee.address
                        If Not String.IsNullOrEmpty(employee.profile_img) Then
                            Using client As New HttpClient()
                                Dim imgResponse As HttpResponseMessage = Await client.GetAsync(employee.profile_img)
                                If imgResponse.IsSuccessStatusCode Then
                                    Using imgStream As Stream = Await imgResponse.Content.ReadAsStreamAsync()
                                        Profile_picture.BackgroundImage = Image.FromStream(imgStream)
                                    End Using
                                Else
                                    MessageBox.Show("Failed to load image. Status code: " & imgResponse.StatusCode.ToString())
                                End If
                            End Using
                        End If
                    End If
                End If
            Else
                MessageBox.Show("Firebase connection failed")
            End If
        Catch ex As Exception
            MessageBox.Show("Error123: " & ex.Message)
        End Try
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Open file dialog to select an image file
        Dim openFileDialog1 As New OpenFileDialog()

        ' Set filter to allow only image files
        openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim imagePath As String = openFileDialog1.FileName

            ' Do something with the image path, like displaying it in a PictureBox
            'Profile_picture.Image = Image.FromFile(imagePath)
            Loader.Show()

            Dim downloadUrl As String = Await UploadToFirebase(imagePath)

            If Not String.IsNullOrEmpty(downloadUrl) Then
                ' Update profile picture
                Dim res = client.Get("Employees/" + Login.ID)
                Dim employee As Employee = res.ResultAs(Of Employee)()
                Dim oldProfile As String = employee.profile_img
                employee.profile_img = downloadUrl
                Dim updateResponse = client.Update("Employees/" + Login.ID, employee)
                If updateResponse.StatusCode = 200 Then
                    ' If update is successful, delete old profile picture
                    Await DeleteFromFirebaseStorage(oldProfile)
                    MessageBox.Show("Employee data updated successfully")
                    ' Reload data
                    MainMenu.Menuloader()
                    LoadData()
                Else
                    MessageBox.Show("Failed to update employee data")
                End If
            Else
                MessageBox.Show("Failed to upload new profile picture")
            End If

            Loader.Dispose()
        End If
    End Sub

    Private Async Function UploadToFirebase(imagePath As String) As Task(Of String)
        Try
            Dim storageBucketUrl As String = "construction-c1b8c.appspot.com"

            ' Initialize Firebase storage with the storage bucket URL
            Dim storage = New FirebaseStorage(storageBucketUrl)

            ' Upload the image
            Dim uploadTask = storage.Child("Profiles").Child(Path.GetFileName(imagePath)).PutAsync(File.Open(imagePath, FileMode.Open))

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
                    Await storage.Child("Profiles").Child(fileName).DeleteAsync()

                    ' Log deletion success
                    Console.WriteLine("Successfully deleted file: " & fileName)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting file from Firebase Storage: " & ex.Message)
        End Try
    End Function
End Class