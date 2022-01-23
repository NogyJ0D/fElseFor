<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContabilidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormContabilidad))
        Me.LblUser = New System.Windows.Forms.Label()
        Me.BtnHub = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PcbAlerta = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbFacturas = New System.Windows.Forms.ComboBox()
        Me.BtnAsiento = New System.Windows.Forms.Button()
        Me.PcbFactura = New System.Windows.Forms.PictureBox()
        CType(Me.PcbAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblUser.Location = New System.Drawing.Point(265, 14)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(28, 30)
        Me.LblUser.TabIndex = 24
        Me.LblUser.Text = "..."
        '
        'BtnHub
        '
        Me.BtnHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.BtnHub.ForeColor = System.Drawing.Color.White
        Me.BtnHub.Location = New System.Drawing.Point(472, 0)
        Me.BtnHub.Name = "BtnHub"
        Me.BtnHub.Size = New System.Drawing.Size(33, 39)
        Me.BtnHub.TabIndex = 22
        Me.BtnHub.Text = "I"
        Me.BtnHub.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 30)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Registro de facturas"
        '
        'PcbAlerta
        '
        Me.PcbAlerta.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PcbAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PcbAlerta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PcbAlerta.Image = Global.FelseFor.My.Resources.Recursos.alerta
        Me.PcbAlerta.Location = New System.Drawing.Point(416, 0)
        Me.PcbAlerta.Name = "PcbAlerta"
        Me.PcbAlerta.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.PcbAlerta.Size = New System.Drawing.Size(49, 39)
        Me.PcbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbAlerta.TabIndex = 23
        Me.PcbAlerta.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(70, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Facturas disponibles"
        '
        'CmbFacturas
        '
        Me.CmbFacturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CmbFacturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFacturas.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CmbFacturas.FormattingEnabled = True
        Me.CmbFacturas.Location = New System.Drawing.Point(260, 68)
        Me.CmbFacturas.Name = "CmbFacturas"
        Me.CmbFacturas.Size = New System.Drawing.Size(164, 29)
        Me.CmbFacturas.TabIndex = 26
        '
        'BtnAsiento
        '
        Me.BtnAsiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnAsiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnAsiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAsiento.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAsiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnAsiento.Location = New System.Drawing.Point(285, 103)
        Me.BtnAsiento.Name = "BtnAsiento"
        Me.BtnAsiento.Size = New System.Drawing.Size(121, 42)
        Me.BtnAsiento.TabIndex = 27
        Me.BtnAsiento.Text = "Registrar"
        Me.BtnAsiento.UseVisualStyleBackColor = False
        '
        'PcbFactura
        '
        Me.PcbFactura.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PcbFactura.Location = New System.Drawing.Point(0, 181)
        Me.PcbFactura.Name = "PcbFactura"
        Me.PcbFactura.Size = New System.Drawing.Size(502, 320)
        Me.PcbFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbFactura.TabIndex = 28
        Me.PcbFactura.TabStop = False
        '
        'FormContabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(502, 501)
        Me.Controls.Add(Me.PcbFactura)
        Me.Controls.Add(Me.BtnAsiento)
        Me.Controls.Add(Me.CmbFacturas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.PcbAlerta)
        Me.Controls.Add(Me.BtnHub)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormContabilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilidad"
        CType(Me.PcbAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUser As Label
    Friend WithEvents PcbAlerta As PictureBox
    Friend WithEvents BtnHub As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbFacturas As ComboBox
    Friend WithEvents BtnAsiento As Button
    Friend WithEvents PcbFactura As PictureBox
End Class
