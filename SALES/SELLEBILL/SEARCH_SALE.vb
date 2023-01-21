Public Class SEARCH_SALE
    Private Sub SEARCH_SALE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM SALEBILL WHERE STATE='TRUE'   ORDER BY SALECODE")
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(0).Value = "عرض"
            Dim Row As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 0 Then

        ElseIf ComboBox1.SelectedIndex = 0 Then

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM SALEBILL  WHERE STATE='TRUE'  AND SALECODE = '" & TextBox1.Text & "'", sqlconnt)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView

        ElseIf ComboBox1.SelectedIndex = 1 Then

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM SALEBILL  WHERE STATE='TRUE' AND CUSTOMERNAME = '" & TextBox1.Text & "'", sqlconnt)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView



        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
            SELL.SHOW_DETALLES(DataGridView1.CurrentRow.Cells(1).Value)
            Me.Close()

        End If
    End Sub
End Class