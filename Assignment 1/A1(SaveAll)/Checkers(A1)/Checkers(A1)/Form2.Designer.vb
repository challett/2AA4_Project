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
        Me.RadioButtonGreenT = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGreenM = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBlueM = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRedM = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGreyM = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBlueT = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRedT = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGreyT = New System.Windows.Forms.RadioButton()
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
        Me.GroupBox1.Controls.Add(Me.RadioButtonGreyT)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRedT)
        Me.GroupBox1.Controls.Add(Me.RadioButtonBlueT)
        Me.GroupBox1.Controls.Add(Me.RadioButtonGreyM)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRedM)
        Me.GroupBox1.Controls.Add(Me.RadioButtonBlueM)
        Me.GroupBox1.Controls.Add(Me.RadioButtonGreenM)
        Me.GroupBox1.Controls.Add(Me.RadioButtonGreenT)
        Me.GroupBox1.Controls.Add(Me.RadioButtonGrey)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRed)
        Me.GroupBox1.Controls.Add(Me.RadioButtonBlue)
        Me.GroupBox1.Controls.Add(Me.RadioButtonGreen)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 113)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colours"
        '
        'RadioButtonGrey
        '
        Me.RadioButtonGrey.AutoSize = True
        Me.RadioButtonGrey.Location = New System.Drawing.Point(7, 89)
        Me.RadioButtonGrey.Name = "RadioButtonGrey"
        Me.RadioButtonGrey.Size = New System.Drawing.Size(67, 17)
        Me.RadioButtonGrey.TabIndex = 3
        Me.RadioButtonGrey.TabStop = True
        Me.RadioButtonGrey.Text = "Grey Felt"
        Me.RadioButtonGrey.UseVisualStyleBackColor = True
        '
        'RadioButtonRed
        '
        Me.RadioButtonRed.AutoSize = True
        Me.RadioButtonRed.Location = New System.Drawing.Point(7, 66)
        Me.RadioButtonRed.Name = "RadioButtonRed"
        Me.RadioButtonRed.Size = New System.Drawing.Size(65, 17)
        Me.RadioButtonRed.TabIndex = 2
        Me.RadioButtonRed.TabStop = True
        Me.RadioButtonRed.Text = "Red Felt"
        Me.RadioButtonRed.UseVisualStyleBackColor = True
        '
        'RadioButtonBlue
        '
        Me.RadioButtonBlue.AutoSize = True
        Me.RadioButtonBlue.Location = New System.Drawing.Point(7, 43)
        Me.RadioButtonBlue.Name = "RadioButtonBlue"
        Me.RadioButtonBlue.Size = New System.Drawing.Size(66, 17)
        Me.RadioButtonBlue.TabIndex = 1
        Me.RadioButtonBlue.TabStop = True
        Me.RadioButtonBlue.Text = "Blue Felt"
        Me.RadioButtonBlue.UseVisualStyleBackColor = True
        '
        'RadioButtonGreen
        '
        Me.RadioButtonGreen.AutoSize = True
        Me.RadioButtonGreen.Location = New System.Drawing.Point(7, 20)
        Me.RadioButtonGreen.Name = "RadioButtonGreen"
        Me.RadioButtonGreen.Size = New System.Drawing.Size(74, 17)
        Me.RadioButtonGreen.TabIndex = 0
        Me.RadioButtonGreen.TabStop = True
        Me.RadioButtonGreen.Text = "Green Felt"
        Me.RadioButtonGreen.UseVisualStyleBackColor = True
        '
        'ButtonColSet
        '
        Me.ButtonColSet.Location = New System.Drawing.Point(104, 172)
        Me.ButtonColSet.Name = "ButtonColSet"
        Me.ButtonColSet.Size = New System.Drawing.Size(75, 23)
        Me.ButtonColSet.TabIndex = 2
        Me.ButtonColSet.Text = "Set Colour"
        Me.ButtonColSet.UseVisualStyleBackColor = True
        '
        'RadioButtonGreenT
        '
        Me.RadioButtonGreenT.AutoSize = True
        Me.RadioButtonGreenT.Location = New System.Drawing.Point(165, 19)
        Me.RadioButtonGreenT.Name = "RadioButtonGreenT"
        Me.RadioButtonGreenT.Size = New System.Drawing.Size(75, 17)
        Me.RadioButtonGreenT.TabIndex = 4
        Me.RadioButtonGreenT.TabStop = True
        Me.RadioButtonGreenT.Text = "Green Blur"
        Me.RadioButtonGreenT.UseVisualStyleBackColor = True
        '
        'RadioButtonGreenM
        '
        Me.RadioButtonGreenM.AutoSize = True
        Me.RadioButtonGreenM.Location = New System.Drawing.Point(94, 19)
        Me.RadioButtonGreenM.Name = "RadioButtonGreenM"
        Me.RadioButtonGreenM.Size = New System.Drawing.Size(54, 17)
        Me.RadioButtonGreenM.TabIndex = 5
        Me.RadioButtonGreenM.TabStop = True
        Me.RadioButtonGreenM.Text = "Green"
        Me.RadioButtonGreenM.UseVisualStyleBackColor = True
        '
        'RadioButtonBlueM
        '
        Me.RadioButtonBlueM.AutoSize = True
        Me.RadioButtonBlueM.Location = New System.Drawing.Point(94, 43)
        Me.RadioButtonBlueM.Name = "RadioButtonBlueM"
        Me.RadioButtonBlueM.Size = New System.Drawing.Size(46, 17)
        Me.RadioButtonBlueM.TabIndex = 6
        Me.RadioButtonBlueM.TabStop = True
        Me.RadioButtonBlueM.Text = "Blue"
        Me.RadioButtonBlueM.UseVisualStyleBackColor = True
        '
        'RadioButtonRedM
        '
        Me.RadioButtonRedM.AutoSize = True
        Me.RadioButtonRedM.Location = New System.Drawing.Point(94, 66)
        Me.RadioButtonRedM.Name = "RadioButtonRedM"
        Me.RadioButtonRedM.Size = New System.Drawing.Size(45, 17)
        Me.RadioButtonRedM.TabIndex = 7
        Me.RadioButtonRedM.TabStop = True
        Me.RadioButtonRedM.Text = "Red"
        Me.RadioButtonRedM.UseVisualStyleBackColor = True
        '
        'RadioButtonGreyM
        '
        Me.RadioButtonGreyM.AutoSize = True
        Me.RadioButtonGreyM.Location = New System.Drawing.Point(94, 89)
        Me.RadioButtonGreyM.Name = "RadioButtonGreyM"
        Me.RadioButtonGreyM.Size = New System.Drawing.Size(47, 17)
        Me.RadioButtonGreyM.TabIndex = 8
        Me.RadioButtonGreyM.TabStop = True
        Me.RadioButtonGreyM.Text = "Grey"
        Me.RadioButtonGreyM.UseVisualStyleBackColor = True
        '
        'RadioButtonBlueT
        '
        Me.RadioButtonBlueT.AutoSize = True
        Me.RadioButtonBlueT.Location = New System.Drawing.Point(165, 43)
        Me.RadioButtonBlueT.Name = "RadioButtonBlueT"
        Me.RadioButtonBlueT.Size = New System.Drawing.Size(67, 17)
        Me.RadioButtonBlueT.TabIndex = 9
        Me.RadioButtonBlueT.TabStop = True
        Me.RadioButtonBlueT.Text = "Blue Blur"
        Me.RadioButtonBlueT.UseVisualStyleBackColor = True
        '
        'RadioButtonRedT
        '
        Me.RadioButtonRedT.AutoSize = True
        Me.RadioButtonRedT.Location = New System.Drawing.Point(165, 66)
        Me.RadioButtonRedT.Name = "RadioButtonRedT"
        Me.RadioButtonRedT.Size = New System.Drawing.Size(66, 17)
        Me.RadioButtonRedT.TabIndex = 10
        Me.RadioButtonRedT.TabStop = True
        Me.RadioButtonRedT.Text = "Red Blur"
        Me.RadioButtonRedT.UseVisualStyleBackColor = True
        '
        'RadioButtonGreyT
        '
        Me.RadioButtonGreyT.AutoSize = True
        Me.RadioButtonGreyT.Location = New System.Drawing.Point(165, 89)
        Me.RadioButtonGreyT.Name = "RadioButtonGreyT"
        Me.RadioButtonGreyT.Size = New System.Drawing.Size(68, 17)
        Me.RadioButtonGreyT.TabIndex = 11
        Me.RadioButtonGreyT.TabStop = True
        Me.RadioButtonGreyT.Text = "Grey Blur"
        Me.RadioButtonGreyT.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 207)
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
    Friend WithEvents RadioButtonGreyT As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonRedT As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonBlueT As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonGreyM As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonRedM As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonBlueM As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonGreenM As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonGreenT As System.Windows.Forms.RadioButton
End Class
