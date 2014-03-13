<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class start_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Start = New System.Windows.Forms.Button()
        Me.Load = New System.Windows.Forms.Button()
        Me.Score = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.ButtonS = New System.Windows.Forms.Button()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Transparent
        Me.Start.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Start.Location = New System.Drawing.Point(166, 64)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(102, 55)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start Game"
        Me.Start.UseVisualStyleBackColor = False
        '
        'Load
        '
        Me.Load.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Load.Location = New System.Drawing.Point(166, 125)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(102, 55)
        Me.Load.TabIndex = 1
        Me.Load.Text = "Load Game"
        Me.Load.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.Score.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.Location = New System.Drawing.Point(166, 186)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(102, 55)
        Me.Score.TabIndex = 2
        Me.Score.Text = "High Scores"
        Me.Score.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(12, 318)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(102, 22)
        Me.Quit.TabIndex = 3
        Me.Quit.Text = "Quit Game"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'ButtonS
        '
        Me.ButtonS.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonS.Location = New System.Drawing.Point(362, 36)
        Me.ButtonS.Name = "ButtonS"
        Me.ButtonS.Size = New System.Drawing.Size(102, 55)
        Me.ButtonS.TabIndex = 4
        Me.ButtonS.Text = "Standard Game"
        Me.ButtonS.UseVisualStyleBackColor = True
        '
        'ButtonC
        '
        Me.ButtonC.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonC.Location = New System.Drawing.Point(362, 107)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(102, 55)
        Me.ButtonC.TabIndex = 5
        Me.ButtonC.Text = "Custom Game"
        Me.ButtonC.UseVisualStyleBackColor = True
        '
        'start_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.abstract_color_background_picture_8016_wide
        Me.ClientSize = New System.Drawing.Size(476, 352)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.ButtonS)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.Start)
        Me.Name = "start_Menu"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Load As System.Windows.Forms.Button
    Friend WithEvents Score As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents ButtonS As System.Windows.Forms.Button
    Friend WithEvents ButtonC As System.Windows.Forms.Button
End Class
