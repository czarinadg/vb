Public Class Form1
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles ti_op.TextChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim loanRef As Integer = Integer.Parse(loanRef_main.Text)
        Dim accNum As Integer = Integer.Parse(an_main.Text)
        Dim name As String = name_main.Text
        Dim address As String = add_main.Text
        Dim amountLoan As Double = Double.Parse(al_main.Text) ' Assuming the loan amount can be a decimal value
        Dim interestRate As Double = Double.Parse(ir_main.Text) / 100 ' Assuming interest rate is in percentage (e.g., 5%)
        Dim yearsPay As Integer = Integer.Parse(ytp_main.Text)

        Dim monthlyInterestRate As Double = interestRate / 12
        Dim totalPayments As Integer = yearsPay * 12

        Dim monthlyPayment As Double = amountLoan * (monthlyInterestRate * (1 + monthlyInterestRate) ^ totalPayments) / ((1 + monthlyInterestRate) ^ totalPayments - 1)
        Dim totalInterest As Double = (monthlyPayment * totalPayments) - amountLoan
        Dim totalAnnualPayment As Double = monthlyPayment * 12
        Dim totalLoanAmount As Double = amountLoan + totalInterest

        loanRef_op.Text = loanRef.ToString()
        acc_op.Text = accNum.ToString()
        name_op.Text = name
        add_op.Text = address
        al_op.Text = amountLoan.ToString()
        ir_op.Text = (interestRate * 100).ToString() ' Display interest rate as a percentage
        ytp_op.Text = yearsPay.ToString()
        mp_op.Text = monthlyPayment.ToString("C2") ' Display as currency
        ti_op.Text = totalInterest.ToString("C2")
        ta_op.Text = totalAnnualPayment.ToString("C2")
        tl_op.Text = totalLoanAmount.ToString("C2")
    End Sub
End Class
