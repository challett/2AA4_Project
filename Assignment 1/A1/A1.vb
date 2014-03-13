Public Class CustomMode
    Dim c_trackarray(0 To 31) As PictureBox
    Dim gamesetup(0 To 32) As Integer 'This is How Save will be Implemented Later
    Private Sub QuitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitGameToolStripMenuItem.Click 'Standard Closing Code
        Dim result As Integer = MessageBox.Show("Are you sure you would like to quit?", "Quitting Right Now Will Delete All Placed Pieces", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            BackGround.Close()
        ElseIf result = DialogResult.Yes Then
            Me.Close()
            start_Menu.Close()
        End If
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        start_Menu.Close()
    End Sub
    Private Sub CustomMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomPiece.Image = red.Image
        gamesetup(32) = 10
        ErrorClick.SendToBack() 'Custom Mode Error Generator
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
        ThisPB.Image = CustomPiece.Image 'Implementation of the Place First, Delete if limit passed Logic
        If LimitCheckBLK() Then
            ThisPB.Image = Nothing
            MsgBox("Black 12 Piece Limit Enforced")
        End If

        If LimitCheckRED() Then
            ThisPB.Image = Nothing
            MsgBox("Red 12 Piece Limit Enforced")
        End If
    End Sub

    Private Sub ExitMode_Click(sender As Object, e As EventArgs) Handles ExitMode.Click 'Finished Setup
        For i = 0 To 31
            If c_trackarray(i).Image Is black.Image Then
                gamesetup(i) = 1
            ElseIf c_trackarray(i).Image Is red.Image Then
                gamesetup(i) = 2
            ElseIf c_trackarray(i).Image Is blkking.Image Then
                gamesetup(i) = 3
            ElseIf c_trackarray(i).Image Is kingred.Image Then
                gamesetup(i) = 4
            Else
                gamesetup(i) = 0
            End If
        Next
        Me.Visible = False
        Play.Show()
    End Sub
    Public Function GetSetup()

        Return gamesetup

    End Function
    'Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    ' Quit is "Q"
    'If e.KeyCode = Keys.Q Then
    'Dim result As Integer = MessageBox.Show("Are you sure you would like to quit?" & vbCrLf & "Clicking 'Yes' will lose any current game progress.", "Quit", MessageBoxButtons.YesNo)
    'If result = DialogResult.No Then
    'Form2.Close()
    'ElseIf result = DialogResult.Yes Then
    'End
    'End If
    'End If

    'End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click 'Returns All to Form Load State
        For i = 0 To 31
            c_trackarray(i).Image = Nothing
        Next
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
        MsgBox("You Cannot Place A Piece Here")
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
            gamesetup(i) = Replace(reader.ReadLine, "\n", "")
        Next
        reader.Close()
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        BackGround.Show()
    End Sub
End Class
