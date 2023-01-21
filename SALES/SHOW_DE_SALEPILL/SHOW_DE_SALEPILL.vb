Public Class SHOW_DE_SALEPILL
    Private Sub SHOW_DE_SALEPILL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(5).Value = Val(DataGridView1.Rows(I).Cells(3).Value) * Val(DataGridView1.Rows(I).Cells(4).Value)
        Next
        Dim TOTAL_, QTY_ As Double
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            TOTAL_ = TOTAL_ + Val(DataGridView1.Rows(I).Cells(5).Value)
            QTY_ = QTY_ + Val(DataGridView1.Rows(I).Cells(4).Value)

        Next
        TOTAL.Text = TOTAL_
        QTY.Text = QTY_
        If DataGridView1.Rows.Count > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SELL.Show()
        SELL.SHOW_DETALLES(TextBox1.Text)
        Me.Close()
    End Sub
End Class