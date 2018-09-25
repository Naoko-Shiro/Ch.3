<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblHello = New System.Windows.Forms.Label()
        Me.rdbFrench = New System.Windows.Forms.RadioButton()
        Me.rdbSpanish = New System.Windows.Forms.RadioButton()
        Me.rdbRussian = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.nudAge = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Location = New System.Drawing.Point(29, 44)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(31, 13)
        Me.lblHello.TabIndex = 0
        Me.lblHello.Text = "Hello"
        '
        'rdbFrench
        '
        Me.rdbFrench.AutoSize = True
        Me.rdbFrench.Location = New System.Drawing.Point(40, 155)
        Me.rdbFrench.Name = "rdbFrench"
        Me.rdbFrench.Size = New System.Drawing.Size(58, 17)
        Me.rdbFrench.TabIndex = 1
        Me.rdbFrench.TabStop = True
        Me.rdbFrench.Text = "French"
        Me.rdbFrench.UseVisualStyleBackColor = True
        '
        'rdbSpanish
        '
        Me.rdbSpanish.AutoSize = True
        Me.rdbSpanish.Location = New System.Drawing.Point(40, 180)
        Me.rdbSpanish.Name = "rdbSpanish"
        Me.rdbSpanish.Size = New System.Drawing.Size(63, 17)
        Me.rdbSpanish.TabIndex = 2
        Me.rdbSpanish.TabStop = True
        Me.rdbSpanish.Text = "Spanish"
        Me.rdbSpanish.UseVisualStyleBackColor = True
        '
        'rdbRussian
        '
        Me.rdbRussian.AutoSize = True
        Me.rdbRussian.Location = New System.Drawing.Point(40, 204)
        Me.rdbRussian.Name = "rdbRussian"
        Me.rdbRussian.Size = New System.Drawing.Size(63, 17)
        Me.rdbRussian.TabIndex = 3
        Me.rdbRussian.TabStop = True
        Me.rdbRussian.Text = "Russian"
        Me.rdbRussian.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(140, 57)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(126, 20)
        Me.txtName.TabIndex = 4
        '
        'nudAge
        '
        Me.nudAge.Location = New System.Drawing.Point(140, 83)
        Me.nudAge.Name = "nudAge"
        Me.nudAge.Size = New System.Drawing.Size(126, 20)
        Me.nudAge.TabIndex = 5
        Me.nudAge.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Age"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Broadway Copyist Text", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button2.Location = New System.Drawing.Point(154, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 47)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.rdbRussian)
        Me.Controls.Add(Me.rdbSpanish)
        Me.Controls.Add(Me.rdbFrench)
        Me.Controls.Add(Me.lblHello)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHello As System.Windows.Forms.Label
    Friend WithEvents rdbFrench As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSpanish As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRussian As System.Windows.Forms.RadioButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents nudAge As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
