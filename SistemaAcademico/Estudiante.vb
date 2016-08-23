'Imports Microsoft.Office.Interop.Word
'Imports System.IO
'Imports Microsoft.Office.Interop
Public Class Estudiante
    'Dim MSWord As New Word.Application
    ' Dim Documento As Word.Document
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
    Private Sub Estudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        BDcadena = "select estudiante.Nombre,estudiante.Cédula,estudiante.Dirección,estudiante.Teléfono,estudiante.Email,estudiante.Especialidad from sisaca.estudiante;"
        TablaDgv.DataSource = ObtenerTabla()
    End Sub
    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        BDcadena = "Select codigo_est FROM sisaca.estudiante;"
        Dim cod As Integer = AsignarId("codigo_est")
        BDcadena = "INSERT INTO `sisaca`.`estudiante` (`codigo_est`, `Nombre`, `Cédula`, `F. Nacimiento`, `Dirección`, `Teléfono`, `Email`, `Especialidad`, `estado`) VALUES ('" + CStr(cod) + "', '" + nomEst.Text + "', '" + CiEst.Text + "', '" + CStr(fnEst.Text) + "', '" + dirEst.Text + "', '" + telEst.Text + "', '" + emailEst.Text + "', '" + carrera.Text + "', '1');"
        Almacenar_Datos()
        Limpiar()
    End Sub

    Private Sub ConsultarBtn_Click(sender As Object, e As EventArgs) Handles ConsultarBtn.Click
        If (bus.Text <> "Seleccione opción") Then
            Select Case bus.Text
                Case "Asignatura"
                    BDcadena = "SELECT sisaca.estudiante.Nombre, sisaca.estudiante.Cédula FROM sisaca.nota inner join sisaca.asignatura on sisaca.nota.asignatura_codigo_asi=sisaca.asignatura.codigo_asi inner join sisaca.estudiante on sisaca.nota.estudiante_codigo_est=sisaca.estudiante.codigo_est where sisaca.asignatura.Nombre='" + buscar.Text + "';"
                Case Else
                    BDcadena = "SELECT sisaca.estudiante.Nombre, sisaca.estudiante.Cédula FROM sisaca.estudiante WHERE " + bus.Text + "='" + buscar.Text + "';"
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As Integer = CInt(TablaDgv.SelectedCells(0).RowIndex) 'filas
        Dim x As Integer = CInt(TablaDgv.SelectedCells(0).ColumnIndex) 'columnas
        Dim atributo As String = ""
        Select Case (x)
            Case 0
                atributo = "Nombre"
            Case 1
                atributo = "F. Nacimiento"
            Case 2
                atributo = "Dirección"
            Case 3
                atributo = "Teléfono"
            Case 4
                atributo = "Email"
            Case 5
                atributo = "Especialidad"
        End Select
        Dim nuevo As String = InputBox("Ingrese un nuevo dato para: " + atributo, "Modificar", CStr(TablaDgv.SelectedCells(0).Value))
        BDcadena = "UPDATE `sisaca`.`estudiante` SET `" + atributo + "`='" + nuevo + "' WHERE `codigo_est`='" + CStr(y) + "';"
        Actualizar_Datos()
        MsgBox("Cambios Realizados con Éxito", MsgBoxStyle.Information)
        TablaDgv.DataSource = ObtenerTabla()
    End Sub

    ' Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    MsgBox("El doc se guardará en: C:\Users\KatyPaty\Documents\GitHub\SistemaAcademico\PlantillaEstudiantesSalidadocx")
    '
    '   FileCopy("C:\Users\KatyPaty\Documents\GitHub\SistemaAcademico\PlantillaEstudiantesSalidadocx")
    '  Documento = MSWord.Documents.Open("C:\Users\KatyPaty\Documents\GitHub\SistemaAcademico\PlantillaEstudiantesSalidadocx")
    '
    '   Documento.Bookmarks.Item("Cédula").Range.Text = txtnombre.Text
    '  Documento.Bookmarks.Item("Nombres y Apellidos").Range.Text = txtapellido.Text
    ' Documento.Bookmarks.Item("F.Nacimiento").Range.Text = txtnombre.Text
    'Documento.Bookmarks.Item("Dirección").Range.Text = txtapellido.Text
    '  Documento.Bookmarks.Item("Teléfono").Range.Text = txtdireccion.Text
    ' Documento.Bookmarks.Item("Email").Range.Text = txtcorreo.Text()
    'Documento.Bookmarks.Item("telefono").Range.Text = txttelefono.Text
    '        Documento.Bookmarks.Item("Dirección").Range.Text = txtdireccion.Text
    '       Documento.Bookmarks.Item("correo").Range.Text = txtcorreo.Text()
    '      Documento.Bookmarks.Item("telefono").Range.Text = txttelefono.Text
    ' End Sub
End Class