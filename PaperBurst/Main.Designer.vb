<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Generate = New System.Windows.Forms.Button()
        Me.Passphrase = New System.Windows.Forms.TextBox()
        Me.GeneratePassphrase = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.revealPK = New System.Windows.Forms.PictureBox()
        Me.revealPwd = New System.Windows.Forms.PictureBox()
        Me.Recalculate = New System.Windows.Forms.Button()
        Me.ReedSolomonAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrivateKey1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PublicKey1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.revealPK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.revealPwd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generate
        '
        Me.Generate.Location = New System.Drawing.Point(832, 480)
        Me.Generate.Name = "Generate"
        Me.Generate.Size = New System.Drawing.Size(327, 83)
        Me.Generate.TabIndex = 8
        Me.Generate.Text = "Generate Paper Wallet !"
        Me.Generate.UseVisualStyleBackColor = True
        '
        'Passphrase
        '
        Me.Passphrase.Location = New System.Drawing.Point(227, 110)
        Me.Passphrase.Multiline = True
        Me.Passphrase.Name = "Passphrase"
        Me.Passphrase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passphrase.Size = New System.Drawing.Size(860, 42)
        Me.Passphrase.TabIndex = 15
        Me.Passphrase.WordWrap = False
        '
        'GeneratePassphrase
        '
        Me.GeneratePassphrase.Location = New System.Drawing.Point(33, 480)
        Me.GeneratePassphrase.Name = "GeneratePassphrase"
        Me.GeneratePassphrase.Size = New System.Drawing.Size(327, 83)
        Me.GeneratePassphrase.TabIndex = 17
        Me.GeneratePassphrase.Text = "Generate New Passphrase !"
        Me.GeneratePassphrase.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.revealPK)
        Me.GroupBox1.Controls.Add(Me.revealPwd)
        Me.GroupBox1.Controls.Add(Me.Recalculate)
        Me.GroupBox1.Controls.Add(Me.ReedSolomonAddress)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PrivateKey1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PublicKey1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Generate)
        Me.GroupBox1.Controls.Add(Me.GeneratePassphrase)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Passphrase)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1190, 588)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'revealPK
        '
        Me.revealPK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.revealPK.Image = CType(resources.GetObject("revealPK.Image"), System.Drawing.Image)
        Me.revealPK.Location = New System.Drawing.Point(1113, 197)
        Me.revealPK.Margin = New System.Windows.Forms.Padding(6)
        Me.revealPK.Name = "revealPK"
        Me.revealPK.Size = New System.Drawing.Size(46, 42)
        Me.revealPK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.revealPK.TabIndex = 29
        Me.revealPK.TabStop = False
        '
        'revealPwd
        '
        Me.revealPwd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.revealPwd.Image = CType(resources.GetObject("revealPwd.Image"), System.Drawing.Image)
        Me.revealPwd.Location = New System.Drawing.Point(1113, 110)
        Me.revealPwd.Margin = New System.Windows.Forms.Padding(6)
        Me.revealPwd.Name = "revealPwd"
        Me.revealPwd.Size = New System.Drawing.Size(46, 42)
        Me.revealPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.revealPwd.TabIndex = 28
        Me.revealPwd.TabStop = False
        '
        'Recalculate
        '
        Me.Recalculate.Location = New System.Drawing.Point(433, 480)
        Me.Recalculate.Name = "Recalculate"
        Me.Recalculate.Size = New System.Drawing.Size(327, 83)
        Me.Recalculate.TabIndex = 24
        Me.Recalculate.Text = "Calculate PublicKey, PrivateKey, RS"
        Me.Recalculate.UseVisualStyleBackColor = True
        '
        'ReedSolomonAddress
        '
        Me.ReedSolomonAddress.BackColor = System.Drawing.SystemColors.Control
        Me.ReedSolomonAddress.Location = New System.Drawing.Point(227, 370)
        Me.ReedSolomonAddress.Multiline = True
        Me.ReedSolomonAddress.Name = "ReedSolomonAddress"
        Me.ReedSolomonAddress.ReadOnly = True
        Me.ReedSolomonAddress.Size = New System.Drawing.Size(932, 42)
        Me.ReedSolomonAddress.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Reed Solomon:"
        '
        'PrivateKey1
        '
        Me.PrivateKey1.BackColor = System.Drawing.SystemColors.Control
        Me.PrivateKey1.Location = New System.Drawing.Point(227, 197)
        Me.PrivateKey1.Multiline = True
        Me.PrivateKey1.Name = "PrivateKey1"
        Me.PrivateKey1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PrivateKey1.ReadOnly = True
        Me.PrivateKey1.Size = New System.Drawing.Size(860, 42)
        Me.PrivateKey1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Private Key:"
        '
        'PublicKey1
        '
        Me.PublicKey1.BackColor = System.Drawing.SystemColors.Control
        Me.PublicKey1.Location = New System.Drawing.Point(227, 286)
        Me.PublicKey1.Multiline = True
        Me.PublicKey1.Name = "PublicKey1"
        Me.PublicKey1.ReadOnly = True
        Me.PublicKey1.Size = New System.Drawing.Size(932, 42)
        Me.PublicKey1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Public Key:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Passphrase:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(371, 58)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(116, 29)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "24 words"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(227, 56)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(116, 29)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "12 words"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Number of words:"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1237, 641)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.Text = "PaperBurst - Offline Paper Wallet Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.revealPK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.revealPwd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Generate As Button
    Friend WithEvents Passphrase As TextBox
    Friend WithEvents GeneratePassphrase As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PrivateKey1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PublicKey1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ReedSolomonAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Recalculate As Button
    Friend WithEvents revealPK As PictureBox
    Friend WithEvents revealPwd As PictureBox
End Class
