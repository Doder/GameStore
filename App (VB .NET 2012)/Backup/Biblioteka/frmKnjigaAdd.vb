Public Class frmKnjigaAdd

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtIsbn.Text = "" Or txtNaziv.Text = "" Or txtAutor.Text = "" Or txtBr.Text = "" Or txtGod.Text = "" Or cmbIzdavac.Text = "" Then
            MsgBox("Morate unijeti sve podatke!", MsgBoxStyle.Exclamation, "Greska")
        Else 'unesena pravilno
            Dim k As New Knjiga(CInt(txtIsbn.Text), txtNaziv.Text, CInt(txtBr.Text), CInt(txtGod.Text), txtAutor.Text, cmbIzdavac.Text)
            If k.UnesiKnjigu Then
                Me.Close()
            Else
                MsgBox("Nepravilni podaci!", MsgBoxStyle.Exclamation, "Greska")
            End If
        End If
    End Sub

    Private Sub frmKnjigaAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbIzdavac.Items.Clear()

        Dim knjige() As Knjiga
        Dim count As Integer
        Dim i As Integer

        knjige = Knjiga.ListaIzdavaca(count)

        For i = 0 To count - 1
            cmbIzdavac.Items.Add(knjige(i).GetIzdavac)
        Next i

    End Sub
End Class