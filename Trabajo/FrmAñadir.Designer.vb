<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAñadir
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtApellido1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtApellido2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ptbFoto = New System.Windows.Forms.PictureBox()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(65, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(186, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(160, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Añadir nuevo empleado"
        '
        'TxtApellido1
        '
        Me.TxtApellido1.Location = New System.Drawing.Point(65, 108)
        Me.TxtApellido1.Name = "TxtApellido1"
        Me.TxtApellido1.Size = New System.Drawing.Size(186, 20)
        Me.TxtApellido1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido1:"
        '
        'TxtApellido2
        '
        Me.TxtApellido2.Location = New System.Drawing.Point(65, 155)
        Me.TxtApellido2.Name = "TxtApellido2"
        Me.TxtApellido2.Size = New System.Drawing.Size(186, 20)
        Me.TxtApellido2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Apellido2:"
        '
        'ptbFoto
        '
        Me.ptbFoto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ptbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbFoto.Location = New System.Drawing.Point(421, 45)
        Me.ptbFoto.Name = "ptbFoto"
        Me.ptbFoto.Size = New System.Drawing.Size(115, 146)
        Me.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFoto.TabIndex = 7
        Me.ptbFoto.TabStop = False
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(15, 238)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(128, 41)
        Me.btnAñadir.TabIndex = 10
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(408, 238)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(128, 41)
        Me.btnVolver.TabIndex = 11
        Me.btnVolver.Text = "Cancelar"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FrmAñadir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 299)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.ptbFoto)
        Me.Controls.Add(Me.TxtApellido2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtApellido1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAñadir"
        Me.Text = "FrmAñadir"
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtApellido1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtApellido2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ptbFoto As PictureBox
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnVolver As Button
End Class
