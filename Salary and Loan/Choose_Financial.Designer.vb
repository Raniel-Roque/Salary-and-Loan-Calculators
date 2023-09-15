<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Choose_Financial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choose_Financial))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoanButt = New System.Windows.Forms.Button()
        Me.SalButt = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(286, 32)
        Me.MenuStrip1.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(166, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Salary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(34, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Loan"
        '
        'LoanButt
        '
        Me.LoanButt.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.LoanButt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoanButt.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LoanButt.FlatAppearance.BorderSize = 2
        Me.LoanButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.LoanButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LoanButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoanButt.Image = CType(resources.GetObject("LoanButt.Image"), System.Drawing.Image)
        Me.LoanButt.Location = New System.Drawing.Point(17, 76)
        Me.LoanButt.Name = "LoanButt"
        Me.LoanButt.Size = New System.Drawing.Size(110, 110)
        Me.LoanButt.TabIndex = 8
        Me.LoanButt.UseVisualStyleBackColor = False
        '
        'SalButt
        '
        Me.SalButt.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.SalButt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalButt.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SalButt.FlatAppearance.BorderSize = 2
        Me.SalButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.SalButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SalButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalButt.Image = CType(resources.GetObject("SalButt.Image"), System.Drawing.Image)
        Me.SalButt.Location = New System.Drawing.Point(161, 76)
        Me.SalButt.Name = "SalButt"
        Me.SalButt.Size = New System.Drawing.Size(110, 110)
        Me.SalButt.TabIndex = 7
        Me.SalButt.UseVisualStyleBackColor = False
        '
        'Choose_Financial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(286, 204)
        Me.Controls.Add(Me.LoanButt)
        Me.Controls.Add(Me.SalButt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Choose_Financial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financial Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SalButt As Button
    Friend WithEvents LoanButt As Button
End Class
