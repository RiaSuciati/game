Public Class highscore

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Visible() = False
        Form1.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim keluar As String
        'hasil jawaban pertanyaan disimpan dalam variabel keluar
        keluar = MessageBox.Show("Do you really want to quit ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'Jika variabel keluar sama dengan 'Yes' maka proses running program akan dihentikan (dengan menggunakan fungsi 'END")
        If keluar = vbYes Then
            Me.Visible = False
            SplashScreen2.Show()
        End If
    End Sub
End Class