<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProduccion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProduccion))
        Me.LblUser = New System.Windows.Forms.Label()
        Me.BtnHub = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.BtnArmar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbDisco = New System.Windows.Forms.ComboBox()
        Me.CmbFuente = New System.Windows.Forms.ComboBox()
        Me.CmbGabo = New System.Windows.Forms.ComboBox()
        Me.CmbPlaca = New System.Windows.Forms.ComboBox()
        Me.CmbCpu = New System.Windows.Forms.ComboBox()
        Me.CmbGpu = New System.Windows.Forms.ComboBox()
        Me.CmbRam = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblError = New System.Windows.Forms.Label()
        Me.PcbAlerta = New System.Windows.Forms.PictureBox()
        CType(Me.PcbAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblUser.Location = New System.Drawing.Point(339, 13)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(33, 32)
        Me.LblUser.TabIndex = 20
        Me.LblUser.Text = "..."
        '
        'BtnHub
        '
        Me.BtnHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.BtnHub.ForeColor = System.Drawing.Color.White
        Me.BtnHub.Location = New System.Drawing.Point(600, 0)
        Me.BtnHub.Name = "BtnHub"
        Me.BtnHub.Size = New System.Drawing.Size(37, 40)
        Me.BtnHub.TabIndex = 18
        Me.BtnHub.Text = "I"
        Me.BtnHub.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 32)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Armado de computadoras"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Lbl1.Location = New System.Drawing.Point(37, 64)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl1.Size = New System.Drawing.Size(90, 21)
        Me.Lbl1.TabIndex = 21
        Me.Lbl1.Text = "Disco Duro"
        '
        'BtnArmar
        '
        Me.BtnArmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnArmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnArmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArmar.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnArmar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnArmar.Location = New System.Drawing.Point(133, 351)
        Me.BtnArmar.Name = "BtnArmar"
        Me.BtnArmar.Size = New System.Drawing.Size(129, 46)
        Me.BtnArmar.TabIndex = 28
        Me.BtnArmar.Text = "Ensamblar"
        Me.BtnArmar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(65, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Fuente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(76, 21)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Gabinete"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(28, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(99, 21)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Placa Madre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(35, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Procesador"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(64, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(62, 21)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Gráfica"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(80, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(46, 21)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "RAM"
        '
        'CmbDisco
        '
        Me.CmbDisco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDisco.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CmbDisco.FormattingEnabled = True
        Me.CmbDisco.Location = New System.Drawing.Point(133, 65)
        Me.CmbDisco.Name = "CmbDisco"
        Me.CmbDisco.Size = New System.Drawing.Size(320, 25)
        Me.CmbDisco.TabIndex = 39
        '
        'CmbFuente
        '
        Me.CmbFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFuente.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CmbFuente.FormattingEnabled = True
        Me.CmbFuente.Location = New System.Drawing.Point(133, 103)
        Me.CmbFuente.Name = "CmbFuente"
        Me.CmbFuente.Size = New System.Drawing.Size(320, 25)
        Me.CmbFuente.TabIndex = 40
        '
        'CmbGabo
        '
        Me.CmbGabo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGabo.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CmbGabo.FormattingEnabled = True
        Me.CmbGabo.Location = New System.Drawing.Point(133, 143)
        Me.CmbGabo.Name = "CmbGabo"
        Me.CmbGabo.Size = New System.Drawing.Size(320, 25)
        Me.CmbGabo.TabIndex = 41
        '
        'CmbPlaca
        '
        Me.CmbPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPlaca.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CmbPlaca.FormattingEnabled = True
        Me.CmbPlaca.Location = New System.Drawing.Point(133, 183)
        Me.CmbPlaca.Name = "CmbPlaca"
        Me.CmbPlaca.Size = New System.Drawing.Size(320, 25)
        Me.CmbPlaca.TabIndex = 42
        '
        'CmbCpu
        '
        Me.CmbCpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCpu.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CmbCpu.FormattingEnabled = True
        Me.CmbCpu.Location = New System.Drawing.Point(133, 223)
        Me.CmbCpu.Name = "CmbCpu"
        Me.CmbCpu.Size = New System.Drawing.Size(320, 25)
        Me.CmbCpu.TabIndex = 43
        '
        'CmbGpu
        '
        Me.CmbGpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGpu.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CmbGpu.FormattingEnabled = True
        Me.CmbGpu.Location = New System.Drawing.Point(133, 263)
        Me.CmbGpu.Name = "CmbGpu"
        Me.CmbGpu.Size = New System.Drawing.Size(320, 25)
        Me.CmbGpu.TabIndex = 44
        '
        'CmbRam
        '
        Me.CmbRam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRam.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CmbRam.FormattingEnabled = True
        Me.CmbRam.Location = New System.Drawing.Point(133, 303)
        Me.CmbRam.Name = "CmbRam"
        Me.CmbRam.Size = New System.Drawing.Size(320, 25)
        Me.CmbRam.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(467, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 100)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "    Insumos extra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "◦ Pasta Termica" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "◦ 5 Cable"
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblError.Location = New System.Drawing.Point(272, 344)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(27, 25)
        Me.LblError.TabIndex = 49
        Me.LblError.Text = "..."
        '
        'PcbAlerta
        '
        Me.PcbAlerta.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PcbAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PcbAlerta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PcbAlerta.Image = Global.FelseFor.My.Resources.Recursos.alerta
        Me.PcbAlerta.Location = New System.Drawing.Point(544, 0)
        Me.PcbAlerta.Name = "PcbAlerta"
        Me.PcbAlerta.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.PcbAlerta.Size = New System.Drawing.Size(49, 39)
        Me.PcbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbAlerta.TabIndex = 19
        Me.PcbAlerta.TabStop = False
        '
        'FormProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 416)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CmbRam)
        Me.Controls.Add(Me.CmbGpu)
        Me.Controls.Add(Me.CmbCpu)
        Me.Controls.Add(Me.CmbPlaca)
        Me.Controls.Add(Me.CmbGabo)
        Me.Controls.Add(Me.CmbFuente)
        Me.Controls.Add(Me.CmbDisco)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnArmar)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.PcbAlerta)
        Me.Controls.Add(Me.BtnHub)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producción"
        CType(Me.PcbAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUser As Label
    Friend WithEvents PcbAlerta As PictureBox
    Friend WithEvents BtnHub As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl1 As Label
    Friend WithEvents BtnArmar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbDisco As ComboBox
    Friend WithEvents CmbFuente As ComboBox
    Friend WithEvents CmbGabo As ComboBox
    Friend WithEvents CmbPlaca As ComboBox
    Friend WithEvents CmbCpu As ComboBox
    Friend WithEvents CmbGpu As ComboBox
    Friend WithEvents CmbRam As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LblError As Label
End Class
