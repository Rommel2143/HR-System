<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sub_FRAME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sub_FRAME))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReviewAndApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.userstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuggestToImproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviceInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRCheckerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AnalyticsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterlistToolStripMenuItem, Me.userstrip, Me.QRCheckerToolStripMenuItem, Me.ManageToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1208, 41)
        Me.MenuStrip1.TabIndex = 11
        '
        'MasterlistToolStripMenuItem
        '
        Me.MasterlistToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateReportToolStripMenuItem, Me.ReviewAndApprovalToolStripMenuItem, Me.ViewRecordsToolStripMenuItem, Me.AnalyticsToolStripMenuItem1})
        Me.MasterlistToolStripMenuItem.Image = CType(resources.GetObject("MasterlistToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MasterlistToolStripMenuItem.Name = "MasterlistToolStripMenuItem"
        Me.MasterlistToolStripMenuItem.Size = New System.Drawing.Size(85, 37)
        Me.MasterlistToolStripMenuItem.Text = "MEMO"
        '
        'CreateReportToolStripMenuItem
        '
        Me.CreateReportToolStripMenuItem.Name = "CreateReportToolStripMenuItem"
        Me.CreateReportToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.CreateReportToolStripMenuItem.Text = "Create Report"
        '
        'ReviewAndApprovalToolStripMenuItem
        '
        Me.ReviewAndApprovalToolStripMenuItem.Name = "ReviewAndApprovalToolStripMenuItem"
        Me.ReviewAndApprovalToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ReviewAndApprovalToolStripMenuItem.Text = "Review and Approval"
        '
        'ViewRecordsToolStripMenuItem
        '
        Me.ViewRecordsToolStripMenuItem.Name = "ViewRecordsToolStripMenuItem"
        Me.ViewRecordsToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ViewRecordsToolStripMenuItem.Text = "View Records"
        '
        'userstrip
        '
        Me.userstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.userstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem, Me.SuggestToImproveToolStripMenuItem, Me.DeviceInfoToolStripMenuItem})
        Me.userstrip.Image = CType(resources.GetObject("userstrip.Image"), System.Drawing.Image)
        Me.userstrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.userstrip.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.userstrip.Name = "userstrip"
        Me.userstrip.Size = New System.Drawing.Size(83, 37)
        Me.userstrip.Text = "User"
        Me.userstrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SuggestToImproveToolStripMenuItem
        '
        Me.SuggestToImproveToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SuggestToImproveToolStripMenuItem.Image = CType(resources.GetObject("SuggestToImproveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SuggestToImproveToolStripMenuItem.Name = "SuggestToImproveToolStripMenuItem"
        Me.SuggestToImproveToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SuggestToImproveToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.SuggestToImproveToolStripMenuItem.Text = "Suggest to improve"
        '
        'DeviceInfoToolStripMenuItem
        '
        Me.DeviceInfoToolStripMenuItem.Image = CType(resources.GetObject("DeviceInfoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeviceInfoToolStripMenuItem.Name = "DeviceInfoToolStripMenuItem"
        Me.DeviceInfoToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DeviceInfoToolStripMenuItem.Text = "Device info."
        '
        'QRCheckerToolStripMenuItem
        '
        Me.QRCheckerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeProfileToolStripMenuItem})
        Me.QRCheckerToolStripMenuItem.Image = CType(resources.GetObject("QRCheckerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QRCheckerToolStripMenuItem.Name = "QRCheckerToolStripMenuItem"
        Me.QRCheckerToolStripMenuItem.Size = New System.Drawing.Size(115, 37)
        Me.QRCheckerToolStripMenuItem.Text = "Monitoring"
        '
        'EmployeeProfileToolStripMenuItem
        '
        Me.EmployeeProfileToolStripMenuItem.Name = "EmployeeProfileToolStripMenuItem"
        Me.EmployeeProfileToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.EmployeeProfileToolStripMenuItem.Text = "Employee Profile"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.Image = CType(resources.GetObject("ManageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(99, 37)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1208, 636)
        Me.Panel1.TabIndex = 12
        '
        'AnalyticsToolStripMenuItem1
        '
        Me.AnalyticsToolStripMenuItem1.Name = "AnalyticsToolStripMenuItem1"
        Me.AnalyticsToolStripMenuItem1.Size = New System.Drawing.Size(234, 22)
        Me.AnalyticsToolStripMenuItem1.Text = "Analytics"
        '
        'sub_FRAME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 677)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sub_FRAME"
        Me.Text = "Scan_Frame"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents userstrip As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuggestToImproveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DeviceInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRCheckerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReviewAndApprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnalyticsToolStripMenuItem1 As ToolStripMenuItem
End Class
