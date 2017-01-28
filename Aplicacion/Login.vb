Public Class Login

    Private Sub validarcampos()
        If txtUsuario.Text = "" Then

            ErrorProvider1.SetError(txtUsuario, "debe ingresar un usuario")
            txtUsuario.Focus()
            Return
            ErrorProvider1.SetError(txtUsuario, "")

        ElseIf txtClave.Text = "" Then
            ErrorProvider1.SetError(txtClave, "debe ingresar una clave")
            txtClave.Focus()
            Return
            ErrorProvider1.SetError(txtClave, "")
        End If


    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        validarcampos()
        Dim PSS As New Menu()
        PSS.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        End
    End Sub
End Class
