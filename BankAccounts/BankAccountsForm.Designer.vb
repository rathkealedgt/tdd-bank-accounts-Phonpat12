﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccountsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnExt = New System.Windows.Forms.Button()
        Me.txtAccountHolder = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtCountyOfOrigin = New System.Windows.Forms.TextBox()
        Me.txtListAccounts = New System.Windows.Forms.TextBox()
        Me.BtnAddAccount = New System.Windows.Forms.Button()
        Me.BtnAddInterest = New System.Windows.Forms.Button()
        Me.BtnPrintAccounts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnExt
        '
        Me.BtnExt.Location = New System.Drawing.Point(552, 314)
        Me.BtnExt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnExt.Name = "BtnExt"
        Me.BtnExt.Size = New System.Drawing.Size(129, 96)
        Me.BtnExt.TabIndex = 0
        Me.BtnExt.Text = "Exit"
        Me.BtnExt.UseVisualStyleBackColor = True
        '
        'txtAccountHolder
        '
        Me.txtAccountHolder.Location = New System.Drawing.Point(24, 39)
        Me.txtAccountHolder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAccountHolder.Name = "txtAccountHolder"
        Me.txtAccountHolder.Size = New System.Drawing.Size(240, 22)
        Me.txtAccountHolder.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Account Holder Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Account Number:"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(24, 94)
        Me.txtAccountNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(240, 22)
        Me.txtAccountNumber.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(388, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "AccountList:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CountryOfOrigin:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Balance:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Interest Rate:"
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(24, 154)
        Me.txtInterestRate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(240, 22)
        Me.txtInterestRate.TabIndex = 9
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(24, 217)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(240, 22)
        Me.txtBalance.TabIndex = 10
        '
        'txtCountyOfOrigin
        '
        Me.txtCountyOfOrigin.Location = New System.Drawing.Point(391, 39)
        Me.txtCountyOfOrigin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCountyOfOrigin.Name = "txtCountyOfOrigin"
        Me.txtCountyOfOrigin.Size = New System.Drawing.Size(240, 22)
        Me.txtCountyOfOrigin.TabIndex = 11
        '
        'txtListAccounts
        '
        Me.txtListAccounts.Location = New System.Drawing.Point(391, 94)
        Me.txtListAccounts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtListAccounts.Multiline = True
        Me.txtListAccounts.Name = "txtListAccounts"
        Me.txtListAccounts.Size = New System.Drawing.Size(240, 198)
        Me.txtListAccounts.TabIndex = 15
        '
        'BtnAddAccount
        '
        Me.BtnAddAccount.Location = New System.Drawing.Point(373, 314)
        Me.BtnAddAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddAccount.Name = "BtnAddAccount"
        Me.BtnAddAccount.Size = New System.Drawing.Size(129, 96)
        Me.BtnAddAccount.TabIndex = 13
        Me.BtnAddAccount.Text = "Add Account"
        Me.BtnAddAccount.UseVisualStyleBackColor = True
        '
        'BtnAddInterest
        '
        Me.BtnAddInterest.Location = New System.Drawing.Point(195, 314)
        Me.BtnAddInterest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddInterest.Name = "BtnAddInterest"
        Me.BtnAddInterest.Size = New System.Drawing.Size(129, 96)
        Me.BtnAddInterest.TabIndex = 14
        Me.BtnAddInterest.Text = "Add Interest"
        Me.BtnAddInterest.UseVisualStyleBackColor = True
        '
        'BtnPrintAccounts
        '
        Me.BtnPrintAccounts.Location = New System.Drawing.Point(9, 314)
        Me.BtnPrintAccounts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPrintAccounts.Name = "BtnPrintAccounts"
        Me.BtnPrintAccounts.Size = New System.Drawing.Size(129, 96)
        Me.BtnPrintAccounts.TabIndex = 15
        Me.BtnPrintAccounts.Text = "PrintAccounts"
        Me.BtnPrintAccounts.UseVisualStyleBackColor = True
        '
        'BankAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnPrintAccounts)
        Me.Controls.Add(Me.BtnAddInterest)
        Me.Controls.Add(Me.BtnAddAccount)
        Me.Controls.Add(Me.txtListAccounts)
        Me.Controls.Add(Me.txtCountyOfOrigin)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAccountHolder)
        Me.Controls.Add(Me.BtnExt)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BankAccountsForm"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExt As Windows.Forms.Button
    Friend WithEvents txtAccountHolder As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtAccountNumber As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtInterestRate As Windows.Forms.TextBox
    Friend WithEvents txtBalance As Windows.Forms.TextBox
    Friend WithEvents txtCountyOfOrigin As Windows.Forms.TextBox
    Friend WithEvents txtListAccounts As Windows.Forms.TextBox
    Friend WithEvents BtnAddAccount As Windows.Forms.Button
    Friend WithEvents BtnAddInterest As Windows.Forms.Button
    Friend WithEvents BtnPrintAccounts As Windows.Forms.Button
End Class
