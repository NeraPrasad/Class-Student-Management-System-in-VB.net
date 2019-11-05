Imports MySql.Data.MySqlClient

Public Class Register

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnSingUP_Click(sender As Object, e As EventArgs) Handles btnSingUP.Click

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
            Query = "insert into classminiproject.tbluser (UserName,Password) values ('" & txtUser.Text & "','" & txtPassword.Text & "')"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Saved")
            MysqlConn.Close()

            LoginForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class
