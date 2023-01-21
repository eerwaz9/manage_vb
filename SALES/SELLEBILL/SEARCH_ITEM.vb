Public Class SEARCH_ITEM
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 0 Then
            FILL_DGV(DataGridView1, "SELECT * FROM ITEMS ORDER BY ITEM_CODE")
        End If

        If RadioButton1.Checked = True Then

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter
                DT.Clear()
                DA = New SqlClient.SqlDataAdapter(" SELECT * FROM ITEMS WHERE ITEM_NAME LIKE '%" & TextBox1.Text & "%'", sqlconnt)
                DA.Fill(DT)
                DataGridView1.DataSource = DT.DefaultView



            End If
        If RadioButton2.Checked = True Then

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM ITEMS WHERE ITEM_BAR LIKE '%" & TextBox1.Text & "%'", sqlconnt)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView



        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
            For I = 0 To SELL.DataGridView1.Rows.Count - 1
                If SELL.DataGridView1.Rows(I).Cells(0).Value = DataGridView1.CurrentRow.Cells(1).Value Then
                    SELL.DataGridView1.Rows(I).Cells(4).Value = SELL.DataGridView1.Rows(I).Cells(4).Value + 1
                    'MessageBox.Show("تم ادراج الصنف مسبقا ", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    SELL.CALC()
                    Exit Sub
                End If
            Next
            SELL.DataGridView1.Rows.Add()
            SELL.DataGridView1.Rows(SELL.DataGridView1.Rows.Count - 1).Cells(0).Value = DataGridView1.CurrentRow.Cells(1).Value
            SELL.DataGridView1.Rows(SELL.DataGridView1.Rows.Count - 1).Cells(1).Value = DataGridView1.CurrentRow.Cells(2).Value
            SELL.DataGridView1.Rows(SELL.DataGridView1.Rows.Count - 1).Cells(2).Value = DataGridView1.CurrentRow.Cells(4).Value
            SELL.DataGridView1.Rows(SELL.DataGridView1.Rows.Count - 1).Cells(3).Value = DataGridView1.CurrentRow.Cells(5).Value
            SELL.DataGridView1.Rows(SELL.DataGridView1.Rows.Count - 1).Cells(7).Value = DataGridView1.CurrentRow.Cells(6).Value
            SELL.DataGridView1.Rows(SELL.DataGridView1.Rows.Count - 1).Cells(8).Value = DataGridView1.CurrentRow.Cells(7).Value
            SELL.DataGridView1.Rows(SELL.DataGridView1.Rows.Count - 1).Cells(4).Value = 1
            SELL.CALC()
        End If
    End Sub

    Private Sub SEARCH_ITEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM ITEMS   ORDER BY ITEM_CODE")
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(0).Value = "عرض"
            Dim Row As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
End Class