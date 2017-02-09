Imports CapaEntidades
Public Class datos
    Private dsEstado As DataSet1
    Private daAdministrador As DataSet1TableAdapters.ADMINISTRADORESTableAdapter
    Private daUsuarios As DataSet1TableAdapters.EMPLEADOSTableAdapter
    Private daFamilias As DataSet1TableAdapters.FAMILIASTableAdapter
    Private daSubFamilias As DataSet1TableAdapters.SUBFAMILIASTableAdapter
    Private Sub CrearDataSetEstado()
        dsEstado = New DataSet1
        daAdministrador = New DataSet1TableAdapters.ADMINISTRADORESTableAdapter
        daAdministrador.Fill(dsEstado.ADMINISTRADORES)
        daUsuarios = New DataSet1TableAdapters.EMPLEADOSTableAdapter
        daUsuarios.Fill(dsEstado.EMPLEADOS)
        daFamilias = New DataSet1TableAdapters.FAMILIASTableAdapter
        daFamilias.Fill(dsEstado.FAMILIAS)
        daSubFamilias = New DataSet1TableAdapters.SUBFAMILIASTableAdapter
        daSubFamilias.Fill(dsEstado.SUBFAMILIAS)
    End Sub
    Public Sub New()
        CrearDataSetEstado()
    End Sub
    Public Function ObtenerEmpleados() As List(Of Empleado)
        Dim empleados = (From drEmpleado In dsEstado.EMPLEADOS Select New Empleado(drEmpleado.COD_EMPLEADO, drEmpleado.NOMBRE, drEmpleado.APELLIDO, drEmpleado.FOTO)).ToList
        Return empleados
    End Function
    Public Function ObtenerAdministadores() As List(Of Administradores)
        Dim administradores = (From dradministrador In dsEstado.ADMINISTRADORES Select New Administradores(dradministrador.ID, dradministrador.USUARIO, dradministrador.APELLIDO, dradministrador.CONTRASEÑA, dradministrador.FOTO)).ToList
        Return administradores
    End Function
    Public Function Login(ByVal nombre As String, ByVal contraseña As String) As String
        Dim comprobacionNombre = nombre.ToLower
        Dim comprobacionContrasena = contraseña.ToLower
        Dim drComprobarAdmin = dsEstado.ADMINISTRADORES.SingleOrDefault(Function(drAdmin As DataSet1.ADMINISTRADORESRow) drAdmin.USUARIO.ToLower = comprobacionNombre)
        If drComprobarAdmin Is Nothing Then Return "El usuario no existe"
        If drComprobarAdmin.CONTRASEÑA.ToLower() <> comprobacionContrasena Then Return "contraseña incorrecta"
        Return "ok"
    End Function
    Public Function AñadirAdministrador(ByVal admin As Administradores) As String
        Dim drComprovarExistenciaDelAdmin = dsEstado.ADMINISTRADORES.SingleOrDefault(Function(drAdmin As DataSet1.ADMINISTRADORESRow) drAdmin.USUARIO.ToLower = admin.Nombre.ToLower AndAlso drAdmin.APELLIDO.ToLower = admin.Apellido.ToLower)
        If drComprovarExistenciaDelAdmin IsNot Nothing Then Return "El usuario ya existe"

        Dim drRowAñadirAdmin As DataSet1.ADMINISTRADORESRow = dsEstado.ADMINISTRADORES.NewRow
        drRowAñadirAdmin.USUARIO = admin.Nombre
        drRowAñadirAdmin.APELLIDO = admin.Apellido
        drRowAñadirAdmin.CONTRASEÑA = admin.Contraseña
        drRowAñadirAdmin.FOTO = admin.Foto
        dsEstado.ADMINISTRADORES.AddADMINISTRADORESRow(drRowAñadirAdmin)
        Try
            daAdministrador.Update(drRowAñadirAdmin)
        Catch ex As Exception
            Return "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico, *O PUEDE QUE SEA QUE ALGUEN A PUESTO TODOS LOS CAMPOS COMO NVARCHAR(1)"
        Finally
            dsEstado.ADMINISTRADORES.AcceptChanges()
        End Try
        Return "ok"
    End Function
    Public Function AñadirEmpleado(ByVal empleado As Empleado) As String
        Dim drComprovarExistenciaDelEmpleado = dsEstado.EMPLEADOS.SingleOrDefault(Function(drEmpleado As DataSet1.EMPLEADOSRow) drEmpleado.NOMBRE.ToLower = empleado.Nombre.ToLower AndAlso drEmpleado.APELLIDO.ToLower = empleado.Apellido.ToLower)
        If drComprovarExistenciaDelEmpleado IsNot Nothing Then Return "El usuario ya existe"

        Dim drRowAñadirEmpleado As DataSet1.EMPLEADOSRow = dsEstado.EMPLEADOS.NewRow
        drRowAñadirEmpleado.NOMBRE = empleado.Nombre
        drRowAñadirEmpleado.APELLIDO = empleado.Apellido
        drRowAñadirEmpleado.FOTO = empleado.Foto
        dsEstado.EMPLEADOS.AddEMPLEADOSRow(drRowAñadirEmpleado)
        Try
            daUsuarios.Update(drRowAñadirEmpleado)
        Catch ex As Exception
            Return "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico, *O PUEDE QUE SEA QUE ALGUEN A PUESTO TODOS LOS CAMPOS COMO NVARCHAR(1)"
        Finally
            dsEstado.EMPLEADOS.AcceptChanges()
        End Try
        Return "ok"
    End Function
    Public Function BorraAdmin(ByVal id As Integer) As String
        Dim drAdminABorrar = dsEstado.ADMINISTRADORES.SingleOrDefault(Function(drAdmin As DataSet1.ADMINISTRADORESRow) drAdmin.ID = id)
        Try
            drAdminABorrar.Delete()
        Catch ex As Exception
            Return "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico"
        Finally
            dsEstado.ADMINISTRADORES.AcceptChanges()
        End Try
        Return "ok"
    End Function
    Public Function BorraEmpleado(ByVal id As Integer) As String
        Dim drEmpleadoABorrar = dsEstado.EMPLEADOS.SingleOrDefault(Function(drEmpleado As DataSet1.EMPLEADOSRow) drEmpleado.COD_EMPLEADO = id)
        Try
            drEmpleadoABorrar.Delete()
        Catch ex As Exception
            Return "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico"
        Finally
            dsEstado.EMPLEADOS.AcceptChanges()
        End Try
        Return "ok"
    End Function
    Public Function CargarFamiliasExistentes() As List(Of Familia)
        Dim familias = (From drfamilia In dsEstado.FAMILIAS Where drfamilia.NOMBRE <> "" AndAlso drfamilia.NOMBRE_COMPLETO <> "" Select (New Familia(drfamilia.ID, drfamilia.NOMBRE, drfamilia.NOMBRE_COMPLETO))).ToList
        Return familias
    End Function
    Public Function CargarSubfamiasDeUnaFamilia(ByVal idFamilia As Integer) As List(Of SubFamilia)
        Dim SubFamilias = (From drSubFamilia In dsEstado.SUBFAMILIAS Where drSubFamilia.ID_FAMILIA = idFamilia AndAlso drSubFamilia.NOMBRE <> "" AndAlso drSubFamilia.NOMBRE <> "" Select New SubFamilia(drSubFamilia.ID, drSubFamilia.NOMBRE, drSubFamilia.NOMBRE_COMPLETO, drSubFamilia.ID_FAMILIA, drSubFamilia.valor)).ToList
        Return SubFamilias
    End Function
    Public Function QuitarUnaFamilia(ByVal idFamilia As Integer) As String
        Dim drFamiliaABorrar = dsEstado.FAMILIAS.SingleOrDefault(Function(drFmilia As DataSet1.FAMILIASRow) drFmilia.ID = idFamilia)
        Dim SubFamiliasDelaFamiliaQuitada = (From drSubFamilia In dsEstado.SUBFAMILIAS Where drSubFamilia.ID_FAMILIA = idFamilia AndAlso drSubFamilia.NOMBRE <> "" AndAlso drSubFamilia.NOMBRE <> "" Select drSubFamilia).ToList
        Try
            drFamiliaABorrar.BeginEdit()
            drFamiliaABorrar.NOMBRE = ""
            drFamiliaABorrar.NOMBRE_COMPLETO = ""
            drFamiliaABorrar.EndEdit()
            For Each subFamilia In SubFamiliasDelaFamiliaQuitada
                subFamilia.BeginEdit()
                subFamilia.NOMBRE = ""
                subFamilia.NOMBRE_COMPLETO = ""
                subFamilia.EndEdit()
            Next
        Catch ex As Exception
            Return "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico"
        Finally
            dsEstado.FAMILIAS.AcceptChanges()
            dsEstado.SUBFAMILIAS.AcceptChanges()
        End Try
        Return "ok"
    End Function
    Public Function QuitarTodasLasFamilias() As String
        Dim familias = (From drfamilia In dsEstado.FAMILIAS Where drfamilia.NOMBRE <> "" AndAlso drfamilia.NOMBRE_COMPLETO <> "" Select drfamilia).ToList
        Dim SubFamilias = (From drSubFamilia In dsEstado.SUBFAMILIAS Where drSubFamilia.NOMBRE <> "" AndAlso drSubFamilia.NOMBRE <> "" Select drSubFamilia).ToList
        Try

            For Each familia In familias

                familia.NOMBRE = ""
                familia.NOMBRE = ""
                daSubFamilias.Update(familia)
            Next
            For Each subFamilia In SubFamilias
                subFamilia.NOMBRE = ""
                subFamilia.NOMBRE_COMPLETO = ""
                daSubFamilias.Update(subFamilia)
            Next
        Catch ex As Exception
            Return "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico"
        Finally
            dsEstado.FAMILIAS.AcceptChanges()
            dsEstado.SUBFAMILIAS.AcceptChanges()
        End Try
        Return "ok"
    End Function
    Public Function QuitarUnaSubFamilia(ByVal id As Integer) As String
        Dim drSubFamiliaAQuitar = dsEstado.SUBFAMILIAS.SingleOrDefault(Function(subFamilia As DataSet1.SUBFAMILIASRow) subFamilia.ID = id)
        Try

            drSubFamiliaAQuitar.NOMBRE = ""
            drSubFamiliaAQuitar.NOMBRE_COMPLETO = ""
            daSubFamilias.Update(drSubFamiliaAQuitar)

        Catch ex As Exception
            Return "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico"
        Finally
            dsEstado.SUBFAMILIAS.AcceptChanges()
        End Try
        Return "ok"
    End Function
    Public Function AñadirNuevaFamilia(ByVal abrebiaturaNombre As String, ByVal nombre As String) As String
        Dim familiaNueva = dsEstado.FAMILIAS.First(Function(drFamilia As DataSet1.FAMILIASRow) drFamilia.NOMBRE = "" AndAlso drFamilia.NOMBRE_COMPLETO = "")
        Try

            familiaNueva.NOMBRE = abrebiaturaNombre
            familiaNueva.NOMBRE_COMPLETO = nombre

            daFamilias.Update(familiaNueva)

        Catch ex As Exception
            Return "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico"
        Finally
            dsEstado.FAMILIAS.AcceptChanges()
        End Try
        Return "ok"
    End Function
    Public Function AñadirNuevaSubfamilia(ByVal id As Integer, ByVal abrebiatura As String, ByVal nombre As String) As String
        Dim subFamiliaNueva = dsEstado.SUBFAMILIAS.First(Function(drsubFamilia As DataSet1.SUBFAMILIASRow) drsubFamilia.ID_FAMILIA = id AndAlso drsubFamilia.NOMBRE = "" AndAlso drsubFamilia.NOMBRE_COMPLETO = "")
        Try

            subFamiliaNueva.NOMBRE = abrebiatura
            subFamiliaNueva.NOMBRE_COMPLETO = nombre
            daSubFamilias.Update(subFamiliaNueva)
        Catch ex As Exception
            Return "Ha surgido un error innesperado con la base de datos consulte con el servicio tecnico"
        Finally
            dsEstado.SUBFAMILIAS.AcceptChanges()
        End Try
        Return "ok"
    End Function
End Class