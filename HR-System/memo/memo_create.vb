Imports MySql.Data.MySqlClient

Public Class memo_create


    Private suggestionIDs As New Dictionary(Of String, String)()

    Private Sub memo_create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker.Value = date1
        cmb_display("SELECT distinct `policy` FROM `hr_memo_policies`", "policy", cmb_violation)
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_violation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_violation.SelectedIndexChanged


        con.Close()
        con.Open()
        Dim selectcmd As New MySqlCommand("SELECT * FROM `hr_memo_policies` WHERE policy = @policy ", con)
        With selectcmd.Parameters
            .AddWithValue("@policy", cmb_violation.Text)
        End With

        dr = selectcmd.ExecuteReader
        If dr.Read = True Then
            violation_id = dr.GetInt32("id")
            violation_class = dr.GetInt32("class")

            lbl_class.Text = violation_class


            con.Close()
            con.Open()
            Dim selectcount As New MySqlCommand("SELECT count(id) FROM `hr_memo_records` WHERE IDno = '" & txt_idno.Text & "' and memoid = '" & violation_id & "' ", con)

            dr = selectcount.ExecuteReader
            If dr.Read = True Then
                lbl_offensecount.Text = dr.GetInt32(0).ToString()
            End If
        End If


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        Try
            If txt_idno.Text = "---" Or cmb_violation.SelectedIndex = -1 Then

                lbl_error.Visible = True
            Else
                violation_idno = txt_idno.Text
                con.Close()
                con.Open()
                Dim insert As New MySqlCommand("INSERT INTO `hr_memo_records`(`IDno`,
                                                                            `memoid`,
                                                                            `dateoffense`,
                                                                            `datein`,
                                                                            `userin`,
                                                                            `status`) 
                                                                    VALUES (@idno,
                                                                           @memoid,
                                                                           @dateoffense,
                                                                          @datein,
                                                                        @userin,
                                                                          @status)", con)

                With insert.Parameters
                    .AddWithValue("@idno", txt_idno.Text)
                    .AddWithValue("@memoid", violation_id)
                    .AddWithValue("@dateoffense", dtpicker.Value.ToString("yyy-MM-dd"))
                    .AddWithValue("@datein", datedb)
                    .AddWithValue("@userin", idno)
                    .AddWithValue("@status", "0")
                End With

                insert.ExecuteNonQuery()
                lbl_error.Visible = False

                Dim result As DialogResult
                result = MessageBox.Show("Do you want to print a report?", "Confirmation", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    With print_memo
                        .Refresh()
                        .TopLevel = False
                        sub_FRAME.Panel1.Controls.Add(print_memo)
                        .BringToFront()
                        .Show()

                    End With
                Else
                    ' Code if the user selects No
                End If

                cmb_violation.SelectedIndex = -1
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        search_name.Show()
        search_name.BringToFront()
    End Sub

    Private Sub txt_idno_Click(sender As Object, e As EventArgs) Handles txt_idno.Click

    End Sub
End Class
