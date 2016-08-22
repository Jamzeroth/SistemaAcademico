Public Class Aula
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Administrativo.Show()
    End Sub

    Private Sub Caula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Caula.KeyPress
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

    Private Sub pisoAu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pisoAu.KeyPress
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

    Private Sub mesasAu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mesasAu.KeyPress
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

    Private Sub siAu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles siAu.KeyPress
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

    Private Sub nomAu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nomAu.KeyPress
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
            MsgBox("Sólo Letras y Números", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub bloAu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bloAu.KeyPress
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


    Private Sub Limpiar()
        nomAu.Text = ""
        Caula.Text = ""
        bloAu.Text = ""
        pisoAu.Text = ""
        dimAu.Text = ""
        mesasAu.Text = ""
        siAu.Text = ""
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        BDcadena = "SELECT codigo_aula FROM sisaca.aula;"
        Dim cod As Integer = AsignarId("codigo_aula")
        BDcadena = "INSERT INTO `sisaca`.`aula` (`codigo_aula`, `Nombre`, `Bloque`, `Piso`, `Dimensiones`, `Capacidad`, `N. de Mesas`, `N. de Sillas`,`colegio_codigo_col`) VALUES ('" + CStr(cod) + "', '" + nomAu.Text + "', '" + bloAu.Text + "', '" + CStr(pisoAu.Text) + "', '" + dimAu.Text + "', '" + CStr(Caula.Text) + "', '" + CStr(mesasAu.Text) + "', '" + CStr(siAu.Text) + "', '0');"
        Almacenar_Datos()
        Limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (bus.Text <> "Seleccione opción") Then
            BDcadena = "SELECT sisaca.aula.Nombre, sisaca.aula.Bloque, sisaca.aula.Piso FROM sisaca.aula WHERE " + bus.Text + "='" + buscar.Text + "';"
        Else
            MsgBox("Seleccione un método de búsqueda")
        End If
        TablaDgv.DataSource = ObtenerTabla()
    End Sub

End Class