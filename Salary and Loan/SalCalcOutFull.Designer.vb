<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalCalcOutFull
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalCalcOutFull))
        Me.GSalaryBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.OverRateBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OverBox = New System.Windows.Forms.TextBox()
        Me.RegRateBox = New System.Windows.Forms.TextBox()
        Me.WHBox = New System.Windows.Forms.TextBox()
        Me.DeptBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NetBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DeductionBox = New System.Windows.Forms.TextBox()
        Me.IncomeTaxBox = New System.Windows.Forms.TextBox()
        Me.PIBox = New System.Windows.Forms.TextBox()
        Me.PHBox = New System.Windows.Forms.TextBox()
        Me.SSSBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NewForm = New System.Windows.Forms.Button()
        Me.FView = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GSalaryBox
        '
        Me.GSalaryBox.BackColor = System.Drawing.SystemColors.Control
        Me.GSalaryBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GSalaryBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.GSalaryBox.ForeColor = System.Drawing.Color.DarkGreen
        Me.GSalaryBox.Location = New System.Drawing.Point(168, 260)
        Me.GSalaryBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.GSalaryBox.Name = "GSalaryBox"
        Me.GSalaryBox.ReadOnly = True
        Me.GSalaryBox.Size = New System.Drawing.Size(202, 22)
        Me.GSalaryBox.TabIndex = 78
        Me.GSalaryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 260)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 22)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Gross Salary:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 40)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(243, 32)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "SALARY DETAILS"
        '
        'OverRateBox
        '
        Me.OverRateBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OverRateBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.OverRateBox.Location = New System.Drawing.Point(168, 230)
        Me.OverRateBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.OverRateBox.Name = "OverRateBox"
        Me.OverRateBox.ReadOnly = True
        Me.OverRateBox.Size = New System.Drawing.Size(202, 22)
        Me.OverRateBox.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 230)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 22)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Overtime Rate:"
        '
        'OverBox
        '
        Me.OverBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OverBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.OverBox.Location = New System.Drawing.Point(168, 200)
        Me.OverBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.OverBox.Name = "OverBox"
        Me.OverBox.ReadOnly = True
        Me.OverBox.Size = New System.Drawing.Size(202, 22)
        Me.OverBox.TabIndex = 83
        '
        'RegRateBox
        '
        Me.RegRateBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegRateBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.RegRateBox.Location = New System.Drawing.Point(168, 170)
        Me.RegRateBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.RegRateBox.Name = "RegRateBox"
        Me.RegRateBox.ReadOnly = True
        Me.RegRateBox.Size = New System.Drawing.Size(202, 22)
        Me.RegRateBox.TabIndex = 82
        '
        'WHBox
        '
        Me.WHBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WHBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.WHBox.Location = New System.Drawing.Point(168, 140)
        Me.WHBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.WHBox.Name = "WHBox"
        Me.WHBox.ReadOnly = True
        Me.WHBox.Size = New System.Drawing.Size(202, 22)
        Me.WHBox.TabIndex = 81
        '
        'DeptBox
        '
        Me.DeptBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DeptBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DeptBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.DeptBox.Location = New System.Drawing.Point(168, 110)
        Me.DeptBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.DeptBox.Name = "DeptBox"
        Me.DeptBox.ReadOnly = True
        Me.DeptBox.Size = New System.Drawing.Size(202, 22)
        Me.DeptBox.TabIndex = 80
        '
        'NameBox
        '
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.NameBox.Location = New System.Drawing.Point(168, 80)
        Me.NameBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.ReadOnly = True
        Me.NameBox.Size = New System.Drawing.Size(202, 22)
        Me.NameBox.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 200)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 22)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Overtime:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 170)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 22)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Regular Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 22)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Working Hour(s):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Department:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 22)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Name:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6)
        Me.MenuStrip1.Size = New System.Drawing.Size(390, 32)
        Me.MenuStrip1.TabIndex = 93
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 290)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 19)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Deductions:"
        '
        'NetBox
        '
        Me.NetBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NetBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.NetBox.Location = New System.Drawing.Point(168, 462)
        Me.NetBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.NetBox.Name = "NetBox"
        Me.NetBox.ReadOnly = True
        Me.NetBox.Size = New System.Drawing.Size(202, 22)
        Me.NetBox.TabIndex = 1
        Me.NetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(77, 461)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 22)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Net Pay:"
        '
        'DeductionBox
        '
        Me.DeductionBox.BackColor = System.Drawing.SystemColors.Control
        Me.DeductionBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DeductionBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.DeductionBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.DeductionBox.Location = New System.Drawing.Point(168, 432)
        Me.DeductionBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.DeductionBox.Name = "DeductionBox"
        Me.DeductionBox.ReadOnly = True
        Me.DeductionBox.Size = New System.Drawing.Size(202, 22)
        Me.DeductionBox.TabIndex = 99
        Me.DeductionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IncomeTaxBox
        '
        Me.IncomeTaxBox.BackColor = System.Drawing.SystemColors.Control
        Me.IncomeTaxBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IncomeTaxBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.IncomeTaxBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.IncomeTaxBox.Location = New System.Drawing.Point(168, 402)
        Me.IncomeTaxBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.IncomeTaxBox.Name = "IncomeTaxBox"
        Me.IncomeTaxBox.ReadOnly = True
        Me.IncomeTaxBox.Size = New System.Drawing.Size(202, 22)
        Me.IncomeTaxBox.TabIndex = 98
        Me.IncomeTaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PIBox
        '
        Me.PIBox.BackColor = System.Drawing.SystemColors.Control
        Me.PIBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PIBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.PIBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PIBox.Location = New System.Drawing.Point(168, 372)
        Me.PIBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.PIBox.Name = "PIBox"
        Me.PIBox.ReadOnly = True
        Me.PIBox.Size = New System.Drawing.Size(202, 22)
        Me.PIBox.TabIndex = 97
        Me.PIBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PHBox
        '
        Me.PHBox.BackColor = System.Drawing.SystemColors.Control
        Me.PHBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PHBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PHBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.PHBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PHBox.Location = New System.Drawing.Point(168, 342)
        Me.PHBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.PHBox.Name = "PHBox"
        Me.PHBox.ReadOnly = True
        Me.PHBox.Size = New System.Drawing.Size(202, 22)
        Me.PHBox.TabIndex = 96
        Me.PHBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SSSBox
        '
        Me.SSSBox.BackColor = System.Drawing.SystemColors.Control
        Me.SSSBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SSSBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SSSBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.SSSBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.SSSBox.Location = New System.Drawing.Point(168, 312)
        Me.SSSBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.SSSBox.Name = "SSSBox"
        Me.SSSBox.ReadOnly = True
        Me.SSSBox.Size = New System.Drawing.Size(202, 22)
        Me.SSSBox.TabIndex = 95
        Me.SSSBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 432)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 22)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "Total Deduction:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 402)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 22)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Income Tax:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(71, 372)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 22)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Pag-Ibig:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(59, 342)
        Me.Label14.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 22)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "PhilHealth:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(104, 312)
        Me.Label15.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 22)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "SSS:"
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
        Me.NewForm.Location = New System.Drawing.Point(168, 502)
        Me.NewForm.Name = "NewForm"
        Me.NewForm.Size = New System.Drawing.Size(202, 36)
        Me.NewForm.TabIndex = 108
        Me.NewForm.Text = "New"
        Me.NewForm.UseVisualStyleBackColor = False
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
        Me.FView.Location = New System.Drawing.Point(16, 502)
        Me.FView.Name = "FView"
        Me.FView.Size = New System.Drawing.Size(146, 36)
        Me.FView.TabIndex = 107
        Me.FView.Text = "Small View"
        Me.FView.UseVisualStyleBackColor = False
        '
        'SalCalcOutFull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(390, 551)
        Me.Controls.Add(Me.NewForm)
        Me.Controls.Add(Me.FView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NetBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DeductionBox)
        Me.Controls.Add(Me.IncomeTaxBox)
        Me.Controls.Add(Me.PIBox)
        Me.Controls.Add(Me.PHBox)
        Me.Controls.Add(Me.SSSBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GSalaryBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.OverRateBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.OverBox)
        Me.Controls.Add(Me.RegRateBox)
        Me.Controls.Add(Me.WHBox)
        Me.Controls.Add(Me.DeptBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalCalcOutFull"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalCalcOutFull"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GSalaryBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents OverRateBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OverBox As TextBox
    Friend WithEvents RegRateBox As TextBox
    Friend WithEvents WHBox As TextBox
    Friend WithEvents DeptBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents NetBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DeductionBox As TextBox
    Friend WithEvents IncomeTaxBox As TextBox
    Friend WithEvents PIBox As TextBox
    Friend WithEvents PHBox As TextBox
    Friend WithEvents SSSBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents NewForm As Button
    Friend WithEvents FView As Button
End Class
