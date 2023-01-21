<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SARF
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
        Me.SA_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SA_CODE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ARABIC = New System.Windows.Forms.TextBox()
        Me.IMP_NAME = New System.Windows.Forms.TextBox()
        Me.NOTE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MONY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IMP_CODE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BUTTSEARCH = New System.Windows.Forms.Button()
        Me.ButtExit = New System.Windows.Forms.Button()
        Me.ButtNew = New System.Windows.Forms.Button()
        Me.ButtDelete = New System.Windows.Forms.Button()
        Me.ButtSave = New System.Windows.Forms.Button()
        Me.ButtEdite = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SA_DATE
        '
        Me.SA_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SA_DATE.Location = New System.Drawing.Point(109, 44)
        Me.SA_DATE.Name = "SA_DATE"
        Me.SA_DATE.Size = New System.Drawing.Size(178, 29)
        Me.SA_DATE.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "تاريخ السند :"
        Me.Label4.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(641, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 21)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "رقم السند  :"
        Me.Label5.UseWaitCursor = True
        '
        'SA_CODE
        '
        Me.SA_CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SA_CODE.Location = New System.Drawing.Point(452, 45)
        Me.SA_CODE.Name = "SA_CODE"
        Me.SA_CODE.Size = New System.Drawing.Size(183, 29)
        Me.SA_CODE.TabIndex = 32
        Me.SA_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ARABIC)
        Me.GroupBox1.Controls.Add(Me.IMP_NAME)
        Me.GroupBox1.Controls.Add(Me.NOTE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MONY)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.IMP_CODE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SA_CODE)
        Me.GroupBox1.Controls.Add(Me.SA_DATE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 341)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات الأساسية"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(110, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 29)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.UseWaitCursor = True
        '
        'ARABIC
        '
        Me.ARABIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ARABIC.Location = New System.Drawing.Point(109, 179)
        Me.ARABIC.Name = "ARABIC"
        Me.ARABIC.Size = New System.Drawing.Size(372, 29)
        Me.ARABIC.TabIndex = 43
        Me.ARABIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IMP_NAME
        '
        Me.IMP_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMP_NAME.Location = New System.Drawing.Point(150, 134)
        Me.IMP_NAME.Name = "IMP_NAME"
        Me.IMP_NAME.Size = New System.Drawing.Size(331, 29)
        Me.IMP_NAME.TabIndex = 42
        Me.IMP_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NOTE
        '
        Me.NOTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NOTE.Location = New System.Drawing.Point(92, 216)
        Me.NOTE.Multiline = True
        Me.NOTE.Name = "NOTE"
        Me.NOTE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.NOTE.Size = New System.Drawing.Size(559, 116)
        Me.NOTE.TabIndex = 40
        Me.NOTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(657, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "الملأحظة  :"
        Me.Label3.UseWaitCursor = True
        '
        'MONY
        '
        Me.MONY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MONY.Location = New System.Drawing.Point(487, 178)
        Me.MONY.Name = "MONY"
        Me.MONY.Size = New System.Drawing.Size(164, 29)
        Me.MONY.TabIndex = 38
        Me.MONY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(657, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "المبلغ :"
        Me.Label2.UseWaitCursor = True
        '
        'IMP_CODE
        '
        Me.IMP_CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMP_CODE.Location = New System.Drawing.Point(487, 135)
        Me.IMP_CODE.Name = "IMP_CODE"
        Me.IMP_CODE.Size = New System.Drawing.Size(164, 29)
        Me.IMP_CODE.TabIndex = 36
        Me.IMP_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(657, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "المورد  :"
        Me.Label1.UseWaitCursor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BUTTSEARCH)
        Me.GroupBox4.Controls.Add(Me.ButtExit)
        Me.GroupBox4.Controls.Add(Me.ButtNew)
        Me.GroupBox4.Controls.Add(Me.ButtDelete)
        Me.GroupBox4.Controls.Add(Me.ButtSave)
        Me.GroupBox4.Controls.Add(Me.ButtEdite)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 365)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(734, 56)
        Me.GroupBox4.TabIndex = 37
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'SARF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 430)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SARF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "سند صرف"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SA_DATE As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SA_CODE As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ARABIC As TextBox
    Friend WithEvents IMP_NAME As TextBox
    Friend WithEvents NOTE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MONY As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IMP_CODE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BUTTSEARCH As Button
    Friend WithEvents ButtExit As Button
    Friend WithEvents ButtNew As Button
    Friend WithEvents ButtDelete As Button
    Friend WithEvents ButtSave As Button
    Friend WithEvents ButtEdite As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
End Class
