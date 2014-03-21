Public Class start_Menu
    Dim gamesetup(0 To 32) As Integer
    Dim gamesetupL(0 To 32) As Integer

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        ButtonC.Visible = True
        ButtonS.Visible = True

    End Sub

    Private Sub start_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonC.Visible = False
        ButtonS.Visible = False
        For i = 0 To 32
            gamesetup(i) = 0
        Next
    End Sub

    Private Sub ButtonS_Click(sender As Object, e As EventArgs) Handles ButtonS.Click
        For i = 0 To 11
            gamesetup(i) = 1 '1 for black piece
        Next
        For i = 20 To 31
            gamesetup(i) = 2 '2 for red piece
        Next
        For i = 12 To 19
            gamesetup(i) = 0 ' for nothing
        Next
        gamesetup(32) = 10
        Play.Visible = True

        Me.Visible = False

    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        Me.Visible = False
        CustomMode.Show()
    End Sub
    Public Function GetSetup()

        Return gamesetup

    End Function

    Private Sub Load_Click(sender As Object, e As EventArgs) Handles Load.Click
        Try
            gamesetupL(32) = 10
            Dim reader As System.IO.StreamReader = _
            New System.IO.StreamReader("../SavedGame.txt")
            For i = 0 To gamesetup.Length - 2
                gamesetupL(i) = Replace(reader.ReadLine, "\n", "")
            Next
            reader.Close()
            Me.Hide()
            Play.Show()
        Catch
            MsgBox("No Saved Game!")
        End Try

    End Sub
    Public Function GetsetupL()
        Return gamesetupL
    End Function
End Class