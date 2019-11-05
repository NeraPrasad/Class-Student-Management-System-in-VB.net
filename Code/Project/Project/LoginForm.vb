Imports MySql.Data.MySqlClient
Public Class LoginForm

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'MySqlConnection = Configured using a connection string
        'MySqlDataReader = Read MySql Database
        'MySqlCommand = Represent MySql Stetament
        'ExecuteReader = Geting the query Result
        'EcecuteScalar = Excute the query and return colum of first Row
        'System.Data.SqlClient = Namespace is the .NET Data Provider

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "select * from classminiproject.tbluser where UserName='" & txtUser.Text & "' and Password='" & txtPassword.Text & "'  "

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("User Name and Password are Correct")
                Me.Hide()
                Dim Home As New Home
                Home.Show()
            ElseIf count > 1 Then
                MessageBox.Show("User Name and Password are Duplicate")
            Else
                MessageBox.Show("User Name and Password are Not Correct")
            End If

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub



    Private Sub LblRegister_Click(sender As Object, e As EventArgs) Handles LblRegister.Click
        Dim a As New Register
        a.Show()
        Me.Hide()

    End Sub

    

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
