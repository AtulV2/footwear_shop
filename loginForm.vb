Public Class loginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            Me.Hide()
            HomeForm.Show()
        End If

    End Sub
End Class