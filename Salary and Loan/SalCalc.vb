Imports System.Reflection.Emit

Public Class SalCalc
    'Programmer: Roque, Raniel Christian B
    'Date: September 16 2023
    'BSIT 2A
    Dim Choose_Financial_Form As Choose_Financial
    Dim SalCalcOut_Form As SalCalcOut
    Private Sub SalCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameBox.Focus()
    End Sub

    Private Sub HomeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
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

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear data?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            NameBox.Text = ""
            DeptBox.Text = ""
            WHBox.Text = ""
            RegRateBox.Text = ""
            OverBox.Text = ""
            OverRateBox.Text = ""
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            Label6.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles Compute.Click
        Dim InputFields As (TextBox, System.Windows.Forms.Label, String)() = {
            (NameBox, Label1, "Name"),
            (DeptBox, Label2, "Department"),
            (WHBox, Label3, "Working Hour(s)"),
            (RegRateBox, Label4, "Regular Rate"),
            (OverBox, Label5, "Overtime"),
            (OverRateBox, Label6, "Overtime Rate")
        }

        Dim EmptyFields As New List(Of String)

        For Each field In InputFields
            Dim textBox As TextBox = field.Item1
            Dim label As System.Windows.Forms.Label = field.Item2
            Dim fieldName As String = field.Item3

            If String.IsNullOrEmpty(textBox.Text) Then
                label.ForeColor = Color.FromArgb(192, 0, 0)
                EmptyFields.Add(fieldName)
            Else
                label.ForeColor = Color.Black
            End If
        Next

        If EmptyFields.Count > 0 Then
            Dim errorMessage As String = $"Please fill in: {String.Join(", ", EmptyFields)}"
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'End of Null Checker
        'Start of Valid Double Input for WHours, Rate, Overtime, OverRate

        Dim NumberFields As (TextBox, System.Windows.Forms.Label, String)() = {
            (WHBox, Label3, "Working Hour(s)"),
            (RegRateBox, Label4, "Regular Rate"),
            (OverBox, Label5, "Overtime"),
            (OverRateBox, Label6, "Overtime Rate")
        }

        Dim InvalidFields As New List(Of String)

        For Each field In NumberFields
            Dim textBox As TextBox = field.Item1
            Dim label As System.Windows.Forms.Label = field.Item2
            Dim fieldName As String = field.Item3

            If Not Double.TryParse(textBox.Text, Nothing) Then
                label.ForeColor = Color.FromArgb(192, 0, 0)
                InvalidFields.Add(fieldName)
            Else
                label.ForeColor = Color.Black
            End If
        Next

        If InvalidFields.Count > 0 Then
            Dim errorMessage As String = $"Please enter valid numbers for: {String.Join(", ", InvalidFields)}."
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure details given are correct?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            GlobalData.Name = NameBox.Text
            GlobalData.Dept = DeptBox.Text
            GlobalData.WHours = WHBox.Text
            GlobalData.RegRate = RegRateBox.Text
            GlobalData.OverTime = OverBox.Text
            GlobalData.OverRate = OverRateBox.Text
            If SalCalcOut_Form Is Nothing Then
                SalCalcOut_Form = New SalCalcOut
            End If
            SalCalcOut_Form.Show()
            Me.Close()
        End If
    End Sub
    Private Sub NameBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NameBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            DeptBox.Focus()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub DeptBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DeptBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            WHBox.Focus()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            NameBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub WHBox_KeyDown(sender As Object, e As KeyEventArgs) Handles WHBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            RegRateBox.Focus()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            DeptBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RegRateBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RegRateBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            OverBox.Focus()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            WHBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub OverBox_KeyDown(sender As Object, e As KeyEventArgs) Handles OverBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            OverRateBox.Focus()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            RegRateBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub OverRateBox_KeyDown(sender As Object, e As KeyEventArgs) Handles OverRateBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Compute.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            OverBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class