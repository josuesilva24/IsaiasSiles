Imports BussinesLogic
Imports BussinesLogic.UsuarioBL
Public Class Login


    Private Function validarcampos() As Boolean
        If txtUsuario.Text = "" Then

            ErrorProvider1.SetError(txtUsuario, "debe ingresar un usuario")
            txtUsuario.Focus()
            ErrorProvider1.SetError(txtUsuario, "")
            Return False

        ElseIf txtClave.Text = "" Then
            ErrorProvider1.SetError(txtClave, "debe ingresar una clave")
            txtClave.Focus()
            ErrorProvider1.SetError(txtClave, "")
            Return False
        End If
        Return True

    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If validarcampos() Then
            Dim usuarioBl = New UsuarioBL()
            Dim session = usuarioBl.Login(txtUsuario.Text, txtClave.Text)
            If [String].IsNullOrEmpty(session.Error) = False Then
                MessageBox.Show(Nothing, session.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim PSS As New Menu()
                PSS.Show()
                Me.Hide()

            End If

        End If
    End Sub

End Class
