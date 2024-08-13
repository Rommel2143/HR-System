Imports MySql.Data.MySqlClient
Public Class memo_view
    Dim idnumber As String
    Dim fullname As String
    Dim section As String
    Dim position As String

    Dim datagrid_status As Integer = 0
    Private Sub search_name_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then
            reloadgrid()
        Else
            reload("SELECT ep.IDno, CONCAT(ep.lastname, ', ', ep.firstname, ' ', ep.middlename) AS Fullname,ep.section, ep.position, COUNT(mr.id) AS Total_Violation FROM  hr_memo_records mr
                    JOIN hr_employee_profile ep ON mr.IDno = ep.IDno
                    WHERE  ep.IDno REGEXP '" & txt_search.Text & "' or ep.firstname  REGEXP '" & txt_search.Text & "' or ep.lastname  REGEXP '" & txt_search.Text & "'
                    GROUP BY mr.IDno
                    ORDER BY COUNT(mr.id) DESC", datagrid1)
        End If
        datagrid_status = 0
    End Sub

    Private Sub reloadgrid()
        reload("SELECT ep.IDno, CONCAT(ep.lastname, ', ', ep.firstname, ' ', ep.middlename) AS Fullname,ep.section, ep.position, COUNT(mr.id) AS Total_Violation FROM  hr_memo_records mr
                    JOIN hr_employee_profile ep ON mr.IDno = ep.IDno
                     GROUP BY mr.IDno
                     ORDER BY COUNT(mr.id) DESC", datagrid1)
    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        Select Case datagrid_status
            Case 0
                If e.RowIndex >= 0 Then
                    lbl_fullname.Text = datagrid1.Rows(e.RowIndex).Cells(1).Value.ToString()
                    idnumber = datagrid1.Rows(e.RowIndex).Cells(0).Value.ToString()
                    reload("SELECT mr.id, mp.policy, 
                       DATE_FORMAT(mr.dateoffense, '%M %d, %Y') AS dateoffense, 
                       DATE_FORMAT(mr.datein, '%M %d, %Y') AS datein, 
                       mr.userin, 
                       CASE WHEN mr.status = '0' THEN 'Pending' 
                            WHEN mr.status = '1' THEN 'Approved' 
                            WHEN mr.status = '2' THEN 'Declined' 
                            
                       END AS status 
                FROM hr_memo_records mr
                JOIN hr_memo_policies mp ON mp.id = mr.memoid
                WHERE IDno = '" & datagrid1.Rows(e.RowIndex).Cells(0).Value.ToString() & "' ", datagrid1)
                    datagrid_status = 1
                End If

            Case 1

                If e.RowIndex >= 0 Then
                    violation_idno = idnumber
                    Dim violation_id As Integer = datagrid1.Rows(e.RowIndex).Cells(0).Value.ToString()
                    con.Close()
                    con.Open()
                    Dim selectcount As New MySqlCommand("SELECT `id`,`memoid`, `dateoffense`  FROM `hr_memo_records` WHERE id = '" & violation_id & "'", con)

                    dr = selectcount.ExecuteReader
                    If dr.Read = True Then
                        violation_date = dr.GetDateTime("dateoffense").ToString("yyyy-MM-dd")
                        violation_memoid = dr.GetInt32("memoid")
                    End If

                    print_memo.Close()
                    With print_memo
                        .Refresh()
                        .TopLevel = False
                        sub_FRAME.Panel1.Controls.Add(print_memo)
                        .BringToFront()
                        .Show()

                    End With
                End If

        End Select

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        With memo_create
            .txt_idno.Text = idnumber
            .lbl_fullname.Text = fullname
            .lbl_section.Text = section
            .lbl_position.Text = position
        End With
        Me.Close()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        reloadgrid()
        datagrid_status = 0
        txt_search.Clear()
    End Sub
End Class