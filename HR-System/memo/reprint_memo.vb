Imports MySql.Data.MySqlClient
Public Class reprint_memo
    Dim dt_sign As New DataTable
    Private Sub print_memo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myrpt As New print_memo_rpt
        dt.Clear()
        viewdata()
        viewdata_sign()
        myrpt.Database.Tables("memo").SetDataSource(dt)
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
                                                p.class
                                            FROM 
                                                hr_memo_records r
                                            JOIN 
                                                hr_employee_profile e ON r.IDno = e.IDno
JOIN 
                                                hr_employee_profile ep ON r.userin = ep.IDno
                                            JOIN hr_memo_policies p ON r.memoid= p.id
                                            WHERE r.memoid = '" & violation_id & "' and r.IDno = '" & violation_idno & "';", con)
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

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class