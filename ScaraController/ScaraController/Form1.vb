'Copyright (C) 2016 Wei Gao, Dival Banerjee
'
'This program is free software; you can redistribute it and/or
'modify it under the terms of the GNU General Public License
'as published by the Free Software Foundation; either version 2
'of the License, or (at your option) any later version.
'
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with this program; if not, write to the Free Software
'Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

Public Class Form1
    Dim robot As Arm
    Dim formGraphics As System.Drawing.Graphics
    Dim pen As System.Drawing.Pen

    Structure Arm
        Dim segments As List(Of Segment)
    End Structure

    Structure Segment
        Dim length As Single
        Dim originPos As Point
        Dim angle As Double
        Dim endPos As Point
        Dim priority As UInt16 ' the first segment has a priority of 0, the next is 1, etc.

        Sub setOriginPos(x As Single, y As Single)
            Me.originPos.X = x
            Me.originPos.Y = y
        End Sub

        Sub move(angle As Double)
            ' math needed

        End Sub

        Sub draw()
            Dim baseRect As Rectangle
            Dim baseRectPos As Point
            baseRectPos.X = Me.originPos.X - 2.5
            baseRectPos.Y = Me.originPos.Y - 2.5
            baseRect.Location = baseRectPos
            Dim baseRectSize As System.Drawing.Size
            baseRectSize.Height = 5
            baseRectSize.Width = 5
            baseRect.Size = baseRectSize

            Dim g As Graphics = Form1.PictureBox1.CreateGraphics()
            g.DrawEllipse(Form1.pen, baseRect)
        End Sub
    End Structure

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

                    StatusTextBox.Text = "Connected"
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
                MsgBox("Something went wrong while opening the port. Check your connection to the device.", MsgBoxStyle.Exclamation, "Disconnected")
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

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        ActiveSerialPort.Close()
        If Not ActiveSerialPort.IsOpen Then
            StatusTextBox.Text = "Not Connected"
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown

    End Sub

    Private Sub SendTestButton_Click(sender As Object, e As EventArgs) Handles SendTestButton.Click
        If ActiveSerialPort.IsOpen() Then
            ActiveSerialPort.Write("Hello from VB!")  ' should match test string on arduino side
        Else
            MsgBox("The device port is closed. Check your connection and reconnect if necessary.", MsgBoxStyle.Exclamation, "Port closed")
        End If
    End Sub
End Class
