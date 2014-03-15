<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomMode
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomMode))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMode = New System.Windows.Forms.Button()
        Me.RightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BlackPieceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackReg = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackKing = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedPieceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedReg = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedKing = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovePiece = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomPiece = New System.Windows.Forms.PictureBox()
        Me.red = New System.Windows.Forms.PictureBox()
        Me.black = New System.Windows.Forms.PictureBox()
        Me.kingred = New System.Windows.Forms.PictureBox()
        Me.blkking = New System.Windows.Forms.PictureBox()
        Me.CustomInfo = New System.Windows.Forms.Label()
        Me.ErrorClick = New System.Windows.Forms.PictureBox()
        Me.TimerDisp = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.RightClick.SuspendLayout()
        CType(Me.CustomPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kingred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blkking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorClick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ViewToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(501, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.PauseGame, Me.QuitGameToolStripMenuItem, Me.SaveGameToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardToolStripMenuItem, Me.CustomToolStripMenuItem, Me.LoadToolStripMenuItem})
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'StandardToolStripMenuItem
        '
        Me.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem"
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.StandardToolStripMenuItem.Text = "Standard"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'PauseGame
        '
        Me.PauseGame.Enabled = False
        Me.PauseGame.Name = "PauseGame"
        Me.PauseGame.Size = New System.Drawing.Size(139, 22)
        Me.PauseGame.Text = "Pause Game"
        '
        'QuitGameToolStripMenuItem
        '
        Me.QuitGameToolStripMenuItem.Name = "QuitGameToolStripMenuItem"
        Me.QuitGameToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.QuitGameToolStripMenuItem.Text = "Quit Game"
        '
        'SaveGameToolStripMenuItem
        '
        Me.SaveGameToolStripMenuItem.Name = "SaveGameToolStripMenuItem"
        Me.SaveGameToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveGameToolStripMenuItem.Text = "Save Game"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitMode
        '
        Me.ExitMode.Location = New System.Drawing.Point(195, 593)
        Me.ExitMode.Name = "ExitMode"
        Me.ExitMode.Size = New System.Drawing.Size(111, 23)
        Me.ExitMode.TabIndex = 22
        Me.ExitMode.Text = "Complete Setup"
        Me.ExitMode.UseVisualStyleBackColor = True
        '
        'RightClick
        '
        Me.RightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackPieceToolStripMenuItem, Me.RedPieceToolStripMenuItem, Me.RemovePiece})
        Me.RightClick.Name = "RightClick"
        Me.RightClick.Size = New System.Drawing.Size(149, 70)
        '
        'BlackPieceToolStripMenuItem
        '
        Me.BlackPieceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackReg, Me.BlackKing})
        Me.BlackPieceToolStripMenuItem.Name = "BlackPieceToolStripMenuItem"
        Me.BlackPieceToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.BlackPieceToolStripMenuItem.Text = "Black Piece"
        '
        'BlackReg
        '
        Me.BlackReg.Name = "BlackReg"
        Me.BlackReg.Size = New System.Drawing.Size(114, 22)
        Me.BlackReg.Text = "Regular"
        '
        'BlackKing
        '
        Me.BlackKing.Name = "BlackKing"
        Me.BlackKing.Size = New System.Drawing.Size(114, 22)
        Me.BlackKing.Text = "King"
        '
        'RedPieceToolStripMenuItem
        '
        Me.RedPieceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedReg, Me.RedKing})
        Me.RedPieceToolStripMenuItem.Name = "RedPieceToolStripMenuItem"
        Me.RedPieceToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.RedPieceToolStripMenuItem.Text = "Red Piece"
        '
        'RedReg
        '
        Me.RedReg.Name = "RedReg"
        Me.RedReg.Size = New System.Drawing.Size(114, 22)
        Me.RedReg.Text = "Regular"
        '
        'RedKing
        '
        Me.RedKing.Name = "RedKing"
        Me.RedKing.Size = New System.Drawing.Size(114, 22)
        Me.RedKing.Text = "King"
        '
        'RemovePiece
        '
        Me.RemovePiece.Name = "RemovePiece"
        Me.RemovePiece.Size = New System.Drawing.Size(148, 22)
        Me.RemovePiece.Text = "Remove Piece"
        '
        'CustomPiece
        '
        Me.CustomPiece.BackColor = System.Drawing.Color.Transparent
        Me.CustomPiece.Image = Global.WindowsApplication1.My.Resources.Resources.BP_shadow_
        Me.CustomPiece.Location = New System.Drawing.Point(123, 570)
        Me.CustomPiece.Name = "CustomPiece"
        Me.CustomPiece.Size = New System.Drawing.Size(53, 50)
        Me.CustomPiece.TabIndex = 23
        Me.CustomPiece.TabStop = False
        '
        'red
        '
        Me.red.Image = Global.WindowsApplication1.My.Resources.Resources.RP_shadow_
        Me.red.Location = New System.Drawing.Point(436, 27)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(53, 50)
        Me.red.TabIndex = 24
        Me.red.TabStop = False
        Me.red.Visible = False
        '
        'black
        '
        Me.black.Image = Global.WindowsApplication1.My.Resources.Resources.BP_shadow_
        Me.black.Location = New System.Drawing.Point(436, 27)
        Me.black.Name = "black"
        Me.black.Size = New System.Drawing.Size(53, 50)
        Me.black.TabIndex = 25
        Me.black.TabStop = False
        Me.black.Visible = False
        '
        'kingred
        '
        Me.kingred.Image = Global.WindowsApplication1.My.Resources.Resources.RP_King__shadow_
        Me.kingred.Location = New System.Drawing.Point(436, 27)
        Me.kingred.Name = "kingred"
        Me.kingred.Size = New System.Drawing.Size(53, 50)
        Me.kingred.TabIndex = 26
        Me.kingred.TabStop = False
        Me.kingred.Visible = False
        '
        'blkking
        '
        Me.blkking.Image = Global.WindowsApplication1.My.Resources.Resources.BP_King__shadow_
        Me.blkking.Location = New System.Drawing.Point(436, 27)
        Me.blkking.Name = "blkking"
        Me.blkking.Size = New System.Drawing.Size(53, 50)
        Me.blkking.TabIndex = 27
        Me.blkking.TabStop = False
        Me.blkking.Visible = False
        '
        'CustomInfo
        '
        Me.CustomInfo.AutoSize = True
        Me.CustomInfo.BackColor = System.Drawing.Color.Transparent
        Me.CustomInfo.Location = New System.Drawing.Point(172, 579)
        Me.CustomInfo.Name = "CustomInfo"
        Me.CustomInfo.Size = New System.Drawing.Size(209, 13)
        Me.CustomInfo.TabIndex = 28
        Me.CustomInfo.Text = "Click On the Left Picture to Change Pieces"
        '
        'ErrorClick
        '
        Me.ErrorClick.BackColor = System.Drawing.Color.Transparent
        Me.ErrorClick.Location = New System.Drawing.Point(48, 135)
        Me.ErrorClick.Name = "ErrorClick"
        Me.ErrorClick.Size = New System.Drawing.Size(406, 409)
        Me.ErrorClick.TabIndex = 29
        Me.ErrorClick.TabStop = False
        '
        'TimerDisp
        '
        Me.TimerDisp.AutoSize = True
        Me.TimerDisp.BackColor = System.Drawing.Color.Transparent
        Me.TimerDisp.Location = New System.Drawing.Point(237, 566)
        Me.TimerDisp.Name = "TimerDisp"
        Me.TimerDisp.Size = New System.Drawing.Size(0, 13)
        Me.TimerDisp.TabIndex = 30
        Me.TimerDisp.Visible = False
        '
        'CustomMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(501, 624)
        Me.ContextMenuStrip = Me.RightClick
        Me.Controls.Add(Me.TimerDisp)
        Me.Controls.Add(Me.ErrorClick)
        Me.Controls.Add(Me.CustomInfo)
        Me.Controls.Add(Me.blkking)
        Me.Controls.Add(Me.kingred)
        Me.Controls.Add(Me.black)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.CustomPiece)
        Me.Controls.Add(Me.ExitMode)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(600, 663)
        Me.MinimumSize = New System.Drawing.Size(517, 39)
        Me.Name = "CustomMode"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.RightClick.ResumeLayout(False)
        CType(Me.CustomPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kingred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blkking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorClick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitMode As System.Windows.Forms.Button
    Friend WithEvents RightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BlackPieceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackReg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackKing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedPieceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedReg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedKing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovePiece As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomPiece As System.Windows.Forms.PictureBox
    Friend WithEvents red As System.Windows.Forms.PictureBox
    Friend WithEvents black As System.Windows.Forms.PictureBox
    Friend WithEvents kingred As System.Windows.Forms.PictureBox
    Friend WithEvents blkking As System.Windows.Forms.PictureBox
    Friend WithEvents CustomInfo As System.Windows.Forms.Label
    Friend WithEvents ErrorClick As System.Windows.Forms.PictureBox
    Friend WithEvents TimerDisp As System.Windows.Forms.Label
    Friend WithEvents SaveGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
