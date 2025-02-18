Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class Orders
    Public status As String
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "F1e80Y0lU7wAbWgDUPpRyeOo0wOcb4wudvGe4QUz",
        .BasePath = "https://construction-c1b8c-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }
    Private client As IFirebaseClient
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetButtonColors(Orderbtn, "#4A6FA5")
        status = "Order Placed"
        LoadData(status)
    End Sub

    Public Sub LoadData(status As String)
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.AllowUserToAddRows = False
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client IsNot Nothing Then
                Dim load As FirebaseResponse = client.Get("Order")

                ' Check if the response is successful and data is available
                If load IsNot Nothing AndAlso load.Body IsNot Nothing Then
                    Dim data As Dictionary(Of String, OrderClass) = JsonConvert.DeserializeObject(Of Dictionary(Of String, OrderClass))(load.Body.ToString())

                    If data IsNot Nothing Then
                        For Each item As KeyValuePair(Of String, OrderClass) In data
                            ' Check if status equals 
                            If item.Value.Status = status Then
                                ' Add the row to the DataGridView
                                Dim rowIndex As Integer = DataGridView1.Rows.Add(item.Value.id, item.Value.fullname,
                                           item.Value.productName, item.Value.quantity, item.Value.subtotal, item.Value.deliveryMethod, item.Value.status, item.Value.siteAddress, item.Value.orderDate, item.Value.recieveDate)
                                Dim cell As DataGridViewButtonCell = CType(DataGridView1.Rows(rowIndex).Cells("stat"), DataGridViewButtonCell)
                                Select Case item.Value.Status
                                    Case "Order Placed"
                                        cell.Style.BackColor = ColorTranslator.FromHtml("#4A6FA5")
                                        cell.Style.ForeColor = Color.Black
                                        cell.Value = "Prepare Order"
                                    Case "Preparing"
                                        cell.Style.BackColor = ColorTranslator.FromHtml("#e9c46a")
                                        cell.Style.ForeColor = Color.Black
                                        cell.Value = "Deliver Order"
                                    Case "Deliver"
                                        cell.Style.BackColor = ColorTranslator.FromHtml("#7ae582")
                                        cell.Style.ForeColor = Color.Black
                                        cell.Value = "Mark as Delivered"
                                    Case "Order Received"
                                        DataGridView1.Rows(rowIndex).Cells("stat") = New DataGridViewTextBoxCell()
                                        DataGridView1.Rows(rowIndex).Cells("stat").Value = "Complete"
                                        DataGridView1.Rows(rowIndex).Cells("stat").Style.BackColor = ColorTranslator.FromHtml("#b298dc")
                                End Select
                            End If
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
    Private Sub SetButtonColors(clickedButton As Button, clickedColor As String)
        ' Set the color of the clicked button
        clickedButton.BackColor = ColorTranslator.FromHtml(clickedColor)

        ' Reset the color of other buttons
        Dim buttonsToReset() As Button = {Orderbtn, Prepbtn, Deliverbtn, Completebtn}
        For Each btn As Button In buttonsToReset
            If btn IsNot clickedButton Then
                btn.BackColor = ColorTranslator.FromHtml("#C0D6DF")
            End If
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Orderbtn.Click, Prepbtn.Click, Deliverbtn.Click, Completebtn.Click
        Dim clickedButton As Button = DirectCast(sender, Button)

        Select Case clickedButton.Name
            Case "Orderbtn"
                status = "Order Placed"
            Case "Prepbtn"
                status = "Preparing"
            Case "Deliverbtn"
                status = "Deliver"
            Case "Completebtn"
                status = "Order Received"
        End Select
        LoadData(status)
        SetButtonColors(clickedButton, "#4A6FA5")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 10 AndAlso e.RowIndex >= 0 Then
            Dim rowData As New List(Of Object)()
            For Each cell As DataGridViewCell In DataGridView1.Rows(e.RowIndex).Cells
                rowData.Add(cell.Value)
            Next

            If rowData(6).ToString() = "Order Placed" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to move this Order to preparing section?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    UpdateStatus(rowData, "Preparing", "Order Placed")
                End If
            ElseIf rowData(6).ToString = "Preparing" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to move this Order to deliver section?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    UpdateStatus(rowData, "Deliver", "Preparing")
                End If
            ElseIf rowData(6).ToString = "Deliver" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to move this Order to deliver section?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    UpdateStatus(rowData, "Order Received", "Deliver")
                End If
            End If
        End If
    End Sub

    Public Sub UpdateStatus(rowData As List(Of Object), stat As String, currentStat As String)
        Dim orderID = rowData(0).ToString
        Try
            Dim orderRes = client.Get("Order/" + orderID)
            If orderRes IsNot Nothing AndAlso orderRes.Body IsNot Nothing Then
                Dim order As OrderClass = orderRes.ResultAs(Of OrderClass)
                order.status = stat
                If stat = "Order Received" Then
                    order.recieveDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ' Set the receive date
                End If
                Dim res = client.UpdateAsync("Order/" & orderID, order)
                If res IsNot Nothing Then
                    LoadData(currentStat)
                    MessageBox.Show("Order Status updated successfully")
                Else
                    MessageBox.Show("Failed to update Order status")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class