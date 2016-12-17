Module Module1

    Sub Main()
        Dim A As Integer
        Dim B As Integer

        A = 1
        B = 2

        B = A
        Debug.Print("Ans  A={0}:B={1}", A, B)

        B = 3
        Debug.Print("Ans  A={0}:B={1}", A, B)

        Dim sA As String
        Dim sB As String

        sA = "abc"
        sB = "def"

        sB = sA
        Debug.Print("Ans  sA={0}:sB={1}", sA, sB)

        sB = "123"
        Debug.Print("Ans  sA={0}:sB={1}", sA, sB)

        Dim classA As New AA
        Dim classB As New AA
        Dim classC As New AA
        classA.Value = 1
        classB.Value = 2
        classC.Value = 3

        classB = classA
        Debug.Print("Ans  A={0}:B={1}:C={1}", classA.Value, classB.Value, classC.Value)

        classB.Value = 3
        Debug.Print("Ans  A={0}:B={1}:C={1}", classA.Value, classB.Value, classC.Value)

        classB.Value = classC.Value
        Debug.Print("Ans  A={0}:B={1}:C={1}", classA.Value, classB.Value, classC.Value)

        HogeByVal(classA)
        Debug.Print("Byval  A={0}", classA.Value)

        HogeByRef(classA)
        Debug.Print("Byref  A={0}", classA.Value)
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
