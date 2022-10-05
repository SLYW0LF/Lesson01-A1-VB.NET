Public Class Form1
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim greeting As String
        Dim fontStyle As FontStyle = FontStyle.Regular

        ProgressBar1.Value = ProgressBar1.Minimum


        If RadioButton1.Checked Then
            greeting = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            greeting = RadioButton2.Text
        ElseIf RadioButton3.Checked Then
            greeting = RadioButton3.Text
        ElseIf RadioButton4.Checked Then
            greeting = RadioButton4.Text
        End If

        If CheckBox1.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If CheckBox2.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If CheckBox3.Checked Then
            fontStyle = fontStyle Or FontStyle.Underline
        End If

        For i = 0 To ProgressBar1.Maximum - 1
            ProgressBar1.Value = ProgressBar1.Value + 1
        Next

        RichTextBox1.Font = New Font(RichTextBox1.Text, 18, fontStyle)

        If String.IsNullOrEmpty(TextBox1.Text) Then
            RichTextBox1.Text = greeting + TextBox1.Text
        Else
            RichTextBox1.Text = greeting + ", " + TextBox1.Text
        End If


    End Sub
End Class
