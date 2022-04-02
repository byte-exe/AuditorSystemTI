Imports MySql.Data.MySqlClient
Imports System.Math
Public Class laporan

    Dim maturity As Double

    Dim koneksi As New MySqlConnection
    Dim stringkoneksi As String = " Server=localhost;User Id=root;Password=;Database=db_skripsi_edo"
    Dim perintahmysql As New MySqlCommand
    Dim datatabel As New DataSet
    Dim tampildata As New MySqlDataAdapter
    Sub koneksi2()
        koneksi.ConnectionString = stringkoneksi
        Try
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
            Else
                koneksi.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub perintah(ByVal kirim As String)
        With perintahmysql
            .CommandText = kirim
            .CommandType = CommandType.Text
            .Connection = koneksi
            .ExecuteNonQuery()
        End With
    End Sub
   
    Sub tampilkan()
        perintahmysql.Connection = koneksi
        perintahmysql.CommandType = CommandType.Text
        perintahmysql.CommandText = "SELECT * FROM data_tata_kelola"
        tampildata.SelectCommand = perintahmysql
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "data_tata_kelola")
        DataGridView1.DataSource = datatabel.Tables("data_tata_kelola")
    End Sub

    Sub tampilkan_data_po9()
        Call koneksi_db()
        Dim str As String
        str = "SELECT AVG(PO9) FROM data_tata_kelola"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox1.Text = Round(Val(rd.Item(0)), 2)
        End If
    End Sub

    Sub tampilkan_data_ai2()
        Call koneksi_db()
        Dim str As String
        str = "SELECT AVG(AI2) FROM data_tata_kelola"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox2.Text = Round(Val(rd.Item(0)), 2)
        End If
    End Sub

    Sub tampilkan_data_ds5()
        Call koneksi_db()
        Dim str As String
        str = "SELECT AVG(DS5) FROM data_tata_kelola"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox3.Text = Round(Val(rd.Item(0)), 2)
        End If
    End Sub

    Sub tampilkan_data_index()
        Call koneksi_db()
        Dim str As String
        str = "SELECT AVG(rata_index) FROM data_tata_kelola"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox4.Text = Round(Val(rd.Item(0)), 2)
        End If

        If TextBox4.Text() <= 0.5 Then
            TextBox5.Text = "Non Existent"
        ElseIf TextBox4.Text >= 0.52 And TextBox4.Text <= 1.5 Then
            TextBox5.Text = "Intial/ Ad Hoc"
        ElseIf TextBox4.Text >= 1.51 And TextBox4.Text <= 2.5 Then
            TextBox5.Text = "Repeatable but Intuitive"
        ElseIf TextBox4.Text >= 2.51 And TextBox4.Text <= 3.5 Then
            TextBox5.Text = "Defined Process"
        ElseIf TextBox4.Text >= 3.51 And TextBox4.Text <= 4.5 Then
            TextBox5.Text = "Managed And Measurable"
        ElseIf TextBox4.Text >= 4.51 And TextBox4.Text <= 5.0 Then
            TextBox5.Text = "Optimized"
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FormMenu.Show()
        Me.Visible = False
    End Sub

    Private Sub laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi2()
        tampilkan()
        tampilkan_data_po9()
        tampilkan_data_ai2()
        tampilkan_data_ds5()
        tampilkan_data_index()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cetak_laporan.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class