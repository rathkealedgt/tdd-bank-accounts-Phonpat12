Imports System.Windows.Forms

Public Class BankAccountsForm

    Private Accounts(4) As BankAccount
    Private NumAccounts As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.NumAccounts = 0
    End Sub

    Public Function CreateAccount()

        'Guard Clause
        If txtAccountHolder.Text = "" Then Throw New Exception("AccountHolderRequiredException")
        If txtAccountNumber.Text = "" Then Throw New Exception("AccountNumberRequiredException")
        If txtCountyOfOrigin.Text = "" Then Throw New Exception("CountryOfOriginRequiredException")
        If txtBalance.Text = "" Then Throw New Exception("BalanceRequiredException")
        If txtInterestRate.Text = "" Then Throw New Exception("InterestRAteRequiredException")



        Dim AccountHolder As String = txtAccountHolder.Text
        Dim AccountNumber = txtAccountNumber.Text
        Dim InterestRate As Double = CDbl(txtInterestRate.Text)
        Dim Balance As Double = CDbl(txtBalance.Text)
        Dim Country As String = txtCountyOfOrigin.Text


        Dim NewAccount As New BankAccount(AccountHolder, AccountNumber, InterestRate, Balance, Country)
        Me.Accounts(Me.NumAccounts) = NewAccount

        Return Nothing
    End Function

    Private Sub BtnExt_Click(sender As Object, e As EventArgs) Handles BtnExt.Click
        Application.Exit()
    End Sub

    Public Function SetTestForTesting(AccountHolder As String, AccountNumber As String, Balance As String, InterestRate As String, CountryOfOrigin As String)
        txtAccountHolder.Text = AccountHolder
        txtAccountNumber.Text = AccountNumber
        txtBalance.Text = Balance
        txtInterestRate.Text = InterestRate
        txtCountyOfOrigin.Text = CountryOfOrigin

        Return Nothing
    End Function

    Public Function GetAccounts() As BankAccount()
        Return Me.Accounts
    End Function



End Class