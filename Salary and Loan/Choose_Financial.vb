Public Class Choose_Financial
    'Programmer: Roque, Raniel Christian B
    'Date: September 16 2023
    'BSIT 2A

    'Forms to be used
    Dim Loading_Financial_Form As Loading_Financial
    Dim Loan_Financial_Form As LoanCalc
    Dim Salary_Financial_Form As SalCalc
    'Placeholder for Home on Final Compilation
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ' Confirmation dialog
        ' Placeholder for Compilation Project
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back to loading screen?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Loading_Financial_Form Is Nothing Then
                Loading_Financial_Form = New Loading_Financial
            End If
            Loading_Financial_Form.Show()
            Me.Close()
        End If
    End Sub
    'Loads Loan
    Private Sub LoanButt_Click(sender As Object, e As EventArgs) Handles LoanButt.Click
        If Loan_Financial_Form Is Nothing Then
            Loan_Financial_Form = New LoanCalc
        End If
        Loan_Financial_Form.Show()
        Me.Close()
    End Sub
    'Loads Salary
    Private Sub SalButt_Click(sender As Object, e As EventArgs) Handles SalButt.Click
        If Salary_Financial_Form Is Nothing Then
            Salary_Financial_Form = New SalCalc
        End If
        Salary_Financial_Form.Show()
        Me.Close()
    End Sub
End Class