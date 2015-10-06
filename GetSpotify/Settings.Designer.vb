<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsWindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsWindow))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Save = New System.Windows.Forms.Button()
        Me.sliderTime = New System.Windows.Forms.Label()
        Me.timerSettings = New System.Windows.Forms.TrackBar()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.timerSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(434, 209)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Save)
        Me.TabPage1.Controls.Add(Me.sliderTime)
        Me.TabPage1.Controls.Add(Me.timerSettings)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(426, 183)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Timer"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Save.Location = New System.Drawing.Point(342, 154)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 2
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'sliderTime
        '
        Me.sliderTime.AutoSize = True
        Me.sliderTime.Location = New System.Drawing.Point(6, 65)
        Me.sliderTime.Name = "sliderTime"
        Me.sliderTime.Size = New System.Drawing.Size(188, 13)
        Me.sliderTime.TabIndex = 1
        Me.sliderTime.Text = "Track-Change-Timer: 500 Milliseconds"
        '
        'timerSettings
        '
        Me.timerSettings.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.timerSettings.LargeChange = 100
        Me.timerSettings.Location = New System.Drawing.Point(6, 17)
        Me.timerSettings.Maximum = 5000
        Me.timerSettings.Minimum = 500
        Me.timerSettings.Name = "timerSettings"
        Me.timerSettings.Size = New System.Drawing.Size(411, 45)
        Me.timerSettings.SmallChange = 100
        Me.timerSettings.TabIndex = 0
        Me.timerSettings.TickFrequency = 100
        Me.timerSettings.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.timerSettings.Value = 500
        '
        'SettingsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 214)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SettingsWindow"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.timerSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents timerSettings As System.Windows.Forms.TrackBar
    Friend WithEvents sliderTime As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
End Class
