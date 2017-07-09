Public Class frmRaspolozivost

    Public primj As Integer
    Public naziv As String

    Public Sub New(ByVal s As Integer, ByVal n As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        primj = s
        naziv = n
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub InitHeader()
        lstRaspolozivost.View = View.Details

        lstRaspolozivost.Columns.Add("ID", 60, HorizontalAlignment.Left)
        lstRaspolozivost.Columns.Add("Povez", 80, HorizontalAlignment.Left)
        lstRaspolozivost.Columns.Add("Zauzet", 90, HorizontalAlignment.Left)
    End Sub

    Public Function DaNe(ByVal x As Integer) As String
        Dim s As String
        s = "Ne"
        If x = 1 Then s = "Da"
        Return s
    End Function

    Private Sub initList()

        lstRaspolozivost.Items.Clear()
        Dim primjerci() As Primjerak
        Dim count As Integer
        Dim i As Integer


        'pozivamo metodu domenske klase
        primjerci = Primjerak.ListaPrimjeraka(count, primj)


        For i = 0 To count - 1
            Dim lvItem As New ListViewItem(primjerci(i).getBroj)
            lvItem.SubItems.Add(primjerci(i).getPovez)
            lvItem.SubItems.Add(DaNe(primjerci(i).getZauzet))
            lstRaspolozivost.Items.Add(lvItem)
        Next i

    End Sub

    Private Sub frmRaspolozivost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblKnjiga.Text = naziv

        InitHeader()
        InitList()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As New frmPrimjerakAdd(primj)
        f.Text = primj
        f.ShowDialog()
        initList()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If lstRaspolozivost.SelectedItems.Count = 0 Then
            MsgBox("Morate odabrati primjerak knjige koji zelite da izbrisete", MsgBoxStyle.Exclamation, "Brisanje")
        Else
            Dim p As MsgBoxResult
            p = MsgBox("Da li ste sigurni da zelite da izbrisete ovaj primjerak?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Brisanje")
            If p = MsgBoxResult.Yes Then
                Dim prim As New Primjerak(primj, CInt(Me.lstRaspolozivost.SelectedItems(0).SubItems(0).Text))
                If prim.BrisiPrimjerak() Then
                    initList()
                Else
                    MsgBox("Nije moguce obrisati ovaj primjerak!")
                End If
            End If

        End If
    End Sub
End Class