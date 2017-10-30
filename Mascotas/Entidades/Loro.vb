Public Class Loro
    'campos
    Private _memoria As Queue(Of String)
    Private _fechaNacimiento As Date
    Private _nombre As String
    Private _palabras As String

    'constructor
    Sub New()
        _memoria = New Queue(Of String)
        _fechaNacimiento = Nothing
        _nombre = ""
        _palabras = ""
    End Sub

    'propiedades
    Public ReadOnly Property Edad As Short
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    'metodos
    Private Function CalcularEdad(fechaNacimiento As Date) As UShort
        If fechaNacimiento.Day < Today.Day And fechaNacimiento.Month <= Today.Month Then
            Return DateDiff("yyyy", fechaNacimiento, Date.Now) - 1
        End If
        Return DateDiff("yyyy", fechaNacimiento, Date.Now)
    End Function

    Public Overridable Sub Escuchar(frase As String)
        _memoria.Enqueue(frase)
    End Sub

    Public Function Hablar() As String
        If _memoria.Count > 0 Then
            _palabras &= _memoria.Dequeue & " "
        End If
        Return _palabras
    End Function

    'sobrescribir ToString
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
