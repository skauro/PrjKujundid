Public Class FormKujundid

    Private precision As Integer = 0
    Private Sub tootleKujund(ByRef kujund As Kujund, precision As Integer)
        lblTyyp.Text = kujund.annatyyp

        txtPindala.Text = Math.Round(kujund.LeiaPindala, precision)
        txtYmbermoot.Text = Math.Round(kujund.LeiaYmbermoot, precision)

    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click

        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text, TxtKorgus.Text)
        tootleKujund(objektKolmnurk, precision)
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        Dim objektRuut As New Ruut(txtKylgA.Text)

        tootleKujund(objektRuut, precision)
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text), precision)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            precision = 0
        End If
        If ComboBox1.SelectedIndex = 1 Then
            precision = 1
        End If
        If ComboBox1.SelectedIndex = 2 Then
            precision = 2
        End If
        If ComboBox1.SelectedIndex = 3 Then
            precision = 3
        End If
    End Sub

    Private Sub btnRomb_Click(sender As Object, e As EventArgs) Handles btnRomb.Click
        Dim objektRomb As New CRomb(txtKylgA.Text, TxtKorgus.Text)

        tootleKujund(objektRomb, precision)
    End Sub

    Private Sub btnRoopkylik_Click(sender As Object, e As EventArgs) Handles btnRoopkylik.Click
        Dim objektRoopkylik As New Roopkylik(txtKylgA.Text, txtKylgB.Text, TxtKorgus.Text)

        tootleKujund(objektRoopkylik, precision)
    End Sub
End Class
