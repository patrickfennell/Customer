
Imports System.Data.SqlClient
Imports System.Data

Public Class Retrive_Data
    Inherits System.Windows.Forms.Form


    Dim _databaseTable As New DataTable
    Dim detailTable As New Details_Table

    Private Sub Retrive_Data_Load(sender As Object,
                                  e As EventArgs) Handles MyBase.Load
        _databaseTable = detailTable.Retrieve

        With myDataGridView
            .AutoGenerateColumns = True
            .DataSource = _databaseTable

        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object,
                                e As EventArgs) Handles btnDelete.Click
        Dim ConnectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True "
        Dim strSql = "DELETE  from Member where ID = " & myDataGridView.CurrentRow.Cells(0).Value.ToString()

        Dim _sqlConnection As New SqlConnection
        Dim _sqlCommand As New SqlCommand

        Using _insertIntoTable As New SqlConnection(ConnectionString)
            _insertIntoTable.Open()

            Dim command As New SqlCommand()
            command.CommandText = "DELETE  from Member where ID = " & myDataGridView.CurrentRow.Cells(0).Value.ToString()

            command.Connection = _insertIntoTable
            command.ExecuteNonQuery()

            _insertIntoTable.Close()
        End Using

        myDataGridView.Rows.RemoveAt(myDataGridView.SelectedRows(0).Index)
        myDataGridView.Update()
        ' _databaseTable.AcceptChanges()

    End Sub

    Private Sub myDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles myDataGridView.CellContentClick

    End Sub

    Private Sub btnHome_Click(sender As Object,
                               e As EventArgs) Handles btnHome.Click
        Dim _home As New Home
        _home.Show()
        Me.Visible = False

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintForm1.Print()
    End Sub
End Class