Public Class Roopkylik
    Inherits Nelinurk

    Private korgus As Double

    ' Konstruktor baasklassi atribuutide väärtustamiseks
    Public Sub New(ByVal kylgA As Double, ByVal kylgB As Double, ByVal korgus As Double)
        ' Baasklassi konstruktori väljakutse

        MyBase.New("Rööpküllik", kylgA, kylgB, kylgA, kylgB)
        Me.korgus = korgus
    End Sub
    ' Funktsioon arvutab ja tagastab rööpküliku pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function


End Class
