Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim size As Integer
        Dim trackarray(0 To 63) As Label

        size = 63

        For i = 0 To size
            trackarray(i) = New Label
            trackarray(i).Top = 0
            trackarray(i).Text = "something"
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
