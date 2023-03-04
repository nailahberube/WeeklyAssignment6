Public Class frmInternetSpeed
    Private Sub btnEnterInternetSpeed_Click(sender As Object, e As EventArgs) Handles btnEnterInternetSpeed.Click
        'Declare and initialize varibles 
        Dim strInternetSpeed As String
        Dim decInternetSpeed As Decimal
        Dim decAverageSpeed As Decimal
        Dim decTotalAverageSpeed As Decimal = 0D
        Dim strInputMessage As String = "Enter the number of Mbps of your home Internet speed user # "
        Dim stringInputHeading As String = "Internet Speed "
        Dim strNormalMessage As String = "Enter your internet speed "
        Dim strNonNumericError As String = "Error - Enter the speed of your home Internet connection  "
        Dim strNegativeError As String = "Error - Enter a valid speed "

        'Initialize loop variables 
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEnteries As Integer = 10
        Dim intNumberOfEnteries As Integer = 1

        'Capture first value 
        strInternetSpeed = InputBox(strInputMessage & intNumberOfEnteries, stringInputHeading, " ")

        'Loop until 10 internet speed values are input or cancel 
        Do Until intNumberOfEnteries > intMaxNumberOfEnteries Or strInternetSpeed = strCancelClicked
            'Is entry numeric?
            If IsNumeric(strInternetSpeed) Then
                decInternetSpeed = Convert.ToDecimal(strInternetSpeed)

                'Check is value is positive 
                If decInternetSpeed > 0 Then
                    'Add internet speed value and increment 
                    lstInternetSpeed.Items.Add(decInternetSpeed)
                    decTotalAverageSpeed += decInternetSpeed
                    intNumberOfEnteries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If

            Else
                strInputMessage = strNonNumericError
            End If
            'Check if 10 values have been entered and captured next value 
            If intNumberOfEnteries <= intMaxNumberOfEnteries Then
                strInternetSpeed = InputBox(strInputMessage & intNumberOfEnteries, stringInputHeading, "")
            End If

        Loop

        'Calculate and display average 
        If intNumberOfEnteries > 1 Then
            lblAverageInternetSpeed.Visible = True
            decAverageSpeed = decTotalAverageSpeed / (intNumberOfEnteries - 1)
            lblAverageInternetSpeed.Text = "Average Internet Speed: " & decAverageSpeed.ToString("F1") & " Mbps"

        End If
        btnEnterInternetSpeed.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstInternetSpeed.Items.Clear()
        lblAverageInternetSpeed.Visible = False
        btnEnterInternetSpeed.Enabled = True
    End Sub
End Class
