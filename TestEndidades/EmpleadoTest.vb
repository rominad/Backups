Imports Entidades
Module EmpleadoTest
    Sub main()
        Try
            Dim empleado1 As New Empleado("Maria", 15000)
            Console.WriteLine(empleado1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
