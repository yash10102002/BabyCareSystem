<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.abc = New System.Windows.Forms.Label()
        Me.Ladd = New System.Windows.Forms.Label()
        Me.nm = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.TextBox()
        Me.Lbabynm = New System.Windows.Forms.Label()
        Me.babynm = New System.Windows.Forms.TextBox()
        Me.Lage = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.TextBox()
        Me.pass1L = New System.Windows.Forms.Label()
        Me.pass1 = New System.Windows.Forms.TextBox()
        Me.Lpass2 = New System.Windows.Forms.Label()
        Me.pass2 = New System.Windows.Forms.TextBox()
        Me.s = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register"
        '
        'abc
        '
        Me.abc.AutoSize = True
        Me.abc.Location = New System.Drawing.Point(106, 64)
        Me.abc.Name = "abc"
        Me.abc.Size = New System.Drawing.Size(62, 13)
        Me.abc.TabIndex = 1
        Me.abc.Text = "username :-"
        '
        'Ladd
        '
        Me.Ladd.AutoSize = True
        Me.Ladd.Location = New System.Drawing.Point(114, 103)
        Me.Ladd.Name = "Ladd"
        Me.Ladd.Size = New System.Drawing.Size(54, 13)
        Me.Ladd.TabIndex = 2
        Me.Ladd.Text = "Address :-"
        '
        'nm
        '
        Me.nm.Location = New System.Drawing.Point(174, 64)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(206, 20)
        Me.nm.TabIndex = 3
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(174, 100)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(206, 20)
        Me.add.TabIndex = 4
        '
        'Lbabynm
        '
        Me.Lbabynm.AutoSize = True
        Me.Lbabynm.Location = New System.Drawing.Point(85, 141)
        Me.Lbabynm.Name = "Lbabynm"
        Me.Lbabynm.Size = New System.Drawing.Size(83, 13)
        Me.Lbabynm.TabIndex = 5
        Me.Lbabynm.Text = "name of baby :- "
        '
        'babynm
        '
        Me.babynm.Location = New System.Drawing.Point(174, 138)
        Me.babynm.Name = "babynm"
        Me.babynm.Size = New System.Drawing.Size(206, 20)
        Me.babynm.TabIndex = 6
        '
        'Lage
        '
        Me.Lage.AutoSize = True
        Me.Lage.Location = New System.Drawing.Point(93, 182)
        Me.Lage.Name = "Lage"
        Me.Lage.Size = New System.Drawing.Size(75, 13)
        Me.Lage.TabIndex = 7
        Me.Lage.Text = "age of baby :- "
        '
        'age
        '
        Me.age.Location = New System.Drawing.Point(174, 179)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(206, 20)
        Me.age.TabIndex = 8
        '
        'pass1L
        '
        Me.pass1L.AutoSize = True
        Me.pass1L.Location = New System.Drawing.Point(84, 227)
        Me.pass1L.Name = "pass1L"
        Me.pass1L.Size = New System.Drawing.Size(84, 13)
        Me.pass1L.TabIndex = 9
        Me.pass1L.Text = "Set Password :- "
        '
        'pass1
        '
        Me.pass1.Location = New System.Drawing.Point(174, 224)
        Me.pass1.Name = "pass1"
        Me.pass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass1.Size = New System.Drawing.Size(206, 20)
        Me.pass1.TabIndex = 10
        '
        'Lpass2
        '
        Me.Lpass2.AutoSize = True
        Me.Lpass2.Location = New System.Drawing.Point(65, 271)
        Me.Lpass2.Name = "Lpass2"
        Me.Lpass2.Size = New System.Drawing.Size(103, 13)
        Me.Lpass2.TabIndex = 11
        Me.Lpass2.Text = "Confirm Password :- "
        '
        'pass2
        '
        Me.pass2.Location = New System.Drawing.Point(174, 268)
        Me.pass2.Name = "pass2"
        Me.pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass2.Size = New System.Drawing.Size(206, 20)
        Me.pass2.TabIndex = 12
        '
        's
        '
        Me.s.Location = New System.Drawing.Point(216, 315)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(105, 49)
        Me.s.TabIndex = 13
        Me.s.Text = "Submit"
        Me.s.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 412)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.pass2)
        Me.Controls.Add(Me.Lpass2)
        Me.Controls.Add(Me.pass1)
        Me.Controls.Add(Me.pass1L)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.Lage)
        Me.Controls.Add(Me.babynm)
        Me.Controls.Add(Me.Lbabynm)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.nm)
        Me.Controls.Add(Me.Ladd)
        Me.Controls.Add(Me.abc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents abc As System.Windows.Forms.Label
    Friend WithEvents Ladd As System.Windows.Forms.Label
    Friend WithEvents nm As System.Windows.Forms.TextBox
    Friend WithEvents add As System.Windows.Forms.TextBox
    Friend WithEvents Lbabynm As System.Windows.Forms.Label
    Friend WithEvents babynm As System.Windows.Forms.TextBox
    Friend WithEvents Lage As System.Windows.Forms.Label
    Friend WithEvents age As System.Windows.Forms.TextBox
    Friend WithEvents pass1L As System.Windows.Forms.Label
    Friend WithEvents pass1 As System.Windows.Forms.TextBox
    Friend WithEvents Lpass2 As System.Windows.Forms.Label
    Friend WithEvents pass2 As System.Windows.Forms.TextBox
    Friend WithEvents s As System.Windows.Forms.Button
End Class
