Public Class Form1

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click

    End Sub

    Private Sub QuitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitGameToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim size As Integer
        Dim trackarray(0 To 31) As PictureBox
        size = 15
        Dim track As Integer
        track = 0
        For i = 0 To 3
            For j = 0 To 3
                trackarray(track) = New PictureBox()
                trackarray(track).Location = New System.Drawing.Point(70 + 140 * j, 208 + 140 * i)
                Me.Controls.Add(trackarray(track))
                trackarray(track).Image = redpiece.Image
                trackarray(track).Height = 70
                trackarray(track).Width = 70
                trackarray(track).BackColor() = Color.Transparent
                track = track + 1
            Next
        Next
        For u = 0 To 15
            AddHandler trackarray(u).Click, AddressOf changelabel
        Next
    End Sub

    Protected Sub changelabel()
        End
    End Sub
End Class
