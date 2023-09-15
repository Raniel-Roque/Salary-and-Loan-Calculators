Public Class SalCalc
    'Programmer: Roque, Raniel Christian B
    'Date: September 16 2023
    'BSIT 2A
    Dim Choose_Financial_Form As Choose_Financial
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

    Private Sub SalCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class