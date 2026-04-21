<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePass))
        Label1 = New Label()
        id2TBox = New TextBox()
        pass2TBox = New TextBox()
        ChagnePassBtn = New Button()
        BackBtn = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(326, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 15)
        Label1.TabIndex = 0
        Label1.Text = "Change Login Password"
        ' 
        ' id2TBox
        ' 
        id2TBox.CharacterCasing = CharacterCasing.Upper
        id2TBox.Location = New Point(216, 170)
        id2TBox.Name = "id2TBox"
        id2TBox.Size = New Size(100, 23)
        id2TBox.TabIndex = 1
        ' 
        ' pass2TBox
        ' 
        pass2TBox.Location = New Point(433, 170)
        pass2TBox.Name = "pass2TBox"
        pass2TBox.Size = New Size(100, 23)
        pass2TBox.TabIndex = 1
        ' 
        ' ChagnePassBtn
        ' 
        ChagnePassBtn.Location = New Point(348, 233)
        ChagnePassBtn.Name = "ChagnePassBtn"
        ChagnePassBtn.Size = New Size(75, 23)
        ChagnePassBtn.TabIndex = 2
        ChagnePassBtn.Text = "Submit"
        ChagnePassBtn.UseVisualStyleBackColor = True
        ' 
        ' BackBtn
        ' 
        BackBtn.Location = New Point(16, 16)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(75, 23)
        BackBtn.TabIndex = 3
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(443, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(216, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 4
        Label3.Text = "User Id"
        ' 
        ' ChangePass
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BackBtn)
        Controls.Add(ChagnePassBtn)
        Controls.Add(pass2TBox)
        Controls.Add(id2TBox)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ChangePass"
        Text = "ChangePass"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents id2TBox As TextBox
    Friend WithEvents pass2TBox As TextBox
    Friend WithEvents ChagnePassBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
