Module Fecha_Hora
    '-------------------------- EJERCICIO 3.1 -------------------------

    'Sub Main()

    '    fecha_actual()
    '    Console.WriteLine("Hora Actual: " & hora_actual())

    '    Console.ReadKey()
    'End Sub

    'Private Sub fecha_actual()
    '    Console.WriteLine("Fecha Actual: " & Date.Today)
    'End Sub

    'Private Function hora_actual() As String
    '    Return TimeOfDay
    'End Function


    '-------------------------- EJERCICIO 3.2 -------------------------

    'Sub Main()

    '    Dim fecha As Date
    '    Dim sumar As UShort

    '    Console.WriteLine("Ingrese fecha: ")
    '    fecha = Console.ReadLine()
    '    Console.WriteLine("Ingrese cantidad de dias a sumar: ")
    '    sumar = Console.ReadLine()

    '    Console.WriteLine(sumar_dias(fecha, sumar))

    '    Console.ReadKey()
    'End Sub

    'Private Function sumar_dias(valor1 As Date, valor2 As UShort) As String
    '    Return valor1.AddDays(valor2)
    'End Function



    '-------------------------- EJERCICIO 3.3 -------------------------

    'Public exponente As UShort = 1

    'Sub Main()

    '    Dim valor_potencia As UShort

    '    Console.WriteLine("Ingresar Valor: ")
    '    valor_potencia = Console.ReadLine()

    '    For ini = 1 To 5
    '        Console.WriteLine(vbCrLf & valor_potencia & " elevado a la " & exponente + 1 & " = " & potencia(valor_potencia))
    '    Next

    '    Console.ReadKey()
    'End Sub

    'Private Function potencia(valor) As UShort
    '    exponente += 1
    '    Return valor ^ exponente
    'End Function



    '-------------------------- EJERCICIO 3.4 -------------------------

    'Private dato As Single
    ''Global para usar en la Funcion y pasar el resultado a la variable.
    'Sub Main()

    '    Console.WriteLine(vbCrLf & "El valor de la Hipotenusa es: " & hipotenusa())

    '    Console.ReadKey()
    'End Sub

    'Private Function hipotenusa() As Single
    '    Dim lado_a As UShort
    '    Dim lado_b As UShort

    '    ingresar_dato("A") 'Paso un caracter para imprimir por pantalla
    '    lado_a = dato
    '    ingresar_dato("B")
    '    lado_b = dato

    '    Return Math.Sqrt(lado_a ^ 2 + lado_b ^ 2)
    'End Function

    'Private Sub ingresar_dato(lado As Char)
    '    Do
    '        dato = 0.0
    '        Console.WriteLine(vbCrLf & "Ingrese Lado " & lado & " : ")
    '        dato = Console.ReadLine()
    '        If validar(dato) = 0 Then
    '            Exit Sub
    '        Else
    '            Console.WriteLine(vbCrLf & "DATO NO VALIDO!!!")
    '        End If
    '    Loop
    'End Sub

    'Private Function validar(valor As Single) As Single

    '    If valor < 1 Then   'Para evitar valores negativos o 0
    '        Return 1
    '    End If
    '    Return valor - Math.Truncate(valor) 'Extraigo parte entera

    'End Function



    '-------------------------- EJERCICIO 3.5 -------------------------

    Private dato As Single
    'Global para usar en la Funcion y pasar el resultado a la variable.
    Sub Main()

        Console.WriteLine(vbCrLf & "El Volumen es: " & volumen_cilindro())

        Console.ReadKey()
    End Sub

    Private Function volumen_cilindro() As Single
        Dim radio As UShort
        Dim altura As UShort

        ingresar_dato("Radio") 'Paso una cadena para imprimir por pantalla
        radio = dato
        ingresar_dato("Altura")
        altura = dato

        Return Math.PI * altura * radio ^ 2
    End Function

    Private Sub ingresar_dato(cadena As String)
        Do
            dato = 0.0
            Console.WriteLine(vbCrLf & "Ingrese " & cadena & " : ")
            dato = Console.ReadLine()
            If validar(dato) = 0 Then
                Exit Sub
            Else
                Console.WriteLine(vbCrLf & "DATO NO VALIDO!!!")
            End If
        Loop
    End Sub

    Private Function validar(valor As Single) As Single

        If valor < 1 Then   'Para evitar valores negativos o 0
            Return 1
        End If
        Return valor - Math.Truncate(valor) 'Extraigo parte entera

    End Function

End Module




