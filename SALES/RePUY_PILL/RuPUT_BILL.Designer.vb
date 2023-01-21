<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RuPUT_BILL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ReSALETYPE = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_BAR = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BUTTSEARCH = New System.Windows.Forms.Button()
        Me.ButtExit = New System.Windows.Forms.Button()
        Me.ButtNew = New System.Windows.Forms.Button()
        Me.ButtDelete = New System.Windows.Forms.Button()
        Me.ButtSave = New System.Windows.Forms.Button()
        Me.ButtEdite = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_SEARCH = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IMP_CODE = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RuIMPORTERS = New System.Windows.Forms.TextBox()
        Me.ReSALEUSER = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BUY_NOTES = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReSALEDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ReSALECODE = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLDEL = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TOTAL = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TOTALQTY = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DISCOUND = New System.Windows.Forms.TextBox()
        Me.TOTALARB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReSALETYPE
        '
        Me.ReSALETYPE.FormattingEnabled = True
        Me.ReSALETYPE.Items.AddRange(New Object() {"نقد", "اجل"})
        Me.ReSALETYPE.Location = New System.Drawing.Point(335, 75)
        Me.ReSALETYPE.Name = "ReSALETYPE"
        Me.ReSALETYPE.Size = New System.Drawing.Size(211, 29)
        Me.ReSALETYPE.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(398, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "نوع الفاتورة :"
        Me.Label1.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 21)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "الموظف :"
        Me.Label7.UseWaitCursor = True
        '
        'TXT_BAR
        '
        Me.TXT_BAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_BAR.Location = New System.Drawing.Point(412, 46)
        Me.TXT_BAR.Name = "TXT_BAR"
        Me.TXT_BAR.Size = New System.Drawing.Size(253, 29)
        Me.TXT_BAR.TabIndex = 40
        Me.TXT_BAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BUTTSEARCH)
        Me.GroupBox4.Controls.Add(Me.ButtExit)
        Me.GroupBox4.Controls.Add(Me.ButtNew)
        Me.GroupBox4.Controls.Add(Me.ButtDelete)
        Me.GroupBox4.Controls.Add(Me.ButtSave)
        Me.GroupBox4.Controls.Add(Me.ButtEdite)
        Me.GroupBox4.Location = New System.Drawing.Point(64, 467)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(734, 56)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.UseWaitCursor = True
        '
        'BUTTSEARCH
        '
        Me.BUTTSEARCH.Location = New System.Drawing.Point(5, 13)
        Me.BUTTSEARCH.Name = "BUTTSEARCH"
        Me.BUTTSEARCH.Size = New System.Drawing.Size(117, 37)
        Me.BUTTSEARCH.TabIndex = 5
        Me.BUTTSEARCH.Text = "البحث"
        Me.BUTTSEARCH.UseVisualStyleBackColor = True
        Me.BUTTSEARCH.UseWaitCursor = True
        '
        'ButtExit
        '
        Me.ButtExit.Location = New System.Drawing.Point(128, 13)
        Me.ButtExit.Name = "ButtExit"
        Me.ButtExit.Size = New System.Drawing.Size(117, 37)
        Me.ButtExit.TabIndex = 4
        Me.ButtExit.Text = "رجوع"
        Me.ButtExit.UseVisualStyleBackColor = True
        Me.ButtExit.UseWaitCursor = True
        '
        'ButtNew
        '
        Me.ButtNew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtNew.Location = New System.Drawing.Point(612, 13)
        Me.ButtNew.Name = "ButtNew"
        Me.ButtNew.Size = New System.Drawing.Size(117, 37)
        Me.ButtNew.TabIndex = 0
        Me.ButtNew.Text = "جديد"
        Me.ButtNew.UseVisualStyleBackColor = True
        Me.ButtNew.UseWaitCursor = True
        '
        'ButtDelete
        '
        Me.ButtDelete.Location = New System.Drawing.Point(251, 13)
        Me.ButtDelete.Name = "ButtDelete"
        Me.ButtDelete.Size = New System.Drawing.Size(117, 37)
        Me.ButtDelete.TabIndex = 3
        Me.ButtDelete.Text = "حذف"
        Me.ButtDelete.UseVisualStyleBackColor = True
        Me.ButtDelete.UseWaitCursor = True
        '
        'ButtSave
        '
        Me.ButtSave.Location = New System.Drawing.Point(493, 13)
        Me.ButtSave.Name = "ButtSave"
        Me.ButtSave.Size = New System.Drawing.Size(117, 37)
        Me.ButtSave.TabIndex = 1
        Me.ButtSave.Text = "حفظ"
        Me.ButtSave.UseVisualStyleBackColor = True
        Me.ButtSave.UseWaitCursor = True
        '
        'ButtEdite
        '
        Me.ButtEdite.Location = New System.Drawing.Point(370, 13)
        Me.ButtEdite.Name = "ButtEdite"
        Me.ButtEdite.Size = New System.Drawing.Size(117, 37)
        Me.ButtEdite.TabIndex = 2
        Me.ButtEdite.Text = "تعديل"
        Me.ButtEdite.UseVisualStyleBackColor = True
        Me.ButtEdite.UseWaitCursor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(500, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 21)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "الباركود :"
        Me.Label10.UseWaitCursor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.TXT_SEARCH)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.TXT_BAR)
        Me.GroupBox5.Location = New System.Drawing.Point(22, 163)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox5.Size = New System.Drawing.Size(770, 93)
        Me.GroupBox5.TabIndex = 49
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "طرق الإدخال :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(154, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 21)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "البحث السريع"
        Me.Label11.UseWaitCursor = True
        '
        'TXT_SEARCH
        '
        Me.TXT_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_SEARCH.Location = New System.Drawing.Point(66, 46)
        Me.TXT_SEARCH.Name = "TXT_SEARCH"
        Me.TXT_SEARCH.Size = New System.Drawing.Size(253, 29)
        Me.TXT_SEARCH.TabIndex = 42
        Me.TXT_SEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IMP_CODE)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.RuIMPORTERS)
        Me.GroupBox2.Controls.Add(Me.ReSALETYPE)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ReSALEUSER)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.BUY_NOTES)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ReSALEDATE)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ReSALECODE)
        Me.GroupBox2.Location = New System.Drawing.Point(-1, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(860, 154)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "البيانات الأساسية :"
        '
        'IMP_CODE
        '
        Me.IMP_CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMP_CODE.Location = New System.Drawing.Point(274, 13)
        Me.IMP_CODE.Name = "IMP_CODE"
        Me.IMP_CODE.Size = New System.Drawing.Size(211, 29)
        Me.IMP_CODE.TabIndex = 45
        Me.IMP_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IMP_CODE.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 29)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.UseWaitCursor = True
        '
        'RuIMPORTERS
        '
        Me.RuIMPORTERS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RuIMPORTERS.Location = New System.Drawing.Point(42, 39)
        Me.RuIMPORTERS.Name = "RuIMPORTERS"
        Me.RuIMPORTERS.Size = New System.Drawing.Size(181, 29)
        Me.RuIMPORTERS.TabIndex = 44
        Me.RuIMPORTERS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ReSALEUSER
        '
        Me.ReSALEUSER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReSALEUSER.Location = New System.Drawing.Point(12, 82)
        Me.ReSALEUSER.Name = "ReSALEUSER"
        Me.ReSALEUSER.Size = New System.Drawing.Size(211, 29)
        Me.ReSALEUSER.TabIndex = 36
        Me.ReSALEUSER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(753, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 21)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "الملاحظة :"
        Me.Label6.UseWaitCursor = True
        '
        'BUY_NOTES
        '
        Me.BUY_NOTES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BUY_NOTES.Location = New System.Drawing.Point(12, 118)
        Me.BUY_NOTES.Name = "BUY_NOTES"
        Me.BUY_NOTES.Size = New System.Drawing.Size(735, 29)
        Me.BUY_NOTES.TabIndex = 34
        Me.BUY_NOTES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 21)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "الموردين :"
        Me.Label3.UseWaitCursor = True
        '
        'ReSALEDATE
        '
        Me.ReSALEDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReSALEDATE.Location = New System.Drawing.Point(583, 83)
        Me.ReSALEDATE.Name = "ReSALEDATE"
        Me.ReSALEDATE.Size = New System.Drawing.Size(165, 29)
        Me.ReSALEDATE.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(751, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "تاريخ الفاتورة :"
        Me.Label4.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(755, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 21)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "رقم الفاتورة :"
        Me.Label5.UseWaitCursor = True
        '
        'ReSALECODE
        '
        Me.ReSALECODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReSALECODE.Location = New System.Drawing.Point(585, 46)
        Me.ReSALECODE.Name = "ReSALECODE"
        Me.ReSALECODE.Size = New System.Drawing.Size(164, 29)
        Me.ReSALECODE.TabIndex = 28
        Me.ReSALECODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(847, 203)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "تفاصيل البضاعة"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(802, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 173)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.UseWaitCursor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.DataGridViewTextBoxColumn1, Me.COLDEL})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(784, 172)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ITEM_CODE"
        Me.Column1.FillWeight = 98.58479!
        Me.Column1.HeaderText = "رقم الصنف"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ITEM_NAME"
        Me.Column2.FillWeight = 98.86273!
        Me.Column2.HeaderText = "اسم الصنف"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "ITEM_UNIT"
        Me.Column3.FillWeight = 98.95088!
        Me.Column3.HeaderText = "الوحدة"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ITEM_TKLFA"
        Me.Column4.FillWeight = 99.96048!
        Me.Column4.HeaderText = "التكلفة"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.FillWeight = 98.97369!
        Me.Column5.HeaderText = "الكمية "
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column6
        '
        Me.Column6.FillWeight = 98.93312!
        Me.Column6.HeaderText = "الخصم"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.FillWeight = 98.88581!
        Me.Column7.HeaderText = "الإحمالي"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "QTY"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column8.HeaderText = "الكمية المخزن"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "الصلاحية"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'COLDEL
        '
        Me.COLDEL.DataPropertyName = "ITEM_EXPIRE"
        Me.COLDEL.HeaderText = "_"
        Me.COLDEL.Name = "COLDEL"
        Me.COLDEL.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COLDEL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TOTAL
        '
        Me.TOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TOTAL.Location = New System.Drawing.Point(621, 37)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(135, 29)
        Me.TOTAL.TabIndex = 40
        Me.TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TOTALQTY)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DISCOUND)
        Me.GroupBox1.Controls.Add(Me.TOTALARB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TOTAL)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 519)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(843, 111)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تفاصيل الفاتورة"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(510, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 21)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "اجمالي الكمية :"
        Me.Label9.UseWaitCursor = True
        '
        'TOTALQTY
        '
        Me.TOTALQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TOTALQTY.Location = New System.Drawing.Point(371, 81)
        Me.TOTALQTY.Name = "TOTALQTY"
        Me.TOTALQTY.Size = New System.Drawing.Size(135, 29)
        Me.TOTALQTY.TabIndex = 45
        Me.TOTALQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(762, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 21)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "الخصم :"
        Me.Label8.UseWaitCursor = True
        '
        'DISCOUND
        '
        Me.DISCOUND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DISCOUND.Location = New System.Drawing.Point(621, 77)
        Me.DISCOUND.Name = "DISCOUND"
        Me.DISCOUND.Size = New System.Drawing.Size(135, 29)
        Me.DISCOUND.TabIndex = 43
        Me.DISCOUND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TOTALARB
        '
        Me.TOTALARB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TOTALARB.Location = New System.Drawing.Point(32, 36)
        Me.TOTALARB.Name = "TOTALARB"
        Me.TOTALARB.Size = New System.Drawing.Size(583, 29)
        Me.TOTALARB.TabIndex = 42
        Me.TOTALARB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(762, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "الأجمالي :"
        Me.Label2.UseWaitCursor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10, Me.Column12, Me.Column11})
        Me.DataGridView2.Location = New System.Drawing.Point(193, 255)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(473, 151)
        Me.DataGridView2.TabIndex = 51
        '
        'Column9
        '
        Me.Column9.HeaderText = "اختيار"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "ITEM_NAME"
        Me.Column10.HeaderText = "اسم الصنف"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "ITEM_BAR"
        Me.Column12.HeaderText = "الباركود"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "ITEM_PRICE"
        Me.Column11.HeaderText = "سعر الصنف"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'RuPUT_BILL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 661)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RuPUT_BILL"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RuPUT_BILL"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReSALETYPE As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_BAR As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BUTTSEARCH As Button
    Friend WithEvents ButtExit As Button
    Friend WithEvents ButtNew As Button
    Friend WithEvents ButtDelete As Button
    Friend WithEvents ButtSave As Button
    Friend WithEvents ButtEdite As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_SEARCH As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ReSALEUSER As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BUY_NOTES As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ReSALEDATE As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ReSALECODE As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TOTAL As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TOTALQTY As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DISCOUND As TextBox
    Friend WithEvents TOTALARB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column9 As DataGridViewButtonColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents COLDEL As DataGridViewButtonColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents RuIMPORTERS As TextBox
    Friend WithEvents IMP_CODE As TextBox
End Class
