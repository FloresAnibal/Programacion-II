Module estructuras_repetitivas
    ''-------------------------- EJERCICIO 2.10 -------------------------
    'Sub Main()
    '    Dim valor1, valor2, aux_valor1 As Integer
    '    Dim cantidad_multiplos As UShort

    '    Console.WriteLine("Ingrese un valor: ")
    '    valor1 = Console.ReadLine()
    '    Console.WriteLine("Ingrese otro valor (mayor al primero): ")
    '    valor2 = Console.ReadLine()

    '    Console.WriteLine(vbCrLf & "----- DO WHILE LOOP -----")
    '    Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

    '    aux_valor1 = valor1

    '    Do While aux_valor1 <= valor2

    '        If aux_valor1 Mod 5 = 0 Then
    '            Console.WriteLine(aux_valor1)
    '            cantidad_multiplos += 1
    '        End If
    '        aux_valor1 += 1

    '    Loop
    '    If cantidad_multiplos = 0 Then
    '        Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
    '    Else
    '        Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
    '    End If

    '    '------------------------------------------------------------------------------------------

    '    Console.WriteLine(vbCrLf & "----- DO LOOP WHILE -----")
    '    Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

    '    aux_valor1 = valor1
    '    cantidad_multiplos = 0

    '    Do

    '        If aux_valor1 Mod 5 = 0 Then
    '            Console.WriteLine(aux_valor1)
    '            cantidad_multiplos += 1
    '        End If
    '        aux_valor1 += 1

    '    Loop While aux_valor1 <= valor2
    '    If cantidad_multiplos = 0 Then
    '        Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
    '    Else
    '        Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
    '    End If

    '    '------------------------------------------------------------------------------------------

    '    Console.WriteLine(vbCrLf & "----- DO UNTIL LOOP -----")
    '    Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

    '    aux_valor1 = valor1
    '    cantidad_multiplos = 0

    '    Do Until aux_valor1 > valor2

    '        If aux_valor1 Mod 5 = 0 Then
    '            Console.WriteLine(aux_valor1)
    '            cantidad_multiplos += 1
    '        End If
    '        aux_valor1 += 1

    '    Loop
    '    If cantidad_multiplos = 0 Then
    '        Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
    '    Else
    '        Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
    '    End If

    '    '------------------------------------------------------------------------------------------

    '    Console.WriteLine(vbCrLf & "----- DO LOOP UNTIL -----")
    '    Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

    '    aux_valor1 = valor1
    '    cantidad_multiplos = 0

    '    Do

    '        If aux_valor1 Mod 5 = 0 Then
    '            Console.WriteLine(aux_valor1)
    '            cantidad_multiplos += 1
    '        End If
    '        aux_valor1 += 1

    '    Loop Until aux_valor1 > valor2
    '    If cantidad_multiplos = 0 Then
    '        Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
    '    Else
    '        Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
    '    End If

    '    '------------------------------------------------------------------------------------------

    '    Console.WriteLine(vbCrLf & "----- FOR NEXT -----")
    '    Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

    '    cantidad_multiplos = 0

    '    For aux_valor1 = valor1 To valor2

    '        If aux_valor1 Mod 5 = 0 Then
    '            Console.WriteLine(aux_valor1)
    '            cantidad_multiplos += 1
    '        End If

    '    Next
    '    If cantidad_multiplos = 0 Then
    '        Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
    '    Else
    '        Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
    '    End If

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 2.11 ---------------------------

    'Sub Main()

    '    Dim valor As Integer
    '    Dim pares As Short
    '    Dim impares As Short
    '    Dim validar As Boolean

    '    Do
    '        Console.WriteLine("Ingrese un valor o 0 para salir")
    '        valor = Console.ReadLine()
    '        If valor > 0 Then
    '            validar = True ' Para validar que se ingreso al menos 1 valor positivo
    '            If valor Mod 2 = 0 Then
    '                pares += 1
    '            Else
    '                impares += 1
    '            End If
    '        End If
    '    Loop While valor <> 0
    '    If validar Then
    '        If pares = 0 Then
    '            Console.WriteLine("Todos son impares")
    '        ElseIf impares = 0 Then
    '            Console.WriteLine("Todos son pares")
    '        Else
    '            Console.WriteLine("Pares: " & pares)
    '            Console.WriteLine("Impares: " & impares)
    '        End If
    '    Else
    '        Console.WriteLine("No se ingresó numeros positivos")
    '    End If

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 2.12 ---------------------------

    'Sub Main()

    '    Dim valor1 As Integer = 0
    '    Dim valor2 As Integer = 1

    '    Console.WriteLine("--- Sucesion de Fibonacci ---")
    '    Console.WriteLine(valor1)
    '    Console.WriteLine(valor2)

    '    For inicio = 1 To 10    ' Imprimo 2 valores por iteracion asi que el FIN del FOR debe ser la mitad del total a mostrar
    '        valor1 += valor2
    '        Console.WriteLine(valor1)
    '        valor2 += valor1
    '        Console.WriteLine(valor2)
    '    Next

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 2.13 ---------------------------

    'Sub Main()

    '    Dim divisor As UShort
    '    Dim primo As Integer

    '    For valor = 1 To 1000
    '        divisor = 1
    '        primo = 0
    '        Do
    '            If valor Mod divisor = 0 Then
    '                primo += 1
    '            End If
    '            divisor += 1
    '        Loop While divisor <= valor
    '        If primo = 2 Then
    '            Console.Write("|" & valor)
    '        End If
    '    Next

    '    Console.ReadKey()
    'End Sub



    '-------------------------- EJERCICIO 2.14 ---------------------------

    'Sub Main()

    '    Dim cantidad As Integer
    '    Dim precio As Single
    '    Dim subtotal As Single
    '    Dim descuento As Single = 0
    '    Dim porcentaje_desc As Byte = 0  'Valor de porcentaje
    '    Dim total_descuento As Single
    '    Dim total As Single

    '    Do
    '        Console.WriteLine("Ingrese Cantidad")
    '        cantidad = Console.ReadLine
    '        If cantidad = 0 Then
    '            Exit Do
    '        End If
    '        Console.WriteLine(vbCrLf & "Ingrese Precio")
    '        precio = Console.ReadLine

    '        subtotal = cantidad * precio

    '        Console.WriteLine(vbCrLf & "SUBTOTAL: " & subtotal)

    '        If cantidad >= 10 Then
    '            If cantidad <= 50 Then
    '                porcentaje_desc = 5
    '            ElseIf cantidad <= 250 Then
    '                porcentaje_desc = 10
    '            Else
    '                porcentaje_desc = 20
    '            End If
    '        End If

    '        descuento = subtotal * porcentaje_desc / 100.0
    '        total_descuento += descuento
    '        total += subtotal - descuento

    '        Console.WriteLine(vbCrLf & "DESCUENTO DE " & porcentaje_desc & "%: " & descuento)
    '        Console.WriteLine(vbCrLf & "TOTAL: " & subtotal - descuento)
    '        Console.WriteLine(vbCrLf & "---------------------------------" & vbCrLf)
    '    Loop

    '    Console.WriteLine(vbCrLf & "TOTAL DE DESCUENTOS: " & total_descuento)
    '    Console.WriteLine(vbCrLf & "TOTAL A ABONAR: " & total)

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 2.15 ---------------------------

    Sub Main()

        Dim capital As Single
        Dim meses As UShort
        Dim tasa_interes As Single = 36 / 100.0 / 12
        Dim interes As Single
        Dim total_interes As Single
        Console.WriteLine("Ingrese capital: " & vbCrLf)
        capital = Console.ReadLine()
        Console.WriteLine(vbCrLf & "Ingrese cantidad de meses: " & vbCrLf)
        meses = Console.ReadLine()
        Console.WriteLine(vbCrLf & "{0, 4}{1, 15}{2, 15}{3, 15}", "MES", "CAPITAL", "INTERES", "SALDO")

        For inicio = 1 To meses
            interes = capital * tasa_interes
            total_interes += interes
            Console.WriteLine("{0, 4}{1, 15}{2, 15}{3, 15}", Math.Round(inicio, 2), Math.Round(capital, 2), Math.Round(interes, 2), Math.Round(capital + interes, 2))
            capital += interes
        Next

        Console.WriteLine(vbCrLf & "TOTAL INTERES GANADO: " & Math.Round(total_interes, 2))

        Console.ReadKey()

    End Sub

End Module
