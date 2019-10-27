<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionMciasElectronicas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionMciasElectronicas))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtTipoEmpenio = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblPrecioMaximo = New System.Windows.Forms.Label()
        Me.txtPrecioMax = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.cmbFamilia = New System.Windows.Forms.ComboBox()
        Me.lblFamilia = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.PanelContenedorMercancias = New System.Windows.Forms.Panel()
        Me.cmbModelo = New System.Windows.Forms.ComboBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.lblNoSerie = New System.Windows.Forms.Label()
        Me.lblPrestamoCantidadMax = New System.Windows.Forms.Label()
        Me.lblPrestamoMax = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtTamanio = New System.Windows.Forms.TextBox()
        Me.lblTamanio = New System.Windows.Forms.Label()
        Me.txtAvaluo = New System.Windows.Forms.TextBox()
        Me.lblAvaluo = New System.Windows.Forms.Label()
        Me.lblDescripcionPrenda = New System.Windows.Forms.Label()
        Me.txtDescripcionPrenda = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedorMercancias.SuspendLayout()
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
        Me.PanelTitulo.Size = New System.Drawing.Size(769, 30)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(741, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 31
        Me.btnCerrar.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitulo.Location = New System.Drawing.Point(17, 6)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(328, 20)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "SELECCIONA LA MERCANCÍA ELECTRÓNICA"
        '
        'txtTipoEmpenio
        '
        Me.txtTipoEmpenio.Enabled = False
        Me.txtTipoEmpenio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoEmpenio.Location = New System.Drawing.Point(16, 33)
        Me.txtTipoEmpenio.Name = "txtTipoEmpenio"
        Me.txtTipoEmpenio.Size = New System.Drawing.Size(140, 23)
        Me.txtTipoEmpenio.TabIndex = 29
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
        Me.btnSalir.Location = New System.Drawing.Point(566, 264)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(203, 30)
        Me.btnSalir.TabIndex = 28
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
        Me.btnAgregar.Location = New System.Drawing.Point(566, 228)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(203, 30)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblPrecioMaximo
        '
        Me.lblPrecioMaximo.AutoSize = True
        Me.lblPrecioMaximo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioMaximo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPrecioMaximo.Location = New System.Drawing.Point(20, 126)
        Me.lblPrecioMaximo.Name = "lblPrecioMaximo"
        Me.lblPrecioMaximo.Size = New System.Drawing.Size(73, 17)
        Me.lblPrecioMaximo.TabIndex = 26
        Me.lblPrecioMaximo.Text = "Prestamo:"
        '
        'txtPrecioMax
        '
        Me.txtPrecioMax.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioMax.Location = New System.Drawing.Point(18, 146)
        Me.txtPrecioMax.Name = "txtPrecioMax"
        Me.txtPrecioMax.Size = New System.Drawing.Size(117, 23)
        Me.txtPrecioMax.TabIndex = 25
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblModelo.Location = New System.Drawing.Point(448, 12)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(61, 17)
        Me.lblModelo.TabIndex = 24
        Me.lblModelo.Text = "Modelo:"
        '
        'cmbMarca
        '
        Me.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(318, 32)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(127, 25)
        Me.cmbMarca.TabIndex = 22
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMarca.Location = New System.Drawing.Point(315, 13)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(53, 17)
        Me.lblMarca.TabIndex = 21
        Me.lblMarca.Text = "Marca:"
        '
        'cmbFamilia
        '
        Me.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFamilia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.Location = New System.Drawing.Point(162, 32)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(150, 25)
        Me.cmbFamilia.TabIndex = 20
        '
        'lblFamilia
        '
        Me.lblFamilia.AutoSize = True
        Me.lblFamilia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamilia.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblFamilia.Location = New System.Drawing.Point(159, 12)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(58, 17)
        Me.lblFamilia.TabIndex = 19
        Me.lblFamilia.Text = "Familia:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTipo.Location = New System.Drawing.Point(13, 13)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(38, 17)
        Me.lblTipo.TabIndex = 18
        Me.lblTipo.Text = "Tipo:"
        '
        'pbImagen
        '
        Me.pbImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbImagen.Image = CType(resources.GetObject("pbImagen.Image"), System.Drawing.Image)
        Me.pbImagen.Location = New System.Drawing.Point(566, 36)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(191, 153)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 30
        Me.pbImagen.TabStop = False
        '
        'PanelContenedorMercancias
        '
        Me.PanelContenedorMercancias.BackColor = System.Drawing.Color.DarkGreen
        Me.PanelContenedorMercancias.Controls.Add(Me.cmbModelo)
        Me.PanelContenedorMercancias.Controls.Add(Me.txtSerie)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblNoSerie)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblPrestamoCantidadMax)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblPrestamoMax)
        Me.PanelContenedorMercancias.Controls.Add(Me.txtColor)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblColor)
        Me.PanelContenedorMercancias.Controls.Add(Me.txtTamanio)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblTamanio)
        Me.PanelContenedorMercancias.Controls.Add(Me.txtAvaluo)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblAvaluo)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblDescripcionPrenda)
        Me.PanelContenedorMercancias.Controls.Add(Me.txtDescripcionPrenda)
        Me.PanelContenedorMercancias.Controls.Add(Me.txtPrecioMax)
        Me.PanelContenedorMercancias.Controls.Add(Me.cmbMarca)
        Me.PanelContenedorMercancias.Controls.Add(Me.txtTipoEmpenio)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblMarca)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblModelo)
        Me.PanelContenedorMercancias.Controls.Add(Me.cmbFamilia)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblTipo)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblFamilia)
        Me.PanelContenedorMercancias.Controls.Add(Me.lblPrecioMaximo)
        Me.PanelContenedorMercancias.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelContenedorMercancias.Location = New System.Drawing.Point(0, 30)
        Me.PanelContenedorMercancias.Name = "PanelContenedorMercancias"
        Me.PanelContenedorMercancias.Size = New System.Drawing.Size(560, 276)
        Me.PanelContenedorMercancias.TabIndex = 31
        '
        'cmbModelo
        '
        Me.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbModelo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModelo.FormattingEnabled = True
        Me.cmbModelo.Location = New System.Drawing.Point(451, 33)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(97, 25)
        Me.cmbModelo.TabIndex = 44
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(261, 88)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(216, 23)
        Me.txtSerie.TabIndex = 42
        '
        'lblNoSerie
        '
        Me.lblNoSerie.AutoSize = True
        Me.lblNoSerie.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoSerie.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblNoSerie.Location = New System.Drawing.Point(258, 68)
        Me.lblNoSerie.Name = "lblNoSerie"
        Me.lblNoSerie.Size = New System.Drawing.Size(68, 17)
        Me.lblNoSerie.TabIndex = 43
        Me.lblNoSerie.Text = "No. Serie:"
        '
        'lblPrestamoCantidadMax
        '
        Me.lblPrestamoCantidadMax.AutoSize = True
        Me.lblPrestamoCantidadMax.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrestamoCantidadMax.ForeColor = System.Drawing.Color.Yellow
        Me.lblPrestamoCantidadMax.Location = New System.Drawing.Point(188, 148)
        Me.lblPrestamoCantidadMax.Name = "lblPrestamoCantidadMax"
        Me.lblPrestamoCantidadMax.Size = New System.Drawing.Size(49, 19)
        Me.lblPrestamoCantidadMax.TabIndex = 41
        Me.lblPrestamoCantidadMax.Text = "$0.00"
        Me.lblPrestamoCantidadMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrestamoMax
        '
        Me.lblPrestamoMax.AutoSize = True
        Me.lblPrestamoMax.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrestamoMax.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPrestamoMax.Location = New System.Drawing.Point(164, 126)
        Me.lblPrestamoMax.Name = "lblPrestamoMax"
        Me.lblPrestamoMax.Size = New System.Drawing.Size(117, 17)
        Me.lblPrestamoMax.TabIndex = 40
        Me.lblPrestamoMax.Text = "Prestamo Maximo:"
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(143, 88)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(112, 23)
        Me.txtColor.TabIndex = 38
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblColor.Location = New System.Drawing.Point(140, 68)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(48, 17)
        Me.lblColor.TabIndex = 39
        Me.lblColor.Text = "Color:"
        '
        'txtTamanio
        '
        Me.txtTamanio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTamanio.Location = New System.Drawing.Point(17, 88)
        Me.txtTamanio.Name = "txtTamanio"
        Me.txtTamanio.Size = New System.Drawing.Size(116, 23)
        Me.txtTamanio.TabIndex = 36
        '
        'lblTamanio
        '
        Me.lblTamanio.AutoSize = True
        Me.lblTamanio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamanio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTamanio.Location = New System.Drawing.Point(18, 68)
        Me.lblTamanio.Name = "lblTamanio"
        Me.lblTamanio.Size = New System.Drawing.Size(65, 17)
        Me.lblTamanio.TabIndex = 37
        Me.lblTamanio.Text = "Tamaño:"
        '
        'txtAvaluo
        '
        Me.txtAvaluo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvaluo.ForeColor = System.Drawing.Color.Navy
        Me.txtAvaluo.Location = New System.Drawing.Point(442, 146)
        Me.txtAvaluo.Name = "txtAvaluo"
        Me.txtAvaluo.Size = New System.Drawing.Size(106, 23)
        Me.txtAvaluo.TabIndex = 32
        '
        'lblAvaluo
        '
        Me.lblAvaluo.AutoSize = True
        Me.lblAvaluo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvaluo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAvaluo.Location = New System.Drawing.Point(439, 126)
        Me.lblAvaluo.Name = "lblAvaluo"
        Me.lblAvaluo.Size = New System.Drawing.Size(58, 17)
        Me.lblAvaluo.TabIndex = 33
        Me.lblAvaluo.Text = "Avalúo:"
        '
        'lblDescripcionPrenda
        '
        Me.lblDescripcionPrenda.AutoSize = True
        Me.lblDescripcionPrenda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionPrenda.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDescripcionPrenda.Location = New System.Drawing.Point(15, 193)
        Me.lblDescripcionPrenda.Name = "lblDescripcionPrenda"
        Me.lblDescripcionPrenda.Size = New System.Drawing.Size(175, 17)
        Me.lblDescripcionPrenda.TabIndex = 31
        Me.lblDescripcionPrenda.Text = "Descripción de la prenda:"
        '
        'txtDescripcionPrenda
        '
        Me.txtDescripcionPrenda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionPrenda.Location = New System.Drawing.Point(16, 213)
        Me.txtDescripcionPrenda.Multiline = True
        Me.txtDescripcionPrenda.Name = "txtDescripcionPrenda"
        Me.txtDescripcionPrenda.Size = New System.Drawing.Size(532, 47)
        Me.txtDescripcionPrenda.TabIndex = 30
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.Location = New System.Drawing.Point(566, 192)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(203, 30)
        Me.btnNuevo.TabIndex = 32
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'frmSeleccionMciasElectronicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(769, 306)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.PanelContenedorMercancias)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeleccionMciasElectronicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSeleccionMciasElectronicas"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedorMercancias.ResumeLayout(False)
        Me.PanelContenedorMercancias.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblPrecioMaximo As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblFamilia As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents PanelContenedorMercancias As Panel
    Friend WithEvents lblNoSerie As Label
    Friend WithEvents lblPrestamoMax As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblTamanio As Label
    Friend WithEvents lblAvaluo As Label
    Friend WithEvents lblDescripcionPrenda As Label
    Friend WithEvents btnNuevo As Button
    Public WithEvents txtTipoEmpenio As TextBox
    Public WithEvents txtPrecioMax As TextBox
    Public WithEvents cmbMarca As ComboBox
    Public WithEvents cmbFamilia As ComboBox
    Public WithEvents txtSerie As TextBox
    Public WithEvents lblPrestamoCantidadMax As Label
    Public WithEvents txtColor As TextBox
    Public WithEvents txtTamanio As TextBox
    Public WithEvents txtAvaluo As TextBox
    Public WithEvents txtDescripcionPrenda As TextBox
    Public WithEvents cmbModelo As ComboBox
End Class
