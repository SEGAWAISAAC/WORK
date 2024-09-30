Public Class Form1

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim marks As Integer = txtmarks.Text

        If marks >= 90 And marks <= 100 Then
            txtgrade.Text = ("Excellent")
        ElseIf marks >= 80 And marks <= 89 Then
            txtgrade.Text = ("Very Good")
        ElseIf marks >= 70 And marks <= 79 Then
            txtgrade.Text = ("Good")
        ElseIf marks >= 60 And marks <= 69 Then
            txtgrade.Text = ("Medium")
        ElseIf marks >= 50 And marks <= 59 Then
            txtgrade.Text = ("Pass")
        ElseIf marks >= 0 And marks <= 49 Then
            txtgrade.Text = ("Fail")
        ElseIf marks > 100 Then
            txtgrade.Text = ("wrong entry, please re-enter the mark")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
