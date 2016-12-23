<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.NombresUsuariotoolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbClientes = New System.Windows.Forms.ToolStripButton()
        Me.tsbProveedores = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.archivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bodegiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.conceptosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.proveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tiposDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.usuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cambioDeClaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.salirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.inventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ventasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.comprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.salidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.devolucionClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.devoluciónAProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.listadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.productosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.clientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.proveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ayudasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.acercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ayudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusStrip1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NombresUsuariotoolStripStatusLabel})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 322)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(785, 22)
        Me.statusStrip1.TabIndex = 8
        Me.statusStrip1.Text = "statusStrip1"
        '
        'NombresUsuariotoolStripStatusLabel
        '
        Me.NombresUsuariotoolStripStatusLabel.Name = "NombresUsuariotoolStripStatusLabel"
        Me.NombresUsuariotoolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbClientes, Me.tsbProveedores, Me.toolStripButton2})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(785, 25)
        Me.toolStrip1.TabIndex = 7
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tsbClientes
        '
        Me.tsbClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbClientes.Image = CType(resources.GetObject("tsbClientes.Image"), System.Drawing.Image)
        Me.tsbClientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClientes.Name = "tsbClientes"
        Me.tsbClientes.Size = New System.Drawing.Size(23, 22)
        Me.tsbClientes.Text = "toolStripButton1"
        Me.tsbClientes.ToolTipText = "Acceso a clientes"
        '
        'tsbProveedores
        '
        Me.tsbProveedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbProveedores.Image = CType(resources.GetObject("tsbProveedores.Image"), System.Drawing.Image)
        Me.tsbProveedores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProveedores.Name = "tsbProveedores"
        Me.tsbProveedores.Size = New System.Drawing.Size(23, 22)
        Me.tsbProveedores.Text = "toolStripButton2"
        Me.tsbProveedores.ToolTipText = "Acceso a proveedores"
        '
        'toolStripButton2
        '
        Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton2.Text = "toolStripButton2"
        Me.toolStripButton2.ToolTipText = "Acceso a ventas"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.archivoToolStripMenuItem, Me.reportesToolStripMenuItem, Me.ayudasToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(785, 24)
        Me.menuStrip1.TabIndex = 6
        Me.menuStrip1.Text = "menuStrip1"
        '
        'archivoToolStripMenuItem
        '
        Me.archivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bodegiasToolStripMenuItem, Me.clientesToolStripMenuItem, Me.conceptosToolStripMenuItem, Me.proveedoresToolStripMenuItem, Me.tiposDeDocumentosToolStripMenuItem, Me.usuariosToolStripMenuItem, Me.toolStripMenuItem1, Me.cambioDeClaveToolStripMenuItem1, Me.toolStripMenuItem2, Me.salirToolStripMenuItem})
        Me.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem"
        Me.archivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.archivoToolStripMenuItem.Text = "&Archivo"
        '
        'bodegiasToolStripMenuItem
        '
        Me.bodegiasToolStripMenuItem.Image = CType(resources.GetObject("bodegiasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.bodegiasToolStripMenuItem.Name = "bodegiasToolStripMenuItem"
        Me.bodegiasToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.bodegiasToolStripMenuItem.Text = "&Anillo"
        '
        'clientesToolStripMenuItem
        '
        Me.clientesToolStripMenuItem.Image = CType(resources.GetObject("clientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem"
        Me.clientesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.clientesToolStripMenuItem.Text = "&Alternativa"
        '
        'conceptosToolStripMenuItem
        '
        Me.conceptosToolStripMenuItem.Image = CType(resources.GetObject("conceptosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.conceptosToolStripMenuItem.Name = "conceptosToolStripMenuItem"
        Me.conceptosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.conceptosToolStripMenuItem.Text = "&Collo"
        '
        'proveedoresToolStripMenuItem
        '
        Me.proveedoresToolStripMenuItem.Image = CType(resources.GetObject("proveedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem"
        Me.proveedoresToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.proveedoresToolStripMenuItem.Text = "&Permisos"
        Me.proveedoresToolStripMenuItem.Visible = False
        '
        'tiposDeDocumentosToolStripMenuItem
        '
        Me.tiposDeDocumentosToolStripMenuItem.Image = CType(resources.GetObject("tiposDeDocumentosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.tiposDeDocumentosToolStripMenuItem.Name = "tiposDeDocumentosToolStripMenuItem"
        Me.tiposDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.tiposDeDocumentosToolStripMenuItem.Text = "&Sitios"
        '
        'usuariosToolStripMenuItem
        '
        Me.usuariosToolStripMenuItem.Image = CType(resources.GetObject("usuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem"
        Me.usuariosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.usuariosToolStripMenuItem.Text = "&Energia"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(171, 6)
        '
        'cambioDeClaveToolStripMenuItem1
        '
        Me.cambioDeClaveToolStripMenuItem1.Image = CType(resources.GetObject("cambioDeClaveToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.cambioDeClaveToolStripMenuItem1.Name = "cambioDeClaveToolStripMenuItem1"
        Me.cambioDeClaveToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.cambioDeClaveToolStripMenuItem1.Text = "Ca&mbio de clave"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(171, 6)
        '
        'salirToolStripMenuItem
        '
        Me.salirToolStripMenuItem.Image = CType(resources.GetObject("salirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.salirToolStripMenuItem.Name = "salirToolStripMenuItem"
        Me.salirToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.salirToolStripMenuItem.Text = "&Salir"
        '
        'reportesToolStripMenuItem
        '
        Me.reportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inventarioToolStripMenuItem, Me.ventasToolStripMenuItem1, Me.comprasToolStripMenuItem1, Me.salidaToolStripMenuItem, Me.devolucionClienteToolStripMenuItem, Me.devoluciónAProveedoresToolStripMenuItem, Me.toolStripSeparator1, Me.listadosToolStripMenuItem, Me.toolStripSeparator2})
        Me.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem"
        Me.reportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.reportesToolStripMenuItem.Text = "&Reportes"
        '
        'inventarioToolStripMenuItem
        '
        Me.inventarioToolStripMenuItem.Image = CType(resources.GetObject("inventarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem"
        Me.inventarioToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.inventarioToolStripMenuItem.Text = "&I"
        '
        'ventasToolStripMenuItem1
        '
        Me.ventasToolStripMenuItem1.Image = CType(resources.GetObject("ventasToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1"
        Me.ventasToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.ventasToolStripMenuItem1.Text = "&l"
        '
        'comprasToolStripMenuItem1
        '
        Me.comprasToolStripMenuItem1.Image = CType(resources.GetObject("comprasToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1"
        Me.comprasToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.comprasToolStripMenuItem1.Text = "&p"
        '
        'salidaToolStripMenuItem
        '
        Me.salidaToolStripMenuItem.Image = CType(resources.GetObject("salidaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem"
        Me.salidaToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.salidaToolStripMenuItem.Text = "&f"
        '
        'devolucionClienteToolStripMenuItem
        '
        Me.devolucionClienteToolStripMenuItem.Image = CType(resources.GetObject("devolucionClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.devolucionClienteToolStripMenuItem.Name = "devolucionClienteToolStripMenuItem"
        Me.devolucionClienteToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.devolucionClienteToolStripMenuItem.Text = "l"
        '
        'devoluciónAProveedoresToolStripMenuItem
        '
        Me.devoluciónAProveedoresToolStripMenuItem.Image = CType(resources.GetObject("devoluciónAProveedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.devoluciónAProveedoresToolStripMenuItem.Name = "devoluciónAProveedoresToolStripMenuItem"
        Me.devoluciónAProveedoresToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.devoluciónAProveedoresToolStripMenuItem.Text = "s"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(114, 6)
        '
        'listadosToolStripMenuItem
        '
        Me.listadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.productosToolStripMenuItem2, Me.clientesToolStripMenuItem1, Me.proveedoresToolStripMenuItem1})
        Me.listadosToolStripMenuItem.Image = CType(resources.GetObject("listadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem"
        Me.listadosToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.listadosToolStripMenuItem.Text = "&Listados"
        '
        'productosToolStripMenuItem2
        '
        Me.productosToolStripMenuItem2.Image = CType(resources.GetObject("productosToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.productosToolStripMenuItem2.Name = "productosToolStripMenuItem2"
        Me.productosToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.productosToolStripMenuItem2.Text = "&Productos"
        '
        'clientesToolStripMenuItem1
        '
        Me.clientesToolStripMenuItem1.Image = CType(resources.GetObject("clientesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1"
        Me.clientesToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.clientesToolStripMenuItem1.Text = "&Clientes"
        '
        'proveedoresToolStripMenuItem1
        '
        Me.proveedoresToolStripMenuItem1.Image = CType(resources.GetObject("proveedoresToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1"
        Me.proveedoresToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.proveedoresToolStripMenuItem1.Text = "P&roveedores"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(114, 6)
        '
        'ayudasToolStripMenuItem
        '
        Me.ayudasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.acercaDeToolStripMenuItem, Me.ayudaToolStripMenuItem})
        Me.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem"
        Me.ayudasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ayudasToolStripMenuItem.Text = "A&yuda"
        '
        'acercaDeToolStripMenuItem
        '
        Me.acercaDeToolStripMenuItem.Image = CType(resources.GetObject("acercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem"
        Me.acercaDeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.acercaDeToolStripMenuItem.Text = "A&cerca de"
        '
        'ayudaToolStripMenuItem
        '
        Me.ayudaToolStripMenuItem.Image = CType(resources.GetObject("ayudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem"
        Me.ayudaToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ayudaToolStripMenuItem.Text = "A&yuda"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 344)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Comercial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents NombresUsuariotoolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsbClientes As System.Windows.Forms.ToolStripButton
    Private WithEvents tsbProveedores As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton2 As System.Windows.Forms.ToolStripButton
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents archivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents bodegiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents clientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents conceptosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents proveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tiposDeDocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents usuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cambioDeClaveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents salirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents reportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents inventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ventasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents comprasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents salidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents devolucionClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents devoluciónAProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents listadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents productosToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents clientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents proveedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ayudasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents acercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ayudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
