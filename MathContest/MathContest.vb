'Justin Bell
'RCET0265
'Fall24
'Math Contest
'https://github.com/ju8t1n203/MathContest

Option Compare Text
Option Explicit On
Option Strict On
Imports System.Threading.Thread
Public Class MathContest
    Dim summaryArray(,) As Integer
    'buttons----------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SNBox.Clear()
        AgeTextBox.Clear()
        GradeTextBox.Clear()
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        StudentAnswerTextBox.Clear()
        AdditionRadioButton.Checked = True
    End Sub

    'textboxes-------------------------
    Private Sub AgeTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AgeTextBox.Validating
        Dim age As Integer
        'confirms the inputed age is acceptable
        If Integer.TryParse(AgeTextBox.Text, age) Then
            If age < 7 OrElse age > 11 Then
                MsgBox("Student is not eligible to compete.")
                AgeTextBox.Clear()
            End If
        Else
            MsgBox("Please enter a valid number.")
            AgeTextBox.Clear()
        End If
    End Sub

    Private Sub GradeTextBox_validating(sender As Object, e As EventArgs) Handles GradeTextBox.Validating
        Dim grade As Integer
        'confirms the inputed grade is acceptable
        If Integer.TryParse(GradeTextBox.Text, grade) Then
            If grade < 1 OrElse grade > 4 Then
                MsgBox("Student is not eligible to compete.")
                GradeTextBox.Clear()
            End If
        Else
        End If
    End Sub

    Private Sub StudentAnswerTextBox_Validating(sender As Object, e As EventArgs) Handles StudentAnswerTextBox.Validating
        Dim answer As Integer
        'checks the answer box for an integer value
        If Integer.TryParse(StudentAnswerTextBox.Text, answer) Then
        Else
            MsgBox("Please enter a whole number.")
            StudentAnswerTextBox.Clear()
        End If
    End Sub

    'arithmatic buttons----------------
    Private Sub MultipliactionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultipliactionRadioButton.Click,
        DivisionRadioButton.Click, AdditionRadioButton.Click, SubtractionRadioButton.Click

        GetNumbers()

    End Sub

    'numbers selector-----------------
    Sub GetNumbers()
        Dim _first As Integer
        Dim _second As Integer
        'generates numbers based off of the inputed grade
        Do
            Select Case (GradeTextBox.Text)
                Case "1"
                    FirstNumberTextBox.Text = CStr(GetRandomNumber(0, 10))
                    SecondNumberTextBox.Text = CStr(GetRandomNumber(0, 10))
                Case "2"
                    FirstNumberTextBox.Text = CStr(GetRandomNumber(0, 20))
                    SecondNumberTextBox.Text = CStr(GetRandomNumber(0, 20))
                Case "3"
                    FirstNumberTextBox.Text = CStr(GetRandomNumber(0, 30))
                    SecondNumberTextBox.Text = CStr(GetRandomNumber(0, 30))
                Case "4"
                    FirstNumberTextBox.Text = CStr(GetRandomNumber(0, 40))
                    SecondNumberTextBox.Text = CStr(GetRandomNumber(0, 40))
                Case Else
                    FirstNumberTextBox.Text = "0"
                    SecondNumberTextBox.Text = "0"
            End Select

            _first = CInt(FirstNumberTextBox.Text)
            _second = CInt(SecondNumberTextBox.Text)

            Select Case MultipliactionRadioButton.Checked
                Case True
                    Exit Do
            End Select
            'ensures that the two numbers to be divided result in an integer
            Select Case DivisionRadioButton.Checked
                Case True
                    If _first Mod _second = 0 Then
                        Exit Do
                    End If
            End Select

            Select Case AdditionRadioButton.Checked
                Case True
                    Exit Do
            End Select
            'makes sure the subtraction will result in an integer
            Select Case SubtractionRadioButton.Checked
                Case True
                    If _first > _second Then
                        Exit Do
                    End If
            End Select
        Loop
    End Sub

    'answer checker--------------------
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim sAnswer As Integer
        Dim _first As Integer
        Dim _second As Integer
        Dim rAnswer As Integer
        Static correct As Integer = 0
        Static total As Integer = 0

        sAnswer = CInt(StudentAnswerTextBox.Text)
        _first = CInt(FirstNumberTextBox.Text)
        _second = CInt(SecondNumberTextBox.Text)
        'program calculates correct answer
        Select Case MultipliactionRadioButton.Checked
            Case True
                rAnswer = _first * _second
        End Select

        Select Case DivisionRadioButton.Checked
            Case True
                rAnswer = CInt(_first / _second)
        End Select

        Select Case AdditionRadioButton.Checked
            Case True
                rAnswer = _first + _second
        End Select

        Select Case SubtractionRadioButton.Checked
            Case True
                rAnswer = _first - _second
        End Select

        If rAnswer = sAnswer Then
            MsgBox("Correct!")
            correct += 1
            total += 1
        Else
            MsgBox($"Incorrect, correct answer is :{rAnswer}")
            total = +1
        End If
        'this should update the summary array
        summaryArray = Summary(correct, total)

        GetNumbers()
        StudentAnswerTextBox.Clear()
    End Sub

    'summary---------------------------
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim correctValue As Integer = summaryArray(0, 0)
        Dim totalValue As Integer = summaryArray(0, 1)
        'should display # of correct answers vs total questions presented
        MsgBox($"{correctValue} out of {totalValue}")
    End Sub

    'functions-------------------------
    Function GetRandomNumber(max%, min%) As Integer
        Dim randomNumber%
        Randomize(DateTime.Now.Millisecond)
        randomNumber = CInt(Math.Floor(Rnd() * (max - min + 1))) + min

        Return randomNumber%
    End Function

    Function Summary(correct As Integer, total As Integer) As Integer(,)
        Dim _summary(0, 1) As Integer
        'pulls the summary values from the array
        _summary(0, 0) = correct
        _summary(0, 1) = total

        Return _summary
    End Function

    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.AcceptButton = SubmitButton
    End Sub
End Class
