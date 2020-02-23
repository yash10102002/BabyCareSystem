Imports System.Text.RegularExpressions
Public Class Form3
    Public s As Integer = 1

    'This is form load event
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        droptime.Format = DateTimePickerFormat.Time
        picktime.Format = DateTimePickerFormat.Time
        slide.Width = 354
        slide.Height = 354
        slide.ImageLocation = "C:\Users\yash\Desktop\baby care system\slide1.jpg"
        adate.Enabled = False
        adate.Text = Today
    End Sub

    'this is click event of moving to right slide
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If s < 3 Then
            s += 1
        End If
        If s = 2 Then
            slide.Width = 354
            slide.Height = 354
            slide.ImageLocation = "C:\Users\yash\Desktop\baby care system\slide2.jpg"
        ElseIf s = 3 Then
            slide.Width = 354
            slide.Height = 354
            slide.ImageLocation = "C:\Users\yash\Desktop\baby care system\slide3.jpg"
        End If
    End Sub



    'this is click event of button to left slide
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If s > 1 Then
            s -= 1
        End If
        If s = 2 Then
            slide.ImageLocation = "C:\Users\yash\Desktop\baby care system\slide2.jpg"
        ElseIf s = 1 Then
            slide.ImageLocation = "C:\Users\yash\Desktop\baby care system\slide1.jpg"
        End If
    End Sub


    Private Sub Tdname_TextChanged(sender As Object, e As EventArgs) Handles Tdname.TextChanged
        Dim dnm As Regex = New Regex("[A-Za-z A-Za-z]+$")
        If dnm.IsMatch(Tdname.Text) Then
            ednm.SetError(Tdname, "")
        ElseIf Tdname.Text = "" Then
            ednm.SetError(Tdname, "")
        Else
            ednm.SetError(Tdname, "!!!Please Enter valid Name!!!")
        End If
    End Sub

    Private Sub Tmname_TextChanged(sender As Object, e As EventArgs) Handles Tmname.TextChanged
        Dim dnm As Regex = New Regex("[A-Za-z A-Za-z]+$")
        If dnm.IsMatch(Tmname.Text) Then
            ednm.SetError(Tmname, "")
        ElseIf Tmname.Text = "" Then
            ednm.SetError(Tmname, "")
        Else
            ednm.SetError(Tmname, "!!!Please Enter valid Name!!!")
        End If
    End Sub

    Private Sub phone_TextChanged(sender As Object, e As EventArgs) Handles phone.TextChanged
        Dim p As Regex = New Regex("[\d {10}]")
        If p.IsMatch(phone.Text) Then
            pno.SetError(phone, "")
        ElseIf phone.Text = "" Then
            pno.SetError(phone, "")
        Else
            pno.SetError(phone, "!!!Please Enter Valid phone number :- !!!")
        End If
    End Sub

    Private Sub adate_TextChanged(sender As Object, e As EventArgs) Handles adate.TextChanged
        Dim dt As Regex = New Regex("dd/mm/yyyy")
        Dim c As Integer = 1
        c += 1
        If c = 3 Then
            adate.Enabled = True

        End If
    End Sub


End Class
