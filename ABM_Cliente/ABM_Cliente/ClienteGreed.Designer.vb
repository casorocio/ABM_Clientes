<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteGreed
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Nuevo = New System.Windows.Forms.Button
        Me.Modifica = New System.Windows.Forms.Button
        Me.Elimina = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(560, 187)
        Me.DataGridView1.TabIndex = 0
        '
        'Nuevo
        '
        Me.Nuevo.Location = New System.Drawing.Point(425, 220)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Nuevo.TabIndex = 1
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Modifica
        '
        Me.Modifica.Location = New System.Drawing.Point(319, 220)
        Me.Modifica.Name = "Modifica"
        Me.Modifica.Size = New System.Drawing.Size(75, 23)
        Me.Modifica.TabIndex = 2
        Me.Modifica.Text = "Modifica"
        Me.Modifica.UseVisualStyleBackColor = True
        '
        'Elimina
        '
        Me.Elimina.Location = New System.Drawing.Point(207, 220)
        Me.Elimina.Name = "Elimina"
        Me.Elimina.Size = New System.Drawing.Size(75, 23)
        Me.Elimina.TabIndex = 3
        Me.Elimina.Text = "Elimina"
        Me.Elimina.UseVisualStyleBackColor = True
        '
        'ClienteGreed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 262)
        Me.Controls.Add(Me.Elimina)
        Me.Controls.Add(Me.Modifica)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ClienteGreed"
        Me.Text = "ClienteGreed"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Modifica As System.Windows.Forms.Button
    Friend WithEvents Elimina As System.Windows.Forms.Button
End Class
