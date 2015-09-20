Imports System.IO

Public Class hoofdprogramma

    Dim directory As String = My.Application.Info.DirectoryPath
    Dim vorigepath, volgendepath As String
    Dim Cteller, randommin, randommax, time1, time2, time1old, time2old, time1next, time2next, timermem, timermem2, timerval2, randomtimer As Integer
    Dim vorige, vorigenext As Boolean


    Private Sub btnconfig_Click(sender As Object, e As EventArgs) Handles btnconfig.Click
        randomtimer = 0
        Timer1.Enabled = False
        lbltijd.Text = ""

        instellingen.Show()
        Me.Hide()

    End Sub






    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGewogen.Click
        Dim sr As New System.IO.StreamReader(directory & "\config\odds.txt")
        Dim oddsA, oddsB, oddsC, oddsD, oddsF, oddsH, oddsJ, oddsS, oddsSOM, hulpgetal, i, rndhulp, ran, minimumC As Integer
        Dim cardID, cardPATH As String

        randomtimer = 0
        Timer1.Enabled = False
        lbltijd.Text = ""
        timermem2 = 0
        btntimer2.Visible = False
        lbltijd2.Text = ""

        vorigepath = PictureBox1.ImageLocation
        time1old = time1
        time2old = time2

        If ChkExclude.Checked = True Then
            ChkExclude.Checked = False
            Dim result = MessageBox.Show("Do you want to delete the last card from the game?", "Delete card", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim schrijver1 As New IO.StreamWriter(directory & "\config\CardsConfig\excludedcards.txt", True)
                Dim schrijver2 As New IO.StreamWriter(directory & "\config\GameData\tmp\tmp1.txt")

                Dim excludehulp As String
                excludehulp = Microsoft.VisualBasic.Right(vorigepath, 9)
                schrijver1.WriteLine(Microsoft.VisualBasic.Left(excludehulp, 5))

                Dim sr3 As New System.IO.StreamReader(directory & "\config\CardsConfig\" & Microsoft.VisualBasic.Left(excludehulp, 1) & "-cards.txt")

                Dim teller As String
                Do Until Microsoft.VisualBasic.Left(excludehulp, 5) = Microsoft.VisualBasic.Left(teller, 5)

                    If teller <> "" Then
                        schrijver2.WriteLine(teller)
                    End If
                    teller = sr3.ReadLine()

                Loop
                Do Until sr3.EndOfStream = True
                    schrijver2.WriteLine(sr3.ReadLine())
                Loop



                schrijver1.Close()
                schrijver1.Dispose()
                schrijver2.Close()
                schrijver2.Dispose()
                sr3.Close()
                sr3.Dispose()

                My.Computer.FileSystem.DeleteFile(directory & "\config\CardsConfig\" & Microsoft.VisualBasic.Left(excludehulp, 1) & "-cards.txt")
                My.Computer.FileSystem.MoveFile(directory & "\config\GameData\tmp\tmp1.txt", directory & "\config\CardsConfig\" & Microsoft.VisualBasic.Left(excludehulp, 1) & "-cards.txt")

            End If


        End If
        If volgendepath <> "" Then
            PictureBox1.ImageLocation = volgendepath
            volgendepath = ""
        Else


            oddsA = sr.ReadLine
            oddsB = sr.ReadLine
            oddsC = sr.ReadLine
            oddsD = sr.ReadLine
            oddsF = sr.ReadLine
            oddsH = sr.ReadLine
            oddsJ = sr.ReadLine
            oddsS = sr.ReadLine
            cardPATH = sr.ReadLine
            minimumC = sr.ReadLine
            randommin = sr.ReadLine
            randommax = sr.ReadLine

            sr.Dispose()
            sr.Close()

            If cardPATH = "" Then
                cardPATH = directory & "\Cards"
            End If
            oddsSOM = oddsA + oddsB + oddsC + oddsD + oddsF + oddsH + oddsJ + oddsS

            Dim rndnumber As Random
            rndnumber = New Random
            hulpgetal = rndnumber.Next(0, oddsSOM)

            Dim type As Char

            If hulpgetal < oddsA Then
                type = "A"
            ElseIf hulpgetal < oddsA + oddsB Then
                type = "B"
            ElseIf hulpgetal < oddsA + oddsB + oddsC Then
                If minimumC < Cteller Then
                    type = "C"
                Else
                    type = "N" ' not good --> C too early
                End If
            ElseIf hulpgetal < oddsA + oddsB + oddsC + oddsD Then
                type = "D"
            ElseIf hulpgetal < oddsA + oddsB + oddsC + oddsD + oddsF Then
                type = "F"
            ElseIf hulpgetal < oddsA + oddsB + oddsC + oddsD + oddsF + oddsH Then
                type = "H"
            ElseIf hulpgetal < oddsA + oddsB + oddsC + oddsD + oddsF + oddsH + oddsJ Then
                type = "J"
            Else
                type = "S"
            End If

            If type = "N" Then
                btnGewogen.PerformClick()

            ElseIf File.ReadAllText(directory & "\config\GameData\" & type & "-cards.txt").Length = 0 Then

                My.Computer.FileSystem.DeleteFile(directory & "\config\GameData\" & type & "-cards.txt")
                My.Computer.FileSystem.CopyFile(directory & "\config\CardsConfig\" & type & "-cards.txt", directory & "\config\GameData\" & type & "-cards.txt")
                btnGewogen.PerformClick()
            Else



                Dim sr1 As New System.IO.StreamReader(directory & "\config\GameData\" & type & "-cards.txt")
                Dim sr2 As New System.IO.StreamReader(directory & "\config\GameData\" & type & "-cards.txt")
                Dim schrijver As New IO.StreamWriter(directory & "\config\GameData\tmp\tmp.txt")


                Do Until sr1.EndOfStream = True
                    sr1.ReadLine()
                    i += 1
                Loop

                sr1.Dispose()
                sr1.Close()
                Randomize()
                ran = Rnd() * i
                Do Until ran = rndhulp
                    If cardID <> "" Then
                        schrijver.WriteLine(cardID)
                    End If
                    cardID = sr2.ReadLine()
                    rndhulp += 1
                Loop
                Do Until sr2.EndOfStream = True
                    schrijver.WriteLine(sr2.ReadLine())
                Loop
                schrijver.Close()
                schrijver.Dispose()

                sr1.Dispose()
                sr1.Close()

                sr2.Dispose()
                sr2.Close()
                If cardID = "" Then
                    btnGewogen.PerformClick()
                Else

                    PictureBox1.ImageLocation = cardPATH & "\" & Microsoft.VisualBasic.Left(cardID, 5) & ".jpg"
                    ' timer 1 en 2 invoegen <-----
                    time1 = Microsoft.VisualBasic.Mid(cardID, 7, 4)
                    time2 = Microsoft.VisualBasic.Mid(cardID, 12, 4)

                    My.Computer.FileSystem.DeleteFile(directory & "\config\GameData\" & type & "-cards.txt")
                    My.Computer.FileSystem.MoveFile(directory & "\config\GameData\tmp\tmp.txt", directory & "\config\GameData\" & type & "-cards.txt")

                    If vorigepath <> "" Then
                        btnVorige.Enabled = True
                    End If
                    Cteller += 1

                End If
            End If
        End If

    End Sub



 
    Private Sub btnVorige_Click(sender As Object, e As EventArgs) Handles btnVorige.Click
        btnVorige.Enabled = False
        volgendepath = PictureBox1.ImageLocation
        time1next = time1
        time2next = time2
        PictureBox1.ImageLocation = vorigepath

        randomtimer = 0
        Timer1.Enabled = False
        lbltijd.Text = ""

        ' vorige timers instellen

        vorige = True


    End Sub

  


 

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        btnGewogen.PerformClick()

    End Sub


    Private Sub myForm_FormClosing(ByVal sender As System.Object,
                          ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                             Handles MyBase.FormClosing

        My.Settings.size = Me.Size
        My.Settings.Save()

    End Sub
    Private Sub myForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
  Handles MyBase.Load

        If Not My.Settings.size.IsEmpty Then
            Me.Size = My.Settings.size
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then


            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnrandomtimer.Click ' timer1 input bijwerken
        If btnrandomtimer.Text = "Start Random Timer" Then
            Dim my_rand As Random
            my_rand = New Random
            randomtimer = my_rand.Next(randommin, randommax)
            Timer1.Enabled = True
        Else

            randomtimer = timermem
            lbltijd.Text = timermem
            Timer1.Enabled = True

        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        randomtimer -= 1
        lbltijd.Text = randomtimer.ToString
        If randomtimer = 0 Then
            Timer1.Enabled = False
            lbltijd.Text = ""
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        MessageBox.Show(directory, "test", MessageBoxButtons.OK)

    End Sub


    Private Sub PictureBox1_newpicture(sender As Object, e As EventArgs) Handles PictureBox1.LoadCompleted
        btnrandomtimer.Enabled = True

        '  MessageBox.Show(time1 & " " & time2)
        If vorige = True Then
            '      MessageBox.Show("dit was een vorige time: " & time1old & " " & time2old, "test", MessageBoxButtons.OK)
            If time1old <> 0 Then
                lbltijd.Text = time1old
                timermem = time1old
                btnrandomtimer.Text = "Start timer 1"
            Else
                btnrandomtimer.Text = "Start Random Timer"
                lbltijd.Text = ""

            End If

            If time2old <> 0 Then
                lbltijd2.Text = time2old.ToString
                timermem2 = time2old
                btntimer2.Visible = True

            Else
                btntimer2.Visible = False
                lbltijd2.Text = ""
                Timer2.Enabled = False

            End If
            vorige = False
            vorigenext = True

        ElseIf vorigenext = True Then
            '       MessageBox.Show("dit was een next na vorige: " & time1next & " " & time2next, "test", MessageBoxButtons.OK)

            If time1next <> 0 Then
                lbltijd.Text = time1next
                timermem = time1next
                btnrandomtimer.Text = "Start timer 1"
            Else
                btnrandomtimer.Text = "Start Random Timer"
                lbltijd.Text = ""

            End If

            If time2next <> 0 Then
                lbltijd2.Text = time2next.ToString
                timermem2 = time2next
                btntimer2.Visible = True
            Else
                btntimer2.Visible = False
                lbltijd2.Text = ""
                Timer2.Enabled = False

            End If

            vorigenext = False
        Else
            '       MessageBox.Show("dit was een normale next: " & time1 & " " & time2, "test", MessageBoxButtons.OK)
            If time1 <> 0 Then
                lbltijd.Text = time1
                timermem = time1
                btnrandomtimer.Text = "Start timer 1"
            Else
                btnrandomtimer.Text = "Start Random Timer"
                lbltijd.Text = ""

            End If

            If time2 <> 0 Then
                lbltijd2.Text = time2.ToString
                timermem2 = time2
                btntimer2.Visible = True
            Else
                btntimer2.Visible = False
                lbltijd2.Text = ""
                Timer2.Enabled = False
            End If
        End If



    End Sub



    Private Sub btntimer2_Click(sender As Object, e As EventArgs) Handles btntimer2.Click
        Timer2.Enabled = True
        timerval2 = timermem2

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        timerval2 -= 1
        lbltijd2.Text = timerval2.ToString
        If timerval2 = 0 Then
            Timer2.Enabled = False
            lbltijd2.Text = ""
        End If
    End Sub
End Class
