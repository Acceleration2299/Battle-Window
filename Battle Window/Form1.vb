Public Class BattleWindow
	Dim blinkerActive As Boolean = False
	Dim boxSel As Byte = 0
	Const heroMaxHealth As Integer = 20
	Const enemyMaxHealth As Integer = 12
	Dim enemyHealth As Integer = 12
	Dim lastDamageCalc As Integer

	Public Function GetRandom(minV As Integer, maxV As Integer) ' This just cleans up the code
		Return CInt(Math.Floor(Rnd() * maxV) + minV)
	End Function
	Public Function atkFunc()
		If enemyHealth = 0 Then
			infoBox.Text = "The opponent is already defeated!!"
		Else
			If GetRandom(1, 5) = 5 Then 'Check to see if my hit landed, Rolling 5 means i missed.
				If GetRandom(1, 5) = 5 Then 'I missed. Check to see if my enemies retaliation hit landed, Rolling 5 means it missed.
					lastDamageCalc = GetRandom(2, 4)
					hitPointsLabel.Text = CInt(hitPointsLabel.Text) - lastDamageCalc 'This is the player damage calculation step for the function
					infoBox.Text = "You missed. The opponent hit you for " + CStr(lastDamageCalc) + " Hitpoints"
				Else 'Enemy Missed
					infoBox.Text = "You missed. Your opponents retaliatory strike also missed."
				End If
			Else 'My hit landed.
				lastDamageCalc = GetRandom(3, 5)
				enemyHealth = enemyHealth - lastDamageCalc
				infoBox.Text = "You struck your opponent for " + CStr(lastDamageCalc) + " Hitpoints"
				If GetRandom(1, 5) = 5 Then
					lastDamageCalc = GetRandom(2, 4)
					hitPointsLabel.Text = hitPointsLabel.Text - CStr(lastDamageCalc)

				Else

				End If
			End If
			If enemyHealth >= 0 Then
				opHP.Value = enemyHealth
			Else
				opHP.Value = 0
			End If
		End If

	End Function
	Public Function blinkerTrigger(xval As Byte, yval As Boolean)
		Select Case xval
			Case 1
				If blinkerActive And yval = True Then
					fightArrowPic.Visible = True
				Else
					fightArrowPic.Visible = False
				End If
			Case 2
				If blinkerActive And yval = True Then
					spellArrowPic.Visible = True
				Else
					spellArrowPic.Visible = False
				End If
			Case 3
				If blinkerActive And yval = True Then
					runArrowPic.Visible = True
				Else
					runArrowPic.Visible = False
				End If
			Case 4
				If blinkerActive And yval = True Then
					itemArrowPic.Visible = True
				Else
					itemArrowPic.Visible = False
				End If
		End Select

	End Function


	' ---- Subs to show which menu option is targetted with the mouse ----
	Private Sub fightBox_MouseEnter(sender As Object, e As EventArgs) Handles fightBox.MouseEnter
		fightArrowPic.Visible = True
		boxSel = 1
	End Sub
	Private Sub fightBox_MouseLeave(sender As Object, e As EventArgs) Handles fightBox.MouseLeave
		fightArrowPic.Visible = False
		boxSel = 0
	End Sub
	Private Sub spellBox_MouseEnter(sender As Object, e As EventArgs) Handles spellBox.MouseEnter
		spellArrowPic.Visible = True
		boxSel = 2
	End Sub
	Private Sub spellBox_MouseLeave(sender As Object, e As EventArgs) Handles spellBox.MouseLeave
		spellArrowPic.Visible = False
		boxSel = 0
	End Sub
	Private Sub runBox_MouseEnter(sender As Object, e As EventArgs) Handles runBox.MouseEnter
		runArrowPic.Visible = True

		boxSel = 3
	End Sub
	Private Sub runBox_MouseLeave(sender As Object, e As EventArgs) Handles runBox.MouseLeave
		runArrowPic.Visible = False
		boxSel = 0
	End Sub
	Private Sub itemBox_MouseEnter(sender As Object, e As EventArgs) Handles itemBox.MouseEnter
		itemArrowPic.Visible = True

		boxSel = 4
	End Sub
	Private Sub itemBox_MouseLeave(sender As Object, e As EventArgs) Handles itemBox.MouseLeave
		itemArrowPic.Visible = False
		boxSel = 0
	End Sub
	' ---- End of Selection Arrow Subs ----

	Private Sub BattleWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		blinkerSys.Enabled = False
		nameLabel.Text = InputBox("What is thine hero's name?  (4 letters max)", "Hero Name")
		hitPointsLabel.Text = heroMaxHealth
		enemyHealth = enemyMaxHealth
		Randomize()
		blinkerSys.Enabled = True
		opHP.Maximum = enemyMaxHealth
		opHP.Value = enemyHealth


	End Sub

	Public Sub blinkerSys_Tick(sender As Object, e As EventArgs) Handles blinkerSys.Tick ''WHY DOES THIS WORK AS A BETTER LOOP SYSTEM THEN WHILE COMMANDS??!
		If blinkerActive = True Then
			blinkerActive = False
		Else
			blinkerActive = True
		End If
		blinkerTrigger(boxSel, blinkerActive)
	End Sub

	Private Sub fightBox_Click(sender As Object, e As EventArgs) Handles fightBox.Click
		atkFunc()
	End Sub

End Class
