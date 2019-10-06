<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisos
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
        Me.pnlDisplayMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnObtenerPermisos = New System.Windows.Forms.Button()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.lblMenuDisplay = New System.Windows.Forms.Label()
        Me.pnlDisplayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDisplayMenu
        '
        Me.pnlDisplayMenu.AutoScroll = True
        Me.pnlDisplayMenu.Controls.Add(Me.lblMenuDisplay)
        Me.pnlDisplayMenu.Location = New System.Drawing.Point(24, 13)
        Me.pnlDisplayMenu.Name = "pnlDisplayMenu"
        Me.pnlDisplayMenu.Size = New System.Drawing.Size(662, 504)
        Me.pnlDisplayMenu.TabIndex = 0
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
        Me.btnSalir.Location = New System.Drawing.Point(834, 464)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(134, 53)
        Me.btnSalir.TabIndex = 9
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
        Me.btnGuardar.Location = New System.Drawing.Point(834, 391)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(134, 53)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(713, 37)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(99, 17)
        Me.lblDescripcion.TabIndex = 13
        Me.lblDescripcion.Text = "ROL A APLICAR:"
        '
        'btnObtenerPermisos
        '
        Me.btnObtenerPermisos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnObtenerPermisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnObtenerPermisos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnObtenerPermisos.FlatAppearance.BorderSize = 0
        Me.btnObtenerPermisos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnObtenerPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnObtenerPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnObtenerPermisos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObtenerPermisos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnObtenerPermisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnObtenerPermisos.Location = New System.Drawing.Point(818, 77)
        Me.btnObtenerPermisos.Name = "btnObtenerPermisos"
        Me.btnObtenerPermisos.Size = New System.Drawing.Size(134, 53)
        Me.btnObtenerPermisos.TabIndex = 15
        Me.btnObtenerPermisos.Text = "OBTENER"
        Me.btnObtenerPermisos.UseVisualStyleBackColor = False
        '
        'cmbRol
        '
        Me.cmbRol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Items.AddRange(New Object() {"a", "b", "c"})
        Me.cmbRol.Location = New System.Drawing.Point(818, 33)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(200, 21)
        Me.cmbRol.TabIndex = 16
        '
        'lblMenuDisplay
        '
        Me.lblMenuDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMenuDisplay.AutoSize = True
        Me.lblMenuDisplay.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuDisplay.Location = New System.Drawing.Point(13, 20)
        Me.lblMenuDisplay.Name = "lblMenuDisplay"
        Me.lblMenuDisplay.Size = New System.Drawing.Size(0, 17)
        Me.lblMenuDisplay.TabIndex = 17
        '
        'frmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 545)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbRol)
        Me.Controls.Add(Me.btnObtenerPermisos)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.pnlDisplayMenu)
        Me.Name = "frmPermisos"
        Me.Text = "Permisos"
        Me.pnlDisplayMenu.ResumeLayout(False)
        Me.pnlDisplayMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlDisplayMenu As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents btnObtenerPermisos As Button
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents lblMenuDisplay As Label
End Class
