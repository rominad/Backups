Public Class Comercio
    Private _ventas As List(Of Venta)
    Private _comision As Single
    Private _vendedores As List(Of Vendedor)
    Public Sub AddVenta(value As Venta)
        _ventas.Add(value)
    End Sub
    Public Function GetAllVentas() As List(Of Venta)
        Return _ventas
    End Function
    'Public Function GetComisionByVendedor(value As Vendedor) As Single
    '    For Each vendedor In _vendedores
    '        If value = vendedor Then
    '            Return vendedor.ComisionPorcentaje
    '        End If
    '    Next
    'End Function
End Class
