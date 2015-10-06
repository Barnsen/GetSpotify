Imports GetSpotify
Imports SpotifyAPI.Local
Imports Newtonsoft.Json
Imports SpotifyAPI.Local.Models
Imports System.Net
Imports System.IO
Imports System.Text


Public Class Form1
    Dim currentTrack As String
    Dim currentArtist As String
    Dim _spotify = New SpotifyLocalAPI()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        GroupBox1.Enabled = False
        format.Text = My.Settings.mixformat
        preview.Text = RenderMix(My.Settings.mixformat)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles connectBtn.Click
        Try
            If Not SpotifyLocalAPI.IsSpotifyRunning() Then
                MessageBox.Show("Spotify isn't running!")
                Return
            End If
            If Not SpotifyLocalAPI.IsSpotifyWebHelperRunning() Then
                MessageBox.Show("SpotifyWebHelper isn't running!")
                Return
            End If

            Dim successful As Boolean = _spotify.Connect()
            If successful Then
                connectBtn.Text = "Connection to Spotify successful"
                connectBtn.Enabled = False
                updateTimer.Start()
                _spotify.ListenForEvents = False
                Button1.Enabled = True
                GroupBox1.Enabled = True
            Else
                Dim res As DialogResult = MessageBox.Show("Couldn't connect to the spotify client.", "Spotify", MessageBoxButtons.OK)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub updateTimer_Tick(sender As Object, e As EventArgs) Handles updateTimer.Tick
        Try
            Dim status As StatusResponse = _spotify.GetStatus()
            If Not status.Track.TrackResource.Name = currentTrack Then
                currentArtist = status.Track.ArtistResource.Name
                currentTrack = status.Track.TrackResource.Name
                DownloadFile(status.Track.GetAlbumArtUrl(Enums.AlbumArtSize.Size160), Application.StartupPath + "\cover.png")
                Cover.ImageLocation = Application.StartupPath + "\cover.png"
                File.WriteAllText(Application.StartupPath + "\track.txt", currentTrack)
                File.WriteAllText(Application.StartupPath + "\artist.txt", currentArtist)
                File.WriteAllText(Application.StartupPath + "\mix.txt", RenderMix(My.Settings.mixformat))
            End If

            Artist.Text = status.Track.ArtistResource.Name
            Track.Text = status.Track.TrackResource.Name
        Catch ex As Exception

        End Try
    End Sub
    Public Sub DownloadFile(ByVal _URL As String, ByVal _SaveAs As String)
        Try
            Dim _WebClient As New System.Net.WebClient()
            _WebClient.DownloadFile(_URL, _SaveAs)
        Catch _Exception As Exception
            Console.WriteLine("Exception caught in process: {0}", _Exception.ToString())
        End Try
    End Sub
    Public Function RenderMix(ByVal Text As String) As String
        Text = Text.Replace("{artist}", currentArtist)
        Text = Text.Replace("{track}", currentTrack)
        Return Text
    End Function

    Private Sub format_TextChanged(sender As Object, e As EventArgs) Handles format.TextChanged
        preview.Text = RenderMix(format.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Settings.mixformat = format.Text
        My.Settings.Save()
        File.WriteAllText(Application.StartupPath + "\mix.txt", RenderMix(My.Settings.mixformat))
        MessageBox.Show("Saved", "Okay", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Cover_Click(sender As Object, e As EventArgs) Handles Cover.Click
        Process.Start("https://obsproject.com/forum/members/trusted.46351/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Update Button
    End Sub
End Class
