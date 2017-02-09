<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAñadirAdmin
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
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.ptbFoto = New System.Windows.Forms.PictureBox()
        Me.TxtApellido2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApellido1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(401, 254)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(128, 41)
        Me.btnvolver.TabIndex = 23
        Me.btnvolver.Text = "Cancelar"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Location = New System.Drawing.Point(8, 254)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(128, 41)
        Me.BtnAñadir.TabIndex = 22
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'ptbFoto
        '
        Me.ptbFoto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ptbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ptbFoto.Location = New System.Drawing.Point(414, 59)
        Me.ptbFoto.Name = "ptbFoto"
        Me.ptbFoto.Size = New System.Drawing.Size(115, 132)
        Me.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFoto.TabIndex = 19
        Me.ptbFoto.TabStop = False
        '
        'TxtApellido2
        '
        Me.TxtApellido2.AcceptsReturn = True
        Me.TxtApellido2.Location = New System.Drawing.Point(120, 155)
        Me.TxtApellido2.Name = "TxtApellido2"
        Me.TxtApellido2.Size = New System.Drawing.Size(186, 20)
        Me.TxtApellido2.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Apellido2:"
        '
        'TxtApellido1
        '
        Me.TxtApellido1.Location = New System.Drawing.Point(120, 108)
        Me.TxtApellido1.Name = "TxtApellido1"
        Me.TxtApellido1.Size = New System.Drawing.Size(186, 20)
        Me.TxtApellido1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Apellido1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(153, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Añadir nuevo Administrador"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(120, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(186, 20)
        Me.txtNombre.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre:"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(120, 187)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Size = New System.Drawing.Size(186, 20)
        Me.TxtContraseña.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Cotraseña:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmAñadirAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 322)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.ptbFoto)
        Me.Controls.Add(Me.TxtApellido2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtApellido1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAñadirAdmin"
        Me.Text = "FrmAñadirAdmin"
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnvolver As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents ptbFoto As PictureBox
    Friend WithEvents TxtApellido2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApellido1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
