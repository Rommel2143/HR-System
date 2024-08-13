Imports MySql.Data.MySqlClient
Public Class memo_analytics
    Private Sub memo_analytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadgrid()
        reloadgrid2()

        loaddata()
    End Sub

    Private Shared Sub loaddata()
        con.Close()
        con.Open()
        Dim selectcmd As New MySqlCommand("SELECT * FROM `hr_memo_policies` WHERE policy = @policy ", con)
        With selectcmd.Parameters
            .AddWithValue("@policy", cmb_violation.Text)
        End With

        dr = selectcmd.ExecuteReader
        If dr.Read = True Then
            violation_memoid = dr.GetInt32("id")


            lbl_class.Text = dr.GetInt32("class")
        End If
    End Sub

    Private Sub reloadgrid()
        reload("SELECT CONCAT(ep.lastname, ', ', ep.firstname, ' ', ep.middlename) AS Fullname, COUNT(mr.id) AS Total_Violation FROM  hr_memo_records mr
                    JOIN hr_employee_profile ep ON mr.IDno = ep.IDno
                    WHERE mr.status = '1'
                     GROUP BY mr.IDno
                     ORDER BY COUNT(mr.id) DESC", datagrid1)
    End Sub

    Private Sub reloadgrid2()
        reload("SELECT mp.policy AS Policy,mp.class AS Class, COUNT(mr.id) AS Total_Violation FROM  hr_memo_records mr
                    JOIN hr_memo_policies mp ON mp.id = mr.memoid
                     WHERE mr.status = '1'
                     GROUP BY mr.memoid
                     ORDER BY COUNT(mr.id) DESC", datagrid2)
    End Sub
End Class