


Imports System.Data.SQLite

Public Class FilterViewForm
    Private Sub FilterBtn_Click(sender As Object, e As EventArgs) Handles FilterBtn.Click
        Dim pid As String = PIdTBox.Text
        Dim pname As String = PNameTBox.Text
        Dim psize As String = PSizeTBox.Text
        Dim pstyle_name As String = PStyle_NameTBox.Text
        Dim pbrand As String = PBrandTBox.Text
        Dim pcolor As String = PColorTBox.Text
        Dim user_group As String = User_GroupTBox.Text
        Dim product_type As String = Product_TypeTBox.Text
        Dim hile_type As String = Hile_TypeTBox.Text
        Dim outer_material As String = Outer_MaterialTBox.Text
        Dim sole_material As String = Sole_MaterialTBox.Text
        Dim water_resistance_level As String = Water_Resistance_LevelTBox.Text
        Dim closure_type As String = Closure_TypeTBox.Text

        If PIdTBox.Text = "" Then
            pid = "%"
        End If

        If pname = "" Then
            pname = "%"
        End If

        If psize = "" Then
            psize = "%"
        End If

        If pstyle_name = "" Then
            pstyle_name = "%"
        End If

        If pbrand = "" Then
            pbrand = "%"
        End If

        If pcolor = "" Then
            pcolor = "%"
        End If

        If user_group = "" Then
            user_group = "%"
        End If

        If product_type = "" Then
            product_type = "%"
        End If

        If hile_type = "" Then
            hile_type = "%"
        End If

        If outer_material = "" Then
            outer_material = "%"
        End If

        If sole_material = "" Then
            sole_material = "%"
        End If


        If water_resistance_level = "" Then
            water_resistance_level = "%"
        End If

        If closure_type = "" Then
            closure_type = "%"
        End If

        Dim Query As String

        Query = "select * from inventory_table where 
pid like            '" & pid & "'         and 
pname like          '" & pname & "'         and 
psize like          '" & psize & "'         and 
pstyle_name like    '" & pstyle_name & "'         and 
pbrand like         '" & pbrand & "'         and 
pcolor like         '" & pcolor & "'         and 
user_group like     '" & user_group & "'         and 
product_type like   '" & product_type & "'         and 
hile like      '" & hile_type & "'         and 
sole_material like  '" & sole_material & "'         and 
outer_material like '" & outer_material & "'         and 
water_resistance like '" & water_resistance_level & "' and 
closure_type like   '" & closure_type & "'         "

        conn.Open()
        Dim cmd As New SQLiteCommand(Query, conn)
        Dim reader As SQLiteDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub



    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Hide()
        HomeForm.Show()
    End Sub
End Class