Imports IntroToOOP.Example1

Module MainModule

    Sub Main()
        Dim sueCat = New Cat()
        sueCat.wagsTail()
        sueCat.Speaks()

        'Example1
        'Dim HeathCliff = New Cat("Heathcliff", "Orange")
        'HeathCliff.wagsTail()
        'HeathCliff.Speaks()

        ''Example2
        'Dim Ooh As New OohCat()
        'Ooh.Name = "OohCat"
        'Ooh.wagsTail()
        'Ooh.Speaks()

        'Example3
        'Dim p As New Process()

        'Dim sueCat = New Cat()
        'Dim HeathCliff = New Cat()
        'Dim Ooh = New OohCat()
        'Dim myDog = New Dog()

        'doAnimalStuff(sueCat, "Sue")
        'doAnimalStuff(HeathCliff, "HeathCliff")
        'doAnimalStuff(Ooh, "Ooh")
        'doAnimalStuff(myDog, "Brain")

        Console.ReadLine() 'Pause
    End Sub

    'Example3
    'Private Sub doAnimalStuff(myAnimal As Animal, name As String)
    '    myAnimal.Name = name
    '    myAnimal.wagsTail()
    '    myAnimal.Speaks()
    'End Sub



End Module
