Public Class Familia
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property NombreCompleto As String

    Public Sub New()

    End Sub
    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal nombreCompleto As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.NombreCompleto = nombreCompleto

    End Sub
End Class
