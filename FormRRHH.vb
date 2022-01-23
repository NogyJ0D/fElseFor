Imports System.IO
Imports System.Text
Public Class FormRRHH
    Dim Carpeta As String = "C:\FelseFor\"
    Dim Archivo As String = $"{Carpeta}\RRHH.txt"
    Private Sub FormRRHH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = FormInicio.Usuario
        Actualizar()
        GroupBox2.ForeColor = Color.FromArgb(237, 243, 243)
        GroupBox3.ForeColor = Color.FromArgb(237, 243, 243)
        GroupBox4.ForeColor = Color.FromArgb(237, 243, 243)
        GroupBox5.ForeColor = Color.FromArgb(237, 243, 243)
        GroupBox6.ForeColor = Color.FromArgb(237, 243, 243)
        GroupBox7.ForeColor = Color.FromArgb(237, 243, 243)
        GroupBox8.ForeColor = Color.FromArgb(237, 243, 243)
    End Sub
    Public Sub Actualizar()
        FormInicio.ActArchivo()
        For Each Line In File.ReadLines(Archivo)
            Dim Linea = Line.Split(";")
            If Linea(0) = "Aday" Then
                LblAday.Text = $"Aday: {Linea(1)}"
            ElseIf Linea(0) = "Josefina" Then
                LblJosefina.Text = $"Josefina: {Linea(1)}"
            ElseIf Linea(0) = "Zaida" Then
                LblZaida.Text = $"Zaida: {Linea(1)}"
            ElseIf Linea(0) = "Xaida" Then
                LblXaida.Text = $"Xaida: {Linea(1)}"
            ElseIf Linea(0) = "Samara" Then
                LblSamara.Text = $"Samara: {Linea(1)}"
            ElseIf Linea(0) = "Hamid" Then
                LblHamid.Text = $"Hamid: {Linea(1)}"
            ElseIf Linea(0) = "Cristina" Then
                LblCristina.Text = $"Cristina: {Linea(1)}"
            ElseIf Linea(0) = "Rodrigo" Then
                LblRodrigo.Text = $"Rodrigo: {Linea(1)}"
                'ElseIf Linea(0) = "Borja" Then
                '    LblBorja.Text = $"Borja: {Linea(1)}"
            ElseIf Linea(0) = "Simona" Then
                LblSimona.Text = $"Simona: {Linea(1)}"
            ElseIf Linea(0) = "Juan" Then
                LblJuan.Text = $"Juan: {Linea(1)}"
            ElseIf Linea(0) = "Matias" Then
                LblMatias.Text = $"Matias: {Linea(1)}"
            ElseIf Linea(0) = "Valentin" Then
                LblValentin.Text = $"Valentin: {Linea(1)}"
            ElseIf Linea(0) = "Marcos" Then
                LblMarcos.Text = $"Marcos: {Linea(1)}"
            ElseIf Linea(0) = "Dina" Then
                LblDina.Text = $"Dina: {Linea(1)}"
            End If
        Next
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Actualizar()
        Console.Beep()
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
            Escribir.WriteLine($"{Ticket};{LblUser.Text};{Valor};{Fecha};RRHH")
        End Using
    End Sub
    Private Sub BtnHub_Click(sender As Object, e As EventArgs) Handles BtnHub.Click
        FormInicio.Show()
        Me.Close()
    End Sub
End Class