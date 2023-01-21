Public Class DAMG_ITEM
    Private Sub TXT_BAR1_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_BAR1.KeyDown
        TXT_BAR1_Leave(sender, e)

    End Sub

    Private Sub TXT_BAR1_Leave(sender As Object, e As EventArgs) Handles TXT_BAR1.Leave
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from ITEMS where ITEM_BAR = '" & TXT_BAR1.Text & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            TXT_BAR1.Text = DT.Rows(0).Item("ITEM_BAR")
            TXT_NAME1.Text = DT.Rows(0).Item("ITEM_NAME")
            TXT_CODE1.Text = DT.Rows(0).Item("ITEM_CODE")
            TXT_PUY1.Text = DT.Rows(0).Item("ITEM_TKLFA")
            TXT_QIT1.Text = DT.Rows(0).Item("QTY")
            TXT_SELL1.Text = DT.Rows(0).Item("ITEM_PRICE")
            TXT_BAR2.Select()
        End If
    End Sub

    Private Sub TXT_BAR1_TextChanged(sender As Object, e As EventArgs) Handles TXT_BAR1.TextChanged

    End Sub

    Private Sub TXT_CODE2_TextChnged(sender As Object, e As EventArgs) Handles TXT_CODE2.TextChanged

    End Sub

    Private Sub TXT_BAR2_TextChanged(sender As Object, e As EventArgs) Handles TXT_BAR2.TextChanged

    End Sub

    Private Sub TXT_BAR2_Leave(sender As Object, e As EventArgs) Handles TXT_BAR2.Leave
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from ITEMS where ITEM_BAR = '" & TXT_BAR2.Text & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            TXT_BAR2.Text = DT.Rows(0).Item("ITEM_BAR")
            TXT_NAME2.Text = DT.Rows(0).Item("ITEM_NAME")
            TXT_CODE2.Text = DT.Rows(0).Item("ITEM_CODE")
            TXT_PUY2.Text = DT.Rows(0).Item("ITEM_TKLFA")
            TXT_QIT2.Text = DT.Rows(0).Item("QTY")
            TXT_SELL2.Text = DT.Rows(0).Item("ITEM_PRICE")
        End If
    End Sub

    Private Sub TXT_BAR2_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_BAR2.KeyDown
        TXT_BAR2_Leave(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TXT_BAR1.Text = Nothing Or TXT_BAR2.Text = Nothing Then
            MessageBox.Show("يرجاء التاكد من الباركود", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        If TXT_PUY1.Text <> TXT_PUY2.Text Then
            MessageBox.Show("يرجاء التاكد من توافق السعر", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        If TXT_SELL1.Text <> TXT_SELL2.Text Then
            MessageBox.Show("يرجاء التاكد من توافق السعر البيع", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        UPDATE_()
        DELET_()
        CLEAR()
        MessageBox.Show("تمت عملية دمج بنحاج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub DAMG_ITEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CLEAR()
        TXT_BAR1.Select()
    End Sub
    Sub CLEAR()
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox2.Controls(I).Text = ""
        Next
    End Sub
    Sub UPDATE_()
        Dim SUM_QTY As Double
        Dim BAR_ As String
        SUM_QTY = Val(TXT_QIT1.Text) + Val(TXT_QIT2.Text)
        BAR_ = TXT_BAR1.Text + TXT_BAR2.Text
        Dim DT As New SqlClient.SqlCommand("UPDATE ITEMS SET QTYB=" & SUM_QTY & ", ITEM_BAR='" & BAR_ & "'WHERE ITEM_NAME='" & TXT_NAME1.Text & "'", sqlconnt)
        DT.ExecuteNonQuery()

    End Sub
    Sub DELET_()


        Dim DT As New SqlClient.SqlCommand("DELETE FROM ITEMS WHERE ITEM_CODE='" & TXT_CODE2.Text & "'", sqlconnt)
        DT.ExecuteNonQuery()

    End Sub
End Class