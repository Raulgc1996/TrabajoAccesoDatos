<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParaAñadirFamiliasYSubFamilias
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAbrebiatura = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 132)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(196, 51)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(572, 132)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(196, 51)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Abrebiado:"
        '
        'txtAbrebiatura
        '
        Me.txtAbrebiatura.Location = New System.Drawing.Point(116, 51)
        Me.txtAbrebiatura.Name = "txtAbrebiatura"
        Me.txtAbrebiatura.Size = New System.Drawing.Size(41, 20)
        Me.txtAbrebiatura.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(116, 81)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(307, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(98, 13)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Nombre Abrebiado:"
        '
        'FrmParaAñadirFamiliasYSubFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 188)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAbrebiatura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmParaAñadirFamiliasYSubFamilias"
        Me.Text = "FrmParaAñadirFamiliasYSubFamilias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAbrebiatura As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitulo As Label
End Class
