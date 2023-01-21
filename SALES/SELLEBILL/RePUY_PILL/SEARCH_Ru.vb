Public Class SEARCH_Ru

    Private Sub SEARCH_RE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM RTPUYBILL WHERE STATE ='TRUE' ORDER BY RuPUYCODE")
        ComboBox1.SelectedIndex = 0
        End Sub
        Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
            If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
            RuPUT_BILL.SHOW_DETALLES(DataGridView1.CurrentRow.Cells(1).Value)
            Me.Close()
            End If

        End Sub
        Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
            For I As Integer = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.Rows(I).Cells(0).Value = "عرض"
                Dim Row As DataGridViewRow = DataGridView1.Rows(I)
            Next
        End Sub


        Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
            If TextBox1.Text.Length = 0 Then
            FILL_DGV(DataGridView1, "SELECT * FROM RTPUYBILL WHERE STATE ='TRUE' ORDER BY RuPUYCODE")
        End If

            If ComboBox1.SelectedIndex = 0 Then

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter
                DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM  RTPUYBILL WHERE STATE='TRUE'  AND RuPUYCODE = '" & TextBox1.Text & "'", sqlconnt)
            DA.Fill(DT)
                DataGridView1.DataSource = DT.DefaultView
            ElseIf ComboBox1.SelectedIndex = 1 Then

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter
                DT.Clear()
            DA = New SqlClient.SqlDataAdapter(" SELECT * FROM  RuPUYBILL WHERE STATE='TRUE' AND RuIMPORTERNAME = '" & TextBox1.Text & "'", sqlconnt)
            DA.Fill(DT)
                DataGridView1.DataSource = DT.DefaultView



            End If


        End Sub

    End Class