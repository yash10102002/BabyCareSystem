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
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.l1 = New System.Windows.Forms.Label()
        Me.l2 = New System.Windows.Forms.Label()
        Me.submit = New System.Windows.Forms.Button()
        Me.reg = New System.Windows.Forms.Button()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Location = New System.Drawing.Point(379, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(198, 198)
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(379, 240)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(198, 20)
        Me.user.TabIndex = 3
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(379, 302)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(198, 20)
        Me.pass.TabIndex = 4
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Location = New System.Drawing.Point(290, 240)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(61, 13)
        Me.l1.TabIndex = 5
        Me.l1.Text = "Username :"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Location = New System.Drawing.Point(290, 302)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(59, 13)
        Me.l2.TabIndex = 6
        Me.l2.Text = "Password :"
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(423, 328)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(106, 43)
        Me.submit.TabIndex = 7
        Me.submit.Text = "login"
        Me.submit.UseVisualStyleBackColor = True
        '
        'reg
        '
        Me.reg.Location = New System.Drawing.Point(379, 377)
        Me.reg.Name = "reg"
        Me.reg.Size = New System.Drawing.Size(198, 43)
        Me.reg.TabIndex = 8
        Me.reg.Text = "Register"
        Me.reg.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 474)
        Me.Controls.Add(Me.reg)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.logo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents reg As System.Windows.Forms.Button

End Class
