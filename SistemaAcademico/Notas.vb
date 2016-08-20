Public Class Notas
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        uno.Show()
    End Sub

    Private Sub n1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles n1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Sólo Numeros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub n2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles n2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Sólo Numeros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub n3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles n3.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Sólo Numeros", MsgBoxStyle.Information)
        End If
    End Sub
End Class