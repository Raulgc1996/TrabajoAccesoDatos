Public Class SubFamilia
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property NombreCompleto As String
    Public Property IdFamilia As Integer
    Public Property Valor As Integer

    Public Sub New()

    End Sub
    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal nombreCompleto As String, ByVal idFamilia As Integer, ByVal valor As Integer)
        Me.Id = id
        Me.Nombre = nombre
        Me.NombreCompleto = nombreCompleto
        Me.IdFamilia = idFamilia
        Me.Valor = valor
    End Sub
End Class
