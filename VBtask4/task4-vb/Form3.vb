Public Class Form3
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\gangnamstyle.wav")
        txtSong.Text = "Gangnam_Style_2012"


    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\chesburger.wav")
        txtSong.Text = "cheesburger"

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\aussies.wav")
        txtSong.Text = "australian national anthem 2020 version"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\PSY - GENTLEMAN MV.wav")
        txtSong.Text = "gentlemen psy"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\Albanian National Anthem - Hymni I Flamurit (SQEN).wav")
        txtSong.Text = "republic of albania"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\Trance - 009 Sound System Dreamscape (HD).wav")
        txtSong.Text = "unregistered hypercam 2, do you guys know what this song is called? it sounds like: dun dun dun dun dun dun dun dun dun"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\bosnia.wav")
        txtSong.Text = "bosnia"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        My.Computer.Audio.Play("F:\YR11\IT\VBtask4\music\LMFAO ft. Lauren Bennett, GoonRock - Party Rock Anthem (Official Video).wav")
        txtSong.Text = "party rockers in the house tonight! we gonna make you loose your mind! we just want to say it! dun dun dun duh duh dun..."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
    End Sub
End Class