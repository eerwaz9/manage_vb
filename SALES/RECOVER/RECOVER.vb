﻿Public Class RECOVER
    Sub SHOW_DETALLES(CODE)
        DataGridView1.Rows.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from ReSALEBILL where ReSALECODE = '" & CODE & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجاء التاكد من رقم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ADD = DT.Rows(0)
            ReSALECODE.Text = ADD!ReSALECODE
            ReSALETYPE.Text = ADD!ReSALETYPE
            ReCUSTOMERNAME.Text = ADD!ReCUSTOMERNAME
            BUY_NOTES.Text = ADD!ReNOTES
            ReSALEUSER.Text = ADD!ReSALEUSER
            ReSALEDATE.Value = ADD!ReSALEDATE
            TOTALQTY.Text = ADD!ReTOTALQNT
            TOTALARB.Text = ADD!ReTOTALARB
            TOTAL.Text = ADD!ReTOTAL
            DISCOUND.Text = ADD!ReDISCOUND
            Dim DS As New DataSet
            ButtEdite.Enabled = True
            ButtDelete.Enabled = True
            ButtSave.Enabled = False

            DA = New SqlClient.SqlDataAdapter("Select * from ReSALE_DET where ReSALECODE = '" & CODE & "' ", sqlconnt)
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
    'تم نسخها
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
    'تم نسخها

    'تم نسخها
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
    'تم نسخها
    Private Sub DataGridView2_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView2.RowsAdded
        For I As Integer = 0 To DataGridView2.Rows.Count - 1
            DataGridView2.Rows(I).Cells(0).Value = "موافق"
            Dim Row As DataGridViewRow = DataGridView2.Rows(I)
        Next
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(9).Value = "حذف"
            Dim Row As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    'تم نسخها
    Private Sub TXT_BAR_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_BAR.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_BAR_Leave(sender, e)
        End If
    End Sub
    Private Sub ButtNew_Click(sender As Object, e As EventArgs) Handles ButtNew.Click
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
            If TypeOf GroupBox1.Controls(I) Is DateTimePicker Then GroupBox1.Controls(I).Text = Date.Now
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox2.Controls(I).Text = ""

        Next
        ReSALECODE.Text = CODE_GENT7("ID") + 1
        DataGridView1.Rows.Clear()
        ReSALETYPE.SelectedIndex = 0
        'FILL_CUSTOMER()
        ButtEdite.Enabled = False
        ButtDelete.Enabled = False
        ButtSave.Enabled = True
        ReCUSTOMERNAME.Text = ""
        TXT_BAR.Select()
        DataGridView2.Visible = False
        FILL_DGV(DataGridView2, "SELECT * FROM ITEMS ORDER BY ITEM_CODE")
    End Sub
    'تم نسخها
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TXT_SEARCH.Text.Length > 0 Then
            DataGridView2.Visible = True
        Else
            DataGridView2.Visible = False
        End If
    End Sub
    'تم نسخها
    Private Sub TXT_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXT_SEARCH.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter
        DT.Clear()
        DA = New SqlClient.SqlDataAdapter(" SELECT * FROM ITEMS WHERE ITEM_NAME LIKE '%" & TXT_SEARCH.Text & "%'", sqlconnt)
        DA.Fill(DT)
        DataGridView2.DataSource = DT.DefaultView
    End Sub
    'تم نسخها
    Private Sub RECOVER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtNew_Click(sender, e)

    End Sub

    Private Sub ButtSave_Click(sender As Object, e As EventArgs) Handles ButtSave.Click
        If ReCUSTOMERNAME.Text = "" Then
            MessageBox.Show("يرجاء ادخال اسم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SEARCH_CUST.ShowDialog()
            ReCUSTOMERNAME.Select()
            Exit Sub
        End If
        If ReSALETYPE.SelectedIndex < 0 Then
            MessageBox.Show("يرجاء اختيار نوع الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReSALETYPE.Select()
            Exit Sub
        End If
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("لا يوجد اصناف لعرضها", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReSALETYPE.Select()
            Exit Sub
        End If
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(I).Cells(4).Value = 0 Then
                MessageBox.Show("يرجاء التحقق من الكمية", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from ReSALEBILL where ReSALECODE = '" & ReSALECODE.Text & "'  ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            ReSALECODE.Text = CODE_GENT7("ID") + 1
        Else
            Dim ADD = DT.NewRow
            ADD!ReSALECODE = ReSALECODE.Text
            ADD!ReSALETYPE = ReSALETYPE.Text
            ADD!ReSALEDATE = ReSALEDATE.Value
            ADD!ReCUSTOMERNAME = ReCUSTOMERNAME.Text
            ADD!ReNOTES = BUY_NOTES.Text
            ADD!ReDISCOUND = Convert.ToDecimal(DISCOUND.Text)
            ADD!ReTOTAL = Convert.ToDecimal(TOTAL.Text)
            ADD!ReTOTALARB = TOTALARB.Text
            ADD!ReTOTALQNT = Val(TOTALQTY.Text)
            ADD!ReSALEUSER = ReSALEUSER.Text
            ADD!STATE = True
            DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
        End If

        '==============حركة الزبون
        'Dim DES = "فاتور استرجاع المشتريات رقم " & ReSALECODE.Text
        'OPER_CUSTEMUR(ReSALECODE.Text, ReSALEDATE.Text, DES, 0, TOTAL.Text, ReCUSTOMERNAME.Text, CUS_CODE.Text)
        Dim DTA As New SqlClient.SqlDataAdapter("Select * from DET_CUSTOMERS ", sqlconnt)
        Dim DASET As New DataSet
        DASET = New DataSet
        DTA.Fill(DASET)
        Dim DT_ = DASET.Tables(0)
        Dim DR_ = DT_.NewRow
        DR_!SALECODE = ReSALECODE.Text
        DR_!SALEDATE = ReSALEDATE.Value
        DR_!DESCRIPTION = "فاتور استرجاع المشتريات رقم " & ReSALECODE.Text
        DR_!DEBIT = "0"
        DR_!CERDIT = Val(TOTAL.Text)
        DR_!CUS_NAME = ReCUSTOMERNAME.Text
        DR_!CUS_CODE = CUS_CODE.Text
        DT_.Rows.Add(DR_)
        Dim SAVE_ As New SqlClient.SqlCommandBuilder(DTA)
        DTA.Update(DT_)
        '===============تفاصيل الفاتورة 
        DA = New SqlClient.SqlDataAdapter("Select * from ReSALE_DET  ", sqlconnt)
        DA.Fill(DT)
        For I = 0 To DataGridView1.Rows.Count - 1
            Dim DR = DT.NewRow
            DR!ReSALECODE = ReSALECODE.Text
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
            NEW_QTY = Val(DataGridView1.Rows(M).Cells(7).Value) + Val(DataGridView1.Rows(M).Cells(4).Value)
            Dim CMD1 As New SqlClient.SqlCommand
            CMD1.Connection = sqlconnt
            CMD1.CommandText = "UPDATE ITEMS SET QTY = " & NEW_QTY & " WHERE ITEM_NAME = '" & DataGridView1.Rows(M).Cells(1).Value & "' "
            CMD1.ExecuteNonQuery()
        Next
        MessageBox.Show("تم حفظ فاتورة استرجاع المبيعات بنجاح ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ButtNew_Click(sender, e)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        If DataGridView2(0, DataGridView2.CurrentRow.Index).Selected = True Then
            TXT_BAR.Text = DataGridView2.CurrentRow.Cells(2).Value
            TXT_BAR_Leave(sender, e)
            TXT_SEARCH.Clear()
            TXT_SEARCH.Select()

        End If
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(9, DataGridView1.CurrentRow.Index).Selected = True Then



            If DataGridView1.Rows.Count = 0 Then Exit Sub
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            CALC()
        End If
    End Sub

    Private Sub ButtEdite_Click(sender As Object, e As EventArgs) Handles ButtEdite.Click
        If ReCUSTOMERNAME.Text = "" Then
            MessageBox.Show("يرجاء ادخال اسم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'SEARCH_CUST.ShowDialog()
            ReCUSTOMERNAME.Select()
            Exit Sub
        End If
        If ReSALETYPE.SelectedIndex < 0 Then
            MessageBox.Show("يرجاء اختيار نوع الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReSALETYPE.Select()
            Exit Sub
        End If
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("لا يوجد اصناف لعرضها", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReSALETYPE.Select()
            Exit Sub
        End If
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(I).Cells(4).Value = 0 Then
                MessageBox.Show("يرجاء التحقق من الكمية", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Next

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from ReSALEBILL where ReSALECODE = '" & ReSALECODE.Text & "'  ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجاء التحقق من رقم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ADD = DT.Rows(0)
            ADD!ReSALECODE = ReSALECODE.Text
            ADD!ReSALETYPE = ReSALETYPE.Text
            ADD!ReSALEDATE = ReSALEDATE.Value
            ADD!ReCUSTOMERNAME = ReCUSTOMERNAME.Text
            ADD!ReNOTES = BUY_NOTES.Text
            ADD!ReDISCOUND = Convert.ToDecimal(DISCOUND.Text)
            ADD!ReTOTAL = Convert.ToDecimal(TOTAL.Text)
            ADD!ReTOTALARB = TOTALARB.Text
            ADD!ReTOTALQNT = Val(TOTALQTY.Text)
            ADD!ReSALEUSER = ReSALEUSER.Text
            ADD!STATE = True

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
        End If
        Dim CMD_DEL As New SqlClient.SqlCommand
        CMD_DEL.Connection = sqlconnt
        CMD_DEL.CommandText = "DELETE FROM  ReSALE_DET WHERE ReSALECODE ='" & ReSALECODE.Text & "' "
        CMD_DEL.ExecuteNonQuery()

        Dim CMD_DELL As New SqlClient.SqlCommand
        CMD_DELL.Connection = sqlconnt
        CMD_DELL.CommandText = "DELETE FROM  DET_CUSTOMERS WHERE ReSALECODE ='" & ReSALECODE.Text & "' "
        CMD_DELL.ExecuteNonQuery()
        '==============حركة الزبون
        Dim DES = "فاتور استرجاع المشتريات رقم " & ReSALECODE.Text
        OPER_CUSTEMUR(ReSALECODE.Text, ReSALEDATE.Text, DES, 0, TOTAL.Text, ReCUSTOMERNAME.Text, CUS_CODE.Text)
        '=================================
        DA = New SqlClient.SqlDataAdapter("Select * from ReSALE_DET  ", sqlconnt)
        DA.Fill(DT)

        For I = 0 To DataGridView1.Rows.Count - 1

            Dim DR = DT.NewRow
            DR!ReSALECODE = ReSALECODE.Text
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
            NEW_QTY = Val(DataGridView1.Rows(M).Cells(7).Value) + Val(DataGridView1.Rows(M).Cells(4).Value)
            Dim CMD1 As New SqlClient.SqlCommand
            CMD1.Connection = sqlconnt
            CMD1.CommandText = "UPDATE ITEMS SET QTY = " & NEW_QTY & " WHERE ITEM_NAME = '" & DataGridView1.Rows(M).Cells(1).Value & "' "
            CMD1.ExecuteNonQuery()
        Next
        MessageBox.Show("تم عملية التعديل فاتورة استرجاع المبيعات بنجاح ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ButtNew_Click(sender, e)
    End Sub

    Private Sub ButtDelete_Click(sender As Object, e As EventArgs) Handles ButtDelete.Click
        Dim DEL = MessageBox.Show("هل ترغم في حذف فاتورة نهايا ام نقلها للارشيف ؟", "رسالة تنبيهية", MessageBoxButtons.YesNoCancel)
        '=============حذف نهائي
        If DEL = Windows.Forms.DialogResult.Yes Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("Select * from RESALEBILL where RESALECODE = '" & ReSALECODE.Text & "'  ", sqlconnt)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("يرجاء التحقق من رقم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim ADD = DT.Rows(0)
                ADD.Delete()
                Dim CMD As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)

                '   Dim CMS_ As New SqlClient.SqlCommandBuilder(DA)
                Dim NEW_QTY As Double
                For H As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim DT_ As New DataTable
                    Dim DA_ As New SqlClient.SqlDataAdapter
                    Dim CMS_ As New SqlClient.SqlCommand
                    DT_.Clear()
                    DA_ = New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS WHERE ITEM_NAME='" & DataGridView1(1, DataGridView1.Rows(H).Index).Value & "'", sqlconnt)
                    DA_.Fill(DT_)
                    If DT_.Rows.Count > 0 Then
                        NEW_QTY = DT_.Rows(0).Item("QTY")
                    End If
                    Dim QTY_ As Double
                    QTY_ = NEW_QTY - Val(DataGridView1(4, DataGridView1.Rows(H).Index).Value)

                    CMS_ = New SqlClient.SqlCommand("UPDATE ITEMS SET QTY = " & QTY_ & " WHERE ITEM_NAME = '" & DataGridView1(1, DataGridView1.Rows(H).Index).Value & "' ", sqlconnt)
                    CMS_.ExecuteNonQuery()
                Next
                MessageBox.Show("تمت عملية استرجاع فاتورة المبيعات نهائيا", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ButtNew_Click(sender, e)
            End If


        End If
        '=========نقل للأرشيف
        If DEL = Windows.Forms.DialogResult.YES Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("Select * from RESALEBILL where RESALECODE = '" & ReSALECODE.Text & "'  ", sqlconnt)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("يرجاء التحقق من رقم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim ADD = DT.Rows(0)
                ADD!STATE = False
                Dim CMD As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                Dim NEW_QTY As Double
                For H As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim DT_ As New DataTable
                    Dim DA_ As New SqlClient.SqlDataAdapter
                    Dim CMS_ As New SqlClient.SqlCommand
                    DT_.Clear()
                    DA_ = New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS WHERE ITEM_NAME='" & DataGridView1(1, DataGridView1.Rows(H).Index).Value & "'", sqlconnt)
                    DA_.Fill(DT_)
                    If DT_.Rows.Count > 0 Then
                        NEW_QTY = DT_.Rows(0).Item("QTY")
                    End If
                    Dim QTY_ As Double
                    QTY_ = NEW_QTY - Val(DataGridView1(4, DataGridView1.Rows(H).Index).Value)

                    CMS_ = New SqlClient.SqlCommand("UPDATE ITEMS SET QTY = " & QTY_ & " WHERE ITEM_NAME = '" & DataGridView1(1, DataGridView1.Rows(H).Index).Value & "' ", sqlconnt)
                    CMS_.ExecuteNonQuery()
                Next
                MessageBox.Show("تمت عملية نقل فاتورة استرجاع المبيعات للارشيف", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ButtNew_Click(sender, e)
            End If


        End If
    End Sub

    Private Sub BUTTSEARCH_Click(sender As Object, e As EventArgs) Handles BUTTSEARCH.Click
        SEARCH_RE.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SHOW_FROM = "1شاشة الزبائن "
        SEARCH_CUSMU.ShowDialog()
    End Sub

    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Dispose()
    End Sub
End Class