Public Class Laboratorio
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Administrativo.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub nomLab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nomLab.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Sólo Letras y Números", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub capLab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles capLab.KeyPress
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

    Private Sub piLab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles piLab.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Sólo Numeros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub maqLab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles maqLab.KeyPress
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

    Private Sub bloLab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bloLab.KeyPress
        If Char.IsLetter(e.KeyChar) Then
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
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        BDcadena = "SELECT codigo_lab FROM sisaca.laboratorio;"
        Dim cod As Integer = AsignarId("codigo_lab")
        BDcadena = "INSERT INTO `sisaca`.`laboratorio` (`codigo_lab`, `Nombre`, `Bloque`, `Piso`, `Dimensiones`, `Capacidad`, `Tipo`, `N. Maquinas`,`colegio_codigo_col`) VALUES ('" + CStr(cod) + "', '" + nomLab.Text + "', '" + bloLab.Text + "', '" + CStr(piLab.Text) + "', '" + dimLab.Text + "', '" + CStr(capLab.Text) + "', '" + tipLab.Text + "','" + CStr(maqLab.Text) + "', '0');"
        Almacenar_Datos()
        Limpiar()
    End Sub

    Private Sub Limpiar()
        nomLab.Text = ""
        capLab.Text = ""
        bloLab.Text = ""
        piLab.Text = ""
        dimLab.Text = ""
        maqLab.Text = ""
        tipLab.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (bus.Text <> "Seleccione opción") Then
            BDcadena = "SELECT sisaca.laboratorio.Nombre, sisaca.laboratorio.Bloque, sisaca.laboratorio.Piso FROM sisaca.laboratorio WHERE " + bus.Text + "='" + buscar.Text + "';"
        Else
            MsgBox("Seleccione un método de búsqueda")
        End If
        TablaDgv.DataSource = ObtenerTabla()
    End Sub
End Class