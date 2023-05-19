Public Class Form3
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim Bandera As Boolean


    Public Sub DeterminarConcatenar()
        If Bandera = True Then
            tbresultado.Text = ""
            Bandera = False
        ElseIf tbresultado.Text = "0" Then
            tbresultado.Text = ""
        End If
    End Sub

    Public Sub OperacionProceso()
        Bandera = True
        Valor2 = Val(tbresultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2

                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
                Case "%"
                    ValorResultado = (ValorResultado * 100) / Valor2

            End Select
            tbresultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If


    End Sub
    Private Sub bt1_Click_1(sender As Object, e As EventArgs) Handles bt1.Click
        DeterminarConcatenar()
        tbresultado.Text &= 1
    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        DeterminarConcatenar()
        tbresultado.Text &= 2
    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        DeterminarConcatenar()
        tbresultado.Text &= 3
    End Sub

    Private Sub t4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        DeterminarConcatenar()
        tbresultado.Text &= 4
    End Sub

    Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
        DeterminarConcatenar()
        tbresultado.Text &= 5
    End Sub

    Private Sub bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        DeterminarConcatenar()
        tbresultado.Text &= 6
    End Sub

    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        DeterminarConcatenar()
        tbresultado.Text &= 7
    End Sub

    Private Sub bt8_Click(sender As Object, e As EventArgs) Handles bt8.Click
        DeterminarConcatenar()
        tbresultado.Text &= 8
    End Sub

    Private Sub bt9_Click(sender As Object, e As EventArgs) Handles bt9.Click
        DeterminarConcatenar()
        tbresultado.Text &= 9
    End Sub

    Private Sub bt0_Click(sender As Object, e As EventArgs) Handles bt0.Click
        DeterminarConcatenar()
        tbresultado.Text &= 0
    End Sub

    Private Sub btCE_Click_1(sender As Object, e As EventArgs) Handles btCE.Click
        tbresultado.Text = ""
    End Sub

    Private Sub btresta_Click_1(sender As Object, e As EventArgs) Handles btresta.Click
        OperacionProceso()
        Operacion = "-"
    End Sub

    Private Sub btsuma_Click_1(sender As Object, e As EventArgs) Handles btsuma.Click
        OperacionProceso()
        Operacion = "+"
    End Sub

    Private Sub btmultiplicacion_Click_1(sender As Object, e As EventArgs) Handles btmultiplicacion.Click
        OperacionProceso()
        Operacion = "*"
    End Sub

    Private Sub btdivision_Click_1(sender As Object, e As EventArgs) Handles btdivision.Click
        OperacionProceso()
        Operacion = "/"
    End Sub

    Private Sub btC_Click_1(sender As Object, e As EventArgs) Handles btC.Click
        tbresultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub btigual_Click_1(sender As Object, e As EventArgs) Handles btigual.Click
        OperacionProceso()
        Operacion = ""
    End Sub

    Private Sub btporcentaje_Click_1(sender As Object, e As EventArgs) Handles btporcentaje.Click
        OperacionProceso()
        Operacion = "%"
    End Sub

    Private Sub btpunto_Click_1(sender As Object, e As EventArgs) Handles btpunto.Click
        DeterminarConcatenar()
        If InStr(tbresultado.Text, ".", CompareMethod.Text) = 0 Then
            tbresultado.Text &= "."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class