Imports System.IO
Imports System.Text
Public Class FormTI
    Dim Archivo As String = "C:\FelseFor\Alertas.txt"
    Private Sub FormTI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrbAlerta.Hide()
        BtnCarpeta.Hide()
        GrbArt.Hide()
        GrbEliminar.Hide()
        LblUser.Text = FormInicio.Usuario
        GroupBox1.ForeColor = Color.FromArgb(237, 243, 243)
    End Sub
    Private Sub BtnAlertas_Click(sender As Object, e As EventArgs) Handles BtnAlertas.Click
        LeerAlerta()
    End Sub
    Private Sub BtnArt_Click(sender As Object, e As EventArgs) Handles BtnArt.Click
        GrbAlerta.Hide()
        GrbEliminar.Hide()
        GrbArt.Show()
    End Sub
    Private Sub BtnHub_Click(sender As Object, e As EventArgs) Handles BtnHub.Click
        FormInicio.Show()
        Me.Close()
    End Sub
    Private Sub BtnSolucionado_Click(sender As Object, e As EventArgs) Handles BtnSolucionado.Click
        If Not CmbTicket.SelectedItem = "" Then
            Dim Ticket As String = CmbTicket.SelectedItem
            Dim Borrador As New List(Of String)
            For Each Line In File.ReadLines(Archivo)
                Dim LActual = Line.Split(";")
                If LActual.GetValue(0) = Ticket Then
                    Borrador = System.IO.File.ReadAllLines(Archivo).ToList
                    Borrador.Remove(Line)
                    Exit For
                End If
            Next
            System.IO.File.WriteAllLines(Archivo, Borrador)
            LeerAlerta()
        End If
    End Sub
    Public Sub LeerAlerta()
        If My.Computer.FileSystem.FileExists(Archivo) = True Then
            GrbArt.Hide()
            GrbEliminar.Hide()
            GrbAlerta.Show()
            DGAlertas.Rows.Clear()
            CmbTicket.Items.Clear()
            For Each Line In File.ReadLines(Archivo)
                Dim Linea = Line.Split(";")
                DGAlertas.Rows.Add(Linea.GetValue(0), Linea.GetValue(1), Linea.GetValue(2), Linea.GetValue(3), Linea.GetValue(4))
                CmbTicket.Items.Add(Linea.GetValue(0))
            Next
            If CmbTicket.Items.Count <> 0 Then
                CmbTicket.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub BtnNAgregar_Click(sender As Object, e As EventArgs) Handles BtnNAgregar.Click
        Dim Nombre As String = InpNNombre.Text
        Dim Precio As Double = InpNPrecio.Text
        Dim Cantidad As Double = InpNCantidad.Text
        Dim NValor As String
        Dim Carpeta As String = "C:\FelseFor"

        If String.IsNullOrEmpty(Nombre) = False Then
            If Not System.IO.Directory.Exists(Carpeta) Then
                System.IO.Directory.CreateDirectory(Carpeta)
            End If

            Dim Archivo = $"{Carpeta}\Almacen.txt"

            NValor = $"{Nombre};{Precio};{Cantidad};Extra;Prueba"

            Using Escribir As New StreamWriter(Archivo, True)
                Escribir.WriteLine(NValor)
            End Using

            FormAbastecimiento.LeerAlmacen()
        End If
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        GrbAlerta.Hide()
        GrbArt.Hide()
        GrbEliminar.Show()
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Console.Beep()
        If System.IO.Directory.Exists("C:\FelseFor") = True Then    'Si archivo existe:
            LblCarpeta.Text = "Carpeta: EXISTE"                     '   Cambiar texto 
            LblCarpeta.BackColor = Color.OliveDrab                  '   Cambiar fondo del texto
            BtnCarpeta.Show()                                       '   Mostrar botón para abrir
        Else                                                        'Si archivo no existe
            LblCarpeta.Text = "Carpeta: NO EXISTE"                  '   Cambiar texto
            LblCarpeta.BackColor = Color.Brown                      '   Cambiar fondo
            BtnCarpeta.Hide()                                       '   Ocultar botón
        End If
        If System.IO.Directory.Exists("C:\FelseFor\Facturas") = True Then
            LblFacturas.Text = "Facturas: EXISTE"
            LblFacturas.BackColor = Color.OliveDrab
        Else
            LblFacturas.Text = "Facturas: No EXISTE"
            LblFacturas.BackColor = Color.Brown
        End If
        If My.Computer.FileSystem.FileExists("C:\FelseFor\Almacen.txt") = True Then
            LblAlmacen.Text = "Almacen: EXISTE"
            LblAlmacen.BackColor = Color.OliveDrab
        Else
            LblAlmacen.Text = "Almacen: NO EXISTE"
            LblAlmacen.BackColor = Color.Brown
        End If
        If My.Computer.FileSystem.FileExists("C:\FelseFor\Alertas.txt") = True Then
            LblAlertas.Text = "Alertas: EXISTE"
            LblAlertas.BackColor = Color.OliveDrab
        Else
            LblAlertas.Text = "Alertas: NO EXISTE"
            LblAlertas.BackColor = Color.Brown
        End If
        If My.Computer.FileSystem.FileExists("C:\FelseFor\RRHH.txt") = True Then
            LblRRHH.Text = "RRHH: EXISTE"
            LblRRHH.BackColor = Color.OliveDrab
        Else
            LblRRHH.Text = "RRHH: NO EXISTE"
            LblRRHH.BackColor = Color.Brown
        End If
        If My.Computer.FileSystem.FileExists("C:\FelseFor\Comprobantes.txt") = True Then
            LblComprobantes.Text = "Comprobantes: EXISTE"
            LblComprobantes.BackColor = Color.OliveDrab
        Else
            LblComprobantes.Text = "Comprobantes: NO EXISTE"
            LblComprobantes.BackColor = Color.Brown
        End If
    End Sub
    Private Sub BtnEEliminar_Click(sender As Object, e As EventArgs) Handles BtnEEliminar.Click
        If Not CmbEProducto.Text = "" And CmbEProducto.Items.Count <> 0 Then
            Dim Prod = CmbEProducto.SelectedItem
            Dim Borrador As List(Of String)

            For Each Line In File.ReadLines("C:\FelseFor\Almacen.txt")
                Dim Linea = Line.Split(";")
                If Linea.GetValue(0) = Prod And Linea.GetValue(4) = "Prueba" Then
                    Borrador = System.IO.File.ReadAllLines("C:\FelseFor\Almacen.txt").ToList
                    Borrador.Remove(Line)
                    Exit For
                End If
            Next
            System.IO.File.WriteAllLines("C:\FelseFor\Almacen.txt", Borrador)
            CmbEProducto.Items.Remove(CmbEProducto.SelectedItem)
            FormAbastecimiento.LeerAlmacen()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAlmacen.Show()
    End Sub
    Private Sub BtnCarpeta_Click(sender As Object, e As EventArgs) Handles BtnCarpeta.Click
        Process.Start("C:\FelseFor")                    ' Abrir la carpeta
    End Sub
End Class