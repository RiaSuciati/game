Public Class Level1

    Public count As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' button 2, 4 
        CheckButton(Butt1:=Button1, Butt2:=Button2)
        CheckButton(Butt1:=Button1, Butt2:=Button4)

        CheckSolvedLevel1()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' button 1, 3 , 5
        CheckButton(Butt1:=Button2, Butt2:=Button1)
        CheckButton(Butt1:=Button2, Butt2:=Button3)
        CheckButton(Butt1:=Button2, Butt2:=Button5)

        CheckSolvedLevel1()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' button 2, 6
        CheckButton(Butt1:=Button3, Butt2:=Button2)
        CheckButton(Butt1:=Button3, Butt2:=Button6)
        
        CheckSolvedLevel1()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' button 1, 5, 7
        CheckButton(Butt1:=Button4, Butt2:=Button1)
        CheckButton(Butt1:=Button4, Butt2:=Button5)
        CheckButton(Butt1:=Button4, Butt2:=Button7)

        CheckSolvedLevel1()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ' button 2, 4, 6, 8
        CheckButton(Butt1:=Button5, Butt2:=Button2)
        CheckButton(Butt1:=Button5, Butt2:=Button4)
        CheckButton(Butt1:=Button5, Butt2:=Button6)
        CheckButton(Butt1:=Button5, Butt2:=Button8)

        CheckSolvedLevel1()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ' button 3, 5, ""
        CheckButton(Butt1:=Button6, Butt2:=Button3)
        CheckButton(Butt1:=Button6, Butt2:=Button5)
        CheckButton(Butt1:=Button6, Butt2:=Button9)

        CheckSolvedLevel1()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ' button 4, 8
        CheckButton(Butt1:=Button7, Butt2:=Button4)
        CheckButton(Butt1:=Button7, Butt2:=Button8)

        CheckSolvedLevel1()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ' button 7, 5, ""
        CheckButton(Butt1:=Button8, Butt2:=Button7)
        CheckButton(Butt1:=Button8, Butt2:=Button5)
        CheckButton(Butt1:=Button8, Butt2:=Button9)

        CheckSolvedLevel1()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ' button 6, 8
        CheckButton(Butt1:=Button9, Butt2:=Button6)
        CheckButton(Butt1:=Button9, Butt2:=Button8)
       
        CheckSolvedLevel1()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shuffleLevel1()
    End Sub
End Class