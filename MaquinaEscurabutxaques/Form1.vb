Public Class Form1
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If Panel1.Visible = False Then
            Panel1.Show()
            Panel2.Show()
            Panel3.Show()
        Else
            If CInt(TotalTextBox.Text) >= 1 Then
                tirada()
                randomizar()
                checkValues()
                'Label4.Visible = False
                'If Label4.Visible = True Then
                '    Label4.Visible = False
                'End If

            Else
                MsgBox("Dinero insuficiente. Deposite más para seguir jugando.")
            End If
        End If
    End Sub

    Function deposit() As Integer
        Dim x As Integer

        If DepositTextBox.Text = "" Then
            MsgBox("Debe introducir una cantidad mínima de 1 euro")
        Else
            x = CInt(DepositTextBox.Text)
            If TotalTextBox.Text = 0 Then
                TotalTextBox.Text = x
            Else
                TotalTextBox.Text = TotalTextBox.Text + x
            End If

        End If
    End Function

    Sub checkValues()
        Dim a, b, c As String
        a = TextBoxA.Text
        b = TextBoxB.Text
        c = TextBoxC.Text
        Dim m, p, e, l, r As String
        m = "M"
        p = "P"
        e = "E"
        l = "L"
        r = "R"
        Dim totalActual As Integer
        totalActual = CInt(TotalTextBox.Text)

        Dim totalF As String


        'If a = r And b = r And c = r Then
        '    totalF = CStr(totalActual + 50)
        '    TotalTextBox.Text = totalF
        'ElseIf a = l And b = l And c = l Then
        '    totalF = CStr(totalActual + 40)
        '    TotalTextBox.Text = totalF
        'ElseIf a = e And b = e And c = e Then
        '    totalF = CStr(totalActual + 30)
        '    TotalTextBox.Text = totalF
        'ElseIf a = p And b = p And c = p Then
        '    totalF = CStr(totalActual + 20)
        '    TotalTextBox.Text = totalF
        'ElseIf a = m And b = m And c = m Then
        '    totalF = CStr(totalActual + 10)
        '    TotalTextBox.Text = totalF
        'ElseIf a = r And b = r Then
        '    totalF = CStr(totalActual + 5)
        '    TotalTextBox.Text = totalF
        'ElseIf a = r And c = r Then
        '    totalF = CStr(totalActual + 5)
        '    TotalTextBox.Text = totalF
        'ElseIf b = r And c = r Then
        '    totalF = CStr(totalActual + 5)
        '    TotalTextBox.Text = totalF
        'ElseIf a = r Then
        '    totalF = CStr(totalActual + 1)
        '    TotalTextBox.Text = totalF
        'ElseIf b = r Then
        '    totalF = CStr(totalActual + 1)
        '    TotalTextBox.Text = totalF
        'ElseIf c = r Then
        '    totalF = CStr(totalActual + 1)
        '    TotalTextBox.Text = totalF
        'End If


        Dim secuencia As String

        secuencia = TextBoxA.Text & TextBoxB.Text & TextBoxC.Text

        Select Case secuencia
            Case "LLL"
                totalF = CStr(totalActual + 40)
                TotalTextBox.Text = totalF
                Label4.Text = "+40€!!"
                timeLabel4()
            Case "EEE"
                totalF = CStr(totalActual + 30)
                TotalTextBox.Text = totalF
                Label4.Text = "+30€!"
                timeLabel4()
            Case "PPP"
                totalF = CStr(totalActual + 20)
                TotalTextBox.Text = totalF
                Label4.Text = "+20€!"
                timeLabel4()
            Case "MMM"
                totalF = CStr(totalActual + 10)
                TotalTextBox.Text = totalF
                Label4.Text = "+10€!"
                timeLabel4()

            Case Else
                Dim x As String
                Dim i, numR As Integer
                numR = 0
                For i = 0 To secuencia.Length - 1
                    x = secuencia(i)
                    If x = "R" Then
                        numR += 1
                    End If
                Next
                Select Case numR
                    Case 3
                        totalF = CStr(totalActual + 50)
                        TotalTextBox.Text = totalF
                        Label4.Text = "+50€!!!"
                        timeLabel4()
                    Case 2
                        totalF = CStr(totalActual + 5)
                        TotalTextBox.Text = totalF
                        Label4.Text = "+5€!"
                        timeLabel4()
                    Case 1
                        totalF = CStr(totalActual + 1)
                        TotalTextBox.Text = totalF
                        Label4.Text = "+1€!"
                        timeLabel4()
                End Select

        End Select



    End Sub
    Sub randomizar()

        Dim frutas(4) As String
        Dim valorA, valorB, valorC As String
        Dim rnd As New Random
        frutas(0) = "M"
        frutas(1) = "P"
        frutas(2) = "E"
        frutas(3) = "L"
        frutas(4) = "R"

        valorA = rnd.Next(0, frutas.Length)
        valorB = rnd.Next(0, frutas.Length)
        valorC = rnd.Next(0, frutas.Length)


        TextBoxA.Text = frutas(valorA)
        TextBoxB.Text = frutas(valorB)
        TextBoxC.Text = frutas(valorC)

    End Sub
    Sub timeLabel4()
        'Timer1.Enabled = True

        Label4.Show()


    End Sub
    Sub tirada()
        Dim x As Integer
        x = CInt(TotalTextBox.Text)
        TotalTextBox.Text = x - 1

    End Sub

    Private Sub BtnDepositar_Click(sender As Object, e As EventArgs) Handles BtnDepositar.Click
        deposit()
        DepositTextBox.Text = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DepositTextBox.Text = 0
        TotalTextBox.Text = 0
    End Sub


    Private Sub DepositTextBox_GotFocus(sender As Object, e As EventArgs) Handles DepositTextBox.GotFocus
        DepositTextBox.Text = ""
    End Sub

    Private Sub BtnRetirar_Click(sender As Object, e As EventArgs) Handles BtnRetirar.Click
        TotalTextBox.Text = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Label4.Show()
    End Sub
End Class
