Imports System
Public Class sub_FRAME

    Private Sub Scan_Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userstrip.Text = fname
    End Sub


    Private Sub display_formsub(form As Form)

        With form
            .Refresh()
            .TopLevel = False
            Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        con.Close()
        Application.Exit()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        display_form(Login)
        Login.txtbarcode.Clear()
    End Sub

    Private Sub DeviceInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeviceInfoToolStripMenuItem.Click
        MessageBox.Show("Device loc:" & PClocation & "   /  Mac:" & PCmac & "   /  Device:" & PCname & "", "This Device is Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SuggestToImproveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuggestToImproveToolStripMenuItem.Click
        suggest_improvent.Show()
        suggest_improvent.BringToFront()
    End Sub

    Private Sub EmployeeProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeProfileToolStripMenuItem.Click
        display_formsub(employee_profile)
    End Sub

    Private Sub PoliciesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageToolStripMenuItem.Click
        display_formsub(policies_add)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CreateReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateReportToolStripMenuItem.Click
        display_formsub(memo_create)
    End Sub

    Private Sub ViewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRecordsToolStripMenuItem.Click
        display_formsub(memo_view)
    End Sub

    Private Sub ReviewAndApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReviewAndApprovalToolStripMenuItem.Click
        display_formsub(memo_approval)
    End Sub

    Private Sub AnalyticsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnalyticsToolStripMenuItem1.Click
        display_formsub(memo_analytics)
    End Sub
End Class