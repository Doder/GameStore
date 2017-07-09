Public Class frmIznajm

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub InitHeaderLice()
        lstLice.View = View.Details

        lstLice.Columns.Add("JMBG", 100, HorizontalAlignment.Left)
        lstLice.Columns.Add("Ime", 80, HorizontalAlignment.Left)
        lstLice.Columns.Add("Prezime", 105, HorizontalAlignment.Left)
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
            lstLice.Items.Add(lvItem)
        Next i

    End Sub

    Private Sub InitHeaderKnjiga()
        lstKnjiga.View = View.Details
        lstKnjiga.Columns.Add("ISBN", 50, HorizontalAlignment.Left)
        lstKnjiga.Columns.Add("Naziv knjige", 110, HorizontalAlignment.Left)
    End Sub

    Private Sub initListKnjiga()
        lstKnjiga.Items.Clear()
        Dim knjige() As Knjiga
        Dim count As Integer
        Dim i As Integer

        'pozivamo metodu domenske klase
        knjige = Knjiga.ListaKnjiga(count, "")

        For i = 0 To count - 1
            Dim lvItem As New ListViewItem(knjige(i).GetIsbn)
            lvItem.SubItems.Add(knjige(i).GetNaziv)
            lstKnjiga.Items.Add(lvItem)
        Next i

    End Sub

    Private Sub InitHeaderPrimjerak()
        lstPrimjerak.View = View.Details
        lstPrimjerak.Columns.Add("ID", 40, HorizontalAlignment.Left)
        lstPrimjerak.Columns.Add("Povez", 85, HorizontalAlignment.Left)
    End Sub

    Private Sub initListPrimjerak()

        lstPrimjerak.Items.Clear()
        Dim primjerci() As Primjerak
        Dim count As Integer
        Dim i As Integer

        'ako je selektovana neka knjiga
        If lstKnjiga.SelectedItems.Count = 1 Then
            'pozivamo metodu domenske klase
            primjerci = Primjerak.ListaSlobodnihPrimjeraka(count, CInt(Me.lstKnjiga.SelectedItems(0).SubItems(0).Text))
            For i = 0 To count - 1
                Dim lvItem As New ListViewItem(primjerci(i).getBroj)
                lvItem.SubItems.Add(primjerci(i).getPovez)
                lstPrimjerak.Items.Add(lvItem)
            Next i
        End If

    End Sub

    Private Sub PopuniLabele()
        Dim l As Lice
        Dim count As Integer

        l = Lice.LiceByJmbg(count, lblJmbg.Text)
        lblIme.Text = l.getIme + " " + l.getPrezime + Chr(10) + Chr(13) + l.getAdr + " " + Chr(10) + Chr(13) + l.getTel
    End Sub

    Private Sub frmIznajm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblIme.Text = ""
        lblJmbg.Text = "Nije odabran korisnik usluga."
        lblKnj.Text = "Nije odabrana knjiga."
        lblPrim.Text = "Nije odabran primjerak."


        'dtpOd.Format = DateTimePickerFormat.Short
        'dtpDo.Format = DateTimePickerFormat.Short

        InitHeaderLice()
        initListLice()

        InitHeaderKnjiga()
        initListKnjiga()

        InitHeaderPrimjerak()


    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        initListLice()
    End Sub

    Private Sub lstLice_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstLice.MouseClick
        lblJmbg.Text = Me.lstLice.SelectedItems.Item(0).SubItems(0).Text
        PopuniLabele()
    End Sub

    Private Sub lstKnjiga_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstKnjiga.MouseClick
        initListPrimjerak()
        lblKnj.Text = Me.lstKnjiga.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub lstPrimjerak_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstPrimjerak.MouseClick
        lblPrim.Text = Me.lstPrimjerak.SelectedItems(0).SubItems(1).Text & " povez"
    End Sub

    Public Function dobriDatumi(ByVal d1 As String, ByVal d2 As String) As Boolean
        Dim p As Boolean
        Dim razlika As Integer

        p = True

        razlika = DateDiff(DateInterval.Day, CDate(d1), CDate(d2))

        If razlika < 0 Then p = False

        Return p
    End Function

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If lblJmbg.Text = "Nije odabran korisnik usluga." Or lblPrim.Text = "Nije odabran primjerak knjige." Then
            If lblJmbg.Text = "Nije odabran korisnik usluga." Then
                MsgBox("Niste odabrali korisnika usluga", MsgBoxStyle.Exclamation, "Greska")
            Else
                MsgBox("Niste odabrali primjerak knjige", MsgBoxStyle.Exclamation, "Greska")
            End If
        Else 'podaci su pravilni
            If dobriDatumi(dtpOd.Text, dtpDo.Text) Then
                Dim r As New Rent(dtpOd.Text, dtpDo.Text, "", lblJmbg.Text, CInt(Me.lstKnjiga.SelectedItems(0).SubItems(0).Text), CInt(Me.lstPrimjerak.SelectedItems(0).SubItems(0).Text))
                Dim p As New Primjerak(CInt(Me.lstKnjiga.SelectedItems(0).SubItems(0).Text), CInt(Me.lstPrimjerak.SelectedItems(0).SubItems(0).Text))
                If r.IznajmiKnjigu And p.ZauzetiPrimjerak Then
                    Me.Close()
                Else
                    MsgBox("Nije validan unos!", MsgBoxStyle.Exclamation, "Greska")
                End If
            Else
                MsgBox("Datum iznajmljivanja ne moze biti posle datuma vracanja auta", MsgBoxStyle.Exclamation, "Greska")
            End If 'end dobriDatumi

        End If
    End Sub
End Class