Public Class SettingsWindow

    Private Sub timerSettings_Scroll(sender As Object, e As EventArgs) Handles timerSettings.Scroll
        sliderTime.Text = "Track-Change-Timer: " + timerSettings.Value.ToString + " Milliseconds"
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Form1.updateTimer.Stop()
        Form1.updateTimer.Interval = timerSettings.Value
        Form1.updateTimer.Start()
        MessageBox.Show("Settings saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show(Form1.updateTimer.Interval.ToString)
    End Sub
End Class