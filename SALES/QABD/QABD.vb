Public Class QABD
    Sub SHOW_AQ(CODE_)

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from QABD where QA_CODE = '" & CODE_ & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجاء التاكد من رقم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ADD = DT.Rows(0)
            QA_CODE.Text = ADD!QA_CODE
            CUS_CODE.Text = ADD!CUS_CODE
            CUS_NAME.Text = ADD!CUS_NAME
            MONY.Text = ADD!MONY
            QA_DATE.Value = ADD!QA_DATE
            ARABIC.Text = ADD!ARABIC_
            NOTE.Text = ADD!NOTE

            ButtDelete.Enabled = True
            ButtEdite.Enabled = True

            ButtSave.Enabled = False



        End If

    End Sub
    Private Sub ButtNew_Click(sender As Object, e As EventArgs) Handles ButtNew.Click
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
            If TypeOf GroupBox1.Controls(I) Is DateTimePicker Then GroupBox1.Controls(I).Text = Date.Now
        Next
        QA_CODE.Text = Format(CODE_GENT11("ID") + 1, "00000")
        CUS_NAME.Select()
    End Sub

    Private Sub QABD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtNew_Click(sender, e)
    End Sub

    Private Sub ButtSave_Click(sender As Object, e As EventArgs) Handles ButtSave.Click
        If CUS_CODE.Text = "" Or CUS_NAME.Text = "" Then
            MessageBox.Show("يرجاء اختيار الزبون", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SEARCH_CUSMU.ShowDialog()
            CUS_NAME.Select()
            Exit Sub
        End If
        If MONY.Text = "" Then
            MessageBox.Show("يرجاء القيمة المالية الزبون", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MONY.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from QABD where QA_CODE = '" & QA_CODE.Text & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            QA_CODE.Text = Format(CODE_GENT11("ID") + 1, "00000")
        Else
            Dim ADD = DT.NewRow
            ADD!QA_DATE = QA_DATE.Value
            ADD!QA_CODE = QA_CODE.Text
            ADD!CUS_CODE = CUS_CODE.Text
            ADD!MONY = Val(MONY.Text)
            ADD!ARABIC_ = ARABIC.Text
            ADD!NOTE = NOTE.Text
            ADD!CUS_NAME = CUS_NAME.Text
            DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            '=========حفظ حركة المورد
            Dim DTA As New SqlClient.SqlDataAdapter("Select * from DET_CUSTOMERS ", sqlconnt)
            'DTA = New SqlClient.SqlDataAdapter
            Dim DASET As New DataSet
            DASET = New DataSet
            DTA.Fill(DASET)
            Dim DT_ = DASET.Tables(0)

            Dim DR_ = DT_.NewRow
            DR_!SALECODE = QA_CODE.Text
            DR_!SALEDATE = QA_DATE.Value
            DR_!DESCRIPTION = "سند قبض"
            DR_!DEBIT = "0"
            DR_!CERDIT = Val(MONY.Text)
            DR_!CUS_NAME = CUS_NAME.Text
            DR_!CUS_CODE = CUS_CODE.Text
            DT_.Rows.Add(DR_)
            Dim SAVE_ As New SqlClient.SqlCommandBuilder(DTA)
            DTA.Update(DT_)
            MessageBox.Show("تمت عملية حفظ السند !", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SHOW_FROM = "شاشة الزبائن3"
        SEARCH_CUSMU.ShowDialog()
    End Sub

    Private Sub ButtEdite_Click(sender As Object, e As EventArgs) Handles ButtEdite.Click
        If CUS_CODE.Text = "" Or CUS_NAME.Text = "" Then
            MessageBox.Show("يرجاء اختيار الزبون", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SEARCH_CUSMU.ShowDialog()
            CUS_NAME.Select()
            Exit Sub
        End If
        If MONY.Text = "" Then
            MessageBox.Show("يرجاء القيمة المالية", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MONY.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from QABD where QA_CODE = '" & QA_CODE.Text & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجاء التاكد من رقم السند ", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ADD = DT.Rows(0)
            ADD!QA_DATE = QA_DATE.Value
            ADD!QA_CODE = QA_CODE.Text
            ADD!CUS_CODE = CUS_CODE.Text
            ADD!MONY = Val(MONY.Text)
            ADD!ARABIC_ = ARABIC.Text
            ADD!NOTE = NOTE.Text
            ADD!CUS_NAME = CUS_NAME.Text
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            '=================حفظ حركة المورد ===========
            Dim CMD_DELL As New SqlClient.SqlCommand
            CMD_DELL.Connection = sqlconnt
            CMD_DELL.CommandText = "DELETE FROM  QABD WHERE QA_CODE ='" & QA_CODE.Text & "' "
            CMD_DELL.ExecuteNonQuery()
            '===================
            Dim DTA As New SqlClient.SqlDataAdapter("Select * from DET_CUSTOMERS ", sqlconnt)
            DTA = New SqlClient.SqlDataAdapter
            Dim DASET As New DataSet
            DASET = New DataSet
            DTA.Fill(DASET)
            Dim DT_ = DASET.Tables(0)

            Dim DR_ = DT_.NewRow
            DR_!SALECODE = QA_CODE.Text
            DR_!SALEDATE = QA_DATE.Value
            DR_!DESCRIPTION = "سند قبض"
            DR_!DEBIT = "0"
            DR_!CERDIT = Val(MONY.Text)
            DR_!CUS_NAME = CUS_NAME.Text
            DR_!CUS_CODE = CUS_CODE.Text
            DT_.Rows.Add(DR_)
            Dim SAVE_ As New SqlClient.SqlCommandBuilder(DTA)
            DTA.Update(DT_)
            MessageBox.Show("تمت عملية التعديل السند !", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If
    End Sub


    Private Sub ButtDelete_Click(sender As Object, e As EventArgs) Handles ButtDelete.Click
        If MessageBox.Show("هل ترغب في حذف السند !", "رسالة تاكيد", MessageBoxButtons.OK) = Windows.Forms.DialogResult.No Then Exit Sub
        If CUS_CODE.Text = "" Then
            MessageBox.Show("يرجاء ادخال  المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

            SARF_IMP.ShowDialog()
            CUS_NAME.Select()
            Exit Sub
        End If
        If MONY.Text = "" Then
            MessageBox.Show("يرجاء القيمة المالية", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MONY.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from QABD where QA_CODE = '" & QA_CODE.Text & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجاء التاكد من رقم الفاتورة ", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ADD = DT.Rows(0)
            ADD.Delete()
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            '=================حفظ حركة المورد ===========

            Dim CMD_DELL As New SqlClient.SqlCommand
            CMD_DELL.Connection = sqlconnt
            CMD_DELL.CommandText = "DELETE FROM  QABD WHERE QA_CODE ='" & QA_CODE.Text & "' "
            CMD_DELL.ExecuteNonQuery()
        End If
    End Sub

    Private Sub BUTTSEARCH_Click(sender As Object, e As EventArgs) Handles BUTTSEARCH.Click
        QABD_old.ShowDialog()
    End Sub

    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Dispose()
    End Sub
End Class