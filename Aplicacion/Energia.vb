Public Class Energia

    Private Sub limpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarButton.Click
        txtAcumAntTrrsc.Clear()
        txtAcumUltMdcnTrrsc.Clear()
        txtDirDlSumElc.Clear()
        txtFchaPdSumElcPrs.Clear()
        txtProvDgstnDsum.Clear()
        txtTarfa.Clear()
        txtTitDlSumElc.Clear()
    End Sub

    Private Sub cancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelarButton.Click
        txtAcumAntTrrsc.Clear()
        txtAcumUltMdcnTrrsc.Clear()
        txtDirDlSumElc.Clear()
        txtFchaPdSumElcPrs.Clear()
        txtProvDgstnDsum.Clear()
        txtTarfa.Clear()
        txtTitDlSumElc.Clear()
        Me.Close()
    End Sub
End Class