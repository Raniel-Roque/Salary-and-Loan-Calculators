﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalCalcOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalCalcOut))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OverRateBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
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
        Me.Compute = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(389, 32)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OverRateBox
        '
        Me.OverRateBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OverRateBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.OverRateBox.Location = New System.Drawing.Point(168, 231)
        Me.OverRateBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.OverRateBox.Name = "OverRateBox"
        Me.OverRateBox.ReadOnly = True
        Me.OverRateBox.Size = New System.Drawing.Size(202, 22)
        Me.OverRateBox.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 231)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 22)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Overtime Rate:"
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Clear.FlatAppearance.BorderSize = 2
        Me.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(16, 273)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(148, 36)
        Me.Clear.TabIndex = 47
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'OverBox
        '
        Me.OverBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OverBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.OverBox.Location = New System.Drawing.Point(168, 201)
        Me.OverBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.OverBox.Name = "OverBox"
        Me.OverBox.ReadOnly = True
        Me.OverBox.Size = New System.Drawing.Size(202, 22)
        Me.OverBox.TabIndex = 40
        '
        'RegRateBox
        '
        Me.RegRateBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegRateBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.RegRateBox.Location = New System.Drawing.Point(168, 171)
        Me.RegRateBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.RegRateBox.Name = "RegRateBox"
        Me.RegRateBox.ReadOnly = True
        Me.RegRateBox.Size = New System.Drawing.Size(202, 22)
        Me.RegRateBox.TabIndex = 39
        '
        'WHBox
        '
        Me.WHBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WHBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.WHBox.Location = New System.Drawing.Point(168, 141)
        Me.WHBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.WHBox.Name = "WHBox"
        Me.WHBox.ReadOnly = True
        Me.WHBox.Size = New System.Drawing.Size(202, 22)
        Me.WHBox.TabIndex = 38
        '
        'DeptBox
        '
        Me.DeptBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DeptBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DeptBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.DeptBox.Location = New System.Drawing.Point(168, 111)
        Me.DeptBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.DeptBox.Name = "DeptBox"
        Me.DeptBox.ReadOnly = True
        Me.DeptBox.Size = New System.Drawing.Size(202, 22)
        Me.DeptBox.TabIndex = 37
        '
        'NameBox
        '
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.NameBox.Location = New System.Drawing.Point(168, 81)
        Me.NameBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.ReadOnly = True
        Me.NameBox.Size = New System.Drawing.Size(202, 22)
        Me.NameBox.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 201)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 22)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Overtime:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 22)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Regular Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 22)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Working Hour(s):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Department:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 22)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Name:"
        '
        'Compute
        '
        Me.Compute.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Compute.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Compute.FlatAppearance.BorderSize = 2
        Me.Compute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Compute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Compute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Compute.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compute.Location = New System.Drawing.Point(168, 273)
        Me.Compute.Name = "Compute"
        Me.Compute.Size = New System.Drawing.Size(202, 36)
        Me.Compute.TabIndex = 49
        Me.Compute.Text = "Compute"
        Me.Compute.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(85, 41)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(243, 32)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "SALARY DETAILS"
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
        'SalCalcOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 326)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Compute)
        Me.Controls.Add(Me.OverRateBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Clear)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalCalcOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverRateBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Clear As Button
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
    Friend WithEvents Compute As Button
    Friend WithEvents Label12 As Label
End Class
