Public Class frmNotifica
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)


    End Sub
    Public Sub fade_in()
        For FadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = FadeIn
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Private Sub frmNotifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fade_in()
    End Sub
End Class