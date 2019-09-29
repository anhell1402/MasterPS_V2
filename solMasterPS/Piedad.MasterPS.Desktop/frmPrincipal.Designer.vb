<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelSubMenuReportes = New System.Windows.Forms.Panel()
        Me.btnAbrirReportes = New System.Windows.Forms.Button()
        Me.PanelSubMenuCaja = New System.Windows.Forms.Panel()
        Me.btnCajaCorte = New System.Windows.Forms.Button()
        Me.btnCajaGastos = New System.Windows.Forms.Button()
        Me.btnAportacionRetiro = New System.Windows.Forms.Button()
        Me.btnCajaArqueo = New System.Windows.Forms.Button()
        Me.PanelSubMenuHistorial = New System.Windows.Forms.Panel()
        Me.btnHistorialApartados = New System.Windows.Forms.Button()
        Me.btnHistorialVentas = New System.Windows.Forms.Button()
        Me.btnHistorialEmpenios = New System.Windows.Forms.Button()
        Me.btnHistorialCliente = New System.Windows.Forms.Button()
        Me.PanelSubMenuInventario = New System.Windows.Forms.Panel()
        Me.btnSalidaInventario = New System.Windows.Forms.Button()
        Me.btnVisas = New System.Windows.Forms.Button()
        Me.btnAdicionCompra = New System.Windows.Forms.Button()
        Me.btnImpresionEtiqueta = New System.Windows.Forms.Button()
        Me.btnLoadBalance = New System.Windows.Forms.Button()
        Me.btnInventarioFundicion = New System.Windows.Forms.Button()
        Me.btnInventarioVenta = New System.Windows.Forms.Button()
        Me.PanelSubMenuCallCenter = New System.Windows.Forms.Panel()
        Me.btnBuscarRegistroCall = New System.Windows.Forms.Button()
        Me.btnRegistroCall = New System.Windows.Forms.Button()
        Me.PanelSubMenuVenta = New System.Windows.Forms.Panel()
        Me.btnDemasias = New System.Windows.Forms.Button()
        Me.btnAbonos = New System.Windows.Forms.Button()
        Me.btnApartado = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSlide = New System.Windows.Forms.PictureBox()
        Me.PanelSubMenuEmpenio = New System.Windows.Forms.Panel()
        Me.btnCotizar = New System.Windows.Forms.Button()
        Me.btnLiqEmp = New System.Windows.Forms.Button()
        Me.btnRefrendo = New System.Windows.Forms.Button()
        Me.btnNuevoEmpenio = New System.Windows.Forms.Button()
        Me.PanelMensajes = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnCaja = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.btnCallCenter = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnEmpenio = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.logoSistema = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.horaFecha = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PanelSubMenuConfiguracion = New System.Windows.Forms.Panel()
        Me.btnSincronizar = New System.Windows.Forms.Button()
        Me.Catalogos = New System.Windows.Forms.Button()
        Me.btnRoles = New System.Windows.Forms.Button()
        Me.btnPermisos = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnGenerales = New System.Windows.Forms.Button()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        Me.PanelSubMenuReportes.SuspendLayout()
        Me.PanelSubMenuCaja.SuspendLayout()
        Me.PanelSubMenuHistorial.SuspendLayout()
        Me.PanelSubMenuInventario.SuspendLayout()
        Me.PanelSubMenuCallCenter.SuspendLayout()
        Me.PanelSubMenuVenta.SuspendLayout()
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSubMenuEmpenio.SuspendLayout()
        Me.PanelMensajes.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.logoSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSubMenuConfiguracion.SuspendLayout()
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
        Me.PanelFormularios.BackgroundImage = CType(resources.GetObject("PanelFormularios.BackgroundImage"), System.Drawing.Image)
        Me.PanelFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuConfiguracion)
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuReportes)
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuCaja)
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuHistorial)
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuInventario)
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuCallCenter)
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuVenta)
        Me.PanelFormularios.Controls.Add(Me.btnSlide)
        Me.PanelFormularios.Controls.Add(Me.PanelSubMenuEmpenio)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(250, 35)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1050, 545)
        Me.PanelFormularios.TabIndex = 0
        '
        'PanelSubMenuReportes
        '
        Me.PanelSubMenuReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuReportes.Controls.Add(Me.btnAbrirReportes)
        Me.PanelSubMenuReportes.Location = New System.Drawing.Point(0, 272)
        Me.PanelSubMenuReportes.Name = "PanelSubMenuReportes"
        Me.PanelSubMenuReportes.Size = New System.Drawing.Size(0, 97)
        Me.PanelSubMenuReportes.TabIndex = 16
        '
        'btnAbrirReportes
        '
        Me.btnAbrirReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAbrirReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbrirReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnAbrirReportes.FlatAppearance.BorderSize = 0
        Me.btnAbrirReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAbrirReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAbrirReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrirReportes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirReportes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAbrirReportes.Image = CType(resources.GetObject("btnAbrirReportes.Image"), System.Drawing.Image)
        Me.btnAbrirReportes.Location = New System.Drawing.Point(0, 0)
        Me.btnAbrirReportes.Name = "btnAbrirReportes"
        Me.btnAbrirReportes.Size = New System.Drawing.Size(135, 97)
        Me.btnAbrirReportes.TabIndex = 0
        Me.btnAbrirReportes.Text = "REPORTES (TODOS)"
        Me.btnAbrirReportes.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAbrirReportes.UseVisualStyleBackColor = False
        '
        'PanelSubMenuCaja
        '
        Me.PanelSubMenuCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuCaja.Controls.Add(Me.btnCajaCorte)
        Me.PanelSubMenuCaja.Controls.Add(Me.btnCajaGastos)
        Me.PanelSubMenuCaja.Controls.Add(Me.btnAportacionRetiro)
        Me.PanelSubMenuCaja.Controls.Add(Me.btnCajaArqueo)
        Me.PanelSubMenuCaja.Location = New System.Drawing.Point(0, 231)
        Me.PanelSubMenuCaja.Name = "PanelSubMenuCaja"
        Me.PanelSubMenuCaja.Size = New System.Drawing.Size(0, 97)
        Me.PanelSubMenuCaja.TabIndex = 15
        '
        'btnCajaCorte
        '
        Me.btnCajaCorte.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCajaCorte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCajaCorte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnCajaCorte.FlatAppearance.BorderSize = 0
        Me.btnCajaCorte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCajaCorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnCajaCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCajaCorte.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajaCorte.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCajaCorte.Image = CType(resources.GetObject("btnCajaCorte.Image"), System.Drawing.Image)
        Me.btnCajaCorte.Location = New System.Drawing.Point(405, 0)
        Me.btnCajaCorte.Name = "btnCajaCorte"
        Me.btnCajaCorte.Size = New System.Drawing.Size(135, 97)
        Me.btnCajaCorte.TabIndex = 3
        Me.btnCajaCorte.Text = "CORTE DE CAJA"
        Me.btnCajaCorte.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCajaCorte.UseVisualStyleBackColor = False
        '
        'btnCajaGastos
        '
        Me.btnCajaGastos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCajaGastos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCajaGastos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnCajaGastos.FlatAppearance.BorderSize = 0
        Me.btnCajaGastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCajaGastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnCajaGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCajaGastos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajaGastos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCajaGastos.Image = CType(resources.GetObject("btnCajaGastos.Image"), System.Drawing.Image)
        Me.btnCajaGastos.Location = New System.Drawing.Point(270, 0)
        Me.btnCajaGastos.Name = "btnCajaGastos"
        Me.btnCajaGastos.Size = New System.Drawing.Size(135, 97)
        Me.btnCajaGastos.TabIndex = 2
        Me.btnCajaGastos.Text = "GASTOS"
        Me.btnCajaGastos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCajaGastos.UseVisualStyleBackColor = False
        '
        'btnAportacionRetiro
        '
        Me.btnAportacionRetiro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAportacionRetiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAportacionRetiro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnAportacionRetiro.FlatAppearance.BorderSize = 0
        Me.btnAportacionRetiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAportacionRetiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAportacionRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAportacionRetiro.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAportacionRetiro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAportacionRetiro.Image = CType(resources.GetObject("btnAportacionRetiro.Image"), System.Drawing.Image)
        Me.btnAportacionRetiro.Location = New System.Drawing.Point(135, 0)
        Me.btnAportacionRetiro.Name = "btnAportacionRetiro"
        Me.btnAportacionRetiro.Size = New System.Drawing.Size(135, 97)
        Me.btnAportacionRetiro.TabIndex = 1
        Me.btnAportacionRetiro.Text = "APORTAR/RETIRAR"
        Me.btnAportacionRetiro.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAportacionRetiro.UseVisualStyleBackColor = False
        '
        'btnCajaArqueo
        '
        Me.btnCajaArqueo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCajaArqueo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCajaArqueo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnCajaArqueo.FlatAppearance.BorderSize = 0
        Me.btnCajaArqueo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCajaArqueo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnCajaArqueo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCajaArqueo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajaArqueo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCajaArqueo.Image = CType(resources.GetObject("btnCajaArqueo.Image"), System.Drawing.Image)
        Me.btnCajaArqueo.Location = New System.Drawing.Point(0, 0)
        Me.btnCajaArqueo.Name = "btnCajaArqueo"
        Me.btnCajaArqueo.Size = New System.Drawing.Size(135, 97)
        Me.btnCajaArqueo.TabIndex = 0
        Me.btnCajaArqueo.Text = "ARQUEO"
        Me.btnCajaArqueo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCajaArqueo.UseVisualStyleBackColor = False
        '
        'PanelSubMenuHistorial
        '
        Me.PanelSubMenuHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuHistorial.Controls.Add(Me.btnHistorialApartados)
        Me.PanelSubMenuHistorial.Controls.Add(Me.btnHistorialVentas)
        Me.PanelSubMenuHistorial.Controls.Add(Me.btnHistorialEmpenios)
        Me.PanelSubMenuHistorial.Controls.Add(Me.btnHistorialCliente)
        Me.PanelSubMenuHistorial.Location = New System.Drawing.Point(0, 193)
        Me.PanelSubMenuHistorial.Name = "PanelSubMenuHistorial"
        Me.PanelSubMenuHistorial.Size = New System.Drawing.Size(0, 97)
        Me.PanelSubMenuHistorial.TabIndex = 14
        '
        'btnHistorialApartados
        '
        Me.btnHistorialApartados.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHistorialApartados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistorialApartados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnHistorialApartados.FlatAppearance.BorderSize = 0
        Me.btnHistorialApartados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnHistorialApartados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnHistorialApartados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialApartados.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialApartados.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHistorialApartados.Image = CType(resources.GetObject("btnHistorialApartados.Image"), System.Drawing.Image)
        Me.btnHistorialApartados.Location = New System.Drawing.Point(405, 0)
        Me.btnHistorialApartados.Name = "btnHistorialApartados"
        Me.btnHistorialApartados.Size = New System.Drawing.Size(135, 97)
        Me.btnHistorialApartados.TabIndex = 3
        Me.btnHistorialApartados.Text = "APARTADOS"
        Me.btnHistorialApartados.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnHistorialApartados.UseVisualStyleBackColor = False
        '
        'btnHistorialVentas
        '
        Me.btnHistorialVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHistorialVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistorialVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnHistorialVentas.FlatAppearance.BorderSize = 0
        Me.btnHistorialVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnHistorialVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnHistorialVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialVentas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialVentas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHistorialVentas.Image = CType(resources.GetObject("btnHistorialVentas.Image"), System.Drawing.Image)
        Me.btnHistorialVentas.Location = New System.Drawing.Point(270, 0)
        Me.btnHistorialVentas.Name = "btnHistorialVentas"
        Me.btnHistorialVentas.Size = New System.Drawing.Size(135, 97)
        Me.btnHistorialVentas.TabIndex = 2
        Me.btnHistorialVentas.Text = "VENTAS"
        Me.btnHistorialVentas.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnHistorialVentas.UseVisualStyleBackColor = False
        '
        'btnHistorialEmpenios
        '
        Me.btnHistorialEmpenios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHistorialEmpenios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistorialEmpenios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnHistorialEmpenios.FlatAppearance.BorderSize = 0
        Me.btnHistorialEmpenios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnHistorialEmpenios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnHistorialEmpenios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialEmpenios.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialEmpenios.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHistorialEmpenios.Image = CType(resources.GetObject("btnHistorialEmpenios.Image"), System.Drawing.Image)
        Me.btnHistorialEmpenios.Location = New System.Drawing.Point(135, 0)
        Me.btnHistorialEmpenios.Name = "btnHistorialEmpenios"
        Me.btnHistorialEmpenios.Size = New System.Drawing.Size(135, 97)
        Me.btnHistorialEmpenios.TabIndex = 1
        Me.btnHistorialEmpenios.Text = "EMPEÑOS"
        Me.btnHistorialEmpenios.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnHistorialEmpenios.UseVisualStyleBackColor = False
        '
        'btnHistorialCliente
        '
        Me.btnHistorialCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHistorialCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistorialCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnHistorialCliente.FlatAppearance.BorderSize = 0
        Me.btnHistorialCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnHistorialCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnHistorialCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHistorialCliente.Image = CType(resources.GetObject("btnHistorialCliente.Image"), System.Drawing.Image)
        Me.btnHistorialCliente.Location = New System.Drawing.Point(0, 0)
        Me.btnHistorialCliente.Name = "btnHistorialCliente"
        Me.btnHistorialCliente.Size = New System.Drawing.Size(135, 97)
        Me.btnHistorialCliente.TabIndex = 0
        Me.btnHistorialCliente.Text = "CLIENTES"
        Me.btnHistorialCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnHistorialCliente.UseVisualStyleBackColor = False
        '
        'PanelSubMenuInventario
        '
        Me.PanelSubMenuInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuInventario.Controls.Add(Me.btnSalidaInventario)
        Me.PanelSubMenuInventario.Controls.Add(Me.btnVisas)
        Me.PanelSubMenuInventario.Controls.Add(Me.btnAdicionCompra)
        Me.PanelSubMenuInventario.Controls.Add(Me.btnImpresionEtiqueta)
        Me.PanelSubMenuInventario.Controls.Add(Me.btnLoadBalance)
        Me.PanelSubMenuInventario.Controls.Add(Me.btnInventarioFundicion)
        Me.PanelSubMenuInventario.Controls.Add(Me.btnInventarioVenta)
        Me.PanelSubMenuInventario.Location = New System.Drawing.Point(0, 113)
        Me.PanelSubMenuInventario.Name = "PanelSubMenuInventario"
        Me.PanelSubMenuInventario.Size = New System.Drawing.Size(540, 194)
        Me.PanelSubMenuInventario.TabIndex = 13
        '
        'btnSalidaInventario
        '
        Me.btnSalidaInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalidaInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalidaInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnSalidaInventario.FlatAppearance.BorderSize = 0
        Me.btnSalidaInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSalidaInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnSalidaInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalidaInventario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalidaInventario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalidaInventario.Image = CType(resources.GetObject("btnSalidaInventario.Image"), System.Drawing.Image)
        Me.btnSalidaInventario.Location = New System.Drawing.Point(270, 97)
        Me.btnSalidaInventario.Name = "btnSalidaInventario"
        Me.btnSalidaInventario.Size = New System.Drawing.Size(135, 97)
        Me.btnSalidaInventario.TabIndex = 6
        Me.btnSalidaInventario.Text = "SALIDA DE INVENTARIO"
        Me.btnSalidaInventario.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSalidaInventario.UseVisualStyleBackColor = False
        '
        'btnVisas
        '
        Me.btnVisas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVisas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVisas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnVisas.FlatAppearance.BorderSize = 0
        Me.btnVisas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnVisas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnVisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnVisas.Image = CType(resources.GetObject("btnVisas.Image"), System.Drawing.Image)
        Me.btnVisas.Location = New System.Drawing.Point(135, 97)
        Me.btnVisas.Name = "btnVisas"
        Me.btnVisas.Size = New System.Drawing.Size(135, 97)
        Me.btnVisas.TabIndex = 5
        Me.btnVisas.Text = "VISAS"
        Me.btnVisas.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnVisas.UseVisualStyleBackColor = False
        '
        'btnAdicionCompra
        '
        Me.btnAdicionCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdicionCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnAdicionCompra.FlatAppearance.BorderSize = 0
        Me.btnAdicionCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAdicionCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnAdicionCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionCompra.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionCompra.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdicionCompra.Image = CType(resources.GetObject("btnAdicionCompra.Image"), System.Drawing.Image)
        Me.btnAdicionCompra.Location = New System.Drawing.Point(0, 97)
        Me.btnAdicionCompra.Name = "btnAdicionCompra"
        Me.btnAdicionCompra.Size = New System.Drawing.Size(135, 97)
        Me.btnAdicionCompra.TabIndex = 4
        Me.btnAdicionCompra.Text = "ADISION/COMPRA"
        Me.btnAdicionCompra.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAdicionCompra.UseVisualStyleBackColor = False
        '
        'btnImpresionEtiqueta
        '
        Me.btnImpresionEtiqueta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImpresionEtiqueta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImpresionEtiqueta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnImpresionEtiqueta.FlatAppearance.BorderSize = 0
        Me.btnImpresionEtiqueta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnImpresionEtiqueta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnImpresionEtiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImpresionEtiqueta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpresionEtiqueta.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnImpresionEtiqueta.Image = CType(resources.GetObject("btnImpresionEtiqueta.Image"), System.Drawing.Image)
        Me.btnImpresionEtiqueta.Location = New System.Drawing.Point(405, 0)
        Me.btnImpresionEtiqueta.Name = "btnImpresionEtiqueta"
        Me.btnImpresionEtiqueta.Size = New System.Drawing.Size(135, 97)
        Me.btnImpresionEtiqueta.TabIndex = 3
        Me.btnImpresionEtiqueta.Text = "IMP. ETIQUETAS"
        Me.btnImpresionEtiqueta.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnImpresionEtiqueta.UseVisualStyleBackColor = False
        '
        'btnLoadBalance
        '
        Me.btnLoadBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLoadBalance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadBalance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnLoadBalance.FlatAppearance.BorderSize = 0
        Me.btnLoadBalance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnLoadBalance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnLoadBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadBalance.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadBalance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLoadBalance.Image = CType(resources.GetObject("btnLoadBalance.Image"), System.Drawing.Image)
        Me.btnLoadBalance.Location = New System.Drawing.Point(270, 0)
        Me.btnLoadBalance.Name = "btnLoadBalance"
        Me.btnLoadBalance.Size = New System.Drawing.Size(135, 97)
        Me.btnLoadBalance.TabIndex = 2
        Me.btnLoadBalance.Text = "LOAD BALANCE"
        Me.btnLoadBalance.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnLoadBalance.UseVisualStyleBackColor = False
        '
        'btnInventarioFundicion
        '
        Me.btnInventarioFundicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInventarioFundicion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventarioFundicion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnInventarioFundicion.FlatAppearance.BorderSize = 0
        Me.btnInventarioFundicion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnInventarioFundicion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnInventarioFundicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventarioFundicion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventarioFundicion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnInventarioFundicion.Image = CType(resources.GetObject("btnInventarioFundicion.Image"), System.Drawing.Image)
        Me.btnInventarioFundicion.Location = New System.Drawing.Point(135, 0)
        Me.btnInventarioFundicion.Name = "btnInventarioFundicion"
        Me.btnInventarioFundicion.Size = New System.Drawing.Size(135, 97)
        Me.btnInventarioFundicion.TabIndex = 1
        Me.btnInventarioFundicion.Text = "EN FUNDICION"
        Me.btnInventarioFundicion.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnInventarioFundicion.UseVisualStyleBackColor = False
        '
        'btnInventarioVenta
        '
        Me.btnInventarioVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInventarioVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventarioVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnInventarioVenta.FlatAppearance.BorderSize = 0
        Me.btnInventarioVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnInventarioVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnInventarioVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventarioVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventarioVenta.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnInventarioVenta.Image = CType(resources.GetObject("btnInventarioVenta.Image"), System.Drawing.Image)
        Me.btnInventarioVenta.Location = New System.Drawing.Point(0, 0)
        Me.btnInventarioVenta.Name = "btnInventarioVenta"
        Me.btnInventarioVenta.Size = New System.Drawing.Size(135, 97)
        Me.btnInventarioVenta.TabIndex = 0
        Me.btnInventarioVenta.Text = "EN VENTA"
        Me.btnInventarioVenta.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnInventarioVenta.UseVisualStyleBackColor = False
        '
        'PanelSubMenuCallCenter
        '
        Me.PanelSubMenuCallCenter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuCallCenter.Controls.Add(Me.btnBuscarRegistroCall)
        Me.PanelSubMenuCallCenter.Controls.Add(Me.btnRegistroCall)
        Me.PanelSubMenuCallCenter.Location = New System.Drawing.Point(0, 154)
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
        Me.btnBuscarRegistroCall.Location = New System.Drawing.Point(135, 0)
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
        'PanelSubMenuVenta
        '
        Me.PanelSubMenuVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuVenta.Controls.Add(Me.btnDemasias)
        Me.PanelSubMenuVenta.Controls.Add(Me.btnAbonos)
        Me.PanelSubMenuVenta.Controls.Add(Me.btnApartado)
        Me.PanelSubMenuVenta.Controls.Add(Me.btnNuevo)
        Me.PanelSubMenuVenta.Location = New System.Drawing.Point(0, 74)
        Me.PanelSubMenuVenta.Name = "PanelSubMenuVenta"
        Me.PanelSubMenuVenta.Size = New System.Drawing.Size(540, 97)
        Me.PanelSubMenuVenta.TabIndex = 10
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
        Me.btnDemasias.Location = New System.Drawing.Point(405, 0)
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
        Me.PanelSubMenuEmpenio.Controls.Add(Me.btnCotizar)
        Me.PanelSubMenuEmpenio.Controls.Add(Me.btnLiqEmp)
        Me.PanelSubMenuEmpenio.Controls.Add(Me.btnRefrendo)
        Me.PanelSubMenuEmpenio.Controls.Add(Me.btnNuevoEmpenio)
        Me.PanelSubMenuEmpenio.Location = New System.Drawing.Point(0, 34)
        Me.PanelSubMenuEmpenio.Name = "PanelSubMenuEmpenio"
        Me.PanelSubMenuEmpenio.Size = New System.Drawing.Size(0, 97)
        Me.PanelSubMenuEmpenio.TabIndex = 9
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
        Me.btnCotizar.Location = New System.Drawing.Point(405, 0)
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
        Me.btnLiqEmp.Location = New System.Drawing.Point(270, 0)
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
        Me.btnRefrendo.Location = New System.Drawing.Point(135, 0)
        Me.btnRefrendo.Name = "btnRefrendo"
        Me.btnRefrendo.Size = New System.Drawing.Size(135, 97)
        Me.btnRefrendo.TabIndex = 1
        Me.btnRefrendo.Text = "REFRENDO +"
        Me.btnRefrendo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnRefrendo.UseVisualStyleBackColor = False
        '
        'btnNuevoEmpenio
        '
        Me.btnNuevoEmpenio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevoEmpenio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoEmpenio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnNuevoEmpenio.FlatAppearance.BorderSize = 0
        Me.btnNuevoEmpenio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnNuevoEmpenio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnNuevoEmpenio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoEmpenio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEmpenio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevoEmpenio.Image = CType(resources.GetObject("btnNuevoEmpenio.Image"), System.Drawing.Image)
        Me.btnNuevoEmpenio.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevoEmpenio.Name = "btnNuevoEmpenio"
        Me.btnNuevoEmpenio.Size = New System.Drawing.Size(135, 97)
        Me.btnNuevoEmpenio.TabIndex = 0
        Me.btnNuevoEmpenio.Text = "NUEVO"
        Me.btnNuevoEmpenio.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnNuevoEmpenio.UseVisualStyleBackColor = False
        '
        'PanelMensajes
        '
        Me.PanelMensajes.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelMensajes.Controls.Add(Me.lblFecha)
        Me.PanelMensajes.Controls.Add(Me.lblHora)
        Me.PanelMensajes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMensajes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMensajes.Location = New System.Drawing.Point(250, 580)
        Me.PanelMensajes.Name = "PanelMensajes"
        Me.PanelMensajes.Size = New System.Drawing.Size(1050, 70)
        Me.PanelMensajes.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblFecha.Location = New System.Drawing.Point(786, 47)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(57, 20)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.Text = "Label1"
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblHora.Location = New System.Drawing.Point(772, -2)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(151, 49)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "Label1"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnReportes)
        Me.PanelMenu.Controls.Add(Me.btnCaja)
        Me.PanelMenu.Controls.Add(Me.btnHistorial)
        Me.PanelMenu.Controls.Add(Me.btnInventario)
        Me.PanelMenu.Controls.Add(Me.btnSummary)
        Me.PanelMenu.Controls.Add(Me.btnConfiguracion)
        Me.PanelMenu.Controls.Add(Me.btnCallCenter)
        Me.PanelMenu.Controls.Add(Me.btnVenta)
        Me.PanelMenu.Controls.Add(Me.btnEmpenio)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 35)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 615)
        Me.PanelMenu.TabIndex = 1
        '
        'btnReportes
        '
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(0, 272)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(250, 35)
        Me.btnReportes.TabIndex = 7
        Me.btnReportes.Text = "REPORTES"
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnCaja
        '
        Me.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCaja.FlatAppearance.BorderSize = 0
        Me.btnCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaja.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaja.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCaja.Image = CType(resources.GetObject("btnCaja.Image"), System.Drawing.Image)
        Me.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCaja.Location = New System.Drawing.Point(0, 231)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(250, 35)
        Me.btnCaja.TabIndex = 5
        Me.btnCaja.Text = "CAJA"
        Me.btnCaja.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistorial.FlatAppearance.BorderSize = 0
        Me.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHistorial.Image = CType(resources.GetObject("btnHistorial.Image"), System.Drawing.Image)
        Me.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorial.Location = New System.Drawing.Point(0, 193)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(250, 35)
        Me.btnHistorial.TabIndex = 4
        Me.btnHistorial.Text = "HISTORIAL"
        Me.btnHistorial.UseVisualStyleBackColor = True
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
        Me.btnInventario.Location = New System.Drawing.Point(0, 113)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(250, 35)
        Me.btnInventario.TabIndex = 2
        Me.btnInventario.Text = "INVENTARIO"
        Me.btnInventario.UseVisualStyleBackColor = True
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
        Me.btnSummary.Location = New System.Drawing.Point(0, 356)
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
        Me.btnConfiguracion.Location = New System.Drawing.Point(0, 313)
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
        Me.btnCallCenter.TabIndex = 3
        Me.btnCallCenter.Text = "CALL CENTER"
        Me.btnCallCenter.UseVisualStyleBackColor = True
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
        'horaFecha
        '
        Me.horaFecha.Enabled = True
        '
        'PanelSubMenuConfiguracion
        '
        Me.PanelSubMenuConfiguracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSubMenuConfiguracion.Controls.Add(Me.btnGenerales)
        Me.PanelSubMenuConfiguracion.Controls.Add(Me.btnSincronizar)
        Me.PanelSubMenuConfiguracion.Controls.Add(Me.Catalogos)
        Me.PanelSubMenuConfiguracion.Controls.Add(Me.btnRoles)
        Me.PanelSubMenuConfiguracion.Controls.Add(Me.btnPermisos)
        Me.PanelSubMenuConfiguracion.Controls.Add(Me.btnUsuarios)
        Me.PanelSubMenuConfiguracion.Location = New System.Drawing.Point(0, 313)
        Me.PanelSubMenuConfiguracion.Name = "PanelSubMenuConfiguracion"
        Me.PanelSubMenuConfiguracion.Size = New System.Drawing.Size(540, 194)
        Me.PanelSubMenuConfiguracion.TabIndex = 17
        '
        'btnSincronizar
        '
        Me.btnSincronizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSincronizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSincronizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnSincronizar.FlatAppearance.BorderSize = 0
        Me.btnSincronizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSincronizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnSincronizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSincronizar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSincronizar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSincronizar.Image = CType(resources.GetObject("btnSincronizar.Image"), System.Drawing.Image)
        Me.btnSincronizar.Location = New System.Drawing.Point(0, 97)
        Me.btnSincronizar.Name = "btnSincronizar"
        Me.btnSincronizar.Size = New System.Drawing.Size(135, 97)
        Me.btnSincronizar.TabIndex = 4
        Me.btnSincronizar.Text = "SYNC"
        Me.btnSincronizar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSincronizar.UseVisualStyleBackColor = False
        '
        'Catalogos
        '
        Me.Catalogos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Catalogos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Catalogos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Catalogos.FlatAppearance.BorderSize = 0
        Me.Catalogos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.Catalogos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Catalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Catalogos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Catalogos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Catalogos.Image = CType(resources.GetObject("Catalogos.Image"), System.Drawing.Image)
        Me.Catalogos.Location = New System.Drawing.Point(405, 0)
        Me.Catalogos.Name = "Catalogos"
        Me.Catalogos.Size = New System.Drawing.Size(135, 97)
        Me.Catalogos.TabIndex = 3
        Me.Catalogos.Text = "CATALOGOS"
        Me.Catalogos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Catalogos.UseVisualStyleBackColor = False
        '
        'btnRoles
        '
        Me.btnRoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRoles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRoles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnRoles.FlatAppearance.BorderSize = 0
        Me.btnRoles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoles.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoles.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRoles.Image = CType(resources.GetObject("btnRoles.Image"), System.Drawing.Image)
        Me.btnRoles.Location = New System.Drawing.Point(270, 0)
        Me.btnRoles.Name = "btnRoles"
        Me.btnRoles.Size = New System.Drawing.Size(135, 97)
        Me.btnRoles.TabIndex = 2
        Me.btnRoles.Text = "ROLES"
        Me.btnRoles.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnRoles.UseVisualStyleBackColor = False
        '
        'btnPermisos
        '
        Me.btnPermisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPermisos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPermisos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnPermisos.FlatAppearance.BorderSize = 0
        Me.btnPermisos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPermisos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPermisos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPermisos.Image = CType(resources.GetObject("btnPermisos.Image"), System.Drawing.Image)
        Me.btnPermisos.Location = New System.Drawing.Point(135, 0)
        Me.btnPermisos.Name = "btnPermisos"
        Me.btnPermisos.Size = New System.Drawing.Size(135, 97)
        Me.btnPermisos.TabIndex = 1
        Me.btnPermisos.Text = "PERMISOS"
        Me.btnPermisos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnPermisos.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(135, 97)
        Me.btnUsuarios.TabIndex = 0
        Me.btnUsuarios.Text = "USUARIOS"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnGenerales
        '
        Me.btnGenerales.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnGenerales.FlatAppearance.BorderSize = 0
        Me.btnGenerales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnGenerales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnGenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerales.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerales.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGenerales.Image = CType(resources.GetObject("btnGenerales.Image"), System.Drawing.Image)
        Me.btnGenerales.Location = New System.Drawing.Point(135, 97)
        Me.btnGenerales.Name = "btnGenerales"
        Me.btnGenerales.Size = New System.Drawing.Size(135, 97)
        Me.btnGenerales.TabIndex = 5
        Me.btnGenerales.Text = "GENERALES"
        Me.btnGenerales.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnGenerales.UseVisualStyleBackColor = False
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
        Me.Text = "Menu Principal"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelSubMenuReportes.ResumeLayout(False)
        Me.PanelSubMenuCaja.ResumeLayout(False)
        Me.PanelSubMenuHistorial.ResumeLayout(False)
        Me.PanelSubMenuInventario.ResumeLayout(False)
        Me.PanelSubMenuCallCenter.ResumeLayout(False)
        Me.PanelSubMenuVenta.ResumeLayout(False)
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSubMenuEmpenio.ResumeLayout(False)
        Me.PanelMensajes.ResumeLayout(False)
        Me.PanelMensajes.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelBarraTitulo.ResumeLayout(False)
        CType(Me.logoSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSubMenuConfiguracion.ResumeLayout(False)
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
    Friend WithEvents btnSummary As Button
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents btnCallCenter As Button
    Friend WithEvents btnVenta As Button
    Friend WithEvents btnEmpenio As Button
    Friend WithEvents logoSistema As PictureBox
    Friend WithEvents btnSlide As PictureBox
    Friend WithEvents PanelSubMenuEmpenio As Panel
    Friend WithEvents btnCotizar As Button
    Friend WithEvents btnLiqEmp As Button
    Friend WithEvents btnRefrendo As Button
    Friend WithEvents btnNuevoEmpenio As Button
    Friend WithEvents PanelSubMenuVenta As Panel
    Friend WithEvents btnDemasias As Button
    Friend WithEvents btnAbonos As Button
    Friend WithEvents btnApartado As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents PanelSubMenuCallCenter As Panel
    Friend WithEvents btnBuscarRegistroCall As Button
    Friend WithEvents btnRegistroCall As Button
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents horaFecha As Timer
    Friend WithEvents btnInventario As Button
    Friend WithEvents PanelSubMenuInventario As Panel
    Friend WithEvents btnImpresionEtiqueta As Button
    Friend WithEvents btnLoadBalance As Button
    Friend WithEvents btnInventarioFundicion As Button
    Friend WithEvents btnInventarioVenta As Button
    Friend WithEvents btnSalidaInventario As Button
    Friend WithEvents btnVisas As Button
    Friend WithEvents btnAdicionCompra As Button
    Friend WithEvents PanelSubMenuHistorial As Panel
    Friend WithEvents btnHistorialApartados As Button
    Friend WithEvents btnHistorialVentas As Button
    Friend WithEvents btnHistorialEmpenios As Button
    Friend WithEvents btnHistorialCliente As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents PanelSubMenuCaja As Panel
    Friend WithEvents btnCajaCorte As Button
    Friend WithEvents btnCajaGastos As Button
    Friend WithEvents btnAportacionRetiro As Button
    Friend WithEvents btnCajaArqueo As Button
    Friend WithEvents btnCaja As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelSubMenuReportes As Panel
    Friend WithEvents btnAbrirReportes As Button
    Friend WithEvents PanelSubMenuConfiguracion As Panel
    Friend WithEvents btnGenerales As Button
    Friend WithEvents btnSincronizar As Button
    Friend WithEvents Catalogos As Button
    Friend WithEvents btnRoles As Button
    Friend WithEvents btnPermisos As Button
    Friend WithEvents btnUsuarios As Button
End Class
