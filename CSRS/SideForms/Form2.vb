Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ports As String() = SerialPort.GetPortNames
            Dim port As String
            For Each port In ports
                ComboBox1.Items.Add(port)
            Next port
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            With SerialPort1
                .PortName = ComboBox1.Text
                .BaudRate = 9600
                .Parity = Parity.None
                .StopBits = StopBits.One
                .DataBits = 8
                .Handshake = Handshake.RequestToSend
                .DtrEnable = True
                .RtsEnable = True
                .NewLine = vbCrLf
                .Open()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        Try
            With SerialPort1
                .PortName = ComboBox1.Text
                .BaudRate = 9600
                .Parity = Parity.None
                .DataBits = 8
                .StopBits = StopBits.One
                .Handshake = Handshake.RequestToSend
                .DtrEnable = True
                .RtsEnable = True
                .NewLine = vbCrLf
            End With
            SerialPort1.Open()
        Catch ex As Exception
        End Try
        SerialPort1.WriteLine("AT+CMGF=1" & vbCr)
        System.Threading.Thread.Sleep(200)
        SerialPort1.WriteLine("AT+CMGS=" & Chr(34) & TextBox1.Text & Chr(34) & vbCr)
        System.Threading.Thread.Sleep(200)
        SerialPort1.WriteLine(TextBox2.Text & vbCrLf & Chr(26))
        System.Threading.Thread.Sleep(200)
    End Sub
End Class
