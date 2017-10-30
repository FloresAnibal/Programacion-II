Public Class Cotorra
    Inherits Loro

    'campos
    Private _grabar As Boolean

    'constructor
    Sub New()
        MyBase.New()
        _grabar = True
    End Sub

    'propiedades
    Public ReadOnly Property EdadHumana As UShort
        Get
            Return Edad * 2
        End Get
    End Property

    'metodos
    Public Overrides Sub Escuchar(frase As String)
        If _grabar Then MyBase.Escuchar(frase)
        _grabar = Not _grabar
    End Sub

End Class
