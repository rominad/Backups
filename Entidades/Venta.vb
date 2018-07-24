Public Class Venta
    Private _fecha As Date
    Private _monto As Single
    Private _vendedor As Vendedor
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Monto As Single
        Get
            Return _monto
        End Get
        Set(value As Single)
            _monto = value
        End Set
    End Property
    Public Property Vendedor As Vendedor
        Get
            Return _vendedor
        End Get
        Set(value As Vendedor)
            _vendedor = value
        End Set
    End Property
    Sub New(fecha As Date, monto As Single, vendedor As Vendedor)
        Me.Fecha = fecha
        Me.Monto = monto
        Me.Vendedor = vendedor
    End Sub
    Public Overrides Function ToString() As String
        Return Fecha & " - $" & Monto
    End Function
End Class
