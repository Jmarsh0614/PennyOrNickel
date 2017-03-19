'Program:       Employee Pay Calculator
'Author:        Joshua Marshall
'Date:          March 14th, 2017
'Purpose:       This program will allow employee to select their current pay and see how much their
'               their total pay for the period will be based on the amount of work days entered.




Option Strict On

Public Class frmPennyOrNickel
    Const _cdecPennyPay As Decimal = 0.01D
    Const _cdecNickelPay As Decimal = 0.05D
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strNumOfWorkDays As String = txtWorkDays.Text
        Dim intNumberOfWorkDays As Integer
        Dim intMaxNumOfWorkDays As Integer = 22
        Dim decTotalPayPerPeriod As Decimal = 0D

        If IsNumeric(strNumOfWorkDays) Then
            intNumberOfWorkDays = Convert.ToInt32(strNumOfWorkDays)
            If intNumberOfWorkDays > 18 And intNumberOfWorkDays < 23 Then
                If radPenny.Checked Then
                    While intNumberOfWorkDays > 18 And intNumberOfWorkDays < 23
                        decTotalPayPerPeriod += CDec(intNumberOfWorkDays * _cdecNickelPay) * 2
                        intNumberOfWorkDays += 1
                        lblTotalPayPerPeriod.Text = "The Total Pay for this period is: " & decTotalPayPerPeriod.ToString("C")
                    End While
                    btnCalculate.Enabled = False



                End If
            Else
                MsgBox("Number of workdays must be between 19 and 22")
            End If
        Else
            MsgBox("Please Enter in a valid number for number of workdays")
        End If




        If IsNumeric(strNumOfWorkDays) Then
            intNumberOfWorkDays = Convert.ToInt32(strNumOfWorkDays)
            If intNumberOfWorkDays > 15 And intNumberOfWorkDays < 23 Then
                If radNickel.Checked Then
                    While intNumberOfWorkDays > 15 And intNumberOfWorkDays < 23
                        decTotalPayPerPeriod += CDec(intNumberOfWorkDays * _cdecNickelPay) * 2
                        intNumberOfWorkDays += 1
                        lblTotalPayPerPeriod.Text = "The Total Pay for this period is: " & decTotalPayPerPeriod.ToString("C")
                    End While

                    btnCalculate.Enabled = False




                End If
            Else
                MsgBox("Number of workdays must be between 16 and 22")
            End If
        Else
            MsgBox("Please Enter in a valid number for number of workdays")
        End If




    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        radPenny.Focus()
        txtWorkDays.Text = ""
        lblTotalPayPerPeriod.Visible = False
        btnCalculate.Enabled = True

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

    Private Sub frmPennyOrNickel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        radPenny.Focus()
        txtWorkDays.Focus()
        lblTotalPayPerPeriod.Text = ""

    End Sub
End Class
