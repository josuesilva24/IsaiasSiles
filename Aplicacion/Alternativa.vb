Public Class Alternativa

    Private Sub cancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelarButton.Click
        txtAlt.Clear()
        txtAltDestru.Clear()
        txtAltLat.Clear()
        txtAltLon.Clear()
        txtCalle.Clear()
        txtCanonMens.Clear()
        txtDistAccPreHespLoc.Clear()
        txtDistPuntConHespLoc.Clear()
        txtDocFaltnt.Clear()
        txtDoComplta.Clear()
        txtDocuDMilst1.Clear()
        txtDocuDMilst2.Clear()
        txtDocuDMilst3.Clear()
        txtDRSMont.Clear()
        txtEC1.Clear()
        txtEC2.Clear()
        txtEstadoSLA.Clear()
        txtEstatsAdq.Clear()
        txtNivlDapoEst.Clear()
        txtNum.Clear()
        txtObsAdq.Clear()
        txtObsvLgals.Clear()
        txtOpComMont.Clear()
        txtPagsAdltds.Clear()
        txtSupAlocar.Clear()
        txtValidMuniTORSC.Clear()
        txtValiEconOperMO.Clear()

        Me.Close()
    End Sub

    Private Sub limpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarButton.Click
        txtAlt.Clear()
        txtAltDestru.Clear()
        txtAltLat.Clear()
        txtAltLon.Clear()
        txtCalle.Clear()
        txtCanonMens.Clear()
        txtDistAccPreHespLoc.Clear()
        txtDistPuntConHespLoc.Clear()
        txtDocFaltnt.Clear()
        txtDoComplta.Clear()
        txtDocuDMilst1.Clear()
        txtDocuDMilst2.Clear()
        txtDocuDMilst3.Clear()
        txtDRSMont.Clear()
        txtEC1.Clear()
        txtEC2.Clear()
        txtEstadoSLA.Clear()
        txtEstatsAdq.Clear()
        txtNivlDapoEst.Clear()
        txtNum.Clear()
        txtObsAdq.Clear()
        txtObsvLgals.Clear()
        txtOpComMont.Clear()
        txtPagsAdltds.Clear()
        txtSupAlocar.Clear()
        txtValidMuniTORSC.Clear()
        txtValiEconOperMO.Clear()

    End Sub

    Private Sub Alternativa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim vistaNombre = "ALTERNATIVA" 'Nombre de la vista en mayuscula
        Dim isReadyOnly = False ' Siempre en false
        'Todos los inputs que se ocupan en readyOnly
        txtAlt.ReadOnly =
        txtCalle.ReadOnly =
        txtNum.ReadOnly =
        isReadyOnly

    End Sub
End Class