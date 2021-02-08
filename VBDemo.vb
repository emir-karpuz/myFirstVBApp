Module VBDemo

    'Consider the following operation On an arbitrary positive Integer

    'If n Is even -> n / 2
    '    If n Is odd -> n * 3 + 1
    'Create a Function To repeatedly evaluate these operations, until reaching 1. Return the number Of steps it took.

    'See the following example, Using 10 As the input, With 6 steps

    '10 Is even - 10 / 2 = 5
    '5 Is odd - 5 * 3 + 1 = 16
    '16 Is even - 16 / 2 = 8
    '8 Is even - 8 / 2 = 4
    '4 Is even - 4 / 2 = 2
    '2 Is even - 2 / 2 = 1 -> Reached 1, so return 6

    Function Collatz(ByVal input As Integer)

        Dim stepCounter As Integer = 0
        If input <> 1 Then
            While input <> 1
                If input Mod 2 = 0 Then
                    input = input \ 2
                Else
                    input = input * 3 + 1
                End If
                stepCounter += 1
            End While
        End If

        Console.WriteLine("Sonuç: " & stepCounter)

    End Function

    Sub Main()

        Console.WriteLine("Sayı giriniz: ")
        Dim input As Integer = Console.ReadLine()

        Collatz(input)

        Console.ReadLine()
    End Sub

End Module
