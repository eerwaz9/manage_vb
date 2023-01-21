Imports System.Windows.Forms.DialogResult
Imports System.Data.SqlClient

Module CONNETION
    Public sqlconnt As New SqlClient.SqlConnection

    Public Sub open_conntion()
        If sqlconnt.State = 1 Then sqlconnt.Close()


        Try
            sqlconnt = New SqlConnection(My.Settings.sqlconnt1)
            sqlconnt.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub
    Public Function CODE_GENT(ID_) As Integer
        CODE_GENT = 0
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS ORDER BY  '" & ID_ & "' ", sqlconnt)
        DAT.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENT = Val(DT.Rows(I).Item(ID_))
        End If

    End Function

    Public Function CODE_GENT2(ID_) As Integer
        CODE_GENT2 = 0
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMERS ORDER BY  '" & ID_ & "' ", sqlconnt)
        DAT.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENT2 = Val(DT.Rows(I).Item(ID_))
        End If

    End Function
    Public Function CODE_GENT3(ID_) As Integer
        CODE_GENT3 = 0
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS ORDER BY  '" & ID_ & "' ", sqlconnt)
        DAT.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENT3 = Val(DT.Rows(I).Item(ID_))
        End If

    End Function
    Public Function CODE_GENT4(ID_) As Integer
        CODE_GENT4 = 0
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM UNIT ORDER BY  '" & ID_ & "' ", sqlconnt)
        DAT.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENT4 = Val(DT.Rows(I).Item(ID_))
        End If

    End Function
    Public Function CODE_GENT5(ID_) As Integer
        CODE_GENT5 = 0
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM PUYBILL ORDER BY  '" & ID_ & "' ", sqlconnt)
        DAT.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENT5 = Val(DT.Rows(I).Item(ID_))
        End If

    End Function
    Public Function CODE_GENT6(ID_) As Integer
        CODE_GENT6 = 0
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM SALEBILL ORDER BY  '" & ID_ & "' ", sqlconnt)
        DAT.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENT6 = Val(DT.Rows(I).Item(ID_))
        End If

    End Function
    Public Function CODE_GENT7(ID_) As Integer
        CODE_GENT7 = 0
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM ReSALEBILL ORDER BY  '" & ID_ & "' ", sqlconnt)
        DAT.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENT7 = Val(DT.Rows(I).Item(ID_))
        End If

    End Function
    Public Function CODE_GENT9(ID_) As Integer
        CODE_GENT9 = 0
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM RTPUYBILL ORDER BY  '" & ID_ & "' ", sqlconnt)
        DAT.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENT9 = Val(DT.Rows(I).Item(ID_))
        End If

    End Function

    Public Function CODE_GENT10(ID_) As Integer
        CODE_GENT10 = 0
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM SARF ORDER BY  '" & ID_ & "' ", sqlconnt)
        DAT.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENT10 = Val(DT.Rows(I).Item(ID_))
        End If

    End Function
    Public Function CODE_GENT11(ID_) As Integer
        CODE_GENT11 = 0
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM QABD ORDER BY  '" & ID_ & "' ", sqlconnt)
        DAT.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENT11 = Val(DT.Rows(I).Item(ID_))
        End If

    End Function

    Public Function OPER_CUSTEMUR(SALECODE, SALEDATE, CUS_CODE, CERDIT, DEBIT, DESCRIPTION, CUS_NAME) As Boolean
        Dim DTA As New SqlClient.SqlDataAdapter("Select * from DET_CUSTOMERS ", sqlconnt)
        Dim DASET As New DataSet
        DASET = New DataSet
        DTA.Fill(DASET)
        Dim DT_ = DASET.Tables(0)
        Dim DR_ = DT_.NewRow
        DR_!SALECODE = SALECODE
        DR_!SALEDATE = SALEDATE
        DR_!DESCRIPTION = DESCRIPTION
        DR_!DEBIT = DEBIT
        DR_!CERDIT = CERDIT
        DR_!CUS_NAME = CUS_NAME
        DR_!CUS_CODE = CUS_CODE
        DT_.Rows.Add(DR_)
        Dim SAVE_ As New SqlClient.SqlCommandBuilder(DTA)
        DTA.Update(DT_)

        OPER_CUSTEMUR = True
    End Function

    '***************تعبئة الداتا جريد فيو

    Public SHOW_FROM As String = ""
    Public Sub FILL_DGV(DGV As DataGridView, SQL As String)
        DGV.DataSource = ""
        Dim DT As New DataTable
        Dim DAT As New SqlClient.SqlDataAdapter(SQL, sqlconnt)
        DAT.Fill(DT)
        DGV.AutoGenerateColumns = False
        DGV.DataSource = DT.DefaultView

    End Sub
End Module
'  Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS ORDER BY ID", sqlconnt)