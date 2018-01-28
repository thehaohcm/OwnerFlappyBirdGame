<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bird = New System.Windows.Forms.PictureBox()
        Me.OngDuoi1 = New System.Windows.Forms.PictureBox()
        Me.OngTren1 = New System.Windows.Forms.PictureBox()
        Me.OngTren2 = New System.Windows.Forms.PictureBox()
        Me.OngDuoi2 = New System.Windows.Forms.PictureBox()
        Me.OngTren3 = New System.Windows.Forms.PictureBox()
        Me.OngDuoi3 = New System.Windows.Forms.PictureBox()
        Me.wall = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.X = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OngDuoi1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OngTren1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OngTren2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OngDuoi2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OngTren3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OngDuoi3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Bird
        '
        Me.Bird.BackColor = System.Drawing.Color.Transparent
        Me.Bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Bird.Image = Global.FlappyBird.My.Resources.Resources.favicon
        Me.Bird.InitialImage = Nothing
        Me.Bird.Location = New System.Drawing.Point(12, 184)
        Me.Bird.Name = "Bird"
        Me.Bird.Size = New System.Drawing.Size(44, 35)
        Me.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Bird.TabIndex = 0
        Me.Bird.TabStop = False
        '
        'OngDuoi1
        '
        Me.OngDuoi1.BackgroundImage = CType(resources.GetObject("OngDuoi1.BackgroundImage"), System.Drawing.Image)
        Me.OngDuoi1.Image = Global.FlappyBird.My.Resources.Resources.Ong_Tren
        Me.OngDuoi1.Location = New System.Drawing.Point(48, 258)
        Me.OngDuoi1.Name = "OngDuoi1"
        Me.OngDuoi1.Size = New System.Drawing.Size(53, 323)
        Me.OngDuoi1.TabIndex = 1
        Me.OngDuoi1.TabStop = False
        '
        'OngTren1
        '
        Me.OngTren1.BackgroundImage = CType(resources.GetObject("OngTren1.BackgroundImage"), System.Drawing.Image)
        Me.OngTren1.Image = Global.FlappyBird.My.Resources.Resources.Ong_Duoi
        Me.OngTren1.Location = New System.Drawing.Point(48, -174)
        Me.OngTren1.Name = "OngTren1"
        Me.OngTren1.Size = New System.Drawing.Size(53, 320)
        Me.OngTren1.TabIndex = 2
        Me.OngTren1.TabStop = False
        '
        'OngTren2
        '
        Me.OngTren2.BackgroundImage = CType(resources.GetObject("OngTren2.BackgroundImage"), System.Drawing.Image)
        Me.OngTren2.Image = Global.FlappyBird.My.Resources.Resources.Ong_Duoi
        Me.OngTren2.Location = New System.Drawing.Point(141, -174)
        Me.OngTren2.Name = "OngTren2"
        Me.OngTren2.Size = New System.Drawing.Size(53, 320)
        Me.OngTren2.TabIndex = 4
        Me.OngTren2.TabStop = False
        '
        'OngDuoi2
        '
        Me.OngDuoi2.BackgroundImage = CType(resources.GetObject("OngDuoi2.BackgroundImage"), System.Drawing.Image)
        Me.OngDuoi2.Image = Global.FlappyBird.My.Resources.Resources.Ong_Tren
        Me.OngDuoi2.Location = New System.Drawing.Point(141, 258)
        Me.OngDuoi2.Name = "OngDuoi2"
        Me.OngDuoi2.Size = New System.Drawing.Size(53, 323)
        Me.OngDuoi2.TabIndex = 3
        Me.OngDuoi2.TabStop = False
        '
        'OngTren3
        '
        Me.OngTren3.BackgroundImage = CType(resources.GetObject("OngTren3.BackgroundImage"), System.Drawing.Image)
        Me.OngTren3.Image = Global.FlappyBird.My.Resources.Resources.Ong_Duoi
        Me.OngTren3.Location = New System.Drawing.Point(236, -174)
        Me.OngTren3.Name = "OngTren3"
        Me.OngTren3.Size = New System.Drawing.Size(53, 320)
        Me.OngTren3.TabIndex = 6
        Me.OngTren3.TabStop = False
        '
        'OngDuoi3
        '
        Me.OngDuoi3.BackgroundImage = CType(resources.GetObject("OngDuoi3.BackgroundImage"), System.Drawing.Image)
        Me.OngDuoi3.Image = Global.FlappyBird.My.Resources.Resources.Ong_Tren
        Me.OngDuoi3.Location = New System.Drawing.Point(236, 258)
        Me.OngDuoi3.Name = "OngDuoi3"
        Me.OngDuoi3.Size = New System.Drawing.Size(53, 323)
        Me.OngDuoi3.TabIndex = 5
        Me.OngDuoi3.TabStop = False
        '
        'wall
        '
        Me.wall.Image = Global.FlappyBird.My.Resources.Resources.Flappy_Ground
        Me.wall.Location = New System.Drawing.Point(-3, 397)
        Me.wall.Name = "wall"
        Me.wall.Size = New System.Drawing.Size(292, 113)
        Me.wall.TabIndex = 7
        Me.wall.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(86, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 47)
        Me.Label2.TabIndex = 10
        Me.Label2.Tag = ""
        Me.Label2.Text = "  Dùng phím space hoặc     chuột để điều khiển"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowMerge = False
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.X})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 488)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(288, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'X
        '
        Me.X.BackColor = System.Drawing.Color.Transparent
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(121, 17)
        Me.X.Text = "ToolStripStatusLabel1"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Interval = 40
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.FlappyBird.My.Resources.Resources.Back_Ground
        Me.ClientSize = New System.Drawing.Size(288, 510)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.wall)
        Me.Controls.Add(Me.OngTren3)
        Me.Controls.Add(Me.OngDuoi3)
        Me.Controls.Add(Me.OngTren2)
        Me.Controls.Add(Me.OngDuoi2)
        Me.Controls.Add(Me.OngTren1)
        Me.Controls.Add(Me.OngDuoi1)
        Me.Controls.Add(Me.Bird)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Flappy Bird (Windows) @NTH"
        CType(Me.Bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OngDuoi1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OngTren1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OngTren2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OngDuoi2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OngTren3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OngDuoi3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Bird As System.Windows.Forms.PictureBox
    Friend WithEvents OngDuoi1 As System.Windows.Forms.PictureBox
    Friend WithEvents OngTren1 As System.Windows.Forms.PictureBox
    Friend WithEvents OngTren2 As System.Windows.Forms.PictureBox
    Friend WithEvents OngDuoi2 As System.Windows.Forms.PictureBox
    Friend WithEvents OngTren3 As System.Windows.Forms.PictureBox
    Friend WithEvents OngDuoi3 As System.Windows.Forms.PictureBox
    Friend WithEvents wall As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents X As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer

End Class
