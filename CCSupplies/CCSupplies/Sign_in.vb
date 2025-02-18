Imports FireSharp.Config
Imports FireSharp.Interfaces
Public Class Sign_in
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "F1e80Y0lU7wAbWgDUPpRyeOo0wOcb4wudvGe4QUz",
        .BasePath = "https://construction-c1b8c-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }
    Private client As IFirebaseClient

    Private Sub Sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Close()
    End Sub

    Private Sub ClearValidationLabels()
        Label12.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""
    End Sub

    Private Function IsEmptyTextBox(textBox As TextBox, label As Label, errorMessage As String) As Boolean
        If textBox.Text.Trim() = "" Then
            label.Text = errorMessage
            Return True
        End If
        Return False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearValidationLabels()

        Dim anyEmpty As Boolean = False

        anyEmpty = anyEmpty Or IsEmptyTextBox(TextBox1, Label12, "Name is required")
        anyEmpty = anyEmpty Or IsEmptyTextBox(TextBox2, Label13, "Lastname is required")
        anyEmpty = anyEmpty Or IsEmptyTextBox(TextBox4, Label14, "Address is required")
        anyEmpty = anyEmpty Or IsEmptyTextBox(TextBox5, Label15, "Username is required")
        anyEmpty = anyEmpty Or IsEmptyTextBox(TextBox6, Label16, "Password is required")
        'Checking password criteria
        If TextBox6.Text.Trim() = "" Then
            Label16.Text = "Password is required"
            anyEmpty = True
        ElseIf TextBox6.Text.Length < 8 Then
            Label16.Text = "Password must be at least 8 characters long"
            anyEmpty = True
        ElseIf Not ContainsUpperCase(TextBox6.Text) Then
            Label16.Text = "Password must contain at least one uppercase letter"
            anyEmpty = True
        ElseIf Not ContainsSymbol(TextBox6.Text) Then
            Label16.Text = "Password must contain at least one symbol"
            anyEmpty = True
        End If

        If Not anyEmpty Then
            ' Proceed with registration
            Dim response = client.Get("Employees/" & TextBox5.Text)

            If response.Body.ToLower() = "null" Then
                ' Username doesn't exist, proceed with registration
                Dim employee = New Employee() With
                {
                  .firstname = TextBox1.Text,
                  .lastname = TextBox2.Text,
                  .address = TextBox4.Text,
                  .username = TextBox5.Text,
                  .password = TextBox6.Text,
                  .profile_img = "https://firebasestorage.googleapis.com/v0/b/construction-c1b8c.appspot.com/o/Profiles%2Fuser%20(1).png?alt=media&token=e89036c9-11a5-400e-87b0-e3f9cf328432"
                }

                Dim Setresponse = client.Set("Employees/" & TextBox5.Text, employee)
                If Setresponse IsNot Nothing Then
                    MessageBox.Show("User added successfully")
                    Login.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Failed to add user")
                End If
            Else
                ' Username already exists
                Label15.Text = "Username is already taken"
            End If
        End If
    End Sub

    Private Sub TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp, TextBox2.KeyUp, TextBox4.KeyUp, TextBox5.KeyUp, TextBox6.KeyUp
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        Dim label As Label = Nothing
        Select Case textBox.Name
            Case "TextBox1"
                label = Label12
            Case "TextBox2"
                label = Label13
            Case "TextBox4"
                label = Label14
            Case "TextBox5"
                label = Label15
            Case "TextBox6"
                label = Label16
        End Select
        If label IsNot Nothing Then
            label.Text = ""
        End If
    End Sub

    Private Function ContainsUpperCase(password As String) As Boolean
        For Each c As Char In password
            If Char.IsUpper(c) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function ContainsSymbol(password As String) As Boolean
        Dim symbols As String = "!@#$%^&*()_-+={[}]|:;'<,>.?/"
        For Each c As Char In password
            If symbols.Contains(c) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox6.UseSystemPasswordChar = False
        Else
            TextBox6.UseSystemPasswordChar = True
        End If
    End Sub
End Class