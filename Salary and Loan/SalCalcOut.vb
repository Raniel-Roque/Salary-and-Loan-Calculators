﻿Public Class SalCalcOut
    Private Sub SalCalcOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameBox.Text = GlobalData.Name
        DeptBox.Text = GlobalData.Dept
        WHBox.Text = GlobalData.WHours
        RegRateBox.Text = GlobalData.RegRate
        OverBox.Text = GlobalData.OverTime
        OverRateBox.Text = GlobalData.OverRate
    End Sub
End Class