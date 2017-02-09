Imports System.IO
Imports CapaEntidades
Public Class FrmCambio
    Private ruta As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub FrmCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsbFamilias.Items.AddRange(negocio.CargarFamiliasExistentes.ToArray)
        lsbFamilias.DisplayMember = "NombreCompleto"
    End Sub

    Private Sub lsbFamilias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbFamilias.SelectedIndexChanged
        lsbSubfamilias.Items.Clear()
        lsbSubfamilias.Items.AddRange(negocio.CargarSubfamiasDeUnaFamilia(lsbFamilias.SelectedItem.Id).ToArray)
        lsbSubfamilias.DisplayMember = "NombreCompleto"
    End Sub

    Private Sub btnCambioNombre_Click(sender As Object, e As EventArgs) Handles btnCambioNombre.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("debe introducir un nuevo nombre")
        Else
            Dim fileReader As String
            Try
                fileReader = My.Computer.FileSystem.ReadAllText("info.txt")
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error fatal, consulte al servicio tecnico")
            End Try
            Dim cambioDeTitulo = fileReader.Split(":")
            cambioDeTitulo(1) = txtNombre.Text
            Try
                My.Computer.FileSystem.DeleteFile("info.txt")
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error fatal, consulte al servicio tecnico")
            Finally
                My.Computer.FileSystem.WriteAllText("info.txt", cambioDeTitulo(0) + ":" + cambioDeTitulo(1) + ":" + cambioDeTitulo(2) + ":" + cambioDeTitulo(3), True)
            End Try
            MessageBox.Show("La operacion se realizo con exito")
            txtNombre.Text = ""
        End If
    End Sub

    Private Sub ptbLogo_Click(sender As Object, e As EventArgs) Handles ptbLogo.Click
        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "Imágenes|*.png;*.jpg|*.*|*.*"
        OpenFileDialog1.Title = "Seleccione una foto"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ptbLogo.Image = Image.FromFile(OpenFileDialog1.FileName)
            My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, "Fotos\" + OpenFileDialog1.SafeFileName, FileIO.UIOption.AllDialogs,
    FileIO.UICancelOption.DoNothing)
            ruta = "Fotos\" + OpenFileDialog1.SafeFileName
        End If
    End Sub

    Private Sub BtnCambiarLogo_Click(sender As Object, e As EventArgs) Handles BtnCambiarLogo.Click
        If ptbLogo.Image Is Nothing Then
            MessageBox.Show("Debe seleccionar una foto")
        Else
            Dim fileReader As String
            Try
                fileReader = My.Computer.FileSystem.ReadAllText("info.txt")
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error fatal, consulte al servicio tecnico")
                My.Computer.FileSystem.DeleteFile(ruta)
            End Try
            Dim cambioDeTitulo = fileReader.Split(":")
            My.Computer.FileSystem.DeleteFile(cambioDeTitulo(3))
            cambioDeTitulo(3) = ruta
            Try
                My.Computer.FileSystem.DeleteFile("info.txt")
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error fatal, consulte al servicio tecnico")
                My.Computer.FileSystem.DeleteFile(ruta)
            Finally
                My.Computer.FileSystem.WriteAllText("info.txt", cambioDeTitulo(0) + ":" + cambioDeTitulo(1) + ":" + cambioDeTitulo(2) + ":" + cambioDeTitulo(3), True)
            End Try
            MessageBox.Show("La operacion se realizo con exito")
            ptbLogo.Image = Nothing
            ruta = ""
        End If
    End Sub

    Private Sub BtnBorrarSubFamilia_Click(sender As Object, e As EventArgs) Handles BtnBorrarSubFamilia.Click
        If lsbSubfamilias.SelectedItem Is Nothing Then
            MessageBox.Show("Debe seleccionar una subfamilia")
        Else
            Dim mensaje As String
            mensaje = negocio.QuitarUnaSubFamilia(lsbSubfamilias.SelectedItem.Id)
            If mensaje = "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico" Then
                MessageBox.Show(mensaje)
            Else
                lsbSubfamilias.Items.Clear()
                lsbSubfamilias.Items.AddRange(negocio.CargarSubfamiasDeUnaFamilia(lsbFamilias.SelectedItem.Id).ToArray)
                lsbSubfamilias.DisplayMember = "NombreCompleto"
            End If
        End If
    End Sub

    Private Sub BtnBorrarTodasLasFamilias_Click(sender As Object, e As EventArgs) Handles BtnBorrarTodasLasFamilias.Click
        Dim mensaje As String
        mensaje = negocio.QuitarTodasLasFamilias()
        If mensaje = "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico" Then
            MessageBox.Show(mensaje)
        Else
            lsbFamilias.Items.Clear()
            lsbFamilias.Items.AddRange(negocio.CargarFamiliasExistentes.ToArray)
            lsbFamilias.DisplayMember = "NombreCompleto"
        End If
    End Sub

    Private Sub BtnBorrarFamilia_Click(sender As Object, e As EventArgs) Handles BtnBorrarFamilia.Click
        If lsbFamilias.SelectedItem Is Nothing Then
            MessageBox.Show("Debe seleccionar una familia")
        Else
            Dim mensaje As String
            mensaje = negocio.QuitarUnaFamilia(lsbFamilias.SelectedItem.Id)
            If mensaje = "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico" Then
                MessageBox.Show(mensaje)
            Else
                lsbFamilias.Items.Clear()
                lsbFamilias.Items.AddRange(negocio.CargarFamiliasExistentes.ToArray)
                lsbFamilias.DisplayMember = "NombreCompleto"
            End If
        End If
    End Sub
End Class