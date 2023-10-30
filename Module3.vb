Module Module3
    Sub Main()

        ' Initialize totalPrice outside the main loop
        Dim totalPrice As Double = 0.0

        ' Loop for the whole program
        Do
            ' Initializing variables
            Dim userItemChoice As String
            Dim userItemChoiceInt As Integer
            Dim itemQuantity As String
            Dim itemPrice As Double
            Dim item1Price As Double = 10.99
            Dim item2Price As Double = 5.66
            Dim item3Price As Double = 7.65
            Dim item4Price As Double = 8.64
            Dim item5Price As Double = 5.0
            Dim item6Price As Double = 7.2
            Dim item7Price As Double = 10.0

            ' Display Menu
            Console.WriteLine("***************************************************")
            Console.WriteLine("************** MINI CASH REGISTER ****************")
            Console.WriteLine("***************************************************")
            Console.WriteLine()
            Console.WriteLine("You can press X at any moment to exit the program")
            Console.WriteLine()
            Console.WriteLine("Which item do you want to buy?")
            Console.WriteLine("Enter the number of the item")
            Console.WriteLine("Item 1  :${0:0.00}", item1Price)
            Console.WriteLine("Item 2  :${0:0.00}", item2Price)
            Console.WriteLine("Item 3  :${0:0.00}", item3Price)
            Console.WriteLine("Item 4  :${0:0.00}", item4Price)
            Console.WriteLine("Item 5  :${0:0.00}", item5Price)
            Console.WriteLine("Item 6  :${0:0.00}", item6Price)
            Console.WriteLine("Item 7  :${0:0.00}", item7Price)
            Console.WriteLine()
            Console.Write("Enter your choice: ")

            ' Proceed with the choice
            Do
                userItemChoice = Console.ReadLine().ToUpper()
                If userItemChoice = "X" Then
                    Environment.Exit(0)
                End If
                If Integer.TryParse(userItemChoice, userItemChoiceInt) AndAlso (userItemChoiceInt >= 1 AndAlso userItemChoiceInt <= 7) Then
                    Exit Do
                Else
                    Console.WriteLine()
                    Console.WriteLine("You did not enter a valid input!")
                    Console.WriteLine("Pleaes choose an item (1 to 7)")
                End If
            Loop
            ' Determine the item price based on the user's choice and calculate the total transaction amount
            Select Case userItemChoiceInt
                Case 1
                    itemPrice = item1Price
                Case 2
                    itemPrice = item2Price
                Case 3
                    itemPrice = item3Price
                Case 4
                    itemPrice = item4Price
                Case 5
                    itemPrice = item5Price
                Case 6
                    itemPrice = item6Price
                Case 7
                    itemPrice = item7Price
                Case Else
                    Console.WriteLine()
                    Console.WriteLine("Invalid item choice.")
            End Select


            ' Ask for the quantity
            Do
                Console.WriteLine()
                Console.WriteLine("Item {0} price = ${1}", userItemChoiceInt, itemPrice)
                Console.WriteLine("How much of item {0} do you want? (The quantity may vary between 0 and 15)", userItemChoiceInt)
                itemQuantity = Console.ReadLine()
                If itemQuantity.ToUpper() = "X" Then
                    Environment.Exit(0)
                ElseIf IsNumeric(itemQuantity) AndAlso (Convert.ToDouble(itemQuantity) >= 0 AndAlso Convert.ToDouble(itemQuantity) <= 15) Then
                    Exit Do
                Else
                    Console.WriteLine()
                    Console.WriteLine("Wrong input! Please enter a number between 0 and 15")
                End If
            Loop



            Dim totalTransaction As Double = Convert.ToDouble(itemQuantity) * itemPrice
            totalPrice += totalTransaction

            Console.WriteLine()
            Console.WriteLine("You've purchased {0} of item {1}", itemQuantity, userItemChoiceInt)
            Console.WriteLine()
            Console.WriteLine("Price of the current transaction = ${0:0.00}", totalTransaction)
            Console.WriteLine("Total price of all your purchases = ${0:0.00}", totalPrice)



            ' Ask if the user wants to make another purchase
            Do
                Console.WriteLine()
                Console.WriteLine("Do you want to purchase something else? (Y/N)")
                Dim morePurchase As String = Console.ReadLine().ToUpper()
                If morePurchase = "X" Then
                    Environment.Exit(0)
                ElseIf morePurchase = "N" Then
                    Console.WriteLine()
                    Console.WriteLine("Total price of all your purchases = ${0:0.00}", totalPrice)
                    totalPrice = 0

                    Do
                        Console.WriteLine()
                        Console.WriteLine("Do you want to exit the program?")
                        Console.WriteLine("Press Y for yes or N for no")
                        Dim exitChoice As String
                        exitChoice = Console.ReadLine().ToUpper
                        If exitChoice = "Y" Or exitChoice = "X" Then
                            Environment.Exit(0)
                        ElseIf exitChoice = "N" Then
                            Exit Do
                        Else
                            Console.WriteLine()
                            Console.WriteLine("Wrong input. Please press Y or X to exit or N to continue")
                        End If
                    Loop
                ElseIf morePurchase = "Y" Then
                    Exit Do
                Else
                    Console.WriteLine()
                    Console.WriteLine("Invalid input. Please enter 'Y' for Yes, 'N' for No, or 'X' to exit.")
                End If
            Loop



            'End of the program loop
        Loop
    End Sub
End Module
