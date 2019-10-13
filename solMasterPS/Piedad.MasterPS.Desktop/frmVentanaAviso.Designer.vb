<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentanaAviso
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
        Me.PanelSuperiorAviso = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.ImagenAviso = New System.Windows.Forms.PictureBox()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.lblMensajeAviso = New System.Windows.Forms.Label()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblEncabezadoAviso = New System.Windows.Forms.Label()
        Me.PanelSuperiorAviso.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.ImagenAviso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperiorAviso
        '
        Me.PanelSuperiorAviso.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSuperiorAviso.Controls.Add(Me.PanelContenedor)
        Me.PanelSuperiorAviso.Controls.Add(Me.lblEncabezadoAviso)
        Me.PanelSuperiorAviso.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperiorAviso.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperiorAviso.Name = "PanelSuperiorAviso"
        Me.PanelSuperiorAviso.Size = New System.Drawing.Size(390, 151)
        Me.PanelSuperiorAviso.TabIndex = 0
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContenedor.Controls.Add(Me.btnOK)
        Me.PanelContenedor.Controls.Add(Me.ImagenAviso)
        Me.PanelContenedor.Controls.Add(Me.btnSi)
        Me.PanelContenedor.Controls.Add(Me.lblMensajeAviso)
        Me.PanelContenedor.Controls.Add(Me.btnNo)
        Me.PanelContenedor.Location = New System.Drawing.Point(4, 26)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(382, 121)
        Me.PanelContenedor.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(287, 78)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 30)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'ImagenAviso
        '
        Me.ImagenAviso.Location = New System.Drawing.Point(3, 12)
        Me.ImagenAviso.Name = "ImagenAviso"
        Me.ImagenAviso.Size = New System.Drawing.Size(50, 50)
        Me.ImagenAviso.TabIndex = 4
        Me.ImagenAviso.TabStop = False
        '
        'btnSi
        '
        Me.btnSi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSi.FlatAppearance.BorderSize = 0
        Me.btnSi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSi.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSi.Location = New System.Drawing.Point(184, 78)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(87, 30)
        Me.btnSi.TabIndex = 1
        Me.btnSi.Text = "SI"
        Me.btnSi.UseVisualStyleBackColor = False
        '
        'lblMensajeAviso
        '
        Me.lblMensajeAviso.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeAviso.ForeColor = System.Drawing.Color.Black
        Me.lblMensajeAviso.Location = New System.Drawing.Point(59, 5)
        Me.lblMensajeAviso.Name = "lblMensajeAviso"
        Me.lblMensajeAviso.Size = New System.Drawing.Size(315, 63)
        Me.lblMensajeAviso.TabIndex = 3
        Me.lblMensajeAviso.Text = "Label2"
        Me.lblMensajeAviso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.FlatAppearance.BorderSize = 0
        Me.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNo.Location = New System.Drawing.Point(287, 78)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(87, 30)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'lblEncabezadoAviso
        '
        Me.lblEncabezadoAviso.AutoSize = True
        Me.lblEncabezadoAviso.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezadoAviso.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEncabezadoAviso.Location = New System.Drawing.Point(20, 6)
        Me.lblEncabezadoAviso.Name = "lblEncabezadoAviso"
        Me.lblEncabezadoAviso.Size = New System.Drawing.Size(50, 17)
        Me.lblEncabezadoAviso.TabIndex = 0
        Me.lblEncabezadoAviso.Text = "Label1"
        '
        'frmVentanaAviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(390, 151)
        Me.Controls.Add(Me.PanelSuperiorAviso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVentanaAviso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmVentanaAviso"
        Me.PanelSuperiorAviso.ResumeLayout(False)
        Me.PanelSuperiorAviso.PerformLayout()
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.ImagenAviso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperiorAviso As Panel
    Friend WithEvents btnSi As Button
    Friend WithEvents lblEncabezadoAviso As Label
    Friend WithEvents btnNo As Button
    Friend WithEvents lblMensajeAviso As Label
    Friend WithEvents ImagenAviso As PictureBox
    Friend WithEvents btnOK As Button
    Friend WithEvents PanelContenedor As Panel
End Class
