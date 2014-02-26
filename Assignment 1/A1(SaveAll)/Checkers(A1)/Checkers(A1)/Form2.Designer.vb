<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonGrey = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRed = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBlue = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGreen = New System.Windows.Forms.RadioButton()
        Me.ButtonColSet = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select the preffered colour background."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonGrey)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRed)
        Me.GroupBox1.Controls.Add(Me.RadioButtonBlue)
        Me.GroupBox1.Controls.Add(Me.RadioButtonGreen)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 113)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colours"
        '
        'RadioButtonGrey
        '
        Me.RadioButtonGrey.AutoSize = True
        Me.RadioButtonGrey.Location = New System.Drawing.Point(7, 89)
        Me.RadioButtonGrey.Name = "RadioButtonGrey"
        Me.RadioButtonGrey.Size = New System.Drawing.Size(47, 17)
        Me.RadioButtonGrey.TabIndex = 3
        Me.RadioButtonGrey.TabStop = True
        Me.RadioButtonGrey.Text = "Grey"
        Me.RadioButtonGrey.UseVisualStyleBackColor = True
        '
        'RadioButtonRed
        '
        Me.RadioButtonRed.AutoSize = True
        Me.RadioButtonRed.Location = New System.Drawing.Point(7, 66)
        Me.RadioButtonRed.Name = "RadioButtonRed"
        Me.RadioButtonRed.Size = New System.Drawing.Size(45, 17)
        Me.RadioButtonRed.TabIndex = 2
        Me.RadioButtonRed.TabStop = True
        Me.RadioButtonRed.Text = "Red"
        Me.RadioButtonRed.UseVisualStyleBackColor = True
        '
        'RadioButtonBlue
        '
        Me.RadioButtonBlue.AutoSize = True
        Me.RadioButtonBlue.Location = New System.Drawing.Point(7, 43)
        Me.RadioButtonBlue.Name = "RadioButtonBlue"
        Me.RadioButtonBlue.Size = New System.Drawing.Size(46, 17)
        Me.RadioButtonBlue.TabIndex = 1
        Me.RadioButtonBlue.TabStop = True
        Me.RadioButtonBlue.Text = "Blue"
        Me.RadioButtonBlue.UseVisualStyleBackColor = True
        '
        'RadioButtonGreen
        '
        Me.RadioButtonGreen.AutoSize = True
        Me.RadioButtonGreen.Location = New System.Drawing.Point(7, 20)
        Me.RadioButtonGreen.Name = "RadioButtonGreen"
        Me.RadioButtonGreen.Size = New System.Drawing.Size(54, 17)
        Me.RadioButtonGreen.TabIndex = 0
        Me.RadioButtonGreen.TabStop = True
        Me.RadioButtonGreen.Text = "Green"
        Me.RadioButtonGreen.UseVisualStyleBackColor = True
        '
        'ButtonColSet
        '
        Me.ButtonColSet.Location = New System.Drawing.Point(93, 172)
        Me.ButtonColSet.Name = "ButtonColSet"
        Me.ButtonColSet.Size = New System.Drawing.Size(75, 23)
        Me.ButtonColSet.TabIndex = 2
        Me.ButtonColSet.Text = "Set Colour"
        Me.ButtonColSet.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 207)
        Me.Controls.Add(Me.ButtonColSet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Background"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonColSet As System.Windows.Forms.Button
    Friend WithEvents RadioButtonGrey As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonRed As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonBlue As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonGreen As System.Windows.Forms.RadioButton
End Class
