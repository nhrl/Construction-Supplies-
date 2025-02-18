Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json.Linq

Public Class Overview
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "F1e80Y0lU7wAbWgDUPpRyeOo0wOcb4wudvGe4QUz",
        .BasePath = "https://construction-c1b8c-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }
    Private client As IFirebaseClient
    Private Async Sub Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        client = New FireSharp.FirebaseClient(fcon)
        If client Is Nothing Then
            MessageBox.Show("Failed to connect to Firebase.")
        Else
            Await GetTotal()
        End If
    End Sub

    Public Async Function GetTotal() As Task
        Dim totalProducts As Integer = Await CountTotalProducts()
        Dim totalUsers As Integer = Await CountTotalUser()
        Me.TotalProduct.Text = totalProducts.ToString()
        Me.user.Text = totalUsers.ToString()
    End Function

    Private Async Function CountTotalProducts() As Task(Of Integer)
        Try
            Dim response As FirebaseResponse = Await client.GetAsync("Product")
            Dim products As JToken = JToken.Parse(response.Body)

            Dim totalProducts As Integer
            If products.Type = JTokenType.Object Then
                totalProducts = products.Children().Count()
            ElseIf products.Type = JTokenType.Array Then
                totalProducts = products.Count()
            Else
                totalProducts = 0
            End If

            Return totalProducts
        Catch ex As Exception
            MessageBox.Show("Error counting products: " & ex.Message)
            Return 0
        End Try
    End Function

    Private Async Function CountTotalUser() As Task(Of Integer)
        Try
            Dim response As FirebaseResponse = Await client.GetAsync("Customer")
            Dim products As JToken = JToken.Parse(response.Body)

            Dim totalProducts As Integer
            If products.Type = JTokenType.Object Then
                totalProducts = products.Children().Count()
            ElseIf products.Type = JTokenType.Array Then
                totalProducts = products.Count()
            Else
                totalProducts = 0
            End If

            Return totalProducts
        Catch ex As Exception
            MessageBox.Show("Error counting products: " & ex.Message)
            Return 0
        End Try
    End Function
End Class
