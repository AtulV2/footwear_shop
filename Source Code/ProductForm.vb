

Imports System.Data.SQLite

Public Class ProductForm
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        conn.Open()

        Dim pid As Integer
        Dim Query As String = "select max(pid) from inventory_table"

        Dim cmd As New SQLiteCommand(Query, conn)

        Dim reader As SQLiteDataReader = cmd.ExecuteReader

        Try
            While reader.Read
                pid = reader.GetInt32(0)
                pid += 1
            End While
        Catch
            pid = 1
        End Try
        conn.Close()

        Dim pname As String = PNameTBox.Text
        Dim psize As Integer = Integer.Parse(PSizeTBox.Text)
        Dim pstyle_name As String = PStyle_NameTBox.Text
        Dim pbrand As String = PBrandTBox.Text
        Dim pcolor As String = PColorTBox.Text
        Dim user_group As String = User_GroupTBox.Text
        Dim product_type As String = Product_TypeTBox.Text
        Dim hile As Integer = Integer.Parse(Hile_TypeTBox.Text)
        Dim outer_material As String = Outer_MaterialTBox.Text
        Dim sole_material As String = Sole_MaterialTBox.Text
        Dim water_resistance_level As String = Water_Resistance_LevelTBox.Text
        Dim closure_type As String = Closure_TypeTBox.Text





        Query = "insert into inventory_table (punits_available,cprice,sprice,pid,pname,psize,pstyle_name,pbrand,pcolor,user_group,product_type,hile,outer_material,sole_material,water_resistance,closure_type) values
        ( 
            0,0,0,
            " & pid & ",
            '" & pname & "',
            " & psize & ",
            '" & pstyle_name & "',
            '" & pbrand & "',
            '" & pcolor & "',
            '" & user_group & "',
            '" & product_type & "',
            " & hile & ",
            '" & outer_material & "',
            '" & sole_material & "',
            '" & water_resistance_level & "',
            '" & closure_type & "'
        )"
        conn.Open()
        '   cmd = New SQLiteCommand(Query, conn)
        Dim cmd2 = conn.CreateCommand
        cmd2.CommandText = Query
        cmd2.ExecuteNonQuery()
        conn.Close()
        MsgBox("Product Added successfully",, "")
    End Sub

    Private Sub BackBtn1_Click(sender As Object, e As EventArgs) Handles BackBtn1.Click
        Me.Hide()
        HomeForm.Show()
    End Sub

    Private Sub ProductForm_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        loginForm.Close()

    End Sub

End Class