Imports CapaNegocio
Module Modulo
    Public negocio As New Negocio
    Public esFamiliaOSubFamilia As String
    Public idFamilia As Integer
    Public Function ObtenerNombreYLogoDeLaTienda() As String()
        Dim fileReader As String
        Try
            fileReader = My.Computer.FileSystem.ReadAllText("info.txt")
        Catch ex As Exception
            Dim str(1) As String
            str(0) = "Error"
            Return str
        End Try

        Dim tituloYLogo = fileReader.Split(":")
        Dim arrayConTituloYLogo(2) As String
        arrayConTituloYLogo(0) = tituloYLogo(1)
        arrayConTituloYLogo(1) = tituloYLogo(3)
        Return arrayConTituloYLogo
    End Function
End Module
