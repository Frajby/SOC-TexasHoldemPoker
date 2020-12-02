<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panelflop = New System.Windows.Forms.Panel()
        Me.Timerlogikahry = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.panelja = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnfold = New System.Windows.Forms.Button()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.btnraise = New System.Windows.Forms.Button()
        Me.numsazka = New System.Windows.Forms.NumericUpDown()
        Me.btnnovahra = New System.Windows.Forms.Button()
        Me.lblmojechips = New System.Windows.Forms.Label()
        Me.lblpot = New System.Windows.Forms.Label()
        CType(Me.numsazka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelflop
        '
        Me.panelflop.BackColor = System.Drawing.Color.Transparent
        Me.panelflop.Location = New System.Drawing.Point(322, 258)
        Me.panelflop.Name = "panelflop"
        Me.panelflop.Size = New System.Drawing.Size(384, 80)
        Me.panelflop.TabIndex = 5
        '
        'Timerlogikahry
        '
        Me.Timerlogikahry.Interval = 1000
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"--------------"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 456)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(178, 121)
        Me.ListBox1.TabIndex = 9
        '
        'panelja
        '
        Me.panelja.BackColor = System.Drawing.Color.Transparent
        Me.panelja.Location = New System.Drawing.Point(455, 470)
        Me.panelja.Name = "panelja"
        Me.panelja.Size = New System.Drawing.Size(100, 80)
        Me.panelja.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 391)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnfold
        '
        Me.btnfold.Enabled = False
        Me.btnfold.Location = New System.Drawing.Point(815, 545)
        Me.btnfold.Name = "btnfold"
        Me.btnfold.Size = New System.Drawing.Size(89, 45)
        Me.btnfold.TabIndex = 13
        Me.btnfold.Text = "Fold"
        Me.btnfold.UseVisualStyleBackColor = True
        '
        'btncheck
        '
        Me.btncheck.Enabled = False
        Me.btncheck.Location = New System.Drawing.Point(720, 545)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(89, 45)
        Me.btncheck.TabIndex = 14
        Me.btncheck.Text = "Check"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'btnraise
        '
        Me.btnraise.Enabled = False
        Me.btnraise.Location = New System.Drawing.Point(910, 545)
        Me.btnraise.Name = "btnraise"
        Me.btnraise.Size = New System.Drawing.Size(89, 45)
        Me.btnraise.TabIndex = 15
        Me.btnraise.Text = "Raise"
        Me.btnraise.UseVisualStyleBackColor = True
        '
        'numsazka
        '
        Me.numsazka.Location = New System.Drawing.Point(910, 519)
        Me.numsazka.Name = "numsazka"
        Me.numsazka.Size = New System.Drawing.Size(89, 20)
        Me.numsazka.TabIndex = 16
        '
        'btnnovahra
        '
        Me.btnnovahra.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnnovahra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnovahra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnnovahra.Location = New System.Drawing.Point(12, 12)
        Me.btnnovahra.Name = "btnnovahra"
        Me.btnnovahra.Size = New System.Drawing.Size(107, 32)
        Me.btnnovahra.TabIndex = 17
        Me.btnnovahra.Text = "Nová hra"
        Me.btnnovahra.UseVisualStyleBackColor = False
        '
        'lblmojechips
        '
        Me.lblmojechips.AutoSize = True
        Me.lblmojechips.BackColor = System.Drawing.Color.Transparent
        Me.lblmojechips.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblmojechips.ForeColor = System.Drawing.SystemColors.Control
        Me.lblmojechips.Location = New System.Drawing.Point(631, 552)
        Me.lblmojechips.Name = "lblmojechips"
        Me.lblmojechips.Size = New System.Drawing.Size(0, 25)
        Me.lblmojechips.TabIndex = 18
        '
        'lblpot
        '
        Me.lblpot.AutoSize = True
        Me.lblpot.BackColor = System.Drawing.Color.Transparent
        Me.lblpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblpot.Location = New System.Drawing.Point(474, 235)
        Me.lblpot.Name = "lblpot"
        Me.lblpot.Size = New System.Drawing.Size(41, 20)
        Me.lblpot.TabIndex = 19
        Me.lblpot.Text = "Pot:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Poker.My.Resources.Resources.pozadi
        Me.ClientSize = New System.Drawing.Size(1008, 602)
        Me.Controls.Add(Me.lblpot)
        Me.Controls.Add(Me.lblmojechips)
        Me.Controls.Add(Me.btnnovahra)
        Me.Controls.Add(Me.numsazka)
        Me.Controls.Add(Me.btnraise)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.btnfold)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.panelja)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.panelflop)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Poker"
        CType(Me.numsazka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelflop As System.Windows.Forms.Panel
    Friend WithEvents Timerlogikahry As System.Windows.Forms.Timer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents panelja As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnfold As System.Windows.Forms.Button
    Friend WithEvents btncheck As System.Windows.Forms.Button
    Friend WithEvents btnraise As System.Windows.Forms.Button
    Friend WithEvents numsazka As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnnovahra As System.Windows.Forms.Button
    Friend WithEvents lblmojechips As System.Windows.Forms.Label
    Friend WithEvents lblpot As System.Windows.Forms.Label

End Class
