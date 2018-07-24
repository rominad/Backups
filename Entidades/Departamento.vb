Imports Entidades

Public Class Departamento
    Implements Entidad
    Private _nombre As String
    Private _vendedores As List(Of Vendedor)
    Private _gerente As Gerente
    Private _ventas As List(Of Venta)

    Public Property Nombre As String Implements Entidad.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value = "" Then
                Throw New Exception("El nombre no puede estar vacio!!")
            End If
            _nombre = value
        End Set
    End Property
    Public Property Gerente As Gerente
        Get
            Return _gerente
        End Get
        Set(value As Gerente)
            _gerente = value
        End Set
    End Property
    Public Function GetVentas(anio As UShort, mes As UShort) As List(Of Venta)
        Dim lista As New List(Of Venta)
        For Each venta In _ventas
            If (venta.Fecha.Month() = mes) And (venta.Fecha.Year() = anio) Then
                lista.Add(venta)
            End If
        Next
        Return lista
    End Function
    Public Sub addVendedores(value As Vendedor)
        _vendedores.Add(value)
    End Sub
    Public Sub removeVendedor(value As Vendedor)
        _vendedores.Remove(value)
    End Sub
    Public Function getAllVendedores() As List(Of Vendedor)
        Return _vendedores
    End Function
    Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
