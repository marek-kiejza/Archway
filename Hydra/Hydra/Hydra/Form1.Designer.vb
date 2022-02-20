<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me._vaultUsername = New System.Windows.Forms.TextBox()
        Me._vaultPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vault username "
        '
        '_vaultUsername
        '
        Me._vaultUsername.Location = New System.Drawing.Point(256, 77)
        Me._vaultUsername.Name = "_vaultUsername"
        Me._vaultUsername.Size = New System.Drawing.Size(100, 20)
        Me._vaultUsername.TabIndex = 1
        '
        '_vaultPassword
        '
        Me._vaultPassword.Location = New System.Drawing.Point(256, 123)
        Me._vaultPassword.Name = "_vaultPassword"
        Me._vaultPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._vaultPassword.Size = New System.Drawing.Size(100, 20)
        Me._vaultPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vault password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(397, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Get Product Categories (commodityGroup)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(392, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Get Financial Account"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(397, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(247, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Get Commodity Identifiers (Parts)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(392, 281)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(247, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "What are commodities"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 494)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._vaultPassword)
        Me.Controls.Add(Me._vaultUsername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents _vaultUsername As TextBox
    Friend WithEvents _vaultPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
