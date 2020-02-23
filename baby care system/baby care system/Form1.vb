Public Class Form1
    Public usernm, ad, bname, p As String
    Public age As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logo.ImageLocation = "C:\Users\yash\Desktop\baby care system\logo.jpg"
    End Sub

    Private Sub reg_Click(sender As Object, e As EventArgs) Handles reg.Click
        Form2.Show()
    End Sub


    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If user.Text = usernm And pass.Text = p Then
            MsgBox("Successfully logged")
            Me.Hide()
            Form3.Show()

        ElseIf user.Text = usernm And pass.Text <> p Then
            MsgBox("incorrect password")
        Else
            MsgBox("incorrect details")
        End If
    End Sub
End Class
