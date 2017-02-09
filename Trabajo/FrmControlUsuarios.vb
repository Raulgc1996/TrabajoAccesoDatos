Imports CapaEntidades
Public Class FrmControlUsuarios
    Public ruta As String
    Private Sub FrmControlUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboAdministradores.Items.AddRange(negocio.ObtenerAdministadores().ToArray)
        cboAdministradores.DisplayMember = "Nombre"
        cboEmpleados.Items.AddRange(negocio.ObtenerEmpleados.ToArray)
        cboEmpleados.DisplayMember = "Nombre"

    End Sub

    Private Sub cboAdministradores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAdministradores.SelectedIndexChanged
        ptbFoto.ImageLocation = cboAdministradores.SelectedItem.Foto
        ruta = cboAdministradores.SelectedItem.Foto
        If ptbFoto.Image Is Nothing Then ptbFoto.ImageLocation = "Fotos/ad.png"
    End Sub

    Private Sub cboEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpleados.SelectedIndexChanged
        ptbFoto.ImageLocation = cboEmpleados.SelectedItem.Foto
        ruta = cboEmpleados.SelectedItem.Foto
        If ptbFoto.Image Is Nothing Then ptbFoto.ImageLocation = "Fotos/em.png"
    End Sub

    Private Sub btnAñadirAdmin_Click(sender As Object, e As EventArgs) Handles btnAñadirAdmin.Click
        FrmAñadirAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnAñadirEmpleado_Click(sender As Object, e As EventArgs) Handles btnAñadirEmpleado.Click
        FrmAñadir.Show()
        Me.Close()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If cboAdministradores.SelectedItem Is Nothing And cboEmpleados.SelectedItem Is Nothing Then
            MessageBox.Show("Debe selecccionar un Empleado/Administrador")
        Else
            If cboAdministradores.SelectedItem IsNot Nothing And cboEmpleados.SelectedItem Is Nothing Then
                Dim mensaje As String
                mensaje = negocio.BorraAdmin(cboAdministradores.SelectedItem.Id)
                If mensaje = "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico" Then
                    MessageBox.Show(mensaje)
                Else
                    If ruta <> "" Then
                        Try
                            My.Computer.FileSystem.DeleteFile(ruta)
                        Catch ex As Exception
                            MessageBox.Show("La foto no ha sido encontrada")
                        Finally
                            ptbFoto.Image = Nothing
                        End Try
                    End If
                    cboAdministradores.Items.Clear()
                    cboAdministradores.Items.AddRange(negocio.ObtenerAdministadores().ToArray)
                    cboAdministradores.DisplayMember = "Nombre"
                End If
                    ElseIf cboAdministradores.SelectedItem Is Nothing And cboEmpleados.SelectedItem IsNot Nothing Then
                Dim mensaje As String
                mensaje = negocio.BorraEmpleado(cboEmpleados.SelectedItem.Id)
                If mensaje = "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico" Then
                    MessageBox.Show(mensaje)
                Else
                    If ruta <> "" Then
                        Try
                            My.Computer.FileSystem.DeleteFile(ruta)
                        Catch ex As Exception
                            MessageBox.Show("La foto no ha sido encontrada")
                        Finally
                            ptbFoto.Image = Nothing
                        End Try
                    End If
                    cboEmpleados.Items.Clear()
                    cboEmpleados.Items.AddRange(negocio.ObtenerEmpleados.ToArray)
                    cboEmpleados.DisplayMember = "Nombre"
                End If
            Else
                MessageBox.Show("Debe selecccionar solo una persona")
            End If
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        frmopciones.Show()
        Me.Close()

    End Sub
End Class