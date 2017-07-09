Public Class frmMain


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        Dim f As New frmUser
        f.ShowDialog()
    End Sub

    Private Sub btnGames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGames.Click
        Dim f As New frmGame
        f.ShowDialog()

    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.activeUser.getAdmin = 0 Then
            btnUsers.Hide()
        End If
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Dim f As New frmCart
        f.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()
    End Sub
End Class
