<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModificarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarCliente))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.PictureBox()
        Me.pblogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.txtFechaNac = New System.Windows.Forms.TextBox()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.txtNumInt = New System.Windows.Forms.TextBox()
        Me.lblNumInt = New System.Windows.Forms.Label()
        Me.txtNumExt = New System.Windows.Forms.TextBox()
        Me.lblNumExt = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.lblAMaterno = New System.Windows.Forms.Label()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.lblAPaterno = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtAlerta = New System.Windows.Forms.TextBox()
        Me.lblAlerta = New System.Windows.Forms.Label()
        Me.lblMediosEnterado = New System.Windows.Forms.Label()
        Me.cmbMediosEnterado = New System.Windows.Forms.ComboBox()
        Me.cmbIdentificacion = New System.Windows.Forms.ComboBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.cmbOcupacion = New System.Windows.Forms.ComboBox()
        Me.cmbTipoTelefono = New System.Windows.Forms.ComboBox()
        Me.txtNumIdent = New System.Windows.Forms.TextBox()
        Me.lblNumIdent = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnSalir)
        Me.PanelTitulo.Controls.Add(Me.pblogo)
        Me.PanelTitulo.Controls.Add(Me.Label1)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(922, 30)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(903, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(16, 16)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.TabStop = False
        '
        'pblogo
        '
        Me.pblogo.Image = CType(resources.GetObject("pblogo.Image"), System.Drawing.Image)
        Me.pblogo.Location = New System.Drawing.Point(3, 3)
        Me.pblogo.Name = "pblogo"
        Me.pblogo.Size = New System.Drawing.Size(25, 25)
        Me.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pblogo.TabIndex = 1
        Me.pblogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(30, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EDITAR CLIENTE"
        '
        'cmbSexo
        '
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Location = New System.Drawing.Point(28, 254)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(148, 21)
        Me.cmbSexo.TabIndex = 61
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(25, 234)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(40, 17)
        Me.lblSexo.TabIndex = 60
        Me.lblSexo.Text = "Sexo:"
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNac.Location = New System.Drawing.Point(755, 196)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(148, 21)
        Me.txtFechaNac.TabIndex = 59
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(753, 176)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(121, 17)
        Me.lblFechaNacimiento.TabIndex = 58
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudad.Location = New System.Drawing.Point(598, 176)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(117, 17)
        Me.lblCiudad.TabIndex = 57
        Me.lblCiudad.Text = "Municipio/Ciudad:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(444, 176)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(51, 17)
        Me.lblEstado.TabIndex = 56
        Me.lblEstado.Text = "Estado:"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.Location = New System.Drawing.Point(290, 176)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(34, 17)
        Me.lblPais.TabIndex = 55
        Me.lblPais.Text = "Pais:"
        '
        'cmbCiudad
        '
        Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(601, 197)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(148, 21)
        Me.cmbCiudad.TabIndex = 54
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(447, 197)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(148, 21)
        Me.cmbEstado.TabIndex = 53
        '
        'cmbPais
        '
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(293, 197)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(148, 21)
        Me.cmbPais.TabIndex = 52
        '
        'txtCP
        '
        Me.txtCP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(210, 196)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(77, 21)
        Me.txtCP.TabIndex = 51
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(207, 176)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(33, 17)
        Me.lblCP.TabIndex = 50
        Me.lblCP.Text = "C.P.:"
        '
        'txtColonia
        '
        Me.txtColonia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColonia.Location = New System.Drawing.Point(28, 196)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(176, 21)
        Me.txtColonia.TabIndex = 49
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(25, 176)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(57, 17)
        Me.lblColonia.TabIndex = 48
        Me.lblColonia.Text = "Colonia:"
        '
        'txtNumInt
        '
        Me.txtNumInt.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumInt.Location = New System.Drawing.Point(832, 145)
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(56, 21)
        Me.txtNumInt.TabIndex = 47
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumInt.Location = New System.Drawing.Point(829, 125)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(59, 17)
        Me.lblNumInt.TabIndex = 46
        Me.lblNumInt.Text = "Num Int.:"
        '
        'txtNumExt
        '
        Me.txtNumExt.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumExt.Location = New System.Drawing.Point(756, 145)
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(58, 21)
        Me.txtNumExt.TabIndex = 45
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumExt.Location = New System.Drawing.Point(753, 125)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(61, 17)
        Me.lblNumExt.TabIndex = 44
        Me.lblNumExt.Text = "Num Ext.:"
        '
        'txtCalle
        '
        Me.txtCalle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalle.Location = New System.Drawing.Point(574, 145)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(176, 21)
        Me.txtCalle.TabIndex = 43
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(571, 125)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(42, 17)
        Me.lblCalle.TabIndex = 42
        Me.lblCalle.Text = "Calle:"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(392, 145)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(176, 21)
        Me.txtApellidoMaterno.TabIndex = 41
        '
        'lblAMaterno
        '
        Me.lblAMaterno.AutoSize = True
        Me.lblAMaterno.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMaterno.Location = New System.Drawing.Point(389, 125)
        Me.lblAMaterno.Name = "lblAMaterno"
        Me.lblAMaterno.Size = New System.Drawing.Size(112, 17)
        Me.lblAMaterno.TabIndex = 40
        Me.lblAMaterno.Text = "ApellidoMaterno:"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(210, 145)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(176, 21)
        Me.txtApellidoPaterno.TabIndex = 39
        '
        'lblAPaterno
        '
        Me.lblAPaterno.AutoSize = True
        Me.lblAPaterno.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPaterno.Location = New System.Drawing.Point(207, 127)
        Me.lblAPaterno.Name = "lblAPaterno"
        Me.lblAPaterno.Size = New System.Drawing.Size(111, 17)
        Me.lblAPaterno.TabIndex = 38
        Me.lblAPaterno.Text = "Apellido Paterno:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(28, 145)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(176, 21)
        Me.txtNombre.TabIndex = 37
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(25, 125)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(59, 17)
        Me.lblNombre.TabIndex = 36
        Me.lblNombre.Text = "Nombre:"
        '
        'txtAlerta
        '
        Me.txtAlerta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlerta.Location = New System.Drawing.Point(28, 371)
        Me.txtAlerta.Name = "txtAlerta"
        Me.txtAlerta.Size = New System.Drawing.Size(875, 21)
        Me.txtAlerta.TabIndex = 76
        '
        'lblAlerta
        '
        Me.lblAlerta.AutoSize = True
        Me.lblAlerta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlerta.Location = New System.Drawing.Point(25, 351)
        Me.lblAlerta.Name = "lblAlerta"
        Me.lblAlerta.Size = New System.Drawing.Size(53, 17)
        Me.lblAlerta.TabIndex = 75
        Me.lblAlerta.Text = "ALERTA:"
        '
        'lblMediosEnterado
        '
        Me.lblMediosEnterado.AutoSize = True
        Me.lblMediosEnterado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMediosEnterado.Location = New System.Drawing.Point(425, 295)
        Me.lblMediosEnterado.Name = "lblMediosEnterado"
        Me.lblMediosEnterado.Size = New System.Drawing.Size(106, 17)
        Me.lblMediosEnterado.TabIndex = 74
        Me.lblMediosEnterado.Text = "Medio Enterado:"
        '
        'cmbMediosEnterado
        '
        Me.cmbMediosEnterado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMediosEnterado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMediosEnterado.FormattingEnabled = True
        Me.cmbMediosEnterado.Location = New System.Drawing.Point(428, 315)
        Me.cmbMediosEnterado.Name = "cmbMediosEnterado"
        Me.cmbMediosEnterado.Size = New System.Drawing.Size(167, 21)
        Me.cmbMediosEnterado.TabIndex = 73
        '
        'cmbIdentificacion
        '
        Me.cmbIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbIdentificacion.FormattingEnabled = True
        Me.cmbIdentificacion.Location = New System.Drawing.Point(480, 255)
        Me.cmbIdentificacion.Name = "cmbIdentificacion"
        Me.cmbIdentificacion.Size = New System.Drawing.Size(164, 21)
        Me.cmbIdentificacion.TabIndex = 72
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(200, 315)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(217, 21)
        Me.txtCorreo.TabIndex = 71
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(197, 295)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(52, 17)
        Me.lblCorreo.TabIndex = 70
        Me.lblCorreo.Text = "Correo:"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(25, 295)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(78, 17)
        Me.lblOcupacion.TabIndex = 69
        Me.lblOcupacion.Text = "Ocupacion:"
        '
        'cmbOcupacion
        '
        Me.cmbOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOcupacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOcupacion.FormattingEnabled = True
        Me.cmbOcupacion.Location = New System.Drawing.Point(28, 315)
        Me.cmbOcupacion.Name = "cmbOcupacion"
        Me.cmbOcupacion.Size = New System.Drawing.Size(166, 21)
        Me.cmbOcupacion.TabIndex = 68
        '
        'cmbTipoTelefono
        '
        Me.cmbTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoTelefono.FormattingEnabled = True
        Me.cmbTipoTelefono.Location = New System.Drawing.Point(354, 255)
        Me.cmbTipoTelefono.Name = "cmbTipoTelefono"
        Me.cmbTipoTelefono.Size = New System.Drawing.Size(120, 21)
        Me.cmbTipoTelefono.TabIndex = 67
        '
        'txtNumIdent
        '
        Me.txtNumIdent.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumIdent.Location = New System.Drawing.Point(650, 255)
        Me.txtNumIdent.Name = "txtNumIdent"
        Me.txtNumIdent.Size = New System.Drawing.Size(164, 21)
        Me.txtNumIdent.TabIndex = 66
        '
        'lblNumIdent
        '
        Me.lblNumIdent.AutoSize = True
        Me.lblNumIdent.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumIdent.Location = New System.Drawing.Point(647, 234)
        Me.lblNumIdent.Name = "lblNumIdent"
        Me.lblNumIdent.Size = New System.Drawing.Size(127, 17)
        Me.lblNumIdent.TabIndex = 65
        Me.lblNumIdent.Text = "Num. Identificacion:"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentificacion.Location = New System.Drawing.Point(477, 234)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(94, 17)
        Me.lblIdentificacion.TabIndex = 64
        Me.lblIdentificacion.Text = "Identificacion:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(182, 254)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(166, 21)
        Me.txtTelefono.TabIndex = 63
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(182, 234)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(62, 17)
        Me.lblTelefono.TabIndex = 62
        Me.lblTelefono.Text = "Telefono:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(816, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
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
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(182, 416)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(259, 37)
        Me.btnGuardar.TabIndex = 79
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(447, 416)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(259, 37)
        Me.btnCerrar.TabIndex = 80
        Me.btnCerrar.Text = "SALIR"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 474)
        Me.Controls.Add(Me.btnCerrar)
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
        Me.Controls.Add(Me.cmbTipoTelefono)
        Me.Controls.Add(Me.txtNumIdent)
        Me.Controls.Add(Me.lblNumIdent)
        Me.Controls.Add(Me.lblIdentificacion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.txtFechaNac)
        Me.Controls.Add(Me.lblFechaNacimiento)
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
        Me.Name = "frmModificarCliente"
        Me.Text = "frmModificarCliente"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnSalir As PictureBox
    Friend WithEvents pblogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents txtFechaNac As TextBox
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblCiudad As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents cmbCiudad As ComboBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents lblCP As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents lblColonia As Label
    Friend WithEvents txtNumInt As TextBox
    Friend WithEvents lblNumInt As Label
    Friend WithEvents txtNumExt As TextBox
    Friend WithEvents lblNumExt As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents lblCalle As Label
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents lblAMaterno As Label
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents lblAPaterno As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtAlerta As TextBox
    Friend WithEvents lblAlerta As Label
    Friend WithEvents lblMediosEnterado As Label
    Friend WithEvents cmbMediosEnterado As ComboBox
    Friend WithEvents cmbIdentificacion As ComboBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents cmbOcupacion As ComboBox
    Friend WithEvents cmbTipoTelefono As ComboBox
    Friend WithEvents txtNumIdent As TextBox
    Friend WithEvents lblNumIdent As Label
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCerrar As Button
End Class
