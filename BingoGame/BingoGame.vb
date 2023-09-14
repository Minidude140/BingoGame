'Zachary Christensen
'RCET 2265
'Fall 2023
'Bingo Game (in class example)
'https://github.com/Minidude140/BingoGame.git


Option Explicit On
Option Strict On

Module BingoGame

    'TODO
    '[]Create an array to track the numbers called
    '[]create a function to display the balls already called
    '[]create a way to draw a ball, check if it has been called, and track it in...
    '[]create a way to restart the game.  Should happen automatically if all balls are called
    '[]new game, play again, or quit functionality
    '[]generate player cards and make playable
    '[]create a way to display the bingo card

    Sub Main()
        '75 ball bingo
        'Letters B I N G O as 0-4 columns
        'numbers 1-15, 16-30, 31-45, 46-60, 61-75
        'ball number = (letter index * 15) + (number index + 1)

        Dim bingoCage(4, 14) As Boolean

        DisplayDraws(bingoCage)
        Console.Read()
    End Sub

    Sub DisplayDraws(ballCage(,) As Boolean)
        Dim currentBall As String
        Dim columnWidth As Integer = 5
        Dim header = New String() {"B |", "I |", "N |", "G |", "O |"}

        'Display column headers
        For i = LBound(header) To UBound(header)
            Console.Write(header(i).PadLeft(columnWidth))
        Next
        Console.WriteLine(vbLf & StrDup(25, "-"))

        'Display Values
        For number = ballCage.GetLowerBound(1) To ballCage.GetUpperBound(1)
            For letter = ballCage.GetLowerBound(0) To ballCage.GetUpperBound(0)
                ' Console.Write((letter * 15) + (number + 1))
                currentBall = CStr((letter * 15) + (number + 1) & " |")
                Console.Write(currentBall.PadLeft(5))
            Next
            Console.WriteLine()
        Next
        Console.WriteLine(StrDup(25, "-"))
    End Sub

End Module
