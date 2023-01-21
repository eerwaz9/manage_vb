Public Class unit_add

    Sub SHOW_DETALLES(CODE_)

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from UNIT where UNIT_CODE = '" & CODE_ & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("الوحده غير موجودة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!UNIT_CODE
            TXT_NAME.Text = DR!UNIT_NAME
            BUTEDIT.Enabled = True
            BUTDELETE.Enabled = True
            BUTSAVE.Enabled = False
        End If



    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BUTNEW.Click
        TXT_CODE.Text = CODE_GENT4("ID") + 1
        TXT_NAME.Text = ""
        BUTDELETE.Enabled = False
        BUTEDIT.Enabled = False
        BUTNEW.Enabled = True
        BUTSAVE.Enabled = True
        FILL_DGV(DataGridView2, "SELECT * FROM UNIT  ORDER BY UNIT_CODE")

    End Sub

    Private Sub unit_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button7_Click(sender, e)
    End Sub
    Private Sub DataGridView2_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView2.RowsAdded
        For I As Integer = 0 To DataGridView2.Rows.Count - 1
            DataGridView2.Rows(I).Cells(0).Value = "ادراج"
            Dim Row As DataGridViewRow = DataGridView2.Rows(I)
        Next
        For I As Integer = 0 To DataGridView2.Rows.Count - 1
            DataGridView2.Rows(I).Cells(2).Value = "عرض"
            Dim Row As DataGridViewRow = DataGridView2.Rows(I)
        Next
    End Sub

    Private Sub BUTSAVE_Click(sender As Object, e As EventArgs) Handles BUTSAVE.Click
        If TXT_NAME.Text = "" Then
            MessageBox.Show("يرجاء ادخال اسم الوحدة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from UNIT where UNIT_NAME = '" & TXT_NAME.Text & "'", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("المورد موجود مسبقا", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim ADD = DT.NewRow
            ADD!UNIT_NAME = TXT_NAME.Text
            ADD!UNIT_CODE = TXT_CODE.Text


            DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية اضافة بيانات الوحدة ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button7_Click(sender, e)
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub BUTEDIT_Click(sender As Object, e As EventArgs) Handles BUTEDIT.Click
        If TXT_NAME.Text = "" Then
            MessageBox.Show("يرجاء ادخال اسم الوحدة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from UNIT where UNIT_CODE = '" & TXT_CODE.Text & "'  ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("اسم الوخدة غير موجود من قبل", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'DT.Rows.Add()
            ' Dim ADD As Integer = DT.Rows.Count - 1
            Dim ADD = DT.Rows(0)
            ADD!UNIT_NAME = TXT_NAME.Text
            ADD!UNIT_CODE = TXT_CODE.Text
            '   DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية التعديل بيانات الوحدة ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button7_Click(sender, e)
        End If
    End Sub

    Private Sub BUTDELETE_Click(sender As Object, e As EventArgs) Handles BUTDELETE.Click
        If MessageBox.Show("هل تريد بالفعل حذف صنف", "رسالة تنبيهية", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from UNIT where UNIT_CODE = '" & TXT_CODE.Text & "'  ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("اسم الوخدة غير موجود من قبل", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim ADD = DT.Rows(0)
            ADD.Delete()
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية التعديل بيانات الوحدة ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button7_Click(sender, e)
        End If
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        If DataGridView2(2, DataGridView2.CurrentRow.Index).Selected = True Then
            SHOW_DETALLES(DataGridView2.CurrentRow.Cells(3).Value)


        End If
        'If DataGridView2(2, DataGridView2.CurrentRow.Index).Selected = True Then

        '    ITEMS.TXT_UNIT.Text = DataGridView2.CurrentRow.Cells(1).Value
        '    Me.Close()
        'End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXT_NAME.TextChanged

    End Sub
End Class