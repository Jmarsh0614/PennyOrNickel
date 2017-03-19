<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPennyOrNickel
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
        Me.grpPay = New System.Windows.Forms.GroupBox()
        Me.radNickel = New System.Windows.Forms.RadioButton()
        Me.radPenny = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuPayCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtWorkDays = New System.Windows.Forms.TextBox()
        Me.lblEntNumOfWrkDays = New System.Windows.Forms.Label()
        Me.lblTotalPayPerPeriod = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpPay.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Pay Calculator"
        '
        'grpPay
        '
        Me.grpPay.BackColor = System.Drawing.Color.Brown
        Me.grpPay.Controls.Add(Me.radNickel)
        Me.grpPay.Controls.Add(Me.radPenny)
        Me.grpPay.Location = New System.Drawing.Point(67, 70)
        Me.grpPay.Name = "grpPay"
        Me.grpPay.Size = New System.Drawing.Size(136, 71)
        Me.grpPay.TabIndex = 1
        Me.grpPay.TabStop = False
        '
        'radNickel
        '
        Me.radNickel.AutoSize = True
        Me.radNickel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNickel.Location = New System.Drawing.Point(7, 43)
        Me.radNickel.Name = "radNickel"
        Me.radNickel.Size = New System.Drawing.Size(129, 17)
        Me.radNickel.TabIndex = 1
        Me.radNickel.TabStop = True
        Me.radNickel.Text = "Nickel for first day"
        Me.radNickel.UseVisualStyleBackColor = True
        '
        'radPenny
        '
        Me.radPenny.AutoSize = True
        Me.radPenny.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPenny.Location = New System.Drawing.Point(7, 20)
        Me.radPenny.Name = "radPenny"
        Me.radPenny.Size = New System.Drawing.Size(128, 17)
        Me.radPenny.TabIndex = 0
        Me.radPenny.TabStop = True
        Me.radPenny.Text = "Penny for first day"
        Me.radPenny.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPayCalc})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(450, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuPayCalc
        '
        Me.mnuPayCalc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuPayCalc.Name = "mnuPayCalc"
        Me.mnuPayCalc.Size = New System.Drawing.Size(37, 20)
        Me.mnuPayCalc.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'txtWorkDays
        '
        Me.txtWorkDays.BackColor = System.Drawing.Color.Sienna
        Me.txtWorkDays.Location = New System.Drawing.Point(225, 113)
        Me.txtWorkDays.Name = "txtWorkDays"
        Me.txtWorkDays.Size = New System.Drawing.Size(39, 20)
        Me.txtWorkDays.TabIndex = 3
        '
        'lblEntNumOfWrkDays
        '
        Me.lblEntNumOfWrkDays.AutoSize = True
        Me.lblEntNumOfWrkDays.BackColor = System.Drawing.Color.IndianRed
        Me.lblEntNumOfWrkDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntNumOfWrkDays.Location = New System.Drawing.Point(222, 90)
        Me.lblEntNumOfWrkDays.Name = "lblEntNumOfWrkDays"
        Me.lblEntNumOfWrkDays.Size = New System.Drawing.Size(213, 18)
        Me.lblEntNumOfWrkDays.TabIndex = 4
        Me.lblEntNumOfWrkDays.Text = "Enter Number of Workdays"
        Me.lblEntNumOfWrkDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPayPerPeriod
        '
        Me.lblTotalPayPerPeriod.AutoSize = True
        Me.lblTotalPayPerPeriod.BackColor = System.Drawing.Color.Olive
        Me.lblTotalPayPerPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayPerPeriod.Location = New System.Drawing.Point(63, 202)
        Me.lblTotalPayPerPeriod.Name = "lblTotalPayPerPeriod"
        Me.lblTotalPayPerPeriod.Size = New System.Drawing.Size(303, 20)
        Me.lblTotalPayPerPeriod.TabIndex = 5
        Me.lblTotalPayPerPeriod.Text = "The pay for this period is: $XXXX.XX"
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.BackColor = System.Drawing.Color.Lime
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(167, 157)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(83, 26)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'frmPennyOrNickel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.PennyOrNickel.My.Resources.Resources.PennyNickel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 261)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalPayPerPeriod)
        Me.Controls.Add(Me.lblEntNumOfWrkDays)
        Me.Controls.Add(Me.txtWorkDays)
        Me.Controls.Add(Me.grpPay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPennyOrNickel"
        Me.Text = "                     Penny or Nickel a day - Pay Calc"
        Me.grpPay.ResumeLayout(False)
        Me.grpPay.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpPay As GroupBox
    Friend WithEvents radNickel As RadioButton
    Friend WithEvents radPenny As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuPayCalc As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents txtWorkDays As TextBox
    Friend WithEvents lblEntNumOfWrkDays As Label
    Friend WithEvents lblTotalPayPerPeriod As Label
    Friend WithEvents btnCalculate As Button
End Class
