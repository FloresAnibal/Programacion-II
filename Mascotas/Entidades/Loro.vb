Public Class Loro
    'campos
    Private _memoria As Queue(Of String)
    Private _edad As Short
    Private _fechaNacimiento As Date
    Private _nombre As String

    'constructor
    Sub New()
        _memoria = New Queue(Of String)
        _edad = 0
        _fechaNacimiento = Nothing
        _nombre = ""
    End Sub
End Class
