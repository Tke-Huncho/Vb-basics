Public Class Form1
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objDemoForm As New ObjectDemonstrationsForm()
        objDemoForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assigning tooltips to buttons
        Dim toolTipLoadObjectDemo As New ToolTip()
        toolTipLoadObjectDemo.SetToolTip(Button1, "Load Object Demo")

        Dim toolTipExit As New ToolTip()
        toolTipExit.SetToolTip(Button2, "Exit")
    End Sub
End Class
