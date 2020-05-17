Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1
    <TestMethod()> Public Sub TestConstructors()

        'Arrange
        Dim Accountholder As String = "Ms I. N. Cogonito"
        Dim Accountnumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOforigin As String = "Isle of MAn"

        'Act
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, Accountnumber, Balance, InterestRate, CountryOforigin)
        Dim Account2 As New BankAccounts.BankAccount(Accountholder, Accountnumber, Balance, InterestRate)
        Dim Account3 As New BankAccounts.BankAccount(Accountholder, Accountnumber, Balance)

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
        Dim CountryOforigin As String = "Isle of MAn"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, Accountnumber, Balance, InterestRate, CountryOforigin)

        'Act
        Dim NAme As String = Account1.GetAccountHolder()

        'Assert
        Assert.AreEqual(NAme, "Ms I. N. Cogonito")
    End Sub

    <TestMethod()> Public Sub TestGetInterestRate()
        'Arrange
        Dim Accountholder As String = "Ms I. N. Cogonito"
        Dim Accountnumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOforigin As String = "Isle of MAn"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, Accountnumber, Balance, InterestRate, CountryOforigin)

        'Act
        Dim IR As Double = Account1.GetInterestRate()

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
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, Accountnumber, Balance, InterestRate, CountryOforigin)

        'Act
        Dim Country As String = Account1.GetCountry()

        'Assert
        Assert.AreEqual(Country, "Isle of Man")
    End Sub

    <TestMethod()> Public Sub TestSetInterestRate()
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Account1.SetInterestRate(5.1)

        'Assert
        Assert.AreEqual(Account1.GetInterestRAte(), 5.1)
    End Sub

    <TestMethod()> Public Sub TestApplyInterestRAte()
        'p x r x t = i => 37.07 + 10343.82 = 10380.89

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

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
End Class