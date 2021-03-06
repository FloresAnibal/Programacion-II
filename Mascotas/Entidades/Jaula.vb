﻿Public Class Jaula

    'campos
    Private _nombre As String
    Private _loro As Loro
    Private _cotorras As List(Of Cotorra)

    'constructor
    Sub New()
        _nombre = ""
        _loro = Nothing
        _cotorras = New List(Of Cotorra)
    End Sub

    'propiedades
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Loro As Loro
        Get
            Return _loro
        End Get
        Set(value As Loro)
            _loro = value
        End Set
    End Property

    'metodos
    Public Sub addCotorra(nombreCotorra As Cotorra)
        If _cotorras.Count < 3 Then _cotorras.Add(nombreCotorra)
    End Sub

    Public Function getAllCotorras() As List(Of Cotorra)
        Return _cotorras
    End Function

    'sobrescribir ToString
    Public Overrides Function ToString() As String
        Return "Esta es la jaula: " & Nombre
    End Function

End Class
