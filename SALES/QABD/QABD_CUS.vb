Public Class QABD_CUS
    Private Sub QABD_CUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FILL_DGV(DataGridView1, "SELECT * FROM CUSTOMERS WHERE STATES ='TRUE' ORDER BY CUS_CODE")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM CUSTOMERS WHERE STATES ='TRUE' AND CUS_NAME LIKE '%" & TextBox1.Text & "%'", sqlconnt)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView



        End If
        If RadioButton2.Checked = True Then

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM CUSTOMERS WHERE CUS_ADDESS LIKE '%" & TextBox1.Text & "%'", sqlconnt)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView



        End If
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(0).Value = "عرض"
            Dim Row As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
            QABD.CUS_NAME.Text = (DataGridView1.CurrentRow.Cells(2).Value)
            QABD.CUS_CODE.Text = (DataGridView1.CurrentRow.Cells(1).Value)
            Me.Close()
        End If

    End Sub
End Class