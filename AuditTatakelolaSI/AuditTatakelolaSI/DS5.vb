Imports System.Math
Public Class DS5

    Dim a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 As Integer
    Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10 As Integer
    Dim c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 As Integer
    Dim d1, d2, d3, d4, d5, d6, d7, d8, d9, d10 As Integer
    Dim e1, e2, e3, e4, e5, e6, e7, e8, e9, e10 As Integer

    Dim total_a As Integer
    Dim total_b As Integer
    Dim total_c As Integer
    Dim total_d As Integer
    Dim total_e As Integer

    Dim index As Double
    Dim total_jawaban As Integer



    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SS_1_5.CheckedChanged
        If SS_1_5.Checked Then
            a1 = 5
        Else
            a1 = 0
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AI2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RID.jumlah_po9.Text = jumlah_po9.Text
        RID.indexPO9.Text = indexPO9.Text
        RID.jumlah_ai2.Text = jumlah_ai2.Text
        RID.indexAI2.Text = indexAI2.Text
        RID.jumlah_ds5.Text = jumlah_ds5.Text
        RID.indexDS5.Text = indexDS5.Text
        RID.Show()
        Me.Close()
    End Sub

    Private Sub P_2_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SS_2_5.CheckedChanged
        If SS_2_5.Checked Then
            a2 = 5
        Else
            a2 = 0
        End If
    End Sub

    Private Sub TextBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseMove
        total_a = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10
        TextBox1.Text = total_a
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub P_3_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SS_3_5.CheckedChanged
        If SS_3_5.Checked Then
            a3 = 5
        Else
            a3 = 0
        End If
    End Sub

    Private Sub P_4_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SS_4_5.CheckedChanged
        If SS_4_5.Checked Then
            a4 = 5
        Else
            a4 = 0
        End If
    End Sub

    Private Sub P_5_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SS_5_5.CheckedChanged
        If SS_5_5.Checked Then
            a5 = 5
        Else
            a5 = 0
        End If
    End Sub

    Private Sub P_6_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SS_6_5.CheckedChanged
        If SS_6_5.Checked Then
            a6 = 5
        Else
            a6 = 0
        End If
    End Sub

    Private Sub P_7_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SS_7_5.CheckedChanged
        If SS_7_5.Checked Then
            a7 = 5
        Else
            a7 = 0
        End If
    End Sub

    Private Sub P_8_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SS_8_5.CheckedChanged
        If SS_8_5.Checked Then
            a8 = 5
        Else
            a8 = 0
        End If
    End Sub

    Private Sub P_1_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_1_4.CheckedChanged
        If S_1_4.Checked Then
            b1 = 4
        Else
            b1 = 0
        End If
    End Sub

    Private Sub TextBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseMove
        total_b = b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9 + b10
        TextBox2.Text = total_b
    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub P_2_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_2_4.CheckedChanged
        If S_2_4.Checked Then
            b2 = 4
        Else
            b2 = 0
        End If
    End Sub

    Private Sub P_3_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_3_4.CheckedChanged
        If S_3_4.Checked Then
            b3 = 4
        Else
            b3 = 0
        End If
    End Sub

    Private Sub P_4_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_4_4.CheckedChanged
        If S_4_4.Checked Then
            b4 = 4
        Else
            b4 = 0
        End If
    End Sub

    Private Sub P_5_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_5_4.CheckedChanged
        If S_5_4.Checked Then
            b5 = 4
        Else
            b5 = 0
        End If
    End Sub

    Private Sub P_6_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_6_4.CheckedChanged
        If S_6_4.Checked Then
            b6 = 4
        Else
            b6 = 0
        End If
    End Sub

    Private Sub P_7_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_7_4.CheckedChanged
        If S_7_4.Checked Then
            b7 = 4
        Else
            b7 = 0
        End If
    End Sub

    Private Sub P_8_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_8_4.CheckedChanged
        If S_8_4.Checked Then
            b8 = 4
        Else
            b8 = 0
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub P_1_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KS_1_3.CheckedChanged
        If KS_1_3.Checked Then
            c1 = 3
        Else
            c1 = 0
        End If
    End Sub

    Private Sub P_2_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KS_2_3.CheckedChanged
        If KS_2_3.Checked Then
            c2 = 3
        Else
            c2 = 0
        End If
    End Sub

    Private Sub P_3_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KS_3_3.CheckedChanged
        If KS_3_3.Checked Then
            c3 = 3
        Else
            c3 = 0
        End If
    End Sub

    Private Sub P_4_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KS_4_3.CheckedChanged
        If KS_4_3.Checked Then
            c4 = 3
        Else
            c4 = 0
        End If
    End Sub

    Private Sub P_5_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KS_5_3.CheckedChanged
        If KS_5_3.Checked Then
            c5 = 3
        Else
            c5 = 0
        End If
    End Sub

    Private Sub P_6_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KS_6_3.CheckedChanged
        If KS_6_3.Checked Then
            c6 = 3
        Else
            c6 = 0
        End If
    End Sub

    Private Sub P_7_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KS_7_3.CheckedChanged
        If KS_7_3.Checked Then
            c7 = 3
        Else
            c7 = 0
        End If
    End Sub

    Private Sub P_8_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KS_8_3.CheckedChanged
        If KS_8_3.Checked Then
            c8 = 3
        Else
            c8 = 0
        End If
    End Sub

    Private Sub TextBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.MouseLeave
        total_c = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10
        TextBox3.Text = total_c
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub P_2_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS_2_2.CheckedChanged
        If TS_2_2.Checked Then
            d2 = 2
        Else
            d2 = 0
        End If
    End Sub

    Private Sub TS_1_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS_1_2.CheckedChanged
        If TS_1_2.Checked Then
            d1 = 2
        Else
            d1 = 0
        End If
    End Sub

    Private Sub TextBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.MouseLeave
        total_d = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10
        TextBox4.Text = total_d
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TS_3_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS_3_2.CheckedChanged
        If TS_3_2.Checked Then
            d3 = 2
        Else
            d3 = 0
        End If
    End Sub

    Private Sub TS_4_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS_4_2.CheckedChanged
        If TS_4_2.Checked Then
            d4 = 2
        Else
            d4 = 0
        End If
    End Sub

    Private Sub TS_5_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS_5_2.CheckedChanged
        If TS_5_2.Checked Then
            d5 = 2
        Else
            d5 = 0
        End If
    End Sub

    Private Sub TS_6_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS_6_2.CheckedChanged
        If TS_6_2.Checked Then
            d6 = 2
        Else
            d6 = 0
        End If
    End Sub

    Private Sub TS_7_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS_7_2.CheckedChanged
        If TS_7_2.Checked Then
            d7 = 2
        Else
            d7 = 0
        End If
    End Sub

    Private Sub TS_8_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS_8_2.CheckedChanged
        If TS_8_2.Checked Then
            d8 = 2
        Else
            d8 = 0
        End If
    End Sub

    Private Sub STS_1_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STS_1_1.CheckedChanged
        If STS_1_1.Checked Then
            e1 = 1
        Else
            e1 = 0
        End If
    End Sub

    Private Sub STS_2_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STS_2_1.CheckedChanged
        If STS_2_1.Checked Then
            e2 = 1
        Else
            e2 = 0
        End If
    End Sub

    Private Sub STS_3_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STS_3_1.CheckedChanged
        If STS_3_1.Checked Then
            e3 = 1
        Else
            e3 = 0
        End If
    End Sub

    Private Sub STS_4_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STS_4_1.CheckedChanged
        If STS_4_1.Checked Then
            e4 = 1
        Else
            e4 = 0
        End If
    End Sub

    Private Sub STS_5_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STS_5_1.CheckedChanged
        If STS_5_1.Checked Then
            e5 = 1
        Else
            e5 = 0
        End If
    End Sub

    Private Sub STS_6_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STS_6_1.CheckedChanged
        If STS_6_1.Checked Then
            e6 = 1
        Else
            e6 = 0
        End If
    End Sub

    Private Sub STS_7_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STS_7_1.CheckedChanged
        If STS_7_1.Checked Then
            e7 = 1
        Else
            e7 = 0
        End If
    End Sub

    Private Sub STS_8_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STS_8_1.CheckedChanged
        If STS_8_1.Checked Then
            e8 = 1
        Else
            e8 = 0
        End If
    End Sub

    Private Sub TextBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.MouseLeave
        total_e = e1 + e2 + e3 + e4 + e5 + e6 + e7 + e8 + e9 + e10
        TextBox5.Text = total_e
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles jumlah_ds5.MouseLeave
        total_jawaban = total_a + total_b + total_c + total_d + total_e
        jumlah_ds5.Text = total_jawaban

        index = total_jawaban / 10
        indexDS5.Text = Round(Val(index), 2)

        If index <= 0.5 Then
            TextBox8.Text = "Non Existent"
        ElseIf index >= 0.51 And index <= 1.5 Then
            TextBox8.Text = "Intial/ Ad Hoc"
        ElseIf index >= 1.51 And index <= 2.5 Then
            TextBox8.Text = "Repeatable but Intuitive"
        ElseIf index >= 2.51 And index <= 3.5 Then
            TextBox8.Text = "Defined Process"
        ElseIf index >= 3.51 And index <= 4.5 Then
            TextBox8.Text = "Managed And Measurable"
        ElseIf index >= 4.51 And index <= 5.0 Then
            TextBox8.Text = "Optimized"
        End If

    End Sub

   

    Private Sub SS_9_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SS_9_5.CheckedChanged
        If SS_9_5.Checked Then
            a9 = 5
        Else
            a9 = 0
        End If
    End Sub

    Private Sub SS_10_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SS_10_5.CheckedChanged
        If SS_10_5.Checked Then
            a10 = 5
        Else
            a10 = 0
        End If
    End Sub

    Private Sub S_9_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_9_4.CheckedChanged
        If S_9_4.Checked Then
            b9 = 4
        Else
            b9 = 0
        End If
    End Sub

    Private Sub S_10_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_10_4.CheckedChanged
        If S_10_4.Checked Then
            b10 = 4
        Else
            b10 = 0
        End If
    End Sub

    Private Sub KS_9_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KS_9_3.CheckedChanged
        If KS_9_3.Checked Then
            c9 = 3
        Else
            c9 = 0
        End If
    End Sub

    Private Sub KS_10_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KS_10_3.CheckedChanged
        If KS_10_3.Checked Then
            c10 = 3
        Else
            c10 = 0
        End If
    End Sub

    Private Sub TS_9_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS_9_2.CheckedChanged
        If TS_9_2.Checked Then
            d9 = 2
        Else
            d9 = 0
        End If
    End Sub

    Private Sub TS_10_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TS_10_2.CheckedChanged
        If TS_10_2.Checked Then
            d10 = 2
        Else
            d10 = 0
        End If
    End Sub

    Private Sub STS_9_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STS_9_1.CheckedChanged
        If STS_9_1.Checked Then
            e9 = 1
        Else
            e9 = 0
        End If
    End Sub

    Private Sub STS_10_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STS_10_1.CheckedChanged
        If STS_10_1.Checked Then
            e10 = 1
        Else
            e10 = 0
        End If
    End Sub
End Class