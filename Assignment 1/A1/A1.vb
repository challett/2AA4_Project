Public Class Form1
    Dim c_trackarray(0 To 31) As PictureBox
    Dim m_custom As Boolean
    Dim m_standard As Boolean
    Dim gamesetup(0 To 31) As Integer
    Dim e_Seconds As Integer
    Dim e_Minutes As Integer
    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        Form2.Show()
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

        ErrorClick.SendToBack()
        m_standard = True
        m_custom = True
        Dim c_track As Integer
        Dim e_Initialx As Integer
        c_track = 0

        For i = 0 To 7
            For j = 0 To 3
                c_trackarray(c_track) = New PictureBox()
                Me.Controls.Add(c_trackarray(c_track))
                c_trackarray(c_track).Image = Nothing
                c_trackarray(c_track).Height = 50
                c_trackarray(c_track).Width = 50
                c_trackarray(c_track).BackColor() = Color.Transparent
                c_trackarray(c_track).BringToFront()
                If (i Mod 2 = 0) Then
                    e_Initialx = 50
                Else
                    e_Initialx = 0
                End If
                c_trackarray(c_track).Location = New System.Drawing.Point(50 + e_Initialx + 100 * j, 135 + 50 * i)
                c_track += 1
            Next
        Next
        For u = 0 To 31
            AddHandler c_trackarray(u).Click, AddressOf MakePiece
        Next
    End Sub

    Protected Sub MakePiece(ByVal sender As Object, ByVal e As EventArgs)
        Dim ThisPB As PictureBox
        ThisPB = sender
        If m_custom = True And m_standard = False Then
            ThisPB.Image = CustomPiece.Image

            If LimitCheckBLK() Then
                ThisPB.Image = Nothing
                MsgBox("Black 12 Piece Limit Enforced")
            End If

            If LimitCheckRED() Then
                ThisPB.Image = Nothing
                MsgBox("Red 12 Piece Limit Enforced")
            End If

        ElseIf m_standard = True And m_custom = False Then
            GameTimer.Enabled = True
            TimerDisp.Visible = True
            For i = 0 To 11
                gamesetup(i) = 1
            Next
            For i = 20 To 31
                gamesetup(i) = 2
            Next
            For i = 0 To 31
                If gamesetup(i) = 1 Then
                    c_trackarray(i).Image = My.Resources.BP_shadow_
                ElseIf gamesetup(i) = 2 Then
                    c_trackarray(i).Image = My.Resources.RP_shadow_
                Else
                    c_trackarray(i).Image = Nothing
                End If
            Next
        ElseIf m_standard = True And m_custom = True Then
            MsgBox("Please Select A Game Mode")
        ElseIf m_standard = False And m_custom = False Then
            MsgBox("Logic For Moving is Done in This State and WIll Come Next")
        Else
            MsgBox("You Have Found a Bug")
        End If



    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        m_custom = False
        m_standard = True
        MakeInvis()
        MsgBox("Click Any Black Square to Start Game and Timer")
    End Sub

    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click
        m_custom = True
        m_standard = False
        ExitMode.Visible = True
        For i = 0 To 31
            c_trackarray(i).Image = Nothing
        Next
        CustomPiece.Image = black.Image
        CustomInfo.Visible = True
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
        m_custom = False
        m_standard = False
        For i = 0 To 31
            c_trackarray(i).Image = Nothing
        Next
        MakeInvis()
    End Sub

    Private Sub ExitMode_Click(sender As Object, e As EventArgs) Handles ExitMode.Click
        TimerDisp.Visible = True
        GameTimer.Enabled = True

        m_custom = False
        m_standard = False
        ExitMode.Visible = False
        CustomInfo.Visible = False
        CustomPiece.Visible = False
    End Sub
    Function LimitCheckBLK() As Boolean
        Dim e_blackCount
        e_blackCount = 0

        For i = 0 To 31
            If c_trackarray(i).Image Is blkking.Image Or c_trackarray(i).Image Is black.Image Then
                e_blackCount += 1
            End If
        Next
        If e_blackCount < 13 Then
            LimitCheckBLK = False
        Else
            LimitCheckBLK = True
        End If

    End Function
    Function LimitCheckRED() As Boolean
        Dim e_redCount
        e_redCount = 0

        For i = 0 To 31
            If c_trackarray(i).Image Is kingred.Image Or c_trackarray(i).Image Is red.Image Then
                e_redCount += 1
            End If
        Next
        If e_redCount < 13 Then
            LimitCheckRED = False
        Else
            LimitCheckRED = True
        End If

    End Function

    Private Sub CustomPiece_Click(sender As Object, e As EventArgs) Handles CustomPiece.Click
        If CustomPiece.Image Is Nothing Then
            CustomInfo.Text = "Now Placing Red"
            CustomPiece.Image = red.Image

        ElseIf CustomPiece.Image Is red.Image Then
            CustomInfo.Text = "Now Placing King Red"
            CustomPiece.Image = kingred.Image

        ElseIf CustomPiece.Image Is kingred.Image Then
            CustomInfo.Text = "Now Placing Black"
            CustomPiece.Image = black.Image

        ElseIf CustomPiece.Image Is black.Image Then
            CustomInfo.Text = "Now Placing King Black"
            CustomPiece.Image = blkking.Image

        ElseIf CustomPiece.Image Is blkking.Image Then
            CustomInfo.Text = "Now Removing, Click Me to Go to Red"

            CustomPiece.Image = Nothing
        Else
            MsgBox("You Have Found a Bug")
        End If
    End Sub

    Private Sub CustomInfo_Click(sender As Object, e As EventArgs) Handles CustomInfo.Click
        If CustomPiece.Image Is Nothing Then
            CustomPiece.Image = red.Image
        End If
    End Sub

    Private Sub ErrorClick_Click(sender As Object, e As EventArgs) Handles ErrorClick.Click
        If m_custom = True Or m_standard = False Then
            MsgBox("You Cannot Place A Piece Here")
        End If

    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        e_Seconds += 1
        If e_Seconds > 60 Then
            e_Minutes +=
            e_Seconds = 0
        End If

        TimerDisp.Text = "Time Elapsed: " + Convert.ToString(e_Minutes) + ":" + Convert.ToString(e_Seconds)
    End Sub
    Function MakeInvis()
        CustomPiece.Visible = False
        CustomInfo.Visible = False
        ExitMode.Visible = False
        GameTimer.Enabled = False
        TimerDisp.Visible = False
    End Function
End Class
