<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalCalcOut2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalCalcOut2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NetBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeductionBox = New System.Windows.Forms.TextBox()
        Me.IncomeTaxBox = New System.Windows.Forms.TextBox()
        Me.PIBox = New System.Windows.Forms.TextBox()
        Me.PHBox = New System.Windows.Forms.TextBox()
        Me.SSSBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FView = New System.Windows.Forms.Button()
        Me.NewForm = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6)
        Me.MenuStrip1.Size = New System.Drawing.Size(387, 32)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HomeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HomeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 40)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(243, 32)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "SALARY DETAILS"
        '
        'NetBox
        '
        Me.NetBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NetBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.NetBox.Location = New System.Drawing.Point(168, 243)
        Me.NetBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.NetBox.Name = "NetBox"
        Me.NetBox.ReadOnly = True
        Me.NetBox.Size = New System.Drawing.Size(202, 22)
        Me.NetBox.TabIndex = 50
        Me.NetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 22)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Net Pay:"
        '
        'DeductionBox
        '
        Me.DeductionBox.BackColor = System.Drawing.SystemColors.Control
        Me.DeductionBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DeductionBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.DeductionBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DeductionBox.Location = New System.Drawing.Point(168, 213)
        Me.DeductionBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.DeductionBox.Name = "DeductionBox"
        Me.DeductionBox.ReadOnly = True
        Me.DeductionBox.Size = New System.Drawing.Size(202, 22)
        Me.DeductionBox.TabIndex = 55
        Me.DeductionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IncomeTaxBox
        '
        Me.IncomeTaxBox.BackColor = System.Drawing.SystemColors.Control
        Me.IncomeTaxBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IncomeTaxBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.IncomeTaxBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IncomeTaxBox.Location = New System.Drawing.Point(168, 183)
        Me.IncomeTaxBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.IncomeTaxBox.Name = "IncomeTaxBox"
        Me.IncomeTaxBox.ReadOnly = True
        Me.IncomeTaxBox.Size = New System.Drawing.Size(202, 22)
        Me.IncomeTaxBox.TabIndex = 54
        Me.IncomeTaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PIBox
        '
        Me.PIBox.BackColor = System.Drawing.SystemColors.Control
        Me.PIBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PIBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.PIBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PIBox.Location = New System.Drawing.Point(168, 153)
        Me.PIBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.PIBox.Name = "PIBox"
        Me.PIBox.ReadOnly = True
        Me.PIBox.Size = New System.Drawing.Size(202, 22)
        Me.PIBox.TabIndex = 53
        Me.PIBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PHBox
        '
        Me.PHBox.BackColor = System.Drawing.SystemColors.Control
        Me.PHBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PHBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PHBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.PHBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PHBox.Location = New System.Drawing.Point(168, 123)
        Me.PHBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.PHBox.Name = "PHBox"
        Me.PHBox.ReadOnly = True
        Me.PHBox.Size = New System.Drawing.Size(202, 22)
        Me.PHBox.TabIndex = 52
        Me.PHBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SSSBox
        '
        Me.SSSBox.BackColor = System.Drawing.SystemColors.Control
        Me.SSSBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SSSBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SSSBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.SSSBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SSSBox.Location = New System.Drawing.Point(168, 93)
        Me.SSSBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.SSSBox.Name = "SSSBox"
        Me.SSSBox.ReadOnly = True
        Me.SSSBox.Size = New System.Drawing.Size(202, 22)
        Me.SSSBox.TabIndex = 51
        Me.SSSBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 213)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 22)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Total Deduction:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 22)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Income Tax:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Pag-Ibig:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "PhilHealth:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 22)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "SSS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 71)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 19)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Deductions:"
        '
        'FView
        '
        Me.FView.BackColor = System.Drawing.Color.PeachPuff
        Me.FView.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FView.FlatAppearance.BorderSize = 2
        Me.FView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff
        Me.FView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen
        Me.FView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FView.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FView.Location = New System.Drawing.Point(116, 279)
        Me.FView.Name = "FView"
        Me.FView.Size = New System.Drawing.Size(151, 36)
        Me.FView.TabIndex = 75
        Me.FView.Text = "Full View"
        Me.FView.UseVisualStyleBackColor = False
        '
        'NewForm
        '
        Me.NewForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.NewForm.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.NewForm.FlatAppearance.BorderSize = 2
        Me.NewForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.NewForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.NewForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewForm.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewForm.Location = New System.Drawing.Point(16, 279)
        Me.NewForm.Name = "NewForm"
        Me.NewForm.Size = New System.Drawing.Size(94, 36)
        Me.NewForm.TabIndex = 74
        Me.NewForm.Text = "New"
        Me.NewForm.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Back.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Back.FlatAppearance.BorderSize = 2
        Me.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(273, 279)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(97, 36)
        Me.Back.TabIndex = 73
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'SalCalcOut2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(387, 330)
        Me.Controls.Add(Me.FView)
        Me.Controls.Add(Me.NewForm)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.NetBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DeductionBox)
        Me.Controls.Add(Me.IncomeTaxBox)
        Me.Controls.Add(Me.PIBox)
        Me.Controls.Add(Me.PHBox)
        Me.Controls.Add(Me.SSSBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalCalcOut2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents NetBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DeductionBox As TextBox
    Friend WithEvents IncomeTaxBox As TextBox
    Friend WithEvents PIBox As TextBox
    Friend WithEvents PHBox As TextBox
    Friend WithEvents SSSBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FView As Button
    Friend WithEvents NewForm As Button
    Friend WithEvents Back As Button
End Class
