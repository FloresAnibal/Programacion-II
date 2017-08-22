Imports Entidades

Module LoroTest

    Sub Main()

        Dim loro_1 As New Loro
        loro_1.Nombre = "Paco"
        loro_1.FechaNacimiento = #08/20/1983#

        Console.WriteLine("Nombre: " & loro_1.Nombre)
        Console.WriteLine("Fecha de Nacimiento: " & loro_1.FechaNacimiento)
        Console.WriteLine("Edad: " & loro_1.Edad)

        loro_1.FechaNacimiento = #09/29/1983#
        Console.WriteLine("Fecha de Nacimiento: " & loro_1.FechaNacimiento)
        Console.WriteLine("Edad: " & loro_1.Edad)

        Console.WriteLine("ToString(): " & loro_1.ToString)

        loro_1.Escuchar("Papita")
        loro_1.Escuchar("pa el loro")
        loro_1.Escuchar("Juan")

        Console.WriteLine(loro_1.Hablar)
        Console.WriteLine(loro_1.Hablar)
        Console.WriteLine(loro_1.Hablar)
        Console.WriteLine(loro_1.Hablar)

        Console.ReadKey()
    End Sub

End Module
