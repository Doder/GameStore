Public Class frmMain

    Private Sub btnCjenovnik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCjenovnik.Click
        Dim f As New frmCjenovnik
        f.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub frmKorisnik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKorisnik.Click
        Dim f As New frmKorisnik
        f.ShowDialog()
    End Sub

    Private Sub btnBiblioteka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBiblioteka.Click
        Dim f As New frmBiblioteka
        f.ShowDialog()

    End Sub

    Private Sub btnRent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRent.Click
        Dim f As New frmRent
        f.ShowDialog()

    End Sub
End Class
