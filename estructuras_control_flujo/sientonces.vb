Module sientonces

    '-------------------------- EJERCICIO 2.1 -------------------------
    'Sub Main()

    '    Dim valor_1 As Integer
    '    Dim valor_2 As Integer

    '    Console.WriteLine("Ingrese valor")
    '    valor_1 = Console.ReadLine
    '    Console.WriteLine()
    '    Console.WriteLine("Ingrese siguiente valor")
    '    valor_2 = Console.ReadLine
    '    Console.WriteLine()

    '    If valor_1 < valor_2 Then
    '        Console.WriteLine(valor_1 & " es menor valor " & valor_2)
    '    ElseIf valor_1 > valor_2 Then
    '        Console.WriteLine(valor_1 & " es mayor valor " & valor_2)
    '    Else
    '        Console.WriteLine(valor_1 & " y " & valor_2 & " son iguales")
    '    End If

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 2.2 -------------------------

    'Sub Main()

    '    Dim valor_1 As Integer
    '    Dim valor_2 As Integer
    '    Dim valor_3 As Integer

    '    Console.WriteLine("Ingrese Primer Valor")
    '    valor_1 = Console.ReadLine
    '    Console.WriteLine(vbCrLf & "Ingrese Segundo Valor")
    '    valor_2 = Console.ReadLine
    '    Console.WriteLine(vbCrLf & "Ingrese Tercer Valor")
    '    valor_3 = Console.ReadLine

    '    If valor_1 > valor_2 Then
    '        valor_1 = valor_2
    '    End If
    '    If valor_3 < valor_1 Then
    '        valor_1 = valor_3
    '    End If

    '    Console.WriteLine(vbCrLf & "El menor valor es = " & valor_1)

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 2.3 -------------------------

    'Sub Main()

    '    Dim valor_1 As Integer
    '    Dim valor_2 As Integer
    '    Dim posicion As String = "Primer"

    '    Console.WriteLine("Ingrese Primer Valor")
    '    valor_1 = Console.ReadLine
    '    Console.WriteLine(vbCrLf & "Ingrese Segundo Valor")
    '    valor_2 = Console.ReadLine

    '    If valor_1 = valor_2 Then
    '        posicion += " y Segundo"
    '    ElseIf valor_1 < valor_2 Then
    '        valor_1 = valor_2
    '        posicion = "Segundo"
    '    End If

    '    Console.WriteLine(vbCrLf & "Ingrese Tercer Valor")
    '    valor_2 = Console.ReadLine

    '    If valor_1 = valor_2 Then
    '        posicion += " y Tercer"
    '    ElseIf valor_1 < valor_2 Then
    '        valor_1 = valor_2
    '        posicion = "Tercer"
    '    End If

    '    Console.WriteLine(vbCrLf & "Ingrese Cuarto Valor")
    '    valor_2 = Console.ReadLine

    '    If valor_1 = valor_2 Then
    '        posicion += " y Cuarto"
    '    ElseIf valor_1 < valor_2 Then
    '        valor_1 = valor_2
    '        posicion = "Cuarto"
    '    End If

    '    Console.WriteLine(vbCrLf & "Ingrese Quinto Valor")
    '    valor_2 = Console.ReadLine

    '    If valor_1 = valor_2 Then
    '        posicion += " y Quinto"
    '    ElseIf valor_1 < valor_2 Then
    '        valor_1 = valor_2
    '        posicion = "Quinto"
    '    End If

    '    Console.WriteLine(vbCrLf & "El " & posicion & " numero es/son el/los de mayor valor")

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 2.4 -------------------------

    'Sub Main()

    '    Dim cantidad As Integer
    '    Dim precio As Single
    '    Dim subtotal As Single
    '    Dim descuento As Single = 0
    '    Dim porcentaje_desc As Byte = 0  'Valor de porcentaje

    '    Console.WriteLine("Ingrese Cantidad")
    '    cantidad = Console.ReadLine
    '    Console.WriteLine(vbCrLf & "Ingrese Precio")
    '    precio = Console.ReadLine

    '    subtotal = cantidad * precio

    '    Console.WriteLine(vbCrLf & "SUBTOTAL: " & subtotal)

    '    If cantidad >= 10 Then
    '        If cantidad <= 50 Then
    '            porcentaje_desc = 5
    '        ElseIf cantidad <= 250 Then
    '            porcentaje_desc = 10
    '        Else
    '            porcentaje_desc = 20
    '        End If
    '    End If

    '    descuento = subtotal * porcentaje_desc / 100.0

    '    Console.WriteLine(vbCrLf & "DESCUENTO DE " & porcentaje_desc & "%: " & descuento)
    '    Console.WriteLine(vbCrLf & "TOTAL: " & subtotal - descuento)

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 2.5 -------------------------

    'Sub Main()

    '    Dim mes As Byte

    '    Console.WriteLine("Ingrese un numero del 1 al 12")
    '    mes = Console.ReadLine()

    '    Select Case mes
    '        Case 1
    '            Console.WriteLine("Enero")
    '        Case 2
    '            Console.WriteLine("Febrero")
    '        Case 3
    '            Console.WriteLine("Marzo")
    '        Case 4
    '            Console.WriteLine("Abril")
    '        Case 5
    '            Console.WriteLine("Mayo")
    '        Case 6
    '            Console.WriteLine("Junio")
    '        Case 7
    '            Console.WriteLine("Julio")
    '        Case 8
    '            Console.WriteLine("Agosto")
    '        Case 9
    '            Console.WriteLine("Septiembre")
    '        Case 10
    '            Console.WriteLine("Octubre")
    '        Case 11
    '            Console.WriteLine("Noviembre")
    '        Case 12
    '            Console.WriteLine("Diciembre")
    '        Case Else
    '            Console.WriteLine("Valor Incorrecto")
    '    End Select

    '    Console.ReadLine()

    'End Sub



    '-------------------------- EJERCICIO 2.6 -------------------------

    'Sub Main()

    '    Dim cantidad As Integer
    '    Dim precio As Single
    '    Dim subtotal As Single
    '    Dim descuento As Single = 0
    '    Dim porcentaje_desc As Byte   'Valor de porcentaje

    '    Console.WriteLine("Ingrese Cantidad")
    '    cantidad = Console.ReadLine
    '    Console.WriteLine(vbCrLf & "Ingrese Precio")
    '    precio = Console.ReadLine
    '    subtotal = cantidad * precio

    '    Console.WriteLine(vbCrLf & "SUBTOTAL: " & subtotal)

    '    Select Case cantidad
    '        Case 10 To 50
    '            porcentaje_desc = 5
    '        Case 51 To 250
    '            porcentaje_desc = 10
    '        Case Is > 250
    '            porcentaje_desc = 20
    '    End Select

    '    descuento = subtotal * porcentaje_desc / 100.0
    '    Console.WriteLine(vbCrLf & "DESCUENTO DE " & porcentaje_desc & "%: " & descuento)
    '    Console.WriteLine(vbCrLf & "TOTAL: " & subtotal - descuento)

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 2.7 -------------------------

    'Sub Main()

    '    Dim valor As Short

    '    Console.WriteLine("Ingrese un valor: " & vbCrLf)
    '    valor = Console.ReadLine

    '    If valor > 0 Then
    '        If valor < 90 Then
    '            valor = 1
    '        ElseIf valor = 90 Then
    '            valor = 2
    '        ElseIf valor < 180 Then
    '            valor = 3
    '        ElseIf valor = 180 Then
    '            valor = 4
    '        ElseIf valor < 360 Then
    '            valor = 5
    '        ElseIf valor = 360 Then
    '            valor = 6
    '        End If
    '    End If

    '    Select Case valor
    '        Case 1
    '            Console.WriteLine(vbCrLf & "Es un ángulo Agudo")
    '        Case 2
    '            Console.WriteLine(vbCrLf & "Es un ángulo Recto")
    '        Case 3
    '            Console.WriteLine(vbCrLf & "Es un ángulo Obtuso")
    '        Case 4
    '            Console.WriteLine(vbCrLf & "Es un ángulo Llano")
    '        Case 5
    '            Console.WriteLine(vbCrLf & "Es un ángulo Cóncavo")
    '        Case 6
    '            Console.WriteLine(vbCrLf & "Es un ángulo Completo")
    '        Case 0
    '            Console.WriteLine(vbCrLf & "Es un ángulo Nulo")
    '        Case Else
    '            Console.WriteLine(vbCrLf & "ERROR!!!")
    '    End Select

    '    Console.ReadKey()

    'End Sub



    '-------------------------- EJERCICIO 2.8 -------------------------

    Enum meses_anio
        enero = 1
        febrero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12
    End Enum

    Sub Main()

        Dim mes As Byte
        Dim anio As UShort
        Dim dias As Byte

        Console.WriteLine("Ingrese un mes (1 al 12)" & vbCrLf)
        mes = Console.ReadLine()

        Select Case mes
            Case meses_anio.enero
                ' Console.WriteLine(vbCrLf & "Se ingresó Enero y tiene " & dias & " días")
                Console.WriteLine(vbCrLf & "Se ingresó Enero y tiene 31 días")
            Case meses_anio.febrero
                Console.WriteLine(vbCrLf & "Ingrese el año" & vbCrLf)
                anio = Console.ReadLine()
                ' Si es Febrero, evaluo si el año es bisiesto o no y asigno la cantidad de dias
                If anio Mod 400 = 0 Or anio Mod 4 = 0 And anio Mod 100 <> 0 Then
                    dias = 29
                Else
                    dias = 28
                End If
                Console.WriteLine(vbCrLf & "Se ingresó Febrero de " & anio & " y tiene " & dias & " días")
            Case meses_anio.marzo
                Console.WriteLine(vbCrLf & "Se ingresó Marzo y tiene 31 días")
            Case meses_anio.abril
                Console.WriteLine(vbCrLf & "Se ingresó Abril y tiene 30 días")
            Case meses_anio.mayo
                Console.WriteLine(vbCrLf & "Se ingresó Mayo y tiene 31 días")
            Case meses_anio.junio
                Console.WriteLine(vbCrLf & "Se ingresó Junio y tiene 30 días")
            Case meses_anio.julio
                Console.WriteLine(vbCrLf & "Se ingresó Julio y tiene 31 días")
            Case meses_anio.agosto
                Console.WriteLine(vbCrLf & "Se ingresó Agosto y tiene 31 días")
            Case meses_anio.septiembre
                Console.WriteLine(vbCrLf & "Se ingresó Septiembre y tiene 30 días")
            Case meses_anio.octubre
                Console.WriteLine(vbCrLf & "Se ingresó Octubre y tiene 31 días")
            Case meses_anio.noviembre
                Console.WriteLine(vbCrLf & "Se ingresó Noviembre y tiene 30 días")
            Case meses_anio.diciembre
                Console.WriteLine(vbCrLf & "Se ingresó Diciembre y tiene 31 días")
            Case Else
                Console.WriteLine(vbCrLf & "Error en el valor del mes")
        End Select

        Console.ReadKey()

    End Sub



    '-------------------------- EJERCICIO 2.9 -------------------------

    'Enum unidades_medida
    '    metros = 1
    '    yardas = 2
    '    pies = 3
    '    pulgadas = 4
    'End Enum

    'Sub Main()

    '    Dim unidad_medida As Short
    '    Dim valor_convertir As Single

    '    Const centimetro As Single = 1
    '    Const metro As Single = 100.0 * centimetro
    '    Const pulgada As Single = 2.54 * centimetro
    '    Const pie As Single = 12.0 * pulgada
    '    Const yarda As Single = 3.0 * pie

    '    Console.WriteLine("Escoja la unidad de medida a convertir: " & vbCrLf)
    '    Console.WriteLine("Metros = 1" & vbCrLf & "Yardas = 2" & vbCrLf & "Pies = 3" & vbCrLf & "Pulgadas = 4" & vbCrLf)
    '    unidad_medida = Console.ReadLine()

    '    If unidad_medida < 1 Or unidad_medida > 4 Then
    '        Console.WriteLine(vbCrLf & "Valor no admitido!!!")
    '    Else
    '        Console.WriteLine(vbCrLf & "Ingrese el valor que desea convertir" & vbCrLf)
    '        valor_convertir = Console.ReadLine()

    '        Select Case unidad_medida
    '            Case unidades_medida.metros
    '                Console.WriteLine(vbCrLf & valor_convertir & " Metro/s equivale a:" & vbCrLf)
    '                Console.WriteLine(valor_convertir / pulgada * metro & " Pulgadas")
    '                Console.WriteLine(valor_convertir / pie * metro & " Pies")
    '                Console.WriteLine(valor_convertir / yarda * metro & " Yardas")
    '                Console.WriteLine(valor_convertir / centimetro * 100 & " Centimetros")
    '            Case unidades_medida.pies
    '                Console.WriteLine(vbCrLf & valor_convertir & " Pie/s equivale a:" & vbCrLf)
    '                Console.WriteLine(valor_convertir / metro * pie & " Metros")
    '                Console.WriteLine(valor_convertir / pulgada * pie & " Pulgadas")
    '                Console.WriteLine(valor_convertir / yarda * pie & " Yardas")
    '                Console.WriteLine(valor_convertir / centimetro * pie & " Centimetros")
    '            Case unidades_medida.pulgadas
    '                Console.WriteLine(vbCrLf & valor_convertir & " Pulgada/s equivale a:" & vbCrLf)
    '                Console.WriteLine(valor_convertir / metro * pulgada & " Metros")
    '                Console.WriteLine(valor_convertir / pie * pulgada & " Pies")
    '                Console.WriteLine(valor_convertir / yarda * pulgada & " Yardas")
    '                Console.WriteLine(valor_convertir / centimetro * pulgada & " Centimetros")
    '            Case unidades_medida.yardas
    '                Console.WriteLine(vbCrLf & valor_convertir & " Yarda/s equivale a:" & vbCrLf)
    '                Console.WriteLine(valor_convertir / metro * yarda & " Metros")
    '                Console.WriteLine(valor_convertir / pie * yarda & " Pies")
    '                Console.WriteLine(valor_convertir / pulgada * yarda & " Pulgadas")
    '                Console.WriteLine(valor_convertir / centimetro * yarda & " Centimetros")
    '        End Select
    '    End If

    '    Console.ReadLine()

    'End Sub

End Module


