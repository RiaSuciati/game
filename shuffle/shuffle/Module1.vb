﻿Module Module1

    Sub CheckButton(ByRef Butt1 As Button, ByRef Butt2 As Button)
        If Butt2.Text = "" Then
            Butt2.Text = Butt1.Text
            Butt1.Text = ""
        End If
    End Sub

    Sub CheckSolved()
        If Form1.Button1.Text = "1" And Form1.Button2.Text = "2" And Form1.Button3.Text = "3" And
            Form1.Button4.Text = "4" And Form1.Button5.Text = "5" And Form1.Button6.Text = "6" And
            Form1.Button7.Text = "7" And Form1.Button8.Text = "8" And Form1.Button9.Text = "9" And
            Form1.Button10.Text = "10" And Form1.Button11.Text = "11" And Form1.Button12.Text = "12" And
            Form1.Button13.Text = "13" And Form1.Button14.Text = "14" And Form1.Button15.Text = "15" Then
            MessageBox.Show("Wow, you did it in " & Form1.count & "click")
        End If

        Form1.count = Form1.count + 1
        Form1.Text = "Shuffle : " & Form1.count & " clicks "
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

        Form1.Button1.Text = a(1)
        Form1.Button2.Text = a(2)
        Form1.Button3.Text = a(3)
        Form1.Button4.Text = a(4)
        Form1.Button5.Text = a(5)

        Form1.Button6.Text = a(6)
        Form1.Button7.Text = a(7)
        Form1.Button8.Text = a(8)
        Form1.Button9.Text = a(9)
        Form1.Button10.Text = a(10)

        Form1.Button11.Text = a(11)
        Form1.Button12.Text = a(12)
        Form1.Button13.Text = a(13)
        Form1.Button14.Text = a(14)
        Form1.Button15.Text = a(15)
        Form1.Button16.Text = ""


    End Sub

    Sub CheckSolvedLevel1()
        If Level1.Button1.Text = "1" And Level1.Button2.Text = "2" And Level1.Button3.Text = "3" And
            Level1.Button4.Text = "4" And Level1.Button5.Text = "5" And Level1.Button6.Text = "6" And
            Level1.Button7.Text = "7" And Level1.Button8.Text = "8" Then
            MessageBox.Show("Wow, you did it in " & Level1.count & "click")
        End If

        Level1.count = Level1.count + 1
        Level1.Text = "Shuffle : " & Level1.count & " clicks "
    End Sub

    Sub shuffleLevel1()
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
        Loop

        Level1.Button1.Text = a(1)
        Level1.Button2.Text = a(2)
        Level1.Button3.Text = a(3)
        Level1.Button4.Text = a(4)
        Level1.Button5.Text = a(5)

        Level1.Button6.Text = a(6)
        Level1.Button7.Text = a(7)
        Level1.Button8.Text = a(8)
        Level1.Button9.Text = ""

    End Sub


    Sub checkSolvedLevel3()

        If Level3.Button1.Text = "1" And Level3.Button2.Text = "2" And Level3.Button3.Text = "3" And
            Level3.Button4.Text = "4" And Level3.Button5.Text = "5" And Level3.Button6.Text = "6" And
            Level3.Button7.Text = "7" And Level3.Button8.Text = "8" And Level3.Button9.Text = "9" And
            Level3.Button10.Text = "10" And Level3.Button11.Text = "11" And Level3.Button12.Text = "12" And
            Level3.Button13.Text = "13" And Level3.Button14.Text = "14" And Level3.Button15.Text = "15" And
            Level3.Button16.Text = "16" And Level3.Button17.Text = "17" And Level3.Button18.Text = "18" And
            Level3.Button19.Text = "19" And Level3.Button20.Text = "20" And Level3.Button21.Text = "21" And
            Level3.Button22.Text = "22" And Level3.Button23.Text = "23" And Level3.Button24.Text = "24" Then
            MessageBox.Show("Wow, you did it in " & Level3.count & "click")
        End If

        Level3.count = Level3.count + 1
        Level3.Text = "Shuffle : " & Level3.count & " clicks "
    End Sub

    Sub shuffleLevel3()

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

        Level3.Button1.Text = a(1)
        Level3.Button2.Text = a(2)
        Level3.Button3.Text = a(3)
        Level3.Button4.Text = a(4)
        Level3.Button5.Text = a(5)

        Level3.Button6.Text = a(6)
        Level3.Button7.Text = a(7)
        Level3.Button8.Text = a(8)
        Level3.Button9.Text = a(9)
        Level3.Button10.Text = a(10)

        Level3.Button11.Text = a(11)
        Level3.Button12.Text = a(12)
        Level3.Button13.Text = a(13)
        Level3.Button14.Text = a(14)
        Level3.Button15.Text = a(15)
        Level3.Button16.Text = a(16)

        Level3.Button17.Text = a(17)
        Level3.Button18.Text = a(18)
        Level3.Button19.Text = a(19)
        Level3.Button20.Text = a(20)
        Level3.Button21.Text = a(21)
        Level3.Button22.Text = a(22)

        Level3.Button23.Text = a(23)
        Level3.Button24.Text = a(24)
        Level3.Button25.Text = ""

    End Sub

End Module
