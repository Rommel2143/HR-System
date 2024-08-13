Imports MySql.Data.MySqlClient
Public Class print_memo
    Dim dt_sign As New DataTable
    Dim dt_records As New DataTable
    Private Sub print_memo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadrpt()
    End Sub

    Private Sub loadrpt()
        Dim myrpt As New print_memo_rpt
        dt.Clear()
        viewdata()
        myrpt.Database.Tables("memo").SetDataSource(dt)
        viewdata_sign()
        myrpt.Database.Tables("signatories").SetDataSource(dt_sign)

        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub

    Sub viewdata()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("SELECT 
                                                 r.id,
                                                r.IDno, 
                                                r.memoid, 
                                                r.dateoffense, 
                                                r.datein, 
                                               CONCAT(UPPER(LEFT(ep.firstname, 1)),'.',UPPER(ep.lastname) ) AS userin, 
                                                CONCAT(UPPER(e.lastname),', ',UPPER(e.firstname), ' ', UPPER(e.middlename )) AS fullname, 
                                                e.section, 
                                                e.position,
                                                 p.policy,
                                              e.status,
                                                p.class,
                                                 CASE WHEN r.status = '0' THEN 'Pending' 
                                               WHEN r.status = '1' THEN 'Approved'
                                               WHEN r.status = '2' THEN 'Declined'
                                               END AS offensestatus 
                                            FROM 
                                                hr_memo_records r
                                            JOIN 
                                                hr_employee_profile e ON r.IDno = e.IDno
                                            JOIN 
                                                hr_employee_profile ep ON r.userin = ep.IDno
                                            JOIN hr_memo_policies p ON r.memoid= p.id
                                            WHERE r.memoid = '" & violation_memoid & "' and r.IDno = '" & violation_idno & "'
                                             ORDER BY 
                                   CASE WHEN r.dateoffense = '" & violation_date & "' THEN 0 ELSE 1 END, 
                                   r.dateoffense DESC;", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()

    End Sub

    Sub viewdata_sign()


        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("SELECT `checked`, `approved`, `noted` FROM `hr_memo_signatories`;", con)
        Dim da_sign As New MySqlDataAdapter(showreport)
        da_sign.Fill(dt_sign)
        con.Close()

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class