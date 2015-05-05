'Léon McGregor
'Updated: 06-10-12
'Name: .TEXT game
'Assess: Visual Basic 2010 express

Public Class Main_Window

    'declare variables
    Dim player_Health As Single
    Dim level As String
    Dim dead As Boolean
    Dim gametime As Single
    Dim enemyHealth As Single
    'make an enemy-fighting pop-up rather than in-game
    Dim swordEquip As Boolean
    Dim level4unlock As Boolean
    Dim level6key As Boolean
    Dim enemyLevel As String

    'load blank paramenters
    Private Sub Main_Window_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        journal.AppendText(vbCrLf & "---------------------")
        swordEquip = False
    End Sub

    'load health timer and health protocols
    Private Sub healthTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles healthTime.Tick
        lblHealth.Text = (player_Health)
        If player_Health > 100 Then
            player_Health = 100
        End If
        If player_Health > 0 Then
            dead = False
        End If
        If player_Health <= 0 Then
            dead = True
            journal.AppendText(vbCrLf & "YOU ARE DEAD")
        End If

        If dead = True Then
            cmdCommand.Enabled = False
            txtCommand.ReadOnly = True
            healthTime.Enabled = False
        End If
    End Sub

    'load game timer and seconds counter
    Private Sub playTime_Tick(sender As System.Object, e As System.EventArgs) Handles playTime.Tick
        gametime = gametime + 1

    End Sub

    'player activates command
    Private Sub cmdCommand_Click(sender As System.Object, e As System.EventArgs) Handles cmdCommand.Click
        Select Case level
            Case Is = "1"
                Select Case txtCommand.Text
                    Case Is = "N"
                        Call north()
                        journal.AppendText(vbCrLf & "The ceiling collapses behind you")
                        Call level2()
                    Case Is = "S", "E", "W"
                        Call blockage()
                    Case Is = "I", "O"
                        Call noobject()
                    Case Else
                        Call donothing()
                End Select
            Case Is = "2"
                Select Case txtCommand.Text
                    Case Is = "N"
                        Call north()
                        Call level3()
                    Case Is = "S", "E", "W"
                        Call blockage()
                    Case Is = "O", "I"
                        Call openchest()
                        Call level2chest()
                    Case Else
                        Call donothing()
                End Select
            Case Is = "3"
                Select Case txtCommand.Text
                    Case Is = "N"
                        Call blockage()
                    Case Is = "S"
                        Call south()
                        Call level2()
                    Case Is = "W"
                        Call west()
                        If level4unlock = False Then
                            Call level4block()
                        Else : Call level4()
                        End If
                    Case Is = "E"
                        Call east()
                        Call level5()
                    Case Is = "O"
                        Call nochest()
                    Case Is = "I"
                        Call pulllever()
                        Call level3lever()
                    Case Else
                        Call donothing()
                End Select
            Case Is = "4"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "E"
                        Call east()
                        Call level3()
                    Case Is = "W"
                        If level6key = False Then
                            Call level6pickup()
                        Else : Call level6()
                        End If
                    Case Is = "O"
                        Call nochest()
                    Case Is = "I"
                        Call level4sword()
                End Select
            Case Is = "5"
                Select Case txtCommand.Text
                    Case Is = "N", "S", "E"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Splash.Image = Nothing
                        Call level3()
                End Select
            Case Is = "6"
                Select Case txtCommand.Text
                    Case Is = "S"
                        Call blockage()
                    Case Is = "E"
                        Call level4()
                    Case Is = "W"
                        Call level22()
                    Case Is = "N"
                        Call level7()
                End Select
            Case Is = "7"
                Select Case txtCommand.Text
                    Case Is = "S"
                        Call level6()
                    Case Is = "N"
                        Call level8()
                    Case Is = "W", "E"
                        Call blockage()
                    Case Is = "I", "O"
                        Call noobject()
                End Select
            Case Is = "8"
                Select Case txtCommand.Text
                    Case Is = "N"
                        Call north()
                        Call level11()
                    Case Is = "E"
                        Call east()
                        Call level9()
                    Case Is = "S"
                        Call south()
                        Call level7()
                    Case Is = "W"
                        Call west()
                        Call level10()
                End Select
            Case Is = "9"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "E"
                        Call east()
                        Call level33()
                    Case Is = "W"
                        Call west()
                        Call level8()
                End Select
            Case Is = "10"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "E"
                        Call east()
                        Call level8()
                    Case Is = "W"
                        Call west()
                        Call level27()
                End Select
            Case Is = "11"
                Select Case txtCommand.Text
                    Case Is = "E", "W"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level12()
                    Case Is = "S"
                        Call south()
                        Call level8()
                End Select
            Case Is = "12"
                Select Case txtCommand.Text
                    Case Is = "W"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level13()
                    Case Is = "S"
                        Call south()
                        Call level11()
                    Case Is = "E"
                        Call east()
                        Call level16()
                End Select
            Case Is = "13"
                Select Case txtCommand.Text
                    Case Is = "N"
                        Call north()
                        Call level14()
                    Case Is = "S"
                        Call south()
                        Call level12()
                    Case Is = "W"
                        Call west()
                        Call level31()
                    Case Is = "E"
                        Call blockage()
                End Select
            Case Is = "14"
                Select Case txtCommand.Text
                    Case Is = "N", "W"
                        Call blockage()
                    Case Is = "E"
                        Call east()
                        Call level15()
                    Case Is = "S"
                        Call south()
                        Call level13()
                End Select
            Case Is = "15"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "E"
                        Call east()
                        Call level18()
                    Case Is = "W"
                        Call west()
                        Call level14()
                End Select
            Case Is = "16"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "E"
                        Call east()
                        Call level17()
                    Case Is = "W"
                        Call west()
                        Call level12()
                End Select
            Case Is = "17"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "W"
                        Call east()
                        Call level16()
                    Case Is = "E"
                        Call west()
                        Call level20()
                End Select
            Case Is = "18"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "W"
                        Call east()
                        Call level15()
                    Case Is = "E"
                        Call west()
                        Call level19()
                End Select
            Case Is = "19"
                Select Case txtCommand.Text
                    Case "N", "E"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Call level18()
                    Case Is = "S"
                        Call south()
                        Call level21()
                End Select
            Case Is = "20"
                Select Case txtCommand.Text
                    Case Is = "E", "S"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level21()
                    Case Is = "W"
                        Call west()
                        Call level17()
                End Select
            Case Is = "21"
                Select Case txtCommand.Text
                    Case Is = "W"
                        Call blockage()
                    Case Is = "S"
                        Call south()
                        Call level20()
                    Case Is = "N"
                        Call north()
                        Call level19()
                    Case Is = "E"
                        Call east()
                        Call level42()
                End Select
            Case Is = "22"
                Select Case txtCommand.Text
                    Case Is = "N", "W"
                        Call blockage()
                    Case Is = "E"
                        Call east()
                        Call level6()
                    Case Is = "S"
                        Call south()
                        Call level23()
                End Select
            Case Is = "23"
                Select Case txtCommand.Text
                    Case Is = "W", "E"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level22()
                    Case Is = "S"
                        Call south()
                        Call level24()
                End Select
            Case Is = "24"
                Select Case txtCommand.Text
                    Case Is = "S"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level23()
                    Case Is = "E"
                        Call east()
                        Call level25()
                    Case Is = "W"
                        Call west()
                        Call level26()
                End Select
            Case Is = "25"
                Select Case txtCommand.Text
                    Case Is = "N", "S", "E"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Call level24()
                End Select
            Case Is = "26"
                Select Case txtCommand.Text
                    Case Is = "N", "W", "S"
                        Call blockage()
                    Case Is = "E"
                        Call east()
                        Call level26()
                End Select
            Case Is = "27"
                Select Case txtCommand.Text
                    Case Is = "S", "W"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level28()
                    Case Is = "E"
                        Call east()
                        Call level10()
                End Select
            Case Is = "28"
                Select Case txtCommand.Text
                    Case Is = "W", "E"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level29()
                    Case Is = "S"
                        Call south()
                        Call level27()
                End Select
            Case Is = "29"
                Select Case txtCommand.Text
                    Case Is = "W", "E"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level30()
                    Case Is = "S"
                        Call south()
                        Call level28()
                End Select
            Case Is = "30"
                Select Case txtCommand.Text
                    Case Is = "W"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level32()
                    Case Is = "S"
                        Call south()
                        Call level29()
                    Case Is = "E"
                        Call east()
                        Call level31()
                End Select
            Case Is = "31"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Call level30()
                    Case Is = "E"
                        Call east()
                        Call level13()
                End Select
            Case Is = "32"
                Select Case txtCommand.Text
                    Case Is = "W", "E", "N"
                        Call blockage()
                    Case Is = "S"
                        Call south()
                        Call level30()
                End Select
            Case Is = "33"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Call level9()
                    Case Is = "E"
                        Call east()
                        Call level34()
                End Select
            Case Is = "34"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Call level33()
                    Case Is = "E"
                        Call east()
                        Call level35()
                End Select
            Case Is = "35"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Call level34()
                    Case Is = "E"
                        Call east()
                        Call level36()
                End Select
            Case Is = "36"
                Select Case txtCommand.Text
                    Case Is = "E"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level37()
                    Case Is = "S"
                        Call south()
                        Call level43()
                    Case Is = "W"
                        Call west()
                        Call level35()
                End Select
            Case Is = "37"
                Select Case txtCommand.Text
                    Case Is = "W", "E"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level38()
                    Case Is = "S"
                        Call south()
                        Call level36()
                End Select
            Case Is = "38"
                Select Case txtCommand.Text
                    Case Is = "W"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level40()
                    Case Is = "S"
                        Call south()
                        Call level37()
                    Case Is = "E"
                        Call east()
                        Call level39()
                End Select
            Case Is = "39"
                Select Case txtCommand.Text
                    Case Is = "N", "E", "S"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Call level38()
                End Select
            Case Is = "40"
                Select Case txtCommand.Text
                    Case Is = "E"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level41()
                    Case Is = "S"
                        Call south()
                        Call level38()
                    Case Is = "W"
                        Call west()
                        Call level42()
                End Select
            Case Is = "41"
                Select Case txtCommand.Text
                    Case Is = "N", "E", "W"
                        Call blockage()
                    Case Is = "S"
                        Call south()
                        Call level40()
                End Select
            Case Is = "42"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Call level21()
                    Case Is = "E"
                        Call east()
                        Call level40()
                End Select
            Case Is = "43"
                Select Case txtCommand.Text
                    Case Is = "W"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level36()
                    Case Is = "S"
                        Call south()
                        Call level44()
                    Case Is = "E"
                        Call east()
                        Call level50()
                End Select
            Case Is = "44"
                Select Case txtCommand.Text
                    Case Is = "W", "E"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level43()
                    Case Is = "S"
                        Call south()
                        Call level45()
                End Select
            Case Is = "45"
                Select Case txtCommand.Text
                    Case Is = "S"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level44()
                    Case Is = "W"
                        Call west()
                        Call level46()
                    Case Is = "E"
                        Call east()
                        Call level48()
                End Select
            Case Is = "46"
                Select Case txtCommand.Text
                    Case Is = "N", "W"
                        Call blockage()
                    Case Is = "E"
                        Call east()
                        Call level45()
                    Case Is = "S"
                        Call south()
                        Call level47()
                End Select
            Case Is = "47"
                Select Case txtCommand.Text
                    Case Is = "W", "S", "E"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level46()
                End Select
            Case Is = "48"
                Select Case txtCommand.Text
                    Case Is = "N", "E"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Call level45()
                    Case Is = "S"
                        Call south()
                        Call level49()
                End Select
            Case Is = "49"
                Select Case txtCommand.Text
                    Case Is = "W", "S", "E"
                        Call blockage()
                    Case Is = "N"
                        Call north()
                        Call level48()
                End Select
            Case Is = "50"
                Select Case txtCommand.Text
                    Case Is = "N", "S"
                        Call blockage()
                    Case Is = "W"
                        Call west()
                        Call level43()
                    Case Is = "E"
                        Call east()
                        Call ending()
                End Select
        End Select

    End Sub

    'reset the game
    Private Sub itemReset_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles itemReset.MouseClick
        journal.Text = "Game Reset" & vbCrLf & "--==--"
        journal.AppendText(vbCrLf & "GAME STARTED" & vbCrLf & "---------------------")
        player_Health = "100"
        lblHealth.Text = player_Health
        cmdCommand.Enabled = True
        txtCommand.ReadOnly = False
        healthTime.Enabled = True
        healthTime.Start()
        playTime.Start()
        Splash.Image = Nothing
        lblSplash.Visible = False
        gametime = 0
        itemClock.Enabled = True
        itemHelp.Enabled = True
        itemNotes.Enabled = True
        itemSplashDock.Enabled = True
        itemSword.Visible = False
        enemyHealth = 100
        enemyLevel = 20
        Call level1()
    End Sub
    'inventory items
    Private Sub itemReset_MouseHover(sender As Object, e As System.EventArgs) Handles itemReset.MouseHover
        itemDesc.Text = itemReset.Tag
    End Sub

    Private Sub itemClock_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles itemClock.MouseClick
        journal.AppendText(vbCrLf & "The Time is: " & gametime)
    End Sub


    Private Sub itemClock_MouseHover(sender As Object, e As System.EventArgs) Handles itemClock.MouseHover
        itemDesc.Text = itemClock.Tag & " " & gametime
    End Sub

    Private Sub itemHelp_hover(sender As System.Object, e As System.EventArgs) Handles itemHelp.MouseHover
        itemDesc.Text = itemHelp.Tag & " " & "Displays a list of commands"
    End Sub

    Private Sub itemHelp_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles itemHelp.MouseClick
        journal.AppendText(vbCrLf & "List of Commands:" & vbCrLf & "N: Go North" & vbCrLf & "S: Go South" & vbCrLf & "O: Open Chest")
        journal.AppendText(vbCrLf & "E: Go East" & vbCrLf & "W: Go West" & vbCrLf & "I: Interact with button/lever")
    End Sub

    Private Sub itemSave_hover(sender As System.Object, e As System.EventArgs) Handles itemSave.MouseHover
        itemDesc.Text = itemSave.Tag
    End Sub

    Private Sub itemSave_Click(sender As System.Object, e As System.EventArgs) Handles itemSave.Click
        My.Settings.level = level
        My.Settings.player_health = player_Health
        My.Settings.gametime = gametime
        My.Settings.swordequip = swordEquip
        My.Settings.level4unlock = level4unlock
        My.Settings.level6key = level6key
        journal.AppendText(vbCrLf & "Game Saved!!!")
    End Sub

    Private Sub itemLoad_hover(sender As System.Object, e As System.EventArgs) Handles itemLoad.MouseHover
        itemDesc.Text = itemLoad.Tag
    End Sub

    Private Sub itemLoad_Click(sender As System.Object, e As System.EventArgs) Handles itemLoad.Click
        lblSplash.Visible = False
        level = My.Settings.level
        player_Health = My.Settings.player_health
        gametime = My.Settings.gametime
        playTime.Start()
        journal.Text = "Game Loaded" & vbCrLf & "--==--"
        lblHealth.Text = player_Health
        cmdCommand.Enabled = True
        txtCommand.ReadOnly = False
        healthTime.Enabled = True
        healthTime.Start()
        Splash.Image = Nothing
        lblSplash.Visible = True
        itemClock.Enabled = True
        itemHelp.Enabled = True
        itemNotes.Enabled = True
        itemSplashDock.Enabled = True
        If My.Settings.swordequip = True Then
            itemSword.Visible = True
        Else : itemSword.Visible = False
        End If
        level4unlock = My.Settings.level4unlock
        level6key = My.Settings.level6key
        If My.Settings.level6key = True Then
            itemKey1.Visible = True
        Else : itemKey1.Visible = False
        End If
    End Sub

    Private Sub itemNotes_Click(sender As System.Object, e As System.EventArgs) Handles itemNotes.Click
        Dim form2 As New Form2
        form2.Show()
    End Sub

    Private Sub itemNotes_MouseHover(sender As Object, e As System.EventArgs) Handles itemNotes.MouseHover
        itemDesc.Text = itemNotes.Tag
    End Sub

    Private Sub itemSplashDock_Click(sender As System.Object, e As System.EventArgs) Handles itemSplashDock.Click
        Dim form3 As New Form3
        If Splash.Visible = True Then
            lblSplash.Visible = True
            Splash.Visible = False
            Form3.Show()
        Else
            lblSplash.Visible = False
            Splash.Visible = True
            Form3.Close()
        End If
    End Sub

    Private Sub itemSplashDock_MouseHover(sender As Object, e As System.EventArgs) Handles itemSplashDock.MouseHover
        itemDesc.Text = itemSplashDock.Tag
    End Sub

    Private Sub itemSword_Click(sender As System.Object, e As System.EventArgs) Handles itemSword.Click
        If enemyLevel = level Then
            enemyHealth = enemyHealth - 5
        End If
    End Sub

    Private Sub itemSword_MouseHover(sender As Object, e As System.EventArgs) Handles itemSword.MouseHover
        itemDesc.Text = itemSword.Tag
    End Sub

    Private Sub itemKey1_Click(sender As System.Object, e As System.EventArgs) Handles itemKey1.Click

    End Sub

    Private Sub itemKey1_MouseHover(sender As Object, e As System.EventArgs) Handles itemKey1.MouseHover

    End Sub

    'level codes
    Private Sub level1()
        level = "1"
        Splash.Image = My.Resources.level1
        journal.AppendText(vbCrLf & "You are at the end of a dark corridor, facing north")
    End Sub

    Private Sub level2()
        level = "2"
        Splash.Image = My.Resources.level2
        journal.AppendText(vbCrLf & "The corridor continues north" & vbCrLf & "There is a chest in front of you")
    End Sub

    Private Sub level2chest()
        journal.AppendText(vbCrLf & "A Spike flies out into your arm")
        player_Health = player_Health - 10
        journal.AppendText(vbCrLf & "The chest closes")
        journal.AppendText(vbCrLf & "You decide to be a bit more careful")
    End Sub

    Private Sub level3()
        Splash.Image = My.Resources.level3
        level = "3"
        journal.AppendText(vbCrLf & "The Corridor splits to the east, and to the west" & vbCrLf & "There is a button on the floor")
    End Sub

    Private Sub level3lever()
        journal.AppendText(vbCrLf & "Out of nowhere, a potion of good health hits you")
        player_Health = player_Health + 5
    End Sub

    Private Sub level4block()
        level = "4"
        swordEquip = True
        journal.AppendText(vbCrLf & "The corrdior is a dead end to the west" & vbCrLf & "You see a sword lying on the floor, on a pressure pad" & vbCrLf & "A wall blocks your path west")
    End Sub

    Private Sub level4sword()
        journal.AppendText(vbCrLf & "You pick up the sword and the pressure pad triggers" & vbCrLf & "the wall in front of you collapses")
        itemSword.Visible = True
        swordEquip = True
    End Sub

    Private Sub level4()
        level = "4.5"
        journal.AppendText(vbCrLf & "The corrdior continues west-east")
    End Sub
    Private Sub level5()
        level = "5"
        journal.AppendText(vbCrLf & "It is a dead end, There is writing on the wall")
        lblSplash.Visible = False
        Splash.Image = My.Resources.level5
        journal.AppendText(vbCrLf & "It reads:")
        journal.AppendText(vbCrLf & "You must get out of here! The monster is loose!")
    End Sub

    Private Sub level6pickup()
        journal.AppendText(vbCrLf & "you see a key on the floor" & vbCrLf & "you pick it up")
        itemKey1.Visible = True
        Call level6()
    End Sub

    Private Sub level6()
        level = "6"
        journal.AppendText(vbCrLf & "The corridor splits North, West and east")
    End Sub
    Private Sub level7()
        level = "7"
        journal.AppendText(vbCrLf & "The corridor heads north and south")
        If enemyHealth > 0 Then
            journal.AppendText(vbCrLf & "You can hear heavy footsteps")
        End If
    End Sub

    Private Sub level8()
        level = "8"
        journal.AppendText(vbCrLf & "The corridor splits N,E,W and S")
    End Sub

    Private Sub level9()
        level = "9"
        journal.AppendText(vbCrLf & "The corridor heads East and West")
    End Sub

    Private Sub level10()
        level = "10"
        journal.AppendText(vbCrLf & "The corridor heads east and west")
    End Sub

    Private Sub level11()
        level = "11"
        journal.AppendText(vbCrLf & "The corridor heads north and south")
    End Sub

    Private Sub level12()
        level = "12"
        journal.AppendText(vbCrLf & "The corridor heads north and south, and splinters east")
    End Sub

    Private Sub level13()
        level = "13"
        journal.AppendText(vbCrLf & "The corridor heads north and south, and splits to the west")
    End Sub

    Private Sub level14()
        level = "14"
        journal.AppendText(vbCrLf & "The corridor corners South and East")
    End Sub

    Private Sub level15()
        level = "15"
        journal.AppendText(vbCrLf & "The corridor heads west and east")
    End Sub

    Private Sub level16()
        level = "16"
        journal.AppendText(vbCrLf & "The corridor passes east and west")
    End Sub

    Private Sub level17()
        level = "17"
        journal.AppendText(vbCrLf & "The corridor continues east and west")
    End Sub

    Private Sub level18()
        level = "18"
        journal.AppendText(vbCrLf & "The corridor makes its way west and east")
    End Sub

    Private Sub level19()
        level = "19"
        journal.AppendText(vbCrLf & "The corridor corners west and south")
    End Sub

    Private Sub level20()
        level = "20"
        journal.AppendText(vbCrLf & "The corridor corners north and west")
        journal.AppendText(vbCrLf & "There is a zombie in front of you!!!")
        My.Settings.enemyhealth = enemyHealth
        My.Settings.enemylevel = enemyLevel
        Dim form4 As New Form4
        form4.Show()
        If enemyHealth >= 0 Then
            form4.TopMost = True
        Else : form4.TopMost = False
        End If
    End Sub

    Private Sub level21()
        level = "21"
        journal.AppendText(vbCrLf & "The corrridor passes north, south and to the east")
    End Sub

    Private Sub level22()
        level = "22"
        journal.AppendText(vbCrLf & "The corridor turns east and south")
    End Sub

    Private Sub level23()
        level = "23"
        journal.AppendText(vbCrLf & "The corridor leads north and south")
    End Sub

    Private Sub level24()
        level = "24"
        journal.AppendText(vbCrLf & "The corridor t-sections to the east, west and north")
    End Sub

    Private Sub level25()
        level = "25"
        journal.AppendText(vbCrLf & "The corridor hits a dead end, leading back west")
    End Sub

    Private Sub level26()
        level = "26"
        journal.AppendText(vbCrLf & "dead end, exit to the east")
    End Sub

    Private Sub level27()
        level = "27"
        journal.AppendText(vbCrLf & "corner of corridor, heading north and east")
    End Sub

    Private Sub level28()
        level = "28"
        journal.AppendText(vbCrLf & "The corridor continues straight north-south")
    End Sub

    Private Sub level29()
        level = "29"
        journal.AppendText(vbCrLf & "The corridor continues north and south")
    End Sub

    Private Sub level30()
        level = "30"
        journal.AppendText(vbCrLf & "The corridor splits 3 ways, to the north, east and south")
    End Sub

    Private Sub level31()
        level = "31"
        journal.AppendText(vbCrLf & "The corridor narrows to a east-west path")
    End Sub

    Private Sub level32()
        level = "32"
        journal.AppendText(vbCrLf & "A dead end. go back to the south")
    End Sub

    Private Sub level33()
        level = "33"
        journal.AppendText(vbCrLf & "The corridor is narrow, to the east and west")
    End Sub

    Private Sub level34()
        level = "34"
        journal.AppendText(vbCrLf & "The corridor is narrow, to the east and west")
    End Sub

    Private Sub level35()
        level = "35"
        journal.AppendText(vbCrLf & "the corridor is narrowe, to the east and west")
    End Sub

    Private Sub level36()
        level = "36"
        journal.AppendText(vbCrLf & "a t-junction to the north, west and south")
    End Sub

    Private Sub level37()
        level = "37"
        journal.AppendText(vbCrLf & "the corridor passes north and south")
    End Sub

    Private Sub level38()
        level = "38"
        journal.AppendText(vbCrLf & "a t-segment, leading north, east and south")
    End Sub

    Private Sub level39()
        level = "39"
        journal.AppendText(vbCrLf & "A dead end, leading back to the west")
    End Sub

    Private Sub level40()
        level = "40"
        journal.AppendText(vbCrLf & "There is a t-junction to the west, norht and south")
    End Sub

    Private Sub level41()
        level = "41"
        journal.AppendText(vbCrLf & "A dead end, leads back south")
    End Sub

    Private Sub level42()
        level = "42"
        journal.AppendText(vbCrLf & "A narrow  path leads west and east")
    End Sub

    Private Sub level43()
        level = "43"
        journal.AppendText(vbCrLf & "The paths heads north-south and splits to the east")
    End Sub

    Private Sub level44()
        level = "44"
        journal.AppendText(vbCrLf & "A path leads north and south")
    End Sub

    Private Sub level45()
        level = "45"
        journal.AppendText(vbCrLf & "A t-section. leading N, E, W")
    End Sub

    Private Sub level46()
        level = "46"
        journal.AppendText(vbCrLf & "The path hits a corner-segment slanting east and south")
    End Sub

    Private Sub level47()
        level = "47"
        journal.AppendText(vbCrLf & "The paths leads to a dead-end, and leads back north ")
    End Sub

    Private Sub level48()
        level = "48"
        journal.AppendText(vbCrLf & "The path turns west and south")
    End Sub

    Private Sub level49()
        level = "49"
        journal.AppendText(vbCrLf & "A dead end, go back north")
    End Sub

    Private Sub level50()
        level = "50"
        journal.AppendText(vbCrLf & "The path leads back west, and east to a door")
    End Sub

    'constant response codes
    Private Sub north()
        journal.AppendText(vbCrLf & "You go north")
    End Sub

    Private Sub east()
        journal.AppendText(vbCrLf & "You go east")
    End Sub

    Private Sub west()
        journal.AppendText(vbCrLf & "You go west")
    End Sub

    Private Sub south()
        journal.AppendText(vbCrLf & "You go south")
    End Sub

    Private Sub openchest()
        journal.AppendText(vbCrLf & "You open the chest")
    End Sub

    Private Sub pushbutton()
        journal.AppendText(vbCrLf & "You push the button")
    End Sub

    Private Sub pulllever()
        journal.AppendText(vbCrLf & "You pull the lever")
    End Sub

    Private Sub donothing()
        journal.AppendText(vbCrLf & "You Do Nothing")
    End Sub

    Private Sub blockage()
        journal.AppendText(vbCrLf & "You Cannot go any further in this direction")
    End Sub

    Private Sub noobject()
        journal.AppendText(vbCrLf & "There is nothing to Interact with")
    End Sub

    Private Sub nochest()
        journal.AppendText(vbCrLf & "There is no chest to open")
    End Sub

    Private Sub ending()
    End Sub

    'C:\Users\Lon\Documents\Visual Studio 2010\Projects\dot text game\LevelImages\map.gif

End Class