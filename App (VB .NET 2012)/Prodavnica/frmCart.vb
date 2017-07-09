Public Class frmCart

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lstCart.SelectedItems.Count = 0 Then
            MsgBox("You must select the item", MsgBoxStyle.Exclamation, "Delete")
        Else
            Dim p As MsgBoxResult
            Dim id As String = Me.lstCart.SelectedItems(0).SubItems(0).Text
            p = MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete")
            If p = MsgBoxResult.Yes Then
                If Cart.DeleteItem(id) Then
                    initDataCart()
                Else
                    MsgBox("It's not possible to delete this item!")
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub InitHeaderCart()
        lstCart.View = View.Details
        lstCart.Columns.Add("ID", 60, HorizontalAlignment.Left)
        lstCart.Columns.Add("Title", 110, HorizontalAlignment.Left)
        lstCart.Columns.Add("Developer", 90, HorizontalAlignment.Left)
        lstCart.Columns.Add("Price", 100, HorizontalAlignment.Left)
    End Sub

    Private Sub initDataCart()
        lstCart.Items.Clear()
        Dim k() As Cart
        Dim count As Integer = 10
        Dim i As Integer
        k = Cart.ListItems(count, GlobalVariables.activeUser.getEmail)

        For i = 0 To count - 1
            Dim lvItem As New ListViewItem(k(i).getId)
            lvItem.SubItems.Add(k(i).getgameTitle)
            lvItem.SubItems.Add(k(i).getDeveloper)
            lvItem.SubItems.Add(Cart.getprice(k(i).getId))
            lstCart.Items.Add(lvItem)
        Next i

    End Sub

    Private Sub frmCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitHeaderCart()
        initDataCart()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        Dim f As New frmPurchase
        Dim i As Integer
        Dim count As Integer = lstCart.Items.Count
        GlobalVariables.sum = 0
        For i = 0 To count - 1
            GlobalVariables.sum += lstCart.Items(i).SubItems(3).Text
        Next
        f.ShowDialog()
    End Sub

    Private Sub frmCart_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        initDataCart()
    End Sub

End Class