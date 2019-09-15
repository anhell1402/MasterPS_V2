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
        Me.lblEncabezadoAviso = New System.Windows.Forms.Label()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblMensajeAviso = New System.Windows.Forms.Label()
        Me.ImagenAviso = New System.Windows.Forms.PictureBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.PanelSuperiorAviso.SuspendLayout()
        CType(Me.ImagenAviso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperiorAviso
        '
        Me.PanelSuperiorAviso.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSuperiorAviso.Controls.Add(Me.lblEncabezadoAviso)
        Me.PanelSuperiorAviso.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperiorAviso.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperiorAviso.Name = "PanelSuperiorAviso"
        Me.PanelSuperiorAviso.Size = New System.Drawing.Size(388, 30)
        Me.PanelSuperiorAviso.TabIndex = 0
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
        Me.btnSi.Location = New System.Drawing.Point(173, 114)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(87, 30)
        Me.btnSi.TabIndex = 1
        Me.btnSi.Text = "SI"
        Me.btnSi.UseVisualStyleBackColor = False
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
        Me.btnNo.Location = New System.Drawing.Point(276, 114)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(87, 30)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'lblMensajeAviso
        '
        Me.lblMensajeAviso.AutoSize = True
        Me.lblMensajeAviso.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeAviso.ForeColor = System.Drawing.Color.Black
        Me.lblMensajeAviso.Location = New System.Drawing.Point(77, 41)
        Me.lblMensajeAviso.Name = "lblMensajeAviso"
        Me.lblMensajeAviso.Size = New System.Drawing.Size(61, 21)
        Me.lblMensajeAviso.TabIndex = 3
        Me.lblMensajeAviso.Text = "Label2"
        '
        'ImagenAviso
        '
        Me.ImagenAviso.Location = New System.Drawing.Point(12, 41)
        Me.ImagenAviso.Name = "ImagenAviso"
        Me.ImagenAviso.Size = New System.Drawing.Size(50, 50)
        Me.ImagenAviso.TabIndex = 4
        Me.ImagenAviso.TabStop = False
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
        Me.btnOK.Location = New System.Drawing.Point(276, 114)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 30)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'frmVentanaAviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 159)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.ImagenAviso)
        Me.Controls.Add(Me.lblMensajeAviso)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.PanelSuperiorAviso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVentanaAviso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmVentanaAviso"
        Me.PanelSuperiorAviso.ResumeLayout(False)
        Me.PanelSuperiorAviso.PerformLayout()
        CType(Me.ImagenAviso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelSuperiorAviso As Panel
    Friend WithEvents btnSi As Button
    Friend WithEvents lblEncabezadoAviso As Label
    Friend WithEvents btnNo As Button
    Friend WithEvents lblMensajeAviso As Label
    Friend WithEvents ImagenAviso As PictureBox
    Friend WithEvents btnOK As Button
End Class
