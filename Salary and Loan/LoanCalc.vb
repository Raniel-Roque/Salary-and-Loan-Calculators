Public Class LoanCalc
    'Programmer: Roque, Raniel Christian B
    'Date: September 16 2023
    'BSIT 2A
    'Forms
    Dim Choose_Financial_Form As Choose_Financial
    Dim Out_Financial_Form As LoanCalcOut
    'Sets initial value of LRN and Focuses on Namebox
    Private Sub LoanCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LRNBox.Text = String.Format("{0:D5}", GlobalData.LRN)
        TextBox1.Focus()
    End Sub

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
    'CLEAR
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear data?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            AccBox.Text = ""
            NameBox.Text = ""
            AddressBox.Text = ""
            LoanBox.Text = ""
            RateBox.Text = ""
            YearBox.Text = ""
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            Label6.ForeColor = Color.Black
            Label7.ForeColor = Color.Black
        End If
    End Sub
    'Checking and Saving data into GlobalData
    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles Compute.Click
        'CHECKS IF NULL FIELDS 
        Dim InputFields As (TextBox, Label, String)() = {
            (AccBox, Label2, "Account Number"),
            (NameBox, Label3, "Name"),
            (AddressBox, Label4, "Address"),
            (LoanBox, Label5, "Account Loan"),
            (RateBox, Label6, "Interest Rate"),
            (YearBox, Label7, "Year(s) to Pay")
        }

        Dim EmptyFields As New List(Of String)

        For Each field In InputFields
            Dim textBox As TextBox = field.Item1
            Dim label As Label = field.Item2
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
        'Start of Valid Double Input for Loan, Rate and Year
        '(AccNum checking is checking if input is only numbers and not necessarily for computation)

        Dim NumberFields As (TextBox, Label, String)() = {
            (AccBox, Label2, "Account Number"),
            (LoanBox, Label5, "Account Loan"),
            (RateBox, Label6, "Interest Rate"),
            (YearBox, Label7, "Year(s) to Pay")
        }

        Dim InvalidFields As New List(Of String)

        For Each field In NumberFields
            Dim textBox As TextBox = field.Item1
            Dim label As Label = field.Item2
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

        Dim result As DialogResult = MessageBox.Show("Are you sure details given are correct?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Out_Financial_Form Is Nothing Then
                Out_Financial_Form = New LoanCalcOut
            End If
            GlobalData.AccNum = AccBox.Text
            GlobalData.Name = NameBox.Text
            GlobalData.Address = AddressBox.Text
            GlobalData.Loan = Double.Parse(LoanBox.Text)
            GlobalData.Rate = Double.Parse(RateBox.Text)
            GlobalData.Year = Double.Parse(YearBox.Text)
            Out_Financial_Form.Show()
            Me.Close()
        End If

    End Sub
    'SHORTCUTS
    Private Sub AccBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AccBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            NameBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub NameBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NameBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            AddressBox.Focus()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            AccBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub AddressBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AddressBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            LoanBox.Focus()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            NameBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub LoanBox_KeyDown(sender As Object, e As KeyEventArgs) Handles LoanBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            RateBox.Focus()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            AddressBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RateBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RateBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            YearBox.Focus()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            LoanBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub YearBox_KeyDown(sender As Object, e As KeyEventArgs) Handles YearBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Compute_Click(sender, e)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            RateBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class