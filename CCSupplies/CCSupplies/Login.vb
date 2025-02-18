Imports FireSharp.Config
Imports FireSharp.Interfaces

Public Class Login
    Public Shared ID As String
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "F1e80Y0lU7wAbWgDUPpRyeOo0wOcb4wudvGe4QUz",
        .BasePath = "https://construction-c1b8c-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }
    Private client As IFirebaseClient

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearErrors()
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

    Private Sub ClearErrors()
        usernameErr.Text = ""
        passErr.Text = ""
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Sign_in.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearErrors()
        If String.IsNullOrWhiteSpace(username.Text) Then
            usernameErr.Text = "Username is required"
        ElseIf String.IsNullOrWhiteSpace(password.Text) Then
            passErr.Text = "Password is required"
        Else
            Try
                Dim result = client.Get("Employees/" & username.Text)
                If result IsNot Nothing Then
                    If result.Body IsNot Nothing Then
                        Dim employee As Employee = result.ResultAs(Of Employee)()
                        If employee IsNot Nothing AndAlso employee.password = password.Text Then
                            ID = username.Text
                            MainMenu.Show()
                            Me.Hide()
                        Else
                            passErr.Text = "Invalid password"
                        End If
                    Else
                        usernameErr.Text = "Username not found" ' Adjust the error message accordingly
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub username_KeyUp(sender As Object, e As KeyEventArgs) Handles username.KeyUp
        ClearErrors()
    End Sub

    Private Sub password_KeyUp(sender As Object, e As KeyEventArgs) Handles password.KeyUp
        ClearErrors()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        password.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub
End Class

