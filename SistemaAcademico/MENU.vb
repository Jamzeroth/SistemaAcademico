Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports MySql.Data.Types

Public Class uno
    Public BDcadena As String = "server=localhost; database=sisaca; user id=sisaca; password=sisaca2016"
    Private BDconexion As New MySqlConnection(BDcadena)
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
    Public Function Login()
        Dim cmd As New MySqlCommand("SELECT *FROM sisaca.usuario", BDconexion)
        cmd.Parameters.AddWithValue("?tipo", TextBox1.Text)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        Dim valor As Integer

        BDconexion.Open()
        da.Fill(dt)
        Dim row As DataRow = dt.Rows(1)
        valor = Convert.ToInt32(row("Tipo"))
        If valor = 1 Then
            Me.Hide()
            Administrativo.Show()
        ElseIf valor = 2 Then
            Me.Hide()
            Notas.Show()
        Else
            Me.Hide()
            ConsultarNotas.Show()
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New MySqlCommand("SELECT sisaca.estudiante.Tipo FROM sisaca.usuario WHERE usuario = '" & user.Text & "' and contrasenia = '" & contraseña.Text & "'")
        Login()

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

        'If (user.Text = "hola") And (contraseña.Text = "123") Then
        'Me.Hide()
        'Administrativo.Show()
        'ElseIf (user.Text = "Alumno") And (contraseña.Text = "Alumno1") Then
        ' Me.Hide()
        'ConsultarNotas.Show()
        'ElseIf (user.Text = "Profesor") And (contraseña.Text = "Profesor1") Then
        ' Me.Hide()
        'Notas.Show()
        'Else
        'MsgBox("Contraseña/Usuario INCORRECTOS, Vuelva a Ingresar", MsgBoxStyle.Exclamation, "ERROR")
        'End If
        user.Text = ""
        contraseña.Text = ""
    End Sub
End Class