Public Class Loguin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsuario.Text = "" Or txtContraseña.Text = "" Then
            MessageBox.Show("Debe intoducir todos los datos")
        Else
            Dim mensaje As String
            mensaje = negocio.Login(txtUsuario.Text, txtContraseña.Text)
            If mensaje = "El usuario no existe" Then
                MessageBox.Show(mensaje)
            ElseIf mensaje = "contraseña incorrecta" Then
                MessageBox.Show(mensaje)
            Else
                frmopciones.Show()
                Me.Close()
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class