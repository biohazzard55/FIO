<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hoofdprogramma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hoofdprogramma))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnconfig = New System.Windows.Forms.Button()
        Me.btnVorige = New System.Windows.Forms.Button()
        Me.btnGewogen = New System.Windows.Forms.Button()
        Me.ChkExclude = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnrandomtimer = New System.Windows.Forms.Button()
        Me.lbltijd = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltijd2 = New System.Windows.Forms.Label()
        Me.btntimer2 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 600)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnconfig
        '
        Me.btnconfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfig.Location = New System.Drawing.Point(698, 639)
        Me.btnconfig.Name = "btnconfig"
        Me.btnconfig.Size = New System.Drawing.Size(114, 44)
        Me.btnconfig.TabIndex = 4
        Me.btnconfig.Text = "Settings"
        Me.btnconfig.UseVisualStyleBackColor = True
        '
        'btnVorige
        '
        Me.btnVorige.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVorige.Enabled = False
        Me.btnVorige.Location = New System.Drawing.Point(12, 699)
        Me.btnVorige.Name = "btnVorige"
        Me.btnVorige.Size = New System.Drawing.Size(75, 23)
        Me.btnVorige.TabIndex = 1
        Me.btnVorige.Text = "Previous"
        Me.btnVorige.UseVisualStyleBackColor = True
        '
        'btnGewogen
        '
        Me.btnGewogen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGewogen.Location = New System.Drawing.Point(12, 639)
        Me.btnGewogen.Name = "btnGewogen"
        Me.btnGewogen.Size = New System.Drawing.Size(118, 44)
        Me.btnGewogen.TabIndex = 0
        Me.btnGewogen.Text = "Next"
        Me.btnGewogen.UseVisualStyleBackColor = True
        '
        'ChkExclude
        '
        Me.ChkExclude.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkExclude.AutoSize = True
        Me.ChkExclude.Location = New System.Drawing.Point(167, 654)
        Me.ChkExclude.Name = "ChkExclude"
        Me.ChkExclude.Size = New System.Drawing.Size(107, 17)
        Me.ChkExclude.TabIndex = 2
        Me.ChkExclude.Text = "Exclude this card"
        Me.ChkExclude.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(737, 699)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnrandomtimer
        '
        Me.btnrandomtimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnrandomtimer.Enabled = False
        Me.btnrandomtimer.Location = New System.Drawing.Point(167, 699)
        Me.btnrandomtimer.Name = "btnrandomtimer"
        Me.btnrandomtimer.Size = New System.Drawing.Size(129, 23)
        Me.btnrandomtimer.TabIndex = 3
        Me.btnrandomtimer.Text = "Start Random Timer"
        Me.btnrandomtimer.UseVisualStyleBackColor = True
        '
        'lbltijd
        '
        Me.lbltijd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltijd.AutoSize = True
        Me.lbltijd.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltijd.Location = New System.Drawing.Point(315, 666)
        Me.lbltijd.Name = "lbltijd"
        Me.lbltijd.Size = New System.Drawing.Size(0, 63)
        Me.lbltijd.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbltijd2
        '
        Me.lbltijd2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltijd2.AutoSize = True
        Me.lbltijd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltijd2.Location = New System.Drawing.Point(583, 666)
        Me.lbltijd2.Name = "lbltijd2"
        Me.lbltijd2.Size = New System.Drawing.Size(0, 63)
        Me.lbltijd2.TabIndex = 8
        '
        'btntimer2
        '
        Me.btntimer2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btntimer2.Location = New System.Drawing.Point(435, 699)
        Me.btntimer2.Name = "btntimer2"
        Me.btntimer2.Size = New System.Drawing.Size(129, 23)
        Me.btntimer2.TabIndex = 6
        Me.btntimer2.Text = "Start timer 2"
        Me.btntimer2.UseVisualStyleBackColor = True
        Me.btntimer2.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'hoofdprogramma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 734)
        Me.Controls.Add(Me.lbltijd2)
        Me.Controls.Add(Me.btntimer2)
        Me.Controls.Add(Me.lbltijd)
        Me.Controls.Add(Me.btnrandomtimer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ChkExclude)
        Me.Controls.Add(Me.btnGewogen)
        Me.Controls.Add(Me.btnVorige)
        Me.Controls.Add(Me.btnconfig)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "hoofdprogramma"
        Me.Text = "FIO v2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnconfig As System.Windows.Forms.Button
    Friend WithEvents btnVorige As System.Windows.Forms.Button
    Friend WithEvents btnGewogen As System.Windows.Forms.Button
    Friend WithEvents ChkExclude As System.Windows.Forms.CheckBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnrandomtimer As System.Windows.Forms.Button
    Friend WithEvents lbltijd As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbltijd2 As System.Windows.Forms.Label
    Friend WithEvents btntimer2 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
