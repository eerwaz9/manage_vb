


Public Class CUSTEMRERS

    Sub SHOW_DETALLES(ID_)
        Try
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("Select * from CUSTOMERS where CUS_CODE = '" & ID_ & "' ", sqlconnt)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("الزبون غير موجود يرجاء التاكد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim Show As Integer = BindingContext(DT).Position
                TXT_CODE.Text = DT.Rows(Show).Item("CUS_CODE")
                TXTPHONE.Text = DT.Rows(Show).Item("CUS_PHONE")
                TXT_NAME.Text = DT.Rows(Show).Item("CUS_NAME")
                TXT_ADDRESS.Text = DT.Rows(Show).Item("CUS_ADDRESS")
                TXT_NOTES.Text = DT.Rows(Show).Item("NOTES")
                TXT_COMPANY.Text = DT.Rows(Show).Item("COMPANY")
                CERDIT.Text = DT.Rows(Show).Item("CREDIT")
                DEBIT.Text = DT.Rows(Show).Item("DEBIT")
                ButtEdite.Enabled = True
                ButtDelete.Enabled = True

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ButtNew_Click(sender As Object, e As EventArgs) Handles ButtNew.Click
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""

        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox2.Controls(I).Text = ""

        Next
        TXT_CODE.Text = CODE_GENT2("ID") + 1
        ButtEdite.Enabled = False
        ButtDelete.Enabled = False
        DEBIT.Text = "0.00"
        CERDIT.Text = "0.00"
        TXTMINS.Text = "0.00"
        TXT_NAME.Select()

    End Sub

    Private Sub CUSTEMRERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtNew_Click(sender, e)
    End Sub

    Private Sub ButtSave_Click(sender As Object, e As EventArgs) Handles ButtSave.Click
        If TXT_NAME.Text = "" Then
            MessageBox.Show("يرجاء ادخال اسم المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If
        If TXTPHONE.Text = "" Then
            '  ErrorProvider1.SetError(TXTPHONE, "يرجاء ادخال رقم الزبون")
            MessageBox.Show("يرجاء رقم هاتف المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXTPHONE.Select()
            Exit Sub
        End If

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from CUSTOMERS where CUS_NAME = '" & TXT_NAME.Text & "' OR CUS_PHONE = '" & TXTPHONE.Text & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("الزبون موجود مسبقا", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'DT.Rows.Add()
            ' Dim ADD As Integer = DT.Rows.Count - 1
            Dim ADD = DT.NewRow
            ADD!CUS_NAME = TXT_NAME.Text
            ADD!CUS_CODE = TXT_CODE.Text
            ADD!CUS_PHONE = TXTPHONE.Text
            ADD!CUS_ADDRESS = TXT_ADDRESS.Text
            ADD!NOTES = TXT_NOTES.Text
            ADD!STATES = True
            ADD!COMPANY = TXT_COMPANY.Text
            ADD!DEBIT = DEBIT.Text
            ADD!CREDIT = CERDIT.Text
            DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية اضافة بيانات الزبون ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If
    End Sub

    Private Sub TXT_NAME_TextChanged(sender As Object, e As EventArgs) Handles TXT_NAME.TextChanged
        ' ErrorProvider.SetError(TXT_NAME, "")
    End Sub

    Private Sub TXTPHONE_TextChanged(sender As Object, e As EventArgs) Handles TXTPHONE.TextChanged
        ' ErrorProvider1.SetError(TXTPHONE, "")
    End Sub

    Private Sub ButtEdite_Click(sender As Object, e As EventArgs) Handles ButtEdite.Click
        If TXT_NAME.Text = "" Then


            MessageBox.Show("يرجاء ادخال اسم المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If
        If TXTPHONE.Text = "" Then
            '  ErrorProvider1.SetError(TXTPHONE, "يرجاء ادخال رقم الزبون")
            MessageBox.Show("يرجاء رقم هاتف المورد", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXTPHONE.Select()
            Exit Sub
        End If

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from CUSTOMERS where CUS_CODE = '" & TXT_CODE.Text & "'  ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("الزبون موجود مسبقا", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'DT.Rows.Add()
            ' Dim ADD As Integer = DT.Rows.Count - 1
            Dim ADD = DT.Rows(0)
            ADD!CUS_NAME = TXT_NAME.Text
            ADD!CUS_CODE = TXT_CODE.Text
            ADD!CUS_PHONE = TXTPHONE.Text
            ADD!CUS_ADDRESS = TXT_ADDRESS.Text
            ADD!NOTES = TXT_NOTES.Text
            ADD!STATES = True
            ADD!COMPANY = TXT_COMPANY.Text
            ADD!DEBIT = DEBIT.Text
            ADD!CREDIT = CERDIT.Text
            '   DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية التعديل بيانات الزبون ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If
    End Sub

    Private Sub ButtDelete_Click(sender As Object, e As EventArgs) Handles ButtDelete.Click
        If MessageBox.Show("هل تريد بالفعل حذف مورد", "رسالة تنبيهية", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from CUSTOMERS where CUS_CODE = '" & TXT_CODE.Text & "'  ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("الزبون موجود مسبقا", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'DT.Rows.Add()
            ' Dim ADD As Integer = DT.Rows.Count - 1
            Dim ADD = DT.Rows(0)

            ADD!STATES = False

            '   DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية حذف بيانات الزبون ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If
    End Sub

    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Dispose()
    End Sub

    Private Sub BUTTSEARCH_Click(sender As Object, e As EventArgs) Handles BUTTSEARCH.Click
        Search_CUS.ShowDialog()
    End Sub

    Private Sub CUSTEMRERS_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub
End Class