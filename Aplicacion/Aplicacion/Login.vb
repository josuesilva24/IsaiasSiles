Public Class Login

  

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim frm As New Menu()
        frm.Show()
        Me.Hide()
    End Sub
End Class
