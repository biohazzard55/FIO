Public Class addcards

    Private Sub addcards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnewname.Text = Microsoft.VisualBasic.Left(newcardname, 5)
        UpDowntimer1.Value = UpDowntimer2.Value = 0



    End Sub

    Private Sub btnaddcard_Click(sender As Object, e As EventArgs) Handles btnaddcard.Click
        newcardname = txtnewname.Text & Microsoft.VisualBasic.Right(newcardname, 4)
        addtimer1 = UpDowntimer1.Value.ToString.PadLeft(4)
        addtimer2 = UpDowntimer2.Value.ToString.PadLeft(4)




        Me.Close()
    End Sub
End Class