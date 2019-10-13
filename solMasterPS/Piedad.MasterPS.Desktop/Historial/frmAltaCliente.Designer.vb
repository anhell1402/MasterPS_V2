<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaCliente))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.lblAPaterno = New System.Windows.Forms.Label()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.lblAMaterno = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.txtNumExt = New System.Windows.Forms.TextBox()
        Me.lblNumExt = New System.Windows.Forms.Label()
        Me.txtNumInt = New System.Windows.Forms.TextBox()
        Me.lblNumInt = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtFechaNac = New System.Windows.Forms.TextBox()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.txtNumIdent = New System.Windows.Forms.TextBox()
        Me.lblNumIdent = New System.Windows.Forms.Label()
        Me.cmbTipoTelefono = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.cmbOcupacion = New System.Windows.Forms.ComboBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.cmbIdentificacion = New System.Windows.Forms.ComboBox()
        Me.lblMediosEnterado = New System.Windows.Forms.Label()
        Me.cmbMediosEnterado = New System.Windows.Forms.ComboBox()
        Me.txtAlerta = New System.Windows.Forms.TextBox()
        Me.lblAlerta = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblfechaRegistro = New System.Windows.Forms.Label()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Controls.Add(Me.lblTituloForm)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(489, 30)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(461, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.TabStop = False
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTituloForm.Location = New System.Drawing.Point(167, 6)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Size = New System.Drawing.Size(121, 20)
        Me.lblTituloForm.TabIndex = 0
        Me.lblTituloForm.Text = "Alta del Cliente"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(72, 58)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(59, 17)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(140, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(176, 21)
        Me.txtNombre.TabIndex = 2
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(140, 83)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(176, 21)
        Me.txtApellidoPaterno.TabIndex = 4
        '
        'lblAPaterno
        '
        Me.lblAPaterno.AutoSize = True
        Me.lblAPaterno.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPaterno.Location = New System.Drawing.Point(23, 84)
        Me.lblAPaterno.Name = "lblAPaterno"
        Me.lblAPaterno.Size = New System.Drawing.Size(111, 17)
        Me.lblAPaterno.TabIndex = 3
        Me.lblAPaterno.Text = "Apellido Paterno:"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(140, 109)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(176, 21)
        Me.txtApellidoMaterno.TabIndex = 6
        '
        'lblAMaterno
        '
        Me.lblAMaterno.AutoSize = True
        Me.lblAMaterno.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMaterno.Location = New System.Drawing.Point(22, 109)
        Me.lblAMaterno.Name = "lblAMaterno"
        Me.lblAMaterno.Size = New System.Drawing.Size(112, 17)
        Me.lblAMaterno.TabIndex = 5
        Me.lblAMaterno.Text = "ApellidoMaterno:"
        '
        'txtCalle
        '
        Me.txtCalle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalle.Location = New System.Drawing.Point(140, 135)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(176, 21)
        Me.txtCalle.TabIndex = 8
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(89, 135)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(42, 17)
        Me.lblCalle.TabIndex = 7
        Me.lblCalle.Text = "Calle:"
        '
        'txtNumExt
        '
        Me.txtNumExt.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumExt.Location = New System.Drawing.Point(140, 161)
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(58, 21)
        Me.txtNumExt.TabIndex = 10
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumExt.Location = New System.Drawing.Point(73, 161)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(61, 17)
        Me.lblNumExt.TabIndex = 9
        Me.lblNumExt.Text = "Num Ext.:"
        '
        'txtNumInt
        '
        Me.txtNumInt.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumInt.Location = New System.Drawing.Point(260, 160)
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(56, 21)
        Me.txtNumInt.TabIndex = 12
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumInt.Location = New System.Drawing.Point(201, 160)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(59, 17)
        Me.lblNumInt.TabIndex = 11
        Me.lblNumInt.Text = "Num Int.:"
        '
        'txtColonia
        '
        Me.txtColonia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColonia.Location = New System.Drawing.Point(140, 187)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(176, 21)
        Me.txtColonia.TabIndex = 14
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(77, 187)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(57, 17)
        Me.lblColonia.TabIndex = 13
        Me.lblColonia.Text = "Colonia:"
        '
        'txtCP
        '
        Me.txtCP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(140, 213)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(77, 21)
        Me.txtCP.TabIndex = 16
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(101, 214)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(33, 17)
        Me.lblCP.TabIndex = 15
        Me.lblCP.Text = "C.P.:"
        '
        'cmbPais
        '
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(140, 239)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(148, 21)
        Me.cmbPais.TabIndex = 17
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(140, 266)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(148, 21)
        Me.cmbEstado.TabIndex = 18
        '
        'cmbCiudad
        '
        Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(140, 293)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(148, 21)
        Me.cmbCiudad.TabIndex = 19
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.Location = New System.Drawing.Point(101, 240)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(34, 17)
        Me.lblPais.TabIndex = 20
        Me.lblPais.Text = "Pais:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(83, 267)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(51, 17)
        Me.lblEstado.TabIndex = 21
        Me.lblEstado.Text = "Estado:"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudad.Location = New System.Drawing.Point(14, 294)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(117, 17)
        Me.lblCiudad.TabIndex = 22
        Me.lblCiudad.Text = "Municipio/Ciudad:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(138, 373)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(166, 21)
        Me.txtTelefono.TabIndex = 24
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(67, 374)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(62, 17)
        Me.lblTelefono.TabIndex = 23
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNac.Location = New System.Drawing.Point(140, 320)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(148, 21)
        Me.txtFechaNac.TabIndex = 28
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(14, 321)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(121, 17)
        Me.lblFechaNacimiento.TabIndex = 27
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentificacion.Location = New System.Drawing.Point(40, 400)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(94, 17)
        Me.lblIdentificacion.TabIndex = 29
        Me.lblIdentificacion.Text = "Identificacion:"
        '
        'txtNumIdent
        '
        Me.txtNumIdent.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumIdent.Location = New System.Drawing.Point(140, 426)
        Me.txtNumIdent.Name = "txtNumIdent"
        Me.txtNumIdent.Size = New System.Drawing.Size(164, 21)
        Me.txtNumIdent.TabIndex = 32
        '
        'lblNumIdent
        '
        Me.lblNumIdent.AutoSize = True
        Me.lblNumIdent.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumIdent.Location = New System.Drawing.Point(7, 427)
        Me.lblNumIdent.Name = "lblNumIdent"
        Me.lblNumIdent.Size = New System.Drawing.Size(127, 17)
        Me.lblNumIdent.TabIndex = 31
        Me.lblNumIdent.Text = "Num. Identificacion:"
        '
        'cmbTipoTelefono
        '
        Me.cmbTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoTelefono.FormattingEnabled = True
        Me.cmbTipoTelefono.Location = New System.Drawing.Point(310, 372)
        Me.cmbTipoTelefono.Name = "cmbTipoTelefono"
        Me.cmbTipoTelefono.Size = New System.Drawing.Size(120, 21)
        Me.cmbTipoTelefono.TabIndex = 33
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(94, 347)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(40, 17)
        Me.lblSexo.TabIndex = 34
        Me.lblSexo.Text = "Sexo:"
        '
        'cmbSexo
        '
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Location = New System.Drawing.Point(140, 346)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(148, 21)
        Me.cmbSexo.TabIndex = 35
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(53, 453)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(78, 17)
        Me.lblOcupacion.TabIndex = 37
        Me.lblOcupacion.Text = "Ocupacion:"
        '
        'cmbOcupacion
        '
        Me.cmbOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOcupacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOcupacion.FormattingEnabled = True
        Me.cmbOcupacion.Location = New System.Drawing.Point(138, 452)
        Me.cmbOcupacion.Name = "cmbOcupacion"
        Me.cmbOcupacion.Size = New System.Drawing.Size(166, 21)
        Me.cmbOcupacion.TabIndex = 36
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(137, 479)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(217, 21)
        Me.txtCorreo.TabIndex = 39
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(79, 480)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(52, 17)
        Me.lblCorreo.TabIndex = 38
        Me.lblCorreo.Text = "Correo:"
        '
        'cmbIdentificacion
        '
        Me.cmbIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbIdentificacion.FormattingEnabled = True
        Me.cmbIdentificacion.Location = New System.Drawing.Point(140, 399)
        Me.cmbIdentificacion.Name = "cmbIdentificacion"
        Me.cmbIdentificacion.Size = New System.Drawing.Size(164, 21)
        Me.cmbIdentificacion.TabIndex = 40
        '
        'lblMediosEnterado
        '
        Me.lblMediosEnterado.AutoSize = True
        Me.lblMediosEnterado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMediosEnterado.Location = New System.Drawing.Point(25, 506)
        Me.lblMediosEnterado.Name = "lblMediosEnterado"
        Me.lblMediosEnterado.Size = New System.Drawing.Size(106, 17)
        Me.lblMediosEnterado.TabIndex = 42
        Me.lblMediosEnterado.Text = "Medio Enterado:"
        '
        'cmbMediosEnterado
        '
        Me.cmbMediosEnterado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMediosEnterado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMediosEnterado.FormattingEnabled = True
        Me.cmbMediosEnterado.Location = New System.Drawing.Point(137, 505)
        Me.cmbMediosEnterado.Name = "cmbMediosEnterado"
        Me.cmbMediosEnterado.Size = New System.Drawing.Size(167, 21)
        Me.cmbMediosEnterado.TabIndex = 41
        '
        'txtAlerta
        '
        Me.txtAlerta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlerta.Location = New System.Drawing.Point(137, 540)
        Me.txtAlerta.Multiline = True
        Me.txtAlerta.Name = "txtAlerta"
        Me.txtAlerta.Size = New System.Drawing.Size(336, 57)
        Me.txtAlerta.TabIndex = 44
        '
        'lblAlerta
        '
        Me.lblAlerta.AutoSize = True
        Me.lblAlerta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlerta.Location = New System.Drawing.Point(76, 540)
        Me.lblAlerta.Name = "lblAlerta"
        Me.lblAlerta.Size = New System.Drawing.Size(53, 17)
        Me.lblAlerta.TabIndex = 43
        Me.lblAlerta.Text = "ALERTA:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(333, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(79, 611)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(336, 33)
        Me.btnGuardar.TabIndex = 46
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblfechaRegistro
        '
        Me.lblfechaRegistro.AutoSize = True
        Me.lblfechaRegistro.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaRegistro.Location = New System.Drawing.Point(339, 213)
        Me.lblfechaRegistro.Name = "lblfechaRegistro"
        Me.lblfechaRegistro.Size = New System.Drawing.Size(91, 17)
        Me.lblfechaRegistro.TabIndex = 47
        Me.lblfechaRegistro.Text = "fechaRegistro"
        '
        'frmAltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(489, 656)
        Me.Controls.Add(Me.lblfechaRegistro)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtAlerta)
        Me.Controls.Add(Me.lblAlerta)
        Me.Controls.Add(Me.lblMediosEnterado)
        Me.Controls.Add(Me.cmbMediosEnterado)
        Me.Controls.Add(Me.cmbIdentificacion)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblOcupacion)
        Me.Controls.Add(Me.cmbOcupacion)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.cmbTipoTelefono)
        Me.Controls.Add(Me.txtNumIdent)
        Me.Controls.Add(Me.lblNumIdent)
        Me.Controls.Add(Me.lblIdentificacion)
        Me.Controls.Add(Me.txtFechaNac)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblCiudad)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.cmbCiudad)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.cmbPais)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.txtNumInt)
        Me.Controls.Add(Me.lblNumInt)
        Me.Controls.Add(Me.txtNumExt)
        Me.Controls.Add(Me.lblNumExt)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.lblAMaterno)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.lblAPaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAltaCliente"
        Me.Text = "frmAltaCliente"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblTituloForm As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents lblAPaterno As Label
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents lblAMaterno As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents lblCalle As Label
    Friend WithEvents txtNumExt As TextBox
    Friend WithEvents lblNumExt As Label
    Friend WithEvents txtNumInt As TextBox
    Friend WithEvents lblNumInt As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents lblColonia As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents lblCP As Label
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbCiudad As ComboBox
    Friend WithEvents lblPais As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblCiudad As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtFechaNac As TextBox
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents txtNumIdent As TextBox
    Friend WithEvents lblNumIdent As Label
    Friend WithEvents cmbTipoTelefono As ComboBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents cmbOcupacion As ComboBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents cmbIdentificacion As ComboBox
    Friend WithEvents lblMediosEnterado As Label
    Friend WithEvents cmbMediosEnterado As ComboBox
    Friend WithEvents txtAlerta As TextBox
    Friend WithEvents lblAlerta As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblfechaRegistro As Label
    Friend WithEvents btnCerrar As PictureBox
End Class
