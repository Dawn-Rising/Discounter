Module Module1
    Function Discounts(discount As Integer, price As Double)
        Dim value As Double

        value = price * (discount / 100)
        Return value
    End Function
    Sub Main()
        Dim price As Integer
        Dim discount As Integer
        Dim value As Integer

        Console.Write("Enter origonal price: £")
        price = Console.ReadLine()

        Console.Write("Enter the discount percent wanting to be applied: %")
        discount = Console.ReadLine()

        value = Discounts(discount, price)
        Console.WriteLine("Your discont applied is £" & value)
        Console.WriteLine("Final print is £" & price - value)
        Console.ReadKey()
    End Sub
End Module
