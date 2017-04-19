Module Variables


    '-------------------------- EJERCICIO 1.1 -------------------------

    'Sub Main()

    '    Dim nombre As String = "Anibal"
    '    Dim tipo_documento As String = "DNI"
    '    Dim numero_documento As UInteger = 29929292
    '    Dim localidad As String = "Posadas"
    '    Dim fecha_nacimiento As Date = #05/01/1983#
    '    Dim edad As Byte = 34
    '    Dim altura As Single = 1.85
    '    Dim estado_civil As String = "soltero"
    '    Dim argentino As Boolean = True

    '    Console.WriteLine("Nombre: " & nombre)
    '    Console.WriteLine("Tipo de Documento: " & tipo_documento)
    '    Console.WriteLine("Numero de Docuemto: " & numero_documento)
    '    Console.WriteLine("Localidad: " & localidad)
    '    Console.WriteLine("Fecha de Nacimiento: " & fecha_nacimiento)
    '    Console.WriteLine("Edad: " & edad)
    '    Console.WriteLine("Altura: " & altura)
    '    Console.WriteLine("Estado Civil: " & estado_civil)
    '    Console.WriteLine("Argentino: " & argentino)

    '    Console.ReadKey()

    'End Sub


    '-------------------------- EJERCICIO 1.2 -------------------------

    'Public nombre As String = "Anibal"
    'Friend tipo_documento As String = "DNI"
    'Friend numero_documento As UInteger = 29929292
    'Friend fecha_nacimiento As Date = #05/01/1983#
    'Private altura As Single = 1.85
    'Private estado_civil As String = "soltero"
    'Private argentino As Boolean = True
    'Private localidad As String = "Posadas"

    'Sub Main()

    '    Dim edad As Byte = 34

    '    Console.WriteLine("Nombre: " & nombre)
    '    Console.WriteLine("Tipo de Documento: " & tipo_documento)
    '    Console.WriteLine("Numero de Docuemto: " & numero_documento)
    '    Console.WriteLine("Localidad: " & localidad)
    '    Console.WriteLine("Fecha de Nacimiento: " & fecha_nacimiento)
    '    Console.WriteLine("Edad: " & edad)
    '    Console.WriteLine("Altura: " & altura)
    '    Console.WriteLine("Estado Civil: " & estado_civil)
    '    Console.WriteLine("Argentino: " & argentino)

    '    Console.ReadKey()

    'End Sub


    '-------------------------- EJERCICIO 1.3 -------------------------

    Sub Main()
        Dim nombre As String = 29929292
        Dim tipo_documento As String = #05/01/1983#
        Dim numero_documento As UInteger = "Anibal"
        Dim localidad As String = -34
        Dim fecha_nacimiento As Date = "DNI"
        Dim edad As Byte = 1.85
        Dim altura As Single = "soltero"
        Dim estado_civil As String = True
        Dim argentino As Boolean = "Posadas"

        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Tipo de Documento: " & tipo_documento)
        Console.WriteLine("Numero de Docuemto: " & numero_documento)
        Console.WriteLine("Localidad: " & localidad)
        Console.WriteLine("Fecha de Nacimiento: " & fecha_nacimiento)
        Console.WriteLine("Edad: " & edad)
        Console.WriteLine("Altura: " & altura)
        Console.WriteLine("Estado Civil: " & estado_civil)
        Console.WriteLine("Argentino: " & argentino)

        Console.ReadKey()
    End Sub

End Module
