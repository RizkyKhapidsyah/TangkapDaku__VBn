Public Class FormTangkapDaku

    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        'menciptakan sebuah objek Random 
        Dim rand As New Random

        'variabel-variabel untuk memuat koordinat XY
        Dim intKiriBaru, intAtasBaru As Integer

        'membaca koordinat XY acak
        intKiriBaru = rand.Next(Me.Width - tombolTangkapDaku.Width)
        intAtasBaru = rand.Next(Me.Height - tombolTangkapDaku.Height)

        'menggeser tombol ke lokasi baru
        tombolTangkapDaku.Left = intKiriBaru
        tombolTangkapDaku.Top = intAtasBaru
    End Sub

    Private Sub tombolTangkapDaku_Click(sender As Object, e As EventArgs) Handles tombolTangkapDaku.Click
        'menonaktifkan timer
        tmrGame.Enabled = False

        'menampilkan pesa
        MessageBox.Show("Anda menang!")
    End Sub
End Class
