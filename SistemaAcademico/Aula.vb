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
        Else
            e.Handled = True
            MsgBox("Sólo Letras", MsgBoxStyle.Information)
        End If
    End Sub
End Class