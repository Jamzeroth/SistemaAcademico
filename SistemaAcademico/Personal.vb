Public Class Personal
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Administrativo.Show()
    End Sub

    Private Sub nomPer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nomPer.KeyPress
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

    Private Sub carPer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles carPer.KeyPress
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

    Private Sub CiPer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CiPer.KeyPress
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

    Private Sub telPer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telPer.KeyPress
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

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        BDcadena = "SELECT codigo_adm FROM sisaca.padministrativo;"
        Dim cod As Integer = AsignarId("codigo_adm")
        BDcadena = "INSERT INTO `sisaca`.`padministrativo` (`codigo_adm`, `Nombre`, `Cédula`, `F. Nacimiento`, `Dirección`, `Teléfono`, `Email`, `Cargo`,`estado`,`colegio_codigo_col`) VALUES ('" + CStr(cod) + "', '" + nomPer.Text + "', '" + CiPer.Text + "', '" + CStr(fnPer.Text) + "', '" + dirPer.Text + "', '" + telPer.Text + "', '" + emailPer.Text + "', '" + carPer.Text + "','1','0');"
        Almacenar_Datos()
        Limpiar()
    End Sub
    Private Sub Limpiar()
        CiPer.Text = ""
        nomPer.Text = ""
        fnPer.Text = Now.ToShortDateString
        dirPer.Text = ""
        telPer.Text = ""
        emailPer.Text = ""
        carPer.Text = ""
    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        If (bus.Text <> "Seleccione opción") Then
            BDcadena = "SELECT sisaca.padministrativo.Nombre, sisaca.padministrativo.Cédula FROM sisaca.padministrativo WHERE " + bus.Text + "='" + buscar.Text + "';"
        Else
            MsgBox("Seleccione un método de búsqueda")
        End If
        TablaDgv.DataSource = ObtenerTabla()
    End Sub

    Private Sub Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        BDcadena = "select padministrativo.Nombre,padministrativo.Cédula,padministrativo.Dirección,padministrativo.Teléfono,padministrativo.Email,padministrativo.Cargo,padministrativo.estado from sisaca.padministrativo;"
        TablaDgv.DataSource = ObtenerTabla()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As Integer = CInt(TablaDgv.SelectedCells(0).RowIndex) 'filas
        Dim x As Integer = CInt(TablaDgv.SelectedCells(0).ColumnIndex) 'columnas
        Dim atributo As String = ""
        Select Case (x)
            Case 0
                atributo = "Nombre"
            Case 1
                atributo = "Dirección"
            Case 2
                atributo = "Teléfono"
            Case 3
                atributo = "Email"
            Case 4
                atributo = "Cargp"
            Case 5
                atributo = "estado"
        End Select
        Dim nuevo As String = InputBox("Ingrese un nuevo dato para: " + atributo, "Modificar", CStr(TablaDgv.SelectedCells(0).Value))
        BDcadena = "UPDATE `sisaca`.`padministrativo` SET `" + atributo + "`='" + nuevo + "' WHERE `codigo_adm`='" + CStr(y) + "';"
        Actualizar_Datos()
        MsgBox("Cambios Realizados con Éxito", MsgBoxStyle.Information)
    End Sub
End Class