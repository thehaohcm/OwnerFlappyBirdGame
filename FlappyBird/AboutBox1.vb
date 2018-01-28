Public NotInheritable Class AboutBox1
    Dim second As Integer = 5
    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Value += 5
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer2.Enabled = False
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("mailto:thehaohcm@yahoo.com.vn")
    End Sub
End Class
