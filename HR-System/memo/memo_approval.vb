Imports MySql.Data.MySqlClient
Public Class memo_approval
    Dim idnumber As String
    Dim fullname As String
    Dim section As String
    Dim position As String

    Dim dataid As Integer
    Private Sub search_name_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then
            reloadgrid()
        Else
            reload("SELECT mr.id,
                        CONCAT(UPPER(ep.lastname),', ',ep.firstname, ' ', ep.middlename ) AS fullname,
                       mp.policy,
                        DATE_FORMAT(mr.dateoffense, '%M %d, %Y') AS Date_Violation, 
                       DATE_FORMAT(mr.datein, '%M %d, %Y') AS Date_Recorded, 
                        CONCAT(UPPER(ep2.lastname),', ',ep2.firstname, ' ', ep2.middlename ) AS Recorded_by,
                        CASE WHEN r.status = '0' THEN 'Pending' 
                                               END AS Status 
                FROM `hr_memo_records` mr
                JOIN hr_employee_profile ep ON mr.IDno= ep.IDno
                JOIN hr_memo_policies mp ON mp.id = mr.memoid
                JOIN hr_employee_profile ep2 ON mr.userin = ep2.IDno
                WHERE mr.status = '0' an ( ep.IDno REGEXP '" & txt_search.Text & "' or ep.firstname  REGEXP '" & txt_search.Text & "' or ep.lastname  REGEXP '" & txt_search.Text & "' )
                ORDER BY mr.id ASC", datagrid1)
        End If

    End Sub

    Private Sub reloadgrid()
        reload("SELECT mr.id,
                        CONCAT(UPPER(ep.lastname),', ',ep.firstname, ' ', ep.middlename ) AS fullname,
                       mp.policy,
                        DATE_FORMAT(mr.dateoffense, '%M %d, %Y') AS Date_Violation, 
                       DATE_FORMAT(mr.datein, '%M %d, %Y') AS Date_Recorded, 
                        CONCAT(UPPER(ep2.lastname),', ',ep2.firstname, ' ', ep2.middlename ) AS Recorded_by,
                        CASE WHEN mr.status = '0' THEN 'Pending' 
                                               END AS Status 
                FROM `hr_memo_records` mr 
                JOIN hr_employee_profile ep ON mr.IDno= ep.IDno
                JOIN hr_memo_policies mp ON mp.id = mr.memoid
                JOIN hr_employee_profile ep2 ON mr.userin = ep2.IDno
                WHERE mr.status = '0'
                ORDER BY mr.id ASC", datagrid1)
    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        Dim result As DialogResult
        result = MessageBox.Show("Change Status for " & datagrid1.Rows(e.RowIndex).Cells(1).Value.ToString() & " ?", "Confirmation", MessageBoxButtons.YesNoCancel)

        If result = DialogResult.Yes Then

            If e.RowIndex >= 0 Then
                'update
                dataid = datagrid1.Rows(e.RowIndex).Cells(0).Value.ToString()
                Panel1.Visible = True
            End If

        Else
            Panel1.Visible = False
            dataid = 0
        End If



    End Sub
    Private Sub changestatus(status As Integer)
        con.Close()
        con.Open()
        Dim update As New MySqlCommand("UPDATE `hr_memo_records` SET `userapproved`='" & idno & "',`status`='" & status & "' WHERE id ='" & dataid & "'", con)
        Update.ExecuteNonQuery()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        changestatus(1)
        MessageBox.Show("Status Approved!", "Confirmation", MessageBoxButtons.OK)
        Panel1.Visible = False
        reloadgrid()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        changestatus(2)
        MessageBox.Show("Status Declined!", "Confirmation", MessageBoxButtons.OK)
        Panel1.Visible = False
        reloadgrid()
    End Sub
End Class