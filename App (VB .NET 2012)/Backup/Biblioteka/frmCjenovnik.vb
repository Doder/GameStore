Public Class frmCjenovnik

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnCijenaEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCijenaEdit.Click
        If lstCjenovnik.SelectedItems.Count = 0 Then
            MsgBox("Odaberite knjigu cije cijene iznajmljivanja zelite da izmijenite!", MsgBoxStyle.Exclamation, "Izmjena")
        Else
            Dim frm As New frmCjenovnikEdit(Me.lstCjenovnik.SelectedItems.Item(0).SubItems(1).Text)
            frm.Text = Me.lstCjenovnik.SelectedItems.Item(0).SubItems(1).Text
            frm.ShowDialog()
        End If
    End Sub

    Private Sub frmCjenovnik_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        initList()
    End Sub

    Private Sub frmCjenovnik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitHeader()
        initList()
    End Sub

    Private Sub InitHeader()
        lstCjenovnik.View = View.Details
        lstCjenovnik.Columns.Add("ISBN", 70, HorizontalAlignment.Left)
        lstCjenovnik.Columns.Add("Naziv", 130, HorizontalAlignment.Left)
        lstCjenovnik.Columns.Add("Autor", 120, HorizontalAlignment.Left)
        lstCjenovnik.Columns.Add("Izdavac", 110, HorizontalAlignment.Left)
        lstCjenovnik.Columns.Add("5 dana", 50, HorizontalAlignment.Left)
        lstCjenovnik.Columns.Add("10 dana", 50, HorizontalAlignment.Left)
        lstCjenovnik.Columns.Add("15 dana", 50, HorizontalAlignment.Left)
        lstCjenovnik.Columns.Add("Kazna", 50, HorizontalAlignment.Left)
    End Sub


    Private Sub initList()
        lstCjenovnik.Items.Clear()
        Dim knjige() As Knjiga
        Dim count As Integer
        Dim i As Integer

        'pozivamo metodu domenske klase
        knjige = Knjiga.ListaKnjiga(count, "")

        For i = 0 To count - 1
            Dim lvItem As New ListViewItem(knjige(i).GetIsbn)
            lvItem.SubItems.Add(knjige(i).GetNaziv)
            lvItem.SubItems.Add(knjige(i).GetAutor)
            lvItem.SubItems.Add(knjige(i).GetIzdavac)
            lvItem.SubItems.Add(knjige(i).GetCijena)
            lvItem.SubItems.Add(knjige(i).GetCijena1)
            lvItem.SubItems.Add(knjige(i).GetCijena2)
            lvItem.SubItems.Add(knjige(i).GetKazna)
            lstCjenovnik.Items.Add(lvItem)
        Next i
    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class