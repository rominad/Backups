Imports Entidades
Module GerenteTest
    Sub main()
        Dim fecha As Date = #7/24/2018#
        Dim gerente1 As New Gerente("Maria", 15000)
        Dim vendedor1 As New Vendedor("Maria", 1000, 0.1)
        Dim venta1 As New Venta(fecha, 1000, vendedor1)
        Dim venta2 As New Venta(fecha, 1000, vendedor1)
        Dim venta3 As New Venta(Today, 1000, vendedor1)
        vendedor1.AddVentas(venta1)
        vendedor1.AddVentas(venta2)
        vendedor1.AddVentas(venta3)

        Console.WriteLine("Comision = {0}", gerente1.GetMontoComision(2018, 7))
        Console.WriteLine("Lista de Ventas = ")
        For Each venta In gerente1.GetVentas(2018, 7)
            Console.WriteLine("-  {0}", venta)
        Next
        Console.ReadKey()
    End Sub
End Module
