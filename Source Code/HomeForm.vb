Imports System.Data.SQLite
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions
Public Class HomeForm
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

    Private Sub Ref_Click(sender As Object, e As EventArgs) Handles Ref.Click
        Call AddItemsToComboBox()
        Call FillInvetoryToDataGrideView()
    End Sub
    Sub FillInvetoryToDataGrideView()
        conn.Open()
        Dim cmd As New SQLiteCommand("select * from inventory_table order by pid", conn)
        Dim reader As SQLiteDataReader = cmd.ExecuteReader
        Dim DT As New DataTable
        DT.Load(reader)
        DGVForInventory.DataSource = DT
        conn.Close()
    End Sub

    Private Sub ProductBtn_Click(sender As Object, e As EventArgs) Handles ProductBtn.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub InventoryBtn_Click(sender As Object, e As EventArgs) Handles InventoryBtn.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub GoToAddProductFormBtn_Click(sender As Object, e As EventArgs) Handles GoToAddProductFormBtn.Click
        Me.Hide()
        ProductForm.Show()
    End Sub

    Private Sub GoToProductEditFormBtn_Click(sender As Object, e As EventArgs) Handles GoToProductEditFormBtn.Click, GoToProductEditFormBtn2.Click
        Me.Hide()
        ProductEditForm.Show()
    End Sub

    Private Sub AddInventoryBtn_Click(sender As Object, e As EventArgs) Handles AddInventoryBtn.Click
        Dim pid As Integer = Integer.Parse(ComboBox1.SelectedValue)
        Dim cprice As Integer = Integer.Parse(CPriceTBox.Text)
        Dim Sprice As Integer = Integer.Parse(SPriceTBox.Text)
        Dim punits_available As Integer = Integer.Parse(ProcutUnitsTBox.Text)

        conn.Open()

        Dim Query2 As String = "update inventory_table set cprice =  " & cprice & ",sprice = " & Sprice & ", punits_available = " & punits_available & " where pid = " & pid
            Dim cmd3 As SQLiteCommand
            cmd3 = conn.CreateCommand
            cmd3.CommandText = Query2
            cmd3.ExecuteNonQuery()
            conn.Close()

        Call FillInvetoryToDataGrideView()
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AddItemsToComboBox()
        Call FillInvetoryToDataGrideView()
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
    End Sub

    Private Sub SellBtn_Click(sender As Object, e As EventArgs) Handles SellBtn.Click
        TabControl1.SelectedTab = TabPage3



        conn.Open()
        Dim cmd As New SQLiteCommand("select pid from inventory_table", conn)
        Dim da As New SQLiteDataAdapter(cmd)
        Dim db As DataTable = New DataTable
        da.Fill(db)

        pid2CBox.DisplayMember = "pid"
        pid2CBox.ValueMember = "pid"
        pid2CBox.DataSource = db
        conn.Close()
    End Sub

    Dim sprice As Integer
    Dim i = 0
    Dim GrandTotal As Long = 0
    Dim punits_available As Integer
    Dim punits As Integer
    Dim pid As Integer
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Dim cname As String = CNameTBox.Text
        Dim cphone As Long


        Try
            pid = Integer.Parse(pid2CBox.Text)
            If CPhoneTBox.Text.Length = 10 Then
                cphone = Long.Parse(CPhoneTBox.Text)
            Else
                cphone = 0
            End If

            punits = Integer.Parse(pUnits2TBox.Text)

        Catch ex As Exception
            '  MsgBox(ex.Message)

            pid = -1
            cphone = 0
            punits = 0
        End Try




        Dim pname As String
        Dim cprice As Integer



        conn.Open()
        Dim cmd As New SQLiteCommand("select pname,cprice,sprice,punits_available from inventory_table where pid=" & pid, conn)
        Dim reader As SQLiteDataReader = cmd.ExecuteReader
        While reader.Read

            'pname = reader.GetString(4)
            'cprice = Integer.Parse(reader.GetString(1))           
            'sprice = Integer.Parse(reader.GetString(2))
            'punits_available = Integer.Parse(reader.GetString(3))


            pname = reader.GetString(0)
            cprice = reader.GetInt32(1)
            sprice = reader.GetInt32(2)
            punits_available = reader.GetInt32(3)
            '  MsgBox(reader.GetDataTypeName(2))


            ''  pname = reader.GetString(0)
            'pname = "hlsfjda"
            ''   cprice = reader.GetInt32(1)
            'cprice = 83
            '' sprice = Integer.Parse(reader.GetString(2))
            'sprice = 232

            'MsgBox(reader.GetString(0) & " -" & reader.GetInt32(1) & " - " & reader.GetInt32(2))
            '' punits_available = Integer.Parse(reader.GetString(3))
            'punits_available = 212
        End While
        conn.Close()
        If pid = -1 Then
            MsgBox("Please enter product id")

        ElseIf cphone = 0 Then
            MsgBox("Enter correct phone number")
        ElseIf punits = 0 Then
            MsgBox("Enter valid product quantity")
        ElseIf punits <= punits_available Then
            Dim rnum As Integer = BillDGV.Rows.Add()
            '  Dim total = Integer.Parse(pUnits2TBox.Text) * 400

            i = i + 1
            BillDGV.Rows.Item(rnum).Cells("No").Value = i
            BillDGV.Rows.Item(rnum).Cells("Product_Name").Value = pname
            BillDGV.Rows.Item(rnum).Cells("Product_ID").Value = pid
            BillDGV.Rows.Item(rnum).Cells("Price").Value = sprice
            BillDGV.Rows.Item(rnum).Cells("Units").Value = punits
            BillDGV.Rows.Item(rnum).Cells("Total_Price").Value = sprice * punits

            GrandTotal += (sprice * punits)


            Call update()
        Else
            MsgBox("Stock not available")
        End If

        GrandTotalLabel.Text = GrandTotal


    End Sub

    Sub update()
        conn.Open()
        Dim Query As String = "update inventory_table set punits_available= " & punits_available - punits & " where pid =" & pid
        Dim cmd As New SQLiteCommand(Query, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Dim tid
    Private Sub GenerateBillBtn_Click(sender As Object, e As EventArgs) Handles GenerateBillBtn.Click


        Dim rowCount As Integer = BillDGV.RowCount
        Dim pid As Integer
        Dim Unit As Integer
        Dim Today As Date = Date.Now
        Dim TodayStr As String = Format(Today, "yyyy-MM-dd")

        Dim cprice As Integer
        Dim sprice As Integer

        Dim cname As String = CNameTBox.Text
        Dim cphone As String = CPhoneTBox.Text



        conn.Open()
        Dim cmd As New SQLiteCommand("Select max(tid) from selles_table", conn)
            Dim reader As SQLiteDataReader = cmd.ExecuteReader
        While reader.Read
            Try
                tid = reader.GetInt32(0)
                tid += 1
            Catch
                tid = 1
            End Try
        End While
            conn.Close()





        For j As Integer = 0 To rowCount - 1
            pid = Integer.Parse(BillDGV.Item(2, j).Value)
            Unit = Integer.Parse(BillDGV.Item(4, j).Value)

            conn.Open()
            Dim Query As String = "select * from inventory_table where pid = " & pid
            Dim cmd2 As New SQLiteCommand(Query, conn)
            Dim r As SQLiteDataReader = cmd2.ExecuteReader
            While r.Read
                cprice = r.GetInt32(1)
                sprice = r.GetInt32(2)
            End While


            Dim Query2 = "insert into selles_table (tid,pid,punits,cprice,sprice,purchase_date,cname,cphone) values(
                " & tid & ",
                " & pid & ",
                " & Unit & ",
                " & cprice & ",
                " & sprice & ",
             DATE('" & TodayStr & "'),
               ' " & cname & "',
                " & cphone & "
            
            )"

            Dim cmd3 As New SQLiteCommand(Query2, conn)
            cmd3.ExecuteNonQuery()
            conn.Close()
        Next


        'TO_DATE('   " & TodayStr & "','DD-MM-YYYY'),

        ppd.Document = pd
        ppd.ShowDialog()

        CNameTBox.Text = ""
        CPhoneTBox.Text = ""
        pUnits2TBox.Text = ""
        BillDGV.Rows.Clear()
        GrandTotal = 0

    End Sub


    Private Sub HomeForm_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        loginForm.Close()

    End Sub
    Private Sub RemoveFromBillBtn_Click(sender As Object, e As EventArgs) Handles RemoveFromBillBtn.Click
        If BillDGV.CurrentRow IsNot Nothing Then
            Dim rowIndex As Integer = BillDGV.CurrentRow.Index
            Dim colIndexUnit As Integer = 4
            Dim colIndexpid As Integer = 2
            Dim pid2 = Integer.Parse(BillDGV.Item(colIndexpid, rowIndex).Value)
            Dim Unit = Integer.Parse(BillDGV.Item(colIndexUnit, rowIndex).Value)

            Dim UnitAvailable
            conn.Open()
            Dim Query2 As String = "select punits_available from inventory_table where pid = " & pid
            Dim cmd2 As New SQLiteCommand(Query2, conn)
            Dim reader As SQLiteDataReader = cmd2.ExecuteReader
            While reader.Read
                UnitAvailable = reader.GetInt32(0)
            End While

            Dim sum As Integer = UnitAvailable + Unit

            Dim Query As String = "update inventory_table set punits_available= " & sum & " where pid =" & pid2
            Dim cmd As New SQLiteCommand(Query, conn)
            cmd.ExecuteNonQuery()

            conn.Close()



            BillDGV.Rows.Remove(BillDGV.CurrentRow)

            i = i - 1
            GrandTotal = GrandTotal - (punits * sprice)
        Else
            MsgBox("Select a row from below to remove",, "")
        End If
    End Sub

    Private Sub ProfitCalculateBtn_Click(sender As Object, e As EventArgs) Handles ProfitCalculateBtn.Click
        conn.Open()
        Dim profit
        Dim D1 = DateTimePicker1.Value
        Dim da1 As String = Format(D1, "yyyy-MM-dd")

        Dim D2 = DateTimePicker2.Value
        Dim da2 As String = Format(D2, "yyyy-MM-dd")

        Dim Query As String = "select SUM((sprice - cprice)*punits) as profit from selles_table where purchase_date >= DATE('" & da1 & "') AND Purchase_date <= DATE('" & da2 & "')"
        Dim cmd As New SQLiteCommand(Query, conn)
        Dim r As SQLiteDataReader = cmd.ExecuteReader
        Try

            While r.Read
                profit = r.GetInt32(0)
            End While
        Catch exception As Exception
            ' MsgBox(exception.Message & profit)

            profit = 0
        End Try

        ProfitLabel.Text = profit

        ' select SUM((sprice - cprice)*punits) as profit from selles_table where purchase_date >= TO_DATE('21-01-2024','DD-MM-YYYY') AND Purchase_date <= TO_DATE('21-01-2024','DD-MM-YYYY')


        Query = "select pid,SUM((sprice - cprice)*punits) as profit from selles_table where purchase_date >= DATE('" & da1 & "') AND Purchase_date <= DATE('" & da2 & "') group by pid"

        cmd = New SQLiteCommand(Query, conn)
        r = cmd.ExecuteReader

        Dim dt As New DataTable
        dt.Load(r)
        PPofitDGV.DataSource = dt





        conn.Close()




    End Sub

    Private Sub A2Btn_Click(sender As Object, e As EventArgs) Handles A2Btn.Click
        conn.Open()
        Dim TotalProdut
        Dim D1 = DateTimePicker3.Value
        Dim da1 As String = Format(D1, "yyyy-MM-dd")

        Dim D2 = DateTimePicker4.Value
        Dim da2 As String = Format(D2, "yyyy-MM-dd")

        Dim Query As String = "select SUM(PUNITS) from selles_table where purchase_date >= DATE('" & da1 & "') AND Purchase_date <= DATE('" & da2 & "')"
        Dim cmd As New SQLiteCommand(Query, conn)
        Dim r As SQLiteDataReader = cmd.ExecuteReader
        Try

            While r.Read
                TotalProdut = r.GetInt32(0)
            End While
        Catch
            TotalProdut = 0
        End Try

        TotalProductLabel.Text = TotalProdut


        Query = "select pid,SUM(punits) as Units from selles_table where purchase_date >= DATE('" & da1 & "') AND Purchase_date <= DATE('" & da2 & "') group by pid"
        cmd = New SQLiteCommand(Query, conn)
        r = cmd.ExecuteReader

        Dim dt As New DataTable
        dt.Load(r)
        PSellDGV.DataSource = dt

        conn.Close()


    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Me.Hide()
        FilterViewForm.Show()


        'cnn.Open()
        'Dim cmd As New OracleCommand("select pid from inventory_table", cnn)
        'Dim da As New OracleDataAdapter(cmd)
        'Dim db As DataTable = New DataTable
        'da.Fill(db)

        'FilterViewForm.ComboBoxForid.DisplayMember = "pid"
        'FilterViewForm.ComboBoxForid.ValueMember = "pid"
        'FilterViewForm.ComboBoxForid.DataSource = db
        'cnn.Close()
    End Sub

    Private Sub transactionBtn_Click(sender As Object, e As EventArgs) Handles transactionBtn.Click
        TabControl1.SelectedTab = TabPage5



        'cnn.Open()
        'Dim cmd As New OracleCommand("select tid from selles_table group by tid", cnn)
        'Dim a As New OracleDataAdapter(cmd)
        'Dim d As DataTable = New DataTable

        'TIDCBox.DisplayMember = "tid"
        'TIDCBox.ValueMember = "tid"
        'a.Fill(d)
        'TIDCBox.DataSource = d

        'cnn.Close()

    End Sub



    Private Sub PRrefreshBtn_Click(sender As Object, e As EventArgs) Handles PRrefreshBtn.Click
        conn.Open()

        Dim cmd As New SQLiteCommand("select * from inventory_table ", conn)
        Dim reader As SQLiteDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        prductDGV3.DataSource = dt


        conn.Close()

    End Sub

    Private Sub AnalysisBtn_Click(sender As Object, e As EventArgs) Handles AnalysisBtn.Click
        TabControl1.SelectedTab = TabPage4
    End Sub










    Dim WithEvents pd As New PrintDocument
    Dim ppd As New PrintPreviewDialog


    ' Handle the PrintPage event of the PrintDocument
    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs) Handles pd.PrintPage
        Dim g As Graphics = e.Graphics
        Dim font As New Font("Arial", 10)
        Dim margin As Integer = 50
        Dim colCount As Integer = BillDGV.ColumnCount
        Dim rowCount As Integer = BillDGV.RowCount
        Dim dgvWidth As Integer = BillDGV.Width
        Dim dgvHeight As Integer = BillDGV.Height
        Static curPage As Integer = 0
        Static curRow As Integer = 0

        ' Calculate the number of pages
        Dim pages As Integer = Math.Ceiling(dgvHeight / (e.MarginBounds.Height - margin * 2))

        e.Graphics.DrawString("Footwear Shop", New Font("Arial", 22), Brushes.CadetBlue, 335, 35)
        e.Graphics.DrawString("***Bill***", New Font("Arial", 14), Brushes.Black, 350, 75)
        e.Graphics.DrawString("Customer Name      : " & CNameTBox.Text, New Font("Arial", 13), Brushes.Black, e.MarginBounds.Left, 100)
        e.Graphics.DrawString("Customer Phone No. : " & CPhoneTBox.Text, New Font("Arial", 13), Brushes.Black, e.MarginBounds.Left, 120)
        e.Graphics.DrawString("Transaction No.    : " & tid, New Font("Arial", 13), Brushes.Black, e.MarginBounds.Left, 140)
        e.Graphics.DrawString("Date    : " & DateString, New Font("Arial", 13), Brushes.Black, e.MarginBounds.Left, 160)



        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top + 100
        Dim cell As Rectangle

        For i As Integer = 0 To colCount - 1
            cell = New Rectangle(x, y, BillDGV.Columns(i).Width, BillDGV.ColumnHeadersHeight)
            g.DrawString(BillDGV.Columns(i).HeaderText, font, Brushes.Black, cell, StringFormat.GenericTypographic)
            x += cell.Width
        Next

        ' Draw the rows
        y += BillDGV.ColumnHeadersHeight
        For i As Integer = curRow To rowCount - 1
            If y + BillDGV.Rows(i).Height > e.MarginBounds.Bottom - margin Then
                ' The current row does not fit in the page, so print the current page and exit
                curRow = i
                curPage += 1
                e.HasMorePages = True
                Return
            End If
            x = e.MarginBounds.Left
            For j As Integer = 0 To colCount - 1
                cell = New Rectangle(x, y, BillDGV.Columns(j).Width, BillDGV.Rows(i).Height)
                g.DrawString(BillDGV(j, i).Value.ToString(), font, Brushes.Black, cell, StringFormat.GenericTypographic)
                x += cell.Width
            Next
            y += BillDGV.Rows(i).Height
        Next

        e.Graphics.DrawString("Total Amount :  " + GrandTotal.ToString(), New Font("Arial", 15), Brushes.Crimson, x - 250, y + 50)
        ' All rows have been printed, so reset the current page and the current row
        curPage = 0
        curRow = 0
        e.HasMorePages = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()

        Dim D1 = DateTimePicker5.Value
        Dim da1 As String = Format(D1, "yyyy-MM-dd")

        Dim D2 = DateTimePicker6.Value
        Dim da2 As String = Format(D2, "yyyy-MM-dd")



        Dim Query As String = "select user_group,sum(punits) As count , sum((selles_table.SPRICE - selles_table.cprice)*punits) as profit from selles_table,inventory_table where purchase_date >= DATE('" & da1 & "') AND Purchase_date <= DATE('" & da2 & "') and selles_table.pid = inventory_table.pid group by USER_GROUP"

        Dim cmd As New SQLiteCommand(Query, conn)
        Dim reader As SQLiteDataReader = cmd.ExecuteReader
        Dim DT As New DataTable
        DT.Load(reader)
        UserGroupGDV.DataSource = DT
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        If Regex.Match(TextBox1.Text, "\d", RegexOptions.ECMAScript).Success Then
            conn.Open()

            Dim Query As String = "select pid,punits,cprice,sprice,purchase_date,cname,cphone from selles_table where tid =  " & Integer.Parse(TextBox1.Text)
            Dim cmd As New SQLiteCommand(Query, conn)
            Dim reader As SQLiteDataReader = cmd.ExecuteReader
            Dim dt As New DataTable
            dt.Load(reader)
            TDGV1.DataSource = dt
            conn.Close()
        Else
            MsgBox("Please Enter valid transaction id",, "")
        End If




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn.Open()

        Dim Query As String = "select tid,pid,punits,cprice,sprice,purchase_date,cname,cphone from selles_table "
        Dim cmd As New SQLiteCommand(Query, conn)
        Dim reader As SQLiteDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        TDGV1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub pid2CBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pid2CBox.SelectedIndexChanged

    End Sub

    Private Sub SettingBtn_Click(sender As Object, e As EventArgs) Handles SettingBtn.Click
        Me.Hide()
        ChangePass.Show()
    End Sub
End Class
