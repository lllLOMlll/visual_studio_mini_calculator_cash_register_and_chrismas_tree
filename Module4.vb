Module Module4
    Sub Main()
        Dim numStars, numRows, totalStars As Integer
        Dim nearestCompletion As Integer = 0
        Dim userChoice As String

        Do
            Dim validInput As Boolean = False

            ' Loop until valid input is received
            Do
                Console.WriteLine("Enter a number of stars (between 4 and 100): ")
                Console.WriteLine("You can press X at any moment to exit the program")
                Dim input As String = Console.ReadLine()

                ' Check for exit condition
                If input.ToLower() = "x" Then
                    Exit Do
                End If

                ' Validate the integer input
                If Integer.TryParse(input, numStars) Then
                    ' Check the range of input
                    If numStars >= 4 AndAlso numStars <= 100 Then
                        validInput = True
                        Exit Do ' Exit the inner loop
                    Else
                        Console.WriteLine()
                        Console.WriteLine("Please enter a number between 4 and 100.")
                        Console.WriteLine()
                    End If
                Else
                    Console.WriteLine()
                    Console.WriteLine("Invalid input. Please enter a number between 4 and 100.")
                    Console.WriteLine()
                End If
            Loop Until validInput

            ' If user chose to exit, break out of the main loop as well
            If Not validInput Then
                Exit Do
            End If

            ' Calculate the nearest number of rows and total stars for completion
            totalStars = 0
            For i = 1 To 100
                'Total stars 
                '1: (2*1-1 = 1)
                '2: (2*2-1 = 3)
                '3: (2*3-1 = 5)
                '4: (2*4-1 = 7)
                '...
                'If the number of stars is 4, the loop will run 2 times, 1+3=4, and the number of rows will be 2 (i = 2)
                totalStars += (2 * i - 1)
                If totalStars > numStars Then
                    Exit For
                End If
                nearestCompletion = totalStars
                numRows = i
            Next

            ' Print the Christmas tree
            For i = 1 To numRows
                ' Print leading spaces
                For j = 1 To numRows - i
                    Console.Write(" ")
                Next
                ' Print stars
                For j = 1 To 2 * i - 1
                    Console.Write("*")
                Next
                ' Move to the next line
                Console.WriteLine()
            Next

            Console.WriteLine()
            Console.WriteLine($"The nearest completion is: {nearestCompletion}")

            ' Ask user if they want to go again
            Console.WriteLine()
            Console.WriteLine("Do you want to try again? Enter any key to continue, or 'X' to exit.")
            userChoice = Console.ReadLine()
            Console.WriteLine()
            ' Check for exit condition
            If userChoice.ToUpper() = "X" Then
                Exit Do
            End If

        Loop While userChoice.ToUpper() <> "X"

    End Sub
End Module
