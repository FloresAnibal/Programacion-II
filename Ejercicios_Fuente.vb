'-------------------------- EJERCICIO 1.1 --Variables--------------

    Sub Main()

        Dim nombre As String = "Anibal"
        Dim tipo_documento As String = "DNI"
        Dim numero_documento As UInteger = 29929292
        Dim localidad As String = "Posadas"
        Dim fecha_nacimiento As Date = #05/01/1983#
        Dim edad As Byte = 34
        Dim altura As Single = 1.85
        Dim estado_civil As String = "soltero"
        Dim argentino As Boolean = True

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


'-------------------------- EJERCICIO 1.2 --Variables--------------


    Public nombre As String = "Anibal"
    Friend tipo_documento As String = "DNI"
    Friend numero_documento As UInteger = 29929292
    Friend fecha_nacimiento As Date = #05/01/1983#
    Private altura As Single = 1.85
    Private estado_civil As String = "soltero"
    Private argentino As Boolean = True
    Private localidad As String = "Posadas"

    Sub Main()

        Dim edad As Byte = 34

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


    
    '-------------------------- EJERCICIO 1.3 --Variables--------------

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


 '-------------------------- EJERCICIO 1.4 --Aritmetica-------------

    Sub Main()

        Dim a As SByte = 5
        Dim b As Short = -26
        Dim c As Single = 2.5
        Dim d As Single = 13.26

        Console.WriteLine("Operaciones Aritmeticas")
        Console.WriteLine()
        Console.WriteLine("Valores: " & "A = " & a & "   B = " & b & "   C = " & c & "   D = " & d)
        Console.WriteLine()
        Console.WriteLine("Suma de Entero con Entero")
        Console.WriteLine("A + B = " & a + b)
        Console.WriteLine()
        Console.WriteLine("Suma de Entero con Punto Flotante")
        Console.WriteLine("B + C = " & b + c)
        Console.WriteLine()
        Console.WriteLine("Suma de Punto Flotante con Punto Flotante")
        Console.WriteLine("C + D = " & c + d)
        Console.WriteLine()
        Console.WriteLine("Resta de Entero con Entero")
        Console.WriteLine("A - B = " & a - b)
        Console.WriteLine()
        Console.WriteLine("Resta de Entero con Punto Flotante")
        Console.WriteLine("B - C = " & b - c)
        Console.WriteLine()
        Console.WriteLine("Resta de Punto Flotante con Punto Flotante")
        Console.WriteLine("C - D = " & c - d)
        Console.WriteLine()
        Console.WriteLine("Multiplicacion de Entero con Entero")
        Console.WriteLine("A * B = " & a * b)
        Console.WriteLine()
        Console.WriteLine("Multiplicacion de Entero con Punto Flotante")
        Console.WriteLine("B * C = " & b * c)
        Console.WriteLine()
        Console.WriteLine("Multiplicacion de Punto Flotante con Punto Flotante")
        Console.WriteLine("C * D = " & c * d)
        Console.WriteLine()
        Console.WriteLine("Division de Entero con Entero")
        Console.WriteLine("A / B = " & a / b)
        Console.WriteLine()
        Console.WriteLine("Division de Entero con Punto Flotante")
        Console.WriteLine("B / C = " & b / c)
        Console.WriteLine()
        Console.WriteLine("Division de Punto Flotante con Punto Flotante")
        Console.WriteLine("C / D = " & c / d)

        Console.ReadKey()

    End Sub



 '-------------------------- EJERCICIO 1.5 --Aritmetica-------------

 Sub Main()

        Dim a As Integer = 1
        Dim b As Integer = 5
        Dim c As Integer = 2

        Console.WriteLine("X = " & (b ^ 2 - 4 * a * c) / (2 * a))

        Console.ReadKey()

    End Sub



    '-------------------------- EJERCICIO 1.6 --Aritmetica-------------


    Sub Main()

        Dim a As Integer = 8
        Dim b As Integer = 14
        Dim c As Integer = 5
        Dim d As Integer = 26

        Console.WriteLine("Valores: " & "A = " & a & "   B = " & b & "   C = " & c & "   D = " & d)
        Console.WriteLine("La sumatoria es: " & a + b + c + d)
        Console.WriteLine("La media de los valores es : " & (a + b + c + d) / 4)
       
        Console.ReadKey()

    End Sub



'-------------------------- EJERCICIO 1.7 --Semanas----------------

    Sub Main()

        Const dias_del_anio As Integer = 365
        Const dias_laborables As Integer = 250
        Const dias_de_la_semana As Integer = 7

        Console.WriteLine("El año cuenta con " & Convert.ToInt32(dias_del_anio / dias_de_la_semana) & " semanas")
        Console.WriteLine("El año cuenta con " & Convert.ToInt32(dias_laborables / dias_de_la_semana) & " semanas laborables")

        Console.ReadKey()

    End Sub



 '-------------------------- EJERCICIO 1.8 --Concatenacion----------

     Sub main()

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



  '-------------------------- EJERCICIO 1.9 --Booleano---------------

    Sub Main()

        Const v As Boolean = True
        Const f As Boolean = False

        Console.WriteLine("--------------AND--------------")
        Console.WriteLine("| Exp1 || Exp2 || Exp1 Y Exp2 |")
        Console.WriteLine("|  V   ||  V   ||    " & (v And v) & "     |")
        Console.WriteLine("|  V   ||  F   ||    " & (v And f) & "    |")
        Console.WriteLine("|  F   ||  V   ||    " & (f And v) & "    |")
        Console.WriteLine("|  F   ||  F   ||    " & (f And f) & "    |")
        Console.WriteLine("------------------------------")
        Console.WriteLine()
        Console.WriteLine("--------NOT--------")
        Console.WriteLine("| Exp1 || NO Exp1 |")
        Console.WriteLine("|  V   ||  " & (Not v) & "  |")
        Console.WriteLine("|  F   ||  " & (Not f) & "   |")
        Console.WriteLine("-------------------")
        Console.WriteLine()
        Console.WriteLine("--------------OR--------------")
        Console.WriteLine("| Exp1 || Exp2 || Exp1 O Exp2|")
        Console.WriteLine("|  V   ||  V   ||    " & (v Or v) & "    |")
        Console.WriteLine("|  V   ||  F   ||    " & (v Or f) & "    |")
        Console.WriteLine("|  F   ||  V   ||    " & (f Or v) & "    |")
        Console.WriteLine("|  F   ||  F   ||    " & (f Or f) & "   |")
        Console.WriteLine("------------------------------")
        Console.WriteLine()
        Console.WriteLine("-------------Xor---------------")
        Console.WriteLine("| Exp1 || Exp2 || Exp1 Xor Exp2|")
        Console.WriteLine("|  V   ||  V   ||    " & (v Xor v) & "     |")
        Console.WriteLine("|  V   ||  F   ||    " & (v Xor f) & "      |")
        Console.WriteLine("|  F   ||  V   ||    " & (f Xor v) & "      |")
        Console.WriteLine("|  F   ||  F   ||    " & (f Xor f) & "     |")
        Console.WriteLine("--------------------------------")

        Console.ReadKey()

    End Sub



    '-------------------------- EJERCICIO 1.10 --Aritmetica-------------

    Sub Main()

        Dim monto As Integer
        Dim interes As Single
        Dim interes_producido As Single
        Dim tiempo As UShort
        Dim capital As UShort

        Console.WriteLine("Ingrese el monto: ")
        monto = Console.ReadLine()
        Console.WriteLine(vbCrLf & "Ingrese el interes: ")
        interes = Console.ReadLine()
        Console.WriteLine(vbCrLf & "Ingrese el tiempo: ")
        tiempo = Console.ReadLine()

        interes_producido = monto * interes * tiempo / (360 * 100)
        Console.WriteLine(vbCrLf & "El interes producido es de: " & interes_producido)
        Console.WriteLine(vbCrLf & "El capital es de: " & monto + capital)

        Console.ReadKey()

    End Sub



     '-------------------------- EJERCICIO 1.11 --Matematica-------------

    Sub Main()

        Dim a As Single
        Console.WriteLine("Ingresar Valor: ")
        a = Console.ReadLine()

        Console.WriteLine("Valor absoluto: " & Math.Abs(a))
        Console.WriteLine("Elevado a la 10: " & Math.Pow(a, 10))
        Console.WriteLine("Valor redondeado: " & Math.Sqrt(a))

        Console.ReadKey()

    End Sub



     '-------------------------- EJERCICIO 1.12 --Matematica-------------

    Sub Main()

        Dim a As Single
        Console.WriteLine("Ingresar Valor: ")
        a = Console.ReadLine()

        Console.WriteLine("Valor aproximado por exceso: " & Math.Ceiling(a))
        Console.WriteLine("Valor aproximado por defecto: " & Math.Floor(a))
        Console.WriteLine("Raiz cuadrada: " & Math.Round(a))

        Console.ReadKey()

    End Sub


 '-------------------------- EJERCICIO 1.13 --Matematica-------------

     Sub Main()

        Dim a As Single = 5
        Dim b As Single = 34.6
        Dim c As Single = 23

        Console.WriteLine("El mayor de los valores es: " & Math.Max(a, Math.Max(b, c)))

        Console.ReadKey()

    End Sub



    '-------------------------- EJERCICIO 1.14 --Fechas-----------------

    Sub Main()

        Dim fecha As Date = Date.Now
        Console.WriteLine("Dia del Año: " & fecha.DayOfYear & vbCrLf)
        Console.WriteLine("Mes: " & fecha.Month & vbCrLf)
        Console.WriteLine("Hora: " & fecha.Hour & vbCrLf)
        Console.WriteLine("Minuto: " & fecha.Minute & vbCrLf)

        Console.ReadKey()

    End Sub



     '-------------------------- EJERCICIO 1.15 --Fechas-----------------

    Sub Main()

       Dim dato_dia As UShort
        Dim dato_hora As UShort
        Dim fecha As Date = Now

        Console.WriteLine("Ingrese un numero (1 a 31)")
        dato_dia = Console.ReadLine()
        Console.WriteLine("Ingrese un numero (0 a 24)")
        dato_hora = Console.ReadLine()

        Console.WriteLine(New Date(fecha.Year, fecha.Month, dato_dia, dato_hora, fecha.Minute, 0))

        Console.ReadKey()

    End Sub



     '-------------------------- EJERCICIO 1.16 --Fechas-----------------

    Sub Main()

        Dim fecha As Date = #04-06-2015#
        Dim dias As UShort = 29

        Console.WriteLine("Fecha dada = " & fecha)
        Console.WriteLine("Dias a sumar = " & dias)
        Console.WriteLine()
        Console.WriteLine(fecha.AddDays(dias))

        Console.ReadKey()

    End Sub



    
    '-------------------------- EJERCICIO 1.17 --Fechas-----------------

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



 '-------------------------- EJERCICIO 2.1 --sientonces-------------
    Sub Main()

        Dim valor_1 As Integer
        Dim valor_2 As Integer

        Console.WriteLine("Ingrese valor")
        valor_1 = Console.ReadLine
        Console.WriteLine()
        Console.WriteLine("Ingrese siguiente valor")
        valor_2 = Console.ReadLine
        Console.WriteLine()

        If valor_1 < valor_2 Then
            Console.WriteLine(valor_1 & " es menor a " & valor_2)
        ElseIf valor_1 > valor_2 Then
            Console.WriteLine(valor_1 & " es mayor a " & valor_2)
        Else
            Console.WriteLine(valor_1 & " y " & valor_2 & " son iguales")
        End If

        Console.ReadKey()

    End Sub



 '-------------------------- EJERCICIO 2.2 --sientonces-------------

    Sub Main()

        Dim valor_1 As Integer
        Dim valor_2 As Integer
        Dim valor_3 As Integer

        Console.WriteLine("Ingrese Primer Valor")
        valor_1 = Console.ReadLine
        Console.WriteLine(vbCrLf & "Ingrese Segundo Valor")
        valor_2 = Console.ReadLine
        Console.WriteLine(vbCrLf & "Ingrese Tercer Valor")
        valor_3 = Console.ReadLine

        If valor_1 > valor_2 Then
            valor_1 = valor_2
        End If
        If valor_3 < valor_1 Then
            valor_1 = valor_3
        End If

        Console.WriteLine(vbCrLf & "El menor valor es = " & valor_1)

        Console.ReadKey()

    End Sub



     '-------------------------- EJERCICIO 2.3 --sientonces-------------

    Sub Main()

        Dim valor_1 As Integer
        Dim valor_2 As Integer
        Dim posicion As String = "Primer"

        Console.WriteLine("Ingrese Primer Valor")
        valor_1 = Console.ReadLine
        Console.WriteLine(vbCrLf & "Ingrese Segundo Valor")
        valor_2 = Console.ReadLine

        If valor_1 = valor_2 Then
            posicion += " y Segundo"
        ElseIf valor_1 < valor_2 Then
            valor_1 = valor_2
            posicion = "Segundo"
        End If

        Console.WriteLine(vbCrLf & "Ingrese Tercer Valor")
        valor_2 = Console.ReadLine

        If valor_1 = valor_2 Then
            posicion += " y Tercer"
        ElseIf valor_1 < valor_2 Then
            valor_1 = valor_2
            posicion = "Tercer"
        End If

        Console.WriteLine(vbCrLf & "Ingrese Cuarto Valor")
        valor_2 = Console.ReadLine

        If valor_1 = valor_2 Then
            posicion += " y Cuarto"
        ElseIf valor_1 < valor_2 Then
            valor_1 = valor_2
            posicion = "Cuarto"
        End If

        Console.WriteLine(vbCrLf & "Ingrese Quinto Valor")
        valor_2 = Console.ReadLine

        If valor_1 = valor_2 Then
            posicion += " y Quinto"
        ElseIf valor_1 < valor_2 Then
            valor_1 = valor_2
            posicion = "Quinto"
        End If

        Console.WriteLine(vbCrLf & "El " & posicion & " numero es/son el/los de mayor valor")

        Console.ReadKey()

    End Sub



     '-------------------------- EJERCICIO 2.4 --sientonces-------------

      Sub Main()

        Dim cantidad As Integer
        Dim precio As Single
        Dim subtotal As Single
        Dim descuento As Single = 0
        Dim porcentaje_desc As Byte = 0  'Valor de porcentaje

        Console.WriteLine("Ingrese Cantidad")
        cantidad = Console.ReadLine
        Console.WriteLine(vbCrLf & "Ingrese Precio")
        precio = Console.ReadLine

        subtotal = cantidad * precio

        Console.WriteLine(vbCrLf & "SUBTOTAL: " & subtotal)

        If cantidad >= 10 Then
            If cantidad <= 50 Then
                porcentaje_desc = 5
            ElseIf cantidad <= 250 Then
                porcentaje_desc = 10
            Else
                porcentaje_desc = 20
            End If
        End If

        descuento = subtotal * porcentaje_desc / 100.0

        Console.WriteLine(vbCrLf & "DESCUENTO DE " & porcentaje_desc & "%: " & descuento)
        Console.WriteLine(vbCrLf & "TOTAL: " & subtotal - descuento)

        Console.ReadKey()

    End Sub



     '-------------------------- EJERCICIO 2.5 --sientonces-------------

    Sub Main()

        Dim mes As Byte

        Console.WriteLine("Ingrese un numero del 1 al 12")
        mes = Console.ReadLine()

        Select Case mes
            Case 1
                Console.WriteLine("Enero")
            Case 2
                Console.WriteLine("Febrero")
            Case 3
                Console.WriteLine("Marzo")
            Case 4
                Console.WriteLine("Abril")
            Case 5
                Console.WriteLine("Mayo")
            Case 6
                Console.WriteLine("Junio")
            Case 7
                Console.WriteLine("Julio")
            Case 8
                Console.WriteLine("Agosto")
            Case 9
                Console.WriteLine("Septiembre")
            Case 10
                Console.WriteLine("Octubre")
            Case 11
                Console.WriteLine("Noviembre")
            Case 12
                Console.WriteLine("Diciembre")
            Case Else
                Console.WriteLine("Valor Incorrecto")
        End Select

        Console.ReadLine()

    End Sub



 '-------------------------- EJERCICIO 2.6 --sientonces-------------

        Sub Main()

        Dim cantidad As Integer
        Dim precio As Single
        Dim subtotal As Single
        Dim descuento As Single = 0
        Dim porcentaje_desc As Byte   'Valor de porcentaje

        Console.WriteLine("Ingrese Cantidad")
        cantidad = Console.ReadLine
        Console.WriteLine(vbCrLf & "Ingrese Precio")
        precio = Console.ReadLine
        subtotal = cantidad * precio

        Console.WriteLine(vbCrLf & "SUBTOTAL: " & subtotal)

        Select Case cantidad
            Case 10 To 50
                porcentaje_desc = 5
            Case 51 To 250
                porcentaje_desc = 10
            Case Is > 250
                porcentaje_desc = 20
        End Select

        descuento = subtotal * porcentaje_desc / 100.0
        Console.WriteLine(vbCrLf & "DESCUENTO DE " & porcentaje_desc & "%: " & descuento)
        Console.WriteLine(vbCrLf & "TOTAL: " & subtotal - descuento)

        Console.ReadKey()

    End Sub



 '-------------------------- EJERCICIO 2.7 --sientonces-------------

    Sub Main()

        Dim valor As Short

        Console.WriteLine("Ingrese un valor: " & vbCrLf)
        valor = Console.ReadLine

        If valor > 0 Then
            If valor < 90 Then
                valor = 1
            ElseIf valor = 90 Then
                valor = 2
            ElseIf valor < 180 Then
                valor = 3
            ElseIf valor = 180 Then
                valor = 4
            ElseIf valor < 360 Then
                valor = 5
            ElseIf valor = 360 Then
                valor = 6
            End If
        End If

        Select Case valor
            Case 1
                Console.WriteLine(vbCrLf & "Es un ángulo Agudo")
            Case 2
                Console.WriteLine(vbCrLf & "Es un ángulo Recto")
            Case 3
                Console.WriteLine(vbCrLf & "Es un ángulo Obtuso")
            Case 4
                Console.WriteLine(vbCrLf & "Es un ángulo Llano")
            Case 5
                Console.WriteLine(vbCrLf & "Es un ángulo Cóncavo")
            Case 6
                Console.WriteLine(vbCrLf & "Es un ángulo Completo")
            Case 0
                Console.WriteLine(vbCrLf & "Es un ángulo Nulo")
            Case Else
                Console.WriteLine(vbCrLf & "ERROR!!!")
        End Select

        Console.ReadKey()

    End Sub



    
    '-------------------------- EJERCICIO 2.8 --sientonces-------------

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

        If mes = meses_anio.febrero Then
            Console.WriteLine(vbCrLf & "Ingrese el año" & vbCrLf)
            anio = Console.ReadLine()
            ' Si es Febrero, evaluo si el año es bisiesto o no y asigno la cantidad de dias
            If anio Mod 400 = 0 Or anio Mod 4 = 0 And anio Mod 100 <> 0 Then
                dias = 29
            Else
                dias = 28
            End If
            ' Si no es Febrero, evaluo si es un mes de 30 o 31 dias
        ElseIf mes < 8 And mes Mod 2 <> 0 Or mes > 7 And mes Mod 2 = 0 Then
            dias = 31
        Else
            dias = 30
        End If

        Select Case mes
            Case meses_anio.enero
                Console.WriteLine(vbCrLf & "Se ingresó Enero y tiene " & dias & " días")
            Case meses_anio.febrero
                Console.WriteLine(vbCrLf & "Se ingresó Febrero de " & anio & " y tiene " & dias & " días")
            Case meses_anio.marzo
                Console.WriteLine(vbCrLf & "Se ingresó Marzo y tiene " & dias & " días")
            Case meses_anio.abril
                Console.WriteLine(vbCrLf & "Se ingresó Abril y tiene " & dias & " días")
            Case meses_anio.mayo
                Console.WriteLine(vbCrLf & "Se ingresó Mayo y tiene " & dias & " días")
            Case meses_anio.junio
                Console.WriteLine(vbCrLf & "Se ingresó Junio y tiene " & dias & " días")
            Case meses_anio.julio
                Console.WriteLine(vbCrLf & "Se ingresó Julio y tiene " & dias & " días")
            Case meses_anio.agosto
                Console.WriteLine(vbCrLf & "Se ingresó Agosto y tiene " & dias & " días")
            Case meses_anio.septiembre
                Console.WriteLine(vbCrLf & "Se ingresó Septiembre y tiene " & dias & " días")
            Case meses_anio.octubre
                Console.WriteLine(vbCrLf & "Se ingresó Octubre y tiene " & dias & " días")
            Case meses_anio.noviembre
                Console.WriteLine(vbCrLf & "Se ingresó Noviembre y tiene " & dias & " días")
            Case meses_anio.diciembre
                Console.WriteLine(vbCrLf & "Se ingresó Diciembre y tiene " & dias & " días")
            Case Else
                Console.WriteLine(vbCrLf & "Error en el valor del mes")
        End Select

        Console.ReadKey()

    End Sub



    '-------------------------- EJERCICIO 2.9 --sientonces-------------

     Enum unidades_medida
        metros = 1
        yardas = 2
        pies = 3
        pulgadas = 4
    End Enum

    Sub Main()

        Dim unidad_medida As Short
        Dim valor_convertir As Single

        Const centimetro As Single = 1
        Const metro As Single = 100.0 * centimetro
        Const pulgada As Single = 2.54 * centimetro
        Const pie As Single = 12.0 * pulgada
        Const yarda As Single = 3.0 * pie

        Console.WriteLine("Escoja la unidad de medida a convertir: " & vbCrLf)
        Console.WriteLine("Metros = 1" & vbCrLf & "Yardas = 2" & vbCrLf & "Pies = 3" & vbCrLf & "Pulgadas = 4" & vbCrLf)
        unidad_medida = Console.ReadLine()

        If unidad_medida < 1 Or unidad_medida > 4 Then
            Console.WriteLine(vbCrLf & "Valor no admitido!!!")
        Else
            Console.WriteLine(vbCrLf & "Ingrese el valor que desea convertir" & vbCrLf)
            valor_convertir = Console.ReadLine()

            Select Case unidad_medida
                Case unidades_medida.metros
                    Console.WriteLine(vbCrLf & valor_convertir & " Metro/s equivale a:" & vbCrLf)
                    Console.WriteLine(valor_convertir / pulgada * metro & " Pulgadas")
                    Console.WriteLine(valor_convertir / pie * metro & " Pies")
                    Console.WriteLine(valor_convertir / yarda * metro & " Yardas")
                    Console.WriteLine(valor_convertir / centimetro * 100 & " Centimetros")
                Case unidades_medida.pies
                    Console.WriteLine(vbCrLf & valor_convertir & " Pie/s equivale a:" & vbCrLf)
                    Console.WriteLine(valor_convertir / metro * pie & " Metros")
                    Console.WriteLine(valor_convertir / pulgada * pie & " Pulgadas")
                    Console.WriteLine(valor_convertir / yarda * pie & " Yardas")
                    Console.WriteLine(valor_convertir / centimetro * pie & " Centimetros")
                Case unidades_medida.pulgadas
                    Console.WriteLine(vbCrLf & valor_convertir & " Pulgada/s equivale a:" & vbCrLf)
                    Console.WriteLine(valor_convertir / metro * pulgada & " Metros")
                    Console.WriteLine(valor_convertir / pie * pulgada & " Pies")
                    Console.WriteLine(valor_convertir / yarda * pulgada & " Yardas")
                    Console.WriteLine(valor_convertir / centimetro * pulgada & " Centimetros")
                Case unidades_medida.yardas
                    Console.WriteLine(vbCrLf & valor_convertir & " Yarda/s equivale a:" & vbCrLf)
                    Console.WriteLine(valor_convertir / metro * yarda & " Metros")
                    Console.WriteLine(valor_convertir / pie * yarda & " Pies")
                    Console.WriteLine(valor_convertir / pulgada * yarda & " Pulgadas")
                    Console.WriteLine(valor_convertir / centimetro * yarda & " Centimetros")
            End Select
        End If

        Console.ReadLine()

    End Sub



    '-------------------------- EJERCICIO 2.10 --estructuras_repetitivas
    Sub Main()
        Dim valor1, valor2, aux_valor1 As Integer
        Dim cantidad_multiplos As UShort

        Console.WriteLine("Ingrese un valor: ")
        valor1 = Console.ReadLine()
        Console.WriteLine("Ingrese otro valor (mayor al primero): ")
        valor2 = Console.ReadLine()

        Console.WriteLine(vbCrLf & "----- DO WHILE LOOP -----")
        Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

        aux_valor1 = valor1

        Do While aux_valor1 <= valor2

            If aux_valor1 Mod 5 = 0 Then
                Console.WriteLine(aux_valor1)
                cantidad_multiplos += 1
            End If
            aux_valor1 += 1

        Loop
        If cantidad_multiplos = 0 Then
            Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
        Else
            Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
        End If

        '------------------------------------------------------------------------------------------

        Console.WriteLine(vbCrLf & "----- DO LOOP WHILE -----")
        Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

        aux_valor1 = valor1
        cantidad_multiplos = 0

        Do

            If aux_valor1 Mod 5 = 0 Then
                Console.WriteLine(aux_valor1)
                cantidad_multiplos += 1
            End If
            aux_valor1 += 1

        Loop While aux_valor1 <= valor2
        If cantidad_multiplos = 0 Then
            Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
        Else
            Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
        End If

        '------------------------------------------------------------------------------------------

        Console.WriteLine(vbCrLf & "----- DO UNTIL LOOP -----")
        Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

        aux_valor1 = valor1
        cantidad_multiplos = 0

        Do Until aux_valor1 > valor2

            If aux_valor1 Mod 5 = 0 Then
                Console.WriteLine(aux_valor1)
                cantidad_multiplos += 1
            End If
            aux_valor1 += 1

        Loop
        If cantidad_multiplos = 0 Then
            Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
        Else
            Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
        End If

        '------------------------------------------------------------------------------------------

        Console.WriteLine(vbCrLf & "----- DO LOOP UNTIL -----")
        Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

        aux_valor1 = valor1
        cantidad_multiplos = 0

        Do

            If aux_valor1 Mod 5 = 0 Then
                Console.WriteLine(aux_valor1)
                cantidad_multiplos += 1
            End If
            aux_valor1 += 1

        Loop Until aux_valor1 > valor2
        If cantidad_multiplos = 0 Then
            Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
        Else
            Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
        End If

        '------------------------------------------------------------------------------------------

        Console.WriteLine(vbCrLf & "----- FOR NEXT -----")
        Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

        cantidad_multiplos = 0

        For aux_valor1 = valor1 To valor2

            If aux_valor1 Mod 5 = 0 Then
                Console.WriteLine(aux_valor1)
                cantidad_multiplos += 1
            End If

        Next
        If cantidad_multiplos = 0 Then
            Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
        Else
            Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
        End If

        Console.ReadKey()

    End Sub


     '-------------------------- EJERCICIO 2.11 --estructuras_repetitivas

    Sub Main()

        Dim valor As Integer
        Dim pares As Short
        Dim impares As Short
        Dim validar As Boolean

        Do
            Console.WriteLine("Ingrese un valor o 0 para salir")
            valor = Console.ReadLine()
            If valor > 0 Then
                validar = True ' Para validar que se ingreso al menos 1 valor positivo
                If valor Mod 2 = 0 Then
                    pares += 1
                Else
                    impares += 1
                End If
            End If
        Loop While valor <> 0
        If validar Then
            If pares = 0 Then
                Console.WriteLine("Todos son impares")
            ElseIf impares = 0 Then
                Console.WriteLine("Todos son pares")
            Else
                Console.WriteLine("Pares: " & pares)
                Console.WriteLine("Impares: " & impares)
            End If
        Else
            Console.WriteLine("No se ingresó numeros positivos")
        End If

        Console.ReadKey()

    End Sub



     '-------------------------- EJERCICIO 2.12 --estructuras_repetitivas

    Sub Main()

        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 1

        Console.WriteLine("--- Sucesion de Fibonacci ---")
        Console.WriteLine(valor1)
        Console.WriteLine(valor2)

        For inicio = 1 To 10    ' Imprimo 2 valores por iteracion asi que el FIN del FOR debe ser la mitad del total a mostrar
            valor1 += valor2
            Console.WriteLine(valor1)
            valor2 += valor1
            Console.WriteLine(valor2)
        Next

        Console.ReadKey()

    End Sub


 '-------------------------- EJERCICIO 2.13 --estructuras_repetitivas

     Sub Main()

        Dim divisor As UShort
        Dim primo As Integer

        For valor = 1 To 1000
            divisor = 1
            primo = 0
            Do
                If valor Mod divisor = 0 Then
                    primo += 1
                End If
                divisor += 1
            Loop While divisor <= valor
            If primo = 2 Then
                Console.Write("|" & valor)
            End If
        Next

        Console.ReadKey()
    End Sub


'-------------------------- EJERCICIO 2.14 --estructuras_repetitivas

 Sub Main()

        Dim cantidad As Integer
        Dim precio As Single
        Dim subtotal As Single
        Dim descuento As Single = 0
        Dim porcentaje_desc As Byte = 0  'Valor de porcentaje
        Dim total_descuento As Single
        Dim total As Single

        Do
            Console.WriteLine("Ingrese Cantidad")
            cantidad = Console.ReadLine
            If cantidad = 0 Then
                Exit Do
            End If
            Console.WriteLine(vbCrLf & "Ingrese Precio")
            precio = Console.ReadLine

            subtotal = cantidad * precio

            Console.WriteLine(vbCrLf & "SUBTOTAL: " & subtotal)

            If cantidad >= 10 Then
                If cantidad <= 50 Then
                    porcentaje_desc = 5
                ElseIf cantidad <= 250 Then
                    porcentaje_desc = 10
                Else
                    porcentaje_desc = 20
                End If
            End If

            descuento = subtotal * porcentaje_desc / 100.0
            total_descuento += descuento
            total += subtotal - descuento

            Console.WriteLine(vbCrLf & "DESCUENTO DE " & porcentaje_desc & "%: " & descuento)
            Console.WriteLine(vbCrLf & "TOTAL: " & subtotal - descuento)
            Console.WriteLine(vbCrLf & "---------------------------------" & vbCrLf)
        Loop

        Console.WriteLine(vbCrLf & "TOTAL DE DESCUENTOS: " & total_descuento)
        Console.WriteLine(vbCrLf & "TOTAL A ABONAR: " & total)

        Console.ReadKey()

    End Sub


'-------------------------- EJERCICIO 2.15 --estructuras_repetitivas

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