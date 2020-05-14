Public Class Form2
    Private Sub btnSong1_Click(sender As Object, e As EventArgs) Handles btnSong1.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\gangnamstyle.wav")
        lblAnthem.Text = "GANGNAM STYLE! - PSY"

    End Sub

    Private Sub btnSong2_Click(sender As Object, e As EventArgs) Handles btnSong2.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\PSY - GENTLEMAN MV.wav")
        lblAnthem.Text = "GENTLEMEN! - PSY"

    End Sub

    Private Sub btnSong3_Click(sender As Object, e As EventArgs) Handles btnSong3.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\LMFAO ft. Lauren Bennett, GoonRock - Party Rock Anthem (Official Video).wav")
        lblAnthem.Text = "PARTY ROCK IS IN THE HOUSE TONIGHT - REDFOO"

    End Sub

    Private Sub btnSong4_Click(sender As Object, e As EventArgs) Handles btnSong4.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\Trance - 009 Sound System Dreamscape (HD).wav")
        lblAnthem.Text = "UNREGISTERED HYPERCAM 2 - BARACK HUSSEIN OBAMA"

    End Sub
End Class