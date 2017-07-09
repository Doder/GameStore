Imports Igraonica.DAO

Module Domain

    Public Class GlobalVariables
        Public Shared activeUser As User
        Public Shared sum As Integer = 0
    End Class


    Class Game

        Private title As String
        Private mark As Integer
        Private pubYear As String
        Private price As Double
        Private developer As String

        Public Sub New(ByVal d As String)
            developer = d
        End Sub

        Public Sub New(ByVal n As String, ByVal c As Double)
            title = n
            price = c
        End Sub

        Public Sub New(ByVal n As String, ByVal o As Integer, ByVal gi As Integer, ByVal c As Double, ByVal d As String)
            pubYear = gi
            title = n
            mark = o
            price = c
            developer = d
        End Sub

        Public Function GetTitle() As String
            Return title
        End Function
        Public Function GetMark() As String
            Return mark
        End Function
        Public Function GetPubYear() As String
            Return pubYear
        End Function
        Public Function GetPrice() As String
            Return price
        End Function
        Public Function GetDeveloper() As String
            Return developer
        End Function

        Public Shared Function ListGames(ByRef count As Integer, ByVal filter As String) As Game()
            Dim k As New GameDAO
            Dim ds As New DataSet
            Dim j As Integer

            ds = k.selectGame(count, filter)
            Dim lst(count) As Game

            For j = 0 To count - 1
                lst(j) = New Game(ds.Tables.Item(0).Rows.Item(j).Item(0), ds.Tables.Item(0).Rows.Item(j).Item(1), ds.Tables.Item(0).Rows.Item(j).Item(2), ds.Tables.Item(0).Rows.Item(j).Item(3), ds.Tables.Item(0).Rows.Item(j).Item(4))
            Next
            Return lst
        End Function

        Public Shared Function listDevelopers(ByRef count As Integer) As Game()
            Dim k As New GameDAO
            Dim ds As New DataSet
            Dim j As Integer

            ds = k.selectDeveloper(count)
            Dim lst(count) As Game

            For j = 0 To count - 1
                lst(j) = New Game(ds.Tables.Item(0).Rows.Item(j).Item(0))
            Next
            Return lst
        End Function

        Public Function InsertGame() As Boolean
            Dim k As New GameDAO
            Return k.insertGame(title, mark, pubYear, price, developer)
        End Function

        Public Function DeleteGame() As Boolean
            Dim k As New GameDAO
            Return k.deleteGame(title)
        End Function

        Public Function addToCart() As Boolean
            Dim k As New GameDAO
            Dim kd As New CartDao

            If kd.isGameInCart(GlobalVariables.activeUser.getEmail, title) Then
                MessageBox.Show("This game is already in the cart")
                Return False
            Else
                Return k.addToCart(title, GlobalVariables.activeUser.getEmail, developer)
            End If
        End Function

    End Class

    Class User
        Private email As String
        Private name As String
        Private surname As String
        Private pnumber As String
        Private address As String
        Private bithday As String
        Private accountBalance As Double
        Private password As String
        Private admin As Integer

        Public Sub New()
        End Sub
        Public Sub New(ByVal j As String, ByVal i As String, ByVal p As String, ByVal t As String, ByVal a As String, ByVal d As String, ByVal adm As Integer, ByVal loz As String, ByVal sr As Integer)
            email = j
            name = i
            surname = p
            pnumber = t
            address = a
            bithday = d
            accountBalance = sr
            admin = adm
            password = loz
        End Sub

        Public Sub New(ByVal e As String)
            email = e
        End Sub

        Public Function getEmail() As String
            Return email
        End Function
        Public Function getName() As String
            Return name
        End Function
        Public Function getSurname() As String
            Return surname
        End Function
        Public Function getAdr() As String
            Return address
        End Function
        Public Function getPhoneNumber() As String
            Return pnumber
        End Function
        Public Function getBd() As String
            Return bithday
        End Function
        Public Function getBalance() As String
            Return accountBalance
        End Function
        Function getPassword() As String
            Return password
        End Function
        Function getAdmin() As Integer
            Return admin
        End Function

        Public Shared Function ListUsers(ByRef count As Integer, ByVal filter As String) As User()
            Dim l As New UserDAO
            Dim ds As New Data.DataSet
            Dim i As Integer

            ds = l.selectUser(count, filter)
            Dim lst(count) As User

            For i = 0 To count - 1
                lst(i) = New User(ds.Tables.Item(0).Rows.Item(i).Item(0), ds.Tables.Item(0).Rows.Item(i).Item(1), ds.Tables.Item(0).Rows.Item(i).Item(2), ds.Tables.Item(0).Rows.Item(i).Item(3), ds.Tables.Item(0).Rows.Item(i).Item(4), ds.Tables.Item(0).Rows.Item(i).Item(5), ds.Tables.Item(0).Rows.Item(i).Item(7), ds.Tables.Item(0).Rows.Item(i).Item(8), ds.Tables.Item(0).Rows.Item(i).Item(6))
            Next

            Return lst
        End Function


        Public Shared Function UserByEmail(ByVal count As Integer, ByVal email As String) As User
            Dim l As New UserDAO
            Dim ds As New Data.DataSet
            Dim i As Integer

            ds = l.selectUserbyEmail(count, email)
            Dim lic As User
            If ds.Tables.Item(0).Rows.Count = 0 Then
                Return New User("")
            Else
                lic = New User(ds.Tables.Item(0).Rows.Item(i).Item(0), ds.Tables.Item(0).Rows.Item(i).Item(1), ds.Tables.Item(0).Rows.Item(i).Item(2), ds.Tables.Item(0).Rows.Item(i).Item(3), ds.Tables.Item(0).Rows.Item(i).Item(4), ds.Tables.Item(0).Rows.Item(i).Item(5), ds.Tables.Item(0).Rows.Item(i).Item(7), ds.Tables.Item(0).Rows.Item(i).Item(8), ds.Tables.Item(0).Rows.Item(i).Item(6))
                Return lic
            End If

        End Function

        Public Function InsertUser() As Boolean
            Dim l As New UserDAO
            Return l.insertUser(email, name, surname, pnumber, address, bithday, accountBalance, admin, password)
        End Function

        Public Function DeleteUser() As Boolean
            Dim l As New UserDAO
            Return l.deleteUser(email)
        End Function

        Sub UpdateBalance(balance As Integer)
            Dim l As New UserDAO
            l.updateAccount(email, balance)
        End Sub



    End Class

    Class Cart
        Dim gameTitle As String
        Dim email As String
        Dim developer As String
        Dim gameID As Integer
        Public Sub New(ByVal i As Integer, ByVal n As String, ByVal e As String, ByVal d As String)
            gameTitle = n
            email = e
            developer = d
            gameID = i
        End Sub
        Public Function getEmail() As String
            Return email
        End Function
        Public Function getDeveloper() As String
            Return developer
        End Function
        Public Function getgameTitle() As String
            Return gameTitle
        End Function
        Public Function getId() As Integer
            Return gameID
        End Function
        Public Shared Function getprice(ByVal id As Integer) As Integer
            Dim ko As New CartDao
            Dim ds As New Data.DataSet
            ds = ko.selectPriceCart(id)
            Return ds.Tables.Item(0).Rows.Item(0).Item(0)
        End Function
        Public Shared Function ListItems(ByRef count As Integer, ByVal email As String) As Cart()
            Dim k As New CartDao
            Dim ds As New Data.DataSet
            Dim i As Integer
            ds = k.selectCartByEmail(count, email)
            count = ds.Tables.Item(0).Rows.Count
            Dim lst(count) As Cart
            For i = 0 To count - 1
                lst(i) = New Cart(ds.Tables.Item(0).Rows.Item(i).Item(0), ds.Tables.Item(0).Rows.Item(i).Item(1), ds.Tables.Item(0).Rows.Item(i).Item(3), ds.Tables.Item(0).Rows.Item(i).Item(2))
            Next
            Return lst
        End Function
        Public Shared Function DeleteItem(ByVal id As Integer) As Boolean
            Dim k As New CartDao
            Return k.deleteFromCart(id)
        End Function
        Public Shared Function DeleteFromUserCart(ByVal email As String) As Boolean
            Dim k As New CartDao
            Return k.deleteUserFromCart(email)
        End Function
    End Class

End Module
