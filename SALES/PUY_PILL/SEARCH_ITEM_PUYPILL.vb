﻿Public Class SEARCH_ITEM_PUYPILL
    Private Sub SEARCH_ITEM_PUYPILL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM ITEMS   ORDER BY ITEM_CODE")
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(0).Value = "عرض"
            Dim Row As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
            For I = 0 To SELLEPILL.DataGridView1.Rows.Count - 1
                If SELLEPILL.DataGridView1.Rows(I).Cells(0).Value = DataGridView1.CurrentRow.Cells(1).Value Then
                    SELLEPILL.DataGridView1.Rows(I).Cells(4).Value = SELLEPILL.DataGridView1.Rows(I).Cells(4).Value + 1
                    'MessageBox.Show("تم ادراج الصنف مسبقا ", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    SELLEPILL.CALC()
                    Exit Sub
                End If
            Next
            SELLEPILL.DataGridView1.Rows.Add()
            SELLEPILL.DataGridView1.Rows(SELLEPILL.DataGridView1.Rows.Count - 1).Cells(0).Value = DataGridView1.CurrentRow.Cells(1).Value
            SELLEPILL.DataGridView1.Rows(SELLEPILL.DataGridView1.Rows.Count - 1).Cells(1).Value = DataGridView1.CurrentRow.Cells(2).Value
            SELLEPILL.DataGridView1.Rows(SELLEPILL.DataGridView1.Rows.Count - 1).Cells(2).Value = DataGridView1.CurrentRow.Cells(4).Value
            SELLEPILL.DataGridView1.Rows(SELLEPILL.DataGridView1.Rows.Count - 1).Cells(3).Value = DataGridView1.CurrentRow.Cells(5).Value
            SELLEPILL.DataGridView1.Rows(SELLEPILL.DataGridView1.Rows.Count - 1).Cells(7).Value = DataGridView1.CurrentRow.Cells(6).Value
            SELLEPILL.DataGridView1.Rows(SELLEPILL.DataGridView1.Rows.Count - 1).Cells(4).Value = 1
            SELLEPILL.CALC()
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class