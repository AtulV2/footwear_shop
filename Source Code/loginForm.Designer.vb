<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        idTBox = New TextBox()
        passTBox = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(148, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 30)
        Label1.TabIndex = 0
        Label1.Text = "User ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(139, 225)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 30)
        Label2.TabIndex = 0
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(243, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 30)
        Label3.TabIndex = 1
        Label3.Text = "Enter Login Details"
        ' 
        ' idTBox
        ' 
        idTBox.CharacterCasing = CharacterCasing.Upper
        idTBox.Location = New Point(340, 134)
        idTBox.Name = "idTBox"
        idTBox.Size = New Size(189, 35)
        idTBox.TabIndex = 2
        ' 
        ' passTBox
        ' 
        passTBox.Location = New Point(340, 225)
        passTBox.Name = "passTBox"
        passTBox.Size = New Size(189, 35)
        passTBox.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(276, 308)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 41)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(680, 418)
        Controls.Add(Button1)
        Controls.Add(passTBox)
        Controls.Add(idTBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 6, 5, 6)
        Name = "loginForm"
        Text = "loginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents idTBox As TextBox
    Friend WithEvents passTBox As TextBox
    Friend WithEvents Button1 As Button
End Class
