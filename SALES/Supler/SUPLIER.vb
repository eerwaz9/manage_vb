

Public Class SUPLIER
    Sub SHOW_DETALLES(ID_)
        Try
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("Select * from IMPORTERS where IMP_CODE = '" & ID_ & "' ", sqlconnt)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("المورد غير موجود يرجاء التاكد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim Show As Integer = BindingContext(DT).Position
                TXT_CODE.Text = DT.Rows(Show).Item("IMP_CODE")
                TXTPHONE.Text = DT.Rows(Show).Item("IMP_PHONE")
                TXT_NAME.Text = DT.Rows(Show).Item("IMP_NAME")
                TXT_ADDRESS.Text = DT.Rows(Show).Item("IMP_ADDESS")
                TXT_NOTES.Text = DT.Rows(Show).Item("NOTES")
                TXT_COMPANY.Text = DT.Rows(Show).Item("COMPANY")
                CERDIT.Text = DT.Rows(Show).Item("CERDIT")
                DEBIT.Text = DT.Rows(Show).Item("DEBIT")
                ButtEdite.Enabled = True
                ButtDelete.Enabled = True
                ButtSave.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub Shoe_Detall()
        Try
            Dim DT As New DataTable
            Dim Show As Integer = BindingContext(DT).Position

            TXT_CODE.Text = DT.Rows(Show).Item("IMP_CODE")
            TXTPHONE.Text = DT.Rows(Show).Item("IMP_PHONE")
            TXT_NAME.Text = DT.Rows(Show).Item("IMP_NAME")
            TXT_ADDRESS.Text = DT.Rows(Show).Item("IMP_ADDESS")
            TXT_NOTES.Text = DT.Rows(Show).Item("NOTES")
            TXT_COMPANY.Text = DT.Rows(Show).Item("COMPANY")
            CERDIT.Text = DT.Rows(Show).Item("CERDIT")
            DEBIT.Text = DT.Rows(Show).Item("DEBIT")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Public Sub ButtNew_Click(sender As Object, e As EventArgs) Handles ButtNew.Click
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""

        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox2.Controls(I).Text = ""

        Next
        TXT_CODE.Text = CODE_GENT("ID") + 1
        ButtEdite.Enabled = False
        ButtDelete.Enabled = False
        DEBIT.Text = "0.00"
        CERDIT.Text = "0.00"
        TXTMINS.Text = "0.00"
        TXT_NAME.Select()


    End Sub

    Private Sub ButtSave_Click(sender As Object, e As EventArgs) Handles ButtSave.Click
        '************* كود الحفظ*****************
        If TXT_NAME.Text = "" Then
            MessageBox.Show("يرجاء ادخال اسم المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If
        If TXTPHONE.Text = "" Then
            MessageBox.Show("يرجاء رقم هاتف المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXTPHONE.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from IMPORTERS where IMP_NAME = '" & TXT_NAME.Text & "' OR IMP_PHONE = '" & TXTPHONE.Text & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("المورد موجود مسبقا", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            DT.Rows.Add()
            Dim ADD As Integer = DT.Rows.Count - 1
            DT.Rows(ADD).Item("IMP_CODE") = TXT_CODE.Text
            DT.Rows(ADD).Item("IMP_PHONE") = TXTPHONE.Text
            DT.Rows(ADD).Item("IMP_NAME") = TXT_NAME.Text
            DT.Rows(ADD).Item("IMP_ADDESS") = TXT_ADDRESS.Text
            DT.Rows(ADD).Item("NOTES") = TXT_NOTES.Text
            DT.Rows(ADD).Item("COMPANY") = TXT_COMPANY.Text
            DT.Rows(ADD).Item("CERDIT") = Val(CERDIT.Text)
            DT.Rows(ADD).Item("DEBIT") = Val(DEBIT.Text)
            DT.Rows(ADD).Item("STATES") = True
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            DT.AcceptChanges()
            MessageBox.Show("تمت عملية اضافة بيانات المورد ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If


    End Sub

    Private Sub ButtEdite_Click(sender As Object, e As EventArgs) Handles ButtEdite.Click

        '************* كود التعديل*****************

        If TXT_NAME.Text = "" Then
            MessageBox.Show("يرجاء ادخال اسم المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If
        If TXTPHONE.Text = "" Then
            MessageBox.Show("يرجاء رقم هاتف المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXTPHONE.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from IMPORTERS where IMP_CODE = '" & TXT_CODE.Text & "'", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("المورد غير موجود ", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim UPDATE As Integer = BindingContext(DT).Position
            DT.Rows(UPDATE).Item("IMP_CODE") = TXT_CODE.Text
            DT.Rows(UPDATE).Item("IMP_PHONE") = TXTPHONE.Text
            DT.Rows(UPDATE).Item("IMP_NAME") = TXT_NAME.Text
            DT.Rows(UPDATE).Item("IMP_ADDESS") = TXT_ADDRESS.Text
            DT.Rows(UPDATE).Item("NOTES") = TXT_NOTES.Text
            DT.Rows(UPDATE).Item("COMPANY") = TXT_COMPANY.Text
            DT.Rows(UPDATE).Item("CERDIT") = Val(CERDIT.Text)
            DT.Rows(UPDATE).Item("DEBIT") = Val(DEBIT.Text)
            DT.Rows(UPDATE).Item("STATES") = True
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            DT.AcceptChanges()
            MessageBox.Show("تمت عملية اضافة بيانات المورد ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If

    End Sub

    Private Sub ButtDelete_Click(sender As Object, e As EventArgs) Handles ButtDelete.Click
        '************* كود الحذف*****************
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        'If MessageBox.Show("هل تريد بالفعل حذف مورد", "رسالة تنبيهية", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance


        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from IMPORTERS where IMP_CODE = '" & TXT_CODE.Text & "'", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("المورد غير موجود ", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim UPDATE As Integer = BindingContext(DT).Position

            DT.Rows(UPDATE).Item("STATES") = False
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            DT.AcceptChanges()
            MessageBox.Show("تمت عملية حذف بيانات المورد ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If

    End Sub

    Private Sub SUPLIER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtNew_Click(sender, e)
    End Sub

    Private Sub TXT_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE.TextChanged

    End Sub

    Private Sub BUTTSEARCH_Click(sender As Object, e As EventArgs) Handles BUTTSEARCH.Click
        Search.ShowDialog()
    End Sub

    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Dispose()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class