<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BattleWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.hitPointsLabel = New System.Windows.Forms.Label()
        Me.levelLabel = New System.Windows.Forms.Label()
        Me.magicPointsLabel = New System.Windows.Forms.Label()
        Me.goldLabel = New System.Windows.Forms.Label()
        Me.expLabel = New System.Windows.Forms.Label()
        Me.itemBox = New System.Windows.Forms.PictureBox()
        Me.spellBox = New System.Windows.Forms.PictureBox()
        Me.runBox = New System.Windows.Forms.PictureBox()
        Me.fightBox = New System.Windows.Forms.PictureBox()
        Me.itemArrowPic = New System.Windows.Forms.PictureBox()
        Me.spellArrowPic = New System.Windows.Forms.PictureBox()
        Me.runArrowPic = New System.Windows.Forms.PictureBox()
        Me.fightArrowPic = New System.Windows.Forms.PictureBox()
        Me.backgroundPicBox = New System.Windows.Forms.PictureBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.blinkerSys = New System.Windows.Forms.Timer(Me.components)
        Me.opHP = New System.Windows.Forms.ProgressBar()
        Me.infoBox = New System.Windows.Forms.RichTextBox()
        CType(Me.itemBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spellBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.runBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fightBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemArrowPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spellArrowPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.runArrowPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fightArrowPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backgroundPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hitPointsLabel
        '
        Me.hitPointsLabel.BackColor = System.Drawing.Color.Black
        Me.hitPointsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hitPointsLabel.ForeColor = System.Drawing.Color.White
        Me.hitPointsLabel.Location = New System.Drawing.Point(82, 133)
        Me.hitPointsLabel.Name = "hitPointsLabel"
        Me.hitPointsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hitPointsLabel.Size = New System.Drawing.Size(84, 33)
        Me.hitPointsLabel.TabIndex = 2
        Me.hitPointsLabel.Text = "20"
        '
        'levelLabel
        '
        Me.levelLabel.BackColor = System.Drawing.Color.Black
        Me.levelLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levelLabel.ForeColor = System.Drawing.Color.White
        Me.levelLabel.Location = New System.Drawing.Point(82, 93)
        Me.levelLabel.Name = "levelLabel"
        Me.levelLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.levelLabel.Size = New System.Drawing.Size(84, 33)
        Me.levelLabel.TabIndex = 3
        Me.levelLabel.Text = "1"
        '
        'magicPointsLabel
        '
        Me.magicPointsLabel.BackColor = System.Drawing.Color.Black
        Me.magicPointsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.magicPointsLabel.ForeColor = System.Drawing.Color.White
        Me.magicPointsLabel.Location = New System.Drawing.Point(82, 173)
        Me.magicPointsLabel.Name = "magicPointsLabel"
        Me.magicPointsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.magicPointsLabel.Size = New System.Drawing.Size(84, 33)
        Me.magicPointsLabel.TabIndex = 4
        Me.magicPointsLabel.Text = "10"
        '
        'goldLabel
        '
        Me.goldLabel.BackColor = System.Drawing.Color.Black
        Me.goldLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goldLabel.ForeColor = System.Drawing.Color.White
        Me.goldLabel.Location = New System.Drawing.Point(82, 214)
        Me.goldLabel.Name = "goldLabel"
        Me.goldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.goldLabel.Size = New System.Drawing.Size(84, 33)
        Me.goldLabel.TabIndex = 5
        Me.goldLabel.Text = "0"
        '
        'expLabel
        '
        Me.expLabel.BackColor = System.Drawing.Color.Black
        Me.expLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expLabel.ForeColor = System.Drawing.Color.White
        Me.expLabel.Location = New System.Drawing.Point(82, 253)
        Me.expLabel.Name = "expLabel"
        Me.expLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.expLabel.Size = New System.Drawing.Size(84, 33)
        Me.expLabel.TabIndex = 6
        Me.expLabel.Text = "0"
        '
        'itemBox
        '
        Me.itemBox.Image = Global.Battle_Window.My.Resources.Resources.item
        Me.itemBox.Location = New System.Drawing.Point(414, 96)
        Me.itemBox.Name = "itemBox"
        Me.itemBox.Size = New System.Drawing.Size(85, 26)
        Me.itemBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.itemBox.TabIndex = 18
        Me.itemBox.TabStop = False
        '
        'spellBox
        '
        Me.spellBox.Image = Global.Battle_Window.My.Resources.Resources.spell
        Me.spellBox.Location = New System.Drawing.Point(414, 56)
        Me.spellBox.Name = "spellBox"
        Me.spellBox.Size = New System.Drawing.Size(105, 27)
        Me.spellBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spellBox.TabIndex = 17
        Me.spellBox.TabStop = False
        '
        'runBox
        '
        Me.runBox.Image = Global.Battle_Window.My.Resources.Resources.run
        Me.runBox.Location = New System.Drawing.Point(254, 96)
        Me.runBox.Name = "runBox"
        Me.runBox.Size = New System.Drawing.Size(65, 25)
        Me.runBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.runBox.TabIndex = 16
        Me.runBox.TabStop = False
        '
        'fightBox
        '
        Me.fightBox.Image = Global.Battle_Window.My.Resources.Resources.fight
        Me.fightBox.Location = New System.Drawing.Point(254, 56)
        Me.fightBox.Name = "fightBox"
        Me.fightBox.Size = New System.Drawing.Size(106, 28)
        Me.fightBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fightBox.TabIndex = 15
        Me.fightBox.TabStop = False
        '
        'itemArrowPic
        '
        Me.itemArrowPic.Image = Global.Battle_Window.My.Resources.Resources.arrow
        Me.itemArrowPic.Location = New System.Drawing.Point(399, 98)
        Me.itemArrowPic.Name = "itemArrowPic"
        Me.itemArrowPic.Size = New System.Drawing.Size(12, 22)
        Me.itemArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.itemArrowPic.TabIndex = 14
        Me.itemArrowPic.TabStop = False
        Me.itemArrowPic.Visible = False
        '
        'spellArrowPic
        '
        Me.spellArrowPic.Image = Global.Battle_Window.My.Resources.Resources.arrow
        Me.spellArrowPic.Location = New System.Drawing.Point(399, 58)
        Me.spellArrowPic.Name = "spellArrowPic"
        Me.spellArrowPic.Size = New System.Drawing.Size(12, 22)
        Me.spellArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spellArrowPic.TabIndex = 13
        Me.spellArrowPic.TabStop = False
        Me.spellArrowPic.Visible = False
        '
        'runArrowPic
        '
        Me.runArrowPic.Image = Global.Battle_Window.My.Resources.Resources.arrow
        Me.runArrowPic.Location = New System.Drawing.Point(239, 98)
        Me.runArrowPic.Name = "runArrowPic"
        Me.runArrowPic.Size = New System.Drawing.Size(12, 22)
        Me.runArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.runArrowPic.TabIndex = 12
        Me.runArrowPic.TabStop = False
        Me.runArrowPic.Visible = False
        '
        'fightArrowPic
        '
        Me.fightArrowPic.Image = Global.Battle_Window.My.Resources.Resources.arrow
        Me.fightArrowPic.Location = New System.Drawing.Point(239, 59)
        Me.fightArrowPic.Name = "fightArrowPic"
        Me.fightArrowPic.Size = New System.Drawing.Size(12, 22)
        Me.fightArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fightArrowPic.TabIndex = 11
        Me.fightArrowPic.TabStop = False
        Me.fightArrowPic.Visible = False
        '
        'backgroundPicBox
        '
        Me.backgroundPicBox.Image = Global.Battle_Window.My.Resources.Resources.gamescreen1
        Me.backgroundPicBox.Location = New System.Drawing.Point(0, -1)
        Me.backgroundPicBox.Name = "backgroundPicBox"
        Me.backgroundPicBox.Size = New System.Drawing.Size(615, 559)
        Me.backgroundPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.backgroundPicBox.TabIndex = 0
        Me.backgroundPicBox.TabStop = False
        '
        'nameLabel
        '
        Me.nameLabel.BackColor = System.Drawing.Color.Black
        Me.nameLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.Color.White
        Me.nameLabel.Location = New System.Drawing.Point(45, 60)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nameLabel.Size = New System.Drawing.Size(108, 33)
        Me.nameLabel.TabIndex = 19
        Me.nameLabel.Text = "Hero"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'blinkerSys
        '
        Me.blinkerSys.Enabled = True
        Me.blinkerSys.Interval = 320
        '
        'opHP
        '
        Me.opHP.Location = New System.Drawing.Point(260, 235)
        Me.opHP.Name = "opHP"
        Me.opHP.Size = New System.Drawing.Size(100, 12)
        Me.opHP.TabIndex = 20
        '
        'infoBox
        '
        Me.infoBox.BackColor = System.Drawing.SystemColors.WindowText
        Me.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.infoBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.infoBox.Font = New System.Drawing.Font("Monocraft", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoBox.ForeColor = System.Drawing.SystemColors.Window
        Me.infoBox.Location = New System.Drawing.Point(65, 346)
        Me.infoBox.Name = "infoBox"
        Me.infoBox.Size = New System.Drawing.Size(463, 186)
        Me.infoBox.TabIndex = 21
        Me.infoBox.Text = "RAAAAAH"
        '
        'BattleWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 559)
        Me.Controls.Add(Me.infoBox)
        Me.Controls.Add(Me.opHP)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.itemBox)
        Me.Controls.Add(Me.spellBox)
        Me.Controls.Add(Me.runBox)
        Me.Controls.Add(Me.fightBox)
        Me.Controls.Add(Me.itemArrowPic)
        Me.Controls.Add(Me.spellArrowPic)
        Me.Controls.Add(Me.runArrowPic)
        Me.Controls.Add(Me.fightArrowPic)
        Me.Controls.Add(Me.expLabel)
        Me.Controls.Add(Me.goldLabel)
        Me.Controls.Add(Me.magicPointsLabel)
        Me.Controls.Add(Me.levelLabel)
        Me.Controls.Add(Me.hitPointsLabel)
        Me.Controls.Add(Me.backgroundPicBox)
        Me.Name = "BattleWindow"
        Me.Text = "Battle Window"
        CType(Me.itemBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spellBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.runBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fightBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemArrowPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spellArrowPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.runArrowPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fightArrowPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backgroundPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backgroundPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents hitPointsLabel As System.Windows.Forms.Label
    Friend WithEvents levelLabel As System.Windows.Forms.Label
    Friend WithEvents magicPointsLabel As System.Windows.Forms.Label
    Friend WithEvents goldLabel As System.Windows.Forms.Label
    Friend WithEvents expLabel As System.Windows.Forms.Label
    Friend WithEvents fightArrowPic As System.Windows.Forms.PictureBox
    Friend WithEvents runArrowPic As System.Windows.Forms.PictureBox
    Friend WithEvents spellArrowPic As System.Windows.Forms.PictureBox
    Friend WithEvents itemArrowPic As System.Windows.Forms.PictureBox
    Friend WithEvents fightBox As System.Windows.Forms.PictureBox
    Friend WithEvents runBox As System.Windows.Forms.PictureBox
    Friend WithEvents spellBox As System.Windows.Forms.PictureBox
    Friend WithEvents itemBox As System.Windows.Forms.PictureBox
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents blinkerSys As Timer
    Friend WithEvents opHP As ProgressBar
    Friend WithEvents infoBox As RichTextBox
End Class
