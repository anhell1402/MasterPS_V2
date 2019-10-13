<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaMcia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaMcia))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.cmbFamilia = New System.Windows.Forms.ComboBox()
        Me.lblFamilia = New System.Windows.Forms.Label()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblPrecioMaximo = New System.Windows.Forms.Label()
        Me.txtPrecioMax = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelTitulo.Size = New System.Drawing.Size(499, 30)
        Me.PanelTitulo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitulo.Location = New System.Drawing.Point(3, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(177, 19)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "ALTA DE MERCANCIAS"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(480, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTipo.Location = New System.Drawing.Point(222, 51)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(38, 17)
        Me.lblTipo.TabIndex = 3
        Me.lblTipo.Text = "Tipo:"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(307, 47)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(175, 21)
        Me.cmbTipo.TabIndex = 4
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(307, 79)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(175, 21)
        Me.cmbCategoria.TabIndex = 6
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblCategoria.Location = New System.Drawing.Point(222, 83)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(79, 17)
        Me.lblCategoria.TabIndex = 5
        Me.lblCategoria.Text = "Categoria:"
        '
        'cmbFamilia
        '
        Me.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.Location = New System.Drawing.Point(307, 111)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(175, 21)
        Me.cmbFamilia.TabIndex = 8
        '
        'lblFamilia
        '
        Me.lblFamilia.AutoSize = True
        Me.lblFamilia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamilia.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblFamilia.Location = New System.Drawing.Point(222, 115)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(58, 17)
        Me.lblFamilia.TabIndex = 7
        Me.lblFamilia.Text = "Familia:"
        '
        'cmbMarca
        '
        Me.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(307, 143)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(175, 21)
        Me.cmbMarca.TabIndex = 10
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMarca.Location = New System.Drawing.Point(222, 147)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(53, 17)
        Me.lblMarca.TabIndex = 9
        Me.lblMarca.Text = "Marca:"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(307, 175)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(175, 20)
        Me.txtModelo.TabIndex = 11
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblModelo.Location = New System.Drawing.Point(222, 178)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(61, 17)
        Me.lblModelo.TabIndex = 12
        Me.lblModelo.Text = "Modelo:"
        '
        'lblPrecioMaximo
        '
        Me.lblPrecioMaximo.AutoSize = True
        Me.lblPrecioMaximo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioMaximo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPrecioMaximo.Location = New System.Drawing.Point(222, 209)
        Me.lblPrecioMaximo.Name = "lblPrecioMaximo"
        Me.lblPrecioMaximo.Size = New System.Drawing.Size(86, 17)
        Me.lblPrecioMaximo.TabIndex = 14
        Me.lblPrecioMaximo.Text = "Precio Max.:"
        '
        'txtPrecioMax
        '
        Me.txtPrecioMax.Location = New System.Drawing.Point(307, 206)
        Me.txtPrecioMax.Name = "txtPrecioMax"
        Me.txtPrecioMax.Size = New System.Drawing.Size(175, 20)
        Me.txtPrecioMax.TabIndex = 13
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
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(225, 233)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(257, 42)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'frmAltaMcia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(499, 287)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblPrecioMaximo)
        Me.Controls.Add(Me.txtPrecioMax)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.cmbFamilia)
        Me.Controls.Add(Me.lblFamilia)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAltaMcia"
        Me.Text = "frmAltaMcia"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents cmbFamilia As ComboBox
    Friend WithEvents lblFamilia As Label
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblPrecioMaximo As Label
    Friend WithEvents txtPrecioMax As TextBox
    Friend WithEvents btnAgregar As Button
End Class
