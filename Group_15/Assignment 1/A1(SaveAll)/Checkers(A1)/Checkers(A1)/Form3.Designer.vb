<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.GameResume = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GameResume
        '
        Me.GameResume.Location = New System.Drawing.Point(200, 590)
        Me.GameResume.Name = "GameResume"
        Me.GameResume.Size = New System.Drawing.Size(103, 23)
        Me.GameResume.TabIndex = 0
        Me.GameResume.Text = "Resume Game"
        Me.GameResume.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(517, 625)
        Me.Controls.Add(Me.GameResume)
        Me.MaximumSize = New System.Drawing.Size(533, 663)
        Me.MinimumSize = New System.Drawing.Size(533, 663)
        Me.Name = "Form3"
        Me.Text = "Ultimate Checkers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GameResume As System.Windows.Forms.Button
End Class
