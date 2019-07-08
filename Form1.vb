Public Class Form1

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    'btton play,pause and stop
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    'FOR ACTIION LISTENWER ON 'OPEN' BUTTON, YOU HAVE TO CLICK OPEN BUTTON,THEK CHOOSE THE TRACK AUDIO OF YOUR CHOICE AND GOOD TO GO
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName

    End Sub

    '//FOR TRACK BAR
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
    End Sub

End Class
