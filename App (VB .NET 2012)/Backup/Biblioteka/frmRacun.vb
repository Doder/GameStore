Public Class frmRacun
    Public poruka As String
    Public rid As Long
    Public d1 As String
    Public d2 As String
    Public dd As String
    Public jmbg As String
    Public isbn As Integer
    Public broj As Integer
    Private naziv As String


    Public danaZak As Integer
    Public danaPreko As Integer
    Public tarifa As Double
    Public tarifaPreko As Double

    Public cijena As Double

    Public Sub New(ByVal p As String, ByVal id As Long, ByVal od As String, ByVal zakazanoVracanje As String, ByVal danas As String, ByVal jm As String, ByVal i As Integer, ByVal b As Integer, ByVal n As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        poruka = p
        rid = id
        d1 = od
        d2 = zakazanoVracanje
        dd = danas
        jmbg = jm
        isbn = i
        broj = b
        naziv = n
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmRacun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dana As Integer

        Dim count As Integer

        lblPor.Text = poruka
        lblRac.Text = rid
        lblOd.Text = d1
        lblDo.Text = d2
        lblDanas.Text = dd
        lblNaziv.Text = naziv

        danaZak = DateDiff(DateInterval.Day, CDate(d1), CDate(d2)) + 1

        Dim k As Knjiga()
        k = Knjiga.ListaKnjiga(count, naziv)

        If danaZak = 5 Then
            tarifa = k(0).GetCijena
        ElseIf danaZak = 10 Then
            tarifa = k(0).GetCijena1
        Else ' danaZak > 15 
            tarifa = k(0).GetCijena2
        End If

        tarifaPreko = k(0).GetKazna

        lblTarifa.Text = CStr(tarifa)
        lblPrekoTar.Text = CStr(tarifaPreko)

        'stvarni broj dana
        dana = DateDiff(DateInterval.Day, CDate(d1), CDate(dd)) + 1


        danaPreko = dana - danaZak
        If danaPreko < 0 Then danaPreko = 0
        lblDana.Text = CStr(danaZak)
        lblPreko.Text = CStr(danaPreko)

        cijena = danaZak * tarifa + danaPreko * tarifaPreko
        lblUkupno.Text = CStr(cijena)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnRacun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblPor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPor.Click

    End Sub

    Private Sub lbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub lblTip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNaziv.Click

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim r As New Rent(rid, d1, d2, dd, cijena, jmbg, isbn, broj)
        Dim p As New Primjerak(isbn, broj)
        If r.Naplata And p.SlobodniPrimjerak Then
            Me.Close()
        Else
            MsgBox("Greska u bazi!", MsgBoxStyle.Exclamation, "Greska")
        End If
    End Sub

    Private Sub lblRac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRac.Click

    End Sub

    Private Sub lblDanas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDanas.Click

    End Sub

    Private Sub lblOd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOd.Click

    End Sub

    Private Sub lblDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDo.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class