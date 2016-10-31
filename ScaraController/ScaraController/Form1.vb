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
        ActiveSerialPort.PortName = PortsListBox.Items(PortsListBox.SelectedIndex)
        'MsgBox(ActiveSerialPort.PortName)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        If PortsListBox.SelectedIndex = -1 Then
            MsgBox("Please select a COM port.", MsgBoxStyle.Exclamation, "No port selected")
        Else

        End If
    End Sub
End Class
