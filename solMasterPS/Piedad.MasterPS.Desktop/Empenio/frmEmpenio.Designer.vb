<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpenio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTituloEmpenios = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnReimprimir = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtClientes = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblDireccionCliente = New System.Windows.Forms.Label()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.lblTipoIdentificacion = New System.Windows.Forms.Label()
        Me.lblNumeroIdenti = New System.Windows.Forms.Label()
        Me.txtNoIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtTipoIdentificacion = New System.Windows.Forms.TextBox()
        Me.lblNombreCotitular = New System.Windows.Forms.Label()
        Me.txtNombreCotitular = New System.Windows.Forms.TextBox()
        Me.lblBuscarCotitular = New System.Windows.Forms.Label()
        Me.txtBuscarCotitular = New System.Windows.Forms.TextBox()
        Me.txtDireccionCotitular = New System.Windows.Forms.TextBox()
        Me.lblDireccionCotitular = New System.Windows.Forms.Label()
        Me.lblBeneficiario = New System.Windows.Forms.Label()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.PanelSubInformativo = New System.Windows.Forms.Panel()
        Me.cmbPlazo = New System.Windows.Forms.ComboBox()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.cmbTipoInteres = New System.Windows.Forms.ComboBox()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.lblTipoInteres = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.lblInteresMensual = New System.Windows.Forms.Label()
        Me.txtInteresMensual = New System.Windows.Forms.TextBox()
        Me.lblfechaVencimiento = New System.Windows.Forms.Label()
        Me.txtFechaVencimiento = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnEditarCotitular = New System.Windows.Forms.Button()
        Me.btnAgregarCotitular = New System.Windows.Forms.Button()
        Me.cmbTipoEmpenio = New System.Windows.Forms.ComboBox()
        Me.dgvDetalleEmpenio = New System.Windows.Forms.DataGridView()
        Me.PanelSeleccionMercancia = New System.Windows.Forms.Panel()
        Me.lblSeleccionarTipoMercancia = New System.Windows.Forms.Label()
        Me.lblDetalleEmpenio = New System.Windows.Forms.Label()
        Me.btnEliminarPrenda = New System.Windows.Forms.Button()
        Me.btnEditarPrenda = New System.Windows.Forms.Button()
        Me.PanelSubInformativo.SuspendLayout()
        CType(Me.dgvDetalleEmpenio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSeleccionMercancia.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTituloEmpenios
        '
        Me.lblTituloEmpenios.AutoSize = True
        Me.lblTituloEmpenios.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloEmpenios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTituloEmpenios.Location = New System.Drawing.Point(491, 4)
        Me.lblTituloEmpenios.Name = "lblTituloEmpenios"
        Me.lblTituloEmpenios.Size = New System.Drawing.Size(99, 25)
        Me.lblTituloEmpenios.TabIndex = 0
        Me.lblTituloEmpenios.Text = "EMPEÑO"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(833, 443)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(217, 42)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnReimprimir
        '
        Me.btnReimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReimprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReimprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReimprimir.FlatAppearance.BorderSize = 0
        Me.btnReimprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnReimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnReimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReimprimir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReimprimir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReimprimir.Location = New System.Drawing.Point(833, 491)
        Me.btnReimprimir.Name = "btnReimprimir"
        Me.btnReimprimir.Size = New System.Drawing.Size(111, 42)
        Me.btnReimprimir.TabIndex = 2
        Me.btnReimprimir.Text = "REIMPRIMIR"
        Me.btnReimprimir.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(950, 491)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 42)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtClientes
        '
        Me.txtClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientes.Location = New System.Drawing.Point(125, 51)
        Me.txtClientes.Name = "txtClientes"
        Me.txtClientes.Size = New System.Drawing.Size(225, 21)
        Me.txtClientes.TabIndex = 5
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(13, 54)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(106, 16)
        Me.lblCliente.TabIndex = 7
        Me.lblCliente.Text = "Buscar Cliente:"
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(12, 81)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(59, 17)
        Me.lblNombreCliente.TabIndex = 9
        Me.lblNombreCliente.Text = "Nombre:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Location = New System.Drawing.Point(15, 101)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(235, 21)
        Me.txtNombreCliente.TabIndex = 8
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(12, 123)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(69, 17)
        Me.lblDireccionCliente.TabIndex = 11
        Me.lblDireccionCliente.Text = "Dirección:"
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionCliente.Location = New System.Drawing.Point(15, 143)
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(419, 21)
        Me.txtDireccionCliente.TabIndex = 10
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(438, 123)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(62, 17)
        Me.lblTelefonoCliente.TabIndex = 13
        Me.lblTelefonoCliente.Text = "Teléfono:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(441, 143)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(166, 21)
        Me.txtTelefonoCliente.TabIndex = 12
        '
        'lblTipoIdentificacion
        '
        Me.lblTipoIdentificacion.AutoSize = True
        Me.lblTipoIdentificacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoIdentificacion.Location = New System.Drawing.Point(253, 81)
        Me.lblTipoIdentificacion.Name = "lblTipoIdentificacion"
        Me.lblTipoIdentificacion.Size = New System.Drawing.Size(140, 17)
        Me.lblTipoIdentificacion.TabIndex = 15
        Me.lblTipoIdentificacion.Text = "Tipo de Identificación:"
        '
        'lblNumeroIdenti
        '
        Me.lblNumeroIdenti.AutoSize = True
        Me.lblNumeroIdenti.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroIdenti.Location = New System.Drawing.Point(446, 81)
        Me.lblNumeroIdenti.Name = "lblNumeroIdenti"
        Me.lblNumeroIdenti.Size = New System.Drawing.Size(117, 17)
        Me.lblNumeroIdenti.TabIndex = 18
        Me.lblNumeroIdenti.Text = "No. Identificación:"
        '
        'txtNoIdentificacion
        '
        Me.txtNoIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoIdentificacion.Location = New System.Drawing.Point(449, 101)
        Me.txtNoIdentificacion.Name = "txtNoIdentificacion"
        Me.txtNoIdentificacion.Size = New System.Drawing.Size(158, 21)
        Me.txtNoIdentificacion.TabIndex = 17
        '
        'txtTipoIdentificacion
        '
        Me.txtTipoIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoIdentificacion.Location = New System.Drawing.Point(256, 101)
        Me.txtTipoIdentificacion.Name = "txtTipoIdentificacion"
        Me.txtTipoIdentificacion.Size = New System.Drawing.Size(187, 21)
        Me.txtTipoIdentificacion.TabIndex = 19
        '
        'lblNombreCotitular
        '
        Me.lblNombreCotitular.AutoSize = True
        Me.lblNombreCotitular.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCotitular.Location = New System.Drawing.Point(11, 211)
        Me.lblNombreCotitular.Name = "lblNombreCotitular"
        Me.lblNombreCotitular.Size = New System.Drawing.Size(59, 17)
        Me.lblNombreCotitular.TabIndex = 23
        Me.lblNombreCotitular.Text = "Nombre:"
        '
        'txtNombreCotitular
        '
        Me.txtNombreCotitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCotitular.Location = New System.Drawing.Point(14, 231)
        Me.txtNombreCotitular.Name = "txtNombreCotitular"
        Me.txtNombreCotitular.Size = New System.Drawing.Size(235, 21)
        Me.txtNombreCotitular.TabIndex = 22
        '
        'lblBuscarCotitular
        '
        Me.lblBuscarCotitular.AutoSize = True
        Me.lblBuscarCotitular.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarCotitular.Location = New System.Drawing.Point(12, 187)
        Me.lblBuscarCotitular.Name = "lblBuscarCotitular"
        Me.lblBuscarCotitular.Size = New System.Drawing.Size(116, 16)
        Me.lblBuscarCotitular.TabIndex = 21
        Me.lblBuscarCotitular.Text = "Buscar Cotitular:"
        '
        'txtBuscarCotitular
        '
        Me.txtBuscarCotitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCotitular.Location = New System.Drawing.Point(134, 184)
        Me.txtBuscarCotitular.Name = "txtBuscarCotitular"
        Me.txtBuscarCotitular.Size = New System.Drawing.Size(225, 21)
        Me.txtBuscarCotitular.TabIndex = 20
        '
        'txtDireccionCotitular
        '
        Me.txtDireccionCotitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionCotitular.Location = New System.Drawing.Point(255, 231)
        Me.txtDireccionCotitular.Name = "txtDireccionCotitular"
        Me.txtDireccionCotitular.Size = New System.Drawing.Size(351, 21)
        Me.txtDireccionCotitular.TabIndex = 24
        '
        'lblDireccionCotitular
        '
        Me.lblDireccionCotitular.AutoSize = True
        Me.lblDireccionCotitular.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCotitular.Location = New System.Drawing.Point(252, 211)
        Me.lblDireccionCotitular.Name = "lblDireccionCotitular"
        Me.lblDireccionCotitular.Size = New System.Drawing.Size(69, 17)
        Me.lblDireccionCotitular.TabIndex = 25
        Me.lblDireccionCotitular.Text = "Dirección:"
        '
        'lblBeneficiario
        '
        Me.lblBeneficiario.AutoSize = True
        Me.lblBeneficiario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeneficiario.Location = New System.Drawing.Point(12, 260)
        Me.lblBeneficiario.Name = "lblBeneficiario"
        Me.lblBeneficiario.Size = New System.Drawing.Size(82, 17)
        Me.lblBeneficiario.TabIndex = 27
        Me.lblBeneficiario.Text = "Beneficiario:"
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.Location = New System.Drawing.Point(100, 258)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(234, 21)
        Me.txtBeneficiario.TabIndex = 26
        '
        'PanelSubInformativo
        '
        Me.PanelSubInformativo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSubInformativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubInformativo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelSubInformativo.Controls.Add(Me.cmbPlazo)
        Me.PanelSubInformativo.Controls.Add(Me.cmbPeriodo)
        Me.PanelSubInformativo.Controls.Add(Me.cmbTipoInteres)
        Me.PanelSubInformativo.Controls.Add(Me.lblPlazo)
        Me.PanelSubInformativo.Controls.Add(Me.lblPeriodo)
        Me.PanelSubInformativo.Controls.Add(Me.lblTipoInteres)
        Me.PanelSubInformativo.Controls.Add(Me.lblUsuario)
        Me.PanelSubInformativo.Controls.Add(Me.txtUsuario)
        Me.PanelSubInformativo.Controls.Add(Me.lblSucursal)
        Me.PanelSubInformativo.Controls.Add(Me.txtSucursal)
        Me.PanelSubInformativo.Controls.Add(Me.lblInteresMensual)
        Me.PanelSubInformativo.Controls.Add(Me.txtInteresMensual)
        Me.PanelSubInformativo.Controls.Add(Me.lblfechaVencimiento)
        Me.PanelSubInformativo.Controls.Add(Me.txtFechaVencimiento)
        Me.PanelSubInformativo.Location = New System.Drawing.Point(708, 38)
        Me.PanelSubInformativo.Name = "PanelSubInformativo"
        Me.PanelSubInformativo.Size = New System.Drawing.Size(330, 146)
        Me.PanelSubInformativo.TabIndex = 28
        '
        'cmbPlazo
        '
        Me.cmbPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlazo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlazo.FormattingEnabled = True
        Me.cmbPlazo.Location = New System.Drawing.Point(252, 57)
        Me.cmbPlazo.Name = "cmbPlazo"
        Me.cmbPlazo.Size = New System.Drawing.Size(58, 24)
        Me.cmbPlazo.TabIndex = 41
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPeriodo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Location = New System.Drawing.Point(148, 57)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(98, 24)
        Me.cmbPeriodo.TabIndex = 40
        '
        'cmbTipoInteres
        '
        Me.cmbTipoInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoInteres.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoInteres.FormattingEnabled = True
        Me.cmbTipoInteres.Location = New System.Drawing.Point(17, 57)
        Me.cmbTipoInteres.Name = "cmbTipoInteres"
        Me.cmbTipoInteres.Size = New System.Drawing.Size(125, 24)
        Me.cmbTipoInteres.TabIndex = 39
        '
        'lblPlazo
        '
        Me.lblPlazo.AutoSize = True
        Me.lblPlazo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlazo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPlazo.Location = New System.Drawing.Point(249, 37)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(39, 17)
        Me.lblPlazo.TabIndex = 38
        Me.lblPlazo.Text = "Plazo"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPeriodo.Location = New System.Drawing.Point(145, 39)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(54, 17)
        Me.lblPeriodo.TabIndex = 33
        Me.lblPeriodo.Text = "Periodo"
        '
        'lblTipoInteres
        '
        Me.lblTipoInteres.AutoSize = True
        Me.lblTipoInteres.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoInteres.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTipoInteres.Location = New System.Drawing.Point(14, 39)
        Me.lblTipoInteres.Name = "lblTipoInteres"
        Me.lblTipoInteres.Size = New System.Drawing.Size(75, 17)
        Me.lblTipoInteres.TabIndex = 37
        Me.lblTipoInteres.Text = "Tipo Interes"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblUsuario.Location = New System.Drawing.Point(237, 87)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(51, 17)
        Me.lblUsuario.TabIndex = 36
        Me.lblUsuario.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.PaleGreen
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(213, 104)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(104, 19)
        Me.txtUsuario.TabIndex = 35
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblSucursal.Location = New System.Drawing.Point(136, 87)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(57, 17)
        Me.lblSucursal.TabIndex = 34
        Me.lblSucursal.Text = "Sucursal"
        '
        'txtSucursal
        '
        Me.txtSucursal.BackColor = System.Drawing.Color.PaleGreen
        Me.txtSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSucursal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.Location = New System.Drawing.Point(123, 104)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(84, 19)
        Me.txtSucursal.TabIndex = 33
        Me.txtSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInteresMensual
        '
        Me.lblInteresMensual.AutoSize = True
        Me.lblInteresMensual.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteresMensual.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInteresMensual.Location = New System.Drawing.Point(17, 87)
        Me.lblInteresMensual.Name = "lblInteresMensual"
        Me.lblInteresMensual.Size = New System.Drawing.Size(100, 17)
        Me.lblInteresMensual.TabIndex = 32
        Me.lblInteresMensual.Text = "Interes Mensual"
        '
        'txtInteresMensual
        '
        Me.txtInteresMensual.BackColor = System.Drawing.Color.PaleGreen
        Me.txtInteresMensual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInteresMensual.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInteresMensual.Location = New System.Drawing.Point(17, 104)
        Me.txtInteresMensual.Name = "txtInteresMensual"
        Me.txtInteresMensual.Size = New System.Drawing.Size(100, 19)
        Me.txtInteresMensual.TabIndex = 31
        Me.txtInteresMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblfechaVencimiento
        '
        Me.lblfechaVencimiento.AutoSize = True
        Me.lblfechaVencimiento.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaVencimiento.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblfechaVencimiento.Location = New System.Drawing.Point(14, 15)
        Me.lblfechaVencimiento.Name = "lblfechaVencimiento"
        Me.lblfechaVencimiento.Size = New System.Drawing.Size(128, 17)
        Me.lblfechaVencimiento.TabIndex = 30
        Me.lblfechaVencimiento.Text = "Fecha Vencimiento:"
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.BackColor = System.Drawing.Color.PaleGreen
        Me.txtFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaVencimiento.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(148, 15)
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(121, 19)
        Me.txtFechaVencimiento.TabIndex = 29
        Me.txtFechaVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarCliente.FlatAppearance.BorderSize = 0
        Me.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarCliente.Location = New System.Drawing.Point(356, 48)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(32, 28)
        Me.btnBuscarCliente.TabIndex = 29
        Me.btnBuscarCliente.Text = "+"
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarCliente.FlatAppearance.BorderSize = 0
        Me.btnEditarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditarCliente.Location = New System.Drawing.Point(394, 48)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(60, 28)
        Me.btnEditarCliente.TabIndex = 30
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.UseVisualStyleBackColor = False
        '
        'btnEditarCotitular
        '
        Me.btnEditarCotitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarCotitular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarCotitular.FlatAppearance.BorderSize = 0
        Me.btnEditarCotitular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditarCotitular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEditarCotitular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCotitular.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCotitular.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditarCotitular.Location = New System.Drawing.Point(405, 181)
        Me.btnEditarCotitular.Name = "btnEditarCotitular"
        Me.btnEditarCotitular.Size = New System.Drawing.Size(60, 28)
        Me.btnEditarCotitular.TabIndex = 32
        Me.btnEditarCotitular.Text = "Editar"
        Me.btnEditarCotitular.UseVisualStyleBackColor = False
        '
        'btnAgregarCotitular
        '
        Me.btnAgregarCotitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarCotitular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarCotitular.FlatAppearance.BorderSize = 0
        Me.btnAgregarCotitular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAgregarCotitular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAgregarCotitular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCotitular.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCotitular.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregarCotitular.Location = New System.Drawing.Point(367, 181)
        Me.btnAgregarCotitular.Name = "btnAgregarCotitular"
        Me.btnAgregarCotitular.Size = New System.Drawing.Size(32, 28)
        Me.btnAgregarCotitular.TabIndex = 31
        Me.btnAgregarCotitular.Text = "+"
        Me.btnAgregarCotitular.UseVisualStyleBackColor = False
        '
        'cmbTipoEmpenio
        '
        Me.cmbTipoEmpenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEmpenio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEmpenio.FormattingEnabled = True
        Me.cmbTipoEmpenio.Location = New System.Drawing.Point(38, 37)
        Me.cmbTipoEmpenio.Name = "cmbTipoEmpenio"
        Me.cmbTipoEmpenio.Size = New System.Drawing.Size(250, 25)
        Me.cmbTipoEmpenio.TabIndex = 43
        '
        'dgvDetalleEmpenio
        '
        Me.dgvDetalleEmpenio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleEmpenio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDetalleEmpenio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDetalleEmpenio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetalleEmpenio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleEmpenio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalleEmpenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleEmpenio.EnableHeadersVisualStyles = False
        Me.dgvDetalleEmpenio.Location = New System.Drawing.Point(405, 284)
        Me.dgvDetalleEmpenio.MultiSelect = False
        Me.dgvDetalleEmpenio.Name = "dgvDetalleEmpenio"
        Me.dgvDetalleEmpenio.ReadOnly = True
        Me.dgvDetalleEmpenio.RowHeadersVisible = False
        Me.dgvDetalleEmpenio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleEmpenio.Size = New System.Drawing.Size(634, 144)
        Me.dgvDetalleEmpenio.TabIndex = 62
        '
        'PanelSeleccionMercancia
        '
        Me.PanelSeleccionMercancia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSeleccionMercancia.Controls.Add(Me.lblSeleccionarTipoMercancia)
        Me.PanelSeleccionMercancia.Controls.Add(Me.cmbTipoEmpenio)
        Me.PanelSeleccionMercancia.Location = New System.Drawing.Point(16, 301)
        Me.PanelSeleccionMercancia.Name = "PanelSeleccionMercancia"
        Me.PanelSeleccionMercancia.Size = New System.Drawing.Size(350, 84)
        Me.PanelSeleccionMercancia.TabIndex = 63
        '
        'lblSeleccionarTipoMercancia
        '
        Me.lblSeleccionarTipoMercancia.AutoSize = True
        Me.lblSeleccionarTipoMercancia.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarTipoMercancia.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblSeleccionarTipoMercancia.Location = New System.Drawing.Point(4, 4)
        Me.lblSeleccionarTipoMercancia.Name = "lblSeleccionarTipoMercancia"
        Me.lblSeleccionarTipoMercancia.Size = New System.Drawing.Size(337, 20)
        Me.lblSeleccionarTipoMercancia.TabIndex = 44
        Me.lblSeleccionarTipoMercancia.Text = "Selecciona el tipo de mercancía a empeñar:"
        '
        'lblDetalleEmpenio
        '
        Me.lblDetalleEmpenio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetalleEmpenio.AutoSize = True
        Me.lblDetalleEmpenio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalleEmpenio.Location = New System.Drawing.Point(402, 264)
        Me.lblDetalleEmpenio.Name = "lblDetalleEmpenio"
        Me.lblDetalleEmpenio.Size = New System.Drawing.Size(182, 16)
        Me.lblDetalleEmpenio.TabIndex = 64
        Me.lblDetalleEmpenio.Text = "Detalle de las mercancías:"
        '
        'btnEliminarPrenda
        '
        Me.btnEliminarPrenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarPrenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminarPrenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarPrenda.FlatAppearance.BorderSize = 0
        Me.btnEliminarPrenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEliminarPrenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEliminarPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPrenda.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPrenda.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminarPrenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarPrenda.Location = New System.Drawing.Point(944, 253)
        Me.btnEliminarPrenda.Name = "btnEliminarPrenda"
        Me.btnEliminarPrenda.Size = New System.Drawing.Size(95, 25)
        Me.btnEliminarPrenda.TabIndex = 65
        Me.btnEliminarPrenda.Text = "ELIMINAR"
        Me.btnEliminarPrenda.UseVisualStyleBackColor = False
        '
        'btnEditarPrenda
        '
        Me.btnEditarPrenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarPrenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarPrenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarPrenda.FlatAppearance.BorderSize = 0
        Me.btnEditarPrenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditarPrenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEditarPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarPrenda.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarPrenda.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditarPrenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarPrenda.Location = New System.Drawing.Point(843, 253)
        Me.btnEditarPrenda.Name = "btnEditarPrenda"
        Me.btnEditarPrenda.Size = New System.Drawing.Size(95, 25)
        Me.btnEditarPrenda.TabIndex = 66
        Me.btnEditarPrenda.Text = "EDITAR"
        Me.btnEditarPrenda.UseVisualStyleBackColor = False
        '
        'frmEmpenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1050, 545)
        Me.Controls.Add(Me.btnEditarPrenda)
        Me.Controls.Add(Me.btnEliminarPrenda)
        Me.Controls.Add(Me.lblDetalleEmpenio)
        Me.Controls.Add(Me.PanelSeleccionMercancia)
        Me.Controls.Add(Me.dgvDetalleEmpenio)
        Me.Controls.Add(Me.btnEditarCotitular)
        Me.Controls.Add(Me.btnAgregarCotitular)
        Me.Controls.Add(Me.btnEditarCliente)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.PanelSubInformativo)
        Me.Controls.Add(Me.lblBeneficiario)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.lblDireccionCotitular)
        Me.Controls.Add(Me.txtDireccionCotitular)
        Me.Controls.Add(Me.lblNombreCotitular)
        Me.Controls.Add(Me.txtNombreCotitular)
        Me.Controls.Add(Me.lblBuscarCotitular)
        Me.Controls.Add(Me.txtBuscarCotitular)
        Me.Controls.Add(Me.txtTipoIdentificacion)
        Me.Controls.Add(Me.lblNumeroIdenti)
        Me.Controls.Add(Me.txtNoIdentificacion)
        Me.Controls.Add(Me.lblTipoIdentificacion)
        Me.Controls.Add(Me.lblTelefonoCliente)
        Me.Controls.Add(Me.txtTelefonoCliente)
        Me.Controls.Add(Me.lblDireccionCliente)
        Me.Controls.Add(Me.txtDireccionCliente)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtClientes)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReimprimir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTituloEmpenios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmpenio"
        Me.Text = "frmEmpenio"
        Me.PanelSubInformativo.ResumeLayout(False)
        Me.PanelSubInformativo.PerformLayout()
        CType(Me.dgvDetalleEmpenio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSeleccionMercancia.ResumeLayout(False)
        Me.PanelSeleccionMercancia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTituloEmpenios As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnReimprimir As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtClientes As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents lblDireccionCliente As Label
    Friend WithEvents txtDireccionCliente As TextBox
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents lblTipoIdentificacion As Label
    Friend WithEvents lblNumeroIdenti As Label
    Friend WithEvents txtNoIdentificacion As TextBox
    Friend WithEvents txtTipoIdentificacion As TextBox
    Friend WithEvents lblNombreCotitular As Label
    Friend WithEvents txtNombreCotitular As TextBox
    Friend WithEvents lblBuscarCotitular As Label
    Friend WithEvents txtBuscarCotitular As TextBox
    Friend WithEvents txtDireccionCotitular As TextBox
    Friend WithEvents lblDireccionCotitular As Label
    Friend WithEvents lblBeneficiario As Label
    Friend WithEvents txtBeneficiario As TextBox
    Friend WithEvents PanelSubInformativo As Panel
    Friend WithEvents cmbPlazo As ComboBox
    Friend WithEvents cmbPeriodo As ComboBox
    Friend WithEvents cmbTipoInteres As ComboBox
    Friend WithEvents lblPlazo As Label
    Friend WithEvents lblPeriodo As Label
    Friend WithEvents lblTipoInteres As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblSucursal As Label
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents lblInteresMensual As Label
    Friend WithEvents txtInteresMensual As TextBox
    Friend WithEvents lblfechaVencimiento As Label
    Friend WithEvents txtFechaVencimiento As TextBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents btnEditarCliente As Button
    Friend WithEvents btnEditarCotitular As Button
    Friend WithEvents btnAgregarCotitular As Button
    Friend WithEvents cmbTipoEmpenio As ComboBox
    Friend WithEvents dgvDetalleEmpenio As DataGridView
    Friend WithEvents PanelSeleccionMercancia As Panel
    Friend WithEvents lblSeleccionarTipoMercancia As Label
    Friend WithEvents lblDetalleEmpenio As Label
    Friend WithEvents btnEliminarPrenda As Button
    Friend WithEvents btnEditarPrenda As Button
End Class
