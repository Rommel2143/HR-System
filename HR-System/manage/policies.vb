Public Class policies
    Private Sub policies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then
            reloadgrid()
        Else
            reload("SELECT `id`, `memo`, `class` FROM `hr_memo_policies`
                 WHERE memo  REGEXP '" & txt_search.Text & "' ", datagrid1)
        End If

    End Sub

    Private Sub reloadgrid()
        reload("SELECT `id`, `memo`, `class` FROM `hr_memo_policies`", datagrid1)

    End Sub

End Class