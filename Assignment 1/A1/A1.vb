Public Class Form1
    Dim c_trackarray(0 To 31) As PictureBox
    Dim m_custom As Boolean
    Dim m_standard As Boolean
    Dim c_Seconds As Integer
    Dim c_Minutes As Integer
    Dim gamesetup(0 To 31) As Integer 'This is How Save will be Implemented Later


    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub QuitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitGameToolStripMenuItem.Click 'Standard Closing Code
        Dim result As Integer = MessageBox.Show("Are you sure you would like to quit?", "Quitting this game will lose any progress", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Form2.Close()
        ElseIf result = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing 'Standard Closing Code
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

        ErrorClick.SendToBack() 'Custom Mode Error Generator
        m_standard = True
        m_custom = True
        Dim c_track As Integer
        Dim c_Initialx As Integer
        c_track = 0

        For i = 0 To 7 'Drawing Image Boxes
            For j = 0 To 3
                c_trackarray(c_track) = New PictureBox()
                Me.Controls.Add(c_trackarray(c_track))
                c_trackarray(c_track).Image = Nothing
                c_trackarray(c_track).Height = 50
                c_trackarray(c_track).Width = 50
                c_trackarray(c_track).BackColor() = Color.Transparent
                c_trackarray(c_track).BringToFront()
                If (i Mod 2 = 0) Then
                    c_Initialx = 50
                Else
                    c_Initialx = 0
                End If
                c_trackarray(c_track).Location = New System.Drawing.Point(50 + c_Initialx + 100 * j, 135 + 50 * i)
                c_track += 1
            Next
        Next
        For u = 0 To 31 'Protected Sub to Handle Clicks
            AddHandler c_trackarray(u).Click, AddressOf MakePiece
        Next
    End Sub

    Protected Sub MakePiece(ByVal sender As Object, ByVal e As EventArgs)
        Dim ThisPB As PictureBox

        ThisPB = sender
        If m_custom = True And m_standard = False Then 'Custom State
            ThisPB.Image = CustomPiece.Image 'Implementation of the Place First, Delete if limit passed Logic
            GameTimer.Enabled = False
            If LimitCheckBLK() Then
                ThisPB.Image = Nothing
                MsgBox("Black 12 Piece Limit Enforced")
            End If

            If LimitCheckRED() Then
                ThisPB.Image = Nothing
                MsgBox("Red 12 Piece Limit Enforced")
            End If

        ElseIf m_standard = True And m_custom = False Then 'Standard Game State
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
        ElseIf m_standard = True And m_custom = True Then 'State Logic- Initial
            MsgBox("Please Select A Game Mode")
        ElseIf m_standard = False And m_custom = False Then 'State Logic - Moving, Not Yet Implemented
            MsgBox("Logic For Moving is Done in This State and Will Come Next")
        Else
            MsgBox("You Have Found a Bug Please REstart The Program") 'All Cases Adressed, Runtime Glitch Prevention 
        End If



    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click 'Standard Mode
        m_custom = False
        m_standard = True
        MakeInvis()
        timestop()
        MsgBox("Click Any Black Square to Start Game and Timer")
    End Sub

    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click 'Custom mode
        m_custom = True
        m_standard = False
        MakeInvis()
        CustomPiece.Visible = True
        ExitMode.Visible = True
        CustomInfo.Visible = True
        TimerDisp.Visible = False
        CustomPiece.Image = red.Image
        timestop()
        For i = 0 To 31
            c_trackarray(i).Image = Nothing
        Next
    End Sub

    Private Sub ExitMode_Click(sender As Object, e As EventArgs) Handles ExitMode.Click 'Finished Setup
        MsgBox("Game Has Began and the Timer Will Start Now")
        Call gamebegin()
    End Sub

    Private Sub PauseGame_Click(sender As Object, e As EventArgs) Handles PauseGame.Click
        '   If PauseGame.Pressed = True Then
        '      Form3.Show() 'New Form Used
        '     Me.Hide() 'Removes User Interaction
        'End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        ' Quit is "Q"
        'If e.KeyCode = Keys.Q Then
        'Dim result As Integer = MessageBox.Show("Are you sure you would like to quit?" & vbCrLf & "Clicking 'Yes' will lose any current game progress.", "Quit", MessageBoxButtons.YesNo)
        'If result = DialogResult.No Then
        'Form2.Close()
        'ElseIf result = DialogResult.Yes Then
        'End
        'End If
        'End If

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click 'Returns All to Form Load State
        m_custom = False
        m_standard = False
        For i = 0 To 31
            c_trackarray(i).Image = Nothing
        Next
        MakeInvis() 'Call to make unecessary pieces disappear
    End Sub

    Function LimitCheckBLK() As Boolean
        Dim c_blackCount
        c_blackCount = 0

        For i = 0 To 31
            If c_trackarray(i).Image Is blkking.Image Or c_trackarray(i).Image Is black.Image Then
                c_blackCount += 1
            End If
        Next
        If c_blackCount < 13 Then 'Limit Check Red Logic
            LimitCheckBLK = False
        Else
            LimitCheckBLK = True
        End If

    End Function
    Function LimitCheckRED() As Boolean 'Limit Checks
        Dim c_redCount
        c_redCount = 0

        For i = 0 To 31
            If c_trackarray(i).Image Is kingred.Image Or c_trackarray(i).Image Is red.Image Then
                c_redCount += 1
            End If
        Next
        If c_redCount < 13 Then 'Logic is 13 because of Internal workings, piece is placed first then cancelled if passed
            LimitCheckRED = False
        Else
            LimitCheckRED = True
        End If

    End Function

    Private Sub CustomPiece_Click(sender As Object, e As EventArgs) Handles CustomPiece.Click 'Cycling Through possible pieces
        Dim nextStatePic As Image
        nextStatePic = CustomLoop(CustomPiece.Image)
        CustomPiece.Image = nextStatePic

    End Sub
    Function CustomLoop(ByRef InPic As Image) As Image 'Next State image, Input Always click, current state as Inpic
        If InPic Is Nothing Then
            CustomInfo.Text = "Now Placing Red"
            CustomLoop = red.Image

        ElseIf InPic Is red.Image Then
            CustomInfo.Text = "Now Placing King Red"
            CustomLoop = kingred.Image

        ElseIf InPic Is kingred.Image Then
            CustomInfo.Text = "Now Placing Black"
            CustomLoop = black.Image

        ElseIf InPic Is black.Image Then
            CustomInfo.Text = "Now Placing King Black"
            CustomLoop = blkking.Image

        ElseIf InPic Is blkking.Image Then
            CustomInfo.Text = "Now Removing, Click Me to Go to Red"
            CustomLoop = Nothing
        Else
            MsgBox("You Have Found a Bug Returing to Initial State") 'Bug Prevention
            CustomInfo.Text = "Now Placing Red"
            CustomLoop = red.Image
        End If
    End Function


    Private Sub CustomInfo_Click(sender As Object, e As EventArgs) Handles CustomInfo.Click
        If CustomPiece.Image Is Nothing Then
            CustomPiece.Image = red.Image
        End If

    End Sub

    Private Sub ErrorClick_Click(sender As Object, e As EventArgs) Handles ErrorClick.Click 'White Tile Clicks
        If m_custom = True Or m_standard = False Then 'Custom Placing State
            MsgBox("You Cannot Place A Piece Here")
        End If

    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        If Me.Visible = False Then
            GameTimer.Enabled = False
        End If

        c_Seconds += 1
        If c_Seconds > 59 Then
            c_Minutes += 1
            c_Seconds = 0
        End If

        TimerDisp.Text = "Time Elapsed: " + Convert.ToString(c_Minutes) + ":" + Convert.ToString(c_Seconds)
    End Sub

    Function MakeInvis() 'Custom Setup buttons, must be invis when other modes selected
        CustomPiece.Visible = False
        CustomInfo.Visible = False
        ExitMode.Visible = False
        GameTimer.Enabled = False
        TimerDisp.Visible = False
        Return True
    End Function

    Function timestop() 'Resets Timing Variables
        c_Seconds = 0
        c_Minutes = 0
        Return True
    End Function
    Function gamebegin() 'qualities that must ben true when game starts
        m_custom = False
        m_standard = False
        ExitMode.Visible = False
        CustomInfo.Visible = False
        CustomPiece.Visible = False
        TimerDisp.Visible = True
        TimerDisp.Enabled = True
        timestop()
        GameTimer.Enabled = True
        Return True
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        If Me.Visible = False Then
            GameTimer.Enabled = False
        Else
        End If
    End Sub

    Private Sub SaveGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveGameToolStripMenuItem.Click
        Dim writer As System.IO.StreamWriter = _
        New System.IO.StreamWriter("../SavedGame.txt")
        For i = 0 To gamesetup.Length - 1
            writer.WriteLine(gamesetup(i))
        Next
        writer.Close()
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Dim reader As System.IO.StreamReader = _
        New System.IO.StreamReader("../SavedGame.txt")
        For i = 0 To gamesetup.Length - 1
            gamesetup(i) = reader.ReadLine
        Next
        reader.Close()
    End Sub
End Class
