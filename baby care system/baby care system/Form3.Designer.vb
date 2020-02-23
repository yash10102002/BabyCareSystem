<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.admittab = New System.Windows.Forms.TabControl()
        Me.hometab = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.slide = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.picktime = New System.Windows.Forms.DateTimePicker()
        Me.droptime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.adate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tmname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tdname = New System.Windows.Forms.TextBox()
        Me.ednm = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.emnm = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pno = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.admittab.SuspendLayout()
        Me.hometab.SuspendLayout()
        CType(Me.slide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ednm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emnm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'admittab
        '
        Me.admittab.Controls.Add(Me.hometab)
        Me.admittab.Controls.Add(Me.TabPage2)
        Me.admittab.Location = New System.Drawing.Point(1, 0)
        Me.admittab.Name = "admittab"
        Me.admittab.SelectedIndex = 0
        Me.admittab.Size = New System.Drawing.Size(762, 479)
        Me.admittab.TabIndex = 0
        '
        'hometab
        '
        Me.hometab.Controls.Add(Me.Button2)
        Me.hometab.Controls.Add(Me.Button1)
        Me.hometab.Controls.Add(Me.slide)
        Me.hometab.Location = New System.Drawing.Point(4, 22)
        Me.hometab.Name = "hometab"
        Me.hometab.Padding = New System.Windows.Forms.Padding(3)
        Me.hometab.Size = New System.Drawing.Size(754, 453)
        Me.hometab.TabIndex = 0
        Me.hometab.Text = "Home"
        Me.hometab.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(176, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "◄"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(572, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "►"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'slide
        '
        Me.slide.Location = New System.Drawing.Point(212, 52)
        Me.slide.Name = "slide"
        Me.slide.Size = New System.Drawing.Size(354, 354)
        Me.slide.TabIndex = 0
        Me.slide.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.picktime)
        Me.TabPage2.Controls.Add(Me.droptime)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.adate)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.phone)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Tmname)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Tdname)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(754, 453)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Admit Baby"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'picktime
        '
        Me.picktime.AllowDrop = True
        Me.picktime.Location = New System.Drawing.Point(297, 350)
        Me.picktime.Name = "picktime"
        Me.picktime.Size = New System.Drawing.Size(242, 20)
        Me.picktime.TabIndex = 40
        Me.picktime.Value = New Date(2020, 1, 24, 23, 31, 0, 0)
        '
        'droptime
        '
        Me.droptime.AllowDrop = True
        Me.droptime.Location = New System.Drawing.Point(297, 310)
        Me.droptime.Name = "droptime"
        Me.droptime.Size = New System.Drawing.Size(242, 20)
        Me.droptime.TabIndex = 39
        Me.droptime.Value = New Date(2020, 1, 24, 23, 31, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(222, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Pickup Time:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Drop Time:"
        '
        'adate
        '
        Me.adate.Location = New System.Drawing.Point(299, 270)
        Me.adate.Name = "adate"
        Me.adate.Size = New System.Drawing.Size(244, 20)
        Me.adate.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Admission date:"
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(297, 234)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(244, 20)
        Me.phone.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Phone Number:"
        '
        'Tmname
        '
        Me.Tmname.Location = New System.Drawing.Point(297, 196)
        Me.Tmname.Name = "Tmname"
        Me.Tmname.Size = New System.Drawing.Size(244, 20)
        Me.Tmname.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Mothers Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 37)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Admission Form"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Fathers Name:"
        '
        'Tdname
        '
        Me.Tdname.Location = New System.Drawing.Point(297, 156)
        Me.Tdname.Name = "Tdname"
        Me.Tdname.Size = New System.Drawing.Size(244, 20)
        Me.Tdname.TabIndex = 28
        '
        'ednm
        '
        Me.ednm.ContainerControl = Me
        '
        'emnm
        '
        Me.emnm.ContainerControl = Me
        '
        'pno
        '
        Me.pno.ContainerControl = Me
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 480)
        Me.Controls.Add(Me.admittab)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.admittab.ResumeLayout(False)
        Me.hometab.ResumeLayout(False)
        CType(Me.slide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ednm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emnm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents admittab As System.Windows.Forms.TabControl
    Friend WithEvents hometab As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents slide As System.Windows.Forms.PictureBox
    Friend WithEvents ednm As System.Windows.Forms.ErrorProvider
    Friend WithEvents emnm As System.Windows.Forms.ErrorProvider
    Friend WithEvents pno As System.Windows.Forms.ErrorProvider
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents picktime As System.Windows.Forms.DateTimePicker
    Friend WithEvents droptime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents adate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents phone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tmname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tdname As System.Windows.Forms.TextBox
End Class
