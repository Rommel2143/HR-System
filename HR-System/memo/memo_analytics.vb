Imports MySql.Data.MySqlClient

Public Class memo_analytics
    Private Sub memo_analytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload_all()
        'loaddata()
    End Sub

    Private Sub reload_all()
        'reloadgrid()
        reloadgrid2()

        Try
            con.Open()
            Dim query As String = "SELECT CONCAT(ep.lastname, ', ', ep.firstname, ' ', ep.middlename) AS Fullname, COUNT(mr.ID) AS CountID, `memoid` FROM `hr_memo_records` mr  
                                   JOIN hr_employee_profile ep ON ep.IDno = mr.IDno 
WHERE mr.status='1'
GROUP BY mr.IDno
ORDER BY COUNT(mr.ID) DESC"
            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim gunahorizontalbardataset As New DataSet()

            ' Fill the dataset with data
            adapter.Fill(gunahorizontalbardataset, "MemoRecords")

            ' Clear existing points in bardataset by reinitializing it
            bardataset = New Guna.Charts.WinForms.GunaHorizontalBarDataset
            bardataset.Label = "Number of Memos Per Employee"
            ' Populate bardataset with data from the dataset
            For Each row As DataRow In gunahorizontalbardataset.Tables("MemoRecords").Rows
                bardataset.DataPoints.Add(row("Fullname").ToString(), Convert.ToInt32(row("CountID")))
            Next

            ' Add bardataset to Chart1 and refresh the chart
            Chart1.Datasets.Clear()
            Chart1.Datasets.Add(bardataset)
            Chart1.Update()



        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Private Shared Sub loaddata()
    '    con.Close()
    '    con.Open()
    '    Dim selectcmd As New MySqlCommand("SELECT * FROM `hr_memo_policies` WHERE policy = @policy ", con)
    '    With selectcmd.Parameters
    '        .AddWithValue("@policy", cmb_violation.Text)
    '    End With

    '    dr = selectcmd.ExecuteReader
    '    If dr.Read = True Then
    '        violation_memoid = dr.GetInt32("id")


    '        lbl_class.Text = dr.GetInt32("class")
    '    End If
    'End Sub

    'Private Sub reloadgrid()
    '    reload("SELECT CONCAT(ep.lastname, ', ', ep.firstname, ' ', ep.middlename) AS Fullname, COUNT(mr.id) AS Total_Violation FROM  hr_memo_records mr
    '                JOIN hr_employee_profile ep ON mr.IDno = ep.IDno
    '                WHERE mr.status = '1'
    '                 GROUP BY mr.IDno
    '                 ORDER BY COUNT(mr.id) DESC", datagrid1)
    'End Sub

    Private Sub reloadgrid2()
        reload("SELECT mp.policy AS Policy,mp.class AS Class, COUNT(mr.id) AS Total_Violation FROM  hr_memo_records mr
                    JOIN hr_memo_policies mp ON mp.id = mr.memoid
                     WHERE mr.status = '1'
                     GROUP BY mr.memoid
                     ORDER BY COUNT(mr.id) DESC", datagrid2)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub
End Class