Public Class FormKujundid
    Private Sub tootleKujund(ByRef kujund As Kujund)
        lblTyyp.Text = kujund.annatyyp

        txtPindala.Text = kujund.LeiaPindala
        txtYmbermoot.Text = kujund.LeiaYmbermoot

    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click

        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        tootleKujund(objektKolmnurk)
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootleKujund(objektRuut)
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text))
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then

        End If
        If ComboBox1.SelectedIndex = 1 Then

        End If
        If ComboBox1.SelectedIndex = 2 Then

        End If
        If ComboBox1.SelectedIndex = 3 Then

        End If
    End Sub

End Class
