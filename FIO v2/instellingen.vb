
Public Class instellingen

    Dim directory As String = My.Application.Info.DirectoryPath

    Private Sub btnimages_Click(sender As Object, e As EventArgs) Handles btnimages.Click
        FolderBrowserImages.ShowDialog()
        If FolderBrowserImages.SelectedPath <> "" Then
            txtimages.Text = FolderBrowserImages.SelectedPath
        Else
            txtimages.Text = directory & "\Cards"
        End If

    End Sub


    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click

        Dim schrijver As New IO.StreamWriter(directory & "\config\odds.txt")
        schrijver.WriteLine(updownA.Value)
        schrijver.WriteLine(updownB.Value)
        schrijver.WriteLine(updownC.Value)
        schrijver.WriteLine(updownD.Value)
        schrijver.WriteLine(updownF.Value)
        schrijver.WriteLine(updownH.Value)
        schrijver.WriteLine(updownJ.Value)
        schrijver.WriteLine(updownS.Value)
        schrijver.WriteLine(txtimages.Text)
        schrijver.WriteLine(numupdown.Value)
        schrijver.WriteLine(rndmin.Value)
        schrijver.WriteLine(rndmax.Value)


        schrijver.Close()
        schrijver.Dispose()



        Me.Close()
        hoofdprogramma.Show()


    End Sub
    Private Sub instellingen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As New System.IO.StreamReader(directory & "\config\odds.txt")

        updownA.Value = sr.ReadLine
        updownB.Value = sr.ReadLine
        updownC.Value = sr.ReadLine
        updownD.Value = sr.ReadLine
        updownF.Value = sr.ReadLine
        updownH.Value = sr.ReadLine
        updownJ.Value = sr.ReadLine
        updownS.Value = sr.ReadLine
        txtimages.Text = sr.ReadLine
        numupdown.Value = sr.ReadLine
        rndmin.Value = sr.ReadLine
        rndmax.Value = sr.ReadLine

        sr.Dispose()
        sr.Close()

        lbltotal.Text = "Total odds: " & (updownA.Value + updownB.Value + updownC.Value + updownD.Value + updownF.Value + updownH.Value + updownJ.Value + updownS.Value)


    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            hoofdprogramma.Show()
            Me.Close()
        End If

    End Sub


    Private Sub updownA_ValueChanged(sender As Object, e As EventArgs) Handles updownA.ValueChanged, updownB.ValueChanged, updownC.ValueChanged, updownD.ValueChanged, updownF.ValueChanged, updownH.ValueChanged, updownJ.ValueChanged, updownS.ValueChanged

        If updownA.Value + updownB.Value + updownC.Value + updownD.Value + updownF.Value + updownH.Value + updownJ.Value + updownS.Value = "0" Then
            updownC.Value = 1
        End If
        lbltotal.Text = "Total odds: " & (updownA.Value + updownB.Value + updownC.Value + updownD.Value + updownF.Value + updownH.Value + updownJ.Value + updownS.Value)


    End Sub

    Private Sub instellingen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        hoofdprogramma.Show()

    End Sub

    Private Sub btnAddCards_Click(sender As Object, e As EventArgs) Handles btnAddCards.Click

        If txtimages.Text = "" Then
            temppath = directory & "\Cards"
        Else
            temppath = txtimages.Text
        End If
        OpenFileNewCards.ShowDialog()

        If OpenFileNewCards.FileName <> "" Then

            ' add new card stuff
            newcardpath = OpenFileNewCards.FileName

            newcardname = Microsoft.VisualBasic.Right(OpenFileNewCards.FileName, 9)
            addcards.Show()
        


        End If




    End Sub
End Class