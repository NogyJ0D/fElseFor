Imports System.IO
Imports System.Text
Public Class FormVentas
    Dim Computadora As String
    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = FormInicio.Usuario
        FormAbastecimiento.LeerAlmacen()
        InpCliente.Text = ""
        InpDireccion.Text = ""
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
            Escribir.WriteLine($"{Ticket};{LblUser.Text};{Valor};{Fecha};Ventas")
        End Using
    End Sub
    Private Sub BtnHub_Click(sender As Object, e As EventArgs) Handles BtnHub.Click
        FormInicio.Show()
        Me.Close()
    End Sub
    Private Sub CmbCompu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCompu.SelectedIndexChanged
        DGHardware.Rows.Clear()
        If Not CmbCompu.SelectedItem = "" Then
            Dim Linea
            For Each Line In File.ReadAllLines("C:\FelseFor\Comprobantes.txt")
                Linea = Line.Split(";")
                If Linea(0) = CmbCompu.SelectedItem Then
                    'LblTiene.Text = $"{Linea(0)} contiene:{Environment.NewLine}{Linea(5)}{Environment.NewLine}{Linea(8)}{Environment.NewLine}{Linea(11)}{Environment.NewLine}{Linea(14)}{Environment.NewLine}{Linea(17)}{Environment.NewLine}{Linea(20)}{Environment.NewLine}{Linea(23)}{Environment.NewLine}{Linea(26)}{Environment.NewLine}{Linea(29)}"
                    LblTiene.Text = $"{Linea(0)} contiene:"
                    DGHardware.Rows.Add("Almacenamiento", Linea(5))
                    DGHardware.Rows.Add("Fuente", Linea(8))
                    DGHardware.Rows.Add("Gabinete", Linea(11))
                    DGHardware.Rows.Add("Gráfica", Linea(20))
                    DGHardware.Rows.Add("Placa Madre", Linea(14))
                    DGHardware.Rows.Add("Procesador", Linea(17))
                    DGHardware.Rows.Add("RAM", Linea(23))
                    DGHardware.Rows.Add("Extra", Linea(26))
                    DGHardware.Rows.Add("Extra", Linea(29))
                End If
            Next
        End If
    End Sub
    Private Sub BtnFactura_Click(sender As Object, e As EventArgs) Handles BtnFactura.Click
        If Not CmbCompu.SelectedItem = "" And Not InpCliente.Text = "" And Not InpDireccion.Text = "" Then
            FormFactura.Show()
            BorrarCompu(CmbCompu.SelectedItem)
            Me.Close()
        End If
    End Sub
    Public Sub BorrarCompu(Compu)
        Dim Borrador As List(Of String) = System.IO.File.ReadLines("C:\FelseFor\Comprobantes.txt").ToList
        For Each Line In File.ReadLines("C:\FelseFor\Comprobantes.txt")
            Dim Linea = Line.Split(";")
            If Linea(0) = Compu Then
                Borrador.Remove(Line)
                Exit For
            End If
        Next
        System.IO.File.WriteAllLines("C:\FelseFor\Comprobantes.txt", Borrador)
    End Sub
End Class