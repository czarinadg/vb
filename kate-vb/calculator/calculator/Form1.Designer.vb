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
        Me.calcu_main = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_c = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.btn_num7 = New System.Windows.Forms.Button()
        Me.btn_num8 = New System.Windows.Forms.Button()
        Me.btn_num9 = New System.Windows.Forms.Button()
        Me.btn_divide = New System.Windows.Forms.Button()
        Me.btn_num4 = New System.Windows.Forms.Button()
        Me.btn_num5 = New System.Windows.Forms.Button()
        Me.btn_num6 = New System.Windows.Forms.Button()
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.btn_num1 = New System.Windows.Forms.Button()
        Me.btn_num2 = New System.Windows.Forms.Button()
        Me.btn_num3 = New System.Windows.Forms.Button()
        Me.btn_multiply = New System.Windows.Forms.Button()
        Me.btn_decimal = New System.Windows.Forms.Button()
        Me.btn_equals = New System.Windows.Forms.Button()
        Me.btn_num0 = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'calcu_main
        '
        Me.calcu_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcu_main.Location = New System.Drawing.Point(21, 35)
        Me.calcu_main.Name = "calcu_main"
        Me.calcu_main.Size = New System.Drawing.Size(447, 98)
        Me.calcu_main.TabIndex = 0
        Me.calcu_main.Text = "0"
        Me.calcu_main.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(21, 162)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(106, 100)
        Me.btn_back.TabIndex = 1
        Me.btn_back.Text = "←"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_c
        '
        Me.btn_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_c.Location = New System.Drawing.Point(133, 162)
        Me.btn_c.Name = "btn_c"
        Me.btn_c.Size = New System.Drawing.Size(106, 100)
        Me.btn_c.TabIndex = 2
        Me.btn_c.Text = "C"
        Me.btn_c.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod.Location = New System.Drawing.Point(245, 162)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(106, 100)
        Me.btn_mod.TabIndex = 3
        Me.btn_mod.Text = "mod"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_up
        '
        Me.btn_up.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_up.Location = New System.Drawing.Point(133, 594)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(106, 100)
        Me.btn_up.TabIndex = 4
        Me.btn_up.Text = "^"
        Me.btn_up.UseVisualStyleBackColor = True
        '
        'btn_num7
        '
        Me.btn_num7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_num7.Location = New System.Drawing.Point(21, 268)
        Me.btn_num7.Name = "btn_num7"
        Me.btn_num7.Size = New System.Drawing.Size(106, 100)
        Me.btn_num7.TabIndex = 5
        Me.btn_num7.Text = "7"
        Me.btn_num7.UseVisualStyleBackColor = True
        '
        'btn_num8
        '
        Me.btn_num8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_num8.Location = New System.Drawing.Point(133, 268)
        Me.btn_num8.Name = "btn_num8"
        Me.btn_num8.Size = New System.Drawing.Size(106, 100)
        Me.btn_num8.TabIndex = 6
        Me.btn_num8.Text = "8"
        Me.btn_num8.UseVisualStyleBackColor = True
        '
        'btn_num9
        '
        Me.btn_num9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_num9.Location = New System.Drawing.Point(245, 268)
        Me.btn_num9.Name = "btn_num9"
        Me.btn_num9.Size = New System.Drawing.Size(106, 100)
        Me.btn_num9.TabIndex = 7
        Me.btn_num9.Text = "9"
        Me.btn_num9.UseVisualStyleBackColor = True
        '
        'btn_divide
        '
        Me.btn_divide.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_divide.Location = New System.Drawing.Point(357, 480)
        Me.btn_divide.Name = "btn_divide"
        Me.btn_divide.Size = New System.Drawing.Size(106, 100)
        Me.btn_divide.TabIndex = 8
        Me.btn_divide.Text = "/"
        Me.btn_divide.UseVisualStyleBackColor = True
        '
        'btn_num4
        '
        Me.btn_num4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_num4.Location = New System.Drawing.Point(21, 374)
        Me.btn_num4.Name = "btn_num4"
        Me.btn_num4.Size = New System.Drawing.Size(106, 100)
        Me.btn_num4.TabIndex = 9
        Me.btn_num4.Text = "4"
        Me.btn_num4.UseVisualStyleBackColor = True
        '
        'btn_num5
        '
        Me.btn_num5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_num5.Location = New System.Drawing.Point(133, 374)
        Me.btn_num5.Name = "btn_num5"
        Me.btn_num5.Size = New System.Drawing.Size(106, 100)
        Me.btn_num5.TabIndex = 10
        Me.btn_num5.Text = "5"
        Me.btn_num5.UseVisualStyleBackColor = True
        '
        'btn_num6
        '
        Me.btn_num6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_num6.Location = New System.Drawing.Point(245, 374)
        Me.btn_num6.Name = "btn_num6"
        Me.btn_num6.Size = New System.Drawing.Size(106, 100)
        Me.btn_num6.TabIndex = 11
        Me.btn_num6.Text = "6"
        Me.btn_num6.UseVisualStyleBackColor = True
        '
        'btn_minus
        '
        Me.btn_minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minus.Location = New System.Drawing.Point(357, 268)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(106, 100)
        Me.btn_minus.TabIndex = 12
        Me.btn_minus.Text = "-"
        Me.btn_minus.UseVisualStyleBackColor = True
        '
        'btn_num1
        '
        Me.btn_num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_num1.Location = New System.Drawing.Point(21, 480)
        Me.btn_num1.Name = "btn_num1"
        Me.btn_num1.Size = New System.Drawing.Size(106, 100)
        Me.btn_num1.TabIndex = 13
        Me.btn_num1.Text = "1"
        Me.btn_num1.UseVisualStyleBackColor = True
        '
        'btn_num2
        '
        Me.btn_num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_num2.Location = New System.Drawing.Point(133, 480)
        Me.btn_num2.Name = "btn_num2"
        Me.btn_num2.Size = New System.Drawing.Size(106, 100)
        Me.btn_num2.TabIndex = 14
        Me.btn_num2.Text = "2"
        Me.btn_num2.UseVisualStyleBackColor = True
        '
        'btn_num3
        '
        Me.btn_num3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_num3.Location = New System.Drawing.Point(245, 480)
        Me.btn_num3.Name = "btn_num3"
        Me.btn_num3.Size = New System.Drawing.Size(106, 100)
        Me.btn_num3.TabIndex = 15
        Me.btn_num3.Text = "3"
        Me.btn_num3.UseVisualStyleBackColor = True
        '
        'btn_multiply
        '
        Me.btn_multiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiply.Location = New System.Drawing.Point(357, 374)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(106, 100)
        Me.btn_multiply.TabIndex = 16
        Me.btn_multiply.Text = "x"
        Me.btn_multiply.UseVisualStyleBackColor = True
        '
        'btn_decimal
        '
        Me.btn_decimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_decimal.Location = New System.Drawing.Point(245, 594)
        Me.btn_decimal.Name = "btn_decimal"
        Me.btn_decimal.Size = New System.Drawing.Size(106, 100)
        Me.btn_decimal.TabIndex = 17
        Me.btn_decimal.Text = "."
        Me.btn_decimal.UseVisualStyleBackColor = True
        '
        'btn_equals
        '
        Me.btn_equals.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_equals.Location = New System.Drawing.Point(357, 594)
        Me.btn_equals.Name = "btn_equals"
        Me.btn_equals.Size = New System.Drawing.Size(106, 100)
        Me.btn_equals.TabIndex = 18
        Me.btn_equals.Text = "="
        Me.btn_equals.UseVisualStyleBackColor = True
        '
        'btn_num0
        '
        Me.btn_num0.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_num0.Location = New System.Drawing.Point(21, 594)
        Me.btn_num0.Name = "btn_num0"
        Me.btn_num0.Size = New System.Drawing.Size(106, 100)
        Me.btn_num0.TabIndex = 19
        Me.btn_num0.Text = "0"
        Me.btn_num0.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(357, 162)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(106, 100)
        Me.btn_add.TabIndex = 20
        Me.btn_add.Text = "+"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 706)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_num0)
        Me.Controls.Add(Me.btn_equals)
        Me.Controls.Add(Me.btn_decimal)
        Me.Controls.Add(Me.btn_multiply)
        Me.Controls.Add(Me.btn_num3)
        Me.Controls.Add(Me.btn_num2)
        Me.Controls.Add(Me.btn_num1)
        Me.Controls.Add(Me.btn_minus)
        Me.Controls.Add(Me.btn_num6)
        Me.Controls.Add(Me.btn_num5)
        Me.Controls.Add(Me.btn_num4)
        Me.Controls.Add(Me.btn_divide)
        Me.Controls.Add(Me.btn_num9)
        Me.Controls.Add(Me.btn_num8)
        Me.Controls.Add(Me.btn_num7)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.btn_mod)
        Me.Controls.Add(Me.btn_c)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.calcu_main)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcu_main As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_c As Button
    Friend WithEvents btn_mod As Button
    Friend WithEvents btn_up As Button
    Friend WithEvents btn_num7 As Button
    Friend WithEvents btn_num8 As Button
    Friend WithEvents btn_num9 As Button
    Friend WithEvents btn_divide As Button
    Friend WithEvents btn_num4 As Button
    Friend WithEvents btn_num5 As Button
    Friend WithEvents btn_num6 As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_num1 As Button
    Friend WithEvents btn_num2 As Button
    Friend WithEvents btn_num3 As Button
    Friend WithEvents btn_multiply As Button
    Friend WithEvents btn_decimal As Button
    Friend WithEvents btn_equals As Button
    Friend WithEvents btn_num0 As Button
    Friend WithEvents btn_add As Button
End Class
