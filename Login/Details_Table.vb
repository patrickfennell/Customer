
Imports System.Data.SqlClient
Imports System.Data

Public Class Details_Table

    Public Function Retrieve() As DataTable


        Dim command As New Data.SqlClient.SqlCommand
        Dim dataSet As New Data.DataSet
        Dim ConnectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True "
        Dim strSql As String = "SELECT * From Member"
        Dim _memberDetails As New DataTable
        Dim _connection As New SqlConnection(ConnectionString)

        _connection.Open()

        Dim memberdataTable As New SqlDataAdapter(strSql, _connection)
        memberdataTable.Fill(_memberDetails)

        _connection.Close()

        Return _memberDetails
    End Function

End Class
