<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlmacen
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlmacen))
        Me.BtnHub = New System.Windows.Forms.Button()
        Me.DataGridAlmacen = New System.Windows.Forms.DataGridView()
        Me.Número = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGCNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGCPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGCCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTCTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnEActualizar = New System.Windows.Forms.Button()
        Me.PcbAlerta = New System.Windows.Forms.PictureBox()
        Me.LblUser = New System.Windows.Forms.Label()
        CType(Me.DataGridAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnHub
        '
        Me.BtnHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.BtnHub.ForeColor = System.Drawing.Color.White
        Me.BtnHub.Location = New System.Drawing.Point(800, 0)
        Me.BtnHub.Name = "BtnHub"
        Me.BtnHub.Size = New System.Drawing.Size(40, 40)
        Me.BtnHub.TabIndex = 13
        Me.BtnHub.Text = "I"
        Me.BtnHub.UseVisualStyleBackColor = True
        '
        'DataGridAlmacen
        '
        Me.DataGridAlmacen.AllowUserToAddRows = False
        Me.DataGridAlmacen.AllowUserToDeleteRows = False
        Me.DataGridAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridAlmacen.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.DataGridAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridAlmacen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2, 5, 2, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridAlmacen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Número, Me.DGCNombre, Me.DGCPrecio, Me.DGCCantidad, Me.DTCTipo, Me.Origen})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridAlmacen.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridAlmacen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridAlmacen.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.DataGridAlmacen.Location = New System.Drawing.Point(0, 72)
        Me.DataGridAlmacen.Name = "DataGridAlmacen"
        Me.DataGridAlmacen.ReadOnly = True
        Me.DataGridAlmacen.RowHeadersVisible = False
        Me.DataGridAlmacen.Size = New System.Drawing.Size(837, 448)
        Me.DataGridAlmacen.TabIndex = 15
        '
        'Número
        '
        Me.Número.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Número.Frozen = True
        Me.Número.HeaderText = ""
        Me.Número.MinimumWidth = 10
        Me.Número.Name = "Número"
        Me.Número.ReadOnly = True
        Me.Número.Width = 23
        '
        'DGCNombre
        '
        Me.DGCNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2)
        Me.DGCNombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGCNombre.FillWeight = 253.8071!
        Me.DGCNombre.HeaderText = "Nombre"
        Me.DGCNombre.Name = "DGCNombre"
        Me.DGCNombre.ReadOnly = True
        '
        'DGCPrecio
        '
        Me.DGCPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(2)
        Me.DGCPrecio.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGCPrecio.FillWeight = 61.54822!
        Me.DGCPrecio.HeaderText = "Precio Total ($)"
        Me.DGCPrecio.MinimumWidth = 130
        Me.DGCPrecio.Name = "DGCPrecio"
        Me.DGCPrecio.ReadOnly = True
        Me.DGCPrecio.Width = 130
        '
        'DGCCantidad
        '
        Me.DGCCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(2)
        Me.DGCCantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGCCantidad.FillWeight = 61.54822!
        Me.DGCCantidad.HeaderText = "Cantidad"
        Me.DGCCantidad.Name = "DGCCantidad"
        Me.DGCCantidad.ReadOnly = True
        Me.DGCCantidad.Width = 91
        '
        'DTCTipo
        '
        Me.DTCTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(2)
        Me.DTCTipo.DefaultCellStyle = DataGridViewCellStyle5
        Me.DTCTipo.FillWeight = 61.54822!
        Me.DTCTipo.HeaderText = "Tipo"
        Me.DTCTipo.Name = "DTCTipo"
        Me.DTCTipo.ReadOnly = True
        Me.DTCTipo.Width = 63
        '
        'Origen
        '
        Me.Origen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(2)
        Me.Origen.DefaultCellStyle = DataGridViewCellStyle6
        Me.Origen.FillWeight = 61.54822!
        Me.Origen.HeaderText = "Origen"
        Me.Origen.Name = "Origen"
        Me.Origen.ReadOnly = True
        Me.Origen.Width = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Inventario del almacén"
        '
        'AlmacenBindingSource
        '
        Me.AlmacenBindingSource.DataMember = "Almacen"
        '
        'BtnEActualizar
        '
        Me.BtnEActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnEActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnEActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEActualizar.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEActualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnEActualizar.Location = New System.Drawing.Point(529, 17)
        Me.BtnEActualizar.Name = "BtnEActualizar"
        Me.BtnEActualizar.Size = New System.Drawing.Size(127, 39)
        Me.BtnEActualizar.TabIndex = 17
        Me.BtnEActualizar.Text = "Actualizar"
        Me.BtnEActualizar.UseVisualStyleBackColor = False
        '
        'PcbAlerta
        '
        Me.PcbAlerta.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PcbAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PcbAlerta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PcbAlerta.Image = Global.FelseFor.My.Resources.Recursos.alerta
        Me.PcbAlerta.Location = New System.Drawing.Point(744, 0)
        Me.PcbAlerta.Name = "PcbAlerta"
        Me.PcbAlerta.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.PcbAlerta.Size = New System.Drawing.Size(49, 39)
        Me.PcbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbAlerta.TabIndex = 18
        Me.PcbAlerta.TabStop = False
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblUser.Location = New System.Drawing.Point(345, 21)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(33, 32)
        Me.LblUser.TabIndex = 19
        Me.LblUser.Text = "..."
        '
        'FormAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(837, 520)
        Me.Controls.Add(Me.DataGridAlmacen)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.PcbAlerta)
        Me.Controls.Add(Me.BtnEActualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacén"
        CType(Me.DataGridAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHub As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AlmacenBindingSource As BindingSource
    Public WithEvents DataGridAlmacen As DataGridView
    Friend WithEvents BtnEActualizar As Button
    Friend WithEvents PcbAlerta As PictureBox
    Friend WithEvents LblUser As Label
    Friend WithEvents Número As DataGridViewTextBoxColumn
    Friend WithEvents DGCNombre As DataGridViewTextBoxColumn
    Friend WithEvents DGCPrecio As DataGridViewTextBoxColumn
    Friend WithEvents DGCCantidad As DataGridViewTextBoxColumn
    Friend WithEvents DTCTipo As DataGridViewTextBoxColumn
    Friend WithEvents Origen As DataGridViewTextBoxColumn
End Class
