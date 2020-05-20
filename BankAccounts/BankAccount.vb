Imports System.Text
''' <summary>
''' <author></author>
''' <Date>14/05/20</Date>
''' </summary>
Public Class BankAccount

    Private AccountHolder As String
    Private AccountNumber As String
    Private InterestRAte As Double
    Private Balance As Double
    Private CountryOfOrigin As String

    Public Sub New(AccountHolder As String, AccountNumber As String, InterestRate As Double, Balance As Double, CountryOfOrigin As String)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRAte = InterestRate
        Me.CountryOfOrigin = CountryOfOrigin
    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, InterestRate As Double, Balance As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRAte = InterestRate
    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, InterestRate As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
    End Sub

    Public Function GetAccountHolder() As String
        Return Me.AccountHolder

    End Function

    Public Function GetCountry() As String
        Return Me.CountryOfOrigin

    End Function

    Public Function GetIBalance() As Double
        Return Me.Balance

    End Function

    Public Function GetInterestRAte() As Double
        Return Me.InterestRAte

    End Function

    Public Function SetInterestRate(Rate As Double)
        Me.InterestRAte = Rate
        Return Nothing

    End Function

    Public Function ApplyInterest()
        Dim NewBalance As Double = Me.Balance + (Me.Balance * 0.043 * (1 / 12))

        Me.Balance = Math.Round(NewBalance, 2)

        Return Nothing
    End Function

    Public Function Deposit(Amount As Double) As Double
        Me.Balance += Amount

        Return Me.Balance

    End Function

    Public Function Withdrawal(Amount As Double) As Double
        If Amount > Me.Balance Then
            Throw New Exception("Insufficient Funds")
        End If

        Me.Balance -= Amount

        Return Me.Balance

    End Function


    Public Overrides Function ToString() As String
        Dim AccountString As New StringBuilder()
        AccountString.Append("ISle OF Man" & vbCrLf)
        AccountString.Append("ABCD 890111 1116789" & vbCrLf)
        AccountString.Append("Ms I. N. Cognito" & vbCrLf)
        AccountString.Append("InterestRate4.3" & vbCrLf)
        AccountString.Append("10343.82 " & vbCrLf)

        Return AccountString.ToString()

    End Function



End Class
