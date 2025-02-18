Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO
Imports System.Net.Http
Public Class MainMenu

    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "F1e80Y0lU7wAbWgDUPpRyeOo0wOcb4wudvGe4QUz",
        .BasePath = "https://construction-c1b8c-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }
    Private client As IFirebaseClient
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(Overview, "Overview")
        Menuloader()
    End Sub

    Public Async Sub Menuloader()
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client IsNot Nothing Then
                Dim res = client.Get("Employees/" + Login.ID)
                If res IsNot Nothing AndAlso res.Body IsNot Nothing Then
                    Dim employee As Employee = res.ResultAs(Of Employee)()
                    ' Check if the employee has a profile image URL
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
            Else
                MessageBox.Show("Firebase connection failed")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub SwitchPanel(panel As Form, title As String)
        TitleName.Text = title
        Panel5.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel5.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub ChangePanel(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Profile_picture.Click
        Dim buttonClicked = DirectCast(sender, Control)
        Dim panelToShow As Form = Nothing
        Dim title = ""

        Select Case buttonClicked.Name
            Case "Button1"
                panelToShow = Overview
                title = "Main"
            Case "Button2"
                panelToShow = Orders
                title = "Orders"
            Case "Button3"
                panelToShow = inv
                title = "Inventory"
            Case "Profile_picture"
                panelToShow = UserProfile
                title = "Profile"
        End Select

        SwitchPanel(panelToShow, title)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Login.Show()
        Me.Close()
    End Sub
End Class
