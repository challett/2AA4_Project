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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(start_Menu))
        Me.Start = New System.Windows.Forms.Button()
        Me.Load = New System.Windows.Forms.Button()
        Me.Score = New System.Windows.Forms.Button()
        Me.ButtonS = New System.Windows.Forms.Button()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Transparent
        Me.Start.Font = New System.Drawing.Font("Agency FB", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Start.Location = New System.Drawing.Point(38, 120)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(102, 55)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start Game"
        Me.Start.UseVisualStyleBackColor = False
        '
        'Load
        '
        Me.Load.Font = New System.Drawing.Font("Agency FB", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Load.Location = New System.Drawing.Point(146, 120)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(102, 55)
        Me.Load.TabIndex = 1
        Me.Load.Text = "Load Game"
        Me.Load.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.Score.Font = New System.Drawing.Font("Agency FB", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.Location = New System.Drawing.Point(92, 272)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(102, 35)
        Me.Score.TabIndex = 2
        Me.Score.Text = "High Scores"
        Me.Score.UseVisualStyleBackColor = True
        '
        'ButtonS
        '
        Me.ButtonS.Font = New System.Drawing.Font("Agency FB", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonS.ForeColor = System.Drawing.Color.Black
        Me.ButtonS.Location = New System.Drawing.Point(38, 191)
        Me.ButtonS.Name = "ButtonS"
        Me.ButtonS.Size = New System.Drawing.Size(102, 36)
        Me.ButtonS.TabIndex = 4
        Me.ButtonS.Text = "Standard"
        Me.ButtonS.UseVisualStyleBackColor = True
        '
        'ButtonC
        '
        Me.ButtonC.Font = New System.Drawing.Font("Agency FB", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonC.ForeColor = System.Drawing.Color.Black
        Me.ButtonC.Location = New System.Drawing.Point(146, 191)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(102, 36)
        Me.ButtonC.TabIndex = 5
        Me.ButtonC.Text = "Custom"
        Me.ButtonC.UseVisualStyleBackColor = True
        '
        'start_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 322)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.ButtonS)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.Start)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(300, 360)
        Me.MinimumSize = New System.Drawing.Size(300, 360)
        Me.Name = "start_Menu"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Load As System.Windows.Forms.Button
    Friend WithEvents Score As System.Windows.Forms.Button
    Friend WithEvents ButtonS As System.Windows.Forms.Button
    Friend WithEvents ButtonC As System.Windows.Forms.Button
End Class
