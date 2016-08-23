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
        'BDconexion.Open()
        'cmd.Parameters.AddWithValue("?tipo", ComboBox1.Text)
        'Dim da As MySqlDataReader
        'Dim query As String
        'Dim valor As Integer = 0
        'query = "SELECT * FROM sisaca.usuario"
        'Dim cmd As New MySqlCommand(query, BDconexion)
        'da = cmd.ExecuteReader
        'While da.Read
        'valor = valor + 1
        'End While
        'If valor = 1 Then
        If (ComboBox1.Text <> "Seleccione Tipo") Then
                Select Case ComboBox1.Text
                    Case "Administrador"
                        Me.Hide()
                        Administrativo.Show()
                    Case "Profesor"
                        Me.Hide()
                        Notas.Show()
                    Case "Estudiante"
                        Me.Hide()
                        ConsultarNotas.Show()
                End Select
            Else
                MsgBox("Seleccione un tipo de usuario", MsgBoxStyle.Information, "ERROR")
            End If
        'Else
        'MsgBox("Contraseña/Usuario INCORRECTOS, Vuelva a Ingresar", MsgBoxStyle.Exclamation, "ERROR")
        'End If

        'da.Fill(dt)
        ' Dim row As DataRow = dt.Rows(1)
        'valor = Convert.ToInt32(row("Tipo"))
        'If valor = 1 Then
        'Me.Hide()
        'Administrativo.Show()
        'ElseIf valor = 2 Then
        ' Me.Hide()
        'Notas.Show()
        'Else
        'Me.Hide()
        'ConsultarNotas.Show()
        'End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login()
        'BDcadena = "SELECT * FROM sisaca.usuario WHERE Usuario = '" + user.Text + "' and Contrasenia = '" + contraseña.Text + "'"

        '        If (ComboBox1.Text <> "Seleccione Tipo") Then
        '       Select Case ComboBox1.Text
        '      Case "Administrador"
        '     Me.Hide()
        '    Administrativo.Show()
        '   Case "Profesor"
        '  Me.Hide()
        ' Notas.Show()
        'Case "Estudiante"
        'Me.Hide()
        'ConsultarNotas.Show()
        'Case Else
        'MsgBox("Contraseña/Usuario INCORRECTOS, Vuelva a Ingresar", MsgBoxStyle.Exclamation, "ERROR")
        'End Select
        'Else
        'MsgBox("Seleccione un tipo de usuario", MsgBoxStyle.Information, "ERROR")
        'End If



        'If (user.Text = "hola") And (contraseña.Text = "123") Then
        'Me.Hide()
        'Administrativo.Show()
        'ElseIf (user.Text = "Alumno") And (contraseña.Text = "Alumno1") Then
        'Me.Hide()
        'ConsultarNotas.Show()
        'ElseIf (user.Text = "Profesor") And (contraseña.Text = "Profesor1") Then
        'Me.Hide()
        ' Notas.Show()
        'Else
        'MsgBox("Contraseña/Usuario INCORRECTOS, Vuelva a Ingresar", MsgBoxStyle.Exclamation, "ERROR")
        'End If
        user.Text = ""
        contraseña.Text = ""
    End Sub


End Class