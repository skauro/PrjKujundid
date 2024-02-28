Public Class CRomb
    Inherits Nelinurk
    ' Konstruktor baasklassi atribuutide väärtustamiseks
    Private korgus As Double
    Public Sub New(ByVal kylgA As Double, ByVal korgus As Double)
        ' Baasklassi konstruktori väljakutse
        MyBase.New("Romb", kylgA, kylgA, kylgA, kylgA)
        Me.korgus = korgus

    End Sub
    ' Funktsioon arvutab ja tagastab rööpküliku pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function
End Class
