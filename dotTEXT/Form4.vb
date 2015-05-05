Public Class Form4

    Dim enemyhealth As Integer

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        enemyhealth = My.Settings.enemyhealth
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        lblenemyLevel.Text = lblenemyLevel.Tag & My.Settings.enemylevel
        lblenemyhealth.Text = lblenemyhealth.Tag & My.Settings.enemyhealth
    End Sub

    Private Sub strifeStrife_Click(sender As System.Object, e As System.EventArgs) Handles strifeStrife.Click
        enemyhealth = enemyhealth - 5
        '   pass variables to Main_Window.
    End Sub
End Class