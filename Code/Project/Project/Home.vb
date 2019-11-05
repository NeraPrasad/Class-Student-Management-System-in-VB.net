Imports MySql.Data.MySqlClient

Public Class Home

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    'Side Bar Panel ======================================================================= Start****
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        pnlOnButtonAddStudent.Height = btnAddStudent.Height
        pnlOnButtonAddStudent.Top = btnAddStudent.Top

        pnlAddStudent.Visible = True
        pnlStudentDetails.Visible = False
        pnlFees.Visible = False
        pnlTeachers.Visible = False
        pnlTeachers.Visible = False
        pnlHome.Visible = False



    End Sub

    Private Sub btnMoney_Click(sender As Object, e As EventArgs) Handles btnMoney.Click
        pnlOnButtonMoney.Height = btnMoney.Height
        pnlOnButtonMoney.Top = btnMoney.Top

        pnlStudentDetails.Visible = False
        pnlFees.Visible = True
        pnlAddStudent.Visible = False
        pnlTeachers.Visible = False
        pnlTimetable.Visible = False
        pnlHome.Visible = False


    End Sub

    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        pnlOnButtonTeachers.Height = btnTeachers.Height
        pnlOnButtonTeachers.Top = btnTeachers.Top

        pnlStudentDetails.Visible = False
        pnlAddStudent.Visible = False
        pnlTeachers.Visible = True
        pnlFees.Visible = False
        pnlTimetable.Visible = False
        pnlHome.Visible = False


    End Sub

    Private Sub btnTimetable_Click(sender As Object, e As EventArgs) Handles btnTimetable.Click
        pnlOnButtonTimeTable.Height = btnTimetable.Height
        pnlOnButtonTimeTable.Top = btnTimetable.Top

        pnlStudentDetails.Visible = False
        pnlAddStudent.Visible = False
        pnlFees.Visible = False
        pnlTimetable.Visible = True
        pnlTeachers.Visible = False
        pnlHome.Visible = False


    End Sub
    Private Sub btnStudentdetails_Click(sender As Object, e As EventArgs) Handles btnStudentdetails.Click
        pnlOnButtonStudentdetails.Height = btnStudentdetails.Height
        pnlOnButtonStudentdetails.Top = btnStudentdetails.Top


        pnlStudentDetails.Visible = True
        pnlAddStudent.Visible = False
        pnlFees.Visible = False
        pnlTeachers.Visible = False
        pnlTimetable.Visible = False
        pnlHome.Visible = False


    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pnlOnButtonHome.Height = btnHome.Height
        pnlOnButtonHome.Top = pnlOnButtonHome.Top


        pnlStudentDetails.Visible = False
        pnlAddStudent.Visible = False
        pnlFees.Visible = False
        pnlTeachers.Visible = False
        pnlTimetable.Visible = False
        pnlHome.Visible = True


    End Sub
    'Side Bar Panel ======================================================================= Finish****

    'Upbar Close,Minimize ======================================================================= Start****
    Private Sub picMininize_Click(sender As Object, e As EventArgs) Handles picMininize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click

        Me.WindowState = FormWindowState.Maximized
    End Sub

    'Upbar Close,Minimize ======================================================================= Finish****

    Private Sub btlLogOut_Click(sender As Object, e As EventArgs) Handles btlLogOut.Click
        LoginForm.Show()
        Me.Hide()
    End Sub


    'Add Student Panel ======================================================================= Start****
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

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
            Query = "insert into classminiproject.tblstudent (RegNo,Name,Phone,Address) values ('" & txtRegNo.Text & "','" & txtName.Text & "','" & txtMobileNumber.Text & "','" & txtAddres.Text & "')"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Saved")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


        txtAddres.Text = ""
        txtMobileNumber.Text = ""
        txtName.Text = ""

    End Sub

    Private Sub btnSUpdate_Click(sender As Object, e As EventArgs) Handles btnSUpdate.Click

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
            Query = "update classminiproject.tblstudent set Name='" & txtName.Text & "',Phone='" & txtMobileNumber.Text & "',Address='" & txtAddres.Text & "' where RegNo='" & txtRegNo.Text & "'"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Update Data")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        txtRegNo.Text = ""
        txtAddres.Text = ""
        txtMobileNumber.Text = ""
        txtName.Text = ""
    End Sub
    'Add Student Panel ======================================================================= Finish****

    'StudentDetails Load Tabel ======================================================================= Start****

    Private Sub StudentTableLoad()

        'MySqlConnection = Configured using a connection string
        'MySqlDataReader = Read MySql Database
        'MySqlCommand = Represent MySql Stetament
        'ExecuteReader = Geting the query Result
        'EcecuteScalar = Excute the query and return colum of first Row
        'System.Data.SqlClient = Namespace is the .NET Data Provider

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select RegNo,Name,Phone,Address from classminiproject.tblstudent"

            COMMAND = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgvStudentDetails.DataSource = bSource
            SDA.Update(dbDataSet)



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub btnLoadTable_Click(sender As Object, e As EventArgs) Handles btnLoadTable.Click


        'MySqlConnection = Configured using a connection string
        'MySqlDataReader = Read MySql Database
        'MySqlCommand = Represent MySql Stetament
        'ExecuteReader = Geting the query Result
        'EcecuteScalar = Excute the query and return colum of first Row
        'System.Data.SqlClient = Namespace is the .NET Data Provider

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select RegNo,Name,Phone,Address from classminiproject.tblstudent"

            COMMAND = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgvStudentDetails.DataSource = bSource
            SDA.Update(dbDataSet)



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub


  
    'StudentDetails Load Tabel ======================================================================= Finish****


    ' Teacher Panel ======================================================================= Start****


    'MySqlConnection = Configured using a connection string
    'MySqlDataReader = Read MySql Database
    'MySqlCommand = Represent MySql Stetament
    'ExecuteReader = Geting the query Result
    'EcecuteScalar = Excute the query and return colum of first Row
    'System.Data.SqlClient = Namespace is the .NET Data Provider

    Private Sub btnT_Save_Click(sender As Object, e As EventArgs) Handles btnT_Save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into classminiproject.tblteachers (RegNo,Name,Phone) values ('" & txtT_RegisterNumber.Text & "','" & txtT_Name.Text & "','" & txtT_MobileNumber.Text & "')"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("New Teacher Data Saved")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        TLoadTable()


        txtT_MobileNumber.Text = ""
        txtT_Name.Text = ""
        txtT_RegisterNumber.Text = ""

    End Sub

    Private Sub TLoadTable()

        'MySqlConnection = Configured using a connection string
        'MySqlDataReader = Read MySql Database
        'MySqlCommand = Represent MySql Stetament
        'ExecuteReader = Geting the query Result
        'EcecuteScalar = Excute the query and return colum of first Row
        'System.Data.SqlClient = Namespace is the .NET Data Provider

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from classminiproject.tblteachers"

            COMMAND = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgvTeachers.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnTLoadTable_Click(sender As Object, e As EventArgs) Handles btnTLoadTable.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from classminiproject.tblteachers"

            COMMAND = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgvTeachers.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub btnT_Update_Click(sender As Object, e As EventArgs) Handles btnT_Update.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update classminiproject.tblteachers set Name='" & txtT_Name.Text & "',Phone='" & txtT_MobileNumber.Text & "' where RegNo='" & txtT_RegisterNumber.Text & "'"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Update Data")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        TLoadTable()

    End Sub
    ' Teacher Panel ======================================================================= Finish****



    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TLoadTable()
        StudentTableLoad()
        TimetableLoad()
        classfeesLoad()
    End Sub

    
   
   
    
    ' TIme Table Panel ======================================================================= Start****
    Private Sub btnTimeSave_Click(sender As Object, e As EventArgs) Handles btnTimeSave.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into classminiproject.tbltimetable (Date,Subject,Hall) values ('" & DateTimePickerTimeTable.Text & "','" & txtTimeSubject.Text & "','" & txtTimeHall.Text & "')"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Saved")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        txtTimeSubject.Text = ""
        txtTimeHall.Text = ""
        
    End Sub

    Private Sub TimetableLoad()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select Date,Subject,Hall from classminiproject.tbltimetable"

            COMMAND = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridViewTT.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnTimeLoadTable_Click_1(sender As Object, e As EventArgs) Handles btnTimeLoadTable.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select Date,Subject,Hall from classminiproject.tbltimetable"

            COMMAND = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridViewTT.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    ' TIme Table Panel ======================================================================= Finish**** 

    ' Class Fees Panel ======================================================================= Start**** 
    Private Sub btnPayied_Click(sender As Object, e As EventArgs) Handles btnPayied.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE classminiproject.tblstudent SET Classfees= 'Yes' WHERE RegNo='" & txtClassFeesID.Text & "'"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Pay Class Fees")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        txtClassFeesID.Text = ""

    End Sub

    
    Private Sub btnFeesLoad_Click(sender As Object, e As EventArgs) Handles btnFeesLoad.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select RegNo,Name,Phone,Classfees from classminiproject.tblstudent"

            COMMAND = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView_F.DataSource = bSource
            SDA.Update(dbDataSet)



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub classfeesLoad()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select RegNo,Name,Phone,Classfees from classminiproject.tblstudent"

            COMMAND = New MySqlCommand(Query, MysqlConn)

            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView_F.DataSource = bSource
            SDA.Update(dbDataSet)



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btlTotal_Click(sender As Object, e As EventArgs) Handles btlTotal.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=classminiproject"



        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select count(Classfees) FROM classminiproject.tblstudent where Classfees='Yes'"

            COMMAND = New MySqlCommand(Query, MysqlConn)

            Dim totalPayCount As Integer
            Dim totalMoneyCount As Integer

            totalPayCount = COMMAND.ExecuteScalar

            totalMoneyCount = totalPayCount * 500

            lblTotal.Text = totalMoneyCount.ToString
            lblPayTotal.Text = totalPayCount.ToString

            MysqlConn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    ' Class Fees Panel ======================================================================= Finish****  
   
   

   
   
End Class