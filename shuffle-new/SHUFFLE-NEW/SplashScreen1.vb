Public NotInheritable Class SplashScreen1
    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint
        Timer1.Enabled = True
    End Sub

    'method ini digunakan untuk fungsi loading, dimana batas akhir progres bar dibuat 120, dengan penambahan 1.5
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1.5
        If ProgressBar1.Value = 120 Then
            Timer1.Dispose()
            'form splash screen dibuat tidak tampak
            Me.Visible() = False
            Form1.Show()  'memanggil class LoginForm
        End If
    End Sub

End Class
