Public Class LoanCalcOut
    'Programmer: Roque, Raniel Christian B
    'Date: September 16 2023
    'BSIT 2A
    Dim Choose_Financial_Form As Choose_Financial
    Dim In_Financial_Form As LoanCalc
    Function CustomFormat(value As Double) As String
        If Math.Floor(value) = 0 Then
            ' Display as 0.XX when the whole number part is less than 1
            Return Format(value, "₱0.00")
        Else
            ' Display as XX.XX for other values
            Return Format(value, "₱#,##.00")
        End If
    End Function

    'Previous Form
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ' Confirmation dialog
        ' Placeholder for Compilation Project
        ' LRN += 1 for next LRN even if going home
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back to main menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            GlobalData.LRN += 1
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
        LoanBox.Text = CustomFormat(GlobalData.Loan)
        If GlobalData.Rate < 0 Then
            RateBox.Text = "0" + GlobalData.Rate.ToString() + "%"
        Else
            RateBox.Text = (GlobalData.Rate.ToString()) + "%"
        End If
        YearBox.Text = GlobalData.Year
        ' Loads Global Data Info to corresponding TextBs
        ' YearlyInterestValue for readability 

        Dim YearlyInterestValue As Double = GlobalData.Loan * (GlobalData.Rate / 100) * GlobalData.Year

        MonthPay.Text = CustomFormat(((GlobalData.Loan + YearlyInterestValue) / GlobalData.Year) / 12)
        TotalInterest.Text = CustomFormat(YearlyInterestValue)
        AnnualPay.Text = CustomFormat((GlobalData.Loan + YearlyInterestValue) / GlobalData.Year)
        LoanPay.Text = CustomFormat(GlobalData.Loan + YearlyInterestValue)

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        ' Confirmation dialog (LRN +1 for Global Data LRN)
        Dim result As DialogResult = MessageBox.Show("Calculate new loan?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            GlobalData.LRN += 1
            If In_Financial_Form Is Nothing Then
                In_Financial_Form = New LoanCalc
            End If
            In_Financial_Form.Show()
            Me.Close()
        End If
    End Sub
End Class