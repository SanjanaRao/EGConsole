Imports System

Public Interface ContractInterface
     Sub Pay(Amount as Double)
End Interface

Public class CashMethod
    Implements ContractInterface
    Public Sub Pay(Amount as Double) Implements ContractInterface.Pay
        Console.WriteLine("Cash method executed")
    End Sub
End class

Public class CreditCardMethod
    Implements ContractInterface
    Public Sub Pay(Amount as Double) Implements ContractInterface.Pay
        Console.WriteLine("Credit card method executed")
    End Sub
End class

Public class UPIMethod
    Implements ContractInterface
    Public Sub Pay(Amount as Double) Implements ContractInterface.Pay
        Console.WriteLine("UPI method executed")
    End Sub
End class

Public  class PaymentFactory

    Public Shared Function GetInstance(Paymentmethod as string) As ContractInterface 
        Dim obj as ContractInterface
        Select Case Paymentmethod
            Case "Cash"
                obj = new CashMethod()
                return obj 
            Case "Credit"
                obj = new CreditCardMethod()
                return obj
            Case "UPI"
                obj = new UPIMethod()
                return obj
        End Select
        
    End Function

End Class

Module Program
    Sub Main(args As String())
       
        Dim obj as ContractInterface = PaymentFactory.GetInstance("UPI")
        obj.Pay(100)
    End Sub
End Module


' create  a console application  which will print a message saying which payment method was executed to process a payment. 
'It should accept the following inputs:

' 1. Amount
' 2. Payment Method (1. Cash, 2. Credit Card, 3. UPI)

' Implement it using a design pattern that suits it best. 
' The solution should support adding additional types of payment with no-to-minimal changes to the existing classes.

' has context menu