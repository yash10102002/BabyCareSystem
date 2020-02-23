Public Class Form2

    Private Sub s_Click(sender As Object, e As EventArgs) Handles s.Click
        If pass1.Text = pass2.Text Then
            Form1.usernm = nm.Text
            Form1.ad = add.Text
            Form1.bname = babynm.Text
            Form1.p = pass1.Text
            Form1.age = age.Text
            Me.Close()
            Form1.Show()
        Else
            MsgBox("password dosent match")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class