<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAportaRetira
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAportaRetira))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.lblAdicionCompra = New System.Windows.Forms.Label()
        Me.cmbTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.PictureBox1)
        Me.PanelTitulo.Controls.Add(Me.lblTituloForm)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(363, 30)
        Me.PanelTitulo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTituloForm.Location = New System.Drawing.Point(29, 5)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Size = New System.Drawing.Size(172, 20)
        Me.lblTituloForm.TabIndex = 0
        Me.lblTituloForm.Text = "APORTACION / RETIRO"
        '
        'lblAdicionCompra
        '
        Me.lblAdicionCompra.AutoSize = True
        Me.lblAdicionCompra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdicionCompra.Location = New System.Drawing.Point(33, 49)
        Me.lblAdicionCompra.Name = "lblAdicionCompra"
        Me.lblAdicionCompra.Size = New System.Drawing.Size(140, 17)
        Me.lblAdicionCompra.TabIndex = 1
        Me.lblAdicionCompra.Text = "Tipo de Movimiento:"
        '
        'cmbTipoMovimiento
        '
        Me.cmbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoMovimiento.FormattingEnabled = True
        Me.cmbTipoMovimiento.Location = New System.Drawing.Point(33, 69)
        Me.cmbTipoMovimiento.Name = "cmbTipoMovimiento"
        Me.cmbTipoMovimiento.Size = New System.Drawing.Size(132, 21)
        Me.cmbTipoMovimiento.TabIndex = 2
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(216, 69)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(116, 20)
        Me.txtCantidad.TabIndex = 3
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(33, 134)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(299, 76)
        Me.txtDescripcion.TabIndex = 4
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(216, 49)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(75, 17)
        Me.lblCantidad.TabIndex = 5
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(33, 114)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(87, 17)
        Me.lblDescripcion.TabIndex = 6
        Me.lblDescripcion.Text = "Descripcion:"
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
        Me.btnSalir.Location = New System.Drawing.Point(192, 230)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(159, 34)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
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
        Me.btnGuardar.Location = New System.Drawing.Point(11, 230)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(159, 34)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmAportaRetira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 282)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cmbTipoMovimiento)
        Me.Controls.Add(Me.lblAdicionCompra)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAportaRetira"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAportaRetira"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTituloForm As Label
    Friend WithEvents lblAdicionCompra As Label
    Friend WithEvents cmbTipoMovimiento As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardar As Button
End Class
