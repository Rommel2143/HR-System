Imports MySql.Data.MySqlClient
Imports System.Reflection
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtpcname.Text = PCname
            txtpcmac.Text = PCmac
            Dim version As String = Assembly.GetExecutingAssembly().GetName().Version.ToString()
            lblversion.Text = version
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT * FROM computer_location WHERE `PCname`='" & PCname & "' and `PCmac`='" & PCmac & "'", con)
            dr = cmdselect.ExecuteReader
            If dr.Read = True Then
                txtbarcode.Enabled = True
                txtbarcode.Focus()
                PClocation = dr.GetString("location")

            Else
                Dim result As DialogResult = MessageBox.Show("Machine not Verified!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)


                If result = DialogResult.OK Then
                    display_form(Register_PC)

                ElseIf result = DialogResult.Cancel Then
                    con.Close()
                    Application.Exit()
                End If



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            txtbarcode.Clear()

        End Try
    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown



    End Sub
    Private Sub noid()
        Try
            labelerror.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
        login()

    End Sub

    Private Sub login()
        Try
            Dim idwithA As String = "A" & txtbarcode.Text & "A"
            Dim idwithoutA As String = txtbarcode.Text.TrimStart("A"c).TrimEnd("A"c)
            Dim idwithoutasmall As String = txtbarcode.Text.TrimStart("a"c).TrimEnd("a"c)
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `hr_user` WHERE (`IDno` = '" & idwithoutA & "' or `IDno` = '" & idwithA & "' or `IDno` = '" & idwithoutasmall & "') and pass = '" & password.Text & "' ", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                idno = dr("IDno").ToString

                con.Close()
                con.Open()
                Dim cmdfname As New MySqlCommand("SELECT * FROM `hr_employee_profile` WHERE (`IDno` = '" & idwithoutA & "' or `IDno` = '" & idwithA & "' or `IDno` = '" & idwithoutasmall & "') ", con)
                dr = cmdfname.ExecuteReader
                If dr.Read = True Then
                    Dim first As String = dr.GetString("firstname")
                    Dim middle As String = dr.GetString("middlename")
                    Dim last As String = dr.GetString("lastname")
                    fname = first & " " & middle & " " & last
                    con.Close()
                    display_form(sub_FRAME)
                    sub_FRAME.userstrip.Text = "Hello, " & first
                    labelerror.Visible = False
                Else
                    noid()
                End If
            Else
                'no fname
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            txtbarcode.Clear()

        End Try
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class