Public Class acount
    Private Sub acount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub SHOWS_DETALLES(ID_)
        Try
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("Select * from DET_CUSTOMERS where CUS_CODE = '" & ID_ & "' ", sqlconnt)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("المورد غير موجود يرجاء التاكد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim Show As Integer = BindingContext(DT).Position
                CUS_CODE.Text = DT.Rows(Show).Item("CUS_CODE")
                CUS_NAME.Text = DT.Rows(Show).Item("CUS_NAME")

                'CERDIT_1.Text = DT.Rows(Show).Item("CERDIT")
                'DEBIT_1.Text = DT.Rows(Show).Item("DEBIT")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub FILL_DATA(SQL_)
        Try
            DataGridView1.Rows.Clear()
            Dim STARTING = "SELECT SUM(DEBIT),SUM(CERDIT) FROM DET_CUSTOMERS WHERE CUS_CODE ='" & CUS_CODE.Text & "' AND SALEDATE < '" & D1.Value & "' "

            Dim CMD As New SqlClient.SqlCommand("SELECT SUM(DEBIT),SUM(CERDIT) FROM DET_CUSTOMERS WHERE CUS_CODE ='" & CUS_CODE.Text & "' AND SALEDATE < '" & D1.Value & "' ", sqlconnt)
            Dim DA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(CMD)
            Dim DT As New DataTable("DET_CUSTOMERS")
            DA.Fill(DT)
            Dim DEBIT, CERDIT As Double
            If IsDBNull(DT.Rows(0).Item(0)) = False Then DEBIT = DT.Rows(0).Item(0)
            If IsDBNull(DT.Rows(0).Item(1)) = False Then CERDIT = DT.Rows(0).Item(1)
            '============= استخراج الرصيد السابق
            Dim I = DataGridView1.Rows.Add
            DataGridView1.Rows(I).Cells(1).Value = "رصيد قبل فترة"
            DataGridView1.Rows(I).Cells(2).Value = Val(DEBIT)
            DataGridView1.Rows(I).Cells(3).Value = Val(CERDIT)
            '=======================
            Dim DA_ = New SqlClient.SqlDataAdapter(SQL_, sqlconnt)
            Dim DS = New DataSet
            DA_.Fill(DS)
            Dim DT_ = DS.Tables(0)
            Dim H = DT_.Rows.Count
            For M = 0 To DT_.Rows.Count - 1
                Dim F = DataGridView1.Rows.Add
                DataGridView1.Rows(F).Cells(0).Value = DT_.Rows(M).Item("SALEDATE")
                DataGridView1.Rows(F).Cells(1).Value = DT_.Rows(M).Item("DESCRIPTION")
                DataGridView1.Rows(F).Cells(2).Value = DT_.Rows(M).Item("DEBIT")
                DataGridView1.Rows(F).Cells(3).Value = DT_.Rows(M).Item("CERDIT")
                DataGridView1.Rows(F).Cells(4).Value = DT_.Rows(M).Item("SALECODE")
            Next
            Dim DE, CR, DIFF_ As Double
            For I = 0 To DataGridView1.Rows.Count - 1
                DE = Val(DE) + DataGridView1.Rows(I).Cells(2).Value
                CR = Val(CR) + DataGridView1.Rows(I).Cells(3).Value
            Next
            DIFF_ = CR - DE
            DEBIT_1.Text = DE
            CERDIT_1.Text = CR
            DIFF.Text = DIFF_
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FILL_DATA("SELECT * FROM DET_CUSTOMERS WHERE CUS_CODE ='" & CUS_CODE.Text & "' AND SALEDATE >='" & D1.Value & "' AND SALEDATE <= '" & D2.Value & "' ORDER BY SALEDATE")
    End Sub

    Private Sub D1_ValueChanged(sender As Object, e As EventArgs) Handles D1.ValueChanged
        FILL_DATA("SELECT * FROM DET_CUSTOMERS WHERE CUS_CODE ='" & CUS_CODE.Text & "' AND SALEDATE >='" & D1.Value & "' AND SALEDATE <= '" & D2.Value & "' ORDER BY SALEDATE")
    End Sub

    Private Sub D2_ValueChanged(sender As Object, e As EventArgs) Handles D2.ValueChanged
        FILL_DATA("SELECT * FROM DET_CUSTOMERS WHERE CUS_CODE ='" & CUS_CODE.Text & "' AND SALEDATE >='" & D1.Value & "' AND SALEDATE <= '" & D2.Value & "' ORDER BY SALEDATE")
    End Sub

    Private Sub IMP_CODE_TextChanged(sender As Object, e As EventArgs) Handles CUS_CODE.TextChanged
        FILL_DATA("SELECT * FROM DET_CUSTOMERS WHERE CUS_CODE ='" & CUS_CODE.Text & "' AND SALEDATE>='" & D1.Value & "' AND SALEDATE <= '" & D2.Value & "' ORDER BY SALEDATE")

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        search_c.ShowDialog()
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(5).Value = "عرض"
            Dim Row As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(5, DataGridView1.CurrentRow.Index).Selected = True Then
            If DataGridView1.CurrentRow.Cells(4).Value = "فاتورة مبيعات" Then
                SHOW_DE_SALEPILL.Text = "فاتورة رقم :" & DataGridView1.CurrentRow.Cells(4).Value
                FILL_DGV(SHOW_DE_SALEPILL.DataGridView1, "SELECT * FROM SALE_DET WHERE SALECODE ='" & DataGridView1.CurrentRow.Cells(4).Value & "'")
                SHOW_DE_SALEPILL.TextBox1.Text = DataGridView1.CurrentRow.Cells(4).Value
                SHOW_DE_SALEPILL.Show()

            End If

            If DataGridView1.CurrentRow.Cells(4).Value = "استرجاع مبيعات" Then
                SHOW_DE_SALEPILL.Text = "فاتورة رقم :" & DataGridView1.CurrentRow.Cells(4).Value
                FILL_DGV(SHOW_DE_SALEPILL.DataGridView1, "SELECT * FROM ReSALE_DET WHERE ReSALECODE ='" & DataGridView1.CurrentRow.Cells(4).Value & "'")
                SHOW_DE_SALEPILL.TextBox1.Text = DataGridView1.CurrentRow.Cells(4).Value
                SHOW_DE_SALEPILL.Show()
            End If
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class