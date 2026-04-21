Imports System.Data.SQLite
Imports System.Text.RegularExpressions

Public Class ChangePass
    Private Sub ChagnePassBtn_Click(sender As Object, e As EventArgs) Handles ChagnePassBtn.Click
        conn.Open()
        Dim password = pass2TBox.Text
        If (password.Length >= 6 AndAlso
            Regex.Match(password, "[a-z]", RegexOptions.ECMAScript).Success AndAlso
            Regex.Match(password, "[A-Z]", RegexOptions.ECMAScript).Success AndAlso
            Regex.Match(password, "\d", RegexOptions.ECMAScript).Success AndAlso
            Regex.Match(password, "[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript).Success) Then



            Dim sqlite_cmd As SQLiteCommand
            sqlite_cmd = conn.CreateCommand()

            sqlite_cmd.CommandText = "select * from login_table"
            Dim reader = sqlite_cmd.ExecuteReader
            If reader.HasRows Then

                Dim cm As SQLiteCommand
                cm = conn.CreateCommand

                cm.CommandText = "update LOGIN_TABLE set uname = '" & id2TBox.Text & "', upass = '" & pass2TBox.Text & "' where constant = 'login'"
                cm.ExecuteNonQuery()
                conn.Close()

            Else
                Dim cmd As New SQLiteCommand
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into  LOGIN_TABLE (UNAME,UPASS,CONSTANT) values('" & id2TBox.Text & "','" & pass2TBox.Text & "','login')"

                cmd.ExecuteNonQuery()
                conn.Close()
            End If


            MsgBox("password change successfull")

        Else
            MsgBox("password must be 6 character long and  contain a capital and small letter, a number and a special character")
        End If


        conn.Close()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Hide()
        HomeForm.Show()
    End Sub

    Private Sub ChangePass_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        loginForm.Close()
    End Sub
End Class