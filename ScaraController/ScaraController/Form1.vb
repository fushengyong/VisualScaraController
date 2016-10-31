Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            PortsListBox.Items.Add(sp)
        Next
    End Sub

    Private Sub TransmitString(str As String)
        ' treat str as a "register" of bytes
        ' 
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PortsListBox.SelectedIndexChanged
        If PortsListBox.SelectedIndex >= 0 Then
            ActiveSerialPort.PortName = PortsListBox.Items(PortsListBox.SelectedIndex)
        End If
        'MsgBox(ActiveSerialPort.PortName)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        If PortsListBox.SelectedIndex = -1 Then
            MsgBox("Please select a COM port.", MsgBoxStyle.Exclamation, "No port selected")
        Else
            Dim portName As String = PortsListBox.Items(PortsListBox.SelectedIndex)
            Try
                ActiveSerialPort.PortName = portName
                ActiveSerialPort.Open()
                If ActiveSerialPort.IsOpen Then
                    MsgBox("Success!")
                End If
            Catch uAccEx As UnauthorizedAccessException
                ' Serial Port is already open by a different process.
                MsgBox("That port is in use by another application.", MsgBoxStyle.Exclamation, "Port busy/access denied")
            Catch argOutOfRangeEx As ArgumentOutOfRangeException
                ' Something is not configured correctly. (Parity, Data/Stop Bits, BaudRate, or timeout invalid)
                MsgBox("The port is not configured correctly. Check the parity, data bits, stop bits, baud rate, or timeout.", MsgBoxStyle.Exclamation, "Misconfigured")
            Catch argEx As ArgumentException ' more general than the one above, I guess
                ' more general; port doesn't begin with COM or "file type of port not supported"
                MsgBox("The port is not supported or does not begin with 'COM'.", MsgBoxStyle.Exclamation, "Port not supported")
            Catch ioEx As System.IO.IOException
                ' something goofed while working with the port
                MsgBox("Something went wrong while opening the port.", MsgBoxStyle.Exclamation, "Error - dun goofed")
            Catch InvOpEx As InvalidOperationException
                ' The port was already opened by this process.
                MsgBox("That port is already open here.", MsgBoxStyle.Exclamation, "Already open")
            End Try
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        PortsListBox.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            PortsListBox.Items.Add(sp)
        Next
    End Sub
End Class
