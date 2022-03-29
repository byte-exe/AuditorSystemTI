Public Class PO9

    Dim a1, a2, a3, a4, a5, a6, a7, a8 As Integer
   

    Dim total_a As Integer


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

    End Sub
End Class