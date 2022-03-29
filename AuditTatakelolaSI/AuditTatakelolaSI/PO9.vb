Public Class PO9

    Dim a1, a2, a3, a4, a5, a6, a7, a8 As Integer
    Dim b1, b2, b3, b4, b5, b6, b7, b8 As Integer
    Dim c1, c2, c3, c4, c5, c6, c7, c8 As Integer
    Dim d1, d2, d3, d4, d5, d6, d7, d8 As Integer
    Dim e1, e2, e3, e4, e5, e6, e7, e8 As Integer
   
    Dim total_a As Integer
    Dim total_b As Integer
    Dim total_c As Integer
    Dim total_d As Integer
    Dim total_e As Integer



    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_1_5.CheckedChanged
        If P_1_5.Checked Then
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
        information.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub P_2_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_2_5.CheckedChanged
        If P_2_5.Checked Then
            a2 = 5
        Else
            a2 = 0
        End If
    End Sub

    Private Sub TextBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseMove
        total_a = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8
        TextBox1.Text = total_a
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub P_3_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_3_5.CheckedChanged
        If P_3_5.Checked Then
            a3 = 5
        Else
            a3 = 0
        End If
    End Sub

    Private Sub P_4_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_4_5.CheckedChanged
        If P_4_5.Checked Then
            a4 = 5
        Else
            a4 = 0
        End If
    End Sub

    Private Sub P_5_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_5_5.CheckedChanged
        If P_5_5.Checked Then
            a5 = 5
        Else
            a5 = 0
        End If
    End Sub

    Private Sub P_6_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_6_5.CheckedChanged
        If P_6_5.Checked Then
            a6 = 5
        Else
            a6 = 0
        End If
    End Sub

    Private Sub P_7_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_7_5.CheckedChanged
        If P_7_5.Checked Then
            a7 = 5
        Else
            a7 = 0
        End If
    End Sub

    Private Sub P_8_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_8_5.CheckedChanged
        If P_8_5.Checked Then
            a8 = 5
        Else
            a8 = 0
        End If
    End Sub

    Private Sub P_1_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_1_4.CheckedChanged
        If P_1_4.Checked Then
            b1 = 4
        Else
            b1 = 0
        End If
    End Sub

    Private Sub TextBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseMove
        total_b = b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8
        TextBox2.Text = total_b
    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub P_2_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_2_4.CheckedChanged
        If P_2_4.Checked Then
            b2 = 4
        Else
            b2 = 0
        End If
    End Sub

    Private Sub P_3_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_3_4.CheckedChanged
        If P_3_4.Checked Then
            b3 = 4
        Else
            b3 = 0
        End If
    End Sub

    Private Sub P_4_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_4_4.CheckedChanged
        If P_4_4.Checked Then
            b4 = 4
        Else
            b4 = 0
        End If
    End Sub

    Private Sub P_5_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_5_4.CheckedChanged
        If P_5_4.Checked Then
            b5 = 4
        Else
            b5 = 0
        End If
    End Sub

    Private Sub P_6_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_6_4.CheckedChanged
        If P_6_4.Checked Then
            b6 = 4
        Else
            b6 = 0
        End If
    End Sub

    Private Sub P_7_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_7_4.CheckedChanged
        If P_7_4.Checked Then
            b7 = 4
        Else
            b7 = 0
        End If
    End Sub

    Private Sub P_8_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_8_4.CheckedChanged
        If P_8_4.Checked Then
            b8 = 4
        Else
            b8 = 0
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class