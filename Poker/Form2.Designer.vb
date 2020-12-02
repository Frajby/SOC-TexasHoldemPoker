<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numsouperi = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numchipy = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnkonec = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkblindy = New System.Windows.Forms.CheckBox()
        Me.numericblindy = New System.Windows.Forms.NumericUpDown()
        CType(Me.numsouperi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numchipy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericblindy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Počet Hráčů (max 7) :"
        '
        'numsouperi
        '
        Me.numsouperi.Location = New System.Drawing.Point(195, 22)
        Me.numsouperi.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.numsouperi.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numsouperi.Name = "numsouperi"
        Me.numsouperi.Size = New System.Drawing.Size(73, 20)
        Me.numsouperi.TabIndex = 1
        Me.numsouperi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Počet chipů (max 10 000) :"
        '
        'numchipy
        '
        Me.numchipy.Location = New System.Drawing.Point(195, 50)
        Me.numchipy.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numchipy.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numchipy.Name = "numchipy"
        Me.numchipy.Size = New System.Drawing.Size(76, 20)
        Me.numchipy.TabIndex = 3
        Me.numchipy.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnkonec
        '
        Me.btnkonec.Location = New System.Drawing.Point(95, 114)
        Me.btnkonec.Name = "btnkonec"
        Me.btnkonec.Size = New System.Drawing.Size(75, 23)
        Me.btnkonec.TabIndex = 5
        Me.btnkonec.Text = "Konec"
        Me.btnkonec.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(106, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Big Blind:"
        '
        'checkblindy
        '
        Me.checkblindy.AutoSize = True
        Me.checkblindy.Location = New System.Drawing.Point(85, 79)
        Me.checkblindy.Name = "checkblindy"
        Me.checkblindy.Size = New System.Drawing.Size(15, 14)
        Me.checkblindy.TabIndex = 7
        Me.checkblindy.UseVisualStyleBackColor = True
        '
        'numericblindy
        '
        Me.numericblindy.Enabled = False
        Me.numericblindy.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numericblindy.Location = New System.Drawing.Point(195, 77)
        Me.numericblindy.Name = "numericblindy"
        Me.numericblindy.Size = New System.Drawing.Size(76, 20)
        Me.numericblindy.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 149)
        Me.Controls.Add(Me.numericblindy)
        Me.Controls.Add(Me.checkblindy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnkonec)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numchipy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numsouperi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Poker"
        CType(Me.numsouperi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numchipy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericblindy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numsouperi As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numchipy As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnkonec As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents checkblindy As System.Windows.Forms.CheckBox
    Friend WithEvents numericblindy As System.Windows.Forms.NumericUpDown
End Class
