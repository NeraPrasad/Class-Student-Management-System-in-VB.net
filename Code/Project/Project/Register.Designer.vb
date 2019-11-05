<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnSingUP = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtPassword.HintText = "Type Your Password"
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.txtPassword.LineThickness = 3
        Me.txtPassword.Location = New System.Drawing.Point(248, 319)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(379, 33)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUser.HintForeColor = System.Drawing.Color.Empty
        Me.txtUser.HintText = "Type Your User Name"
        Me.txtUser.isPassword = False
        Me.txtUser.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtUser.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUser.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.txtUser.LineThickness = 3
        Me.txtUser.Location = New System.Drawing.Point(248, 241)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(379, 33)
        Me.txtUser.TabIndex = 5
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSingUP
        '
        Me.btnSingUP.ActiveBorderThickness = 1
        Me.btnSingUP.ActiveCornerRadius = 20
        Me.btnSingUP.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnSingUP.ActiveForecolor = System.Drawing.Color.White
        Me.btnSingUP.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnSingUP.BackColor = System.Drawing.SystemColors.Control
        Me.btnSingUP.BackgroundImage = CType(resources.GetObject("btnSingUP.BackgroundImage"), System.Drawing.Image)
        Me.btnSingUP.ButtonText = "Sing Up"
        Me.btnSingUP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSingUP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSingUP.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSingUP.IdleBorderThickness = 1
        Me.btnSingUP.IdleCornerRadius = 20
        Me.btnSingUP.IdleFillColor = System.Drawing.Color.White
        Me.btnSingUP.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnSingUP.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnSingUP.Location = New System.Drawing.Point(308, 401)
        Me.btnSingUP.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSingUP.Name = "btnSingUP"
        Me.btnSingUP.Size = New System.Drawing.Size(265, 41)
        Me.btnSingUP.TabIndex = 7
        Me.btnSingUP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Location = New System.Drawing.Point(808, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(30, 30)
        Me.lblClose.TabIndex = 12
        Me.lblClose.Text = "X"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Project.My.Resources.Resources._123
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(326, 54)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(226, 147)
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 46)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Register"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 473)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Log In"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 500)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.btnSingUP)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnSingUP As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
