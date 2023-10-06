Public Class RecibosCores
    Public idRecibo As Integer
    Public CorRecibo As Color
    Public Property DeFinirID As Integer
        Get
            Return idRecibo
        End Get
        'Defini
        Set(ByVal Value As Integer)
            idRecibo = Value
        End Set
    End Property
End Class
