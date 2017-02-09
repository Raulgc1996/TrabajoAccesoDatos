Public Class frmopciones
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnModificarTienda.Click
        FrmCambio.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnControlUsuarios.Click
        FrmControlUsuarios.Show()

    End Sub
End Class