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
    Private Sub Anillo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vistaNombre = "ANILLO" 'Nombre de la vista en mayuscula
        Dim isReadyOnly = False ' Siempre en false
        'Todos los inputs que se ocupan en readyOnly
     
        txtAltRFreq.ReadOnly =
        txtAltTXreq.ReadOnly =
        txtAnllat.ReadOnly =
        txtAnllong.ReadOnly =
        txtCdgoTRRSC.ReadOnly =
        txtCodOprdrANCLA.ReadOnly =
        txtEstDAnilo.ReadOnly =
        txtNomOprdrANCLA.ReadOnly =
        txtOprdrANCLA.ReadOnly =
        txtRdioBusq.ReadOnly =
        isReadyOnly


    End Sub
End Class