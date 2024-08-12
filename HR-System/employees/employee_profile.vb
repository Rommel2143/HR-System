Public Class employee_profile
    Private Sub employee_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class