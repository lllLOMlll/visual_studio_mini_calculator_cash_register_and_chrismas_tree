Module Module2
    Sub Main()
        'Variables 
        Dim userInput As String
        Dim inputNum1 As String
        Dim num1 As Double
        Dim inputNum2 As String
        Dim num2 As Double

        'Program loop 
        Do

            'Initializing variables
            Dim operationChoice As String

            'Initial menu
            Console.WriteLine("***************************************")
            Console.WriteLine("***********MINI CALCULATOR*************")
            Console.WriteLine("***************************************")
            Console.WriteLine()
            Console.WriteLine("You can press X at any moment to exit the program")
            Console.WriteLine()
            Console.WriteLine("What do you want to?")
            Console.WriteLine("Choose an operation:")
            Console.WriteLine()
            Console.WriteLine("Addition        : A")
            Console.WriteLine("Substraction    : S")
            Console.WriteLine("Multiplication  : M")
            Console.WriteLine("Whole Division  : WD")
            Console.WriteLine("Division        : D")
            Console.WriteLine("Modulo          : Mod")
            Console.WriteLine("Exponential     : Pow")
            Console.WriteLine("Exit            : E")
            Console.WriteLine()
            Console.Write("Enter your choice: ")


            'CHOOSE AN OPERATION
            'Loop until the user provides a right choice
            Do
                operationChoice = Console.ReadLine().ToUpper
                If operationChoice = "X" Then
                    Environment.Exit(0)
                End If
                If operationChoice = "A" Or operationChoice = "S" Or operationChoice = "M" Or operationChoice = "WD" Or operationChoice = "D" Or operationChoice = "MOD" Or operationChoice = "POW" Or operationChoice = "E" Then
                    Exit Do
                End If
                Console.WriteLine()
                Console.WriteLine("Wrong inpyut. Please enter a valid input")
                Console.WriteLine("What do you want to?")
                Console.WriteLine("Choose an operation:")
                Console.WriteLine()
                Console.WriteLine("Addition        : A")
                Console.WriteLine("Substraction    : S")
                Console.WriteLine("Multiplication  : M")
                Console.WriteLine("Whole Division  : WD")
                Console.WriteLine("Division        : D")
                Console.WriteLine("Modulo          : Mod")
                Console.WriteLine("Exponential     : Pow")
                Console.WriteLine("Exit            : E")
                Console.WriteLine()
                Console.Write("Enter your choice: ")
            Loop

            ' Number 1
            Console.WriteLine()
            Console.WriteLine("Please enter a number: ")
            Do
                inputNum1 = Console.ReadLine.ToUpper()
                If inputNum1 = "X" Then
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
                inputNum2 = Console.ReadLine.ToUpper()
                If inputNum2 = "X" Then
                    Environment.Exit(0)
                End If
                If IsNumeric(inputNum2) Then
                    Exit Do
                End If
                Console.WriteLine()
                Console.WriteLine("You did not enter a valid input!")
                Console.WriteLine("Please enter a second number: ")
            Loop

            'Converting inputNum (string) to numbers (double)
            num1 = Convert.ToDouble(inputNum1)
            num2 = Convert.ToDouble(inputNum2)

            'Calculate and display     
            If operationChoice = "A" Then
                Console.WriteLine()
                Console.WriteLine("ADDITION")
                Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2)
            ElseIf operationChoice = "S" Then
                Console.WriteLine()
                Console.WriteLine("SUBSTRACTION")
                Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2)
            ElseIf operationChoice = "M" Then
                Console.WriteLine()
                Console.WriteLine("MULTIPLICATION")
                Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2)
            ElseIf operationChoice = "WD" Then
                Console.WriteLine()
                Console.WriteLine("WHOLE DIVISION")
                If num2 = 0 Then
                    Console.WriteLine("You cannot divide by 0")
                Else
                    Console.WriteLine("{0} \ {1} = {2}", num1, num2, num1 \ num2)
                End If
            ElseIf operationChoice = "D" Then
                    Console.WriteLine()
                Console.WriteLine("DIVISION")
                If num2 = 0 Then
                    Console.WriteLine("You cannot divide by 0")
                Else
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2)
                End If
            ElseIf operationChoice = "MOD" Then
                Console.WriteLine()
                Console.WriteLine("MODULO")
                Console.WriteLine("{0} modulo {1} = {2}", num1, num2, num1 Mod num2)
            ElseIf operationChoice = "POW" Then
                Console.WriteLine()
                Console.WriteLine("EXPONENTIAL")
                Console.WriteLine("{0} ^ {1} = {2}", num1, num2, num1 ^ num2)
            End If


            Do
                Console.WriteLine()
                Console.WriteLine("Do you want to continue?")
                Console.WriteLine("Press 'C' to continue or 'X' to exit the program")
                userInput = Console.ReadLine().ToUpper()

                If userInput = "C" OrElse userInput = "X" Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid input. Please press 'C' to continue or 'X' to exit.")
                End If
            Loop
            ' The loop will go in if the user press C
        Loop While userInput = "C"


    End Sub






End Module
