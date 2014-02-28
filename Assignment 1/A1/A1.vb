Public Class Form1
    Dim trackarray(0 To 31) As PictureBox
    Dim custom As Boolean
    Dim counter As Integer
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click

    End Sub

    Private Sub QuitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitGameToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to quit?", "Quitting this game will lose any progress", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Form2.Close()
        ElseIf result = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim size As Integer
        custom = False
        size = 15
        Dim track As Integer
        Dim Initialx As Integer
        track = 0
        For i = 0 To 7
            For j = 0 To 3
                trackarray(track) = New PictureBox()
                Me.Controls.Add(trackarray(track))
                trackarray(track).Image = Nothing
                trackarray(track).Height = 50
                trackarray(track).Width = 50
                trackarray(track).BackColor() = Color.Transparent
                If (i Mod 2 = 0) Then
                    Initialx = 50
                Else
                    Initialx = 0
                End If
                trackarray(track).Location = New System.Drawing.Point(50 + Initialx + 100 * j, 135 + 50 * i)
                track = track + 1
            Next
        Next
        For u = 0 To 31
            AddHandler trackarray(u).Click, AddressOf doSomething
        Next
    End Sub

    Protected Sub doSomething(ByVal sender As Object, ByVal e As EventArgs)
        Dim ThisPB As PictureBox
        ThisPB = sender
        If custom = True Then
            ThisPB.Image = redpiece.Image
            counter = counter + 1
        Else
            MsgBox("")
        End If
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Dim gamesetup(0 To 31) As Integer
        custom = False
        For i = 0 To 11
            gamesetup(i) = 1
        Next
        For i = 20 To 31
            gamesetup(i) = 2
        Next
        For i = 0 To 31
            If gamesetup(i) = 1 Then
                trackarray(i).Image = blackpiece.Image
            ElseIf gamesetup(i) = 2 Then
                trackarray(i).Image = redpiece.Image
            Else
                trackarray(i).Image = Nothing
            End If
        Next

    End Sub

    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click
        custom = True
        For i = 0 To 31
            trackarray(i).Image = Nothing
        Next
    End Sub

    Private Sub PauseGame_Click(sender As Object, e As EventArgs) Handles PauseGame.Click
        If PauseGame.Pressed = True Then
            Me.BackgroundImage = My.Resources.PauseScreen
        End If
        If PauseGame.Pressed = False Then
            Me.BackgroundImage = My.Resources.LayoutGreen
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        ' Quit is "Q"
        If e.KeyCode = Keys.Q Then
            Dim result As Integer = MessageBox.Show("Are you sure you would like to quit?" & vbCrLf & "Clicking 'Yes' will lose any current game progress.", "Quit", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Form2.Close()
            ElseIf result = DialogResult.Yes Then
                End
            End If
        End If

        ' Pause is "P"
        If e.KeyCode = Keys.P Then
            Me.BackgroundImage = My.Resources.PauseScreen
        End If
    End Sub
End Class
