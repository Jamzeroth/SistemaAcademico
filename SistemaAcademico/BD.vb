﻿Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module BD
    Public BDcadena As String = "server=localhost; database=sisaca; user id=sisaca; password=sisaca2016"
    Private BDconexion As New MySqlConnection(BDcadena)
    ' Public cm As New MySqlCommand

    Public Function Conectar() As Boolean
        Try
            BDconexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return True
        End Try
        Return False
    End Function

    Public Sub Desconectar()
        BDconexion.Close()
    End Sub

    Public Function AsignarId(ByVal columna As String) As Integer
        Try
            Dim adaptabla As New MySql.Data.MySqlClient.MySqlDataAdapter(BDcadena, BDconexion)
            Dim initabla As New DataSet
            adaptabla.Fill(initabla, "ID")
            Dim resultabla As DataTable
            resultabla = initabla.Tables("ID")
            Dim tablafila As DataRow
            Dim cont As Integer = 0
            For Each tablafila In resultabla.Rows
                If (cont = CInt(tablafila.Item(columna))) Then
                    cont += 1
                Else
                    Return cont
                End If
            Next
            Return cont
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function ObtenerTabla() As DataTable
        Try
            Dim adaptabla As New MySql.Data.MySqlClient.MySqlDataAdapter(BDcadena, BDconexion)
            Dim initabla As New DataSet
            adaptabla.Fill(initabla, "Tabla")
            Dim resultabla As DataTable
            resultabla = initabla.Tables("Tabla")
            Return resultabla
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


    Public Function Almacenar_Datos()
        Try
            Dim Ejecuta As New MySql.Data.MySqlClient.MySqlCommand(BDcadena, BDconexion)
            Ejecuta.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Actualizar_Datos()
        Try
            Dim Ejecuta As New MySql.Data.MySqlClient.MySqlCommand(BDcadena, BDconexion)
            Ejecuta.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function LLenarComboBoxAsig(ByVal cb As ComboBox)
        Dim enunciado As MySqlCommand
        Dim respuesta As MySqlDataReader
        Try
            enunciado = New MySqlCommand("SELECT Nombre FROM sisaca.asignatura", BDconexion)
            respuesta = enunciado.ExecuteReader
            While respuesta.Read
                'cb.Text = (respuesta.Item("Nombre"))
                cb.Items.Add(respuesta.Item("Nombre"))
            End While
            respuesta.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
    Public Function LLenarComboBoxEst(ByVal cb As ComboBox)
        Dim enunciado As MySqlCommand
        Dim respuesta As MySqlDataReader
        Try
            enunciado = New MySqlCommand("select sisaca.estudiante.Nombre from sisaca.nota inner join sisaca.asignatura on sisaca.nota.asignatura_codigo_asi=sisaca.asignatura.codigo_asi inner join sisaca.estudiante where sisaca.nota.estudiante_codigo_est=sisaca.estudiante.codigo_est", BDconexion)
            respuesta = enunciado.ExecuteReader
            While respuesta.Read
                'cb.Text = (respuesta.Item("Nombre"))
                cb.Items.Add(respuesta.Item("Nombre"))
            End While
            respuesta.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


End Module
