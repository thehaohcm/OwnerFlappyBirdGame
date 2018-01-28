Public Class Form1
    Dim yspeed As Integer = 0
    Dim gravity As Integer = 1
    Dim Score As Integer = 0
    Dim BegPos As Integer = 53 + 175 + 53 + 175
    Dim SpeedRun As Integer = 4
    Dim Jump As Integer = 15
    Dim box() As Object = {OngDuoi1, OngDuoi2, OngDuoi3, OngTren1, OngTren2, OngTren3, wall}

    Private Sub load()
        OngDuoi1.Enabled = False
        OngDuoi2.Enabled = False
        OngDuoi3.Enabled = False
        OngTren1.Enabled = False
        OngTren2.Enabled = False
        OngTren3.Enabled = False
        wall.Enabled = False
        Bird.Enabled = False

        Bird.Image = My.Resources.favicon

        OngDuoi1.Left = 250 + 53
        OngTren1.Left = OngDuoi1.Left

        OngDuoi2.Left = 250 + 53 + 175
        OngTren2.Left = OngDuoi2.Left

        OngDuoi3.Left = 250 + 53 + 175 + 175
        OngTren3.Left = OngDuoi3.Left

        Label2.Show()
        Bird.Top = 184
        'Label2.Hide()

        Score = 0

        Timer2.Enabled = False
        Timer1.Enabled = False

        Score = 0
        X.Text = "Điểm: 0"

        gravity = 1
        yspeed = 0

        RandHeightOng(OngTren1, OngDuoi1)
        RandHeightOng(OngTren2, OngDuoi2)
        RandHeightOng(OngTren3, OngDuoi3)

        Timer3.Enabled = False
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        AboutBox1.Close()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            If Timer1.Enabled = False Then
                Timer1.Enabled = True
                Timer2.Enabled = True
                Label2.Hide()
            Else
                yspeed -= Jump
            End If
        End If
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If (Timer1.Enabled = False) Then
            Timer1.Enabled = True
            Timer2.Enabled = True
            Label2.Hide()
        Else
            yspeed -= Jump
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OngDuoi1.Enabled = False
        OngDuoi2.Enabled = False
        OngDuoi3.Enabled = False
        OngTren1.Enabled = False
        OngTren2.Enabled = False
        OngTren3.Enabled = False
        wall.Enabled = False
        Bird.Enabled = False

        'Bird.BackgroundImage = Me.BackgroundImage

        Timer2.Enabled = False
        Timer1.Enabled = False

        load()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dung()

        OngTren1.Left -= SpeedRun
        OngDuoi1.Left = OngTren1.Left

        OngTren2.Left -= SpeedRun
        OngDuoi2.Left = OngTren2.Left

        OngTren3.Left -= SpeedRun
        OngDuoi3.Left = OngTren3.Left

        If (OngTren1.Right <= 0) Then
            OngTren1.Left = BegPos
            OngDuoi1.Left = BegPos
            RandHeightOng(OngTren1, OngDuoi1)
        End If

        If (OngTren2.Right <= 0) Then
            OngTren2.Left = BegPos
            OngDuoi2.Left = BegPos
            RandHeightOng(OngTren2, OngDuoi2)
        End If

        If (OngTren3.Right <= 0) Then
            OngTren3.Left = BegPos
            OngDuoi3.Left = BegPos
            RandHeightOng(OngTren3, OngDuoi3)
        End If
            
        Bird.Top += yspeed
        yspeed += gravity

        'If OngDuoi1.Right <= 2 Or OngDuoi2.Right <= 2 Or OngDuoi3.Right <= 2 Then
        '    Timer2.Enabled = True
        'End If

        
    End Sub

    Private Sub RandHeightOng(ByVal Pic1 As PictureBox, ByVal Pic2 As PictureBox)
        'Pic1 là ống trên
        'Pic2 là ống dưới

        Pic2.Top = 70 + 290 * Rnd()
        If Pic2.Top < 125 Then
            RandHeightOng(Pic1, Pic2)
        End If
        Pic1.Top = Pic2.Top - 420

        GhiDiem()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        GhiDiem()
    End Sub

    Private Function KTDung(ByVal Object_ As Object) As Boolean
        Dim codung As Boolean = False
        If Bird.Top + Bird.Height - 5 >= Object_.top And _
            Object_.top + Object_.Height >= Bird.Top And _
            Bird.Left + Bird.Width - 5 >= Object_.left And _
            Object_.left + Object_.width >= Bird.Left + 5 And Bird.Visible = True And Object_.visible = True Then
            codung = True
        End If
        Return codung
    End Function

    Private Sub Dung()
        If KTDung(OngDuoi1) Or KTDung(OngDuoi2) Or KTDung(OngDuoi3) Or KTDung(OngTren1) Or KTDung(OngTren2) Or KTDung(OngTren3) Or KTDung(wall) Then
            Dim a
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = True
            a = MessageBox.Show("Trò chơi kết thúc" & vbNewLine & vbNewLine & "Số điểm: " & Score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If a = vbOK Then
                load()
            End If
        End If
    End Sub

    Private Function TestGhiDiem(ByVal Object_ As Object) As Boolean
        'Object_ là ống nước
        'If Object_.location.x >= 0 And Object_.location.x <= 5 Then 'Bird.Location.X <= Object_.location.x+1 And Bird.Location.X >= Object_.location.x - 1 Then
        '    Return True
        'End If

        If Object_.location.x >= 0 And Object_.location.x <= Bird.Location.X + 5 Then
            Return True
            'Timer2.Enabled = False
        End If
        Return False
    End Function

    Private Sub GhiDiem()
        If TestGhiDiem(OngDuoi1) Or TestGhiDiem(OngDuoi2) Or TestGhiDiem(OngDuoi3) Then 'Or TestGhiDiem(OngTren1) Or TestGhiDiem(OngTren2) Or TestGhiDiem(OngTren3) Then
            Score += 1
            X.Text = "Điểm: " + Score.ToString
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Bird.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        If Bird.Top + Bird.Height < wall.Top Then
            Bird.Top += 8
        End If

        
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If OngDuoi1.Location.X < 0 Or OngDuoi2.Location.X < 0 Or OngDuoi3.Location.X < 0 Then
            Timer2.Enabled = True
        End If

        If Bird.Top < 3 Then
            Jump = -1
            Bird.Top = 3
        Else
            Jump = 15
        End If
    End Sub
End Class
