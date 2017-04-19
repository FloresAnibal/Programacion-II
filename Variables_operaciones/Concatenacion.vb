Module Concatenacion

    '-------------------------- EJERCICIO 1.8 -------------------------

    Sub Main()

        Dim nombre_empresa As String = "Empresa S.A."
        Dim nombre_calle As String = "Calle 105"
        Dim altura_calle As Integer = 1234
        Dim fecha_inicio_actividades As Date = #01-01-2015#
        'Conversion implicita
        Console.WriteLine(nombre_empresa & " " & nombre_calle & " " & altura_calle & " " & fecha_inicio_actividades)
        'Conversion explicita
        Console.WriteLine(nombre_empresa + " " + nombre_calle + " " + Convert.ToString(altura_calle) + " " + Convert.ToString(fecha_inicio_actividades))
        Console.ReadKey()

    End Sub

End Module
