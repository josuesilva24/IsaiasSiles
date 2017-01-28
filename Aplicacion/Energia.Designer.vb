<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Energia
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Energia))
        Me.limpiarButton = New System.Windows.Forms.Button()
        Me.borrarButton = New System.Windows.Forms.Button()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.guardarButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTarfa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFchaPdSumElcPrs = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTienCntdr = New System.Windows.Forms.ComboBox()
        Me.txtDirDlSumElc = New System.Windows.Forms.TextBox()
        Me.txtAcumAntTrrsc = New System.Windows.Forms.TextBox()
        Me.dtpFchaMdcnAntTrrsc = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTitDlSumElc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.cmbCodTrrsc = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.cmbAltn = New System.Windows.Forms.ComboBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.cmbClle = New System.Windows.Forms.ComboBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.cmbNmro = New System.Windows.Forms.ComboBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.cmbEnClle1 = New System.Windows.Forms.ComboBox()
        Me.cmbEnClle2 = New System.Windows.Forms.ComboBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.cmbPrvncia = New System.Windows.Forms.ComboBox()
        Me.txtAcumUltMdcnTrrsc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFchDsumElecXPrs = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProvDgstnDsum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'limpiarButton
        '
        Me.limpiarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.limpiarButton.BackColor = System.Drawing.Color.White
        Me.limpiarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.limpiarButton.Image = CType(resources.GetObject("limpiarButton.Image"), System.Drawing.Image)
        Me.limpiarButton.Location = New System.Drawing.Point(741, 159)
        Me.limpiarButton.Name = "limpiarButton"
        Me.limpiarButton.Size = New System.Drawing.Size(63, 65)
        Me.limpiarButton.TabIndex = 220
        Me.limpiarButton.Text = "Limpiar"
        Me.limpiarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.limpiarButton.UseVisualStyleBackColor = False
        '
        'borrarButton
        '
        Me.borrarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.borrarButton.BackColor = System.Drawing.Color.White
        Me.borrarButton.Image = CType(resources.GetObject("borrarButton.Image"), System.Drawing.Image)
        Me.borrarButton.Location = New System.Drawing.Point(740, 233)
        Me.borrarButton.Name = "borrarButton"
        Me.borrarButton.Size = New System.Drawing.Size(64, 65)
        Me.borrarButton.TabIndex = 219
        Me.borrarButton.Text = "Borrar"
        Me.borrarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.borrarButton.UseVisualStyleBackColor = False
        '
        'cancelarButton
        '
        Me.cancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelarButton.BackColor = System.Drawing.Color.White
        Me.cancelarButton.Image = CType(resources.GetObject("cancelarButton.Image"), System.Drawing.Image)
        Me.cancelarButton.Location = New System.Drawing.Point(739, 307)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(65, 65)
        Me.cancelarButton.TabIndex = 218
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cancelarButton.UseVisualStyleBackColor = False
        '
        'guardarButton
        '
        Me.guardarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guardarButton.BackColor = System.Drawing.Color.White
        Me.guardarButton.Image = CType(resources.GetObject("guardarButton.Image"), System.Drawing.Image)
        Me.guardarButton.Location = New System.Drawing.Point(741, 83)
        Me.guardarButton.Name = "guardarButton"
        Me.guardarButton.Size = New System.Drawing.Size(63, 65)
        Me.guardarButton.TabIndex = 217
        Me.guardarButton.Text = "Guardar"
        Me.guardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.guardarButton.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtTarfa)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 318)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(421, 83)
        Me.GroupBox4.TabIndex = 216
        Me.GroupBox4.TabStop = False
        '
        'txtTarfa
        '
        Me.txtTarfa.Location = New System.Drawing.Point(109, 41)
        Me.txtTarfa.Name = "txtTarfa"
        Me.txtTarfa.Size = New System.Drawing.Size(199, 20)
        Me.txtTarfa.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Tárifa"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtFchaPdSumElcPrs)
        Me.GroupBox3.Location = New System.Drawing.Point(454, 262)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 139)
        Me.GroupBox3.TabIndex = 215
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Prestadora de Suministro Eléctrico"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(26, 32)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(225, 20)
        Me.TextBox3.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Tipo de Suministro Eléctrico"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(26, 71)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(225, 20)
        Me.TextBox4.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Fecha Pedido de Suministro Eléctrico a la Prestadora"
        '
        'txtFchaPdSumElcPrs
        '
        Me.txtFchaPdSumElcPrs.Location = New System.Drawing.Point(26, 110)
        Me.txtFchaPdSumElcPrs.Name = "txtFchaPdSumElcPrs"
        Me.txtFchaPdSumElcPrs.Size = New System.Drawing.Size(225, 20)
        Me.txtFchaPdSumElcPrs.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbTienCntdr)
        Me.GroupBox2.Controls.Add(Me.txtDirDlSumElc)
        Me.GroupBox2.Controls.Add(Me.txtAcumAntTrrsc)
        Me.GroupBox2.Controls.Add(Me.dtpFchaMdcnAntTrrsc)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTitDlSumElc)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(484, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 216)
        Me.GroupBox2.TabIndex = 214
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Dirección del Suministro Eléctrico"
        '
        'cmbTienCntdr
        '
        Me.cmbTienCntdr.FormattingEnabled = True
        Me.cmbTienCntdr.Location = New System.Drawing.Point(35, 108)
        Me.cmbTienCntdr.Name = "cmbTienCntdr"
        Me.cmbTienCntdr.Size = New System.Drawing.Size(167, 21)
        Me.cmbTienCntdr.TabIndex = 46
        '
        'txtDirDlSumElc
        '
        Me.txtDirDlSumElc.Location = New System.Drawing.Point(35, 31)
        Me.txtDirDlSumElc.Name = "txtDirDlSumElc"
        Me.txtDirDlSumElc.Size = New System.Drawing.Size(167, 20)
        Me.txtDirDlSumElc.TabIndex = 42
        '
        'txtAcumAntTrrsc
        '
        Me.txtAcumAntTrrsc.Location = New System.Drawing.Point(34, 144)
        Me.txtAcumAntTrrsc.Name = "txtAcumAntTrrsc"
        Me.txtAcumAntTrrsc.Size = New System.Drawing.Size(167, 20)
        Me.txtAcumAntTrrsc.TabIndex = 48
        '
        'dtpFchaMdcnAntTrrsc
        '
        Me.dtpFchaMdcnAntTrrsc.Location = New System.Drawing.Point(24, 183)
        Me.dtpFchaMdcnAntTrrsc.Name = "dtpFchaMdcnAntTrrsc"
        Me.dtpFchaMdcnAntTrrsc.Size = New System.Drawing.Size(197, 20)
        Me.dtpFchaMdcnAntTrrsc.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Titular del Suministro Eléctrico"
        '
        'txtTitDlSumElc
        '
        Me.txtTitDlSumElc.Location = New System.Drawing.Point(35, 70)
        Me.txtTitDlSumElc.Name = "txtTitDlSumElc"
        Me.txtTitDlSumElc.Size = New System.Drawing.Size(167, 20)
        Me.txtTitDlSumElc.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(184, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Fecha Medición Anterior TORRESEC"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Tiene Contador Energía TORRESEC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Acumulado Anterior TORRESEC"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label74)
        Me.GroupBox1.Controls.Add(Me.cmbCodTrrsc)
        Me.GroupBox1.Controls.Add(Me.Label73)
        Me.GroupBox1.Controls.Add(Me.cmbAltn)
        Me.GroupBox1.Controls.Add(Me.Label72)
        Me.GroupBox1.Controls.Add(Me.cmbClle)
        Me.GroupBox1.Controls.Add(Me.Label71)
        Me.GroupBox1.Controls.Add(Me.cmbNmro)
        Me.GroupBox1.Controls.Add(Me.Label70)
        Me.GroupBox1.Controls.Add(Me.cmbEnClle1)
        Me.GroupBox1.Controls.Add(Me.cmbEnClle2)
        Me.GroupBox1.Controls.Add(Me.Label67)
        Me.GroupBox1.Controls.Add(Me.Label66)
        Me.GroupBox1.Controls.Add(Me.cmbPrvncia)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 125)
        Me.GroupBox1.TabIndex = 213
        Me.GroupBox1.TabStop = False
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(16, 20)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(102, 13)
        Me.Label74.TabIndex = 11
        Me.Label74.Text = "Código TORRESEC"
        '
        'cmbCodTrrsc
        '
        Me.cmbCodTrrsc.FormattingEnabled = True
        Me.cmbCodTrrsc.Location = New System.Drawing.Point(126, 17)
        Me.cmbCodTrrsc.Name = "cmbCodTrrsc"
        Me.cmbCodTrrsc.Size = New System.Drawing.Size(93, 21)
        Me.cmbCodTrrsc.TabIndex = 20
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(16, 45)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(57, 13)
        Me.Label73.TabIndex = 13
        Me.Label73.Text = "Alternativa"
        '
        'cmbAltn
        '
        Me.cmbAltn.FormattingEnabled = True
        Me.cmbAltn.Location = New System.Drawing.Point(126, 42)
        Me.cmbAltn.Name = "cmbAltn"
        Me.cmbAltn.Size = New System.Drawing.Size(93, 21)
        Me.cmbAltn.TabIndex = 21
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(16, 69)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(30, 13)
        Me.Label72.TabIndex = 15
        Me.Label72.Text = "Calle"
        '
        'cmbClle
        '
        Me.cmbClle.FormattingEnabled = True
        Me.cmbClle.Location = New System.Drawing.Point(126, 66)
        Me.cmbClle.Name = "cmbClle"
        Me.cmbClle.Size = New System.Drawing.Size(93, 21)
        Me.cmbClle.TabIndex = 22
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(240, 18)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(66, 13)
        Me.Label71.TabIndex = 19
        Me.Label71.Text = "Entre calle 1"
        '
        'cmbNmro
        '
        Me.cmbNmro.FormattingEnabled = True
        Me.cmbNmro.Location = New System.Drawing.Point(126, 93)
        Me.cmbNmro.Name = "cmbNmro"
        Me.cmbNmro.Size = New System.Drawing.Size(93, 21)
        Me.cmbNmro.TabIndex = 23
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(240, 43)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(66, 13)
        Me.Label70.TabIndex = 18
        Me.Label70.Text = "Entre calle 2"
        '
        'cmbEnClle1
        '
        Me.cmbEnClle1.FormattingEnabled = True
        Me.cmbEnClle1.Location = New System.Drawing.Point(311, 17)
        Me.cmbEnClle1.Name = "cmbEnClle1"
        Me.cmbEnClle1.Size = New System.Drawing.Size(93, 21)
        Me.cmbEnClle1.TabIndex = 24
        '
        'cmbEnClle2
        '
        Me.cmbEnClle2.FormattingEnabled = True
        Me.cmbEnClle2.Location = New System.Drawing.Point(311, 42)
        Me.cmbEnClle2.Name = "cmbEnClle2"
        Me.cmbEnClle2.Size = New System.Drawing.Size(93, 21)
        Me.cmbEnClle2.TabIndex = 25
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(240, 69)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(51, 13)
        Me.Label67.TabIndex = 14
        Me.Label67.Text = "Provincia"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(16, 96)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(44, 13)
        Me.Label66.TabIndex = 12
        Me.Label66.Text = "Numero"
        '
        'cmbPrvncia
        '
        Me.cmbPrvncia.FormattingEnabled = True
        Me.cmbPrvncia.Location = New System.Drawing.Point(311, 66)
        Me.cmbPrvncia.Name = "cmbPrvncia"
        Me.cmbPrvncia.Size = New System.Drawing.Size(93, 21)
        Me.cmbPrvncia.TabIndex = 28
        '
        'txtAcumUltMdcnTrrsc
        '
        Me.txtAcumUltMdcnTrrsc.Location = New System.Drawing.Point(124, 278)
        Me.txtAcumUltMdcnTrrsc.Name = "txtAcumUltMdcnTrrsc"
        Me.txtAcumUltMdcnTrrsc.Size = New System.Drawing.Size(200, 20)
        Me.txtAcumUltMdcnTrrsc.TabIndex = 212
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(126, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(197, 13)
        Me.Label12.TabIndex = 211
        Me.Label12.Text = "Acumulado última medición TORRESEC"
        '
        'dtpFchDsumElecXPrs
        '
        Me.dtpFchDsumElecXPrs.Location = New System.Drawing.Point(124, 203)
        Me.dtpFchDsumElecXPrs.Name = "dtpFchDsumElecXPrs"
        Me.dtpFchDsumElecXPrs.Size = New System.Drawing.Size(200, 20)
        Me.dtpFchDsumElecXPrs.TabIndex = 210
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(87, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 13)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Fecha Entrega de Suministro Electrico por la prestadora"
        '
        'txtProvDgstnDsum
        '
        Me.txtProvDgstnDsum.Location = New System.Drawing.Point(124, 242)
        Me.txtProvDgstnDsum.Name = "txtProvDgstnDsum"
        Me.txtProvDgstnDsum.Size = New System.Drawing.Size(200, 20)
        Me.txtProvDgstnDsum.TabIndex = 208
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(140, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "Proveedor de gestión de suministro"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Energia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(818, 447)
        Me.Controls.Add(Me.limpiarButton)
        Me.Controls.Add(Me.borrarButton)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.guardarButton)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAcumUltMdcnTrrsc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtpFchDsumElecXPrs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProvDgstnDsum)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Energia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Energia"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents limpiarButton As System.Windows.Forms.Button
    Private WithEvents borrarButton As System.Windows.Forms.Button
    Private WithEvents cancelarButton As System.Windows.Forms.Button
    Private WithEvents guardarButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTarfa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFchaPdSumElcPrs As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbTienCntdr As System.Windows.Forms.ComboBox
    Friend WithEvents txtDirDlSumElc As System.Windows.Forms.TextBox
    Friend WithEvents txtAcumAntTrrsc As System.Windows.Forms.TextBox
    Friend WithEvents dtpFchaMdcnAntTrrsc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTitDlSumElc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents cmbCodTrrsc As System.Windows.Forms.ComboBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents cmbAltn As System.Windows.Forms.ComboBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents cmbClle As System.Windows.Forms.ComboBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents cmbNmro As System.Windows.Forms.ComboBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents cmbEnClle1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEnClle2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents cmbPrvncia As System.Windows.Forms.ComboBox
    Friend WithEvents txtAcumUltMdcnTrrsc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFchDsumElecXPrs As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProvDgstnDsum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
