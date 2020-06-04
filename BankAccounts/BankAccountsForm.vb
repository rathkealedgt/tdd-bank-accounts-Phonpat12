Imports System.Text
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
        If Me.NumAccounts > 4 Then Throw New Exception("MaximumnumAccountsReachedException")


        Dim AccountHolder As String = txtAccountHolder.Text
        Dim AccountNumber = txtAccountNumber.Text
        Dim InterestRate As Double = CDbl(txtInterestRate.Text)
        Dim Balance As Double = CDbl(txtBalance.Text)
        Dim Country As String = txtCountyOfOrigin.Text


        Dim NewAccount As New BankAccount(AccountHolder, AccountNumber, InterestRate, Balance, Country)
        Me.Accounts(Me.NumAccounts) = NewAccount
        Me.NumAccounts += 1

        Return Nothing
    End Function

    Private Sub BtnExt_Click(sender As Object, e As EventArgs) Handles BtnExt.Click
        Application.Exit()
    End Sub

    Private Sub BtnAddInterest_Click(sender As Object, e As EventArgs) Handles BtnAddInterest.Click
        For Each BA As BankAccount In Me.Accounts
            If BA Is Nothing Then Exit For

            BA.ApplyInterest()

        Next
    End Sub

    Private Sub BtnAddAccount_Click(sender As Object, e As EventArgs) Handles BtnAddAccount.Click
        Dim Feedback As String = "Account added"
        Dim Title As String = "Success"
        Try
            Me.CreateAccount()


        Catch ex As Exception
            Title = ex.Message()

            If ex.Message = "AccountHolderRequiredException" Then
                Feedback = "Please enter an account holder name"
                txtAccountHolder.Focus()

            ElseIf ex.Message = "AccountNumberRequiredException" Then
                Feedback = "Please enter an account number"
                txtAccountNumber.Focus()

            ElseIf ex.Message = "CountryOfOriginRequiredException" Then
                Feedback = "Please enter an account country of Origin"
                txtCountyOfOrigin.Focus()

            ElseIf ex.Message = "AccountBalanceRequiredException" Then
                Feedback = "Please enter valid account balance"
                txtBalance.Focus()

            ElseIf ex.Message = "InterestRateRequiredException" Then
                Feedback = "Please enter valid interest rate"
                txtInterestRate.Focus()

            ElseIf ex.Message = "MaximumAccountReachedRequiredException" Then
                Feedback = "You have reached the maximum number of accounts"

            Else
                Title = "An error occurred"
                Feedback = ex.Message

            End If

        End Try

        MsgBox(Feedback, vbOKOnly, Title)

        txtAccountHolder.Clear()
        txtAccountNumber.Clear()
        txtBalance.Clear()
        txtCountyOfOrigin.Clear()
        txtInterestRate.Clear()

    End Sub

    Private Sub BtnPrintAccounts_Click(sender As Object, e As EventArgs) Handles BtnPrintAccounts.Click
        Dim Allaccounts As New StringBuilder()

        For Each BA As BankAccount In Me.Accounts
            If BA Is Nothing Then Exit For

            Allaccounts.Append(BA.ToString())
            Allaccounts.Append(vbCrLf)

        Next

        txtListAccounts.Text = Allaccounts.ToString()

    End Sub

    Public Function SetTextForTesting(AccountHolder As String, AccountNumber As String, Balance As String, InterestRate As String, CountryOfOrigin As String)
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