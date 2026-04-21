

Imports System.Data.SQLite

Public Class ProductEditForm
    Private Sub ProductEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AddItemsToComboBox()

    End Sub


    Private Sub AddItemsToComboBox()
        conn.Open()
        Dim cmd As New SQLiteCommand("select pid from inventory_table", conn)
        Dim da As New SQLiteDataAdapter(cmd)
        Dim db As DataTable = New DataTable
        da.Fill(db)

        ComboBox1.DisplayMember = "pid"
        ComboBox1.ValueMember = "pid"
        ComboBox1.DataSource = db
        conn.Close()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Dim re As MsgBoxResult = MsgBox("Are You Sure ? this cannot be undo ", MsgBoxStyle.OkCancel, "")
        If re.Yes Then
            conn.Open()

            Dim pid As Integer = Integer.Parse(ComboBox1.SelectedValue)

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





            Dim Query As String = "update inventory_table             
            set pname =   '" & pname & "',
            psize  = " & psize & ",
            pstyle_name =   '" & pstyle_name & "',
            pbrand =  '" & pbrand & "',
            pcolor =  '" & pcolor & "',
            user_group  = '" & user_group & "',
            product_type  =  '" & product_type & "',
            hile = " & hile & ",
            outer_material =  '" & outer_material & "',
            sole_material = '" & sole_material & "',
            water_resistance = '" & water_resistance_level & "',
            closure_type = '" & closure_type & "'
            
            where pid = " & pid & "
            "

            Dim cmd As New SQLiteCommand(Query, conn)
            cmd.ExecuteNonQuery()
            conn.Close()

        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim pid As Integer = Integer.Parse(ComboBox1.SelectedValue)

        conn.Open()
        Dim Query As String = "select * from inventory_table where pid = " & pid
        Dim cmd As New SQLiteCommand(Query, conn)
        Dim reader As SQLiteDataReader = cmd.ExecuteReader
        While reader.Read
            PNameTBox.Text = reader.GetString(4)
            PSizeTBox.Text = reader.GetInt32(5)
            PStyle_NameTBox.Text = reader.GetString(6)
            PBrandTBox.Text = reader.GetString(7)
            PColorTBox.Text = reader.GetString(8)
            User_GroupTBox.Text = reader.GetString(9)
            Product_TypeTBox.Text = reader.GetString(10)
            Hile_TypeTBox.Text = reader.GetInt32(11)
            Outer_MaterialTBox.Text = reader.GetString(12)
            Sole_MaterialTBox.Text = reader.GetString(13)
            Water_Resistance_LevelTBox.Text = reader.GetString(14)
            Closure_TypeTBox.Text = reader.GetString(15)
        End While
        conn.Close()

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim pid As Integer = Integer.Parse(ComboBox1.Text)
        Dim re As MsgBoxResult = MsgBox("Are You Sure Delete a product which id is " & pid, MsgBoxStyle.OkCancel, "")
        If re.Yes Then
            conn.Open()

            Dim Query As String = "delete from inventory_table where pid = " & pid
            Dim cmd As SQLiteCommand
            cmd = conn.CreateCommand
            cmd.CommandText = Query
            cmd.ExecuteNonQuery()

            'Query = "delete inventory_table where pid = " & pid
            'cmd = New OracleCommand(Query, cnn)
            'cmd.ExecuteNonQuery()

            conn.Close()



            Call AddItemsToComboBox()

            PNameTBox.Text = ""
            PSizeTBox.Text = ""
            PStyle_NameTBox.Text = ""
            PBrandTBox.Text = ""
            PColorTBox.Text = ""
            User_GroupTBox.Text = ""
            Product_TypeTBox.Text = ""
            Hile_TypeTBox.Text = ""
            Outer_MaterialTBox.Text = ""
            Sole_MaterialTBox.Text = ""
            Water_Resistance_LevelTBox.Text = ""
            Closure_TypeTBox.Text = ""

        End If
    End Sub

    Private Sub BackBtn2_Click(sender As Object, e As EventArgs) Handles BackBtn2.Click
        Me.Hide()
        HomeForm.Show()
    End Sub



    Private Sub ProductEditForm_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        loginForm.Close()

    End Sub
End Class