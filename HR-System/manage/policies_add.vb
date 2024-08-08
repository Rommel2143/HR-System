Imports MySql.Data.MySqlClient
Public Class policies_add
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            If idno.Text = "" Or password.Text = "" Then
                MessageBox.Show("All Fields are required!")
            Else
                Dim idwithA As String = "A" & idno.Text & "A"
                Dim idwithoutA As String = idno.Text.TrimStart("A"c).TrimEnd("A"c)
                Dim idwithoutasmall As String = idno.Text.TrimStart("a"c).TrimEnd("a"c)
                con.Close()
                con.Open()
                Dim cmdfname As New MySqlCommand("SELECT * FROM `hr_employee_profile` WHERE  (`IDno` = '" & idwithoutA & "' or `IDno` = '" & idwithA & "' or `IDno` = '" & idwithoutasmall & "')", con)
                dr = cmdfname.ExecuteReader
                If dr.Read = True Then

                    con.Close()
                    con.Open()
                    Dim cmd As New MySqlCommand("SELECT IDno FROM `hr_user` WHERE IDno = '" & idno.Text & "' ", con)
                    dr = cmd.ExecuteReader
                    If dr.Read = False Then
                        con.Close()
                        con.Open()

                        Dim cmdinsert As New MySqlCommand(" INSERT INTO `hr_user` (`IDno`, `pass`) VALUES ('" & idno.Text & "','" & password.Text & "')", con)
                        cmdinsert.ExecuteNonQuery()
                        MessageBox.Show("USER Added successfully!")
                        con.Close()
                        idno.Clear()
                        password.Clear()
                    Else
                        MessageBox.Show("USER already Exist!")
                    End If
                Else
                    MessageBox.Show("No Employee Record Found!")
                End If


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2ImageButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2ImageButton1.MouseDown
        ' Show password characters
        password.PasswordChar = ""
    End Sub

    ' This event will trigger when the button is released
    Private Sub Guna2ImageButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles Guna2ImageButton1.MouseUp
        ' Hide password characters
        password.PasswordChar = "*"c
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            If txt_policy.Text = "" Or num_class.Value = 0 Then
                MessageBox.Show("All Fields are required!")
            Else
                con.Close()
                con.Open()
                Dim cmd As New MySqlCommand("SELECT memo FROM `hr_memo_policies` WHERE memo = '" & txt_policy.Text & "' and class = '" & num_class.Value & "' ", con)
                dr = cmd.ExecuteReader
                If dr.Read = False Then
                    con.Close()
                    con.Open()

                    Dim cmdinsert As New MySqlCommand(" INSERT INTO `hr_memo_policies` (`memo`, `class`) VALUES ('" & txt_policy.Text & "','" & num_class.Value & "')", con)
                    cmdinsert.ExecuteNonQuery()
                    MessageBox.Show("Policy Added successfully!")
                    con.Close()
                    txt_policy.Clear()
                    num_class.Value = 0
                Else
                    MessageBox.Show("Policy already Exist!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click

    End Sub

    Private Sub Guna2Button3_Click_1(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        With policies
            .Refresh()
            .TopLevel = False
            sub_FRAME.Panel1.Controls.Add(policies)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class