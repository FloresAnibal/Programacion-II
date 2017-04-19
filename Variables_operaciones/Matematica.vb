Module Matematica

    '-------------------------- EJERCICIO 1.11 -------------------------

    'Sub Main()

    '    Dim a As Single
    '    Console.WriteLine("Ingresar Valor: ")
    '    a = Console.ReadLine()

    '    Console.WriteLine("Valor absoluto: " & Math.Abs(a))
    '    Console.WriteLine("Elevado a la 10: " & Math.Pow(a, 10))
    '    Console.WriteLine("Raiz cuadrada: " & Math.Sqrt(a))

    '    Console.ReadKey()
    'End Sub



    '-------------------------- EJERCICIO 1.12 -------------------------

    'Sub Main()

    '    Dim a As Single
    '    Console.WriteLine("Ingresar Valor: ")
    '    a = Console.ReadLine()

    '    Console.WriteLine("Valor aproximado por exceso: " & Math.Ceiling(a))
    '    Console.WriteLine("Valor aproximado por defecto: " & Math.Floor(a))
    '    Console.WriteLine("Valor redondeado: " & Math.Round(a))

    '    Console.ReadKey()
    'End Sub



    '-------------------------- EJERCICIO 1.13 -------------------------

    Sub Main()

        Dim a As Single = 5
        Dim b As Single = 34.6
        Dim c As Single = 23

        Console.WriteLine("El mayor de los valores es: " & Math.Max(a, Math.Max(b, c)))

        Console.ReadKey()
    End Sub
End Module
