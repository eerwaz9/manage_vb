<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class unit_add
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BUTNEW = New System.Windows.Forms.Button()
        Me.BUTSAVE = New System.Windows.Forms.Button()
        Me.BUTEDIT = New System.Windows.Forms.Button()
        Me.BUTDELETE = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BUTNEW)
        Me.GroupBox1.Controls.Add(Me.BUTSAVE)
        Me.GroupBox1.Controls.Add(Me.BUTEDIT)
        Me.GroupBox1.Controls.Add(Me.BUTDELETE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 353)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "الوحدة:"
        '
        'BUTNEW
        '
        Me.BUTNEW.Location = New System.Drawing.Point(234, 17)
        Me.BUTNEW.Name = "BUTNEW"
        Me.BUTNEW.Size = New System.Drawing.Size(117, 37)
        Me.BUTNEW.TabIndex = 21
        Me.BUTNEW.Text = "جديد"
        Me.BUTNEW.UseVisualStyleBackColor = True
        Me.BUTNEW.UseWaitCursor = True
        '
        'BUTSAVE
        '
        Me.BUTSAVE.Location = New System.Drawing.Point(234, 59)
        Me.BUTSAVE.Name = "BUTSAVE"
        Me.BUTSAVE.Size = New System.Drawing.Size(117, 37)
        Me.BUTSAVE.TabIndex = 20
        Me.BUTSAVE.Text = "حفظ"
        Me.BUTSAVE.UseVisualStyleBackColor = True
        Me.BUTSAVE.UseWaitCursor = True
        '
        'BUTEDIT
        '
        Me.BUTEDIT.Location = New System.Drawing.Point(111, 17)
        Me.BUTEDIT.Name = "BUTEDIT"
        Me.BUTEDIT.Size = New System.Drawing.Size(117, 37)
        Me.BUTEDIT.TabIndex = 19
        Me.BUTEDIT.Text = "تعديل"
        Me.BUTEDIT.UseVisualStyleBackColor = True
        Me.BUTEDIT.UseWaitCursor = True
        '
        'BUTDELETE
        '
        Me.BUTDELETE.Location = New System.Drawing.Point(111, 60)
        Me.BUTDELETE.Name = "BUTDELETE"
        Me.BUTDELETE.Size = New System.Drawing.Size(117, 37)
        Me.BUTDELETE.TabIndex = 18
        Me.BUTDELETE.Text = "حذف"
        Me.BUTDELETE.UseVisualStyleBackColor = True
        Me.BUTDELETE.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(544, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "اسم الوحدة :"
        Me.Label2.UseWaitCursor = True
        '
        'TXT_NAME
        '
        Me.TXT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NAME.Location = New System.Drawing.Point(374, 67)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(164, 29)
        Me.TXT_NAME.TabIndex = 16
        Me.TXT_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(544, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "رقم الوحدة :"
        Me.Label1.UseWaitCursor = True
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODE.Location = New System.Drawing.Point(374, 28)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(164, 29)
        Me.TXT_CODE.TabIndex = 14
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView2.Location = New System.Drawing.Point(5, 102)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(632, 240)
        Me.DataGridView2.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "اختر"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "UNIT_NAME"
        Me.Column2.HeaderText = "اسم الوحدة"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "التفاصيل"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "UNIT_CODE"
        Me.Column4.HeaderText = "رقم الوحدة"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'unit_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 359)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "unit_add"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الوحدات"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents BUTNEW As Button
    Friend WithEvents BUTSAVE As Button
    Friend WithEvents BUTEDIT As Button
    Friend WithEvents BUTDELETE As Button
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
