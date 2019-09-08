<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelSubMenuVenta = New System.Windows.Forms.Panel()
        Me.btnReportesVentas = New System.Windows.Forms.Button()
        Me.btnDemasias = New System.Windows.Forms.Button()
        Me.btnAbonos = New System.Windows.Forms.Button()
        Me.btnApartado = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSlide = New System.Windows.Forms.PictureBox()
        Me.PanelSubMenuEmpenio = New System.Windows.Forms.Panel()
        Me.btnReportesEmpenios = New System.Windows.Forms.Button()
        Me.btnCotizar = New System.Windows.Forms.Button()
        Me.btnLiqEmp = New System.Windows.Forms.Button()
        Me.btnRefrendo = New System.Windows.Forms.Button()
        Me.btnNuevoEmpeño = New System.Windows.Forms.Button()
        Me.FondoLogo = New System.Windows.Forms.PictureBox()
        Me.PanelMensajes = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnCheckInOut = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.btnCallCenter = New System.Windows.Forms.Button()
        Me.btnCatalogo = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnEmpenio = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.logoSistema = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelSubMenuCatalogo = New System.Windows.Forms.Panel()
        Me.btnAltaCotitular = New System.Windows.Forms.Button()
        Me.btnAltaUsuario = New System.Windows.Forms.Button()
        Me.btnAltaMercancia = New System.Windows.Forms.Button()
        Me.btnAltaCliente = New System.Windows.Forms.Button()
        Me.PanelSubMenuCallCenter = New System.Windows.Forms.Panel()
        Me.btnBuscarRegistroCall = New System.Windows.Forms.Button()
        Me.btnRegistroCall = New System.Windows.Forms.Button()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        Me.PanelSubMenuVenta.SuspendLayout()
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSubMenuEmpenio.SuspendLayout()
        CType(Me.FondoLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.logoSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSubMenuCatalogo.SuspendLayout()
        Me.PanelSubMenuCallCenter.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.LightGray
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMensajes)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1300, 650)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuCallCenter)
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuCatalogo)
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuVenta)
        Me.PanelFormularios.Controls.Add(Me.btnSlide)
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuEmpenio)
        Me.PanelFormularios.Controls.Add(Me.FondoLogo)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(250, 35)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1050, 545)
        Me.PanelFormularios.TabIndex = 3
        '
        'PanelSubMenuVenta
        '
        Me.PanelSubMenuVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuVenta.Controls.Add(Me.btnReportesVentas)
        Me.PanelSubMenuVenta.Controls.Add(Me.btnDemasias)
        Me.PanelSubMenuVenta.Controls.Add(Me.btnAbonos)
        Me.PanelSubMenuVenta.Controls.Add(Me.btnApartado)
        Me.PanelSubMenuVenta.Controls.Add(Me.btnNuevo)
        Me.PanelSubMenuVenta.Location = New System.Drawing.Point(0, 74)
        Me.PanelSubMenuVenta.Name = "PanelSubMenuVenta"
        Me.PanelSubMenuVenta.Size = New System.Drawing.Size(0, 195)
        Me.PanelSubMenuVenta.TabIndex = 10
        '
        'btnReportesVentas
        '
        Me.btnReportesVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReportesVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportesVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnReportesVentas.FlatAppearance.BorderSize = 0
        Me.btnReportesVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnReportesVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnReportesVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportesVentas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportesVentas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReportesVentas.Image = CType(resources.GetObject("btnReportesVentas.Image"), System.Drawing.Image)
        Me.btnReportesVentas.Location = New System.Drawing.Point(135, 97)
        Me.btnReportesVentas.Name = "btnReportesVentas"
        Me.btnReportesVentas.Size = New System.Drawing.Size(135, 97)
        Me.btnReportesVentas.TabIndex = 6
        Me.btnReportesVentas.Text = "REPORTES"
        Me.btnReportesVentas.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnReportesVentas.UseVisualStyleBackColor = False
        '
        'btnDemasias
        '
        Me.btnDemasias.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDemasias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDemasias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnDemasias.FlatAppearance.BorderSize = 0
        Me.btnDemasias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnDemasias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnDemasias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDemasias.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemasias.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDemasias.Image = CType(resources.GetObject("btnDemasias.Image"), System.Drawing.Image)
        Me.btnDemasias.Location = New System.Drawing.Point(0, 97)
        Me.btnDemasias.Name = "btnDemasias"
        Me.btnDemasias.Size = New System.Drawing.Size(135, 97)
        Me.btnDemasias.TabIndex = 3
        Me.btnDemasias.Text = "DEMASIAS"
        Me.btnDemasias.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnDemasias.UseVisualStyleBackColor = False
        '
        'btnAbonos
        '
        Me.btnAbonos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAbonos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbonos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnAbonos.FlatAppearance.BorderSize = 0
        Me.btnAbonos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAbonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbonos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbonos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAbonos.Image = CType(resources.GetObject("btnAbonos.Image"), System.Drawing.Image)
        Me.btnAbonos.Location = New System.Drawing.Point(270, 0)
        Me.btnAbonos.Name = "btnAbonos"
        Me.btnAbonos.Size = New System.Drawing.Size(135, 97)
        Me.btnAbonos.TabIndex = 2
        Me.btnAbonos.Text = "ABONOS"
        Me.btnAbonos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAbonos.UseVisualStyleBackColor = False
        '
        'btnApartado
        '
        Me.btnApartado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApartado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApartado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnApartado.FlatAppearance.BorderSize = 0
        Me.btnApartado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnApartado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnApartado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApartado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApartado.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnApartado.Image = CType(resources.GetObject("btnApartado.Image"), System.Drawing.Image)
        Me.btnApartado.Location = New System.Drawing.Point(135, 0)
        Me.btnApartado.Name = "btnApartado"
        Me.btnApartado.Size = New System.Drawing.Size(135, 97)
        Me.btnApartado.TabIndex = 1
        Me.btnApartado.Text = "APARTADO"
        Me.btnApartado.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnApartado.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(135, 97)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSlide
        '
        Me.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSlide.Image = CType(resources.GetObject("btnSlide.Image"), System.Drawing.Image)
        Me.btnSlide.Location = New System.Drawing.Point(3, 3)
        Me.btnSlide.Name = "btnSlide"
        Me.btnSlide.Size = New System.Drawing.Size(20, 20)
        Me.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSlide.TabIndex = 8
        Me.btnSlide.TabStop = False
        '
        'PanelSubMenuEmpenio
        '
        Me.PanelSubMenuEmpenio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuEmpenio.Controls.Add(Me.btnReportesEmpenios)
        Me.PanelSubMenuEmpenio.Controls.Add(Me.btnCotizar)
        Me.PanelSubMenuEmpenio.Controls.Add(Me.btnLiqEmp)
        Me.PanelSubMenuEmpenio.Controls.Add(Me.btnRefrendo)
        Me.PanelSubMenuEmpenio.Controls.Add(Me.btnNuevoEmpeño)
        Me.PanelSubMenuEmpenio.Location = New System.Drawing.Point(0, 34)
        Me.PanelSubMenuEmpenio.Name = "PanelSubMenuEmpenio"
        Me.PanelSubMenuEmpenio.Size = New System.Drawing.Size(0, 195)
        Me.PanelSubMenuEmpenio.TabIndex = 9
        '
        'btnReportesEmpenios
        '
        Me.btnReportesEmpenios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReportesEmpenios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportesEmpenios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnReportesEmpenios.FlatAppearance.BorderSize = 0
        Me.btnReportesEmpenios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnReportesEmpenios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnReportesEmpenios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportesEmpenios.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportesEmpenios.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReportesEmpenios.Image = CType(resources.GetObject("btnReportesEmpenios.Image"), System.Drawing.Image)
        Me.btnReportesEmpenios.Location = New System.Drawing.Point(136, 97)
        Me.btnReportesEmpenios.Name = "btnReportesEmpenios"
        Me.btnReportesEmpenios.Size = New System.Drawing.Size(135, 97)
        Me.btnReportesEmpenios.TabIndex = 6
        Me.btnReportesEmpenios.Text = "REPORTES"
        Me.btnReportesEmpenios.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnReportesEmpenios.UseVisualStyleBackColor = False
        '
        'btnCotizar
        '
        Me.btnCotizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCotizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCotizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnCotizar.FlatAppearance.BorderSize = 0
        Me.btnCotizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCotizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnCotizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCotizar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCotizar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCotizar.Image = CType(resources.GetObject("btnCotizar.Image"), System.Drawing.Image)
        Me.btnCotizar.Location = New System.Drawing.Point(0, 97)
        Me.btnCotizar.Name = "btnCotizar"
        Me.btnCotizar.Size = New System.Drawing.Size(135, 97)
        Me.btnCotizar.TabIndex = 3
        Me.btnCotizar.Text = "COTIZAR EMPEÑO"
        Me.btnCotizar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCotizar.UseVisualStyleBackColor = False
        '
        'btnLiqEmp
        '
        Me.btnLiqEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLiqEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLiqEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnLiqEmp.FlatAppearance.BorderSize = 0
        Me.btnLiqEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnLiqEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnLiqEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLiqEmp.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiqEmp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLiqEmp.Image = CType(resources.GetObject("btnLiqEmp.Image"), System.Drawing.Image)
        Me.btnLiqEmp.Location = New System.Drawing.Point(269, 0)
        Me.btnLiqEmp.Name = "btnLiqEmp"
        Me.btnLiqEmp.Size = New System.Drawing.Size(135, 97)
        Me.btnLiqEmp.TabIndex = 2
        Me.btnLiqEmp.Text = "LIQUIDACION"
        Me.btnLiqEmp.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnLiqEmp.UseVisualStyleBackColor = False
        '
        'btnRefrendo
        '
        Me.btnRefrendo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefrendo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefrendo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnRefrendo.FlatAppearance.BorderSize = 0
        Me.btnRefrendo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnRefrendo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnRefrendo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrendo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrendo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefrendo.Image = CType(resources.GetObject("btnRefrendo.Image"), System.Drawing.Image)
        Me.btnRefrendo.Location = New System.Drawing.Point(137, 0)
        Me.btnRefrendo.Name = "btnRefrendo"
        Me.btnRefrendo.Size = New System.Drawing.Size(135, 97)
        Me.btnRefrendo.TabIndex = 1
        Me.btnRefrendo.Text = "REFRENDO +"
        Me.btnRefrendo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnRefrendo.UseVisualStyleBackColor = False
        '
        'btnNuevoEmpeño
        '
        Me.btnNuevoEmpeño.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevoEmpeño.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoEmpeño.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnNuevoEmpeño.FlatAppearance.BorderSize = 0
        Me.btnNuevoEmpeño.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnNuevoEmpeño.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnNuevoEmpeño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoEmpeño.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEmpeño.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevoEmpeño.Image = CType(resources.GetObject("btnNuevoEmpeño.Image"), System.Drawing.Image)
        Me.btnNuevoEmpeño.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevoEmpeño.Name = "btnNuevoEmpeño"
        Me.btnNuevoEmpeño.Size = New System.Drawing.Size(135, 97)
        Me.btnNuevoEmpeño.TabIndex = 0
        Me.btnNuevoEmpeño.Text = "NUEVO"
        Me.btnNuevoEmpeño.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnNuevoEmpeño.UseVisualStyleBackColor = False
        '
        'FondoLogo
        '
        Me.FondoLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FondoLogo.Image = CType(resources.GetObject("FondoLogo.Image"), System.Drawing.Image)
        Me.FondoLogo.Location = New System.Drawing.Point(202, 126)
        Me.FondoLogo.Name = "FondoLogo"
        Me.FondoLogo.Size = New System.Drawing.Size(721, 306)
        Me.FondoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FondoLogo.TabIndex = 0
        Me.FondoLogo.TabStop = False
        '
        'PanelMensajes
        '
        Me.PanelMensajes.BackColor = System.Drawing.Color.Transparent
        Me.PanelMensajes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMensajes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMensajes.Location = New System.Drawing.Point(250, 580)
        Me.PanelMensajes.Name = "PanelMensajes"
        Me.PanelMensajes.Size = New System.Drawing.Size(1050, 70)
        Me.PanelMensajes.TabIndex = 2
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnInventario)
        Me.PanelMenu.Controls.Add(Me.btnCheckInOut)
        Me.PanelMenu.Controls.Add(Me.btnUsuario)
        Me.PanelMenu.Controls.Add(Me.btnSummary)
        Me.PanelMenu.Controls.Add(Me.btnConfiguracion)
        Me.PanelMenu.Controls.Add(Me.btnCallCenter)
        Me.PanelMenu.Controls.Add(Me.btnCatalogo)
        Me.PanelMenu.Controls.Add(Me.btnVenta)
        Me.PanelMenu.Controls.Add(Me.btnEmpenio)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 35)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 615)
        Me.PanelMenu.TabIndex = 1
        '
        'btnInventario
        '
        Me.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnInventario.Image = CType(resources.GetObject("btnInventario.Image"), System.Drawing.Image)
        Me.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventario.Location = New System.Drawing.Point(0, 234)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(250, 35)
        Me.btnInventario.TabIndex = 10
        Me.btnInventario.Text = "INVENTARIO"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnCheckInOut
        '
        Me.btnCheckInOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckInOut.FlatAppearance.BorderSize = 0
        Me.btnCheckInOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCheckInOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnCheckInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckInOut.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckInOut.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCheckInOut.Image = CType(resources.GetObject("btnCheckInOut.Image"), System.Drawing.Image)
        Me.btnCheckInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckInOut.Location = New System.Drawing.Point(0, 194)
        Me.btnCheckInOut.Name = "btnCheckInOut"
        Me.btnCheckInOut.Size = New System.Drawing.Size(250, 35)
        Me.btnCheckInOut.TabIndex = 9
        Me.btnCheckInOut.Text = "CHECK IN/OUT"
        Me.btnCheckInOut.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUsuario.Image = CType(resources.GetObject("btnUsuario.Image"), System.Drawing.Image)
        Me.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuario.Location = New System.Drawing.Point(0, 314)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(250, 35)
        Me.btnUsuario.TabIndex = 7
        Me.btnUsuario.Text = "USUARIOS"
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'btnSummary
        '
        Me.btnSummary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSummary.FlatAppearance.BorderSize = 0
        Me.btnSummary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummary.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummary.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSummary.Image = CType(resources.GetObject("btnSummary.Image"), System.Drawing.Image)
        Me.btnSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummary.Location = New System.Drawing.Point(0, 274)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(250, 35)
        Me.btnSummary.TabIndex = 6
        Me.btnSummary.Text = "SUMMARY"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguracion.FlatAppearance.BorderSize = 0
        Me.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnConfiguracion.Image = CType(resources.GetObject("btnConfiguracion.Image"), System.Drawing.Image)
        Me.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfiguracion.Location = New System.Drawing.Point(0, 354)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(250, 35)
        Me.btnConfiguracion.TabIndex = 5
        Me.btnConfiguracion.Text = "CONFIGURACION"
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'btnCallCenter
        '
        Me.btnCallCenter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCallCenter.FlatAppearance.BorderSize = 0
        Me.btnCallCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCallCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnCallCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCallCenter.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCallCenter.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCallCenter.Image = CType(resources.GetObject("btnCallCenter.Image"), System.Drawing.Image)
        Me.btnCallCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCallCenter.Location = New System.Drawing.Point(0, 154)
        Me.btnCallCenter.Name = "btnCallCenter"
        Me.btnCallCenter.Size = New System.Drawing.Size(250, 35)
        Me.btnCallCenter.TabIndex = 4
        Me.btnCallCenter.Text = "CALL CENTER"
        Me.btnCallCenter.UseVisualStyleBackColor = True
        '
        'btnCatalogo
        '
        Me.btnCatalogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCatalogo.FlatAppearance.BorderSize = 0
        Me.btnCatalogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatalogo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatalogo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCatalogo.Image = CType(resources.GetObject("btnCatalogo.Image"), System.Drawing.Image)
        Me.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatalogo.Location = New System.Drawing.Point(0, 114)
        Me.btnCatalogo.Name = "btnCatalogo"
        Me.btnCatalogo.Size = New System.Drawing.Size(250, 35)
        Me.btnCatalogo.TabIndex = 3
        Me.btnCatalogo.Text = "CATALOGO"
        Me.btnCatalogo.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVenta.FlatAppearance.BorderSize = 0
        Me.btnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnVenta.Image = CType(resources.GetObject("btnVenta.Image"), System.Drawing.Image)
        Me.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVenta.Location = New System.Drawing.Point(0, 74)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(250, 35)
        Me.btnVenta.TabIndex = 1
        Me.btnVenta.Text = "VENTAS"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'btnEmpenio
        '
        Me.btnEmpenio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpenio.FlatAppearance.BorderSize = 0
        Me.btnEmpenio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEmpenio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEmpenio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpenio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpenio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEmpenio.Image = CType(resources.GetObject("btnEmpenio.Image"), System.Drawing.Image)
        Me.btnEmpenio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpenio.Location = New System.Drawing.Point(0, 34)
        Me.btnEmpenio.Name = "btnEmpenio"
        Me.btnEmpenio.Size = New System.Drawing.Size(250, 35)
        Me.btnEmpenio.TabIndex = 0
        Me.btnEmpenio.Text = "EMPEÑOS"
        Me.btnEmpenio.UseVisualStyleBackColor = True
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.logoSistema)
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1300, 35)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'logoSistema
        '
        Me.logoSistema.Image = CType(resources.GetObject("logoSistema.Image"), System.Drawing.Image)
        Me.logoSistema.Location = New System.Drawing.Point(3, 3)
        Me.logoSistema.Name = "logoSistema"
        Me.logoSistema.Size = New System.Drawing.Size(192, 32)
        Me.logoSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logoSistema.TabIndex = 4
        Me.logoSistema.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(1250, 12)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(16, 16)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1228, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(1250, 12)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1272, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'PanelSubMenuCatalogo
        '
        Me.PanelSubMenuCatalogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuCatalogo.Controls.Add(Me.btnAltaCotitular)
        Me.PanelSubMenuCatalogo.Controls.Add(Me.btnAltaUsuario)
        Me.PanelSubMenuCatalogo.Controls.Add(Me.btnAltaMercancia)
        Me.PanelSubMenuCatalogo.Controls.Add(Me.btnAltaCliente)
        Me.PanelSubMenuCatalogo.Location = New System.Drawing.Point(0, 114)
        Me.PanelSubMenuCatalogo.Name = "PanelSubMenuCatalogo"
        Me.PanelSubMenuCatalogo.Size = New System.Drawing.Size(0, 195)
        Me.PanelSubMenuCatalogo.TabIndex = 11
        '
        'btnAltaCotitular
        '
        Me.btnAltaCotitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAltaCotitular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAltaCotitular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnAltaCotitular.FlatAppearance.BorderSize = 0
        Me.btnAltaCotitular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAltaCotitular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAltaCotitular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaCotitular.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaCotitular.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAltaCotitular.Image = CType(resources.GetObject("btnAltaCotitular.Image"), System.Drawing.Image)
        Me.btnAltaCotitular.Location = New System.Drawing.Point(0, 99)
        Me.btnAltaCotitular.Name = "btnAltaCotitular"
        Me.btnAltaCotitular.Size = New System.Drawing.Size(135, 97)
        Me.btnAltaCotitular.TabIndex = 6
        Me.btnAltaCotitular.Text = "COTITULAR"
        Me.btnAltaCotitular.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAltaCotitular.UseVisualStyleBackColor = False
        '
        'btnAltaUsuario
        '
        Me.btnAltaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAltaUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAltaUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnAltaUsuario.FlatAppearance.BorderSize = 0
        Me.btnAltaUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAltaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaUsuario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAltaUsuario.Image = CType(resources.GetObject("btnAltaUsuario.Image"), System.Drawing.Image)
        Me.btnAltaUsuario.Location = New System.Drawing.Point(136, 99)
        Me.btnAltaUsuario.Name = "btnAltaUsuario"
        Me.btnAltaUsuario.Size = New System.Drawing.Size(135, 97)
        Me.btnAltaUsuario.TabIndex = 3
        Me.btnAltaUsuario.Text = "USUARIOS"
        Me.btnAltaUsuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAltaUsuario.UseVisualStyleBackColor = False
        '
        'btnAltaMercancia
        '
        Me.btnAltaMercancia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAltaMercancia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAltaMercancia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnAltaMercancia.FlatAppearance.BorderSize = 0
        Me.btnAltaMercancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAltaMercancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAltaMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaMercancia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaMercancia.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAltaMercancia.Image = CType(resources.GetObject("btnAltaMercancia.Image"), System.Drawing.Image)
        Me.btnAltaMercancia.Location = New System.Drawing.Point(136, 0)
        Me.btnAltaMercancia.Name = "btnAltaMercancia"
        Me.btnAltaMercancia.Size = New System.Drawing.Size(135, 97)
        Me.btnAltaMercancia.TabIndex = 1
        Me.btnAltaMercancia.Text = "MERCANCIAS"
        Me.btnAltaMercancia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAltaMercancia.UseVisualStyleBackColor = False
        '
        'btnAltaCliente
        '
        Me.btnAltaCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAltaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAltaCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnAltaCliente.FlatAppearance.BorderSize = 0
        Me.btnAltaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAltaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAltaCliente.Image = CType(resources.GetObject("btnAltaCliente.Image"), System.Drawing.Image)
        Me.btnAltaCliente.Location = New System.Drawing.Point(0, 0)
        Me.btnAltaCliente.Name = "btnAltaCliente"
        Me.btnAltaCliente.Size = New System.Drawing.Size(135, 97)
        Me.btnAltaCliente.TabIndex = 0
        Me.btnAltaCliente.Text = "CLIENTES"
        Me.btnAltaCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAltaCliente.UseVisualStyleBackColor = False
        '
        'PanelSubMenuCallCenter
        '
        Me.PanelSubMenuCallCenter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuCallCenter.Controls.Add(Me.btnBuscarRegistroCall)
        Me.PanelSubMenuCallCenter.Controls.Add(Me.btnRegistroCall)
        Me.PanelSubMenuCallCenter.Location = New System.Drawing.Point(0, 155)
        Me.PanelSubMenuCallCenter.Name = "PanelSubMenuCallCenter"
        Me.PanelSubMenuCallCenter.Size = New System.Drawing.Size(0, 97)
        Me.PanelSubMenuCallCenter.TabIndex = 12
        '
        'btnBuscarRegistroCall
        '
        Me.btnBuscarRegistroCall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarRegistroCall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarRegistroCall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnBuscarRegistroCall.FlatAppearance.BorderSize = 0
        Me.btnBuscarRegistroCall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnBuscarRegistroCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnBuscarRegistroCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarRegistroCall.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRegistroCall.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarRegistroCall.Image = CType(resources.GetObject("btnBuscarRegistroCall.Image"), System.Drawing.Image)
        Me.btnBuscarRegistroCall.Location = New System.Drawing.Point(136, 0)
        Me.btnBuscarRegistroCall.Name = "btnBuscarRegistroCall"
        Me.btnBuscarRegistroCall.Size = New System.Drawing.Size(135, 97)
        Me.btnBuscarRegistroCall.TabIndex = 1
        Me.btnBuscarRegistroCall.Text = "BUSCAR REGISTROS"
        Me.btnBuscarRegistroCall.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnBuscarRegistroCall.UseVisualStyleBackColor = False
        '
        'btnRegistroCall
        '
        Me.btnRegistroCall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistroCall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistroCall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnRegistroCall.FlatAppearance.BorderSize = 0
        Me.btnRegistroCall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnRegistroCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnRegistroCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistroCall.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroCall.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRegistroCall.Image = CType(resources.GetObject("btnRegistroCall.Image"), System.Drawing.Image)
        Me.btnRegistroCall.Location = New System.Drawing.Point(0, 0)
        Me.btnRegistroCall.Name = "btnRegistroCall"
        Me.btnRegistroCall.Size = New System.Drawing.Size(135, 97)
        Me.btnRegistroCall.TabIndex = 0
        Me.btnRegistroCall.Text = "REGISTRO"
        Me.btnRegistroCall.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnRegistroCall.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelSubMenuVenta.ResumeLayout(False)
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSubMenuEmpenio.ResumeLayout(False)
        CType(Me.FondoLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelBarraTitulo.ResumeLayout(False)
        CType(Me.logoSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSubMenuCatalogo.ResumeLayout(False)
        Me.PanelSubMenuCallCenter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PanelMensajes As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnSummary As Button
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents btnCallCenter As Button
    Friend WithEvents btnCatalogo As Button
    Friend WithEvents btnVenta As Button
    Friend WithEvents btnEmpenio As Button
    Friend WithEvents FondoLogo As PictureBox
    Friend WithEvents logoSistema As PictureBox
    Friend WithEvents btnSlide As PictureBox
    Friend WithEvents PanelSubMenuEmpenio As Panel
    Friend WithEvents btnCheckInOut As Button
    Friend WithEvents btnReportesEmpenios As Button
    Friend WithEvents btnCotizar As Button
    Friend WithEvents btnLiqEmp As Button
    Friend WithEvents btnRefrendo As Button
    Friend WithEvents btnNuevoEmpeño As Button
    Friend WithEvents PanelSubMenuVenta As Panel
    Friend WithEvents btnReportesVentas As Button
    Friend WithEvents btnDemasias As Button
    Friend WithEvents btnAbonos As Button
    Friend WithEvents btnApartado As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents PanelSubMenuCatalogo As Panel
    Friend WithEvents btnAltaCotitular As Button
    Friend WithEvents btnAltaUsuario As Button
    Friend WithEvents btnAltaMercancia As Button
    Friend WithEvents btnAltaCliente As Button
    Friend WithEvents PanelSubMenuCallCenter As Panel
    Friend WithEvents btnBuscarRegistroCall As Button
    Friend WithEvents btnRegistroCall As Button
End Class
