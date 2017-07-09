Public Class frmKorisnikAdd

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtJmbg.Text = "" Or txtIme.Text = "" Or txtPrezime.Text = "" Or txtAdresa.Text = "" Or txtTel.Text = "" Then
            MsgBox("Morate unijeti sve podatke!", MsgBoxStyle.Exclamation, "Greska")
        Else 'unesena pravilno
            Dim l As New Lice(txtJmbg.Text, txtIme.Text, txtPrezime.Text, txtTel.Text, txtAdresa.Text)
            If l.UnesiLice Then
                Me.Close()
            Else
                MsgBox("Nepravilni podaci!", MsgBoxStyle.Exclamation, "Greska")
            End If
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtIme_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIme.TextChanged

    End Sub

    Private Sub frmKorisnikAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class