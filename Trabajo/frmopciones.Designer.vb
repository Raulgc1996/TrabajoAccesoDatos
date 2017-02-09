<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmopciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnModificarTienda = New System.Windows.Forms.Button()
        Me.btnControlUsuarios = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnModificarTienda
        '
        Me.BtnModificarTienda.Location = New System.Drawing.Point(12, 12)
        Me.BtnModificarTienda.Name = "BtnModificarTienda"
        Me.BtnModificarTienda.Size = New System.Drawing.Size(153, 23)
        Me.BtnModificarTienda.TabIndex = 0
        Me.BtnModificarTienda.Text = "Modificar tienda"
        Me.BtnModificarTienda.UseVisualStyleBackColor = True
        '
        'btnControlUsuarios
        '
        Me.btnControlUsuarios.Location = New System.Drawing.Point(12, 58)
        Me.btnControlUsuarios.Name = "btnControlUsuarios"
        Me.btnControlUsuarios.Size = New System.Drawing.Size(153, 23)
        Me.btnControlUsuarios.TabIndex = 1
        Me.btnControlUsuarios.Text = "Control de Usuarios"
        Me.btnControlUsuarios.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(341, 58)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 2
        Me.BtnVolver.Text = "salir"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'frmopciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 100)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.btnControlUsuarios)
        Me.Controls.Add(Me.BtnModificarTienda)
        Me.Name = "frmopciones"
        Me.Text = "frmopciones"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnModificarTienda As Button
    Friend WithEvents btnControlUsuarios As Button
    Friend WithEvents BtnVolver As Button
End Class
