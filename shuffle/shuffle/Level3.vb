Public Class Level3

    Public count As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' button 2, 6 
        CheckButton(Butt1:=Button1, Butt2:=Button2)
        CheckButton(Butt1:=Button1, Butt2:=Button6)

        checkSolvedLevel3()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' button 1, 7, 3
        CheckButton(Butt1:=Button2, Butt2:=Button1)
        CheckButton(Butt1:=Button2, Butt2:=Button7)
        CheckButton(Butt1:=Button2, Butt2:=Button3)

        checkSolvedLevel3()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' button 2, 8, 4
        CheckButton(Butt1:=Button3, Butt2:=Button2)
        CheckButton(Butt1:=Button3, Butt2:=Button8)
        CheckButton(Butt1:=Button3, Butt2:=Button4)

        checkSolvedLevel3()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' button 3, 9, 5
        CheckButton(Butt1:=Button4, Butt2:=Button3)
        CheckButton(Butt1:=Button4, Butt2:=Button9)
        CheckButton(Butt1:=Button4, Butt2:=Button5)

        checkSolvedLevel3()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ' button 4, 10
        CheckButton(Butt1:=Button5, Butt2:=Button4)
        CheckButton(Butt1:=Button5, Butt2:=Button10)
        
        checkSolvedLevel3()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ' button 1, 7, 11
        CheckButton(Butt1:=Button6, Butt2:=Button1)
        CheckButton(Butt1:=Button6, Butt2:=Button7)
        CheckButton(Butt1:=Button6, Butt2:=Button11)
        
        checkSolvedLevel3()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ' button 2, 6, 8, 12
        CheckButton(Butt1:=Button7, Butt2:=Button2)
        CheckButton(Butt1:=Button7, Butt2:=Button6)
        CheckButton(Butt1:=Button7, Butt2:=Button8)
        CheckButton(Butt1:=Button7, Butt2:=Button12)

        checkSolvedLevel3()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ' button 3, 7, 9, 13
        CheckButton(Butt1:=Button8, Butt2:=Button3)
        CheckButton(Butt1:=Button8, Butt2:=Button7)
        CheckButton(Butt1:=Button8, Butt2:=Button9)
        CheckButton(Butt1:=Button8, Butt2:=Button13)

        checkSolvedLevel3()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ' button 4, 8, 10, 14
        CheckButton(Butt1:=Button9, Butt2:=Button4)
        CheckButton(Butt1:=Button9, Butt2:=Button8)
        CheckButton(Butt1:=Button9, Butt2:=Button10)
        CheckButton(Butt1:=Button9, Butt2:=Button14)

        checkSolvedLevel3()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ' button 5, 9, 15
        CheckButton(Butt1:=Button10, Butt2:=Button5)
        CheckButton(Butt1:=Button10, Butt2:=Button9)
        CheckButton(Butt1:=Button10, Butt2:=Button15)

        checkSolvedLevel3()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ' button 6, 12, 16
        CheckButton(Butt1:=Button11, Butt2:=Button6)
        CheckButton(Butt1:=Button11, Butt2:=Button12)
        CheckButton(Butt1:=Button11, Butt2:=Button16)
       
        checkSolvedLevel3()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ' button 7, 11, 13, 17
        CheckButton(Butt1:=Button12, Butt2:=Button7)
        CheckButton(Butt1:=Button12, Butt2:=Button11)
        CheckButton(Butt1:=Button12, Butt2:=Button13)
        CheckButton(Butt1:=Button12, Butt2:=Button17)

        checkSolvedLevel3()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ' button 8, 12, 14, 18
        CheckButton(Butt1:=Button13, Butt2:=Button8)
        CheckButton(Butt1:=Button13, Butt2:=Button12)
        CheckButton(Butt1:=Button13, Butt2:=Button14)
        CheckButton(Butt1:=Button13, Butt2:=Button18)

        checkSolvedLevel3()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        ' button 9, 13, 15, 19
        CheckButton(Butt1:=Button14, Butt2:=Button9)
        CheckButton(Butt1:=Button14, Butt2:=Button13)
        CheckButton(Butt1:=Button14, Butt2:=Button15)
        CheckButton(Butt1:=Button14, Butt2:=Button19)

        checkSolvedLevel3()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        ' button 10, 14, 20
        CheckButton(Butt1:=Button15, Butt2:=Button10)
        CheckButton(Butt1:=Button15, Butt2:=Button14)
        CheckButton(Butt1:=Button15, Butt2:=Button20)

        checkSolvedLevel3()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        ' button 11, 17, 21
        CheckButton(Butt1:=Button16, Butt2:=Button11)
        CheckButton(Butt1:=Button16, Butt2:=Button17)
        CheckButton(Butt1:=Button16, Butt2:=Button21)

        checkSolvedLevel3()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        ' button 12, 16, 18, 22
        CheckButton(Butt1:=Button17, Butt2:=Button12)
        CheckButton(Butt1:=Button17, Butt2:=Button16)
        CheckButton(Butt1:=Button17, Butt2:=Button18)
        CheckButton(Butt1:=Button17, Butt2:=Button22)

        checkSolvedLevel3()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        ' button 13, 17, 19, 23
        CheckButton(Butt1:=Button18, Butt2:=Button13)
        CheckButton(Butt1:=Button18, Butt2:=Button17)
        CheckButton(Butt1:=Button18, Butt2:=Button19)
        CheckButton(Butt1:=Button18, Butt2:=Button23)

        checkSolvedLevel3()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        ' button 14, 18, 20 24
        CheckButton(Butt1:=Button19, Butt2:=Button14)
        CheckButton(Butt1:=Button19, Butt2:=Button18)
        CheckButton(Butt1:=Button19, Butt2:=Button20)
        CheckButton(Butt1:=Button19, Butt2:=Button24)

        checkSolvedLevel3()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        ' button 15, 19, 25
        CheckButton(Butt1:=Button20, Butt2:=Button15)
        CheckButton(Butt1:=Button20, Butt2:=Button19)
        CheckButton(Butt1:=Button20, Butt2:=Button25)

        checkSolvedLevel3()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        ' button 16, 22
        CheckButton(Butt1:=Button21, Butt2:=Button16)
        CheckButton(Butt1:=Button21, Butt2:=Button22)

        checkSolvedLevel3()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        ' button 17, 21, 23
        CheckButton(Butt1:=Button22, Butt2:=Button17)
        CheckButton(Butt1:=Button22, Butt2:=Button21)
        CheckButton(Butt1:=Button22, Butt2:=Button23)

        checkSolvedLevel3()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        ' button 18, 22, 24
        CheckButton(Butt1:=Button23, Butt2:=Button18)
        CheckButton(Butt1:=Button23, Butt2:=Button22)
        CheckButton(Butt1:=Button23, Butt2:=Button24)

        checkSolvedLevel3()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        ' button 19, 23, 25
        CheckButton(Butt1:=Button24, Butt2:=Button19)
        CheckButton(Butt1:=Button24, Butt2:=Button23)
        CheckButton(Butt1:=Button24, Butt2:=Button25)

        checkSolvedLevel3()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        ' button 20, 24
        CheckButton(Butt1:=Button25, Butt2:=Button20)
        CheckButton(Butt1:=Button25, Butt2:=Button24)

        checkSolvedLevel3()
    End Sub

    Private Sub Level3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shuffleLevel3()
    End Sub

End Class