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
End Class