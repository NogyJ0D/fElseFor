Imports System.IO
Imports System.Text
Public Class FormInicio
    Public Usuario As String = ""
    Dim Fecha As String = String.Format("{0:dd/MM/yy HH:mm}", DateTime.Now)
    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbDepto.SelectedIndex = 0
        FormAbastecimiento.LeerAlmacen()
    End Sub
    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Dim Contra As String = InpContraseña.Text
        Dim Depto As String = CmbDepto.SelectedIndex

        Select Case [Depto]
            Case 0
                If Contra = "1234" Then
                    Usuario = "Zaida"
                    ActArchivo()
                    FormAbastecimiento.Show()
                    Me.Close()
                ElseIf Contra = "7895" Then
                    Usuario = "Xaida"
                    ActArchivo()
                    FormAbastecimiento.Show()
                    Me.Close()
                Else
                    InpContraseña.Text = ""
                End If

            Case 1
                If Contra = "1234" Then
                    Usuario = "Aday"
                    ActArchivo()
                    FormAlmacen.Show()
                    Me.Close()
                ElseIf Contra = "7895" Then
                    Usuario = "Josefina"
                    ActArchivo()
                    FormAlmacen.Show()
                    Me.Close()
                Else
                    InpContraseña.Text = ""
                End If

            Case 2
                If Contra = "1234" Then
                    Usuario = "Samara"
                    ActArchivo()
                    FormContabilidad.Show()
                    Me.Close()
                ElseIf Contra = "7895" Then
                    Usuario = "Hamid"
                    ActArchivo()
                    FormContabilidad.Show()
                    Me.Close()
                Else
                    InpContraseña.Text = ""
                End If

            Case 3
                If Contra = "1234" Then
                    Usuario = "Juan"
                    ActArchivo()
                    FormTI.Show()
                    Me.Close()
                ElseIf Contra = "7895" Then
                    Usuario = "Matias"
                    ActArchivo()
                    FormTI.Show()
                    Me.Close()
                ElseIf Contra = "9045" Then
                    Usuario = "Valentin"
                    ActArchivo()
                    FormTI.Show()
                    Me.Close()
                End If

            Case 4
                If Contra = "1234" Then
                    Usuario = "Cristina"
                    ActArchivo()
                    FormProduccion.Show()
                    Me.Close()
                ElseIf Contra = "7895" Then
                    Usuario = "Rodrigo"
                    ActArchivo()
                    FormProduccion.Show()
                    Me.Close()
                Else
                    InpContraseña.Text = ""
                End If

            Case 5
                If Contra = "1234" Then
                    Usuario = "Borja"
                    ActArchivo()
                    FormRRHH.Show()
                    Me.Close()
                ElseIf Contra = "7895" Then
                    Usuario = "Simona"
                    ActArchivo()
                    FormRRHH.Show()
                    Me.Close()
                Else
                    InpContraseña.Text = ""
                End If

            Case 6
                If Contra = "1234" Then
                    Usuario = "Marcos"
                    ActArchivo()
                    FormVentas.Show()
                    Me.Close()
                ElseIf Contra = "7895" Then
                    Usuario = "Dina"
                    ActArchivo()
                    FormVentas.Show()
                    Me.Close()
                Else
                    InpContraseña.Text = ""
                End If
        End Select

    End Sub
    Public Sub ActArchivo()
        Dim Carpeta As String = "C:\FelseFor"
        Dim Archivo As String = $"{Carpeta}\RRHH.txt"
        Dim NValor As String, VariableRandom As Integer = 0
        If Not System.IO.Directory.Exists(Carpeta) Then
            System.IO.Directory.CreateDirectory(Carpeta)
        End If

        Dim Borrador As New List(Of String)

        If Not System.IO.Directory.Exists(Carpeta) Then                         '   Si la carpeta no existe:
            System.IO.Directory.CreateDirectory(Carpeta)                        '       Crearla
        End If

        If My.Computer.FileSystem.FileExists(Archivo) = True Then
            If File.ReadAllLines(Archivo).Count = 0 Then
                File.Delete(Archivo)
            End If
            For Each Line In File.ReadLines(Archivo)
                Dim Linea = Line.Split(";")
                If Linea.GetValue(0) = Usuario Then
                    NValor = $"{Usuario};{Fecha}"
                    Borrador = System.IO.File.ReadAllLines(Archivo).ToList
                    Borrador.Remove(Line)
                    Borrador.Add(NValor)
                    VariableRandom = 2
                    Exit For
                Else
                    NValor = $"{Usuario};{Fecha}"
                    VariableRandom = 1
                End If
            Next
        Else
            NValor = $"{Usuario};{Fecha}"
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
    End Sub
End Class