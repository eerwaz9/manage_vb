<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUPLIER
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
        Me.ButtEdite = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTMINS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CERDIT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DEBIT = New System.Windows.Forms.TextBox()
        Me.BUTTSEARCH = New System.Windows.Forms.Button()
        Me.ButtExit = New System.Windows.Forms.Button()
        Me.ButtNew = New System.Windows.Forms.Button()
        Me.ButtDelete = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_NOTES = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_COMPANY = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTPHONE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_ADDRESS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtEdite
        '
        Me.ButtEdite.Location = New System.Drawing.Point(382, 13)
        Me.ButtEdite.Name = "ButtEdite"
        Me.ButtEdite.Size = New System.Drawing.Size(117, 37)
        Me.ButtEdite.TabIndex = 2
        Me.ButtEdite.Text = "تعديل"
        Me.ButtEdite.UseVisualStyleBackColor = True
        Me.ButtEdite.UseWaitCursor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TXTMINS)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CERDIT)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DEBIT)
        Me.GroupBox2.Location = New System.Drawing.Point(62, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(888, 71)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "حركة الحساب :"
        Me.GroupBox2.UseWaitCursor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(253, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "الفرق :"
        Me.Label9.UseWaitCursor = True
        '
        'TXTMINS
        '
        Me.TXTMINS.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TXTMINS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTMINS.Enabled = False
        Me.TXTMINS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXTMINS.Location = New System.Drawing.Point(79, 28)
        Me.TXTMINS.Name = "TXTMINS"
        Me.TXTMINS.ReadOnly = True
        Me.TXTMINS.Size = New System.Drawing.Size(168, 29)
        Me.TXTMINS.TabIndex = 14
        Me.TXTMINS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTMINS.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(525, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "المدين :"
        Me.Label8.UseWaitCursor = True
        '
        'CERDIT
        '
        Me.CERDIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CERDIT.ForeColor = System.Drawing.Color.Red
        Me.CERDIT.Location = New System.Drawing.Point(351, 28)
        Me.CERDIT.Name = "CERDIT"
        Me.CERDIT.Size = New System.Drawing.Size(168, 29)
        Me.CERDIT.TabIndex = 12
        Me.CERDIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CERDIT.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(792, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "الدئن :"
        Me.Label7.UseWaitCursor = True
        '
        'DEBIT
        '
        Me.DEBIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DEBIT.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.DEBIT.Location = New System.Drawing.Point(618, 28)
        Me.DEBIT.Name = "DEBIT"
        Me.DEBIT.Size = New System.Drawing.Size(168, 29)
        Me.DEBIT.TabIndex = 10
        Me.DEBIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DEBIT.UseWaitCursor = True
        '
        'BUTTSEARCH
        '
        Me.BUTTSEARCH.Location = New System.Drawing.Point(17, 13)
        Me.BUTTSEARCH.Name = "BUTTSEARCH"
        Me.BUTTSEARCH.Size = New System.Drawing.Size(117, 37)
        Me.BUTTSEARCH.TabIndex = 5
        Me.BUTTSEARCH.Text = "البحث"
        Me.BUTTSEARCH.UseVisualStyleBackColor = True
        Me.BUTTSEARCH.UseWaitCursor = True
        '
        'ButtExit
        '
        Me.ButtExit.Location = New System.Drawing.Point(140, 13)
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
        Me.ButtNew.Location = New System.Drawing.Point(624, 13)
        Me.ButtNew.Name = "ButtNew"
        Me.ButtNew.Size = New System.Drawing.Size(117, 37)
        Me.ButtNew.TabIndex = 0
        Me.ButtNew.Text = "جديد"
        Me.ButtNew.UseVisualStyleBackColor = True
        Me.ButtNew.UseWaitCursor = True
        '
        'ButtDelete
        '
        Me.ButtDelete.Location = New System.Drawing.Point(263, 13)
        Me.ButtDelete.Name = "ButtDelete"
        Me.ButtDelete.Size = New System.Drawing.Size(117, 37)
        Me.ButtDelete.TabIndex = 3
        Me.ButtDelete.Text = "حذف"
        Me.ButtDelete.UseVisualStyleBackColor = True
        Me.ButtDelete.UseWaitCursor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BUTTSEARCH)
        Me.GroupBox3.Controls.Add(Me.ButtExit)
        Me.GroupBox3.Controls.Add(Me.ButtNew)
        Me.GroupBox3.Controls.Add(Me.ButtDelete)
        Me.GroupBox3.Controls.Add(Me.ButtSave)
        Me.GroupBox3.Controls.Add(Me.ButtEdite)
        Me.GroupBox3.Location = New System.Drawing.Point(132, 341)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(755, 81)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.UseWaitCursor = True
        '
        'ButtSave
        '
        Me.ButtSave.Location = New System.Drawing.Point(505, 13)
        Me.ButtSave.Name = "ButtSave"
        Me.ButtSave.Size = New System.Drawing.Size(117, 37)
        Me.ButtSave.TabIndex = 1
        Me.ButtSave.Text = "حفظ"
        Me.ButtSave.UseVisualStyleBackColor = True
        Me.ButtSave.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "الملأحظات :"
        Me.Label6.UseWaitCursor = True
        '
        'TXT_NOTES
        '
        Me.TXT_NOTES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTES.Location = New System.Drawing.Point(11, 133)
        Me.TXT_NOTES.Multiline = True
        Me.TXT_NOTES.Name = "TXT_NOTES"
        Me.TXT_NOTES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_NOTES.Size = New System.Drawing.Size(351, 76)
        Me.TXT_NOTES.TabIndex = 10
        Me.TXT_NOTES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_NOTES.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(863, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "اسم الشركة :"
        Me.Label5.UseWaitCursor = True
        '
        'TXT_COMPANY
        '
        Me.TXT_COMPANY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_COMPANY.Location = New System.Drawing.Point(534, 158)
        Me.TXT_COMPANY.Name = "TXT_COMPANY"
        Me.TXT_COMPANY.Size = New System.Drawing.Size(323, 29)
        Me.TXT_COMPANY.TabIndex = 8
        Me.TXT_COMPANY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_COMPANY.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(368, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "رقم الهاتف :"
        Me.Label4.UseWaitCursor = True
        '
        'TXTPHONE
        '
        Me.TXTPHONE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPHONE.Location = New System.Drawing.Point(11, 83)
        Me.TXTPHONE.Name = "TXTPHONE"
        Me.TXTPHONE.Size = New System.Drawing.Size(351, 29)
        Me.TXTPHONE.TabIndex = 6
        Me.TXTPHONE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTPHONE.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(534, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "اسم المورد :"
        Me.Label3.UseWaitCursor = True
        '
        'TXT_NAME
        '
        Me.TXT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NAME.Location = New System.Drawing.Point(11, 28)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(517, 29)
        Me.TXT_NAME.TabIndex = 4
        Me.TXT_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_NAME.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(863, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "عنوان المورد :"
        Me.Label2.UseWaitCursor = True
        '
        'TXT_ADDRESS
        '
        Me.TXT_ADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_ADDRESS.Location = New System.Drawing.Point(534, 98)
        Me.TXT_ADDRESS.Name = "TXT_ADDRESS"
        Me.TXT_ADDRESS.Size = New System.Drawing.Size(323, 29)
        Me.TXT_ADDRESS.TabIndex = 2
        Me.TXT_ADDRESS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ADDRESS.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(863, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "رقم المورد :"
        Me.Label1.UseWaitCursor = True
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CODE.Location = New System.Drawing.Point(693, 28)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(164, 29)
        Me.TXT_CODE.TabIndex = 0
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_NOTES)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_COMPANY)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTPHONE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_ADDRESS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(957, 323)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات الأساسية"
        '
        'SUPLIER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 486)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SUPLIER"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة الموردين"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtEdite As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTMINS As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CERDIT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DEBIT As TextBox
    Friend WithEvents BUTTSEARCH As Button
    Friend WithEvents ButtExit As Button
    Friend WithEvents ButtNew As Button
    Friend WithEvents ButtDelete As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtSave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_NOTES As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_COMPANY As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTPHONE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_ADDRESS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
