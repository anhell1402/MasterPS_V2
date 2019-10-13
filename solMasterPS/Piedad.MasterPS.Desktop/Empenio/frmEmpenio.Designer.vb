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
        Me.lblTituloEmpenios = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnReimprimir = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtClientes = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblDireccionCliente = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.lblTipoIdentificacion = New System.Windows.Forms.Label()
        Me.lblNumeroIdenti = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.txtTipoIdentificacion = New System.Windows.Forms.TextBox()
        Me.lblNombreCotitular = New System.Windows.Forms.Label()
        Me.txtNombreCotitular = New System.Windows.Forms.TextBox()
        Me.lblBuscarCotitular = New System.Windows.Forms.Label()
        Me.txtBuscarCotitular = New System.Windows.Forms.TextBox()
        Me.txtDireccionCotitular = New System.Windows.Forms.TextBox()
        Me.lblDireccionCotitular = New System.Windows.Forms.Label()
        Me.lblBeneficiario = New System.Windows.Forms.Label()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.PanelTasasyPlanes = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbTipoInteres = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnEditarCotitular = New System.Windows.Forms.Button()
        Me.btnAgregarCotitular = New System.Windows.Forms.Button()
        Me.PanelMercancias = New System.Windows.Forms.Panel()
        Me.cmbTipoEmpenio = New System.Windows.Forms.ComboBox()
        Me.lblTipoMercancia = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnAltaMcia = New System.Windows.Forms.Button()
        Me.PanelTasasyPlanes.SuspendLayout()
        Me.PanelMercancias.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTituloEmpenios
        '
        Me.lblTituloEmpenios.AutoSize = True
        Me.lblTituloEmpenios.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloEmpenios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTituloEmpenios.Location = New System.Drawing.Point(463, 9)
        Me.lblTituloEmpenios.Name = "lblTituloEmpenios"
        Me.lblTituloEmpenios.Size = New System.Drawing.Size(99, 25)
        Me.lblTituloEmpenios.TabIndex = 0
        Me.lblTituloEmpenios.Text = "EMPEÑO"
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
        Me.btnGuardar.Location = New System.Drawing.Point(833, 443)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(217, 42)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        Me.txtClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientes.Location = New System.Drawing.Point(152, 41)
        Me.txtClientes.Name = "txtClientes"
        Me.txtClientes.Size = New System.Drawing.Size(225, 20)
        Me.txtClientes.TabIndex = 5
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(40, 44)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(106, 16)
        Me.lblCliente.TabIndex = 7
        Me.lblCliente.Text = "Buscar Cliente:"
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(39, 75)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(59, 17)
        Me.lblNombreCliente.TabIndex = 9
        Me.lblNombreCliente.Text = "Nombre:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Location = New System.Drawing.Point(42, 95)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(235, 20)
        Me.txtNombreCliente.TabIndex = 8
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(39, 123)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(69, 17)
        Me.lblDireccionCliente.TabIndex = 11
        Me.lblDireccionCliente.Text = "Dirección:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(42, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(419, 20)
        Me.TextBox1.TabIndex = 10
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(465, 123)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(62, 17)
        Me.lblTelefonoCliente.TabIndex = 13
        Me.lblTelefonoCliente.Text = "Teléfono:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(468, 143)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(166, 20)
        Me.txtTelefonoCliente.TabIndex = 12
        '
        'lblTipoIdentificacion
        '
        Me.lblTipoIdentificacion.AutoSize = True
        Me.lblTipoIdentificacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoIdentificacion.Location = New System.Drawing.Point(280, 75)
        Me.lblTipoIdentificacion.Name = "lblTipoIdentificacion"
        Me.lblTipoIdentificacion.Size = New System.Drawing.Size(140, 17)
        Me.lblTipoIdentificacion.TabIndex = 15
        Me.lblTipoIdentificacion.Text = "Tipo de Identificación:"
        '
        'lblNumeroIdenti
        '
        Me.lblNumeroIdenti.AutoSize = True
        Me.lblNumeroIdenti.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroIdenti.Location = New System.Drawing.Point(473, 75)
        Me.lblNumeroIdenti.Name = "lblNumeroIdenti"
        Me.lblNumeroIdenti.Size = New System.Drawing.Size(117, 17)
        Me.lblNumeroIdenti.TabIndex = 18
        Me.lblNumeroIdenti.Text = "No. Identificación:"
        '
        'txt
        '
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(476, 95)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(158, 20)
        Me.txt.TabIndex = 17
        '
        'txtTipoIdentificacion
        '
        Me.txtTipoIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoIdentificacion.Location = New System.Drawing.Point(283, 95)
        Me.txtTipoIdentificacion.Name = "txtTipoIdentificacion"
        Me.txtTipoIdentificacion.Size = New System.Drawing.Size(187, 20)
        Me.txtTipoIdentificacion.TabIndex = 19
        '
        'lblNombreCotitular
        '
        Me.lblNombreCotitular.AutoSize = True
        Me.lblNombreCotitular.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCotitular.Location = New System.Drawing.Point(38, 211)
        Me.lblNombreCotitular.Name = "lblNombreCotitular"
        Me.lblNombreCotitular.Size = New System.Drawing.Size(59, 17)
        Me.lblNombreCotitular.TabIndex = 23
        Me.lblNombreCotitular.Text = "Nombre:"
        '
        'txtNombreCotitular
        '
        Me.txtNombreCotitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCotitular.Location = New System.Drawing.Point(41, 231)
        Me.txtNombreCotitular.Name = "txtNombreCotitular"
        Me.txtNombreCotitular.Size = New System.Drawing.Size(235, 20)
        Me.txtNombreCotitular.TabIndex = 22
        '
        'lblBuscarCotitular
        '
        Me.lblBuscarCotitular.AutoSize = True
        Me.lblBuscarCotitular.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarCotitular.Location = New System.Drawing.Point(39, 187)
        Me.lblBuscarCotitular.Name = "lblBuscarCotitular"
        Me.lblBuscarCotitular.Size = New System.Drawing.Size(116, 16)
        Me.lblBuscarCotitular.TabIndex = 21
        Me.lblBuscarCotitular.Text = "Buscar Cotitular:"
        '
        'txtBuscarCotitular
        '
        Me.txtBuscarCotitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCotitular.Location = New System.Drawing.Point(161, 184)
        Me.txtBuscarCotitular.Name = "txtBuscarCotitular"
        Me.txtBuscarCotitular.Size = New System.Drawing.Size(225, 20)
        Me.txtBuscarCotitular.TabIndex = 20
        '
        'txtDireccionCotitular
        '
        Me.txtDireccionCotitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionCotitular.Location = New System.Drawing.Point(282, 231)
        Me.txtDireccionCotitular.Name = "txtDireccionCotitular"
        Me.txtDireccionCotitular.Size = New System.Drawing.Size(351, 20)
        Me.txtDireccionCotitular.TabIndex = 24
        '
        'lblDireccionCotitular
        '
        Me.lblDireccionCotitular.AutoSize = True
        Me.lblDireccionCotitular.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCotitular.Location = New System.Drawing.Point(279, 211)
        Me.lblDireccionCotitular.Name = "lblDireccionCotitular"
        Me.lblDireccionCotitular.Size = New System.Drawing.Size(69, 17)
        Me.lblDireccionCotitular.TabIndex = 25
        Me.lblDireccionCotitular.Text = "Dirección:"
        '
        'lblBeneficiario
        '
        Me.lblBeneficiario.AutoSize = True
        Me.lblBeneficiario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeneficiario.Location = New System.Drawing.Point(39, 260)
        Me.lblBeneficiario.Name = "lblBeneficiario"
        Me.lblBeneficiario.Size = New System.Drawing.Size(82, 17)
        Me.lblBeneficiario.TabIndex = 27
        Me.lblBeneficiario.Text = "Beneficiario:"
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.Location = New System.Drawing.Point(127, 258)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(234, 20)
        Me.txtBeneficiario.TabIndex = 26
        '
        'PanelTasasyPlanes
        '
        Me.PanelTasasyPlanes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTasasyPlanes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTasasyPlanes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelTasasyPlanes.Controls.Add(Me.ComboBox2)
        Me.PanelTasasyPlanes.Controls.Add(Me.ComboBox1)
        Me.PanelTasasyPlanes.Controls.Add(Me.cmbTipoInteres)
        Me.PanelTasasyPlanes.Controls.Add(Me.Label9)
        Me.PanelTasasyPlanes.Controls.Add(Me.Label8)
        Me.PanelTasasyPlanes.Controls.Add(Me.Label7)
        Me.PanelTasasyPlanes.Controls.Add(Me.Label6)
        Me.PanelTasasyPlanes.Controls.Add(Me.TextBox6)
        Me.PanelTasasyPlanes.Controls.Add(Me.Label5)
        Me.PanelTasasyPlanes.Controls.Add(Me.TextBox5)
        Me.PanelTasasyPlanes.Controls.Add(Me.Label4)
        Me.PanelTasasyPlanes.Controls.Add(Me.TextBox4)
        Me.PanelTasasyPlanes.Controls.Add(Me.Label3)
        Me.PanelTasasyPlanes.Controls.Add(Me.TextBox2)
        Me.PanelTasasyPlanes.Location = New System.Drawing.Point(708, 38)
        Me.PanelTasasyPlanes.Name = "PanelTasasyPlanes"
        Me.PanelTasasyPlanes.Size = New System.Drawing.Size(330, 146)
        Me.PanelTasasyPlanes.TabIndex = 28
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(252, 57)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(58, 24)
        Me.ComboBox2.TabIndex = 41
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(148, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(98, 24)
        Me.ComboBox1.TabIndex = 40
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(249, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Plazo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(145, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Periodo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(14, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Tipo Interes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(237, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Usuario"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.PaleGreen
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(213, 104)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(104, 19)
        Me.TextBox6.TabIndex = 35
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(136, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Sucursal"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.PaleGreen
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(123, 104)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(84, 19)
        Me.TextBox5.TabIndex = 33
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(17, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Interes Mensual"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.PaleGreen
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(17, 104)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 19)
        Me.TextBox4.TabIndex = 31
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(14, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Fecha Vencimiento:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.PaleGreen
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(148, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 19)
        Me.TextBox2.TabIndex = 29
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarCliente.FlatAppearance.BorderSize = 0
        Me.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarCliente.Location = New System.Drawing.Point(383, 38)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(32, 28)
        Me.btnBuscarCliente.TabIndex = 29
        Me.btnBuscarCliente.Text = "+"
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarCliente.FlatAppearance.BorderSize = 0
        Me.btnEditarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditarCliente.Location = New System.Drawing.Point(421, 38)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(60, 28)
        Me.btnEditarCliente.TabIndex = 30
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.UseVisualStyleBackColor = False
        '
        'btnEditarCotitular
        '
        Me.btnEditarCotitular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarCotitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarCotitular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarCotitular.FlatAppearance.BorderSize = 0
        Me.btnEditarCotitular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditarCotitular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEditarCotitular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCotitular.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCotitular.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditarCotitular.Location = New System.Drawing.Point(432, 181)
        Me.btnEditarCotitular.Name = "btnEditarCotitular"
        Me.btnEditarCotitular.Size = New System.Drawing.Size(60, 28)
        Me.btnEditarCotitular.TabIndex = 32
        Me.btnEditarCotitular.Text = "Editar"
        Me.btnEditarCotitular.UseVisualStyleBackColor = False
        '
        'btnAgregarCotitular
        '
        Me.btnAgregarCotitular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCotitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarCotitular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarCotitular.FlatAppearance.BorderSize = 0
        Me.btnAgregarCotitular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAgregarCotitular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAgregarCotitular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCotitular.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCotitular.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregarCotitular.Location = New System.Drawing.Point(394, 181)
        Me.btnAgregarCotitular.Name = "btnAgregarCotitular"
        Me.btnAgregarCotitular.Size = New System.Drawing.Size(32, 28)
        Me.btnAgregarCotitular.TabIndex = 31
        Me.btnAgregarCotitular.Text = "+"
        Me.btnAgregarCotitular.UseVisualStyleBackColor = False
        '
        'PanelMercancias
        '
        Me.PanelMercancias.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelMercancias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMercancias.Controls.Add(Me.btnAltaMcia)
        Me.PanelMercancias.Controls.Add(Me.TextBox7)
        Me.PanelMercancias.Controls.Add(Me.Label15)
        Me.PanelMercancias.Controls.Add(Me.Label14)
        Me.PanelMercancias.Controls.Add(Me.TextBox8)
        Me.PanelMercancias.Controls.Add(Me.Label13)
        Me.PanelMercancias.Controls.Add(Me.Label12)
        Me.PanelMercancias.Controls.Add(Me.TextBox3)
        Me.PanelMercancias.Controls.Add(Me.Label11)
        Me.PanelMercancias.Controls.Add(Me.ComboBox5)
        Me.PanelMercancias.Controls.Add(Me.Label10)
        Me.PanelMercancias.Controls.Add(Me.ComboBox4)
        Me.PanelMercancias.Controls.Add(Me.Label2)
        Me.PanelMercancias.Controls.Add(Me.ComboBox3)
        Me.PanelMercancias.Controls.Add(Me.Label1)
        Me.PanelMercancias.Controls.Add(Me.cmbTipoEmpenio)
        Me.PanelMercancias.Controls.Add(Me.lblTipoMercancia)
        Me.PanelMercancias.Location = New System.Drawing.Point(41, 296)
        Me.PanelMercancias.Name = "PanelMercancias"
        Me.PanelMercancias.Size = New System.Drawing.Size(592, 237)
        Me.PanelMercancias.TabIndex = 33
        '
        'cmbTipoEmpenio
        '
        Me.cmbTipoEmpenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEmpenio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoEmpenio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEmpenio.FormattingEnabled = True
        Me.cmbTipoEmpenio.Location = New System.Drawing.Point(82, 13)
        Me.cmbTipoEmpenio.Name = "cmbTipoEmpenio"
        Me.cmbTipoEmpenio.Size = New System.Drawing.Size(147, 24)
        Me.cmbTipoEmpenio.TabIndex = 43
        '
        'lblTipoMercancia
        '
        Me.lblTipoMercancia.AutoSize = True
        Me.lblTipoMercancia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMercancia.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTipoMercancia.Location = New System.Drawing.Point(5, 15)
        Me.lblTipoMercancia.Name = "lblTipoMercancia"
        Me.lblTipoMercancia.Size = New System.Drawing.Size(72, 17)
        Me.lblTipoMercancia.TabIndex = 42
        Me.lblTipoMercancia.Text = "Categoria:"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(82, 43)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(147, 24)
        Me.ComboBox3.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(1, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Mercancia:"
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(82, 73)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(147, 24)
        Me.ComboBox4.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(24, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Familia:"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(312, 13)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(147, 24)
        Me.ComboBox5.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(257, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Marca:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(250, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Modelo:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(312, 43)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(147, 20)
        Me.TextBox3.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(250, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 17)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Prestamo Maximo:"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(329, 203)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(130, 22)
        Me.TextBox8.TabIndex = 54
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(251, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 16)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "PRESTAMO:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(373, 167)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 19)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Label"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(8, 120)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(238, 102)
        Me.TextBox7.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(5, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 17)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Descripción:"
        '
        'btnAltaMcia
        '
        Me.btnAltaMcia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAltaMcia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAltaMcia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAltaMcia.FlatAppearance.BorderSize = 0
        Me.btnAltaMcia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAltaMcia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAltaMcia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaMcia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaMcia.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAltaMcia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAltaMcia.Location = New System.Drawing.Point(267, 73)
        Me.btnAltaMcia.Name = "btnAltaMcia"
        Me.btnAltaMcia.Size = New System.Drawing.Size(192, 24)
        Me.btnAltaMcia.TabIndex = 34
        Me.btnAltaMcia.Text = "AGREGAR"
        Me.btnAltaMcia.UseVisualStyleBackColor = False
        '
        'frmEmpenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1050, 545)
        Me.Controls.Add(Me.PanelMercancias)
        Me.Controls.Add(Me.btnEditarCotitular)
        Me.Controls.Add(Me.btnAgregarCotitular)
        Me.Controls.Add(Me.btnEditarCliente)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.PanelTasasyPlanes)
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
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.lblTipoIdentificacion)
        Me.Controls.Add(Me.lblTelefonoCliente)
        Me.Controls.Add(Me.txtTelefonoCliente)
        Me.Controls.Add(Me.lblDireccionCliente)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtClientes)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReimprimir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblTituloEmpenios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmpenio"
        Me.Text = "frmEmpenio"
        Me.PanelTasasyPlanes.ResumeLayout(False)
        Me.PanelTasasyPlanes.PerformLayout()
        Me.PanelMercancias.ResumeLayout(False)
        Me.PanelMercancias.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTituloEmpenios As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnReimprimir As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtClientes As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents lblDireccionCliente As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents lblTipoIdentificacion As Label
    Friend WithEvents lblNumeroIdenti As Label
    Friend WithEvents txt As TextBox
    Friend WithEvents txtTipoIdentificacion As TextBox
    Friend WithEvents lblNombreCotitular As Label
    Friend WithEvents txtNombreCotitular As TextBox
    Friend WithEvents lblBuscarCotitular As Label
    Friend WithEvents txtBuscarCotitular As TextBox
    Friend WithEvents txtDireccionCotitular As TextBox
    Friend WithEvents lblDireccionCotitular As Label
    Friend WithEvents lblBeneficiario As Label
    Friend WithEvents txtBeneficiario As TextBox
    Friend WithEvents PanelTasasyPlanes As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmbTipoInteres As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents btnEditarCliente As Button
    Friend WithEvents btnEditarCotitular As Button
    Friend WithEvents btnAgregarCotitular As Button
    Friend WithEvents PanelMercancias As Panel
    Friend WithEvents btnAltaMcia As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoEmpenio As ComboBox
    Friend WithEvents lblTipoMercancia As Label
End Class
