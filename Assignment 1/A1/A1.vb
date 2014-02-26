Public Class Form1
    Dim trackarray(0 To 31) As PictureBox
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
        size = 15
        Dim track As Integer
        Dim Initialx As Integer
        track = 0
        For i = 0 To 7
            For j = 0 To 3
                trackarray(track) = New PictureBox()
                Me.Controls.Add(trackarray(track))
                trackarray(track).Image = Nothing
                trackarray(track).Height = 70
                trackarray(track).Width = 70
                trackarray(track).BackColor() = Color.Transparent
                If (i Mod 2 = 0) Then
                    Initialx = 70
                Else
                    Initialx = 0
                End If
                trackarray(track).Location = New System.Drawing.Point(70 + 70 * i, 138 + 70 * j)
                track = track + 1
            Next
        Next
        For u = 0 To 31
            AddHandler trackarray(u).Click, AddressOf changelabel
        Next
    End Sub

    Protected Sub changelabel()
        End
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Dim gamesetup(0 To 31) As Integer
        For i = 0 To 11
            gamesetup(i) = 1
        Next
        For i = 20 To 31
            gamesetup(i) = 2
        Next
        For i = 0 To 31
            If gamesetup(i) = 1 Then
                trackarray(i).Image = redpiece.Image
            ElseIf gamesetup(i) = 2 Then
                trackarray(i).Image = blackpiece.Image
            Else
                trackarray(i).Image = Nothing
            End If
        Next

    End Sub
End Class
