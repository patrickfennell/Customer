
Public Class Customer

    Private _firstName As String
    Private _lastName As String
    Private _eMail As String
    Private _gender As String
    Private _age As Integer

    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal Value As String)
            _firstName = Value
        End Set
    End Property


    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal Value As String)
            _lastName = Value
        End Set
    End Property


    Public Property EMail() As String
        Get
            Return _eMail
        End Get
        Set(ByVal Value As String)
            _eMail = Value
        End Set
    End Property


    Public Property Gender() As String
        Get
            Return _gender
        End Get
        Set(ByVal Value As String)
            _gender = Value
        End Set
    End Property


    Public Property Age() As Integer
        Get
            Return _age
        End Get
        Set(ByVal Value As Integer)
            _age = Value
        End Set
    End Property

End Class



