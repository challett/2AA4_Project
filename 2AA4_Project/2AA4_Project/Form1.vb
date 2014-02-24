Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim size As Integer
        Dim trackarray(0 To 63) As PictureBox
        size = 63

        For i = 0 To size
            trackarray(i) = New PictureBox()
            trackarray(i).Top = 30 * i
            Me.Controls.Add(trackarray(i))
            trackarray(i).Image = PictureBox2.Image
        Next
        For i = 0 To size
            AddHandler trackarray(i).Click, AddressOf changelabel
        Next
    End Sub

    Protected Sub changelabel()
        Dim thisLabel As Label
        Label1.Text = "test"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
