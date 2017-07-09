Public Class frmVracanje

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub InitHeader()
        lstRent.View = View.Details

        lstRent.Columns.Add("ID", 50, HorizontalAlignment.Left)
        lstRent.Columns.Add("JMBG", 90, HorizontalAlignment.Left)
        lstRent.Columns.Add("Ime", 85, HorizontalAlignment.Left)
        lstRent.Columns.Add("Prezime", 90, HorizontalAlignment.Left)
        lstRent.Columns.Add("ISBN", 50, HorizontalAlignment.Left)
        lstRent.Columns.Add("Broj", 40, HorizontalAlignment.Left)
        lstRent.Columns.Add("Naziv", 105, HorizontalAlignment.Left)
        lstRent.Columns.Add("od", 70, HorizontalAlignment.Left)
        lstRent.Columns.Add("do", 70, HorizontalAlignment.Left)
    End Sub

    Private Sub initList()
        lstRent.Items.Clear()
        Dim rents() As Rent
        Dim count As Integer
        Dim c As Integer
        Dim i As Integer

        'pozivamo metodu domenske klase
        rents = Rent.ListaIznajmljenih(count)

        For i = 0 To count - 1

            Dim l As Lice
            l = Lice.LiceByJmbg(c, rents(i).getJmbg)

            Dim k() As Knjiga
            k = Knjiga.ListaKnjigaByIsbn(c, rents(i).getIsbn)

            Dim lvItem As New ListViewItem(rents(i).getRID)
            lvItem.SubItems.Add(rents(i).getJmbg)
            lvItem.SubItems.Add(l.getIme)
            lvItem.SubItems.Add(l.getPrezime)
            lvItem.SubItems.Add(rents(i).getIsbn)
            lvItem.SubItems.Add(rents(i).getBroj)
            lvItem.SubItems.Add(k(0).GetNaziv)
            lvItem.SubItems.Add(rents(i).getOd)
            lvItem.SubItems.Add(rents(i).getDo)
            lstRent.Items.Add(lvItem)

        Next i

    End Sub


    Private Sub frmVracanje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitHeader()
        initList()
    End Sub

    Private Sub btnRentBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentBack.Click
        If lstRent.SelectedItems.Count = 0 Then
            MsgBox("Odaberite knjigu koje se vraca.", MsgBoxStyle.Exclamation, "Greska")

        Else 'izabrali smo knjigu koje zelimo da vratimo

            Dim danas As Date
            Dim zakazanoVracanje As Date
            Dim poruka As String

            Dim id As Integer
            Dim od As String
            Dim isbn As Integer
            Dim jmbg As String
            Dim broj As Integer
            Dim naziv As String

            id = CInt(Me.lstRent.SelectedItems(0).SubItems(0).Text)
            od = Me.lstRent.SelectedItems(0).SubItems(7).Text
            isbn = Me.lstRent.SelectedItems(0).SubItems(4).Text
            naziv = Me.lstRent.SelectedItems(0).SubItems(6).Text
            broj = Me.lstRent.SelectedItems(0).SubItems(5).Text

            jmbg = Me.lstRent.SelectedItems(0).SubItems(1).Text

            danas = Date.Today
            zakazanoVracanje = CDate(Me.lstRent.SelectedItems(0).SubItems(8).Text)

            If DateDiff(DateInterval.Day, danas, zakazanoVracanje) = 0 Then
                poruka = "Knjiga je vracena na vrijeme."
            Else 'nije pravilan datum vracanja
                If DateDiff(DateInterval.Day, danas, zakazanoVracanje) > 0 Then
                    poruka = "Knjiga je vracena ranije nego sto je predvidjeno!"
                Else
                    poruka = "Napravljeno je prekoracenje!"
                End If
            End If


            Dim f As New frmRacun(poruka, id, od, zakazanoVracanje, danas, jmbg, isbn, broj, naziv)
            f.ShowDialog()
            initList()
        End If
    End Sub
End Class