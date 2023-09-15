Public Class ColorProgressBar
    'Programmer: Roque, Raniel Christian B
    'Date: September 16 2023
    'BSIT 2A
    Inherits ProgressBar

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim rect As Rectangle = e.ClipRectangle
        rect.Width = CInt(rect.Width * (CDbl(Value) / Maximum)) - 4

        If ProgressBarRenderer.IsSupported Then
            ' Draw the black border
            Using borderPen As New Pen(Color.Black, 3)
                e.Graphics.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1)
            End Using

            rect.Height = rect.Height - 4

            ' Create a custom SolidBrush with the color #02AAAA
            Dim customBrush As New SolidBrush(Color.FromArgb(&HFF02AAAA))

            e.Graphics.FillRectangle(customBrush, 2, 2, rect.Width, rect.Height)
        End If
    End Sub
End Class
