Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Dim capital_prestamo As Double
    Public I As Double
    Dim N As Double
    Dim Mychechk As Double
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Definimos C como la cuota a pagar mensualmente
        Dim C As Double
        'Definimos R como interes anual
        Dim R As Double
        'Dim mostrar As Double
        'Calculamos el interes anual
        'Agregamos el valor del capital del prestamo
        If Not IsNumeric(TextBox1.Text) Then
            MessageBox.Show("Error: Valor no numérico en el capital del préstamo.")
            Return
        End If

        If Not IsNumeric(TextBox2.Text) Then
            MessageBox.Show("Error: Valor no numérico en la tasa de interés anual.")
            Return
        End If

        If Not IsNumeric(TextBox3.Text) Then
            MessageBox.Show("Error: Valor no numérico en el número de años.")
            Return
        End If
        capital_prestamo = CDbl(TextBox1.Text)
        I = CDbl(TextBox2.Text)
        N = CDbl(TextBox3.Text)

        R = (I / 100) / 12 ' Tasa de interés mensual
        C = (capital_prestamo * R) / (1 - (1 / (1 + R)) ^ (N * 12))
        TextBox4.Text = C.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
