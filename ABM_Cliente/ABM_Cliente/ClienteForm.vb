Public Class ClienteForm


    Dim operacion_ As String
    Dim Cliente As New ClienteClass
    Dim indice_ As Byte


    Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property
    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        If TextBox1.Text.Length = 0 Then
            MsgBox("Debe ingresar Id")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Ingrese Nombre")
        End If

        If TextBox3.Text.Length = 0 Then
            MsgBox("Debe ingresar Direccion")
            Exit Sub
        End If
        If TextBox4.Text.Length = 0 Then
            MsgBox("Debe ingresar saldo")
            Exit Sub
        End If
        If combocategiva.SelectedIndex = -1 Then
            MsgBox("seleccione opcion")
            Exit Sub
        End If
       
       

        Cliente.id = CInt(TextBox1.Text)
        Cliente.Nombre = TextBox2.Text
        Cliente.Direccion = TextBox3.Text
        Cliente.CategIva = Combocategiva.SelectedItem

        Select Case operacion_
            Case "nuevo"
                lst.Add(Cliente)
            Case "modifica"
                lst.Item(indice_) = Cliente
                ClienteGreed.DataGridView1.Refresh()
            Case "elimina"
                lst.RemoveAt(indice_)
        End Select
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Exit Sub
       
        'If TextBox1.SelectionStart = 0 Then MsgBox("Debe ingresar Id")
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsNumber(e.KeyChar) Then e.Handled = True
       
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Exit Sub
    End Sub

End Class
