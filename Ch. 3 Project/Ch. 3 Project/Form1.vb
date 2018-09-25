Public Class Form1

    Private Sub rdbFrench_Click(sender As Object, e As EventArgs) Handles rdbFrench.Click
        lblHello.Text = "Bonjour Mond"
    End Sub

    Private Sub rdbSpanish_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSpanish.CheckedChanged
        lblHello.Text = "Hola Mundo"
    End Sub

    Private Sub rdbRussian_Click(sender As Object, e As EventArgs) Handles rdbRussian.Click
        lblHello.Text = "Привет мир"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(txtName.Text & " is " & nudAge.Value & " years old. ")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudAge.Value = 15
    End Sub

    Private Sub lblHello_Click(sender As Object, e As EventArgs) Handles lblHello.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        lblHello.Text = "the square root of 8 is " & Math.Sqrt(Math.Pow(2, 3))

    End Sub
End Class
