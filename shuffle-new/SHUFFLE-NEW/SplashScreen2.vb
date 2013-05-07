Public NotInheritable Class SplashScreen2

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'method ini digunakan untuk fungsi loading, dimana batas akhir progres bar dibuat 120, dengan penambahan 4
        ProgressBar1.Value += 4
        If ProgressBar1.Value = 120 Then
            Timer1.Dispose()
            'form splash screen dibuat tidak tampak
            Me.Visible() = False
            End 'fungsi untuk mengakhiri program yang sedang berjalan
        End If
    End Sub
End Class
