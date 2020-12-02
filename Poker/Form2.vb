Public Class Form2
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Form1.Show()
        Form1.novahra()
        Form1.Timerlogikahry.Start()

        Me.Hide()
    End Sub

    Private Sub btnkonec_Click(sender As Object, e As EventArgs) Handles btnkonec.Click
        Me.Close()

    End Sub

    Private Sub checkblindy_CheckedChanged(sender As Object, e As EventArgs) Handles checkblindy.CheckedChanged
        If checkblindy.Checked Then
            numericblindy.Enabled = True
        Else
            numericblindy.Enabled = False
        End If
    End Sub
End Class