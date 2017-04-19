Module Fechas

    '-------------------------- EJERCICIO 1.14 -------------------------

    'Sub Main()

    '    Dim fecha As Date = Date.Now
    '    Console.WriteLine("Dia del Año: " & fecha.DayOfYear & vbCrLf)
    '    Console.WriteLine("Mes: " & fecha.Month & vbCrLf)
    '    Console.WriteLine("Hora: " & fecha.Hour & vbCrLf)
    '    Console.WriteLine("Minuto: " & fecha.Minute & vbCrLf)

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 1.15 -------------------------

    'Sub Main()

    '    Dim dato_dia As UShort
    '    Dim dato_hora As UShort
    '    Dim fecha As Date = Now

    '    Console.WriteLine("Ingrese un numero (1 a 31)")
    '    dato_dia = Console.ReadLine()
    '    Console.WriteLine("Ingrese un numero (0 a 24)")
    '    dato_hora = Console.ReadLine()

    '    Console.WriteLine(New Date(fecha.Year, fecha.Month, dato_dia, dato_hora, fecha.Minute, 0))

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 1.16 -------------------------

    'Sub Main()

    '    Dim fecha As Date = #04-06-2015#
    '    Dim dias As UShort = 29

    '    Console.WriteLine("Fecha dada = " & fecha)
    '    Console.WriteLine("Dias a sumar = " & dias)
    '    Console.WriteLine()
    '    Console.WriteLine(fecha.AddDays(dias))

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 1.17 -------------------------

    Enum dias_semana As Integer
        Domingo
        Lunes
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
    End Enum

    Sub Main()

        Dim fecha As Date = #04-06-2015#
        Dim dia_sumar As UShort
        Dim fecha_resultado As Date

        Console.WriteLine("Ingrese dias a sumar")
        dia_sumar = Console.ReadLine()

        Console.WriteLine("Fecha dada = " & fecha)
        Console.WriteLine("Dias a sumar = " & dia_sumar)
        Console.WriteLine()
        fecha_resultado = fecha.AddDays(dia_sumar)
        Console.WriteLine("Fecha resultante: " & fecha_resultado)

        If fecha_resultado.DayOfWeek = dias_semana.Domingo Then
            Console.WriteLine("Dia de la semana: Domingo")
        ElseIf fecha_resultado.DayOfWeek = dias_semana.Lunes Then
            Console.WriteLine("Dia de la semana: Lunes")
        ElseIf fecha_resultado.DayOfWeek = dias_semana.Martes Then
            Console.WriteLine("Dia de la semana: Martes")
        ElseIf fecha_resultado.DayOfWeek = dias_semana.Miercoles Then
            Console.WriteLine("Dia de la semana: Miercoles")
        ElseIf fecha_resultado.DayOfWeek = dias_semana.Jueves Then
            Console.WriteLine("Dia de la semana: Jueves")
        ElseIf fecha_resultado.DayOfWeek = dias_semana.Viernes Then
            Console.WriteLine("Dia de la semana: Viernes")
        Else
            Console.WriteLine("Dia de la semana: Sabado")
        End If

        Console.ReadKey()

    End Sub

End Module
