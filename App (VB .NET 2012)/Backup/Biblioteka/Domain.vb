Imports Biblioteka.DAO

Module Domain

    Class Knjiga

        Private isbn As Integer
        Private naziv As String
        Private br_strana As Integer
        Private god_izdavanja As Integer
        Private cijena As Double
        Private cijena1 As Double
        Private cijena2 As Double
        Private kazna As Double
        Private autor As String
        Private izdavac As String


        'KONSTRUKTORI
        'prazni konstruktor
        Public Sub New()
        End Sub

        ' potpuni kontruktor

        Private Sub New(ByVal i As Integer, ByVal n As String, ByVal b As Integer, ByVal g As Integer, ByVal c As Double, ByVal c1 As Double, ByVal c2 As Double, ByVal k As Double, ByVal a As String, ByVal izd As String)
            isbn = i
            naziv = n
            br_strana = b
            god_izdavanja = g
            cijena = c
            cijena1 = c1
            cijena2 = c2
            kazna = k
            autor = a
            izdavac = izd
        End Sub

        Public Sub New(ByVal i As Integer, ByVal n As String)
            isbn = i
            naziv = n
        End Sub

        Public Sub New(ByVal n As String, ByVal c As Double, ByVal c1 As Double, ByVal c2 As Double, ByVal k As Double)
            naziv = n
            cijena = c
            cijena1 = c1
            cijena2 = c2
            kazna = k
        End Sub

        Public Sub New(ByVal i As Integer, ByVal n As String, ByVal b As Integer, ByVal g As Integer, ByVal a As String, ByVal izd As String)
            isbn = i
            naziv = n
            br_strana = b
            god_izdavanja = g
            autor = a
            izdavac = izd
        End Sub

        Public Sub New(ByVal izd As String)
            izdavac = izd
        End Sub

        ' Seteri i geteri
        Public Function GetIsbn() As String
            Return isbn
        End Function
        Public Function GetNaziv() As String
            Return naziv
        End Function
        Public Function GetBrStrana() As String
            Return br_strana
        End Function
        Public Function GetGod() As String
            Return god_izdavanja
        End Function
        Public Function GetCijena() As String
            Return cijena
        End Function
        Public Function GetCijena1() As String
            Return cijena1
        End Function
        Public Function GetCijena2() As String
            Return cijena2
        End Function
        Public Function GetKazna() As String
            Return kazna
        End Function
        Public Function GetAutor() As String
            Return autor
        End Function
        Public Function GetIzdavac() As String
            Return izdavac
        End Function

        Public Shared Function ListaKnjiga(ByRef count As Integer, ByVal filter As String) As Knjiga()
            Dim k As New KnjigaDAO
            Dim ds As New DataSet
            Dim j As Integer

            ds = k.selectKnjiga(count, filter)
            Dim lst(count) As Knjiga

            For j = 0 To count - 1
                lst(j) = New Knjiga(CInt(ds.Tables.Item(0).Rows.Item(j).Item(0)), ds.Tables.Item(0).Rows.Item(j).Item(1), CInt(ds.Tables.Item(0).Rows.Item(j).Item(2)), CInt(ds.Tables.Item(0).Rows.Item(j).Item(3)), ds.Tables.Item(0).Rows.Item(j).Item(4).ToString, ds.Tables.Item(0).Rows.Item(j).Item(5).ToString, ds.Tables.Item(0).Rows.Item(j).Item(6).ToString, ds.Tables.Item(0).Rows.Item(j).Item(7).ToString, ds.Tables.Item(0).Rows.Item(j).Item(8), ds.Tables.Item(0).Rows.Item(j).Item(9))
            Next
            Return lst
        End Function

        Public Shared Function ListaKnjigaByIsbn(ByRef count As Integer, ByVal isbn As Integer) As Knjiga()
            Dim k As New KnjigaDAO
            Dim ds As New DataSet
            Dim j As Integer

            ds = k.selectKnjigaByIsbn(count, CInt(isbn))
            Dim lst(count) As Knjiga

            For j = 0 To count - 1
                lst(j) = New Knjiga(CInt(ds.Tables.Item(0).Rows.Item(j).Item(0)), ds.Tables.Item(0).Rows.Item(j).Item(1))
            Next
            Return lst
        End Function

        Public Shared Function ListaIzdavaca(ByRef count As Integer) As Knjiga()
            Dim k As New KnjigaDAO
            Dim ds As New DataSet
            Dim j As Integer

            ds = k.selectIzdavac(count)
            Dim lst(count) As Knjiga

            For j = 0 To count - 1
                lst(j) = New Knjiga(ds.Tables.Item(0).Rows.Item(j).Item(0))
            Next
            Return lst
        End Function

        Public Function UnesiKnjigu() As Boolean
            Dim k As New KnjigaDAO
            Return k.UnesiKnjigu(isbn, naziv, br_strana, god_izdavanja, cijena, cijena1, cijena2, kazna, autor, izdavac)
        End Function

        Public Function IzbrisiKnjigu() As Boolean
            Dim k As New KnjigaDAO
            Return k.IzbrisiKnjigu(isbn)
        End Function

        Public Function PromjenaCijena() As Boolean
            Dim k As New KnjigaDAO
            Return k.PromjenaCijena(naziv, cijena, cijena1, cijena2, kazna)
        End Function

    End Class

    Class Lice
        Private jmbg As String
        Private ime As String
        Private prezime As String
        Private telefon As String
        Private adresa As String

        'KONSTRUKTORI
        'prazni konstruktor
        Public Sub New()
        End Sub
        'potpuni konstruktor
        Public Sub New(ByVal j As String, ByVal i As String, ByVal p As String, ByVal t As String, ByVal a As String)
            jmbg = j
            ime = i
            prezime = p
            telefon = t
            adresa = a
        End Sub

        'SETERI I GETERI
        Public Function getJmbg() As String
            Return jmbg
        End Function
        Public Function getIme() As String
            Return ime
        End Function
        Public Function getPrezime() As String
            Return prezime
        End Function
        Public Function getAdr() As String
            Return adresa
        End Function
        Public Function getTel() As String
            Return telefon
        End Function

        Public Shared Function ListaLica(ByRef count As Integer, ByVal filter As String) As Lice()
            Dim l As New LiceDAO
            Dim ds As New Data.DataSet
            Dim i As Integer

            ds = l.selectLice(count, filter)
            Dim lst(count) As Lice

            'odje moramo da popunimo listu
            For i = 0 To count - 1
                lst(i) = New Lice(ds.Tables.Item(0).Rows.Item(i).Item(0), ds.Tables.Item(0).Rows.Item(i).Item(1), ds.Tables.Item(0).Rows.Item(i).Item(2), ds.Tables.Item(0).Rows.Item(i).Item(3), ds.Tables.Item(0).Rows.Item(i).Item(4))
            Next

            Return lst
        End Function


        Public Shared Function LiceByJmbg(ByVal count As Integer, ByVal jmbg As String) As Lice
            Dim l As New LiceDAO
            Dim ds As New Data.DataSet
            Dim i As Integer

            ds = l.selectLicebyJmbg(count, jmbg)
            Dim lic As Lice

            lic = New Lice(ds.Tables.Item(0).Rows.Item(i).Item(0), ds.Tables.Item(0).Rows.Item(i).Item(1), ds.Tables.Item(0).Rows.Item(i).Item(2), ds.Tables.Item(0).Rows.Item(i).Item(3), ds.Tables.Item(0).Rows.Item(i).Item(4))
            Return lic
        End Function

        Public Function UnesiLice() As Boolean
            Dim l As New LiceDAO
            Return l.UnesiLice(jmbg, ime, prezime, telefon, adresa)
        End Function

        Public Function IzbrisiLice() As Boolean
            Dim l As New LiceDAO
            Return l.IzbrisiLice(jmbg)
        End Function
    End Class

    Class Primjerak
        Inherits BazaDAO

        Private isbn As Integer
        Private broj As Integer
        Private povez As String
        Private zauzet As Integer
        Private naziv As String

        'KONSTRUKTORI
        'prazni konstruktor
        Public Sub New()
        End Sub

        'potpuni konstruktor
        Public Sub New(ByVal i As Integer, ByVal br As Integer, ByVal p As String, ByVal z As Integer)
            isbn = i
            broj = br
            povez = p
            zauzet = z
        End Sub

        Public Sub New(ByVal br As Integer, ByVal pov As String, ByVal z As Integer)
            broj = br
            povez = pov
            zauzet = z
        End Sub

        Public Sub New(ByVal i As Integer, ByVal b As Integer)
            isbn = i
            broj = b
            zauzet = 1
        End Sub


        'kontruktor za kreiranje primjerka
        Public Sub New(ByVal i As Integer, ByVal pov As String)
            isbn = i
            povez = pov
            zauzet = 0
            Dim count As Integer
            Dim p As New PrimjerakDAO
            Dim ds As Data.DataSet
            Dim ds1 As Data.DataSet


            ds = p.selectPrimjerak(count, isbn)
            ds1 = p.selectMaxBroj(count, isbn)
            If ds.Tables.Item(0).Rows.Count = 0 Then
                broj = 1
            Else
                broj = ds1.Tables.Item(0).Rows.Item(0).Item(0) + 1
            End If
        End Sub

        'SETERI I GETERI
        Public Function getIsbn() As String
            Return isbn
        End Function

        Public Function getBroj() As String
            Return broj
        End Function

        Public Function getPovez() As String
            Return povez
        End Function

        Public Function getZauzet() As String
            Return zauzet
        End Function

        Public Shared Function ListaPrimjeraka(ByRef count As Integer, ByVal isbn As Integer) As Primjerak()
            Dim p As New PrimjerakDAO
            Dim ds As New Data.DataSet
            Dim i As Integer

            ds = p.selectPrimjerak(count, isbn)
            Dim lst(count) As Primjerak

            'ovdje moramo da popunimo listu
            For i = 0 To count - 1
                lst(i) = New Primjerak(CInt(ds.Tables.Item(0).Rows.Item(i).Item(0)), ds.Tables.Item(0).Rows.Item(i).Item(1), ds.Tables.Item(0).Rows.Item(i).Item(2), CInt(ds.Tables.Item(0).Rows.Item(i).Item(3)))
            Next
            Return lst
        End Function


        Public Shared Function ListaSlobodnihPrimjeraka(ByRef count As Integer, ByVal isbn As Integer) As Primjerak()
            Dim p As New PrimjerakDAO
            Dim ds As New Data.DataSet
            Dim i As Integer

            ds = p.selectSlobodniPrimjerak(count, isbn)
            Dim lst(count) As Primjerak

            'ovdje moramo da popunimo listu
            For i = 0 To count - 1
                lst(i) = New Primjerak(CInt(ds.Tables.Item(0).Rows.Item(i).Item(1)), ds.Tables.Item(0).Rows.Item(i).Item(2), CInt(ds.Tables.Item(0).Rows.Item(i).Item(3)))
            Next
            Return lst
        End Function

        Public Function UnesiPrimjerak() As Boolean
            Dim p As New PrimjerakDAO
            Return p.UnesiPrimjerak(isbn, broj, povez, zauzet)
        End Function

        Public Function BrisiPrimjerak() As Boolean
            Dim p As New PrimjerakDAO
            Return p.BrisiPrimjerak(isbn, broj)
        End Function

        Public Function ZauzetiPrimjerak() As Boolean
            Dim p As New PrimjerakDAO
            Return p.ZauzetiPrimjerak(isbn, broj)
        End Function

        Public Function SlobodniPrimjerak() As Boolean
            Dim p As New PrimjerakDAO
            Return p.SlobodniPrimjerak(isbn, broj)
        End Function

    End Class

    Class Rent
        Private rent_id As Integer
        Private datod As String
        Private datdo As String
        Private dat_vracanja As String
        Private racun As Double
        Private jmbg As String
        Private isbn As Integer
        Private broj As Integer


        'KONSTRUKTORI
        'prazni konstruktor
        Public Sub New()
        End Sub

        'potpuni konstruktor
        Public Sub New(ByVal r As Integer, ByVal od As String, ByVal d As String, ByVal vrac As String, ByVal rac As Double, ByVal j As String, ByVal i As Integer, ByVal b As Integer)
            rent_id = r
            datod = od
            datdo = d
            dat_vracanja = vrac
            racun = rac
            jmbg = j
            isbn = i
            broj = b
        End Sub

        'potpuni konstruktor (bez rent_id, jer je identity, i bez racuna)
        Public Sub New(ByVal od As String, ByVal d As String, ByVal vrac As String, ByVal j As String, ByVal i As Integer, ByVal b As Integer)
            datod = od
            datdo = d
            dat_vracanja = vrac
            jmbg = j
            isbn = i
            broj = b
        End Sub

        'SETERI I GETERI
        Public Function getRID() As String
            Return rent_id
        End Function
        Public Function getOd() As String
            Return datod
        End Function
        Public Function getDo() As String
            Return datdo
        End Function
        Public Function getVrac() As String
            Return dat_vracanja
        End Function
        Public Function getJmbg() As String
            Return jmbg
        End Function
        Public Function getIsbn() As String
            Return isbn
        End Function
        Public Function getBroj() As String
            Return broj
        End Function

        Public Function IznajmiKnjigu() As Boolean
            Dim r As New RentDAO
            Return r.IznajmiKnjigu(datod, datdo, dat_vracanja, jmbg, isbn, broj)
        End Function

        Public Shared Function ListaIznajmljenih(ByRef count As Integer) As Rent()
            Dim l As New RentDAO
            Dim ds As New Data.DataSet
            Dim i As Integer

            ds = l.selectRent(count)
            Dim rnt(count) As Rent

            'ovdje moramo da popunimo listu
            For i = 0 To count - 1
                rnt(i) = New Rent(CInt(ds.Tables.Item(0).Rows.Item(i).Item(0)), ds.Tables.Item(0).Rows.Item(i).Item(1), ds.Tables.Item(0).Rows.Item(i).Item(2), ds.Tables.Item(0).Rows.Item(i).Item(3), CDbl(ds.Tables.Item(0).Rows.Item(i).Item(4)), ds.Tables.Item(0).Rows.Item(i).Item(5), CInt(ds.Tables.Item(0).Rows.Item(i).Item(6)), CInt(ds.Tables.Item(0).Rows.Item(i).Item(7)))
            Next
            Return rnt
        End Function

        Public Function Naplata() As Boolean
            Dim r As New RentDAO
            Return r.Naplata(rent_id, racun, dat_vracanja)
        End Function

    End Class

End Module
