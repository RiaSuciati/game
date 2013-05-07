Module Module1

    Sub CheckButton(ByRef Butt1 As Button, ByRef Butt2 As Button)
        If Butt2.Text = "" Then
            Butt2.Text = Butt1.Text
            Butt1.Text = ""
        End If
    End Sub

    Sub CheckSolvedeasy_mode()
        If easy_mode.Button1.Text = "1" And easy_mode.Button2.Text = "2" And easy_mode.Button3.Text = "3" And
            easy_mode.Button4.Text = "4" And easy_mode.Button5.Text = "5" And easy_mode.Button6.Text = "6" And
            easy_mode.Button7.Text = "7" And easy_mode.Button8.Text = "8" Then
            youwin.Show()
        End If
        easy_mode.count = easy_mode.count + 1
        easy_mode.TextBox1.Text = easy_mode.count
    End Sub

    Sub shuffleeasy_mode()
        Dim a(8), i, j, RN As Integer
        Dim flag As Boolean

        flag = False
        i = 1
        a(j) = 1

        Do While i <= 8
            Randomize()
            RN = CInt(Int((8 * Rnd())) + 1)

            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next

            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If
            'MessageBox.Show(RN)

        Loop

        easy_mode.Button1.Text = a(1)
        easy_mode.Button2.Text = a(2)
        easy_mode.Button3.Text = a(3)
        easy_mode.Button4.Text = a(4)
        easy_mode.Button5.Text = a(5)

        easy_mode.Button6.Text = a(6)
        easy_mode.Button7.Text = a(7)
        easy_mode.Button8.Text = a(8)
        easy_mode.Button9.Text = ""

    End Sub

    Sub CheckSolved()
        If medium_mode.Button1.Text = "1" And medium_mode.Button2.Text = "2" And medium_mode.Button3.Text = "3" And
            medium_mode.Button4.Text = "4" And medium_mode.Button5.Text = "5" And medium_mode.Button6.Text = "6" And
            medium_mode.Button7.Text = "7" And medium_mode.Button8.Text = "8" And medium_mode.Button9.Text = "9" And
            medium_mode.Button10.Text = "10" And medium_mode.Button11.Text = "11" And medium_mode.Button12.Text = "12" And
            medium_mode.Button13.Text = "13" And medium_mode.Button14.Text = "14" And medium_mode.Button15.Text = "15" Then
            youwin.Show()
        End If
        medium_mode.count = medium_mode.count + 1
        medium_mode.TextBox1.Text = medium_mode.count
    End Sub

    Sub shuffle()
        Dim a(15), i, j, RN As Integer
        Dim flag As Boolean

        flag = False
        i = 1
        a(j) = 1

        Do While i <= 15
            Randomize()
            RN = CInt(Int((15 * Rnd())) + 1)

            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next

            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If
        Loop

        medium_mode.Button1.Text = a(1)
        medium_mode.Button2.Text = a(2)
        medium_mode.Button3.Text = a(3)
        medium_mode.Button4.Text = a(4)
        medium_mode.Button5.Text = a(5)

        medium_mode.Button6.Text = a(6)
        medium_mode.Button7.Text = a(7)
        medium_mode.Button8.Text = a(8)
        medium_mode.Button9.Text = a(9)
        medium_mode.Button10.Text = a(10)

        medium_mode.Button11.Text = a(11)
        medium_mode.Button12.Text = a(12)
        medium_mode.Button13.Text = a(13)
        medium_mode.Button14.Text = a(14)
        medium_mode.Button15.Text = a(15)
        medium_mode.Button16.Text = ""


    End Sub

    Sub checkSolvedhard_mode()
        If hard_mode.Button1.Text = "1" And hard_mode.Button2.Text = "2" And hard_mode.Button3.Text = "3" And
            hard_mode.Button4.Text = "4" And hard_mode.Button5.Text = "5" And hard_mode.Button6.Text = "6" And
            hard_mode.Button7.Text = "7" And hard_mode.Button8.Text = "8" And hard_mode.Button9.Text = "9" And
            hard_mode.Button10.Text = "10" And hard_mode.Button11.Text = "11" And hard_mode.Button12.Text = "12" And
            hard_mode.Button13.Text = "13" And hard_mode.Button14.Text = "14" And hard_mode.Button15.Text = "15" And
            hard_mode.Button16.Text = "16" And hard_mode.Button17.Text = "17" And hard_mode.Button18.Text = "18" And
            hard_mode.Button19.Text = "19" And hard_mode.Button20.Text = "20" And hard_mode.Button21.Text = "21" And
            hard_mode.Button22.Text = "22" And hard_mode.Button23.Text = "23" And hard_mode.Button24.Text = "24" Then
            youwin.Show()
        End If
        hard_mode.count = hard_mode.count + 1
        hard_mode.TextBox1.Text = hard_mode.count
    End Sub

    Sub shufflehard_mode()

        Dim a(24), i, j, RN As Integer
        Dim flag As Boolean

        flag = False
        i = 1
        a(j) = 1

        Do While i <= 24
            Randomize()
            RN = CInt(Int((24 * Rnd())) + 1)

            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next

            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If
        Loop

        hard_mode.Button1.Text = a(1)
        hard_mode.Button2.Text = a(2)
        hard_mode.Button3.Text = a(3)
        hard_mode.Button4.Text = a(4)
        hard_mode.Button5.Text = a(5)

        hard_mode.Button6.Text = a(6)
        hard_mode.Button7.Text = a(7)
        hard_mode.Button8.Text = a(8)
        hard_mode.Button9.Text = a(9)
        hard_mode.Button10.Text = a(10)

        hard_mode.Button11.Text = a(11)
        hard_mode.Button12.Text = a(12)
        hard_mode.Button13.Text = a(13)
        hard_mode.Button14.Text = a(14)
        hard_mode.Button15.Text = a(15)
        hard_mode.Button16.Text = a(16)

        hard_mode.Button17.Text = a(17)
        hard_mode.Button18.Text = a(18)
        hard_mode.Button19.Text = a(19)
        hard_mode.Button20.Text = a(20)
        hard_mode.Button21.Text = a(21)
        hard_mode.Button22.Text = a(22)

        hard_mode.Button23.Text = a(23)
        hard_mode.Button24.Text = a(24)
        hard_mode.Button25.Text = ""

    End Sub

End Module
