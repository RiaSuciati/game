Public Class medium_mode

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
        ' button 2, 5 
        CheckButton(Butt1:=Button1, Butt2:=Button2)
        CheckButton(Butt1:=Button1, Butt2:=Button5)

        CheckSolved()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' button 1, 3, 6
        CheckButton(Butt1:=Button2, Butt2:=Button1)
        CheckButton(Butt1:=Button2, Butt2:=Button3)
        CheckButton(Butt1:=Button2, Butt2:=Button6)

        CheckSolved()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' button 2, 4, 7
        CheckButton(Butt1:=Button3, Butt2:=Button2)
        CheckButton(Butt1:=Button3, Butt2:=Button4)
        CheckButton(Butt1:=Button3, Butt2:=Button7)

        CheckSolved()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' button 3, 8
        CheckButton(Butt1:=Button4, Butt2:=Button3)
        CheckButton(Butt1:=Button4, Butt2:=Button8)

        CheckSolved()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ' button 1, 6, 9
        CheckButton(Butt1:=Button5, Butt2:=Button1)
        CheckButton(Butt1:=Button5, Butt2:=Button6)
        CheckButton(Butt1:=Button5, Butt2:=Button9)

        CheckSolved()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ' button 2, 5, 7, 10
        CheckButton(Butt1:=Button6, Butt2:=Button2)
        CheckButton(Butt1:=Button6, Butt2:=Button5)
        CheckButton(Butt1:=Button6, Butt2:=Button7)
        CheckButton(Butt1:=Button6, Butt2:=Button10)

        CheckSolved()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ' button 3, 6, 8, 11
        CheckButton(Butt1:=Button7, Butt2:=Button3)
        CheckButton(Butt1:=Button7, Butt2:=Button6)
        CheckButton(Butt1:=Button7, Butt2:=Button8)
        CheckButton(Butt1:=Button7, Butt2:=Button11)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ' button 4, 7, 12
        CheckButton(Butt1:=Button8, Butt2:=Button4)
        CheckButton(Butt1:=Button8, Butt2:=Button7)
        CheckButton(Butt1:=Button8, Butt2:=Button12)

        CheckSolved()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ' button 5, 10, 13
        CheckButton(Butt1:=Button9, Butt2:=Button5)
        CheckButton(Butt1:=Button9, Butt2:=Button10)
        CheckButton(Butt1:=Button9, Butt2:=Button13)

        CheckSolved()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ' button 6, 9, 11, 14
        CheckButton(Butt1:=Button10, Butt2:=Button6)
        CheckButton(Butt1:=Button10, Butt2:=Button9)
        CheckButton(Butt1:=Button10, Butt2:=Button11)
        CheckButton(Butt1:=Button10, Butt2:=Button14)

        CheckSolved()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ' button 7, 10, 12 , 15
        CheckButton(Butt1:=Button11, Butt2:=Button7)
        CheckButton(Butt1:=Button11, Butt2:=Button10)
        CheckButton(Butt1:=Button11, Butt2:=Button12)
        CheckButton(Butt1:=Button11, Butt2:=Button15)

        CheckSolved()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ' button 8 , 11, 16
        CheckButton(Butt1:=Button12, Butt2:=Button8)
        CheckButton(Butt1:=Button12, Butt2:=Button11)
        CheckButton(Butt1:=Button12, Butt2:=Button16)

        CheckSolved()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ' button 9, 14
        CheckButton(Butt1:=Button13, Butt2:=Button9)
        CheckButton(Butt1:=Button13, Butt2:=Button14)

        CheckSolved()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        ' button 10, 13, 15
        CheckButton(Butt1:=Button14, Butt2:=Button10)
        CheckButton(Butt1:=Button14, Butt2:=Button13)
        CheckButton(Butt1:=Button14, Butt2:=Button15)

        CheckSolved()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        ' button 11, 14
        CheckButton(Butt1:=Button15, Butt2:=Button11)
        CheckButton(Butt1:=Button15, Butt2:=Button14)
        CheckButton(Butt1:=Button15, Butt2:=Button16)

        CheckSolved()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        ' button 12, 15
        CheckButton(Butt1:=Button16, Butt2:=Button12)
        CheckButton(Butt1:=Button16, Butt2:=Button15)

        CheckSolved()
    End Sub

    Private Sub medium_mode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shuffle()
    End Sub
End Class