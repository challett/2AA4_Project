Public Class Play
    Dim c_trackarray(0 To 31) As PictureBox
    Dim movecount As Integer
    Dim current As PictureBox
    Dim CB1, CB2, CR1, CR2 As Integer
    Dim BlkT, RedT As Boolean
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        start_Menu.Close()
        CustomMode.Close()
    End Sub
    Private Sub Play_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c_track As Integer
        Dim c_Initialx As Integer
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
        If gamesetupC(32) = 10 Then
            makegame(gamesetupC)
        ElseIf gamesetupS(32) = 10 Then
            makegame(gamesetupS)
        End If

    End Sub
    Protected Sub MakePiece(ByVal sender As Object, ByVal e As EventArgs)
        Dim ThisPB As PictureBox
        ThisPB = sender
        Dim BadNum As Integer
        Dim BadRed(0 To 11) As Integer
        Dim BadBlack(0 To 11) As Integer


        BadBlack = {4, 5, 6, 7, 12, 13, 14, 15, 20, 21, 22, 23}
        BadRed = {8, 9, 10, 11, 16, 17, 18, 19, 24, 25, 26, 27}

        If Not (ThisPB.Image Is Nothing) Then
            movecount = 0
            If movecount = 0 Then
                current = ThisPB
                CurrentPiece.Image = ThisPB.Image
                CurrentInfo.Text = Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", ""))
                BadNum = Convert.ToInt32(Replace(current.Name, "PictureBox", ""))
            End If
            If CurrentPiece.Image Is red.Image Then
                If BadRed.Contains(BadNum) Then
                    RedT = True
                Else
                    RedT = False
                End If
            ElseIf CurrentPiece.Image Is black.Image Then
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
            If movecount = 1 Then
                If CurrentPiece.Image Is black.Image Then
                    If Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(current.Name, "PictureBox", "")) + CB1) Or Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(current.Name, "PictureBox", "")) + CB2) Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                    End If
                ElseIf CurrentPiece.Image Is red.Image Then
                    If Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(current.Name, "PictureBox", "")) - CR1) Or (Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(current.Name, "PictureBox", "")) - CR2) Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                    End If
                ElseIf CurrentPiece.Image Is kingred.Image Or CurrentPiece.Image Is blackking.Image Then
                    If Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = (Convert.ToInt32(Replace(current.Name, "PictureBox", "")) - CR1) Or (Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(current.Name, "PictureBox", "")) - CR2) Or Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(current.Name, "PictureBox", "")) + CB1 Or Convert.ToInt32(Replace(ThisPB.Name, "PictureBox", "")) = Convert.ToInt32(Replace(current.Name, "PictureBox", "")) + CB2 Then
                        ThisPB.Image = CurrentPiece.Image
                        current.Image = Nothing
                        movecount = 0
                    End If
                End If
            End If
        End If

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
End Class