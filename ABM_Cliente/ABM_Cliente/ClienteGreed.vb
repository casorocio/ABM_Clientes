Public Class ClienteGreed

    Private Sub ClienteGreed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst
    End Sub

    Private Sub Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina.Click
        ClienteForm.operacion = "elimina"
        ClienteForm.Text = "Eliminar Contribuyente"
        ClienteForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        ClienteForm.Show()
    End Sub

    Private Sub llenarform()
        ClienteForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ClienteForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ClienteForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ClienteForm.combocategiva.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value.ToString
        ClienteForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
    End Sub


    Private Sub Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modifica.Click
        ClienteForm.operacion = "modifica"
        ClienteForm.Text = "Modificar Articulo"
        ClienteForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        ClienteForm.Show()
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        ClienteForm.operacion = "nuevo"
        ClienteForm.Text = "Nuevo contribuyente"
        ClienteForm.Show()
    End Sub
End Class