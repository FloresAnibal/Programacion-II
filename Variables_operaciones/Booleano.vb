Module Booleano

    '-------------------------- EJERCICIO 1.9 -------------------------

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
End Module
