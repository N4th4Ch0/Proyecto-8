<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDividendo = New System.Windows.Forms.Label()
        Me.lblDivisor = New System.Windows.Forms.Label()
        Me.txtDividendo = New System.Windows.Forms.TextBox()
        Me.txtDivisor = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.cmdResultado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(60, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Division "
        '
        'lblDividendo
        '
        Me.lblDividendo.AutoSize = True
        Me.lblDividendo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDividendo.Location = New System.Drawing.Point(37, 76)
        Me.lblDividendo.Name = "lblDividendo"
        Me.lblDividendo.Size = New System.Drawing.Size(72, 17)
        Me.lblDividendo.TabIndex = 1
        Me.lblDividendo.Text = "Dividendo"
        '
        'lblDivisor
        '
        Me.lblDivisor.AutoSize = True
        Me.lblDivisor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDivisor.Location = New System.Drawing.Point(37, 109)
        Me.lblDivisor.Name = "lblDivisor"
        Me.lblDivisor.Size = New System.Drawing.Size(52, 17)
        Me.lblDivisor.TabIndex = 2
        Me.lblDivisor.Text = "Divisor"
        '
        'txtDividendo
        '
        Me.txtDividendo.Location = New System.Drawing.Point(124, 75)
        Me.txtDividendo.Name = "txtDividendo"
        Me.txtDividendo.Size = New System.Drawing.Size(100, 23)
        Me.txtDividendo.TabIndex = 3
        '
        'txtDivisor
        '
        Me.txtDivisor.Location = New System.Drawing.Point(124, 109)
        Me.txtDivisor.Name = "txtDivisor"
        Me.txtDivisor.Size = New System.Drawing.Size(100, 23)
        Me.txtDivisor.TabIndex = 4
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblResultado.Location = New System.Drawing.Point(109, 191)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 17)
        Me.lblResultado.TabIndex = 5
        '
        'cmdResultado
        '
        Me.cmdResultado.Location = New System.Drawing.Point(135, 138)
        Me.cmdResultado.Name = "cmdResultado"
        Me.cmdResultado.Size = New System.Drawing.Size(75, 23)
        Me.cmdResultado.TabIndex = 6
        Me.cmdResultado.Text = "Calcular"
        Me.cmdResultado.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 347)
        Me.Controls.Add(Me.cmdResultado)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txtDivisor)
        Me.Controls.Add(Me.txtDividendo)
        Me.Controls.Add(Me.lblDivisor)
        Me.Controls.Add(Me.lblDividendo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDividendo As Label
    Friend WithEvents lblDivisor As Label
    Friend WithEvents txtDividendo As TextBox
    Friend WithEvents txtDivisor As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents cmdResultado As Button
End Class
