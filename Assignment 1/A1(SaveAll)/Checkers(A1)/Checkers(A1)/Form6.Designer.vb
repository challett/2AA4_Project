<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayAsRed
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RedInfo = New System.Windows.Forms.Label()
        Me.BlackInfo = New System.Windows.Forms.Label()
        Me.CurrentInfo = New System.Windows.Forms.Label()
        Me.CurrentPiece = New System.Windows.Forms.PictureBox()
        Me.kingred = New System.Windows.Forms.PictureBox()
        Me.red = New System.Windows.Forms.PictureBox()
        Me.black = New System.Windows.Forms.PictureBox()
        Me.blackking = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.CurrentPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kingred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Algerian", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(197, 600)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Press Here To Resign"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RedInfo
        '
        Me.RedInfo.AutoSize = True
        Me.RedInfo.BackColor = System.Drawing.Color.Transparent
        Me.RedInfo.Font = New System.Drawing.Font("Algerian", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedInfo.Location = New System.Drawing.Point(44, 587)
        Me.RedInfo.Name = "RedInfo"
        Me.RedInfo.Size = New System.Drawing.Size(72, 12)
        Me.RedInfo.TabIndex = 33
        Me.RedInfo.Text = "Current: 12"
        '
        'BlackInfo
        '
        Me.BlackInfo.AutoSize = True
        Me.BlackInfo.BackColor = System.Drawing.Color.Transparent
        Me.BlackInfo.Font = New System.Drawing.Font("Algerian", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlackInfo.Location = New System.Drawing.Point(382, 587)
        Me.BlackInfo.Name = "BlackInfo"
        Me.BlackInfo.Size = New System.Drawing.Size(63, 12)
        Me.BlackInfo.TabIndex = 32
        Me.BlackInfo.Text = "Your Turn"
        '
        'CurrentInfo
        '
        Me.CurrentInfo.AutoSize = True
        Me.CurrentInfo.BackColor = System.Drawing.Color.Transparent
        Me.CurrentInfo.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentInfo.Location = New System.Drawing.Point(210, 573)
        Me.CurrentInfo.Name = "CurrentInfo"
        Me.CurrentInfo.Size = New System.Drawing.Size(0, 18)
        Me.CurrentInfo.TabIndex = 31
        '
        'CurrentPiece
        '
        Me.CurrentPiece.BackColor = System.Drawing.Color.Transparent
        Me.CurrentPiece.Location = New System.Drawing.Point(141, 573)
        Me.CurrentPiece.Name = "CurrentPiece"
        Me.CurrentPiece.Size = New System.Drawing.Size(50, 50)
        Me.CurrentPiece.TabIndex = 30
        Me.CurrentPiece.TabStop = False
        '
        'kingred
        '
        Me.kingred.Image = Global.WindowsApplication1.My.Resources.Resources.RP_King__shadow_
        Me.kingred.Location = New System.Drawing.Point(426, 74)
        Me.kingred.Name = "kingred"
        Me.kingred.Size = New System.Drawing.Size(100, 50)
        Me.kingred.TabIndex = 29
        Me.kingred.TabStop = False
        Me.kingred.Visible = False
        '
        'red
        '
        Me.red.Image = Global.WindowsApplication1.My.Resources.Resources.RP_shadow_
        Me.red.Location = New System.Drawing.Point(296, 74)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(100, 50)
        Me.red.TabIndex = 28
        Me.red.TabStop = False
        Me.red.Visible = False
        '
        'black
        '
        Me.black.Image = Global.WindowsApplication1.My.Resources.Resources.BP_shadow_
        Me.black.Location = New System.Drawing.Point(0, 267)
        Me.black.Name = "black"
        Me.black.Size = New System.Drawing.Size(100, 50)
        Me.black.TabIndex = 27
        Me.black.TabStop = False
        Me.black.Visible = False
        '
        'blackking
        '
        Me.blackking.Image = Global.WindowsApplication1.My.Resources.Resources.BP_King__shadow_
        Me.blackking.Location = New System.Drawing.Point(38, 74)
        Me.blackking.Name = "blackking"
        Me.blackking.Size = New System.Drawing.Size(100, 50)
        Me.blackking.TabIndex = 26
        Me.blackking.TabStop = False
        Me.blackking.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(501, 24)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveGameToolStripMenuItem, Me.ExitApplicationToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SaveGameToolStripMenuItem
        '
        Me.SaveGameToolStripMenuItem.Name = "SaveGameToolStripMenuItem"
        Me.SaveGameToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SaveGameToolStripMenuItem.Text = "Save Game"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit Application"
        '
        'PlayAsRed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LayoutGreen
        Me.ClientSize = New System.Drawing.Size(501, 624)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RedInfo)
        Me.Controls.Add(Me.BlackInfo)
        Me.Controls.Add(Me.CurrentInfo)
        Me.Controls.Add(Me.CurrentPiece)
        Me.Controls.Add(Me.kingred)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.black)
        Me.Controls.Add(Me.blackking)
        Me.Name = "PlayAsRed"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "PlayAgainstAi"
        CType(Me.CurrentPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kingred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RedInfo As System.Windows.Forms.Label
    Friend WithEvents BlackInfo As System.Windows.Forms.Label
    Friend WithEvents CurrentInfo As System.Windows.Forms.Label
    Friend WithEvents CurrentPiece As System.Windows.Forms.PictureBox
    Friend WithEvents kingred As System.Windows.Forms.PictureBox
    Friend WithEvents red As System.Windows.Forms.PictureBox
    Friend WithEvents black As System.Windows.Forms.PictureBox
    Friend WithEvents blackking As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
