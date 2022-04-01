Imports MySql.Data.MySqlClient
Imports System.Math
Public Class RID
    Dim total_index As Double
    Dim a, b, c As Double
    Dim maturity As Double

    


    Private Sub RID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilDataComboBox()
        Call autoNumber()

    End Sub

    Sub tampilDataComboBox()
        Call koneksi_db()
        Dim str As String
        str = "select kode_responden,nama_responden from responden"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                ComboBox1.Items.Add(rd("kode_responden"))

            Loop
        Else

        End If
    End Sub


    Sub autoNumber()
        TextBox1.Enabled = False
        Call koneksi_db()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        Dim str As String
        str = "SELECT * From data_tata_kelola ORDER BY kode"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            strSementara = Mid(rd.Item("kode"), 2, 2)
            strIsi = Val(strSementara) + 1
            TextBox1.Text = "P" + Mid("0", 1, 2 - strIsi.Length) & strIsi
        Else
            TextBox1.Text = "P01"
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi_db()
        Dim str As String
        str = "SELECT kode_responden, nama_responden FROM responden WHERE kode_responden='" & ComboBox1.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox2.Text = rd.Item(1)
        End If

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub rata_index_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rata_index.MouseLeave
        a = indexPO9.Text
        b = indexAI2.Text
        c = indexDS5.Text
        total_index = (a + b + c) / 3
        rata_index.Text = Round(Val(total_index), 2)
        TextBox6.Text = Round(Val(total_index), 2)
        maturity = Round(Val(total_index), 2)
        If maturity <= 0.49 Then
            maturity_level.Text = "Non Existent"
            TextBox7.Text = "Non Existent"
        ElseIf maturity <= 1.49 Then
            maturity_level.Text = "Intial/ Ad Hoc"
            TextBox7.Text = "Intial/ Ad Hoc"
        ElseIf maturity <= 2.49 Then
            maturity_level.Text = "Repeatable but Intuitive"
            TextBox7.Text = "Repeatable but Intuitive"
        ElseIf maturity <= 3.49 Then
            maturity_level.Text = "Defined Process"
            TextBox7.Text = "Defined Process"
        ElseIf maturity <= 4.49 Then
            maturity_level.Text = "Managed And Measurable"
            TextBox7.Text = "Managed And Measurable"
        ElseIf maturity <= 5.0 Then
            maturity_level.Text = "Optimized"
            TextBox7.Text = "Optimized"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call koneksi_db()
        Dim str As String
        Dim tanggal As Date
        tanggal = DateTimePicker1.Value
        str = "insert into data_tata_kelola value('" & TextBox1.Text & "','" & tanggal & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        MsgBox("Berhasil Menyimpan Data Audit")

        FormMenu.Show()
        Me.Close()
        
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
    End Sub
End Class