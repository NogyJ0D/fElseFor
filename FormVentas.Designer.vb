<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentas))
        Me.LblUser = New System.Windows.Forms.Label()
        Me.PcbAlerta = New System.Windows.Forms.PictureBox()
        Me.BtnHub = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbCompu = New System.Windows.Forms.ComboBox()
        Me.BtnFactura = New System.Windows.Forms.Button()
        Me.LblTiene = New System.Windows.Forms.Label()
        Me.DGHardware = New System.Windows.Forms.DataGridView()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Componente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InpCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InpDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PcbAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGHardware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblUser.Location = New System.Drawing.Point(298, 16)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(28, 30)
        Me.LblUser.TabIndex = 24
        Me.LblUser.Text = "..."
        '
        'PcbAlerta
        '
        Me.PcbAlerta.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PcbAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PcbAlerta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PcbAlerta.Image = Global.FelseFor.My.Resources.Recursos.alerta
        Me.PcbAlerta.Location = New System.Drawing.Point(840, 0)
        Me.PcbAlerta.Name = "PcbAlerta"
        Me.PcbAlerta.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.PcbAlerta.Size = New System.Drawing.Size(49, 39)
        Me.PcbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbAlerta.TabIndex = 23
        Me.PcbAlerta.TabStop = False
        '
        'BtnHub
        '
        Me.BtnHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.BtnHub.ForeColor = System.Drawing.Color.White
        Me.BtnHub.Location = New System.Drawing.Point(896, 0)
        Me.BtnHub.Name = "BtnHub"
        Me.BtnHub.Size = New System.Drawing.Size(47, 39)
        Me.BtnHub.TabIndex = 22
        Me.BtnHub.Text = "I"
        Me.BtnHub.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 30)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Venta de computadoras"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(39, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 28)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Vender"
        '
        'CmbCompu
        '
        Me.CmbCompu.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CmbCompu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCompu.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CmbCompu.FormattingEnabled = True
        Me.CmbCompu.Location = New System.Drawing.Point(130, 72)
        Me.CmbCompu.Name = "CmbCompu"
        Me.CmbCompu.Size = New System.Drawing.Size(216, 29)
        Me.CmbCompu.TabIndex = 27
        '
        'BtnFactura
        '
        Me.BtnFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFactura.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnFactura.Location = New System.Drawing.Point(162, 255)
        Me.BtnFactura.Name = "BtnFactura"
        Me.BtnFactura.Size = New System.Drawing.Size(152, 40)
        Me.BtnFactura.TabIndex = 28
        Me.BtnFactura.Text = "Preparar factura"
        Me.BtnFactura.UseVisualStyleBackColor = False
        '
        'LblTiene
        '
        Me.LblTiene.AutoSize = True
        Me.LblTiene.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LblTiene.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblTiene.Location = New System.Drawing.Point(474, 34)
        Me.LblTiene.Name = "LblTiene"
        Me.LblTiene.Size = New System.Drawing.Size(296, 30)
        Me.LblTiene.TabIndex = 29
        Me.LblTiene.Text = "Especificaciones de Hardware"
        '
        'DGHardware
        '
        Me.DGHardware.AllowUserToAddRows = False
        Me.DGHardware.AllowUserToDeleteRows = False
        Me.DGHardware.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.DGHardware.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGHardware.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGHardware.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Componente})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGHardware.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGHardware.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.DGHardware.Location = New System.Drawing.Point(362, 72)
        Me.DGHardware.Name = "DGHardware"
        Me.DGHardware.ReadOnly = True
        Me.DGHardware.RowHeadersVisible = False
        Me.DGHardware.Size = New System.Drawing.Size(552, 223)
        Me.DGHardware.TabIndex = 30
        '
        'Tipo
        '
        Me.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!)
        Me.Tipo.DefaultCellStyle = DataGridViewCellStyle2
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 56
        '
        'Componente
        '
        Me.Componente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!)
        Me.Componente.DefaultCellStyle = DataGridViewCellStyle3
        Me.Componente.HeaderText = "Componente"
        Me.Componente.Name = "Componente"
        Me.Componente.ReadOnly = True
        Me.Componente.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'InpCliente
        '
        Me.InpCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.InpCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InpCliente.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InpCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InpCliente.Location = New System.Drawing.Point(130, 175)
        Me.InpCliente.Name = "InpCliente"
        Me.InpCliente.Size = New System.Drawing.Size(216, 29)
        Me.InpCliente.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 28)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Cliente"
        '
        'InpDireccion
        '
        Me.InpDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.InpDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InpDireccion.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InpDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InpDireccion.Location = New System.Drawing.Point(130, 215)
        Me.InpDireccion.Name = "InpDireccion"
        Me.InpDireccion.Size = New System.Drawing.Size(216, 29)
        Me.InpDireccion.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Dirección"
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(937, 319)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InpDireccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InpCliente)
        Me.Controls.Add(Me.DGHardware)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.LblTiene)
        Me.Controls.Add(Me.BtnFactura)
        Me.Controls.Add(Me.CmbCompu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PcbAlerta)
        Me.Controls.Add(Me.BtnHub)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.PcbAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGHardware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUser As Label
    Friend WithEvents PcbAlerta As PictureBox
    Friend WithEvents BtnHub As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbCompu As ComboBox
    Friend WithEvents BtnFactura As Button
    Friend WithEvents LblTiene As Label
    Friend WithEvents DGHardware As DataGridView
    Friend WithEvents InpCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents InpDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Componente As DataGridViewTextBoxColumn
End Class
