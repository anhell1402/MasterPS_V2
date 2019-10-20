<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionVehiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionVehiculo))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.cmbTipoFamilia = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cmbNivelCombustible = New System.Windows.Forms.ComboBox()
        Me.cmbTipoMotor = New System.Windows.Forms.ComboBox()
        Me.cmbAgencia = New System.Windows.Forms.ComboBox()
        Me.txtFechaVenc = New System.Windows.Forms.TextBox()
        Me.lblFechaVenc = New System.Windows.Forms.Label()
        Me.txtNoPoliza = New System.Windows.Forms.TextBox()
        Me.lblPoliza = New System.Windows.Forms.Label()
        Me.txtAseguradora = New System.Windows.Forms.TextBox()
        Me.lblAseguradora = New System.Windows.Forms.Label()
        Me.txtNumTarjetaCirculacion = New System.Windows.Forms.TextBox()
        Me.lblTarjetaCirculacion = New System.Windows.Forms.Label()
        Me.lblNivelComb = New System.Windows.Forms.Label()
        Me.lblTipoMotor = New System.Windows.Forms.Label()
        Me.txtREPUVE = New System.Windows.Forms.TextBox()
        Me.lblREPUVE = New System.Windows.Forms.Label()
        Me.txtNumChasis = New System.Windows.Forms.TextBox()
        Me.lblNumChasis = New System.Windows.Forms.Label()
        Me.txtNumMotor = New System.Windows.Forms.TextBox()
        Me.lblNumMotor = New System.Windows.Forms.Label()
        Me.lblAgencia = New System.Windows.Forms.Label()
        Me.txtKms = New System.Windows.Forms.TextBox()
        Me.lblKms = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.txtPlacas = New System.Windows.Forms.TextBox()
        Me.lblPlacas = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cmbModelo = New System.Windows.Forms.ComboBox()
        Me.lblCantidadPrestamoMax = New System.Windows.Forms.Label()
        Me.lblPrestamoMax = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtAvaluo = New System.Windows.Forms.TextBox()
        Me.lblAvaluo = New System.Windows.Forms.Label()
        Me.lblDescripcionVehiculo = New System.Windows.Forms.Label()
        Me.txtDescripcionVehiculo = New System.Windows.Forms.TextBox()
        Me.txtPrecioMax = New System.Windows.Forms.TextBox()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.txtTipoEmpenio = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.cmbTipoMercancia = New System.Windows.Forms.ComboBox()
        Me.lblMercancia = New System.Windows.Forms.Label()
        Me.lblTipoMercancia = New System.Windows.Forms.Label()
        Me.lblPrecioMaximo = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Controls.Add(Me.lblTitulo)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(870, 30)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(851, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 67
        Me.btnCerrar.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitulo.Location = New System.Drawing.Point(7, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(174, 20)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Seleccion de Vehículo"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContenedor.Controls.Add(Me.cmbTipoFamilia)
        Me.PanelContenedor.Controls.Add(Me.lblTipo)
        Me.PanelContenedor.Controls.Add(Me.cmbNivelCombustible)
        Me.PanelContenedor.Controls.Add(Me.cmbTipoMotor)
        Me.PanelContenedor.Controls.Add(Me.cmbAgencia)
        Me.PanelContenedor.Controls.Add(Me.txtFechaVenc)
        Me.PanelContenedor.Controls.Add(Me.lblFechaVenc)
        Me.PanelContenedor.Controls.Add(Me.txtNoPoliza)
        Me.PanelContenedor.Controls.Add(Me.lblPoliza)
        Me.PanelContenedor.Controls.Add(Me.txtAseguradora)
        Me.PanelContenedor.Controls.Add(Me.lblAseguradora)
        Me.PanelContenedor.Controls.Add(Me.txtNumTarjetaCirculacion)
        Me.PanelContenedor.Controls.Add(Me.lblTarjetaCirculacion)
        Me.PanelContenedor.Controls.Add(Me.lblNivelComb)
        Me.PanelContenedor.Controls.Add(Me.lblTipoMotor)
        Me.PanelContenedor.Controls.Add(Me.txtREPUVE)
        Me.PanelContenedor.Controls.Add(Me.lblREPUVE)
        Me.PanelContenedor.Controls.Add(Me.txtNumChasis)
        Me.PanelContenedor.Controls.Add(Me.lblNumChasis)
        Me.PanelContenedor.Controls.Add(Me.txtNumMotor)
        Me.PanelContenedor.Controls.Add(Me.lblNumMotor)
        Me.PanelContenedor.Controls.Add(Me.lblAgencia)
        Me.PanelContenedor.Controls.Add(Me.txtKms)
        Me.PanelContenedor.Controls.Add(Me.lblKms)
        Me.PanelContenedor.Controls.Add(Me.txtFactura)
        Me.PanelContenedor.Controls.Add(Me.lblFactura)
        Me.PanelContenedor.Controls.Add(Me.txtPlacas)
        Me.PanelContenedor.Controls.Add(Me.lblPlacas)
        Me.PanelContenedor.Controls.Add(Me.txtAnio)
        Me.PanelContenedor.Controls.Add(Me.lblAnio)
        Me.PanelContenedor.Controls.Add(Me.btnNuevo)
        Me.PanelContenedor.Controls.Add(Me.btnSalir)
        Me.PanelContenedor.Controls.Add(Me.btnAgregar)
        Me.PanelContenedor.Controls.Add(Me.cmbModelo)
        Me.PanelContenedor.Controls.Add(Me.lblCantidadPrestamoMax)
        Me.PanelContenedor.Controls.Add(Me.lblPrestamoMax)
        Me.PanelContenedor.Controls.Add(Me.txtColor)
        Me.PanelContenedor.Controls.Add(Me.lblColor)
        Me.PanelContenedor.Controls.Add(Me.txtAvaluo)
        Me.PanelContenedor.Controls.Add(Me.lblAvaluo)
        Me.PanelContenedor.Controls.Add(Me.lblDescripcionVehiculo)
        Me.PanelContenedor.Controls.Add(Me.txtDescripcionVehiculo)
        Me.PanelContenedor.Controls.Add(Me.txtPrecioMax)
        Me.PanelContenedor.Controls.Add(Me.cmbMarca)
        Me.PanelContenedor.Controls.Add(Me.txtTipoEmpenio)
        Me.PanelContenedor.Controls.Add(Me.lblMarca)
        Me.PanelContenedor.Controls.Add(Me.lblModelo)
        Me.PanelContenedor.Controls.Add(Me.cmbTipoMercancia)
        Me.PanelContenedor.Controls.Add(Me.lblMercancia)
        Me.PanelContenedor.Controls.Add(Me.lblTipoMercancia)
        Me.PanelContenedor.Controls.Add(Me.lblPrecioMaximo)
        Me.PanelContenedor.Controls.Add(Me.pbImagen)
        Me.PanelContenedor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelContenedor.Location = New System.Drawing.Point(5, 35)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(860, 405)
        Me.PanelContenedor.TabIndex = 1
        '
        'cmbTipoFamilia
        '
        Me.cmbTipoFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoFamilia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoFamilia.FormattingEnabled = True
        Me.cmbTipoFamilia.Location = New System.Drawing.Point(499, 67)
        Me.cmbTipoFamilia.Name = "cmbTipoFamilia"
        Me.cmbTipoFamilia.Size = New System.Drawing.Size(112, 25)
        Me.cmbTipoFamilia.TabIndex = 102
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Black
        Me.lblTipo.Location = New System.Drawing.Point(496, 48)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(35, 17)
        Me.lblTipo.TabIndex = 101
        Me.lblTipo.Text = "Tipo:"
        '
        'cmbNivelCombustible
        '
        Me.cmbNivelCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNivelCombustible.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNivelCombustible.FormattingEnabled = True
        Me.cmbNivelCombustible.Location = New System.Drawing.Point(545, 124)
        Me.cmbNivelCombustible.Name = "cmbNivelCombustible"
        Me.cmbNivelCombustible.Size = New System.Drawing.Size(90, 25)
        Me.cmbNivelCombustible.TabIndex = 100
        '
        'cmbTipoMotor
        '
        Me.cmbTipoMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoMotor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoMotor.FormattingEnabled = True
        Me.cmbTipoMotor.Location = New System.Drawing.Point(428, 124)
        Me.cmbTipoMotor.Name = "cmbTipoMotor"
        Me.cmbTipoMotor.Size = New System.Drawing.Size(111, 25)
        Me.cmbTipoMotor.TabIndex = 99
        '
        'cmbAgencia
        '
        Me.cmbAgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgencia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgencia.FormattingEnabled = True
        Me.cmbAgencia.Location = New System.Drawing.Point(358, 67)
        Me.cmbAgencia.Name = "cmbAgencia"
        Me.cmbAgencia.Size = New System.Drawing.Size(135, 25)
        Me.cmbAgencia.TabIndex = 98
        '
        'txtFechaVenc
        '
        Me.txtFechaVenc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaVenc.Location = New System.Drawing.Point(574, 238)
        Me.txtFechaVenc.Name = "txtFechaVenc"
        Me.txtFechaVenc.Size = New System.Drawing.Size(112, 22)
        Me.txtFechaVenc.TabIndex = 96
        Me.txtFechaVenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFechaVenc
        '
        Me.lblFechaVenc.AutoSize = True
        Me.lblFechaVenc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVenc.ForeColor = System.Drawing.Color.Black
        Me.lblFechaVenc.Location = New System.Drawing.Point(571, 218)
        Me.lblFechaVenc.Name = "lblFechaVenc"
        Me.lblFechaVenc.Size = New System.Drawing.Size(128, 17)
        Me.lblFechaVenc.TabIndex = 97
        Me.lblFechaVenc.Text = "Fecha Vencimiento:"
        '
        'txtNoPoliza
        '
        Me.txtNoPoliza.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPoliza.Location = New System.Drawing.Point(456, 238)
        Me.txtNoPoliza.Name = "txtNoPoliza"
        Me.txtNoPoliza.Size = New System.Drawing.Size(112, 22)
        Me.txtNoPoliza.TabIndex = 94
        Me.txtNoPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPoliza
        '
        Me.lblPoliza.AutoSize = True
        Me.lblPoliza.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoliza.ForeColor = System.Drawing.Color.Black
        Me.lblPoliza.Location = New System.Drawing.Point(453, 218)
        Me.lblPoliza.Name = "lblPoliza"
        Me.lblPoliza.Size = New System.Drawing.Size(68, 17)
        Me.lblPoliza.TabIndex = 95
        Me.lblPoliza.Text = "No. Poliza:"
        '
        'txtAseguradora
        '
        Me.txtAseguradora.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAseguradora.Location = New System.Drawing.Point(338, 238)
        Me.txtAseguradora.Name = "txtAseguradora"
        Me.txtAseguradora.Size = New System.Drawing.Size(112, 22)
        Me.txtAseguradora.TabIndex = 92
        Me.txtAseguradora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAseguradora
        '
        Me.lblAseguradora.AutoSize = True
        Me.lblAseguradora.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAseguradora.ForeColor = System.Drawing.Color.Black
        Me.lblAseguradora.Location = New System.Drawing.Point(335, 218)
        Me.lblAseguradora.Name = "lblAseguradora"
        Me.lblAseguradora.Size = New System.Drawing.Size(88, 17)
        Me.lblAseguradora.TabIndex = 93
        Me.lblAseguradora.Text = "Aseguradora:"
        '
        'txtNumTarjetaCirculacion
        '
        Me.txtNumTarjetaCirculacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTarjetaCirculacion.Location = New System.Drawing.Point(535, 181)
        Me.txtNumTarjetaCirculacion.Name = "txtNumTarjetaCirculacion"
        Me.txtNumTarjetaCirculacion.Size = New System.Drawing.Size(158, 22)
        Me.txtNumTarjetaCirculacion.TabIndex = 90
        Me.txtNumTarjetaCirculacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTarjetaCirculacion
        '
        Me.lblTarjetaCirculacion.AutoSize = True
        Me.lblTarjetaCirculacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarjetaCirculacion.ForeColor = System.Drawing.Color.Black
        Me.lblTarjetaCirculacion.Location = New System.Drawing.Point(532, 161)
        Me.lblTarjetaCirculacion.Name = "lblTarjetaCirculacion"
        Me.lblTarjetaCirculacion.Size = New System.Drawing.Size(146, 17)
        Me.lblTarjetaCirculacion.TabIndex = 91
        Me.lblTarjetaCirculacion.Text = "No. Tarjeta Circulación:"
        '
        'lblNivelComb
        '
        Me.lblNivelComb.AutoSize = True
        Me.lblNivelComb.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelComb.ForeColor = System.Drawing.Color.Black
        Me.lblNivelComb.Location = New System.Drawing.Point(542, 104)
        Me.lblNivelComb.Name = "lblNivelComb"
        Me.lblNivelComb.Size = New System.Drawing.Size(139, 17)
        Me.lblNivelComb.TabIndex = 89
        Me.lblNivelComb.Text = "Nivel de Combustible:"
        '
        'lblTipoMotor
        '
        Me.lblTipoMotor.AutoSize = True
        Me.lblTipoMotor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMotor.ForeColor = System.Drawing.Color.Black
        Me.lblTipoMotor.Location = New System.Drawing.Point(425, 104)
        Me.lblTipoMotor.Name = "lblTipoMotor"
        Me.lblTipoMotor.Size = New System.Drawing.Size(93, 17)
        Me.lblTipoMotor.TabIndex = 87
        Me.lblTipoMotor.Text = "Tipo de Motor:"
        '
        'txtREPUVE
        '
        Me.txtREPUVE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtREPUVE.Location = New System.Drawing.Point(214, 238)
        Me.txtREPUVE.Name = "txtREPUVE"
        Me.txtREPUVE.Size = New System.Drawing.Size(112, 22)
        Me.txtREPUVE.TabIndex = 84
        Me.txtREPUVE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblREPUVE
        '
        Me.lblREPUVE.AutoSize = True
        Me.lblREPUVE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblREPUVE.ForeColor = System.Drawing.Color.Black
        Me.lblREPUVE.Location = New System.Drawing.Point(211, 218)
        Me.lblREPUVE.Name = "lblREPUVE"
        Me.lblREPUVE.Size = New System.Drawing.Size(54, 17)
        Me.lblREPUVE.TabIndex = 85
        Me.lblREPUVE.Text = "REPUVE:"
        '
        'txtNumChasis
        '
        Me.txtNumChasis.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumChasis.Location = New System.Drawing.Point(406, 181)
        Me.txtNumChasis.Name = "txtNumChasis"
        Me.txtNumChasis.Size = New System.Drawing.Size(123, 22)
        Me.txtNumChasis.TabIndex = 82
        Me.txtNumChasis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumChasis
        '
        Me.lblNumChasis.AutoSize = True
        Me.lblNumChasis.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumChasis.ForeColor = System.Drawing.Color.Black
        Me.lblNumChasis.Location = New System.Drawing.Point(403, 161)
        Me.lblNumChasis.Name = "lblNumChasis"
        Me.lblNumChasis.Size = New System.Drawing.Size(90, 17)
        Me.lblNumChasis.TabIndex = 83
        Me.lblNumChasis.Text = "No. de Chasis:"
        '
        'txtNumMotor
        '
        Me.txtNumMotor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumMotor.Location = New System.Drawing.Point(274, 181)
        Me.txtNumMotor.Name = "txtNumMotor"
        Me.txtNumMotor.Size = New System.Drawing.Size(126, 22)
        Me.txtNumMotor.TabIndex = 80
        Me.txtNumMotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumMotor
        '
        Me.lblNumMotor.AutoSize = True
        Me.lblNumMotor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMotor.ForeColor = System.Drawing.Color.Black
        Me.lblNumMotor.Location = New System.Drawing.Point(271, 161)
        Me.lblNumMotor.Name = "lblNumMotor"
        Me.lblNumMotor.Size = New System.Drawing.Size(89, 17)
        Me.lblNumMotor.TabIndex = 81
        Me.lblNumMotor.Text = "No. de Motor:"
        '
        'lblAgencia
        '
        Me.lblAgencia.AutoSize = True
        Me.lblAgencia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgencia.ForeColor = System.Drawing.Color.Black
        Me.lblAgencia.Location = New System.Drawing.Point(355, 46)
        Me.lblAgencia.Name = "lblAgencia"
        Me.lblAgencia.Size = New System.Drawing.Size(62, 17)
        Me.lblAgencia.TabIndex = 79
        Me.lblAgencia.Text = "Agencia:"
        '
        'txtKms
        '
        Me.txtKms.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKms.Location = New System.Drawing.Point(214, 181)
        Me.txtKms.Name = "txtKms"
        Me.txtKms.Size = New System.Drawing.Size(51, 22)
        Me.txtKms.TabIndex = 76
        Me.txtKms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblKms
        '
        Me.lblKms.AutoSize = True
        Me.lblKms.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKms.ForeColor = System.Drawing.Color.Black
        Me.lblKms.Location = New System.Drawing.Point(211, 161)
        Me.lblKms.Name = "lblKms"
        Me.lblKms.Size = New System.Drawing.Size(37, 17)
        Me.lblKms.TabIndex = 77
        Me.lblKms.Text = "Kms.:"
        '
        'txtFactura
        '
        Me.txtFactura.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(699, 181)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(112, 22)
        Me.txtFactura.TabIndex = 74
        Me.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.ForeColor = System.Drawing.Color.Black
        Me.lblFactura.Location = New System.Drawing.Point(696, 161)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(57, 17)
        Me.lblFactura.TabIndex = 75
        Me.lblFactura.Text = "Factura:"
        '
        'txtPlacas
        '
        Me.txtPlacas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlacas.Location = New System.Drawing.Point(355, 124)
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.Size = New System.Drawing.Size(67, 22)
        Me.txtPlacas.TabIndex = 72
        Me.txtPlacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPlacas
        '
        Me.lblPlacas.AutoSize = True
        Me.lblPlacas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlacas.ForeColor = System.Drawing.Color.Black
        Me.lblPlacas.Location = New System.Drawing.Point(352, 104)
        Me.lblPlacas.Name = "lblPlacas"
        Me.lblPlacas.Size = New System.Drawing.Size(50, 17)
        Me.lblPlacas.TabIndex = 73
        Me.lblPlacas.Text = "Placas:"
        '
        'txtAnio
        '
        Me.txtAnio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.Location = New System.Drawing.Point(214, 124)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(67, 22)
        Me.txtAnio.TabIndex = 70
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.ForeColor = System.Drawing.Color.Black
        Me.lblAnio.Location = New System.Drawing.Point(211, 104)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(35, 17)
        Me.lblAnio.TabIndex = 71
        Me.lblAnio.Text = "Año:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnNuevo.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.Location = New System.Drawing.Point(7, 173)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(195, 30)
        Me.btnNuevo.TabIndex = 69
        Me.btnNuevo.Text = "+ Nuevo Auto"
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalir.Location = New System.Drawing.Point(690, 359)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(170, 30)
        Me.btnSalir.TabIndex = 68
        Me.btnSalir.Text = "CERRAR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregar.Location = New System.Drawing.Point(543, 359)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(141, 30)
        Me.btnAgregar.TabIndex = 67
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cmbModelo
        '
        Me.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModelo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModelo.FormattingEnabled = True
        Me.cmbModelo.Location = New System.Drawing.Point(750, 66)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(97, 25)
        Me.cmbModelo.TabIndex = 66
        '
        'lblCantidadPrestamoMax
        '
        Me.lblCantidadPrestamoMax.AutoSize = True
        Me.lblCantidadPrestamoMax.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadPrestamoMax.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidadPrestamoMax.Location = New System.Drawing.Point(22, 239)
        Me.lblCantidadPrestamoMax.Name = "lblCantidadPrestamoMax"
        Me.lblCantidadPrestamoMax.Size = New System.Drawing.Size(49, 19)
        Me.lblCantidadPrestamoMax.TabIndex = 63
        Me.lblCantidadPrestamoMax.Text = "$0.00"
        Me.lblCantidadPrestamoMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrestamoMax
        '
        Me.lblPrestamoMax.AutoSize = True
        Me.lblPrestamoMax.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrestamoMax.ForeColor = System.Drawing.Color.Navy
        Me.lblPrestamoMax.Location = New System.Drawing.Point(21, 218)
        Me.lblPrestamoMax.Name = "lblPrestamoMax"
        Me.lblPrestamoMax.Size = New System.Drawing.Size(143, 18)
        Me.lblPrestamoMax.TabIndex = 62
        Me.lblPrestamoMax.Text = "Prestamo Maximo:"
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(284, 124)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(65, 22)
        Me.txtColor.TabIndex = 60
        Me.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.ForeColor = System.Drawing.Color.Black
        Me.lblColor.Location = New System.Drawing.Point(281, 104)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(43, 17)
        Me.lblColor.TabIndex = 61
        Me.lblColor.Text = "Color:"
        '
        'txtAvaluo
        '
        Me.txtAvaluo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvaluo.ForeColor = System.Drawing.Color.Navy
        Me.txtAvaluo.Location = New System.Drawing.Point(67, 321)
        Me.txtAvaluo.Name = "txtAvaluo"
        Me.txtAvaluo.Size = New System.Drawing.Size(134, 22)
        Me.txtAvaluo.TabIndex = 56
        Me.txtAvaluo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvaluo
        '
        Me.lblAvaluo.AutoSize = True
        Me.lblAvaluo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvaluo.ForeColor = System.Drawing.Color.Black
        Me.lblAvaluo.Location = New System.Drawing.Point(7, 324)
        Me.lblAvaluo.Name = "lblAvaluo"
        Me.lblAvaluo.Size = New System.Drawing.Size(54, 17)
        Me.lblAvaluo.TabIndex = 57
        Me.lblAvaluo.Text = "Avalúo:"
        '
        'lblDescripcionVehiculo
        '
        Me.lblDescripcionVehiculo.AutoSize = True
        Me.lblDescripcionVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionVehiculo.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcionVehiculo.Location = New System.Drawing.Point(210, 275)
        Me.lblDescripcionVehiculo.Name = "lblDescripcionVehiculo"
        Me.lblDescripcionVehiculo.Size = New System.Drawing.Size(159, 17)
        Me.lblDescripcionVehiculo.TabIndex = 55
        Me.lblDescripcionVehiculo.Text = "Descripción del vehículo:"
        '
        'txtDescripcionVehiculo
        '
        Me.txtDescripcionVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionVehiculo.Location = New System.Drawing.Point(211, 295)
        Me.txtDescripcionVehiculo.Multiline = True
        Me.txtDescripcionVehiculo.Name = "txtDescripcionVehiculo"
        Me.txtDescripcionVehiculo.Size = New System.Drawing.Size(612, 55)
        Me.txtDescripcionVehiculo.TabIndex = 54
        '
        'txtPrecioMax
        '
        Me.txtPrecioMax.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioMax.Location = New System.Drawing.Point(39, 289)
        Me.txtPrecioMax.Name = "txtPrecioMax"
        Me.txtPrecioMax.Size = New System.Drawing.Size(162, 26)
        Me.txtPrecioMax.TabIndex = 51
        Me.txtPrecioMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbMarca
        '
        Me.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarca.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(617, 66)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(127, 25)
        Me.cmbMarca.TabIndex = 49
        '
        'txtTipoEmpenio
        '
        Me.txtTipoEmpenio.Enabled = False
        Me.txtTipoEmpenio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoEmpenio.Location = New System.Drawing.Point(297, 8)
        Me.txtTipoEmpenio.Name = "txtTipoEmpenio"
        Me.txtTipoEmpenio.Size = New System.Drawing.Size(140, 23)
        Me.txtTipoEmpenio.TabIndex = 53
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.Black
        Me.lblMarca.Location = New System.Drawing.Point(614, 47)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(50, 17)
        Me.lblMarca.TabIndex = 48
        Me.lblMarca.Text = "Marca:"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.ForeColor = System.Drawing.Color.Black
        Me.lblModelo.Location = New System.Drawing.Point(747, 45)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(57, 17)
        Me.lblModelo.TabIndex = 50
        Me.lblModelo.Text = "Modelo:"
        '
        'cmbTipoMercancia
        '
        Me.cmbTipoMercancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoMercancia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoMercancia.FormattingEnabled = True
        Me.cmbTipoMercancia.Location = New System.Drawing.Point(214, 66)
        Me.cmbTipoMercancia.Name = "cmbTipoMercancia"
        Me.cmbTipoMercancia.Size = New System.Drawing.Size(138, 25)
        Me.cmbTipoMercancia.TabIndex = 47
        '
        'lblMercancia
        '
        Me.lblMercancia.AutoSize = True
        Me.lblMercancia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMercancia.ForeColor = System.Drawing.Color.Black
        Me.lblMercancia.Location = New System.Drawing.Point(211, 11)
        Me.lblMercancia.Name = "lblMercancia"
        Me.lblMercancia.Size = New System.Drawing.Size(80, 17)
        Me.lblMercancia.TabIndex = 45
        Me.lblMercancia.Text = "Mercancía:"
        '
        'lblTipoMercancia
        '
        Me.lblTipoMercancia.AutoSize = True
        Me.lblTipoMercancia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMercancia.ForeColor = System.Drawing.Color.Black
        Me.lblTipoMercancia.Location = New System.Drawing.Point(210, 46)
        Me.lblTipoMercancia.Name = "lblTipoMercancia"
        Me.lblTipoMercancia.Size = New System.Drawing.Size(88, 17)
        Me.lblTipoMercancia.TabIndex = 46
        Me.lblTipoMercancia.Text = "Clasificación:"
        '
        'lblPrecioMaximo
        '
        Me.lblPrecioMaximo.AutoSize = True
        Me.lblPrecioMaximo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioMaximo.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioMaximo.Location = New System.Drawing.Point(36, 269)
        Me.lblPrecioMaximo.Name = "lblPrecioMaximo"
        Me.lblPrecioMaximo.Size = New System.Drawing.Size(67, 17)
        Me.lblPrecioMaximo.TabIndex = 52
        Me.lblPrecioMaximo.Text = "Prestamo:"
        '
        'pbImagen
        '
        Me.pbImagen.Image = CType(resources.GetObject("pbImagen.Image"), System.Drawing.Image)
        Me.pbImagen.Location = New System.Drawing.Point(7, 3)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(194, 167)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 0
        Me.pbImagen.TabStop = False
        '
        'frmSeleccionVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(870, 445)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeleccionVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSeleccionVehiculo"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents pbImagen As PictureBox
    Public WithEvents cmbModelo As ComboBox
    Public WithEvents lblCantidadPrestamoMax As Label
    Friend WithEvents lblPrestamoMax As Label
    Public WithEvents txtColor As TextBox
    Friend WithEvents lblColor As Label
    Public WithEvents txtAvaluo As TextBox
    Friend WithEvents lblAvaluo As Label
    Friend WithEvents lblDescripcionVehiculo As Label
    Public WithEvents txtDescripcionVehiculo As TextBox
    Public WithEvents txtPrecioMax As TextBox
    Public WithEvents cmbMarca As ComboBox
    Public WithEvents txtTipoEmpenio As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblModelo As Label
    Public WithEvents cmbTipoMercancia As ComboBox
    Friend WithEvents lblMercancia As Label
    Friend WithEvents lblTipoMercancia As Label
    Friend WithEvents lblPrecioMaximo As Label
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregar As Button
    Public WithEvents cmbNivelCombustible As ComboBox
    Public WithEvents cmbTipoMotor As ComboBox
    Public WithEvents cmbAgencia As ComboBox
    Public WithEvents txtFechaVenc As TextBox
    Friend WithEvents lblFechaVenc As Label
    Public WithEvents txtNoPoliza As TextBox
    Friend WithEvents lblPoliza As Label
    Public WithEvents txtAseguradora As TextBox
    Friend WithEvents lblAseguradora As Label
    Public WithEvents txtNumTarjetaCirculacion As TextBox
    Friend WithEvents lblTarjetaCirculacion As Label
    Friend WithEvents lblNivelComb As Label
    Friend WithEvents lblTipoMotor As Label
    Public WithEvents txtREPUVE As TextBox
    Friend WithEvents lblREPUVE As Label
    Public WithEvents txtNumChasis As TextBox
    Friend WithEvents lblNumChasis As Label
    Public WithEvents txtNumMotor As TextBox
    Friend WithEvents lblNumMotor As Label
    Friend WithEvents lblAgencia As Label
    Public WithEvents txtKms As TextBox
    Friend WithEvents lblKms As Label
    Public WithEvents txtFactura As TextBox
    Friend WithEvents lblFactura As Label
    Public WithEvents txtPlacas As TextBox
    Friend WithEvents lblPlacas As Label
    Public WithEvents txtAnio As TextBox
    Friend WithEvents lblAnio As Label
    Public WithEvents cmbTipoFamilia As ComboBox
    Friend WithEvents lblTipo As Label
End Class
