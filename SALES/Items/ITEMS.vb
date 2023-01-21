Public Class ITEMS
    Sub SHOW_DETALLES(ID_)
        Try
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("Select * from ITEMS where ITEM_CODE = '" & ID_ & "' ", sqlconnt)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("بيانات الصنف غير موجودة", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim ADD = DT.Rows(0)
                TXT_NAME.Text = ADD!ITEM_NAME
                TXT_CODE.Text = ADD!ITEM_CODE
                TXT_UNIT.Text = ADD!ITEM_UNIT
                TXT_PUY.Text = ADD!ITEM_TKLFA
                TXT_SELL.Text = ADD!ITEM_PRICE
                TXT_DATE.Value = ADD!ITEM_EXPIRE
                TXT_NOTES.Text = ADD!NOTES
                TXT_BAR.Text = ADD!ITEM_BAR
                CheckBox1.Checked = ADD!ITEM_CHEACK
                TXT_QIT.Text = ADD!QTY
                ButtEdite.Enabled = True
                ButtDelete.Enabled = True
                ButtSave.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub FILL_UNIT(STR As String)
        TXT_UNIT.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(STR, sqlconnt)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_UNIT.Items.Add(DT.Rows(I).Item("UNIT_NAME"))
        Next
    End Sub
    Private Sub ButtNew_Click(sender As Object, e As EventArgs) Handles ButtNew.Click
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
            If TypeOf GroupBox1.Controls(I) Is DateTimePicker Then GroupBox1.Controls(I).Text = Now.Date
            'If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next
        CheckBox1.Checked = False
        TXT_UNIT.Text = ""
        TXT_CODE.Text = CODE_GENT3("ID") + 1
        ButtDelete.Enabled = False
        ButtEdite.Enabled = False

        TXT_NAME.Select()
    End Sub

    Private Sub ITEMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtNew_Click(sender, e)
    End Sub

    Private Sub ButtSave_Click(sender As Object, e As EventArgs) Handles ButtSave.Click
        If TXT_NAME.Text = "" Then
            TXT_NAME.BackColor = Color.Red
            TXT_NAME.Select()

            TXT_NAME.Select()
            Exit Sub
        End If
        If TXT_BAR.Text = "" Then
            TXT_BAR.BackColor = Color.Red
            TXT_BAR.Select()
            TXT_BAR.Select()
            Exit Sub
        End If
        If Val(TXT_PUY.Text) > (TXT_SELL.Text) Then
            MessageBox.Show("سعر التكلفة اكبر من سعر البيع ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Val(TXT_PUY.Text) = (TXT_SELL.Text) Then
            MessageBox.Show("سعر التكلفة يساوي من سعر البيع  ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from ITEMS where ITEM_CODE = '" & TXT_CODE.Text & "' OR ITEM_BAR = '" & TXT_BAR.Text & "' ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("الزبون موجود مسبقا", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim ADD = DT.NewRow
            ADD!ITEM_NAME = TXT_NAME.Text
            ADD!ITEM_CODE = TXT_CODE.Text
            ADD!ITEM_UNIT = TXT_UNIT.Text
            ADD!ITEM_TKLFA = (TXT_PUY.Text)
            ADD!ITEM_PRICE = Val(TXT_SELL.Text)
            ADD!ITEM_EXPIRE = TXT_DATE.Value
            ADD!NOTES = TXT_NOTES.Text
            ADD!ITEM_BAR = TXT_BAR.Text
            ADD!ITEM_CHEACK = CheckBox1.Checked
            ADD!QTY = Val(TXT_QIT.Text)
            DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية اضافة بيانات الزبون ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TXT_NAME_TextChanged(sender As Object, e As EventArgs) Handles TXT_NAME.TextChanged
        TXT_NAME.BackColor = Color.White
    End Sub

    Private Sub TXT_BAR_TextChanged(sender As Object, e As EventArgs) Handles TXT_BAR.TextChanged
        TXT_BAR.BackColor = Color.White
    End Sub

    Private Sub ButtEdite_Click(sender As Object, e As EventArgs) Handles ButtEdite.Click
        If TXT_NAME.Text = "" Then
            TXT_NAME.BackColor = Color.Red
            TXT_NAME.Select()

            TXT_NAME.Select()
            Exit Sub
        End If
        If TXT_BAR.Text = "" Then
            TXT_BAR.BackColor = Color.Red
            TXT_BAR.Select()
            TXT_BAR.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from ITEMS where ITEM_CODE = '" & TXT_CODE.Text & "'  ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("الزبون موجود مسبقا", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'DT.Rows.Add()
            ' Dim ADD As Integer = DT.Rows.Count - 1
            Dim ADD = DT.Rows(0)
            ADD!ITEM_NAME = TXT_NAME.Text
            ADD!ITEM_CODE = TXT_CODE.Text
            ADD!ITEM_UNIT = TXT_UNIT.Text
            ADD!ITEM_TKLFA = (TXT_PUY.Text)
            ADD!ITEM_PRICE = Val(TXT_SELL.Text)
            ADD!ITEM_EXPIRE = TXT_DATE.Value
            ADD!NOTES = TXT_NOTES.Text
            'ADD!ITEM_CHEACK = True
            ADD!ITEM_BAR = TXT_BAR.Text
            ADD!ITEM_CHEACK = CheckBox1.Checked
            ADD!QTY = Val(TXT_QIT.Text)
            '   DT.Rows.Add(ADD)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية التعديل بيانات الزبون ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)
        End If
    End Sub

    Private Sub ButtDelete_Click(sender As Object, e As EventArgs) Handles ButtDelete.Click
        If MessageBox.Show("هddddddddddddل حذف صنف", "رسالة تنبيهية", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("Select * from ITEMS where ITEM_CODE = '" & TXT_CODE.Text & "'  ", sqlconnt)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("اسم الوخدة غير موجود من قبل", "رسالة تنبيهية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim ADD = DT.Rows(0)
            ADD.Delete()
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية التعديل بيانات الوحدة ", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtNew_Click(sender, e)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        unit_add.ShowDialog()
    End Sub

    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Dispose()
    End Sub

    Private Sub TXT_UNIT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_UNIT.SelectedIndexChanged

    End Sub

    Private Sub TXT_UNIT_DropDown(sender As Object, e As EventArgs) Handles TXT_UNIT.DropDown
        FILL_UNIT("SELECT * FROM UNIT")
    End Sub

    Private Sub BUTTSEARCH_Click(sender As Object, e As EventArgs) Handles BUTTSEARCH.Click
        SEARCH_ITEMS.ShowDialog()
    End Sub
End Class