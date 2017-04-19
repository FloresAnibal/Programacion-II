Module Semanas

    '-------------------------- EJERCICIO 1.7 -------------------------

    Sub Main()

        Const dias_del_anio As Integer = 365
        Const dias_laborables As Integer = 250
        Const dias_de_la_semana As Integer = 7

        Console.WriteLine("El año cuenta con " & Convert.ToInt32(dias_del_anio / dias_de_la_semana) & " semanas")
        Console.WriteLine("El año cuenta con " & Convert.ToInt32(dias_laborables / dias_de_la_semana) & " semanas laborables")

        Console.ReadKey()

    End Sub
End Module
