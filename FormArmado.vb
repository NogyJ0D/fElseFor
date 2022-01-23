Imports System.IO
Imports System.Text
Public Class FormArmado
    Dim Coordenadas As New Point
    Dim Componentes As Integer = 0
    Public Nombre As String
    Private Sub FormArmado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelTodo.Hide()
        Gabo2.Hide()
        BtnPasta.Hide()
        BtnCpuFan.Hide()
        BtnCables.Hide()
        BtnDisco.Hide()
        BtnFuente.Hide()
        BtnPlaca.Hide()
        BtnCpu.Hide()
        BtnGpu.Hide()
        BtnRam.Hide()
        BtnFan.Hide()
        GrbPlaca.Hide()
        GrbVentilador.Hide()
        GrbRam.Hide()
        GrbCpu.Hide()
        GrbGpu.Hide()
        GrbAlmacenamiento.Hide()
        BtnCables.Hide()
        GrbFuente.Hide()
        Label10.Hide()
        InpNombre.Hide()
        Button8.Hide()
        MoverComponentes()
        Componentes = 0
    End Sub
    Private Sub MoverComponentes()
        AddHandler BtnGabo.MouseDown, AddressOf GaboMouseDown
        AddHandler BtnDisco.MouseDown, AddressOf DiscoMouseDown
        AddHandler BtnFuente.MouseDown, AddressOf FuenteMouseDown
        AddHandler BtnPlaca.MouseDown, AddressOf PlacaMouseDown
        AddHandler BtnCpu.MouseDown, AddressOf CpuMouseDown
        AddHandler BtnGpu.MouseDown, AddressOf GpuMouseDown
        AddHandler BtnRam.MouseDown, AddressOf RamMouseDown
        AddHandler BtnFan.MouseDown, AddressOf FanMouseDown
        AddHandler BtnGabo.MouseMove, AddressOf GaboMouseMove
        AddHandler BtnDisco.MouseMove, AddressOf DiscoMouseMove
        AddHandler BtnFuente.MouseMove, AddressOf FuenteMouseMove
        AddHandler BtnPlaca.MouseMove, AddressOf PlacaMouseMove
        AddHandler BtnCpu.MouseMove, AddressOf CpuMouseMove
        AddHandler BtnGpu.MouseMove, AddressOf GpuMouseMove
        AddHandler BtnRam.MouseMove, AddressOf RamMouseMove
        AddHandler BtnFan.MouseMove, AddressOf FanMouseMove
        AddHandler BtnGabo.MouseUp, AddressOf GaboMouseUp
        AddHandler BtnDisco.MouseUp, AddressOf DiscoMouseUp
        AddHandler BtnFuente.MouseUp, AddressOf FuenteMouseUp
        AddHandler BtnPlaca.MouseUp, AddressOf PlacaMouseUp
        AddHandler BtnCpu.MouseUp, AddressOf CpuMouseUp
        AddHandler BtnGpu.MouseUp, AddressOf GpuMouseUp
        AddHandler BtnRam.MouseUp, AddressOf RamMouseUp
        AddHandler BtnFan.MouseUp, AddressOf FanMouseUp
    End Sub
    ' Al darle click
    Private Sub GaboMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Coordenadas.Y = MousePosition.Y - sender.top
        Coordenadas.X = MousePosition.X - sender.left
    End Sub
    Private Sub DiscoMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Coordenadas.Y = MousePosition.Y - sender.top
        Coordenadas.X = MousePosition.X - sender.left
    End Sub
    Private Sub FuenteMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Coordenadas.Y = MousePosition.Y - sender.top
        Coordenadas.X = MousePosition.X - sender.left
    End Sub
    Private Sub PlacaMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Coordenadas.Y = MousePosition.Y - sender.top
        Coordenadas.X = MousePosition.X - sender.left
    End Sub
    Private Sub CpuMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Coordenadas.Y = MousePosition.Y - sender.top
        Coordenadas.X = MousePosition.X - sender.left
    End Sub
    Private Sub GpuMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Coordenadas.Y = MousePosition.Y - sender.top
        Coordenadas.X = MousePosition.X - sender.left
    End Sub
    Private Sub RamMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Coordenadas.Y = MousePosition.Y - sender.top
        Coordenadas.X = MousePosition.X - sender.left
    End Sub
    Private Sub FanMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Coordenadas.Y = MousePosition.Y - sender.top
        Coordenadas.X = MousePosition.X - sender.left
    End Sub
    ' Al moverlo
    Private Sub GaboMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - Coordenadas.Y
            sender.left = MousePosition.X - Coordenadas.X
            Dim B As Button = DirectCast(sender, Button)
            GrbGabo.SendToBack()
            If B.Location.Y >= GrbGabo.Location.Y And
                B.Location.Y + B.Height <= GrbGabo.Location.Y + GrbGabo.Height And
                B.Location.X > GrbGabo.Location.X And
                B.Location.X + B.Width <= GrbGabo.Location.X + GrbGabo.Width Then
                GrbGabo.BackColor = Color.OliveDrab
            Else
                GrbGabo.BackColor = Color.Brown
            End If
        End If
    End Sub
    Private Sub DiscoMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - Coordenadas.Y
            sender.left = MousePosition.X - Coordenadas.X
            Dim B As Button = DirectCast(sender, Button)
            B.BringToFront()
            If B.Location.Y >= GrbAlmacenamiento.Location.Y And
                B.Location.Y + B.Height <= GrbAlmacenamiento.Location.Y + GrbAlmacenamiento.Height And
                B.Location.X > GrbAlmacenamiento.Location.X And
                B.Location.X + B.Width <= GrbAlmacenamiento.Location.X + GrbAlmacenamiento.Width Then
                GrbAlmacenamiento.BackColor = Color.OliveDrab
            Else
                GrbAlmacenamiento.BackColor = Color.Brown
            End If
        End If
    End Sub
    Private Sub FuenteMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - Coordenadas.Y
            sender.left = MousePosition.X - Coordenadas.X
            Dim B As Button = DirectCast(sender, Button)
            B.BringToFront()
            If B.Location.Y >= GrbFuente.Location.Y And
                B.Location.Y + B.Height <= GrbFuente.Location.Y + GrbFuente.Height And
                B.Location.X > GrbFuente.Location.X And
                B.Location.X + B.Width <= GrbFuente.Location.X + GrbFuente.Width Then
                GrbFuente.BackColor = Color.OliveDrab
            Else
                GrbFuente.BackColor = Color.Brown
            End If
        End If
    End Sub
    Private Sub PlacaMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - Coordenadas.Y
            sender.left = MousePosition.X - Coordenadas.X
            Dim B As Button = DirectCast(sender, Button)
            B.BringToFront()
            If B.Location.Y >= GrbPlaca.Location.Y And
                B.Location.Y + B.Height <= GrbPlaca.Location.Y + GrbPlaca.Height And
                B.Location.X > GrbPlaca.Location.X And
                B.Location.X + B.Width <= GrbPlaca.Location.X + GrbPlaca.Width Then
                GrbPlaca.BackColor = Color.OliveDrab
            Else
                GrbPlaca.BackColor = Color.Brown
            End If
        End If
    End Sub
    Private Sub CpuMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - Coordenadas.Y
            sender.left = MousePosition.X - Coordenadas.X
            Dim B As Button = DirectCast(sender, Button)
            B.BringToFront()
            If B.Location.Y >= GrbCpu.Location.Y And
                B.Location.Y + B.Height <= GrbCpu.Location.Y + GrbCpu.Height And
                B.Location.X > GrbCpu.Location.X And
                B.Location.X + B.Width <= GrbCpu.Location.X + GrbCpu.Width Then
                GrbCpu.BackColor = Color.OliveDrab
            Else
                GrbCpu.BackColor = Color.Brown
            End If
        End If
    End Sub
    Private Sub GpuMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - Coordenadas.Y
            sender.left = MousePosition.X - Coordenadas.X
            Dim B As Button = DirectCast(sender, Button)
            B.BringToFront()
            If B.Location.Y >= GrbGpu.Location.Y And
                B.Location.Y + B.Height <= GrbGpu.Location.Y + GrbGpu.Height And
                B.Location.X > GrbGpu.Location.X And
                B.Location.X + B.Width <= GrbGpu.Location.X + GrbGpu.Width Then
                GrbGpu.BackColor = Color.OliveDrab
            Else
                GrbGpu.BackColor = Color.Brown
            End If
        End If
    End Sub
    Private Sub RamMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - Coordenadas.Y
            sender.left = MousePosition.X - Coordenadas.X
            Dim B As Button = DirectCast(sender, Button)
            B.BringToFront()
            If B.Location.Y >= GrbRam.Location.Y And
                B.Location.Y + B.Height <= GrbRam.Location.Y + GrbRam.Height And
                B.Location.X > GrbRam.Location.X And
                B.Location.X + B.Width <= GrbRam.Location.X + GrbRam.Width Then
                GrbRam.BackColor = Color.OliveDrab
            Else
                GrbRam.BackColor = Color.Brown
            End If
        End If
    End Sub
    Private Sub FanMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - Coordenadas.Y
            sender.left = MousePosition.X - Coordenadas.X
            Dim B As Button = DirectCast(sender, Button)
            B.BringToFront()
            If B.Location.Y >= GrbVentilador.Location.Y And
                B.Location.Y + B.Height <= GrbVentilador.Location.Y + GrbVentilador.Height And
                B.Location.X > GrbVentilador.Location.X And
                B.Location.X + B.Width <= GrbVentilador.Location.X + GrbVentilador.Width Then
                GrbVentilador.BackColor = Color.OliveDrab
            Else
                GrbVentilador.BackColor = Color.Brown
            End If
        End If
    End Sub
    ' Al soltarlo
    Private Sub GaboMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim B As Button = DirectCast(sender, Button)
        If B.Location.Y >= GrbGabo.Location.Y And
                B.Location.Y + B.Height <= GrbGabo.Location.Y + GrbGabo.Height And
                B.Location.X > GrbGabo.Location.X And
                B.Location.X + B.Width <= GrbGabo.Location.X + GrbGabo.Width Then
            Me.Controls.Remove(B)
            GrbGabo.Hide()
            PanelTodo.Show()
            BtnDisco.Show()
            GrbAlmacenamiento.Show()
            BtnPlaca.Show()
            GrbPlaca.Show()
            BtnFuente.Show()
            GrbFuente.Show()
            Componentes += 1
        End If
    End Sub
    Private Sub DiscoMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim B As Button = DirectCast(sender, Button)
        If B.Location.Y >= GrbAlmacenamiento.Location.Y And
                B.Location.Y + B.Height <= GrbAlmacenamiento.Location.Y + GrbAlmacenamiento.Height And
                B.Location.X > GrbAlmacenamiento.Location.X And
                B.Location.X + B.Width <= GrbAlmacenamiento.Location.X + GrbAlmacenamiento.Width Then
            Me.Controls.Remove(B)
            GrbAlmacenamiento.BackColor = Color.OliveDrab
            Componentes += 1
            If Componentes = 7 Then
                BtnFan.Show()
            End If
            If Componentes = 8 Then
                BtnCables.Show()
            End If
        End If
    End Sub
    Private Sub FuenteMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim B As Button = DirectCast(sender, Button)
        If B.Location.Y >= GrbFuente.Location.Y And
                B.Location.Y + B.Height <= GrbFuente.Location.Y + GrbFuente.Height And
                B.Location.X > GrbFuente.Location.X And
                B.Location.X + B.Width <= GrbFuente.Location.X + GrbFuente.Width Then
            Me.Controls.Remove(B)
            GrbFuente.BackColor = Color.OliveDrab
            Componentes += 1
            If Componentes = 7 Then
                BtnFan.Show()
            End If
            If Componentes = 8 Then
                BtnCables.Show()
            End If
        End If
    End Sub
    Private Sub PlacaMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim B As Button = DirectCast(sender, Button)
        If B.Location.Y >= GrbPlaca.Location.Y And
                B.Location.Y + B.Height <= GrbPlaca.Location.Y + GrbPlaca.Height And
                B.Location.X > GrbPlaca.Location.X And
                B.Location.X + B.Width <= GrbPlaca.Location.X + GrbPlaca.Width Then
            Me.Controls.Remove(B)
            GrbVentilador.Show()
            GrbRam.Show()
            BtnRam.Show()
            GrbCpu.Show()
            BtnCpu.Show()
            GrbGpu.Show()
            BtnGpu.Show()
            GrbPlaca.BackColor = Color.OliveDrab
            Componentes += 1
            If Componentes = 7 Then
                BtnFan.Show()
            End If
            If Componentes = 8 Then
                BtnCables.Show()
            End If
        End If
    End Sub
    Private Sub CpuMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim B As Button = DirectCast(sender, Button)
        If B.Location.Y >= GrbCpu.Location.Y And
                B.Location.Y + B.Height <= GrbCpu.Location.Y + GrbCpu.Height And
                B.Location.X > GrbCpu.Location.X And
                B.Location.X + B.Width <= GrbCpu.Location.X + GrbCpu.Width Then
            Me.Controls.Remove(B)
            BtnPasta.Show()
            GrbCpu.BackColor = Color.OliveDrab
        End If
    End Sub
    Private Sub GpuMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim B As Button = DirectCast(sender, Button)
        If B.Location.Y >= GrbGpu.Location.Y And
                B.Location.Y + B.Height <= GrbGpu.Location.Y + GrbGpu.Height And
                B.Location.X > GrbGpu.Location.X And
                B.Location.X + B.Width <= GrbGpu.Location.X + GrbGpu.Width Then
            Me.Controls.Remove(B)
            GrbGpu.BackColor = Color.OliveDrab
            Componentes += 1
            If Componentes = 7 Then
                BtnFan.Show()
            End If
            If Componentes = 8 Then
                BtnCables.Show()
            End If
        End If
    End Sub
    Private Sub RamMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim B As Button = DirectCast(sender, Button)
        If B.Location.Y >= GrbRam.Location.Y And
                B.Location.Y + B.Height <= GrbRam.Location.Y + GrbRam.Height And
                B.Location.X > GrbRam.Location.X And
                B.Location.X + B.Width <= GrbRam.Location.X + GrbRam.Width Then
            Me.Controls.Remove(B)
            GrbRam.BackColor = Color.OliveDrab
            Componentes += 1
            If Componentes = 7 Then
                BtnFan.Show()
            End If
            If Componentes = 8 Then
                BtnCables.Show()
            End If
        End If
    End Sub
    Private Sub FanMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim B As Button = DirectCast(sender, Button)
        If B.Location.Y >= GrbVentilador.Location.Y And
                B.Location.Y + B.Height <= GrbVentilador.Location.Y + GrbVentilador.Height And
                B.Location.X > GrbVentilador.Location.X And
                B.Location.X + B.Width <= GrbVentilador.Location.X + GrbVentilador.Width Then
            Me.Controls.Remove(B)
            GrbVentilador.BackColor = Color.OliveDrab
            Componentes += 1
            If Componentes = 8 Then
                BtnCables.Show()
            End If
        End If
    End Sub
    Private Sub BtnPasta_Click(sender As Object, e As EventArgs) Handles BtnPasta.Click
        BtnPasta.Hide()
        BtnCpuFan.Show()
    End Sub
    Private Sub BtnCpuFan_Click(sender As Object, e As EventArgs) Handles BtnCpuFan.Click
        BtnCpuFan.Hide()
        Componentes += 1
        If Componentes = 7 Then
            BtnFan.Show()
        End If
        If Componentes = 8 Then
            BtnCables.Show()
        End If
    End Sub
    Private Sub BtnCables_Click(sender As Object, e As EventArgs) Handles BtnCables.Click
        If Componentes = 8 Then
            Gabo2.Show()
            BtnCables.Hide()
            Componentes += 1
            GrbPlaca.Hide()
            GrbRam.Hide()
            GrbGpu.Hide()
            GrbCpu.Hide()
            GrbAlmacenamiento.Hide()
            GrbFuente.Hide()
            GrbVentilador.Hide()
            Label10.Show()
            InpNombre.Show()
            Button8.Show()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Nombre As String = InpNombre.Text
        Randomize()
        Dim RandomN As Integer = CInt(Int((500 * Rnd()) + 1))
        Dim Existe As Boolean = False
        Dim Dia As String = String.Format("{0:dd}", DateTime.Now)
        Dim Mes As String = String.Format("{0:MM}", DateTime.Now)
        Dim Año As String = String.Format("{0:yy}", DateTime.Now)
        If Not Nombre = "" And Componentes = 9 Then
            If File.Exists("C:\FelseFor\Comprobantes.txt") = True Then
                For Each Lone In File.ReadLines("C:\FelseFor\Comprobantes.txt")
                    Dim Linea2 = Lone.Split(";")
                    If Linea2(0) = Nombre Then
                        Existe = True
                        Exit For
                    End If
                Next
            End If
            If Existe = False Then
                Dim Borrador As List(Of String), Comprobantes As String() = New String(10) {}, Precio As Integer = 0
                Borrador = System.IO.File.ReadAllLines("C:\FelseFor\Almacen.txt").ToList

                Comprobantes(0) = $"{Nombre};{RandomN};{Dia};{Mes};{Año}"
                For Each Line In File.ReadLines("C:\FelseFor\Almacen.txt")
                    Dim Linea = Line.Split(";")
                    If Linea(0) = FormProduccion.CmbDisco.SelectedItem And Linea(3) = "Almacenamiento" And Linea(4) = "Compra" Then
                        Borrador.Remove(Line)
                        Borrador.Add($"{FormProduccion.CmbDisco.SelectedItem};{Linea(1) - (Linea(1) \ Linea(2))};{(Linea(2) - 1)};Almacenamiento;Compra")
                        Comprobantes(1) = $"{FormProduccion.CmbDisco.SelectedItem};{(Linea(1) \ Linea(2))};Almacenamiento"
                        Precio += (Linea(1) \ Linea(2))

                    ElseIf Linea(0) = FormProduccion.CmbFuente.SelectedItem And Linea(3) = "Fuente" And Linea(4) = "Compra" Then
                        Borrador.Remove(Line)
                        Borrador.Add($"{FormProduccion.CmbFuente.SelectedItem};{Linea(1) - (Linea(1) \ Linea(2))};{(Linea(2) - 1)};Fuente;Compra")
                        Comprobantes(2) = $"{FormProduccion.CmbFuente.SelectedItem};{(Linea(1) \ Linea(2))};Fuente"
                        Precio += (Linea(1) \ Linea(2))

                    ElseIf Linea(0) = FormProduccion.CmbGabo.SelectedItem And Linea(3) = "Gabinete" And Linea(4) = "Compra" Then
                        Borrador.Remove(Line)
                        Borrador.Add($"{FormProduccion.CmbGabo.SelectedItem};{Linea(1) - (Linea(1) \ Linea(2))};{(Linea(2) - 1)};Gabinete;Compra")
                        Comprobantes(3) = $"{FormProduccion.CmbGabo.SelectedItem};{(Linea(1) \ Linea(2))};Gabinete"
                        Precio += (Linea(1) \ Linea(2))

                    ElseIf Linea(0) = FormProduccion.CmbPlaca.SelectedItem And Linea(3) = "Placa Madre" And Linea(4) = "Compra" Then
                        Borrador.Remove(Line)
                        Borrador.Add($"{FormProduccion.CmbPlaca.SelectedItem};{Linea(1) - (Linea(1) \ Linea(2))};{(Linea(2) - 1)};Placa Madre;Compra")
                        Comprobantes(4) = $"{FormProduccion.CmbPlaca.SelectedItem};{(Linea(1) \ Linea(2))};Placa Madre"
                        Precio += (Linea(1) \ Linea(2))

                    ElseIf Linea(0) = FormProduccion.CmbCpu.SelectedItem And Linea(3) = "Procesador" And Linea(4) = "Compra" Then
                        Borrador.Remove(Line)
                        Borrador.Add($"{FormProduccion.CmbCpu.SelectedItem};{Linea(1) - (Linea(1) \ Linea(2))};{(Linea(2) - 1)};Procesador;Compra")
                        Comprobantes(5) = $"{FormProduccion.CmbCpu.SelectedItem};{(Linea(1) \ Linea(2))};Procesador"
                        Precio += (Linea(1) \ Linea(2))

                    ElseIf Linea(0) = FormProduccion.CmbGpu.SelectedItem And Linea(3) = "Gráfica" And Linea(4) = "Compra" Then
                        Borrador.Remove(Line)
                        Borrador.Add($"{FormProduccion.CmbGpu.SelectedItem};{Linea(1) - (Linea(1) \ Linea(2))};{(Linea(2) - 1)};Gráfica;Compra")
                        Comprobantes(6) = $"{FormProduccion.CmbGpu.SelectedItem};{(Linea(1) \ Linea(2))};Gráfica"
                        Precio += (Linea(1) \ Linea(2))

                    ElseIf Linea(0) = FormProduccion.CmbRam.SelectedItem And Linea(3) = "RAM" And Linea(4) = "Compra" Then
                        Borrador.Remove(Line)
                        Borrador.Add($"{FormProduccion.CmbRam.SelectedItem};{Linea(1) - (Linea(1) \ Linea(2))};{(Linea(2) - 1)};RAM;Compra")
                        Comprobantes(7) = $"{FormProduccion.CmbRam.SelectedItem};{(Linea(1) \ Linea(2))};RAM"
                        Precio += (Linea(1) \ Linea(2))

                    ElseIf Linea(0) = "Cable" And Linea(3) = "Extra" And Linea(4) = "Compra" Then
                        Borrador.Remove(Line)
                        Borrador.Add($"Cable;{Linea(1) - ((Linea(1) \ Linea(2)) * 5)};{(Linea(2) - 5)};Extra;Compra")
                        Comprobantes(8) = $"Cable;{((Linea(1) \ Linea(2)) * 5)};Extra"
                        Precio += ((Linea(1) \ Linea(2)) * 5)

                    ElseIf Linea(0) = "Pasta Termica" And Linea(3) = "Extra" And Linea(4) = "Compra" Then
                        Borrador.Remove(Line)
                        Borrador.Add($"Pasta Termica;{Linea(1) - (Linea(1) \ Linea(2))};{Linea(2) - 1};Extra;Compra")
                        Comprobantes(9) = $"Pasta Termica;{Linea(1) \ Linea(2)};Extra"
                        Precio += (Linea(1) \ Linea(2))
                    End If
                Next
                Precio += 50
                Comprobantes(10) = Precio
                Using Escribir As New StreamWriter("C:\FelseFor\Comprobantes.txt", True)
                    Escribir.WriteLine($"{Comprobantes(0)};{Comprobantes(1)};{Comprobantes(2)};{Comprobantes(3)};{Comprobantes(4)};{Comprobantes(5)};{Comprobantes(6)};{Comprobantes(7)};{Comprobantes(8)};{Comprobantes(9)};{Comprobantes(10)}")
                End Using

                System.IO.File.WriteAllLines("C:\FelseFor\Almacen.txt", Borrador)
                FormAbastecimiento.LeerAlmacen()
                FormProduccion.LblError.Text = $"La computadora {Nombre}{Environment.NewLine}está lista para vender."
                FormProduccion.Show()
                Console.Beep()
                Me.Close()
            Else
                InpNombre.Text = "No válido"
                Console.Beep()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormProduccion.Show()
        Me.Close()
    End Sub
End Class