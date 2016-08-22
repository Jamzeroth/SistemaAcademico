Imports MySql.Data.MySqlClient
Public Class uno
    Private Sub MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next
        If Conectar() Then MsgBox("No se Puede Acceder a la Base de Datos")
        BDcadena = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BDcadena = "SELECT sisaca.estudiante.Tipo FROM sisaca.usuario WHERE usuario = '" & user.Text & "' and contrasenia = '" & contraseña.Text & "'"

        'dr = cm.ExecuteReader

        'Login()
        'If dr.HasRows = True Then
        'While dr.Read
        'valor = dr.GetValue(0)
        'MsgBox(valor)
        'End While
        'dr.NextResult()
        'Select Case (valor)
        'Case 1
        'Me.Hide()
        'Administrativo.Show()
        'Case 2
        'Me.Hide()
        'ConsultarNotas.Show()
        'Case 3
        'Me.Hide()
        'Notas.Show()
        'End Select
        'Else

        'MsgBox("Contraseña/Usuario INCORRECTOS, Vuelva a Ingresar", MsgBoxStyle.Exclamation, "ERROR")
        'End If

        If (user.Text = "hola") And (contraseña.Text = "123") Then
            Me.Hide()
            Administrativo.Show()
        ElseIf (user.Text = "Alumno") And (contraseña.Text = "Alumno1") Then
            Me.Hide()
            ConsultarNotas.Show()
        ElseIf (user.Text = "Profesor") And (contraseña.Text = "Profesor1") Then
            Me.Hide()
            Notas.Show()
        Else
            MsgBox("Contraseña/Usuario INCORRECTOS, Vuelva a Ingresar", MsgBoxStyle.Exclamation, "ERROR")
        End If
        user.Text = ""
        contraseña.Text = ""
    End Sub
End Class