Imports System.IO
Imports System.Text
Public Class FormFactura
    Dim Numero As String
    Private Sub FormFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Linea
        For Each Line In File.ReadAllLines("C:\FelseFor\Comprobantes.txt")
            Linea = Line.Split(";")
            If Linea(0) = FormVentas.CmbCompu.SelectedItem Then

                Señor.Text = FormVentas.InpCliente.Text
                Dire.Text = FormVentas.InpDireccion.Text

                LblDia.Text = Linea(2)
                LblMes.Text = Linea(3)
                LblAño.Text = Linea(4)
                LblNum.Text = $"Nº {Linea(1)}"
                Numero = Linea(1)

                LblDisco.Text = Linea(5)
                LblFuente.Text = Linea(8)
                LblGabo.Text = Linea(11)
                LblPlaca.Text = Linea(14)
                LblCpu.Text = Linea(17)
                LblGpu.Text = Linea(20)
                LblRam.Text = Linea(23)

                LUA.Text = $"${Linea(6)}"
                LUF.Text = $"${Linea(9)}"
                LUG.Text = $"${Linea(12)}"
                LUP.Text = $"${Linea(15)}"
                LUC.Text = $"${Linea(18)}"
                LUTG.Text = $"${Linea(21)}"
                LUR.Text = $"${Linea(24)}"
                LUAR.Text = "$50"
                LUCA.Text = $"${Linea(27) / 5}"
                LUPT.Text = $"${Linea(30)}"

                LTA.Text = $"${Linea(6)}"
                LTF.Text = $"${Linea(9)}"
                LTG.Text = $"${Linea(12)}"
                LTP.Text = $"${Linea(15)}"
                LTC.Text = $"${Linea(18)}"
                LTTG.Text = $"${Linea(21)}"
                LTR.Text = $"${Linea(24)}"
                LTAR.Text = "$50"
                LTCA.Text = $"${Linea(27)}"
                LTPT.Text = $"${Linea(30)}"

                SubTotal.Text = $"{Linea(32)}"
                Dim SubT As Double = SubTotal.Text
                IVA.Text = $"{(SubT / 100) * 21}"
                Dim IvaT As Double = IVA.Text
                Total.Text = $"{SubT + IvaT}"

                Exit For
            End If
        Next
    End Sub
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        BtnEnviar.Hide()
        Dim Factura = Form.ActiveForm
        Using bmp = New Bitmap(Factura.Width, Factura.Height)
            Factura.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
            If Not System.IO.Directory.Exists("C:\FelseFor\Facturas") Then                         '   Si la carpeta no existe:
                System.IO.Directory.CreateDirectory("C:\FelseFor\Facturas")                        '       Crearla
            End If
            bmp.Save($"C:\FelseFor\Facturas\{Numero}_n.jpeg")
        End Using

        MsgBox($"La factura {Numero} ha sido guardada en la carpeta interna Facturas.")

        FormVentas.Show()
        Me.Close()
    End Sub
    ' Codigo para mover la ventana sin que tenga los bordes
    Const WM_NCHITTEST As Integer = &H84        'Envia mensaje si se está moviendo el cursor o se mantiene el boton sobre el formulario
    Const HTCLIENT As Integer = &H1             'El caracter 1
    Const HTCAPTION As Integer = &H2            'El caracter 2
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
End Class