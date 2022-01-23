Imports System.IO
Imports System.Text
Public Class FormProduccion
    Dim Archivo As String = "C:\FelseFor\Almacen.txt"
    Private Sub FormProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = FormInicio.Usuario
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
            Escribir.WriteLine($"{Ticket};{LblUser.Text};{Valor};{Fecha};Producción")
        End Using
    End Sub
    Private Sub BtnHub_Click(sender As Object, e As EventArgs) Handles BtnHub.Click
        FormInicio.Show()
        Me.Close()
    End Sub
    Private Sub BtnArmar_Click(sender As Object, e As EventArgs) Handles BtnArmar.Click
        Dim LActual
        Dim Correcto As Integer = 0
        For Each Line In File.ReadLines("C:\FelseFor\Almacen.txt")
            LActual = Line.Split(";")
            If CmbDisco.SelectedItem = LActual(0) And LActual(2) > 0 And LActual(4) = "Compra" Then
                Correcto += 1
            ElseIf CmbFuente.SelectedItem = LActual(0) And LActual(2) > 0 And LActual(4) = "Compra" Then
                Correcto += 1
            ElseIf CmbGabo.SelectedItem = LActual(0) And LActual(2) > 0 And LActual(4) = "Compra" Then
                Correcto += 1
            ElseIf CmbPlaca.SelectedItem = LActual(0) And LActual(2) > 0 And LActual(4) = "Compra" Then
                Correcto += 1
            ElseIf CmbCpu.SelectedItem = LActual(0) And LActual(2) > 0 And LActual(4) = "Compra" Then
                Correcto += 1
            ElseIf CmbGpu.SelectedItem = LActual(0) And LActual(2) > 0 And LActual(4) = "Compra" Then
                Correcto += 1
            ElseIf CmbRam.SelectedItem = LActual(0) And LActual(2) > 0 And LActual(4) = "Compra" Then
                Correcto += 1
            ElseIf LActual(0) = "Cable" And LActual(2) >= 5 And LActual(4) = "Compra" Then
                Correcto += 1
            End If
        Next
        If Correcto = 8 Then
            FormArmado.Show()
            Me.Hide()
        Else
            LblError.Text = $"Error, faltan insumos."
        End If
    End Sub
End Class



' Codigo desechado: sirve para ensamblar un producto especifico, asignandole insumos y precio
'Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
'    Dim Producto = InpProducto.SelectedItem
'    If Not Producto = "" Then
'        If My.Computer.FileSystem.FileExists(Archivo) = True Then
'            Dim InsumosTot As Integer = 0
'            Dim Agregar As Boolean = False
'            Dim Borrador As New List(Of String)
'            Dim PrecioTot As Integer = 0
'            Select Case [Producto]
'                Case "Disco Duro"
'                    Borrador = System.IO.File.ReadAllLines(Archivo).ToList
'
'                    For Each Line In File.ReadLines(Archivo)
'                        Dim Linea = Line.Split(";")
'
'                        If Linea(0) = "Insumo 1" Then
'                            If Linea(2) <> 0 Then
'                                Borrador.Remove(Line)
'                                Borrador.Add($"{Linea(0)};{Linea(1) - (Linea(1) / Linea(2))};{Linea(2) - 1};{Linea(3)}")
'                                PrecioTot = PrecioTot + (Linea(1) / Linea(2))
'                                InsumosTot += 1
'                            End If
'                        End If
'                        If Linea(0) = "Insumo 2" Then
'                            If Linea(2) > 0 Then
'                                Borrador.Remove(Line)
'                                Borrador.Add($"{Linea(0)};{Linea(1) - (Linea(1) / Linea(2))};{Linea(2) - 1};{Linea(3)}")
'                                PrecioTot = PrecioTot + (Linea(1) / Linea(2))
'                                InsumosTot += 1
'                            End If
'                        End If
'                        If InsumosTot = 2 Then
'                            LblInsumos.Text = $"{Producto} fabricado."
'                            For Each Line2 In File.ReadLines(Archivo)
'                                Dim Linea2 = Line2.Split(";")
'                                If Linea2.GetValue(0) = Producto Then
'                                    Borrador.Remove(Line2)
'                                    Borrador.Add($"{Producto};{Linea2(1) + PrecioTot};{Linea2(2) + 1};Mercadería")
'                                    Agregar = True
'                                    Exit Select
'                                End If
'                            Next
'                            Agregar = True
'                            Borrador.Add($"{Producto};{PrecioTot};1;Mercadería")
'                        Else
'                            LblInsumos.Text = "Insumos insuficientes"
'                        End If
'
'                    Next
'
'                Case "Fuente de Alimentación"
'
'
'                Case "Gabinete"
'
'
'                Case "Placa Madre"
'
'
'                Case "Procesador"
'
'
'                Case "Tarjeta Gráfica"
'
'
'                Case "Tarjeta RAM"
'
'
'            End Select
'            If Agregar = True Then
'                System.IO.File.WriteAllLines(Archivo, Borrador)
'                Console.Beep()
'                FormCompras.LeerAlmacen()
'            End If
'        Else
'            LblInsumos.Text = "El almacén está vacío."
'        End If
'    End If
'End Sub