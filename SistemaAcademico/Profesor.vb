Public Class Profesor
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Administrativo.Show()
    End Sub

    Private Sub Cipro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cipro.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Sólo Numeros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub nompro_TextChanged(sender As Object, e As EventArgs) Handles nompro.TextChanged

    End Sub

    Private Sub nompro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nompro.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Sólo Letras", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub telPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telPro.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Sólo Numeros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub sueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sueldo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Sólo Numeros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub titPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles titPro.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Sólo Letras", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        BDcadena = "SELECT codigo_pro FROM sisaca.profesor;"
        Dim cod As Integer = AsignarId("codigo_pro")
        BDcadena = "INSERT INTO `sisaca`.`profesor` (`codigo_pro`, `Nombre`, `Cédula`, `F. Nacimiento`, `Dirección`, `Teléfono`, `Email`, `Título`, `Sueldo`,`estado`,`colegio_codigo_col`) VALUES ('" + CStr(cod) + "', '" + nompro.Text + "', '" + Cipro.Text + "', '" + CStr(fnPro.Text) + "', '" + dirPro.Text + "', '" + telPro.Text + "', '" + emailPro.Text + "', '" + titPro.Text + "', '" + CStr(sueldo.Text) + "','1','0');"
        Almacenar_Datos()
        Limpiar()
    End Sub

    Private Sub Limpiar()
        Cipro.Text = ""
        nompro.Text = ""
        fnPro.Text = Now.ToShortDateString
        dirPro.Text = ""
        telPro.Text = ""
        emailPro.Text = ""
        titPro.Text = ""
        sueldo.Text = ""
    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        If (bus.Text <> "Seleccione opción") Then
            Select Case bus.Text
                Case "Asignatura"
                    BDcadena = "SELECT sisaca.profesor.Nombre, sisaca.profesor.Cédula FROM sisaca.nota inner join sisaca.asignatura on sisaca.nota.asignatura_codigo_asi=sisaca.asignatura.codigo_asi inner join sisaca.profesor on sisaca.nota.profesor_codigo_pro=sisaca.profesor.codigo_pro where sisaca.asignatura.Nombre='" + buscar.Text + "';"
                Case Else
                    BDcadena = "SELECT sisaca.profesor.Nombre, sisaca.profesor.Cédula FROM sisaca.profesor WHERE " + bus.Text + "='" + buscar.Text + "';"
            End Select
        Else
            MsgBox("Seleccione un método de búsqueda")
        End If
        TablaDgv.DataSource = ObtenerTabla()
    End Sub
End Class