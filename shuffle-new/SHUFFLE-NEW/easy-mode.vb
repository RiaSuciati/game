Public Class easy_mode

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form2.Show()
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

    Public count As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' button 2, 4 
        CheckButton(Butt1:=Button1, Butt2:=Button2)
        CheckButton(Butt1:=Button1, Butt2:=Button4)

        CheckSolvedeasy_mode()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' button 1, 3 , 5
        CheckButton(Butt1:=Button2, Butt2:=Button1)
        CheckButton(Butt1:=Button2, Butt2:=Button3)
        CheckButton(Butt1:=Button2, Butt2:=Button5)

        CheckSolvedeasy_mode()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' button 2, 6
        CheckButton(Butt1:=Button3, Butt2:=Button2)
        CheckButton(Butt1:=Button3, Butt2:=Button6)

        CheckSolvedeasy_mode()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' button 1, 5, 7
        CheckButton(Butt1:=Button4, Butt2:=Button1)
        CheckButton(Butt1:=Button4, Butt2:=Button5)
        CheckButton(Butt1:=Button4, Butt2:=Button7)

        CheckSolvedeasy_mode()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ' button 2, 4, 6, 8
        CheckButton(Butt1:=Button5, Butt2:=Button2)
        CheckButton(Butt1:=Button5, Butt2:=Button4)
        CheckButton(Butt1:=Button5, Butt2:=Button6)
        CheckButton(Butt1:=Button5, Butt2:=Button8)

        CheckSolvedeasy_mode()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ' button 3, 5, ""
        CheckButton(Butt1:=Button6, Butt2:=Button3)
        CheckButton(Butt1:=Button6, Butt2:=Button5)
        CheckButton(Butt1:=Button6, Butt2:=Button9)

        CheckSolvedeasy_mode()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ' button 4, 8
        CheckButton(Butt1:=Button7, Butt2:=Button4)
        CheckButton(Butt1:=Button7, Butt2:=Button8)

        CheckSolvedeasy_mode()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ' button 7, 5, ""
        CheckButton(Butt1:=Button8, Butt2:=Button7)
        CheckButton(Butt1:=Button8, Butt2:=Button5)
        CheckButton(Butt1:=Button8, Butt2:=Button9)

        CheckSolvedeasy_mode()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ' button 6, 8
        CheckButton(Butt1:=Button9, Butt2:=Button6)
        CheckButton(Butt1:=Button9, Butt2:=Button8)

        CheckSolvedeasy_mode()
    End Sub

    Private Sub easy_mode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shuffleeasy_mode()
    End Sub
End Class