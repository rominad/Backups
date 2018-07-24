Public Class Vendedor
    Inherits Empleado
    Private _ComisionPorcentaje As Single
    Private _ventas As List(Of Venta)
    Public Property ComisionPorcentaje As Single
        Get
            Return _ComisionPorcentaje
        End Get
        Set(value As Single)
            _ComisionPorcentaje = value
        End Set
    End Property
    Public Function Mensualidad(anio As UShort, mes As UShort) As Single
        Dim totalVentas As New Single
        For Each venta In _ventas
            If (venta.Fecha.Month() = mes) And (venta.Fecha.Year() = anio) Then
                totalVentas += venta.Monto * ComisionPorcentaje
            End If
        Next
        Return Sueldo + totalVentas
    End Function
    Public Sub AddVentas(value As Venta)
        _ventas.Add(value)
    End Sub
    Public Function GetVentas(anio As UShort, mes As UShort) As List(Of Venta)
        Dim lista As New List(Of Venta)
        For Each venta In _ventas
            If (venta.Fecha.Month() = mes) And (venta.Fecha.Year() = anio) Then
                lista.Add(venta)
            End If
        Next
        Return lista
    End Function
    Public Function GetMontoComision(anio As UShort, mes As UShort) As Single
        Dim total As New Single
        For Each venta In _ventas
            If (venta.Fecha.Month() = mes) And (venta.Fecha.Year() = anio) Then
                total += venta.Monto + (venta.Vendedor.Sueldo * venta.Vendedor.ComisionPorcentaje)
            End If
        Next
        Return total
    End Function

    Sub New(nombre As String, sueldo As Single, comision As Single)
        MyBase.New(nombre, sueldo)
        Me.ComisionPorcentaje = comision
        _ventas = New List(Of Venta)
    End Sub
End Class
