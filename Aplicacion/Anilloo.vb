Public Class Anilloo

    Private Sub limpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarButton.Click
        txtAltRFreq.Clear()
        txtAltTXreq.Clear()
        txtAnllat.Clear()
        txtAnllong.Clear()
        txtCdgoTRRSC.Clear()
        txtCodOprdrANCLA.Clear()
        txtEstDAnilo.Clear()
        txtNomOprdrANCLA.Clear()
        txtOprdrANCLA.Clear()
        txtRdioBusq.Clear()

    End Sub

    Private Sub cancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelarButton.Click
        txtAltRFreq.Clear()
        txtAltTXreq.Clear()
        txtAnllat.Clear()
        txtAnllong.Clear()
        txtCdgoTRRSC.Clear()
        txtCodOprdrANCLA.Clear()
        txtEstDAnilo.Clear()
        txtNomOprdrANCLA.Clear()
        txtOprdrANCLA.Clear()
        txtRdioBusq.Clear()
        Me.Close()
    End Sub
End Class