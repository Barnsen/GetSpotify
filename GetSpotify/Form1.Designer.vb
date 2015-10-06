<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.connectBtn = New System.Windows.Forms.Button()
        Me.updateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Cover = New System.Windows.Forms.PictureBox()
        Me.Artist = New System.Windows.Forms.Label()
        Me.Track = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.preview = New System.Windows.Forms.Label()
        Me.previewLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.format = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Cover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'connectBtn
        '
        Me.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.connectBtn.Image = CType(resources.GetObject("connectBtn.Image"), System.Drawing.Image)
        Me.connectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.connectBtn.Location = New System.Drawing.Point(13, 13)
        Me.connectBtn.Name = "connectBtn"
        Me.connectBtn.Size = New System.Drawing.Size(336, 35)
        Me.connectBtn.TabIndex = 0
        Me.connectBtn.Text = "Connect to Spotify"
        Me.connectBtn.UseVisualStyleBackColor = True
        '
        'updateTimer
        '
        Me.updateTimer.Enabled = True
        '
        'Cover
        '
        Me.Cover.ErrorImage = CType(resources.GetObject("Cover.ErrorImage"), System.Drawing.Image)
        Me.Cover.Image = CType(resources.GetObject("Cover.Image"), System.Drawing.Image)
        Me.Cover.InitialImage = CType(resources.GetObject("Cover.InitialImage"), System.Drawing.Image)
        Me.Cover.Location = New System.Drawing.Point(13, 55)
        Me.Cover.Name = "Cover"
        Me.Cover.Size = New System.Drawing.Size(160, 160)
        Me.Cover.TabIndex = 1
        Me.Cover.TabStop = False
        '
        'Artist
        '
        Me.Artist.AutoSize = True
        Me.Artist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Artist.Location = New System.Drawing.Point(180, 55)
        Me.Artist.Name = "Artist"
        Me.Artist.Size = New System.Drawing.Size(153, 13)
        Me.Artist.TabIndex = 2
        Me.Artist.Text = "Please connect to Spotify"
        '
        'Track
        '
        Me.Track.AutoSize = True
        Me.Track.Location = New System.Drawing.Point(180, 68)
        Me.Track.Name = "Track"
        Me.Track.Size = New System.Drawing.Size(0, 13)
        Me.Track.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(352, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Settings"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.preview)
        Me.GroupBox1.Controls.Add(Me.previewLabel)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.format)
        Me.GroupBox1.Location = New System.Drawing.Point(183, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 129)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "mix.txt format settings"
        '
        'preview
        '
        Me.preview.AutoSize = True
        Me.preview.Location = New System.Drawing.Point(7, 111)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(0, 13)
        Me.preview.TabIndex = 4
        '
        'previewLabel
        '
        Me.previewLabel.AutoSize = True
        Me.previewLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previewLabel.Location = New System.Drawing.Point(7, 98)
        Me.previewLabel.Name = "previewLabel"
        Me.previewLabel.Size = New System.Drawing.Size(56, 13)
        Me.previewLabel.TabIndex = 3
        Me.previewLabel.Text = "Preview:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(241, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Syntax:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{artist} = Artist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{track} = Track"
        '
        'format
        '
        Me.format.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.format.Location = New System.Drawing.Point(7, 29)
        Me.format.MaxLength = 120
        Me.format.Name = "format"
        Me.format.Size = New System.Drawing.Size(250, 20)
        Me.format.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(355, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Update?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 223)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Track)
        Me.Controls.Add(Me.Artist)
        Me.Controls.Add(Me.Cover)
        Me.Controls.Add(Me.connectBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "GetSpotify"
        CType(Me.Cover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents connectBtn As System.Windows.Forms.Button
    Friend WithEvents updateTimer As System.Windows.Forms.Timer
    Friend WithEvents Cover As System.Windows.Forms.PictureBox
    Friend WithEvents Artist As System.Windows.Forms.Label
    Friend WithEvents Track As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents format As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents previewLabel As System.Windows.Forms.Label
    Friend WithEvents preview As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
