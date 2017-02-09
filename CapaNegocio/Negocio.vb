Imports CapaDatos, CapaEntidades
Public Class Negocio
    Public dato As New datos

    Public Function ObtenerEmpleados() As List(Of Empleado)
        Return dato.ObtenerEmpleados()
    End Function
    Public Function ObtenerAdministadores() As List(Of Administradores)
        Return dato.ObtenerAdministadores()
    End Function
    Public Function Login(ByVal nombre As String, ByVal contraseña As String) As String
        Return dato.Login(nombre, contraseña)
    End Function
    Public Function AñadirAdministrador(ByVal admin As Administradores) As String
        Return dato.AñadirAdministrador(admin)
    End Function
    Public Function AñadirEmpleado(ByVal empleado As Empleado) As String
        Return dato.AñadirEmpleado(empleado)
    End Function
    Public Function BorraAdmin(ByVal id As Integer) As String
        Return dato.BorraAdmin(id)
    End Function
    Public Function BorraEmpleado(ByVal id As Integer) As String
        Return dato.BorraEmpleado(id)
    End Function
    Public Function CargarFamiliasExistentes() As List(Of Familia)
        Return dato.CargarFamiliasExistentes()
    End Function
    Public Function CargarSubfamiasDeUnaFamilia(ByVal idFamilia As Integer) As List(Of SubFamilia)
        Return dato.CargarSubfamiasDeUnaFamilia(idFamilia)
    End Function
    Public Function QuitarUnaFamilia(ByVal idFamilia As Integer) As String
        Return dato.QuitarUnaFamilia(idFamilia)
    End Function
    Public Function QuitarTodasLasFamilias() As String
        Return dato.QuitarTodasLasFamilias()
    End Function
    Public Function QuitarUnaSubFamilia(ByVal id As Integer) As String
        Return dato.QuitarUnaSubFamilia(id)
    End Function
    Public Function AñadirNuevaFamilia(ByVal abrebiaturaNombre As String, ByVal nombre As String) As String
        Return dato.AñadirNuevaFamilia(abrebiaturaNombre, nombre)
    End Function
    Public Function AñadirNuevaSubfamilia(ByVal id As Integer, ByVal abrebiatura As String, ByVal nombre As String) As String
        Return dato.AñadirNuevaSubfamilia(id, abrebiatura, nombre)
    End Function
End Class
