﻿Public Class SARF_old
    Private Sub SARF_old_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM SARF   ORDER BY SA_CODE")
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM SARF WHERE IMP_NAME LIKE '%" & TextBox1.Text & "%'", sqlconnt)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If RadioButton2.Checked = True Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM SARF WHERE SA_CODE LIKE '%" & TextBox1.Text & "%'", sqlconnt)
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
            SARF.SHOW_DET(DataGridView1.CurrentRow.Cells(1).Value)
            'RuPUT_BILL.IMP_CODE.Text = (DataGridView1.CurrentRow.Cells(1).Value)
            Me.Close()
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class