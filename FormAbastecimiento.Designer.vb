<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbastecimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbastecimiento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnHub = New System.Windows.Forms.Button()
        Me.PcbAlerta = New System.Windows.Forms.PictureBox()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.BtnNAgregar = New System.Windows.Forms.Button()
        Me.InpNPrecio = New System.Windows.Forms.NumericUpDown()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.InpNCantidad = New System.Windows.Forms.NumericUpDown()
        Me.InpNNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PcbAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InpNPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InpNCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(27, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Agregar compra"
        '
        'BtnHub
        '
        Me.BtnHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHub.ForeColor = System.Drawing.Color.White
        Me.BtnHub.Location = New System.Drawing.Point(464, 0)
        Me.BtnHub.Name = "BtnHub"
        Me.BtnHub.Size = New System.Drawing.Size(42, 40)
        Me.BtnHub.TabIndex = 12
        Me.BtnHub.Text = "I"
        Me.BtnHub.UseVisualStyleBackColor = True
        '
        'PcbAlerta
        '
        Me.PcbAlerta.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PcbAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PcbAlerta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PcbAlerta.Image = Global.FelseFor.My.Resources.Recursos.alerta
        Me.PcbAlerta.Location = New System.Drawing.Point(408, 0)
        Me.PcbAlerta.Name = "PcbAlerta"
        Me.PcbAlerta.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.PcbAlerta.Size = New System.Drawing.Size(49, 39)
        Me.PcbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbAlerta.TabIndex = 15
        Me.PcbAlerta.TabStop = False
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblUser.Location = New System.Drawing.Point(233, 20)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(33, 32)
        Me.LblUser.TabIndex = 16
        Me.LblUser.Text = "..."
        '
        'BtnNAgregar
        '
        Me.BtnNAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnNAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnNAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNAgregar.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnNAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnNAgregar.Location = New System.Drawing.Point(192, 240)
        Me.BtnNAgregar.Name = "BtnNAgregar"
        Me.BtnNAgregar.Size = New System.Drawing.Size(106, 42)
        Me.BtnNAgregar.TabIndex = 7
        Me.BtnNAgregar.Text = "Agregar"
        Me.BtnNAgregar.UseVisualStyleBackColor = False
        '
        'InpNPrecio
        '
        Me.InpNPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.InpNPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InpNPrecio.DecimalPlaces = 2
        Me.InpNPrecio.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InpNPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InpNPrecio.Location = New System.Drawing.Point(237, 112)
        Me.InpNPrecio.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.InpNPrecio.Name = "InpNPrecio"
        Me.InpNPrecio.Size = New System.Drawing.Size(184, 29)
        Me.InpNPrecio.TabIndex = 8
        Me.InpNPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InpNPrecio.ThousandsSeparator = True
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblPrecio.Location = New System.Drawing.Point(49, 154)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(168, 21)
        Me.LblPrecio.TabIndex = 5
        Me.LblPrecio.Text = "Cantidad de unidades"
        '
        'InpNCantidad
        '
        Me.InpNCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.InpNCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InpNCantidad.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InpNCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InpNCantidad.Location = New System.Drawing.Point(237, 149)
        Me.InpNCantidad.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.InpNCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.InpNCantidad.Name = "InpNCantidad"
        Me.InpNCantidad.Size = New System.Drawing.Size(184, 29)
        Me.InpNCantidad.TabIndex = 9
        Me.InpNCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InpNCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'InpNNombre
        '
        Me.InpNNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.InpNNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InpNNombre.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InpNNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InpNNombre.Location = New System.Drawing.Point(237, 75)
        Me.InpNNombre.Name = "InpNNombre"
        Me.InpNNombre.Size = New System.Drawing.Size(240, 29)
        Me.InpNNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(122, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Precio total   $"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblNombre.Location = New System.Drawing.Point(48, 76)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(171, 21)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre del producto"
        '
        'CmbTipo
        '
        Me.CmbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"Almacenamiento", "Fuente", "Gabinete", "Gráfica", "Placa Madre", "Procesador", "RAM", "Extra"})
        Me.CmbTipo.Location = New System.Drawing.Point(237, 186)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(184, 29)
        Me.CmbTipo.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(175, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 21)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Tipo"
        '
        'FormAbastecimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(501, 310)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.PcbAlerta)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnHub)
        Me.Controls.Add(Me.InpNNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InpNCantidad)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.BtnNAgregar)
        Me.Controls.Add(Me.InpNPrecio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAbastecimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abastecimiento"
        CType(Me.PcbAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InpNPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InpNCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHub As Button
    Friend WithEvents PcbAlerta As PictureBox
    Friend WithEvents LblUser As Label
    Friend WithEvents BtnNAgregar As Button
    Friend WithEvents InpNPrecio As NumericUpDown
    Friend WithEvents LblPrecio As Label
    Friend WithEvents InpNCantidad As NumericUpDown
    Friend WithEvents InpNNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents Label3 As Label
End Class
