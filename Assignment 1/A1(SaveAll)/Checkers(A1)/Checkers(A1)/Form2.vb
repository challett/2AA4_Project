Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonColSet_Click(sender As Object, e As EventArgs) Handles ButtonColSet.Click
        If RadioButtonGreen.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutGreen
        End If

        If RadioButtonBlue.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutBlue
        End If

        If RadioButtonRed.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutRed
        End If

        If RadioButtonGrey.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutGrey
        End If

        If RadioButtonGreenM.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutGreenM
        End If

        If RadioButtonBlueM.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutBlueM
        End If

        If RadioButtonRedM.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutRedM
        End If

        If RadioButtonGreyM.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutGreyM
        End If

        If RadioButtonGreenT.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutGreenT
        End If

        If RadioButtonBlueT.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutBlueT
        End If

        If RadioButtonRedT.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutRedT
        End If

        If RadioButtonGreyT.Checked = True Then
            Form1.BackgroundImage = My.Resources.LayoutGreyT
        End If

    End Sub
End Class