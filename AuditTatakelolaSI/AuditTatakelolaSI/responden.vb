Imports MySql.Data.MySqlClient
Public Class responden


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
    Sub bersih()
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub
    Sub tampilkan()
        perintahmysql.Connection = koneksi
        perintahmysql.CommandType = CommandType.Text
        perintahmysql.CommandText = "SELECT * FROM responden"
        tampildata.SelectCommand = perintahmysql
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "responden")
        DataGridView1.DataSource = datatabel.Tables("responden")
    End Sub

    Sub autoNumber()
        TextBox1.Enabled = False
        Call koneksi_db()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        Dim str As String
        str = "SELECT * From responden ORDER BY kode_responden desc"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            strSementara = Mid(rd.Item("kode_responden"), 2, 2)
            strIsi = Val(strSementara) + 1
            TextBox1.Text = "R" + Mid("0", 1, 2 - strIsi.Length) & strIsi
        Else
            TextBox1.Text = "R01"
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi2()
        tampilkan()
        autoNumber()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim kalimatmysql As String = "insert into responden value('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
        perintah(kalimatmysql)
        MsgBox("data berhasil disimpan")
        tampilkan()
        bersih()
        autoNumber()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bersih()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MessageBox.Show("apakah data yakin dihapus", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim HAPUS As String = "DELETE from responden WHERE kode_responden='" & TextBox1.Text & "'"
            perintah(HAPUS)
        Else
            bersih()
        End If
        bersih()
        tampilkan()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FormMenu.Show()
        Me.Visible = False
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class