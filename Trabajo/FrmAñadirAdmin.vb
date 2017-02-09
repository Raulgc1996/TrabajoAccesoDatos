Imports System.IO, CapaEntidades
Public Class FrmAñadirAdmin
    Public rutaFoto As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ptbFoto.Click
        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "Imágenes|*.png;*.jpg|*.*|*.*"

        OpenFileDialog1.Title = "Seleccione una foto"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ptbFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, "Fotos\" + OpenFileDialog1.SafeFileName, FileIO.UIOption.AllDialogs,
    FileIO.UICancelOption.DoNothing)
            rutaFoto = "Fotos\" + OpenFileDialog1.SafeFileName
        End If

    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        FrmControlUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Debe introducir un Nombre")
        Else
            If TxtApellido1.Text = "" Or TxtApellido2.Text = "" Then
                MessageBox.Show("Debe intoducir ambos apellidos")
            Else
                If TxtContraseña.Text = "" Then
                    MessageBox.Show("Debe introducir una contraseña")
                Else
                    Dim nuevoAdmin As New Administradores
                    nuevoAdmin.Nombre = txtNombre.Text
                    nuevoAdmin.Apellido = TxtApellido1.Text + " " + TxtApellido2.Text
                    nuevoAdmin.Contraseña = TxtContraseña.Text
                    nuevoAdmin.Foto = rutaFoto
                    Dim mensaje As String
                    mensaje = negocio.AñadirAdministrador(nuevoAdmin)
                    If mensaje = "El usuario ya existe" Then
                        MessageBox.Show(mensaje)
                        If ptbFoto.Image IsNot Nothing Then My.Computer.FileSystem.DeleteFile(rutaFoto)
                    ElseIf mensaje = "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico, *O PUEDE QUE SEA QUE ALGUEN A PUESTO TODOS LOS CAMPOS COMO NVARCHAR(1)" Then
                        MessageBox.Show(mensaje)
                        If ptbFoto.Image IsNot Nothing Then My.Computer.FileSystem.DeleteFile(rutaFoto)
                    Else
                        txtNombre.Text = ""
                        TxtApellido1.Text = ""
                        TxtApellido2.Text = ""
                        TxtContraseña.Text = ""
                        ptbFoto.Image = Nothing
                        rutaFoto = ""
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub FrmAñadirAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rutaFoto = ""
    End Sub
End Class