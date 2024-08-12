Public Class search_name
    Dim idnumber As String
    Dim fullname As String
    Dim section As String
    Dim position As String
    Private Sub search_name_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then
            reloadgrid()
        Else
            reload("SELECT `IDno`, CONCAT(lastname, ', ', firstname, ' ', middlename) AS Fullname,`section`, `position` FROM `hr_employee_profile`
                 WHERE IDno REGEXP '" & txt_search.Text & "' or firstname  REGEXP '" & txt_search.Text & "' or lastname  REGEXP '" & txt_search.Text & "' ", datagrid1)
        End If

    End Sub

    Private Sub reloadgrid()
        reload("SELECT `IDno`,CONCAT(lastname, ', ', firstname, ' ', middlename) AS Fullname,`section`, `position` FROM `hr_employee_profile`", datagrid1)
    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If e.RowIndex >= 0 Then
            ' Get the value from column 0 of the selected row.
            With memo_create
                idnumber = datagrid1.Rows(e.RowIndex).Cells(0).Value.ToString()
                fullname = datagrid1.Rows(e.RowIndex).Cells(1).Value.ToString()
                section = datagrid1.Rows(e.RowIndex).Cells(2).Value.ToString()
                position = datagrid1.Rows(e.RowIndex).Cells(3).Value.ToString()
            End With
            lbl_fullname.Text = datagrid1.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With memo_create
            .txt_idno.Text = idnumber
            .lbl_fullname.Text = fullname
            .lbl_section.Text = section
            .lbl_position.Text = position
        End With
        Me.Close()
    End Sub
End Class