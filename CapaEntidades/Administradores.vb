﻿Public Class Administradores

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Contraseña As String
    Public Property Foto As String
    Property Apellido As String

    Public Sub New()

    End Sub
    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal apellido As String, ByVal contraseña As String, ByVal foto As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Contraseña = contraseña
        Me.Foto = foto

    End Sub
End Class
