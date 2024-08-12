<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class memo_create
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(memo_create))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_offensecount = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lbl_class = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_violation = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_section = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_idno = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.txt_idno)
        Me.Guna2Panel1.Controls.Add(Me.lbl_error)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Controls.Add(Me.lbl_offensecount)
        Me.Guna2Panel1.Controls.Add(Me.Label12)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.dtpicker)
        Me.Guna2Panel1.Controls.Add(Me.lbl_class)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.cmb_violation)
        Me.Guna2Panel1.Controls.Add(Me.lbl_position)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.lbl_section)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.lbl_fullname)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(169, 68)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1058, 675)
        Me.Guna2Panel1.TabIndex = 0
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.BackColor = System.Drawing.Color.White
        Me.lbl_error.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error.Location = New System.Drawing.Point(419, 511)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(187, 20)
        Me.lbl_error.TabIndex = 35
        Me.lbl_error.Text = "Please Complete the Form!"
        Me.lbl_error.Visible = False
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(448, 534)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(134, 56)
        Me.Guna2Button2.TabIndex = 34
        Me.Guna2Button2.Text = "Save Report"
        '
        'lbl_offensecount
        '
        Me.lbl_offensecount.AutoSize = True
        Me.lbl_offensecount.BackColor = System.Drawing.Color.White
        Me.lbl_offensecount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_offensecount.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_offensecount.Location = New System.Drawing.Point(256, 295)
        Me.lbl_offensecount.Name = "lbl_offensecount"
        Me.lbl_offensecount.Size = New System.Drawing.Size(27, 20)
        Me.lbl_offensecount.TabIndex = 33
        Me.lbl_offensecount.Text = "---"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(140, 295)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 20)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Offense Count :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(140, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Date :"
        '
        'dtpicker
        '
        Me.dtpicker.Checked = True
        Me.dtpicker.FillColor = System.Drawing.SystemColors.HotTrack
        Me.dtpicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker.ForeColor = System.Drawing.Color.White
        Me.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker.Location = New System.Drawing.Point(199, 335)
        Me.dtpicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker.Name = "dtpicker"
        Me.dtpicker.Size = New System.Drawing.Size(246, 43)
        Me.dtpicker.TabIndex = 30
        Me.dtpicker.Value = New Date(2024, 8, 8, 15, 45, 18, 704)
        '
        'lbl_class
        '
        Me.lbl_class.AutoSize = True
        Me.lbl_class.BackColor = System.Drawing.Color.White
        Me.lbl_class.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_class.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_class.Location = New System.Drawing.Point(195, 263)
        Me.lbl_class.Name = "lbl_class"
        Me.lbl_class.Size = New System.Drawing.Size(27, 20)
        Me.lbl_class.TabIndex = 29
        Me.lbl_class.Text = "---"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(140, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Class :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(113, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Violation :"
        '
        'cmb_violation
        '
        Me.cmb_violation.BackColor = System.Drawing.Color.Transparent
        Me.cmb_violation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_violation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_violation.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_violation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_violation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_violation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_violation.ItemHeight = 30
        Me.cmb_violation.Location = New System.Drawing.Point(199, 208)
        Me.cmb_violation.Name = "cmb_violation"
        Me.cmb_violation.Size = New System.Drawing.Size(609, 36)
        Me.cmb_violation.TabIndex = 26
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.BackColor = System.Drawing.Color.White
        Me.lbl_position.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_position.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_position.Location = New System.Drawing.Point(108, 150)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(27, 20)
        Me.lbl_position.TabIndex = 25
        Me.lbl_position.Text = "---"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(34, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Position :"
        '
        'lbl_section
        '
        Me.lbl_section.AutoSize = True
        Me.lbl_section.BackColor = System.Drawing.Color.White
        Me.lbl_section.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_section.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_section.Location = New System.Drawing.Point(195, 130)
        Me.lbl_section.Name = "lbl_section"
        Me.lbl_section.Size = New System.Drawing.Size(27, 20)
        Me.lbl_section.TabIndex = 23
        Me.lbl_section.Text = "---"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(34, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Department/ Section :"
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.BackColor = System.Drawing.Color.White
        Me.lbl_fullname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fullname.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_fullname.Location = New System.Drawing.Point(116, 110)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(27, 20)
        Me.lbl_fullname.TabIndex = 21
        Me.lbl_fullname.Text = "---"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(34, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fullname :"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(38, 70)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(971, 14)
        Me.Guna2Separator1.TabIndex = 18
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.Location = New System.Drawing.Point(38, 23)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(105, 41)
        Me.Guna2Button1.TabIndex = 17
        Me.Guna2Button1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(34, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID no :"
        '
        'txt_idno
        '
        Me.txt_idno.AutoSize = True
        Me.txt_idno.BackColor = System.Drawing.Color.White
        Me.txt_idno.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idno.ForeColor = System.Drawing.Color.DimGray
        Me.txt_idno.Location = New System.Drawing.Point(89, 90)
        Me.txt_idno.Name = "txt_idno"
        Me.txt_idno.Size = New System.Drawing.Size(27, 20)
        Me.txt_idno.TabIndex = 36
        Me.txt_idno.Text = "---"
        '
        'memo_create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1396, 843)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "memo_create"
        Me.Text = "memo_create"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_position As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_section As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_fullname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_offensecount As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lbl_class As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_violation As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_error As Label
    Friend WithEvents txt_idno As Label
End Class
