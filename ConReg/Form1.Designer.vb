<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCon
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
        Me.gboxBadge = New System.Windows.Forms.GroupBox()
        Me.rbtnCon = New System.Windows.Forms.RadioButton()
        Me.rbtnAutograph = New System.Windows.Forms.RadioButton()
        Me.rbtnSuper = New System.Windows.Forms.RadioButton()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.gboxBadge.SuspendLayout()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboxBadge
        '
        Me.gboxBadge.BackColor = System.Drawing.Color.LightBlue
        Me.gboxBadge.Controls.Add(Me.rbtnCon)
        Me.gboxBadge.Controls.Add(Me.rbtnAutograph)
        Me.gboxBadge.Controls.Add(Me.rbtnSuper)
        Me.gboxBadge.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxBadge.ForeColor = System.Drawing.Color.Red
        Me.gboxBadge.Location = New System.Drawing.Point(72, 207)
        Me.gboxBadge.Name = "gboxBadge"
        Me.gboxBadge.Size = New System.Drawing.Size(375, 100)
        Me.gboxBadge.TabIndex = 0
        Me.gboxBadge.TabStop = False
        Me.gboxBadge.Text = "Select Badge Type"
        '
        'rbtnCon
        '
        Me.rbtnCon.AutoSize = True
        Me.rbtnCon.Location = New System.Drawing.Point(10, 76)
        Me.rbtnCon.Name = "rbtnCon"
        Me.rbtnCon.Size = New System.Drawing.Size(107, 19)
        Me.rbtnCon.TabIndex = 2
        Me.rbtnCon.TabStop = True
        Me.rbtnCon.Text = "Convention"
        Me.rbtnCon.UseVisualStyleBackColor = True
        '
        'rbtnAutograph
        '
        Me.rbtnAutograph.AutoSize = True
        Me.rbtnAutograph.Location = New System.Drawing.Point(10, 48)
        Me.rbtnAutograph.Name = "rbtnAutograph"
        Me.rbtnAutograph.Size = New System.Drawing.Size(200, 19)
        Me.rbtnAutograph.TabIndex = 1
        Me.rbtnAutograph.TabStop = True
        Me.rbtnAutograph.Text = "Convention +Autographs"
        Me.rbtnAutograph.UseVisualStyleBackColor = True
        '
        'rbtnSuper
        '
        Me.rbtnSuper.AutoSize = True
        Me.rbtnSuper.Location = New System.Drawing.Point(10, 20)
        Me.rbtnSuper.Name = "rbtnSuper"
        Me.rbtnSuper.Size = New System.Drawing.Size(279, 19)
        Me.rbtnSuper.TabIndex = 0
        Me.rbtnSuper.TabStop = True
        Me.rbtnSuper.Text = "Convention + Superhero Experience"
        Me.rbtnSuper.UseVisualStyleBackColor = True
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.ForeColor = System.Drawing.Color.Red
        Me.lblSize.Location = New System.Drawing.Point(137, 167)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(101, 23)
        Me.lblSize.TabIndex = 1
        Me.lblSize.Text = "Group Size:"
        '
        'txtSize
        '
        Me.txtSize.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.ForeColor = System.Drawing.Color.Red
        Me.txtSize.Location = New System.Drawing.Point(274, 164)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(72, 30)
        Me.txtSize.TabIndex = 2
        Me.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg.ForeColor = System.Drawing.Color.Red
        Me.lblReg.Location = New System.Drawing.Point(75, 346)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(151, 23)
        Me.lblReg.TabIndex = 3
        Me.lblReg.Text = "Registration Cost:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Red
        Me.lblCost.Location = New System.Drawing.Point(329, 346)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(61, 23)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Label3"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(63, 395)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(164, 42)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(274, 395)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(164, 42)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.ForeColor = System.Drawing.Color.Red
        Me.lblRegistration.Location = New System.Drawing.Point(12, 82)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(484, 45)
        Me.lblRegistration.TabIndex = 7
        Me.lblRegistration.Text = "Comic Convention Registration"
        '
        'picComic
        '
        Me.picComic.Image = Global.ConReg.My.Resources.Resources.comic
        Me.picComic.Location = New System.Drawing.Point(0, -1)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(502, 80)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 8
        Me.picComic.TabStop = False
        '
        'FrmCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 450)
        Me.Controls.Add(Me.picComic)
        Me.Controls.Add(Me.lblRegistration)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.gboxBadge)
        Me.Name = "FrmCon"
        Me.Text = "Comic Convention Registration"
        Me.gboxBadge.ResumeLayout(False)
        Me.gboxBadge.PerformLayout()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gboxBadge As GroupBox
    Friend WithEvents rbtnCon As RadioButton
    Friend WithEvents rbtnAutograph As RadioButton
    Friend WithEvents rbtnSuper As RadioButton
    Friend WithEvents lblSize As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblReg As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblRegistration As Label
    Friend WithEvents picComic As PictureBox
End Class
