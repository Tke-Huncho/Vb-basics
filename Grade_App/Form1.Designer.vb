<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()

        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(119, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(674, 407)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"

        Label1.AutoSize = True
        Label1.Location = New Point(81, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 5
        Label1.Text = "Subject 1"

        TextBox4.Location = New Point(178, 215)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(166, 27)
        TextBox4.TabIndex = 3

        TextBox3.Location = New Point(178, 100)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(166, 27)
        TextBox3.TabIndex = 2

        TextBox2.Location = New Point(178, 154)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(166, 27)
        TextBox2.TabIndex = 1

        TextBox1.Location = New Point(178, 49)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(166, 27)
        TextBox1.TabIndex = 0

        Label2.AutoSize = True
        Label2.Location = New Point(81, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 6
        Label2.Text = "Subject 2"

        Label3.AutoSize = True
        Label3.Location = New Point(81, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 7
        Label3.Text = "Subject 3"

        Label4.AutoSize = True
        Label4.Location = New Point(81, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 8
        Label4.Text = "Subject 4"

        Label5.AutoSize = True
        Label5.Location = New Point(225, 311)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 9

        Button1.Location = New Point(211, 293)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 10
        Button1.Text = "Grade"
        Button1.UseVisualStyleBackColor = True

        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(1025, 525)
        Controls.Add(GroupBox1)
        ForeColor = SystemColors.Highlight
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim subject1Grade, subject2Grade, subject3Grade, subject4Grade As Double


        If Not Double.TryParse(TextBox1.Text, subject1Grade) Then
            MessageBox.Show("Invalid input for Subject 1 grade. Please enter a valid number.")
            Return
        End If

        If Not Double.TryParse(TextBox2.Text, subject2Grade) Then
            MessageBox.Show("Invalid input for Subject 2 grade. Please enter a valid number.")
            Return
        End If

        If Not Double.TryParse(TextBox3.Text, subject3Grade) Then
            MessageBox.Show("Invalid input for Subject 3 grade. Please enter a valid number.")
            Return
        End If

        If Not Double.TryParse(TextBox4.Text, subject4Grade) Then
            MessageBox.Show("Invalid input for Subject 4 grade. Please enter a valid number.")
            Return
        End If

        Dim averageGrade As Double = (subject1Grade + subject2Grade + subject3Grade + subject4Grade) / 4

        Dim grade As String = ""
        If averageGrade < 50 Then
            grade = "Fail"
        ElseIf averageGrade < 65 Then
            grade = "C"
        ElseIf averageGrade < 75 Then
            grade = "B"
        Else
            grade = "A"
        End If

        MessageBox.Show("Average Grade: " & averageGrade.ToString("F2") & vbCrLf & "Grade: " & grade)

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub
End Class