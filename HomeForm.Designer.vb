<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        AnalysisBtn = New Button()
        Label7 = New Label()
        LOGO = New Label()
        transactionBtn = New Button()
        SearchBtn = New Button()
        SellBtn = New Button()
        InventoryBtn = New Button()
        ProductBtn = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TableLayoutPanel4 = New TableLayoutPanel()
        prductDGV3 = New DataGridView()
        Panel4 = New Panel()
        PRrefreshBtn = New Button()
        GoToProductEditFormBtn2 = New Button()
        GoToProductEditFormBtn = New Button()
        GoToAddProductFormBtn = New Button()
        TabPage2 = New TabPage()
        TableLayoutPanel3 = New TableLayoutPanel()
        Panel3 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        SPriceTBox = New TextBox()
        CPriceTBox = New TextBox()
        AddInventoryBtn = New Button()
        Ref = New Button()
        Label10 = New Label()
        ProcutUnitsTBox = New TextBox()
        Label19 = New Label()
        ComboBox1 = New ComboBox()
        DGVForInventory = New DataGridView()
        TabPage3 = New TabPage()
        TableLayoutPanel2 = New TableLayoutPanel()
        BillDGV = New DataGridView()
        No = New DataGridViewTextBoxColumn()
        Product_Name = New DataGridViewTextBoxColumn()
        Product_ID = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Units = New DataGridViewTextBoxColumn()
        Total_Price = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Label5 = New Label()
        GrandTotalLabel = New Label()
        CPhoneTBox = New TextBox()
        CNameTBox = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        GenerateBillBtn = New Button()
        RemoveFromBillBtn = New Button()
        Button5 = New Button()
        Label21 = New Label()
        Label20 = New Label()
        pUnits2TBox = New TextBox()
        pid2CBox = New ComboBox()
        TabPage4 = New TabPage()
        TabControl2 = New TabControl()
        TabPage8 = New TabPage()
        PPofitDGV = New DataGridView()
        ProfitLabel = New Label()
        ProfitCalculateBtn = New Button()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label22 = New Label()
        TabPage9 = New TabPage()
        PSellDGV = New DataGridView()
        TotalProductLabel = New Label()
        A2Btn = New Button()
        DateTimePicker3 = New DateTimePicker()
        DateTimePicker4 = New DateTimePicker()
        Label6 = New Label()
        TabPage6 = New TabPage()
        Button1 = New Button()
        DateTimePicker6 = New DateTimePicker()
        DateTimePicker5 = New DateTimePicker()
        UserGroupGDV = New DataGridView()
        TabPage5 = New TabPage()
        TableLayoutPanel5 = New TableLayoutPanel()
        TDGV1 = New DataGridView()
        Panel5 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(prductDGV3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        TabPage2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DGVForInventory, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(BillDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TabPage4.SuspendLayout()
        TabControl2.SuspendLayout()
        TabPage8.SuspendLayout()
        CType(PPofitDGV, ComponentModel.ISupportInitialize).BeginInit()
        TabPage9.SuspendLayout()
        CType(PSellDGV, ComponentModel.ISupportInitialize).BeginInit()
        TabPage6.SuspendLayout()
        CType(UserGroupGDV, ComponentModel.ISupportInitialize).BeginInit()
        TabPage5.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        CType(TDGV1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 71.5F))
        TableLayoutPanel1.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel1.Controls.Add(TabControl1, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(AnalysisBtn)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(LOGO)
        Panel2.Controls.Add(transactionBtn)
        Panel2.Controls.Add(SearchBtn)
        Panel2.Controls.Add(SellBtn)
        Panel2.Controls.Add(InventoryBtn)
        Panel2.Controls.Add(ProductBtn)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(222, 444)
        Panel2.TabIndex = 1
        ' 
        ' AnalysisBtn
        ' 
        AnalysisBtn.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        AnalysisBtn.BackColor = Color.FromArgb(CByte(213), CByte(213), CByte(255))
        AnalysisBtn.Location = New Point(41, 320)
        AnalysisBtn.Name = "AnalysisBtn"
        AnalysisBtn.Size = New Size(123, 39)
        AnalysisBtn.TabIndex = 4
        AnalysisBtn.Text = "Analysis"
        AnalysisBtn.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(9, 54)
        Label7.Name = "Label7"
        Label7.Size = New Size(205, 14)
        Label7.TabIndex = 3
        Label7.Text = "Inventory Managment System"
        ' 
        ' LOGO
        ' 
        LOGO.Anchor = AnchorStyles.Top
        LOGO.AutoSize = True
        LOGO.Font = New Font("Agbalumo", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        LOGO.Location = New Point(31, 20)
        LOGO.Name = "LOGO"
        LOGO.Size = New Size(158, 34)
        LOGO.TabIndex = 2
        LOGO.Text = "Footwear Shop"
        ' 
        ' transactionBtn
        ' 
        transactionBtn.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        transactionBtn.BackColor = Color.FromArgb(CByte(255), CByte(233), CByte(209))
        transactionBtn.Location = New Point(41, 381)
        transactionBtn.Name = "transactionBtn"
        transactionBtn.Size = New Size(123, 39)
        transactionBtn.TabIndex = 1
        transactionBtn.Text = "Bill Details"
        transactionBtn.UseVisualStyleBackColor = False
        ' 
        ' SearchBtn
        ' 
        SearchBtn.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        SearchBtn.BackColor = Color.FromArgb(CByte(212), CByte(241), CByte(239))
        SearchBtn.Location = New Point(41, 143)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(123, 39)
        SearchBtn.TabIndex = 0
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = False
        ' 
        ' SellBtn
        ' 
        SellBtn.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        SellBtn.BackColor = Color.FromArgb(CByte(213), CByte(241), CByte(229))
        SellBtn.Location = New Point(41, 259)
        SellBtn.Name = "SellBtn"
        SellBtn.Size = New Size(123, 39)
        SellBtn.TabIndex = 0
        SellBtn.Text = "Sell"
        SellBtn.UseVisualStyleBackColor = False
        ' 
        ' InventoryBtn
        ' 
        InventoryBtn.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        InventoryBtn.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(216))
        InventoryBtn.Location = New Point(41, 202)
        InventoryBtn.Name = "InventoryBtn"
        InventoryBtn.Size = New Size(123, 39)
        InventoryBtn.TabIndex = 0
        InventoryBtn.Text = "Inventory"
        InventoryBtn.UseVisualStyleBackColor = False
        ' 
        ' ProductBtn
        ' 
        ProductBtn.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ProductBtn.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(233))
        ProductBtn.Location = New Point(41, 88)
        ProductBtn.Name = "ProductBtn"
        ProductBtn.Size = New Size(123, 39)
        ProductBtn.TabIndex = 0
        ProductBtn.Text = "Product Section"
        ProductBtn.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(231, 3)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(566, 444)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(233))
        TabPage1.Controls.Add(TableLayoutPanel4)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(558, 416)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(prductDGV3, 0, 1)
        TableLayoutPanel4.Controls.Add(Panel4, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 10.97561F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 89.02439F))
        TableLayoutPanel4.Size = New Size(552, 410)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' prductDGV3
        ' 
        prductDGV3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        prductDGV3.Dock = DockStyle.Fill
        prductDGV3.Location = New Point(3, 48)
        prductDGV3.Name = "prductDGV3"
        prductDGV3.RowTemplate.Height = 25
        prductDGV3.Size = New Size(546, 359)
        prductDGV3.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(PRrefreshBtn)
        Panel4.Controls.Add(GoToProductEditFormBtn2)
        Panel4.Controls.Add(GoToProductEditFormBtn)
        Panel4.Controls.Add(GoToAddProductFormBtn)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(3, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(546, 39)
        Panel4.TabIndex = 1
        ' 
        ' PRrefreshBtn
        ' 
        PRrefreshBtn.Anchor = AnchorStyles.None
        PRrefreshBtn.Location = New Point(411, 6)
        PRrefreshBtn.Name = "PRrefreshBtn"
        PRrefreshBtn.Size = New Size(75, 23)
        PRrefreshBtn.TabIndex = 2
        PRrefreshBtn.Text = "Refresh"
        PRrefreshBtn.UseVisualStyleBackColor = True
        ' 
        ' GoToProductEditFormBtn2
        ' 
        GoToProductEditFormBtn2.Anchor = AnchorStyles.None
        GoToProductEditFormBtn2.Location = New Point(292, 6)
        GoToProductEditFormBtn2.Name = "GoToProductEditFormBtn2"
        GoToProductEditFormBtn2.Size = New Size(75, 23)
        GoToProductEditFormBtn2.TabIndex = 1
        GoToProductEditFormBtn2.Text = "Delete"
        GoToProductEditFormBtn2.UseVisualStyleBackColor = True
        ' 
        ' GoToProductEditFormBtn
        ' 
        GoToProductEditFormBtn.Anchor = AnchorStyles.None
        GoToProductEditFormBtn.Location = New Point(169, 6)
        GoToProductEditFormBtn.Name = "GoToProductEditFormBtn"
        GoToProductEditFormBtn.Size = New Size(75, 23)
        GoToProductEditFormBtn.TabIndex = 1
        GoToProductEditFormBtn.Text = "Edit"
        GoToProductEditFormBtn.UseVisualStyleBackColor = True
        ' 
        ' GoToAddProductFormBtn
        ' 
        GoToAddProductFormBtn.Anchor = AnchorStyles.None
        GoToAddProductFormBtn.Location = New Point(61, 6)
        GoToAddProductFormBtn.Name = "GoToAddProductFormBtn"
        GoToAddProductFormBtn.Size = New Size(75, 23)
        GoToAddProductFormBtn.TabIndex = 0
        GoToAddProductFormBtn.Text = "Add"
        GoToAddProductFormBtn.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        TabPage2.Controls.Add(TableLayoutPanel3)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(558, 416)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Panel3, 0, 0)
        TableLayoutPanel3.Controls.Add(DGVForInventory, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 35.8536568F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 64.14634F))
        TableLayoutPanel3.Size = New Size(552, 410)
        TableLayoutPanel3.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(216))
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(SPriceTBox)
        Panel3.Controls.Add(CPriceTBox)
        Panel3.Controls.Add(AddInventoryBtn)
        Panel3.Controls.Add(Ref)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(ProcutUnitsTBox)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(546, 140)
        Panel3.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(339, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 8
        Label2.Text = "Selling Price"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(339, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 8
        Label1.Text = "Cost Price"
        ' 
        ' SPriceTBox
        ' 
        SPriceTBox.Anchor = AnchorStyles.None
        SPriceTBox.Location = New Point(424, 55)
        SPriceTBox.Name = "SPriceTBox"
        SPriceTBox.Size = New Size(100, 23)
        SPriceTBox.TabIndex = 7
        ' 
        ' CPriceTBox
        ' 
        CPriceTBox.Anchor = AnchorStyles.None
        CPriceTBox.Location = New Point(424, 15)
        CPriceTBox.Name = "CPriceTBox"
        CPriceTBox.Size = New Size(100, 23)
        CPriceTBox.TabIndex = 6
        ' 
        ' AddInventoryBtn
        ' 
        AddInventoryBtn.Anchor = AnchorStyles.None
        AddInventoryBtn.Location = New Point(301, 103)
        AddInventoryBtn.Name = "AddInventoryBtn"
        AddInventoryBtn.Size = New Size(75, 23)
        AddInventoryBtn.TabIndex = 5
        AddInventoryBtn.Text = "Add"
        AddInventoryBtn.UseVisualStyleBackColor = True
        ' 
        ' Ref
        ' 
        Ref.Anchor = AnchorStyles.None
        Ref.Location = New Point(193, 103)
        Ref.Name = "Ref"
        Ref.Size = New Size(75, 23)
        Ref.TabIndex = 4
        Ref.Text = "Refresh"
        Ref.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Location = New Point(27, 18)
        Label10.Name = "Label10"
        Label10.Size = New Size(83, 15)
        Label10.TabIndex = 1
        Label10.Text = "Select Product"
        ' 
        ' ProcutUnitsTBox
        ' 
        ProcutUnitsTBox.Anchor = AnchorStyles.None
        ProcutUnitsTBox.Location = New Point(167, 57)
        ProcutUnitsTBox.Name = "ProcutUnitsTBox"
        ProcutUnitsTBox.Size = New Size(121, 23)
        ProcutUnitsTBox.TabIndex = 3
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.None
        Label19.AutoSize = True
        Label19.Location = New Point(27, 60)
        Label19.Name = "Label19"
        Label19.Size = New Size(34, 15)
        Label19.TabIndex = 2
        Label19.Text = "Units"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(167, 15)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' DGVForInventory
        ' 
        DGVForInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVForInventory.Dock = DockStyle.Fill
        DGVForInventory.Location = New Point(3, 149)
        DGVForInventory.Name = "DGVForInventory"
        DGVForInventory.RowTemplate.Height = 25
        DGVForInventory.Size = New Size(546, 258)
        DGVForInventory.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(213), CByte(241), CByte(229))
        TabPage3.Controls.Add(TableLayoutPanel2)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(558, 416)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(BillDGV, 0, 1)
        TableLayoutPanel2.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 186F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(552, 410)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' BillDGV
        ' 
        BillDGV.AllowUserToAddRows = False
        BillDGV.AllowUserToDeleteRows = False
        BillDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BillDGV.Columns.AddRange(New DataGridViewColumn() {No, Product_Name, Product_ID, Price, Units, Total_Price})
        BillDGV.Dock = DockStyle.Fill
        BillDGV.Location = New Point(3, 189)
        BillDGV.Name = "BillDGV"
        BillDGV.ReadOnly = True
        BillDGV.RowHeadersWidth = 4
        BillDGV.RowTemplate.Height = 25
        BillDGV.Size = New Size(546, 218)
        BillDGV.TabIndex = 0
        ' 
        ' No
        ' 
        No.HeaderText = "No"
        No.Name = "No"
        No.ReadOnly = True
        No.Width = 48
        ' 
        ' Product_Name
        ' 
        Product_Name.HeaderText = "Product_Name"
        Product_Name.Name = "Product_Name"
        Product_Name.ReadOnly = True
        Product_Name.Width = 111
        ' 
        ' Product_ID
        ' 
        Product_ID.HeaderText = "Product_ID"
        Product_ID.Name = "Product_ID"
        Product_ID.ReadOnly = True
        Product_ID.Width = 90
        ' 
        ' Price
        ' 
        Price.HeaderText = "Price"
        Price.Name = "Price"
        Price.ReadOnly = True
        Price.Width = 58
        ' 
        ' Units
        ' 
        Units.HeaderText = "Units"
        Units.Name = "Units"
        Units.ReadOnly = True
        Units.Width = 59
        ' 
        ' Total_Price
        ' 
        Total_Price.HeaderText = "Total_Price"
        Total_Price.Name = "Total_Price"
        Total_Price.ReadOnly = True
        Total_Price.Width = 88
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(GrandTotalLabel)
        Panel1.Controls.Add(CPhoneTBox)
        Panel1.Controls.Add(CNameTBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(GenerateBillBtn)
        Panel1.Controls.Add(RemoveFromBillBtn)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(pUnits2TBox)
        Panel1.Controls.Add(pid2CBox)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(546, 180)
        Panel1.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Location = New Point(376, 159)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 10
        Label5.Text = "Grand Total"
        ' 
        ' GrandTotalLabel
        ' 
        GrandTotalLabel.Anchor = AnchorStyles.None
        GrandTotalLabel.AutoSize = True
        GrandTotalLabel.Location = New Point(458, 159)
        GrandTotalLabel.Name = "GrandTotalLabel"
        GrandTotalLabel.Size = New Size(25, 15)
        GrandTotalLabel.TabIndex = 9
        GrandTotalLabel.Text = "000"
        ' 
        ' CPhoneTBox
        ' 
        CPhoneTBox.Anchor = AnchorStyles.None
        CPhoneTBox.Location = New Point(146, 37)
        CPhoneTBox.Name = "CPhoneTBox"
        CPhoneTBox.Size = New Size(121, 23)
        CPhoneTBox.TabIndex = 8
        ' 
        ' CNameTBox
        ' 
        CNameTBox.Anchor = AnchorStyles.None
        CNameTBox.Location = New Point(145, 8)
        CNameTBox.Name = "CNameTBox"
        CNameTBox.Size = New Size(121, 23)
        CNameTBox.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(22, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 15)
        Label4.TabIndex = 7
        Label4.Text = "Customer Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(22, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 15)
        Label3.TabIndex = 7
        Label3.Text = "Customer Phone"
        ' 
        ' GenerateBillBtn
        ' 
        GenerateBillBtn.Anchor = AnchorStyles.None
        GenerateBillBtn.Location = New Point(360, 90)
        GenerateBillBtn.Name = "GenerateBillBtn"
        GenerateBillBtn.Size = New Size(124, 23)
        GenerateBillBtn.TabIndex = 6
        GenerateBillBtn.Text = "Generate Bill"
        GenerateBillBtn.UseVisualStyleBackColor = True
        ' 
        ' RemoveFromBillBtn
        ' 
        RemoveFromBillBtn.Anchor = AnchorStyles.None
        RemoveFromBillBtn.Location = New Point(360, 57)
        RemoveFromBillBtn.Name = "RemoveFromBillBtn"
        RemoveFromBillBtn.Size = New Size(124, 23)
        RemoveFromBillBtn.TabIndex = 5
        RemoveFromBillBtn.Text = "Remove From Bill"
        RemoveFromBillBtn.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.Location = New Point(360, 15)
        Button5.Name = "Button5"
        Button5.Size = New Size(124, 23)
        Button5.TabIndex = 4
        Button5.Text = "Add To Bill"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.None
        Label21.AutoSize = True
        Label21.Location = New Point(22, 112)
        Label21.Name = "Label21"
        Label21.Size = New Size(98, 15)
        Label21.TabIndex = 3
        Label21.Text = "Product Quantity"
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.None
        Label20.AutoSize = True
        Label20.Location = New Point(22, 80)
        Label20.Name = "Label20"
        Label20.Size = New Size(62, 15)
        Label20.TabIndex = 2
        Label20.Text = "Product Id"
        ' 
        ' pUnits2TBox
        ' 
        pUnits2TBox.Anchor = AnchorStyles.None
        pUnits2TBox.Location = New Point(145, 104)
        pUnits2TBox.Name = "pUnits2TBox"
        pUnits2TBox.Size = New Size(121, 23)
        pUnits2TBox.TabIndex = 1
        ' 
        ' pid2CBox
        ' 
        pid2CBox.Anchor = AnchorStyles.None
        pid2CBox.FormattingEnabled = True
        pid2CBox.Location = New Point(146, 72)
        pid2CBox.Name = "pid2CBox"
        pid2CBox.Size = New Size(121, 23)
        pid2CBox.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(TabControl2)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(558, 416)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TabControl2
        ' 
        TabControl2.Controls.Add(TabPage8)
        TabControl2.Controls.Add(TabPage9)
        TabControl2.Controls.Add(TabPage6)
        TabControl2.Dock = DockStyle.Fill
        TabControl2.Location = New Point(3, 3)
        TabControl2.Name = "TabControl2"
        TabControl2.SelectedIndex = 0
        TabControl2.Size = New Size(552, 410)
        TabControl2.TabIndex = 3
        ' 
        ' TabPage8
        ' 
        TabPage8.BackColor = Color.FromArgb(CByte(213), CByte(213), CByte(255))
        TabPage8.Controls.Add(PPofitDGV)
        TabPage8.Controls.Add(ProfitLabel)
        TabPage8.Controls.Add(ProfitCalculateBtn)
        TabPage8.Controls.Add(DateTimePicker1)
        TabPage8.Controls.Add(DateTimePicker2)
        TabPage8.Controls.Add(Label22)
        TabPage8.Location = New Point(4, 24)
        TabPage8.Name = "TabPage8"
        TabPage8.Padding = New Padding(3)
        TabPage8.Size = New Size(544, 382)
        TabPage8.TabIndex = 0
        TabPage8.Text = "_Profit_"
        ' 
        ' PPofitDGV
        ' 
        PPofitDGV.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PPofitDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PPofitDGV.Location = New Point(3, 126)
        PPofitDGV.Name = "PPofitDGV"
        PPofitDGV.RowTemplate.Height = 25
        PPofitDGV.Size = New Size(538, 253)
        PPofitDGV.TabIndex = 5
        ' 
        ' ProfitLabel
        ' 
        ProfitLabel.Anchor = AnchorStyles.Top
        ProfitLabel.AutoSize = True
        ProfitLabel.Location = New Point(293, 92)
        ProfitLabel.Name = "ProfitLabel"
        ProfitLabel.Size = New Size(31, 15)
        ProfitLabel.TabIndex = 4
        ProfitLabel.Text = "0000"
        ' 
        ' ProfitCalculateBtn
        ' 
        ProfitCalculateBtn.Anchor = AnchorStyles.Top
        ProfitCalculateBtn.Location = New Point(413, 51)
        ProfitCalculateBtn.Name = "ProfitCalculateBtn"
        ProfitCalculateBtn.Size = New Size(94, 23)
        ProfitCalculateBtn.TabIndex = 3
        ProfitCalculateBtn.Text = "Calculate"
        ProfitCalculateBtn.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Top
        DateTimePicker1.Location = New Point(27, 51)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(139, 23)
        DateTimePicker1.TabIndex = 1
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Anchor = AnchorStyles.Top
        DateTimePicker2.Location = New Point(209, 49)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(164, 23)
        DateTimePicker2.TabIndex = 2
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Top
        Label22.AutoSize = True
        Label22.Location = New Point(199, 92)
        Label22.Name = "Label22"
        Label22.Size = New Size(36, 15)
        Label22.TabIndex = 0
        Label22.Text = "Profit"
        ' 
        ' TabPage9
        ' 
        TabPage9.BackColor = Color.FromArgb(CByte(210), CByte(193), CByte(255))
        TabPage9.Controls.Add(PSellDGV)
        TabPage9.Controls.Add(TotalProductLabel)
        TabPage9.Controls.Add(A2Btn)
        TabPage9.Controls.Add(DateTimePicker3)
        TabPage9.Controls.Add(DateTimePicker4)
        TabPage9.Controls.Add(Label6)
        TabPage9.Location = New Point(4, 24)
        TabPage9.Name = "TabPage9"
        TabPage9.Padding = New Padding(3)
        TabPage9.Size = New Size(544, 382)
        TabPage9.TabIndex = 1
        TabPage9.Text = "_Count_"
        ' 
        ' PSellDGV
        ' 
        PSellDGV.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PSellDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PSellDGV.Location = New Point(3, 148)
        PSellDGV.Name = "PSellDGV"
        PSellDGV.RowTemplate.Height = 25
        PSellDGV.Size = New Size(538, 231)
        PSellDGV.TabIndex = 10
        ' 
        ' TotalProductLabel
        ' 
        TotalProductLabel.Anchor = AnchorStyles.Top
        TotalProductLabel.AutoSize = True
        TotalProductLabel.Location = New Point(289, 111)
        TotalProductLabel.Name = "TotalProductLabel"
        TotalProductLabel.Size = New Size(37, 15)
        TotalProductLabel.TabIndex = 9
        TotalProductLabel.Text = "00000"
        ' 
        ' A2Btn
        ' 
        A2Btn.Anchor = AnchorStyles.Top
        A2Btn.Location = New Point(429, 51)
        A2Btn.Name = "A2Btn"
        A2Btn.Size = New Size(75, 23)
        A2Btn.TabIndex = 8
        A2Btn.Text = "Calculate"
        A2Btn.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Anchor = AnchorStyles.Top
        DateTimePicker3.Location = New Point(40, 51)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(139, 23)
        DateTimePicker3.TabIndex = 6
        ' 
        ' DateTimePicker4
        ' 
        DateTimePicker4.Anchor = AnchorStyles.Top
        DateTimePicker4.Location = New Point(221, 51)
        DateTimePicker4.Name = "DateTimePicker4"
        DateTimePicker4.Size = New Size(164, 23)
        DateTimePicker4.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Location = New Point(163, 111)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 15)
        Label6.TabIndex = 5
        Label6.Text = "Total Product Sell"
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(Button1)
        TabPage6.Controls.Add(DateTimePicker6)
        TabPage6.Controls.Add(DateTimePicker5)
        TabPage6.Controls.Add(UserGroupGDV)
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(544, 382)
        TabPage6.TabIndex = 2
        TabPage6.Text = "_Category_Wise_"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(420, 37)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker6
        ' 
        DateTimePicker6.Location = New Point(198, 37)
        DateTimePicker6.Name = "DateTimePicker6"
        DateTimePicker6.Size = New Size(122, 23)
        DateTimePicker6.TabIndex = 2
        ' 
        ' DateTimePicker5
        ' 
        DateTimePicker5.Location = New Point(56, 37)
        DateTimePicker5.Name = "DateTimePicker5"
        DateTimePicker5.Size = New Size(119, 23)
        DateTimePicker5.TabIndex = 1
        ' 
        ' UserGroupGDV
        ' 
        UserGroupGDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UserGroupGDV.Location = New Point(6, 92)
        UserGroupGDV.Name = "UserGroupGDV"
        UserGroupGDV.RowTemplate.Height = 25
        UserGroupGDV.Size = New Size(532, 284)
        UserGroupGDV.TabIndex = 0
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(TableLayoutPanel5)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Margin = New Padding(0)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(558, 416)
        TabPage5.TabIndex = 4
        TabPage5.Text = "TabPage5"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(TDGV1, 0, 1)
        TableLayoutPanel5.Controls.Add(Panel5, 0, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 3)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 23.6585369F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 76.34146F))
        TableLayoutPanel5.Size = New Size(552, 410)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' TDGV1
        ' 
        TDGV1.AllowUserToAddRows = False
        TDGV1.AllowUserToDeleteRows = False
        TDGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TDGV1.Dock = DockStyle.Fill
        TDGV1.Location = New Point(0, 97)
        TDGV1.Margin = New Padding(0)
        TDGV1.Name = "TDGV1"
        TDGV1.ReadOnly = True
        TDGV1.RowTemplate.Height = 25
        TDGV1.Size = New Size(552, 313)
        TDGV1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(255), CByte(233), CByte(209))
        Panel5.Controls.Add(Button3)
        Panel5.Controls.Add(Button2)
        Panel5.Controls.Add(TextBox1)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(0, 0)
        Panel5.Margin = New Padding(0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(552, 97)
        Panel5.TabIndex = 1
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(453, 36)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 2
        Button3.Text = "See All"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(345, 37)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "Search"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(82, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(206, 23)
        TextBox1.TabIndex = 0
        ' 
        ' HomeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "HomeForm"
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        CType(prductDGV3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DGVForInventory, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        CType(BillDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabControl2.ResumeLayout(False)
        TabPage8.ResumeLayout(False)
        TabPage8.PerformLayout()
        CType(PPofitDGV, ComponentModel.ISupportInitialize).EndInit()
        TabPage9.ResumeLayout(False)
        TabPage9.PerformLayout()
        CType(PSellDGV, ComponentModel.ISupportInitialize).EndInit()
        TabPage6.ResumeLayout(False)
        CType(UserGroupGDV, ComponentModel.ISupportInitialize).EndInit()
        TabPage5.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        CType(TDGV1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SellBtn As Button
    Friend WithEvents InventoryBtn As Button
    Friend WithEvents ProductBtn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ProcutUnitsTBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BillDGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pid2CBox As ComboBox
    Friend WithEvents RemoveFromBillBtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents pUnits2TBox As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DGVForInventory As DataGridView
    Friend WithEvents GenerateBillBtn As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents SearchBtn As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Ref As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents prductDGV3 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GoToProductEditFormBtn As Button
    Friend WithEvents GoToAddProductFormBtn As Button
    Friend WithEvents GoToProductEditFormBtn2 As Button
    Friend WithEvents CPriceTBox As TextBox
    Friend WithEvents AddInventoryBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SPriceTBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CPhoneTBox As TextBox
    Friend WithEvents CNameTBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GrandTotalLabel As Label
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents Product_ID As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Units As DataGridViewTextBoxColumn
    Friend WithEvents Total_Price As DataGridViewTextBoxColumn
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents ProfitCalculateBtn As Button
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents ProfitLabel As Label
    Friend WithEvents TotalProductLabel As Label
    Friend WithEvents A2Btn As Button
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents PSellDGV As DataGridView
    Friend WithEvents PPofitDGV As DataGridView
    Friend WithEvents transactionBtn As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TDGV1 As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PRrefreshBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LOGO As Label
    Friend WithEvents AnalysisBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker6 As DateTimePicker
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents UserGroupGDV As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button

End Class
