<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.ExitMode = New System.Windows.Forms.Button()
        Me.RightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BlackPieceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackReg = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackKing = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedPieceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedReg = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedKing = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovePiece = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.RightClick.SuspendLayout()
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
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.PauseGame, Me.QuitGameToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardToolStripMenuItem, Me.CustomToolStripMenuItem})
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
        'PauseGame
        '
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.RadioButton1.Location = New System.Drawing.Point(132, 581)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton1.TabIndex = 18
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Black Piece"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.RadioButton2.Location = New System.Drawing.Point(132, 604)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(106, 17)
        Me.RadioButton2.TabIndex = 19
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "King Black Piece"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Red
        Me.RadioButton3.Location = New System.Drawing.Point(281, 581)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton3.TabIndex = 20
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Red Piece"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Red
        Me.RadioButton4.Location = New System.Drawing.Point(281, 604)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton4.TabIndex = 21
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "King Red Piece"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'ExitMode
        '
        Me.ExitMode.Location = New System.Drawing.Point(221, 578)
        Me.ExitMode.Name = "ExitMode"
        Me.ExitMode.Size = New System.Drawing.Size(54, 23)
        Me.ExitMode.TabIndex = 22
        Me.ExitMode.Text = "Done"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(501, 624)
        Me.ContextMenuStrip = Me.RightClick
        Me.Controls.Add(Me.ExitMode)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(517, 663)
        Me.MinimumSize = New System.Drawing.Size(517, 39)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Ultimate Checkers"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.RightClick.ResumeLayout(False)
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
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents ExitMode As System.Windows.Forms.Button
    Friend WithEvents RightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BlackPieceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackReg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackKing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedPieceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedReg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedKing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovePiece As System.Windows.Forms.ToolStripMenuItem

End Class
