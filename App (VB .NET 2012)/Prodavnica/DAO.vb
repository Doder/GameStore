Imports System.Data.SqlClient

Module DAO

    Private Class DBConnection
        Public Shared conn As SqlConnection = New SqlConnection("Data Source=.\SQLExpress;Initial Catalog=store;password=sa;persist security info=True;user id=sa;workstation id=(DESKTOP-PVO4CS6\SQLEXPRESS);packet size=4096")

        Public Sub New()
            If Not conn.State = Data.ConnectionState.Open Then
                conn.Open()
            End If
        End Sub

    End Class

    Public Class DatabaseDAO
        Public Sub New()
            If Not DBConnection.conn.State = Data.ConnectionState.Open Then
                DBConnection.conn.Open()
            End If
        End Sub

        Public Function executeQuery(ByVal s As String) As Boolean
            Try
                Dim command As New SqlCommand(s, DBConnection.conn)
                command.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return ex.Message
            End Try

        End Function

        Public Function executeSelect(ByVal s As String, ByRef count As Integer) As Data.DataSet
            Dim ds As New Data.DataSet

            Dim da As New SqlDataAdapter(s, DBConnection.conn)
            da.Fill(ds)
            count = ds.Tables.Item(0).Rows.Count
            Return ds

        End Function
    End Class


    Public Class GameDAO
        Inherits DatabaseDAO

        Public Function selectGame(ByRef count As Integer, ByVal filter As String) As Data.DataSet
            Dim ds As New DataSet
            ds = executeSelect("Select * from game where title like '%" + filter + "%' order by pub_year", count)
            Return ds
        End Function

        Public Function selectDeveloper(ByRef count As Integer) As Data.DataSet
            Dim ds As New DataSet
            ds = executeSelect("Select * from developer order by name", count)
            Return ds
        End Function

        Public Function insertGame(ByVal n As String, ByVal o As Integer, ByVal g As Integer, ByVal c As Double, ByVal d As String) As Boolean
            Return executeQuery("insert into game(title, mark, pub_year, price, developer) values('" + n + "','" + o.ToString + "','" + g.ToString + "','" + c.ToString + "','" + d + "')")
        End Function

        Public Function addToCart(ByVal title As String, ByVal email As String, ByVal developer As String) As Boolean
            Return executeQuery("insert into cart(game_title, developer, userr) values('" + title + "','" + developer + "','" + email + "')")
        End Function

        Public Function deleteGame(ByVal n As String) As Boolean
            Return executeQuery("delete from game where title='" + n + "'")
        End Function

    End Class


    Public Class UserDAO
        Inherits DatabaseDAO

        Public Function selectUser(ByRef count As Integer, ByVal filter As String) As Data.DataSet
            Dim ds As New Data.DataSet
            ds = executeSelect("select * from userr where surname like'%" + filter + "%' order by email", count)
            Return ds
        End Function

        Public Function selectUserbyEmail(ByVal count As Integer, ByVal email As String) As Data.DataSet
            Dim ds As New Data.DataSet
            ds = executeSelect("select * from userr where email='" + email + "'", count)
            Return ds
        End Function

        Public Function insertUser(ByVal j As String, ByVal i As String, ByVal p As String, ByVal t As String, ByVal a As String, ByVal d As String, ByVal balance As Integer, ByVal adm As Integer, ByVal pw As String) As Boolean
            Return executeQuery("insert into userr(email, name, surname, phone_number, address, birthday, balance, admin, password) values('" + j + "','" + i + "','" + p + "','" + t + "','" + a + "','" + d + "','" + balance.ToString + "','" + adm.ToString + "','" + pw + "')")
        End Function

        Public Function deleteUser(ByVal j As String) As Boolean
            Return executeQuery("delete from userr where email='" + j + "'")
        End Function

        Sub updateAccount(email As String, balance As Double)
            executeQuery("update userr set balance='" + balance.ToString + "'  where email='" + email + "'")
        End Sub

    End Class

    Public Class CartDao
        Inherits DatabaseDAO

        Public Function selectCartByEmail(ByVal count As Integer, ByVal email As String) As Data.DataSet
            Dim ds As New DataSet
            ds = executeSelect("Select * from cart where userr='" + email + "'", count)
            Return ds
        End Function

        Public Function isGameInCart(ByVal email As String, ByVal n As String) As Boolean
            Dim ds As New DataSet
            ds = executeSelect("Select * from cart where userr='" + email + "' and game_title='" + n + "'", 2)
            If ds.Tables.Item(0).Rows.Count = 0 Then
                Return False
            End If
            Return True
        End Function

        Public Function selectPriceCart(ByVal id As Integer) As Data.DataSet
            Dim ds As New DataSet
            ds = executeSelect("Select price from cart K, game I where K.developer = I.developer AND K.game_title = I.title AND K.ID = '" + id.ToString + "'", 1)
            Return ds
        End Function
        Public Function deleteFromCart(ByVal id As String) As Boolean
            Return executeQuery("delete from cart where id ='" + id + "'")
        End Function
        Public Function deleteUserFromCart(ByVal email As String) As Boolean
            Return executeQuery("delete from cart where userr ='" + email + "'")
        End Function

    End Class

End Module
