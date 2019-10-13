<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigUsuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblTituloUsuario = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApaterno = New System.Windows.Forms.Label()
        Me.txtApaterno = New System.Windows.Forms.TextBox()
        Me.lblAmaterno = New System.Windows.Forms.Label()
        Me.txtAmaterno = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblTipoTelefono = New System.Windows.Forms.Label()
        Me.cmbTipoTelefono = New System.Windows.Forms.ComboBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.chbxActivo = New System.Windows.Forms.CheckBox()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(892, 185)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(159, 42)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "NUEVO"
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
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(892, 469)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(159, 42)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(892, 233)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(159, 42)
        Me.btnEditar.TabIndex = 7
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(892, 281)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(159, 42)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'lblTituloUsuario
        '
        Me.lblTituloUsuario.AutoSize = True
        Me.lblTituloUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloUsuario.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTituloUsuario.Location = New System.Drawing.Point(464, 9)
        Me.lblTituloUsuario.Name = "lblTituloUsuario"
        Me.lblTituloUsuario.Size = New System.Drawing.Size(103, 25)
        Me.lblTituloUsuario.TabIndex = 5
        Me.lblTituloUsuario.Text = "USUARIO"
        '
        'pbImagen
        '
        Me.pbImagen.Image = CType(resources.GetObject("pbImagen.Image"), System.Drawing.Image)
        Me.pbImagen.Location = New System.Drawing.Point(30, 40)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(168, 161)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 10
        Me.pbImagen.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(230, 92)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(194, 19)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(227, 72)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 17)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "NOMBRE:"
        '
        'lblApaterno
        '
        Me.lblApaterno.AutoSize = True
        Me.lblApaterno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApaterno.Location = New System.Drawing.Point(431, 72)
        Me.lblApaterno.Name = "lblApaterno"
        Me.lblApaterno.Size = New System.Drawing.Size(134, 17)
        Me.lblApaterno.TabIndex = 14
        Me.lblApaterno.Text = "APELLIDO PATERNO:"
        '
        'txtApaterno
        '
        Me.txtApaterno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtApaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApaterno.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApaterno.Location = New System.Drawing.Point(434, 92)
        Me.txtApaterno.Name = "txtApaterno"
        Me.txtApaterno.Size = New System.Drawing.Size(196, 19)
        Me.txtApaterno.TabIndex = 2
        '
        'lblAmaterno
        '
        Me.lblAmaterno.AutoSize = True
        Me.lblAmaterno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmaterno.Location = New System.Drawing.Point(635, 72)
        Me.lblAmaterno.Name = "lblAmaterno"
        Me.lblAmaterno.Size = New System.Drawing.Size(137, 17)
        Me.lblAmaterno.TabIndex = 16
        Me.lblAmaterno.Text = "APELLIDO MATERNO:"
        '
        'txtAmaterno
        '
        Me.txtAmaterno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAmaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmaterno.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmaterno.Location = New System.Drawing.Point(638, 92)
        Me.txtAmaterno.Name = "txtAmaterno"
        Me.txtAmaterno.Size = New System.Drawing.Size(198, 19)
        Me.txtAmaterno.TabIndex = 3
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(550, 127)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(68, 17)
        Me.lblCorreo.TabIndex = 18
        Me.lblCorreo.Text = "CORREO:"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(553, 147)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(283, 19)
        Me.txtCorreo.TabIndex = 6
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(228, 243)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(65, 17)
        Me.lblUsuario.TabIndex = 20
        Me.lblUsuario.Text = "USUARIO:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(299, 244)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(179, 19)
        Me.txtUsuario.TabIndex = 9
        '
        'cmbRol
        '
        Me.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRol.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Location = New System.Drawing.Point(230, 204)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(190, 24)
        Me.cmbRol.TabIndex = 7
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.Location = New System.Drawing.Point(227, 184)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(57, 17)
        Me.lblRol.TabIndex = 26
        Me.lblRol.Text = "PUESTO:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(227, 127)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(75, 17)
        Me.lblTelefono.TabIndex = 28
        Me.lblTelefono.Text = "TELEFONO:"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(230, 147)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(179, 19)
        Me.txtTelefono.TabIndex = 4
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(439, 184)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(74, 17)
        Me.lblSucursal.TabIndex = 30
        Me.lblSucursal.Text = "SUCURSAL:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(442, 204)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(207, 24)
        Me.cmbSucursal.TabIndex = 8
        '
        'lblTipoTelefono
        '
        Me.lblTipoTelefono.AutoSize = True
        Me.lblTipoTelefono.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoTelefono.Location = New System.Drawing.Point(412, 127)
        Me.lblTipoTelefono.Name = "lblTipoTelefono"
        Me.lblTipoTelefono.Size = New System.Drawing.Size(39, 17)
        Me.lblTipoTelefono.TabIndex = 32
        Me.lblTipoTelefono.Text = "TIPO:"
        '
        'cmbTipoTelefono
        '
        Me.cmbTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoTelefono.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoTelefono.FormattingEnabled = True
        Me.cmbTipoTelefono.Location = New System.Drawing.Point(415, 147)
        Me.cmbTipoTelefono.Name = "cmbTipoTelefono"
        Me.cmbTipoTelefono.Size = New System.Drawing.Size(128, 24)
        Me.cmbTipoTelefono.TabIndex = 5
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.EnableHeadersVisualStyles = False
        Me.dgvUsuarios.Location = New System.Drawing.Point(231, 292)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(605, 152)
        Me.dgvUsuarios.TabIndex = 33
        '
        'chbxActivo
        '
        Me.chbxActivo.AutoSize = True
        Me.chbxActivo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxActivo.Location = New System.Drawing.Point(768, 247)
        Me.chbxActivo.Name = "chbxActivo"
        Me.chbxActivo.Size = New System.Drawing.Size(68, 20)
        Me.chbxActivo.TabIndex = 35
        Me.chbxActivo.Text = "ACTIVO"
        Me.chbxActivo.UseVisualStyleBackColor = True
        '
        'frmConfigUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1050, 545)
        Me.Controls.Add(Me.chbxActivo)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.lblTipoTelefono)
        Me.Controls.Add(Me.cmbTipoTelefono)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblRol)
        Me.Controls.Add(Me.cmbRol)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblAmaterno)
        Me.Controls.Add(Me.txtAmaterno)
        Me.Controls.Add(Me.lblApaterno)
        Me.Controls.Add(Me.txtApaterno)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblTituloUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfigUsuarios"
        Me.Text = "frmConfigUsuarios"
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblTituloUsuario As Label
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApaterno As Label
    Friend WithEvents txtApaterno As TextBox
    Friend WithEvents lblAmaterno As Label
    Friend WithEvents txtAmaterno As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents lblRol As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblSucursal As Label
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents lblTipoTelefono As Label
    Friend WithEvents cmbTipoTelefono As ComboBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents chbxActivo As CheckBox
End Class
