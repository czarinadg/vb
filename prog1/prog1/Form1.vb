Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles name_main.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String = name_main.Text
        Dim dept As String = dept_main.Text
        Dim working_hours As Double = Double.Parse(wh_main.Text)
        Dim regular_rate As Double = Double.Parse(rr_main.Text)
        Dim overtime As Double = Double.Parse(ot_main.Text)
        Dim overtime_rate As Double = Double.Parse(otrate_main.Text)

        Dim regular_salary As Double = working_hours * regular_rate
        Dim overtime_salary As Double = overtime * overtime_rate
        Dim gross_salary As Double = regular_salary + overtime_salary

        Dim sss_rate As Double = 0.1
        Dim philhealth_rate As Double = 0.035
        Dim pagibig_rate As Double = 0.02
        Dim income_tax_rate As Double = 0.2

        Dim sss_deduction As Double = gross_salary * sss_rate
        Dim philhealth_deduction As Double = gross_salary * philhealth_rate
        Dim pagibig_deduction As Double = gross_salary * pagibig_rate
        Dim income_tax_deduction As Double = gross_salary * income_tax_rate

        Dim total_deduction As Double = sss_deduction + philhealth_deduction + pagibig_deduction + income_tax_deduction

        name_op.Text = name
        depy_main.Text = dept
        wh_op.Text = working_hours.ToString()
        rr_op.Text = regular_rate.ToString()
        ot_op.Text = overtime.ToString()
        otrate_op.Text = overtime_rate.ToString()
        gross_op.Text = gross_salary.ToString()
        sss_op.Text = sss_deduction.ToString()
        ph_op.Text = philhealth_deduction.ToString()
        pi_op.Text = pagibig_deduction.ToString()
        it_op.Text = income_tax_deduction.ToString()
        td_op.Text = total_deduction.ToString()

        Dim net_pay As Double = gross_salary - total_deduction
        np_op.Text = net_pay.ToString()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        name_main.Text = ""
        dept_main.Text = ""
        wh_main.Text = ""
        rr_main.Text = ""
        ot_main.Text = ""
        otrate_main.Text = ""

        name_op.Text = ""
        depy_main.Text = ""
        wh_op.Text = ""
        rr_op.Text = ""
        ot_op.Text = ""
        otrate_op.Text = ""
        gross_op.Text = ""
        sss_op.Text = ""
        ph_op.Text = ""
        pi_op.Text = ""
        it_op.Text = ""
        td_op.Text = ""
        np_op.Text = ""
    End Sub
End Class
