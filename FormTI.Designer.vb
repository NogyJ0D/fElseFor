<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTI))
        Me.LblUser = New System.Windows.Forms.Label()
        Me.BtnHub = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAlertas = New System.Windows.Forms.Button()
        Me.DGAlertas = New System.Windows.Forms.DataGridView()
        Me.Ticket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Problema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnArt = New System.Windows.Forms.Button()
        Me.GrbArt = New System.Windows.Forms.GroupBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InpNNombre = New System.Windows.Forms.TextBox()
        Me.InpNCantidad = New System.Windows.Forms.NumericUpDown()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.InpNPrecio = New System.Windows.Forms.NumericUpDown()
        Me.BtnNAgregar = New System.Windows.Forms.Button()
        Me.GrbAlerta = New System.Windows.Forms.GroupBox()
        Me.BtnSolucionado = New System.Windows.Forms.Button()
        Me.CmbTicket = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GrbEliminar = New System.Windows.Forms.GroupBox()
        Me.CmbEProducto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnEEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblFacturas = New System.Windows.Forms.Label()
        Me.LblComprobantes = New System.Windows.Forms.Label()
        Me.LblRRHH = New System.Windows.Forms.Label()
        Me.LblAlertas = New System.Windows.Forms.Label()
        Me.LblAlmacen = New System.Windows.Forms.Label()
        Me.LblCarpeta = New System.Windows.Forms.Label()
        Me.BtnCarpeta = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGAlertas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbArt.SuspendLayout()
        CType(Me.InpNCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InpNPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbAlerta.SuspendLayout()
        Me.GrbEliminar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblUser.Location = New System.Drawing.Point(298, 18)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(33, 32)
        Me.LblUser.TabIndex = 19
        Me.LblUser.Text = "..."
        '
        'BtnHub
        '
        Me.BtnHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.BtnHub.ForeColor = System.Drawing.Color.White
        Me.BtnHub.Location = New System.Drawing.Point(712, 0)
        Me.BtnHub.Name = "BtnHub"
        Me.BtnHub.Size = New System.Drawing.Size(43, 40)
        Me.BtnHub.TabIndex = 18
        Me.BtnHub.Text = "I"
        Me.BtnHub.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 32)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ver estado del sistema"
        '
        'BtnAlertas
        '
        Me.BtnAlertas.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnAlertas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlertas.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAlertas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnAlertas.Location = New System.Drawing.Point(20, 80)
        Me.BtnAlertas.Name = "BtnAlertas"
        Me.BtnAlertas.Size = New System.Drawing.Size(96, 60)
        Me.BtnAlertas.TabIndex = 20
        Me.BtnAlertas.Text = "Revisar alertas"
        Me.BtnAlertas.UseVisualStyleBackColor = False
        '
        'DGAlertas
        '
        Me.DGAlertas.AllowUserToAddRows = False
        Me.DGAlertas.AllowUserToDeleteRows = False
        Me.DGAlertas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.DGAlertas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGAlertas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlertas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAlertas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ticket, Me.Nombre, Me.Problema, Me.Fecha, Me.Departamento})
        Me.DGAlertas.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.DGAlertas.Location = New System.Drawing.Point(11, 16)
        Me.DGAlertas.Name = "DGAlertas"
        Me.DGAlertas.ReadOnly = True
        Me.DGAlertas.RowHeadersVisible = False
        Me.DGAlertas.Size = New System.Drawing.Size(594, 192)
        Me.DGAlertas.TabIndex = 21
        '
        'Ticket
        '
        Me.Ticket.HeaderText = "Ticket"
        Me.Ticket.Name = "Ticket"
        Me.Ticket.ReadOnly = True
        Me.Ticket.Width = 50
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Problema
        '
        Me.Problema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Problema.HeaderText = "Problema"
        Me.Problema.Name = "Problema"
        Me.Problema.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Departamento
        '
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        '
        'BtnArt
        '
        Me.BtnArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnArt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArt.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnArt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnArt.Location = New System.Drawing.Point(20, 146)
        Me.BtnArt.Name = "BtnArt"
        Me.BtnArt.Size = New System.Drawing.Size(96, 55)
        Me.BtnArt.TabIndex = 22
        Me.BtnArt.Text = "Generar artículo"
        Me.BtnArt.UseVisualStyleBackColor = False
        '
        'GrbArt
        '
        Me.GrbArt.Controls.Add(Me.LblNombre)
        Me.GrbArt.Controls.Add(Me.Label2)
        Me.GrbArt.Controls.Add(Me.InpNNombre)
        Me.GrbArt.Controls.Add(Me.InpNCantidad)
        Me.GrbArt.Controls.Add(Me.LblPrecio)
        Me.GrbArt.Controls.Add(Me.InpNPrecio)
        Me.GrbArt.Controls.Add(Me.BtnNAgregar)
        Me.GrbArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbArt.Location = New System.Drawing.Point(128, 72)
        Me.GrbArt.Name = "GrbArt"
        Me.GrbArt.Size = New System.Drawing.Size(296, 160)
        Me.GrbArt.TabIndex = 23
        Me.GrbArt.TabStop = False
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblNombre.Location = New System.Drawing.Point(8, 25)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(162, 20)
        Me.LblNombre.TabIndex = 12
        Me.LblNombre.Text = "Nombre del producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(79, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Precio total: $"
        '
        'InpNNombre
        '
        Me.InpNNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.InpNNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InpNNombre.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.InpNNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InpNNombre.Location = New System.Drawing.Point(184, 24)
        Me.InpNNombre.Name = "InpNNombre"
        Me.InpNNombre.Size = New System.Drawing.Size(100, 25)
        Me.InpNNombre.TabIndex = 13
        '
        'InpNCantidad
        '
        Me.InpNCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.InpNCantidad.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.InpNCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InpNCantidad.Location = New System.Drawing.Point(184, 88)
        Me.InpNCantidad.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.InpNCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.InpNCantidad.Name = "InpNCantidad"
        Me.InpNCantidad.Size = New System.Drawing.Size(100, 25)
        Me.InpNCantidad.TabIndex = 17
        Me.InpNCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblPrecio.Location = New System.Drawing.Point(9, 90)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(161, 20)
        Me.LblPrecio.TabIndex = 14
        Me.LblPrecio.Text = "Cantidad de unidades:"
        '
        'InpNPrecio
        '
        Me.InpNPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.InpNPrecio.DecimalPlaces = 2
        Me.InpNPrecio.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.InpNPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InpNPrecio.Location = New System.Drawing.Point(184, 56)
        Me.InpNPrecio.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.InpNPrecio.Name = "InpNPrecio"
        Me.InpNPrecio.Size = New System.Drawing.Size(100, 25)
        Me.InpNPrecio.TabIndex = 16
        Me.InpNPrecio.ThousandsSeparator = True
        '
        'BtnNAgregar
        '
        Me.BtnNAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnNAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnNAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNAgregar.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnNAgregar.Location = New System.Drawing.Point(184, 120)
        Me.BtnNAgregar.Name = "BtnNAgregar"
        Me.BtnNAgregar.Size = New System.Drawing.Size(98, 28)
        Me.BtnNAgregar.TabIndex = 15
        Me.BtnNAgregar.Text = "Agregar"
        Me.BtnNAgregar.UseVisualStyleBackColor = False
        '
        'GrbAlerta
        '
        Me.GrbAlerta.Controls.Add(Me.BtnSolucionado)
        Me.GrbAlerta.Controls.Add(Me.CmbTicket)
        Me.GrbAlerta.Controls.Add(Me.Label3)
        Me.GrbAlerta.Controls.Add(Me.DGAlertas)
        Me.GrbAlerta.Location = New System.Drawing.Point(128, 72)
        Me.GrbAlerta.Name = "GrbAlerta"
        Me.GrbAlerta.Size = New System.Drawing.Size(616, 264)
        Me.GrbAlerta.TabIndex = 24
        Me.GrbAlerta.TabStop = False
        '
        'BtnSolucionado
        '
        Me.BtnSolucionado.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnSolucionado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnSolucionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSolucionado.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSolucionado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnSolucionado.Location = New System.Drawing.Point(187, 222)
        Me.BtnSolucionado.Name = "BtnSolucionado"
        Me.BtnSolucionado.Size = New System.Drawing.Size(112, 25)
        Me.BtnSolucionado.TabIndex = 24
        Me.BtnSolucionado.Text = "Solucionado"
        Me.BtnSolucionado.UseVisualStyleBackColor = False
        '
        'CmbTicket
        '
        Me.CmbTicket.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CmbTicket.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CmbTicket.FormattingEnabled = True
        Me.CmbTicket.Location = New System.Drawing.Point(112, 222)
        Me.CmbTicket.Name = "CmbTicket"
        Me.CmbTicket.Size = New System.Drawing.Size(64, 25)
        Me.CmbTicket.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Ticket Nº"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnEliminar.Location = New System.Drawing.Point(20, 207)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(96, 58)
        Me.BtnEliminar.TabIndex = 25
        Me.BtnEliminar.Text = "Eliminar artículo"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'GrbEliminar
        '
        Me.GrbEliminar.Controls.Add(Me.CmbEProducto)
        Me.GrbEliminar.Controls.Add(Me.Label4)
        Me.GrbEliminar.Controls.Add(Me.BtnEEliminar)
        Me.GrbEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbEliminar.Location = New System.Drawing.Point(128, 70)
        Me.GrbEliminar.Name = "GrbEliminar"
        Me.GrbEliminar.Size = New System.Drawing.Size(296, 96)
        Me.GrbEliminar.TabIndex = 26
        Me.GrbEliminar.TabStop = False
        '
        'CmbEProducto
        '
        Me.CmbEProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEProducto.FormattingEnabled = True
        Me.CmbEProducto.Location = New System.Drawing.Point(176, 24)
        Me.CmbEProducto.Name = "CmbEProducto"
        Me.CmbEProducto.Size = New System.Drawing.Size(112, 24)
        Me.CmbEProducto.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nombre del producto"
        '
        'BtnEEliminar
        '
        Me.BtnEEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnEEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnEEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEEliminar.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnEEliminar.Location = New System.Drawing.Point(184, 56)
        Me.BtnEEliminar.Name = "BtnEEliminar"
        Me.BtnEEliminar.Size = New System.Drawing.Size(98, 28)
        Me.BtnEEliminar.TabIndex = 15
        Me.BtnEEliminar.Text = "Eliminar"
        Me.BtnEEliminar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblFacturas)
        Me.GroupBox1.Controls.Add(Me.LblComprobantes)
        Me.GroupBox1.Controls.Add(Me.LblRRHH)
        Me.GroupBox1.Controls.Add(Me.LblAlertas)
        Me.GroupBox1.Controls.Add(Me.LblAlmacen)
        Me.GroupBox1.Controls.Add(Me.LblCarpeta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(128, 344)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 144)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado de los archivos"
        '
        'LblFacturas
        '
        Me.LblFacturas.AutoSize = True
        Me.LblFacturas.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblFacturas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblFacturas.Location = New System.Drawing.Point(368, 25)
        Me.LblFacturas.Name = "LblFacturas"
        Me.LblFacturas.Size = New System.Drawing.Size(111, 32)
        Me.LblFacturas.TabIndex = 22
        Me.LblFacturas.Text = "Facturas:"
        '
        'LblComprobantes
        '
        Me.LblComprobantes.AutoSize = True
        Me.LblComprobantes.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblComprobantes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblComprobantes.Location = New System.Drawing.Point(224, 96)
        Me.LblComprobantes.Name = "LblComprobantes"
        Me.LblComprobantes.Size = New System.Drawing.Size(113, 20)
        Me.LblComprobantes.TabIndex = 21
        Me.LblComprobantes.Text = "Comprobantes:"
        '
        'LblRRHH
        '
        Me.LblRRHH.AutoSize = True
        Me.LblRRHH.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblRRHH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblRRHH.Location = New System.Drawing.Point(224, 64)
        Me.LblRRHH.Name = "LblRRHH"
        Me.LblRRHH.Size = New System.Drawing.Size(53, 20)
        Me.LblRRHH.TabIndex = 19
        Me.LblRRHH.Text = "RRHH:"
        '
        'LblAlertas
        '
        Me.LblAlertas.AutoSize = True
        Me.LblAlertas.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblAlertas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblAlertas.Location = New System.Drawing.Point(71, 96)
        Me.LblAlertas.Name = "LblAlertas"
        Me.LblAlertas.Size = New System.Drawing.Size(60, 20)
        Me.LblAlertas.TabIndex = 2
        Me.LblAlertas.Text = "Alertas:"
        '
        'LblAlmacen
        '
        Me.LblAlmacen.AutoSize = True
        Me.LblAlmacen.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblAlmacen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblAlmacen.Location = New System.Drawing.Point(59, 64)
        Me.LblAlmacen.Name = "LblAlmacen"
        Me.LblAlmacen.Size = New System.Drawing.Size(72, 20)
        Me.LblAlmacen.TabIndex = 1
        Me.LblAlmacen.Text = "Almacen:"
        '
        'LblCarpeta
        '
        Me.LblCarpeta.AutoSize = True
        Me.LblCarpeta.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblCarpeta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblCarpeta.Location = New System.Drawing.Point(29, 25)
        Me.LblCarpeta.Name = "LblCarpeta"
        Me.LblCarpeta.Size = New System.Drawing.Size(107, 32)
        Me.LblCarpeta.TabIndex = 0
        Me.LblCarpeta.Text = "Carpeta:"
        '
        'BtnCarpeta
        '
        Me.BtnCarpeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnCarpeta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCarpeta.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCarpeta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnCarpeta.Location = New System.Drawing.Point(229, 494)
        Me.BtnCarpeta.Name = "BtnCarpeta"
        Me.BtnCarpeta.Size = New System.Drawing.Size(111, 36)
        Me.BtnCarpeta.TabIndex = 20
        Me.BtnCarpeta.Text = "Abrir carpeta"
        Me.BtnCarpeta.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnActualizar.Location = New System.Drawing.Point(128, 494)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(93, 36)
        Me.BtnActualizar.TabIndex = 18
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(20, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 55)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Ver almacén"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormTI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 542)
        Me.Controls.Add(Me.GrbEliminar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCarpeta)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.GrbArt)
        Me.Controls.Add(Me.BtnArt)
        Me.Controls.Add(Me.BtnAlertas)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.BtnHub)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrbAlerta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IT"
        CType(Me.DGAlertas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbArt.ResumeLayout(False)
        Me.GrbArt.PerformLayout()
        CType(Me.InpNCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InpNPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbAlerta.ResumeLayout(False)
        Me.GrbAlerta.PerformLayout()
        Me.GrbEliminar.ResumeLayout(False)
        Me.GrbEliminar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUser As Label
    Friend WithEvents BtnHub As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAlertas As Button
    Friend WithEvents DGAlertas As DataGridView
    Friend WithEvents BtnArt As Button
    Friend WithEvents GrbArt As GroupBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InpNNombre As TextBox
    Friend WithEvents InpNCantidad As NumericUpDown
    Friend WithEvents LblPrecio As Label
    Friend WithEvents InpNPrecio As NumericUpDown
    Friend WithEvents BtnNAgregar As Button
    Friend WithEvents GrbAlerta As GroupBox
    Friend WithEvents BtnSolucionado As Button
    Friend WithEvents CmbTicket As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents GrbEliminar As GroupBox
    Friend WithEvents CmbEProducto As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnEEliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblAlertas As Label
    Friend WithEvents LblAlmacen As Label
    Friend WithEvents LblCarpeta As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LblRRHH As Label
    Friend WithEvents BtnCarpeta As Button
    Friend WithEvents LblComprobantes As Label
    Friend WithEvents LblFacturas As Label
    Friend WithEvents Ticket As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Problema As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
End Class
