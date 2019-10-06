<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatGenerico
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblGenerico = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.ComboBoxGenericos = New System.Windows.Forms.ComboBox()
        Me.DGVGenericos = New System.Windows.Forms.DataGridView()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblAuxiliar1 = New System.Windows.Forms.Label()
        Me.lblAuxiliar2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtAuxiliarUno = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.cmbTipoEmpenio = New System.Windows.Forms.ComboBox()
        CType(Me.DGVGenericos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGenerico
        '
        Me.lblGenerico.AutoSize = True
        Me.lblGenerico.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGenerico.Location = New System.Drawing.Point(463, 9)
        Me.lblGenerico.Name = "lblGenerico"
        Me.lblGenerico.Size = New System.Drawing.Size(131, 25)
        Me.lblGenerico.TabIndex = 1
        Me.lblGenerico.Text = "GENERICOS"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeleccionar.FlatAppearance.BorderSize = 0
        Me.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(295, 89)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(134, 23)
        Me.btnSeleccionar.TabIndex = 8
        Me.btnSeleccionar.Text = "SELECCIONAR"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
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
        Me.btnSalir.Location = New System.Drawing.Point(916, 271)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(134, 31)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(916, 95)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(134, 53)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(916, 149)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(134, 53)
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(44, 90)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(39, 17)
        Me.lblTipo.TabIndex = 9
        Me.lblTipo.Text = "TIPO :"
        '
        'ComboBoxGenericos
        '
        Me.ComboBoxGenericos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGenericos.FormattingEnabled = True
        Me.ComboBoxGenericos.Location = New System.Drawing.Point(89, 89)
        Me.ComboBoxGenericos.Name = "ComboBoxGenericos"
        Me.ComboBoxGenericos.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxGenericos.TabIndex = 10
        '
        'DGVGenericos
        '
        Me.DGVGenericos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVGenericos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVGenericos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVGenericos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVGenericos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVGenericos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVGenericos.EnableHeadersVisualStyles = False
        Me.DGVGenericos.Location = New System.Drawing.Point(47, 133)
        Me.DGVGenericos.MultiSelect = False
        Me.DGVGenericos.Name = "DGVGenericos"
        Me.DGVGenericos.ReadOnly = True
        Me.DGVGenericos.RowHeadersVisible = False
        Me.DGVGenericos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGenericos.Size = New System.Drawing.Size(568, 230)
        Me.DGVGenericos.TabIndex = 11
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(643, 133)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(93, 17)
        Me.lblDescripcion.TabIndex = 12
        Me.lblDescripcion.Text = "DESCRIPCIÓN :"
        '
        'lblAuxiliar1
        '
        Me.lblAuxiliar1.AutoSize = True
        Me.lblAuxiliar1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuxiliar1.Location = New System.Drawing.Point(643, 201)
        Me.lblAuxiliar1.Name = "lblAuxiliar1"
        Me.lblAuxiliar1.Size = New System.Drawing.Size(32, 17)
        Me.lblAuxiliar1.TabIndex = 13
        Me.lblAuxiliar1.Text = "URL:"
        '
        'lblAuxiliar2
        '
        Me.lblAuxiliar2.AutoSize = True
        Me.lblAuxiliar2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuxiliar2.Location = New System.Drawing.Point(643, 272)
        Me.lblAuxiliar2.Name = "lblAuxiliar2"
        Me.lblAuxiliar2.Size = New System.Drawing.Size(106, 17)
        Me.lblAuxiliar2.TabIndex = 14
        Me.lblAuxiliar2.Text = "TIPO DE EMPEÑO:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(646, 153)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(239, 20)
        Me.txtDescripcion.TabIndex = 15
        '
        'txtAuxiliarUno
        '
        Me.txtAuxiliarUno.Location = New System.Drawing.Point(646, 221)
        Me.txtAuxiliarUno.Name = "txtAuxiliarUno"
        Me.txtAuxiliarUno.Size = New System.Drawing.Size(239, 20)
        Me.txtAuxiliarUno.TabIndex = 16
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
        Me.btnEliminar.Location = New System.Drawing.Point(916, 203)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(134, 53)
        Me.btnEliminar.TabIndex = 18
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'cmbTipoEmpenio
        '
        Me.cmbTipoEmpenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEmpenio.FormattingEnabled = True
        Me.cmbTipoEmpenio.Location = New System.Drawing.Point(646, 292)
        Me.cmbTipoEmpenio.Name = "cmbTipoEmpenio"
        Me.cmbTipoEmpenio.Size = New System.Drawing.Size(239, 21)
        Me.cmbTipoEmpenio.TabIndex = 19
        '
        'frmCatGenerico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 545)
        Me.Controls.Add(Me.cmbTipoEmpenio)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtAuxiliarUno)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblAuxiliar2)
        Me.Controls.Add(Me.lblAuxiliar1)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.DGVGenericos)
        Me.Controls.Add(Me.ComboBoxGenericos)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblGenerico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCatGenerico"
        Me.Text = "Generico"
        CType(Me.DGVGenericos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGenerico As Label
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblTipo As Label
    Friend WithEvents ComboBoxGenericos As ComboBox
    Friend WithEvents DGVGenericos As DataGridView
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblAuxiliar1 As Label
    Friend WithEvents lblAuxiliar2 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtAuxiliarUno As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents cmbTipoEmpenio As ComboBox
End Class
