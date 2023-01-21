Public Class DEBIT
    Sub SHOWS_DETALLES(ID_)
        Try
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("Select * from DET_IMPORTERS where IMP_CODE = '" & ID_ & "' ", sqlconnt)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("المورد غير موجود يرجاء التاكد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim Show As Integer = BindingContext(DT).Position
                IMP_CODE.Text = DT.Rows(Show).Item("IMP_CODE")
                IMP_NAME.Text = DT.Rows(Show).Item("IMP_NAME")

                'CERDIT_1.Text = DT.Rows(Show).Item("CERDIT")
                'DEBIT_1.Text = DT.Rows(Show).Item("DEBIT")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub FILL_DATA(SQL_)
        Try
            DataGridView1.Rows.Clear()
            Dim STARTING = "SELECT SUM(DEBIT),SUM(CERDIT) FROM DET_IMPORTERS WHERE IMP_CODE ='" & IMP_CODE.Text & "' AND PUYDATE < '" & D1.Value & "' "

            Dim CMD As New SqlClient.SqlCommand("SELECT SUM(DEBIT),SUM(CERDIT) FROM DET_IMPORTERS WHERE IMP_CODE ='" & IMP_CODE.Text & "' AND PUYDATE < '" & D1.Value & "' ", sqlconnt)
            Dim DA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(CMD)
            Dim DT As New DataTable("DET_IMPORTERS")
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
                DataGridView1.Rows(F).Cells(0).Value = DT_.Rows(M).Item("PUYDATE")
                DataGridView1.Rows(F).Cells(1).Value = DT_.Rows(M).Item("DESCRIPTION")
                DataGridView1.Rows(F).Cells(2).Value = DT_.Rows(M).Item("DEBIT")
                DataGridView1.Rows(F).Cells(3).Value = DT_.Rows(M).Item("CERDIT")
                DataGridView1.Rows(F).Cells(4).Value = DT_.Rows(M).Item("PUYCODE")
            Next
            Dim DE, CR, DIFF_ As Double
            For I = 0 To DataGridView1.Rows.Count - 1
                DE = Val(DE) + DataGridView1.Rows(I).Cells(2).Value
                CR = Val(CR) + DataGridView1.Rows(I).Cells(3).Value
            Next
            DIFF_ = DE - CR
            DEBIT_1.Text = DE
            CERDIT_1.Text = CR
            DIFF.Text = DIFF_
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FILL_DATA("SELECT * FROM DET_IMPORTERS WHERE IMP_CODE ='" & IMP_CODE.Text & "' AND PUYDATE >='" & D1.Value & "' AND PUYDATE <= '" & D2.Value & "' ORDER BY PUYDATE")
    End Sub

    Private Sub D1_ValueChanged(sender As Object, e As EventArgs) Handles D1.ValueChanged
        FILL_DATA("SELECT * FROM DET_IMPORTERS WHERE IMP_CODE ='" & IMP_CODE.Text & "' AND PUYDATE >='" & D1.Value & "' AND PUYDATE <= '" & D2.Value & "' ORDER BY PUYDATE")
    End Sub

    Private Sub D2_ValueChanged(sender As Object, e As EventArgs) Handles D2.ValueChanged
        FILL_DATA("SELECT * FROM DET_IMPORTERS WHERE IMP_CODE ='" & IMP_CODE.Text & "' AND PUYDATE >='" & D1.Value & "' AND PUYDATE <= '" & D2.Value & "' ORDER BY PUYDATE")
    End Sub

    Private Sub IMP_CODE_TextChanged(sender As Object, e As EventArgs) Handles IMP_CODE.TextChanged
        FILL_DATA("SELECT * FROM DET_IMPORTERS WHERE IMP_CODE ='" & IMP_CODE.Text & "' AND PUYDATE>='" & D1.Value & "' AND PUYDATE <= '" & D2.Value & "' ORDER BY PUYDATE")

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'SHOW_FROM = "شاشة الزبائن2 "
        Search.ShowDialog()
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(5).Value = "عرض"
            Dim Row As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(5, DataGridView1.CurrentRow.Index).Selected = True Then
            SHOW_DE_PUYBILL.Text = "فاتورة رقم :" & DataGridView1.CurrentRow.Cells(4).Value
            FILL_DGV(SHOW_DE_PUYBILL.DataGridView1, "SELECT * FROM PUY_DET WHERE PUYCODE ='" & DataGridView1.CurrentRow.Cells(4).Value & "'")
            SHOW_DE_PUYBILL.TextBox1.Text = DataGridView1.CurrentRow.Cells(4).Value
            SHOW_DE_PUYBILL.Show()
            'Me.Close()
        End If

    End Sub

    Private Sub DEBIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IMP_NAME_TextChanged(sender As Object, e As EventArgs) Handles IMP_NAME.TextChanged

    End Sub
End Class