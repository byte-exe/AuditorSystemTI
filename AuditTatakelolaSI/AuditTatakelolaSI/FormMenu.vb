Public Class FormMenu

    Sub waktu()

        'HR'

        Dim hr As String = TimeOfDay.Hour

        If hr = 1 Then

            hr = "0" + hr

        End If

        If hr = 2 Then

            hr = "0" + hr

        End If

        If hr = 3 Then

            hr = "0" + hr

        End If

        If hr = 4 Then

            hr = "0" + hr

        End If

        If hr = 5 Then

            hr = "0" + hr

        End If

        If hr = 6 Then

            hr = "0" + hr

        End If

        If hr = 7 Then

            hr = "0" + hr

        End If

        If hr = 8 Then

            hr = "0" + hr

        End If

        If hr = 9 Then

            hr = "0" + hr

        End If

        If hr = 0 Then

            hr = "0" + hr

        End If

        'MN'

        Dim mn As String = TimeOfDay.Minute

        If mn = 1 Then

            mn = "0" + mn

        End If

        If mn = 2 Then

            mn = "0" + mn

        End If

        If mn = 3 Then

            mn = "0" + mn

        End If

        If mn = 4 Then

            mn = "0" + mn

        End If

        If mn = 5 Then

            mn = "0" + mn

        End If

        If mn = 6 Then

            mn = "0" + mn

        End If

        If mn = 7 Then

            mn = "0" + mn

        End If

        If mn = 8 Then

            mn = "0" + mn

        End If

        If mn = 9 Then

            mn = "0" + mn

        End If

        If mn = 0 Then

            mn = "0" + mn

        End If

        'SC'

        Dim sc As String = TimeOfDay.Second

        If sc = 1 Then

            sc = "0" + sc

        End If

        If sc = 2 Then

            sc = "0" + sc

        End If

        If sc = 3 Then

            sc = "0" + sc

        End If

        If sc = 4 Then

            sc = "0" + sc

        End If

        If sc = 5 Then

            sc = "0" + sc

        End If

        If sc = 6 Then

            sc = "0" + sc

        End If

        If sc = 7 Then

            sc = "0" + sc

        End If

        If sc = 8 Then

            sc = "0" + sc

        End If

        If sc = 9 Then

            sc = "0" + sc

        End If

        If sc = 0 Then

            sc = "0" + sc

        End If

        TextBox1.Text = hr + ":" + mn + ":" + sc

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        waktu()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        information.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        responden.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        laporan.Show()
        Me.Close()
    End Sub
End Class