Public Class Gerente
    Inherits Empleado
    Private _ventas As List(Of Venta)
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
    Sub New(nombre As String, sueldo As Single)
        MyBase.New(nombre, sueldo)
        _ventas = New List(Of Venta)

    End Sub
End Class
