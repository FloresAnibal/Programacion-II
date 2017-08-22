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

        loro_1.Escuchar("Papita")
        loro_1.Escuchar("pa el loro")
        loro_1.Escuchar("Juan")

        Console.WriteLine(loro_1.Hablar)
        Console.WriteLine(loro_1.Hablar)
        Console.WriteLine(loro_1.Hablar)
        Console.WriteLine(loro_1.Hablar & vbCrLf)
        '-----------------------------------------------------------------------------
        cotorra_1.Nombre = "Sara"
        cotorra_1.FechaNacimiento = #10-06-1998#

        Console.WriteLine("Nombre de la cotorra: " & cotorra_1.Nombre)
        Console.WriteLine("Fecha de Nacimiento: " & cotorra_1.FechaNacimiento)
        Console.WriteLine("Edad: " & cotorra_1.Edad)
        Console.WriteLine("Edad Humana: " & cotorra_1.EdadHumana)

        cotorra_1.Escuchar("Papita")
        cotorra_1.Escuchar("pa la cotorra")
        cotorra_1.Escuchar("Juana")
        cotorra_1.Escuchar("que esta")
        cotorra_1.Escuchar("con hambre")

        Console.WriteLine("Primera Vez... " & cotorra_1.Hablar)
        Console.WriteLine("Segunda Vez... " & cotorra_1.Hablar)
        Console.WriteLine("Tercera Vez... " & cotorra_1.Hablar)
        Console.WriteLine("Cuarta Vez... " & cotorra_1.Hablar & vbCrLf)
        '-----------------------------------------------------------------------------
        cotorra_2.Nombre = "Tere"
        cotorra_2.FechaNacimiento = #02-05-2000#

        Console.WriteLine("Nombre de la cotorra: " & cotorra_2.Nombre)
        Console.WriteLine("Fecha de Nacimiento: " & cotorra_2.FechaNacimiento)
        Console.WriteLine("Edad: " & cotorra_2.Edad)
        Console.WriteLine("Edad Humana: " & cotorra_2.EdadHumana)

        cotorra_2.Escuchar("Papita")
        cotorra_2.Escuchar("pa la cotorra")
        cotorra_2.Escuchar("Juana")
        cotorra_2.Escuchar("que esta")
        cotorra_2.Escuchar("con hambre")

        Console.WriteLine("Primera Vez... " & cotorra_2.Hablar)
        Console.WriteLine("Segunda Vez... " & cotorra_2.Hablar)
        Console.WriteLine("Tercera Vez... " & cotorra_2.Hablar)
        Console.WriteLine("Cuarta Vez... " & cotorra_2.Hablar & vbCrLf)
        '-----------------------------------------------------------------------------
        cotorra_3.Nombre = "Gaby"
        cotorra_3.FechaNacimiento = #11-23-2005#

        Console.WriteLine("Nombre de la cotorra: " & cotorra_3.Nombre)
        Console.WriteLine("Fecha de Nacimiento: " & cotorra_3.FechaNacimiento)
        Console.WriteLine("Edad: " & cotorra_3.Edad)
        Console.WriteLine("Edad Humana: " & cotorra_3.EdadHumana)

        cotorra_3.Escuchar("Papita")
        cotorra_3.Escuchar("pa la cotorra")
        cotorra_3.Escuchar("Juana")
        cotorra_3.Escuchar("que esta")
        cotorra_3.Escuchar("con hambre")

        Console.WriteLine("Primera Vez... " & cotorra_3.Hablar)
        Console.WriteLine("Segunda Vez... " & cotorra_3.Hablar)
        Console.WriteLine("Tercera Vez... " & cotorra_3.Hablar)
        Console.WriteLine("Cuarta Vez... " & cotorra_3.Hablar & vbCrLf)
        '-----------------------------------------------------------------------------
        cotorra_4.Nombre = "Clara"
        cotorra_4.FechaNacimiento = #04-17-2009#

        Console.WriteLine("Nombre de la cotorra: " & cotorra_4.Nombre)
        Console.WriteLine("Fecha de Nacimiento: " & cotorra_4.FechaNacimiento)
        Console.WriteLine("Edad: " & cotorra_4.Edad)
        Console.WriteLine("Edad Humana: " & cotorra_4.EdadHumana)

        cotorra_4.Escuchar("Papita")
        cotorra_4.Escuchar("pa la cotorra")
        cotorra_4.Escuchar("Juana")
        cotorra_4.Escuchar("que esta")
        cotorra_4.Escuchar("con hambre")

        Console.WriteLine("Primera Vez... " & cotorra_4.Hablar)
        Console.WriteLine("Segunda Vez... " & cotorra_4.Hablar)
        Console.WriteLine("Tercera Vez... " & cotorra_4.Hablar)
        Console.WriteLine("Cuarta Vez... " & cotorra_4.Hablar & vbCrLf)
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
End Module