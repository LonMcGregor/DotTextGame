Public Class Form3

    Private Sub Form3_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
        Main_Window.Splash.Visible = True
        Main_Window.lblSplash.Visible = False
    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dockSplash.Image = Main_Window.Splash.Image
        splashUpdate.Start()
    End Sub

    Private Sub splashUpdate_Tick(sender As Object, e As System.EventArgs) Handles splashUpdate.Tick
        dockSplash.Image = Main_Window.Splash.Image
    End Sub


End Class