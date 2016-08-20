Public Class Estudiante
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Administrativo.Show()
    End Sub

    Private Sub CiEst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CiEst.KeyPress
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

    Private Sub nomEst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nomEst.KeyPress
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

    Private Sub telEst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telEst.KeyPress
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

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        BDcadena = "SELECT codigo_est FROM sisaca.estudiante;"
        Dim cod As Integer = AsignarId("codigo_est")
        BDcadena = "INSERT INTO `sisaca`.`estudiante` (`codigo_est`, `Nombre`, `Cédula`, `F. Nacimiento`, `Dirección`, `Teléfono`, `Email`, `Especialidad`, `estado`) VALUES ('" + CStr(cod) + "', '" + nomEst.Text + "', '" + CiEst.Text + "', '" + CStr(fnEst.Text) + "', '" + dirEst.Text + "', '" + telEst.Text + "', '" + emailEst.Text + "', '" + carrera.Text + "', '1');"
        Almacenar_Datos()
        Limpiar()
    End Sub

    Private Sub ConsultarBtn_Click(sender As Object, e As EventArgs) Handles ConsultarBtn.Click
        If (bus.Text <> "Seleccione opción") Then
            Select Case bus.Text
                Case "Asignatura"
                    BDcadena = "SELECT sisaca.estudiante.Nombre FROM sisaca.nota inner join sisaca.asignatura on sisaca.nota.asignatura_codigo_asi=sisaca.asignatura.codigo_asi inner join sisaca.estudiante on sisaca.nota.estudiante_codigo_est=sisaca.estudiante.codigo_est where sisaca.asignatura.Nombre='" + buscar.Text + "';"
                Case Else
                    BDcadena = "SELECT " + bus.Text + " FROM sisaca.estudiante WHERE " + bus.Text + "='" + buscar.Text + "';"
            End Select
        Else
            MsgBox("Seleccione un método de búsqueda")
        End If
        TablaDgv.DataSource = ObtenerTabla()
    End Sub

    Private Sub Limpiar()
        CiEst.Text = ""
        nomEst.Text = ""
        fnEst.Text = Now.ToShortDateString
        dirEst.Text = ""
        telEst.Text = ""
        emailEst.Text = ""
        carrera.Text = "Seleccione especialidad"
    End Sub
End Class