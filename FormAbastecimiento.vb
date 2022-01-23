Imports System.IO
Imports System.Text
Public Class FormAbastecimiento
    Dim Carpeta As String = "C:\FelseFor"
    Dim Archivo = $"{Carpeta}\Almacen.txt"
    Dim DGAlmacen As DataGridView = FormAlmacen.DataGridAlmacen
    Dim Usuario As String = FormInicio.Usuario
    Private Sub FormCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = FormInicio.Usuario
        CmbTipo.SelectedIndex = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnNAgregar.Click
        Dim Nombre As String = InpNNombre.Text
        Dim Precio As Double = InpNPrecio.Text
        Dim Cantidad As Double = InpNCantidad.Text
        Dim Tipo As String = CmbTipo.SelectedItem
        Dim NValor As String, VariableRandom As Integer = 0, Borrador As List(Of String)

        If String.IsNullOrEmpty(Nombre) = False Then                                ' Si "Nombre" no está vacío:
            If Not System.IO.Directory.Exists(Carpeta) Then                         '   Si la carpeta no existe:
                System.IO.Directory.CreateDirectory(Carpeta)                        '       Crearla
            End If

            If My.Computer.FileSystem.FileExists(Archivo) = True Then
                'If File.ReadAllLines(Archivo).Count = 0 Then
                '   File.Delete(Archivo)
                'End If
                For Each Line In File.ReadLines(Archivo)
                    Dim Linea = Line.Split(";")
                    If Linea.GetValue(0) = Nombre And Linea.GetValue(4) = "Compra" Then
                        NValor = $"{Nombre};{Precio + Linea.GetValue(1)};{Cantidad + Linea.GetValue(2)};{Tipo};Compra"
                        Borrador = System.IO.File.ReadAllLines(Archivo).ToList
                        Borrador.Remove(Line)
                        Borrador.Add(NValor)
                        VariableRandom = 2
                        Exit For
                    Else
                        NValor = $"{Nombre};{Precio};{Cantidad};{Tipo};Compra"
                        VariableRandom = 1
                    End If
                Next
            Else
                NValor = $"{Nombre};{Precio};{Cantidad};{Tipo};Compra"
                Using Escribir As New StreamWriter(Archivo, True)
                    Escribir.WriteLine(NValor)
                End Using
            End If
            If VariableRandom = 1 Then
                Using Escribir As New StreamWriter(Archivo, True)
                    Escribir.WriteLine(NValor)
                End Using
            ElseIf VariableRandom = 2 Then
                System.IO.File.WriteAllLines(Archivo, Borrador)
            End If
            InpNNombre.Text = ""
            Console.Beep()
        End If
    End Sub
    Private Sub BtnHub_Click(sender As Object, e As EventArgs) Handles BtnHub.Click
        FormInicio.Show()   ' Volver al inicio
        Me.Close()
    End Sub
    Public Sub LeerAlmacen()
        Dim Num As Integer = 1
        If My.Computer.FileSystem.FileExists(Archivo) = True Then
            FormAlmacen.DataGridAlmacen.Rows.Clear()
            FormTI.CmbEProducto.Items.Clear()
            Dim LActual
            Dim Componentes As Integer = 0
            Dim Borrador As List(Of String)
            Borrador = System.IO.File.ReadAllLines("C:\FelseFor\Almacen.txt").ToList

            FormProduccion.CmbDisco.Items.Clear()
            FormProduccion.CmbFuente.Items.Clear()
            FormProduccion.CmbGabo.Items.Clear()
            FormProduccion.CmbPlaca.Items.Clear()
            FormProduccion.CmbCpu.Items.Clear()
            FormProduccion.CmbGpu.Items.Clear()
            FormProduccion.CmbRam.Items.Clear()

            For Each Line In File.ReadLines(Archivo)
                LActual = Line.Split(";")

                If LActual(2) = 0 Then
                    Borrador.Remove(Line)
                Else
                    FormAlmacen.DataGridAlmacen.Rows.Add(Num, LActual(0), LActual(1), LActual(2), LActual(3), LActual(4))
                End If

                If LActual(4) = "Prueba" And LActual(2) > 0 Then
                    FormTI.CmbEProducto.Items.Add(LActual(0))
                End If
                If LActual(3) = "Almacenamiento" And LActual(2) > 0 And LActual(4) = "Compra" Then
                    FormProduccion.CmbDisco.Items.Add(LActual(0))
                End If
                If LActual(3) = "Fuente" And LActual(2) > 0 And LActual(4) = "Compra" Then
                    FormProduccion.CmbFuente.Items.Add(LActual(0))
                End If
                If LActual(3) = "Gabinete" And LActual(2) > 0 And LActual(4) = "Compra" Then
                    FormProduccion.CmbGabo.Items.Add(LActual(0))
                End If
                If LActual(3) = "Placa Madre" And LActual(2) > 0 And LActual(4) = "Compra" Then
                    FormProduccion.CmbPlaca.Items.Add(LActual(0))
                End If
                If LActual(3) = "Procesador" And LActual(2) > 0 And LActual(4) = "Compra" Then
                    FormProduccion.CmbCpu.Items.Add(LActual(0))
                End If
                If LActual(3) = "Gráfica" And LActual(2) > 0 And LActual(4) = "Compra" Then
                    FormProduccion.CmbGpu.Items.Add(LActual(0))
                End If
                If LActual(3) = "RAM" And LActual(2) > 0 And LActual(4) = "Compra" Then
                    FormProduccion.CmbRam.Items.Add(LActual(0))
                End If

                Num += 1
            Next
            System.IO.File.WriteAllLines("C:\FelseFor\Almacen.txt", Borrador)
        End If
        If My.Computer.FileSystem.FileExists("C:\FelseFor\Comprobantes.txt") = True Then
            If File.ReadAllLines("C:\FelseFor\Comprobantes.txt").Count > 0 Then
                Dim Linea
                FormVentas.CmbCompu.Items.Clear()
                For Each Comprobante In File.ReadAllLines("C:\FelseFor\Comprobantes.txt")
                    Linea = Comprobante.Split(";")
                    If Not Linea(0) = "" Then
                        FormAlmacen.DataGridAlmacen.Rows.Add(Num, Linea(0), Linea(32), "1", "Computadora", "Mercadería")
                        FormVentas.CmbCompu.Items.Add(Linea(0))
                    End If
                    Num += 1
                Next
            End If
        End If
    End Sub
    Private Sub PcbAlerta_Click(sender As Object, e As EventArgs) Handles PcbAlerta.Click
        Dim Mensaje, Titulo, Valor, Ticket
        Dim Fecha As String = String.Format("{0:dd/MM/yy HH:mm}", DateTime.Now)
        Mensaje = "Ingrese su problema y se le atenderá a la brevedad:"
        Titulo = "Enviar alerta al departamento de IT"
        Valor = InputBox(Mensaje, Titulo)

        If My.Computer.FileSystem.FileExists("C:\FelseFor\Alertas.txt") = True Then
            Ticket = File.ReadLines("C:\FelseFor\Alertas.txt").Count + 1
        Else
            Ticket = 1
        End If
        Using Escribir As New StreamWriter("C:\FelseFor\Alertas.txt", True)
            Escribir.WriteLine($"{Ticket};{LblUser.Text};{Valor};{Fecha};Abastecimiento")
        End Using
        Console.Beep()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class