Public Class Menu

    Private Sub clientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clientesToolStripMenuItem.Click
       
    End Sub

    Private Sub bodegiasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bodegiasToolStripMenuItem.Click
       
    End Sub

    Private Sub conceptosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conceptosToolStripMenuItem.Click
        Dim h As New Collo
        h.Show()

    End Sub

    Private Sub proveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedoresToolStripMenuItem.Click
        Dim hIM As New Permisos
        hIM.Show()
    End Sub
End Class