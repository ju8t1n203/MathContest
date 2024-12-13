<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContest
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
        Me.ButtonBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.SIBox = New System.Windows.Forms.GroupBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.SNLabel = New System.Windows.Forms.Label()
        Me.SNBox = New System.Windows.Forms.TextBox()
        Me.ProblemBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.SubtractionRadioButton = New System.Windows.Forms.RadioButton()
        Me.AdditionRadioButton = New System.Windows.Forms.RadioButton()
        Me.DivisionRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultipliactionRadioButton = New System.Windows.Forms.RadioButton()
        Me.ButtonBox.SuspendLayout()
        Me.SIBox.SuspendLayout()
        Me.ProblemBox.SuspendLayout()
        Me.ProblemTypeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonBox
        '
        Me.ButtonBox.Controls.Add(Me.ExitButton)
        Me.ButtonBox.Controls.Add(Me.SummaryButton)
        Me.ButtonBox.Controls.Add(Me.ClearButton)
        Me.ButtonBox.Controls.Add(Me.SubmitButton)
        Me.ButtonBox.Location = New System.Drawing.Point(367, 12)
        Me.ButtonBox.Name = "ButtonBox"
        Me.ButtonBox.Size = New System.Drawing.Size(145, 327)
        Me.ButtonBox.TabIndex = 3
        Me.ButtonBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(6, 248)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(129, 68)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(6, 171)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(129, 71)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(6, 91)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(129, 75)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(6, 19)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(129, 66)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'SIBox
        '
        Me.SIBox.Controls.Add(Me.GradeTextBox)
        Me.SIBox.Controls.Add(Me.AgeTextBox)
        Me.SIBox.Controls.Add(Me.AgeLabel)
        Me.SIBox.Controls.Add(Me.GradeLabel)
        Me.SIBox.Controls.Add(Me.SNLabel)
        Me.SIBox.Controls.Add(Me.SNBox)
        Me.SIBox.Location = New System.Drawing.Point(12, 12)
        Me.SIBox.Name = "SIBox"
        Me.SIBox.Size = New System.Drawing.Size(349, 72)
        Me.SIBox.TabIndex = 0
        Me.SIBox.TabStop = False
        Me.SIBox.Text = "Student Information"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(241, 44)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GradeTextBox.TabIndex = 2
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(241, 18)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 1
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(206, 21)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(29, 13)
        Me.AgeLabel.TabIndex = 1
        Me.AgeLabel.Text = "Age:"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(196, 51)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(39, 13)
        Me.GradeLabel.TabIndex = 1
        Me.GradeLabel.Text = "Grade:"
        '
        'SNLabel
        '
        Me.SNLabel.AutoSize = True
        Me.SNLabel.Location = New System.Drawing.Point(13, 22)
        Me.SNLabel.Name = "SNLabel"
        Me.SNLabel.Size = New System.Drawing.Size(38, 13)
        Me.SNLabel.TabIndex = 1
        Me.SNLabel.Text = "Name:"
        '
        'SNBox
        '
        Me.SNBox.Location = New System.Drawing.Point(54, 19)
        Me.SNBox.Name = "SNBox"
        Me.SNBox.Size = New System.Drawing.Size(130, 20)
        Me.SNBox.TabIndex = 0
        '
        'ProblemBox
        '
        Me.ProblemBox.Controls.Add(Me.StudentAnswerLabel)
        Me.ProblemBox.Controls.Add(Me.SecondNumberLabel)
        Me.ProblemBox.Controls.Add(Me.FirstNumberLabel)
        Me.ProblemBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.ProblemBox.Controls.Add(Me.SecondNumberTextBox)
        Me.ProblemBox.Controls.Add(Me.FirstNumberTextBox)
        Me.ProblemBox.Location = New System.Drawing.Point(12, 90)
        Me.ProblemBox.Name = "ProblemBox"
        Me.ProblemBox.Size = New System.Drawing.Size(127, 153)
        Me.ProblemBox.TabIndex = 2
        Me.ProblemBox.TabStop = False
        Me.ProblemBox.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(6, 103)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(82, 13)
        Me.StudentAnswerLabel.TabIndex = 5
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(6, 64)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(65, 13)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(6, 25)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(61, 13)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(9, 119)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(111, 20)
        Me.StudentAnswerTextBox.TabIndex = 2
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(9, 80)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.ReadOnly = True
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(111, 20)
        Me.SecondNumberTextBox.TabIndex = 1
        Me.SecondNumberTextBox.TabStop = False
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(9, 41)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.ReadOnly = True
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(111, 20)
        Me.FirstNumberTextBox.TabIndex = 0
        Me.FirstNumberTextBox.TabStop = False
        '
        'ProblemTypeGroupBox
        '
        Me.ProblemTypeGroupBox.Controls.Add(Me.SubtractionRadioButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.AdditionRadioButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.DivisionRadioButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.MultipliactionRadioButton)
        Me.ProblemTypeGroupBox.Location = New System.Drawing.Point(145, 90)
        Me.ProblemTypeGroupBox.Name = "ProblemTypeGroupBox"
        Me.ProblemTypeGroupBox.Size = New System.Drawing.Size(115, 123)
        Me.ProblemTypeGroupBox.TabIndex = 1
        Me.ProblemTypeGroupBox.TabStop = False
        Me.ProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'SubtractionRadioButton
        '
        Me.SubtractionRadioButton.AutoSize = True
        Me.SubtractionRadioButton.Location = New System.Drawing.Point(6, 86)
        Me.SubtractionRadioButton.Name = "SubtractionRadioButton"
        Me.SubtractionRadioButton.Size = New System.Drawing.Size(79, 17)
        Me.SubtractionRadioButton.TabIndex = 3
        Me.SubtractionRadioButton.Text = "Subtraction"
        Me.SubtractionRadioButton.UseVisualStyleBackColor = True
        '
        'AdditionRadioButton
        '
        Me.AdditionRadioButton.AutoSize = True
        Me.AdditionRadioButton.Checked = True
        Me.AdditionRadioButton.Location = New System.Drawing.Point(6, 64)
        Me.AdditionRadioButton.Name = "AdditionRadioButton"
        Me.AdditionRadioButton.Size = New System.Drawing.Size(63, 17)
        Me.AdditionRadioButton.TabIndex = 2
        Me.AdditionRadioButton.TabStop = True
        Me.AdditionRadioButton.Text = "Addition"
        Me.AdditionRadioButton.UseVisualStyleBackColor = True
        '
        'DivisionRadioButton
        '
        Me.DivisionRadioButton.AutoSize = True
        Me.DivisionRadioButton.Location = New System.Drawing.Point(6, 41)
        Me.DivisionRadioButton.Name = "DivisionRadioButton"
        Me.DivisionRadioButton.Size = New System.Drawing.Size(62, 17)
        Me.DivisionRadioButton.TabIndex = 1
        Me.DivisionRadioButton.Text = "Division"
        Me.DivisionRadioButton.UseVisualStyleBackColor = True
        '
        'MultipliactionRadioButton
        '
        Me.MultipliactionRadioButton.AutoSize = True
        Me.MultipliactionRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.MultipliactionRadioButton.Name = "MultipliactionRadioButton"
        Me.MultipliactionRadioButton.Size = New System.Drawing.Size(86, 17)
        Me.MultipliactionRadioButton.TabIndex = 0
        Me.MultipliactionRadioButton.Text = "Multiplication"
        Me.MultipliactionRadioButton.UseVisualStyleBackColor = True
        '
        'MathContest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 346)
        Me.Controls.Add(Me.ProblemTypeGroupBox)
        Me.Controls.Add(Me.ProblemBox)
        Me.Controls.Add(Me.SIBox)
        Me.Controls.Add(Me.ButtonBox)
        Me.Name = "MathContest"
        Me.Text = "Form1"
        Me.ButtonBox.ResumeLayout(False)
        Me.SIBox.ResumeLayout(False)
        Me.SIBox.PerformLayout()
        Me.ProblemBox.ResumeLayout(False)
        Me.ProblemBox.PerformLayout()
        Me.ProblemTypeGroupBox.ResumeLayout(False)
        Me.ProblemTypeGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents SIBox As GroupBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents SNLabel As Label
    Friend WithEvents SNBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents ProblemBox As GroupBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents ProblemTypeGroupBox As GroupBox
    Friend WithEvents SubtractionRadioButton As RadioButton
    Friend WithEvents AdditionRadioButton As RadioButton
    Friend WithEvents DivisionRadioButton As RadioButton
    Friend WithEvents MultipliactionRadioButton As RadioButton
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
End Class
