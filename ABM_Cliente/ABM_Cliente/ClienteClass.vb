Public Class ClienteClass
    Dim id_ As Integer
    Dim Nombre_, Direccion_, CategIva_ As String
    Dim Saldo_ As Decimal

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property

    Public Property CategIva() As String
        Get
            Return CategIva_
        End Get
        Set(ByVal value As String)
            CategIva_ = value
        End Set
    End Property

    Public Property Saldo() As Decimal
        Get
            Return Saldo_
        End Get
        Set(ByVal value As Decimal)
            Saldo_ = value
        End Set
    End Property
End Class
