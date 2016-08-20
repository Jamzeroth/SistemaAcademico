Public Class ConsultarNotas
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles buscar.KeyPress
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