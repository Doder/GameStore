Public Class frmGame

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click
        If lstGames.SelectedItems.Count = 0 Then
            MsgBox("Select the game first!", MsgBoxStyle.Exclamation, "Details")
        Else

            Dim frm As New frmDetails(Me.lstGames.SelectedItems.Item(0).SubItems(0).Text)
            frm.Text = Me.lstGames.SelectedItems.Item(0).SubItems(0).Text
            frm.ShowDialog()
        End If

    End Sub

    Private Sub InitHeader()
        lstGames.View = View.Details

        lstGames.Columns.Add("Titles", 200, HorizontalAlignment.Left)
        lstGames.Columns.Add("Price", 200, HorizontalAlignment.Left)
    End Sub

    Private Sub initList()
        lstGames.Items.Clear()
        Dim igre() As Game
        Dim count As Integer
        Dim i As Integer

        igre = Game.ListGames(count, txtFilter.Text)

        For i = 0 To count - 1
            Dim lvItem As New ListViewItem(igre(i).GetTitle)
            lvItem.SubItems.Add(igre(i).GetPrice)
            lstGames.Items.Add(lvItem)
        Next i


    End Sub

    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GlobalVariables.activeUser.getAdmin = 0 Then
            btnAdd.Hide()
            btnDel.Hide()
        End If
        InitHeader()
        initList()
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        initList()
    End Sub




    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As New frmAddGame
        f.ShowDialog()
        initList()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If lstGames.SelectedItems.Count = 0 Then
            MsgBox("Please first select the game you want to delete!", MsgBoxStyle.Exclamation, "Delete")
        Else
            Dim p As MsgBoxResult
            p = MsgBox("Are you sure you want to delete this game?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete")
            If p = MsgBoxResult.Yes Then
                Dim k As New Game(Me.lstGames.SelectedItems(0).SubItems(0).Text, CInt(Me.lstGames.SelectedItems(0).SubItems(1).Text))
                If k.DeleteGame Then
                    initList()
                Else
                    MsgBox("It's not possible to delete this game!")
                End If
            End If
        End If
    End Sub

    Private Sub btnToCart_Click(sender As Object, e As EventArgs) Handles btnToCart.Click
        If lstGames.SelectedItems.Count = 0 Then
            MsgBox("Please first select the game you want to add to cart!", MsgBoxStyle.Exclamation, "add to cart")
        Else
            Dim games() As Game
            games = Game.ListGames(1, Me.lstGames.SelectedItems(0).SubItems(0).Text)
            If games(0).addToCart Then
                MsgBox("Successfully added to cart!", MsgBoxStyle.Information, "add to cart")
            Else
                MsgBox("It's not possible to add this game to cart!")
            End If
        End If
    End Sub
End Class