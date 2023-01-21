Public Class SEARCH_CUST
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 0 Then
            FILL_DGV(DataGridView1, "SELECT * FROM CUSTOMERS WHERE STATES ='TRUE' ORDER BY CUS_CODE")
        End If

        If ComboBox1.SelectedIndex = 0 Then

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM PUYBILL  WHERE STATE='TRUE'  AND PUYCODE = '" & TextBox1.Text & "'", sqlconnt)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        ElseIf ComboBox1.SelectedIndex = 1 Then

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM PUYBILL  WHERE STATE='TRUE' AND IMPORTERNAME = '" & TextBox1.Text & "'", sqlconnt)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView



        End If

    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(0).Value = "إدراج"
            Dim Row As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
            SELL.CUSTOMERNAME.Text = DataGridView1.CurrentRow.Cells(2).Value
            SELL.CUS_CODE.Text = DataGridView1.CurrentRow.Cells(1).Value
            Me.Close()
        End If

    End Sub
    Private Sub SEARCH_CUST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM CUSTOMERS WHERE STATES ='TRUE' ORDER BY CUS_CODE")
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class