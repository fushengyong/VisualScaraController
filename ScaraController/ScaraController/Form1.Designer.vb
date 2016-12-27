<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ActiveSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.PortsListBox = New System.Windows.Forms.ListBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SendTestButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActiveSerialPort
        '
        Me.ActiveSerialPort.PortName = "COM4"
        '
        'PortsListBox
        '
        Me.PortsListBox.FormattingEnabled = True
        Me.PortsListBox.ItemHeight = 20
        Me.PortsListBox.Location = New System.Drawing.Point(57, 29)
        Me.PortsListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PortsListBox.Name = "PortsListBox"
        Me.PortsListBox.Size = New System.Drawing.Size(211, 284)
        Me.PortsListBox.TabIndex = 0
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(57, 402)
        Me.ConnectButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(90, 37)
        Me.ConnectButton.TabIndex = 1
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Location = New System.Drawing.Point(141, 362)
        Me.StatusTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(127, 26)
        Me.StatusTextBox.TabIndex = 2
        Me.StatusTextBox.Text = "Not Connected"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 366)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Status:"
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(57, 318)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(213, 34)
        Me.RefreshButton.TabIndex = 4
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(156, 405)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(114, 34)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "Disconnect"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SendTestButton
        '
        Me.SendTestButton.Location = New System.Drawing.Point(57, 448)
        Me.SendTestButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendTestButton.Name = "SendTestButton"
        Me.SendTestButton.Size = New System.Drawing.Size(213, 31)
        Me.SendTestButton.TabIndex = 7
        Me.SendTestButton.Text = "Send Test"
        Me.SendTestButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SendTestButton)
        Me.GroupBox1.Controls.Add(Me.CloseButton)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GroupBox1.Controls.Add(Me.ConnectButton)
        Me.GroupBox1.Controls.Add(Me.PortsListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(420, 535)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serial Connection"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(444, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(582, 597)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(652, 621)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(21, 29)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(550, 550)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 875)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActiveSerialPort As IO.Ports.SerialPort
    Friend WithEvents PortsListBox As ListBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RefreshButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SendTestButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
