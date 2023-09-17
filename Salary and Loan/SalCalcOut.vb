Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SalCalcOut
    'Programmer: Roque, Raniel Christian B
    'Date: September 17 2023
    'BSIT 2A
    Dim Choose_Financial_Form As Choose_Financial
    Dim SalCalcIn_Form As SalCalc
    Dim SalCalcOut2_Form As SalCalcOut2
    Dim SalCalcOutFull_Form As SalCalcOutFull
    Function CustomFormat(value As Double) As String
        If Math.Floor(value) = 0 Then
            ' Display as 0.XX when the whole number part is less than 1
            Return Format(value, "₱0.00")
        Else
            ' Display as XX.XX for other values
            Return Format(value, "₱#,##.00")
        End If
    End Function
    Private Sub SalCalcOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GSalaryBox.Focus()
        NameBox.Text = GlobalData.Name
        DeptBox.Text = GlobalData.Dept
        WHBox.Text = GlobalData.WHours
        RegRateBox.Text = CustomFormat(GlobalData.RegRate) + "/h"
        OverBox.Text = GlobalData.OverTime
        OverRateBox.Text = CustomFormat(GlobalData.OverRate) + "/h"
        GSalaryBox.Text = CustomFormat((GlobalData.WHours * GlobalData.RegRate) + (GlobalData.OverTime * GlobalData.OverRate))
    End Sub

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
    'New 
    Private Sub NewForm_Click(sender As Object, e As EventArgs) Handles NewForm.Click
        ' Confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Calculate new salary details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If SalCalcIn_Form Is Nothing Then
                SalCalcIn_Form = New SalCalc
            End If
            SalCalcIn_Form.Show()
            Me.Close()
        End If
    End Sub
    'Next Button
    Private Sub NextButt_Click(sender As Object, e As EventArgs) Handles NextButt.Click
        If SalCalcOut2_Form Is Nothing Then
            SalCalcOut2_Form = New SalCalcOut2
        End If
        SalCalcOut2_Form.Show()
        Me.Close()
    End Sub
    'Full View Button
    Private Sub FView_Click(sender As Object, e As EventArgs) Handles FView.Click
        If SalCalcOutFull_Form Is Nothing Then
            SalCalcOutFull_Form = New SalCalcOutFull
        End If
        SalCalcOutFull_Form.Show()
        Me.Close()
    End Sub
End Class