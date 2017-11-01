Public Class Cars

    Dim enemyspeed As Integer = 100
    Dim hisScore As Integer = 0
    Dim myScore As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pctblue.Left = pctblue.Left + 1
        If pctblue.Bounds.IntersectsWith(pctFinish.Bounds) Then
            hisScore = hisScore + 1
            pctblue.Left = 12
            pctgreen.Left = 12
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub






    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmdClose.KeyUp
        If e.KeyValue = Keys.Q Then
            pctgreen.Left = pctgreen.Left + 3
        End If
        If pctgreen.Bounds.IntersectsWith(pctFinish.Bounds) Then
            myScore = myScore + 1
            MsgBox("Congratulations. You Won. Play Again and I'll beat you")
            pctblue.Left = 12
            pctgreen.Left = 12
            enemyspeed = enemyspeed - 10
            Timer1.Interval = enemyspeed
        End If

    End Sub

    Private Sub pctblue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctblue.Click

    End Sub
End Class
