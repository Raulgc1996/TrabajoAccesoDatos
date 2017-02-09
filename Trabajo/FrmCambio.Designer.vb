<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCambio
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.BtnCambiarLogo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.lsbFamilias = New System.Windows.Forms.ListBox()
        Me.BtnAñadirNuevaFamilia = New System.Windows.Forms.Button()
        Me.BtnBorrarFamilia = New System.Windows.Forms.Button()
        Me.lsbSubfamilias = New System.Windows.Forms.ListBox()
        Me.btnCambioNombre = New System.Windows.Forms.Button()
        Me.BtnBorrarSubFamilia = New System.Windows.Forms.Button()
        Me.BtnAñadirSubFamilia = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBorrarTodasLasFamilias = New System.Windows.Forms.Button()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nuevo nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(28, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtNombre.TabIndex = 4
        '
        'BtnCambiarLogo
        '
        Me.BtnCambiarLogo.Location = New System.Drawing.Point(658, 384)
        Me.BtnCambiarLogo.Name = "BtnCambiarLogo"
        Me.BtnCambiarLogo.Size = New System.Drawing.Size(127, 38)
        Me.BtnCambiarLogo.TabIndex = 5
        Me.BtnCambiarLogo.Text = "Cambiar logo"
        Me.BtnCambiarLogo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(662, 668)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 38)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(401, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nuevo logo"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ptbLogo.Location = New System.Drawing.Point(479, 11)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(306, 350)
        Me.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbLogo.TabIndex = 8
        Me.ptbLogo.TabStop = False
        '
        'lsbFamilias
        '
        Me.lsbFamilias.FormattingEnabled = True
        Me.lsbFamilias.Location = New System.Drawing.Point(15, 159)
        Me.lsbFamilias.Name = "lsbFamilias"
        Me.lsbFamilias.Size = New System.Drawing.Size(285, 277)
        Me.lsbFamilias.TabIndex = 9
        '
        'BtnAñadirNuevaFamilia
        '
        Me.BtnAñadirNuevaFamilia.Location = New System.Drawing.Point(306, 159)
        Me.BtnAñadirNuevaFamilia.Name = "BtnAñadirNuevaFamilia"
        Me.BtnAñadirNuevaFamilia.Size = New System.Drawing.Size(127, 38)
        Me.BtnAñadirNuevaFamilia.TabIndex = 10
        Me.BtnAñadirNuevaFamilia.Text = "Añadir Familia"
        Me.BtnAñadirNuevaFamilia.UseVisualStyleBackColor = True
        '
        'BtnBorrarFamilia
        '
        Me.BtnBorrarFamilia.Location = New System.Drawing.Point(306, 398)
        Me.BtnBorrarFamilia.Name = "BtnBorrarFamilia"
        Me.BtnBorrarFamilia.Size = New System.Drawing.Size(127, 38)
        Me.BtnBorrarFamilia.TabIndex = 11
        Me.BtnBorrarFamilia.Text = "Borrar Familia"
        Me.BtnBorrarFamilia.UseVisualStyleBackColor = True
        '
        'lsbSubfamilias
        '
        Me.lsbSubfamilias.FormattingEnabled = True
        Me.lsbSubfamilias.Location = New System.Drawing.Point(15, 476)
        Me.lsbSubfamilias.Name = "lsbSubfamilias"
        Me.lsbSubfamilias.Size = New System.Drawing.Size(313, 225)
        Me.lsbSubfamilias.TabIndex = 12
        '
        'btnCambioNombre
        '
        Me.btnCambioNombre.Location = New System.Drawing.Point(173, 62)
        Me.btnCambioNombre.Name = "btnCambioNombre"
        Me.btnCambioNombre.Size = New System.Drawing.Size(127, 38)
        Me.btnCambioNombre.TabIndex = 13
        Me.btnCambioNombre.Text = "Cambiar nombre"
        Me.btnCambioNombre.UseVisualStyleBackColor = True
        '
        'BtnBorrarSubFamilia
        '
        Me.BtnBorrarSubFamilia.Location = New System.Drawing.Point(334, 606)
        Me.BtnBorrarSubFamilia.Name = "BtnBorrarSubFamilia"
        Me.BtnBorrarSubFamilia.Size = New System.Drawing.Size(127, 38)
        Me.BtnBorrarSubFamilia.TabIndex = 15
        Me.BtnBorrarSubFamilia.Text = "Borrar SubFamilia"
        Me.BtnBorrarSubFamilia.UseVisualStyleBackColor = True
        '
        'BtnAñadirSubFamilia
        '
        Me.BtnAñadirSubFamilia.Location = New System.Drawing.Point(336, 523)
        Me.BtnAñadirSubFamilia.Name = "BtnAñadirSubFamilia"
        Me.BtnAñadirSubFamilia.Size = New System.Drawing.Size(127, 38)
        Me.BtnAñadirSubFamilia.TabIndex = 14
        Me.BtnAñadirSubFamilia.Text = "Añadir SubFamilia"
        Me.BtnAñadirSubFamilia.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Familias"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "SubFamilias"
        '
        'BtnBorrarTodasLasFamilias
        '
        Me.BtnBorrarTodasLasFamilias.Location = New System.Drawing.Point(306, 285)
        Me.BtnBorrarTodasLasFamilias.Name = "BtnBorrarTodasLasFamilias"
        Me.BtnBorrarTodasLasFamilias.Size = New System.Drawing.Size(127, 38)
        Me.BtnBorrarTodasLasFamilias.TabIndex = 18
        Me.BtnBorrarTodasLasFamilias.Text = "Borrar Todas Las Familias"
        Me.BtnBorrarTodasLasFamilias.UseVisualStyleBackColor = True
        '
        'FrmCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 718)
        Me.Controls.Add(Me.BtnBorrarTodasLasFamilias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnBorrarSubFamilia)
        Me.Controls.Add(Me.BtnAñadirSubFamilia)
        Me.Controls.Add(Me.btnCambioNombre)
        Me.Controls.Add(Me.lsbSubfamilias)
        Me.Controls.Add(Me.BtnBorrarFamilia)
        Me.Controls.Add(Me.BtnAñadirNuevaFamilia)
        Me.Controls.Add(Me.lsbFamilias)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnCambiarLogo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmCambio"
        Me.Text = "FrmOpciones"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents BtnCambiarLogo As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents lsbFamilias As ListBox
    Friend WithEvents BtnAñadirNuevaFamilia As Button
    Friend WithEvents BtnBorrarFamilia As Button
    Friend WithEvents lsbSubfamilias As ListBox
    Friend WithEvents btnCambioNombre As Button
    Friend WithEvents BtnBorrarSubFamilia As Button
    Friend WithEvents BtnAñadirSubFamilia As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnBorrarTodasLasFamilias As Button
End Class
