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
        TextBox1.Text = ""
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

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi2()
        tampilkan()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim kalimatmysql As String = "insert into responden value('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
        perintah(kalimatmysql)
        MsgBox("data berhasil disimpan")
        tampilkan()
        bersih()
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
            Dim HAPUS As String = "DELETE from kode_responden WHERE kode_responden='" & TextBox1.Text & "'"
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
End Class