
Namespace IntroToOOP.Example2
    Public Class Cat

        Public Sub New()
            Me.Name = "Sue"
            Me.Color = "Black"
        End Sub

        Public Sub New(name As String, color As String)
            Me.Name = name
            Me.Color = color
        End Sub

        Public Name As String
        Public Color As String

        Public Sub wagsTail()
            Console.WriteLine("{0} wags tail...", Name)
        End Sub

        Public Overridable Sub Speaks()
            Console.WriteLine("{0} purrs...", Name)
        End Sub

    End Class

    Public Class OohCat
        Inherits Cat

        Public Overrides Sub Speaks()
            Console.WriteLine("{0} raises hand to mouth slowly and says OOOOOOOOHHHHHH!", Name)
        End Sub

    End Class

End Namespace
