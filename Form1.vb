Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim label2 = TextBox1.Text
        Dim Label3 = TextBox2.Text
        Dim Label4 = ComboBox1.Text
        Dim Label5 = TextBox3.Text
        Dim Label6 = TextBox4.Text
        Dim Label7 = TextBox5.Text
        Dim Label8 = TextBox6.Text
        Dim Label9 = TextBox7.Text
        Dim label10 = TextBox8.Text

        TextBox7.Text = TextBox4.Text * 0.2 + TextBox5.Text * 0.3 + TextBox6.Text * 0.5
        TextBox9.Text = TextBox7.Text / TextBox3.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
