<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnlineShopper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOnlineShopper))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbComputer = New System.Windows.Forms.GroupBox()
        Me.rbPC = New System.Windows.Forms.RadioButton()
        Me.rbLaptop = New System.Windows.Forms.RadioButton()
        Me.rbMacintosh = New System.Windows.Forms.RadioButton()
        Me.gbOffice = New System.Windows.Forms.GroupBox()
        Me.chMachine = New System.Windows.Forms.CheckBox()
        Me.chCalculator = New System.Windows.Forms.CheckBox()
        Me.chCopyMachine = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbPeripherals = New System.Windows.Forms.ListBox()
        Me.cbPayMethod = New System.Windows.Forms.ComboBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbCalculator = New System.Windows.Forms.PictureBox()
        Me.pbPhone = New System.Windows.Forms.PictureBox()
        Me.pbTelecom = New System.Windows.Forms.PictureBox()
        Me.pbComputer = New System.Windows.Forms.PictureBox()
        Me.PbMoney = New System.Windows.Forms.PictureBox()
        Me.pbPeripherals = New System.Windows.Forms.PictureBox()
        Me.gbComputer.SuspendLayout()
        Me.gbOffice.SuspendLayout()
        CType(Me.pbCalculator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTelecom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPeripherals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The Online Shopper"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Cascadia Code", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(519, 44)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Outfit your office now by choosing the office products you need using radio butto" &
    "ns, check boxes, a list box, and a combo box."
        '
        'gbComputer
        '
        Me.gbComputer.Controls.Add(Me.rbLaptop)
        Me.gbComputer.Controls.Add(Me.rbMacintosh)
        Me.gbComputer.Controls.Add(Me.rbPC)
        Me.gbComputer.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbComputer.Location = New System.Drawing.Point(17, 113)
        Me.gbComputer.Name = "gbComputer"
        Me.gbComputer.Size = New System.Drawing.Size(200, 100)
        Me.gbComputer.TabIndex = 2
        Me.gbComputer.TabStop = False
        Me.gbComputer.Text = "Computer (Required)"
        '
        'rbPC
        '
        Me.rbPC.AutoSize = True
        Me.rbPC.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPC.Location = New System.Drawing.Point(6, 22)
        Me.rbPC.Name = "rbPC"
        Me.rbPC.Size = New System.Drawing.Size(37, 19)
        Me.rbPC.TabIndex = 3
        Me.rbPC.TabStop = True
        Me.rbPC.Text = "PC"
        Me.rbPC.UseVisualStyleBackColor = True
        '
        'rbLaptop
        '
        Me.rbLaptop.AutoSize = True
        Me.rbLaptop.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLaptop.Location = New System.Drawing.Point(6, 72)
        Me.rbLaptop.Name = "rbLaptop"
        Me.rbLaptop.Size = New System.Drawing.Size(61, 19)
        Me.rbLaptop.TabIndex = 4
        Me.rbLaptop.TabStop = True
        Me.rbLaptop.Text = "Laptop"
        Me.rbLaptop.UseVisualStyleBackColor = True
        '
        'rbMacintosh
        '
        Me.rbMacintosh.AutoSize = True
        Me.rbMacintosh.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMacintosh.Location = New System.Drawing.Point(6, 47)
        Me.rbMacintosh.Name = "rbMacintosh"
        Me.rbMacintosh.Size = New System.Drawing.Size(79, 19)
        Me.rbMacintosh.TabIndex = 5
        Me.rbMacintosh.TabStop = True
        Me.rbMacintosh.Text = "Macintosh"
        Me.rbMacintosh.UseVisualStyleBackColor = True
        '
        'gbOffice
        '
        Me.gbOffice.Controls.Add(Me.chCopyMachine)
        Me.gbOffice.Controls.Add(Me.chMachine)
        Me.gbOffice.Controls.Add(Me.chCalculator)
        Me.gbOffice.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOffice.Location = New System.Drawing.Point(17, 230)
        Me.gbOffice.Name = "gbOffice"
        Me.gbOffice.Size = New System.Drawing.Size(200, 119)
        Me.gbOffice.TabIndex = 3
        Me.gbOffice.TabStop = False
        Me.gbOffice.Text = "Office Equipment (0-3)"
        '
        'chMachine
        '
        Me.chMachine.AutoSize = True
        Me.chMachine.Location = New System.Drawing.Point(6, 22)
        Me.chMachine.Name = "chMachine"
        Me.chMachine.Size = New System.Drawing.Size(163, 21)
        Me.chMachine.TabIndex = 0
        Me.chMachine.Text = "Answering Machine"
        Me.chMachine.UseVisualStyleBackColor = True
        '
        'chCalculator
        '
        Me.chCalculator.AutoSize = True
        Me.chCalculator.Location = New System.Drawing.Point(6, 49)
        Me.chCalculator.Name = "chCalculator"
        Me.chCalculator.Size = New System.Drawing.Size(107, 21)
        Me.chCalculator.TabIndex = 4
        Me.chCalculator.Text = "Calculator"
        Me.chCalculator.UseVisualStyleBackColor = True
        '
        'chCopyMachine
        '
        Me.chCopyMachine.AutoSize = True
        Me.chCopyMachine.Location = New System.Drawing.Point(6, 77)
        Me.chCopyMachine.Name = "chCopyMachine"
        Me.chCopyMachine.Size = New System.Drawing.Size(123, 21)
        Me.chCopyMachine.TabIndex = 5
        Me.chCopyMachine.Text = "Copy Machine"
        Me.chCopyMachine.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(266, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Peripherals (one only)"
        '
        'lbPeripherals
        '
        Me.lbPeripherals.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbPeripherals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPeripherals.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPeripherals.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbPeripherals.FormattingEnabled = True
        Me.lbPeripherals.ItemHeight = 21
        Me.lbPeripherals.Location = New System.Drawing.Point(269, 135)
        Me.lbPeripherals.Name = "lbPeripherals"
        Me.lbPeripherals.Size = New System.Drawing.Size(264, 107)
        Me.lbPeripherals.TabIndex = 5
        '
        'cbPayMethod
        '
        Me.cbPayMethod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbPayMethod.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPayMethod.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cbPayMethod.FormattingEnabled = True
        Me.cbPayMethod.Location = New System.Drawing.Point(269, 263)
        Me.cbPayMethod.Name = "cbPayMethod"
        Me.cbPayMethod.Size = New System.Drawing.Size(264, 29)
        Me.cbPayMethod.TabIndex = 6
        Me.cbPayMethod.Text = "Payment Method"
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnQuit.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.Yellow
        Me.btnQuit.Location = New System.Drawing.Point(318, 316)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(169, 33)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(554, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 40)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Products Ordered"
        '
        'pbCalculator
        '
        Me.pbCalculator.Location = New System.Drawing.Point(554, 113)
        Me.pbCalculator.Name = "pbCalculator"
        Me.pbCalculator.Size = New System.Drawing.Size(100, 91)
        Me.pbCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCalculator.TabIndex = 9
        Me.pbCalculator.TabStop = False
        '
        'pbPhone
        '
        Me.pbPhone.Location = New System.Drawing.Point(660, 113)
        Me.pbPhone.Name = "pbPhone"
        Me.pbPhone.Size = New System.Drawing.Size(100, 91)
        Me.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPhone.TabIndex = 10
        Me.pbPhone.TabStop = False
        '
        'pbTelecom
        '
        Me.pbTelecom.Location = New System.Drawing.Point(554, 210)
        Me.pbTelecom.Name = "pbTelecom"
        Me.pbTelecom.Size = New System.Drawing.Size(100, 91)
        Me.pbTelecom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTelecom.TabIndex = 11
        Me.pbTelecom.TabStop = False
        '
        'pbComputer
        '
        Me.pbComputer.Location = New System.Drawing.Point(660, 210)
        Me.pbComputer.Name = "pbComputer"
        Me.pbComputer.Size = New System.Drawing.Size(100, 91)
        Me.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbComputer.TabIndex = 12
        Me.pbComputer.TabStop = False
        '
        'PbMoney
        '
        Me.PbMoney.Location = New System.Drawing.Point(554, 307)
        Me.PbMoney.Name = "PbMoney"
        Me.PbMoney.Size = New System.Drawing.Size(100, 91)
        Me.PbMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbMoney.TabIndex = 13
        Me.PbMoney.TabStop = False
        '
        'pbPeripherals
        '
        Me.pbPeripherals.Location = New System.Drawing.Point(660, 307)
        Me.pbPeripherals.Name = "pbPeripherals"
        Me.pbPeripherals.Size = New System.Drawing.Size(100, 91)
        Me.pbPeripherals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPeripherals.TabIndex = 14
        Me.pbPeripherals.TabStop = False
        '
        'frmOnlineShopper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(772, 417)
        Me.Controls.Add(Me.pbPeripherals)
        Me.Controls.Add(Me.PbMoney)
        Me.Controls.Add(Me.pbComputer)
        Me.Controls.Add(Me.pbTelecom)
        Me.Controls.Add(Me.pbPhone)
        Me.Controls.Add(Me.pbCalculator)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.cbPayMethod)
        Me.Controls.Add(Me.lbPeripherals)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbOffice)
        Me.Controls.Add(Me.gbComputer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOnlineShopper"
        Me.Text = "Online Shopper"
        Me.gbComputer.ResumeLayout(False)
        Me.gbComputer.PerformLayout()
        Me.gbOffice.ResumeLayout(False)
        Me.gbOffice.PerformLayout()
        CType(Me.pbCalculator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTelecom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPeripherals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbComputer As GroupBox
    Friend WithEvents rbPC As RadioButton
    Friend WithEvents rbLaptop As RadioButton
    Friend WithEvents rbMacintosh As RadioButton
    Friend WithEvents gbOffice As GroupBox
    Friend WithEvents chMachine As CheckBox
    Friend WithEvents chCopyMachine As CheckBox
    Friend WithEvents chCalculator As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbPeripherals As ListBox
    Friend WithEvents cbPayMethod As ComboBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents pbCalculator As PictureBox
    Friend WithEvents pbPhone As PictureBox
    Friend WithEvents pbTelecom As PictureBox
    Friend WithEvents pbComputer As PictureBox
    Friend WithEvents PbMoney As PictureBox
    Friend WithEvents pbPeripherals As PictureBox
End Class
