Imports System.Math

Public Class Kolmnurk
    Inherits Kujund

    Private korgus As Double

    Public Sub New(ByVal alus As Double, ByVal haar As Double)

        MyBase.New("Võrdhaarne kolmnurk", alus, haar, haar)

        'height
        If haar  Then

        End If
        Me.korgus = Sqrt(haar * haar - (alus * alus) / 4)

    End Sub
    Public Overrides Function LeiaYmbermoot() As Double
        Return kylgA + kylgB + kylgC
    End Function

    Public Overrides Function LeiaPindala() As Double
        Return (kylgA * korgus) / 2
    End Function
End Class
