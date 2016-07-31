
Namespace IntroToOOP.Example1
    Public Class Cat

        'Internal Members
        Private _name As String
        Private _color As String

        'Constructor
        Public Sub New()
            _name = "Sue"
            _color = "Black"
        End Sub

        Public Sub New(name As String, color As String)
            _name = name
            _color = color
        End Sub

        Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        ReadOnly Property Color As String
            Get
                Return _color
            End Get
        End Property

        'Behavior
        Public Sub wagsTail()
            Console.WriteLine("{0} wags tail...", _name)
        End Sub

        Public Sub Speaks()
            Console.WriteLine("{0} purrs...", _name)
        End Sub


    End Class
End Namespace

