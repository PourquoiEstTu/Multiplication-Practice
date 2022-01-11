Public Class Form1
    'Roshaan Q., Mar. 21, 2020, A multiplication practice program for children
    Dim num1 As Integer
    Dim num2 As Integer 'these two variables must be declared locally since an expression you cannot pass parameters twice (assumption of the reason)
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim areYouSure As Integer
        areYouSure = MessageBox.Show("Are you sure you don't want some more practice?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If areYouSure = vbYes Then 'This if statement is unnecessary but I think promotes the user to continue practicing
            Me.Close()
        Else
            MessageBox.Show("Keep getting at it!")
        End If
    End Sub
    Private Sub generateProblem() 'this sub actually configures what the problem will look like and has the command to display the problem
        Randomize()
        num1 = Int(Rnd() * 10) + 1
        num2 = Int(Rnd() * 10) + 1
        lblShowProblem.Text = "Solve " & num1 & " * " & num2
        txtAnswer.Clear()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'This sub is for instantly conducting a process(usually a sub) when the form loads. In this instant, the problem is instantly generated
        generateProblem() 'calls the sub to conduct its own action in this sub
        picWallpaper.SendToBack()
    End Sub
    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        If IsNumeric(txtAnswer.Text) Then 'if statement for foolproofing
            checkAnswer() 'if the txtAnswer is numeric then the checkAnswer() sub will start
        Else
            MessageBox.Show("Please enter a number!")
        End If
    End Sub
    Private Sub checkAnswer()
        Dim answer As Integer 'answer cannot be static because the value changes every time the problem is generated
        Static numberCorrect As Integer
        Static numberQuestions As Integer 'These two need to be static because their previous values are added on to in this sub and when conducted in other subs
        answer = num1 * num2
        If answer = txtAnswer.Text Then
            MessageBox.Show("Good job, that is correct!")
            numberCorrect += 1
            numberQuestions += 1
        Else
            MessageBox.Show("Unlucky! The answer was actually " & answer & ".")
            numberQuestions += 1
        End If
        MessageBox.Show("Your score is currently " & numberCorrect & "/" & numberQuestions & ".")
        generateProblem()
    End Sub

    Private Sub txtAnswer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnswer.KeyDown 'sub for affecting keyboard key properties instead of text properties
        If e.KeyCode = Keys.Enter Then 'This is just for simplicity and intuitiveness
            btnLaunch.PerformClick()
        End If
    End Sub

    'The private sub below COULD be in the program for foolproofing but IsNumeric is used instead

    'Private Sub txtAnswer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnswer.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        btnLaunch.PerformClick()
    '    ElseIf Not (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9 Or e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9 Or e.KeyCode = Keys.Back) Then
    '        e.SuppressKeyPress = True
    '    End If
    'End Sub
End Class
