Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GlobalVariables.activeUser = User.UserByEmail(1, txtEmail.Text)

        If GlobalVariables.activeUser.getEmail <> "" And txtEmail.Text = GlobalVariables.activeUser.getEmail And txtPwd.Text = GlobalVariables.activeUser.getPassword Then
            Dim f As New frmMain
            f.ShowDialog()
        Else
            MessageBox.Show("Incorrect email or password")
        End If
    End Sub

End Class