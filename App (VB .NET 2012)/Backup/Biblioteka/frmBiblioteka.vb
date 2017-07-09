Public Class frmBiblioteka

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnKarakteristike_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKarakteristike.Click
        If lstBiblio.SelectedItems.Count = 0 Then
            MsgBox("Odaberite knjigu cije karakteristike zelite da vidite!", MsgBoxStyle.Exclamation, "Izmjena")
        Else

            Dim frm As New frmKarakt(Me.lstBiblio.SelectedItems.Item(0).SubItems(1).Text)
            frm.Text = Me.lstBiblio.SelectedItems.Item(0).SubItems(1).Text
            frm.ShowDialog()
        End If

    End Sub

    Private Sub InitHeader()
        lstBiblio.View = View.Details

        lstBiblio.Columns.Add("ISBN", 80, HorizontalAlignment.Left)
        lstBiblio.Columns.Add("Naziv", 200, HorizontalAlignment.Left)
    End Sub

    Private Sub initList()
        lstBiblio.Items.Clear()
        Dim knjige() As Knjiga
        Dim count As Integer
        Dim i As Integer

        'pozivamo metodu domenske klase
        knjige = Knjiga.ListaKnjiga(count, txtFilter.Text)

        For i = 0 To count - 1
            Dim lvItem As New ListViewItem(knjige(i).GetIsbn)
            lvItem.SubItems.Add(knjige(i).GetNaziv)
            lstBiblio.Items.Add(lvItem)
        Next i


    End Sub

    Private Sub frmBiblioteka_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitHeader()
        InitList()
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        initList()
    End Sub


    Private Sub btnRaspolozivost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaspolozivost.Click
        If lstBiblio.SelectedItems.Count = 0 Then
            MsgBox("Odaberite knjigu ciju raspolozivost zelite da vidite!", MsgBoxStyle.Exclamation, "Izmjena")
        Else
            Dim frm As New frmRaspolozivost(Me.lstBiblio.SelectedItems.Item(0).SubItems(0).Text, Me.lstBiblio.SelectedItems.Item(0).SubItems(1).Text)
            frm.Text = Me.lstBiblio.SelectedItems.Item(0).SubItems(1).Text
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As New frmKnjigaAdd
        f.ShowDialog()
        initList()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If lstBiblio.SelectedItems.Count = 0 Then
            MsgBox("Morate odabrati knjigu koju zelite da izbrisete", MsgBoxStyle.Exclamation, "Brisanje")
        Else
            Dim p As MsgBoxResult
            p = MsgBox("Da li ste sigurni da zelite da izbrisete ovu knjigu?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Brisanje")
            If p = MsgBoxResult.Yes Then
                Dim k As New Knjiga(CInt(Me.lstBiblio.SelectedItems(0).SubItems(0).Text), Me.lstBiblio.SelectedItems(0).SubItems(1).Text)
                If k.IzbrisiKnjigu Then
                    initList()
                Else
                    MsgBox("Nije moguce izbrisati ovu knjigu!")
                End If
            End If
        End If
    End Sub
End Class