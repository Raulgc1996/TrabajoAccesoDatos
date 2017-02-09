Imports CapaEntidades
Public Class FrmCambio
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub FrmCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsbFamilias.Items.AddRange(negocio.CargarFamiliasExistentes.ToArray)
        lsbFamilias.DisplayMember = "NombreCompleto"
    End Sub

    Private Sub lsbFamilias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbFamilias.SelectedIndexChanged

    End Sub
End Class