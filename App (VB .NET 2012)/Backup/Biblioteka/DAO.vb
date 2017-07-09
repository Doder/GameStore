Imports System.Data.SqlClient

Module DAO

    Private Class DBConnection
        Public Shared conn As SqlConnection = New SqlConnection("Data Source=WINDOWS\ROOT;Initial Catalog=biblioteka;password=sa;persist security info=True;user id=sa;workstation id=(local);packet size=4096")

        Public Sub New()
            If Not conn.State = Data.ConnectionState.Open Then
                conn.Open()
            End If
        End Sub

    End Class

    Public Class BazaDAO
        Public Sub New()
            If Not DBConnection.conn.State = Data.ConnectionState.Open Then
                DBConnection.conn.Open()
            End If
        End Sub

        Public Function IzvrsiUpit(ByVal s As String) As Boolean
            Try
                Dim command As New SqlCommand(s, DBConnection.conn)
                command.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Return ex.Message
            End Try

        End Function

        Public Function IzvrsiSelect(ByVal s As String, ByRef count As Integer) As Data.DataSet
            Dim ds As New Data.DataSet

            Dim da As New SqlDataAdapter(s, DBConnection.conn)
            da.Fill(ds)
            count = ds.Tables.Item(0).Rows.Count
            Return ds

        End Function
    End Class

    'DAO klasa knjiga
    Public Class KnjigaDAO
        Inherits BazaDAO

        Public Function selectKnjiga(ByRef count As Integer, ByVal filter As String) As Data.DataSet
            Dim ds As New DataSet
            ds = IzvrsiSelect("Select * from knjiga where naziv like '%" + filter + "%' order by isbn", count)
            Return ds
        End Function

        Public Function selectKnjigaByIsbn(ByRef count As Integer, ByVal isbn As Integer) As Data.DataSet
            Dim ds As New DataSet
            ds = IzvrsiSelect("Select * from knjiga where isbn ='" + isbn.ToString + "'", count)
            Return ds
        End Function

        'vraca izdavace
        Public Function selectIzdavac(ByRef count As Integer) As Data.DataSet
            Dim ds As New DataSet
            ds = IzvrsiSelect("Select * from izdavac order by naziv", count)
            Return ds
        End Function

        Public Function UnesiKnjigu(ByVal i As Integer, ByVal n As String, ByVal b As Integer, ByVal g As Integer, ByVal c As Double, ByVal c1 As Double, ByVal c2 As Double, ByVal k As Double, ByVal a As String, ByVal izd As String) As Boolean
            Return IzvrsiUpit("insert into knjiga(isbn,naziv,br_strana,god_izdavanja,cijena,cijena1,cijena2,kazna,autor,izdavac) values('" + i.ToString + "','" + n + "','" + b.ToString + "','" + g.ToString + "',0,0,0,0,'" + a + "','" + izd + "')")
        End Function

        Public Function IzbrisiKnjigu(ByVal i As Integer) As Boolean
            Return IzvrsiUpit("delete from knjiga where isbn='" + i.ToString + "'")
        End Function

        Public Function PromjenaCijena(ByVal naziv As String, ByVal cij As Double, ByVal cij1 As Double, ByVal cij2 As Double, ByVal kaz As Double) As Boolean
            Return IzvrsiUpit("Update knjiga set cijena='" + cij.ToString + "', cijena1='" + cij1.ToString + "', cijena2='" + cij2.ToString + "', kazna='" + kaz.ToString + "' where naziv ='" + naziv + "' ")
        End Function
    End Class


    'DAO klasa lice
    Public Class LiceDAO
        Inherits BazaDAO

        Public Function selectLice(ByRef count As Integer, ByVal filter As String) As Data.DataSet
            Dim ds As New Data.DataSet
            ds = IzvrsiSelect("select * from Lice where prezime like'%" + filter + "%' order by jmbg", count)
            Return ds
        End Function

        Public Function selectLicebyJmbg(ByVal count As Integer, ByVal jm As String) As Data.DataSet
            Dim ds As New Data.DataSet
            ds = IzvrsiSelect("select * from Lice where jmbg ='" + jm + "'", count)
            Return ds
        End Function

        Public Function UnesiLice(ByVal j As String, ByVal i As String, ByVal p As String, ByVal t As String, ByVal a As String) As Boolean
            Return IzvrsiUpit("insert into Lice(jmbg, ime, prezime, telefon, adresa) values('" + j + "','" + i + "','" + p + "','" + t + "','" + a + "')")
        End Function

        Public Function IzbrisiLice(ByVal j As String) As Boolean
            Return IzvrsiUpit("delete from Lice where jmbg='" + j + "'")
        End Function
    End Class


    'DAO klasa primjerak
    Public Class PrimjerakDAO
        Inherits BazaDAO

        Public Function selectPrimjerak(ByRef count As Integer, ByVal isbn As Integer) As Data.DataSet
            Dim ds As New Data.DataSet
            ds = IzvrsiSelect("select * from primjerak where isbn ='" + isbn.ToString + "' order by broj", count)
            Return ds
        End Function

        Public Function selectMaxBroj(ByRef count As Integer, ByVal isbn As Integer) As Data.DataSet
            Dim ds As New Data.DataSet
            ds = IzvrsiSelect("select max(broj) from primjerak where isbn ='" + isbn.ToString + "'", count)
            Return ds
        End Function

        Public Function UnesiPrimjerak(ByVal i As Integer, ByVal b As Integer, ByVal pov As String, ByVal z As Integer) As Boolean
            Return IzvrsiUpit("insert into primjerak(isbn,broj,povez,zauzet) values('" + i.ToString + "','" + b.ToString + "','" + pov + "','" + z.ToString + "')")
        End Function

        Public Function BrisiPrimjerak(ByVal isbn As Integer, ByVal br As Integer) As Boolean
            Return IzvrsiUpit("delete from primjerak where isbn='" + isbn.ToString + "' and broj='" + br.ToString + "'")
        End Function

        Public Function selectSlobodniPrimjerak(ByRef count As Integer, ByVal isbn As Integer) As Data.DataSet
            Dim ds As New Data.DataSet
            ds = IzvrsiSelect("select * from primjerak where isbn like'%" + isbn.ToString + "%' and zauzet=0 order by broj", count)
            Return ds
        End Function

        Public Function ZauzetiPrimjerak(ByVal isbn As Integer, ByVal broj As Integer) As Boolean
            Return IzvrsiUpit("update primjerak set zauzet=1 where broj='" + broj.ToString + "' and isbn='" + isbn.ToString + "'")
        End Function

        Public Function SlobodniPrimjerak(ByVal isbn As Integer, ByVal broj As Integer) As Boolean
            Return IzvrsiUpit("update primjerak set zauzet=0 where broj='" + broj.ToString + "' and isbn='" + isbn.ToString + "'")
        End Function

    End Class


    'DAO klasa rent
    Public Class RentDAO
        Inherits BazaDAO

        Public Function IznajmiKnjigu(ByVal od As String, ByVal d As String, ByVal vrac As String, ByVal jm As String, ByVal i As Integer, ByVal b As Integer) As Boolean
            Return IzvrsiUpit("insert into rent(datod,datdo,dat_vracanja,jmbg,isbn,broj) values('" + od + "','" + d + "','" + d + "','" + jm + "','" + i.ToString + "','" + b.ToString + "')")
        End Function


        Public Function selectRent(ByRef count As Integer) As Data.DataSet
            Dim ds As New Data.DataSet
            ds = IzvrsiSelect("select * from rent where racun=0", count)
            Return ds
        End Function

        Public Function Naplata(ByVal rid As Integer, ByVal r As Double, ByVal d As String) As Boolean
            Return IzvrsiUpit("Update Rent set racun='" + CStr(r) + "', dat_vracanja='" + d + "' where rent_id='" + rid.ToString + "'")
        End Function

    End Class


End Module
