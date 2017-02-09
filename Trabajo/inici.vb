Public Class inici
    Private Sub inici_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tituloYLogo() As String
        tituloYLogo = ObtenerNombreYLogoDeLaTienda()

        If tituloYLogo(0) <> "Error" Then
            lbnTitulo.Text = tituloYLogo(0)
            ptbLogo.ImageLocation = tituloYLogo(1)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Loguin.Show()

    End Sub
End Class