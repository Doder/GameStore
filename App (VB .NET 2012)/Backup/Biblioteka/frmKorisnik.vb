Public Class frmKorisnik

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub InitHeaderLice()
        lstLice.View = View.Details

        lstLice.Columns.Add("JMBG", 120, HorizontalAlignment.Left)
        lstLice.Columns.Add("Ime", 80, HorizontalAlignment.Left)
        lstLice.Columns.Add("Prezime", 100, HorizontalAlignment.Left)
        lstLice.Columns.Add("Telefon", 100, HorizontalAlignment.Left)
        lstLice.Columns.Add("Adresa", 110, HorizontalAlignment.Left)
    End Sub

    Private Sub initListLice()
        lstLice.Items.Clear()
        Dim lica() As Lice
        Dim count As Integer
        Dim i As Integer

        'pozivamo metodu domenske klase
        lica = Lice.ListaLica(count, txtFilter.Text)

        For i = 0 To count - 1
            Dim lvItem As New ListViewItem(lica(i).getJmbg)
            lvItem.SubItems.Add(lica(i).getIme)
            lvItem.SubItems.Add(lica(i).getPrezime)
            lvItem.SubItems.Add(lica(i).getTel)
            lvItem.SubItems.Add(lica(i).getAdr)
            lstLice.Items.Add(lvItem)
        Next i

    End Sub
    Private Sub frmKorisnik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitHeaderLice()
        initListLice()
    End Sub

    Private Sub btnBrisi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrisi.Click
        If lstLice.SelectedItems.Count = 0 Then
            MsgBox("Morate odabrati korisnika kojeg zelite da izbrisete", MsgBoxStyle.Exclamation, "Brisanje")
        Else
            Dim p As MsgBoxResult
            p = MsgBox("Da li ste sigurni da zelite da izbrisete ovog korisnika?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Brisanje")
            If p = MsgBoxResult.Yes Then
                Dim l As New Lice(Me.lstLice.SelectedItems(0).SubItems(0).Text, "", "", "", "")
                If l.IzbrisiLice() Then
                    initListLice()
                Else
                    MsgBox("Nije moguce izbrisati ovo lice!")
                End If
            End If
        End If
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        initListLice()
    End Sub

    Private Sub btnDodaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDodaj.Click
        Dim f As New frmKorisnikAdd
        f.ShowDialog()
        initListLice()
    End Sub
End Class