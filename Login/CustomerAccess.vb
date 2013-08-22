
Imports System.Data
Imports System.Data.SqlClient

Public Class CustomerAccess

    Public Sub SaveCustomer(
                           Entity As Customer)


        Dim _sqlConnection As New SqlConnection
        Dim _sqlCommand As New SqlCommand

        Dim _databaseConnectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True "

        Using _insertIntoTable As New SqlConnection(_databaseConnectionString)

            _insertIntoTable.Open()

            Dim command As New SqlCommand()
            command.CommandText = "INSERT INTO Member Values ( @Firstname, @Lastname, @Email, @Gender, @Age,@CreatedBy,@Creationtimestamp)"

            Dim _firstName As New SqlParameter("@Firstname", SqlDbType.VarChar)
            _firstName.Value = Entity.FirstName
            command.Parameters.Add(_firstName)

            Dim _lastName As New SqlParameter("@Lastname", SqlDbType.VarChar)
            _lastName.Value = Entity.LastName
            command.Parameters.Add(_lastName)

            Dim _eMail As New SqlParameter("@Email", SqlDbType.VarChar)
            _eMail.Value = Entity.EMail
            command.Parameters.Add(_eMail)

            Dim _gender As New SqlParameter("@Gender", SqlDbType.VarChar)
            _gender.Value = Entity.Gender
            command.Parameters.Add(_gender)


            Dim _age = New SqlParameter("@Age", SqlDbType.Int)
            _age.Value = Entity.Age
            command.Parameters.Add(_age)


            Dim _createdBy = New SqlParameter("@CreatedBy", SqlDbType.VarChar)
            _createdBy.Value = "Administrator"
            command.Parameters.Add(_createdBy)


            Dim _creationTimeStamp = New SqlParameter("@CreationTimestamp", SqlDbType.DateTime)
            _creationTimeStamp.Value = Date.Now
            command.Parameters.Add(_creationTimeStamp)

            command.Connection = _insertIntoTable
            command.ExecuteNonQuery()

            _insertIntoTable.Close()

        End Using
    End Sub

End Class
