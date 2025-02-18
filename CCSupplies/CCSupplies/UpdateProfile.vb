Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Public Class UpdateProfile

    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "F1e80Y0lU7wAbWgDUPpRyeOo0wOcb4wudvGe4QUz",
        .BasePath = "https://construction-c1b8c-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }
    Private client As IFirebaseClient
    Private Sub UpdateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = UserProfile.Firstname
        TextBox2.Text = UserProfile.Lastname
        TextBox4.Text = UserProfile.Address
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client IsNot Nothing Then
                'Connection successful
            Else
                MessageBox.Show("Firebase connection failed")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dataToUpdate As New With {
                .firstname = TextBox1.Text,
                .lastname = TextBox2.Text,
                .address = TextBox4.Text
            }

            Dim response = client.UpdateAsync("Employees/" & Login.ID, dataToUpdate)
            If response IsNot Nothing Then
                MessageBox.Show("Employee data updated successfully")
                UserProfile.LoadData()
                Me.Close()
            Else
                MessageBox.Show("Failed to update employee data")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class