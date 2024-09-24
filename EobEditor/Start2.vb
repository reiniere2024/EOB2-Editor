Imports System.IO

Public Class Start2
    Public StartX As Integer = 300
    Public StartY As Integer = 30
    Public PicWidth As Integer = 20
    Public WinHeight As Integer = 720
    Public WinWidth As Integer = 1000
    Public LocLevel As Integer = 2091
    Public LocPosition As Integer = 2095
    Public LocPosition2 As Integer = 2096
    Public EmptyImage As String = "picts\empty.jpg"
    Public RoadImage As String = "picts\road.jpg"
    Public StartImage As String = "picts\start.jpg"
    Public StairsImage As String = "picts\stairs.jpg"
    Public CurrentImage As String = "picts\current.jpg"
    Public NewImage As String = "picts\new.jpg"

    Public CurrentPosition As Integer = 0
    Public CurrentPosX As Integer = 0
    Public CurrentPosY As Integer = 0

    Public CurrentTag As Integer = 0
    Public CurrentClicked As Integer = 0
    Public CurrentClickedX As Integer = 0
    Public CurrentClickedY As Integer = 0

    Public CurrentClickedTag As Integer = 0
    Public CurSavegameSelected As Integer = 0

    Public CurrentSaveGame As Integer = 0
    Public CurrentSaveGameName As String = "EOBDATA0.SAV"
    Public GameFolder As String = ""

    Public LevelSelectedMap As Integer = -1
    Public LevelSavegameMap As Integer = -1

    Public MyPictures(32, 32) As PictureBox
    Public MyFields(32, 32) As Integer
    Public ds As New DataSet


    Private Sub Start2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Width = WinWidth
        Me.Height = WinHeight
        Me.Location = New Point(0, 0)

        'Read Game Settings in EOB.XML
        ds.ReadXml(CurDir() + "\xml\eob2.xml")
        GameFolder = ds.Tables(0).Rows(0).Item(0)
        TextBox1.Text = GameFolder

        Me.CreateControls()

    End Sub

    Public Sub FillMaps(ByVal mapnr As Integer)

        Select Case mapnr
            Case 1
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields1(x, y)
                    Next
                Next

            Case 2
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields2(x, y)
                    Next
                Next
            Case 3
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields3(x, y)
                    Next
                Next
            Case 4
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields4(x, y)
                    Next
                Next

            Case 5
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields5(x, y)
                    Next
                Next
            Case 6
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields6(x, y)
                    Next
                Next
            Case 7
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields7(x, y)
                    Next
                Next
            Case 8
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields8(x, y)
                    Next
                Next
            Case 9
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields9(x, y)
                    Next
                Next
            Case 10
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields10(x, y)
                    Next
                Next
            Case 11
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields11(x, y)
                    Next
                Next
            Case 12
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields12(x, y)
                    Next
                Next
            Case 13
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields13(x, y)
                    Next
                Next
            Case 14
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields14(x, y)
                    Next
                Next
            Case 15
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields15(x, y)
                    Next
                Next
            Case 16
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields16(x, y)
                    Next
                Next
            Case 17
                For x = 0 To 31
                    For y = 0 To 31
                        MyFields(y, x) = MyFields17(x, y)
                    Next
                Next


        End Select


    End Sub

    Public Sub InitializeFields()

        For x = 0 To 31
            For y = 0 To 31
                MyPictures(x, y).Image = Image.FromFile(EmptyImage)
            Next
        Next

        For x = 0 To 31
            For y = 0 To 31
                If MyFields(x, y) <> 0 Then
                    Me.AddImage(x, y, MyFields(x, y))
                End If
            Next
        Next

    End Sub

    Public Sub AddImage(ByVal pictx As Integer, ByVal picty As Integer, ByVal pictnum As Integer)

        Select Case pictnum

            Case 0
                MyPictures(pictx, picty).Image = Image.FromFile(EmptyImage)
                MyPictures(pictx, picty).Tag = "0"

            Case 1
                MyPictures(pictx, picty).Image = Image.FromFile(RoadImage)
                MyPictures(pictx, picty).Tag = "1"

            Case 2
                MyPictures(pictx, picty).Image = Image.FromFile(StartImage)
                MyPictures(pictx, picty).Tag = "2"

            Case 5
                MyPictures(pictx, picty).Image = Image.FromFile(StairsImage)
                MyPictures(pictx, picty).Tag = "5"

        End Select

        'MyPictures(pict).Image = Image.FromFile("picts\road01.jpg")

    End Sub


    Public Sub CreateControls()
        Dim l As Point

        l.X = StartX
        l.Y = StartY


        For x = 0 To 31
            For y = 0 To 31
                l.X = l.X + PicWidth

                Dim myTB As PictureBox
                Me.MyPictures(x, y) = New PictureBox
                myTB = MyPictures(x, y)
                myTB.Image = Image.FromFile(EmptyImage)
                myTB.Tag = "0"
                myTB.Width = PicWidth
                myTB.Height = PicWidth
                myTB.Location = l
                myTB.Name = "PB" + x.ToString + "-" + y.ToString() ' <- important for later accessing
                'myTB.SizeMode = PictureBoxSizeMode.StretchImage
                Me.Controls.Add(myTB)
                AddHandler MyPictures(x, y).Click, AddressOf Me.ClickButton
            Next
            l.Y = l.Y + PicWidth
            l.X = StartX
        Next

    End Sub

    Private Sub ClickButton(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim str, str1, str2 As String
        Dim ind, ind1, ind2 As Integer
        Dim btn As PictureBox
        btn = CType(sender, PictureBox)

        str = btn.Name
        str1 = str.Substring(2, 1)
        If str.Substring(3, 1) = "-" Then
            ind1 = CInt(str1)
            str2 = str.Substring(4, 1)
            If str.Length() = 5 Then
                ind2 = CInt(str2)
            Else
                str2 = str2 + str.Substring(5, 1)
                ind2 = CInt(str2)
            End If
        Else
            str1 = str1 + str.Substring(3, 1)
            ind1 = CInt(str1)
            str2 = str.Substring(5, 1)
            If str.Length() = 6 Then
                ind2 = CInt(str2)
            Else
                str2 = str2 + str.Substring(6, 1)
                ind2 = CInt(str2)
            End If
        End If

        ind = (ind2 * 32) + ind1

        If CurrentClicked > 0 Then
            Me.AddImage(CurrentClickedX, CurrentClickedY, CurrentClickedTag)
        End If
        CurrentClicked = ind
        CurrentClickedX = ind1
        CurrentClickedY = ind2
        CurrentClickedTag = MyPictures(CurrentClickedX, CurrentClickedY).Tag
        MyPictures(CurrentClickedX, CurrentClickedY).Image = Image.FromFile(NewImage)
        t_position2.Text = CurrentClicked.ToString()


        'MsgBox("you clicked button: " + str)


    End Sub

    Private Sub LoadSaveGame()

        If CurrentSaveGame = 0 Then
            MsgBox("No savegame selected. Please select a savegame first !!!")
            Return

        End If

        Dim FilName As String
        Dim sItem, sFile, sItemHex, sItemTwo, myname As String
        Dim CurPosition As Integer

        FilName = TextBox1.Text
        FilName = FilName + "\" + CurrentSaveGameName

        'Level of the SaveGame
        sItem = Me.ReadFileChar(FilName, LocLevel)
        If sItem = "" Then Return

        t_level.Text = sItem
        t_lvlname.Text = GetLevel(sItem)

        'Position in the SaveGame
        sItem = Me.ReadFileChar(FilName, LocPosition)
        If sItem = "" Then Return

        sItemHex = Hex(sItem)
        If sItemHex.Length < 2 Then
            sItemHex = "0" + sItemHex
        End If
        t_hex.Text = sItemHex

        'Position Byte 2 in the SaveGame
        sItemTwo = Me.ReadFileChar(FilName, LocPosition2)
        If sItemTwo = "" Then Return

        t_hex2.Text = sItemTwo

        CurPosition = Me.CalculatePosition(sItemHex, sItemTwo)
        If CurrentPosition > 0 Then
            'MyPictures(CurrentPosition).Image = Image.FromFile(RoadImage)
            MyPictures(CurrentPosX, CurrentPosY).Image = Image.FromFile(RoadImage)
        End If
        CurrentPosY = CurPosition / 32
        CurrentPosX = (CurPosition Mod 32)
        'MyPictures(CurPosition).Image = Image.FromFile(CurrentImage)
        MyPictures(CurrentPosX, CurrentPosY).Image = Image.FromFile(CurrentImage)
        CurrentPosition = CurPosition

        'Name of the SaveGame
        myname = Me.ReadFileName(FilName)
        If myname = "" Then
            Return
        Else
            t_name.Text = myname
        End If

    End Sub

    Private Sub Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Load.Click

        Me.LoadSaveGame()

    End Sub

    Private Function GetLevel(ByVal level As String) As String
        Dim mylevel As String

        Select Case level

            Case 1
                mylevel = "Catacomb Level 1"
                LevelSavegameMap = 1
            Case 2
                mylevel = "Catacomb Level 2"
                LevelSavegameMap = 2
            Case 3
                mylevel = "Catacomb Level 3"
                LevelSavegameMap = 3

            Case "4"
                mylevel = "Wood Level"
                LevelSavegameMap = 0

            Case "5"
                mylevel = "Temple Level 1"
                LevelSavegameMap = 5
            Case "6"
                mylevel = "Temple Level 2"
                LevelSavegameMap = 6
            Case "7"
                mylevel = "Silver Tower Level 1"
                LevelSavegameMap = 7
            Case "8"
                mylevel = "Silver Tower Level 2"
                LevelSavegameMap = 8
            Case "9"
                mylevel = "Silver Tower Level 3"
                LevelSavegameMap = 9
            Case "10"
                mylevel = "Azure Tower Level 1"
                LevelSavegameMap = 10
            Case "11"
                mylevel = "Azure Tower Level 2"
                LevelSavegameMap = 11
            Case "12"
                mylevel = "Azure Tower Level 3"
                LevelSavegameMap = 12
            Case "13"
                mylevel = "Azure Tower Level 4"
                LevelSavegameMap = 13
            Case "14"
                mylevel = "Frost Giants Level"
                LevelSavegameMap = 14
            Case "15"
                mylevel = "Crimson Tower Level 1"
                LevelSavegameMap = 15
            Case "16"
                mylevel = "Crimson Tower Level 2"
                LevelSavegameMap = 16

        End Select

        Return mylevel


    End Function

    Private Function ReadFileName(ByVal filnam As String) As String
        Dim name, sItem As String
        Dim endofname As Boolean = False
        Dim pos As Integer
        Dim ch As Char

        Try
            Dim FS As New FileStream(filnam, FileMode.Open, FileAccess.Read)
            Dim SR As New BinaryReader(FS)

            Do While endofname = False
                sItem = SR.ReadByte()
                If CInt(sItem) = 0 Then
                    'MsgBox(pos)
                    'MsgBox(name)
                    endofname = True
                Else
                    name = name + Chr(sItem)
                End If
                pos += 1
            Loop

            SR.Close()
            FS.Close()

            Return name

        Catch ex As Exception

            MsgBox("Savegame " + CurrentSaveGameName + " not found. Please generate a savegame in EOB2 !!!")
            Return ""

        End Try




    End Function

    Private Function ReadFileChar(ByVal filnam As String, ByVal location As Integer) As String
        Dim pos As Integer = 0
        Dim sItem, sFile As String

        Try

            Dim FS As New FileStream(filnam, FileMode.Open, FileAccess.Read)
            Dim SR As New BinaryReader(FS)

            Do While pos < location
                sItem = SR.ReadByte()
                pos += 1
            Loop


            SR.Close()
            FS.Close()

            Return sItem

        Catch ex As Exception

            MsgBox("Savegame " + CurrentSaveGameName + " not found. Please generate a savegame in EOB2 !!!")
            Return ""

        End Try



    End Function


    Private Function CalculatePosition(ByVal str As String, ByVal row As String) As Integer
        Dim sItem, sItemHex As String
        Dim char1, char2 As Char
        Dim pos1, pos2, pos As Integer

        char1 = str.Substring(0, 1)
        char2 = str.Substring(1, 1)

        pos1 = hextodigit(char1)
        pos2 = hextodigit(char2)
        pos = ((pos1 * 16) + pos2)
        Select Case row
            Case 1
                pos = pos + 256
                pos1 = pos1 + 8
            Case 2
                pos = pos + 512
                pos1 = pos1 + 16
            Case 3
                pos = pos + 768
                pos1 = pos1 + 24
        End Select

        t_position.Text = pos.ToString()
        t_pos1.Text = pos1.ToString()
        t_pos2.Text = pos2.ToString()

        Return pos


    End Function

    Private Function hextodigit(ByVal mychar As Char) As Integer
        Dim mypos As Integer

        Select Case mychar

            Case "0"
                mypos = 0
            Case "1"
                mypos = 1
            Case "2"
                mypos = 2
            Case "3"
                mypos = 3
            Case "4"
                mypos = 4
            Case "5"
                mypos = 5
            Case "6"
                mypos = 6
            Case "7"
                mypos = 7
            Case "8"
                mypos = 8
            Case "9"
                mypos = 9
            Case "A"
                mypos = 10
            Case "B"
                mypos = 11
            Case "C"
                mypos = 12
            Case "D"
                mypos = 13
            Case "E"
                mypos = 14
            Case "F"
                mypos = 15
        End Select

        Return mypos

    End Function

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_level.SelectedIndexChanged
        Dim i As Integer
        Dim str As String

        str = c_level.Text

        Select Case str
            Case "00  - Wood"
                Me.FillMaps(1)
                Me.InitializeFields()
                LevelSelectedMap = 0
                t_level2.Text = "0"
                t_lvlname2.Text = "Wood Level"
            Case "01 - Catacombs 1"
                Me.FillMaps(2)
                Me.InitializeFields()
                LevelSelectedMap = 1
                t_lvlname2.Text = "Catacomb Level 1"
            Case "02 - Catacombs 2"
                Me.FillMaps(3)
                Me.InitializeFields()
                LevelSelectedMap = 2
                t_lvlname2.Text = "Catacomb Level 2"
            Case "03 - Catacombs 3"
                Me.FillMaps(4)
                Me.InitializeFields()
                LevelSelectedMap = 3
                t_lvlname2.Text = "Catacomb Level 3"
            Case "04 - Catacombs 4"
                Me.FillMaps(5)
                Me.InitializeFields()
                LevelSelectedMap = 4
                t_lvlname2.Text = "Catacomb Level 4"
            Case "05 - Temple 1"
                Me.FillMaps(6)
                Me.InitializeFields()
                LevelSelectedMap = 5
                t_lvlname2.Text = "Temple Level 1"
            Case "06 - Temple 2"
                Me.FillMaps(7)
                Me.InitializeFields()
                LevelSelectedMap = 6
                t_lvlname2.Text = "Temple Level 2"
            Case "07 - Silver Tower 1"
                Me.FillMaps(8)
                Me.InitializeFields()
                LevelSelectedMap = 7
                t_lvlname2.Text = "Silver Tower Level 1"
            Case "08 - Silver Tower 2"
                Me.FillMaps(9)
                Me.InitializeFields()
                LevelSelectedMap = 8
                t_lvlname2.Text = "Silver Tower Level 2"
            Case "09 - Silver Tower 3"
                Me.FillMaps(10)
                Me.InitializeFields()
                LevelSelectedMap = 9
                t_lvlname2.Text = "Silver Tower Level 3"
            Case "10 - Azure Tower 1"
                Me.FillMaps(11)
                Me.InitializeFields()
                LevelSelectedMap = 10
                t_lvlname2.Text = "Azure Tower Level 1"
            Case "11 - Azure Tower 2"
                Me.FillMaps(12)
                Me.InitializeFields()
                LevelSelectedMap = 11
                t_lvlname2.Text = "Azure Tower Level 2"
            Case "12 - Azure Tower 3"
                Me.FillMaps(13)
                Me.InitializeFields()
                LevelSelectedMap = 12
                t_lvlname2.Text = "Azure Tower Level 3"
            Case "13 - Azure Tower 4"
                Me.FillMaps(14)
                Me.InitializeFields()
                LevelSelectedMap = 13
                t_lvlname2.Text = "Azure Tower Level 4"
            Case "14 - Frost Giants"
                Me.FillMaps(15)
                Me.InitializeFields()
                LevelSelectedMap = 14
                t_lvlname2.Text = "Frost Giants Level"
            Case "15 - Crimson Tower 1"
                Me.FillMaps(16)
                Me.InitializeFields()
                LevelSelectedMap = 15
                t_lvlname2.Text = "Crimson Tower Level 1"
            Case "16 - Crimson Tower 2"
                Me.FillMaps(17)
                Me.InitializeFields()
                LevelSelectedMap = 16
                t_lvlname2.Text = "Crimson Tower Level 2"
        End Select
        t_level2.Text = LevelSelectedMap.ToString()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim rc As Integer

        If CurrentSaveGame = 0 Then
            MsgBox("No savegame selected. Please select a savegame first !!!")
            Return
        End If

        rc = MsgBox("This will update your position in the savegame !" + vbCrLf + "Are you sure wou want to do this ?", MsgBoxStyle.OkCancel)
        If rc = 1 Then
            'MsgBox("ok")
            Me.SavePosition()

        Else

            Return
            'MsgBox("cancel")
        End If

    End Sub


    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click

        If RadioButton1.Checked = True Then
            CurrentSaveGame = 1
            CurrentSaveGameName = "EOBDATA0.SAV"
        End If

    End Sub

 

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click

        If RadioButton2.Checked = True Then
            CurrentSaveGame = 2
            CurrentSaveGameName = "EOBDATA1.SAV"
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(CurrentSaveGameName)

    End Sub

    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click

        If RadioButton3.Checked = True Then
            CurrentSaveGame = 3
            CurrentSaveGameName = "EOBDATA2.SAV"
        End If

    End Sub

    Private Sub RadioButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click

        If RadioButton4.Checked = True Then
            CurrentSaveGame = 4
            CurrentSaveGameName = "EOBDATA3.SAV"
        End If

    End Sub

    Private Sub RadioButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.Click

        If RadioButton5.Checked = True Then
            CurrentSaveGame = 5
            CurrentSaveGameName = "EOBDATA4.SAV"
        End If

    End Sub

    Private Sub RadioButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton6.Click

        If RadioButton6.Checked = True Then
            CurrentSaveGame = 6
            CurrentSaveGameName = "EOBDATA5.SAV"
        End If

    End Sub

    Public Sub SavePositionCopyRemoveLater()

        Dim curpos, newpos, newpos2 As Integer
        Dim pos As Integer = 0
        Dim filnam, sItem, sItem2, sItemHex As String
        Dim byte1, byte2 As Byte

        curpos = CurrentPosition
        newpos = CurrentClicked
        If newpos > 767 Then
            newpos = newpos - 768
            newpos2 = 3
        ElseIf newpos > 511 Then
            newpos = newpos - 512
            newpos2 = 2
        ElseIf newpos > 255 Then
            newpos = newpos - 256
            newpos2 = 1
        Else
            newpos2 = 0
        End If
        '256 512 768 1024

        sItem = newpos.ToString()
        sItem2 = newpos2.ToString()

        filnam = TextBox1.Text
        filnam = filnam + "\" + CurrentSaveGameName

        Dim fileStream As IO.FileStream = New IO.FileStream(filnam, IO.FileMode.Open)
        fileStream.Seek(LocPosition - 1, IO.SeekOrigin.Begin)
        fileStream.WriteByte(sItem)
        fileStream.WriteByte(sItem2)

        fileStream.Close()
        CurrentClicked = 0
        CurrentClickedX = 0
        CurrentClickedY = 0
        CurrentTag = CurrentClickedTag
        Me.LoadSaveGame()

    End Sub


    Public Sub SavePosition()

        Dim curpos, curposx, curposy, newpos, newposx, newposy, newpos2 As Integer
        Dim pos As Integer = 0
        Dim filnam, sItem, sItem2, sItemHex As String
        Dim byte1, byte2 As Byte

        'CurrentPosY = CurPosition / 32
        'CurrentPosX = (CurPosition Mod 32)

        curpos = CurrentPosition
        curposx = CurrentPosX
        curposy = CurrentPosY

        newpos = CurrentClicked
        newposx = CurrentClickedX
        newposy = CurrentClickedY

        If newpos > 767 Then
            newpos = newpos - 768
            newpos2 = 3
        ElseIf newpos > 511 Then
            newpos = newpos - 512
            newpos2 = 2
        ElseIf newpos > 255 Then
            newpos = newpos - 256
            newpos2 = 1
        Else
            newpos2 = 0
        End If

        sItem = newpos.ToString()
        sItem2 = newpos2.ToString()

        filnam = TextBox1.Text
        filnam = filnam + "\" + CurrentSaveGameName

        WriteFile(filnam, LocPosition, sItem)
        WriteFile(filnam, LocPosition + 1, sItem2)

        CurrentClicked = 0
        CurrentClickedX = 0
        CurrentClickedY = 0
        CurrentTag = CurrentClickedTag
        Me.LoadSaveGame()


    End Sub

    Private Sub WriteNewSavegame(ByVal name As String, ByVal Lvl As String, ByVal Item As String, ByVal Item2 As String)

        Dim filnam As String

        filnam = TextBox1.Text
        filnam = filnam + "\" + CurrentSaveGameName

        If name <> "" Then
            WriteFileString(filnam, 0, name)
        End If
        WriteFile(filnam, LocLevel, Lvl)
        WriteFile(filnam, LocPosition, Item)
        WriteFile(filnam, LocPosition + 1, Item2)


    End Sub

    Private Sub WriteFileString(ByVal fnam As String, ByVal pos As Integer, ByVal item As String)
        Dim loc, l2 As Integer
        Dim str, strasci, strhex As String

        If pos = 0 Then
            loc = 0
        Else
            loc = pos - 1
        End If

        Dim fileStream As IO.FileStream = New IO.FileStream(fnam, IO.FileMode.Open)
        fileStream.Seek(loc, IO.SeekOrigin.Begin)

        For i = 0 To item.Length - 1
            str = item.Substring(i, 1)
            strasci = Asc(str)
            fileStream.WriteByte(strasci)
        Next
        fileStream.Close()

    End Sub

    Private Sub WriteFile(ByVal fnam As String, ByVal pos As Integer, ByVal item As String)

        Dim fileStream As IO.FileStream = New IO.FileStream(fnam, IO.FileMode.Open)
        fileStream.Seek(pos - 1, IO.SeekOrigin.Begin)
        fileStream.WriteByte(item)
        fileStream.Close()


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.SavePosition()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If CurrentSaveGame = 0 Then
            MsgBox("No savegame selected. Please load a savegame first !!!")
            Return
        End If

        If c_newlevel.Text = "" Then
            MsgBox("No new level selected. Please select a a new level first !!!")
            Return
        End If

        Me.NewLevelSavegame(t_sgname.Text, c_newlevel.Text)
        MsgBox("New level is saved. Please select this map and then reopen the savegame !!!")


    End Sub

    Private Sub NewLevelSavegame(ByVal name As String, ByVal str As String)

        Dim sItem, sItem2, sLvl As String

        Select Case str

            Case "00  - Wood" 'Wood is placed on map level 4 !
                sLvl = 4
                sItem = 171
                sItem2 = 0
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "01 - Catacombs 1"
                sLvl = 1
                sItem = 138
                sItem2 = 1
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "02 - Catacombs 2"
                sLvl = 2
                sItem = 170
                sItem2 = 1
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "03 - Catacombs 3"
                sLvl = 3
                sItem = 90
                sItem2 = 0
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "04 - Catacombs 4"  'Level 4 is placed left on Map level 3 !
                sLvl = 3
                sItem = 37
                sItem2 = 0
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "05 - Temple 1"
                sLvl = 5
                sItem = 46
                sItem2 = 1
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "06 - Temple 2"
                sLvl = 6
                sItem = 106
                sItem2 = 0
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "07 - Silver Tower 1"
                sLvl = 7
                sItem = 207
                sItem2 = 0
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "08 - Silver Tower 2"
                sLvl = 8
                sItem = 182
                sItem2 = 3
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "09 - Silver Tower 3"
                sLvl = 9
                sItem = 5
                sItem2 = 1
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "10 - Azure Tower 1"
                sLvl = 10
                sItem = 214
                sItem2 = 1
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "11 - Azure Tower 2"
                sLvl = 11
                sItem = 209
                sItem2 = 3
                WriteNewSavegame(name, sLvl, sItem, sItem2)


            Case "12 - Azure Tower 3"
                sLvl = 12
                sItem = 252
                sItem2 = 2
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "13 - Azure Tower 4"
                sLvl = 13
                sItem = 187
                sItem2 = 3
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "14 - Frost Giants"
                sLvl = 14
                sItem = 249
                sItem2 = 1
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "15 - Crimson Tower 1"
                sLvl = 15
                sItem = 1
                sItem2 = 2
                WriteNewSavegame(name, sLvl, sItem, sItem2)

            Case "16 - Crimson Tower 2"
                sLvl = 16
                sItem = 16
                sItem2 = 1
                WriteNewSavegame(name, sLvl, sItem, sItem2)

        End Select

    End Sub

    Private Sub t_position2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_position2.TextChanged

    End Sub
End Class