<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteForm
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
        Me.combocategiva = New System.Windows.Forms.ComboBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CategIva = New System.Windows.Forms.Label
        Me.Direccion = New System.Windows.Forms.Label
        Me.Nombre = New System.Windows.Forms.Label
        Me.Id = New System.Windows.Forms.Label
        Me.Salir = New System.Windows.Forms.Button
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Saldo = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'combocategiva
        '
        Me.combocategiva.FormattingEnabled = True
        Me.combocategiva.Items.AddRange(New Object() {"contribuyente", "no contribuyente"})
        Me.combocategiva.Location = New System.Drawing.Point(151, 98)
        Me.combocategiva.Name = "combocategiva"
        Me.combocategiva.Size = New System.Drawing.Size(121, 21)
        Me.combocategiva.TabIndex = 19
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(166, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(166, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(166, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 16
        '
        'CategIva
        '
        Me.CategIva.AutoSize = True
        Me.CategIva.Location = New System.Drawing.Point(21, 106)
        Me.CategIva.Name = "CategIva"
        Me.CategIva.Size = New System.Drawing.Size(50, 13)
        Me.CategIva.TabIndex = 15
        Me.CategIva.Text = "CategIva"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Location = New System.Drawing.Point(19, 79)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(52, 13)
        Me.Direccion.TabIndex = 14
        Me.Direccion.Text = "Direccion"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(19, 53)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 13
        Me.Nombre.Text = "Nombre"
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Location = New System.Drawing.Point(19, 27)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(16, 13)
        Me.Id.TabIndex = 12
        Me.Id.Text = "Id"
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(49, 220)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 11
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(191, 220)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 10
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Saldo
        '
        Me.Saldo.AutoSize = True
        Me.Saldo.Location = New System.Drawing.Point(21, 135)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(34, 13)
        Me.Saldo.TabIndex = 20
        Me.Saldo.Text = "Saldo"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(166, 128)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 21
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Saldo)
        Me.Controls.Add(Me.combocategiva)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CategIva)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Aceptar)
        Me.Name = "ClienteForm"
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents combocategiva As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CategIva As System.Windows.Forms.Label
    Friend WithEvents Direccion As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents Id As System.Windows.Forms.Label
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Saldo As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox

End Class
