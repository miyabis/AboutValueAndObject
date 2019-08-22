Module Module1

    Sub Main()
        Debug.Print("Primitive")
        Dim A As Integer
        Dim B As Integer

        A = 1
        B = 2

        B = A
        Debug.Print($"  A={A}, B={B}")

        B = 3
        Debug.Print($"  A={A}, B={B}")

        Debug.Print("String")
        Dim sA As String
        Dim sB As String

        sA = "abc"
        sB = "def"

        sB = sA
        Debug.Print($"  sA={sA}, sB={sB}")

        sB = "123"
        Debug.Print($"  sA={sA}, sB={sB}")

        Debug.Print("Object")
        Dim classA As New AA
        Dim classB As New AA
        Dim classC As New AA
        classA.Value = 1
        classB.Value = 2
        classC.Value = 3

        classB = classA
        Debug.Print($"  A={classA.Value}, B={classB.Value}, C={classC.Value}")

        classB.Value = 4
        Debug.Print($"  A={classA.Value}, B={classB.Value}, C={classC.Value}")

        classB.Value = classC.Value
        Debug.Print($"  A={classA.Value}, B={classB.Value}, C={classC.Value}")

        Debug.Print("Method Args")
        HogeByVal(classA)
        Debug.Print($"  Byval  A={classA.Value}")

        HogeByRef(classA)
        Debug.Print($"  Byval  A={classA.Value}")
    End Sub

    Sub HogeByVal(ByVal val1 As AA)
        Dim val As New AA
        val.Value = 10
        val1 = val
    End Sub

    Sub HogeByRef(ByRef val1 As AA)
        Dim val As New AA
        val.Value = 10
        val1 = val
    End Sub

End Module

Class AA
    Public Property Value As Integer

End Class
