Public Class ObjectDemonstrationsForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' This event is triggered when Button1 (Load Picture) is clicked
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        openFileDialog.Title = "Select an Image"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' This event is triggered when Button2 is clicked
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ' This event is triggered when RadioButton1 is checked or unchecked
        If RadioButton1.Checked Then
            TextBox1.ForeColor = Color.Green
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ' This event is triggered when RadioButton2 is checked or unchecked
        If RadioButton2.Checked Then
            TextBox1.ForeColor = Color.Blue
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ' This event is triggered when RadioButton3 is checked or unchecked
        If RadioButton3.Checked Then
            TextBox1.ForeColor = Color.Red
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' This event is triggered when CheckBox1 is checked or unchecked
        If CheckBox1.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic)
        Else
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ' This event is triggered when CheckBox2 is checked or unchecked
        If CheckBox2.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold)
        Else
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        ' This event is triggered when CheckBox3 is checked or unchecked
        If CheckBox3.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Italic)
        Else
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub ObjectDemonstrationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event is triggered when ObjectDemonstrationsForm is loaded
        TextBox1.Text = "Sample Text"
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged
        ' This event is triggered when any radio button in the group is checked
        Dim selectedRadioButton As RadioButton = DirectCast(sender, RadioButton)

        If selectedRadioButton.Checked Then
            Select Case selectedRadioButton.Name
                Case "RadioButton4"
                    TextBox1.Font = New Font("Garamond", 12, TextBox1.Font.Style)
                Case "RadioButton5"
                    TextBox1.Font = New Font("Magneto", 12, TextBox1.Font.Style)
                Case "RadioButton6"
                    TextBox1.Font = New Font("Tahoma", 12, TextBox1.Font.Style)
            End Select
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class