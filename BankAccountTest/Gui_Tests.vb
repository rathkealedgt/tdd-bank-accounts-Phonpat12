Imports System.Text
Imports BankAccounts
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Gui_Tests

    <TestMethod()> Public Sub TestCreateAccount()
        Dim Accountholder As String = "Ms I. N. Cogonito"
        Dim Accountnumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "Isle of Man"
        Dim BF As New BankAccountsForm()
        BF.SetTestForTesting(Accountholder, Accountnumber, Balance, InterestRate, CountryOfOrigin)

        'Act
        BF.CreateAccount()
        Dim TempAccount() As BankAccount = BF.GetAccounts()

        'Assert
        Assert.AreEqual(Accountholder, TempAccount(0).GetAccountHolder())
        Assert.AreEqual(Accountnumber, BF.GetAccounts(0).GetAccountNumber())
        Assert.AreEqual(4.3, TempAccount(0).GetInterestRAte)
        Assert.AreEqual(10343.82, BF.GetAccounts(0).GetIBalance)
        Assert.AreEqual(CountryOfOrigin, BF.GetAccounts(0).GetCountry())

    End Sub

    <TestMethod()> Public Sub TestEmptyAccountHolder()
        'Arrange
        Dim Accountholder As String = ""
        Dim Accountnumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim BF As New BankAccountsForm()
        BF.SetTestForTesting(Accountholder, Accountnumber, Balance, InterestRate, CountryOfOrigin)

        Try
            BF.CreateAccount()
            Assert.Fail()

        Catch ex As Exception
            Assert.AreEqual("AccountHolderRequiredException", ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyAccountNumber()
        'Arrange
        Dim Accountholder As String = "Ms I. N. Cogonito"
        Dim Accountnumber As String = ""
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim BF As New BankAccountsForm()
        BF.SetTestForTesting(Accountholder, Accountnumber, Balance, InterestRate, CountryOfOrigin)
        Try
            BF.CreateAccount()
            Assert.Fail()

        Catch ex As Exception
            Assert.AreEqual("AccountNumberRequiredException", ex.Message)

        End Try
    End Sub

    <TestMethod()> Public Sub TestEmptyCountryOfOrigin()
        'Arrange
        Dim Accountholder As String = "Ms I. N. Cogonito"
        Dim Accountnumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = ""

        Dim BF As New BankAccountsForm()
        BF.SetTestForTesting(Accountholder, Accountnumber, Balance, InterestRate, CountryOfOrigin)
        Try
            BF.CreateAccount()
            Assert.Fail()

        Catch ex As Exception
            Assert.AreEqual("CountryOfOriginRequiredException", ex.Message)

        End Try
    End Sub


    <TestMethod()> Public Sub TestEmptyInterestRate()
        'Arrange
        Dim AccountHolder As String = "Ms I. N. Cogonito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = ""
        Dim Balance As String = "10343.82"
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim BF As New BankAccountsForm()
        BF.SetTestForTesting(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)
        Try
            BF.CreateAccount()
            Assert.Fail()

        Catch ex As Exception
            Assert.AreEqual("InterestRAteRequiredException", ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyBalance()
        'Arrange
        Dim Accountholder As String = "Ms I. N. Cogonito"
        Dim Accountnumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim Balance As String = ""
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim BF As New BankAccountsForm()
        BF.SetTestForTesting(Accountholder, Accountnumber, Balance, InterestRate, CountryOfOrigin)
        Try
            BF.CreateAccount()
            Assert.Fail()

        Catch ex As Exception
            Assert.AreEqual("BalanceRequiredException", ex.Message)

        End Try
    End Sub
End Class