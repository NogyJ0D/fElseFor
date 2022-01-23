Imports System.IO
Imports System.Text
Public Class FormAlmacen
    Private Sub BtnHub_Click(sender As Object, e As EventArgs) Handles BtnHub.Click
        FormInicio.Show()
        Me.Close()
    End Sub
    Private Sub FormAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = FormInicio.Usuario
    End Sub
    Private Sub BtnEActualizar_Click(sender As Object, e As EventArgs) Handles BtnEActualizar.Click
        FormAbastecimiento.LeerAlmacen()
        Console.Beep()
    End Sub
    Private Sub PcbAlerta_Click(sender As Object, e As EventArgs) Handles PcbAlerta.Click
        If LblUser.Text = "Jean" Or LblUser.Text = "Periné" Then
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
                Escribir.WriteLine($"{Ticket};{LblUser.Text};{Valor};{Fecha};Almacén")
            End Using
            Console.Beep()
        End If
    End Sub
End Class