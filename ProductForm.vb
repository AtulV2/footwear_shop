Imports Oracle.ManagedDataAccess.Client

Public Class ProductForm
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        cnn.Open()

        Dim pid As Integer
        Dim Query As String = "select max(pid) from product_table"

        Dim cmd As New OracleCommand(Query, cnn)
        Dim reader As OracleDataReader = cmd.ExecuteReader

        Try
            While reader.Read
                pid = Integer.Parse(reader.GetString(0))
                pid += 1
            End While
        Catch
            pid = 1
        End Try

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





        Query = "insert into inventory_table (pid,pname,psize,pstyle_name,pbrand,pcolor,user_group,product_type,hile,outer_material,sole_material,water_resistance,closure_type) values
        ( 
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

        cmd = New OracleCommand(Query, cnn)
        cmd.ExecuteNonQuery()
        cnn.Close()
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