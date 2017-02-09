<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmControlUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboAdministradores = New System.Windows.Forms.ComboBox()
        Me.ptbFoto = New System.Windows.Forms.PictureBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnAñadirEmpleado = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.cboEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAñadirAdmin = New System.Windows.Forms.Button()
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboAdministradores
        '
        Me.cboAdministradores.FormattingEnabled = True
        Me.cboAdministradores.Location = New System.Drawing.Point(12, 52)
        Me.cboAdministradores.Name = "cboAdministradores"
        Me.cboAdministradores.Size = New System.Drawing.Size(316, 21)
        Me.cboAdministradores.TabIndex = 0
        '
        'ptbFoto
        '
        Me.ptbFoto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ptbFoto.Location = New System.Drawing.Point(363, 12)
        Me.ptbFoto.Name = "ptbFoto"
        Me.ptbFoto.Size = New System.Drawing.Size(117, 131)
        Me.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFoto.TabIndex = 1
        Me.ptbFoto.TabStop = False
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(13, 139)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(316, 50)
        Me.btnborrar.TabIndex = 2
        Me.btnborrar.Text = "Borrar usuario/Admin"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnAñadirEmpleado
        '
        Me.btnAñadirEmpleado.Location = New System.Drawing.Point(13, 195)
        Me.btnAñadirEmpleado.Name = "btnAñadirEmpleado"
        Me.btnAñadirEmpleado.Size = New System.Drawing.Size(118, 52)
        Me.btnAñadirEmpleado.TabIndex = 3
        Me.btnAñadirEmpleado.Text = "Añadir nuevo Empleado"
        Me.btnAñadirEmpleado.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(363, 195)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(118, 52)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Salir"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'cboEmpleados
        '
        Me.cboEmpleados.FormattingEnabled = True
        Me.cboEmpleados.Location = New System.Drawing.Point(12, 112)
        Me.cboEmpleados.Name = "cboEmpleados"
        Me.cboEmpleados.Size = New System.Drawing.Size(316, 21)
        Me.cboEmpleados.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Empleados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Administrdores"
        '
        'btnAñadirAdmin
        '
        Me.btnAñadirAdmin.Location = New System.Drawing.Point(210, 195)
        Me.btnAñadirAdmin.Name = "btnAñadirAdmin"
        Me.btnAñadirAdmin.Size = New System.Drawing.Size(118, 52)
        Me.btnAñadirAdmin.TabIndex = 8
        Me.btnAñadirAdmin.Text = "Añadir nuevo Administrador"
        Me.btnAñadirAdmin.UseVisualStyleBackColor = True
        '
        'FrmControlUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 256)
        Me.Controls.Add(Me.btnAñadirAdmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboEmpleados)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAñadirEmpleado)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.ptbFoto)
        Me.Controls.Add(Me.cboAdministradores)
        Me.Name = "FrmControlUsuarios"
        Me.Text = "FrmControlUsuarios"
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboAdministradores As ComboBox
    Friend WithEvents ptbFoto As PictureBox
    Friend WithEvents btnborrar As Button
    Friend WithEvents btnAñadirEmpleado As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents cboEmpleados As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAñadirAdmin As Button
End Class
