Imports MySql.Data.MySqlClient
Public Class laporan


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



   

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    

    End Sub

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FormMenu.Show()
        Me.Visible = False
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi2()
        tampilkan()

    End Sub
End Class