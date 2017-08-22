Imports Entidades

Module CotorraTest
    Sub main()

        Dim cotorra_1 As New Cotorra

        cotorra_1.Nombre = "Dora"
        cotorra_1.FechaNacimiento = #01-05-1988#

        Console.WriteLine("Nombre: " & cotorra_1.Nombre)
        Console.WriteLine("Fecha de Nacimiento: " & cotorra_1.FechaNacimiento)
        Console.WriteLine("Edad: " & cotorra_1.Edad)
        Console.WriteLine("Edad Humana: " & cotorra_1.EdadHumana)

        cotorra_1.FechaNacimiento = #12-05-1988#

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
        Console.WriteLine("Cuarta Vez... " & cotorra_1.Hablar)

        Console.ReadKey()
    End Sub
End Module
