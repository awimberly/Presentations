Namespace IntroToOOP.Example3
    Public Class Animal

        Public Sub New()

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
            Console.WriteLine("{0} grunts...", Name)
        End Sub
    End Class

    Public Class Cat
        Inherits Animal

        Public Sub New()
            Me.Name = "Sue"
            Me.Color = "Black"
        End Sub

        Public Sub New(name As String, color As String)
            MyBase.Name = name
            MyBase.Color = color
        End Sub

        Public Overrides Sub Speaks()
            MyBase.Speaks()
            Console.WriteLine("{0} purrs...", Me.Name)
        End Sub

    End Class

    Public Class OohCat
        Inherits Animal

        Public Overrides Sub Speaks()
            Console.WriteLine("{0} raises hand to mouth slowly and says OOOOOHHH!", Name)
        End Sub
    End Class

    Public Class Dog
        Inherits Animal

        Public Overrides Sub Speaks()
            Console.WriteLine("{0} barks and howls...", Name)
        End Sub

    End Class
End Namespace

