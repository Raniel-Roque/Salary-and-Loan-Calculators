
Public Class Loading_Financial
    'Programmer: Roque, Raniel Christian B
    'Date: September 16 2023
    'BSIT 2A
    'Next Form
    Dim Choose_Financial_Form As Choose_Financial
    'Progress Bar
    Private Sub Loading_Timer_Tick(sender As Object, e As EventArgs) Handles Loading_Timer.Tick
        If ColorProgressBar1.Value <= ColorProgressBar1.Maximum - 1 Then
            ColorProgressBar1.Value += 4
        ElseIf ColorProgressBar1.Value = ColorProgressBar1.Maximum Then
            If Choose_Financial_Form Is Nothing Then
                Choose_Financial_Form = New Choose_Financial
            End If
            Choose_Financial_Form.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Loading_Financial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
