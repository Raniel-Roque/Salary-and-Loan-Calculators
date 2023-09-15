<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoanCalc))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Compute = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.AccBox = New System.Windows.Forms.TextBox()
        Me.LRNBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LoanBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RateBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.YearBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6)
        Me.MenuStrip1.Size = New System.Drawing.Size(406, 32)
        Me.MenuStrip1.TabIndex = 1
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
        'Compute
        '
        Me.Compute.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Compute.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Compute.FlatAppearance.BorderSize = 2
        Me.Compute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Compute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Compute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Compute.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compute.Location = New System.Drawing.Point(192, 259)
        Me.Compute.Name = "Compute"
        Me.Compute.Size = New System.Drawing.Size(202, 36)
        Me.Compute.TabIndex = 18
        Me.Compute.Text = "Compute"
        Me.Compute.UseVisualStyleBackColor = False
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
        Me.Clear.Location = New System.Drawing.Point(16, 259)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(166, 36)
        Me.Clear.TabIndex = 17
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'AccBox
        '
        Me.AccBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AccBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.AccBox.Location = New System.Drawing.Point(192, 70)
        Me.AccBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.AccBox.Name = "AccBox"
        Me.AccBox.Size = New System.Drawing.Size(202, 22)
        Me.AccBox.TabIndex = 9
        '
        'LRNBox
        '
        Me.LRNBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LRNBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.LRNBox.Location = New System.Drawing.Point(192, 40)
        Me.LRNBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.LRNBox.Name = "LRNBox"
        Me.LRNBox.ReadOnly = True
        Me.LRNBox.Size = New System.Drawing.Size(202, 22)
        Me.LRNBox.TabIndex = 10
        '
        'NameBox
        '
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.NameBox.Location = New System.Drawing.Point(192, 100)
        Me.NameBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(202, 22)
        Me.NameBox.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 220)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 22)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Year(s) to Pay:"
        '
        'AddressBox
        '
        Me.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddressBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddressBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.AddressBox.Location = New System.Drawing.Point(192, 130)
        Me.AddressBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(202, 22)
        Me.AddressBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Interest Rate:"
        '
        'LoanBox
        '
        Me.LoanBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LoanBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.LoanBox.Location = New System.Drawing.Point(192, 160)
        Me.LoanBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.LoanBox.Name = "LoanBox"
        Me.LoanBox.Size = New System.Drawing.Size(202, 22)
        Me.LoanBox.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Account Loan:"
        '
        'RateBox
        '
        Me.RateBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RateBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.RateBox.Location = New System.Drawing.Point(192, 190)
        Me.RateBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.RateBox.Name = "RateBox"
        Me.RateBox.Size = New System.Drawing.Size(202, 22)
        Me.RateBox.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Address:"
        '
        'YearBox
        '
        Me.YearBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.YearBox.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.YearBox.Location = New System.Drawing.Point(192, 220)
        Me.YearBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(202, 22)
        Me.YearBox.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Account Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Loan Ref. Number:"
        '
        'LoanCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(406, 308)
        Me.Controls.Add(Me.Compute)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.YearBox)
        Me.Controls.Add(Me.RateBox)
        Me.Controls.Add(Me.LoanBox)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.AccBox)
        Me.Controls.Add(Me.LRNBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoanCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Compute As Button
    Friend WithEvents Clear As Button
    Friend WithEvents AccBox As TextBox
    Friend WithEvents LRNBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LoanBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RateBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents YearBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
