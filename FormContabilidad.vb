Imports System.IO
Imports System.Text
Public Class FormContabilidad
    Dim Carpeta As String = "C:\FelseFor\Facturas"              ' Establecer la carpeta
    Private Sub FormContabilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = FormInicio.Usuario
        LeerFacturas()
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
            Escribir.WriteLine($"{Ticket};{LblUser.Text};{Valor};{Fecha};Contabilidad")
        End Using
    End Sub
    Private Sub BtnHub_Click(sender As Object, e As EventArgs) Handles BtnHub.Click
        FormInicio.Show()
        Me.Close()
    End Sub
    Private Sub LeerFacturas()
        If System.IO.Directory.Exists(Carpeta) Then                 ' Si la carpeta existe:
            For Each File In Directory.GetFiles(Carpeta)                            ' Por cada archivo en la carpeta
                Dim NSep = File.Split("\")                          ' Separar el nombre del archivo entre el numero y la letra
                NSep = NSep(3).Split("_")
                If NSep(1) = "n.jpeg" Then                               ' Si el segundo elemento de la separacion es "n":
                    CmbFacturas.Items.Add(NSep(0))                  ' Agregar el numero al combobox
                End If
            Next
        End If
    End Sub
    Private Sub BtnAsiento_Click(sender As Object, e As EventArgs) Handles BtnAsiento.Click
        If Not CmbFacturas.SelectedItem = "" Then
            MsgBox($"La factura {CmbFacturas.SelectedItem} fue registrada satisfactoriamente.")

            'Tomar directorio del archivo
            Dim Archivo = $"C:\FelseFor\Facturas\{CmbFacturas.SelectedItem}_n.jpeg"
            'Renombrar archivo
            My.Computer.FileSystem.RenameFile(Archivo, $"{CmbFacturas.SelectedItem}_r.jpeg")
            'Borrar factura de la lista
            CmbFacturas.Items.Remove(CmbFacturas.SelectedItem)

        End If
    End Sub
    Private Sub CmbFacturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFacturas.SelectedIndexChanged
        If Not CmbFacturas.SelectedItem = "" Then
            For Each File In Directory.GetFiles(Carpeta)
                Dim NSep = File.Split("\")
                NSep = NSep(3).Split("_")
                If CmbFacturas.SelectedItem = NSep(0) Then
                    PcbFactura.ImageLocation = File
                    Exit For
                End If
            Next
        End If
    End Sub
End Class