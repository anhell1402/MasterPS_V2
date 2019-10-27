<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeleccionJoyeria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionJoyeria))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtAvaluo = New System.Windows.Forms.TextBox()
        Me.lblAvaluo = New System.Windows.Forms.Label()
        Me.lblPrestamoMaxCantidad = New System.Windows.Forms.Label()
        Me.lblPrestamoMaximo = New System.Windows.Forms.Label()
        Me.txtPrestamo = New System.Windows.Forms.TextBox()
        Me.lblPrestamo = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cmbTipoMetal = New System.Windows.Forms.ComboBox()
        Me.lblMetal = New System.Windows.Forms.Label()
        Me.cmbKilataje = New System.Windows.Forms.ComboBox()
        Me.txtTipoEmpenio = New System.Windows.Forms.TextBox()
        Me.lblKilataje = New System.Windows.Forms.Label()
        Me.cmbPrenda = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblPrenda = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.lblTitulo)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(297, 30)
        Me.PanelTitulo.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitulo.Location = New System.Drawing.Point(3, 7)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(207, 16)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Seleccione la prenda  a empeñar"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContenedor.Controls.Add(Me.btnCerrar)
        Me.PanelContenedor.Controls.Add(Me.btnAgregar)
        Me.PanelContenedor.Controls.Add(Me.txtDescripcion)
        Me.PanelContenedor.Controls.Add(Me.lblDescripcion)
        Me.PanelContenedor.Controls.Add(Me.txtAvaluo)
        Me.PanelContenedor.Controls.Add(Me.lblAvaluo)
        Me.PanelContenedor.Controls.Add(Me.lblPrestamoMaxCantidad)
        Me.PanelContenedor.Controls.Add(Me.lblPrestamoMaximo)
        Me.PanelContenedor.Controls.Add(Me.txtPrestamo)
        Me.PanelContenedor.Controls.Add(Me.lblPrestamo)
        Me.PanelContenedor.Controls.Add(Me.cmbEstado)
        Me.PanelContenedor.Controls.Add(Me.lblEstado)
        Me.PanelContenedor.Controls.Add(Me.cmbTipoMetal)
        Me.PanelContenedor.Controls.Add(Me.lblMetal)
        Me.PanelContenedor.Controls.Add(Me.cmbKilataje)
        Me.PanelContenedor.Controls.Add(Me.txtTipoEmpenio)
        Me.PanelContenedor.Controls.Add(Me.lblKilataje)
        Me.PanelContenedor.Controls.Add(Me.cmbPrenda)
        Me.PanelContenedor.Controls.Add(Me.lblTipo)
        Me.PanelContenedor.Controls.Add(Me.lblPrenda)
        Me.PanelContenedor.Controls.Add(Me.pbImagen)
        Me.PanelContenedor.Location = New System.Drawing.Point(5, 35)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(285, 453)
        Me.PanelContenedor.TabIndex = 1
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
        Me.btnCerrar.Location = New System.Drawing.Point(147, 415)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(134, 30)
        Me.btnCerrar.TabIndex = 49
        Me.btnCerrar.Text = "CERRAR"
        Me.btnCerrar.UseVisualStyleBackColor = False
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
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregar.Location = New System.Drawing.Point(8, 415)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(134, 30)
        Me.btnAgregar.TabIndex = 48
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(7, 371)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(265, 39)
        Me.txtDescripcion.TabIndex = 47
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.Location = New System.Drawing.Point(4, 351)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(87, 17)
        Me.lblDescripcion.TabIndex = 46
        Me.lblDescripcion.Text = "Descripción:"
        '
        'txtAvaluo
        '
        Me.txtAvaluo.Enabled = False
        Me.txtAvaluo.Location = New System.Drawing.Point(90, 321)
        Me.txtAvaluo.Name = "txtAvaluo"
        Me.txtAvaluo.Size = New System.Drawing.Size(150, 20)
        Me.txtAvaluo.TabIndex = 45
        '
        'lblAvaluo
        '
        Me.lblAvaluo.AutoSize = True
        Me.lblAvaluo.BackColor = System.Drawing.Color.Transparent
        Me.lblAvaluo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvaluo.ForeColor = System.Drawing.Color.Black
        Me.lblAvaluo.Location = New System.Drawing.Point(30, 324)
        Me.lblAvaluo.Name = "lblAvaluo"
        Me.lblAvaluo.Size = New System.Drawing.Size(58, 17)
        Me.lblAvaluo.TabIndex = 44
        Me.lblAvaluo.Text = "Avalúo:"
        '
        'lblPrestamoMaxCantidad
        '
        Me.lblPrestamoMaxCantidad.AutoSize = True
        Me.lblPrestamoMaxCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblPrestamoMaxCantidad.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrestamoMaxCantidad.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPrestamoMaxCantidad.Location = New System.Drawing.Point(161, 266)
        Me.lblPrestamoMaxCantidad.Name = "lblPrestamoMaxCantidad"
        Me.lblPrestamoMaxCantidad.Size = New System.Drawing.Size(44, 18)
        Me.lblPrestamoMaxCantidad.TabIndex = 43
        Me.lblPrestamoMaxCantidad.Text = "$0.00"
        '
        'lblPrestamoMaximo
        '
        Me.lblPrestamoMaximo.AutoSize = True
        Me.lblPrestamoMaximo.BackColor = System.Drawing.Color.Transparent
        Me.lblPrestamoMaximo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrestamoMaximo.ForeColor = System.Drawing.Color.Black
        Me.lblPrestamoMaximo.Location = New System.Drawing.Point(47, 266)
        Me.lblPrestamoMaximo.Name = "lblPrestamoMaximo"
        Me.lblPrestamoMaximo.Size = New System.Drawing.Size(117, 17)
        Me.lblPrestamoMaximo.TabIndex = 42
        Me.lblPrestamoMaximo.Text = "Prestamo Máximo:"
        '
        'txtPrestamo
        '
        Me.txtPrestamo.Location = New System.Drawing.Point(90, 295)
        Me.txtPrestamo.Name = "txtPrestamo"
        Me.txtPrestamo.Size = New System.Drawing.Size(150, 20)
        Me.txtPrestamo.TabIndex = 41
        '
        'lblPrestamo
        '
        Me.lblPrestamo.AutoSize = True
        Me.lblPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.lblPrestamo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrestamo.ForeColor = System.Drawing.Color.Black
        Me.lblPrestamo.Location = New System.Drawing.Point(15, 295)
        Me.lblPrestamo.Name = "lblPrestamo"
        Me.lblPrestamo.Size = New System.Drawing.Size(73, 17)
        Me.lblPrestamo.TabIndex = 40
        Me.lblPrestamo.Text = "Préstamo:"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(90, 233)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(150, 21)
        Me.cmbEstado.TabIndex = 39
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Black
        Me.lblEstado.Location = New System.Drawing.Point(32, 234)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(56, 17)
        Me.lblEstado.TabIndex = 38
        Me.lblEstado.Text = "Estado:"
        '
        'cmbTipoMetal
        '
        Me.cmbTipoMetal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoMetal.FormattingEnabled = True
        Me.cmbTipoMetal.Location = New System.Drawing.Point(90, 152)
        Me.cmbTipoMetal.Name = "cmbTipoMetal"
        Me.cmbTipoMetal.Size = New System.Drawing.Size(150, 21)
        Me.cmbTipoMetal.TabIndex = 37
        '
        'lblMetal
        '
        Me.lblMetal.AutoSize = True
        Me.lblMetal.BackColor = System.Drawing.Color.Transparent
        Me.lblMetal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetal.ForeColor = System.Drawing.Color.Black
        Me.lblMetal.Location = New System.Drawing.Point(40, 153)
        Me.lblMetal.Name = "lblMetal"
        Me.lblMetal.Size = New System.Drawing.Size(48, 17)
        Me.lblMetal.TabIndex = 36
        Me.lblMetal.Text = "Metal:"
        '
        'cmbKilataje
        '
        Me.cmbKilataje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKilataje.FormattingEnabled = True
        Me.cmbKilataje.Location = New System.Drawing.Point(90, 206)
        Me.cmbKilataje.Name = "cmbKilataje"
        Me.cmbKilataje.Size = New System.Drawing.Size(150, 21)
        Me.cmbKilataje.TabIndex = 34
        '
        'txtTipoEmpenio
        '
        Me.txtTipoEmpenio.Enabled = False
        Me.txtTipoEmpenio.Location = New System.Drawing.Point(90, 126)
        Me.txtTipoEmpenio.Name = "txtTipoEmpenio"
        Me.txtTipoEmpenio.Size = New System.Drawing.Size(150, 20)
        Me.txtTipoEmpenio.TabIndex = 35
        Me.txtTipoEmpenio.Text = "JOYERÍA"
        Me.txtTipoEmpenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblKilataje
        '
        Me.lblKilataje.AutoSize = True
        Me.lblKilataje.BackColor = System.Drawing.Color.Transparent
        Me.lblKilataje.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKilataje.ForeColor = System.Drawing.Color.Black
        Me.lblKilataje.Location = New System.Drawing.Point(28, 207)
        Me.lblKilataje.Name = "lblKilataje"
        Me.lblKilataje.Size = New System.Drawing.Size(60, 17)
        Me.lblKilataje.TabIndex = 33
        Me.lblKilataje.Text = "Kilataje:"
        '
        'cmbPrenda
        '
        Me.cmbPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrenda.FormattingEnabled = True
        Me.cmbPrenda.Location = New System.Drawing.Point(90, 179)
        Me.cmbPrenda.Name = "cmbPrenda"
        Me.cmbPrenda.Size = New System.Drawing.Size(150, 21)
        Me.cmbPrenda.TabIndex = 32
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Black
        Me.lblTipo.Location = New System.Drawing.Point(50, 126)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(38, 17)
        Me.lblTipo.TabIndex = 30
        Me.lblTipo.Text = "Tipo:"
        '
        'lblPrenda
        '
        Me.lblPrenda.AutoSize = True
        Me.lblPrenda.BackColor = System.Drawing.Color.Transparent
        Me.lblPrenda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenda.ForeColor = System.Drawing.Color.Black
        Me.lblPrenda.Location = New System.Drawing.Point(30, 180)
        Me.lblPrenda.Name = "lblPrenda"
        Me.lblPrenda.Size = New System.Drawing.Size(58, 17)
        Me.lblPrenda.TabIndex = 31
        Me.lblPrenda.Text = "Prenda:"
        '
        'pbImagen
        '
        Me.pbImagen.Image = CType(resources.GetObject("pbImagen.Image"), System.Drawing.Image)
        Me.pbImagen.Location = New System.Drawing.Point(83, 6)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(133, 114)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 1
        Me.pbImagen.TabStop = False
        '
        'frmSeleccionJoyeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(297, 494)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeleccionJoyeria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSeleccionJoyeria"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents pbImagen As PictureBox
    Public WithEvents cmbKilataje As ComboBox
    Public WithEvents txtTipoEmpenio As TextBox
    Friend WithEvents lblKilataje As Label
    Public WithEvents cmbPrenda As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblPrenda As Label
    Public WithEvents cmbEstado As ComboBox
    Friend WithEvents lblEstado As Label
    Public WithEvents cmbTipoMetal As ComboBox
    Friend WithEvents lblMetal As Label
    Friend WithEvents lblPrestamoMaxCantidad As Label
    Friend WithEvents lblPrestamoMaximo As Label
    Public WithEvents txtPrestamo As TextBox
    Friend WithEvents lblPrestamo As Label
    Public WithEvents txtAvaluo As TextBox
    Friend WithEvents lblAvaluo As Label
    Public WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnAgregar As Button
End Class
