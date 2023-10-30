Module Module1

    Sub Main()
        ' Variable to loop the whole program
        Dim userInput As String

        Do
            ' Initializing other variables
            Dim inputNum1 As String
            Dim num1 As Double
            Dim inputNum2 As String
            Dim num2 As Double
            Dim inputNum3 As String
            Dim num3 As Double

            Console.WriteLine("***************************************************")
            Console.WriteLine("************* ADDITION AND AVERAGE ****************")
            Console.WriteLine("***************************************************")
            Console.WriteLine()
            Console.WriteLine("You can press X at any moment to exit the program")
            Console.WriteLine()

            ' Number 1
            Console.WriteLine("Please enter a number: ")
            Do
                inputNum1 = Console.ReadLine()
                ' X = exit
                If inputNum1.ToUpper() = "X" Then
                    Environment.Exit(0)
                End If
                If IsNumeric(inputNum1) Then
                    Exit Do
                End If
                Console.WriteLine()
                Console.WriteLine("You did not enter a valid input!")
                Console.WriteLine("Please enter a number: ")
            Loop

            ' Number 2
            Console.WriteLine()
            Console.WriteLine("Please enter a second number: ")
            Do
                inputNum2 = Console.ReadLine()
                ' X = exit
                If inputNum2.ToUpper() = "X" Then
                    Environment.Exit(0)
                End If
                If IsNumeric(inputNum2) Then
                    Exit Do
                End If
                Console.WriteLine()
                Console.WriteLine("You did not enter a valid input!")
                Console.WriteLine("Please enter a second number: ")
            Loop

            ' Number 3
            Console.WriteLine()
            Console.WriteLine("Please enter a third number: ")
            Do
                inputNum3 = Console.ReadLine()
                ' E = exit
                If inputNum3.ToUpper() = "X" Then
                    Environment.Exit(0)
                End If
                If IsNumeric(inputNum3) Then
                    Exit Do
                End If
                Console.WriteLine()
                Console.WriteLine("You did not enter a valid input!")
                Console.WriteLine("Please enter a third number: ")
            Loop

            ' Converting string to numbers
            num1 = Convert.ToDouble(inputNum1)
            num2 = Convert.ToDouble(inputNum2)
            num3 = Convert.ToDouble(inputNum3)

            ' Displaying the numbers
            Console.WriteLine()
            Console.WriteLine("Your 3 numbers are : {0}, {1}, {2}", num1, num2, num3)

            ' Total of 3 numbers
            Console.WriteLine()
            Console.WriteLine("SUM")
            Console.WriteLine("The sum of your 3 numbers is: {0}", num1 + num2 + num3)
            Console.WriteLine("{0} + {1} + {2} = {3}", num1, num2, num3, num1 + num2 + num3)

            ' Average of 3 numbers
            Console.WriteLine()
            Console.WriteLine("AVERAGE")
            Console.WriteLine("The average of your 3 numbers is: {0}", (num1 + num2 + num3) / 3)
            Console.WriteLine("({0} + {1} + {2}) / 3 = {3}", num1, num2, num3, (num1 + num2 + num3) / 3)

            ' Ask the user if they want to continue or exit
            Do
                Console.WriteLine()
                Console.WriteLine("Press 'C' to continue or 'X' to exit.")
                userInput = Console.ReadLine().ToUpper()

                ' Exit the application if 'E' is pressed
                If userInput = "X" Then
                    Environment.Exit(0)
                ElseIf userInput = "C" Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid input. Please press 'C' to continue or 'E' to exit.")
                End If
            Loop
            ' If the user enters "C", the loop will continue
        Loop While userInput = "C"

    End Sub

End Module
