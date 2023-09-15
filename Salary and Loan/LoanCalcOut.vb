Public Class LoanCalcOut
    'Programmer: Roque, Raniel Christian B
    'Date: September 16 2023
    'BSIT 2A
    Dim Choose_Financial_Form As Choose_Financial
    Dim In_Financial_Form As LoanCalc
    'Previous Form
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ' Confirmation dialog
        ' Placeholder for Compilation Project
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back to main menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Choose_Financial_Form Is Nothing Then
                Choose_Financial_Form = New Choose_Financial
            End If
            Choose_Financial_Form.Show()
            Me.Close()
        End If
    End Sub
    Private Sub LoanCalcOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LRNBox.Text = String.Format("{0:D5}", GlobalData.LRN)
        AccBox.Text = GlobalData.AccNum
        NameBox.Text = GlobalData.Name
        AddressBox.Text = GlobalData.Address
        LoanBox.Text = Format(GlobalData.Loan, "₱#,##.00")
        RateBox.Text = (GlobalData.Rate.ToString()) + "%"
        YearBox.Text = GlobalData.Year

        Dim YearlyInterestValue As Double = GlobalData.Loan * (GlobalData.Rate / 100)

        MonthPay.Text = Format(YearlyInterestValue / 12, "₱#,##.00")
        TotalInterest.Text = Format(YearlyInterestValue * GlobalData.Year, "₱#,##.00")
        AnnualPay.Text = Format(YearlyInterestValue, "₱#,##.00")
        LoanPay.Text = Format(GlobalData.Loan + (YearlyInterestValue * GlobalData.Year), "₱#,##.00")

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        GlobalData.LRN += 1
        If In_Financial_Form Is Nothing Then
            In_Financial_Form = New LoanCalc
        End If
        In_Financial_Form.Show()
        Me.Close()
    End Sub
End Class