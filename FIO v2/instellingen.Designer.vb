<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instellingen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instellingen))
        Me.txtimages = New System.Windows.Forms.TextBox()
        Me.btnimages = New System.Windows.Forms.Button()
        Me.FolderBrowserImages = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.numupdown = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.updownS = New System.Windows.Forms.NumericUpDown()
        Me.updownD = New System.Windows.Forms.NumericUpDown()
        Me.updownJ = New System.Windows.Forms.NumericUpDown()
        Me.updownC = New System.Windows.Forms.NumericUpDown()
        Me.updownH = New System.Windows.Forms.NumericUpDown()
        Me.updownB = New System.Windows.Forms.NumericUpDown()
        Me.updownF = New System.Windows.Forms.NumericUpDown()
        Me.updownA = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rndmin = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rndmax = New System.Windows.Forms.NumericUpDown()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btnAddCards = New System.Windows.Forms.Button()
        Me.OpenFileNewCards = New System.Windows.Forms.OpenFileDialog()
        CType(Me.numupdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.updownS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rndmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rndmax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtimages
        '
        Me.txtimages.Location = New System.Drawing.Point(118, 11)
        Me.txtimages.Name = "txtimages"
        Me.txtimages.ReadOnly = True
        Me.txtimages.Size = New System.Drawing.Size(355, 20)
        Me.txtimages.TabIndex = 1
        '
        'btnimages
        '
        Me.btnimages.Location = New System.Drawing.Point(12, 9)
        Me.btnimages.Name = "btnimages"
        Me.btnimages.Size = New System.Drawing.Size(100, 23)
        Me.btnimages.TabIndex = 0
        Me.btnimages.Text = "Cards Location"
        Me.btnimages.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(12, 303)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "B:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "D:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "C:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "H:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "F:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(103, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "S:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(103, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "J:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Minimum cards untill C-card:"
        '
        'numupdown
        '
        Me.numupdown.Location = New System.Drawing.Point(161, 217)
        Me.numupdown.Name = "numupdown"
        Me.numupdown.Size = New System.Drawing.Size(40, 20)
        Me.numupdown.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.updownS)
        Me.GroupBox1.Controls.Add(Me.updownD)
        Me.GroupBox1.Controls.Add(Me.updownJ)
        Me.GroupBox1.Controls.Add(Me.updownC)
        Me.GroupBox1.Controls.Add(Me.updownH)
        Me.GroupBox1.Controls.Add(Me.updownB)
        Me.GroupBox1.Controls.Add(Me.updownF)
        Me.GroupBox1.Controls.Add(Me.updownA)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 158)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Odds:"
        '
        'updownS
        '
        Me.updownS.Location = New System.Drawing.Point(126, 111)
        Me.updownS.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.updownS.Name = "updownS"
        Me.updownS.Size = New System.Drawing.Size(52, 20)
        Me.updownS.TabIndex = 7
        '
        'updownD
        '
        Me.updownD.Location = New System.Drawing.Point(30, 111)
        Me.updownD.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.updownD.Name = "updownD"
        Me.updownD.Size = New System.Drawing.Size(52, 20)
        Me.updownD.TabIndex = 3
        '
        'updownJ
        '
        Me.updownJ.Location = New System.Drawing.Point(126, 84)
        Me.updownJ.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.updownJ.Name = "updownJ"
        Me.updownJ.Size = New System.Drawing.Size(52, 20)
        Me.updownJ.TabIndex = 6
        '
        'updownC
        '
        Me.updownC.Location = New System.Drawing.Point(29, 84)
        Me.updownC.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.updownC.Name = "updownC"
        Me.updownC.Size = New System.Drawing.Size(52, 20)
        Me.updownC.TabIndex = 2
        '
        'updownH
        '
        Me.updownH.Location = New System.Drawing.Point(127, 59)
        Me.updownH.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.updownH.Name = "updownH"
        Me.updownH.Size = New System.Drawing.Size(52, 20)
        Me.updownH.TabIndex = 5
        '
        'updownB
        '
        Me.updownB.Location = New System.Drawing.Point(29, 59)
        Me.updownB.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.updownB.Name = "updownB"
        Me.updownB.Size = New System.Drawing.Size(52, 20)
        Me.updownB.TabIndex = 1
        '
        'updownF
        '
        Me.updownF.Location = New System.Drawing.Point(126, 33)
        Me.updownF.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.updownF.Name = "updownF"
        Me.updownF.Size = New System.Drawing.Size(52, 20)
        Me.updownF.TabIndex = 4
        '
        'updownA
        '
        Me.updownA.Location = New System.Drawing.Point(29, 33)
        Me.updownA.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.updownA.Name = "updownA"
        Me.updownA.Size = New System.Drawing.Size(52, 20)
        Me.updownA.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Random timer minimum time:"
        '
        'rndmin
        '
        Me.rndmin.Location = New System.Drawing.Point(162, 244)
        Me.rndmin.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.rndmin.Name = "rndmin"
        Me.rndmin.Size = New System.Drawing.Size(40, 20)
        Me.rndmin.TabIndex = 4
        Me.rndmin.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 278)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Random timer maximum time:"
        '
        'rndmax
        '
        Me.rndmax.Location = New System.Drawing.Point(162, 271)
        Me.rndmax.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.rndmax.Name = "rndmax"
        Me.rndmax.Size = New System.Drawing.Size(40, 20)
        Me.rndmax.TabIndex = 5
        Me.rndmax.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(223, 83)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(63, 13)
        Me.lbltotal.TabIndex = 28
        Me.lbltotal.Text = "Total odds: "
        '
        'btnAddCards
        '
        Me.btnAddCards.Location = New System.Drawing.Point(226, 303)
        Me.btnAddCards.Name = "btnAddCards"
        Me.btnAddCards.Size = New System.Drawing.Size(97, 23)
        Me.btnAddCards.TabIndex = 29
        Me.btnAddCards.Text = "Add new cards"
        Me.btnAddCards.UseVisualStyleBackColor = True
        Me.btnAddCards.Visible = False
        '
        'OpenFileNewCards
        '
        Me.OpenFileNewCards.Filter = """JPEG *.jpg|*.jpg|Bitmap *.bmp|*.bmp|GIF *.gif|*.gif"""
        '
        'instellingen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 357)
        Me.Controls.Add(Me.btnAddCards)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.rndmax)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.rndmin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.numupdown)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtimages)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnimages)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "instellingen"
        Me.Text = "Settings"
        CType(Me.numupdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.updownS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rndmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rndmax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtimages As System.Windows.Forms.TextBox
    Friend WithEvents btnimages As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserImages As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents numupdown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rndmin As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rndmax As System.Windows.Forms.NumericUpDown
    Friend WithEvents updownS As System.Windows.Forms.NumericUpDown
    Friend WithEvents updownD As System.Windows.Forms.NumericUpDown
    Friend WithEvents updownJ As System.Windows.Forms.NumericUpDown
    Friend WithEvents updownC As System.Windows.Forms.NumericUpDown
    Friend WithEvents updownH As System.Windows.Forms.NumericUpDown
    Friend WithEvents updownB As System.Windows.Forms.NumericUpDown
    Friend WithEvents updownF As System.Windows.Forms.NumericUpDown
    Friend WithEvents updownA As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents btnAddCards As System.Windows.Forms.Button
    Friend WithEvents OpenFileNewCards As System.Windows.Forms.OpenFileDialog
End Class
