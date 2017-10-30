Imports Entidades

Module JaulaTest
    Sub main()

        'Instancias
        Dim jaula_1 As New Jaula
        Dim loro_1 As New Loro
        Dim cotorra_1 As New Cotorra
        Dim cotorra_2 As New Cotorra
        Dim cotorra_3 As New Cotorra
        Dim cotorra_4 As New Cotorra

        jaula_1.Nombre = "Principal"
        Console.WriteLine("Nombre de la jaula: " & jaula_1.Nombre & vbCrLf)

        '-----------------------------------------------------------------------------

        loro_1.Nombre = "Lorenzo"
        loro_1.FechaNacimiento = #12/29/2003#
        Console.WriteLine("Nombre del Loro: " & loro_1.Nombre)
        Console.WriteLine("Fecha de Nacimiento: " & loro_1.FechaNacimiento)
        Console.WriteLine("Edad: " & loro_1.Edad)

        Console.WriteLine(vbCrLf & "------ ESCUCHANDO... ------" & vbCrLf)
        loro_1.Escuchar("Papita")
        Console.WriteLine("Primera Vez: Papita")
        loro_1.Escuchar("pa el loro")
        Console.WriteLine("Segunda Vez: pa el loro")
        loro_1.Escuchar("Juan")
        Console.WriteLine("Tercera Vez: Juan")

        Console.WriteLine(vbCrLf & "------ HABLANDO... ------" & vbCrLf)
        For x = 1 To 4
            Console.WriteLine(loro_1.Hablar)
        Next
        Console.WriteLine("******************************************")

        '-----------------------------------------------------------------------------

        cotorra_1.Nombre = "Sara"
        cotorra_1.FechaNacimiento = #10-06-1998#

        MostrarPorPantalla(cotorra_1)

        '-----------------------------------------------------------------------------

        cotorra_2.Nombre = "Tere"
        cotorra_2.FechaNacimiento = #02-05-2000#

        MostrarPorPantalla(cotorra_2)

        '-----------------------------------------------------------------------------

        cotorra_3.Nombre = "Gaby"
        cotorra_3.FechaNacimiento = #11-23-2005#

        MostrarPorPantalla(cotorra_3)

        '-----------------------------------------------------------------------------

        cotorra_4.Nombre = "Clara"
        cotorra_4.FechaNacimiento = #04-17-2009#

        MostrarPorPantalla(cotorra_4)

        '-----------------------------------------------------------------------------

        'Asigno a la jaula
        jaula_1.Loro = loro_1
        jaula_1.addCotorra(cotorra_1)
        jaula_1.addCotorra(cotorra_2)
        jaula_1.addCotorra(cotorra_3)
        jaula_1.addCotorra(cotorra_4)

        Console.Write("Loro: ")
        Console.WriteLine(jaula_1.Loro)

        For Each iterar As Cotorra In jaula_1.getAllCotorras
            Console.Write("Cotorra: ")
            Console.WriteLine(iterar)
        Next

        Console.WriteLine(vbCrLf & "ToString(): " & jaula_1.ToString)

        Console.ReadKey()
    End Sub

    Private Sub MostrarPorPantalla(objeto As Cotorra)
        Dim Veces = New ArrayList()
        Veces.Add("Primera Vez... ")
        Veces.Add("Segunda Vez... ")
        Veces.Add("Tercera Vez... ")
        Veces.Add("Cuarta Vez... ")

        Console.WriteLine("Nombre de la cotorra: " & objeto.Nombre)
        Console.WriteLine("Fecha de Nacimiento: " & objeto.FechaNacimiento)
        Console.WriteLine("Edad: " & objeto.Edad)
        Console.WriteLine("Edad Humana: " & objeto.EdadHumana)

        CargarEscuchar(objeto)

        Console.WriteLine(vbCrLf & "------ HABLANDO... ------" & vbCrLf)
        For x = 0 To 3
            Console.WriteLine(Veces.Item(x) & objeto.Hablar)
        Next
        Console.WriteLine("******************************************")
    End Sub

    Private Sub CargarEscuchar(objeto2 As Cotorra)
        Console.WriteLine(vbCrLf & "------ ESCUCHANDO... ------" & vbCrLf)
        objeto2.Escuchar("Papita")
        Console.WriteLine("Primera Vez: Papita")
        objeto2.Escuchar("pa la cotorra")
        Console.WriteLine("Segunda Vez: pa la cotorra")
        objeto2.Escuchar("Juana")
        Console.WriteLine("Tercera Vez: Juana")
        objeto2.Escuchar("que esta")
        Console.WriteLine("Cuarta Vez: que esta")
        objeto2.Escuchar("con hambre")
        Console.WriteLine("Quinta Vez: con hambre")
    End Sub
End Module