Public Class BackGround

    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Curback As Object = My.Resources.LayoutGreen


    Public Sub ButtonColSet_Click(sender As Object, e As EventArgs) Handles ButtonColSet.Click

        Dim CurBack As Object

        If RadioButtonGreen.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutGreen
            CurBack = My.Resources.LayoutGreen
            Return
        End If

        If RadioButtonBlue.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutBlue
            CurBack = My.Resources.LayoutBlue
        End If

        If RadioButtonRed.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutRed
            CurBack = My.Resources.LayoutRed
        End If

        If RadioButtonGrey.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutGrey
            CurBack = My.Resources.LayoutGrey
        End If

        If RadioButtonGreenM.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutGreenM
            CurBack = My.Resources.LayoutGreenM
        End If

        If RadioButtonBlueM.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutBlueM
            CurBack = My.Resources.LayoutBlueM
        End If

        If RadioButtonRedM.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutRedM
            CurBack = My.Resources.LayoutRedM
        End If

        If RadioButtonGreyM.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutGreyM
            CurBack = My.Resources.LayoutGreyM
        End If

        If RadioButtonGreenT.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutGreenT
            CurBack = My.Resources.LayoutGreenT
        End If

        If RadioButtonBlueT.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutBlueT
            CurBack = My.Resources.LayoutBlueT
        End If

        If RadioButtonRedT.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutRedT
            CurBack = My.Resources.LayoutRedT
        End If

        If RadioButtonGreyT.Checked = True Then
            Play.BackgroundImage = My.Resources.LayoutGreyT
            CurBack = My.Resources.LayoutGreyT
        End If

    End Sub

    Private Sub RadioButtonGreen_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonGreen.CheckedChanged

    End Sub
End Class