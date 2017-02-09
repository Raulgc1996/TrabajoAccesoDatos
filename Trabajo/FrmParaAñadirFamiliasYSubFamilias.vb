Public Class FrmParaAñadirFamiliasYSubFamilias
    Private Sub FrmParaAñadirFamiliasYSubFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Añadir" + esFamiliaOSubFamilia
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtAbrebiatura.Text = "" And TxtNombre.Text = "" Then
            MessageBox.Show("Debe rellenar los campos")
        Else
            If esFamiliaOSubFamilia = "Familia" Then
                Dim mensaje As String
                mensaje = negocio.AñadirNuevaFamilia(txtAbrebiatura.Text, TxtNombre.Text)
                If mensaje = "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico" Then
                    MessageBox.Show(mensaje)
                    Me.Close()
                Else
                    esFamiliaOSubFamilia = ""
                    Me.Close()
                End If
            Else
                Dim mensaje As String
                mensaje = negocio.AñadirNuevaSubfamilia(idFamilia, txtAbrebiatura.Text, TxtNombre.Text)
                If mensaje = "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico" Then
                    MessageBox.Show(mensaje)
                    Me.Close()
                Else
                    idFamilia = 0
                    esFamiliaOSubFamilia = ""
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class