Public Class SELL
    'Sub FILL_IMPORTERNAME()
    '    CUSTOMERNAME.Items.Clear()
    '    Dim DT As New DataTable
    '    Dim DA As New SqlClient.SqlDataAdapter("Select * from CUSTOMERS ", sqlconnt)
    '    DA.Fill(DT)
    '    For I = 0 To DT.Rows.Count - 1
    '        CUSTOMERNAME.Items.Add(DT.Rows(I).Item("IMP_NAME"))
    '        'MessageBox.Show("الوحده غير موجودة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    Next

    'End Sub

    Private Sub BUTTONCLICK(ByVal SENDER As System.Object, ByVal E As System.EventArgs)
        SENDER.GetType()
        TXT_BAR.Text = SENDER.NAME
        TXT_BAR_Leave(Me, E)
    End Sub
    Sub SHOW_ITEM()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from ITEMS where ITEM_CHEACK ='TRUE'", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            Dim VALUE As Integer
            For VALUE = 0 To DT.Rows.Count - 1
                Dim BTN As New System.Windows.Forms.Button
                BTN.Name = DT.Rows(VALUE).Item("ITEM_BAR")
                BTN.Text = DT.Rows(VALUE).Item("ITEM_NAME")
                BTN.Font = Label2.Font
                BTN.Width = 135
                BTN.Height = 50
                AddHandler BTN.Click, AddressOf BUTTONCLICK
                FLB.Controls.Add(BTN)
            Next
        End If
    End Sub
    Sub SHOW_DETALLES(CODE)
        DataGridView1.Rows.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from SALEBILL where SALECODE = '" & CODE & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجاء التاكد من رقم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ADD = DT.Rows(0)
            SALECODE.Text = ADD!SALECODE
            SALETYPE.Text = ADD!SALETYPE
            CUSTOMERNAME.Text = ADD!CUSTOMERNAME
            BUY_NOTES.Text = ADD!NOTES
            SALEUSER.Text = ADD!SALEUSER
            SALEDATE.Value = ADD!SALEDATE
            TOTALQTY.Text = ADD!TOTALQNT
            TOTALARB.Text = ADD!TOTALARB
            TOTAL.Text = ADD!TOTAL
            DISCOUND.Text = ADD!DISCOUND
            Dim DS As New DataSet
            ButtEdite.Enabled = True
            ButtDelete.Enabled = True
            ButtSave.Enabled = False

            DA = New SqlClient.SqlDataAdapter("Select * from SALE_DET where SALECODE = '" & CODE & "' ", sqlconnt)
            DS = New DataSet
            DA.Fill(DS)
            DT = DS.Tables(0)

            For I = 0 To DT.Rows.Count - 1


                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(I).Cells(0).Value = DT.Rows(I).Item("ITEMCODE")
                    DataGridView1.Rows(I).Cells(1).Value = DT.Rows(I).Item("ITEMNAME")
                    DataGridView1.Rows(I).Cells(2).Value = DT.Rows(I).Item("UNIT")
                    DataGridView1.Rows(I).Cells(3).Value = DT.Rows(I).Item("PRICE")
                    DataGridView1.Rows(I).Cells(4).Value = DT.Rows(I).Item("QTY")
                    DataGridView1.Rows(I).Cells(5).Value = DT.Rows(I).Item("DISCOUND")
                    DataGridView1.Rows(I).Cells(6).Value = DT.Rows(I).Item("TOTAL")
                    DataGridView1.Rows(I).Cells(7).Value = DT.Rows(I).Item("QTY_IN")


                Next
            ButtDelete.Enabled = True
            ButtEdite.Enabled = True
            ButtSave.Enabled = False
        End If

    End Sub
    Sub CALC()
        'العمليات الحسابية
        For I = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(6).Value = Val(DataGridView1.Rows(I).Cells(3).Value) * Val(DataGridView1.Rows(I).Cells(4).Value)
        Next
        Dim TOTAL_, DISCOUND_, QTY_ As Double
        For I = 0 To DataGridView1.Rows.Count - 1
            TOTAL_ = Val(TOTAL_) + Val(DataGridView1.Rows(I).Cells(6).Value)
            DISCOUND_ = Val(DISCOUND_) + Val(DataGridView1.Rows(I).Cells(5).Value)
            QTY_ = Val(QTY_) + Val(DataGridView1.Rows(I).Cells(4).Value)

        Next
        TOTAL.Text = Val(TOTAL_) - Val(DISCOUND_)
        DISCOUND.Text = DISCOUND_
        TOTALQTY.Text = QTY_
        If Val(TOTAL.Text) > 0 Then
            'TOTALARB.Text = AR.CONVERTTOARABIC(TOTAL.Text)
        Else
            TOTALARB.Text = ""

        End If

    End Sub
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FLB.Paint

    End Sub
    Private Sub TXT_BAR_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_BAR.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_BAR_Leave(sender, e)
        End If
    End Sub
    Private Sub TXT_BAR_Leave(sender As Object, e As EventArgs) Handles TXT_BAR.Leave
        '================ طريقة الادخال عن طريق الباركود
        Dim BAR As Integer
        If TXT_BAR.Text <> Nothing Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("Select * FROM ITEMS WHERE ITEM_BAR Like '" & TXT_BAR.Text & "'  ", sqlconnt)
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                For I = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(I).Cells(0).Value = DT.Rows(0).Item("ITEM_CODE") Then
                        DataGridView1.Rows(I).Cells(4).Value = DataGridView1.Rows(I).Cells(4).Value + 1
                        CALC()
                        TXT_BAR.Clear()
                        Exit Sub
                    End If
                Next
                DataGridView1.Rows.Add()
                BAR = DataGridView1.Rows.Count - 1
                DataGridView1(0, BAR).Value = DT.Rows(0).Item("ITEM_CODE")
                DataGridView1(1, BAR).Value = DT.Rows(0).Item("ITEM_NAME")
                DataGridView1(2, BAR).Value = DT.Rows(0).Item("ITEM_UNIT")
                DataGridView1(3, BAR).Value = DT.Rows(0).Item("ITEM_TKLFA")
                DataGridView1(7, BAR).Value = DT.Rows(0).Item("QTY")
                DataGridView1(8, BAR).Value = DT.Rows(0).Item("ITEM_EXPIRE")
                DataGridView1(4, BAR).Value = 1
                CALC()
            End If


        End If
        CALC()
        TXT_BAR.Clear()


    End Sub

    Private Sub ButtNew_Click(sender As Object, e As EventArgs) Handles ButtNew.Click
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
            If TypeOf GroupBox1.Controls(I) Is DateTimePicker Then GroupBox1.Controls(I).Text = Date.Now
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox2.Controls(I).Text = ""

        Next
        SALECODE.Text = CODE_GENT6("ID") + 1
        DataGridView1.Rows.Clear()
        SALETYPE.SelectedIndex = 0
        'TOTAL.Text = "1000"
        ButtEdite.Enabled = False
        ButtDelete.Enabled = False
        ButtSave.Enabled = True
        CUSTOMERNAME.Text = "نقدا"
        TXT_BAR.Select()
        '  FILL_IMPORTERNAME()
    End Sub

    Private Sub SELL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SHOW_ITEM()
        ButtNew_Click(sender, e)
    End Sub

    Private Sub ButtSave_Click(sender As Object, e As EventArgs) Handles ButtSave.Click
        If CUSTOMERNAME.Text = "" Then
            MessageBox.Show("يرجاء ادخال اسم المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SEARCH_CUST.ShowDialog()
            CUSTOMERNAME.Select()
            Exit Sub
        End If
        If SALETYPE.SelectedIndex < 0 Then
            MessageBox.Show("يرجاء اختيار نوع الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SALETYPE.Select()
            Exit Sub
        End If
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("لا يوجد اصناف لعرضها", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SALETYPE.Select()
            Exit Sub
        End If
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(I).Cells(4).Value = 0 Then
                MessageBox.Show("يرجاء التحقق من الكمية", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Next
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from SALEBILL where SALECODE = '" & SALECODE.Text & "'  ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            SALECODE.Text = CODE_GENT5("ID") + 1
        Else
            Dim ADD = DT.NewRow
            ADD!SALECODE = SALECODE.Text
            ADD!SALETYPE = SALETYPE.Text
            ADD!SALEDATE = SALEDATE.Value
            ADD!CUSTOMERNAME = CUSTOMERNAME.Text
            ADD!NOTES = BUY_NOTES.Text
            ADD!DISCOUND = Convert.ToDecimal(DISCOUND.Text)
            ADD!TOTAL = Convert.ToDecimal(TOTAL.Text)
            ADD!TOTALARB = TOTALARB.Text
            ADD!TOTALQNT = Val(TOTALQTY.Text)
            ADD!SALEUSER = SALEUSER.Text
            ADD!STATE = True
            DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
        End If
        '==============حركة الزبون

        Dim DTA As New SqlClient.SqlDataAdapter("Select * from DET_CUSTOMERS ", sqlconnt)
        Dim DASET As New DataSet
        DASET = New DataSet
        DTA.Fill(DASET)
        Dim DT_ = DASET.Tables(0)
        Dim DR_ = DT_.NewRow
        DR_!SALECODE = SALECODE.Text
        DR_!SALEDATE = SALEDATE.Value
        DR_!DESCRIPTION = "فاتور  المبيعات رقم " & SALECODE.Text
        DR_!DEBIT = "0"
        DR_!CERDIT = Val(TOTAL.Text)
        DR_!CUS_NAME = CUSTOMERNAME.Text
        DR_!CUS_CODE = CUS_CODE.Text
        DT_.Rows.Add(DR_)
        Dim SAVE_ As New SqlClient.SqlCommandBuilder(DTA)
        DTA.Update(DT_)
        '============================
        DA = New SqlClient.SqlDataAdapter("Select * from SALE_DET  ", sqlconnt)
        DA.Fill(DT)
        For I = 0 To DataGridView1.Rows.Count - 1
            Dim DR = DT.NewRow
            DR!SALECODE = SALECODE.Text
            DR!ITEMCODE = DataGridView1.Rows(I).Cells(0).Value
            DR!ITEMNAME = DataGridView1.Rows(I).Cells(1).Value
            DR!UNIT = DataGridView1.Rows(I).Cells(2).Value
            DR!QTY = DataGridView1.Rows(I).Cells(4).Value
            DR!PRICE = Val(DataGridView1.Rows(I).Cells(3).Value)
            DR!TOTAL = DataGridView1.Rows(I).Cells(6).Value
            DR!DISCOUND = Val(DataGridView1.Rows(I).Cells(5).Value)
            DR!QTY_IN = DataGridView1.Rows(I).Cells(7).Value
            DT.Rows.Add(DR)
            Dim CMD As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
        Next
        For M As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim NEW_QTY As Integer
            NEW_QTY = Val(DataGridView1.Rows(M).Cells(7).Value) - Val(DataGridView1.Rows(M).Cells(4).Value)
            Dim CMD1 As New SqlClient.SqlCommand
            CMD1.Connection = sqlconnt
            CMD1.CommandText = "UPDATE ITEMS SET QTY = " & NEW_QTY & " WHERE ITEM_NAME = '" & DataGridView1.Rows(M).Cells(1).Value & "' "
            CMD1.ExecuteNonQuery()




        Next

        MessageBox.Show("تم حفظ فاتورة المبيعات بنجاح ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        ButtNew_Click(sender, e)


    End Sub

    Private Sub ButtEdite_Click(sender As Object, e As EventArgs) Handles ButtEdite.Click
        If CUSTOMERNAME.Text = "" Then
            MessageBox.Show("يرجاء ادخال اسم المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SEARCH_CUST.ShowDialog()
            CUSTOMERNAME.Select()
            Exit Sub
        End If
        If SALETYPE.SelectedIndex < 0 Then
            MessageBox.Show("يرجاء اختيار نوع الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SALETYPE.Select()
            Exit Sub
        End If
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("لا يوجد اصناف لعرضها", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SALETYPE.Select()
            Exit Sub
        End If
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(I).Cells(4).Value = 0 Then
                MessageBox.Show("يرجاء التحقق من الكمية", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Next

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from SALEBILL where SALECODE = '" & SALECODE.Text & "'  ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجاء التحقق من رقم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ADD = DT.Rows(0)
            ADD!SALECODE = SALECODE.Text
            ADD!SALETYPE = SALETYPE.Text
            ADD!SALEDATE = SALEDATE.Value
            ADD!CUSTOMERNAME = CUSTOMERNAME.Text
            ADD!NOTES = BUY_NOTES.Text
            ADD!DISCOUND = Convert.ToDecimal(DISCOUND.Text)
            ADD!TOTAL = Convert.ToDecimal(TOTAL.Text)
            ADD!TOTALARB = TOTALARB.Text
            ADD!TOTALQNT = Val(TOTALQTY.Text)
            ADD!SALEUSER = SALEUSER.Text
            ADD!STATE = True

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
        End If
        '==========حذف تفاصيل الفاتورة اولا ثم اضافة التعديل 
        Dim CMD_DEL As New SqlClient.SqlCommand
        CMD_DEL.Connection = sqlconnt
        CMD_DEL.CommandText = "DELETE FROM  SALE_DET WHERE SALECODE ='" & SALECODE.Text & "' "
        CMD_DEL.ExecuteNonQuery()
        '=================================
        Dim CMD_DELL As New SqlClient.SqlCommand
        CMD_DELL.Connection = sqlconnt
        CMD_DELL.CommandText = "DELETE FROM  DET_CUSTOMERS WHERE SALECODE ='" & SALECODE.Text & "' "
        CMD_DELL.ExecuteNonQuery()
        '==============حركة الزبون
        Dim DTA As New SqlClient.SqlDataAdapter("Select * from DET_CUSTOMERS ", sqlconnt)
        Dim DASET As New DataSet
        DASET = New DataSet
        DTA.Fill(DASET)
        Dim DT_ = DASET.Tables(0)
        Dim DR_ = DT_.NewRow
        DR_!SALECODE = SALECODE.Text
        DR_!SALEDATE = SALEDATE.Value
        DR_!DESCRIPTION = "فاتور استرجاع المشتريات رقم " & SALECODE.Text
        DR_!DEBIT = "0"
        DR_!CERDIT = Val(TOTAL.Text)
        DR_!CUS_NAME = CUSTOMERNAME.Text
        DR_!CUS_CODE = CUS_CODE.Text
        DT_.Rows.Add(DR_)
        Dim SAVE_ As New SqlClient.SqlCommandBuilder(DTA)
        DTA.Update(DT_)
        DA = New SqlClient.SqlDataAdapter("Select * from SALE_DET  ", sqlconnt)
        DA.Fill(DT)

        For I = 0 To DataGridView1.Rows.Count - 1

            Dim DR = DT.NewRow
            DR!SALECODE = SALECODE.Text
            DR!ITEMCODE = DataGridView1.Rows(I).Cells(0).Value
            DR!ITEMNAME = DataGridView1.Rows(I).Cells(1).Value
            DR!UNIT = DataGridView1.Rows(I).Cells(2).Value
            DR!QTY = DataGridView1.Rows(I).Cells(4).Value
            DR!PRICE = Val(DataGridView1.Rows(I).Cells(3).Value)
            DR!TOTAL = DataGridView1.Rows(I).Cells(6).Value
            DR!DISCOUND = Val(DataGridView1.Rows(I).Cells(5).Value)
            DR!QTY_IN = DataGridView1.Rows(I).Cells(7).Value
            DT.Rows.Add(DR)
            Dim CMD As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
        Next

        For M As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim NEW_QTY As Integer
            NEW_QTY = Val(DataGridView1.Rows(M).Cells(7).Value) - Val(DataGridView1.Rows(M).Cells(4).Value)
            Dim CMD1 As New SqlClient.SqlCommand
            CMD1.Connection = sqlconnt
            CMD1.CommandText = "UPDATE ITEMS SET QTY = " & NEW_QTY & " WHERE ITEM_NAME = '" & DataGridView1.Rows(M).Cells(1).Value & "' "
            CMD1.ExecuteNonQuery()




        Next

        MessageBox.Show("تم عملية التعديل فاتورة المبيعات بنجاح ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        ButtNew_Click(sender, e)

    End Sub

    Private Sub ButtDelete_Click(sender As Object, e As EventArgs) Handles ButtDelete.Click

        Dim DEL = MessageBox.Show("هل ترغم في حذف فاتورة نهايا ام نقلها للارشيف ؟", "رسالة تنبيهية", MessageBoxButtons.YesNo)
        '=============حذف نهائي
        If DEL = Windows.Forms.DialogResult.YES Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("Select * from SALEBILL where SALECODE = '" & SALECODE.Text & "'  ", sqlconnt)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("يرجاء التحقق من رقم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim ADD = DT.Rows(0)
                ADD.Delete()
                Dim CMD As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                For M As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim NEW_QTY As Integer
                    NEW_QTY = Val(DataGridView1.Rows(M).Cells(7).Value) + Val(DataGridView1.Rows(M).Cells(4).Value)
                    Dim CMD1 As New SqlClient.SqlCommand
                    CMD1.Connection = sqlconnt
                    CMD1.CommandText = "UPDATE ITEMS SET QTY = " & NEW_QTY & " WHERE ITEM_NAME = '" & DataGridView1.Rows(M).Cells(1).Value & "' "
                    CMD1.ExecuteNonQuery()
                Next
                Dim CMD_DELL As New SqlClient.SqlCommand
                CMD_DELL.Connection = sqlconnt
                CMD_DELL.CommandText = "DELETE FROM  DET_CUSTOMERS WHERE SALECODE ='" & SALECODE.Text & "' "
                CMD_DELL.ExecuteNonQuery()
                MessageBox.Show("تمت عملية حذف فاتورة المبيعات نهائيا", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ButtNew_Click(sender, e)
            End If


        End If
        '=========نقل للأرشيف
        If DEL = Windows.Forms.DialogResult.YES Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("Select * from SALEBILL where SALECODE = '" & SALECODE.Text & "'  ", sqlconnt)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("يرجاء التحقق من رقم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim ADD = DT.Rows(0)
                ADD!STATE = False
                Dim CMD As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                For M As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim NEW_QTY As Integer
                    NEW_QTY = Val(DataGridView1.Rows(M).Cells(7).Value) + Val(DataGridView1.Rows(M).Cells(4).Value)
                    Dim CMD1 As New SqlClient.SqlCommand
                    CMD1.Connection = sqlconnt
                    CMD1.CommandText = "UPDATE ITEMS SET QTY = " & NEW_QTY & " WHERE ITEM_NAME = '" & DataGridView1.Rows(M).Cells(1).Value & "' "
                    CMD1.ExecuteNonQuery()
                Next
                MessageBox.Show("تمت عملية نقل فاتورة المبيعات للارشيف", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ButtNew_Click(sender, e)
            End If


        End If
    End Sub

    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Dispose()
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SEARCH_ITEM.ShowDialog()
    End Sub

    Private Sub BUTTSEARCH_Click(sender As Object, e As EventArgs) Handles BUTTSEARCH.Click
        SEARCH_SALE.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = -1 Or DataGridView1.Rows.Count = 0 Then Exit Sub
        Dim COLUM = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If COLUM = "COLDEL" Then
            If DataGridView1.Rows.Count = 0 Then Exit Sub
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            CALC()
        End If
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(9).Value = "حذف"
            Dim Row As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub SALETYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SALETYPE.SelectedIndexChanged
        If SALETYPE.SelectedIndex = 0 Then
            CUSTOMERNAME.Text = "نقدا"
            CUSTOMERNAME.Enabled = False
            Button2.Enabled = False
        Else
            CUSTOMERNAME.Text = ""
            CUSTOMERNAME.Enabled = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SEARCH_CUST.ShowDialog()
    End Sub

    Private Sub CUSTOMERNAME_TextChanged(sender As Object, e As EventArgs) Handles CUSTOMERNAME.TextChanged

    End Sub

    Private Sub بياناتالصنفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles بياناتالصنفToolStripMenuItem.Click
        ITEMS.Show()
        ITEMS.SHOW_DETALLES(DataGridView1.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub إدراجصنفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إدراجصنفToolStripMenuItem.Click
        SEARCH_ITEM.ShowDialog()
    End Sub

    Private Sub CUS_CODE_TextChanged(sender As Object, e As EventArgs) Handles CUS_CODE.TextChanged

    End Sub
End Class