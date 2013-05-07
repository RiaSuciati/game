Public Class Form2

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        easy_mode.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        medium_mode.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        hard_mode.Show()
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