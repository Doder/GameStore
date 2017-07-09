Public Class frmPurchase
    Dim nb As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Cart.DeleteFromUserCart(GlobalVariables.activeUser.getEmail())
        GlobalVariables.activeUser.UpdateBalance(nb)
        MessageBox.Show("Successfully puchased!")
        Me.Close()
    End Sub

    Private Sub frmKupovina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nb = GlobalVariables.activeUser.getBalance - GlobalVariables.sum
        lblCurrB.Text = GlobalVariables.activeUser.getBalance.ToString
        lblPrice.Text = GlobalVariables.sum.ToString
        lblNewBalance.Text = nb.ToString
    End Sub
End Class