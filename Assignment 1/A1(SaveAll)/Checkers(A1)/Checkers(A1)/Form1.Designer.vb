﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Play
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
        Me.blackking = New System.Windows.Forms.PictureBox()
        Me.black = New System.Windows.Forms.PictureBox()
        Me.red = New System.Windows.Forms.PictureBox()
        Me.kingred = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentPiece = New System.Windows.Forms.PictureBox()
        Me.CurrentInfo = New System.Windows.Forms.Label()
        CType(Me.blackking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kingred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'blackking
        '
        Me.blackking.Image = Global.WindowsApplication1.My.Resources.Resources.BP_King__shadow_
        Me.blackking.Location = New System.Drawing.Point(12, 41)
        Me.blackking.Name = "blackking"
        Me.blackking.Size = New System.Drawing.Size(100, 50)
        Me.blackking.TabIndex = 0
        Me.blackking.TabStop = False
        Me.blackking.Visible = False
        '
        'black
        '
        Me.black.Image = Global.WindowsApplication1.My.Resources.Resources.BP_shadow_
        Me.black.Location = New System.Drawing.Point(141, 41)
        Me.black.Name = "black"
        Me.black.Size = New System.Drawing.Size(100, 50)
        Me.black.TabIndex = 1
        Me.black.TabStop = False
        Me.black.Visible = False
        '
        'red
        '
        Me.red.Image = Global.WindowsApplication1.My.Resources.Resources.RP_shadow_
        Me.red.Location = New System.Drawing.Point(270, 41)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(100, 50)
        Me.red.TabIndex = 2
        Me.red.TabStop = False
        Me.red.Visible = False
        '
        'kingred
        '
        Me.kingred.Image = Global.WindowsApplication1.My.Resources.Resources.RP_King__shadow_
        Me.kingred.Location = New System.Drawing.Point(400, 41)
        Me.kingred.Name = "kingred"
        Me.kingred.Size = New System.Drawing.Size(100, 50)
        Me.kingred.TabIndex = 3
        Me.kingred.TabStop = False
        Me.kingred.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(397, 590)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'CurrentPiece
        '
        Me.CurrentPiece.BackColor = System.Drawing.Color.Transparent
        Me.CurrentPiece.Location = New System.Drawing.Point(141, 573)
        Me.CurrentPiece.Name = "CurrentPiece"
        Me.CurrentPiece.Size = New System.Drawing.Size(50, 50)
        Me.CurrentPiece.TabIndex = 5
        Me.CurrentPiece.TabStop = False
        '
        'CurrentInfo
        '
        Me.CurrentInfo.AutoSize = True
        Me.CurrentInfo.BackColor = System.Drawing.Color.Transparent
        Me.CurrentInfo.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentInfo.Location = New System.Drawing.Point(202, 573)
        Me.CurrentInfo.Name = "CurrentInfo"
        Me.CurrentInfo.Size = New System.Drawing.Size(0, 18)
        Me.CurrentInfo.TabIndex = 6
        '
        'Play
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LayoutBlueM
        Me.ClientSize = New System.Drawing.Size(501, 624)
        Me.Controls.Add(Me.CurrentInfo)
        Me.Controls.Add(Me.CurrentPiece)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.kingred)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.black)
        Me.Controls.Add(Me.blackking)
        Me.Name = "Play"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Checkers!"
        CType(Me.blackking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kingred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentPiece, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents blackking As System.Windows.Forms.PictureBox
    Friend WithEvents black As System.Windows.Forms.PictureBox
    Friend WithEvents red As System.Windows.Forms.PictureBox
    Friend WithEvents kingred As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CurrentPiece As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentInfo As System.Windows.Forms.Label
End Class
