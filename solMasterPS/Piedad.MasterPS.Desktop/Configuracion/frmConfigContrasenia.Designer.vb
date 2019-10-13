<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigContrasenia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigContrasenia))
        Me.pbimagenuser = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblPassActual = New System.Windows.Forms.Label()
        Me.txtPassAnterior = New System.Windows.Forms.TextBox()
        Me.txtPassNueva = New System.Windows.Forms.TextBox()
        Me.lblPassNueva = New System.Windows.Forms.Label()
        Me.txtPassConfirmado = New System.Windows.Forms.TextBox()
        Me.lblPassConfirmado = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.pbImgIz = New System.Windows.Forms.PictureBox()
        Me.pbImgDr = New System.Windows.Forms.PictureBox()
        CType(Me.pbimagenuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImgIz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImgDr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbimagenuser
        '
        Me.pbimagenuser.Image = CType(resources.GetObject("pbimagenuser.Image"), System.Drawing.Image)
        Me.pbimagenuser.Location = New System.Drawing.Point(113, 61)
        Me.pbimagenuser.Name = "pbimagenuser"
        Me.pbimagenuser.Size = New System.Drawing.Size(136, 141)
        Me.pbimagenuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbimagenuser.TabIndex = 0
        Me.pbimagenuser.TabStop = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.Black
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Controls.Add(Me.lblTitulo)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(360, 35)
        Me.PanelTitulo.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(342, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(15, 15)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitulo.Location = New System.Drawing.Point(65, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(239, 17)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "ACTUALIZACION DE LA CONTRASEÑA"
        '
        'lblPassActual
        '
        Me.lblPassActual.AutoSize = True
        Me.lblPassActual.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassActual.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPassActual.Location = New System.Drawing.Point(110, 221)
        Me.lblPassActual.Name = "lblPassActual"
        Me.lblPassActual.Size = New System.Drawing.Size(134, 17)
        Me.lblPassActual.TabIndex = 2
        Me.lblPassActual.Text = "Contraseña Actual:"
        '
        'txtPassAnterior
        '
        Me.txtPassAnterior.Location = New System.Drawing.Point(106, 241)
        Me.txtPassAnterior.Name = "txtPassAnterior"
        Me.txtPassAnterior.Size = New System.Drawing.Size(151, 20)
        Me.txtPassAnterior.TabIndex = 3
        '
        'txtPassNueva
        '
        Me.txtPassNueva.Location = New System.Drawing.Point(106, 293)
        Me.txtPassNueva.Name = "txtPassNueva"
        Me.txtPassNueva.Size = New System.Drawing.Size(151, 20)
        Me.txtPassNueva.TabIndex = 5
        '
        'lblPassNueva
        '
        Me.lblPassNueva.AutoSize = True
        Me.lblPassNueva.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassNueva.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPassNueva.Location = New System.Drawing.Point(114, 273)
        Me.lblPassNueva.Name = "lblPassNueva"
        Me.lblPassNueva.Size = New System.Drawing.Size(135, 17)
        Me.lblPassNueva.TabIndex = 4
        Me.lblPassNueva.Text = "Nueva Contraseña:"
        '
        'txtPassConfirmado
        '
        Me.txtPassConfirmado.Location = New System.Drawing.Point(106, 347)
        Me.txtPassConfirmado.Name = "txtPassConfirmado"
        Me.txtPassConfirmado.Size = New System.Drawing.Size(151, 20)
        Me.txtPassConfirmado.TabIndex = 7
        '
        'lblPassConfirmado
        '
        Me.lblPassConfirmado.AutoSize = True
        Me.lblPassConfirmado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassConfirmado.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPassConfirmado.Location = New System.Drawing.Point(105, 327)
        Me.lblPassConfirmado.Name = "lblPassConfirmado"
        Me.lblPassConfirmado.Size = New System.Drawing.Size(157, 17)
        Me.lblPassConfirmado.TabIndex = 6
        Me.lblPassConfirmado.Text = "Confirmar Contraseña:"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.Black
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(103, 394)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnActualizar.Size = New System.Drawing.Size(159, 33)
        Me.btnActualizar.TabIndex = 9
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'pbImgIz
        '
        Me.pbImgIz.Image = CType(resources.GetObject("pbImgIz.Image"), System.Drawing.Image)
        Me.pbImgIz.Location = New System.Drawing.Point(0, 35)
        Me.pbImgIz.Name = "pbImgIz"
        Me.pbImgIz.Size = New System.Drawing.Size(22, 403)
        Me.pbImgIz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImgIz.TabIndex = 10
        Me.pbImgIz.TabStop = False
        '
        'pbImgDr
        '
        Me.pbImgDr.Image = CType(resources.GetObject("pbImgDr.Image"), System.Drawing.Image)
        Me.pbImgDr.Location = New System.Drawing.Point(338, 34)
        Me.pbImgDr.Name = "pbImgDr"
        Me.pbImgDr.Size = New System.Drawing.Size(22, 403)
        Me.pbImgDr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImgDr.TabIndex = 11
        Me.pbImgDr.TabStop = False
        '
        'frmConfigContrasenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(360, 439)
        Me.Controls.Add(Me.pbImgDr)
        Me.Controls.Add(Me.pbImgIz)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtPassConfirmado)
        Me.Controls.Add(Me.lblPassConfirmado)
        Me.Controls.Add(Me.txtPassNueva)
        Me.Controls.Add(Me.lblPassNueva)
        Me.Controls.Add(Me.txtPassAnterior)
        Me.Controls.Add(Me.lblPassActual)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.pbimagenuser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfigContrasenia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfigContrasenia"
        CType(Me.pbimagenuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImgIz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImgDr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbimagenuser As PictureBox
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblPassActual As Label
    Friend WithEvents txtPassAnterior As TextBox
    Friend WithEvents txtPassNueva As TextBox
    Friend WithEvents lblPassNueva As Label
    Friend WithEvents txtPassConfirmado As TextBox
    Friend WithEvents lblPassConfirmado As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents pbImgIz As PictureBox
    Friend WithEvents pbImgDr As PictureBox
End Class
