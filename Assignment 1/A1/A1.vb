Public Class Form1
    Dim trackarray(0 To 31) As PictureBox
    Dim custom As Boolean
    Dim redcounter As Integer
    Dim blackcounter As Integer
    Dim redselect As Boolean
    Dim blackselect As Boolean
    Dim redkingselect As Boolean
    Dim blackkingselect As Boolean
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

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you would like to quit?" & vbCrLf & "Clicking 'Yes' will lose any current game progress.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Quit")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim size As Integer
        custom = False
        size = 15
        Dim track As Integer
        Dim Initialx As Integer
        track = 0
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False
        ExitMode.Visible = False
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
        If custom = True And redselect = True And redcounter < 12 Then
            ThisPB.Image = My.Resources.RP_shadow_
            redcounter = redcounter + 1

        ElseIf custom = True And redkingselect = True And redcounter < 12 Then
            ThisPB.Image = My.Resources.RP_shadow_
            redcounter = redcounter + 1

        ElseIf custom = True And blackselect = True And blackcounter < 12 Then
            ThisPB.Image = My.Resources.BP_shadow_
            blackcounter = blackcounter + 1

        ElseIf custom = True And blackkingselect = True And blackcounter < 12 Then
            ThisPB.Image = My.Resources.BP_King__shadow_
            blackcounter = blackcounter + 1
        Else
            MsgBox("Please Select A Game Mode")
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
                trackarray(i).Image = My.Resources.BP_shadow_
            ElseIf gamesetup(i) = 2 Then
                trackarray(i).Image = My.Resources.RP_shadow_
            Else
                trackarray(i).Image = Nothing
            End If
        Next
    End Sub

    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click
        custom = True
        ExitMode.Visible = True
        For i = 0 To 31
            trackarray(i).Image = Nothing
        Next
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
    End Sub

    Private Sub PauseGame_Click(sender As Object, e As EventArgs) Handles PauseGame.Click
        If PauseGame.Pressed = True Then
            Me.BackgroundImage = My.Resources.PauseScreen
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

        ' Resume is "R"
        If e.KeyCode = Keys.R Then
            Me.BackgroundImage = Form2.CurBack
        End If

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        custom = False
        For i = 0 To 31
            trackarray(i).Image = Nothing
        Next
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        blackselect = True
        blackkingselect = False
        redselect = False
        redkingselect = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        blackselect = False
        blackkingselect = False
        redselect = True
        redkingselect = False
        RadioButton2.Checked = False
        RadioButton1.Checked = False
        RadioButton4.Checked = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        blackselect = False
        blackkingselect = True
        redselect = False
        redkingselect = False
        RadioButton1.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        blackselect = False
        blackkingselect = False
        redselect = False
        redkingselect = True
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton1.Checked = False
    End Sub

    Private Sub ExitMode_Click(sender As Object, e As EventArgs) Handles ExitMode.Click
        custom = False
        ExitMode.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False
    End Sub
End Class
