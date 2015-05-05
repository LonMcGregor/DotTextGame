Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gameNotes.Text = My.Settings.notes
    End Sub
    Private Sub saveNotes_Click(sender As System.Object, e As System.EventArgs) Handles saveNotes.Click
        My.Settings.notes = gameNotes.Text
    End Sub


    Private Sub resetNotes_Click(sender As System.Object, e As System.EventArgs) Handles resetNotes.Click
        gameNotes.Text = Nothing
    End Sub
End Class