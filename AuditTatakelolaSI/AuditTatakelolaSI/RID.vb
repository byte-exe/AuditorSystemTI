Imports MySql.Data.MySqlClient
Public Class RID
    Dim total_index As Integer

    Private Sub RID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilDataComboBox()
    End Sub

    Sub tampilDataComboBox()
        Call koneksi()
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
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

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total.TextChanged
        total_index = (indexPO9 + indexAI2 + indexDS5) / 3
        total.Text = total_index
    End Sub
End Class