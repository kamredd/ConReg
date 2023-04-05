Public Class FrmCon
    Private Sub FrmCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSize.Text = ""
        txtSize.Focus()
        lblCost.Text = ""
        rbtnCon.Checked = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSize.Text = ""
        txtSize.Focus()
        lblCost.Text = ""
        rbtnCon.Checked = True
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intCon As Integer = 209
        Dim intAuto As Integer = 275
        Dim intSuper As Integer = 380
        Dim intFinalCost As Integer
        Dim intSize As Integer

        If IsNumeric(txtSize.Text) Then
            intSize = Convert.ToInt32(txtSize.Text)
            ''if the group size is less than one or more than 20
            If intSize > 0 Then
                If intSize < 20 Then
                    If rbtnSuper.Checked = True Then
                        intFinalCost = intSize * intSuper
                        lblCost.Text = intFinalCost.ToString("C")
                    ElseIf rbtnAutograph.Checked = True Then
                        intFinalCost = intSize * intAuto
                        lblCost.Text = intFinalCost.ToString("C")
                    Else
                        intFinalCost = intSize * intCon
                        lblCost.Text = intFinalCost.ToString("C")
                    End If
                Else
                        MsgBox("Group size must be less than 20! Please try again", 5, "Group Size Error")
                    txtSize.Text = ""
                    txtSize.Focus()
                End If

            Else
                MsgBox("Group size must be greater than 0! Please try again", 5, "Group Size Error")
                txtSize.Text = ""
                txtSize.Focus()
            End If

        Else
            MsgBox("Please enter a numeric value.", 5, "Input Error")
            txtSize.Text = ""
            txtSize.Focus()
        End If



    End Sub
End Class
