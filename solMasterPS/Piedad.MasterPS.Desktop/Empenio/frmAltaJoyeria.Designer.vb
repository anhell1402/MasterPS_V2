<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaJoyeria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaJoyeria))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.lblPrestamoMaximo = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblMetal = New System.Windows.Forms.Label()
        Me.lblKilatajePureza = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblPrenda = New System.Windows.Forms.Label()
        Me.txtTipoPrenda = New System.Windows.Forms.TextBox()
        Me.txtKilatajePureza = New System.Windows.Forms.TextBox()
        Me.txtEstadoPrenda = New System.Windows.Forms.TextBox()
        Me.txtPrestamoMaximo = New System.Windows.Forms.TextBox()
        Me.dgvPrendas = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.cmbMetal = New System.Windows.Forms.ComboBox()
        Me.cmbTipoEmpenio = New System.Windows.Forms.ComboBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPrendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.Black
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Controls.Add(Me.lblTitulo)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(730, 30)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(706, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 70
        Me.btnCerrar.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitulo.Location = New System.Drawing.Point(4, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(130, 20)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "ALTA DE JOYERIA"
        '
        'pbImagen
        '
        Me.pbImagen.Image = CType(resources.GetObject("pbImagen.Image"), System.Drawing.Image)
        Me.pbImagen.Location = New System.Drawing.Point(7, 13)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(104, 71)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 1
        Me.pbImagen.TabStop = False
        '
        'lblPrestamoMaximo
        '
        Me.lblPrestamoMaximo.AutoSize = True
        Me.lblPrestamoMaximo.BackColor = System.Drawing.Color.Transparent
        Me.lblPrestamoMaximo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrestamoMaximo.ForeColor = System.Drawing.Color.Red
        Me.lblPrestamoMaximo.Location = New System.Drawing.Point(51, 142)
        Me.lblPrestamoMaximo.Name = "lblPrestamoMaximo"
        Me.lblPrestamoMaximo.Size = New System.Drawing.Size(127, 16)
        Me.lblPrestamoMaximo.TabIndex = 61
        Me.lblPrestamoMaximo.Text = "Prestamo Máximo:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Black
        Me.lblEstado.Location = New System.Drawing.Point(123, 118)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(55, 16)
        Me.lblEstado.TabIndex = 59
        Me.lblEstado.Text = "Estado:"
        '
        'lblMetal
        '
        Me.lblMetal.AutoSize = True
        Me.lblMetal.BackColor = System.Drawing.Color.Transparent
        Me.lblMetal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetal.ForeColor = System.Drawing.Color.Black
        Me.lblMetal.Location = New System.Drawing.Point(129, 42)
        Me.lblMetal.Name = "lblMetal"
        Me.lblMetal.Size = New System.Drawing.Size(49, 16)
        Me.lblMetal.TabIndex = 57
        Me.lblMetal.Text = "Metal:"
        '
        'lblKilatajePureza
        '
        Me.lblKilatajePureza.AutoSize = True
        Me.lblKilatajePureza.BackColor = System.Drawing.Color.Transparent
        Me.lblKilatajePureza.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKilatajePureza.ForeColor = System.Drawing.Color.Black
        Me.lblKilatajePureza.Location = New System.Drawing.Point(66, 94)
        Me.lblKilatajePureza.Name = "lblKilatajePureza"
        Me.lblKilatajePureza.Size = New System.Drawing.Size(112, 16)
        Me.lblKilatajePureza.TabIndex = 54
        Me.lblKilatajePureza.Text = "Kilates / Pureza:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Black
        Me.lblTipo.Location = New System.Drawing.Point(139, 13)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(39, 16)
        Me.lblTipo.TabIndex = 51
        Me.lblTipo.Text = "Tipo:"
        '
        'lblPrenda
        '
        Me.lblPrenda.AutoSize = True
        Me.lblPrenda.BackColor = System.Drawing.Color.Transparent
        Me.lblPrenda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenda.ForeColor = System.Drawing.Color.Black
        Me.lblPrenda.Location = New System.Drawing.Point(120, 70)
        Me.lblPrenda.Name = "lblPrenda"
        Me.lblPrenda.Size = New System.Drawing.Size(58, 16)
        Me.lblPrenda.TabIndex = 52
        Me.lblPrenda.Text = "Prenda:"
        '
        'txtTipoPrenda
        '
        Me.txtTipoPrenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTipoPrenda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoPrenda.Location = New System.Drawing.Point(178, 70)
        Me.txtTipoPrenda.Name = "txtTipoPrenda"
        Me.txtTipoPrenda.Size = New System.Drawing.Size(106, 16)
        Me.txtTipoPrenda.TabIndex = 1
        Me.txtTipoPrenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKilatajePureza
        '
        Me.txtKilatajePureza.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKilatajePureza.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKilatajePureza.Location = New System.Drawing.Point(178, 94)
        Me.txtKilatajePureza.Name = "txtKilatajePureza"
        Me.txtKilatajePureza.Size = New System.Drawing.Size(106, 16)
        Me.txtKilatajePureza.TabIndex = 2
        Me.txtKilatajePureza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEstadoPrenda
        '
        Me.txtEstadoPrenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstadoPrenda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoPrenda.Location = New System.Drawing.Point(178, 118)
        Me.txtEstadoPrenda.Name = "txtEstadoPrenda"
        Me.txtEstadoPrenda.Size = New System.Drawing.Size(106, 16)
        Me.txtEstadoPrenda.TabIndex = 3
        Me.txtEstadoPrenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrestamoMaximo
        '
        Me.txtPrestamoMaximo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrestamoMaximo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrestamoMaximo.Location = New System.Drawing.Point(178, 142)
        Me.txtPrestamoMaximo.Name = "txtPrestamoMaximo"
        Me.txtPrestamoMaximo.Size = New System.Drawing.Size(106, 16)
        Me.txtPrestamoMaximo.TabIndex = 4
        Me.txtPrestamoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvPrendas
        '
        Me.dgvPrendas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPrendas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvPrendas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrendas.Location = New System.Drawing.Point(305, 12)
        Me.dgvPrendas.Name = "dgvPrendas"
        Me.dgvPrendas.Size = New System.Drawing.Size(403, 143)
        Me.dgvPrendas.TabIndex = 69
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalir.Location = New System.Drawing.Point(622, 163)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 30)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.Location = New System.Drawing.Point(522, 163)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 30)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelContenedor.Controls.Add(Me.cmbMetal)
        Me.PanelContenedor.Controls.Add(Me.cmbTipoEmpenio)
        Me.PanelContenedor.Controls.Add(Me.lblId)
        Me.PanelContenedor.Controls.Add(Me.btnEditar)
        Me.PanelContenedor.Controls.Add(Me.lblPrestamoMaximo)
        Me.PanelContenedor.Controls.Add(Me.btnSalir)
        Me.PanelContenedor.Controls.Add(Me.btnNuevo)
        Me.PanelContenedor.Controls.Add(Me.pbImagen)
        Me.PanelContenedor.Controls.Add(Me.lblPrenda)
        Me.PanelContenedor.Controls.Add(Me.dgvPrendas)
        Me.PanelContenedor.Controls.Add(Me.lblTipo)
        Me.PanelContenedor.Controls.Add(Me.txtPrestamoMaximo)
        Me.PanelContenedor.Controls.Add(Me.lblKilatajePureza)
        Me.PanelContenedor.Controls.Add(Me.txtEstadoPrenda)
        Me.PanelContenedor.Controls.Add(Me.txtKilatajePureza)
        Me.PanelContenedor.Controls.Add(Me.lblMetal)
        Me.PanelContenedor.Controls.Add(Me.txtTipoPrenda)
        Me.PanelContenedor.Controls.Add(Me.lblEstado)
        Me.PanelContenedor.Location = New System.Drawing.Point(5, 35)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(720, 205)
        Me.PanelContenedor.TabIndex = 73
        '
        'cmbMetal
        '
        Me.cmbMetal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMetal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMetal.FormattingEnabled = True
        Me.cmbMetal.Location = New System.Drawing.Point(178, 41)
        Me.cmbMetal.Name = "cmbMetal"
        Me.cmbMetal.Size = New System.Drawing.Size(108, 24)
        Me.cmbMetal.TabIndex = 0
        '
        'cmbTipoEmpenio
        '
        Me.cmbTipoEmpenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEmpenio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoEmpenio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEmpenio.FormattingEnabled = True
        Me.cmbTipoEmpenio.Location = New System.Drawing.Point(178, 12)
        Me.cmbTipoEmpenio.Name = "cmbTipoEmpenio"
        Me.cmbTipoEmpenio.Size = New System.Drawing.Size(108, 24)
        Me.cmbTipoEmpenio.TabIndex = 75
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.Black
        Me.lblId.Location = New System.Drawing.Point(7, 87)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(20, 17)
        Me.lblId.TabIndex = 74
        Me.lblId.Text = "Id"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditar.Location = New System.Drawing.Point(305, 161)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(94, 32)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'frmAltaJoyeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(730, 245)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAltaJoyeria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAltaJoyeria"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPrendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents lblPrestamoMaximo As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblMetal As Label
    Friend WithEvents lblKilatajePureza As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblPrenda As Label
    Friend WithEvents txtTipoPrenda As TextBox
    Friend WithEvents txtKilatajePureza As TextBox
    Friend WithEvents txtEstadoPrenda As TextBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents txtPrestamoMaximo As TextBox
    Friend WithEvents dgvPrendas As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblId As Label
    Friend WithEvents cmbTipoEmpenio As ComboBox
    Friend WithEvents cmbMetal As ComboBox
End Class
