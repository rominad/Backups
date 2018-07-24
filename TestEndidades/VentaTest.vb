Imports Entidades

Module VentaTest
    Sub main()
        Try
            Dim vendedor1 As New Vendedor("Maria", 2000, 0.2)
            Dim venta1 As New Venta(Today, 1000, vendedor1)
            Console.WriteLine(venta1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()

    End Sub
End Module
