Imports System.Security.Cryptography

Imports System.Data.SqlClient
Imports System.Data

Partial Public Class Login_Form


    Public Login_Form()


    Private Sub login(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub btnLogin_Click(sender As Object,
                               e As EventArgs) Handles btnLogin.Click

        Dim _userName = txtUser.Text

        Dim _password = txtPassword.Text

        Dim _sqlConnectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=UserLogin;Integrated Security=True "
        Dim _connection = New SqlConnection(_sqlConnectionString)
        Dim _sqlSelect As String = "SELECT * From UserVerification "

        Dim _userTable As New DataTable()

        _connection.Open()

        Using _userDataTable As New SqlDataAdapter(_sqlSelect, _connection)
            _userDataTable.Fill(_userTable)

        End Using
        Dim _Verify = _userTable.Select(String.Format("username = '{0}'AND password = '{1}'", _userName, _password))

        If _Verify.Length = 1 Then

            Dim _home = New Home
            txtUser.Clear()
            txtPassword.Clear()
            _home.Show()
            Me.Visible = False
            
        Else
            lblError.Text = "Invalid username password combination"
            txtUser.Clear()
            txtPassword.Clear()

        End If
       
        _connection.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "*"c
    End Sub

End Class









