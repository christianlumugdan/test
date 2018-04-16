<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splashscreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splashscreen))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        AxWindowsMediaPlayer1.Size = New System.Drawing.Size(767, 446)
        AxWindowsMediaPlayer1.TabIndex = 3
        AddHandler AxWindowsMediaPlayer1.Enter, AddressOf Me.AxWindowsMediaPlayer1_Enter
        '
        'Timer1
        '
        Me.Timer1.Interval = 45
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.BorderRadius = 5
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 397)
        Me.ProgressBar1.MaximumValue = 100
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressColor = System.Drawing.Color.Black
        Me.ProgressBar1.Size = New System.Drawing.Size(734, 10)
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Value = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 9)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me
        '
        'Splashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 405)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(AxWindowsMediaPlayer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splashscreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading..."
        CType(AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse

End Class
