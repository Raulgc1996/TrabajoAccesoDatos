Public Class inici
    Private Sub inici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ajustarResolucion()
    End Sub
    Private Sub ajustarResolucion()
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        For Each item As Control In Controls
            item.Size = New Size((desktopSize.Width * item.Width) / 300, (desktopSize.Height * item.Height) / 300)
            item.Location = New Point((desktopSize.Width * item.Location.X) / 300, (desktopSize.Height * item.Location.Y) / 300)
        Next
    End Sub
End Class