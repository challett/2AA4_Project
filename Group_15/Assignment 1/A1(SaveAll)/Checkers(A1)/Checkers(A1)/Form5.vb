Public Class PlayingAgainstAi
    Dim c_trackarray(0 To 31) As PictureBox
    Dim e_LegalMoves(0 To 31) As String
    Dim c_moveCount As Integer
    Dim m_Current As PictureBox
    Dim C_B1, C_B2, C_R1, C_R2 As Integer
    Dim c_BlkT, c_RedT As Boolean
    Dim m_currentIndex As Integer
    Dim m_nextB1, m_nextB2, m_nextR1, m_nextR2, m_nextB11, m_nextB21, m_nextR11, m_nextR21 As String
    Dim c_nextB3, c_nextB4, c_nextR3, c_nextR4 As PictureBox
    Dim m_ThisPB As PictureBox
    Dim m_infoarray(0 To 31) As String
    Dim m_turn As Integer
    Dim m_red(0 To 11) As Integer
    Dim m_black(0 To 11) As Integer
    Dim c_PCturn, m_allowmove As Boolean
    Dim e_NoneJumps As Integer
    Dim c_compnext1, c_compnext2 As PictureBox
    Dim c_CompJump1, c_CompJump2 As PictureBox

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        start_Menu.Close()
        CustomMode.Close()
    End Sub
    Private Sub Play_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c_track As Integer
        Dim c_Initialx As Integer
        e_NoneJumps = 0
        m_turn = 0
        MsgBox("Black Will Make The First Move")
        m_black = {4, 5, 6, 7, 12, 13, 14, 15, 20, 21, 22, 23, 28, 29, 30, 31}
        m_red = {0, 1, 2, 3, 8, 9, 10, 11, 16, 17, 18, 19, 24, 25, 26, 27}
        m_infoarray = {"B8", "D8", "F8", "H8", "A7", "C7", "E7", "G7", "B6", "D6", "F6", "H6", "A5", "C5", "E5", "G5", "B4", "D4", "F4", "H4", "A3", "C3", "E3", "G3", "B2", "D2", "F2", "H2", "A1", "C1", "E1", "G1"}
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
        RedInfo.Text = "Current:" & redcount()

    End Sub
    Protected Sub MakePiece(ByVal sender As Object, ByVal e As EventArgs)
        m_ThisPB = sender
        c_PCturn = m_turn Mod 2 = 0

        If Not (m_ThisPB.Image Is Nothing) Then
            c_moveCount = 0
            If c_moveCount = 0 Then
                m_Current = m_ThisPB
                CurrentPiece.Image = m_ThisPB.Image
                m_currentIndex = Convert.ToInt32(Replace(m_Current.Name, "PictureBox", ""))
                CurrentInfo.Text = "Your Position: " & m_infoarray(m_currentIndex)
            End If
            Call BadPiece(CurrentPiece)
            Call DecideMove()
            c_moveCount = 1
        End If

        For i = 0 To 31 'All Takable Pieces
            e_LegalMoves(i) = Nothing
            Call BadPiece(c_trackarray(i))
            Call DecideMove()
            m_nextB11 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(c_trackarray(i).Name, "PictureBox", "")) + C_B1)
            m_nextB21 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(c_trackarray(i).Name, "PictureBox", "")) + C_B2)
            m_nextR11 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(c_trackarray(i).Name, "PictureBox", "")) - C_R1)
            m_nextR21 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(c_trackarray(i).Name, "PictureBox", "")) - C_R2)
            Call nextPiece(m_nextB11, m_nextB21, m_nextR11, m_nextR21)
            Call NextLogic(c_trackarray(i))
            If C_B1 > 6 Or C_R1 > 6 Then
                If c_PCturn And c_trackarray(i).Image IsNot red.Image Then
                    e_LegalMoves(i) = c_trackarray(i).Name
                ElseIf Not c_PCturn And c_trackarray(i).Image IsNot black.Image Then
                    e_LegalMoves(i) = c_trackarray(i).Name
                Else
                    e_LegalMoves(i) = Nothing
                End If
            End If
        Next
        If c_moveCount = 1 Then
            For i = 0 To 31
                If e_LegalMoves(i) Is Nothing Then
                    e_NoneJumps += 1
                End If
            Next
            If e_NoneJumps > 31 Then
                m_allowmove = True
                e_NoneJumps = 0
            Else
                m_allowmove = False
                e_NoneJumps = 0
            End If
            For i = 0 To 31
                If e_LegalMoves(i) = m_Current.Name Then
                    m_allowmove = True
                End If
            Next
        End If

        If m_ThisPB.Image Is Nothing And m_allowmove Then

            'Finding Next Piece
            m_nextB1 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(m_Current.Name, "PictureBox", "")) + C_B1)
            m_nextB2 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(m_Current.Name, "PictureBox", "")) + C_B2)
            m_nextR1 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(m_Current.Name, "PictureBox", "")) - C_R1)
            m_nextR2 = "PictureBox" & Convert.ToString(Convert.ToInt32(Replace(m_Current.Name, "PictureBox", "")) - C_R2)

            Call nextPiece(m_nextB1, m_nextB2, m_nextR1, m_nextR2) 'Detects Whether if next piece is filled

            Call NextLogic(CurrentPiece) 'Allows Legal Jump Moves

            If c_moveCount = 1 Then
                If CurrentPiece.Image Is black.Image And c_PCturn Then
                    If Convert.ToInt32(Replace(m_ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(m_Current.Name, "PictureBox", "")) + C_B1) Then
                        m_ThisPB.Image = CurrentPiece.Image
                        m_Current.Image = Nothing
                        c_moveCount = 0
                        m_turn += 1

                        If C_B1 > 5 Then
                            c_nextB3.Image = Nothing
                        End If
                    ElseIf Convert.ToInt32(Replace(m_ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(m_Current.Name, "PictureBox", "")) + C_B2) Then
                        m_ThisPB.Image = CurrentPiece.Image
                        m_Current.Image = Nothing
                        c_moveCount = 0
                        m_turn += 1

                        If C_B2 > 5 Then
                            c_nextB4.Image = Nothing
                        End If
                    End If
                ElseIf (CurrentPiece.Image Is blackking.Image And c_PCturn) Then
                    If Convert.ToInt32(Replace(m_ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(m_Current.Name, "PictureBox", "")) - C_R1) Then
                        m_ThisPB.Image = CurrentPiece.Image
                        m_Current.Image = Nothing
                        c_moveCount = 0
                        m_turn += 1

                        If C_R1 > 5 Then
                            c_nextR3.Image = Nothing
                        End If
                    ElseIf (Convert.ToInt32(Replace(m_ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(m_Current.Name, "PictureBox", "")) - C_R2) Then
                        m_ThisPB.Image = CurrentPiece.Image
                        m_Current.Image = Nothing
                        c_moveCount = 0
                        m_turn += 1

                        If C_R2 > 5 Then
                            c_nextR4.Image = Nothing
                        End If
                    ElseIf Convert.ToInt32(Replace(m_ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(m_Current.Name, "PictureBox", "")) + C_B1 Then
                        m_ThisPB.Image = CurrentPiece.Image
                        m_Current.Image = Nothing
                        c_moveCount = 0
                        m_turn += 1

                        If C_B1 > 5 Then
                            c_nextB3.Image = Nothing
                        End If
                    ElseIf Convert.ToInt32(Replace(m_ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(m_Current.Name, "PictureBox", "")) + C_B2 Then
                        m_ThisPB.Image = CurrentPiece.Image
                        m_Current.Image = Nothing
                        c_moveCount = 0
                        m_turn += 1

                        If C_B2 > 5 Then
                            c_nextB4.Image = Nothing
                        End If
                    End If
                End If
            End If
        End If
        BlackInfo.Text = "Current: " & blackcount()
        RedInfo.Text = "Current: " & redcount()
        c_PCturn = (m_turn Mod 2 = 0) 'second instance to make computer move
        If Not c_PCturn Then
            Call redmove() 'Computer Move Function
        End If

        Call CheckKing()
    End Sub

    Function nextPiece(ByVal NextB1 As String, ByVal NextB2 As String, ByVal NextR1 As String, ByVal NextR2 As String)
        For i = 0 To 31
            If c_trackarray(i).Name = NextB1 Then
                c_nextB3 = c_trackarray(i)
            End If
        Next
        For i = 0 To 31
            If c_trackarray(i).Name = NextB2 Then
                c_nextB4 = c_trackarray(i)
            End If
        Next
        For i = 0 To 31
            If c_trackarray(i).Name = NextR1 Then
                c_nextR3 = c_trackarray(i)
            End If
        Next
        For i = 0 To 31
            If c_trackarray(i).Name = NextR2 Then
                c_nextR4 = c_trackarray(i)
            End If
        Next
    End Function
    Function DecideMove()
        If c_RedT = True Then
            C_R1 = 3
            C_R2 = 4
        Else
            C_R1 = 4
            C_R2 = 5
        End If
        If c_BlkT = True Then
            C_B1 = 3
            C_B2 = 4
        Else
            C_B1 = 4
            C_B2 = 5
        End If
    End Function
    Function BadPiece(ByRef Piece As PictureBox)
        If Piece.Image Is red.Image Or Piece.Image Is kingred.Image Or Piece.Image Is blackking.Image Then
            If m_red.Contains(m_currentIndex) Then
                c_RedT = True
            Else
                c_RedT = False
            End If
        End If
        If Piece.Image Is black.Image Or Piece.Image Is blackking.Image Or Piece.Image Is kingred.Image Then
            If m_black.Contains(m_currentIndex) Then
                c_BlkT = True
            Else
                c_BlkT = False
            End If
        End If
    End Function
    Function CheckKing()
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
    End Function
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
    Function redcount() As Integer
        For i = 0 To 31
            If c_trackarray(i).Image Is red.Image Or c_trackarray(i).Image Is kingred.Image Then
                redcount += 1
            End If
        Next
    End Function
    Function blackcount() As Integer
        For i = 0 To 31
            If c_trackarray(i).Image Is black.Image Or c_trackarray(i).Image Is blackking.Image Then
                blackcount += 1
            End If
        Next
    End Function
    Private Sub ExitGameToolStripMenuItem_Click(sender As Object, e As EventArgs)
        start_Menu.Show()
        Me.Hide()

    End Sub

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        Me.Close()
        start_Menu.Close()
    End Sub
    Function NextLogic(ByVal CurrentPic As PictureBox)
        If CurrentPic.Image Is black.Image Or CurrentPic.Image Is blackking.Image Then
            If c_nextB3.Image Is red.Image Or c_nextB3.Image Is kingred.Image Then
                C_B1 = 7
            End If
        End If
        If CurrentPic.Image Is black.Image Or CurrentPic.Image Is blackking.Image Then
            If c_nextB4.Image Is red.Image Or c_nextB4.Image Is kingred.Image Then
                C_B2 = 9
            End If
        End If
        If CurrentPic.Image Is blackking.Image Then
            If c_nextR3.Image Is red.Image Or c_nextR3.Image Is kingred.Image Then
                C_R1 = 7
            End If
        End If
        If CurrentPic.Image Is blackking.Image Then
            If c_nextR4.Image Is red.Image Or c_nextR4.Image Is kingred.Image Then
                C_R2 = 9
            End If
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If CurrentPic.Image Is red.Image Or CurrentPic.Image Is kingred.Image Then
            If c_nextR3.Image Is black.Image Or c_nextR3.Image Is blackking.Image Then
                C_R1 = 7
            End If
        End If
        If CurrentPic.Image Is red.Image Or CurrentPic.Image Is kingred.Image Then
            If c_nextR4.Image Is black.Image Or c_nextR4.Image Is blackking.Image Then
                C_R2 = 9
            End If
        End If
        If CurrentPic.Image Is kingred.Image Then
            If c_nextB3.Image Is black.Image Or c_nextB3.Image Is blackking.Image Then
                C_B1 = 7
            End If
        End If
        If CurrentPic.Image Is kingred.Image Then
            If c_nextB4.Image Is black.Image Or c_nextB4.Image Is blackking.Image Then
                C_B2 = 9
            End If
        End If
    End Function
    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        BackGround.Show()

    End Sub
    Function redmove()

        Dim m_compRedNextJump1, m_compRedNextJump2 As String
        Dim c_compJumped As Boolean
        Dim c_Comp As PictureBox
        Dim m_compRedSml, m_compRedBig As Integer
        Dim m_compRedNext1, m_compRedNext2 As String
        c_compJumped = False
        For i = 0 To 31
            c_PCturn = (m_turn Mod 2 = 0)
            If c_trackarray(i).Image Is red.Image And Not (c_PCturn) Then
                c_Comp = c_trackarray(i)
                m_red = {0, 1, 2, 3, 8, 9, 10, 11, 16, 17, 18, 19, 24, 25, 26, 27}
                For j = 0 To 11
                    If i = m_red(j) Then
                        m_compRedSml = 3
                        m_compRedBig = 4
                        Exit For
                    Else
                        m_compRedSml = 4
                        m_compRedBig = 5
                    End If
                Next
                If i = 20 Or i = 28 Then
                    m_compRedBig = 0
                End If
                m_compRedNext1 = Convert.ToString("PictureBox" & (Convert.ToInt32(Replace(c_Comp.Name, "PictureBox", "")) - m_compRedSml))
                m_compRedNext2 = Convert.ToString("PictureBox" & (Convert.ToInt32(Replace(c_Comp.Name, "PictureBox", "")) - m_compRedBig))
                Call compnext(m_compRedNext1, m_compRedNext2)
                If c_compnext1.Image Is black.Image Or c_compnext1.Image Is blackking.Image Then
                    m_compRedSml = 7
                ElseIf c_compnext2.Image Is black.Image Or c_compnext2.Image Is blackking.Image Then
                    m_compRedBig = 9
                End If

                m_compRedNextJump1 = Convert.ToString("PictureBox" & (Convert.ToInt32(Replace(c_Comp.Name, "PictureBox", "")) - m_compRedSml))
                m_compRedNextJump2 = Convert.ToString("PictureBox" & (Convert.ToInt32(Replace(c_Comp.Name, "PictureBox", "")) - m_compRedBig))
                Call compjump(m_compRedNextJump1, m_compRedNextJump2)
                If m_compRedSml > 6 And (c_CompJump1.Image Is Nothing) Then
                    c_compnext1.Image = Nothing 'Jumped Image is removed
                    c_CompJump1.Image = c_Comp.Image 'New Piece is Placed
                    c_Comp.Image = Nothing 'Old Piece Removed
                    c_compJumped = True
                    m_turn += 1
                    Exit For
                ElseIf m_compRedBig > 8 And (c_CompJump2.Image Is Nothing) Then
                    c_compnext2.Image = Nothing 'Jumped Image is removed
                    c_CompJump2.Image = c_Comp.Image 'New piece
                    c_Comp.Image = Nothing 'Old Piece Removed
                    c_compJumped = True
                    m_turn += 1
                    Exit For
                End If
            End If

        Next

        For i = 0 To 31
            If c_compJumped = False Then
                c_Comp = c_trackarray(i)
                If c_Comp.Image Is red.Image Then
                    For j = 0 To 11
                        If i = m_red(j) Then
                            m_compRedSml = 3
                            m_compRedBig = 4
                            Exit For
                        Else
                            m_compRedSml = 3
                            m_compRedBig = 4
                        End If
                    Next
                    m_compRedNext1 = Convert.ToString("PictureBox" & (Convert.ToInt32(Replace(c_Comp.Name, "PictureBox", "")) - m_compRedSml))
                    m_compRedNext2 = Convert.ToString("PictureBox" & (Convert.ToInt32(Replace(c_Comp.Name, "PictureBox", "")) - m_compRedBig))
                    Call compnext(m_compRedNext1, m_compRedNext2)

                    If c_compnext2.Image Is Nothing Then
                        c_compnext2.Image = c_Comp.Image
                        c_Comp.Image = Nothing
                        m_turn += 1
                        Exit For
                    ElseIf c_compnext1.Image Is Nothing Then
                        c_compnext1.Image = c_Comp.Image
                        c_Comp.Image = Nothing
                        m_turn += 1
                        Exit For
                    End If
                End If
            End If
        Next

    End Function
    Function compnext(ByVal m_next1 As String, ByVal m_next2 As String)
        For i = 0 To 31
            If c_trackarray(i).Name = m_next1 Then
                c_compnext1 = c_trackarray(i)
            ElseIf c_trackarray(i).Name = m_next2 Then
                c_compnext2 = c_trackarray(i)
            End If
        Next
    End Function
    Function compjump(ByVal m_JumpSmall As String, ByVal m_JumpBig As String)
        For i = 0 To 31
            If c_trackarray(i).Name = m_JumpSmall Then
                c_CompJump1 = c_trackarray(i)
            ElseIf c_trackarray(i).Name = m_JumpBig Then
                c_CompJump2 = c_trackarray(i)
            End If
        Next
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c_resign As Integer
        c_resign = MsgBox("Are You Sure You Wish to Resign?", vbYesNo)
        If c_resign = 6 Then
            Me.Close()
        End If
    End Sub
End Class