Public Class Play
    Dim c_trackarray(0 To 31) As PictureBox
    Dim movecount As Integer
    Dim current As PictureBox
    Dim CB1, CB2, CR1, CR2 As Integer
    Dim BlkT, RedT As Boolean
    Dim BadNum As Integer
    Dim nextB1, nextB2, nextR1, nextR2 As String
    Dim nextB3, nextB4, nextR3, nextR4 As PictureBox
    Dim ThisPB As PictureBox
    Dim infoarray(0 To 31) As String


    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        start_Menu.Close()
        CustomMode.Close()
    End Sub
    Private Sub Play_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c_track As Integer
        Dim c_Initialx As Integer
        infoarray = {"B8", "D8", "F8", "H8", "A7", "C7", "E7", "G7", "B6", "D6", "F6", "H6", "A5", "C5", "E5", "G5", "B4", "D4", "F4", "H4", "A3", "C3", "E3", "G3", "D2", "F2", "H2", "A1", "C1", "E1", "G1"}
        c_track = 0
        For i = 0 To 7 'Drawing Image Boxes
            For j = 0 To 3
                c_trackarray(c_track) = New PictureBox()
                c_trackarray(c_track).Name() = "PictureBox" + Convert.ToString(c_track)
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
        Dim gamesetupC(0 To 32) As Integer
        Dim gamesetupS(0 To 32) As Integer
        Dim gamesetupL(0 To 32) As Integer

        gamesetupC = CustomMode.GetSetup
        gamesetupS = start_Menu.GetSetup
        gamesetupL = start_Menu.GetsetupL
        If gamesetupC(32) = 10 Then
            makegame(gamesetupC)
        ElseIf gamesetupS(32) = 10 Then
            makegame(gamesetupS)
        ElseIf gamesetupL(32) = 10 Then
            makegame(gamesetupL)
        End If

    End Sub
    Protected Sub MakePiece(ByVal sender As Object, ByVal e As EventArgs)
        ThisPB = sender
        Dim BadRed(0 To 11) As Integer
        Dim BadBlack(0 To 11) As Integer


        BadBlack = {4, 5, 6, 7, 12, 13, 14, 15, 20, 21, 22, 23, 28, 29, 30, 31}
        BadRed = {0, 1, 2, 3, 8, 9, 10, 11, 16, 17, 18, 19, 24, 25, 26, 27}

        If Not (ThisPB.Image Is Nothing) Then
            movecount = 0
            If movecount = 0 Then
                current = ThisPB
                CurrentPiece.Image = ThisPB.Image
                BadNum = Convert.ToInt32(Replace(current.Name, "PictureBox", ""))
                CurrentInfo.Text = "Your Position: " & infoarray(BadNum)

            End If
            If CurrentPiece.Image Is red.Image Or CurrentPiece.Image Is kingred.Image Or CurrentPiece.Image Is blackking.Image Then
                If BadRed.Contains(BadNum) Then
                    RedT = True
                Else
                    RedT = False
                End If
            End If
            If CurrentPiece.Image Is black.Image Or CurrentPiece.Image Is blackking.Image Or CurrentPiece.Image Is kingred.Image Then
                If BadBlack.Contains(BadNum) Then
                    BlkT = True
                Else
                    BlkT = False
                End If
            End If
            If RedT = True Then
                CR1 = 3
                CR2 = 4
            Else
                CR1 = 4
                CR2 = 5
            End If
            If BlkT = True Then
                CB1 = 3
                CB2 = 4
            Else
                CB1 = 4
                CB2 = 5
            End If
            movecount = 1
        End If


        If ThisPB.Image Is Nothing Then
            'Finding Next Piece
            nextB1 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(current.Name, "PictureBox", "")) + CB1)
            nextB2 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(current.Name, "PictureBox", "")) + CB2)
            nextR1 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(current.Name, "PictureBox", "")) - CR1)
            nextR2 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(current.Name, "PictureBox", "")) - CR2)

            For i = 0 To 31
                If c_trackarray(i).Name = nextB1 Then
                    nextB3 = c_trackarray(i)
                End If
            Next
            For i = 0 To 31
                If c_trackarray(i).Name = nextB2 Then
                    nextB4 = c_trackarray(i)
                End If
            Next
            For i = 0 To 31
                If c_trackarray(i).Name = nextR1 Then
                    nextR3 = c_trackarray(i)
                End If
            Next
            For i = 0 To 31
                If c_trackarray(i).Name = nextR2 Then
                    nextR4 = c_trackarray(i)
                End If
            Next
            'Finding Next Piece
            ' Detecting Next Piece
            If CurrentPiece.Image Is black.Image Or CurrentPiece.Image Is blackking.Image Then
                If nextB3.Image Is red.Image Or nextB3.Image Is kingred.Image Then
                    CB1 = 7
                End If
            End If
            If CurrentPiece.Image Is black.Image Or CurrentPiece.Image Is blackking.Image Then
                If nextB4.Image Is red.Image Or nextB4.Image Is kingred.Image Then
                    CB2 = 9
                End If
            End If
            If CurrentPiece.Image Is blackking.Image Then
                If nextR3.Image Is red.Image Or nextR3.Image Is kingred.Image Then
                    CR1 = 7
                End If
            End If
            If CurrentPiece.Image Is blackking.Image Then
                If nextR4.Image Is red.Image Or nextR4.Image Is kingred.Image Then
                    CR2 = 9
                End If
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If CurrentPiece.Image Is red.Image Or CurrentPiece.Image Is kingred.Image Then
                If nextR3.Image Is black.Image Or nextR3.Image Is blackking.Image Then
                    CR1 = 7
                End If
            End If
            If CurrentPiece.Image Is red.Image Or CurrentPiece.Image Is kingred.Image Then
                If nextR4.Image Is black.Image Or nextR4.Image Is blackking.Image Then
                    CR2 = 9
                End If
            End If
            If CurrentPiece.Image Is kingred.Image Then
                If nextB3.Image Is black.Image Or nextB3.Image Is blackking.Image Then
                    CB1 = 7
                End If
            End If
            If CurrentPiece.Image Is kingred.Image Then
                If nextB4.Image Is black.Image Or nextB4.Image Is blackking.Image Then
                    CB2 = 9
                End If
            End If
            ' Detecting Next Piece

            If movecount = 1 Then
                If CurrentPiece.Image Is black.Image Then
                    If Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(current.Name, "PictureBox", "")) + CB1) Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                        If CB1 > 5 Then
                            nextB3.Image = Nothing
                        End If
                    ElseIf Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(current.Name, "PictureBox", "")) + CB2) Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                        If CB2 > 5 Then
                            nextB4.Image = Nothing
                        End If
                    End If
                ElseIf CurrentPiece.Image Is red.Image Then
                    If Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(current.Name, "PictureBox", "")) - CR1) Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                        If CR1 > 5 Then
                            nextR3.Image = Nothing
                        End If
                    ElseIf (Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(current.Name, "PictureBox", "")) - CR2) Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                        If CR2 > 5 Then
                            nextR4.Image = Nothing
                        End If
                    End If
                Else 'If CurrentPiece.Image Is kingred.Image Or CurrentPiece.Image Is blackking.Image Then
                    If Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(current.Name, "PictureBox", "")) - CR1) Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                        If CR1 > 5 Then
                            nextR3.Image = Nothing
                        End If
                    ElseIf (Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(current.Name, "PictureBox", "")) - CR2) Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                        If CR2 > 5 Then
                            nextR4.Image = Nothing
                        End If
                    ElseIf Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(current.Name, "PictureBox", "")) + CB1 Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                        If CB1 > 5 Then
                            nextB3.Image = Nothing
                        End If
                    ElseIf Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(current.Name, "PictureBox", "")) + CB2 Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                        If CB2 > 5 Then
                            nextB4.Image = Nothing
                        End If
                    End If
                End If
            End If
        End If

        For i = 0 To 3
            If c_trackarray(i).Image Is red.Image Then
                c_trackarray(i).Image = kingred.Image
            End If
        Next

        For j = 28 To 31
            If c_trackarray(j).Image Is black.Image Then
                c_trackarray(j).Image = blackking.Image

            End If
        Next
    End Sub
    Function makegame(ByVal Array() As Integer)
        For i = 0 To 31
            If Array(i) = 1 Then
                c_trackarray(i).Image = black.Image
            ElseIf Array(i) = 2 Then
                c_trackarray(i).Image = red.Image
            ElseIf Array(i) = 3 Then
                c_trackarray(i).Image = blackking.Image
            ElseIf Array(i) = 4 Then
                c_trackarray(i).Image = kingred.Image
            Else
                c_trackarray(i).Image = Nothing
            End If
        Next

    End Function


    Private Sub SaveGameToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveGameToolStripMenuItem.Click
        Dim writer As System.IO.StreamWriter = _
      New System.IO.StreamWriter("../SavedGame.txt")
        Dim gamesetup(0 To 32) As Integer
        For i = 0 To 31
            If c_trackarray(i).Image Is red.Image Then
                gamesetup(i) = 2
            ElseIf c_trackarray(i).Image Is black.Image Then
                gamesetup(i) = 1
            ElseIf c_trackarray(i).Image Is blackking.Image Then
                gamesetup(i) = 3
            ElseIf c_trackarray(i).Image Is kingred.Image Then
                gamesetup(i) = 4
            Else
                gamesetup(i) = 0
            End If
        Next
        For i = 0 To gamesetup.Length - 1
            writer.WriteLine(gamesetup(i))
        Next
        writer.Close()
    End Sub

    Private Sub ExitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitGameToolStripMenuItem.Click
        start_Menu.Show()
        Me.Hide()

    End Sub

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        Me.Close()
        start_Menu.Close()
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        BackGround.Show()

    End Sub
End Class