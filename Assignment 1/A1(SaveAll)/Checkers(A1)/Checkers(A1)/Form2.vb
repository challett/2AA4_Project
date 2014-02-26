Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonColSet_Click(sender As Object, e As EventArgs) Handles ButtonColSet.Click
        If RadioButtonGreen.Checked = True Then
            Form1.BackgroundImage = Image.FromFile("C:\Users\NICK\Documents\Ecole\Université (McMaster)\McMaster\Courses\SOFTWARE ENG II\Deuxième Semestre\Software Design I (2AA4)\Assignments\Assignment 1\Images\Checkerboard\LayoutGreen.png")
        End If

        If RadioButtonBlue.Checked = True Then
            Form1.BackgroundImage = Image.FromFile("C:\Users\NICK\Documents\Ecole\Université (McMaster)\McMaster\Courses\SOFTWARE ENG II\Deuxième Semestre\Software Design I (2AA4)\Assignments\Assignment 1\Images\Checkerboard\LayoutBlue.png")
        End If

        If RadioButtonRed.Checked = True Then
            Form1.BackgroundImage = Image.FromFile("C:\Users\NICK\Documents\Ecole\Université (McMaster)\McMaster\Courses\SOFTWARE ENG II\Deuxième Semestre\Software Design I (2AA4)\Assignments\Assignment 1\Images\Checkerboard\LayoutRed.png")
        End If

        If RadioButtonGrey.Checked = True Then
            Form1.BackgroundImage = Image.FromFile("C:\Users\NICK\Documents\Ecole\Université (McMaster)\McMaster\Courses\SOFTWARE ENG II\Deuxième Semestre\Software Design I (2AA4)\Assignments\Assignment 1\Images\Checkerboard\LayoutGrey.png")
        End If

    End Sub
End Class