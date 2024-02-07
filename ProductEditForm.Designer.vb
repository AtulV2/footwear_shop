<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductEditForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        EditBtn = New Button()
        Closure_TypeTBox = New TextBox()
        Sole_MaterialTBox = New TextBox()
        Water_Resistance_LevelTBox = New TextBox()
        Outer_MaterialTBox = New TextBox()
        Hile_TypeTBox = New TextBox()
        PBrandTBox = New TextBox()
        User_GroupTBox = New TextBox()
        PSizeTBox = New TextBox()
        Product_TypeTBox = New TextBox()
        PStyle_NameTBox = New TextBox()
        PColorTBox = New TextBox()
        PNameTBox = New TextBox()
        Closure_TypeLabel = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Label3 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label7 = New Label()
        Label12 = New Label()
        Label6 = New Label()
        Label11 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        SearchBtn = New Button()
        DeleteBtn = New Button()
        BackBtn2 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(271, 40)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(137, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Location = New Point(126, 43)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter Product id"
        ' 
        ' EditBtn
        ' 
        EditBtn.Anchor = AnchorStyles.Top
        EditBtn.Location = New Point(428, 401)
        EditBtn.Margin = New Padding(4)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(85, 30)
        EditBtn.TabIndex = 61
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = True
        ' 
        ' Closure_TypeTBox
        ' 
        Closure_TypeTBox.Anchor = AnchorStyles.Top
        Closure_TypeTBox.CharacterCasing = CharacterCasing.Lower
        Closure_TypeTBox.Location = New Point(518, 314)
        Closure_TypeTBox.Margin = New Padding(4)
        Closure_TypeTBox.Name = "Closure_TypeTBox"
        Closure_TypeTBox.Size = New Size(113, 27)
        Closure_TypeTBox.TabIndex = 59
        ' 
        ' Sole_MaterialTBox
        ' 
        Sole_MaterialTBox.Anchor = AnchorStyles.Top
        Sole_MaterialTBox.CharacterCasing = CharacterCasing.Lower
        Sole_MaterialTBox.Location = New Point(518, 199)
        Sole_MaterialTBox.Margin = New Padding(4)
        Sole_MaterialTBox.Name = "Sole_MaterialTBox"
        Sole_MaterialTBox.Size = New Size(113, 27)
        Sole_MaterialTBox.TabIndex = 58
        ' 
        ' Water_Resistance_LevelTBox
        ' 
        Water_Resistance_LevelTBox.Anchor = AnchorStyles.Top
        Water_Resistance_LevelTBox.CharacterCasing = CharacterCasing.Lower
        Water_Resistance_LevelTBox.Location = New Point(518, 252)
        Water_Resistance_LevelTBox.Margin = New Padding(4)
        Water_Resistance_LevelTBox.Name = "Water_Resistance_LevelTBox"
        Water_Resistance_LevelTBox.Size = New Size(113, 27)
        Water_Resistance_LevelTBox.TabIndex = 57
        ' 
        ' Outer_MaterialTBox
        ' 
        Outer_MaterialTBox.Anchor = AnchorStyles.Top
        Outer_MaterialTBox.CharacterCasing = CharacterCasing.Lower
        Outer_MaterialTBox.Location = New Point(518, 135)
        Outer_MaterialTBox.Margin = New Padding(4)
        Outer_MaterialTBox.Name = "Outer_MaterialTBox"
        Outer_MaterialTBox.Size = New Size(113, 27)
        Outer_MaterialTBox.TabIndex = 56
        ' 
        ' Hile_TypeTBox
        ' 
        Hile_TypeTBox.Anchor = AnchorStyles.Top
        Hile_TypeTBox.CharacterCasing = CharacterCasing.Lower
        Hile_TypeTBox.Location = New Point(150, 542)
        Hile_TypeTBox.Margin = New Padding(4)
        Hile_TypeTBox.Name = "Hile_TypeTBox"
        Hile_TypeTBox.Size = New Size(113, 27)
        Hile_TypeTBox.TabIndex = 55
        ' 
        ' PBrandTBox
        ' 
        PBrandTBox.Anchor = AnchorStyles.Top
        PBrandTBox.CharacterCasing = CharacterCasing.Lower
        PBrandTBox.Location = New Point(150, 303)
        PBrandTBox.Margin = New Padding(4)
        PBrandTBox.Name = "PBrandTBox"
        PBrandTBox.Size = New Size(113, 27)
        PBrandTBox.TabIndex = 54
        ' 
        ' User_GroupTBox
        ' 
        User_GroupTBox.Anchor = AnchorStyles.Top
        User_GroupTBox.CharacterCasing = CharacterCasing.Lower
        User_GroupTBox.Location = New Point(150, 428)
        User_GroupTBox.Margin = New Padding(4)
        User_GroupTBox.Name = "User_GroupTBox"
        User_GroupTBox.Size = New Size(113, 27)
        User_GroupTBox.TabIndex = 53
        ' 
        ' PSizeTBox
        ' 
        PSizeTBox.Anchor = AnchorStyles.Top
        PSizeTBox.CharacterCasing = CharacterCasing.Lower
        PSizeTBox.Location = New Point(150, 189)
        PSizeTBox.Margin = New Padding(4)
        PSizeTBox.Name = "PSizeTBox"
        PSizeTBox.Size = New Size(113, 27)
        PSizeTBox.TabIndex = 52
        ' 
        ' Product_TypeTBox
        ' 
        Product_TypeTBox.Anchor = AnchorStyles.Top
        Product_TypeTBox.CharacterCasing = CharacterCasing.Lower
        Product_TypeTBox.Location = New Point(150, 481)
        Product_TypeTBox.Margin = New Padding(4)
        Product_TypeTBox.Name = "Product_TypeTBox"
        Product_TypeTBox.Size = New Size(113, 27)
        Product_TypeTBox.TabIndex = 51
        ' 
        ' PStyle_NameTBox
        ' 
        PStyle_NameTBox.Anchor = AnchorStyles.Top
        PStyle_NameTBox.CharacterCasing = CharacterCasing.Lower
        PStyle_NameTBox.Location = New Point(150, 242)
        PStyle_NameTBox.Margin = New Padding(4)
        PStyle_NameTBox.Name = "PStyle_NameTBox"
        PStyle_NameTBox.Size = New Size(113, 27)
        PStyle_NameTBox.TabIndex = 50
        ' 
        ' PColorTBox
        ' 
        PColorTBox.Anchor = AnchorStyles.Top
        PColorTBox.CharacterCasing = CharacterCasing.Lower
        PColorTBox.Location = New Point(150, 366)
        PColorTBox.Margin = New Padding(4)
        PColorTBox.Name = "PColorTBox"
        PColorTBox.Size = New Size(113, 27)
        PColorTBox.TabIndex = 49
        ' 
        ' PNameTBox
        ' 
        PNameTBox.Anchor = AnchorStyles.Top
        PNameTBox.CharacterCasing = CharacterCasing.Lower
        PNameTBox.Location = New Point(150, 128)
        PNameTBox.Margin = New Padding(4)
        PNameTBox.Name = "PNameTBox"
        PNameTBox.Size = New Size(113, 27)
        PNameTBox.TabIndex = 60
        ' 
        ' Closure_TypeLabel
        ' 
        Closure_TypeLabel.Anchor = AnchorStyles.Top
        Closure_TypeLabel.AutoSize = True
        Closure_TypeLabel.Location = New Point(355, 314)
        Closure_TypeLabel.Margin = New Padding(4, 0, 4, 0)
        Closure_TypeLabel.Name = "Closure_TypeLabel"
        Closure_TypeLabel.Size = New Size(93, 20)
        Closure_TypeLabel.TabIndex = 47
        Closure_TypeLabel.Text = "Closure Type"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Location = New Point(355, 199)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 20)
        Label5.TabIndex = 46
        Label5.Text = "Sole Material Type"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Location = New Point(354, 256)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(159, 20)
        Label8.TabIndex = 45
        Label8.Text = "Water Resistance Level"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Location = New Point(354, 142)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 20)
        Label3.TabIndex = 44
        Label3.Text = "Outer Material Type"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top
        Label14.AutoSize = True
        Label14.Location = New Point(30, 546)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(91, 20)
        Label14.TabIndex = 43
        Label14.Text = "Hile (inches)"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top
        Label13.AutoSize = True
        Label13.Location = New Point(30, 485)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(95, 20)
        Label13.TabIndex = 42
        Label13.Text = "Product Type"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Location = New Point(30, 308)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 20)
        Label7.TabIndex = 41
        Label7.Text = "Brand"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.Location = New Point(30, 431)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(83, 20)
        Label12.TabIndex = 40
        Label12.Text = "User Group"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Location = New Point(30, 246)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 20)
        Label6.TabIndex = 39
        Label6.Text = "Style Name"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Location = New Point(30, 370)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(45, 20)
        Label11.TabIndex = 38
        Label11.Text = "Color"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Location = New Point(30, 192)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 37
        Label4.Text = "Size"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(30, 131)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 48
        Label2.Text = "Product Name"
        ' 
        ' SearchBtn
        ' 
        SearchBtn.Anchor = AnchorStyles.Top
        SearchBtn.Location = New Point(448, 40)
        SearchBtn.Margin = New Padding(4)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(85, 30)
        SearchBtn.TabIndex = 62
        SearchBtn.Text = "Seach"
        SearchBtn.UseVisualStyleBackColor = True
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.Anchor = AnchorStyles.Top
        DeleteBtn.Location = New Point(428, 470)
        DeleteBtn.Margin = New Padding(4)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(85, 30)
        DeleteBtn.TabIndex = 63
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' BackBtn2
        ' 
        BackBtn2.Anchor = AnchorStyles.Top
        BackBtn2.Location = New Point(428, 542)
        BackBtn2.Margin = New Padding(4)
        BackBtn2.Name = "BackBtn2"
        BackBtn2.Size = New Size(85, 30)
        BackBtn2.TabIndex = 64
        BackBtn2.Text = "Back"
        BackBtn2.UseVisualStyleBackColor = True
        ' 
        ' ProductEditForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(658, 610)
        Controls.Add(BackBtn2)
        Controls.Add(DeleteBtn)
        Controls.Add(SearchBtn)
        Controls.Add(EditBtn)
        Controls.Add(Closure_TypeTBox)
        Controls.Add(Sole_MaterialTBox)
        Controls.Add(Water_Resistance_LevelTBox)
        Controls.Add(Outer_MaterialTBox)
        Controls.Add(Hile_TypeTBox)
        Controls.Add(PBrandTBox)
        Controls.Add(User_GroupTBox)
        Controls.Add(PSizeTBox)
        Controls.Add(Product_TypeTBox)
        Controls.Add(PStyle_NameTBox)
        Controls.Add(PColorTBox)
        Controls.Add(PNameTBox)
        Controls.Add(Closure_TypeLabel)
        Controls.Add(Label5)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label7)
        Controls.Add(Label12)
        Controls.Add(Label6)
        Controls.Add(Label11)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "ProductEditForm"
        Text = "ProductEditForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EditBtn As Button
    Friend WithEvents Closure_TypeTBox As TextBox
    Friend WithEvents Sole_MaterialTBox As TextBox
    Friend WithEvents Water_Resistance_LevelTBox As TextBox
    Friend WithEvents Outer_MaterialTBox As TextBox
    Friend WithEvents Hile_TypeTBox As TextBox
    Friend WithEvents PBrandTBox As TextBox
    Friend WithEvents User_GroupTBox As TextBox
    Friend WithEvents PSizeTBox As TextBox
    Friend WithEvents Product_TypeTBox As TextBox
    Friend WithEvents PStyle_NameTBox As TextBox
    Friend WithEvents PColorTBox As TextBox
    Friend WithEvents PNameTBox As TextBox
    Friend WithEvents Closure_TypeLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents BackBtn2 As Button
End Class
