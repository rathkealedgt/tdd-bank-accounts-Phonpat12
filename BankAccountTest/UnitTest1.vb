Imports System.Text
Imports BankAccounts


<TestClass()> Public Class UnitTest1
    <TestMethod()> Public Sub TestConstructors()

        'Arrange
        Dim Accountholder As String = "Ms I. N. Cogonito"
        Dim Accountnumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOforigin As String = "Isle of Man"

        'Act
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, Accountnumber, InterestRate, Balance, CountryOforigin)
        Dim Account2 As New BankAccounts.BankAccount(Accountholder, Accountnumber, InterestRate, Balance)
        Dim Account3 As New BankAccounts.BankAccount(Accountholder, Accountnumber, InterestRate)

        'Assert
        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(Account3)
    End Sub


    <TestMethod()> Public Sub TestGetAccountHolder()
        'Arrange
        Dim Accountholder As String = "Ms I. N. Cogonito"
        Dim Accountnumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOforigin As String = "Isle of Man"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, Accountnumber, InterestRate, Balance, CountryOforigin)

        'Act
        Dim Name As String = Account1.GetAccountHolder()

        'Assert
        Assert.AreEqual(Name, "Ms I. N. Cogonito")
    End Sub

    <TestMethod()> Public Sub TestGetInterestRate()
        'Arrange
        Dim Accountholder As String = "Ms I. N. Cogonito"
        Dim Accountnumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOforigin As String = "Isle of Man"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, Accountnumber, InterestRate, Balance, CountryOforigin)

        'Act
        Dim IR As Double = Account1.GetInterestRAte()

        'Assert
        Assert.AreEqual(4, 3, IR)
    End Sub

    <TestMethod()> Public Sub TestGetCountry()
        'Arrange
        Dim Accountholder As String = "Ms I. N. Cogonito"
        Dim Accountnumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, Accountnumber, InterestRate, Balance, CountryOfOrigin)

        'Act
        Dim Country As String = Account1.GetCountry()

        'Assert
        Assert.AreEqual(Country, "Isle of Man")
    End Sub

    <TestMethod()> Public Sub TestSetInterestRate()
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        'Act
        Account1.SetInterestRate(5.1)

        'Assert
        Assert.AreEqual(Account1.GetInterestRAte(), 5.1)
    End Sub

    <TestMethod()> Public Sub TestApplyInterestRate()
        'p x r x t = i => 37.07 + 10343.82 = 10380.89

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        'Act
        Account1.ApplyInterest()


        'Assert
        Assert.AreEqual(Account1.GetIBalance(), 10380.89)
    End Sub


    Private Function NewAccount() As BankAccounts.BankAccount

        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOforigin As String = "Isle of MAn"
        Return New BankAccounts.BankAccount(AccountHolder, AccountNumber, InterestRate, Balance, CountryOforigin)

    End Function

    Private Function NewAccounts() As BankAccounts.BankAccount

        'HoueKeeping
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOforigin As String = "Isle of MAn"

        'Instantiate a new BAnkAccount Obj
        Dim Account1 As New BankAccount(AccountHolder, AccountNumber, InterestRate, Balance, CountryOforigin)

        'Return the new object
        Return Account1
    End Function

    <TestMethod()> Public Sub TestDeposit()
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()
        Dim ExpectedValue As Double = 10343.82 + 700


        'Act
        Dim ActualValue As Double = Account1.Deposit(700)

        'Assert
        Assert.AreEqual(ExpectedValue, ActualValue)

    End Sub

    <TestMethod()> Public Sub TestWithdrawalsmall()
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()
        Dim ExpectedValue As Double = 10343.82 - 700


        'Act
        Dim NewBalance = Account1.Withdrawal(700.0)

        'Assert
        Assert.AreEqual(ExpectedValue, NewBalance)

    End Sub


    <TestMethod()> Public Sub TestWithdrawallarge()
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()
        Dim ExpectedVal As Double = 10343.82


        'Act
        Try
            Dim NewBalance = Account1.Withdrawal(11000.0)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        'Assert
        Assert.AreEqual(ExpectedVal, Account1.GetIBalance())

    End Sub


End Class