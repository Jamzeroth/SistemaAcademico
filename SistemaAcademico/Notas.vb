Imports MySql.Data.MySqlClient

Public Class Notas
    Dim BDconexion As New MySqlConnection("server=localhost; database=sisaca; user id=sisaca; password=sisaca2016")
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub n1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles n1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Sólo Numeros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub n2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles n2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Sólo Numeros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub n3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles n3.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Sólo Numeros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prom As Double
        Dim esta As String
        Dim cod_pro As Integer
        CodigoEst(TextBox1)
        CodigoAsi(promedio)
        prom = CDbl(n1.Text + n2.Text + n3.Text / 3)
        'promedio.Text = CStr(prom)
        If prom >= 14 Then
            esta = "Aprobado"
        Else
            esta = "Reprobado"
        End If
        BDcadena = "SELECT codigo_nota FROM sisaca.nota;"
        Dim cod As Integer = AsignarId("codigo_nota")
        BDcadena = "INSERT INTO `sisaca`.`nota` (`codigo_nota`, `Nota1`, `Nota2`, `Nota3`, `Promedio`, `Estado`, `pacademico_codigo_aca`, `pacademico_colegio_codigo_col`, `estudiante_codigo_est`,`estudiante_colegio_codigo_col`,`profesor_codigo_pro`,`profesor_colegio_codigo_col`,`asignatura_codigo_asi`) VALUES ('" + CStr(cod) + "', '" + CStr(n1.Text) + "', '" + CStr(n2.Text) + "','" + CStr(n3.Text) + "','" + prom + "','" + esta + "','0', '0', '" + CStr(TextBox1.Text) + "', '0', '" + CStr(cod_pro) + "', '0','" + CStr(promedio.Text) + "');"
        Almacenar_Datos()
        Limpiar()
    End Sub

    Private Sub Limpiar()
        n1.Text = ""
        n2.Text = ""
        n3.Text = ""
        promedio.Text = ""
        TextBox1.Text = ""
    End Sub
    Private Sub Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BDconexion.Open()
        LLenarComboBoxAsig(asig)
    End Sub

    Public Function CodigoAsi(ByVal cb As Label)
        Dim cod_asi As Object
        cod_asi = asig.SelectedItem.ToString
        Dim enunciado As MySqlCommand
        Dim respuesta As MySqlDataReader
        Try
            enunciado = New MySqlCommand("SELECT sisaca.asignatura.codigo_asi FROM sisaca.asignatura WHERE sisaca.estudiante.Nombre='" + cod_asi + "'", BDconexion)
            respuesta = enunciado.ExecuteReader
            While respuesta.Read
                cb.Text = (respuesta.Item("codigo_asi"))
            End While
            respuesta.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function CodigoEst(ByVal cb As TextBox)
        Dim cod_est As Object
        cod_est = est.SelectedItem.ToString
        Dim enunciado As MySqlCommand
        Dim respuesta As MySqlDataReader
        Try
            enunciado = New MySqlCommand("SELECT sisaca.estudiante.codigo_est FROM sisaca.estudiante WHERE sisaca.estudiante.Nombre='" + cod_est + "'", BDconexion)
            respuesta = enunciado.ExecuteReader
            While respuesta.Read
                cb.Text = (respuesta.Item("codigo_est"))
            End While
            respuesta.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (asig.Text <> "Seleccione asignatura") Then
            If (est.Text <> "Seleccione estudiante") Then
                LLenarComboBoxEst(est)

            Else
                MsgBox("Seleccione un estudiante")
            End If

        Else
            MsgBox("Seleccione una asignatura")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (bus.Text <> "Seleccione opción") Then
            Select Case bus.Text
                Case "Estudiante"
                    BDcadena = "select sisaca.estudiante.Nombre, sisaca.nota.Nota1, sisaca.nota.Nota2, sisaca.nota.Nota3, sisaca.nota.Promedio, sisaca.nota.Estado
from sisaca.nota inner join sisaca.estudiante on nota.estudiante_codigo_est=estudiante.codigo_est where estudiante.Nombre='" + buscar.Text + "';"
                Case Else
                    BDcadena = "select sisaca.asignatura.Nombre, sisaca.nota.Nota1, sisaca.nota.Nota2, sisaca.nota.Nota3, sisaca.nota.Promedio, sisaca.nota.Estado
from sisaca.nota inner join sisaca.asignatura on nota.asignatura_codigo_asi=asignatura.codigo_asi where asignatura.Nombre='" + buscar.Text + " ';"
            End Select
        Else
            MsgBox("Seleccione un método de búsqueda")
        End If
        TablaDgv.DataSource = ObtenerTabla()
    End Sub
End Class