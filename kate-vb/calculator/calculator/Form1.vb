Public Class Form1

    Dim Firstnum As Decimal
    Dim Secondnum As Decimal
    Dim Operations As Integer
    Dim Operator_Selector As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_c.Click
        calcu_main.Text = "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        Firstnum = calcu_main.Text
        calcu_main.Text = "0"
        Operator_Selector = True
        Operations = 5
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim currentText As String = calcu_main.Text
        If currentText.Length <= 1 Then
            calcu_main.Text = "0"
        Else
            calcu_main.Text = currentText.Substring(0, currentText.Length - 1)
        End If
    End Sub

    Private Sub calcu_main_TextChanged(sender As Object, e As EventArgs) Handles calcu_main.TextChanged

    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        If Decimal.TryParse(calcu_main.Text, Secondnum) Then
            Dim result As Decimal = Firstnum Mod Secondnum
            calcu_main.Text = result.ToString()
            Operator_Selector = True
        End If
    End Sub

    Private Sub btn_num7_Click(sender As Object, e As EventArgs) Handles btn_num7.Click
        If calcu_main.Text <> "0" Then
            calcu_main.Text += "7"
        Else
            calcu_main.Text = "7"
        End If
    End Sub

    Private Sub btn_num8_Click(sender As Object, e As EventArgs) Handles btn_num8.Click
        If calcu_main.Text <> "0" Then
            calcu_main.Text += "8"
        Else
            calcu_main.Text = "8"
        End If
    End Sub

    Private Sub btn_num9_Click(sender As Object, e As EventArgs) Handles btn_num9.Click
        If calcu_main.Text <> "0" Then
            calcu_main.Text += "9"
        Else
            calcu_main.Text = "9"
        End If
    End Sub

    Private Sub btn_divide_Click(sender As Object, e As EventArgs) Handles btn_divide.Click
        Firstnum = calcu_main.Text
        calcu_main.Text = "0"
        Operator_Selector = True
        Operations = 4 ' /
    End Sub

    Private Sub btn_num1_Click(sender As Object, e As EventArgs) Handles btn_num1.Click
        If calcu_main.Text <> "0" Then
            calcu_main.Text += "1"
        Else
            calcu_main.Text = "1"
        End If
    End Sub

    Private Sub btn_num2_Click(sender As Object, e As EventArgs) Handles btn_num2.Click
        If calcu_main.Text <> "0" Then
            calcu_main.Text += "2"
        Else
            calcu_main.Text = "2"
        End If
    End Sub

    Private Sub btn_num3_Click(sender As Object, e As EventArgs) Handles btn_num3.Click
        If calcu_main.Text <> "0" Then
            calcu_main.Text += "3"
        Else
            calcu_main.Text = "3"
        End If
    End Sub

    Private Sub btn_num4_Click(sender As Object, e As EventArgs) Handles btn_num4.Click
        If calcu_main.Text <> "0" Then
            calcu_main.Text += "4"
        Else
            calcu_main.Text = "4"
        End If
    End Sub

    Private Sub btn_num5_Click(sender As Object, e As EventArgs) Handles btn_num5.Click
        If calcu_main.Text <> "0" Then
            calcu_main.Text += "5"
        Else
            calcu_main.Text = "5"
        End If
    End Sub

    Private Sub btn_num6_Click(sender As Object, e As EventArgs) Handles btn_num6.Click
        If calcu_main.Text <> "0" Then
            calcu_main.Text += "6"
        Else
            calcu_main.Text = "6"
        End If
    End Sub

    Private Sub btn_num0_Click(sender As Object, e As EventArgs) Handles btn_num0.Click
        If calcu_main.Text <> "0" Then
            calcu_main.Text += "0"
        End If
    End Sub

    Private Sub btn_decimal_Click(sender As Object, e As EventArgs) Handles btn_decimal.Click
        If Not (calcu_main.Text.Contains(".")) Then
            calcu_main.Text += "."
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Firstnum = calcu_main.Text
        calcu_main.Text = "0"
        Operator_Selector = True
        Operations = 1 ' = +
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        Firstnum = calcu_main.Text
        calcu_main.Text = "0"
        Operator_Selector = True
        Operations = 2 ' = -
    End Sub

    Private Sub btn_multiply_Click(sender As Object, e As EventArgs) Handles btn_multiply.Click
        Firstnum = calcu_main.Text
        calcu_main.Text = "0"
        Operator_Selector = True
        Operations = 3 ' = *
    End Sub

    Private Sub btn_equals_Click(sender As Object, e As EventArgs) Handles btn_equals.Click
        If Operator_Selector = True Then
            Secondnum = calcu_main.Text
            If Operations = 1 Then
                calcu_main.Text = Firstnum + Secondnum
            ElseIf Operations = 2 Then
                calcu_main.Text = Firstnum - Secondnum
            ElseIf Operations = 3 Then
                calcu_main.Text = Firstnum * Secondnum
            ElseIf Operations = 4 Then
                If Secondnum = 0 Then
                    calcu_main.Text = "Error!"
                Else
                    calcu_main.Text = Firstnum / Secondnum
                End If
            ElseIf Operations = 5 Then
                calcu_main.Text = Math.Pow(Firstnum, Secondnum).ToString()
            End If
            Operator_Selector = False
        End If
    End Sub
End Class
