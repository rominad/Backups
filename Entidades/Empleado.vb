Imports Entidades

Public Class Empleado
    Implements Entidad
    Private _nombre As String
    Private _sueldo As Single
    Private _departamento As Departamento
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
    Public Property Sueldo As Single
        Get
            Return _sueldo
        End Get
        Set(value As Single)
            If value < 0 Then
                Throw New Exception("El sueldo no puede ser menor a cero!!")
            End If
            _sueldo = value
        End Set
    End Property
    Public Property Departamento As Departamento
        Get
            Return _departamento
        End Get
        Set(value As Departamento)
            _departamento = value
        End Set
    End Property
    Sub New(nombre As String, sueldo As Single)
        Me.Nombre = nombre
        Me.Sueldo = sueldo
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
