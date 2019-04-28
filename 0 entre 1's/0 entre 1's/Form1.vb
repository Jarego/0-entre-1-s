Public Class Form1
    Dim contador = 0
    Dim salida As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += " "
        PictureBox1.Image = ImageList1.Images(1)
        MsgBox("inicio")
        s1()
    End Sub
    Sub s1()
        If TextBox1.Text(contador) = "1" Then
            contador += 1
            salida += "1"
            Label1.Text = salida
            PictureBox1.Image = ImageList1.Images(2)
            MsgBox("Encuentra 1, lo deja igual, derecha")
            s2()
        ElseIf TextBox1.Text(contador) <> "1" Then
            MsgBox("NO SE ACEPTA")
        End If
    End Sub
    Sub s2()
        If TextBox1.Text(contador) = "1" Then
            contador += 1
            salida += "1"
            Label1.Text = salida
            PictureBox1.Image = ImageList1.Images(1)
            MsgBox("Encuentra 1, lo deja igual, derecha")
            s2()
        ElseIf TextBox1.Text(contador) = "0" Then
            contador += 1
            salida += "0"
            Label1.Text = salida
            PictureBox1.Image = ImageList1.Images(1)
            MsgBox("Encuentra 0, lo deja igual, derecha")
            s1()
        ElseIf TextBox1.Text(contador) = " " Then
            PictureBox1.Image = ImageList1.Images(3)
            MsgBox("se acepta la cadena")

        End If

    End Sub
End Class
