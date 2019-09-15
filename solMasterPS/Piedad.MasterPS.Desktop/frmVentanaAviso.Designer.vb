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
        Me.btnEmpenio = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblEncabezadoAviso = New System.Windows.Forms.Label()
        Me.lblMensajeAviso = New System.Windows.Forms.Label()
        Me.ImagenAviso = New System.Windows.Forms.PictureBox()
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
        'btnEmpenio
        '
        Me.btnEmpenio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEmpenio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpenio.FlatAppearance.BorderSize = 0
        Me.btnEmpenio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEmpenio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnEmpenio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpenio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpenio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEmpenio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpenio.Location = New System.Drawing.Point(173, 114)
        Me.btnEmpenio.Name = "btnEmpenio"
        Me.btnEmpenio.Size = New System.Drawing.Size(87, 30)
        Me.btnEmpenio.TabIndex = 1
        Me.btnEmpenio.Text = "SI"
        Me.btnEmpenio.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(276, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "NO"
        Me.Button1.UseVisualStyleBackColor = False
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
        'frmVentanaAviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 159)
        Me.Controls.Add(Me.ImagenAviso)
        Me.Controls.Add(Me.lblMensajeAviso)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEmpenio)
        Me.Controls.Add(Me.PanelSuperiorAviso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVentanaAviso"
        Me.Text = "frmVentanaAviso"
        Me.PanelSuperiorAviso.ResumeLayout(False)
        Me.PanelSuperiorAviso.PerformLayout()
        CType(Me.ImagenAviso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelSuperiorAviso As Panel
    Friend WithEvents btnEmpenio As Button
    Friend WithEvents lblEncabezadoAviso As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblMensajeAviso As Label
    Friend WithEvents ImagenAviso As PictureBox
End Class
