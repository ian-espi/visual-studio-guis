Public Class frmGrade
    Dim _decAveragedGrade As Decimal
    Dim _decAverage As Decimal
    Dim _strInputMessageBoxHeading As String = "Average Your Grade"
    Dim _strInputMessageBoxShow As String = "Enter Grade"
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblAverageGrade.Click

    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim decMax As Decimal = 12D
        Dim decMin As Decimal = 0D
        Dim strCancelButton As String = ""
        Dim strError As String = "Enter Valid Grades between 0 to 100"
        Dim strGrades As String
        Dim strErrorAllGrade As String = "Enter all of your Grades"
        strGrades = InputBox(_strInputMessageBoxShow & decMin + 1, _strInputMessageBoxHeading, "")
        Do Until decMin > decMax
            If IsNumeric(strGrades) Then
                _decAverage = Convert.ToInt32(strGrades)
                If _decAverage >= 0 And _decAverage <= 100 Then
                    lstGrades.Items.Add(_decAverage)
                    decMin += 1
                Else
                    MsgBox(strError & _strErrorAllGrade)
                End If
            Else
                MsgBox(strError & _strErrorAllGrade)
            End If
            If decMin <= decMax Then
                strGrades = InputBox(_strInputMessageBoxShow & decMin + 1, _strInputMessageBoxHeading, "")
            End If
        Loop
        btnAverage.Visible = True
        btnEnter.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picStudent.Click

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        Dim intNumberOfGrades As Integer = 13L
        Dim decArray(intNumberOfGrades) As Decimal
        Dim decAverage As Decimal
        Dim intl As Integer
        For intl As Integer
                decArray(intl) = Convert.ToInt32(lstGrades, ItemActivation(intl))
        Next
        Array.Sort(decArray)
        decAverage = decCalcAverage(decArray)
        StoreLittleFile(decArray, decAverage)
        lblAverage.Visible = True
        lblAverage.Text = ("Your Average Grade = " & decAverage.ToString("N0") & "%")
    End Sub
    Function decCalcAverage(ByVal decSortGrades() As Decimal) As Decimal)
        Dim intIndex As Integer
        Dim decAdd As Decimal = 0D
        Dim decReturn As Decimal
        For intIndec = 3 To 13
            decAdd += decSortGrades(intIndex)
        Next
End Class
