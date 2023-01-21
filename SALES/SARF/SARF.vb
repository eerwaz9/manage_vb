Public Class SARF
    Sub SHOW_DET(CODE_)

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from SARF where SA_CODE = '" & CODE_ & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجاء التاكد من رقم الفاتورة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ADD = DT.Rows(0)
            SA_CODE.Text = ADD!SA_CODE
            IMP_CODE.Text = ADD!IMP_CODE
            IMP_NAME.Text = ADD!IMP_NAME
            MONY.Text = ADD!MONY
            SA_DATE.Value = ADD!SA_DATE
            ARABIC.Text = ADD!ARABIC_
            NOTE.Text = ADD!NOTE





        End If

    End Sub
    Private Sub ButtNew_Click(sender As Object, e As EventArgs) Handles ButtNew.Click
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
            If TypeOf GroupBox1.Controls(I) Is DateTimePicker Then GroupBox1.Controls(I).Text = Now.Date
            'If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next

        SA_CODE.Text = Format(CODE_GENT10("ID") + 1, "00000")
        ButtDelete.Enabled = False
        ButtEdite.Enabled = False
        NOTE.Text = "تسوية حساب"
        ButtSave.Enabled = True
    End Sub

    Private Sub SARF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtNew_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SARF_IMP.ShowDialog()
    End Sub

    Private Sub ButtSave_Click(sender As Object, e As EventArgs) Handles ButtSave.Click
        If IMP_CODE.Text = "" Then
            MessageBox.Show("يرجاء ادخال  المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

            SARF_IMP.ShowDialog()
            IMP_NAME.Select()
            Exit Sub
        End If
        If MONY.Text = "" Then
            MessageBox.Show("يرجاء القيمة المالية", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MONY.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from SARF where SA_CODE = '" & SA_CODE.Text & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            SA_CODE.Text = Format(CODE_GENT10("ID") + 1, "00000")
        Else
            Dim ADD = DT.NewRow
            ADD!SA_DATE = SA_DATE.Value
            ADD!SA_CODE = SA_CODE.Text
            ADD!IMP_CODE = IMP_CODE.Text
            ADD!MONY = Val(MONY.Text)
            ADD!ARABIC_ = ARABIC.Text
            ADD!NOTE = NOTE.Text
            ADD!IMP_NAME = IMP_NAME.Text
            DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            '=================حفظ حركة المورد ===========
            Dim DTA As New SqlClient.SqlDataAdapter("Select * from DET_IMPORTERS ", sqlconnt)
            'DTA = New SqlClient.SqlDataAdapter
            Dim DASET As New DataSet
            DASET = New DataSet
            DTA.Fill(DASET)
            Dim DT_ = DASET.Tables(0)

            Dim DR_ = DT_.NewRow
            DR_!PUYCODE = SA_CODE.Text
            DR_!PUYDATE = SA_DATE.Value
            DR_!DESCRIPTION = NOTE.Text
            DR_!DEBIT = "0"
            DR_!CERDIT = Val(MONY.Text)
            DR_!IMP_NAME = IMP_NAME.Text
            DR_!IMP_CODE = IMP_CODE.Text
            DT_.Rows.Add(DR_)
            Dim SAVE_ As New SqlClient.SqlCommandBuilder(DTA)
            DTA.Update(DT_)






            MessageBox.Show("تمت عملية حفظ السند !", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If
    End Sub

    Private Sub ButtEdite_Click(sender As Object, e As EventArgs) Handles ButtEdite.Click
        If IMP_CODE.Text = "" Then
            MessageBox.Show("يرجاء ادخال  المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

            SARF_IMP.ShowDialog()
            IMP_NAME.Select()
            Exit Sub
        End If
        If MONY.Text = "" Then
            MessageBox.Show("يرجاء القيمة المالية", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MONY.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from SARF where SA_CODE = '" & SA_CODE.Text & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجاء التاكد من رقم الفاتورة ", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ADD = DT.Rows(0)
            ADD!SA_DATE = SA_DATE.Value
            ADD!SA_CODE = SA_CODE.Text
            ADD!IMP_CODE = IMP_CODE.Text
            ADD!MONY = Val(MONY.Text)
            ADD!ARABIC_ = ARABIC.Text
            ADD!NOTE = NOTE.Text
            ADD!IMP_NAME = IMP_NAME.Text
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            '=================حفظ حركة المورد ===========
            Dim CMD_DELL As New SqlClient.SqlCommand
            CMD_DELL.Connection = sqlconnt
            CMD_DELL.CommandText = "DELETE FROM  DET_IMPORTERS WHERE PUYCODE ='" & SA_CODE.Text & "' "
            CMD_DELL.ExecuteNonQuery()
            '===================
            Dim DTA As New SqlClient.SqlDataAdapter("Select * from DET_IMPORTERS ", sqlconnt)
            DTA = New SqlClient.SqlDataAdapter
            Dim DASET As New DataSet
            DASET = New DataSet
            DTA.Fill(DASET)
            Dim DT_ = DASET.Tables(0)

            Dim DR_ = DT_.NewRow
            DR_!PUYCODE = SA_CODE.Text
            DR_!PUYDATE = SA_DATE.Value
            DR_!DESCRIPTION = NOTE.Text
            DR_!DEBIT = "0"
            DR_!CERDIT = Val(MONY.Text)
            DR_!IMP_NAME = IMP_NAME.Text
            DR_!IMP_CODE = IMP_CODE.Text
            DT_.Rows.Add(DR_)
            Dim SAVE_ As New SqlClient.SqlCommandBuilder(DTA)
            DTA.Update(DT_)

            MessageBox.Show("تمت عملية التعديل السند !", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If
    End Sub

    Private Sub ButtDelete_Click(sender As Object, e As EventArgs) Handles ButtDelete.Click
        If MessageBox.Show("هل ترغب في حذف السند !", "رسالة تاكيد", MessageBoxButtons.OK) = Windows.Forms.DialogResult.No Then Exit Sub
        If IMP_CODE.Text = "" Then
            MessageBox.Show("يرجاء ادخال  المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)

            SARF_IMP.ShowDialog()
            IMP_NAME.Select()
            Exit Sub
        End If
        If MONY.Text = "" Then
            MessageBox.Show("يرجاء القيمة المالية", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MONY.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from SARF where SA_CODE = '" & SA_CODE.Text & "' ", sqlconnt)
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
            CMD_DELL.CommandText = "DELETE FROM  DET_IMPORTERS WHERE PUYCODE ='" & SA_CODE.Text & "' "
            CMD_DELL.ExecuteNonQuery()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Val(MONY.Text) > 0 Then
            'ARABIC.Text = ARABIC.C
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BUTTSEARCH_Click(sender As Object, e As EventArgs) Handles BUTTSEARCH.Click
        SARF_old.ShowDialog()
    End Sub

    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Dispose()
    End Sub
End Class